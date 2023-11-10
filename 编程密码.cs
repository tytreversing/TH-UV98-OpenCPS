// Decompiled with JetBrains decompiler
// Type: _8890DTest.编程密码
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class 编程密码 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button2;
    private Label label1;
    private TextBox textBox1;
    public string GiFileName1 = "8890D_TempFile.icf";
    public static string[,] Button_EngCh = new string[2, 2]
    {
      {
        "确定",
        "取消"
      },
      {
        "Enter",
        "Canel"
      }
    };
    private string[,] lableArrName = new string[2, 1]
    {
      {
        "    编程密码:"
      },
      {
        "Program Code:"
      }
    };
    private Button[] Button_Arr;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.button1 = new Button();
      this.button2 = new Button();
      this.label1 = new Label();
      this.textBox1 = new TextBox();
      this.SuspendLayout();
      this.button1.Location = new Point(32, 68);
      this.button1.Name = "button1";
      this.button1.Size = new Size(73, 28);
      this.button1.TabIndex = 0;
      this.button1.Text = "确定";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(137, 68);
      this.button2.Name = "button2";
      this.button2.Size = new Size(73, 28);
      this.button2.TabIndex = 1;
      this.button2.Text = "取消";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.label1.Location = new Point(7, 39);
      this.label1.Name = "label1";
      this.label1.Size = new Size(98, 14);
      this.label1.TabIndex = 2;
      this.label1.Text = "    编程密码:";
      this.textBox1.Location = new Point(111, 32);
      this.textBox1.MaxLength = 8;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(122, 21);
      this.textBox1.TabIndex = 3;
      this.textBox1.Leave += new EventHandler(this.textBox1_Leave);
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(244, 108);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Name = nameof (编程密码);
      this.Load += new EventHandler(this.ProgramCode_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public 编程密码()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void SetContrlAs_arrPro()
    {
      this.Button_Arr = new Button[2];
      this.Button_Arr[0] = this.button1;
      this.Button_Arr[1] = this.button2;
    }

    private void load_GroBox1_ButtonPro()
    {
      for (int index = 0; index <= 1; ++index)
        this.Button_Arr[index].Text = 编程密码.Button_EngCh[Class1.English_En, index];
    }

    private void DisSetDataPro(string Datastr)
    {
      string str = Datastr.Substring(0, 8);
      if (str == "FFFFFFFF")
        this.textBox1.Text = "";
      else
        this.textBox1.Text = str;
    }

    private void LoadCurSetDataDisPro()
    {
      string str1;
      try
      {
        string[] strArray = Class1.ReadFileDataPro(this.GiFileName1).Split('\r');
        int num = Class1.ConFreCodeBegAddr / Class1.ConOneRowDatCt;
        str1 = Class2.AutoAdd_n_Pro(strArray[Class1.FielBegRow + num]);
      }
      catch
      {
        str1 = "\n010020A02C8102A02C8102FF0FFF2F0000202020186CDC02186CDC0275031300000006";
      }
      if (str1 == "")
        str1 = "\n010020A02C8102A02C8102FF0FFF2F0000202020186CDC02186CDC0275031300000006";
      string str2 = str1.Substring(0, 1);
      this.DisSetDataPro(!(str2 == "\n") && !(str2 == "n") ? str1.Substring(6, 64) : str1.Substring(7, 64));
    }

    private void load_WinDisplayPro() => this.LoadCurSetDataDisPro();

    private void ProgramCode_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.SetContrlAs_arrPro();
      this.label1.Text = this.lableArrName[Class1.English_En, 0];
      this.load_GroBox1_ButtonPro();
      this.load_WinDisplayPro();
    }

    private void button2_Click(object sender, EventArgs e) => this.Close();

    private void SavCodeDataPro(string CurrStr)
    {
      string[] StrData = Class1.ReadFileDataPro(this.GiFileName1).Split('\r');
      int num = Class1.ConFreCodeBegAddr / Class1.ConOneRowDatCt;
      string str1 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num]);
      string str2 = str1.Substring(0, 1);
      string str3 = !(str2 == "\n") && !(str2 == "n") ? str1.Substring(0, 6) + CurrStr + str1.Substring(14, str1.Length - 14) : str1.Substring(0, 7) + CurrStr + str1.Substring(15, str1.Length - 15);
      StrData[Class1.FielBegRow + num] = str3;
      Class1.SaveFileDataPro(this.GiFileName1, StrData);
    }

    private string StrAutoAddEndFPro(string StrTemp, byte Length)
    {
      if (StrTemp.Length < (int) Length)
      {
        int num = (int) Length - StrTemp.Length;
        for (int index = 0; index < num; ++index)
          StrTemp += "F";
      }
      return StrTemp;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string StrTemp = this.textBox1.Text;
      if (StrTemp == "")
        StrTemp = "FFFFFFFF";
      this.SavCodeDataPro(Class1.StrAutoAdd0Pro(StrTemp, (byte) 8));
      this.Close();
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool flag = Class1.DtmfKeyUseFulChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar != '\r')
        return;
      this.button1_Click(sender, (EventArgs) e);
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      if (!(this.textBox1.Text != ""))
        return;
      this.textBox1.Text = Class1.StrAutoAdd0Pro(this.textBox1.Text, (byte) 8);
    }
  }
}
