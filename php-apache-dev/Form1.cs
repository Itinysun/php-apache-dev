using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.ServiceProcess;
using System.Threading;

namespace php_apache_dev
{
    public delegate void DelReadStdOutput(string result);
    public delegate void DelReadErrOutput(string result);
    public partial class Form1 : Form
    {
        private string httpdHost;
        private string httpdConf;
        private string httpdExe;
        private string phpIni;
        private string phpExt;
        private string _phpPath;
        private string PHP
        {
            set
            {
                _phpPath = value;
                phpIni = Path.Combine(value, "php.ini");
                phpExt = Path.Combine(value, "ext");
                if(!string.IsNullOrEmpty(value))
                    ShowTrace("加载PHP目录:" + value);
            }
            get
            {
                return _phpPath;
            }
        }
        private string _httpd;
        private string HTTPD
        {
            set
            {
                _httpd = value;
                httpdConf = Path.Combine(value, "conf/httpd.conf");
                httpdHost = Path.Combine(value, "conf/extra/httpd-vhosts.conf");
                httpdExe = Path.Combine(value, "bin/httpd.exe");
                if (!string.IsNullOrEmpty(value))
                    ShowTrace("加载APACHE目录:" + value);
            }
            get
            {
                return _httpd;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Init();
            InitPath();
        }

        #region form
        private void Form1_Load(object sender, EventArgs e)
        {            
            notifyIcon1.Visible = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }            
            e.Cancel = true;
        }
        private void InitPath()
        {
            string thisPath = Application.StartupPath;
            DirectoryInfo di = new DirectoryInfo(thisPath);
            var php = SearchInPath("php.exe", di);
            var apache = SearchInPath("httpd.exe", di);
            if(php!=null && apache != null)
            {
                timer1.Interval = 1000 * 60 * 5;
                timer1.Start();
                PHP = php.Directory.FullName;
                HTTPD = apache.Directory.Parent.FullName;
                GetServiceStatus();
            }

        }
        private FileInfo SearchInPath(string file,DirectoryInfo di)
        {
            try
            {
                var ds = di.GetFiles(file, SearchOption.AllDirectories);
                return ds[0];
            }catch
            {
                ShowTrace(file + "没有找到，请下载后将程序解压到本程序同级目录下！然后重启程序");
                return null;
            }
        }
        private void quit()
        {
            notifyIcon1.Dispose();
            this.Dispose();
            Environment.Exit(0);
        }
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }
        #endregion

