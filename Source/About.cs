using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace JeutieControl
{
  public class About : Form
  {
    private IContainer components;
    private Button button1;
    private RichTextBox richTextBox1;
    private PictureBox pictureBox1;

    public About()
    {
      this.InitializeComponent();
      this.richTextBox1.LinkClicked += new LinkClickedEventHandler(this.richTextBox1_LinkClicked);
    }

    private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e) => Process.Start(e.LinkText);

    private void About_Load(object sender, EventArgs e)
    {
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://jordythery.be/");

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://craftedro.go.ro/");

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (About));
      this.button1 = new Button();
      this.richTextBox1 = new RichTextBox();
      this.pictureBox1 = new PictureBox();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.button1.Location = new Point(87, 132);
      this.button1.Name = "button1";
      this.button1.Size = new Size(175, 30);
      this.button1.TabIndex = 4;
      this.button1.Text = "Close";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.richTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
      this.richTextBox1.BorderStyle = BorderStyle.None;
      this.richTextBox1.Location = new Point(12, 12);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.ReadOnly = true;
      this.richTextBox1.Size = new Size(242, 84);
      this.richTextBox1.TabIndex = 5;
      this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
      this.richTextBox1.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(266, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(69, 72);
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(347, 174);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.richTextBox1);
      this.Controls.Add((Control) this.button1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name = nameof (About);
      this.Text = nameof (About);
      this.Load += new EventHandler(this.About_Load);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
