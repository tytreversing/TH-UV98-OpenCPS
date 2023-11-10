// Decompiled with JetBrains decompiler
// Type: _8890DTest.Cmx138Set
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Timers;
using System.Windows.Forms;

namespace _8890DTest
{
  public class Cmx138Set : Form
  {
    private static System.Timers.Timer aTimer1;
    public string BaudRadio = "9600";
    private string[,] ConStrTable = new string[55, 6]
    {
      {
        "1",
        "频率微调",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "2",
        "接收调谐1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "3",
        "接收调谐2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "4",
        "接收调谐3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "5",
        "1级静噪宽1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "6",
        "1级静噪宽2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "7",
        "1级静噪宽3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "8",
        "1级静噪窄1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "9",
        "1级静噪窄2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "10",
        "1级静噪窄3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "11",
        "9级静噪宽1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "12",
        "9级静噪宽2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "13",
        "9级静噪宽3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "14",
        "9级静噪窄1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "15",
        "9级静噪窄2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "16",
        "9级静噪窄3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "17",
        "低功率1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "18",
        "低功率2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "19",
        "低功率3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "20",
        "中功率1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "21",
        "中功率2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "22",
        "中功率3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "23",
        "高功率1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "24",
        "高功率2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "25",
        "高功率3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "26",
        "频偏宽1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "27",
        "频偏宽2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "28",
        "频偏宽3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "29",
        "频偏窄1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "30",
        "频偏窄2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "31",
        "频偏窄3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "32",
        "DCS宽1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "33",
        "DCS宽2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "34",
        "DCS宽3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "35",
        "DCS窄1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "36",
        "DCS窄2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "37",
        "DCS窄3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "38",
        "Ctc 67HZ 宽1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "39",
        "Ctc 67HZ 宽2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "40",
        "Ctc 67HZ 宽3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "41",
        "Ctc 156.7HZ 宽1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "42",
        "Ctc 156.7HZ 宽2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "43",
        "Ctc 156.7HZ 宽3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "44",
        "Ctc 254.1HZ 宽1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "45",
        "Ctc 254.1HZ 宽2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "46",
        "Ctc 254.1HZ 宽3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "47",
        "Ctc 67HZ 窄1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "48",
        "Ctc 67HZ 窄2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "49",
        "Ctc 67HZ 窄3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "50",
        "Ctc 156.7HZ 窄1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "51",
        "Ctc 156.7HZ 窄2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "52",
        "Ctc 156.7HZ 窄3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "53",
        "Ctc 254.1HZ 窄1",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "54",
        "Ctc 254.1HZ 窄2",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      },
      {
        "55",
        "Ctc 254.1HZ 窄3",
        "255",
        "202",
        "400M+25KHZ",
        "否"
      }
    };
    private string[] VolumeLev = new string[9]
    {
      "255",
      "238",
      "252",
      "221",
      "248",
      "187",
      "136",
      "128",
      "00"
    };
    private string ReadCt_OneTm = "3230";
    private string WriteCt_OneTm = "3230";
    private int ConOneTmReadCt = 32;
    private int ConOneTmWriteCt = 32;
    private int Con138BegAdd = 6448;
    private int Con138BegLine = 6;
    private int ConTestReadDataTm = 1;
    private int ConTestWriteDataTm = 1;
    public string GiFilePathName = "TestModDef.icf";
    private string GiCurrDataBuf;
    private string GiDefDataBuf;
    private string ComTempStr;
    private string[] WriteDataBuf;
    private bool OnlyOneLine = false;
    private bool ComFail = false;
    private bool GbTestMod = false;
    private bool GbAtLineMod = false;
    private bool GbItemAjdEn = false;
    private int IicAddress;
    private int CurrentCom = 6;
    private int SendByte = 0;
    private int CurrAdjData;
    private int CurrAdjItem;
    private byte[] RxBuffer = new byte[200];
    private byte CommuCt = 0;
    private byte CommuItem = 0;
    private string ConEntTestCom = "FEFEEEEFF026980000000000FD";
    private string ConExitTestCom = "FEFEEEEFF126980000000000FD";
    private string ConWriTestCom = "FEFEEEEFF226980000000000FD";
    private string ConExtWriModCom = "FEFEEEEFF726980000000000FD";
    private string ConEntItemCom = "FEFEEEEFFA26980000";
    private string ConExitItemCom = "FEFEEEEFF326980000093039FD";
    private string ConAutoAdjCom = "FEFEEEEFF826980000";
    private string ConPttpressCom = "FEFEEEEFF426980000";
    private string ConPttupCom = "FEFEEEEFF526980000";
    private string ConKeyDatTestCom = "FEFEEEEFF626980000093039FD";
    private string ConTxReadCom = "FEFEEEEFEB";
    private string ConTxWriteCom = "FEFEEEEFE4";
    private string ConAckCom = "FEFEEFEEE600FD";
    private string ConReadDatAckCom = "FEFEEFEEE4";
    private IContainer components = (IContainer) null;
    private Button button2;
    private Button button1;
    private GroupBox groupBox6;
    private ListBox listBox1;
    private GroupBox groupBox4;
    private Button button3;
    private ComboBox comboBox1;
    private Label label1;
    private SerialPort serialPort1;
    private Button button8;
    private ComboBox comboBox4;
    private GroupBox groupBox7;
    private TextBox textBox7;
    private Label label8;
    private Label label9;
    private TextBox textBox9;
    private Label label10;
    private Label label11;
    private TextBox textBox8;
    private TextBox textBox6;
    private GroupBox groupBox9;
    private GroupBox groupBox10;
    private TextBox textBox4;
    private TextBox textBox5;
    private Label label2;
    private Label label3;
    private TextBox textBox3;
    private Label label4;
    private GroupBox groupBox11;
    private Label label5;
    private Label label6;
    private ComboBox comboBox2;
    private Label label7;
    private ComboBox comboBox3;
    private Button button9;
    private GroupBox groupBox3;
    private ComboBox comboBox5;
    private GroupBox groupBox1;
    private ComboBox comboBox6;
    private ComboBox comboBox7;
    private Label label12;
    private Label label13;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox10;
    private TextBox textBox11;
    private ComboBox comboBox8;
    private ComboBox comboBox9;
    private ComboBox comboBox10;
    private ComboBox comboBox11;
    private Label label14;
    private Label label15;
    private Label label16;
    private Label label17;
    private Label label18;
    private Label label19;
    private Label label20;
    private Label label21;

