// Decompiled with JetBrains decompiler
// Type: _8890DTest.万能密码公式
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class 万能密码公式 : Form
  {
    public const int ConData = 53;
    private IContainer components = (IContainer) null;
    private Label label2;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label1;
    private Button button1;
    private Label label3;
    private Button button2;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label2 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.label1 = new Label();
      this.button1 = new Button();
      this.label3 = new Label();
      this.button2 = new Button();
      this.SuspendLayout();
      this.label2.AutoSize = true;
      this.label2.Location = new Point(44, 94);
      this.label2.Name = "label2";
      this.label2.Size = new Size(59, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "输出密码:";
      this.textBox1.Location = new Point(130, 85);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(75, 21);
      this.textBox1.TabIndex = 2;
      this.textBox2.Location = new Point(130, 46);
      this.textBox2.MaxLength = 8;
      this.textBox2.Name = "textBox2";
      this.textBox2.PasswordChar = '*';
      this.textBox2.Size = new Size(75, 21);
      this.textBox2.TabIndex = 4;
      this.textBox2.Leave += new EventHandler(this.textBox2_Leave);
      this.textBox2.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(44, 55);
      this.label1.Name = "label1";
      this.label1.Size = new Size(59, 12);
      this.label1.TabIndex = 3;
      this.label1.Text = "输入密匙:";
      this.button1.Location = new Point(16, 125);
      this.button1.Name = "button1";
      this.button1.Size = new Size(114, 32);
      this.button1.TabIndex = 5;
      this.button1.Text = "获 取 密 码";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label3.AutoSize = true;
      this.label3.Font = new Font("宋体", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.label3.ForeColor = Color.Crimson;
      this.label3.Location = new Point(12, 9);
      this.label3.Name = "label3";
      this.label3.Size = new Size(251, 20);
      this.label3.TabIndex = 6;
      this.label3.Text = "注:此万能密码当小时有效";
      this.button2.Location = new Point(140, 125);
      this.button2.Name = "button2";
      this.button2.Size = new Size(114, 32);
      this.button2.TabIndex = 7;
      this.button2.Text = "获 取 默 认 值";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(266, 169);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label2);
      this.Name = nameof (万能密码公式);
      this.Text = nameof (万能密码公式);
      this.Load += new EventHandler(this.万能密码公式_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public 万能密码公式()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void 万能密码公式_Load(object sender, EventArgs e) => this.textBox2.Text = string.Format("{0:yyMMddHH}", (object) DateTime.Now);

    private void button1_Click(object sender, EventArgs e)
    {
      DateTime now = DateTime.Now;
      string text = this.textBox2.Text;
      Convert.ToInt32(text.Substring(0, 2), 16);
      int int32_1 = Convert.ToInt32(text.Substring(2, 2), 16);
      int int32_2 = Convert.ToInt32(text.Substring(4, 2), 16);
      int Data1 = Convert.ToInt32(text.Substring(6, 2), 16) ^ int32_1 ^ 53;
      int Data2 = int32_2 ^ Data1 ^ 53;
      int Data3 = Data2 ^ Data1 ^ 53;
      int Data4 = Data3 ^ Data2 ^ 53;
      this.textBox1.Text = Class1.DataToHexStr((long) Data1) + Class1.DataToHexStr((long) Data2) + Class1.DataToHexStr((long) Data3) + Class1.DataToHexStr((long) Data4);
    }

    private void textBox2_Leave(object sender, EventArgs e)
    {
      if (!(this.textBox2.Text != ""))
        return;
      this.textBox2.Text = Class1.StrAutoAdd0Pro(this.textBox2.Text, (byte) 8);
    }

    private void button2_Click(object sender, EventArgs e) => this.textBox2.Text = string.Format("{0:yyMMddHH}", (object) DateTime.Now);

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool flag = Class1.DtmfKeyUseFulChkPro(e.KeyChar);
      e.Handled = flag;
    }
  }
}
