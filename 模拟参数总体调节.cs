// Decompiled with JetBrains decompiler
// Type: _8890DTest.模拟参数总体调节
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace _8890DTest
{
  public class 模拟参数总体调节 : Form
  {
    private static System.Timers.Timer aTimer;
    private bool GbRxEnable = false;
    private bool GbPTTon = false;
    private bool GbPTTOff = false;
    private bool GbAdjEn = false;
    private Decimal CurrAdjData;
    private Label[] Label_Arr;
    private NumericUpDown[] Numer_Arr;
    private int GbCommDelay = 15;
    private Button[] Button_Arr;
    private int FielBegRow = 3;
    private int ConOneRowDatCt = 32;
    private int ConReadLength = 14;
    private int ConOneTmReadCt = 32;
    private int ConOneTmWriteCt = 32;
    private int ConMaxReadAdrr = 5823;
    private int ConMaxWriteAdrr = 5759;
    private int ConFreadjAddr = 512;
    private int ConAdjTetBegAdd = 6400;
    private int ConBatadjAddr = 6400;
    public string GiFilePathName = "AllTestModDef.icf";
    public string BaudRadio = "38400";
    private string ConCodeBuf = "FAIL";
    private string GiCurComm = "";
    private int IicAddress;
    private string DataBuffer;
    private bool OnlyOneLine = false;
    private bool ComFail = false;
    public int CurrentCom = 1;
    private int SendByte = 0;
    public bool GbReadMod = true;
    public bool GbWriteMod = false;
    private bool GbAtLineMod = false;
    private bool GbTestMod = false;
    private byte[] RxBuffer = new byte[200];
    private string[] WriteDataBuf;
    private byte CommuItem = 0;
    private byte CommuCt = 0;
    private int GiTestWriteDataTm = 3;
    public bool R_W_Succeed = false;
    private string GiDefDataBuf;
    private string GiCurrDataBuf;
    private string ComTempStr;
    private bool ComunicationDisEn = true;
    private bool GbFirComEn = true;
    private int CurRow;
    private int CurCol;
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private ListBox listBox1;
    private ComboBox comboBox5;
    private Button button2;
    private Button button1;
    private SerialPort serialPort1;
    private GroupBox groupBox1;
    private Label label8;
    private Button button3;
    private Button button4;
    private GroupBox groupBox2;
    private Label label10;
    private Label label9;
    private Label label19;
    private GroupBox groupBox3;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label14;
    private Label label15;
    private Label label16;
    private NumericUpDown numericUpDown17;
    private Label label17;
    private Label label18;
    private NumericUpDown numericUpDown3;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private NumericUpDown numericUpDown18;
    private NumericUpDown numericUpDown16;
    private NumericUpDown numericUpDown14;
    private NumericUpDown numericUpDown12;
    private NumericUpDown numericUpDown10;
    private NumericUpDown numericUpDown8;
    private NumericUpDown numericUpDown6;
    private NumericUpDown numericUpDown7;
    private NumericUpDown numericUpDown15;
    private NumericUpDown numericUpDown13;
    private NumericUpDown numericUpDown11;
    private NumericUpDown numericUpDown9;
    private NumericUpDown numericUpDown5;
    private NumericUpDown numericUpDown4;
    private NumericUpDown numericUpDown20;
    private Label label21;
    private NumericUpDown numericUpDown19;
    private Label label20;
    private ComboBox comboBox1;
    private MenuStrip menuStrip;
    private ToolStripMenuItem helpMenu;
    private ToolStripSeparator toolStripSeparator8;
    private Button button5;
    private Button button6;
    private Button button7;
    private ComboBox comboBox2;
    private Label label22;
    private NumericUpDown numericUpDown21;
    private Label label23;
    private NumericUpDown numericUpDown22;
    private Label label24;
    private NumericUpDown numericUpDown25;
    private NumericUpDown numericUpDown26;
    private Label label27;
    private Label label28;
    private NumericUpDown numericUpDown23;
    private NumericUpDown numericUpDown24;
    private Label label25;
    private Label label26;
    private NumericUpDown numericUpDown29;
    private Label label31;
    private NumericUpDown numericUpDown27;
    private NumericUpDown numericUpDown28;
    private Label label29;
    private Label label30;
    private TextBox textBox1;
    private Label label32;
    private CheckBox checkBox3;
    private CheckBox checkBox2;
    private ComboBox comboBox3;
    private Label label33;
    private CheckBox checkBox1;
    private CheckBox checkBox4;

    private void TimerResPro()
    {
      模拟参数总体调节.aTimer = new System.Timers.Timer(10000.0);
      模拟参数总体调节.aTimer.Elapsed += new ElapsedEventHandler(this.OnTimedEvent);
      模拟参数总体调节.aTimer.Interval = 1000.0;
      模拟参数总体调节.aTimer.Enabled = false;
    }

    private void TimeRestartPro()
    {
      模拟参数总体调节.aTimer.Enabled = false;
      模拟参数总体调节.aTimer.Interval = 3000.0;
      模拟参数总体调节.aTimer.Enabled = true;
    }

    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
      this.GbAtLineMod = false;
      if (this.serialPort1.IsOpen)
        this.serialPort1.Close();
      模拟参数总体调节.aTimer.Enabled = false;
      if (this.GbFirComEn)
      {
        int num1 = (int) MessageBox.Show("通信失败，请检查连接或选择正确串口！", "RadioName");
      }
      else
      {
        int num2 = (int) MessageBox.Show("通信超时", "RadioName");
      }
      this.Invoke((Delegate) new EventHandler(this.ControlResPro1));
    }

    private void ControlResPro()
    {
      模拟参数总体调节.aTimer.Enabled = false;
      this.button1.Enabled = true;
      this.button2.Enabled = true;
      this.button3.Enabled = true;
    }

    private void ControlResPro1(object sender, EventArgs e)
    {
      模拟参数总体调节.aTimer.Enabled = false;
      for (int index = 0; index <= 6; ++index)
        this.Button_Arr[index].Enabled = true;
      if (this.GbPTTon && this.CommuCt <= (byte) 4 || this.GbRxEnable && this.CommuCt <= (byte) 2)
      {
        this.GbPTTon = false;
        this.GbRxEnable = false;
      }
      else
      {
        this.GbAdjEn = false;
        this.Invoke((Delegate) new EventHandler(this.CtrlSet));
      }
    }

    private void LoadControlResPro(object sender, EventArgs e)
    {
      模拟参数总体调节.aTimer.Enabled = false;
      for (int index = 0; index <= 6; ++index)
        this.Button_Arr[index].Enabled = false;
      this.Button_Arr[2].Enabled = true;
      for (int index = 0; index <= 20; ++index)
        this.Label_Arr[index].Enabled = true;
      this.GbAdjEn = false;
      this.GbRxEnable = false;
      this.GbPTTon = false;
      this.button1.Text = "开始发射调节";
      this.button2.Text = "开始接收调节";
    }

    public 模拟参数总体调节()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (this.GbAdjEn || this.GbPTTon && this.CommuCt <= (byte) 4 || this.GbRxEnable && this.CommuCt <= (byte) 2)
        return;
      if (this.serialPort1.IsOpen)
        return;
      try
      {
        this.serialPort1.Open();
        this.AdjContrlEnPro();
        this.ComTempStr = "##调节项目:频率  指令:3030   长度:3034##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        string freDataPro = this.GetFreDataPro();
        this.GiCurComm = freDataPro;
        this.SendComDatPro(freDataPro, (byte) 18, (byte) 7);
      }
      catch
      {
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (!this.GbRxEnable)
      {
        this.GbRxEnable = true;
        if (this.GbPTTon)
        {
          this.GbPTTon = false;
          try
          {
            if (this.GbTestMod)
            {
              if (this.OpenWkorkComPro() == (byte) 0)
                return;
              this.CommuItem = (byte) 3;
              this.listBox1.Items.Add((object) "/**********************退出调试项模式*************************/");
              this.SendComDatPro("FEFEEEEFF355563838093039FD", (byte) 13, (byte) 7);
            }
          }
          catch
          {
          }
        }
        for (int index = 2; index <= 15; ++index)
        {
          this.Numer_Arr[index].Enabled = false;
          this.Label_Arr[index].Enabled = false;
        }
        this.button2.Text = "结束接收调节";
        this.button1.Text = "开始发射调节";
        this.Numer_Arr[0].Enabled = true;
        this.Numer_Arr[1].Enabled = true;
        this.Label_Arr[0].Enabled = true;
        this.Label_Arr[1].Enabled = true;
        for (int index = 16; index <= 19; ++index)
        {
          this.Numer_Arr[index].Enabled = true;
          this.Label_Arr[index].Enabled = true;
        }
      }
      else
      {
        this.GbRxEnable = false;
        for (int index = 2; index <= 15; ++index)
        {
          this.Numer_Arr[index].Enabled = true;
          this.Label_Arr[index].Enabled = true;
        }
        this.button2.Text = "开始接收调节";
        try
        {
          if (this.GbTestMod && this.OpenWkorkComPro() != (byte) 0)
          {
            this.CommuItem = (byte) 3;
            this.listBox1.Items.Add((object) "/**********************退出调试项模式*************************/");
            this.SendComDatPro("FEFEEEEFF355563838093039FD", (byte) 13, (byte) 7);
          }
        }
        catch
        {
        }
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
      if (!this.ComunicationDisEn)
        return;
      this.listBox1.Items.Add((object) this.ComTempStr);
      this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
    }

    private void CtrlSet(object sender, EventArgs e)
    {
      if (this.GbRxEnable)
      {
        this.Label_Arr[0].Enabled = false;
        for (int index = 0; index <= 6; ++index)
          this.Label_Arr[index].Enabled = false;
        for (int index = 0; index <= 6; ++index)
          this.Numer_Arr[index].Enabled = false;
        this.Numer_Arr[1].Enabled = true;
      }
      else
      {
        if (!this.GbPTTon)
          return;
        for (int index = 0; index <= 6; ++index)
          this.Label_Arr[index].Enabled = true;
        this.Label_Arr[1].Enabled = false;
        for (int index = 0; index <= 6; ++index)
          this.Numer_Arr[index].Enabled = true;
        this.Numer_Arr[1].Enabled = false;
      }
    }

    private void SendComDatPro(string TempStr, byte SendByteCt, byte AckByteCt)
    {
      byte[] buffer = new byte[(int) SendByteCt];
      Thread.Sleep(this.GbCommDelay);
      this.ComTempStr = "TX: " + TempStr;
      this.Invoke((Delegate) new EventHandler(this.ComuDis));
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
      Thread.Sleep(30);
      this.TimeRestartPro();
    }

    private string GetUp_DownDataPro(NumericUpDown numericUpDownContrl, int length)
    {
      string StrTemp;
      try
      {
        StrTemp = Class1.ConvertString(numericUpDownContrl.Value.ToString(), 10, 16);
      }
      catch
      {
        StrTemp = "55";
      }
      if (StrTemp.Length < length)
      {
        int num = length - StrTemp.Length;
        for (int index = 0; index < num; ++index)
          StrTemp = "0" + StrTemp;
      }
      return Class1.StrToAscii(StrTemp);
    }

    private string GetFreDataPro()
    {
      string StrTemp;
      try
      {
        StrTemp = "400.000";
      }
      catch
      {
        StrTemp = "400.000";
      }
      return "FEFEEEEFA030303034" + Class1.StrToAscii(Class2.ChgRxFreToDataPro(StrTemp)) + "FD";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!this.GbPTTon)
      {
        this.GbRxEnable = false;
        this.GbPTTon = true;
        for (int index = 2; index <= 15; ++index)
        {
          this.Numer_Arr[index].Enabled = true;
          this.Label_Arr[index].Enabled = true;
        }
        this.button1.Text = "结束发射调节";
        this.button2.Text = "开始接收调节";
        this.Numer_Arr[0].Enabled = false;
        this.Numer_Arr[1].Enabled = false;
        this.Label_Arr[0].Enabled = false;
        this.Label_Arr[1].Enabled = false;
        for (int index = 16; index <= 19; ++index)
        {
          this.Numer_Arr[index].Enabled = false;
          this.Label_Arr[index].Enabled = false;
        }
      }
      else
      {
        try
        {
          if (this.GbTestMod)
          {
            if (this.OpenWkorkComPro() == (byte) 0)
              return;
            this.CommuItem = (byte) 3;
            this.listBox1.Items.Add((object) "/**********************退出调试项模式*************************/");
            this.SendComDatPro("FEFEEEEFF355563838093039FD", (byte) 13, (byte) 7);
          }
        }
        catch
        {
        }
        this.GbPTTon = false;
        this.Numer_Arr[0].Enabled = true;
        this.Numer_Arr[1].Enabled = true;
        this.Label_Arr[0].Enabled = true;
        this.Label_Arr[1].Enabled = true;
        for (int index = 16; index <= 19; ++index)
        {
          this.Numer_Arr[index].Enabled = true;
          this.Label_Arr[index].Enabled = true;
        }
        this.button1.Text = "开始发射调节";
      }
    }

    private void AdjContrlEnPro()
    {
      this.GbAdjEn = true;
      if (this.GbPTTon)
      {
        this.CommuCt = (byte) 4;
      }
      else
      {
        if (!this.GbRxEnable)
          return;
        this.CommuCt = (byte) 2;
      }
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      if (this.GbAdjEn || this.CommuCt <= (byte) 4)
        return;
      if (this.serialPort1.IsOpen)
        return;
      try
      {
        this.serialPort1.Open();
        this.AdjContrlEnPro();
        this.ComTempStr = "##调节项目:频率微调  指令:3132   长度:3031##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        this.SendComDatPro("FEFEEEEFA031323031" + this.GetUp_DownDataPro(this.numericUpDown1, 2) + "FD", (byte) 12, (byte) 7);
      }
      catch
      {
      }
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
      if (!this.GbRxEnable || this.GbAdjEn || this.CommuCt <= (byte) 2)
        return;
      if (this.serialPort1.IsOpen)
        return;
      try
      {
        this.serialPort1.Open();
        this.AdjContrlEnPro();
        this.ComTempStr = "##调节项目:静噪调节  指令:3133   长度:3031##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        this.SendComDatPro("FEFEEEEFA031333031" + this.GetUp_DownDataPro(this.numericUpDown2, 2) + "FD", (byte) 12, (byte) 7);
      }
      catch
      {
      }
    }

    private void numericUpDown5_ValueChanged(object sender, EventArgs e)
    {
      if (this.GbAdjEn || this.CommuCt <= (byte) 4)
        return;
      if (this.serialPort1.IsOpen)
        return;
      try
      {
        this.serialPort1.Open();
        this.AdjContrlEnPro();
        this.ComTempStr = "##调节项目:高功调节  指令:3135   长度:3031##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        this.SendComDatPro("FEFEEEEFA031353031" + this.GetUp_DownDataPro(this.numericUpDown5, 2) + "FD", (byte) 12, (byte) 7);
      }
      catch
      {
      }
    }

    private void numericUpDown3_ValueChanged(object sender, EventArgs e)
    {
      if (this.GbAdjEn || this.CommuCt <= (byte) 4)
        return;
      if (this.serialPort1.IsOpen)
        return;
      try
      {
        this.serialPort1.Open();
        this.AdjContrlEnPro();
        this.ComTempStr = "##调节项目:频偏调节  指令:3136   长度:3031##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        this.SendComDatPro("FEFEEEEFA031363031" + this.GetUp_DownDataPro(this.numericUpDown3, 2) + "FD", (byte) 12, (byte) 7);
      }
      catch
      {
      }
    }

    private void numericUpDown4_ValueChanged(object sender, EventArgs e)
    {
      if (this.GbAdjEn || this.CommuCt <= (byte) 4)
        return;
      if (this.serialPort1.IsOpen)
        return;
      try
      {
        this.serialPort1.Open();
        this.AdjContrlEnPro();
        this.ComTempStr = "##调节项目:低功调节  指令:3134   长度:3031##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        this.SendComDatPro("FEFEEEEFA031343031" + this.GetUp_DownDataPro(this.numericUpDown4, 2) + "FD", (byte) 12, (byte) 7);
      }
      catch
      {
      }
    }

    private void numericUpDown6_ValueChanged(object sender, EventArgs e)
    {
      if (this.GbAdjEn || this.CommuCt <= (byte) 4)
        return;
      if (this.serialPort1.IsOpen)
        return;
      try
      {
        this.serialPort1.Open();
        this.AdjContrlEnPro();
        this.ComTempStr = "##调节项目:数字亚音  指令:3137   长度:3031##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        this.SendComDatPro("FEFEEEEFA031373031" + this.GetUp_DownDataPro(this.numericUpDown6, 2) + "FD", (byte) 12, (byte) 7);
      }
      catch
      {
      }
    }

    private void numericUpDown7_ValueChanged(object sender, EventArgs e)
    {
      if (this.GbAdjEn || this.CommuCt <= (byte) 4)
        return;
      if (this.serialPort1.IsOpen)
        return;
      try
      {
        this.serialPort1.Open();
        this.AdjContrlEnPro();
        this.ComTempStr = "##调节项目:模拟亚音  指令:3138   长度:3031##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        this.SendComDatPro("FEFEEEEFA031383031" + this.GetUp_DownDataPro(this.numericUpDown7, 2) + "FD", (byte) 12, (byte) 7);
      }
      catch
      {
      }
    }

    private void SetContrlAs_arrPro()
    {
      this.Label_Arr = new Label[21];
      this.Label_Arr[0] = this.label2;
      this.Label_Arr[1] = this.label13;
      this.Label_Arr[2] = this.label3;
      this.Label_Arr[3] = this.label9;
      this.Label_Arr[4] = this.label4;
      this.Label_Arr[5] = this.label14;
      this.Label_Arr[6] = this.label12;
      this.Label_Arr[7] = this.label15;
      this.Label_Arr[8] = this.label5;
      this.Label_Arr[9] = this.label16;
      this.Label_Arr[10] = this.label7;
      this.Label_Arr[11] = this.label17;
      this.Label_Arr[12] = this.label6;
      this.Label_Arr[13] = this.label18;
      this.Label_Arr[14] = this.label10;
      this.Label_Arr[15] = this.label11;
      this.Label_Arr[16] = this.label20;
      this.Label_Arr[17] = this.label21;
      this.Label_Arr[18] = this.label8;
      this.Label_Arr[19] = this.label1;
      this.Label_Arr[20] = this.label19;
      this.Numer_Arr = new NumericUpDown[20];
      this.Numer_Arr[0] = this.numericUpDown1;
      this.Numer_Arr[1] = this.numericUpDown2;
      this.Numer_Arr[2] = this.numericUpDown3;
      this.Numer_Arr[3] = this.numericUpDown4;
      this.Numer_Arr[4] = this.numericUpDown5;
      this.Numer_Arr[5] = this.numericUpDown6;
      this.Numer_Arr[6] = this.numericUpDown7;
      this.Numer_Arr[7] = this.numericUpDown8;
      this.Numer_Arr[8] = this.numericUpDown9;
      this.Numer_Arr[9] = this.numericUpDown10;
      this.Numer_Arr[10] = this.numericUpDown11;
      this.Numer_Arr[11] = this.numericUpDown12;
      this.Numer_Arr[12] = this.numericUpDown13;
      this.Numer_Arr[13] = this.numericUpDown14;
      this.Numer_Arr[14] = this.numericUpDown15;
      this.Numer_Arr[15] = this.numericUpDown16;
      this.Numer_Arr[16] = this.numericUpDown19;
      this.Numer_Arr[17] = this.numericUpDown20;
      this.Numer_Arr[0] = this.numericUpDown17;
      this.Numer_Arr[1] = this.numericUpDown18;
      this.Button_Arr = new Button[7];
      this.Button_Arr[0] = this.button1;
      this.Button_Arr[1] = this.button2;
      this.Button_Arr[2] = this.button3;
      this.Button_Arr[3] = this.button4;
      this.Button_Arr[4] = this.button5;
      this.Button_Arr[5] = this.button6;
      this.Button_Arr[6] = this.button7;
    }

    public void LoadFileDataDisPro()
    {
      string str1 = "";
      try
      {
        this.WriteDataBuf = Class1.ReadFileDataPro(this.GiFilePathName).Split('\r');
        for (int index = 0; index < 1; ++index)
        {
          string str2 = Class2.AutoAdd_n_Pro(this.WriteDataBuf[index + 3]);
          string str3 = str2.Substring(0, 1);
          str1 = !(str3 == "\n") && !(str3 == "n") ? str1 + str2.Substring(6, str2.Length - 6) : str1 + str2.Substring(7, str2.Length - 7);
        }
        string str4 = str1;
        this.GiDefDataBuf = str4;
        this.GiCurrDataBuf = str4;
        this.DisDatatoGridViewXX();
      }
      catch
      {
      }
    }

    private void AngSet_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.SetContrlAs_arrPro();
      for (int index = 0; index <= 6; ++index)
      {
        this.Numer_Arr[index].Maximum = 128M;
        this.Numer_Arr[index].Hexadecimal = false;
      }
      this.Numer_Arr[0].Maximum = 255M;
      this.TimerResPro();
      this.comboBox1.SelectedIndex = 1;
      this.comboBox2.SelectedIndex = 1;
      this.comboBox5.SelectedIndex = 1;
      this.comboBox3.SelectedIndex = 1;
      Class1.GetAllTestDefFilePro(this.GiFilePathName);
      this.LoadFileDataDisPro();
    }

    private void SetDisDataPro(int i, int ArrPt)
    {
      try
      {
        int int32 = Convert.ToInt32(this.GiCurrDataBuf.Substring(i * 2, 2), 16);
        this.Numer_Arr[ArrPt].Value = (Decimal) int32;
      }
      catch
      {
        int num = (int) MessageBox.Show("读出的数据异常", Class1.RadioName);
      }
    }

    private void DisDatatoGridViewXX()
    {
      try
      {
        this.SetDisDataPro(0, 0);
        int num1 = Convert.ToInt32(this.GiCurrDataBuf.Substring(2, 2), 16);
        if (num1 >= 16)
          num1 = 3;
        this.numericUpDown18.Value = (Decimal) num1;
        int num2;
        switch (Convert.ToInt32(this.GiCurrDataBuf.Substring(4, 2), 16))
        {
          case 160:
            num2 = 0;
            break;
          case 224:
            num2 = 1;
            break;
          default:
            num2 = 1;
            break;
        }
        this.comboBox1.SelectedIndex = num2;
        this.comboBox2.SelectedIndex = Convert.ToInt32(this.GiCurrDataBuf.Substring(6, 2), 16) & 1;
        int num3 = Convert.ToInt32(this.GiCurrDataBuf.Substring(8, 2), 16);
        if (num3 >= 16)
          num3 = 13;
        this.numericUpDown21.Value = (Decimal) num3;
        int num4 = Convert.ToInt32(this.GiCurrDataBuf.Substring(10, 2), 16);
        if (num4 >= 16)
          num4 = 13;
        this.numericUpDown22.Value = (Decimal) num4;
        int num5 = Convert.ToInt32(this.GiCurrDataBuf.Substring(12, 2), 16);
        if (num5 >= 63)
          num5 = 55;
        this.numericUpDown26.Value = (Decimal) num5;
        int num6 = Convert.ToInt32(this.GiCurrDataBuf.Substring(14, 2), 16);
        if (num6 >= 63)
          num6 = 48;
        this.numericUpDown27.Value = (Decimal) num6;
        int num7 = Convert.ToInt32(this.GiCurrDataBuf.Substring(16, 2), 16);
        if (num7 >= 63)
          num7 = 8;
        this.numericUpDown28.Value = (Decimal) num7;
        int num8 = Convert.ToInt32(this.GiCurrDataBuf.Substring(18, 2), 16);
        if (num8 >= 63)
          num8 = 42;
        this.numericUpDown29.Value = (Decimal) num8;
        int num9 = Convert.ToInt32(this.GiCurrDataBuf.Substring(20, 2), 16);
        if (num9 >= 63)
          num9 = 12;
        this.numericUpDown23.Value = (Decimal) num9;
        int num10 = Convert.ToInt32(this.GiCurrDataBuf.Substring(22, 2), 16);
        if (num10 >= 63)
          num10 = 31;
        this.numericUpDown24.Value = (Decimal) num10;
        int num11 = Convert.ToInt32(this.GiCurrDataBuf.Substring(24, 2), 16);
        if (num11 >= 63)
          num11 = 3;
        this.numericUpDown25.Value = (Decimal) num11;
        int int32 = Convert.ToInt32(this.GiCurrDataBuf.Substring(26, 2), 16);
        int num12 = int32 & 15;
        if (num12 >= 3)
          this.comboBox3.SelectedIndex = 3;
        else
          this.comboBox3.SelectedIndex = num12;
        this.checkBox2.Checked = (int32 & 16) == 0;
        this.checkBox3.Checked = (int32 & 32) == 0;
        this.checkBox1.Checked = (int32 & 64) == 0;
        if ((int32 & 128) == 0)
          this.checkBox4.Checked = true;
        else
          this.checkBox4.Checked = false;
      }
      catch
      {
        int num = (int) MessageBox.Show("读出的数据异常", Class1.RadioName);
      }
    }

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

    private string SendWriteDatAddComPro()
    {
      string str = "";
      if ((int) this.CommuCt > this.GiTestWriteDataTm)
        return "";
      if ((byte) 1 == this.CommuCt)
      {
        this.ComTempStr = "##保存数据1: 长度:3031##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        str = this.GiDefDataBuf.Substring(0, this.GiDefDataBuf.Length);
        this.IicAddress = this.ConAdjTetBegAdd;
      }
      string TempStr1 = Class1.DataToStrPro((long) this.IicAddress, 8) + Class1.DataToStrPro((long) this.ConOneTmReadCt, 4) + str;
      return "FEFEEEEFE4" + (TempStr1 + this.GetChkSum_AddrPro(TempStr1)) + "FD";
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
          string str = Convert.ToString(this.RxBuffer[index], 16);
          if (str.Length == 1)
            str = "0" + str;
          strTest += str;
        }
        string aZ = Class1.Chga_z_ToA_Z(strTest);
        this.ComTempStr = "RX: " + aZ;
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        string str1 = aZ.Substring(2 * this.SendByte, aZ.Length - 2 * this.SendByte);
        if (str1.Substring(str1.Length - 2, 2) != "FD")
        {
          this.ComFail = true;
          int num = (int) MessageBox.Show("通信结束非FD！", Class1.RadioName);
          this.Invoke((Delegate) new EventHandler(this.ControlResPro1));
        }
        else
        {
          switch (this.CommuItem)
          {
            case 0:
              if (str1.Substring(0, 14) == "FEFEEFEEE600FD")
              {
                ++this.CommuCt;
                if (this.GbRxEnable)
                {
                  switch (this.CommuCt)
                  {
                    case 1:
                      this.ComTempStr = "##调节项目:频率  指令:3030   长度:3034##";
                      this.Invoke((Delegate) new EventHandler(this.ComuDis));
                      this.GiCurComm = this.GetFreDataPro();
                      break;
                    case 2:
                      this.ComTempStr = "##调节项目:静噪调节  指令:3133   长度:3031##";
                      this.Invoke((Delegate) new EventHandler(this.ComuDis));
                      this.GiCurComm = "FEFEEEEFA031333031" + this.GetUp_DownDataPro(this.numericUpDown2, 2) + "FD";
                      break;
                    case 3:
                      this.GbAtLineMod = false;
                      模拟参数总体调节.aTimer.Enabled = false;
                      this.Invoke((Delegate) new EventHandler(this.CtrlSet));
                      break;
                  }
                }
                else
                {
                  if (this.GbPTTon)
                  {
                    switch (this.CommuCt)
                    {
                      case 1:
                        this.ComTempStr = "##调节项目:频率调节  指令:3132    长度:3031##";
                        this.Invoke((Delegate) new EventHandler(this.ComuDis));
                        this.GiCurComm = "FEFEEEEFA031323031" + this.GetUp_DownDataPro(this.numericUpDown1, 2) + "FD";
                        break;
                      case 2:
                        this.ComTempStr = "##调节项目:低功调节  指令:3134  长度:3031##";
                        this.Invoke((Delegate) new EventHandler(this.ComuDis));
                        this.GiCurComm = "FEFEEEEFA031343031" + this.GetUp_DownDataPro(this.numericUpDown4, 2) + "FD";
                        break;
                      case 3:
                        this.ComTempStr = "##调节项目:频偏调节  指令:3136   长度:3031##";
                        this.Invoke((Delegate) new EventHandler(this.ComuDis));
                        this.GiCurComm = "FEFEEEEFA031363031" + this.GetUp_DownDataPro(this.numericUpDown3, 2) + "FD";
                        break;
                      case 4:
                        this.ComTempStr = "##调节项目:模拟发射  指令:3535   长度:3031##";
                        this.Invoke((Delegate) new EventHandler(this.ComuDis));
                        this.GiCurComm = "FEFEEEEFA0353530313333FD";
                        break;
                      case 5:
                        this.GbAtLineMod = false;
                        模拟参数总体调节.aTimer.Enabled = false;
                        this.ControlResPro();
                        break;
                    }
                    break;
                  }
                  break;
                }
              }
              else
              {
                this.ComFail = true;
                int num = (int) MessageBox.Show("应答信号出错！", Class1.RadioName);
                this.Invoke((Delegate) new EventHandler(this.ControlResPro1));
              }
              break;
            case 1:
              ++this.CommuCt;
              if (str1.Substring(0, 14) == "FEFEEFEEE600FD")
              {
                switch (this.CommuCt)
                {
                  case 1:
                    this.GiCurComm = this.SendWriteDatAddComPro();
                    break;
                  case 2:
                    this.ComTempStr = "##保存成功##############";
                    this.Invoke((Delegate) new EventHandler(this.ComuDis));
                    this.GiCurComm = "FEFEEEEFF755563838000000FD";
                    this.GbAtLineMod = false;
                    模拟参数总体调节.aTimer.Enabled = false;
                    int num1 = (int) MessageBox.Show("写入成功！", Class1.RadioName);
                    break;
                }
              }
              else
              {
                this.ComFail = true;
                int num2 = (int) MessageBox.Show("写入当前值应答信号出错！", Class1.RadioName);
                this.Invoke((Delegate) new EventHandler(this.ControlResPro1));
              }
              break;
            case 2:
              if ((byte) 0 == this.CommuCt)
              {
                if (str1.Substring(0, 14) == "FEFEEFEEE600FD")
                {
                  ++this.CommuCt;
                  this.IicAddress = this.ConAdjTetBegAdd;
                  this.ConOneTmReadCt = 32;
                  this.GiCurComm = "FEFEEEEFEB" + (Class1.DataToStrPro((long) this.IicAddress, 8) + Class1.DataToStrPro((long) this.ConReadLength, 4)) + "FD";
                  break;
                }
                this.ComFail = true;
                int num3 = (int) MessageBox.Show("写入当前值应答信号出错！", Class1.RadioName);
                this.Invoke((Delegate) new EventHandler(this.ControlResPro1));
                break;
              }
              if (this.GiTestWriteDataTm == (int) this.CommuCt)
              {
                ++this.CommuCt;
                if (str1.Substring(0, 10) == "FEFEEFEEE4")
                {
                  string str2 = str1.Substring(10, str1.Length - 11);
                  this.GiCurrDataBuf = str2.Substring(12, str2.Length - 12);
                  this.DisDatatoGridViewXX();
                  this.GbAtLineMod = false;
                  模拟参数总体调节.aTimer.Enabled = false;
                  this.Invoke((Delegate) new EventHandler(this.ControlResPro1));
                  int num4 = (int) MessageBox.Show("读取成功！", Class1.RadioName);
                  this.GbTestMod = true;
                }
                break;
              }
              break;
            case 3:
              if (str1.Substring(0, 14) == "FEFEEFEEE600FD")
              {
                模拟参数总体调节.aTimer.Enabled = false;
                this.GbAtLineMod = false;
                break;
              }
              if (this.ComFail)
              {
                int num5 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
              }
              break;
            case 7:
              if ((byte) 0 == this.CommuCt)
              {
                if (str1.Substring(0, 14) == "FEFEEFEEE600FD")
                {
                  ++this.CommuCt;
                  this.IicAddress = this.ConBatadjAddr;
                  break;
                }
                if (this.ComFail)
                {
                  int num6 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
                }
                break;
              }
              if (str1.Substring(0, 10) == "FEFEEFEEE4")
              {
                模拟参数总体调节.aTimer.Enabled = false;
                string str3 = str1.Substring(10, str1.Length - 12);
                string str4 = str3.Substring(12, str3.Length - 14);
                ++this.CommuCt;
                if (this.CommuCt > (byte) 1)
                {
                  int int32 = Convert.ToInt32(str4, 16);
                  this.GbAdjEn = true;
                  this.Numer_Arr[0].Value = (Decimal) int32;
                  this.GbAtLineMod = false;
                }
              }
              else if (this.ComFail)
              {
                int num7 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
              }
              break;
            case 8:
              if (str1.Substring(0, 14) == "FEFEEFEEE600FD")
              {
                模拟参数总体调节.aTimer.Enabled = false;
                this.GbAtLineMod = false;
                this.Invoke((Delegate) new EventHandler(this.LoadControlResPro));
                break;
              }
              if (this.ComFail)
              {
                int num8 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
              }
              break;
          }
        }
      }
      catch
      {
        this.ComFail = true;
        int num = (int) MessageBox.Show("语法错误！", "RadioName");
        this.ControlResPro();
      }
    }

    private byte GetDataTxRxBytePro(int TxRxCt) => (byte) (13 + TxRxCt);

    private void SendReadAdjDatComPro() => this.SendComDatPro("FEFEEEEFEB" + Class1.StrHexAutoAdd0Pro((long) this.IicAddress, (byte) 8) + "0001FD", (byte) 12, this.GetDataTxRxBytePro(1));

    private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      this.serialPort1.Read(this.RxBuffer, 0, this.serialPort1.ReceivedBytesThreshold);
      this.GbAtLineMod = true;
      this.Invoke((Delegate) new EventHandler(this.DisplayText));
      if (this.ComFail)
      {
        this.serialPort1.Close();
      }
      else
      {
        if (!this.GbAtLineMod)
        {
          this.serialPort1.Close();
          this.GbAdjEn = false;
        }
        else
          this.GbAtLineMod = false;
        switch (this.CommuItem)
        {
          case 0:
            if (this.GbPTTon && this.CommuCt <= (byte) 4 || this.GbRxEnable && this.CommuCt <= (byte) 2)
            {
              this.SendComDatPro(this.GiCurComm, (byte) (this.GiCurComm.Length / 2), (byte) 7);
              break;
            }
            this.Invoke((Delegate) new EventHandler(this.ControlResPro1));
            break;
          case 1:
            if (this.CommuCt <= (byte) 1)
            {
              this.SendComDatPro(this.GiCurComm, (byte) (this.GiCurComm.Length / 2), (byte) 7);
              break;
            }
            this.CommuItem = (byte) 0;
            this.Invoke((Delegate) new EventHandler(this.ControlResPro1));
            break;
          case 2:
            if (this.CommuCt <= (byte) 1)
            {
              this.SendComDatPro(this.GiCurComm, (byte) 12, this.GetDataTxRxBytePro(this.ConReadLength));
              break;
            }
            this.CommuItem = (byte) 0;
            this.Invoke((Delegate) new EventHandler(this.ControlResPro1));
            break;
          case 7:
            if (this.CommuCt == (byte) 1)
            {
              this.SendReadAdjDatComPro();
              break;
            }
            break;
        }
      }
    }

    private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox5.SelectedIndex == 0)
        this.OnlyOneLine = true;
      else
        this.OnlyOneLine = false;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        this.GbCommDelay = (int) Convert.ToInt16(this.textBox1.Text, 10);
        this.CommuCt = (byte) 0;
        this.CommuItem = (byte) 2;
        this.GiTestWriteDataTm = 1;
        this.listBox1.Items.Clear();
        this.GiCurrDataBuf = "";
        this.ComTempStr = "##读取当前内容##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        Thread.Sleep(1000);
        this.SendComDatPro("FEFEEEEFF055563838000000FD", (byte) 13, (byte) 7);
      }
      catch
      {
        int num = (int) MessageBox.Show("button2_Click事件异常", Class1.RadioName);
      }
    }

    private string GetUp_DownData1Pro(NumericUpDown numericUpDownContrl, byte length)
    {
      string StrTemp;
      try
      {
        StrTemp = numericUpDownContrl.Value.ToString();
      }
      catch
      {
        StrTemp = "64";
      }
      return Class1.StrAutoAdd0Pro(Class1.ConvertString(StrTemp, 10, 16), length);
    }

    private string GetCurstrDataPro()
    {
      string str1 = "" + this.GetUp_DownData1Pro(this.Numer_Arr[0], (byte) 2) + this.GetUp_DownData1Pro(this.Numer_Arr[1], (byte) 2);
      string str2 = 0 != this.comboBox1.SelectedIndex ? str1 + "E0" : str1 + "A0";
      return (1 != this.comboBox2.SelectedIndex ? str2 + "00" : str2 + "01") + this.GetUp_DownData1Pro(this.numericUpDown21, (byte) 2) + this.GetUp_DownData1Pro(this.numericUpDown22, (byte) 2) + this.GetUp_DownData1Pro(this.numericUpDown26, (byte) 2) + this.GetUp_DownData1Pro(this.numericUpDown27, (byte) 2) + this.GetUp_DownData1Pro(this.numericUpDown28, (byte) 2) + this.GetUp_DownData1Pro(this.numericUpDown29, (byte) 2) + this.GetUp_DownData1Pro(this.numericUpDown23, (byte) 2) + this.GetUp_DownData1Pro(this.numericUpDown24, (byte) 2) + this.GetUp_DownData1Pro(this.numericUpDown25, (byte) 2) + Class1.DataToHexStr((long) (this.comboBox3.SelectedIndex | (this.checkBox2.Checked ? 0 : 1) << 4 | (this.checkBox3.Checked ? 0 : 1) << 5 | (this.checkBox1.Checked ? 0 : 1) << 6 | (this.checkBox4.Checked ? 0 : 1) << 7)) + "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
    }

    private void button4_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        this.CommuCt = (byte) 0;
        this.CommuItem = (byte) 1;
        this.GbCommDelay = (int) Convert.ToInt16(this.textBox1.Text, 10);
        this.listBox1.Items.Clear();
        this.GiTestWriteDataTm = 1;
        this.GiDefDataBuf = this.GetCurstrDataPro();
        this.ComTempStr = "##保存当前内容##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        Thread.Sleep(1000);
        this.SendComDatPro("FEFEEEEFF255563838000000FD", (byte) 13, (byte) 7);
      }
      catch
      {
        int num = (int) MessageBox.Show("button2_Click事件异常", Class1.RadioName);
      }
    }

    private void AngSet_FormClosed(object sender, FormClosedEventArgs e)
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
            string str = "FEFEEEEFF155563838000000FD".Substring(2 * index, 2);
            buffer[index] = Convert.ToByte(str, 16);
          }
          this.serialPort1.ReceivedBytesThreshold = 50;
          this.serialPort1.Write(buffer, 0, 13);
          do
            ;
          while ((byte) this.serialPort1.BytesToWrite != (byte) 0);
          this.serialPort1.Close();
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("TestModWin_Leavek事件异常", Class1.RadioName);
      }
    }

    private void label10_Click(object sender, EventArgs e)
    {
    }

    private void EnterItemModPro(string StrTemp, string StrTemp1, string StrTemp2)
    {
      this.GbAdjEn = true;
      StrTemp = "FEFEEEEFFA5556" + StrTemp1 + StrTemp + "FD";
      if (StrTemp2 == "是")
      {
        this.CommuItem = (byte) 7;
        this.CommuCt = (byte) 0;
      }
      else
        this.CommuItem = (byte) 3;
      this.SendComDatPro(StrTemp, (byte) 13, (byte) 7);
    }

    private void numericUpDown17_ValueChanged(object sender, EventArgs e)
    {
      if (this.GbTestMod)
        this.GbRxEnable = true;
      if (!this.GbRxEnable || this.GbAdjEn)
        return;
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        this.EnterItemModPro("02203030", "30", "是");
      }
      catch
      {
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if ((!this.GbRxEnable || this.GbAdjEn) && (!this.GbPTTon || this.GbAdjEn))
        return;
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        switch (this.comboBox1.SelectedIndex)
        {
          case 0:
            this.EnterItemModPro("02224130", "30", "否");
            break;
          case 1:
            this.EnterItemModPro("02224530", "30", "否");
            break;
          case 2:
            this.EnterItemModPro("02223630", "30", "否");
            break;
        }
      }
      catch
      {
      }
    }

    private void numericUpDownX_ValueChanged(
      NumericUpDown numericUpDownContrl,
      string StrList,
      string StrRang)
    {
      if (!this.GbPTTon || this.GbAdjEn)
        return;
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        string upDownDataPro = this.GetUp_DownDataPro(numericUpDownContrl, 2);
        this.EnterItemModPro(StrList + upDownDataPro, StrRang, "否");
      }
      catch
      {
      }
    }

    private void numericUpDownX_ValueChangedRx(
      NumericUpDown numericUpDownContrl,
      string StrList,
      string StrRang)
    {
      if (!this.GbRxEnable || this.GbAdjEn)
        return;
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        string upDownDataPro = this.GetUp_DownDataPro(numericUpDownContrl, 2);
        this.EnterItemModPro(StrList + upDownDataPro, StrRang, "否");
      }
      catch
      {
      }
    }

    private void numericUpDown3_ValueChanged_1(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown3, "0200", "30");

    private void numericUpDown4_ValueChanged_1(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown4, "0201", "30");

    private void numericUpDown5_ValueChanged_1(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown5, "0202", "30");

    private void numericUpDown9_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown9, "0203", "30");

    private void numericUpDown11_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown11, "0204", "30");

    private void numericUpDown13_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown13, "0205", "30");

    private void numericUpDown15_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown15, "0206", "30");

    private void numericUpDown1_ValueChanged_1(object sender, EventArgs e) => this.numericUpDownX_ValueChangedRx(this.numericUpDown1, "0207", "30");

    private void numericUpDown19_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChangedRx(this.numericUpDown19, "0208", "30");

    private void numericUpDown6_ValueChanged_1(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown6, "0200", "32");

    private void numericUpDown7_ValueChanged_1(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown7, "0201", "32");

    private void numericUpDown8_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown8, "0202", "32");

    private void numericUpDown10_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown10, "0203", "32");

    private void numericUpDown12_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown12, "0204", "32");

    private void numericUpDown14_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown14, "0205", "32");

    private void numericUpDown16_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChanged(this.numericUpDown16, "0206", "32");

    private void numericUpDown2_ValueChanged_1(object sender, EventArgs e) => this.numericUpDownX_ValueChangedRx(this.numericUpDown2, "0207", "32");

    private void numericUpDown20_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChangedRx(this.numericUpDown20, "0208", "32");

    private void numericUpDown18_ValueChanged(object sender, EventArgs e) => this.numericUpDownX_ValueChangedRx(this.numericUpDown18, "0221", "30");

    private void helpMenu_Click(object sender, EventArgs e)
    {
      int num = (int) new 车台调试使用说明().ShowDialog((IWin32Window) this);
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void button6_Click(object sender, EventArgs e)
    {
      string str1 = "";
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        this.CommuCt = (byte) 0;
        this.CommuItem = (byte) 1;
        this.GbCommDelay = (int) Convert.ToInt16(this.textBox1.Text, 10);
        this.listBox1.Items.Clear();
        this.GiTestWriteDataTm = 1;
        this.WriteDataBuf = Class1.ReadFileDataPro(this.GiFilePathName).Split('\r');
        for (int index = 0; index < 1; ++index)
        {
          string str2 = Class2.AutoAdd_n_Pro(this.WriteDataBuf[index + 3]);
          string str3 = str2.Substring(0, 1);
          str1 = !(str3 == "\n") && !(str3 == "n") ? str1 + str2.Substring(6, str2.Length - 6) : str1 + str2.Substring(7, str2.Length - 7);
        }
        this.GiDefDataBuf = str1;
        this.ComTempStr = "##保存当前内容##";
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        Thread.Sleep(1000);
        this.SendComDatPro("FEFEEEEFF255563838000000FD", (byte) 13, (byte) 7);
      }
      catch
      {
        int num = (int) MessageBox.Show("button2_Click事件异常", Class1.RadioName);
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.WriteDataBuf = Class1.ReadFileDataPro(this.GiFilePathName).Split('\r');
      this.GiDefDataBuf = this.GetCurstrDataPro();
      this.GiDefDataBuf = Class1.Chga_z_ToA_Z(this.GiDefDataBuf);
      int length = Class1.ConOneRowDatCt * 2;
      for (int index = 0; index < 1; ++index)
      {
        string str1 = Class2.AutoAdd_n_Pro(this.WriteDataBuf[index + 3]).Substring(0, 7);
        string str2 = this.GiDefDataBuf.Substring(index * length, length);
        this.WriteDataBuf[index + 3] = str1 + str2;
      }
      Class1.SaveFileDataPro(this.GiFilePathName, this.WriteDataBuf);
    }

    private void button7_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.GbTestMod && this.OpenWkorkComPro() != (byte) 0)
        {
          this.GbTestMod = false;
          this.CommuItem = (byte) 8;
          this.listBox1.Items.Add((object) "/**********************退出测试模式*************************/");
          Thread.Sleep(1000);
          this.SendComDatPro("FEFEEEEFF155563838000000FD", (byte) 13, (byte) 7);
        }
      }
      catch
      {
      }
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.GbTestMod)
        this.GbRxEnable = true;
      if ((!this.GbRxEnable || this.GbAdjEn) && (!this.GbPTTon || this.GbAdjEn))
        return;
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        switch (this.comboBox2.SelectedIndex)
        {
          case 0:
            this.EnterItemModPro("02230000", "30", "否");
            break;
          case 1:
            this.EnterItemModPro("02230100", "30", "否");
            break;
        }
      }
      catch
      {
      }
    }

    private void helpMenu_DoubleClick(object sender, EventArgs e)
    {
    }

    private void label8_Click(object sender, EventArgs e)
    {
    }

    private void label8_DoubleClick(object sender, EventArgs e)
    {
      if (this.label32.Enabled)
      {
        this.label32.Enabled = false;
        this.label32.Visible = false;
        this.textBox1.Enabled = false;
        this.textBox1.Visible = false;
      }
      else
      {
        this.label32.Enabled = true;
        this.label32.Visible = true;
        this.textBox1.Enabled = true;
        this.textBox1.Visible = true;
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.checkBox2.Checked = this.comboBox3.SelectedIndex == 0;
      if (this.comboBox3.SelectedIndex == 1)
        this.checkBox1.Checked = true;
      else
        this.checkBox1.Checked = false;
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
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.label7 = new Label();
      this.listBox1 = new ListBox();
      this.comboBox5 = new ComboBox();
      this.button2 = new Button();
      this.button1 = new Button();
      this.serialPort1 = new SerialPort(this.components);
      this.groupBox1 = new GroupBox();
      this.comboBox3 = new ComboBox();
      this.label33 = new Label();
      this.checkBox3 = new CheckBox();
      this.checkBox2 = new CheckBox();
      this.textBox1 = new TextBox();
      this.label32 = new Label();
      this.numericUpDown29 = new NumericUpDown();
      this.label31 = new Label();
      this.numericUpDown27 = new NumericUpDown();
      this.numericUpDown22 = new NumericUpDown();
      this.numericUpDown28 = new NumericUpDown();
      this.label24 = new Label();
      this.label29 = new Label();
      this.numericUpDown21 = new NumericUpDown();
      this.label30 = new Label();
      this.label23 = new Label();
      this.numericUpDown25 = new NumericUpDown();
      this.comboBox2 = new ComboBox();
      this.label22 = new Label();
      this.numericUpDown26 = new NumericUpDown();
      this.button7 = new Button();
      this.label27 = new Label();
      this.button5 = new Button();
      this.button6 = new Button();
      this.label28 = new Label();
      this.numericUpDown17 = new NumericUpDown();
      this.numericUpDown18 = new NumericUpDown();
      this.numericUpDown23 = new NumericUpDown();
      this.button3 = new Button();
      this.button4 = new Button();
      this.numericUpDown24 = new NumericUpDown();
      this.label8 = new Label();
      this.label25 = new Label();
      this.label26 = new Label();
      this.comboBox1 = new ComboBox();
      this.label19 = new Label();
      this.groupBox3 = new GroupBox();
      this.numericUpDown20 = new NumericUpDown();
      this.label21 = new Label();
      this.numericUpDown14 = new NumericUpDown();
      this.numericUpDown12 = new NumericUpDown();
      this.numericUpDown16 = new NumericUpDown();
      this.numericUpDown10 = new NumericUpDown();
      this.numericUpDown8 = new NumericUpDown();
      this.numericUpDown6 = new NumericUpDown();
      this.numericUpDown7 = new NumericUpDown();
      this.numericUpDown2 = new NumericUpDown();
      this.label12 = new Label();
      this.label13 = new Label();
      this.label14 = new Label();
      this.label11 = new Label();
      this.label15 = new Label();
      this.label16 = new Label();
      this.label17 = new Label();
      this.label18 = new Label();
      this.groupBox2 = new GroupBox();
      this.numericUpDown19 = new NumericUpDown();
      this.numericUpDown13 = new NumericUpDown();
      this.numericUpDown3 = new NumericUpDown();
      this.label20 = new Label();
      this.numericUpDown11 = new NumericUpDown();
      this.numericUpDown9 = new NumericUpDown();
      this.numericUpDown1 = new NumericUpDown();
      this.numericUpDown15 = new NumericUpDown();
      this.numericUpDown5 = new NumericUpDown();
      this.label10 = new Label();
      this.numericUpDown4 = new NumericUpDown();
      this.label9 = new Label();
      this.menuStrip = new MenuStrip();
      this.helpMenu = new ToolStripMenuItem();
      this.toolStripSeparator8 = new ToolStripSeparator();
      this.checkBox1 = new CheckBox();
      this.checkBox4 = new CheckBox();
      this.groupBox1.SuspendLayout();
      this.numericUpDown29.BeginInit();
      this.numericUpDown27.BeginInit();
      this.numericUpDown22.BeginInit();
      this.numericUpDown28.BeginInit();
      this.numericUpDown21.BeginInit();
      this.numericUpDown25.BeginInit();
      this.numericUpDown26.BeginInit();
      this.numericUpDown17.BeginInit();
      this.numericUpDown18.BeginInit();
      this.numericUpDown23.BeginInit();
      this.numericUpDown24.BeginInit();
      this.groupBox3.SuspendLayout();
      this.numericUpDown20.BeginInit();
      this.numericUpDown14.BeginInit();
      this.numericUpDown12.BeginInit();
      this.numericUpDown16.BeginInit();
      this.numericUpDown10.BeginInit();
      this.numericUpDown8.BeginInit();
      this.numericUpDown6.BeginInit();
      this.numericUpDown7.BeginInit();
      this.numericUpDown2.BeginInit();
      this.groupBox2.SuspendLayout();
      this.numericUpDown19.BeginInit();
      this.numericUpDown13.BeginInit();
      this.numericUpDown3.BeginInit();
      this.numericUpDown11.BeginInit();
      this.numericUpDown9.BeginInit();
      this.numericUpDown1.BeginInit();
      this.numericUpDown15.BeginInit();
      this.numericUpDown5.BeginInit();
      this.numericUpDown4.BeginInit();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(21, 84);
      this.label1.Name = "label1";
      this.label1.Size = new Size(65, 12);
      this.label1.TabIndex = 9;
      this.label1.Text = "按键音大小";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(287, 58);
      this.label2.Name = "label2";
      this.label2.Size = new Size(53, 12);
      this.label2.TabIndex = 11;
      this.label2.Text = "静噪调节";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(6, 29);
      this.label3.Name = "label3";
      this.label3.Size = new Size(53, 12);
      this.label3.TabIndex = 13;
      this.label3.Text = "低功调节";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(6, 99);
      this.label4.Name = "label4";
      this.label4.Size = new Size(53, 12);
      this.label4.TabIndex = 15;
      this.label4.Text = "高功调节";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(154, 29);
      this.label5.Name = "label5";
      this.label5.Size = new Size(53, 12);
      this.label5.TabIndex = 17;
      this.label5.Text = "频偏调节";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(154, 99);
      this.label6.Name = "label6";
      this.label6.Size = new Size(53, 12);
      this.label6.TabIndex = 19;
      this.label6.Text = "模拟亚音";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(154, 63);
      this.label7.Name = "label7";
      this.label7.Size = new Size(53, 12);
      this.label7.TabIndex = 21;
      this.label7.Text = "数字亚音";
      this.listBox1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.listBox1.FormattingEnabled = true;
      this.listBox1.HorizontalScrollbar = true;
      this.listBox1.ImeMode = ImeMode.NoControl;
      this.listBox1.ItemHeight = 12;
      this.listBox1.Location = new Point(0, 287);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(436, 64);
      this.listBox1.TabIndex = 27;
      this.comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox5.FormattingEnabled = true;
      this.comboBox5.Items.AddRange(new object[2]
      {
        (object) "单线",
        (object) "双线"
      });
      this.comboBox5.Location = new Point(646, 42);
      this.comboBox5.Name = "comboBox5";
      this.comboBox5.Size = new Size(60, 20);
      this.comboBox5.TabIndex = 26;
      this.comboBox5.Visible = false;
      this.comboBox5.SelectedIndexChanged += new EventHandler(this.comboBox5_SelectedIndexChanged);
      this.button2.Enabled = false;
      this.button2.Location = new Point(1068, 145);
      this.button2.Name = "button2";
      this.button2.Size = new Size(67, 32);
      this.button2.TabIndex = 24;
      this.button2.Text = "开始接收调节";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Visible = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.Enabled = false;
      this.button1.Location = new Point(1079, 185);
      this.button1.Name = "button1";
      this.button1.Size = new Size(67, 32);
      this.button1.TabIndex = 23;
      this.button1.Text = "开始发射调节";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
      this.groupBox1.Controls.Add((Control) this.checkBox4);
      this.groupBox1.Controls.Add((Control) this.checkBox1);
      this.groupBox1.Controls.Add((Control) this.comboBox3);
      this.groupBox1.Controls.Add((Control) this.label33);
      this.groupBox1.Controls.Add((Control) this.checkBox3);
      this.groupBox1.Controls.Add((Control) this.checkBox2);
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Controls.Add((Control) this.label32);
      this.groupBox1.Controls.Add((Control) this.numericUpDown29);
      this.groupBox1.Controls.Add((Control) this.label31);
      this.groupBox1.Controls.Add((Control) this.numericUpDown27);
      this.groupBox1.Controls.Add((Control) this.numericUpDown22);
      this.groupBox1.Controls.Add((Control) this.numericUpDown28);
      this.groupBox1.Controls.Add((Control) this.label24);
      this.groupBox1.Controls.Add((Control) this.label29);
      this.groupBox1.Controls.Add((Control) this.numericUpDown21);
      this.groupBox1.Controls.Add((Control) this.label30);
      this.groupBox1.Controls.Add((Control) this.label23);
      this.groupBox1.Controls.Add((Control) this.numericUpDown25);
      this.groupBox1.Controls.Add((Control) this.comboBox2);
      this.groupBox1.Controls.Add((Control) this.label22);
      this.groupBox1.Controls.Add((Control) this.numericUpDown26);
      this.groupBox1.Controls.Add((Control) this.button7);
      this.groupBox1.Controls.Add((Control) this.label27);
      this.groupBox1.Controls.Add((Control) this.button5);
      this.groupBox1.Controls.Add((Control) this.button6);
      this.groupBox1.Controls.Add((Control) this.label28);
      this.groupBox1.Controls.Add((Control) this.numericUpDown17);
      this.groupBox1.Controls.Add((Control) this.numericUpDown18);
      this.groupBox1.Controls.Add((Control) this.numericUpDown23);
      this.groupBox1.Controls.Add((Control) this.button3);
      this.groupBox1.Controls.Add((Control) this.button4);
      this.groupBox1.Controls.Add((Control) this.numericUpDown24);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.label25);
      this.groupBox1.Controls.Add((Control) this.label26);
      this.groupBox1.Location = new Point(1, 28);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(436, 253);
      this.groupBox1.TabIndex = 28;
      this.groupBox1.TabStop = false;
      this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Items.AddRange(new object[4]
      {
        (object) "希腊",
        (object) "欧美",
        (object) "泰国",
        (object) "其它"
      });
      this.comboBox3.Location = new Point(231, 133);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new Size(60, 20);
      this.comboBox3.TabIndex = 62;
      this.comboBox3.SelectedIndexChanged += new EventHandler(this.comboBox3_SelectedIndexChanged);
      this.label33.AutoSize = true;
      this.label33.Location = new Point(166, 141);
      this.label33.Name = "label33";
      this.label33.Size = new Size(53, 12);
      this.label33.TabIndex = 63;
      this.label33.Text = "使用国家";
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new Point(307, 131);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new Size(108, 16);
      this.checkBox3.TabIndex = 61;
      this.checkBox3.Text = "上下屏模式分开";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new Point(307, 107);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(126, 16);
      this.checkBox2.TabIndex = 60;
      this.checkBox2.Text = "隐藏 W/N 菜单显示";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.textBox1.Location = new Point(110, 161);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(48, 21);
      this.textBox1.TabIndex = 59;
      this.textBox1.Text = "15";
      this.textBox1.Visible = false;
      this.label32.AutoSize = true;
      this.label32.Location = new Point(34, 166);
      this.label32.Name = "label32";
      this.label32.Size = new Size(65, 12);
      this.label32.TabIndex = 58;
      this.label32.Text = "Delay Time";
      this.label32.Visible = false;
      this.numericUpDown29.Location = new Point(232, 102);
      this.numericUpDown29.Maximum = new Decimal(new int[4]
      {
        62,
        0,
        0,
        0
      });
      this.numericUpDown29.Name = "numericUpDown29";
      this.numericUpDown29.Size = new Size(60, 21);
      this.numericUpDown29.TabIndex = 57;
      this.numericUpDown29.Value = new Decimal(new int[4]
      {
        42,
        0,
        0,
        0
      });
      this.label31.AutoSize = true;
      this.label31.Location = new Point(173, 111);
      this.label31.Name = "label31";
      this.label31.Size = new Size(53, 12);
      this.label31.TabIndex = 56;
      this.label31.Text = "Tone_Low";
      this.numericUpDown27.Location = new Point(231, 48);
      this.numericUpDown27.Maximum = new Decimal(new int[4]
      {
        62,
        0,
        0,
        0
      });
      this.numericUpDown27.Name = "numericUpDown27";
      this.numericUpDown27.Size = new Size(60, 21);
      this.numericUpDown27.TabIndex = 55;
      this.numericUpDown27.Value = new Decimal(new int[4]
      {
        48,
        0,
        0,
        0
      });
      this.numericUpDown22.Location = new Point(98, 133);
      this.numericUpDown22.Maximum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.numericUpDown22.Name = "numericUpDown22";
      this.numericUpDown22.Size = new Size(60, 21);
      this.numericUpDown22.TabIndex = 43;
      this.numericUpDown22.Value = new Decimal(new int[4]
      {
        13,
        0,
        0,
        0
      });
      this.numericUpDown28.Location = new Point(231, 75);
      this.numericUpDown28.Maximum = new Decimal(new int[4]
      {
        62,
        0,
        0,
        0
      });
      this.numericUpDown28.Name = "numericUpDown28";
      this.numericUpDown28.Size = new Size(60, 21);
      this.numericUpDown28.TabIndex = 54;
      this.numericUpDown28.Value = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.label24.AutoSize = true;
      this.label24.Location = new Point(9, 138);
      this.label24.Name = "label24";
      this.label24.Size = new Size(77, 12);
      this.label24.TabIndex = 42;
      this.label24.Text = "窄带声音大小";
      this.label29.AutoSize = true;
      this.label29.Location = new Point(173, 84);
      this.label29.Name = "label29";
      this.label29.Size = new Size(53, 12);
      this.label29.TabIndex = 53;
      this.label29.Text = "Tone_Hig";
      this.numericUpDown21.Location = new Point(98, 102);
      this.numericUpDown21.Maximum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.numericUpDown21.Name = "numericUpDown21";
      this.numericUpDown21.Size = new Size(60, 21);
      this.numericUpDown21.TabIndex = 41;
      this.numericUpDown21.Value = new Decimal(new int[4]
      {
        13,
        0,
        0,
        0
      });
      this.label30.AutoSize = true;
      this.label30.Location = new Point(173, 57);
      this.label30.Name = "label30";
      this.label30.Size = new Size(53, 12);
      this.label30.TabIndex = 52;
      this.label30.Text = "DTMF_Low";
      this.label23.AutoSize = true;
      this.label23.Location = new Point(9, 111);
      this.label23.Name = "label23";
      this.label23.Size = new Size(77, 12);
      this.label23.TabIndex = 40;
      this.label23.Text = "宽带声音大小";
      this.numericUpDown25.Location = new Point(367, 75);
      this.numericUpDown25.Maximum = new Decimal(new int[4]
      {
        7,
        0,
        0,
        0
      });
      this.numericUpDown25.Name = "numericUpDown25";
      this.numericUpDown25.Size = new Size(60, 21);
      this.numericUpDown25.TabIndex = 51;
      this.numericUpDown25.Value = new Decimal(new int[4]
      {
        3,
        0,
        0,
        0
      });
      this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[2]
      {
        (object) "允许",
        (object) "禁止"
      });
      this.comboBox2.Location = new Point(98, 49);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(60, 20);
      this.comboBox2.TabIndex = 38;
      this.comboBox2.SelectedIndexChanged += new EventHandler(this.comboBox2_SelectedIndexChanged);
      this.label22.AutoSize = true;
      this.label22.Location = new Point(33, 57);
      this.label22.Name = "label22";
      this.label22.Size = new Size(53, 12);
      this.label22.TabIndex = 39;
      this.label22.Text = "语言切换";
      this.numericUpDown26.Location = new Point(232, 21);
      this.numericUpDown26.Maximum = new Decimal(new int[4]
      {
        62,
        0,
        0,
        0
      });
      this.numericUpDown26.Name = "numericUpDown26";
      this.numericUpDown26.Size = new Size(60, 21);
      this.numericUpDown26.TabIndex = 50;
      this.numericUpDown26.Value = new Decimal(new int[4]
      {
        55,
        0,
        0,
        0
      });
      this.button7.Enabled = false;
      this.button7.Location = new Point(352, 207);
      this.button7.Name = "button7";
      this.button7.Size = new Size(74, 39);
      this.button7.TabIndex = 37;
      this.button7.Text = "退出测试模式";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.label27.AutoSize = true;
      this.label27.Location = new Point(173, 30);
      this.label27.Name = "label27";
      this.label27.Size = new Size(53, 12);
      this.label27.TabIndex = 49;
      this.label27.Text = "DTMF_Hig";
      this.button5.Enabled = false;
      this.button5.Location = new Point(5, 225);
      this.button5.Name = "button5";
      this.button5.Size = new Size(74, 21);
      this.button5.TabIndex = 36;
      this.button5.Text = "存为默认值";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button6.Enabled = false;
      this.button6.Location = new Point(97, 225);
      this.button6.Name = "button6";
      this.button6.Size = new Size(74, 21);
      this.button6.TabIndex = 35;
      this.button6.Text = "写入默认值";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.label28.AutoSize = true;
      this.label28.Location = new Point(306, 84);
      this.label28.Name = "label28";
      this.label28.Size = new Size(53, 12);
      this.label28.TabIndex = 48;
      this.label28.Text = "DCS_Gain";
      this.numericUpDown17.Location = new Point(98, 21);
      this.numericUpDown17.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown17.Name = "numericUpDown17";
      this.numericUpDown17.Size = new Size(60, 21);
      this.numericUpDown17.TabIndex = 22;
      this.numericUpDown17.Value = new Decimal(new int[4]
      {
        192,
        0,
        0,
        0
      });
      this.numericUpDown17.ValueChanged += new EventHandler(this.numericUpDown17_ValueChanged);
      this.numericUpDown18.Location = new Point(98, 75);
      this.numericUpDown18.Maximum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.numericUpDown18.Name = "numericUpDown18";
      this.numericUpDown18.Size = new Size(60, 21);
      this.numericUpDown18.TabIndex = 29;
      this.numericUpDown18.Value = new Decimal(new int[4]
      {
        3,
        0,
        0,
        0
      });
      this.numericUpDown18.ValueChanged += new EventHandler(this.numericUpDown18_ValueChanged);
      this.numericUpDown23.Location = new Point(367, 21);
      this.numericUpDown23.Maximum = new Decimal(new int[4]
      {
        62,
        0,
        0,
        0
      });
      this.numericUpDown23.Name = "numericUpDown23";
      this.numericUpDown23.Size = new Size(60, 21);
      this.numericUpDown23.TabIndex = 47;
      this.numericUpDown23.Value = new Decimal(new int[4]
      {
        12,
        0,
        0,
        0
      });
      this.button3.Location = new Point(188, 225);
      this.button3.Name = "button3";
      this.button3.Size = new Size(74, 21);
      this.button3.TabIndex = 30;
      this.button3.Text = "读取当前值";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.Enabled = false;
      this.button4.Location = new Point(268, 225);
      this.button4.Name = "button4";
      this.button4.Size = new Size(74, 21);
      this.button4.TabIndex = 29;
      this.button4.Text = "写入当前值";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.numericUpDown24.Location = new Point(366, 48);
      this.numericUpDown24.Maximum = new Decimal(new int[4]
      {
        62,
        0,
        0,
        0
      });
      this.numericUpDown24.Name = "numericUpDown24";
      this.numericUpDown24.Size = new Size(60, 21);
      this.numericUpDown24.TabIndex = 46;
      this.numericUpDown24.Value = new Decimal(new int[4]
      {
        31,
        0,
        0,
        0
      });
      this.label8.AutoSize = true;
      this.label8.Location = new Point(9, 30);
      this.label8.Name = "label8";
      this.label8.Size = new Size(77, 12);
      this.label8.TabIndex = 27;
      this.label8.Text = "7.4V参考电压";
      this.label8.Click += new EventHandler(this.label8_Click);
      this.label8.DoubleClick += new EventHandler(this.label8_DoubleClick);
      this.label25.AutoSize = true;
      this.label25.Location = new Point(312, 57);
      this.label25.Name = "label25";
      this.label25.Size = new Size(47, 12);
      this.label25.TabIndex = 45;
      this.label25.Text = "CTC_Low";
      this.label26.AutoSize = true;
      this.label26.Location = new Point(312, 30);
      this.label26.Name = "label26";
      this.label26.Size = new Size(47, 12);
      this.label26.TabIndex = 44;
      this.label26.Text = "CTC_Hig";
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[2]
      {
        (object) "正向",
        (object) "反向"
      });
      this.comboBox1.Location = new Point(851, 401);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(60, 20);
      this.comboBox1.TabIndex = 29;
      this.comboBox1.Visible = false;
      this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
      this.label19.AutoSize = true;
      this.label19.Location = new Point(780, 404);
      this.label19.Name = "label19";
      this.label19.Size = new Size(65, 12);
      this.label19.TabIndex = 34;
      this.label19.Text = "液晶屏方向";
      this.label19.Visible = false;
      this.groupBox3.Controls.Add((Control) this.numericUpDown20);
      this.groupBox3.Controls.Add((Control) this.label21);
      this.groupBox3.Controls.Add((Control) this.numericUpDown14);
      this.groupBox3.Controls.Add((Control) this.numericUpDown12);
      this.groupBox3.Controls.Add((Control) this.numericUpDown16);
      this.groupBox3.Controls.Add((Control) this.numericUpDown10);
      this.groupBox3.Controls.Add((Control) this.numericUpDown8);
      this.groupBox3.Controls.Add((Control) this.numericUpDown6);
      this.groupBox3.Controls.Add((Control) this.numericUpDown7);
      this.groupBox3.Controls.Add((Control) this.numericUpDown2);
      this.groupBox3.Controls.Add((Control) this.label12);
      this.groupBox3.Controls.Add((Control) this.label13);
      this.groupBox3.Controls.Add((Control) this.label14);
      this.groupBox3.Controls.Add((Control) this.label11);
      this.groupBox3.Controls.Add((Control) this.label15);
      this.groupBox3.Controls.Add((Control) this.label16);
      this.groupBox3.Controls.Add((Control) this.label17);
      this.groupBox3.Controls.Add((Control) this.label18);
      this.groupBox3.Location = new Point(638, 220);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(424, 121);
      this.groupBox3.TabIndex = 32;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "450M";
      this.groupBox3.Visible = false;
      this.numericUpDown20.Location = new Point(346, 91);
      this.numericUpDown20.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown20.Name = "numericUpDown20";
      this.numericUpDown20.Size = new Size(60, 21);
      this.numericUpDown20.TabIndex = 33;
      this.numericUpDown20.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown20.ValueChanged += new EventHandler(this.numericUpDown20_ValueChanged);
      this.label21.AutoSize = true;
      this.label21.Location = new Point(286, 100);
      this.label21.Name = "label21";
      this.label21.Size = new Size(53, 12);
      this.label21.TabIndex = 32;
      this.label21.Text = "调谐电压";
      this.numericUpDown14.Location = new Point(213, 91);
      this.numericUpDown14.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown14.Name = "numericUpDown14";
      this.numericUpDown14.Size = new Size(60, 21);
      this.numericUpDown14.TabIndex = 29;
      this.numericUpDown14.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown14.ValueChanged += new EventHandler(this.numericUpDown14_ValueChanged);
      this.numericUpDown12.Location = new Point(213, 55);
      this.numericUpDown12.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown12.Name = "numericUpDown12";
      this.numericUpDown12.Size = new Size(60, 21);
      this.numericUpDown12.TabIndex = 30;
      this.numericUpDown12.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown12.ValueChanged += new EventHandler(this.numericUpDown12_ValueChanged);
      this.numericUpDown16.Location = new Point(346, 24);
      this.numericUpDown16.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown16.Name = "numericUpDown16";
      this.numericUpDown16.Size = new Size(60, 21);
      this.numericUpDown16.TabIndex = 30;
      this.numericUpDown16.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown16.ValueChanged += new EventHandler(this.numericUpDown16_ValueChanged);
      this.numericUpDown10.Location = new Point(213, 28);
      this.numericUpDown10.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown10.Name = "numericUpDown10";
      this.numericUpDown10.Size = new Size(60, 21);
      this.numericUpDown10.TabIndex = 30;
      this.numericUpDown10.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown10.ValueChanged += new EventHandler(this.numericUpDown10_ValueChanged);
      this.numericUpDown8.Location = new Point(65, 91);
      this.numericUpDown8.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown8.Name = "numericUpDown8";
      this.numericUpDown8.Size = new Size(60, 21);
      this.numericUpDown8.TabIndex = 30;
      this.numericUpDown8.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown8.ValueChanged += new EventHandler(this.numericUpDown8_ValueChanged);
      this.numericUpDown6.Location = new Point(65, 21);
      this.numericUpDown6.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown6.Name = "numericUpDown6";
      this.numericUpDown6.Size = new Size(60, 21);
      this.numericUpDown6.TabIndex = 31;
      this.numericUpDown6.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown6.ValueChanged += new EventHandler(this.numericUpDown6_ValueChanged_1);
      this.numericUpDown7.Location = new Point(65, 55);
      this.numericUpDown7.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown7.Name = "numericUpDown7";
      this.numericUpDown7.Size = new Size(60, 21);
      this.numericUpDown7.TabIndex = 29;
      this.numericUpDown7.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown7.ValueChanged += new EventHandler(this.numericUpDown7_ValueChanged_1);
      this.numericUpDown2.Location = new Point(346, 58);
      this.numericUpDown2.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new Size(60, 21);
      this.numericUpDown2.TabIndex = 30;
      this.numericUpDown2.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown2.ValueChanged += new EventHandler(this.numericUpDown2_ValueChanged_1);
      this.label12.AutoSize = true;
      this.label12.Location = new Point(6, 64);
      this.label12.Name = "label12";
      this.label12.Size = new Size(53, 12);
      this.label12.TabIndex = 19;
      this.label12.Text = "中功调节";
      this.label13.AutoSize = true;
      this.label13.Location = new Point(287, 67);
      this.label13.Name = "label13";
      this.label13.Size = new Size(53, 12);
      this.label13.TabIndex = 11;
      this.label13.Text = "静噪调节";
      this.label14.AutoSize = true;
      this.label14.Location = new Point(6, 30);
      this.label14.Name = "label14";
      this.label14.Size = new Size(53, 12);
      this.label14.TabIndex = 13;
      this.label14.Text = "低功调节";
      this.label11.AutoSize = true;
      this.label11.Location = new Point(287, 33);
      this.label11.Name = "label11";
      this.label11.Size = new Size(53, 12);
      this.label11.TabIndex = 24;
      this.label11.Text = "可选信令";
      this.label15.AutoSize = true;
      this.label15.Location = new Point(6, 100);
      this.label15.Name = "label15";
      this.label15.Size = new Size(53, 12);
      this.label15.TabIndex = 15;
      this.label15.Text = "高功调节";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(154, 30);
      this.label16.Name = "label16";
      this.label16.Size = new Size(53, 12);
      this.label16.TabIndex = 17;
      this.label16.Text = "频偏调节";
      this.label17.AutoSize = true;
      this.label17.Location = new Point(154, 64);
      this.label17.Name = "label17";
      this.label17.Size = new Size(53, 12);
      this.label17.TabIndex = 21;
      this.label17.Text = "数字亚音";
      this.label18.AutoSize = true;
      this.label18.Location = new Point(154, 100);
      this.label18.Name = "label18";
      this.label18.Size = new Size(53, 12);
      this.label18.TabIndex = 19;
      this.label18.Text = "模拟亚音";
      this.groupBox2.Controls.Add((Control) this.numericUpDown19);
      this.groupBox2.Controls.Add((Control) this.numericUpDown13);
      this.groupBox2.Controls.Add((Control) this.numericUpDown3);
      this.groupBox2.Controls.Add((Control) this.label20);
      this.groupBox2.Controls.Add((Control) this.numericUpDown11);
      this.groupBox2.Controls.Add((Control) this.label2);
      this.groupBox2.Controls.Add((Control) this.numericUpDown9);
      this.groupBox2.Controls.Add((Control) this.numericUpDown1);
      this.groupBox2.Controls.Add((Control) this.numericUpDown15);
      this.groupBox2.Controls.Add((Control) this.numericUpDown5);
      this.groupBox2.Controls.Add((Control) this.label10);
      this.groupBox2.Controls.Add((Control) this.numericUpDown4);
      this.groupBox2.Controls.Add((Control) this.label9);
      this.groupBox2.Controls.Add((Control) this.label3);
      this.groupBox2.Controls.Add((Control) this.label4);
      this.groupBox2.Controls.Add((Control) this.label5);
      this.groupBox2.Controls.Add((Control) this.label7);
      this.groupBox2.Controls.Add((Control) this.label6);
      this.groupBox2.Location = new Point(638, 93);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(424, 121);
      this.groupBox2.TabIndex = 31;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "150M";
      this.groupBox2.Visible = false;
      this.numericUpDown19.Location = new Point(346, 83);
      this.numericUpDown19.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown19.Name = "numericUpDown19";
      this.numericUpDown19.Size = new Size(60, 21);
      this.numericUpDown19.TabIndex = 33;
      this.numericUpDown19.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown19.ValueChanged += new EventHandler(this.numericUpDown19_ValueChanged);
      this.numericUpDown13.Location = new Point(215, 90);
      this.numericUpDown13.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown13.Name = "numericUpDown13";
      this.numericUpDown13.Size = new Size(60, 21);
      this.numericUpDown13.TabIndex = 31;
      this.numericUpDown13.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown13.ValueChanged += new EventHandler(this.numericUpDown13_ValueChanged);
      this.numericUpDown3.Location = new Point(65, 20);
      this.numericUpDown3.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new Size(60, 21);
      this.numericUpDown3.TabIndex = 31;
      this.numericUpDown3.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown3.ValueChanged += new EventHandler(this.numericUpDown3_ValueChanged_1);
      this.label20.AutoSize = true;
      this.label20.Location = new Point(287, 92);
      this.label20.Name = "label20";
      this.label20.Size = new Size(53, 12);
      this.label20.TabIndex = 32;
      this.label20.Text = "调谐电压";
      this.numericUpDown11.Location = new Point(213, 54);
      this.numericUpDown11.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown11.Name = "numericUpDown11";
      this.numericUpDown11.Size = new Size(60, 21);
      this.numericUpDown11.TabIndex = 29;
      this.numericUpDown11.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown11.ValueChanged += new EventHandler(this.numericUpDown11_ValueChanged);
      this.numericUpDown9.Location = new Point(213, 20);
      this.numericUpDown9.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown9.Name = "numericUpDown9";
      this.numericUpDown9.Size = new Size(60, 21);
      this.numericUpDown9.TabIndex = 29;
      this.numericUpDown9.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown9.ValueChanged += new EventHandler(this.numericUpDown9_ValueChanged);
      this.numericUpDown1.Location = new Point(346, 49);
      this.numericUpDown1.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new Size(60, 21);
      this.numericUpDown1.TabIndex = 29;
      this.numericUpDown1.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged_1);
      this.numericUpDown15.Location = new Point(346, 18);
      this.numericUpDown15.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown15.Name = "numericUpDown15";
      this.numericUpDown15.Size = new Size(60, 21);
      this.numericUpDown15.TabIndex = 29;
      this.numericUpDown15.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown15.ValueChanged += new EventHandler(this.numericUpDown15_ValueChanged);
      this.numericUpDown5.Location = new Point(65, 90);
      this.numericUpDown5.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown5.Name = "numericUpDown5";
      this.numericUpDown5.Size = new Size(60, 21);
      this.numericUpDown5.TabIndex = 30;
      this.numericUpDown5.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown5.ValueChanged += new EventHandler(this.numericUpDown5_ValueChanged_1);
      this.label10.AutoSize = true;
      this.label10.Location = new Point(287, 27);
      this.label10.Name = "label10";
      this.label10.Size = new Size(53, 12);
      this.label10.TabIndex = 24;
      this.label10.Text = "可选信令";
      this.label10.Click += new EventHandler(this.label10_Click);
      this.numericUpDown4.Location = new Point(65, 54);
      this.numericUpDown4.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown4.Name = "numericUpDown4";
      this.numericUpDown4.Size = new Size(60, 21);
      this.numericUpDown4.TabIndex = 29;
      this.numericUpDown4.Value = new Decimal(new int[4]
      {
        64,
        0,
        0,
        0
      });
      this.numericUpDown4.ValueChanged += new EventHandler(this.numericUpDown4_ValueChanged_1);
      this.label9.AutoSize = true;
      this.label9.Location = new Point(6, 63);
      this.label9.Name = "label9";
      this.label9.Size = new Size(53, 12);
      this.label9.TabIndex = 19;
      this.label9.Text = "中功调节";
      this.menuStrip.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.helpMenu
      });
      this.menuStrip.Location = new Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new Size(447, 25);
      this.menuStrip.TabIndex = 29;
      this.menuStrip.Text = "MenuStrip";
      this.helpMenu.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.toolStripSeparator8
      });
      this.helpMenu.Name = "helpMenu";
      this.helpMenu.Size = new Size(85, 21);
      this.helpMenu.Text = "使用说明(&H)";
      this.helpMenu.Click += new EventHandler(this.helpMenu_Click);
      this.helpMenu.DoubleClick += new EventHandler(this.helpMenu_DoubleClick);
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new Size(57, 6);
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(307, 155);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(108, 16);
      this.checkBox1.TabIndex = 64;
      this.checkBox1.Text = "关闭手动扩缩频";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new Point(307, 179);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new Size(84, 16);
      this.checkBox4.TabIndex = 65;
      this.checkBox4.Text = "禁止初始化";
      this.checkBox4.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(447, 362);
      this.Controls.Add((Control) this.menuStrip);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.listBox1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.comboBox1);
      this.Controls.Add((Control) this.comboBox5);
      this.Controls.Add((Control) this.label19);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.button2);
      this.Name = nameof (模拟参数总体调节);
      this.Text = "AngSet";
      this.FormClosed += new FormClosedEventHandler(this.AngSet_FormClosed);
      this.Load += new EventHandler(this.AngSet_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.numericUpDown29.EndInit();
      this.numericUpDown27.EndInit();
      this.numericUpDown22.EndInit();
      this.numericUpDown28.EndInit();
      this.numericUpDown21.EndInit();
      this.numericUpDown25.EndInit();
      this.numericUpDown26.EndInit();
      this.numericUpDown17.EndInit();
      this.numericUpDown18.EndInit();
      this.numericUpDown23.EndInit();
      this.numericUpDown24.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.numericUpDown20.EndInit();
      this.numericUpDown14.EndInit();
      this.numericUpDown12.EndInit();
      this.numericUpDown16.EndInit();
      this.numericUpDown10.EndInit();
      this.numericUpDown8.EndInit();
      this.numericUpDown6.EndInit();
      this.numericUpDown7.EndInit();
      this.numericUpDown2.EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.numericUpDown19.EndInit();
      this.numericUpDown13.EndInit();
      this.numericUpDown3.EndInit();
      this.numericUpDown11.EndInit();
      this.numericUpDown9.EndInit();
      this.numericUpDown1.EndInit();
      this.numericUpDown15.EndInit();
      this.numericUpDown5.EndInit();
      this.numericUpDown4.EndInit();
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
