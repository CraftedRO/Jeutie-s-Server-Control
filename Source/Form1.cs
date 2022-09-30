using JeutieControl.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JeutieControl
{
  public class Form1 : Form
  {
    public const string version = "1.1";
    private IContainer components;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem KeepOnTop;
    private ToolStripMenuItem transparencyToolStripMenuItem;
    private ToolStripMenuItem Opacity100;
    private ToolStripMenuItem Opacity90;
    private ToolStripMenuItem Opacity80;
    private ToolStripMenuItem Opacity70;
    private ToolStripMenuItem Opacity60;
    private ToolStripMenuItem Opacity50;
    private TextBox MySQLPath;
    private TextBox ServerPath;
    private CheckBox AutoRestart;
    private Button startWorld;
    private Button startAuth;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private Button stopWorld;
    private Button stopAuth;
    private FolderBrowserDialog ServerFolderBrowser;
    private Button ServerPathButton;
    private Button MySQLPathButton;
    private Button ApachePathButton;
    private FolderBrowserDialog SqlFolderBrowser;
    private FolderBrowserDialog ApacheFolderBrowser;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
    private Button startMySQL;
    private Button startApache;
    private Button stopMySQL;
    private Button stopApache;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem openWorldserverConfigToolStripMenuItem;
    private ToolStripMenuItem openAuthserverConfigToolStripMenuItem;
    private ToolStripSeparator breakToolStripMenuItem;
    private RichTextBox log;
    private TextBox ApachePath;
    private ToolStripMenuItem currentOpacitySetting;
    private bool isServerPathCorrect;
    private bool isMysqlPathCorrect;
    private bool isApachePathCorrect;
    private Process authServer;
    private Process worldServer;
    private Process mySQL;
    private Process apache;
    private ProcessStartInfo authServerInfo;
    private ProcessStartInfo worldServerInfo;
    private ProcessStartInfo mySQLInfo;
    private ProcessStartInfo apacheInfo;
    private uint authServerRestartCount;
    private uint worldServerRestartCount;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.openWorldserverConfigToolStripMenuItem = new ToolStripMenuItem();
      this.openAuthserverConfigToolStripMenuItem = new ToolStripMenuItem();
      this.breakToolStripMenuItem = new ToolStripSeparator();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.optionsToolStripMenuItem = new ToolStripMenuItem();
      this.KeepOnTop = new ToolStripMenuItem();
      this.transparencyToolStripMenuItem = new ToolStripMenuItem();
      this.Opacity100 = new ToolStripMenuItem();
      this.Opacity90 = new ToolStripMenuItem();
      this.Opacity80 = new ToolStripMenuItem();
      this.Opacity70 = new ToolStripMenuItem();
      this.Opacity60 = new ToolStripMenuItem();
      this.Opacity50 = new ToolStripMenuItem();
      this.helpToolStripMenuItem = new ToolStripMenuItem();
      this.aboutToolStripMenuItem = new ToolStripMenuItem();
      this.MySQLPath = new TextBox();
      this.ServerPath = new TextBox();
      this.AutoRestart = new CheckBox();
      this.startWorld = new Button();
      this.startAuth = new Button();
      this.stopWorld = new Button();
      this.stopAuth = new Button();
      this.ServerFolderBrowser = new FolderBrowserDialog();
      this.ServerPathButton = new Button();
      this.MySQLPathButton = new Button();
      this.ApachePathButton = new Button();
      this.SqlFolderBrowser = new FolderBrowserDialog();
      this.ApacheFolderBrowser = new FolderBrowserDialog();
      this.startMySQL = new Button();
      this.startApache = new Button();
      this.stopMySQL = new Button();
      this.stopApache = new Button();
      this.pictureBox4 = new PictureBox();
      this.pictureBox3 = new PictureBox();
      this.pictureBox2 = new PictureBox();
      this.pictureBox1 = new PictureBox();
      this.log = new RichTextBox();
      this.ApachePath = new TextBox();
      this.menuStrip1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox4).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.menuStrip1.BackColor = SystemColors.ControlLight;
      this.menuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.fileToolStripMenuItem,
        (ToolStripItem) this.optionsToolStripMenuItem,
        (ToolStripItem) this.helpToolStripMenuItem,
        (ToolStripItem) this.aboutToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Margin = new Padding(0, 0, 0, 5);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(391, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.openWorldserverConfigToolStripMenuItem,
        (ToolStripItem) this.openAuthserverConfigToolStripMenuItem,
        (ToolStripItem) this.breakToolStripMenuItem,
        (ToolStripItem) this.exitToolStripMenuItem
      });
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      this.openWorldserverConfigToolStripMenuItem.Name = "openWorldserverConfigToolStripMenuItem";
      this.openWorldserverConfigToolStripMenuItem.Size = new Size(208, 22);
      this.openWorldserverConfigToolStripMenuItem.Text = "Open Worldserver Config";
      this.openWorldserverConfigToolStripMenuItem.Click += new EventHandler(this.openWorldserverConfigToolStripMenuItem_Click);
      this.openAuthserverConfigToolStripMenuItem.Name = "openAuthserverConfigToolStripMenuItem";
      this.openAuthserverConfigToolStripMenuItem.Size = new Size(208, 22);
      this.openAuthserverConfigToolStripMenuItem.Text = "Open Authserver Config";
      this.openAuthserverConfigToolStripMenuItem.Click += new EventHandler(this.openAuthserverConfigToolStripMenuItem_Click);
      this.breakToolStripMenuItem.Name = "breakToolStripMenuItem";
      this.breakToolStripMenuItem.Size = new Size(205, 6);
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new Size(208, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
      this.optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.KeepOnTop,
        (ToolStripItem) this.transparencyToolStripMenuItem
      });
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new Size(61, 20);
      this.optionsToolStripMenuItem.Text = "Options";
      this.KeepOnTop.CheckOnClick = true;
      this.KeepOnTop.Name = "KeepOnTop";
      this.KeepOnTop.Size = new Size(154, 22);
      this.KeepOnTop.Text = "Always On Top";
      this.KeepOnTop.Click += new EventHandler(this.KeepOnTop_Click);
      this.transparencyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.Opacity100,
        (ToolStripItem) this.Opacity90,
        (ToolStripItem) this.Opacity80,
        (ToolStripItem) this.Opacity70,
        (ToolStripItem) this.Opacity60,
        (ToolStripItem) this.Opacity50
      });
      this.transparencyToolStripMenuItem.Name = "transparencyToolStripMenuItem";
      this.transparencyToolStripMenuItem.Size = new Size(154, 22);
      this.transparencyToolStripMenuItem.Text = "Opacity";
      this.Opacity100.Checked = true;
      this.Opacity100.CheckOnClick = true;
      this.Opacity100.CheckState = CheckState.Checked;
      this.Opacity100.Name = "Opacity100";
      this.Opacity100.Size = new Size(102, 22);
      this.Opacity100.Text = "100%";
      this.Opacity100.Click += new EventHandler(this.Opacity100_Click);
      this.Opacity90.CheckOnClick = true;
      this.Opacity90.Name = "Opacity90";
      this.Opacity90.Size = new Size(102, 22);
      this.Opacity90.Text = "90%";
      this.Opacity90.Click += new EventHandler(this.Opacity90_Click);
      this.Opacity80.CheckOnClick = true;
      this.Opacity80.Name = "Opacity80";
      this.Opacity80.Size = new Size(102, 22);
      this.Opacity80.Text = "80%";
      this.Opacity80.Click += new EventHandler(this.Opacity80_Click);
      this.Opacity70.CheckOnClick = true;
      this.Opacity70.Name = "Opacity70";
      this.Opacity70.Size = new Size(102, 22);
      this.Opacity70.Text = "70%";
      this.Opacity70.Click += new EventHandler(this.Opacity70_Click);
      this.Opacity60.CheckOnClick = true;
      this.Opacity60.Name = "Opacity60";
      this.Opacity60.Size = new Size(102, 22);
      this.Opacity60.Text = "60%";
      this.Opacity60.Click += new EventHandler(this.Opacity60_Click);
      this.Opacity50.CheckOnClick = true;
      this.Opacity50.Name = "Opacity50";
      this.Opacity50.Size = new Size(102, 22);
      this.Opacity50.Text = "50%";
      this.Opacity50.Click += new EventHandler(this.Opacity50_Click);
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      this.helpToolStripMenuItem.Click += new EventHandler(this.helpToolStripMenuItem_Click);
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new Size(52, 20);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
      this.MySQLPath.BorderStyle = BorderStyle.FixedSingle;
      this.MySQLPath.Font = new Font("Microsoft Sans Serif", 6.75f);
      this.MySQLPath.Location = new Point(109, 282);
      this.MySQLPath.Name = "MySQLPath";
      this.MySQLPath.ReadOnly = true;
      this.MySQLPath.Size = new Size(270, 18);
      this.MySQLPath.TabIndex = 2;
      this.MySQLPath.Text = "Path has not been set yet.";
      this.ServerPath.AllowDrop = true;
      this.ServerPath.BorderStyle = BorderStyle.FixedSingle;
      this.ServerPath.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ServerPath.Location = new Point(109, 250);
      this.ServerPath.Name = "ServerPath";
      this.ServerPath.ReadOnly = true;
      this.ServerPath.Size = new Size(270, 18);
      this.ServerPath.TabIndex = 3;
      this.ServerPath.Text = "Path has not been set yet.";
      this.AutoRestart.AutoSize = true;
      this.AutoRestart.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.AutoRestart.Location = new Point(12, 124);
      this.AutoRestart.Name = "AutoRestart";
      this.AutoRestart.Size = new Size(242, 22);
      this.AutoRestart.TabIndex = 8;
      this.AutoRestart.Text = "Automatically restart upon crash.";
      this.AutoRestart.UseVisualStyleBackColor = true;
      this.startWorld.BackColor = Color.Transparent;
      this.startWorld.ImageAlign = ContentAlignment.TopLeft;
      this.startWorld.Location = new Point(59, 32);
      this.startWorld.Name = "startWorld";
      this.startWorld.Size = new Size(241, 40);
      this.startWorld.TabIndex = 9;
      this.startWorld.Text = "Start the World server.";
      this.startWorld.UseVisualStyleBackColor = false;
      this.startWorld.Click += new EventHandler(this.startWorld_Click);
      this.startAuth.BackColor = Color.Transparent;
      this.startAuth.Location = new Point(58, 78);
      this.startAuth.Name = "startAuth";
      this.startAuth.Size = new Size(242, 40);
      this.startAuth.TabIndex = 10;
      this.startAuth.Text = "Start the Auth server.";
      this.startAuth.UseVisualStyleBackColor = false;
      this.startAuth.Click += new EventHandler(this.startAuth_Click);
      this.stopWorld.BackColor = Color.Transparent;
      this.stopWorld.ImageAlign = ContentAlignment.TopLeft;
      this.stopWorld.Location = new Point(306, 32);
      this.stopWorld.Name = "stopWorld";
      this.stopWorld.Size = new Size(73, 40);
      this.stopWorld.TabIndex = 13;
      this.stopWorld.Text = "Stop";
      this.stopWorld.UseVisualStyleBackColor = false;
      this.stopWorld.Click += new EventHandler(this.stopWorld_Click);
      this.stopAuth.BackColor = Color.Transparent;
      this.stopAuth.Location = new Point(306, 78);
      this.stopAuth.Name = "stopAuth";
      this.stopAuth.Size = new Size(73, 40);
      this.stopAuth.TabIndex = 14;
      this.stopAuth.Text = "Stop";
      this.stopAuth.UseVisualStyleBackColor = false;
      this.stopAuth.Click += new EventHandler(this.stopAuth_Click);
      this.ServerPathButton.Location = new Point(12, 244);
      this.ServerPathButton.Name = "ServerPathButton";
      this.ServerPathButton.Size = new Size(91, 26);
      this.ServerPathButton.TabIndex = 15;
      this.ServerPathButton.Text = "Server path";
      this.ServerPathButton.UseVisualStyleBackColor = true;
      this.ServerPathButton.Click += new EventHandler(this.ServerPathButton_Click);
      this.MySQLPathButton.Location = new Point(12, 276);
      this.MySQLPathButton.Name = "MySQLPathButton";
      this.MySQLPathButton.Size = new Size(91, 26);
      this.MySQLPathButton.TabIndex = 16;
      this.MySQLPathButton.Text = "MySQL path";
      this.MySQLPathButton.UseVisualStyleBackColor = true;
      this.MySQLPathButton.Click += new EventHandler(this.MySQLPathButton_Click);
      this.ApachePathButton.Location = new Point(12, 308);
      this.ApachePathButton.Name = "ApachePathButton";
      this.ApachePathButton.Size = new Size(91, 26);
      this.ApachePathButton.TabIndex = 17;
      this.ApachePathButton.Text = "Apache path";
      this.ApachePathButton.UseVisualStyleBackColor = true;
      this.ApachePathButton.Click += new EventHandler(this.ApachePathButton_Click);
      this.startMySQL.Location = new Point(58, 152);
      this.startMySQL.Name = "startMySQL";
      this.startMySQL.Size = new Size(242, 40);
      this.startMySQL.TabIndex = 20;
      this.startMySQL.Text = "Start the MySQL server.";
      this.startMySQL.UseVisualStyleBackColor = true;
      this.startMySQL.Click += new EventHandler(this.startMySQL_Click);
      this.startApache.Location = new Point(58, 198);
      this.startApache.Name = "startApache";
      this.startApache.Size = new Size(242, 40);
      this.startApache.TabIndex = 21;
      this.startApache.Text = "Start the Apache server.";
      this.startApache.UseVisualStyleBackColor = true;
      this.startApache.Click += new EventHandler(this.startApache_Click);
      this.stopMySQL.Location = new Point(306, 152);
      this.stopMySQL.Name = "stopMySQL";
      this.stopMySQL.Size = new Size(73, 40);
      this.stopMySQL.TabIndex = 22;
      this.stopMySQL.Text = "Stop";
      this.stopMySQL.UseVisualStyleBackColor = true;
      this.stopMySQL.Click += new EventHandler(this.stopMySQL_Click);
      this.stopApache.Location = new Point(306, 198);
      this.stopApache.Name = "stopApache";
      this.stopApache.Size = new Size(73, 40);
      this.stopApache.TabIndex = 23;
      this.stopApache.Text = "Stop";
      this.stopApache.UseVisualStyleBackColor = true;
      this.stopApache.Click += new EventHandler(this.stopApache_Click);
      this.pictureBox4.BackgroundImageLayout = ImageLayout.None;
      this.pictureBox4.Image = (Image) componentResourceManager.GetObject("pictureBox4.Image");
      this.pictureBox4.Location = new Point(12, 198);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new Size(40, 40);
      this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox4.TabIndex = 19;
      this.pictureBox4.TabStop = false;
      this.pictureBox3.BackgroundImageLayout = ImageLayout.None;
      this.pictureBox3.Image = (Image) componentResourceManager.GetObject("pictureBox3.Image");
      this.pictureBox3.Location = new Point(12, 152);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(40, 40);
      this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox3.TabIndex = 18;
      this.pictureBox3.TabStop = false;
      this.pictureBox2.BackgroundImageLayout = ImageLayout.None;
      this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
      this.pictureBox2.Location = new Point(12, 78);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(40, 40);
      this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 12;
      this.pictureBox2.TabStop = false;
      this.pictureBox1.BackgroundImageLayout = ImageLayout.None;
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(12, 32);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(40, 40);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 11;
      this.pictureBox1.TabStop = false;
      this.log.BackColor = SystemColors.Info;
      this.log.BorderStyle = BorderStyle.FixedSingle;
      this.log.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.log.Location = new Point(12, 340);
      this.log.Name = "log";
      this.log.ReadOnly = true;
      this.log.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
      this.log.Size = new Size(367, 130);
      this.log.TabIndex = 0;
      this.log.Text = "";
      this.ApachePath.BorderStyle = BorderStyle.FixedSingle;
      this.ApachePath.Font = new Font("Microsoft Sans Serif", 6.75f);
      this.ApachePath.Location = new Point(109, 314);
      this.ApachePath.Name = "ApachePath";
      this.ApachePath.ReadOnly = true;
      this.ApachePath.Size = new Size(270, 18);
      this.ApachePath.TabIndex = 1;
      this.ApachePath.Text = "Path has not been set yet.";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(391, 486);
      this.Controls.Add((Control) this.ServerPathButton);
      this.Controls.Add((Control) this.ApachePath);
      this.Controls.Add((Control) this.log);
      this.Controls.Add((Control) this.MySQLPath);
      this.Controls.Add((Control) this.stopApache);
      this.Controls.Add((Control) this.stopMySQL);
      this.Controls.Add((Control) this.ApachePathButton);
      this.Controls.Add((Control) this.ServerPath);
      this.Controls.Add((Control) this.MySQLPathButton);
      this.Controls.Add((Control) this.startApache);
      this.Controls.Add((Control) this.startMySQL);
      this.Controls.Add((Control) this.pictureBox4);
      this.Controls.Add((Control) this.pictureBox3);
      this.Controls.Add((Control) this.stopAuth);
      this.Controls.Add((Control) this.stopWorld);
      this.Controls.Add((Control) this.pictureBox2);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.startAuth);
      this.Controls.Add((Control) this.startWorld);
      this.Controls.Add((Control) this.AutoRestart);
      this.Controls.Add((Control) this.menuStrip1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = nameof (Form1);
      this.Text = "Jeutie's Repack Restarter";
      this.Load += new EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((ISupportInitialize) this.pictureBox4).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public Form1()
    {
      this.InitializeComponent();
      this.currentOpacitySetting = this.Opacity100;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.log.Text = "Welcome to Jeutie's Blizzlike Repack Control Panel v1.1!";
      this.CheckForNewMachine();
      this.ServerPath.Text = Settings.Default.ServerPath;
      this.ApachePath.Text = Settings.Default.ApachePath;
      this.MySQLPath.Text = Settings.Default.MySQLPath;
      this.KeepOnTop.Checked = Settings.Default.KeepOnTop;
      this.authServerRestartCount = 0U;
      this.worldServerRestartCount = 0U;
      this.authServerInfo = new ProcessStartInfo("authserver.exe");
      this.worldServerInfo = new ProcessStartInfo("worldserver.exe");
      this.mySQLInfo = new ProcessStartInfo("mysqld.exe");
      this.apacheInfo = new ProcessStartInfo("httpd.exe");
      this.mySQLInfo.Arguments = "--defaults-file=my.ini";
      this.worldServer = new Process();
      this.authServer = new Process();
      this.mySQL = new Process();
      this.apache = new Process();
      this.worldServer.StartInfo = this.worldServerInfo;
      this.authServer.StartInfo = this.authServerInfo;
      this.mySQL.StartInfo = this.mySQLInfo;
      this.apache.StartInfo = this.apacheInfo;
      this.apache.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      this.mySQL.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      this.worldServer.EnableRaisingEvents = true;
      this.worldServer.Exited += new EventHandler(this.autoRestartWorldServer);
      this.authServer.EnableRaisingEvents = true;
      this.authServer.Exited += new EventHandler(this.autoRestartAuthServer);
      this.CheckPaths();
    }

    private void CheckForNewMachine()
    {
      if (!(Settings.Default.MachineName != Environment.MachineName))
        return;
      Settings.Default.ServerPath = "Path has not been set yet!";
      Settings.Default.ApachePath = "Path has not been set yet!";
      Settings.Default.MySQLPath = "Path has not been set yet!";
      Settings.Default.KeepOnTop = false;
      Settings.Default.MachineName = Environment.MachineName;
      Settings.Default.Save();
    }

    private void autoRestartAuthServer(object sender, EventArgs e)
    {
      if (this.AutoRestart.Checked)
      {
        if (!this.isServerPathCorrect)
          return;
        this.authServer.Start();
        ++this.authServerRestartCount;
        this.Log("Stopped the Auth server.  Restarting...");
      }
      else
        this.Log("Stopped the Auth server.");
    }

    private void autoRestartWorldServer(object sender, EventArgs e)
    {
      if (this.AutoRestart.Checked)
      {
        if (!this.isServerPathCorrect)
          return;
        this.worldServer.Start();
        ++this.worldServerRestartCount;
        this.Log("Stopped the World server.  Restarting...");
      }
      else
        this.Log("Stopped the World server.");
    }

    private void ChangeOpacity(object menuSelection, double opacity)
    {
      this.Opacity = opacity;
      this.currentOpacitySetting.Checked = false;
      this.currentOpacitySetting = (ToolStripMenuItem) menuSelection;
      this.currentOpacitySetting.Checked = true;
    }

    private void Opacity100_Click(object sender, EventArgs e) => this.ChangeOpacity(sender, 1.0);

    private void Opacity90_Click(object sender, EventArgs e) => this.ChangeOpacity(sender, 0.9);

    private void Opacity80_Click(object sender, EventArgs e) => this.ChangeOpacity(sender, 0.8);

    private void Opacity70_Click(object sender, EventArgs e) => this.ChangeOpacity(sender, 0.7);

    private void Opacity60_Click(object sender, EventArgs e) => this.ChangeOpacity(sender, 0.6);

    private void Opacity50_Click(object sender, EventArgs e) => this.ChangeOpacity(sender, 0.5);

    private void KeepOnTop_Click(object sender, EventArgs e)
    {
      this.TopMost = ((ToolStripMenuItem) sender).Checked;
      Settings.Default.KeepOnTop = this.TopMost;
      Settings.Default.Save();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

    private void ServerPathButton_Click(object sender, EventArgs e)
    {
      int num = (int) this.ServerFolderBrowser.ShowDialog();
      if (this.ServerFolderBrowser.SelectedPath != "")
      {
        this.ServerPath.Text = this.ServerFolderBrowser.SelectedPath;
        Settings.Default.ServerPath = this.ServerFolderBrowser.SelectedPath;
        Settings.Default.Save();
      }
      this.CheckPaths();
    }

    private void MySQLPathButton_Click(object sender, EventArgs e)
    {
      int num = (int) this.SqlFolderBrowser.ShowDialog();
      if (this.SqlFolderBrowser.SelectedPath != "")
      {
        this.MySQLPath.Text = this.SqlFolderBrowser.SelectedPath;
        Settings.Default.MySQLPath = this.SqlFolderBrowser.SelectedPath;
        Settings.Default.Save();
      }
      this.CheckPaths();
    }

    private void ApachePathButton_Click(object sender, EventArgs e)
    {
      int num = (int) this.ApacheFolderBrowser.ShowDialog();
      if (this.ApacheFolderBrowser.SelectedPath != "")
      {
        this.ApachePath.Text = this.ApacheFolderBrowser.SelectedPath;
        Settings.Default.ApachePath = this.ApacheFolderBrowser.SelectedPath;
        Settings.Default.Save();
      }
      this.CheckPaths();
    }

    private void CheckPaths()
    {
      if (File.Exists(this.ServerPath.Text + "\\authserver.exe") && File.Exists(this.ServerPath.Text + "\\worldserver.exe"))
      {
        this.isServerPathCorrect = true;
        this.ServerPath.BackColor = Color.LightGreen;
        this.startWorld.Enabled = true;
        this.startAuth.Enabled = true;
        this.stopWorld.Enabled = true;
        this.stopAuth.Enabled = true;
        this.AutoRestart.Enabled = true;
        this.worldServerInfo.WorkingDirectory = this.ServerPath.Text;
        this.authServerInfo.WorkingDirectory = this.ServerPath.Text;
      }
      else
      {
        this.isServerPathCorrect = false;
        this.ServerPath.BackColor = Color.LightCoral;
        this.startWorld.Enabled = false;
        this.startAuth.Enabled = false;
        this.stopWorld.Enabled = false;
        this.stopAuth.Enabled = false;
        this.AutoRestart.Enabled = false;
      }
      if (File.Exists(this.MySQLPath.Text + "\\mysqld.exe"))
      {
        this.isMysqlPathCorrect = true;
        this.MySQLPath.BackColor = Color.LightGreen;
        this.startMySQL.Enabled = true;
        this.stopMySQL.Enabled = true;
        this.mySQLInfo.WorkingDirectory = this.MySQLPath.Text;
      }
      else
      {
        this.isMysqlPathCorrect = false;
        this.MySQLPath.BackColor = Color.LightCoral;
        this.startMySQL.Enabled = false;
        this.stopMySQL.Enabled = false;
      }
      if (File.Exists(this.ApachePath.Text + "\\httpd.exe"))
      {
        this.isApachePathCorrect = true;
        this.ApachePath.BackColor = Color.LightGreen;
        this.startApache.Enabled = true;
        this.stopApache.Enabled = true;
        this.apacheInfo.WorkingDirectory = this.ApachePath.Text;
      }
      else
      {
        this.isApachePathCorrect = false;
        this.ApachePath.BackColor = Color.LightCoral;
        this.startApache.Enabled = false;
        this.stopApache.Enabled = false;
      }
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new About().ShowDialog();
    }

    private void startWorld_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.worldServer.HasExited)
          return;
        this.CheckPaths();
        if (!this.isServerPathCorrect)
          return;
        this.worldServer.Start();
        this.Log("Started the World server.");
      }
      catch (InvalidOperationException ex)
      {
        this.worldServer.Start();
        this.Log("Started the World server.");
      }
    }

    private void stopWorld_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.worldServer.HasExited)
          return;
        this.worldServer.Kill();
      }
      catch (InvalidOperationException ex)
      {
      }
    }

    private void startAuth_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.authServer.HasExited)
          return;
        this.CheckPaths();
        if (!this.isServerPathCorrect)
          return;
        this.authServer.Start();
        this.Log("Started the Auth server.");
      }
      catch (InvalidOperationException ex)
      {
        this.authServer.Start();
        this.Log("Started the Auth server.");
      }
    }

    private void stopAuth_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.authServer.HasExited)
          return;
        this.authServer.Kill();
      }
      catch (InvalidOperationException ex)
      {
      }
    }

    private void startMySQL_Click(object sender, EventArgs e)
    {
      if (this.IsProcessRunning("mysqld"))
        return;
      this.mySQL.Start();
      this.Log("Started the MySQL server.");
    }

    private void stopMySQL_Click(object sender, EventArgs e)
    {
      if (!this.KillProcess("mysqld"))
        return;
      this.Log("Stopped the MySQL server.");
    }

    private void startApache_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.apache.HasExited)
          return;
        this.CheckPaths();
        if (!this.isApachePathCorrect)
          return;
        this.apache.Start();
        this.Log("Started the Apache server.");
      }
      catch (InvalidOperationException ex)
      {
        this.apache.Start();
        this.Log("Started the Apache server.");
      }
    }

    private void stopApache_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.apache.HasExited)
        {
          this.apache.Kill();
          this.Log("Stopped the Apache server.");
        }
      }
      catch (InvalidOperationException ex)
      {
      }
      this.KillProcess("httpd");
    }

    private bool IsProcessRunning(string processName) => Process.GetProcessesByName(processName).Length != 0;

    private bool KillProcess(string processName)
    {
      Process[] processesByName = Process.GetProcessesByName(processName);
      bool flag = false;
      foreach (Process process in processesByName)
      {
        try
        {
          process.Kill();
          flag = true;
        }
        catch (Win32Exception ex)
        {
        }
      }
      return flag;
    }

    private void helpToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new Help().ShowDialog();
    }

    private void openWorldserverConfigToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.isServerPathCorrect)
        Process.Start("notepad.exe", this.ServerPath.Text + "\\worldserver.conf");
      else
        this.Log("Error!  Can't open the config file, incorrect server path.");
    }

    private void openAuthserverConfigToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.isServerPathCorrect)
        Process.Start("notepad.exe", this.ServerPath.Text + "\\authserver.conf");
      else
        this.Log("Error!  Can't open the config file, incorrect server path.");
    }

    private void Log(string text)
    {
      if (this.log.InvokeRequired)
      {
        this.Invoke((Delegate) new Form1.SetLogCallback(this.Log), (object) text);
      }
      else
      {
        this.log.AppendText("\n[" + DateTime.Now.ToString("hh:mm:ss tt") + "] " + text);
        this.log.ScrollToCaret();
      }
    }

    private delegate void SetLogCallback(string text);
  }
}