    public Cmx138Set()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void CtrLResAllPro(object sender, EventArgs e)
    {
      this.GbTestMod = false;
      this.button1.Text = "进入测试模式";
      this.button1.Enabled = true;
      this.button2.Enabled = false;
      this.button9.Enabled = false;
      this.button3.Text = "重新检测端口";
      this.button3.Enabled = true;
    }

    private void TimerResPro()
    {
      Cmx138Set.aTimer1 = new System.Timers.Timer(10000.0);
      Cmx138Set.aTimer1.Elapsed += new ElapsedEventHandler(this.OnTimedEvent);
      Cmx138Set.aTimer1.Enabled = false;
    }

    private void TimeRestartPro()
    {
      Cmx138Set.aTimer1.Enabled = false;
      Cmx138Set.aTimer1.Interval = 2000.0;
      Cmx138Set.aTimer1.Enabled = true;
    }

    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
      if (!this.GbAtLineMod)
        this.serialPort1.Close();
      else
        this.GbAtLineMod = false;
      Cmx138Set.aTimer1.Enabled = false;
      int num = (int) MessageBox.Show("通信超时", "RadioName");
      this.Invoke((Delegate) new EventHandler(this.CtrLResAllPro));
    }

    private void load_GroupBox4Pro()
    {
      this.groupBox4.Text = "";
      this.label1.Text = "串口选择:";
      this.button3.Text = "重新检测端口";
    }

    private void load_GroupBox6Pro()
    {
      this.groupBox6.Text = "";
      this.button1.Text = "进入测试模式";
      this.button1.Enabled = true;
      this.button2.Text = "批写测试数据";
      this.button2.Enabled = false;
      this.button8.Text = "退出";
      this.button8.Enabled = true;
      this.button9.Text = "写入当前值";
      this.button9.Enabled = false;
    }

    private void LookCurComNo()
    {
      this.WriteDataBuf = Class1.ReadFileDataPro(this.GiFilePathName).Split('\r');
      int index = 0;
      while (index < this.comboBox1.Items.Count && !(this.WriteDataBuf[0] == this.comboBox1.Items[index].ToString()))
        ++index;
      if (index >= this.comboBox1.Items.Count)
        this.comboBox1.SelectedIndex = 0;
      else
        this.comboBox1.SelectedIndex = index;
    }

    private void GetCurComNo()
    {
      string text = this.comboBox1.Text;
      if (text != "")
      {
        this.CurrentCom = Convert.ToInt32(text.Substring(3, text.Length - 3), 10);
      }
      else
      {
        int num = (int) MessageBox.Show("当前无可用端口", "RadioName");
      }
    }

    public void LoadFileDataDisPro()
    {
      string str1 = Class1.ReadFileDataPro(this.GiFilePathName);
      string str2 = "";
      this.WriteDataBuf = str1.Split('\r');
      for (int index = 0; index < this.ConTestWriteDataTm; ++index)
      {
        string str3 = this.WriteDataBuf[index + 3];
        str2 += str3.Substring(7, str3.Length - 7);
      }
    }

