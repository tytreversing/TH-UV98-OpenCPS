// Decompiled with JetBrains decompiler
// Type: _8890DTest.汉字与GBK转换
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8890DTest
{
  public class 汉字与GBK转换 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button2;

    public 汉字与GBK转换() => this.InitializeComponent();

    private string hanziTOGbk_ChangePro(string StrTemp, int Length)
    {
      byte[] bytes = Encoding.GetEncoding("GBK").GetBytes(StrTemp);
      string StrTemp1 = "";
      foreach (byte num in bytes)
        StrTemp1 += string.Format("{0:X2}", (object) num);
      return Class1.StrAutoAdd0X20Pro(StrTemp1, 4 * Length);
    }

    private string GBKTOHanzi_ChangePro(string StrTempData)
    {
      string str1 = StrTempData;
      string str2 = "";
      byte[] bytes = new byte[2];
      int num = StrTempData.Length / 4;
      for (int index = 0; index < num; ++index)
      {
        string str3 = str1.Substring(4 * index, 2);
        bytes[0] = Convert.ToByte(str3, 16);
        string str4 = str1.Substring(4 * index + 2, 2);
        bytes[1] = Convert.ToByte(str4, 16);
        str2 += Encoding.GetEncoding("GBK").GetString(bytes);
      }
      return str2;
    }

    private void button1_Click(object sender, EventArgs e) => this.textBox2.Text = this.hanziTOGbk_ChangePro(this.textBox1.Text.ToString(), 8);

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e) => this.textBox1.Text = this.GBKTOHanzi_ChangePro(this.textBox2.Text.ToString());

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.button1 = new Button();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.button2 = new Button();
      this.SuspendLayout();
      this.button1.Location = new Point(38, 210);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "汉字转GBK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.textBox1.Location = new Point(38, 27);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(140, 21);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "董小灿是我爸爸啊";
      this.textBox2.Location = new Point(38, 80);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(211, 82);
      this.textBox2.TabIndex = 2;
      this.button2.Location = new Point(174, 210);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 3;
      this.button2.Text = "GBK转汉字";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(284, 261);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