        #region ui
        private void TsConsole_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
            }
        }

        private void TsQuit_Click(object sender, EventArgs e)
        {
            quit();
        }

        private void BtInstall_Click(object sender, EventArgs e)
        {
            UpdateStatus(3);
            RealAction(httpdExe, " -k install");
        }
        private void BtRefresh_Click(object sender, EventArgs e)
        {
            UpdateStatus(3);
            RealAction(httpdExe, " -k restart");
        }
        private void BtUninstall_Click(object sender, EventArgs e)
        {
            UpdateStatus(3);
            RealAction(httpdExe, " -k uninstall");
        }
        private void BtStop_Click(object sender, EventArgs e)
        {
            UpdateStatus(3);
            RealAction(httpdExe, " -k stop");
        }
        private void TsStart_Click(object sender, EventArgs e)
        {
            UpdateStatus(3);
            RealAction(httpdExe, " -k start");
        }
        private void BtIni_Click(object sender, EventArgs e)
        {
            try
            {
                GenHttpdConf();
                ShowTrace("httpd.conf 初始化完毕！");
            }
            catch (Exception ex)
            {
                ShowTrace("httpd.conf 初始化异常！"+ex.Message);
            }
            
        }

        private void BtHost_Click(object sender, EventArgs e)
        {
            var domain = TbDomain.Text.Trim().ToLower();
            var path = TbPath.Text.Trim().ToLower();
            try
            {
                AddHost(domain, path);
                AddDomainDns(domain);
                TbDomain.Text = "";
                TbPath.Text = "";
            }
            catch(Exception ex)
            {
                ShowTrace("添加网站失败！" + ex.Message);
            }

        }
        #endregion

        #region Status
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetServiceStatus();
        }
        private void GetServiceStatus()
        {
            //获得服务集合
            var serviceControllers = ServiceController.GetServices();
            //遍历服务集合，打印服务名和服务状态
            foreach (var service in serviceControllers)
            {
                if (service.ServiceName.ToLower().Contains("apache"))
                {
                    UpdateStatus((int)service.Status);
                    return;
                }
            }
            UpdateStatus(0);
        }
        private void UpdateStatus(int s)
        {
            if (BtInstall.InvokeRequired)
            {
                this.Invoke(new UpdateStatusHandle(UpdateStatusFunction), s);
            }
            else
            {
                UpdateStatusFunction(s);
            }
        }
        private delegate void UpdateStatusHandle(int s);
        private void UpdateStatusFunction(int s)
        {
            bool install = false, run = false, pause = false;
            if (s == 0)
            {
                install = false;
                notifyIcon1.Icon = Properties.Resources.uninstall;
            }else if (s == 4)
            {
                install = true;
                run = true;
                notifyIcon1.Icon = Properties.Resources.run;
            }else if(s==3 || s==6 || s == 7)
            {
                pause = true;
                install = true;
                notifyIcon1.Icon = Properties.Resources.runfresh;
            }
            else
            {
                install = true;
                run = false;
                notifyIcon1.Icon = Properties.Resources.stop;
            }
            BtInstall.Enabled = !install;
            BtUninstall.Enabled = install;

            TsRestart.Enabled = BtRefresh.Enabled =install && run;
            TsStart.Enabled = BtStart.Enabled =install && ( (!run) || pause);
            TsStop.Enabled  = BtStop.Enabled =install && run;
            BtIni.Enabled = install;
        }
        #endregion

        #region message
        /// <summary>
        /// 显示必要的系统日志
        /// </summary>
        /// <param name="msg">日志列表</param>

        public void ShowTrace(List<string> msg)
        {
            if (RbMsg.InvokeRequired)
            {
                this.Invoke(new UpdateTrace(UpdateTraceFunction), msg);
            }
            else
            {
                UpdateTraceFunction(msg);
            }
        }

        public void ShowTrace(string msg)
        {
            ShowTrace(new List<string> { msg });
        }
        private delegate void UpdateTrace(List<string> msg);
        private void UpdateTraceFunction(List<string> msg)
        {
            if (RbMsg.Lines.Length > 500)
            {
                RbMsg.Clear();
            }
            if (msg.Count > 0)
            {
                foreach (var str in msg)
                {
                    RbMsg.Text = RbMsg.Text.Insert(0, string.Format("[{0}]{1}{2}", DateTime.Now.ToShortTimeString(), str, Environment.NewLine));
                }
            }
        }
        #endregion

        #region cmd
        // 2.定义委托事件  
        public event DelReadStdOutput ReadStdOutput;
        public event DelReadErrOutput ReadErrOutput;
        private void Init()
        {
            //3.将相应函数注册到委托事件中  
            ReadStdOutput += new DelReadStdOutput(ReadStdOutputAction);
            ReadErrOutput += new DelReadErrOutput(ReadErrOutputAction);
        }
        private void RealAction(string StartFileName, string StartFileArg)
        {
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = StartFileName;      // 命令  
            CmdProcess.StartInfo.Arguments = StartFileArg;      // 参数  

            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口  
            CmdProcess.StartInfo.UseShellExecute = false;
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入  
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出  
            CmdProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
                                                                //CmdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  

            CmdProcess.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            CmdProcess.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);

            CmdProcess.EnableRaisingEvents = true;                      // 启用Exited事件  
            CmdProcess.Exited += new EventHandler(CmdProcess_Exited);   // 注册进程结束事件  

            CmdProcess.Start();
            CmdProcess.BeginOutputReadLine();
            CmdProcess.BeginErrorReadLine(); 
            // 如果打开注释，则以同步方式执行命令，此例子中用Exited事件异步执行。  
            // CmdProcess.WaitForExit();       
        }

        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // 4. 异步调用，需要invoke  
                this.Invoke(ReadStdOutput, new object[] { e.Data });
            }
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(ReadErrOutput, new object[] { e.Data });
            }
        }

        private void ReadStdOutputAction(string result)
        {
            ShowTrace(result);
        }

        private void ReadErrOutputAction(string result)
        {
            ShowTrace(result);
        }

        private void CmdProcess_Exited(object sender, EventArgs e)
        {
            GetServiceStatus();
        }
        #endregion

        #region conf & ini & host
        private void GenPHPini()
        {
            var temp = Path.Combine(Path.GetDirectoryName(PHP), "temp");
            Directory.CreateDirectory(temp);
            string[] contents;
            if (File.Exists(phpIni))
            {
                contents = File.ReadAllLines(phpIni);
                File.Move(phpIni, phpIni + ".bak" + DateTime.Now.ToString("ffff"));
            }
            else
            {
                contents = File.ReadAllLines(phpIni + "-development");
            }
            List<string> res = new List<string>();
            bool uploadDir = true,uploadMax=true, mysql = true, curl = true, fileinfo = true, gd2 = true, mbs = true, mysqli = true, ssl = true;
            foreach (var lc in contents)
            {
                var c = lc.Trim();
                if (string.IsNullOrEmpty(c))
                    continue;
                bool documented = c.StartsWith(";");

                if (uploadDir && c.Contains("upload_tmp_dir"))
                {
                    res.Add(phpValue("upload_tmp_dir", temp));
                    uploadDir = false;
                    break;
                }
                if (uploadMax && c.Contains("upload_max_filesize"))
                {
                    res.Add(phpValue("upload_max_filesize", "50M"));
                    uploadMax = false;
                    break;
                }
                if (mysql && c.Contains("extension=pdo_mysql"))
                {
                    res.Add("extension=pdo_mysql");
                    mysql = false;
                    break;
                }
                if (curl && c.Contains("extension=curl"))
                {
                    res.Add("extension=curl");
                    curl = false;
                    break;
                }
                if (fileinfo && c.Contains("extension=fileinfo"))
                {
                    res.Add("extension=fileinfo");
                    fileinfo = false;
                    break;
                }
                if (gd2 && c.Contains("extension=gd2"))
                {
                    res.Add("extension=gd2");
                    gd2 = false;
                    break;
                }
                if (mbs && c.Contains("extension=mbstring"))
                {
                    res.Add("extension=mbstring");
                    mbs = false;
                    break;
                }
                if (mysqli && c.Contains("extension=mysqli"))
                {
                    res.Add("extension=mysqli");
                    mysqli = false;
                    break;
                }
                if (ssl && c.Contains("extension=openssl"))
                {
                    res.Add("extension=openssl");
                    ssl = false;
                    break;
                }

            }
            File.WriteAllLines(phpIni, res.ToArray());
        }

        private void GenHttpdConf()
        {
            var conf = File.ReadAllLines(httpdConf);
            List<string> cout = new List<string>();
            bool srvRoot = true, phpModule = true, closeSsl = true, setIndex = true, errorlog = true, vhost = true,phpini=true,accesslog=true;
            foreach (var c in conf)
            {
                if (string.IsNullOrEmpty(c.Trim()))
                    continue;
                bool documented = c.Trim().StartsWith("#");
                if (srvRoot && c.Contains("Define SRVROOT"))
                {
                    cout.Add(apacheValue("Define SRVROOT", HTTPD));
                    srvRoot = false;
                    continue;
                }
                if (closeSsl && c.Contains("modules/mod_ssl.so"))
                {
                    closeSsl = false;
                    continue;
                }
                if (setIndex && !documented && c.Contains("DirectoryIndex"))
                {
                    cout.Add("DirectoryIndex index.html index.php");
                    continue;
                }
                if (errorlog && !documented && c.Contains("ErrorLog"))
                {
                    string log = Path.Combine(Path.GetDirectoryName(HTTPD), "logs", "default");
                    Directory.CreateDirectory(log);
                    cout.Add(apacheValue("ErrorLog", Path.Combine(log,"error.log")));
                    errorlog = false;
                    continue;
                }
                if(accesslog && !documented && c.Contains("CustomLog"))
                {
                    string log = Path.Combine(Path.GetDirectoryName(HTTPD), "logs", "default");
                    Directory.CreateDirectory(log);
                    cout.Add(string.Format("CustomLog \"{0}\" common", Path.Combine(log, "access.log")));
                    accesslog = true;
                    continue;
                }
                if (vhost && documented && c.Contains("conf/extra/httpd-vhosts.conf"))
                {
                    cout.Add("Include conf/extra/httpd-vhosts.conf");
                    vhost = false;
                    continue;
                }
                if (phpModule && c.Contains("php7_module"))
                {
                    cout.Add(apacheValue("LoadModule php7_module", Path.Combine(PHP, "php7apache2_4.dll")));
                    phpModule = false;
                    continue;
                }
                if (phpini && c.Contains("PHPIniDir"))
                {
                    cout.Add(apacheValue("PHPIniDir", PHP));
                    phpini = false;
                    continue;
                }
                if (!documented)
                {
                    cout.Add(c);
                }
            }
            if (phpModule)
            {
                cout.Add(apacheValue("LoadModule php7_module", Path.Combine(PHP, "php7apache2_4.dll")));
                cout.Add(apacheValue("PHPIniDir", PHP));
                cout.Add("AddType application/x-httpd-php .php");
                cout.Add("AddType application/pdf .pdf");
            }
            File.Move(httpdConf, httpdConf + ".bak"+DateTime.Now.ToString("ffff"));
            File.WriteAllLines(httpdConf, cout.ToArray());
            File.WriteAllText(Path.Combine(HTTPD, "htdocs/index.php"), "<?php phpinfo(); ?>");

        }

        private void GenHttpdHost()
        {
            string www = Path.Combine(Path.GetDirectoryName(HTTPD), "www");
            
            string check = File.ReadAllText(httpdHost);


        }

        private void AddHost(string domain,string path)
        {
            string www = Path.Combine(Path.GetDirectoryName(HTTPD), "www");
            string web = Path.Combine(www, path);
            string logs = Path.Combine(Path.GetDirectoryName(HTTPD), "logs", path);
            string check = File.ReadAllText(httpdHost);

            if (check.Contains("\"" + domain + "\""))
            {
                throw new Exception(domain+"已经存在");
            }
            if(check.Contains("\"" + path + "\""))
            {
                throw new Exception(path + "已经存在");
            }

            Directory.CreateDirectory(web);
            Directory.CreateDirectory(logs);
            List<string> res = new List<string>();

            string dirgen = string.Format("<Directory \"{0}\">", www);
            if (!check.Contains(dirgen))
            {
                res.Add(dirgen);
                res.Add("Options Indexes FollowSymLinks");
                res.Add("AllowOverride all");
                res.Add("Require all granted");
                res.Add("</Directory>");
            }

            res.Add("<VirtualHost *:80>");
            res.Add(apacheValue("ServerName", domain));
            res.Add(apacheValue("DocumentRoot", web));
            res.Add(apacheValue("ErrorLog", Path.Combine(logs, domain + "_error.log")));
            res.Add(string.Format("CustomLog \"{0}_access.log\" common", Path.Combine(logs, domain)));
            res.Add("</VirtualHost>");
            File.AppendAllLines(httpdHost, res.ToArray());

        }

        private void AddDomainDns(string domain)
        {
            try
            {
                var system = Environment.GetFolderPath(Environment.SpecialFolder.System);
                var file = Path.Combine(system, "drivers\\etc\\hosts");
                var check = File.ReadAllText(file);
                if (check.Contains(domain))
                {
                    ShowTrace(domain + "已经存在于HOST文件中，请手动修改");
                    return;
                }
                var content = "127.0.0.1 " + domain;
                File.AppendAllLines(file, new string[] { content });
            }
            catch
            {
                ShowTrace("HOST修改失败，请手动添加");
            }

        }


        private string apacheValue(string name,string vaule)
        {
            return string.Format("{0} \"{1}\"", name, vaule);
        }
        private string phpValue(string name,string vaule)
        {
            return string.Format("{0} = {1}", name, vaule);
        }
        #endregion

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string www = Path.Combine(Path.GetDirectoryName(HTTPD), "www");
            OpenLink(www);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://www.apachehaus.com/cgi-bin/download.plx");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://windows.php.net/download");
        }


        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("http://pecl.php.net/");
        }
        private void OpenLink(string href)
        {
            Process.Start(href);
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink(Path.GetDirectoryName(httpdHost));
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink(httpdConf);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink(httpdHost);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("http://127.0.0.1");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink(phpExt);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink(phpIni);
        }
    }
}
