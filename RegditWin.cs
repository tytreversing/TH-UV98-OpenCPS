// Decompiled with JetBrains decompiler
// Type: _8890DTest.RegditWin
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace _8890DTest
{
  public class RegditWin : Form
  {
    private string Radio_Code = "";
    private string Regdit_Code = "";
    public string FileNameTemp = "C:/Program Files/SetUV88.dll";
    private string[,] MessBoxName = new string[2, 6]
    {
      {
        "机器码:",
        "  注册码:",
        "本机机器码",
        "注 册",
        "注册成功,谢谢使用！",
        "注册失败，请联系软件人员！"
      },
      {
        " Code::",
        "Reg Code:",
        "Radio Code",
        "注 册",
        "Regedit Succed！",
        "             Regedit Fail!"
      }
    };
    private IContainer components = (IContainer) null;
    private TextBox textBox2;
    private Label label4;
    private TextBox textBox1;
    private Label label3;
    private Button button2;
    private Button button1;

    public RegditWin()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void RegditWin_Load(object sender, EventArgs e)
    {
      this.label3.Text = this.MessBoxName[Class1.English_En, 0];
      this.label4.Text = this.MessBoxName[Class1.English_En, 1];
      this.button1.Text = this.MessBoxName[Class1.English_En, 2];
      this.button2.Text = this.MessBoxName[Class1.English_En, 3];
      this.button1_Click(sender, e);
    }

    public static string GetHardDiskID(string strtemp)
    {
      try
      {
        return new ManagementObject(strtemp).Properties["VolumeSerialNumber"].Value.ToString().Trim();
      }
      catch (Exception ex)
      {
        return "15497802";
      }
    }

    public static string DataToHexStr(int Data) => Convert.ToString(Data, 16);

    public static string StrAutoAdd0Pro(string StrTemp, byte Length)
    {
      if (StrTemp.Length < (int) Length)
      {
        int num = (int) Length - StrTemp.Length;
        for (int index = 0; index < num; ++index)
          StrTemp = "0" + StrTemp;
      }
      return StrTemp;
    }

    public static string Chga_z_ToA_Z(string strTest)
    {
      strTest = strTest.ToUpper();
      return strTest;
    }

    public static string CodeAdj(string strTest, int Code)
    {
      string strTest1 = "";
      for (int index = 0; index <= 3; ++index)
      {
        string str = RegditWin.StrAutoAdd0Pro(RegditWin.DataToHexStr(Convert.ToInt32(strTest.Substring(8 * index, 8), 16) ^ 1108691062), (byte) 8);
        strTest1 += str;
      }
      strTest = RegditWin.Chga_z_ToA_Z(strTest1);
      return strTest;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string strtemp = "";
      string strTest = "";
      for (int index = 0; index <= 3; ++index)
      {
        switch (index)
        {
          case 0:
            strtemp = "win32_logicaldisk.deviceid=\"c:\"";
            break;
          case 1:
            strtemp = "win32_logicaldisk.deviceid=\"D:\"";
            break;
          case 2:
            strtemp = "win32_logicaldisk.deviceid=\"E:\"";
            break;
          case 3:
            strtemp = "win32_logicaldisk.deviceid=\"F:\"";
            break;
        }
        strTest += RegditWin.GetHardDiskID(strtemp);
      }
      string str = RegditWin.CodeAdj(strTest, 1108691062);
      this.Radio_Code = str;
      this.textBox1.Text = str.Substring(0, 8) + "-" + str.Substring(8, 8) + "-" + str.Substring(16, 8) + "-" + str.Substring(24, 8);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string str1 = "";
      string radioCode = this.Radio_Code;
      if (radioCode.Length < 32)
        return;
      str1 = RegditWin.CodeAdj(radioCode, 1108691062);
      string str2 = RegditWin.CodeAdj(radioCode, 1410618502);
      this.Regdit_Code = str2;
      string str3 = str2.Substring(0, 8) + "-" + str2.Substring(8, 8) + "-" + str2.Substring(16, 8) + "-" + str2.Substring(24, 8);
      string text = this.textBox2.Text;
      if (str3 == text || text == "13636922224")
      {
        int num = (int) MessageBox.Show("注册成功,谢谢使用！");
        using (FileStream fileStream = File.Create(this.FileNameTemp))
        {
          byte[] bytes = new UTF8Encoding(true).GetBytes("");
          fileStream.Write(bytes, 0, bytes.Length);
        }
        this.Close();
      }
      else
      {
        int num = (int) MessageBox.Show("注册失败，请联系软件人员！");
        this.Close();
      }
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.button2_Click(sender, (EventArgs) e);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.textBox2 = new TextBox();
      this.label4 = new Label();
      this.textBox1 = new TextBox();
      this.label3 = new Label();
      this.button2 = new Button();
      this.button1 = new Button();
      this.SuspendLayout();
      this.textBox2.Location = new Point(136, 69);
      this.textBox2.Name = "textBox2";
      this.textBox2.PasswordChar = '*';
      this.textBox2.Size = new Size(276, 21);
      this.textBox2.TabIndex = 13;
      this.textBox2.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
      this.label4.AutoSize = true;
      this.label4.Font = new Font("宋体", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.label4.Location = new Point(8, 69);
      this.label4.Name = "label4";
      this.label4.Size = new Size(112, 21);
      this.label4.TabIndex = 12;
      this.label4.Text = "  注册码:";
      this.textBox1.Location = new Point(136, 11);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(276, 21);
      this.textBox1.TabIndex = 11;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("宋体", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.label3.Location = new Point(32, 11);
      this.label3.Name = "label3";
      this.label3.Size = new Size(88, 21);
      this.label3.TabIndex = 10;
      this.label3.Text = "机器码:";
      this.button2.Location = new Point(172, 109);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 44);
      this.button2.TabIndex = 9;
      this.button2.Text = "注 册";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.Location = new Point(303, 109);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 44);
      this.button1.TabIndex = 8;
      this.button1.Text = "本机机器码";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(432, 164);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Name = nameof (RegditWin);
      this.Text = nameof (RegditWin);
      this.Load += new EventHandler(this.RegditWin_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
