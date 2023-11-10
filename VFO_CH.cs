// Decompiled with JetBrains decompiler
// Type: _8890DTest.VFO_CH
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class VFO_CH : Form
  {
    private Label[] Label_Arr;
    private ComboBox[] ComboBoxl_Arr;
    private TextBox[] TextBoxl_Arr;
    private CheckBox[] CheckBox_Arr;
    private Button[] Button_Arr;
    private GroupBox[] GroupBox_Arr_P1;
    private Label[] Label_Arr_P1;
    private ComboBox[] ComboBoxl_Arr_P1;
    private TextBox[] TextBoxl_Arr_P1;
    private CheckBox[] CheckBox_Arr_P1;
    private Button[] Button_Arr_P1;
    private Label[] Label_Arr_P2;
    private ComboBox[] ComboBoxl_Arr_P2;
    private TextBox[] TextBoxl_Arr_P2;
    private CheckBox[] CheckBox_Arr_P2;
    private Button[] Button_Arr_P2;
    private GroupBox[] GroupBox_Arr_P2;
    private Label[] Label_Arr_P3;
    private ComboBox[] ComboBoxl_Arr_P3;
    private TextBox[] TextBoxl_Arr_P3;
    private CheckBox[] CheckBox_Arr_P3;
    private Button[] Button_Arr_P3;
    private GroupBox[] GroupBox_Arr_P3;
    private Label[] Label_Arr_P4;
    private ComboBox[] ComboBoxl_Arr_P4;
    private TextBox[] TextBoxl_Arr_P4;
    private CheckBox[] CheckBox_Arr_P4;
    private Button[] Button_Arr_P4;
    private GroupBox[] GroupBox_Arr_P4;
    private Label[] Label_Arr_P5;
    private ComboBox[] ComboBoxl_Arr_P5;
    private TextBox[] TextBoxl_Arr_P5;
    private CheckBox[] CheckBox_Arr_P5;
    private Button[] Button_Arr_P5;
    private GroupBox[] GroupBox_Arr_P5;
    private Label[] Label_Arr_P6;
    private ComboBox[] ComboBoxl_Arr_P6;
    private TextBox[] TextBoxl_Arr_P6;
    private CheckBox[] CheckBox_Arr_P6;
    private Button[] Button_Arr_P6;
    private GroupBox[] GroupBox_Arr_P6;
    public string GiFileName1 = "8890D_TempFile.icf";
    private string GiRxFreTemp;
    private string GiShiftFreTemp;
    private int GiCurChNum = 0;
    private int GDataChgen = 0;
    public static string[,] lableArrName = new string[2, 13]
    {
      {
        "接收频率",
        "接收亚音",
        "发射亚音",
        "扰    频",
        " 功率",
        "遇忙禁发",
        "步进",
        " 带宽",
        "可选信令",
        "DTMF PTTID",
        "5TONE PTTID",
        "  差频方向",
        "差频频率(MHZ)"
      },
      {
        "  Rx Fre",
        "  Decode",
        "  Encode",
        "Scramble",
        "Power",
        "  B_Lock",
        "Step",
        "Wide",
        " Signal",
        "DTMF PTTID",
        "5TONE PTTID",
        "Offset Dir",
        "  Offset Freq"
      }
    };
    public static string[,] GroupBox_EngCh = new string[2, 3]
    {
      {
        "信道信息",
        "模拟",
        "数字"
      },
      {
        "Chanel Inf",
        "Analog",
        "Digital"
      }
    };
    public static string[,] ChekcBox_EngCh = new string[2, 5]
    {
      {
        "倒频",
        "发射禁止",
        "脱网   ",
        "发射GPS信息    ",
        "接收GPS信息    "
      },
      {
        "Rev ",
        "Tx Inh  ",
        "Talk Off",
        "TX GPS",
        "RX GPS"
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
    private string[,] MessBoxName = new string[2, 3]
    {
      {
        "当前频率超出范围，请重新输入！[",
        "第",
        "行数据非法！"
      },
      {
        "Frequency Out Off Rang  [",
        "No:",
        "Line Data Error!"
      }
    };
    private IContainer components = (IContainer) null;
    private TabControl tabControl1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private TabPage tabPage1;
    private TabPage tabPage6;
    private GroupBox groupBox1;
    private Label label197;
    private ComboBox comboBox155;
    private Button button2;
    private ComboBox comboBox11;
    private Button button1;
    private Label label14;
    private Label label11;
    private TextBox textBox2;
    private CheckBox checkBox1;
    private ComboBox comboBox10;
    private Label label12;
    private ComboBox comboBox9;
    private ComboBox comboBox8;
    private Label label6;
    private Label label2;
    private CheckBox checkBox5;
    private CheckBox checkBox4;
    private Label label13;
    private CheckBox checkBox3;
    private CheckBox checkBox2;
    private Label label1;
    private Label label3;
    private Label label4;
    private ComboBox comboBox6;
    private ComboBox comboBox7;
    private Label label5;
    private ComboBox comboBox5;
    private Label label7;
    private ComboBox comboBox4;
    private Label label8;
    private ComboBox comboBox3;
    private Label label9;
    private ComboBox comboBox2;
    private Label label10;
    private ComboBox comboBox1;
    private TextBox textBox1;
    private Button button9;
    private Button button10;

    public VFO_CH()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void SetContrlAs_arr_P1Pro()
    {
      this.Label_Arr = new Label[23];
      this.Label_Arr[0] = this.label1;
      this.Label_Arr[1] = this.label3;
      this.Label_Arr[2] = this.label4;
      this.Label_Arr[3] = this.label197;
      this.Label_Arr[4] = this.label5;
      this.Label_Arr[5] = this.label2;
      this.Label_Arr[6] = this.label7;
      this.Label_Arr[7] = this.label8;
      this.Label_Arr[8] = this.label9;
      this.Label_Arr[9] = this.label12;
      this.Label_Arr[10] = this.label6;
      this.Label_Arr[11] = this.label14;
      this.Label_Arr[12] = this.label11;
      this.ComboBoxl_Arr = new ComboBox[13];
      this.ComboBoxl_Arr[0] = this.comboBox1;
      this.ComboBoxl_Arr[1] = this.comboBox2;
      this.ComboBoxl_Arr[2] = this.comboBox3;
      this.ComboBoxl_Arr[3] = this.comboBox5;
      this.ComboBoxl_Arr[4] = this.comboBox6;
      this.ComboBoxl_Arr[5] = this.comboBox7;
      this.ComboBoxl_Arr[6] = this.comboBox8;
      this.ComboBoxl_Arr[7] = this.comboBox9;
      this.ComboBoxl_Arr[8] = this.comboBox10;
      this.ComboBoxl_Arr[9] = this.comboBox4;
      this.ComboBoxl_Arr[10] = this.comboBox11;
      this.ComboBoxl_Arr[11] = this.comboBox155;
      this.TextBoxl_Arr = new TextBox[3];
      this.TextBoxl_Arr[0] = this.textBox1;
      this.TextBoxl_Arr[1] = this.textBox2;
      this.CheckBox_Arr = new CheckBox[6];
      this.CheckBox_Arr[0] = this.checkBox3;
      this.CheckBox_Arr[1] = this.checkBox4;
      this.CheckBox_Arr[2] = this.checkBox2;
      this.CheckBox_Arr[3] = this.checkBox5;
      this.CheckBox_Arr[4] = this.checkBox1;
      this.Button_Arr = new Button[2];
      this.Button_Arr[0] = this.button10;
      this.Button_Arr[1] = this.button9;
      this.GroupBox_Arr_P1 = new GroupBox[1];
      this.GroupBox_Arr_P1[0] = this.groupBox1;
    }

    private void SetContrlAs_arrPro() => this.SetContrlAs_arr_P1Pro();

    private void TextBoxResPro(TextBox Textbo, int length, string name)
    {
      Textbo.Text = name;
      Textbo.MaxLength = length;
      Textbo.TextAlign = HorizontalAlignment.Center;
      Textbo.Visible = true;
    }

    private void ComBoxResPro(ComboBox ComboBo, int Index)
    {
      ComboBo.SelectedIndex = Index;
      ComboBo.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBo.Visible = true;
    }

    private void load_GroBoxX_textBoxPro(TextBox[] TextBoxl_Arr_X)
    {
      this.TextBoxResPro(TextBoxl_Arr_X[0], 9, "430.00000");
      this.TextBoxResPro(TextBoxl_Arr_X[1], 9, "0.60000");
      TextBoxl_Arr_X[1].Enabled = false;
    }

    private void load_GroBoxX_LabelPro(Label[] Label_Arr_X)
    {
      for (int index = 0; index <= 12; ++index)
        Label_Arr_X[index].Text = VFO_CH.lableArrName[Class1.English_En, index];
    }

    private void load_CmbBoxNPro(ComboBox cmbHelp, string[] StrArr, int Number)
    {
      for (int index = 0; index <= Number; ++index)
        cmbHelp.Items.Add((object) StrArr[index]);
      this.ComBoxResPro(cmbHelp, 0);
    }

    private void load_GroBoxX_comboBoxPro(ComboBox[] ComboBoxl_Arr_X)
    {
      string[] StrArr = new string[104];
      公共控件操作.Load_CmbBoxNPro(ComboBoxl_Arr_X[0], Class1.CtcTone, 51);
      for (int index = 0; index < Class1.DcsTone.Length; ++index)
        StrArr[index] = Class1.DcsTone[index] + "N";
      公共控件操作.Load_CmbBoxNPro(ComboBoxl_Arr_X[0], StrArr, 103);
      for (int index = 0; index < Class1.DcsTone.Length; ++index)
        StrArr[index] = Class1.DcsTone[index] + "I";
      公共控件操作.Load_CmbBoxNPro(ComboBoxl_Arr_X[0], StrArr, 103);
      ComboBoxl_Arr_X[0].DropDownStyle = ComboBoxStyle.DropDown;
      ComboBoxl_Arr_X[0].MaxLength = 5;
      公共控件操作.Load_CmbBoxNPro(ComboBoxl_Arr_X[1], Class1.CtcTone, 51);
      for (int index = 0; index < Class1.DcsTone.Length; ++index)
        StrArr[index] = Class1.DcsTone[index] + "N";
      公共控件操作.Load_CmbBoxNPro(ComboBoxl_Arr_X[1], StrArr, 103);
      for (int index = 0; index < Class1.DcsTone.Length; ++index)
        StrArr[index] = Class1.DcsTone[index] + "I";
      公共控件操作.Load_CmbBoxNPro(ComboBoxl_Arr_X[1], StrArr, 103);
      ComboBoxl_Arr_X[1].DropDownStyle = ComboBoxStyle.DropDown;
      ComboBoxl_Arr_X[1].MaxLength = 3;
      公共控件操作.load_CmbBoxNProEng_Ch1(ComboBoxl_Arr_X[2], Class1.TxPower_EngCh, Class1.TxPower_EngCh.GetLength(1) - 1);
      this.load_CmbBoxNPro(ComboBoxl_Arr_X[9], Class1.ConStep, Class1.ConStep.Length - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(ComboBoxl_Arr_X[3], Class1.WideNar_EngCh, Class1.WideNar_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(ComboBoxl_Arr_X[5], Class1.Spkind_EngCh, Class1.Spkind_EngCh.GetLength(1) - 1);
      ComboBoxl_Arr_X[5].Visible = false;
      公共控件操作.load_CmbBoxNProEng_Ch1(ComboBoxl_Arr_X[11], Class1.ScrChSet_EngCh, Class1.ScrChSet_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(ComboBoxl_Arr_X[6], Class1.PttKind_EngCh, Class1.PttKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(ComboBoxl_Arr_X[7], Class1.PttKind_EngCh, Class1.PttKind_EngCh.GetLength(1) - 1);
      ComboBoxl_Arr_X[7].Visible = false;
      公共控件操作.load_CmbBoxNProEng_Ch1(ComboBoxl_Arr_X[8], Class1.BusyKind_EngCh, Class1.BusyKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(ComboBoxl_Arr_X[4], Class1.OptSig_EngCh, Class1.OptSig_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(ComboBoxl_Arr_X[10], Class1.OffsetDir_EngCh, Class1.OffsetDir_EngCh.GetLength(1) - 1);
    }

    private void load_GroBoX_CheckBoxPro(CheckBox[] CheckBox_Arr_X)
    {
      for (int index = 0; index <= 4; ++index)
        CheckBox_Arr_X[index].Text = VFO_CH.ChekcBox_EngCh[Class1.English_En, index];
      if (Class1.GpsEable == "Enable")
      {
        CheckBox_Arr_X[4].Visible = true;
        CheckBox_Arr_X[3].Visible = true;
      }
      else
      {
        CheckBox_Arr_X[4].Visible = false;
        CheckBox_Arr_X[3].Visible = false;
      }
    }

    private void load_GroBoX_ButtonPro(Button[] Button_Arr_X)
    {
      for (int index = 0; index <= 1; ++index)
        Button_Arr_X[index].Text = VFO_CH.Button_EngCh[Class1.English_En, index];
    }

    private void load_GroupBox1Pro()
    {
      this.load_GroBoxX_textBoxPro(this.TextBoxl_Arr);
      this.load_GroBoxX_LabelPro(this.Label_Arr);
      this.load_GroBoxX_comboBoxPro(this.ComboBoxl_Arr);
      this.load_GroBoX_CheckBoxPro(this.CheckBox_Arr);
      this.load_GroBoX_ButtonPro(this.Button_Arr);
      this.tabPage1.Text = "A_150M";
      this.tabPage2.Text = "A_245M";
      this.tabPage3.Text = "A_450M";
      this.tabPage4.Text = "B_150M";
      this.tabPage5.Text = "B_245M";
      this.tabPage6.Text = "B_450M";
      if (Class1.FreBandData[0, 0] != 0)
        ;
      if (Class1.FreBandData[1, 0] != 0)
        ;
      if (Class1.FreBandData[2, 0] != 0)
        ;
    }

    private void DisCurrCh_XPro(
      string Datastr,
      int i,
      ComboBox[] ComboBoxl_Arr_X,
      TextBox[] TextBoxl_Arr_X,
      CheckBox[] CheckBox_Arr_X)
    {
      for (int index = 0; index <= 4; ++index)
        CheckBox_Arr_X[index].Checked = false;
      bool flag = false;
      if (Datastr == "")
      {
        flag = true;
        Datastr = "A4CB9702A4CB9702FF0FFF0F00040620202020202020202020202020202020";
      }
      string StrTemp1 = Class2.StringChgPro(Datastr.Substring(0, 8), 4);
      string StrTemp2 = Class2.StringChgPro(Datastr.Substring(8, 8), 4);
      string StrTemp3 = Class2.StringChgPro(Datastr.Substring(16, 4), 2);
      string StrTemp4 = Class2.StringChgPro(Datastr.Substring(20, 4), 2);
      string str1 = Datastr.Substring(24, 2);
      string str2 = Datastr.Substring(26, 2);
      string str3 = Datastr.Substring(28, 2);
      string str4 = Datastr.Substring(30, 8);
      try
      {
        int int32_1 = Convert.ToInt32(StrTemp1, 16);
        int int32_2 = Convert.ToInt32(StrTemp2, 16);
        int int32_3 = Convert.ToInt32(str4, 16);
        int int32_4 = Convert.ToInt32(StrTemp3, 16);
        int int32_5 = Convert.ToInt32(StrTemp4, 16);
        string str5 = Class2.StringChgFrePro(StrTemp1, 5);
        TextBoxl_Arr_X[0].Text = str5;
        Class2.StringChgFrePro(StrTemp2, 5);
        if (int32_1 > int32_2)
        {
          ComboBoxl_Arr_X[10].SelectedIndex = 1;
          double num1 = (double) (int32_1 - int32_2) / 100000.0;
          if (num1 > 40.0)
            num1 = 0.6;
          string StrTemp5 = num1.ToString();
          int num2 = Class1.LookStringPt(StrTemp5, ".");
          if (num2 < 0)
            num2 = Class1.LookStringPt(StrTemp5, ",");
          string str6 = num2 < 0 ? StrTemp5 + ".00000" : (StrTemp5.Substring(0, num2) + Class1.StrAutoAddEnd0Pro(StrTemp5.Substring(num2, StrTemp5.Length - num2), (byte) 6)).Replace(",", ".");
          TextBoxl_Arr_X[1].Text = str6;
        }
        else if (int32_1 < int32_2)
        {
          ComboBoxl_Arr_X[10].SelectedIndex = 2;
          double num3 = (double) (int32_2 - int32_1) / 100000.0;
          if (num3 > 40.0)
            num3 = 0.6;
          string StrTemp6 = num3.ToString();
          int num4 = Class1.LookStringPt(StrTemp6, ".");
          if (num4 < 0)
            num4 = Class1.LookStringPt(StrTemp6, ",");
          string str7 = num4 < 0 ? StrTemp6 + ".00000" : (StrTemp6.Substring(0, num4) + Class1.StrAutoAddEnd0Pro(StrTemp6.Substring(num4, StrTemp6.Length - num4), (byte) 6)).Replace(",", ".");
          TextBoxl_Arr_X[1].Text = str7;
        }
        else
        {
          ComboBoxl_Arr_X[10].SelectedIndex = 0;
          double num5 = (double) int32_3;
          if (num5 > 40.0)
            num5 = 0.6;
          string StrTemp7 = num5.ToString();
          int num6 = Class1.LookStringPt(StrTemp7, ".");
          if (num6 < 0)
            num6 = Class1.LookStringPt(StrTemp7, ",");
          string str8 = num6 < 0 ? StrTemp7 + ".00000" : (StrTemp7.Substring(0, num6) + Class1.StrAutoAddEnd0Pro(StrTemp7.Substring(num6, StrTemp7.Length - num6), (byte) 6)).Replace(",", ".");
          TextBoxl_Arr_X[1].Text = str8;
        }
        int num7 = (int32_4 & 61440) >> 12;
        ComboBoxl_Arr_X[11].SelectedIndex = num7;
        if ((int32_5 & 4096) >> 12 != 0)
          CheckBox_Arr_X[4].Checked = true;
        int num8 = int32_5 & 49152;
        string str9 = (num8 & 16384) == 0 ? Class2.Rx_TxChgToSubDataPro(StrTemp3, 0) : Class2.Rx_TxChgToSubDataPro(StrTemp3, 1);
        ComboBoxl_Arr_X[0].Text = str9;
        string str10 = (num8 & 32768) == 0 ? Class2.Rx_TxChgToSubDataPro(StrTemp4, 0) : Class2.Rx_TxChgToSubDataPro(StrTemp4, 1);
        ComboBoxl_Arr_X[1].Text = str10;
        int int32_6 = Convert.ToInt32(str1, 16);
        if ((int32_6 & 1) != 0)
          CheckBox_Arr_X[1].Checked = true;
        if ((int32_6 & 2) != 0)
        {
          CheckBox_Arr_X[0].Checked = true;
          CheckBox_Arr_X[2].Checked = false;
        }
        int num9 = (int32_6 & 12) >> 2;
        ComboBoxl_Arr_X[8].SelectedIndex = num9;
        int num10 = (int32_6 & 48) >> 4;
        ComboBoxl_Arr_X[3].SelectedIndex = num10;
        int num11 = (int32_6 & 192) >> 6;
        ComboBoxl_Arr_X[2].SelectedIndex = num11;
        int int32_7 = Convert.ToInt32(str2, 16);
        if ((int32_7 & 1) != 0)
          CheckBox_Arr_X[3].Checked = true;
        if ((int32_7 & 2) != 0)
        {
          CheckBox_Arr_X[2].Checked = true;
          CheckBox_Arr_X[0].Checked = false;
        }
        int num12 = (int32_7 & 24) >> 3;
        ComboBoxl_Arr_X[4].SelectedIndex = num12;
        int num13 = (int32_7 & 224) >> 5;
        ComboBoxl_Arr_X[5].SelectedIndex = num13;
        int int32_8 = Convert.ToInt32(str3, 16);
        int num14 = int32_8 & 15;
        ComboBoxl_Arr_X[9].SelectedIndex = num14;
        int num15 = (int32_8 & 48) >> 4;
        ComboBoxl_Arr_X[6].SelectedIndex = num15;
        int num16 = (int32_8 & 192) >> 6;
        ComboBoxl_Arr_X[7].SelectedIndex = num16;
        if (!flag)
          return;
        TextBoxl_Arr_X[0].Text = "";
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 1] + (object) i + this.MessBoxName[Class1.English_En, 2], Class1.RadioName);
      }
    }

    private void LoadCurChDataDisPro()
    {
      int i = this.GiCurChNum + 204;
      string Datastr;
      try
      {
        Datastr = Class2.GetOneChStringPro(Class1.ReadFileDataPro(this.GiFileName1).Split('\r'), i);
      }
      catch
      {
        Datastr = "";
      }
      this.DisCurrCh_XPro(Datastr, i, this.ComboBoxl_Arr, this.TextBoxl_Arr, this.CheckBox_Arr);
    }

    private void VFO_CH_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.SetContrlAs_arrPro();
      this.load_GroupBox1Pro();
      this.GiCurChNum = this.tabControl1.SelectedIndex;
      this.LoadCurChDataDisPro();
    }

    private string ChgChStringXPro(
      ComboBox[] ComboBoxl_Arr_X,
      TextBox[] TextBoxl_Arr_X,
      CheckBox[] CheckBox_Arr_X)
    {
      Class1.ReadFileDataPro(this.GiFileName1).Split('\r');
      string[] strArray = new string[11];
      strArray[0] = Class2.ChgRxFreToDataPro(TextBoxl_Arr_X[0].Text);
      strArray[10] = Class2.ChgRxFreToDataPro(TextBoxl_Arr_X[1].Text);
      if (ComboBoxl_Arr_X[10].SelectedIndex == 0)
      {
        strArray[1] = strArray[0];
        strArray[10] = strArray[10] + "0000";
      }
      else if (ComboBoxl_Arr_X[10].SelectedIndex == 1)
      {
        double num = (double) (Convert.ToInt32(Class2.StringChgPro(strArray[0], 4), 16) - Convert.ToInt32(Class2.StringChgPro(strArray[10], 4), 16)) / 100000.0;
        strArray[1] = num.ToString();
        strArray[1] = Class2.ChgRxFreToDataPro(strArray[1]);
        strArray[10] = strArray[10] + "0000";
      }
      else if (ComboBoxl_Arr_X[10].SelectedIndex == 2)
      {
        double num = (double) (Convert.ToInt32(Class2.StringChgPro(strArray[0], 4), 16) + Convert.ToInt32(Class2.StringChgPro(strArray[10], 4), 16)) / 100000.0;
        strArray[1] = num.ToString();
        strArray[1] = Class2.ChgRxFreToDataPro(strArray[1]);
        strArray[10] = strArray[10] + "0000";
      }
      strArray[2] = ComboBoxl_Arr_X[0].Text;
      strArray[3] = ComboBoxl_Arr_X[1].Text;
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      if (CheckBox_Arr_X[4].Checked)
        num2 = 1;
      string str1 = strArray[2].Substring(strArray[2].Length - 1, 1);
      if (str1 == "I" || str1 == "i")
        num3 = 1;
      string str2 = strArray[3].Substring(strArray[3].Length - 1, 1);
      if (str2 == "I" || str2 == "i")
        num4 = 1;
      int num5 = num2 << 4;
      string hexStr1 = Class1.DataToHexStr((long) (num1 | num5 | num3 << 6 | num4 << 7));
      strArray[2] = Class2.ChgSubToDataPro(strArray[2]);
      strArray[3] = Class2.ChgSubToDataPro(strArray[3]);
      string hexStr2 = Class1.DataToHexStr((long) (Convert.ToInt32(strArray[3].Substring(2, 2), 16) & 15 | ComboBoxl_Arr_X[11].SelectedIndex << 4));
      int num6 = 0;
      if (CheckBox_Arr_X[1].Checked)
        num6 = 1;
      int num7 = 0;
      if (CheckBox_Arr_X[0].Checked)
        num7 = 1;
      int selectedIndex1 = ComboBoxl_Arr_X[8].SelectedIndex;
      int selectedIndex2 = ComboBoxl_Arr_X[3].SelectedIndex;
      int selectedIndex3 = ComboBoxl_Arr_X[2].SelectedIndex;
      string hexStr3 = Class1.DataToHexStr((long) (num6 | num7 << 1 | selectedIndex1 << 2 | selectedIndex2 << 4 | selectedIndex3 << 6));
      int num8 = 0;
      if (CheckBox_Arr_X[3].Checked)
        num8 = 1;
      int num9 = 0;
      if (CheckBox_Arr_X[2].Checked)
        num9 = 1;
      int num10 = 0;
      int selectedIndex4 = ComboBoxl_Arr_X[4].SelectedIndex;
      int selectedIndex5 = ComboBoxl_Arr_X[5].SelectedIndex;
      string hexStr4 = Class1.DataToHexStr((long) (num8 | num9 << 1 | num10 << 2 | selectedIndex4 << 3 | selectedIndex5 << 5));
      string hexStr5 = Class1.DataToHexStr((long) (ComboBoxl_Arr_X[9].SelectedIndex | ComboBoxl_Arr_X[6].SelectedIndex << 4 | ComboBoxl_Arr_X[7].SelectedIndex << 6));
      strArray[0] = strArray[0] + strArray[1] + strArray[2].Substring(0, 2) + hexStr2.Substring(0, 1) + strArray[2].Substring(3, 1) + strArray[3].Substring(0, 2) + hexStr1.Substring(0, 1) + strArray[3].Substring(3, 1) + hexStr3 + hexStr4 + hexStr5 + strArray[10];
      return Class1.Chga_z_ToA_Z(strArray[0]);
    }

    private void ChanelDataSavePro()
    {
      if (this.GDataChgen == 0)
        return;
      int i = this.GiCurChNum + 204;
      Class1.SavOneChgDatPro(this.ChgChStringXPro(this.ComboBoxl_Arr, this.TextBoxl_Arr, this.CheckBox_Arr), i, this.GiFileName1);
      this.GDataChgen = 0;
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.GDataChgen = 1;
      this.ChanelDataSavePro();
      this.GiCurChNum = this.tabControl1.SelectedIndex;
      int index = this.GiCurChNum % 3;
      if (Class1.FreBandData[index, 0] == 0)
        this.groupBox1.Enabled = false;
      else
        this.groupBox1.Enabled = true;
      this.LoadCurChDataDisPro();
      this.GDataChgen = 0;
    }

    private void button10_Click(object sender, EventArgs e)
    {
      this.GDataChgen = 1;
      this.ChanelDataSavePro();
      this.Close();
    }

    private void button9_Click(object sender, EventArgs e) => this.Close();

    private void textBoxX_Enter(object sender, EventArgs e, TextBox[] TextBoxl_Arr_X, int FreBand)
    {
      this.GiRxFreTemp = TextBoxl_Arr_X[0].Text;
      if (!(this.GiRxFreTemp == ""))
        return;
      if (FreBand == 0 || FreBand == 2)
        this.GiRxFreTemp = "136.02500";
      else if (FreBand == 1 || FreBand == 3)
        this.GiRxFreTemp = "435.02500";
    }

    private void textBox1_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.TextBoxl_Arr, 0);

    private void textBoxX_KeyPress(
      object sender,
      KeyPressEventArgs e,
      TextBox[] TextBoxl_Arr_X,
      Button[] Button_Arr_X,
      int FreBand)
    {
      string str = "";
      int[] numArray1 = new int[3];
      int[] numArray2 = new int[3];
      int[] numArray3 = new int[3];
      int[] numArray4 = new int[3];
      bool flag = Class1.KeyUseFul0_9ChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar != '\r')
        return;
      if (Class2.DataUseFulFreChk(TextBoxl_Arr_X[0].Text, 0) == "BandOver")
      {
        numArray1[0] = Class1.FreBandData[0, 0] / 100000;
        numArray2[0] = Class1.FreBandData[0, 1] / 100000;
        numArray3[0] = Class1.FreBandData[0, 2] / 100000;
        numArray4[0] = Class1.FreBandData[0, 3] / 100000;
        numArray1[1] = Class1.FreBandData[1, 0] / 100000;
        numArray2[1] = Class1.FreBandData[1, 1] / 100000;
        numArray3[1] = Class1.FreBandData[1, 2] / 100000;
        numArray4[1] = Class1.FreBandData[1, 3] / 100000;
        numArray1[2] = Class1.FreBandData[2, 0] / 100000;
        numArray2[2] = Class1.FreBandData[2, 1] / 100000;
        numArray3[2] = Class1.FreBandData[2, 2] / 100000;
        numArray4[2] = Class1.FreBandData[2, 3] / 100000;
        if (FreBand == 0 || 2 == FreBand)
          str = this.MessBoxName[Class1.English_En, 0] + (object) numArray1[0] + "M," + (object) numArray2[0] + "M]";
        else if (1 == FreBand || 3 == FreBand)
          str = this.MessBoxName[Class1.English_En, 0] + (object) numArray1[2] + "M," + (object) numArray2[2] + "M]";
        TextBoxl_Arr_X[0].Text = this.GiRxFreTemp;
        TextBoxl_Arr_X[0].Focus();
      }
      else
        Button_Arr_X[0].Focus();
    }

    private void textBoxX_Leave(object sender, EventArgs e, TextBox[] TextBoxl_Arr_X, int FreBand)
    {
      string text = TextBoxl_Arr_X[0].Text;
      int[] numArray1 = new int[3];
      int[] numArray2 = new int[3];
      int[] numArray3 = new int[3];
      int[] numArray4 = new int[3];
      string str1 = Class2.DataUseFulFreChk5(text, 0, FreBand);
      if (str1 == "BandOver")
      {
        numArray1[0] = Class1.FreBandData[FreBand, 0] / 100000;
        numArray2[0] = Class1.FreBandData[FreBand, 1] / 100000;
        numArray3[0] = Class1.FreBandData[FreBand, 2] / 100000;
        numArray4[0] = Class1.FreBandData[FreBand, 3] / 100000;
        int num = (int) MessageBox.Show("当前频率超出范围，请重新输入！[" + (object) numArray1[0] + "M," + (object) numArray2[0] + "M]", Class1.RadioName);
        TextBoxl_Arr_X[0].Text = this.GiRxFreTemp;
        TextBoxl_Arr_X[0].Focus();
      }
      else
      {
        string str2 = str1.Replace(",", ".");
        TextBoxl_Arr_X[0].Text = str2;
        if (str2 == "")
        {
          string giRxFreTemp = this.GiRxFreTemp;
          TextBoxl_Arr_X[0].Text = giRxFreTemp;
        }
      }
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      int FreBand = this.GiCurChNum % 3;
      this.textBoxX_Leave(sender, e, this.TextBoxl_Arr, FreBand);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.tabPage2 = new TabPage();
      this.tabPage3 = new TabPage();
      this.tabPage4 = new TabPage();
      this.tabPage5 = new TabPage();
      this.tabPage6 = new TabPage();
      this.groupBox1 = new GroupBox();
      this.label197 = new Label();
      this.comboBox155 = new ComboBox();
      this.button2 = new Button();
      this.comboBox11 = new ComboBox();
      this.button1 = new Button();
      this.label14 = new Label();
      this.label11 = new Label();
      this.textBox2 = new TextBox();
      this.checkBox1 = new CheckBox();
      this.comboBox10 = new ComboBox();
      this.label12 = new Label();
      this.comboBox9 = new ComboBox();
      this.comboBox8 = new ComboBox();
      this.label6 = new Label();
      this.label2 = new Label();
      this.checkBox5 = new CheckBox();
      this.checkBox4 = new CheckBox();
      this.label13 = new Label();
      this.checkBox3 = new CheckBox();
      this.checkBox2 = new CheckBox();
      this.label1 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.comboBox6 = new ComboBox();
      this.comboBox7 = new ComboBox();
      this.label5 = new Label();
      this.comboBox5 = new ComboBox();
      this.label7 = new Label();
      this.comboBox4 = new ComboBox();
      this.label8 = new Label();
      this.comboBox3 = new ComboBox();
      this.label9 = new Label();
      this.comboBox2 = new ComboBox();
      this.label10 = new Label();
      this.comboBox1 = new ComboBox();
      this.textBox1 = new TextBox();
      this.button9 = new Button();
      this.button10 = new Button();
      this.tabControl1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Controls.Add((Control) this.tabPage4);
      this.tabControl1.Controls.Add((Control) this.tabPage5);
      this.tabControl1.Controls.Add((Control) this.tabPage6);
      this.tabControl1.Font = new Font("宋体", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.tabControl1.Location = new Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(623, 47);
      this.tabControl1.TabIndex = 0;
      this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
      this.tabPage1.Location = new Point(4, 29);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(615, 14);
      this.tabPage1.TabIndex = 5;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage2.Location = new Point(4, 29);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(615, 14);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.tabPage3.Location = new Point(4, 29);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(615, 14);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "tabPage3";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.tabPage4.Location = new Point(4, 29);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(615, 14);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "tabPage4";
      this.tabPage4.UseVisualStyleBackColor = true;
      this.tabPage5.Location = new Point(4, 29);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new Padding(3);
      this.tabPage5.Size = new Size(615, 14);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "tabPage5";
      this.tabPage5.UseVisualStyleBackColor = true;
      this.tabPage6.Location = new Point(4, 29);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Padding = new Padding(3);
      this.tabPage6.Size = new Size(615, 14);
      this.tabPage6.TabIndex = 6;
      this.tabPage6.Text = "tabPage6";
      this.tabPage6.UseVisualStyleBackColor = true;
      this.groupBox1.Controls.Add((Control) this.label197);
      this.groupBox1.Controls.Add((Control) this.comboBox155);
      this.groupBox1.Controls.Add((Control) this.button2);
      this.groupBox1.Controls.Add((Control) this.comboBox11);
      this.groupBox1.Controls.Add((Control) this.button1);
      this.groupBox1.Controls.Add((Control) this.label14);
      this.groupBox1.Controls.Add((Control) this.label11);
      this.groupBox1.Controls.Add((Control) this.textBox2);
      this.groupBox1.Controls.Add((Control) this.checkBox1);
      this.groupBox1.Controls.Add((Control) this.comboBox10);
      this.groupBox1.Controls.Add((Control) this.label12);
      this.groupBox1.Controls.Add((Control) this.comboBox9);
      this.groupBox1.Controls.Add((Control) this.comboBox8);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.checkBox5);
      this.groupBox1.Controls.Add((Control) this.checkBox4);
      this.groupBox1.Controls.Add((Control) this.label13);
      this.groupBox1.Controls.Add((Control) this.checkBox3);
      this.groupBox1.Controls.Add((Control) this.checkBox2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.comboBox6);
      this.groupBox1.Controls.Add((Control) this.comboBox7);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.comboBox5);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.comboBox4);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.comboBox3);
      this.groupBox1.Controls.Add((Control) this.label9);
      this.groupBox1.Controls.Add((Control) this.comboBox2);
      this.groupBox1.Controls.Add((Control) this.label10);
      this.groupBox1.Controls.Add((Control) this.comboBox1);
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Location = new Point(4, 53);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(615, 258);
      this.groupBox1.TabIndex = 43;
      this.groupBox1.TabStop = false;
      this.label197.AutoSize = true;
      this.label197.Location = new Point(258, 55);
      this.label197.Name = "label197";
      this.label197.Size = new Size(53, 12);
      this.label197.TabIndex = 75;
      this.label197.Text = "扰频信道";
      this.comboBox155.FormattingEnabled = true;
      this.comboBox155.Location = new Point(320, 47);
      this.comboBox155.Name = "comboBox155";
      this.comboBox155.Size = new Size(100, 20);
      this.comboBox155.TabIndex = 76;
      this.button2.Location = new Point(669, 208);
      this.button2.Name = "button2";
      this.button2.Size = new Size(72, 24);
      this.button2.TabIndex = 47;
      this.button2.Text = "取消";
      this.button2.UseVisualStyleBackColor = true;
      this.comboBox11.FormattingEnabled = true;
      this.comboBox11.Location = new Point(320, 152);
      this.comboBox11.Name = "comboBox11";
      this.comboBox11.Size = new Size(100, 20);
      this.comboBox11.TabIndex = 74;
      this.button1.Location = new Point(669, 173);
      this.button1.Name = "button1";
      this.button1.Size = new Size(72, 24);
      this.button1.TabIndex = 46;
      this.button1.Text = "确定";
      this.button1.UseVisualStyleBackColor = true;
      this.label14.AutoSize = true;
      this.label14.Location = new Point(246, 160);
      this.label14.Name = "label14";
      this.label14.Size = new Size(65, 12);
      this.label14.TabIndex = 72;
      this.label14.Text = "  差频方向";
      this.label11.AutoSize = true;
      this.label11.Location = new Point(228, 195);
      this.label11.Name = "label11";
      this.label11.Size = new Size(83, 12);
      this.label11.TabIndex = 69;
      this.label11.Text = "差频频率(MHZ)";
      this.textBox2.Location = new Point(320, 186);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(100, 21);
      this.textBox2.TabIndex = 70;
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(625, 38);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(90, 16);
      this.checkBox1.TabIndex = 68;
      this.checkBox1.Text = "接收GPS信息";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.Visible = false;
      this.comboBox10.FormattingEnabled = true;
      this.comboBox10.Location = new Point(320, 82);
      this.comboBox10.Name = "comboBox10";
      this.comboBox10.Size = new Size(100, 20);
      this.comboBox10.TabIndex = 64;
      this.label12.AutoSize = true;
      this.label12.Location = new Point(246, 20);
      this.label12.Name = "label12";
      this.label12.Size = new Size(65, 12);
      this.label12.TabIndex = 53;
      this.label12.Text = "DTMF PTTID";
      this.comboBox9.FormattingEnabled = true;
      this.comboBox9.Location = new Point(725, 160);
      this.comboBox9.Name = "comboBox9";
      this.comboBox9.Size = new Size(60, 20);
      this.comboBox9.TabIndex = 63;
      this.comboBox9.Visible = false;
      this.comboBox8.FormattingEnabled = true;
      this.comboBox8.Location = new Point(320, 12);
      this.comboBox8.Name = "comboBox8";
      this.comboBox8.Size = new Size(100, 20);
      this.comboBox8.TabIndex = 62;
      this.label6.AutoSize = true;
      this.label6.Location = new Point(642, 171);
      this.label6.Name = "label6";
      this.label6.Size = new Size(71, 12);
      this.label6.TabIndex = 54;
      this.label6.Text = "5TONE PTTID";
      this.label6.Visible = false;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(258, 90);
      this.label2.Name = "label2";
      this.label2.Size = new Size(53, 12);
      this.label2.TabIndex = 55;
      this.label2.Text = "遇忙禁发";
      this.checkBox5.AutoSize = true;
      this.checkBox5.Location = new Point(620, 19);
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.Size = new Size(90, 16);
      this.checkBox5.TabIndex = 61;
      this.checkBox5.Text = "发射GPS信息";
      this.checkBox5.UseVisualStyleBackColor = true;
      this.checkBox5.Visible = false;
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new Point(638, 106);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new Size(72, 16);
      this.checkBox4.TabIndex = 60;
      this.checkBox4.Text = "发射禁止";
      this.checkBox4.UseVisualStyleBackColor = true;
      this.checkBox4.Visible = false;
      this.label13.AutoSize = true;
      this.label13.Location = new Point(680, 53);
      this.label13.Name = "label13";
      this.label13.Size = new Size(0, 12);
      this.label13.TabIndex = 56;
      this.label13.Visible = false;
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new Point(638, 71);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new Size(48, 16);
      this.checkBox3.TabIndex = 59;
      this.checkBox3.Text = "倒频";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox3.Visible = false;
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new Point(638, 141);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(54, 16);
      this.checkBox2.TabIndex = 58;
      this.checkBox2.Text = "脱 网";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.Visible = false;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(34, 20);
      this.label1.Name = "label1";
      this.label1.Size = new Size(53, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "接收频率";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(34, 55);
      this.label3.Name = "label3";
      this.label3.Size = new Size(53, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "接收亚音";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(34, 90);
      this.label4.Name = "label4";
      this.label4.Size = new Size(53, 12);
      this.label4.TabIndex = 3;
      this.label4.Text = "发射亚音";
      this.comboBox6.FormattingEnabled = true;
      this.comboBox6.Location = new Point(105, 187);
      this.comboBox6.Name = "comboBox6";
      this.comboBox6.Size = new Size(100, 20);
      this.comboBox6.TabIndex = 35;
      this.comboBox7.FormattingEnabled = true;
      this.comboBox7.Location = new Point(105, 222);
      this.comboBox7.Name = "comboBox7";
      this.comboBox7.Size = new Size(100, 20);
      this.comboBox7.TabIndex = 36;
      this.comboBox7.Visible = false;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(52, 125);
      this.label5.Name = "label5";
      this.label5.Size = new Size(35, 12);
      this.label5.TabIndex = 4;
      this.label5.Text = " 功率";
      this.comboBox5.FormattingEnabled = true;
      this.comboBox5.Location = new Point(105, 152);
      this.comboBox5.Name = "comboBox5";
      this.comboBox5.Size = new Size(100, 20);
      this.comboBox5.TabIndex = 34;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(282, 125);
      this.label7.Name = "label7";
      this.label7.Size = new Size(29, 12);
      this.label7.TabIndex = 6;
      this.label7.Text = "步进";
      this.comboBox4.FormattingEnabled = true;
      this.comboBox4.Location = new Point(320, 117);
      this.comboBox4.Name = "comboBox4";
      this.comboBox4.Size = new Size(100, 20);
      this.comboBox4.TabIndex = 33;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(58, 160);
      this.label8.Name = "label8";
      this.label8.Size = new Size(29, 12);
      this.label8.TabIndex = 7;
      this.label8.Text = "带宽";
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new Point(105, 117);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new Size(100, 20);
      this.comboBox3.TabIndex = 32;
      this.label9.AutoSize = true;
      this.label9.Location = new Point(34, 195);
      this.label9.Name = "label9";
      this.label9.Size = new Size(53, 12);
      this.label9.TabIndex = 8;
      this.label9.Text = "可选信令";
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new Point(105, 82);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(100, 20);
      this.comboBox2.TabIndex = 31;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(34, 230);
      this.label10.Name = "label10";
      this.label10.Size = new Size(53, 12);
      this.label10.TabIndex = 9;
      this.label10.Text = "静噪模式";
      this.label10.Visible = false;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(105, 47);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(100, 20);
      this.comboBox1.TabIndex = 30;
      this.textBox1.Location = new Point(105, 11);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 21);
      this.textBox1.TabIndex = 27;
      this.textBox1.Leave += new EventHandler(this.textBox1_Leave);
      this.textBox1.Enter += new EventHandler(this.textBox1_Enter);
      this.button9.Location = new Point(283, 341);
      this.button9.Name = "button9";
      this.button9.Size = new Size(75, 41);
      this.button9.TabIndex = 51;
      this.button9.Text = "取消";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.button10.Location = new Point(189, 341);
      this.button10.Name = "button10";
      this.button10.Size = new Size(73, 41);
      this.button10.TabIndex = 50;
      this.button10.Text = "确定";
      this.button10.UseVisualStyleBackColor = true;
      this.button10.Click += new EventHandler(this.button10_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(632, 397);
      this.Controls.Add((Control) this.button9);
      this.Controls.Add((Control) this.button10);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.tabControl1);
      this.Name = nameof (VFO_CH);
      this.Text = nameof (VFO_CH);
      this.Load += new EventHandler(this.VFO_CH_Load);
      this.tabControl1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
