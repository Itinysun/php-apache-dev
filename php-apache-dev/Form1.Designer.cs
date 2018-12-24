namespace php_apache_dev
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsStop = new System.Windows.Forms.ToolStripMenuItem();
            this.TsStart = new System.Windows.Forms.ToolStripMenuItem();
            this.TsRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.BtInstall = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbPath = new System.Windows.Forms.TextBox();
            this.TbDomain = new System.Windows.Forms.TextBox();
            this.BtHost = new System.Windows.Forms.Button();
            this.BtIni = new System.Windows.Forms.Button();
            this.BtUninstall = new System.Windows.Forms.Button();
            this.BtRefresh = new System.Windows.Forms.Button();
            this.BtStop = new System.Windows.Forms.Button();
            this.BtStart = new System.Windows.Forms.Button();
            this.RbMsg = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "php-apache-dev";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsQuit,
            this.TsConsole,
            this.toolStripSeparator1,
            this.TsStop,
            this.TsStart,
            this.TsRestart});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 120);
            // 
            // TsQuit
            // 
            this.TsQuit.Name = "TsQuit";
            this.TsQuit.Size = new System.Drawing.Size(112, 22);
            this.TsQuit.Text = "退出";
            this.TsQuit.Click += new System.EventHandler(this.TsQuit_Click);
            // 
            // TsConsole
            // 
            this.TsConsole.Image = global::php_apache_dev.Properties.Resources.console_24px_1172366_easyicon_net;
            this.TsConsole.Name = "TsConsole";
            this.TsConsole.Size = new System.Drawing.Size(112, 22);
            this.TsConsole.Text = "控制台";
            this.TsConsole.Click += new System.EventHandler(this.TsConsole_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // TsStop
            // 
            this.TsStop.Image = global::php_apache_dev.Properties.Resources.stop_24px_34301_easyicon_net;
            this.TsStop.Name = "TsStop";
            this.TsStop.Size = new System.Drawing.Size(112, 22);
            this.TsStop.Text = "停止";
            this.TsStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // TsStart
            // 
            this.TsStart.Image = global::php_apache_dev.Properties.Resources.play_24px_26794_easyicon_net;
            this.TsStart.Name = "TsStart";
            this.TsStart.Size = new System.Drawing.Size(112, 22);
            this.TsStart.Text = "启动";
            this.TsStart.Click += new System.EventHandler(this.TsStart_Click);
            // 
            // TsRestart
            // 
            this.TsRestart.Image = global::php_apache_dev.Properties.Resources.refresh_24px_28542_easyicon_net;
            this.TsRestart.Name = "TsRestart";
            this.TsRestart.Size = new System.Drawing.Size(112, 22);
            this.TsRestart.Text = "重启";
            this.TsRestart.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(333, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 12);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "下载Apache";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(333, 45);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 12);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "下载PHP";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(242, 45);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(53, 12);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "下载扩展";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // BtInstall
            // 
            this.BtInstall.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtInstall.Enabled = false;
            this.BtInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtInstall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtInstall.Location = new System.Drawing.Point(7, 31);
            this.BtInstall.Name = "BtInstall";
            this.BtInstall.Size = new System.Drawing.Size(75, 23);
            this.BtInstall.TabIndex = 4;
            this.BtInstall.Text = "安装";
            this.BtInstall.UseVisualStyleBackColor = false;
            this.BtInstall.Click += new System.EventHandler(this.BtInstall_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RbMsg);
            this.splitContainer1.Size = new System.Drawing.Size(547, 428);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel10);
            this.groupBox2.Controls.Add(this.linkLabel9);
            this.groupBox2.Controls.Add(this.linkLabel8);
            this.groupBox2.Controls.Add(this.linkLabel7);
            this.groupBox2.Controls.Add(this.linkLabel6);
            this.groupBox2.Controls.Add(this.linkLabel5);
            this.groupBox2.Controls.Add(this.linkLabel4);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 107);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "快捷方式";
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(86, 23);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(53, 12);
            this.linkLabel10.TabIndex = 10;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "HOST目录";
            this.linkLabel10.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(68, 45);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(71, 12);
            this.linkLabel9.TabIndex = 9;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "php扩展目录";
            this.linkLabel9.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(14, 45);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(47, 12);
            this.linkLabel8.TabIndex = 8;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "phpinfo";
            this.linkLabel8.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(14, 23);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(53, 12);
            this.linkLabel7.TabIndex = 7;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "网站目录";
            this.linkLabel7.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(216, 23);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(107, 12);
            this.linkLabel6.TabIndex = 6;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "httpd-vhosts.conf";
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(145, 23);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(65, 12);
            this.linkLabel5.TabIndex = 5;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "httpd.conf";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(163, 45);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(47, 12);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "php.ini";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbPath);
            this.groupBox1.Controls.Add(this.TbDomain);
            this.groupBox1.Controls.Add(this.BtHost);
            this.groupBox1.Controls.Add(this.BtIni);
            this.groupBox1.Controls.Add(this.BtUninstall);
            this.groupBox1.Controls.Add(this.BtRefresh);
            this.groupBox1.Controls.Add(this.BtInstall);
            this.groupBox1.Controls.Add(this.BtStop);
            this.groupBox1.Controls.Add(this.BtStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 131);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apache";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "目录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "域名";
            // 
            // TbPath
            // 
            this.TbPath.Location = new System.Drawing.Point(326, 58);
            this.TbPath.Name = "TbPath";
            this.TbPath.Size = new System.Drawing.Size(181, 21);
            this.TbPath.TabIndex = 11;
            // 
            // TbDomain
            // 
            this.TbDomain.Location = new System.Drawing.Point(326, 31);
            this.TbDomain.Name = "TbDomain";
            this.TbDomain.Size = new System.Drawing.Size(181, 21);
            this.TbDomain.TabIndex = 10;
            // 
            // BtHost
            // 
            this.BtHost.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtHost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtHost.Location = new System.Drawing.Point(366, 89);
            this.BtHost.Name = "BtHost";
            this.BtHost.Size = new System.Drawing.Size(75, 23);
            this.BtHost.TabIndex = 1;
            this.BtHost.Text = "添加虚拟机";
            this.BtHost.UseVisualStyleBackColor = false;
            this.BtHost.Click += new System.EventHandler(this.BtHost_Click);
            // 
            // BtIni
            // 
            this.BtIni.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtIni.Enabled = false;
            this.BtIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtIni.Location = new System.Drawing.Point(169, 31);
            this.BtIni.Name = "BtIni";
            this.BtIni.Size = new System.Drawing.Size(75, 23);
            this.BtIni.TabIndex = 9;
            this.BtIni.Text = "初始化";
            this.BtIni.UseVisualStyleBackColor = false;
            this.BtIni.Click += new System.EventHandler(this.BtIni_Click);
            // 
            // BtUninstall
            // 
            this.BtUninstall.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtUninstall.Enabled = false;
            this.BtUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtUninstall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtUninstall.Location = new System.Drawing.Point(88, 31);
            this.BtUninstall.Name = "BtUninstall";
            this.BtUninstall.Size = new System.Drawing.Size(75, 23);
            this.BtUninstall.TabIndex = 5;
            this.BtUninstall.Text = "卸载";
            this.BtUninstall.UseVisualStyleBackColor = false;
            this.BtUninstall.Click += new System.EventHandler(this.BtUninstall_Click);
            // 
            // BtRefresh
            // 
            this.BtRefresh.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtRefresh.Enabled = false;
            this.BtRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtRefresh.Location = new System.Drawing.Point(169, 74);
            this.BtRefresh.Name = "BtRefresh";
            this.BtRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtRefresh.TabIndex = 8;
            this.BtRefresh.Text = "重启";
            this.BtRefresh.UseVisualStyleBackColor = false;
            this.BtRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // BtStop
            // 
            this.BtStop.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtStop.Enabled = false;
            this.BtStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtStop.Location = new System.Drawing.Point(88, 74);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(75, 23);
            this.BtStop.TabIndex = 7;
            this.BtStop.Text = "停止";
            this.BtStop.UseVisualStyleBackColor = false;
            this.BtStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // BtStart
            // 
            this.BtStart.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtStart.Enabled = false;
            this.BtStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtStart.Location = new System.Drawing.Point(7, 74);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(75, 23);
            this.BtStart.TabIndex = 6;
            this.BtStart.Text = "启动";
            this.BtStart.UseVisualStyleBackColor = false;
            this.BtStart.Click += new System.EventHandler(this.TsStart_Click);
            // 
            // RbMsg
            // 
            this.RbMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RbMsg.Location = new System.Drawing.Point(0, 0);
            this.RbMsg.Name = "RbMsg";
            this.RbMsg.Size = new System.Drawing.Size(547, 162);
            this.RbMsg.TabIndex = 1;
            this.RbMsg.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(547, 428);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHP DEV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsStart;
        private System.Windows.Forms.ToolStripMenuItem TsStop;
        private System.Windows.Forms.ToolStripMenuItem TsRestart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TsConsole;
        private System.Windows.Forms.ToolStripMenuItem TsQuit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button BtInstall;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox RbMsg;
        private System.Windows.Forms.Button BtRefresh;
        private System.Windows.Forms.Button BtStop;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.Button BtUninstall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtIni;
        private System.Windows.Forms.Button BtHost;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbPath;
        private System.Windows.Forms.TextBox TbDomain;
        private System.Windows.Forms.Label label2;
    }
}

