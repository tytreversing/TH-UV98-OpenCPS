// Decompiled with JetBrains decompiler
// Type: _8890DTest.ComSet
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace _8890DTest
{
  public class ComSet : Form
  {
    public bool[] ComUseAble = new bool[16];
    public int ChNumBer = 0;
    public string StrPath = "";
    public static string[,] Button_EngCh = new string[2, 3]
    {
      {
        "确定",
        "取消",
        "端口选择"
      },
      {
        "Enter",
        "Cancel",
        "COM Select"
      }
    };
    private IContainer components = (IContainer) null;
    private SerialPort serialPort1;
    private GroupBox groupBox1;
    private Button button2;
    private Button button1;
    private RadioButton radioButton13;
    private RadioButton radioButton14;
    private RadioButton radioButton15;
    private RadioButton radioButton16;
    private RadioButton radioButton9;
    private RadioButton radioButton10;
    private RadioButton radioButton11;
    private RadioButton radioButton12;
    private RadioButton radioButton5;
    private RadioButton radioButton6;
    private RadioButton radioButton7;
    private RadioButton radioButton8;
    private RadioButton radioButton4;
    private RadioButton radioButton3;
    private RadioButton radioButton2;
    private RadioButton radioButton1;

    public ComSet()
    {
      this.StartPosition = FormStartPosition.CenterScreen;
      this.InitializeComponent();
    }

    public void ComUseFulChkPro()
    {
      for (int index = 1; index <= 16; ++index)
      {
        try
        {
          this.serialPort1.PortName = "COM" + (object) index;
          this.serialPort1.Open();
          this.serialPort1.Close();
          this.ComUseAble[index - 1] = true;
        }
        catch
        {
          this.ComUseAble[index - 1] = false;
        }
      }
      RadioButton[] radioButtonArray = new RadioButton[16]
      {
        this.radioButton1,
        this.radioButton2,
        this.radioButton3,
        this.radioButton4,
        this.radioButton5,
        this.radioButton6,
        this.radioButton7,
        this.radioButton8,
        this.radioButton9,
        this.radioButton10,
        this.radioButton11,
        this.radioButton12,
        this.radioButton13,
        this.radioButton14,
        this.radioButton15,
        this.radioButton16
      };
      for (int index = 0; index <= 15; ++index)
      {
        radioButtonArray[index].Enabled = this.ComUseAble[index];
        if (radioButtonArray[index].Checked)
          this.ChNumBer = index + 1;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      string[] strArray = Class1.ReadFileDataPro(this.StrPath).Split('\r');
      int num = Class1.LookStringPt(strArray[9], "=");
      switch (strArray[9].Substring(num + 1, strArray[9].Length - num - 1))
      {
        case "COM1":
          this.ChNumBer = 1;
          this.radioButton1.Checked = true;
          break;
        case "COM2":
          this.ChNumBer = 2;
          this.radioButton2.Checked = true;
          break;
        case "COM3":
          this.ChNumBer = 3;
          this.radioButton3.Checked = true;
          break;
        case "COM4":
          this.ChNumBer = 4;
          this.radioButton4.Checked = true;
          break;
        case "COM5":
          this.ChNumBer = 5;
          this.radioButton5.Checked = true;
          break;
        case "COM6":
          this.ChNumBer = 6;
          this.radioButton6.Checked = true;
          break;
        case "COM7":
          this.ChNumBer = 7;
          this.radioButton7.Checked = true;
          break;
        case "COM8":
          this.ChNumBer = 8;
          this.radioButton8.Checked = true;
          break;
        case "COM9":
          this.ChNumBer = 9;
          this.radioButton9.Checked = true;
          break;
        case "COM10":
          this.ChNumBer = 10;
          this.radioButton10.Checked = true;
          break;
        case "COM11":
          this.ChNumBer = 11;
          this.radioButton11.Checked = true;
          break;
        case "COM12":
          this.ChNumBer = 12;
          this.radioButton12.Checked = true;
          break;
        case "COM13":
          this.ChNumBer = 13;
          this.radioButton13.Checked = true;
          break;
        case "COM14":
          this.ChNumBer = 14;
          this.radioButton14.Checked = true;
          break;
        case "COM15":
          this.ChNumBer = 15;
          this.radioButton15.Checked = true;
          break;
        case "COM16":
          this.ChNumBer = 16;
          this.radioButton16.Checked = true;
          break;
        default:
          this.ChNumBer = 1;
          this.radioButton1.Checked = true;
          break;
      }
      this.ComUseFulChkPro();
      this.button1.Text = ComSet.Button_EngCh[Class1.English_En, 0];
      this.button2.Text = ComSet.Button_EngCh[Class1.English_En, 1];
      this.Text = ComSet.Button_EngCh[Class1.English_En, 2];
    }

    private void radioButton7_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string[] strArray = Class1.ReadFileDataPro(this.StrPath).Split('\r');
      int num = Class1.LookStringPt(strArray[9], "=");
      string str = strArray[9].Substring(num + 1, strArray[9].Length - num - 1);
      this.ChNumBer = (int) Convert.ToInt16(str.Substring(3, str.Length - 3), 10);
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.ChNumBer >= 1 && this.ChNumBer <= 16)
      {
        string str = Convert.ToString(this.ChNumBer, 10);
        string[] StrData = Class1.ReadFileDataPro(Class1.MainFilePath + "settings.ini").Split('\r');
        StrData[9] = "COMSelect=COM" + str;
        Class1.SaveFileDataPro(Class1.MainFilePath + "settings.ini", StrData);
      }
      this.Close();
    }

    private void radioButton1_Click(object sender, EventArgs e)
    {
      if (!this.radioButton1.Checked)
        return;
      this.ChNumBer = 1;
    }

    private void radioButton2_Click(object sender, EventArgs e)
    {
      if (!this.radioButton2.Checked)
        return;
      this.ChNumBer = 2;
    }

    private void radioButton3_Click(object sender, EventArgs e)
    {
      if (!this.radioButton3.Checked)
        return;
      this.ChNumBer = 3;
    }

    private void radioButton4_Click(object sender, EventArgs e)
    {
      if (!this.radioButton4.Checked)
        return;
      this.ChNumBer = 4;
    }

    private void radioButton5_Click(object sender, EventArgs e)
    {
      if (!this.radioButton5.Checked)
        return;
      this.ChNumBer = 5;
    }

    private void radioButton6_Click(object sender, EventArgs e)
    {
      if (!this.radioButton6.Checked)
        return;
      this.ChNumBer = 6;
    }

    private void radioButton7_Click(object sender, EventArgs e)
    {
      if (!this.radioButton7.Checked)
        return;
      this.ChNumBer = 7;
    }

    private void radioButton8_Click(object sender, EventArgs e)
    {
      if (!this.radioButton8.Checked)
        return;
      this.ChNumBer = 8;
    }

    private void radioButton9_Click(object sender, EventArgs e)
    {
      if (!this.radioButton9.Checked)
        return;
      this.ChNumBer = 9;
    }

    private void radioButton10_Click(object sender, EventArgs e)
    {
      if (!this.radioButton10.Checked)
        return;
      this.ChNumBer = 10;
    }

    private void radioButton11_Click(object sender, EventArgs e)
    {
      if (!this.radioButton11.Checked)
        return;
      this.ChNumBer = 1;
    }

    private void radioButton12_Click(object sender, EventArgs e)
    {
      if (!this.radioButton12.Checked)
        return;
      this.ChNumBer = 12;
    }

    private void radioButton13_Click(object sender, EventArgs e)
    {
      if (!this.radioButton13.Checked)
        return;
      this.ChNumBer = 13;
    }

    private void radioButton14_Click(object sender, EventArgs e)
    {
      if (!this.radioButton14.Checked)
        return;
      this.ChNumBer = 14;
    }

    private void radioButton15_Click(object sender, EventArgs e)
    {
      if (!this.radioButton15.Checked)
        return;
      this.ChNumBer = 15;
    }

    private void radioButton16_Click(object sender, EventArgs e)
    {
      if (!this.radioButton16.Checked)
        return;
      this.ChNumBer = 16;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ComSet));
      this.serialPort1 = new SerialPort(this.components);
      this.groupBox1 = new GroupBox();
      this.button2 = new Button();
      this.button1 = new Button();
      this.radioButton13 = new RadioButton();
      this.radioButton14 = new RadioButton();
      this.radioButton15 = new RadioButton();
      this.radioButton16 = new RadioButton();
      this.radioButton9 = new RadioButton();
      this.radioButton10 = new RadioButton();
      this.radioButton11 = new RadioButton();
      this.radioButton12 = new RadioButton();
      this.radioButton5 = new RadioButton();
      this.radioButton6 = new RadioButton();
      this.radioButton7 = new RadioButton();
      this.radioButton8 = new RadioButton();
      this.radioButton4 = new RadioButton();
      this.radioButton3 = new RadioButton();
      this.radioButton2 = new RadioButton();
      this.radioButton1 = new RadioButton();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.button2);
      this.groupBox1.Controls.Add((Control) this.button1);
      this.groupBox1.Controls.Add((Control) this.radioButton13);
      this.groupBox1.Controls.Add((Control) this.radioButton14);
      this.groupBox1.Controls.Add((Control) this.radioButton15);
      this.groupBox1.Controls.Add((Control) this.radioButton16);
      this.groupBox1.Controls.Add((Control) this.radioButton9);
      this.groupBox1.Controls.Add((Control) this.radioButton10);
      this.groupBox1.Controls.Add((Control) this.radioButton11);
      this.groupBox1.Controls.Add((Control) this.radioButton12);
      this.groupBox1.Controls.Add((Control) this.radioButton5);
      this.groupBox1.Controls.Add((Control) this.radioButton6);
      this.groupBox1.Controls.Add((Control) this.radioButton7);
      this.groupBox1.Controls.Add((Control) this.radioButton8);
      this.groupBox1.Controls.Add((Control) this.radioButton4);
      this.groupBox1.Controls.Add((Control) this.radioButton3);
      this.groupBox1.Controls.Add((Control) this.radioButton2);
      this.groupBox1.Controls.Add((Control) this.radioButton1);
      this.groupBox1.Location = new Point(-1, -2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(300, 235);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.button2.Location = new Point(185, 202);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 33;
      this.button2.Text = "取消";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.Location = new Point(56, 202);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 32;
      this.button1.Text = "确定";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.radioButton13.AutoSize = true;
      this.radioButton13.Location = new Point(236, 42);
      this.radioButton13.Name = "radioButton13";
      this.radioButton13.Size = new Size(53, 16);
      this.radioButton13.TabIndex = 31;
      this.radioButton13.Text = "COM13";
      this.radioButton13.UseVisualStyleBackColor = true;
      this.radioButton13.Click += new EventHandler(this.radioButton13_Click);
      this.radioButton14.AutoSize = true;
      this.radioButton14.Location = new Point(241, 79);
      this.radioButton14.Name = "radioButton14";
      this.radioButton14.Size = new Size(53, 16);
      this.radioButton14.TabIndex = 30;
      this.radioButton14.Text = "COM14";
      this.radioButton14.UseVisualStyleBackColor = true;
      this.radioButton14.Click += new EventHandler(this.radioButton14_Click);
      this.radioButton15.AutoSize = true;
      this.radioButton15.Location = new Point(241, 116);
      this.radioButton15.Name = "radioButton15";
      this.radioButton15.Size = new Size(53, 16);
      this.radioButton15.TabIndex = 29;
      this.radioButton15.Text = "COM15";
      this.radioButton15.UseVisualStyleBackColor = true;
      this.radioButton15.Click += new EventHandler(this.radioButton15_Click);
      this.radioButton16.AutoSize = true;
      this.radioButton16.Location = new Point(241, 157);
      this.radioButton16.Name = "radioButton16";
      this.radioButton16.Size = new Size(53, 16);
      this.radioButton16.TabIndex = 28;
      this.radioButton16.Text = "COM16";
      this.radioButton16.UseVisualStyleBackColor = true;
      this.radioButton16.Click += new EventHandler(this.radioButton16_Click);
      this.radioButton9.AutoSize = true;
      this.radioButton9.Location = new Point(173, 42);
      this.radioButton9.Name = "radioButton9";
      this.radioButton9.Size = new Size(47, 16);
      this.radioButton9.TabIndex = 27;
      this.radioButton9.Text = "COM9";
      this.radioButton9.UseVisualStyleBackColor = true;
      this.radioButton9.Click += new EventHandler(this.radioButton9_Click);
      this.radioButton10.AutoSize = true;
      this.radioButton10.Location = new Point(173, 79);
      this.radioButton10.Name = "radioButton10";
      this.radioButton10.Size = new Size(53, 16);
      this.radioButton10.TabIndex = 26;
      this.radioButton10.Text = "COM10";
      this.radioButton10.UseVisualStyleBackColor = true;
      this.radioButton10.Click += new EventHandler(this.radioButton10_Click);
      this.radioButton11.AutoSize = true;
      this.radioButton11.Location = new Point(173, 116);
      this.radioButton11.Name = "radioButton11";
      this.radioButton11.Size = new Size(53, 16);
      this.radioButton11.TabIndex = 25;
      this.radioButton11.Text = "COM11";
      this.radioButton11.UseVisualStyleBackColor = true;
      this.radioButton11.Click += new EventHandler(this.radioButton11_Click);
      this.radioButton12.AutoSize = true;
      this.radioButton12.Location = new Point(173, 157);
      this.radioButton12.Name = "radioButton12";
      this.radioButton12.Size = new Size(53, 16);
      this.radioButton12.TabIndex = 24;
      this.radioButton12.Text = "COM12";
      this.radioButton12.UseVisualStyleBackColor = true;
      this.radioButton12.Click += new EventHandler(this.radioButton12_Click);
      this.radioButton5.AutoSize = true;
      this.radioButton5.Location = new Point(105, 42);
      this.radioButton5.Name = "radioButton5";
      this.radioButton5.Size = new Size(47, 16);
      this.radioButton5.TabIndex = 23;
      this.radioButton5.Text = "COM5";
      this.radioButton5.UseVisualStyleBackColor = true;
      this.radioButton5.Click += new EventHandler(this.radioButton5_Click);
      this.radioButton6.AutoSize = true;
      this.radioButton6.Location = new Point(105, 79);
      this.radioButton6.Name = "radioButton6";
      this.radioButton6.Size = new Size(47, 16);
      this.radioButton6.TabIndex = 22;
      this.radioButton6.Text = "COM6";
      this.radioButton6.UseVisualStyleBackColor = true;
      this.radioButton6.Click += new EventHandler(this.radioButton6_Click);
      this.radioButton7.AutoSize = true;
      this.radioButton7.Location = new Point(105, 116);
      this.radioButton7.Name = "radioButton7";
      this.radioButton7.Size = new Size(47, 16);
      this.radioButton7.TabIndex = 21;
      this.radioButton7.Text = "COM7";
      this.radioButton7.UseVisualStyleBackColor = true;
      this.radioButton7.Click += new EventHandler(this.radioButton7_Click);
      this.radioButton8.AutoSize = true;
      this.radioButton8.Location = new Point(105, 157);
      this.radioButton8.Name = "radioButton8";
      this.radioButton8.Size = new Size(47, 16);
      this.radioButton8.TabIndex = 20;
      this.radioButton8.Text = "COM8";
      this.radioButton8.UseVisualStyleBackColor = true;
      this.radioButton8.Click += new EventHandler(this.radioButton8_Click);
      this.radioButton4.AutoSize = true;
      this.radioButton4.Location = new Point(37, 157);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new Size(47, 16);
      this.radioButton4.TabIndex = 19;
      this.radioButton4.Text = "COM4";
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton4.Click += new EventHandler(this.radioButton4_Click);
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new Point(37, 116);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new Size(47, 16);
      this.radioButton3.TabIndex = 18;
      this.radioButton3.Text = "COM3";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.Click += new EventHandler(this.radioButton3_Click);
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new Point(37, 79);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new Size(47, 16);
      this.radioButton2.TabIndex = 17;
      this.radioButton2.Text = "COM2";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.Click += new EventHandler(this.radioButton2_Click);
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new Point(37, 42);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new Size(47, 16);
      this.radioButton1.TabIndex = 16;
      this.radioButton1.Text = "COM1";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.Click += new EventHandler(this.radioButton1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(306, 238);
      this.Controls.Add((Control) this.groupBox1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (ComSet);
      this.Text = "端口选择";
      this.Load += new EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
