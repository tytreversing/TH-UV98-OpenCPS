// Decompiled with JetBrains decompiler
// Type: _8890DTest.TongXun
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace _8890DTest
{
  public class TongXun : Form
  {
    private const int CP_NOCLOSE_BUTTON = 512;
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private ProgressBar progressBar1;
    private SerialPort serialPort1;
    private GroupBox groupBox2;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
    private Button button3;
    private Label label2;
    private Label label1;
    private Button button2;
    private Button button1;
    private GroupBox groupBox3;
    private ListBox listBox1;
    private TextBox textBox1;
    private Label label3;
    private static System.Timers.Timer aTimer;
    private int GbCommDelay = 15;
    private int FielBegRow = 3;
    private int ConOneRowDatCt = 32;
    private int ConOneTmReadCt = 32;
    private int ConOneTmWriteCt = 32;
    private int ConMaxReadAdrr = 8864;
    private int ConMaxWriteAdrr = 8864;
    public string GiFilePathName = "e:\\1.icf";
    public string BaudRadio = "9600";
    private int IicAddress;
    private string DataBuffer;
    private bool OnlyOneLine = false;
    private bool ComFail = false;
    public int CurrentCom = 6;
    private int SendByte = 0;
    public bool GbReadMod = true;
    public bool GbWriteMod = false;
    private bool GbAtLineMod = false;
    private byte[] RxBuffer = new byte[200];
    private string[] WriteDataBuf;
    private byte CommuCt = 0;
    public bool R_W_Succeed = false;
    private string ComTempStr;
    private bool ComunicationDisEn = false;
    private bool GbFirComEn = true;
    private string[,] MessBoxName = new string[2, 17]
    {
      {
        "当前串口",
        "：被占用,请选择其它串口！",
        "逻辑出错步聚:",
        "通信失败",
        "通信超时，请检查串口和波特率是否正确！",
        "非0XFD结束符！",
        "非握手应答指应",
        "非波特率应答指令",
        "读写频密码不正确！",
        "非读写频应答指令！",
        "非读频应答指令！",
        "非写频应答指令！",
        "通信成功!",
        "非通讯结束应答指令",
        "数据非法异常！",
        "通信超时",
        "非法异常"
      },
      {
        "Comport",
        "：Occupancy!",
        "Logic code Error:",
        "Connect Error",
        "Communication timed out, please check the com and baud rate correct or not !",
        "Connect Error",
        "Connect Error",
        "Connect Error",
        "Code Error！",
        "Connect Error！",
        "Connect Error！",
        "Connect Error！",
        "Succeed!",
        "Connect Error",
        "Connect Error！",
        "Connect Error",
        "Connect Error"
      }
    };
    public static string[,] ContlrName = new string[2, 8]
    {
      {
        "读频",
        "写频",
        "退出",
        "DTMF",
        "2 音",
        "5 音",
        "频段范围      ",
        "GPS 系统      "
      },
      {
        "Read  ",
        "Write ",
        "Exit",
        "DTMF",
        "2Tone",
        "5Tone",
        "Frequency Rang",
        "GPS System      "
      }
    };

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.groupBox1 = new GroupBox();
      this.progressBar1 = new ProgressBar();
      this.serialPort1 = new SerialPort(this.components);
      this.groupBox2 = new GroupBox();
      this.groupBox3 = new GroupBox();
      this.radioButton2 = new RadioButton();
      this.radioButton1 = new RadioButton();
      this.button3 = new Button();
      this.label2 = new Label();
      this.label1 = new Label();
      this.button2 = new Button();
      this.button1 = new Button();
      this.listBox1 = new ListBox();
      this.label3 = new Label();
      this.textBox1 = new TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.progressBar1);
      this.groupBox1.Location = new Point(4, 7);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(425, 46);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Enter += new EventHandler(this.groupBox1_Enter);
      this.progressBar1.Location = new Point(0, 5);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new Size(425, 36);
      this.progressBar1.TabIndex = 3;
      this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
      this.groupBox2.Controls.Add((Control) this.textBox1);
      this.groupBox2.Controls.Add((Control) this.label3);
      this.groupBox2.Controls.Add((Control) this.groupBox3);
      this.groupBox2.Controls.Add((Control) this.radioButton2);
      this.groupBox2.Controls.Add((Control) this.radioButton1);
      this.groupBox2.Controls.Add((Control) this.button3);
      this.groupBox2.Controls.Add((Control) this.label2);
      this.groupBox2.Controls.Add((Control) this.label1);
      this.groupBox2.Controls.Add((Control) this.button2);
      this.groupBox2.Controls.Add((Control) this.button1);
      this.groupBox2.Location = new Point(4, 54);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(425, 65);
      this.groupBox2.TabIndex = 6;
      this.groupBox2.TabStop = false;
      this.groupBox3.Location = new Point(407, 49);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(10, 10);
      this.groupBox3.TabIndex = 7;
      this.groupBox3.TabStop = false;
      this.groupBox3.MouseCaptureChanged += new EventHandler(this.groupBox3_MouseCaptureChanged);
      this.groupBox3.Enter += new EventHandler(this.groupBox3_Enter);
      this.radioButton2.AutoSize = true;
      this.radioButton2.Checked = true;
      this.radioButton2.Location = new Point(348, 11);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new Size(71, 16);
      this.radioButton2.TabIndex = 17;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "双线写频";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new Point(271, 12);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new Size(71, 16);
      this.radioButton1.TabIndex = 16;
      this.radioButton1.Text = "单线写频";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new EventHandler(this.radioButton1_CheckedChanged);
      this.button3.Location = new Point(300, 34);
      this.button3.Name = "button3";
      this.button3.Size = new Size(52, 25);
      this.button3.TabIndex = 15;
      this.button3.Text = "退出";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.label2.AutoSize = true;
      this.label2.Location = new Point(102, 17);
      this.label2.Name = "label2";
      this.label2.Size = new Size(23, 12);
      this.label2.TabIndex = 14;
      this.label2.Text = "0/0";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(2, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(89, 12);
      this.label1.TabIndex = 13;
      this.label1.Text = "接收/发射个数:";
      this.button2.Location = new Point(174, 34);
      this.button2.Name = "button2";
      this.button2.Size = new Size(52, 25);
      this.button2.TabIndex = 12;
      this.button2.Text = "写频";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.Location = new Point(48, 34);
      this.button1.Name = "button1";
      this.button1.Size = new Size(52, 25);
      this.button1.TabIndex = 11;
      this.button1.Text = "读频";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.listBox1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.listBox1.FormattingEnabled = true;
      this.listBox1.HorizontalScrollbar = true;
      this.listBox1.ImeMode = ImeMode.NoControl;
      this.listBox1.ItemHeight = 12;
      this.listBox1.Location = new Point(4, 125);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(425, 316);
      this.listBox1.TabIndex = 7;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(131, 13);
      this.label3.Name = "label3";
      this.label3.Size = new Size(65, 12);
      this.label3.TabIndex = 18;
      this.label3.Text = "Delay Time";
      this.label3.Visible = false;
      this.textBox1.Location = new Point(207, 8);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(48, 21);
      this.textBox1.TabIndex = 19;
      this.textBox1.Text = "15";
      this.textBox1.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(433, 125);
      this.Controls.Add((Control) this.listBox1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = nameof (TongXun);
      this.Text = "通讯";
      this.Load += new EventHandler(this.TongXun_Load);
      this.FormClosed += new FormClosedEventHandler(this.TongXun_FormClosed);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
    }

    public TongXun()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
      this.ControlBox = false;
    }

    protected override CreateParams CreateParams
    {
      get
      {
        CreateParams createParams = base.CreateParams;
        createParams.ClassStyle |= 512;
        return createParams;
      }
    }

    private void serialPortResSetPro()
    {
      this.serialPort1.PortName = "COM1";
      this.serialPort1.BaudRate = Convert.ToInt32(this.BaudRadio, 10);
      this.serialPort1.DataBits = 8;
      this.serialPort1.StopBits = StopBits.One;
      this.serialPort1.Parity = Parity.None;
      this.serialPort1.RtsEnable = true;
      this.serialPort1.DtrEnable = true;
      this.serialPort1.Encoding = Encoding.ASCII;
    }

    private void load_GroupBox1Pro()
    {
      this.button1.Text = TongXun.ContlrName[Class1.English_En, 0];
      this.button2.Text = TongXun.ContlrName[Class1.English_En, 1];
      this.button3.Text = TongXun.ContlrName[Class1.English_En, 2];
      this.label1.Text = "接收/发射个数:";
      this.label1.Visible = false;
      this.label2.Text = "0/0";
      this.label2.Visible = false;
      this.radioButton1.Text = "单线写频";
      this.radioButton1.Checked = false;
      this.radioButton1.Visible = false;
      this.radioButton2.Text = "双线写频";
      this.radioButton2.Checked = true;
      this.radioButton2.Visible = false;
    }

    private void TongXun_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.load_GroupBox1Pro();
      this.serialPortResSetPro();
      this.TimerResPro();
      this.OnlyOneLine = this.radioButton1.Checked;
      if (this.GbReadMod)
      {
        this.button1_Click(sender, e);
      }
      else
      {
        if (!this.GbWriteMod)
          return;
        this.button2_Click(sender, e);
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
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 0] + (object) this.CurrentCom + this.MessBoxName[Class1.English_En, 1], Class1.RadioName);
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

    private void SendComDatPro(string TempStr, int SendByteCt, int AckByteCt)
    {
      byte[] buffer = new byte[SendByteCt];
      try
      {
        Thread.Sleep(this.GbCommDelay);
        this.ComTempStr = "TX: " + TempStr;
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        for (int index = 0; index < SendByteCt; ++index)
        {
          string str = TempStr.Substring(2 * index, 2);
          buffer[index] = Convert.ToByte(str, 16);
        }
        this.SendByte = 0;
        for (int index = 0; index < 80; ++index)
          this.RxBuffer[index] = (byte) 0;
        if (Class1.GbOnlyOneLine)
          this.SendByte = SendByteCt;
        this.serialPort1.ReceivedBytesThreshold = AckByteCt + this.SendByte;
        this.serialPort1.Write(buffer, 0, SendByteCt);
        this.TimeRestartPro();
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 2] + (object) this.CommuCt, Class1.RadioName);
      }
    }

    private void SendBaudComDatPro()
    {
      string str = !(this.BaudRadio == "9600") ? (!(this.BaudRadio == "19200") ? (!(this.BaudRadio == "38400") ? (!(this.BaudRadio == "56000") ? (!(this.BaudRadio == "57600") ? "00" : "04") : "03") : "02") : "01") : "00";
      this.SendComDatPro("FEFEEEEFE65556393801FD".Substring(0, "FEFEEEEFE65556393801FD".Length - 4) + str + "FD", 11, 7);
      this.serialPort1.Close();
      this.serialPort1.BaudRate = Convert.ToInt32(this.BaudRadio, 10);
      this.serialPort1.Open();
      this.SendByte = 0;
      this.serialPort1.ReceivedBytesThreshold = 7;
    }

    private byte GetDataTxRxBytePro(int SendRxCt) => (byte) (13 + SendRxCt);

    private void SendReadDatAddComPro()
    {
      if (this.IicAddress >= this.ConMaxReadAdrr)
      {
        this.CommuCt = (byte) 5;
        this.SendComDatPro("FEFEEEEFE555563938FD", 10, 7);
      }
      else
        this.SendComDatPro("FEFEEEEFEB" + (Class1.DataToStrPro((long) this.IicAddress, 8) + Class1.DataToStrPro((long) this.ConOneTmReadCt, 4)) + "FD", 12, (int) this.GetDataTxRxBytePro(this.ConOneTmReadCt));
    }

    private string GetChkSum_AddrPro(string TempStr1)
    {
      byte[] Data = new byte[this.ConOneTmWriteCt + 6];
      string[] strArray = new string[this.ConOneTmWriteCt + 6];
      for (int index = 0; index < this.ConOneTmWriteCt + 6; ++index)
        strArray[index] = TempStr1.Substring(2 * index, 2);
      for (int index = 0; index < this.ConOneTmWriteCt + 6; ++index)
        Data[index] = Convert.ToByte(strArray[index], 16);
      TempStr1 = Convert.ToString((byte) (256U - (uint) Class1.GetChkSumPro(Data)), 16);
      if (TempStr1.Length == 1)
        TempStr1 = "0" + TempStr1;
      TempStr1 = Class1.Chga_z_ToA_Z(TempStr1);
      return TempStr1;
    }

    private void SendWriteDatAddComPro()
    {
      try
      {
        if (this.IicAddress >= this.ConMaxWriteAdrr)
        {
          this.CommuCt = (byte) 5;
          this.SendComDatPro("FEFEEEEFE555563938FD", 10, 7);
        }
        else
        {
          string str1 = this.WriteDataBuf[this.IicAddress / this.ConOneRowDatCt + this.FielBegRow];
          int length = this.ConOneTmWriteCt << 1;
          string str2 = this.IicAddress % this.ConOneRowDatCt != 0 ? str1.Substring(str1.Length - length, length) : str1.Substring(7, length);
          string TempStr1 = Class1.StrHexAutoAdd0Pro((long) this.IicAddress, (byte) 8) + Class1.StrHexAutoAdd0Pro((long) this.ConOneTmWriteCt, (byte) 4) + str2;
          this.SendComDatPro("FEFEEEEFE4" + (TempStr1 + this.GetChkSum_AddrPro(TempStr1)) + "FD", (int) this.GetDataTxRxBytePro(this.ConOneTmWriteCt), 7);
          this.IicAddress += this.ConOneTmWriteCt;
          if (this.IicAddress == 5760)
            this.IicAddress = Class1.EditEn ? 5760 : 6464;
          else if (this.IicAddress >= 5808 && this.IicAddress < 6464)
            this.IicAddress = 6464;
        }
      }
      catch
      {
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        this.GbCommDelay = (int) Convert.ToInt16(this.textBox1.Text, 10);
        this.Text = TongXun.ContlrName[Class1.English_En, 0];
        this.listBox1.Items.Clear();
        this.GbReadMod = true;
        this.GbWriteMod = false;
        this.CommuCt = (byte) 0;
        this.button1.Enabled = false;
        this.button2.Enabled = false;
        this.button3.Enabled = false;
        this.DataBuffer = "";
        this.GbFirComEn = true;
        Thread.Sleep(500);
        this.SendComDatPro("FEFEEEEFE055563938FD", 10, 36);
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 3], Class1.RadioName);
      }
    }

    private void ControlResPro1(object sender, EventArgs e)
    {
      this.button1.Enabled = true;
      this.button2.Enabled = true;
      this.button3.Enabled = true;
    }

    private void TimerResPro()
    {
      TongXun.aTimer = new System.Timers.Timer(10000.0);
      TongXun.aTimer.Elapsed += new ElapsedEventHandler(this.OnTimedEvent);
      TongXun.aTimer.Interval = 1000.0;
      TongXun.aTimer.Enabled = false;
    }

    private void TimeRestartPro()
    {
      TongXun.aTimer.Enabled = false;
      TongXun.aTimer.Interval = 3000.0;
      TongXun.aTimer.Enabled = true;
    }

    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
      if (!this.GbAtLineMod)
        this.serialPort1.Close();
      else
        this.GbAtLineMod = false;
      TongXun.aTimer.Enabled = false;
      if (this.GbFirComEn)
      {
        int num1 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 4], Class1.RadioName);
      }
      else
      {
        int num2 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 3], Class1.RadioName);
      }
      this.Invoke((Delegate) new EventHandler(this.ControlResPro1));
    }

    private void ControlResPro()
    {
      TongXun.aTimer.Enabled = false;
      this.button1.Enabled = true;
      this.button2.Enabled = true;
      this.button3.Enabled = true;
    }

    private void DisplayText(object sender, EventArgs e)
    {
      string strTest = "";
      string str1 = "";
      this.ComFail = false;
      try
      {
        this.TimeRestartPro();
        for (int index = 0; index < this.serialPort1.ReceivedBytesThreshold; ++index)
        {
          string str2 = Convert.ToString(this.RxBuffer[index], 16);
          if (str2.Length == 1)
            str2 = "0" + str2;
          strTest += str2;
        }
        string aZ = Class1.Chga_z_ToA_Z(strTest);
        this.ComTempStr = "RX: " + aZ;
        this.Invoke((Delegate) new EventHandler(this.ComuDis));
        string str3 = aZ.Substring(2 * this.SendByte, aZ.Length - 2 * this.SendByte);
        if (str3.Substring(str3.Length - 2, 2) != "FD")
        {
          this.ComFail = true;
          int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 15], Class1.RadioName);
          this.ControlResPro();
        }
        else
        {
          switch (this.CommuCt)
          {
            case 0:
              if (str3.Substring(0, 18) == "FEFEEFEEE155563938")
              {
                this.GbFirComEn = false;
                Class1.ConCodeBuf = str3.Substring(str3.Length - 14, 4);
                this.CommuCt = (byte) 2;
                break;
              }
              this.ComFail = true;
              int num1 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 15], Class1.RadioName);
              this.ControlResPro();
              break;
            case 1:
              if (str3.Substring(0, 14) == "FEFEEFEEE600FD")
              {
                this.CommuCt = !(Class1.ConCodeBuf == "3435") ? (byte) 3 : (byte) 2;
                break;
              }
              this.ComFail = true;
              int num2 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 15], Class1.RadioName);
              this.ControlResPro();
              break;
            case 2:
              if (str3.Substring(0, 14) == "FEFEEFEEE600FD")
              {
                this.CommuCt = (byte) 3;
                break;
              }
              TongXun.aTimer.Enabled = false;
              this.ComFail = true;
              int num3 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 8], Class1.RadioName);
              this.ControlResPro();
              break;
            case 3:
              if (str3.Substring(0, 14) == "FEFEEFEEE600FD")
              {
                this.IicAddress = 0;
                this.CommuCt = (byte) 4;
                break;
              }
              this.ComFail = true;
              int num4 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 15], Class1.RadioName);
              this.ControlResPro();
              break;
            case 4:
              if (this.GbReadMod)
              {
                if (str3.Substring(0, 10) == "FEFEEFEEE4")
                {
                  string str4 = str3.Substring(10, str3.Length - 12);
                  int num5 = this.ConOneRowDatCt << 1;
                  string str5 = str4.Substring(0, str4.Length - 2);
                  str1 = str5.Substring(0, 12);
                  string str6 = str5.Substring(12, str5.Length - 12);
                  if (this.IicAddress % this.ConOneRowDatCt == 0)
                  {
                    int num6 = str6.Length / num5;
                    int num7 = num6;
                    if (str6.Length % num5 != 0)
                      ++num7;
                    int num8;
                    for (num8 = 0; num8 < num6; ++num8)
                    {
                      this.DataBuffer = this.DataBuffer + "\n" + Class1.Chga_z_ToA_Z(Class1.StrHexAutoAdd0Pro((long) (this.IicAddress + this.ConOneRowDatCt * num8), (byte) 8).Substring(4, 4)) + Class1.StrHexAutoAdd0Pro((long) this.ConOneRowDatCt, (byte) 2);
                      this.DataBuffer = this.DataBuffer + Class1.Chga_z_ToA_Z(str6.Substring(0, num5)) + "\r";
                      str6 = str6.Substring(num5, str6.Length - num5);
                    }
                    if (num7 > num6)
                    {
                      this.DataBuffer = this.DataBuffer + "\n" + Class1.Chga_z_ToA_Z(Class1.StrHexAutoAdd0Pro((long) (this.IicAddress + this.ConOneRowDatCt * num8), (byte) 8).Substring(4, 4)) + Class1.StrHexAutoAdd0Pro((long) this.ConOneRowDatCt, (byte) 2);
                      this.DataBuffer = this.DataBuffer + str6 + "\r";
                    }
                  }
                  else
                  {
                    int num9 = this.IicAddress % this.ConOneRowDatCt << 1;
                    this.DataBuffer = this.DataBuffer + Class1.Chga_z_ToA_Z(str6.Substring(0, num9)) + "\r";
                    string str7 = str6.Substring(num9, str6.Length - num9);
                    int num10 = str7.Length / num5;
                    for (int index = 1; index < num10; ++index)
                    {
                      this.DataBuffer = this.DataBuffer + "\n" + Class1.Chga_z_ToA_Z(Class1.StrHexAutoAdd0Pro((long) (this.IicAddress + this.ConOneRowDatCt * index), (byte) 8).Substring(4, 4)) + Class1.StrHexAutoAdd0Pro((long) this.ConOneRowDatCt, (byte) 2);
                      this.DataBuffer = this.DataBuffer + Class1.Chga_z_ToA_Z(str7.Substring(0, num5)) + "\r";
                      str7 = str7.Substring(num5, str7.Length - num5);
                    }
                  }
                  this.IicAddress += this.ConOneTmReadCt;
                  double num11 = (double) this.IicAddress * 100.0 / (double) this.ConMaxReadAdrr;
                  if (num11 > 100.0)
                    num11 = 100.0;
                  this.progressBar1.Value = (int) num11;
                  break;
                }
                this.ComFail = true;
                int num12 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 15], Class1.RadioName);
                this.ControlResPro();
                break;
              }
              if (this.GbWriteMod)
              {
                if (str3.Substring(0, 14) == "FEFEEFEEE600FD")
                {
                  this.progressBar1.Value = (int) ((double) this.IicAddress * 100.0 / (double) this.ConMaxReadAdrr);
                  this.ComFail = false;
                  break;
                }
                this.ComFail = true;
                int num13 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 15], Class1.RadioName);
                this.ControlResPro();
                break;
              }
              break;
            case 5:
              if (str3.Substring(0, 14) == "FEFEEFEEE600FD")
              {
                TongXun.aTimer.Enabled = false;
                this.progressBar1.Value = 100;
                int num14 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 12], Class1.RadioName);
                this.ControlResPro();
                this.progressBar1.Value = 0;
                this.ComFail = false;
                break;
              }
              this.ComFail = true;
              int num15 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 15], Class1.RadioName);
              this.ControlResPro();
              break;
          }
        }
      }
      catch
      {
        this.ComFail = true;
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 15], Class1.RadioName);
        this.ControlResPro();
      }
    }

    private void SaveReadDataPro()
    {
      string[] StrData = Class1.ReadFileDataPro(this.GiFilePathName).Split('\r');
      string str1 = this.DataBuffer.Substring(0, 1);
      if ("\n" == str1 || "n" == str1)
        this.DataBuffer = this.DataBuffer.Substring(1, this.DataBuffer.Length - 1);
      string[] strArray = this.DataBuffer.Split('\n');
      int num = Class1.FielBegRow;
      for (int index1 = 0; index1 <= strArray.GetLength(0) - 1; ++index1)
      {
        string aZ = Class1.Chga_z_ToA_Z(strArray[index1].Substring(0, 6));
        if (index1 == 135)
          index1 = 135;
        int index2;
        for (index2 = num; index2 <= StrData.GetLength(0) - 1; ++index2)
        {
          if (StrData[index2].Length >= 1)
          {
            string str2 = StrData[index2].Substring(0, 1);
            if ((!(str2 == "\n") && !(str2 == "n") ? StrData[index2].Substring(0, 6) : StrData[index2].Substring(1, 6)) == aZ)
            {
              StrData[index2] = "\n" + strArray[index1];
              num = index2;
              break;
            }
          }
        }
        if (index2 == StrData.GetLength(0))
          break;
      }
      for (int index = 0; index <= StrData.GetLength(0) - 1; ++index)
      {
        string str3 = StrData[index];
        if (str3.Length != 0 && str3.Substring(str3.Length - 1, 1) == "\r")
          StrData[index] = StrData[index].Substring(0, StrData[index].Length - 1);
      }
      Class1.SaveFileDataPro(this.GiFilePathName, StrData);
    }

    private void CloseWindPro(object sender, EventArgs e) => this.Close();

    private void LoadCodeWindow(object sender, EventArgs e)
    {
      int num = (int) new 密码输入框()
      {
        GiFileName1 = this.GiFilePathName,
        CodeTypePt = 0
      }.ShowDialog((IWin32Window) this);
    }

    private void LoadCodeWindow1(object sender, EventArgs e)
    {
      int num = (int) new 密码输入框()
      {
        GiFileName1 = this.GiFilePathName,
        CodeTypePt = 1
      }.ShowDialog((IWin32Window) this);
    }

    private void LoadCodeWindow2(object sender, EventArgs e)
    {
      int num = (int) new 密码输入框()
      {
        GiFileName1 = this.GiFilePathName,
        CodeTypePt = 2
      }.ShowDialog((IWin32Window) this);
    }

    private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      if (this.serialPort1.ReceivedBytesThreshold != this.serialPort1.BytesToRead)
        return;
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
          this.serialPort1.Close();
        else
          this.GbAtLineMod = false;
        switch (this.CommuCt)
        {
          case 0:
            this.SendComDatPro("FEFEEEEFE055563938FD", 10, 36);
            break;
          case 1:
            this.SendBaudComDatPro();
            break;
          case 2:
            bool flag = true;
            flag = true;
            if (Class1.ConCodeBuf == "3435")
            {
              TongXun.aTimer.Enabled = false;
              this.Invoke((Delegate) new EventHandler(this.LoadCodeWindow));
              this.SendComDatPro("FEFEEEEFE7" + Class1.GiRightCode + "FD", 10, 7);
              break;
            }
            this.CommuCt = (byte) 3;
            if (this.GbReadMod)
              this.SendComDatPro("FEFEEEEFE255563938FD", 10, 7);
            else if (this.GbWriteMod)
              this.SendComDatPro("FEFEEEEFE355563938FD", 10, 7);
            break;
          case 3:
            if (this.GbReadMod)
            {
              this.SendComDatPro("FEFEEEEFE255563938FD", 10, 7);
              break;
            }
            if (this.GbWriteMod)
            {
              this.SendComDatPro("FEFEEEEFE355563938FD", 10, 7);
              break;
            }
            break;
          case 4:
            if (this.GbReadMod)
            {
              this.SendReadDatAddComPro();
              break;
            }
            if (this.GbWriteMod)
            {
              this.SendWriteDatAddComPro();
              break;
            }
            break;
          case 5:
            if (this.GbReadMod)
            {
              this.SaveReadDataPro();
              this.R_W_Succeed = true;
            }
            this.serialPort1.Close();
            if (!this.ComunicationDisEn)
            {
              this.Invoke((Delegate) new EventHandler(this.CloseWindPro));
              break;
            }
            break;
        }
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (!this.GbAtLineMod)
        this.serialPort1.Close();
      else
        this.GbAtLineMod = false;
      TongXun.aTimer.Enabled = false;
      int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 3], Class1.RadioName);
      this.button1.Enabled = true;
      this.button2.Enabled = true;
      this.button3.Enabled = true;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.OpenWkorkComPro() == (byte) 0)
          return;
        this.GbCommDelay = (int) Convert.ToInt16(this.textBox1.Text, 10);
        this.listBox1.Items.Clear();
        this.Text = TongXun.ContlrName[Class1.English_En, 1];
        this.GbWriteMod = true;
        this.GbReadMod = false;
        this.CommuCt = (byte) 0;
        this.button1.Enabled = false;
        this.button2.Enabled = false;
        this.button3.Enabled = false;
        this.WriteDataBuf = Class1.ReadFileDataPro(this.GiFilePathName).Split('\r');
        this.GbFirComEn = true;
        Thread.Sleep(500);
        this.SendComDatPro("FEFEEEEFE055563938FD", 10, 36);
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 3], Class1.RadioName);
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.serialPort1.Close();
      TongXun.aTimer.Enabled = false;
      this.Close();
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void TongXun_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.serialPort1.Close();
      TongXun.aTimer.Enabled = false;
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e) => this.OnlyOneLine = this.radioButton1.Checked;

    private void groupBox3_MouseCaptureChanged(object sender, EventArgs e)
    {
      if (this.ComunicationDisEn)
      {
        this.Height -= this.listBox1.Height;
        this.listBox1.Visible = false;
        this.ComunicationDisEn = false;
        this.label3.Enabled = false;
        this.label3.Visible = false;
        this.textBox1.Enabled = false;
        this.textBox1.Visible = false;
      }
      else
      {
        this.Height += this.listBox1.Height;
        this.listBox1.Visible = true;
        this.ComunicationDisEn = true;
        this.label3.Enabled = true;
        this.label3.Visible = true;
        this.textBox1.Enabled = true;
        this.textBox1.Visible = true;
      }
    }

    private void groupBox3_Enter(object sender, EventArgs e)
    {
    }
  }
}
