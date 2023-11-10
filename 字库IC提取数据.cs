// Decompiled with JetBrains decompiler
// Type: _8890DTest.字库IC提取数据
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _8890DTest
{
  public class 字库IC提取数据 : Form
  {
    private string FileName = "字库IC_out.c";
    private string FileNameOut = "字库IC.c";
    private string ConTempFilePath2;
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private CheckBox checkBox1;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private OpenFileDialog openFileDialog1;
    private Button button4;
    private TextBox textBox2;
    private Button button1;
    private TextBox textBox1;
    private Label label3;

    public 字库IC提取数据()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private static int FastIndexOf(string source, string pattern)
    {
      int count = source.Length - pattern.Length + 1;
      if (count < 1)
        return -1;
      char ch1 = pattern[0];
      char ch2 = pattern.Length > 1 ? pattern[1] : ' ';
      int num1 = source.IndexOf(ch1, 0, count);
      while (num1 != -1)
      {
        if (pattern.Length > 1 && (int) source[num1 + 1] != (int) ch2)
        {
          int num2;
          num1 = source.IndexOf(ch1, num2 = num1 + 1, count - num2);
        }
        else
        {
          bool flag = true;
          for (int index = 2; index < pattern.Length; ++index)
          {
            if ((int) source[num1 + index] != (int) pattern[index])
            {
              flag = false;
              break;
            }
          }
          if (flag)
            return num1;
          int num3;
          num1 = source.IndexOf(ch1, num3 = num1 + 1, count - num3);
        }
      }
      return -1;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.openFileDialog1.CheckFileExists = true;
      this.openFileDialog1.CheckPathExists = true;
      this.openFileDialog1.Multiselect = true;
      this.openFileDialog1.ReadOnlyChecked = true;
      this.openFileDialog1.ShowHelp = true;
      this.openFileDialog1.Filter = "（*.c）|*.c|（*.*）|*.*";
      this.openFileDialog1.FileName = "*.c";
      int num = (int) this.openFileDialog1.ShowDialog();
    }

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      this.FileName = this.openFileDialog1.FileName;
      this.textBox2.Text = this.FileName;
      this.ConTempFilePath2 = Path.GetDirectoryName(this.openFileDialog1.FileName);
      this.FileNameOut = this.ConTempFilePath2 + "/FileOut.c";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string strTest = "";
      if (this.textBox2.Text == "")
      {
        int num1 = (int) MessageBox.Show("请选择待转换数据！", Class1.RadioName);
      }
      else
      {
        string[] strArray = Class1.ReadFileDataPro(this.FileName).Split('\n');
        int num2 = (int) this.numericUpDown1.Value;
        int length1 = num2 * 5;
        int length2 = (int) this.numericUpDown2.Value;
        int num3 = (num2 + 1) * length2;
        string text = this.textBox1.Text;
        for (int index = 0; index < num3; ++index)
        {
          string source = strArray[index];
          if (source.Substring(source.Length - 1, 1) == "\r")
            source = source.Substring(0, source.Length - 1);
          int num4 = 字库IC提取数据.FastIndexOf(source, "Data_OX");
          string str1 = Class1.StrAutoAdd0Pro(source.Substring(num4 + 8, source.Length - (num4 + 8)), (byte) 2);
          if (str1 != text)
          {
            string str2 = "0X" + str1 + ",";
            strTest += str2;
          }
        }
        string aZ = Class1.Chga_z_ToA_Z(strTest);
        for (int index = 0; index < length2; ++index)
          strArray[index] = this.checkBox1.Checked ? "{" + aZ.Substring(index * length1, length1) + "}," : aZ.Substring(index * length1, length1);
        string[] StrData = new string[length2];
        for (int index = 0; index < length2; ++index)
          StrData[index] = strArray[index];
        Class1.SaveFileDataPro(this.FileNameOut, StrData);
        int num5 = (int) MessageBox.Show("数据提取成功！", Class1.RadioName);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label2 = new Label();
      this.checkBox1 = new CheckBox();
      this.numericUpDown1 = new NumericUpDown();
      this.numericUpDown2 = new NumericUpDown();
      this.openFileDialog1 = new OpenFileDialog();
      this.button4 = new Button();
      this.textBox2 = new TextBox();
      this.button1 = new Button();
      this.textBox1 = new TextBox();
      this.label3 = new Label();
      this.numericUpDown1.BeginInit();
      this.numericUpDown2.BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(13, 21);
      this.label1.Name = "label1";
      this.label1.Size = new Size(83, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "每组字节个数:";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(171, 21);
      this.label2.Name = "label2";
      this.label2.Size = new Size(65, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "共计几组：";
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(15, 50);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(102, 16);
      this.checkBox1.TabIndex = 2;
      this.checkBox1.Text = "每组用{}分开:";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.numericUpDown1.Location = new Point(102, 12);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new Size(50, 21);
      this.numericUpDown1.TabIndex = 3;
      this.numericUpDown1.Value = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown2.Location = new Point(242, 12);
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new Size(50, 21);
      this.numericUpDown2.TabIndex = 4;
      this.numericUpDown2.Value = new Decimal(new int[4]
      {
        59,
        0,
        0,
        0
      });
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.FileOk += new CancelEventHandler(this.openFileDialog1_FileOk);
      this.button4.Location = new Point(217, 79);
      this.button4.Name = "button4";
      this.button4.Size = new Size(75, 23);
      this.button4.TabIndex = 19;
      this.button4.Text = "选择....";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.textBox2.Enabled = false;
      this.textBox2.Location = new Point(3, 81);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(208, 21);
      this.textBox2.TabIndex = 18;
      this.button1.Location = new Point(102, 131);
      this.button1.Name = "button1";
      this.button1.Size = new Size(85, 47);
      this.button1.TabIndex = 20;
      this.button1.Text = "开始转换";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.textBox1.Location = new Point(242, 48);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(44, 21);
      this.textBox1.TabIndex = 21;
      this.textBox1.Text = "aa";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(147, 57);
      this.label3.Name = "label3";
      this.label3.Size = new Size(89, 12);
      this.label3.TabIndex = 22;
      this.label3.Text = "每组开始头字符";
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(299, 208);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.numericUpDown2);
      this.Controls.Add((Control) this.numericUpDown1);
      this.Controls.Add((Control) this.checkBox1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (字库IC提取数据);
      this.Text = nameof (字库IC提取数据);
      this.Load += new EventHandler(this.Form1_Load);
      this.numericUpDown1.EndInit();
      this.numericUpDown2.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
