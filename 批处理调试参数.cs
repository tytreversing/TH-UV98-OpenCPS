// Decompiled with JetBrains decompiler
// Type: _8890DTest.批处理调试参数
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
  public class 批处理调试参数 : Form
  {
    private static System.Timers.Timer aTimer1;
    private string ReadCt_OneTm = "3230";
    private int ConOneTmReadCt = 32;
    private int ConOneTmWriteCt = 32;
    private int ConTetBegAdd = 512;
    private int ConSct3258BegAdd = 800;
    private int Con1846BegAdd = 896;
    private int Con1846BegLine = 7;
    private int ConTestReadDataTm = 11;
    private int ConTestWriteDataTm = 11;
    public string BaudRadio = "9600";
    private int ConMaxReadAdrr = 896;
    private int ConMaxWriteAdrr = 896;
    public string GiFilePathName = "TestModDef.icf";
    private string GiCurrDataBuf;
    private string GiDefDataBuf;
    private string ComTempStr;
    private string[] WriteDataBuf;
    private bool Listening = false;
    private bool OnlyOneLine = false;
    private bool ComFail = false;
    private bool GbTestMod = false;
    private bool GbAtLineMod = false;
    private bool GbItemAjdEn;
    public bool GbReadMod = true;
    private int IicAddress;
    public int CurrentCom = 3;
    private int SendByte = 0;
    private int CurrAdjData;
    private int CurrAdjItem = 0;
    private int ConBegLine = 20;
    private byte[] RxBuffer = new byte[200];
    private byte CommuCt = 0;
    private byte CommuItem = 0;
    private int GbResSendTm;
    private string CurrCommandStr;
    private byte CurrSendByteCt;
    private byte CurrAckByteCt;
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
    private ProgressBar progressBar1;
    private Button button1;
    private Button button2;
    private Button button3;
    private SerialPort serialPort1;
    private ListBox listBox1;
    private Button button4;

    public 批处理调试参数()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void TimerResPro()
    {
      批处理调试参数.aTimer1 = new System.Timers.Timer(10000.0);
      批处理调试参数.aTimer1.Elapsed += new ElapsedEventHandler(this.OnTimedEvent);
      批处理调试参数.aTimer1.Enabled = false;
    }

    private void TimeRestartPro()
    {
      批处理调试参数.aTimer1.Enabled = false;
      批处理调试参数.aTimer1.Interval = 1200.0;
      批处理调试参数.aTimer1.Enabled = true;
    }

    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
      byte[] numArray = new byte[200];
      ++this.GbResSendTm;
      if (this.GbResSendTm < 5)
      {
        if (!this.serialPort1.IsOpen)
          return;
        批处理调试参数.aTimer1.Enabled = false;
        批处理调试参数.aTimer1.Interval = 500.0;
        批处理调试参数.aTimer1.Enabled = true;
        this.serialPort1.DiscardInBuffer();
        this.SendComDatPro(this.CurrCommandStr, this.CurrSendByteCt, this.CurrAckByteCt);
      }
      else
      {
        if (!this.GbAtLineMod)
          this.serialPort1.Close();
        else
          this.GbAtLineMod = false;
        批处理调试参数.aTimer1.Enabled = false;
        int num = (int) MessageBox.Show("通信超时", "RadioName");
        this.Invoke((Delegate) new EventHandler(this.CtrLResAllPro));
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

    public void LoadFileDataDisPro() => this.WriteDataBuf = Class1.ReadFileDataPro(this.GiFilePathName).Split('\r');

    private void 批处理调试参数_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.TimerResPro();
      this.button3.Enabled = false;
      this.LoadFileDataDisPro();
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
        Thread.Sleep(30);
        this.TimeRestartPro();
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
      }
      catch
      {
        int num = (int) MessageBox.Show("SendComDatPro事件指令:" + (object) this.CommuItem, Class1.RadioName);
      }
    }

    private void FirSendComDatPro(string TempStr, byte SendByteCt, byte AckByteCt)
    {
      this.GbResSendTm = 0;
      this.CurrCommandStr = TempStr;
      this.CurrSendByteCt = SendByteCt;
      this.CurrAckByteCt = AckByteCt;
      this.SendComDatPro(TempStr, SendByteCt, AckByteCt);
    }

    private void ComunicationStartPro()
    {
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        this.button1.Enabled = false;
        this.GbTestMod = true;
        if (this.GbReadMod)
        {
          this.CommuItem = (byte) 0;
          this.button4.Enabled = false;
        }
        else
        {
          this.CommuItem = (byte) 2;
          this.button4.Enabled = true;
        }
        this.CommuCt = (byte) 0;
        this.GiCurrDataBuf = "";
        this.progressBar1.Value = 0;
        this.IicAddress = this.ConTetBegAdd;
        this.listBox1.Items.Clear();
        this.listBox1.Items.Add((object) "/**********************进入测试模式*************************/");
        this.FirSendComDatPro(this.ConEntTestCom, (byte) 13, (byte) 7);
      }
      catch
      {
        int num = (int) MessageBox.Show("button1_Click事件异常", Class1.RadioName);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.button4.Enabled)
        this.GbReadMod = true;
      this.ComunicationStartPro();
    }

    private void CtrLResAllPro(object sender, EventArgs e)
    {
      this.GbTestMod = false;
      this.button1.Enabled = true;
      this.button2.Enabled = true;
      this.button3.Enabled = false;
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
            switch (this.CommuCt)
            {
              case 0:
                if (str1.Substring(0, 14) == this.ConAckCom)
                {
                  ++this.CommuCt;
                  this.IicAddress = this.ConTetBegAdd;
                  return;
                }
                this.SetCommuFailPro();
                if (this.ComFail)
                {
                  int num1 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
                }
                return;
              case 1:
              case 2:
              case 3:
              case 4:
              case 5:
              case 6:
              case 7:
              case 8:
              case 9:
              case 10:
                if (str1.Substring(0, 10) == this.ConReadDatAckCom)
                {
                  string str2 = Class1.AllAsciiToStr(str1.Substring(10, str1.Length - 11));
                  this.GiCurrDataBuf += str2.Substring(6, str2.Length - 8);
                  if ((byte) 7 == this.CommuCt)
                    this.IicAddress = this.ConSct3258BegAdd;
                  ++this.CommuCt;
                  double num2 = (double) this.IicAddress * 100.0 / (double) this.ConMaxReadAdrr;
                  if (num2 >= 100.0)
                    num2 = 100.0;
                  this.progressBar1.Value = (int) num2;
                  return;
                }
                this.SetCommuFailPro();
                if (this.ComFail)
                {
                  int num3 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
                }
                return;
              case 11:
                if (str1.Substring(0, 10) == this.ConReadDatAckCom)
                {
                  string str3 = Class1.AllAsciiToStr(str1.Substring(10, str1.Length - 11));
                  this.GiCurrDataBuf += str3.Substring(6, str3.Length - 8);
                  ++this.CommuCt;
                  批处理调试参数.aTimer1.Enabled = false;
                  this.button1.Text = "读频";
                  this.button1.Enabled = true;
                  this.button2.Enabled = true;
                  this.GbAtLineMod = false;
                  this.button3.Enabled = true;
                  this.button4.Enabled = true;
                  int num4 = (int) MessageBox.Show("读频成功！", Class1.RadioName);
                  return;
                }
                this.SetCommuFailPro();
                if (this.ComFail)
                {
                  int num5 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
                }
                return;
              default:
                return;
            }
          case 1:
            if (str1.Substring(0, 14) == this.ConAckCom)
            {
              批处理调试参数.aTimer1.Enabled = false;
              this.Invoke((Delegate) new EventHandler(this.CtrLResAllPro));
              this.GbAtLineMod = false;
              this.button1.Focus();
              break;
            }
            this.SetCommuFailPro();
            if (this.ComFail)
            {
              int num6 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
            }
            break;
          case 2:
            if (str1.Substring(0, 14) == this.ConAckCom)
            {
              if ((byte) 8 == this.CommuCt)
                this.IicAddress = this.ConSct3258BegAdd;
              ++this.CommuCt;
              double num7 = (double) this.IicAddress * 100.0 / (double) this.ConMaxWriteAdrr;
              if (num7 >= 100.0)
                num7 = 100.0;
              this.progressBar1.Value = (int) num7;
              if ((int) this.CommuCt <= this.ConTestWriteDataTm + 2)
                break;
              批处理调试参数.aTimer1.Enabled = false;
              this.GbAtLineMod = false;
              this.button1.Enabled = true;
              this.button2.Enabled = true;
              this.button1.Text = "读频";
              int num8 = (int) MessageBox.Show("批写成功", Class1.RadioName);
              break;
            }
            this.SetCommuFailPro();
            if (this.ComFail)
            {
              int num9 = (int) MessageBox.Show("DisplayText通信失败" + (object) this.CommuItem + (object) this.CommuCt, Class1.RadioName);
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

    private byte GetDataTxRxBytePro(int TxRxCt) => (byte) (14 + (TxRxCt << 1));

    private void SendReadDatAddComPro()
    {
      if ((int) this.CommuCt > this.ConTestReadDataTm)
        return;
      this.FirSendComDatPro(this.ConTxReadCom + Class1.DataToAscii((long) this.IicAddress, 4) + this.ReadCt_OneTm + "FD", (byte) 12, this.GetDataTxRxBytePro(this.ConOneTmReadCt));
      this.IicAddress += this.ConOneTmReadCt;
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

    private void SendWriteDatAddComPro(byte CurrData)
    {
      if ((int) this.CommuCt > this.ConTestWriteDataTm + 1)
        return;
      string str1 = this.WriteDataBuf[(int) this.CommuCt + 1 + this.ConBegLine];
      string str2 = str1.Substring(0, 1);
      string str3 = !(str2 == "n") && !(str2 == "\n") ? str1.Substring(6, str1.Length - 6) : str1.Substring(7, str1.Length - 7);
      string str4 = Class1.StrHexAutoAdd0Pro((long) this.IicAddress, (byte) 4) + Class1.StrHexAutoAdd0Pro((long) this.ConOneTmWriteCt, (byte) 2);
      this.GiDefDataBuf += str3;
      string TempStr1 = str4 + str3;
      this.FirSendComDatPro(this.ConTxWriteCom + Class1.StrToAscii(TempStr1 + this.GetChkSum_AddrPro(TempStr1)) + "FD", this.GetDataTxRxBytePro(this.ConOneTmWriteCt), (byte) 7);
      this.IicAddress += this.ConOneTmWriteCt;
    }

    private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      this.Listening = true;
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
          this.GbItemAjdEn = false;
          this.serialPort1.Close();
          return;
        }
        this.GbAtLineMod = false;
        switch (this.CommuItem)
        {
          case 0:
            this.SendReadDatAddComPro();
            break;
          case 2:
            if ((int) this.CommuCt == this.ConTestWriteDataTm + 2)
            {
              this.FirSendComDatPro(this.ConExtWriModCom, (byte) 13, (byte) 7);
              break;
            }
            if (this.CommuCt == (byte) 1)
            {
              this.FirSendComDatPro(this.ConWriTestCom, (byte) 13, (byte) 7);
              break;
            }
            this.SendWriteDatAddComPro((byte) 0);
            break;
        }
      }
      this.Listening = false;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void SavDefDataPro()
    {
      this.WriteDataBuf = Class1.ReadFileDataPro(this.GiFilePathName).Split('\r');
      int length = Class1.ConOneRowDatCt * 2;
      for (int index = 0; index < this.ConTestWriteDataTm; ++index)
      {
        string str1 = Class2.AutoAdd_n_Pro(this.WriteDataBuf[index + 3 + this.ConBegLine]).Substring(0, 7);
        string str2 = this.GiDefDataBuf.Substring(index * length, length);
        this.WriteDataBuf[index + 3 + this.ConBegLine] = str1 + str2;
      }
      Class1.SaveFileDataPro(this.GiFilePathName, this.WriteDataBuf);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (!this.GbTestMod)
        return;
      this.button3.Enabled = false;
      this.GiDefDataBuf = Class1.Chga_z_ToA_Z(this.GiCurrDataBuf);
      this.SavDefDataPro();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.serialPort1.IsOpen)
      {
        while (this.Listening)
        {
          Application.DoEvents();
          Thread.Sleep(10);
        }
        if (this.serialPort1.IsOpen)
          this.serialPort1.Close();
        批处理调试参数.aTimer1.Enabled = false;
        this.Close();
      }
      else
        this.Close();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.GbReadMod = false;
      this.ComunicationStartPro();
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
      this.progressBar1 = new ProgressBar();
      this.button1 = new Button();
      this.button2 = new Button();
      this.button3 = new Button();
      this.serialPort1 = new SerialPort(this.components);
      this.listBox1 = new ListBox();
      this.button4 = new Button();
      this.SuspendLayout();
      this.progressBar1.Location = new Point(12, 12);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new Size(425, 36);
      this.progressBar1.TabIndex = 4;
      this.button1.Location = new Point(15, 70);
      this.button1.Name = "button1";
      this.button1.Size = new Size(78, 43);
      this.button1.TabIndex = 5;
      this.button1.Text = "开始";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(99, 70);
      this.button2.Name = "button2";
      this.button2.Size = new Size(78, 43);
      this.button2.TabIndex = 6;
      this.button2.Text = "退出";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Location = new Point(269, 70);
      this.button3.Name = "button3";
      this.button3.Size = new Size(78, 43);
      this.button3.TabIndex = 7;
      this.button3.Text = "存为默认值";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
      this.listBox1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.listBox1.FormattingEnabled = true;
      this.listBox1.HorizontalScrollbar = true;
      this.listBox1.ImeMode = ImeMode.NoControl;
      this.listBox1.ItemHeight = 12;
      this.listBox1.Location = new Point(15, 119);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(420, 292);
      this.listBox1.TabIndex = 8;
      this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
      this.button4.Enabled = false;
      this.button4.Location = new Point(353, 70);
      this.button4.Name = "button4";
      this.button4.Size = new Size(78, 43);
      this.button4.TabIndex = 9;
      this.button4.Text = "写入默认值";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(443, 117);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.listBox1);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.progressBar1);
      this.Name = nameof (批处理调试参数);
      this.Text = nameof (批处理调试参数);
      this.Load += new EventHandler(this.批处理调试参数_Load);
      this.ResumeLayout(false);
    }
  }
}
