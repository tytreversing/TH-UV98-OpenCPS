// Decompiled with JetBrains decompiler
// Type: _8890DTest.RadioSYS
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class RadioSYS : Form
  {
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private Label label15;
    private Label label14;
    private Label label13;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox textBox22;
    private TextBox textBox21;
    private TextBox textBox20;
    private TextBox textBox19;
    private TextBox textBox18;
    private TextBox textBox17;
    private TextBox textBox16;
    private TextBox textBox15;
    private TextBox textBox14;
    private TextBox textBox13;
    private TextBox textBox12;
    private TextBox textBox11;
    private TextBox textBox10;
    private TextBox textBox9;
    private TextBox textBox8;
    private TextBox textBox7;
    private TextBox textBox6;
    private TextBox textBox5;
    private TextBox textBox4;
    private TextBox textBox3;
    private TextBox textBox2;
    private TextBox textBox1;
    private Label label24;
    private Label label23;
    private Label label22;
    private Label label21;
    private Label label20;
    private Label label19;
    private Label label18;
    private Label label17;
    private Label label16;
    private TextBox textBox24;
    private TextBox textBox23;
    private Label label27;
    private Label label26;
    private Label label25;
    private Button button1;
    private Button button2;
    private GroupBox groupBox2;
    private Label label28;
    private TextBox textBox25;
    private Label label29;
    public string GiFileName = "8890D_TempFile.icf";
    public static string[,] lableArrName = new string[2, 15]
    {
      {
        "   频率(MHZ)  ",
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
        "Frequency(MHZ)",
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
    public static string[,] lableArrChannelName = new string[2, 1]
    {
      {
        "   信道"
      },
      {
        "Channel"
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
    private Label[] Label_Arr;
    private ComboBox[] ComboBoxl_Arr;
    private TextBox[] TextBoxl_Arr;
    private CheckBox[] CheckBox_Arr;
    private GroupBox[] GroupBox_Arr;
    private Button[] Button_Arr;
    private string GiRxFreTemp;
    public bool GbChChangeen = false;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.label27 = new Label();
      this.label26 = new Label();
      this.label25 = new Label();
      this.textBox24 = new TextBox();
      this.textBox23 = new TextBox();
      this.textBox22 = new TextBox();
      this.textBox21 = new TextBox();
      this.textBox20 = new TextBox();
      this.textBox19 = new TextBox();
      this.textBox18 = new TextBox();
      this.textBox17 = new TextBox();
      this.textBox16 = new TextBox();
      this.textBox15 = new TextBox();
      this.textBox14 = new TextBox();
      this.textBox13 = new TextBox();
      this.textBox12 = new TextBox();
      this.textBox11 = new TextBox();
      this.textBox10 = new TextBox();
      this.textBox9 = new TextBox();
      this.textBox8 = new TextBox();
      this.textBox7 = new TextBox();
      this.textBox6 = new TextBox();
      this.textBox5 = new TextBox();
      this.textBox4 = new TextBox();
      this.textBox3 = new TextBox();
      this.textBox2 = new TextBox();
      this.textBox1 = new TextBox();
      this.label24 = new Label();
      this.label23 = new Label();
      this.label22 = new Label();
      this.label21 = new Label();
      this.label20 = new Label();
      this.label19 = new Label();
      this.label18 = new Label();
      this.label17 = new Label();
      this.label16 = new Label();
      this.label15 = new Label();
      this.label14 = new Label();
      this.label13 = new Label();
      this.label12 = new Label();
      this.label11 = new Label();
      this.label10 = new Label();
      this.label9 = new Label();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.button1 = new Button();
      this.button2 = new Button();
      this.groupBox2 = new GroupBox();
      this.label28 = new Label();
      this.textBox25 = new TextBox();
      this.label29 = new Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.AutoSize = true;
      this.groupBox1.Controls.Add((Control) this.label27);
      this.groupBox1.Controls.Add((Control) this.label26);
      this.groupBox1.Controls.Add((Control) this.label25);
      this.groupBox1.Controls.Add((Control) this.textBox24);
      this.groupBox1.Controls.Add((Control) this.textBox23);
      this.groupBox1.Controls.Add((Control) this.textBox22);
      this.groupBox1.Controls.Add((Control) this.textBox21);
      this.groupBox1.Controls.Add((Control) this.textBox20);
      this.groupBox1.Controls.Add((Control) this.textBox19);
      this.groupBox1.Controls.Add((Control) this.textBox18);
      this.groupBox1.Controls.Add((Control) this.textBox17);
      this.groupBox1.Controls.Add((Control) this.textBox16);
      this.groupBox1.Controls.Add((Control) this.textBox15);
      this.groupBox1.Controls.Add((Control) this.textBox14);
      this.groupBox1.Controls.Add((Control) this.textBox13);
      this.groupBox1.Controls.Add((Control) this.textBox12);
      this.groupBox1.Controls.Add((Control) this.textBox11);
      this.groupBox1.Controls.Add((Control) this.textBox10);
      this.groupBox1.Controls.Add((Control) this.textBox9);
      this.groupBox1.Controls.Add((Control) this.textBox8);
      this.groupBox1.Controls.Add((Control) this.textBox7);
      this.groupBox1.Controls.Add((Control) this.textBox6);
      this.groupBox1.Controls.Add((Control) this.textBox5);
      this.groupBox1.Controls.Add((Control) this.textBox4);
      this.groupBox1.Controls.Add((Control) this.textBox3);
      this.groupBox1.Controls.Add((Control) this.textBox2);
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Controls.Add((Control) this.label24);
      this.groupBox1.Controls.Add((Control) this.label23);
      this.groupBox1.Controls.Add((Control) this.label22);
      this.groupBox1.Controls.Add((Control) this.label21);
      this.groupBox1.Controls.Add((Control) this.label20);
      this.groupBox1.Controls.Add((Control) this.label19);
      this.groupBox1.Controls.Add((Control) this.label18);
      this.groupBox1.Controls.Add((Control) this.label17);
      this.groupBox1.Controls.Add((Control) this.label16);
      this.groupBox1.Controls.Add((Control) this.label15);
      this.groupBox1.Controls.Add((Control) this.label14);
      this.groupBox1.Controls.Add((Control) this.label13);
      this.groupBox1.Controls.Add((Control) this.label12);
      this.groupBox1.Controls.Add((Control) this.label11);
      this.groupBox1.Controls.Add((Control) this.label10);
      this.groupBox1.Controls.Add((Control) this.label9);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(5, 72);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(552, 323);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.label27.AutoSize = true;
      this.label27.Location = new Point(439, 17);
      this.label27.Name = "label27";
      this.label27.Size = new Size(89, 12);
      this.label27.TabIndex = 49;
      this.label27.Text = "     频率(MHZ)";
      this.label26.AutoSize = true;
      this.label26.Location = new Point(262, 17);
      this.label26.Name = "label26";
      this.label26.Size = new Size(89, 12);
      this.label26.TabIndex = 48;
      this.label26.Text = "     频率(MHZ)";
      this.label25.AutoSize = true;
      this.label25.Location = new Point(82, 17);
      this.label25.Name = "label25";
      this.label25.Size = new Size(89, 12);
      this.label25.TabIndex = 47;
      this.label25.Text = "     频率(MHZ)";
      this.textBox24.Location = new Point(433, 282);
      this.textBox24.Name = "textBox24";
      this.textBox24.Size = new Size(100, 21);
      this.textBox24.TabIndex = 46;
      this.textBox24.Text = "90.4";
      this.textBox24.Leave += new EventHandler(this.textBox24_Leave);
      this.textBox24.KeyPress += new KeyPressEventHandler(this.textBox24_KeyPress);
      this.textBox24.Enter += new EventHandler(this.textBox24_Enter);
      this.textBox23.Location = new Point(433, 248);
      this.textBox23.Name = "textBox23";
      this.textBox23.Size = new Size(100, 21);
      this.textBox23.TabIndex = 45;
      this.textBox23.Text = "90.4";
      this.textBox23.Leave += new EventHandler(this.textBox23_Leave);
      this.textBox23.KeyPress += new KeyPressEventHandler(this.textBox23_KeyPress);
      this.textBox23.Enter += new EventHandler(this.textBox23_Enter);
      this.textBox22.Location = new Point(433, 209);
      this.textBox22.Name = "textBox22";
      this.textBox22.Size = new Size(100, 21);
      this.textBox22.TabIndex = 44;
      this.textBox22.Text = "90.4";
      this.textBox22.Leave += new EventHandler(this.textBox22_Leave);
      this.textBox22.KeyPress += new KeyPressEventHandler(this.textBox22_KeyPress);
      this.textBox22.Enter += new EventHandler(this.textBox22_Enter);
      this.textBox21.Location = new Point(433, 175);
      this.textBox21.Name = "textBox21";
      this.textBox21.Size = new Size(100, 21);
      this.textBox21.TabIndex = 43;
      this.textBox21.Text = "90.4";
      this.textBox21.Leave += new EventHandler(this.textBox21_Leave);
      this.textBox21.KeyPress += new KeyPressEventHandler(this.textBox21_KeyPress);
      this.textBox21.Enter += new EventHandler(this.textBox21_Enter);
      this.textBox20.Location = new Point(433, 141);
      this.textBox20.Name = "textBox20";
      this.textBox20.Size = new Size(100, 21);
      this.textBox20.TabIndex = 42;
      this.textBox20.Text = "90.4";
      this.textBox20.Leave += new EventHandler(this.textBox20_Leave);
      this.textBox20.KeyPress += new KeyPressEventHandler(this.textBox20_KeyPress);
      this.textBox20.Enter += new EventHandler(this.textBox20_Leave);
      this.textBox19.Location = new Point(433, 107);
      this.textBox19.Name = "textBox19";
      this.textBox19.Size = new Size(100, 21);
      this.textBox19.TabIndex = 41;
      this.textBox19.Text = "90.4";
      this.textBox19.Leave += new EventHandler(this.textBox19_Leave);
      this.textBox19.KeyPress += new KeyPressEventHandler(this.textBox19_KeyPress);
      this.textBox19.Enter += new EventHandler(this.textBox19_Enter);
      this.textBox18.Location = new Point(433, 73);
      this.textBox18.Name = "textBox18";
      this.textBox18.Size = new Size(100, 21);
      this.textBox18.TabIndex = 40;
      this.textBox18.Text = "90.4";
      this.textBox18.Leave += new EventHandler(this.textBox18_Leave);
      this.textBox18.KeyPress += new KeyPressEventHandler(this.textBox18_KeyPress);
      this.textBox18.Enter += new EventHandler(this.textBox18_Enter);
      this.textBox17.Location = new Point(433, 39);
      this.textBox17.Name = "textBox17";
      this.textBox17.Size = new Size(100, 21);
      this.textBox17.TabIndex = 39;
      this.textBox17.Text = "90.4";
      this.textBox17.Leave += new EventHandler(this.textBox17_Leave);
      this.textBox17.KeyPress += new KeyPressEventHandler(this.textBox17_KeyPress);
      this.textBox17.Enter += new EventHandler(this.textBox17_Enter);
      this.textBox16.Location = new Point(256, 282);
      this.textBox16.Name = "textBox16";
      this.textBox16.Size = new Size(100, 21);
      this.textBox16.TabIndex = 38;
      this.textBox16.Text = "90.4";
      this.textBox16.Leave += new EventHandler(this.textBox16_Leave);
      this.textBox16.KeyPress += new KeyPressEventHandler(this.textBox16_KeyPress);
      this.textBox16.Enter += new EventHandler(this.textBox16_Enter);
      this.textBox15.Location = new Point(256, 248);
      this.textBox15.Name = "textBox15";
      this.textBox15.Size = new Size(100, 21);
      this.textBox15.TabIndex = 38;
      this.textBox15.Text = "90.4";
      this.textBox15.Leave += new EventHandler(this.textBox15_Leave);
      this.textBox15.KeyPress += new KeyPressEventHandler(this.textBox15_KeyPress);
      this.textBox15.Enter += new EventHandler(this.textBox15_Enter);
      this.textBox14.Location = new Point(256, 209);
      this.textBox14.Name = "textBox14";
      this.textBox14.Size = new Size(100, 21);
      this.textBox14.TabIndex = 37;
      this.textBox14.Text = "90.4";
      this.textBox14.Leave += new EventHandler(this.textBox14_Leave);
      this.textBox14.KeyPress += new KeyPressEventHandler(this.textBox14_KeyPress);
      this.textBox14.Enter += new EventHandler(this.textBox14_Enter);
      this.textBox13.Location = new Point(256, 175);
      this.textBox13.Name = "textBox13";
      this.textBox13.Size = new Size(100, 21);
      this.textBox13.TabIndex = 36;
      this.textBox13.Text = "90.4";
      this.textBox13.Leave += new EventHandler(this.textBox13_Leave);
      this.textBox13.KeyPress += new KeyPressEventHandler(this.textBox13_KeyPress);
      this.textBox13.Enter += new EventHandler(this.textBox13_Enter);
      this.textBox12.Location = new Point(256, 141);
      this.textBox12.Name = "textBox12";
      this.textBox12.Size = new Size(100, 21);
      this.textBox12.TabIndex = 35;
      this.textBox12.Text = "90.4";
      this.textBox12.Leave += new EventHandler(this.textBox12_Leave);
      this.textBox12.KeyPress += new KeyPressEventHandler(this.textBox12_KeyPress);
      this.textBox12.Enter += new EventHandler(this.textBox12_Enter);
      this.textBox11.Location = new Point(256, 107);
      this.textBox11.Name = "textBox11";
      this.textBox11.Size = new Size(100, 21);
      this.textBox11.TabIndex = 34;
      this.textBox11.Text = "90.4";
      this.textBox11.Leave += new EventHandler(this.textBox11_Leave);
      this.textBox11.KeyPress += new KeyPressEventHandler(this.textBox11_KeyPress);
      this.textBox11.Enter += new EventHandler(this.textBox11_Enter);
      this.textBox10.Location = new Point(256, 73);
      this.textBox10.Name = "textBox10";
      this.textBox10.Size = new Size(100, 21);
      this.textBox10.TabIndex = 33;
      this.textBox10.Text = "90.4";
      this.textBox10.Leave += new EventHandler(this.textBox10_Leave);
      this.textBox10.KeyPress += new KeyPressEventHandler(this.textBox10_KeyPress);
      this.textBox10.Enter += new EventHandler(this.textBox10_Enter);
      this.textBox9.Location = new Point(256, 39);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new Size(100, 21);
      this.textBox9.TabIndex = 32;
      this.textBox9.Text = "90.4";
      this.textBox9.Leave += new EventHandler(this.textBox9_Leave);
      this.textBox9.KeyPress += new KeyPressEventHandler(this.textBox9_KeyPress);
      this.textBox9.Enter += new EventHandler(this.textBox9_Enter);
      this.textBox8.Location = new Point(76, 282);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new Size(100, 21);
      this.textBox8.TabIndex = 31;
      this.textBox8.Text = "90.4";
      this.textBox8.Leave += new EventHandler(this.textBox8_Leave);
      this.textBox8.KeyPress += new KeyPressEventHandler(this.textBox8_KeyPress);
      this.textBox8.Enter += new EventHandler(this.textBox8_Enter);
      this.textBox7.Location = new Point(76, 248);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new Size(100, 21);
      this.textBox7.TabIndex = 30;
      this.textBox7.Text = "90.4";
      this.textBox7.Leave += new EventHandler(this.textBox7_Leave);
      this.textBox7.KeyPress += new KeyPressEventHandler(this.textBox7_KeyPress);
      this.textBox7.Enter += new EventHandler(this.textBox7_Enter);
      this.textBox6.Location = new Point(76, 209);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(100, 21);
      this.textBox6.TabIndex = 29;
      this.textBox6.Text = "90.4";
      this.textBox6.Leave += new EventHandler(this.textBox6_Leave);
      this.textBox6.KeyPress += new KeyPressEventHandler(this.textBox6_KeyPress);
      this.textBox6.Enter += new EventHandler(this.textBox6_Enter);
      this.textBox5.Location = new Point(76, 175);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(100, 21);
      this.textBox5.TabIndex = 28;
      this.textBox5.Text = "90.4";
      this.textBox5.Leave += new EventHandler(this.textBox5_Leave);
      this.textBox5.KeyPress += new KeyPressEventHandler(this.textBox5_KeyPress);
      this.textBox5.Enter += new EventHandler(this.textBox5_Enter);
      this.textBox4.Location = new Point(76, 141);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(100, 21);
      this.textBox4.TabIndex = 27;
      this.textBox4.Text = "90.4";
      this.textBox4.Leave += new EventHandler(this.textBox4_Leave);
      this.textBox4.KeyPress += new KeyPressEventHandler(this.textBox4_KeyPress);
      this.textBox4.Enter += new EventHandler(this.textBox4_Enter);
      this.textBox3.Location = new Point(76, 107);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(100, 21);
      this.textBox3.TabIndex = 26;
      this.textBox3.Text = "90.4";
      this.textBox3.Leave += new EventHandler(this.textBox3_Leave);
      this.textBox3.KeyPress += new KeyPressEventHandler(this.textBox3_KeyPress);
      this.textBox3.Enter += new EventHandler(this.textBox3_Enter);
      this.textBox2.Location = new Point(76, 73);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(100, 21);
      this.textBox2.TabIndex = 25;
      this.textBox2.Text = "90.4";
      this.textBox2.Leave += new EventHandler(this.textBox2_Leave);
      this.textBox2.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
      this.textBox2.Enter += new EventHandler(this.textBox12_Enter);
      this.textBox1.Location = new Point(76, 39);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 21);
      this.textBox1.TabIndex = 24;
      this.textBox1.Text = "90.4";
      this.textBox1.Leave += new EventHandler(this.textBox1_Leave);
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.textBox1.Enter += new EventHandler(this.textBox1_Enter);
      this.label24.AutoSize = true;
      this.label24.Location = new Point(366, 286);
      this.label24.Name = "label24";
      this.label24.Size = new Size(59, 12);
      this.label24.TabIndex = 23;
      this.label24.Text = "Channel24";
      this.label23.AutoSize = true;
      this.label23.Location = new Point(366, 252);
      this.label23.Name = "label23";
      this.label23.Size = new Size(59, 12);
      this.label23.TabIndex = 22;
      this.label23.Text = "Channel24";
      this.label22.AutoSize = true;
      this.label22.Location = new Point(366, 218);
      this.label22.Name = "label22";
      this.label22.Size = new Size(59, 12);
      this.label22.TabIndex = 21;
      this.label22.Text = "Channel24";
      this.label21.AutoSize = true;
      this.label21.Location = new Point(366, 184);
      this.label21.Name = "label21";
      this.label21.Size = new Size(59, 12);
      this.label21.TabIndex = 20;
      this.label21.Text = "Channel24";
      this.label20.AutoSize = true;
      this.label20.Location = new Point(366, 150);
      this.label20.Name = "label20";
      this.label20.Size = new Size(59, 12);
      this.label20.TabIndex = 19;
      this.label20.Text = "Channel24";
      this.label19.AutoSize = true;
      this.label19.Location = new Point(366, 116);
      this.label19.Name = "label19";
      this.label19.Size = new Size(59, 12);
      this.label19.TabIndex = 18;
      this.label19.Text = "Channel24";
      this.label18.AutoSize = true;
      this.label18.Location = new Point(366, 82);
      this.label18.Name = "label18";
      this.label18.Size = new Size(59, 12);
      this.label18.TabIndex = 17;
      this.label18.Text = "Channel24";
      this.label17.AutoSize = true;
      this.label17.Location = new Point(366, 48);
      this.label17.Name = "label17";
      this.label17.Size = new Size(59, 12);
      this.label17.TabIndex = 16;
      this.label17.Text = "Channel24";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(188, 286);
      this.label16.Name = "label16";
      this.label16.Size = new Size(59, 12);
      this.label16.TabIndex = 15;
      this.label16.Text = "Channel16";
      this.label15.AutoSize = true;
      this.label15.Location = new Point(188, 252);
      this.label15.Name = "label15";
      this.label15.Size = new Size(59, 12);
      this.label15.TabIndex = 14;
      this.label15.Text = "Channel16";
      this.label14.AutoSize = true;
      this.label14.Location = new Point(188, 218);
      this.label14.Name = "label14";
      this.label14.Size = new Size(59, 12);
      this.label14.TabIndex = 13;
      this.label14.Text = "Channel16";
      this.label13.AutoSize = true;
      this.label13.Location = new Point(188, 184);
      this.label13.Name = "label13";
      this.label13.Size = new Size(59, 12);
      this.label13.TabIndex = 12;
      this.label13.Text = "Channel16";
      this.label12.AutoSize = true;
      this.label12.Location = new Point(188, 150);
      this.label12.Name = "label12";
      this.label12.Size = new Size(59, 12);
      this.label12.TabIndex = 11;
      this.label12.Text = "Channel16";
      this.label11.AutoSize = true;
      this.label11.Location = new Point(188, 116);
      this.label11.Name = "label11";
      this.label11.Size = new Size(59, 12);
      this.label11.TabIndex = 10;
      this.label11.Text = "Channel16";
      this.label10.AutoSize = true;
      this.label10.Location = new Point(188, 82);
      this.label10.Name = "label10";
      this.label10.Size = new Size(59, 12);
      this.label10.TabIndex = 9;
      this.label10.Text = "Channel16";
      this.label9.AutoSize = true;
      this.label9.Location = new Point(188, 48);
      this.label9.Name = "label9";
      this.label9.Size = new Size(59, 12);
      this.label9.TabIndex = 8;
      this.label9.Text = "Channel16";
      this.label8.AutoSize = true;
      this.label8.Location = new Point(15, 286);
      this.label8.Name = "label8";
      this.label8.Size = new Size(53, 12);
      this.label8.TabIndex = 7;
      this.label8.Text = "Channel8";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(15, 252);
      this.label7.Name = "label7";
      this.label7.Size = new Size(53, 12);
      this.label7.TabIndex = 6;
      this.label7.Text = "Channel8";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(15, 218);
      this.label6.Name = "label6";
      this.label6.Size = new Size(53, 12);
      this.label6.TabIndex = 5;
      this.label6.Text = "Channel8";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(15, 184);
      this.label5.Name = "label5";
      this.label5.Size = new Size(53, 12);
      this.label5.TabIndex = 4;
      this.label5.Text = "Channel8";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(15, 150);
      this.label4.Name = "label4";
      this.label4.Size = new Size(53, 12);
      this.label4.TabIndex = 3;
      this.label4.Text = "Channel8";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(15, 116);
      this.label3.Name = "label3";
      this.label3.Size = new Size(53, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "Channel8";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(15, 82);
      this.label2.Name = "label2";
      this.label2.Size = new Size(53, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "Channel8";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(15, 48);
      this.label1.Name = "label1";
      this.label1.Size = new Size(53, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "Channel8";
      this.button1.Location = new Point(125, 413);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(286, 413);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.groupBox2.Controls.Add((Control) this.label28);
      this.groupBox2.Controls.Add((Control) this.textBox25);
      this.groupBox2.Controls.Add((Control) this.label29);
      this.groupBox2.Location = new Point(5, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(166, 71);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "VFO";
      this.label28.AutoSize = true;
      this.label28.Location = new Point(31, 17);
      this.label28.Name = "label28";
      this.label28.Size = new Size(89, 12);
      this.label28.TabIndex = 50;
      this.label28.Text = "     频率(MHZ)";
      this.textBox25.Location = new Point(33, 42);
      this.textBox25.Name = "textBox25";
      this.textBox25.Size = new Size(100, 21);
      this.textBox25.TabIndex = 49;
      this.textBox25.Text = "90.4";
      this.textBox25.Leave += new EventHandler(this.textBox25_Leave);
      this.textBox25.KeyPress += new KeyPressEventHandler(this.textBox25_KeyPress);
      this.textBox25.Enter += new EventHandler(this.textBox25_Enter);
      this.label29.AutoSize = true;
      this.label29.Location = new Point(12, 51);
      this.label29.Name = "label29";
      this.label29.Size = new Size(0, 12);
      this.label29.TabIndex = 48;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(564, 449);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = nameof (RadioSYS);
      this.Text = nameof (RadioSYS);
      this.Load += new EventHandler(this.RadioSYS_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public RadioSYS()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void SetContrlAs_arrPro()
    {
      this.Label_Arr = new Label[37];
      this.Label_Arr[0] = this.label1;
      this.Label_Arr[1] = this.label2;
      this.Label_Arr[2] = this.label3;
      this.Label_Arr[3] = this.label4;
      this.Label_Arr[4] = this.label5;
      this.Label_Arr[5] = this.label6;
      this.Label_Arr[6] = this.label7;
      this.Label_Arr[7] = this.label8;
      this.Label_Arr[8] = this.label9;
      this.Label_Arr[9] = this.label10;
      this.Label_Arr[10] = this.label11;
      this.Label_Arr[11] = this.label12;
      this.Label_Arr[12] = this.label13;
      this.Label_Arr[13] = this.label14;
      this.Label_Arr[14] = this.label15;
      this.Label_Arr[15] = this.label16;
      this.Label_Arr[16] = this.label17;
      this.Label_Arr[17] = this.label18;
      this.Label_Arr[18] = this.label19;
      this.Label_Arr[19] = this.label20;
      this.Label_Arr[20] = this.label21;
      this.Label_Arr[21] = this.label22;
      this.Label_Arr[22] = this.label23;
      this.Label_Arr[23] = this.label24;
      this.Label_Arr[24] = this.label25;
      this.Label_Arr[25] = this.label26;
      this.Label_Arr[26] = this.label27;
      this.Label_Arr[27] = this.label28;
      this.TextBoxl_Arr = new TextBox[24];
      this.TextBoxl_Arr[0] = this.textBox1;
      this.TextBoxl_Arr[1] = this.textBox2;
      this.TextBoxl_Arr[2] = this.textBox3;
      this.TextBoxl_Arr[3] = this.textBox4;
      this.TextBoxl_Arr[4] = this.textBox5;
      this.TextBoxl_Arr[5] = this.textBox6;
      this.TextBoxl_Arr[6] = this.textBox7;
      this.TextBoxl_Arr[7] = this.textBox8;
      this.TextBoxl_Arr[8] = this.textBox9;
      this.TextBoxl_Arr[9] = this.textBox10;
      this.TextBoxl_Arr[10] = this.textBox11;
      this.TextBoxl_Arr[11] = this.textBox12;
      this.TextBoxl_Arr[12] = this.textBox13;
      this.TextBoxl_Arr[13] = this.textBox14;
      this.TextBoxl_Arr[14] = this.textBox15;
      this.TextBoxl_Arr[15] = this.textBox16;
      this.TextBoxl_Arr[16] = this.textBox17;
      this.TextBoxl_Arr[17] = this.textBox18;
      this.TextBoxl_Arr[18] = this.textBox19;
      this.TextBoxl_Arr[19] = this.textBox20;
      this.TextBoxl_Arr[20] = this.textBox21;
      this.TextBoxl_Arr[21] = this.textBox22;
      this.TextBoxl_Arr[22] = this.textBox23;
      this.TextBoxl_Arr[23] = this.textBox24;
      this.Button_Arr = new Button[2];
      this.Button_Arr[0] = this.button1;
      this.Button_Arr[1] = this.button2;
    }

    private string GetOneRadioChStringPro(string[] n, int i)
    {
      int num = Class1.ConOneRadioChDatCt * i / Class1.ConOneRowDatCt + Class1.ConRadioBegAdd / Class1.ConOneRowDatCt;
      string str1 = Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num]);
      string str2 = str1.Substring(Class1.ConUseChDatSta + 1, str1.Length - Class1.ConUseChDatSta - 1);
      string str3 = Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num + 1]);
      return (str2 + str3.Substring(Class1.ConUseChDatSta + 1, str3.Length - Class1.ConUseChDatSta - 1)).Substring(Class1.ConOneRadioChDatCt * i % Class1.ConOneRowDatCt << 1, 2 * Class1.ConOneRadioChDatCt);
    }

    private void load_WinDisplayPro()
    {
      byte[] numArray = new byte[4];
      int num1 = 24;
      string[] n = Class1.ReadFileDataPro(this.GiFileName).Split('\r');
      for (int i = 0; i < num1; ++i)
      {
        string str1;
        try
        {
          str1 = Class2.StringChUsefulPro(Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + Class1.ConRadioEnableBegAdd / Class1.ConOneRowDatCt]), i) != 0 ? this.GetOneRadioChStringPro(n, i) : "";
        }
        catch
        {
          str1 = "";
        }
        string str2;
        if (str1 != "")
        {
          try
          {
            str2 = Class2.StringChgFrePro(Class2.StringChgPro(str1.Substring(0, 8), 4), 5);
          }
          catch
          {
            str2 = "";
          }
        }
        else
          str2 = "";
        this.TextBoxl_Arr[i].Text = str2;
      }
      string str3;
      try
      {
        int num2 = Class1.ConFMVfoBegAdd / Class1.ConOneRowDatCt;
        string str4 = Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num2]);
        str3 = Class2.StringChgFrePro(Class2.StringChgPro(str4.Substring(Class1.ConUseChDatSta + 1, str4.Length - Class1.ConUseChDatSta - 1).Substring(Class1.ConFMVfoBegAdd % Class1.ConOneRowDatCt << 1, 8), 4), 5);
      }
      catch
      {
        str3 = "90.4";
      }
      this.textBox25.Text = str3;
    }

    private void RadioSYS_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.SetContrlAs_arrPro();
      for (int index = 0; index <= 1; ++index)
        this.Button_Arr[index].Text = RadioSYS.Button_EngCh[Class1.English_En, index];
      for (int index = 0; index <= 23; ++index)
        this.Label_Arr[index].Text = RadioSYS.lableArrChannelName[Class1.English_En, 0] + (index + 1).ToString();
      for (int index = 0; index <= 23; ++index)
        this.TextBoxl_Arr[index].Text = "";
      for (int index = 24; index <= 27; ++index)
        this.Label_Arr[index].Text = RadioSYS.lableArrName[Class1.English_En, 0];
      this.load_WinDisplayPro();
    }

    private void SavRadioDatPro(string CurrStr, string FileName)
    {
      string[] StrData = Class1.ReadFileDataPro(FileName).Split('\r');
      string str = StrData[Class1.FielBegRow + Class1.ConRadioBegAdd / Class1.ConOneRowDatCt] + StrData[Class1.FielBegRow + Class1.ConRadioBegAdd / Class1.ConOneRowDatCt + 1] + StrData[Class1.FielBegRow + Class1.ConRadioBegAdd / Class1.ConOneRowDatCt + 2];
      Class1.SaveFileDataPro(FileName, StrData);
    }

    private void RadioChSavePro(string Chinf, string FileName)
    {
      string[] StrData = Class1.ReadFileDataPro(FileName).Split('\r');
      int num1 = Class1.FielBegRow + Class1.ConRadioBegAdd / Class1.ConOneRowDatCt;
      int num2;
      for (num2 = 0; num2 <= 2; ++num2)
      {
        string str = StrData[num1 + num2].Substring(0, Class1.ConUseChDatSta + 1) + Chinf.Substring(num2 * 64, 64);
        StrData[num1 + num2] = str;
      }
      string str1 = StrData[num1 + num2];
      string str2 = str1.Substring(0, Class1.ConUseChDatSta + 1) + Chinf.Substring(num2 * 64, 6) + str1.Substring(Class1.ConUseChDatSta + 1 + 6, str1.Length - (Class1.ConUseChDatSta + 1 + 6));
      StrData[num1 + num2] = str2;
      Class1.SaveFileDataPro(FileName, StrData);
    }

    private void RadioVFoSavePro(string Chinf, string FileName)
    {
      string[] StrData = Class1.ReadFileDataPro(FileName).Split('\r');
      int index = Class1.FielBegRow + Class1.ConFMVfoBegAdd / Class1.ConOneRowDatCt;
      int num = Class1.ConFMVfoBegAdd % Class1.ConOneRowDatCt << 1;
      string str1 = StrData[index];
      string str2 = str1.Substring(0, Class1.ConUseChDatSta + 1 + num) + Chinf + str1.Substring(Class1.ConUseChDatSta + 1 + num + 8, str1.Length - (Class1.ConUseChDatSta + 1 + num + 8));
      StrData[index] = str2;
      Class1.SaveFileDataPro(FileName, StrData);
    }

    private void SaveCurrenChData()
    {
      byte[] numArray = new byte[3];
      string strTest = "";
      for (int index = 0; index <= 23; ++index)
      {
        string text = this.TextBoxl_Arr[index].Text;
        string str;
        if (text == "")
        {
          ref byte local = ref numArray[index / 8];
          int num1 = (int) local;
          int num2 = index % 8;
          int num3 = 0;
          local = (byte) (num1 | num3);
          str = "FFFFFFFF";
        }
        else
        {
          numArray[index / 8] |= (byte) (1 << index % 8);
          str = Class2.ChgRxFreToDataPro(text);
        }
        strTest += str;
      }
      for (int index = 0; index <= 2; ++index)
      {
        string hexStr = Class1.DataToHexStr((long) numArray[index]);
        strTest += hexStr;
      }
      this.RadioChSavePro(Class1.Chga_z_ToA_Z(strTest), this.GiFileName);
      this.RadioVFoSavePro(Class1.Chga_z_ToA_Z(Class2.ChgRxFreToDataPro(this.textBox25.Text)), this.GiFileName);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
      this.SaveCurrenChData();
    }

    private void button2_Click(object sender, EventArgs e) => this.Close();

    private string DataUseFulFreChk9(string StrTemp)
    {
      try
      {
        if (StrTemp == "")
          return "BandOver";
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num = Convert.ToDouble(StrTemp) * 100000.0;
        if (num < 6400000.0 || num > 10800000.0)
          return "BandOver";
        StrTemp = Class2.AutoAddFreBytePro(StrTemp);
      }
      catch
      {
        StrTemp = "";
      }
      return StrTemp;
    }

    private void textBoxX_KeyPress(object sender, KeyPressEventArgs e, TextBox TextBoxX)
    {
      bool flag = Class1.KeyUseFul0_9ChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar != '\r')
        return;
      if (this.DataUseFulFreChk9(TextBoxX.Text) == "BandOver")
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 0] + "64M,108M]", Class1.RadioName);
        string str = this.GiRxFreTemp.Replace(",", ".");
        TextBoxX.Text = str;
        TextBoxX.SelectionLength = TextBoxX.Text.Length;
        TextBoxX.Focus();
      }
      else
        this.button1.Focus();
    }

    private void textBoxX_Leave(object sender, EventArgs e, TextBox TextBoxX)
    {
      string text = TextBoxX.Text;
      int[] numArray1 = new int[3];
      int[] numArray2 = new int[3];
      int[] numArray3 = new int[3];
      int[] numArray4 = new int[3];
      if (text == "")
        return;
      string str1 = this.DataUseFulFreChk9(text);
      if (str1 == "BandOver")
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 0] + "64M,108M]", Class1.RadioName);
        string str2 = this.GiRxFreTemp.Replace(",", ".");
        TextBoxX.Text = str2;
        TextBoxX.SelectionLength = TextBoxX.Text.Length;
        TextBoxX.Focus();
      }
      else
      {
        string str3 = str1.Replace(",", ".");
        TextBoxX.Text = str3;
        if (str3 == "")
        {
          if (str3 != this.GiRxFreTemp)
            this.GbChChangeen = true;
        }
        else if (str3 != this.GiRxFreTemp)
          this.GbChChangeen = true;
      }
    }

    private void textBoxX_Enter(object sender, EventArgs e, TextBox TextBoxX) => this.GiRxFreTemp = TextBoxX.Text;

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox1);

    private void textBox1_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox1);

    private void textBox1_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox1);

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox2);

    private void textBox3_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox3);

    private void textBox4_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox4);

    private void textBox5_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox5);

    private void textBox6_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox6);

    private void textBox7_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox7);

    private void textBox8_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox8);

    private void textBox9_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox9);

    private void textBox10_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox10);

    private void textBox11_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox11);

    private void textBox12_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox12);

    private void textBox13_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox13);

    private void textBox14_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox14);

    private void textBox15_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox15);

    private void textBox16_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox16);

    private void textBox17_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox17);

    private void textBox18_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox18);

    private void textBox19_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox19);

    private void textBox20_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox20);

    private void textBox21_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox21);

    private void textBox22_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox22);

    private void textBox23_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox23);

    private void textBox24_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox24);

    private void textBox2_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox2);

    private void textBox3_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox3);

    private void textBox4_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox4);

    private void textBox5_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox5);

    private void textBox6_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox6);

    private void textBox7_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox7);

    private void textBox8_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox8);

    private void textBox9_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox9);

    private void textBox10_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox10);

    private void textBox11_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox11);

    private void textBox12_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox12);

    private void textBox13_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox13);

    private void textBox14_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox14);

    private void textBox15_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox15);

    private void textBox16_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox16);

    private void textBox17_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox17);

    private void textBox18_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox18);

    private void textBox19_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox19);

    private void textBox20_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox20);

    private void textBox21_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox21);

    private void textBox22_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox22);

    private void textBox23_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox23);

    private void textBox24_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox24);

    private void textBox2_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox2);

    private void textBox3_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox3);

    private void textBox4_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox4);

    private void textBox5_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox5);

    private void textBox6_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox6);

    private void textBox7_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox7);

    private void textBox8_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox8);

    private void textBox9_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox9);

    private void textBox10_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox10);

    private void textBox11_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox11);

    private void textBox12_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox12);

    private void textBox13_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox13);

    private void textBox14_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox14);

    private void textBox15_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox15);

    private void textBox16_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox16);

    private void textBox17_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox17);

    private void textBox18_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox18);

    private void textBox19_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox19);

    private void textBox20_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox20);

    private void textBox21_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox21);

    private void textBox22_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox22);

    private void textBox23_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox23);

    private void textBox24_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox24);

    private void textBox25_Enter(object sender, EventArgs e) => this.textBoxX_Enter(sender, e, this.textBox25);

    private void textBox25_KeyPress(object sender, KeyPressEventArgs e) => this.textBoxX_KeyPress(sender, e, this.textBox25);

    private void textBox25_Leave(object sender, EventArgs e) => this.textBoxX_Leave(sender, e, this.textBox25);
  }
}