    private void TestModWin_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.TimerResPro();
      this.listBox1.Visible = false;
      this.groupBox7.Visible = false;
      this.load_GroupBox4Pro();
      this.load_GroupBox6Pro();
      Class1.GetTestDefFilePro(this.GiFilePathName);
      this.button3_Click(sender, e);
      this.GetCurComNo();
      this.OnlyOneLine = this.comboBox4.SelectedIndex == 0;
      this.LoadFileDataDisPro();
    }

    private void SavDefDataPro()
    {
      this.WriteDataBuf = Class1.ReadFileDataPro(this.GiFilePathName).Split('\r');
      int length = Class1.ConOneRowDatCt * 2;
      for (int index = 0; index < this.ConTestWriteDataTm; ++index)
      {
        string str1 = Class2.AutoAdd_n_Pro(this.WriteDataBuf[index + 3 + this.Con138BegLine]);
        string str2 = str1.Substring(0, 1);
        string str3 = !(str2 == "n") && !(str2 == "\n") ? str1.Substring(0, 6) : str1.Substring(0, 7);
        string str4 = this.GiDefDataBuf.Substring(index * length, length);
        this.WriteDataBuf[index + 3 + this.Con138BegLine] = str3 + str4;
      }
      Class1.SaveFileDataPro(this.GiFilePathName, this.WriteDataBuf);
    }

    private void SavCurDataPro(string StrTemp)
    {
      this.WriteDataBuf = Class1.ReadFileDataPro(this.GiFilePathName).Split('\r');
      int length = Class1.ConOneRowDatCt * 2;
      for (int index = 0; index < this.ConTestWriteDataTm; ++index)
      {
        string str1 = this.WriteDataBuf[index + 3 + this.ConTestWriteDataTm + this.Con138BegLine];
        string str2 = str1.Substring(0, 1);
        string str3 = !(str2 == "n") && !(str2 == "\n") ? str1.Substring(0, 6) : str1.Substring(0, 7);
        string aZ = Class1.Chga_z_ToA_Z(StrTemp.Substring(index * length, length));
        this.WriteDataBuf[index + 3 + this.ConTestWriteDataTm + this.Con138BegLine] = str3 + aZ;
      }
      Class1.SaveFileDataPro(this.GiFilePathName, this.WriteDataBuf);
    }

    private void SavCurComPro()
    {
      this.WriteDataBuf = Class1.ReadFileDataPro(this.GiFilePathName).Split('\r');
      this.WriteDataBuf[0] = this.comboBox1.Text;
      Class1.SaveFileDataPro(this.GiFilePathName, this.WriteDataBuf);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (this.GbTestMod)
      {
        this.GiCurrDataBuf = this.GetDataFromFacePro();
        this.GiDefDataBuf = this.GiCurrDataBuf;
        this.SavDefDataPro();
      }
      else
      {
        this.comboBox1.Items.Clear();
        for (int index = 1; index <= 32; ++index)
        {
          try
          {
            string str = "COM" + (object) index;
            this.serialPort1.PortName = "COM" + (object) index;
            this.serialPort1.Open();
            this.serialPort1.Close();
            this.comboBox1.Items.Add((object) str);
          }
          catch
          {
          }
        }
        this.LookCurComNo();
        this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox1.Visible = true;
      }
    }

    private byte OpenWkorkComPro()
    {
      try
      {
        this.serialPort1.BaudRate = Convert.ToInt32(this.BaudRadio, 10);
        this.serialPort1.PortName = "COM" + (object) this.CurrentCom;
        this.serialPort1.Open();
        return 1;
      }
      catch
      {
        int num = (int) MessageBox.Show("当前串口" + (object) this.CurrentCom + "：被占用!请选择其它串口！", "RadioName");
        return 0;
      }
    }

    private void ComuDis(object sender, EventArgs e)
    {
      this.listBox1.Items.Add((object) this.ComTempStr);
      this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
    }

    private void SendComDatPro(string TempStr, byte SendByteCt, byte AckByteCt)
    {
      byte[] buffer = new byte[(int) SendByteCt];
      try
      {
        this.ComTempStr = "TX: " + TempStr;
        for (int index = 0; index < (int) SendByteCt; ++index)
        {
          string str = TempStr.Substring(2 * index, 2);
          buffer[index] = Convert.ToByte(str, 16);
        }
        this.SendByte = 0;
        if (this.OnlyOneLine)
          this.SendByte = (int) SendByteCt;
        this.serialPort1.ReceivedBytesThreshold = (int) AckByteCt + this.SendByte;
        this.serialPort1.Write(buffer, 0, (int) SendByteCt);
        this.TimeRestartPro();
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
      }
      catch
      {
        int num = (int) MessageBox.Show("SendComDatPro事件指令:" + (object) this.CommuItem, Class1.RadioName);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        this.button1.Enabled = false;
        if (this.GbTestMod)
        {
          this.GbTestMod = false;
          this.CommuItem = (byte) 1;
          this.listBox1.Items.Add((object) "/**********************退出测试模式*************************/");
          this.SendComDatPro(this.ConExitTestCom, (byte) 13, (byte) 7);
        }
        else
        {
          this.GbTestMod = true;
          this.CommuItem = (byte) 0;
          this.CommuCt = (byte) 0;
          this.GiCurrDataBuf = "";
          this.IicAddress = this.Con138BegAdd;
          this.listBox1.Items.Clear();
          this.listBox1.Items.Add((object) "/**********************进入测试模式*************************/");
          this.SendComDatPro(this.ConEntTestCom, (byte) 13, (byte) 7);
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("button1_Click事件异常", Class1.RadioName);
      }
    }

    private byte GetDataTxRxBytePro(int TxRxCt) => (byte) (14 + (TxRxCt << 1));

    private void SendReadDatAddComPro()
    {
      if ((int) this.CommuCt > this.ConTestReadDataTm)
        return;
      this.SendComDatPro(this.ConTxReadCom + Class1.DataToAscii((long) this.IicAddress, 4) + this.ReadCt_OneTm + "FD", (byte) 12, this.GetDataTxRxBytePro(this.ConOneTmReadCt));
      this.IicAddress += this.ConOneTmReadCt;
    }

    private void SendReadAdjDatComPro() => this.SendComDatPro(this.ConTxReadCom + Class1.DataToAscii((long) this.IicAddress, 4) + "3031FD", (byte) 12, this.GetDataTxRxBytePro(1));

    private string GetChkSum_AddrPro(string TempStr1)
    {
      byte[] Data = new byte[this.ConOneTmWriteCt + 3];
      string[] strArray = new string[this.ConOneTmWriteCt + 3];
      for (int index = 0; index < this.ConOneTmWriteCt + 3; ++index)
        strArray[index] = TempStr1.Substring(2 * index, 2);
      for (int index = 0; index < this.ConOneTmWriteCt + 3; ++index)
        Data[index] = Convert.ToByte(strArray[index], 16);
      TempStr1 = Class1.DataToHexStr((long) (byte) (256U - (uint) Class1.GetChkSumPro(Data)));
      return TempStr1;
    }

    private void SendWriteDatAddComPro(byte CurrData)
    {
      if ((int) this.CommuCt > this.ConTestWriteDataTm)
        return;
      string str1 = CurrData != (byte) 1 ? this.WriteDataBuf[(int) this.CommuCt + 2 + this.Con138BegLine] : this.WriteDataBuf[(int) this.CommuCt + 2 + this.ConTestWriteDataTm + this.Con138BegLine];
      string str2 = str1.Substring(0, 1);
      string str3 = !(str2 == "n") && !(str2 == "\n") ? str1.Substring(6, str1.Length - 6) : str1.Substring(7, str1.Length - 7);
      string str4 = Class1.StrHexAutoAdd0Pro((long) this.IicAddress, (byte) 4) + Class1.StrHexAutoAdd0Pro((long) this.ConOneTmWriteCt, (byte) 2);
      this.GiDefDataBuf += str3;
      string TempStr1 = str4 + str3;
      this.SendComDatPro(this.ConTxWriteCom + Class1.StrToAscii(TempStr1 + this.GetChkSum_AddrPro(TempStr1)) + "FD", this.GetDataTxRxBytePro(this.ConOneTmWriteCt), (byte) 7);
      this.IicAddress += this.ConOneTmWriteCt;
    }

    private void ControlResPro() => Cmx138Set.aTimer1.Enabled = false;

    private void DisDatatoFacePro(string StrTemp)
    {
      try
      {
        string str1 = StrTemp.Substring(0, 2);
        string str2 = StrTemp.Substring(2, 2);
        string str3 = StrTemp.Substring(4, 2);
        string str4 = StrTemp.Substring(6, 4);
        string str5 = StrTemp.Substring(10, 4);
        string str6 = StrTemp.Substring(14, 4);
        string str7 = StrTemp.Substring(18, 4);
        int int32_1 = Convert.ToInt32(str1, 16);
        int num1 = int32_1 & 7;
        if (num1 < this.comboBox11.Items.Count)
          this.comboBox11.SelectedIndex = num1;
        else
          this.comboBox11.SelectedIndex = 4;
        int num2 = (int32_1 & 112) >> 4;
        if (num2 < this.comboBox9.Items.Count)
          this.comboBox9.SelectedIndex = num2;
        else
          this.comboBox9.SelectedIndex = 0;
        int int32_2 = Convert.ToInt32(str2, 16);
        int num3 = int32_2 & 7;
        if (num3 < this.comboBox10.Items.Count)
          this.comboBox10.SelectedIndex = num3;
        else
          this.comboBox10.SelectedIndex = 4;
        int num4 = (int32_2 & 112) >> 4;
        if (num4 < this.comboBox8.Items.Count)
          this.comboBox8.SelectedIndex = num4;
        else
          this.comboBox8.SelectedIndex = 0;
        int int32_3 = Convert.ToInt32(str3, 16);
        int num5 = int32_3 & 15;
        if (num5 < this.comboBox7.Items.Count)
          this.comboBox7.SelectedIndex = num5;
        else
          this.comboBox7.SelectedIndex = 4;
        int num6 = (int32_3 & 240) >> 4;
        if (num6 < this.comboBox6.Items.Count)
          this.comboBox6.SelectedIndex = num6;
        else
          this.comboBox6.SelectedIndex = 0;
        this.textBox11.Text = (Convert.ToInt32(str4, 16) & 16383).ToString();
        this.textBox10.Text = (Convert.ToInt32(str5, 16) & 16383).ToString();
        this.textBox1.Text = (Convert.ToInt32(str6, 16) & 16383).ToString();
        this.textBox2.Text = (Convert.ToInt32(str7, 16) & 16383).ToString();
      }
      catch
      {
        int num = (int) MessageBox.Show("DisDatatoFacePro异常", Class1.RadioName);
      }
    }

    private void SetCommuFailPro()
    {
      this.ComFail = true;
      this.Invoke((Delegate) new EventHandler(this.CtrLResAllPro));
    }

    private void DisplayText(object sender, EventArgs e)
    {
      string strTest = "";
      this.ComFail = false;
      try
      {
        this.TimeRestartPro();
        for (int index = 0; index < this.serialPort1.ReceivedBytesThreshold; ++index)
        {
          string hexStr = Class1.DataToHexStr((long) this.RxBuffer[index]);
          strTest += hexStr;
        }
        string aZ = Class1.Chga_z_ToA_Z(strTest);
        this.ComTempStr = "RX: " + aZ;
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        string str1 = aZ.Substring(2 * this.SendByte, aZ.Length - 2 * this.SendByte);
        if (str1.Substring(str1.Length - 2, 2) != "FD")
        {
          this.SetCommuFailPro();
          if (this.ComFail)
          {
            int num = (int) MessageBox.Show("DisplayText_通信结束符非FD！", Class1.RadioName);
          }
        }
        switch (this.CommuItem)
        {
          case 0:
            if ((byte) 0 == this.CommuCt)
            {
              if (str1.Substring(0, 14) == this.ConAckCom)
              {
                ++this.CommuCt;
                this.IicAddress = this.Con138BegAdd;
                break;
              }
              this.SetCommuFailPro();
              if (this.ComFail)
              {
                int num = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
              }
              break;
            }
            if (str1.Substring(0, 10) == this.ConReadDatAckCom)
            {
              string str2 = Class1.AllAsciiToStr(str1.Substring(10, str1.Length - 11));
              this.GiCurrDataBuf += str2.Substring(6, str2.Length - 8);
              ++this.CommuCt;
              if ((int) this.CommuCt > this.ConTestReadDataTm)
              {
                this.DisDatatoFacePro(this.GiCurrDataBuf);
                Cmx138Set.aTimer1.Enabled = false;
                this.button1.Text = "退出测试模式";
                this.button1.Enabled = true;
                this.button2.Enabled = true;
                this.button3.Text = "保存为默认值";
                this.GbAtLineMod = false;
                this.button9.Enabled = true;
              }
            }
            else
            {
              this.SetCommuFailPro();
              if (this.ComFail)
              {
                int num = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
              }
            }
            break;
          case 1:
            if (str1.Substring(0, 14) == this.ConAckCom)
            {
              Cmx138Set.aTimer1.Enabled = false;
              this.Invoke((Delegate) new EventHandler(this.CtrLResAllPro));
              this.GbAtLineMod = false;
              this.button1.Focus();
              break;
            }
            this.SetCommuFailPro();
            if (this.ComFail)
            {
              int num1 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
            }
            break;
          case 2:
            if (str1.Substring(0, 14) == this.ConAckCom)
            {
              ++this.CommuCt;
              if ((int) this.CommuCt <= this.ConTestWriteDataTm + 1)
                break;
              Cmx138Set.aTimer1.Enabled = false;
              this.GbAtLineMod = false;
              this.button2.Enabled = true;
              this.button8.Enabled = true;
              this.button9.Enabled = true;
              int num2 = (int) MessageBox.Show("批写成功", Class1.RadioName);
              break;
            }
            this.SetCommuFailPro();
            if (this.ComFail)
            {
              int num3 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
            }
            break;
          case 3:
            if (str1.Substring(0, 14) == this.ConAckCom)
            {
              ++this.CommuCt;
              if ((int) this.CommuCt <= this.ConTestWriteDataTm + 1)
                break;
              Cmx138Set.aTimer1.Enabled = false;
              this.GbAtLineMod = false;
              this.button2.Enabled = true;
              this.button8.Enabled = true;
              this.button9.Enabled = true;
              int num4 = (int) MessageBox.Show("写入当前值成功", Class1.RadioName);
              break;
            }
            this.SetCommuFailPro();
            if (this.ComFail)
            {
              int num5 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
            }
            break;
        }
      }
      catch
      {
        this.SetCommuFailPro();
        if (!this.ComFail)
          return;
        int num = (int) MessageBox.Show("DisplayText 异常" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
      }
    }

    private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      this.serialPort1.Read(this.RxBuffer, 0, this.serialPort1.ReceivedBytesThreshold);
      this.GbAtLineMod = true;
      this.Invoke((Delegate) new EventHandler(this.DisplayText));
      if (this.ComFail)
        this.serialPort1.Close();
      else if (!this.GbAtLineMod)
      {
        this.GbItemAjdEn = false;
        this.serialPort1.Close();
      }
      else
      {
        this.GbAtLineMod = false;
        switch (this.CommuItem)
        {
          case 0:
            this.SendReadDatAddComPro();
            break;
          case 2:
            if ((int) this.CommuCt == this.ConTestWriteDataTm + 1)
            {
              this.SendComDatPro(this.ConExtWriModCom, (byte) 13, (byte) 7);
              break;
            }
            this.SendWriteDatAddComPro((byte) 0);
            break;
          case 3:
            if ((int) this.CommuCt == this.ConTestWriteDataTm + 1)
            {
              this.SendComDatPro(this.ConExtWriModCom, (byte) 13, (byte) 7);
              break;
            }
            this.SendWriteDatAddComPro((byte) 1);
            break;
        }
      }
    }

    private void GetDeafaulDataPro()
    {
      this.GiCurrDataBuf = "";
      for (int index = 0; index < this.ConTestWriteDataTm; ++index)
      {
        string str1 = this.WriteDataBuf[index + 3 + this.Con138BegLine];
        string str2 = str1.Substring(1, str1.Length - 1);
        this.GiCurrDataBuf = !(str2 == "n") && !(str2 == "/n") ? str1.Substring(6, str1.Length - 6) : str1.Substring(7, str1.Length - 7);
      }
      this.DisDatatoFacePro(this.GiCurrDataBuf);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        this.button2.Enabled = false;
        this.button8.Enabled = false;
        this.button9.Enabled = false;
        this.GetDeafaulDataPro();
        this.IicAddress = this.Con138BegAdd;
        this.CommuCt = (byte) 0;
        this.CommuItem = (byte) 2;
        this.GiDefDataBuf = "";
        this.listBox1.Items.Add((object) "/**********************批写测试模式*************************/");
        this.SendComDatPro(this.ConWriTestCom, (byte) 13, (byte) 7);
      }
      catch
      {
        int num = (int) MessageBox.Show("button2_Click事件异常", Class1.RadioName);
      }
    }

    private void button6_Click(object sender, EventArgs e)
    {
    }

    private void button7_Click(object sender, EventArgs e)
    {
    }

    private void button4_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        this.CommuItem = (byte) 4;
        this.CommuCt = (byte) 1;
        this.listBox1.Items.Add((object) "/**********************退出当前调试选项*************************/");
        this.SendComDatPro(this.ConExitItemCom, (byte) 13, (byte) 7);
      }
      catch
      {
        int num = (int) MessageBox.Show("button4_Click事件异常", Class1.RadioName);
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
    }

    private string GetAdjItemDataPro1(string StrTemp)
    {
      try
      {
        this.CurrAdjData = Convert.ToInt32(StrTemp, 10);
      }
      catch
      {
        int num = (int) MessageBox.Show("GetAdjItemDataPro1_数据非法", Class1.RadioName);
        this.CurrAdjData = 0;
      }
      StrTemp = Class1.DataToHexStr((long) this.CurrAdjItem);
      string ascii = Class1.StrToAscii(Class1.DataToHexStr((long) this.CurrAdjData));
      StrTemp += ascii;
      return StrTemp;
    }

    private void EntItemComPro()
    {
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => this.EntItemComPro();

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.GetCurComNo();
      this.SavCurComPro();
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
    }

    private void trackBar1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == '\r')
      {
        this.button4_Click(sender, (EventArgs) e);
      }
      else
      {
        if (e.KeyChar != '\u001B')
          return;
        this.button5_Click(sender, (EventArgs) e);
      }
    }

    private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.EntItemComPro();
    }

    private void button8_Click(object sender, EventArgs e) => this.Close();

    private void TestModWin_FormClosed(object sender, FormClosedEventArgs e)
    {
      try
      {
        if (this.GbTestMod && this.OpenWkorkComPro() != (byte) 0)
        {
          this.GbTestMod = false;
          this.CommuItem = (byte) 1;
          byte[] buffer = new byte[13];
          for (int index = 0; index < 13; ++index)
          {
            string str = this.ConExitTestCom.Substring(2 * index, 2);
            buffer[index] = Convert.ToByte(str, 16);
          }
          this.serialPort1.ReceivedBytesThreshold = 50;
          this.serialPort1.Write(buffer, 0, 13);
          if (this.serialPort1.IsOpen)
            this.serialPort1.Close();
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("TestModWin_Leavek事件异常", Class1.RadioName);
      }
    }

    private string GetDataFromFacePro() => Class1.DataToHexStr((long) (this.comboBox11.SelectedIndex | this.comboBox9.SelectedIndex << 4)) + Class1.DataToHexStr((long) (this.comboBox10.SelectedIndex | this.comboBox8.SelectedIndex << 4)) + Class1.DataToHexStr((long) (this.comboBox7.SelectedIndex | this.comboBox6.SelectedIndex << 4)) + Class1.StrHexAutoAdd0Pro((long) Convert.ToInt32(this.textBox11.Text, 10), (byte) 4) + Class1.StrHexAutoAdd0Pro((long) Convert.ToInt32(this.textBox10.Text, 10), (byte) 4) + Class1.StrHexAutoAdd0Pro((long) Convert.ToInt32(this.textBox1.Text, 10), (byte) 4) + Class1.StrHexAutoAdd0Pro((long) Convert.ToInt32(this.textBox2.Text, 10), (byte) 4) + "000000000000000000000000000000000000000000";

    private void button9_Click(object sender, EventArgs e)
    {
      this.SavCurDataPro(this.GetDataFromFacePro());
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        this.button2.Enabled = false;
        this.button8.Enabled = false;
        this.button9.Enabled = false;
        this.CommuCt = (byte) 0;
        this.IicAddress = this.Con138BegAdd;
        this.CommuItem = (byte) 3;
        this.GiDefDataBuf = "";
        this.listBox1.Items.Add((object) "/**********************写入当前值*************************/");
        this.SendComDatPro(this.ConWriTestCom, (byte) 13, (byte) 7);
      }
      catch
      {
        int num = (int) MessageBox.Show("button2_Click事件异常", Class1.RadioName);
      }
    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) => this.comboBox2.SelectedIndex = this.comboBox3.SelectedIndex;

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox4.SelectedIndex == 0)
        this.OnlyOneLine = true;
      else
        this.OnlyOneLine = false;
    }

    private void groupBox3_MouseCaptureChanged(object sender, EventArgs e) => this.listBox1.Visible = !this.listBox1.Visible;

    private void textBox11_TextChanged(object sender, EventArgs e)
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
      this.components = (IContainer) new System.ComponentModel.Container();
      this.groupBox6 = new GroupBox();
      this.groupBox3 = new GroupBox();
      this.button9 = new Button();
      this.button8 = new Button();
      this.button1 = new Button();
      this.button2 = new Button();
      this.listBox1 = new ListBox();
      this.groupBox4 = new GroupBox();
      this.comboBox4 = new ComboBox();
      this.button3 = new Button();
      this.comboBox1 = new ComboBox();
      this.label1 = new Label();
      this.serialPort1 = new SerialPort(this.components);
      this.groupBox7 = new GroupBox();
      this.textBox7 = new TextBox();
      this.label8 = new Label();
      this.label9 = new Label();
      this.textBox9 = new TextBox();
      this.label10 = new Label();
      this.label11 = new Label();
      this.textBox8 = new TextBox();
      this.textBox6 = new TextBox();
      this.groupBox9 = new GroupBox();
      this.groupBox10 = new GroupBox();
      this.textBox4 = new TextBox();
      this.textBox5 = new TextBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.textBox3 = new TextBox();
      this.label4 = new Label();
      this.groupBox11 = new GroupBox();
      this.comboBox5 = new ComboBox();
      this.label5 = new Label();
      this.label6 = new Label();
      this.comboBox2 = new ComboBox();
      this.label7 = new Label();
      this.comboBox3 = new ComboBox();
      this.groupBox1 = new GroupBox();
      this.comboBox6 = new ComboBox();
      this.comboBox7 = new ComboBox();
      this.label12 = new Label();
      this.label13 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.textBox10 = new TextBox();
      this.textBox11 = new TextBox();
      this.comboBox8 = new ComboBox();
      this.comboBox9 = new ComboBox();
      this.comboBox10 = new ComboBox();
      this.comboBox11 = new ComboBox();
      this.label14 = new Label();
      this.label15 = new Label();
      this.label16 = new Label();
      this.label17 = new Label();
      this.label18 = new Label();
      this.label19 = new Label();
      this.label20 = new Label();
      this.label21 = new Label();
      this.groupBox6.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.groupBox10.SuspendLayout();
      this.groupBox11.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox6.Controls.Add((Control) this.groupBox3);
      this.groupBox6.Controls.Add((Control) this.button9);
      this.groupBox6.Controls.Add((Control) this.button8);
      this.groupBox6.Controls.Add((Control) this.button1);
      this.groupBox6.Controls.Add((Control) this.button2);
      this.groupBox6.Location = new Point(12, 231);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(420, 78);
      this.groupBox6.TabIndex = 3;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "groupBox6";
      this.groupBox3.Location = new Point(398, 62);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(10, 10);
      this.groupBox3.TabIndex = 22;
      this.groupBox3.TabStop = false;
      this.groupBox3.MouseCaptureChanged += new EventHandler(this.groupBox3_MouseCaptureChanged);
      this.button9.Location = new Point(212, 22);
      this.button9.Name = "button9";
      this.button9.Size = new Size(96, 38);
      this.button9.TabIndex = 21;
      this.button9.Text = "写入当前值";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.button8.Location = new Point(319, 22);
      this.button8.Name = "button8";
      this.button8.Size = new Size(96, 38);
      this.button8.TabIndex = 20;
      this.button8.Text = "button8";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.button1.Location = new Point(3, 22);
      this.button1.Name = "button1";
      this.button1.Size = new Size(96, 38);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(105, 22);
      this.button2.Name = "button2";
      this.button2.Size = new Size(96, 38);
      this.button2.TabIndex = 1;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.listBox1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.listBox1.FormattingEnabled = true;
      this.listBox1.HorizontalScrollbar = true;
      this.listBox1.ImeMode = ImeMode.NoControl;
      this.listBox1.ItemHeight = 12;
      this.listBox1.Location = new Point(12, 315);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(420, 100);
      this.listBox1.TabIndex = 0;
      this.groupBox4.Controls.Add((Control) this.comboBox4);
      this.groupBox4.Controls.Add((Control) this.button3);
      this.groupBox4.Controls.Add((Control) this.comboBox1);
      this.groupBox4.Controls.Add((Control) this.label1);
      this.groupBox4.Location = new Point(12, 12);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(420, 61);
      this.groupBox4.TabIndex = 1;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "groupBox4";
      this.comboBox4.Enabled = false;
      this.comboBox4.FormattingEnabled = true;
      this.comboBox4.Items.AddRange(new object[2]
      {
        (object) "收发同线",
        (object) "收发异线"
      });
      this.comboBox4.Location = new Point(324, 35);
      this.comboBox4.Name = "comboBox4";
      this.comboBox4.Size = new Size(76, 20);
      this.comboBox4.TabIndex = 9;
      this.comboBox4.Text = "收发同线";
      this.comboBox4.SelectedIndexChanged += new EventHandler(this.comboBox4_SelectedIndexChanged);
      this.button3.Location = new Point(213, 17);
      this.button3.Name = "button3";
      this.button3.Size = new Size(88, 38);
      this.button3.TabIndex = 2;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.comboBox1.Font = new Font("宋体", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(92, 26);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(99, 29);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(26, 37);
      this.label1.Name = "label1";
      this.label1.Size = new Size(59, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "串口选择:";
      this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
      this.groupBox7.Controls.Add((Control) this.textBox7);
      this.groupBox7.Controls.Add((Control) this.label8);
      this.groupBox7.Controls.Add((Control) this.label9);
      this.groupBox7.Controls.Add((Control) this.textBox9);
      this.groupBox7.Controls.Add((Control) this.label10);
      this.groupBox7.Controls.Add((Control) this.label11);
      this.groupBox7.Controls.Add((Control) this.textBox8);
      this.groupBox7.Controls.Add((Control) this.textBox6);
      this.groupBox7.Location = new Point(458, 12);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(420, 77);
      this.groupBox7.TabIndex = 39;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "groupBox7";
      this.textBox7.Location = new Point(352, 20);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new Size(62, 21);
      this.textBox7.TabIndex = 24;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(19, 29);
      this.label8.Name = "label8";
      this.label8.Size = new Size(125, 12);
      this.label8.TabIndex = 19;
      this.label8.Text = "发射频偏: 0X59[15:6]";
      this.label9.AutoSize = true;
      this.label9.Location = new Point(227, 29);
      this.label9.Name = "label9";
      this.label9.Size = new Size(119, 12);
      this.label9.TabIndex = 20;
      this.label9.Text = "亚音频偏: 0X59[5:0]";
      this.textBox9.Location = new Point(352, 47);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new Size(62, 21);
      this.textBox9.TabIndex = 26;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(6, 56);
      this.label10.Name = "label10";
      this.label10.Size = new Size(137, 12);
      this.label10.TabIndex = 21;
      this.label10.Text = "静噪开启值: 0X49[13:7]";
      this.label11.AutoSize = true;
      this.label11.Location = new Point(217, 56);
      this.label11.Name = "label11";
      this.label11.Size = new Size(131, 12);
      this.label11.TabIndex = 22;
      this.label11.Text = "静噪开启值: 0X49[6:0]";
      this.textBox8.Location = new Point(149, 47);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new Size(62, 21);
      this.textBox8.TabIndex = 25;
      this.textBox6.Location = new Point(152, 20);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(62, 21);
      this.textBox6.TabIndex = 23;
      this.groupBox9.Controls.Add((Control) this.groupBox10);
      this.groupBox9.Controls.Add((Control) this.groupBox11);
      this.groupBox9.Location = new Point(458, 101);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new Size(420, 146);
      this.groupBox9.TabIndex = 37;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "声音参数";
      this.groupBox10.Controls.Add((Control) this.textBox4);
      this.groupBox10.Controls.Add((Control) this.textBox5);
      this.groupBox10.Controls.Add((Control) this.label2);
      this.groupBox10.Controls.Add((Control) this.label3);
      this.groupBox10.Controls.Add((Control) this.textBox3);
      this.groupBox10.Controls.Add((Control) this.label4);
      this.groupBox10.Location = new Point(243, 20);
      this.groupBox10.Name = "groupBox10";
      this.groupBox10.Size = new Size(157, 119);
      this.groupBox10.TabIndex = 20;
      this.groupBox10.TabStop = false;
      this.groupBox10.Text = "其它音量参数";
      this.textBox4.Location = new Point(81, 46);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(62, 21);
      this.textBox4.TabIndex = 13;
      this.textBox4.Text = "6";
      this.textBox5.Location = new Point(81, 73);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(62, 21);
      this.textBox5.TabIndex = 14;
      this.textBox5.Text = "0";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(10, 23);
      this.label2.Name = "label2";
      this.label2.Size = new Size(65, 12);
      this.label2.TabIndex = 0;
      this.label2.Text = "0X0A[10:6]";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(16, 50);
      this.label3.Name = "label3";
      this.label3.Size = new Size(59, 12);
      this.label3.TabIndex = 1;
      this.label3.Text = "0X41[6:0]";
      this.textBox3.Location = new Point(81, 14);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(62, 21);
      this.textBox3.TabIndex = 12;
      this.textBox3.Text = "16";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(10, 82);
      this.label4.Name = "label4";
      this.label4.Size = new Size(65, 12);
      this.label4.TabIndex = 2;
      this.label4.Text = "0X44[11:8]";
      this.groupBox11.Controls.Add((Control) this.comboBox5);
      this.groupBox11.Controls.Add((Control) this.label5);
      this.groupBox11.Controls.Add((Control) this.label6);
      this.groupBox11.Controls.Add((Control) this.comboBox2);
      this.groupBox11.Controls.Add((Control) this.label7);
      this.groupBox11.Controls.Add((Control) this.comboBox3);
      this.groupBox11.Location = new Point(17, 20);
      this.groupBox11.Name = "groupBox11";
      this.groupBox11.Size = new Size(211, 119);
      this.groupBox11.TabIndex = 19;
      this.groupBox11.TabStop = false;
      this.groupBox11.Text = "音量大小";
      this.comboBox5.FormattingEnabled = true;
      this.comboBox5.Items.AddRange(new object[9]
      {
        (object) "FF",
        (object) "EE",
        (object) "FC",
        (object) "DD",
        (object) "F8",
        (object) "BB",
        (object) "88",
        (object) "80",
        (object) "00"
      });
      this.comboBox5.Location = new Point(71, 74);
      this.comboBox5.Name = "comboBox5";
      this.comboBox5.Size = new Size(62, 20);
      this.comboBox5.TabIndex = 11;
      this.comboBox5.Text = "FF";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(69, 15);
      this.label5.Name = "label5";
      this.label5.Size = new Size(29, 12);
      this.label5.TabIndex = 3;
      this.label5.Text = "0X42";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(137, 15);
      this.label6.Name = "label6";
      this.label6.Size = new Size(29, 12);
      this.label6.TabIndex = 4;
      this.label6.Text = "0X43";
      this.comboBox2.Enabled = false;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[3]
      {
        (object) "0X0100",
        (object) "0X00A9",
        (object) "0X0045"
      });
      this.comboBox2.Location = new Point(139, 34);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(62, 20);
      this.comboBox2.TabIndex = 8;
      this.comboBox2.Text = "0X0100";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(73, 57);
      this.label7.Name = "label7";
      this.label7.Size = new Size(65, 12);
      this.label7.TabIndex = 5;
      this.label7.Text = "0X44[7:00]";
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Items.AddRange(new object[3]
      {
        (object) "0X1052",
        (object) "0X1036",
        (object) "0X1016"
      });
      this.comboBox3.Location = new Point(71, 34);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new Size(62, 20);
      this.comboBox3.TabIndex = 7;
      this.comboBox3.Text = "0X1052";
      this.comboBox3.SelectedIndexChanged += new EventHandler(this.comboBox3_SelectedIndexChanged);
      this.groupBox1.Controls.Add((Control) this.comboBox6);
      this.groupBox1.Controls.Add((Control) this.comboBox7);
      this.groupBox1.Controls.Add((Control) this.label12);
      this.groupBox1.Controls.Add((Control) this.label13);
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Controls.Add((Control) this.textBox2);
      this.groupBox1.Controls.Add((Control) this.textBox10);
      this.groupBox1.Controls.Add((Control) this.textBox11);
      this.groupBox1.Controls.Add((Control) this.comboBox8);
      this.groupBox1.Controls.Add((Control) this.comboBox9);
      this.groupBox1.Controls.Add((Control) this.comboBox10);
      this.groupBox1.Controls.Add((Control) this.comboBox11);
      this.groupBox1.Controls.Add((Control) this.label14);
      this.groupBox1.Controls.Add((Control) this.label15);
      this.groupBox1.Controls.Add((Control) this.label16);
      this.groupBox1.Controls.Add((Control) this.label17);
      this.groupBox1.Controls.Add((Control) this.label18);
      this.groupBox1.Controls.Add((Control) this.label19);
      this.groupBox1.Controls.Add((Control) this.label20);
      this.groupBox1.Controls.Add((Control) this.label21);
      this.groupBox1.Location = new Point(16, 75);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(416, 172);
      this.groupBox1.TabIndex = 40;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      this.comboBox6.FormattingEnabled = true;
      this.comboBox6.Items.AddRange(new object[16]
      {
        (object) "Mute",
        (object) "-22.4dB",
        (object) "-19.2dB",
        (object) "-16.0dB",
        (object) "-12.8dB",
        (object) "-9.6dB",
        (object) "-6.4dB",
        (object) "-3.2dB",
        (object) "0dB",
        (object) "3.2dB",
        (object) "6.4dB",
        (object) "9.6dB",
        (object) "12.8dB",
        (object) "16.0dB",
        (object) "19.2 dB",
        (object) "22.4 dB"
      });
      this.comboBox6.Location = new Point(319, 138);
      this.comboBox6.Name = "comboBox6";
      this.comboBox6.Size = new Size(62, 20);
      this.comboBox6.TabIndex = 41;
      this.comboBox6.Text = "6.4dB";
      this.comboBox7.FormattingEnabled = true;
      this.comboBox7.Items.AddRange(new object[16]
      {
        (object) "Mute",
        (object) "-22.4dB",
        (object) "-19.2dB",
        (object) "-16.0dB",
        (object) "-12.8dB",
        (object) "-9.6dB",
        (object) "-6.4dB",
        (object) "-3.2dB",
        (object) "0dB",
        (object) "3.2dB",
        (object) "6.4dB",
        (object) "9.6dB",
        (object) "12.8dB",
        (object) "16.0dB",
        (object) "19.2 dB",
        (object) "22.4 dB"
      });
      this.comboBox7.Location = new Point(125, 138);
      this.comboBox7.Name = "comboBox7";
      this.comboBox7.Size = new Size(62, 20);
      this.comboBox7.TabIndex = 40;
      this.comboBox7.Text = "12.8dB";
      this.label12.AutoSize = true;
      this.label12.Location = new Point(206, 146);
      this.label12.Name = "label12";
      this.label12.Size = new Size(107, 12);
      this.label12.TabIndex = 39;
      this.label12.Text = "Disc_Au By 增益db";
      this.label13.AutoSize = true;
      this.label13.Location = new Point(17, 146);
      this.label13.Name = "label13";
      this.label13.Size = new Size(107, 12);
      this.label13.TabIndex = 38;
      this.label13.Text = "Mic_Mod By 增益db";
      this.textBox1.Location = new Point(319, 109);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(62, 21);
      this.textBox1.TabIndex = 37;
      this.textBox1.Text = "0";
      this.textBox2.Location = new Point(319, 52);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(62, 21);
      this.textBox2.TabIndex = 36;
      this.textBox2.Text = "0";
      this.textBox10.Location = new Point(125, 108);
      this.textBox10.Name = "textBox10";
      this.textBox10.Size = new Size(62, 21);
      this.textBox10.TabIndex = 35;
      this.textBox10.Text = "0";
      this.textBox11.Location = new Point(125, 49);
      this.textBox11.Name = "textBox11";
      this.textBox11.Size = new Size(62, 21);
      this.textBox11.TabIndex = 34;
      this.textBox11.Text = "0";
      this.textBox11.TextChanged += new EventHandler(this.textBox11_TextChanged);
      this.comboBox8.FormattingEnabled = true;
      this.comboBox8.Items.AddRange(new object[8]
      {
        (object) "Mute",
        (object) "-19.2dB",
        (object) "-16.0dB",
        (object) "-12.8dB",
        (object) "-9.6dB",
        (object) "-6.4dB",
        (object) "-3.2dB",
        (object) "0dB"
      });
      this.comboBox8.Location = new Point(319, 81);
      this.comboBox8.Name = "comboBox8";
      this.comboBox8.Size = new Size(62, 20);
      this.comboBox8.TabIndex = 33;
      this.comboBox8.Text = "0dB";
      this.comboBox9.FormattingEnabled = true;
      this.comboBox9.Items.AddRange(new object[8]
      {
        (object) "0dB",
        (object) "3.2dB",
        (object) "6.4dB",
        (object) "9.6dB",
        (object) "12.8dB",
        (object) "16.0dB",
        (object) "19.2dB",
        (object) "22.4dB"
      });
      this.comboBox9.Location = new Point(319, 17);
      this.comboBox9.Name = "comboBox9";
      this.comboBox9.Size = new Size(62, 20);
      this.comboBox9.TabIndex = 32;
      this.comboBox9.Text = "6.4dB";
      this.comboBox10.FormattingEnabled = true;
      this.comboBox10.Items.AddRange(new object[8]
      {
        (object) "Mute",
        (object) "-19.2dB",
        (object) "-16.0dB",
        (object) "-12.8dB",
        (object) "-9.6dB",
        (object) "-6.4dB",
        (object) "-3.2dB",
        (object) "0dB"
      });
      this.comboBox10.Location = new Point(125, 79);
      this.comboBox10.Name = "comboBox10";
      this.comboBox10.Size = new Size(62, 20);
      this.comboBox10.TabIndex = 31;
      this.comboBox10.Text = "0dB";
      this.comboBox11.FormattingEnabled = true;
      this.comboBox11.Items.AddRange(new object[8]
      {
        (object) "0dB",
        (object) "3.2dB",
        (object) "6.4dB",
        (object) "9.6dB",
        (object) "12.8dB",
        (object) "16.0dB",
        (object) "19.2dB",
        (object) "22.4dB"
      });
      this.comboBox11.Location = new Point(125, 20);
      this.comboBox11.Name = "comboBox11";
      this.comboBox11.Size = new Size(62, 20);
      this.comboBox11.TabIndex = 30;
      this.comboBox11.Text = "12.8dB";
      this.label14.AutoSize = true;
      this.label14.Location = new Point(206, 112);
      this.label14.Name = "label14";
      this.label14.Size = new Size(113, 12);
      this.label14.TabIndex = 29;
      this.label14.Text = "Audio微调(0～2A73)";
      this.label15.AutoSize = true;
      this.label15.Location = new Point(206, 59);
      this.label15.Name = "label15";
      this.label15.Size = new Size(107, 12);
      this.label15.TabIndex = 28;
      this.label15.Text = "Disc微调(0～2A73)";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(206, 89);
      this.label16.Name = "label16";
      this.label16.Size = new Size(101, 12);
      this.label16.TabIndex = 27;
      this.label16.Text = "AUDIO Out 增益db";
      this.label17.AutoSize = true;
      this.label17.Location = new Point(206, 25);
      this.label17.Name = "label17";
      this.label17.Size = new Size(107, 12);
      this.label17.TabIndex = 26;
      this.label17.Text = "Disc Input 增益db";
      this.label18.AutoSize = true;
      this.label18.Location = new Point(17, 112);
      this.label18.Name = "label18";
      this.label18.Size = new Size(95, 12);
      this.label18.TabIndex = 25;
      this.label18.Text = "MOD微调(0-2A73)";
      this.label19.AutoSize = true;
      this.label19.Location = new Point(17, 54);
      this.label19.Name = "label19";
      this.label19.Size = new Size(101, 12);
      this.label19.TabIndex = 24;
      this.label19.Text = "MIC微调(0～2A73)";
      this.label20.AutoSize = true;
      this.label20.Location = new Point(17, 83);
      this.label20.Name = "label20";
      this.label20.Size = new Size(89, 12);
      this.label20.TabIndex = 23;
      this.label20.Text = "Mod Out 增益db";
      this.label21.AutoSize = true;
      this.label21.Location = new Point(17, 25);
      this.label21.Name = "label21";
      this.label21.Size = new Size(101, 12);
      this.label21.TabIndex = 22;
      this.label21.Text = "Mic Input 增益db";
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(444, 421);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.listBox1);
      this.Controls.Add((Control) this.groupBox6);
      this.Controls.Add((Control) this.groupBox7);
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.groupBox9);
      this.Name = nameof (Cmx138Set);
      this.Text = nameof (Cmx138Set);
      this.Load += new EventHandler(this.TestModWin_Load);
      this.FormClosed += new FormClosedEventHandler(this.TestModWin_FormClosed);
      this.groupBox6.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.groupBox9.ResumeLayout(false);
      this.groupBox10.ResumeLayout(false);
      this.groupBox10.PerformLayout();
      this.groupBox11.ResumeLayout(false);
      this.groupBox11.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
