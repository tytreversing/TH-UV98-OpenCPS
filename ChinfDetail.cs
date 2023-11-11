// Decompiled with JetBrains decompiler
// Type: _8890DTest.ChinfDetail
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class ChinfDetail : Form
  {
    public int GiCurrentCh = 3;
    public string GiFileName1 = "TempFile.icf";
    public static string[,] lableArrName = new string[2, 15]
    {
      {
        "信道号",
        "接收频率",
        "发射频率",
        "接收亚音",
        "发射亚音",
        "扰    频",
        " 功率",
        "遇忙禁发 ",
        "步进",
        " 带宽",
        "可选信令",
        "信道名称",
        "DTMF PTTID",
        "5TONE PTTID",
        "扫描"
      },
      {
        "Number",
        "  Rx Fre",
        "  Tx Fre",
        "  Decode",
        "  Encode",
        "Scramble",
        "Power",
        "   B_Lock",
        "Step",
        "Wide",
        " Singnal",
        " Ch Name",
        "DTMF PTTID",
        "5TONE PTTID",
        "Scan"
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
        " 发射GPS信息",
        "接收GPS信息    ",
        "脱网   "
      },
      {
        "Rev ",
        "Tx Inh  ",
        "Tx Gps",
        "RX Gps",
        "Talk Off"
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
    private string GiRxFreTemp;
    private string GiTxFreTemp;
    private string GiNameTemp;
    public bool GbChChangeen = false;
    public bool GbFirDisEn = true;
    private Label[] Label_Arr;
    private ComboBox[] ComboBoxl_Arr;
    private TextBox[] TextBoxl_Arr;
    private CheckBox[] CheckBox_Arr;
    private GroupBox[] GroupBox_Arr;
    private Button[] Button_Arr;
    private IContainer components = (IContainer) null;
    private GroupBox groupBox3;
    private GroupBox groupBox2;
    private Label label12;
    private Label label6;
    private ComboBox comboBox8;
    private Label label13;
    private ComboBox comboBox7;
    private Label label15;
    private CheckBox checkBox5;
    private CheckBox checkBox4;
    private CheckBox checkBox3;
    private CheckBox checkBox2;
    private CheckBox checkBox1;
    private GroupBox groupBox1;
    private Label label2;
    private ComboBox comboBox9;
    private Label label1;
    private Label label3;
    private Label label4;
    private ComboBox comboBox6;
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
    private Label label11;
    private TextBox textBox3;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label18;
    private Button button2;
    private Button button1;
    private ComboBox comboBox10;
    private ComboBox comboBox11;
    private NumericUpDown numericUpDown1;
    private Label label23;
    private ComboBox comboBox14;
    private CheckBox checkBox6;
    private Label label22;
    private ComboBox comboBox13;
    private Label label21;
    private ComboBox comboBox12;

    public ChinfDetail()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

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

    private void load_GroBox1_LabelPro()
    {
      for (int index = 0; index <= 14; ++index)
        this.Label_Arr[index].Text = ChinfDetail.lableArrName[Class1.English_En, index];
    }

    private void load_GroBox1_textBoxPro()
    {
      this.TextBoxResPro(this.textBox1, 9, "430.00000");
      this.TextBoxResPro(this.textBox2, 9, "430.00000");
      this.TextBoxResPro(this.textBox3, 6, "MEM001");
    }

    private void load_CmbBoxNPro(ComboBox cmbHelp, string[] StrArr, int Number)
    {
      for (int index = 0; index <= Number; ++index)
        cmbHelp.Items.Add((object) StrArr[index]);
      this.ComBoxResPro(cmbHelp, 0);
    }

    private void load_GroBox1_comboBoxPro()
    {
      string[] StrArr = new string[104];
      公共控件操作.Load_CmbBoxNPro(this.comboBox1, Class1.CtcTone, 51);
      for (int index = 0; index < Class1.DcsTone.Length; ++index)
        StrArr[index] = Class1.DcsTone[index] + "N";
      公共控件操作.Load_CmbBoxNPro(this.comboBox1, StrArr, 103);
      for (int index = 0; index < Class1.DcsTone.Length; ++index)
        StrArr[index] = Class1.DcsTone[index] + "I";
      公共控件操作.Load_CmbBoxNPro(this.comboBox1, StrArr, 103);
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
      this.comboBox1.MaxLength = 5;
      公共控件操作.Load_CmbBoxNPro(this.comboBox2, Class1.CtcTone, 51);
      for (int index = 0; index < Class1.DcsTone.Length; ++index)
        StrArr[index] = Class1.DcsTone[index] + "N";
      公共控件操作.Load_CmbBoxNPro(this.comboBox2, StrArr, 103);
      for (int index = 0; index < Class1.DcsTone.Length; ++index)
        StrArr[index] = Class1.DcsTone[index] + "I";
      公共控件操作.Load_CmbBoxNPro(this.comboBox2, StrArr, 103);
      this.comboBox2.DropDownStyle = ComboBoxStyle.DropDown;
      this.comboBox2.MaxLength = 3;
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox3, Class1.TxPower_EngCh, Class1.TxPower_EngCh.GetLength(1) - 1);
      this.load_CmbBoxNPro(this.comboBox4, Class1.ConStep, Class1.ConStep.Length - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox5, Class1.WideNar_EngCh, Class1.WideNar_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox7, Class1.Spkind_EngCh, Class1.Spkind_EngCh.GetLength(1) - 1);
      this.comboBox7.Visible = false;
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox8, Class1.PttKind_EngCh, Class1.PttKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox9, Class1.PttKind_EngCh, Class1.PttKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox10, Class1.BusyKind_EngCh, Class1.BusyKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox11, Class1.ScanSkip_EngCh, Class1.ScanSkip_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox6, Class1.OptSig_EngCh, Class1.OptSig_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox14, Class1.ScrChSet_EngCh, Class1.ScrChSet_EngCh.GetLength(1) - 1);
    }

    private void load_GroupBox1Pro()
    {
      公共控件操作.numericUpDownXRes(this.numericUpDown1, 201, 0, 1);
      this.numericUpDown1.Enabled = true;
      this.load_GroBox1_textBoxPro();
      this.load_GroBox1_LabelPro();
      this.load_GroBox1_comboBoxPro();
      for (int index = 0; index <= 4; ++index)
        this.CheckBox_Arr[index].Text = ChinfDetail.ChekcBox_EngCh[Class1.English_En, index];
    }

    private void SetCombo_XListPro(
      ComboBox comboBox_x,
      string[] ArrTemp,
      string StringTemp,
      bool AddEn)
    {
      int num = 0;
      if (AddEn)
        comboBox_x.Items.Clear();
      for (int index = 0; index < ArrTemp.Length; ++index)
      {
        if (AddEn)
          comboBox_x.Items.Add((object) ArrTemp[index]);
        if (ArrTemp[index] == StringTemp)
          num = index;
      }
      if (num >= ArrTemp.Length)
        comboBox_x.SelectedIndex = 0;
      else
        comboBox_x.SelectedIndex = num;
    }

    private void LookCombo_XAddPro(ComboBox comboBox_x, string[] ArrTemp, string StringTemp)
    {
      int num1 = ArrTemp.Length;
      for (int index = 0; index < ArrTemp.Length; ++index)
      {
        if (ArrTemp[index] == StringTemp)
        {
          num1 = index;
          break;
        }
        StringTemp = Class2.DoubleDataChgPro(StringTemp);
        double num2 = Convert.ToDouble(StringTemp);
        ArrTemp[index] = Class2.DoubleDataChgPro(ArrTemp[index]);
        double num3 = Convert.ToDouble(ArrTemp[index]);
        if (num2 < num3)
        {
          num1 = index - 1;
          break;
        }
      }
      if (num1 >= ArrTemp.Length)
        comboBox_x.SelectedIndex = 0;
      else
        comboBox_x.SelectedIndex = num1;
    }

    private void DisCurrChPro(string Datastr, int i)
    {
      this.checkBox1.Checked = false;
      this.checkBox2.Checked = false;
      this.checkBox3.Checked = false;
      this.checkBox4.Checked = false;
      this.checkBox5.Checked = false;
      bool flag = false;
      if (Datastr == "")
      {
        flag = true;
        Datastr = "A4CB9702A4CB9702FF0FFF0F00040620202020202020202020202020202020";
        this.comboBox11.SelectedIndex = 0;
      }
      else
      {
        if (!this.textBox2.Enabled)
          this.AllContrlEnablePro();
        string[] strArray = Class1.ReadFileDataPro(this.GiFileName1).Split('\r');
        i = this.GiCurrentCh;
        if (Class2.StringChUsefulPro(Class2.AutoAdd_n_Pro(strArray[Class1.FielBegRow + Class1.ChSkipBegAddr / Class1.ConOneRowDatCt]), i) == 1)
          this.comboBox11.SelectedIndex = 0;
        else
          this.comboBox11.SelectedIndex = 1;
      }
      string StrTemp1 = Class2.StringChgPro(Datastr.Substring(0, 8), 4);
      string StrTemp2 = Class2.StringChgPro(Datastr.Substring(8, 8), 4);
      string StrTemp3 = Class2.StringChgPro(Datastr.Substring(16, 4), 2);
      string StrTemp4 = Class2.StringChgPro(Datastr.Substring(20, 4), 2);
      string str1 = Datastr.Substring(24, 2);
      string str2 = Datastr.Substring(26, 2);
      string str3 = Datastr.Substring(28, 2);
      Datastr.Substring(30, 12);
      try
      {
        int int32_1 = Convert.ToInt32(StrTemp1, 16);
        int32_1 = Convert.ToInt32(StrTemp2, 16);
        int int32_2 = Convert.ToInt32(StrTemp3, 16);
        int int32_3 = Convert.ToInt32(StrTemp4, 16);
        this.textBox1.Text = Class2.StringChgFrePro(StrTemp1, 5);
        this.textBox2.Text = Class2.StringChgFrePro(StrTemp2, 5);
        string str4 = Class1.GBKTOHanzi_ChangePro(Datastr.Substring(30, 32));
        if (str4 == "                ")
          str4 = "";
        this.textBox3.Text = str4;
        this.comboBox14.SelectedIndex = (int32_2 & 61440) >> 12;
        if ((int32_3 & 4096) >> 12 != 0)
          this.checkBox6.Checked = true;
        int num = int32_3 & 49152;
        this.comboBox1.Text = (num & 16384) == 0 ? Class2.Rx_TxChgToSubDataPro(StrTemp3, 0) : Class2.Rx_TxChgToSubDataPro(StrTemp3, 1);
        this.comboBox2.Text = (num & 32768) == 0 ? Class2.Rx_TxChgToSubDataPro(StrTemp4, 0) : Class2.Rx_TxChgToSubDataPro(StrTemp4, 1);
        int int32_4 = Convert.ToInt32(str1, 16);
        if ((int32_4 & 1) != 0)
          this.checkBox4.Checked = true;
        if ((int32_4 & 2) != 0)
        {
          this.checkBox3.Checked = true;
          this.checkBox2.Checked = false;
        }
        this.comboBox10.SelectedIndex = (int32_4 & 12) >> 2;
        this.comboBox5.SelectedIndex = (int32_4 & 48) >> 4;
        this.comboBox3.SelectedIndex = (int32_4 & 192) >> 6;
        int int32_5 = Convert.ToInt32(str2, 16);
        if ((int32_5 & 1) != 0)
          this.checkBox5.Checked = true;
        if ((int32_5 & 2) != 0)
        {
          this.checkBox2.Checked = true;
          this.checkBox3.Checked = false;
        }
        this.comboBox6.SelectedIndex = (int32_5 & 24) >> 3;
        this.comboBox7.SelectedIndex = (int32_5 & 224) >> 5;
        int int32_6 = Convert.ToInt32(str3, 16);
        this.comboBox4.SelectedIndex = int32_6 & 15;
        this.comboBox8.SelectedIndex = (int32_6 & 48) >> 4;
        this.comboBox9.SelectedIndex = (int32_6 & 192) >> 6;
        if (!flag)
          return;
        this.textBox1.Text = "";
        this.textBox2.Text = "";
        this.AllContrlDisablePro();
      }
      catch
      {
        ++i;
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 1] + (object) i + this.MessBoxName[Class1.English_En, 2], Class1.RadioName);
      }
    }

    private void LoadCurChDataDisPro()
    {
      int i = 1;
      string Datastr;
      try
      {
        string[] n = Class1.ReadFileDataPro(this.GiFileName1).Split('\r');
        i = this.GiCurrentCh;
        if (Class2.StringChUsefulPro(Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + Class1.ChinfBegAddr / Class1.ConOneRowDatCt]), i) == 0)
        {
          Datastr = "";
        }
        else
        {
          string str = Class2.GetOneChStringPro(n, i) + Class2.GetOneChStringAddNamePro(n, i);
          Datastr = str.Substring(0, str.Length - 12) + "202020202020";
        }
      }
      catch
      {
        Datastr = "";
      }
      this.DisCurrChPro(Datastr, i);
    }

    private void load_WinDisplayPro()
    {
      this.numericUpDown1.Value = (Decimal) (this.GiCurrentCh + 1);
      this.LoadCurChDataDisPro();
    }

    private void SetContrlAs_arrPro()
    {
      this.Label_Arr = new Label[23];
      this.Label_Arr[0] = this.label18;
      this.Label_Arr[1] = this.label1;
      this.Label_Arr[2] = this.label2;
      this.Label_Arr[3] = this.label3;
      this.Label_Arr[4] = this.label4;
      this.Label_Arr[5] = this.label23;
      this.Label_Arr[6] = this.label5;
      this.Label_Arr[7] = this.label15;
      this.Label_Arr[8] = this.label7;
      this.Label_Arr[9] = this.label8;
      this.Label_Arr[10] = this.label9;
      this.Label_Arr[11] = this.label11;
      this.Label_Arr[12] = this.label12;
      this.Label_Arr[13] = this.label13;
      this.Label_Arr[14] = this.label6;
      this.ComboBoxl_Arr = new ComboBox[13];
      this.ComboBoxl_Arr[0] = this.comboBox1;
      this.ComboBoxl_Arr[1] = this.comboBox2;
      this.ComboBoxl_Arr[2] = this.comboBox3;
      this.ComboBoxl_Arr[3] = this.comboBox4;
      this.ComboBoxl_Arr[4] = this.comboBox5;
      this.ComboBoxl_Arr[5] = this.comboBox6;
      this.ComboBoxl_Arr[6] = this.comboBox7;
      this.ComboBoxl_Arr[7] = this.comboBox8;
      this.ComboBoxl_Arr[8] = this.comboBox9;
      this.ComboBoxl_Arr[9] = this.comboBox10;
      this.ComboBoxl_Arr[10] = this.comboBox11;
      this.ComboBoxl_Arr[11] = this.comboBox12;
      this.ComboBoxl_Arr[12] = this.comboBox13;
      this.TextBoxl_Arr = new TextBox[3];
      this.TextBoxl_Arr[0] = this.textBox1;
      this.TextBoxl_Arr[1] = this.textBox2;
      this.TextBoxl_Arr[2] = this.textBox3;
      this.CheckBox_Arr = new CheckBox[6];
      this.CheckBox_Arr[0] = this.checkBox3;
      this.CheckBox_Arr[1] = this.checkBox4;
      this.CheckBox_Arr[2] = this.checkBox5;
      this.CheckBox_Arr[3] = this.checkBox6;
      this.CheckBox_Arr[4] = this.checkBox2;
      this.CheckBox_Arr[5] = this.checkBox1;
      this.GroupBox_Arr = new GroupBox[3];
      this.GroupBox_Arr[0] = this.groupBox3;
      this.GroupBox_Arr[1] = this.groupBox2;
      this.Button_Arr = new Button[2];
      this.Button_Arr[0] = this.button1;
      this.Button_Arr[1] = this.button2;
    }

    private void ChinfDetail_Load(object sender, EventArgs e)
    {
      this.SetContrlAs_arrPro();
      this.GbChChangeen = false;
      this.GbFirDisEn = true;
      for (int index = 0; index <= 1; ++index)
        this.GroupBox_Arr[index].Text = ChinfDetail.GroupBox_EngCh[Class1.English_En, index];
      for (int index = 0; index <= 1; ++index)
        this.Button_Arr[index].Text = ChinfDetail.Button_EngCh[Class1.English_En, index];
      this.load_GroupBox1Pro();
      this.load_WinDisplayPro();
      this.textBox3.MaxLength = 8;
      if (Class1.GpsEable == "Enable")
      {
        this.checkBox5.Visible = true;
        this.checkBox6.Visible = true;
      }
      else
      {
        this.checkBox5.Visible = false;
        this.checkBox6.Visible = false;
      }
      this.checkBox1.Visible = false;
      this.checkBox2.Visible = false;
      this.checkBox3.Visible = false;
      this.checkBox4.Visible = false;
      this.checkBox5.Visible = false;
      this.checkBox6.Visible = false;
      this.comboBox9.Visible = false;
      this.GbFirDisEn = false;
    }

    private void groupBox3_Enter(object sender, EventArgs e)
    {
    }

    private string ChgChStringPro()
    {
      string str1 = "";
      Class1.ReadFileDataPro(this.GiFileName1).Split('\r');
      int giCurrentCh = this.GiCurrentCh;
      if (this.textBox1.Text == "")
        return str1;
      string[] strArray = new string[11];
      strArray[0] = Class2.ChgRxFreToDataPro(this.textBox1.Text);
      strArray[1] = Class2.ChgRxFreToDataPro(this.textBox2.Text);
      strArray[2] = this.comboBox1.Text;
      strArray[3] = this.comboBox2.Text;
      strArray[10] = Class1.hanziTOGbk_ChangePro(this.textBox3.Text, 8);
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      if (this.checkBox6.Checked)
        num2 = 1;
      string str2 = strArray[2].Substring(strArray[2].Length - 1, 1);
      if (str2 == "I" || str2 == "i")
        num3 = 1;
      string str3 = strArray[3].Substring(strArray[3].Length - 1, 1);
      if (str3 == "I" || str3 == "i")
        num4 = 1;
      int num5 = num2 << 4;
      string hexStr1 = Class1.DataToHexStr((long) (num1 | num5 | num3 << 6 | num4 << 7));
      strArray[2] = Class2.ChgSubToDataPro(strArray[2]);
      strArray[3] = Class2.ChgSubToDataPro(strArray[3]);
      string hexStr2 = Class1.DataToHexStr((long) (Convert.ToInt32(strArray[3].Substring(2, 2), 16) & 15 | this.comboBox14.SelectedIndex << 4));
      int num6 = 0;
      if (this.checkBox4.Checked)
        num6 = 1;
      int num7 = 0;
      if (this.checkBox3.Checked)
        num7 = 1;
      int selectedIndex1 = this.comboBox10.SelectedIndex;
      int selectedIndex2 = this.comboBox5.SelectedIndex;
      int selectedIndex3 = this.comboBox3.SelectedIndex;
      string hexStr3 = Class1.DataToHexStr((long) (num6 | num7 << 1 | selectedIndex1 << 2 | selectedIndex2 << 4 | selectedIndex3 << 6));
      int num8 = 0;
      if (this.checkBox5.Checked)
        num8 = 1;
      int num9 = 0;
      if (this.checkBox2.Checked)
        num9 = 1;
      int num10 = 0;
      if (strArray[10] != "20202020202020202020202020202020")
        num10 = 1;
      int selectedIndex4 = this.comboBox6.SelectedIndex;
      int selectedIndex5 = this.comboBox7.SelectedIndex;
      string hexStr4 = Class1.DataToHexStr((long) (num8 | num9 << 1 | num10 << 2 | selectedIndex4 << 3 | selectedIndex5 << 5));
      string hexStr5 = Class1.DataToHexStr((long) (this.comboBox4.SelectedIndex | this.comboBox8.SelectedIndex << 4 | this.comboBox9.SelectedIndex << 6));
      strArray[0] = strArray[0] + strArray[1] + strArray[2].Substring(0, 2) + hexStr2.Substring(0, 1) + strArray[2].Substring(3, 1) + strArray[3].Substring(0, 2) + hexStr1.Substring(0, 1) + strArray[3].Substring(3, 1) + hexStr3 + hexStr4 + hexStr5 + strArray[10];
      return Class1.Chga_z_ToA_Z(strArray[0]);
    }

    private void SaveCurrenChData()
    {
      Class1.SavOneChgDatPro(this.ChgChStringPro(), this.GiCurrentCh, this.GiFileName1);
      Class1.SavOneChgSkipSttPro(this.comboBox11.SelectedIndex, this.GiCurrentCh, this.GiFileName1);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
      this.SaveCurrenChData();
    }

    private void button2_Click(object sender, EventArgs e) => this.Close();

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      string text = "";
      int[] numArray1 = new int[3];
      int[] numArray2 = new int[3];
      int[] numArray3 = new int[3];
      int[] numArray4 = new int[3];
      bool flag = Class1.KeyUseFul0_9ChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar != '\r')
        return;
      if (Class2.DataUseFulFreChk(this.textBox1.Text, 0) == "BandOver")
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
        if (numArray1[0] != 0 && numArray2[0] != 0)
          text = this.MessBoxName[Class1.English_En, 0] + (object) numArray1[0] + "M," + (object) numArray2[0] + "M]";
        if (numArray1[1] != 0 && numArray2[1] != 0)
          text = text + "||" + (object) numArray1[1] + "M," + (object) numArray2[1] + "M]";
        if (numArray1[2] != 0 && numArray2[2] != 0)
          text = text + "||" + (object) numArray1[2] + "M," + (object) numArray2[2] + "M]";
        int num = (int) MessageBox.Show(text, Class1.RadioName);
        this.textBox1.Text = this.GiRxFreTemp;
        this.textBox1.Focus();
      }
      else
      {
        this.AllContrlEnablePro();
        this.textBox2.Focus();
      }
    }

    private void comboBox7_TextChanged(object sender, EventArgs e)
    {
    }

    private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.GbFirDisEn)
        this.GbChChangeen = true;
      if (this.comboBox1.Text == "OFF")
      {
        if (this.comboBox7.SelectedIndex == 1)
          this.comboBox7.SelectedIndex = 0;
        else if (this.comboBox7.SelectedIndex == 3 || this.comboBox7.SelectedIndex == 4)
          this.comboBox7.SelectedIndex = 2;
      }
      if (this.comboBox6.SelectedIndex != 0)
        return;
      if (this.comboBox7.SelectedIndex == 2)
      {
        if (this.comboBox1.SelectedIndex <= 1)
          this.comboBox7.SelectedIndex = 0;
        else
          this.comboBox7.SelectedIndex = 1;
      }
      else if (this.comboBox7.SelectedIndex == 3 || this.comboBox7.SelectedIndex == 4)
      {
        if (this.comboBox1.Text == "OFF")
          this.comboBox7.SelectedIndex = 0;
        else
          this.comboBox7.SelectedIndex = 1;
      }
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.GbFirDisEn)
        this.GbChChangeen = true;
      if (!this.checkBox2.Checked || !this.checkBox3.Checked)
        return;
      this.checkBox3.Checked = false;
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.GbFirDisEn)
        this.GbChChangeen = true;
      if (!this.checkBox3.Checked || !this.checkBox2.Checked)
        return;
      this.checkBox2.Checked = false;
    }

    private void AllContrlDisablePro()
    {
      for (int index = 1; index < 3; ++index)
        this.TextBoxl_Arr[index].Enabled = false;
      for (int index = 0; index < 13; ++index)
        this.ComboBoxl_Arr[index].Enabled = false;
      this.comboBox14.Enabled = false;
      for (int index = 1; index < 15; ++index)
        this.Label_Arr[index].Enabled = false;
      for (int index = 1; index < 6; ++index)
        this.CheckBox_Arr[index].Enabled = false;
    }

    private void AllContrlEnablePro()
    {
      for (int index = 0; index < 3; ++index)
        this.TextBoxl_Arr[index].Enabled = true;
      for (int index = 0; index < 12; ++index)
        this.ComboBoxl_Arr[index].Enabled = true;
      this.comboBox14.Enabled = true;
      for (int index = 0; index < 15; ++index)
        this.Label_Arr[index].Enabled = true;
      for (int index = 0; index < 6; ++index)
        this.CheckBox_Arr[index].Enabled = true;
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      string text1 = "";
      string text2 = this.textBox1.Text;
      int[] numArray1 = new int[3];
      int[] numArray2 = new int[3];
      int[] numArray3 = new int[3];
      int[] numArray4 = new int[3];
      string StrTemp = text2;
      int index = Class2.DataUseFulFreChk02(text2);
      string str1 = Class2.DataUseFulFreChk(text2, 0);
      if (str1 == "BandOver")
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
        if (numArray1[0] != 0 && numArray2[0] != 0)
          text1 = this.MessBoxName[Class1.English_En, 0] + (object) numArray1[0] + "M," + (object) numArray2[0] + "M]";
        if (numArray1[1] != 0 && numArray2[1] != 0)
          text1 = text1 + "||" + (object) numArray1[1] + "M," + (object) numArray2[1] + "M]";
        if (numArray1[2] != 0 && numArray2[2] != 0)
          text1 = text1 + "||" + (object) numArray1[2] + "M," + (object) numArray2[2] + "M]";
        int num = (int) MessageBox.Show(text1, Class1.RadioName);
        this.textBox1.Text = this.GiRxFreTemp;
        this.textBox1.Focus();
      }
      else
      {
        string str2 = str1.Replace(",", ".");
        this.textBox1.Text = str2;
        if (str2 == "")
        {
          if (str2 != this.GiRxFreTemp)
            this.GbChChangeen = true;
          this.AllContrlDisablePro();
        }
        else
        {
          if (str2 != this.GiRxFreTemp)
            this.GbChChangeen = true;
          if (this.GiRxFreTemp == "")
          {
            this.AllContrlEnablePro();
            string str3 = this.textBox1.Text;
            if (Class2.DataUseFulFreChk(StrTemp, 2) == "BandOver")
              str3 = Class2.DataUseFulFreChk((Class1.FreBandData[index, 2] / 100000).ToString(), 2);
            this.textBox2.Text = str3;
          }
        }
      }
    }

    private void textBox1_Enter(object sender, EventArgs e) => this.GiRxFreTemp = this.textBox1.Text;

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      string text = "";
      int[] numArray1 = new int[3];
      int[] numArray2 = new int[3];
      int[] numArray3 = new int[3];
      int[] numArray4 = new int[3];
      bool flag = Class1.KeyUseFul0_9ChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar != '\r')
        return;
      string str = Class2.DataUseFulFreChk(this.textBox2.Text, 2);
      if (str == "BandOver")
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
        if (numArray3[0] != 0 && numArray4[0] != 0)
          text = this.MessBoxName[Class1.English_En, 0] + (object) numArray3[0] + "M," + (object) numArray4[0] + "M]";
        if (numArray3[1] != 0 && numArray4[1] != 0)
          text = text + "||" + (object) numArray3[1] + "M," + (object) numArray4[1] + "M]";
        if (numArray3[2] != 0 && numArray4[2] != 0)
          text = text + "||" + (object) numArray3[2] + "M," + (object) numArray4[2] + "M]";
        int num = (int) MessageBox.Show(text, Class1.RadioName);
        this.textBox2.Text = this.GiTxFreTemp;
        this.textBox2.Focus();
      }
      else
      {
        this.textBox2.Text = str;
        this.textBox3.Focus();
      }
    }

    private void textBox2_Leave(object sender, EventArgs e)
    {
      string text1 = "";
      string text2 = this.textBox2.Text;
      int[] numArray1 = new int[3];
      int[] numArray2 = new int[3];
      int[] numArray3 = new int[3];
      int[] numArray4 = new int[3];
      string str = Class2.DataUseFulFreChk(text2, 2);
      if (str == "BandOver")
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
        if (numArray3[0] != 0 && numArray4[0] != 0)
          text1 = this.MessBoxName[Class1.English_En, 0] + (object) numArray3[0] + "M," + (object) numArray4[0] + "M]";
        if (numArray3[1] != 0 && numArray4[1] != 0)
          text1 = text1 + "||" + (object) numArray3[1] + "M," + (object) numArray4[1] + "M]";
        if (numArray3[2] != 0 && numArray4[2] != 0)
          text1 = text1 + "||" + (object) numArray3[2] + "M," + (object) numArray4[2] + "M]";
        int num = (int) MessageBox.Show(text1, Class1.RadioName);
        this.textBox2.Text = this.GiTxFreTemp;
        this.textBox2.Focus();
      }
      else
      {
        this.textBox2.Text = str;
        if (this.GiTxFreTemp != str)
          this.GbChChangeen = true;
      }
    }

    private void textBox2_Enter(object sender, EventArgs e) => this.GiTxFreTemp = this.textBox2.Text;

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      if (this.GbChChangeen)
        this.SaveCurrenChData();
      this.GbChChangeen = false;
      公共控件操作.numericUpDown_ValueChanged(this.numericUpDown1);
      this.GiCurrentCh = (int) this.numericUpDown1.Value - 1;
      this.LoadCurChDataDisPro();
    }

    private void comboBox1_Click(object sender, EventArgs e) => 公共控件操作.LookCombo_XAdd_QtTDqtPro(this.comboBox1, this.comboBox1.Text);

    private void comboBox2_Click(object sender, EventArgs e) => 公共控件操作.LookCombo_XAdd_QtTDqtPro(this.comboBox2, this.comboBox2.Text);

    private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.GbFirDisEn)
        this.GbChChangeen = true;
      if (this.comboBox6.SelectedIndex >= 1)
      {
        if (this.comboBox1.SelectedIndex >= 1)
          this.comboBox7.SelectedIndex = 3;
        else
          this.comboBox7.SelectedIndex = 2;
      }
      else
      {
        string text = this.comboBox7.Text;
        if (text == Class1.Spkind_EngCh[Class1.English_En, 1])
          this.comboBox7.SelectedIndex = 0;
        else if (text == Class1.Spkind_EngCh[Class1.English_En, 2] || text == Class1.Spkind_EngCh[Class1.English_En, 3])
          this.comboBox7.SelectedIndex = 1;
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.GbFirDisEn)
        this.GbChChangeen = true;
      string text1 = this.comboBox7.Text;
      string text2 = this.comboBox1.Text;
      this.comboBox2.Text = this.comboBox1.Text;
      if (text2 == "OFF")
      {
        if (text1 == Class1.Spkind_EngCh[Class1.English_En, 1])
        {
          this.comboBox7.Text = Class1.Spkind_EngCh[Class1.English_En, 0];
        }
        else
        {
          if (!(text1 == Class1.Spkind_EngCh[Class1.English_En, 2]) && !(text1 == Class1.Spkind_EngCh[Class1.English_En, 3]))
            return;
          this.comboBox7.Text = Class1.Spkind_EngCh[Class1.English_En, 2];
        }
      }
      else if (text1 == Class1.Spkind_EngCh[Class1.English_En, 0])
        this.comboBox7.Text = Class1.Spkind_EngCh[Class1.English_En, 1];
    }

    private void textBox3_KeyPress(object sender, KeyPressEventArgs e) => this.textBox3.MaxLength = Class1.InputLengthSetPro(this.textBox3.Text, 5);

    private void textBox3_Enter(object sender, EventArgs e) => this.GiNameTemp = this.textBox3.Text;

    private void textBox3_Leave(object sender, EventArgs e)
    {
      if (!(this.GiNameTemp != this.textBox3.Text))
        return;
      this.GbChChangeen = true;
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    private void checkBox5_CheckedChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    private void checkBox6_CheckedChanged(object sender, EventArgs e)
    {
      if (this.GbFirDisEn)
        return;
      this.GbChChangeen = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinfDetail));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.comboBox13);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.comboBox12);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 483);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信道信息";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(279, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "DCS方向";
            this.label22.Visible = false;
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(332, 36);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(100, 21);
            this.comboBox13.TabIndex = 42;
            this.comboBox13.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 45;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(23, 27);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(100, 21);
            this.comboBox12.TabIndex = 38;
            this.comboBox12.Visible = false;
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 44);
            this.button1.TabIndex = 44;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(168, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "信道号:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.InterceptArrowKeys = false;
            this.numericUpDown1.Location = new System.Drawing.Point(221, 34);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 38;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.comboBox9);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.comboBox14);
            this.groupBox2.Controls.Add(this.comboBox11);
            this.groupBox2.Controls.Add(this.comboBox10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox8);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(231, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 350);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(29, 307);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(96, 17);
            this.checkBox6.TabIndex = 43;
            this.checkBox6.Text = "接收GPS信息";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(144, 146);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(100, 21);
            this.comboBox9.TabIndex = 38;
            this.comboBox9.Visible = false;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "5TONE PTTID";
            this.label13.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(48, -40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "亚音频方式";
            this.label21.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(36, 126);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 41;
            this.label23.Text = "扰频信道";
            // 
            // comboBox14
            // 
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(144, 118);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(100, 21);
            this.comboBox14.TabIndex = 42;
            this.comboBox14.Visible = false;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(144, 86);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(100, 21);
            this.comboBox11.TabIndex = 40;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(144, 54);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(100, 21);
            this.comboBox10.TabIndex = 39;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "DTMF PTTID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "扫描";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(144, 27);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(100, 21);
            this.comboBox8.TabIndex = 37;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoEllipsis = true;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Блокировка передачи";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(29, 275);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(96, 17);
            this.checkBox5.TabIndex = 24;
            this.checkBox5.Text = "发射GPS信息";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(33, 244);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(74, 17);
            this.checkBox4.TabIndex = 23;
            this.checkBox4.Text = "发射禁止";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(119, 215);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(50, 17);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "倒频";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(33, 212);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "脱 网";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 244);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "扰频";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.comboBox7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 407);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "发射频率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "接收频率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "接收亚音";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "发射亚音";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(105, 325);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(100, 21);
            this.comboBox6.TabIndex = 35;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(105, 363);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(100, 21);
            this.comboBox7.TabIndex = 36;
            this.comboBox7.Visible = false;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = " 功率";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(105, 287);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 21);
            this.comboBox5.TabIndex = 34;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "步进";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(105, 249);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 21);
            this.comboBox4.TabIndex = 33;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = " 带宽";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(105, 211);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 32;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "可选信令";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(105, 173);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "静噪模式";
            this.label10.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "信道名称";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 28;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // ChinfDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 486);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChinfDetail";
            this.Text = "Настройки канала";
            this.Load += new System.EventHandler(this.ChinfDetail_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }
  }
}
