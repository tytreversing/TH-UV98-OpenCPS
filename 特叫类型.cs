// Decompiled with JetBrains decompiler
// Type: _8890DTest.特叫类型
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class 特叫类型 : Form
  {
    private string[] ConDtmfCh = new string[16]
    {
      "M1",
      "M2",
      "M3",
      "M4",
      "M5",
      "M6",
      "M7",
      "M8",
      "M9",
      "M10",
      "M11",
      "M12",
      "M13",
      "M14",
      "M15",
      "M16"
    };
    public static string[,] ConDtmfTxKind = new string[2, 3]
    {
      {
        "无",
        "ANI",
        "数传"
      },
      {
        "OFF. ",
        "ANI",
        "Send Message"
      }
    };
    public static string[,] lableArrName = new string[2, 13]
    {
      {
        "序号",
        "呼叫类型",
        " 呼叫ID",
        "数传信息",
        "     特殊呼叫",
        "首位数码时间(MS)",
        "   自动复位时间(S)",
        " 选定信道",
        "PTT ID 类型",
        " PTT ID 开始",
        "PTT ID 结束",
        "   遥晕码",
        "   遥毙码"
      },
      {
        "  No",
        "Call Type",
        "Call ID",
        " Message",
        " Specical Call",
        " First Digit(MS)",
        "Auto Reset Time(S)",
        "Select Ch",
        "PTT ID Type",
        "PTT ID Begin",
        " PTT ID End",
        "Stun Code",
        "Kill Code"
      }
    };
    public static string[,] Button_EngCh = new string[2, 2]
    {
      {
        "确定",
        "取消"
      },
      {
        "Enter",
        "Cancel"
      }
    };
    private Label[] Label_Arr;
    private ComboBox[] ComboBoxl_Arr;
    private TextBox[] TextBoxl_Arr;
    private CheckBox[] CheckBox_Arr;
    private GroupBox[] GroupBox_Arr;
    private Button[] Button_Arr;
    public int GiCurrCh;
    public int GiKind;
    public string Spilt_String = "*";
    public string OwnId_String = "";
    public string CallId_String = "";
    public string Inf_String = "";
    public int MaxLength = 4;
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private ComboBox comboBox1;
    private ComboBox comboBox2;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label4;
    private Button button1;
    private Button button2;

    public 特叫类型()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void load_GroupBox1Pro()
    {
      公共控件操作.Load_CmbBoxNPro(this.comboBox1, this.ConDtmfCh, 15);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox2, 特叫类型.ConDtmfTxKind, 特叫类型.ConDtmfTxKind.GetLength(1) - 1);
      this.textBox2.Text = this.CallId_String;
      this.comboBox1.SelectedIndex = this.GiCurrCh;
      this.comboBox1.Enabled = false;
      this.comboBox2.SelectedIndex = this.GiKind;
      this.comboBox2.Enabled = false;
      if (2 == this.GiKind)
      {
        this.textBox1.Visible = true;
        this.label4.Visible = true;
        this.textBox1.Text = Class1.GBKTOHanzi_ChangePro(this.Inf_String);
      }
      else
      {
        if (1 != this.GiKind)
          return;
        this.textBox1.Visible = false;
        this.label4.Visible = false;
      }
    }

    private void SetContrlAs_arrPro()
    {
      this.Label_Arr = new Label[5];
      this.Label_Arr[0] = this.label1;
      this.Label_Arr[1] = this.label2;
      this.Label_Arr[2] = this.label3;
      this.Label_Arr[3] = this.label4;
      this.Button_Arr = new Button[2];
      this.Button_Arr[0] = this.button1;
      this.Button_Arr[1] = this.button2;
    }

    private void load_GroBox1_LabelPro()
    {
      for (int index = 0; index <= 3; ++index)
        this.Label_Arr[index].Text = 特叫类型.lableArrName[Class1.English_En, index];
    }

    private void load_GroBox1_ButtonPro()
    {
      for (int index = 0; index <= 1; ++index)
        this.Button_Arr[index].Text = 特叫类型.Button_EngCh[Class1.English_En, index];
    }

    private void 特叫类型_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.SetContrlAs_arrPro();
      this.load_GroBox1_LabelPro();
      this.load_GroBox1_ButtonPro();
      this.Text = 特叫类型.lableArrName[Class1.English_En, 4];
      this.load_GroupBox1Pro();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.Inf_String == "")
        this.Inf_String = "313233";
      if (this.CallId_String == "")
        this.CallId_String = "001";
      if (1 == this.GiKind)
        Class1.GiDailData = this.CallId_String + this.Spilt_String + this.OwnId_String;
      else if (2 == this.GiKind)
        Class1.GiDailData = this.CallId_String + this.Spilt_String + this.Spilt_String + this.Inf_String;
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.CallId_String = this.textBox2.Text;
      this.Inf_String = this.textBox1.Text;
      this.Inf_String = Class1.hanziTOGbk_ChangePro1(this.Inf_String);
      if (this.Inf_String == "")
        this.Inf_String = "313233";
      if (this.CallId_String == "")
        this.CallId_String = "001";
      if (1 == this.GiKind)
      {
        Class1.GiDailData = this.CallId_String + this.Spilt_String + this.OwnId_String;
        Class1.GiCallId = this.CallId_String;
      }
      else if (2 == this.GiKind)
      {
        Class1.GiDailData = this.CallId_String + this.Spilt_String + this.Spilt_String + this.Inf_String;
        Class1.GiCallId = this.CallId_String;
        Class1.GiInfData = this.Inf_String;
      }
      this.Close();
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e) => this.textBox1.MaxLength = Class1.InputLengthSetPro(this.textBox1.Text, this.MaxLength);

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
      this.label3 = new Label();
      this.comboBox1 = new ComboBox();
      this.comboBox2 = new ComboBox();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.label4 = new Label();
      this.button1 = new Button();
      this.button2 = new Button();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(67, 43);
      this.label1.Name = "label1";
      this.label1.Size = new Size(35, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "序号:";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(43, 79);
      this.label2.Name = "label2";
      this.label2.Size = new Size(59, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "呼叫类型:";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(55, 115);
      this.label3.Name = "label3";
      this.label3.Size = new Size(47, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "呼号ID:";
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(121, 35);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(74, 20);
      this.comboBox1.TabIndex = 3;
      this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new Point(121, 71);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(74, 20);
      this.comboBox2.TabIndex = 4;
      this.textBox1.Location = new Point(121, 142);
      this.textBox1.MaxLength = 13;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(119, 21);
      this.textBox1.TabIndex = 5;
      this.textBox1.TextAlign = HorizontalAlignment.Center;
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.textBox2.Location = new Point(121, 106);
      this.textBox2.MaxLength = 8;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(74, 21);
      this.textBox2.TabIndex = 7;
      this.textBox2.TextAlign = HorizontalAlignment.Center;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(43, 151);
      this.label4.Name = "label4";
      this.label4.Size = new Size(59, 12);
      this.label4.TabIndex = 6;
      this.label4.Text = "数传信息:";
      this.button1.Location = new Point(45, 187);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 8;
      this.button1.Text = "确定";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(165, 187);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 9;
      this.button2.Text = "取消";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(284, 224);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.comboBox2);
      this.Controls.Add((Control) this.comboBox1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (特叫类型);
      this.Text = "DTMF特殊呼叫";
      this.Load += new EventHandler(this.特叫类型_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
