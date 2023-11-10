// Decompiled with JetBrains decompiler
// Type: _8890DTest.密码输入框
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class 密码输入框 : Form
  {
    public string GiFileName1 = "8890D_TempFile.icf";
    public int CodeTypePt = 0;
    public static string[,] CodeType = new string[2, 4]
    {
      {
        "请输入读写频密码:",
        "请输入遥毙密码:",
        "请输入遥晕密码:",
        "请输入密码:"
      },
      {
        "Enter Fre Code:",
        "Enter Kill Code:",
        "Enter Stun Code:",
        "Enter  Code:"
      }
    };
    private IContainer components = (IContainer) null;
    private Button button2;
    private Label label1;
    private TextBox textBox1;

    public 密码输入框()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
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
      string str;
      try
      {
        string[] strArray = Class1.ReadFileDataPro(this.GiFileName1).Split('\r');
        int num = Class1.ConFreCodeBegAddr / Class1.ConOneRowDatCt;
        str = Class2.AutoAdd_n_Pro(strArray[Class1.FielBegRow + num]);
      }
      catch
      {
        str = "\n010020A02C8102A02C8102FF0FFF2F0000202020186CDC02186CDC0275031300000006";
      }
      if (str == "")
        str = "\n010020A02C8102A02C8102FF0FFF2F0000202020186CDC02186CDC0275031300000006";
      this.DisSetDataPro(str.Substring(7, 64));
    }

    private void load_WinDisplayPro() => this.LoadCurSetDataDisPro();

    private void EnterCode_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.label1.Text = 密码输入框.CodeType[Class1.English_En, this.CodeTypePt];
      this.load_WinDisplayPro();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == "")
      {
        Class1.GiRightCode = "FFFFFFFF";
      }
      else
      {
        string str1 = this.textBox1.Text;
        string str2 = Class2.WannengCode();
        if (str1 == str2)
          str1 = "18105078";
        Class1.GiRightCode = str1;
      }
      this.Close();
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool flag = Class1.DtmfKeyUseFulChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar != '\r')
        return;
      this.button2_Click(sender, (EventArgs) e);
    }

    private void textBox2_Leave(object sender, EventArgs e)
    {
      if (!(this.textBox1.Text != ""))
        return;
      this.textBox1.Text = Class1.StrAutoAdd0Pro(this.textBox1.Text, (byte) 8);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void 密码输入框_FormClosed(object sender, FormClosedEventArgs e)
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
      this.button2 = new Button();
      this.label1 = new Label();
      this.textBox1 = new TextBox();
      this.SuspendLayout();
      this.button2.Location = new Point(63, 80);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 10;
      this.button2.Text = "确定";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(71, 12);
      this.label1.TabIndex = 11;
      this.label1.Text = "请输入密码:";
      this.textBox1.Location = new Point(63, 40);
      this.textBox1.MaxLength = 8;
      this.textBox1.Name = "textBox1";
      this.textBox1.PasswordChar = '*';
      this.textBox1.Size = new Size(112, 21);
      this.textBox1.TabIndex = 9;
      this.textBox1.Text = "12345678";
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.textBox1.Leave += new EventHandler(this.textBox2_Leave);
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(206, 112);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox1);
      this.Name = nameof (密码输入框);
      this.Load += new EventHandler(this.EnterCode_Load);
      this.FormClosed += new FormClosedEventHandler(this.密码输入框_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
