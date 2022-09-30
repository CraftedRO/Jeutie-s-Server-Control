using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JeutieControl
{
  public class Help : Form
  {
    private IContainer components;
    private RichTextBox richTextBox1;
    private TextBox textBox1;
    private TextBox textBox2;
    private RichTextBox richTextBox2;
    private Button button1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Help));
      this.richTextBox1 = new RichTextBox();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.richTextBox2 = new RichTextBox();
      this.button1 = new Button();
      this.SuspendLayout();
      this.richTextBox1.BackColor = SystemColors.Control;
      this.richTextBox1.BorderStyle = BorderStyle.None;
      this.richTextBox1.Location = new Point(12, 47);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.ReadOnly = true;
      this.richTextBox1.Size = new Size(527, 180);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
      this.textBox1.BackColor = SystemColors.Control;
      this.textBox1.BorderStyle = BorderStyle.None;
      this.textBox1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textBox1.Location = new Point(12, 12);
      this.textBox1.Margin = new Padding(3, 3, 3, 5);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new Size(443, 27);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "How to use this program.";
      this.textBox2.BackColor = SystemColors.Control;
      this.textBox2.BorderStyle = BorderStyle.None;
      this.textBox2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textBox2.ForeColor = Color.Firebrick;
      this.textBox2.Location = new Point(12, 233);
      this.textBox2.Margin = new Padding(3, 3, 3, 5);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new Size(443, 27);
      this.textBox2.TabIndex = 3;
      this.textBox2.Text = "Important!";
      this.richTextBox2.BackColor = SystemColors.Control;
      this.richTextBox2.BorderStyle = BorderStyle.None;
      this.richTextBox2.ForeColor = Color.Firebrick;
      this.richTextBox2.Location = new Point(12, 268);
      this.richTextBox2.Name = "richTextBox2";
      this.richTextBox2.ReadOnly = true;
      this.richTextBox2.Size = new Size(527, 113);
      this.richTextBox2.TabIndex = 2;
      this.richTextBox2.Text = componentResourceManager.GetString("richTextBox2.Text");
      this.button1.Location = new Point(161, 411);
      this.button1.Name = "button1";
      this.button1.Size = new Size(231, 32);
      this.button1.TabIndex = 4;
      this.button1.Text = "Close";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(551, 455);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.richTextBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.richTextBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = nameof (Help);
      this.Text = nameof (Help);
      this.Load += new EventHandler(this.Help_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public Help() => this.InitializeComponent();

    private void Help_Load(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();
  }
}
