// Decompiled with JetBrains decompiler
// Type: _8890DTest.RadioSet
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class RadioSet : Form
  {
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private Button button1;
    private Button button2;
    private Label label1;
    private Label label13;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label4;
    private Label label3;
    private Label label16;
    private ComboBox comboBox5;
    private ComboBox comboBox2;
    private ComboBox comboBox1;
    private ComboBox comboBox10;
    private ComboBox comboBox9;
    private ComboBox comboBox8;
    private ComboBox comboBox7;
    private ComboBox comboBox6;
    private TextBox textBox2;
    private CheckBox checkBox2;
    private CheckBox checkBox1;
    private ComboBox comboBox12;
    private ComboBox comboBox11;
    private ComboBox comboBox16;
    private ComboBox comboBox15;
    private ComboBox comboBox14;
    private ComboBox comboBox13;
    private Label label20;
    private Label label19;
    private Label label18;
    private Label label17;
    private CheckBox checkBox4;
    private CheckBox checkBox3;
    private Label label21;
    private ComboBox comboBox17;
    private ComboBox comboBox18;
    private Label label14;
    private ComboBox comboBox19;
    private GroupBox groupBox2;
    private TextBox textBox3;
    private Label label22;
    private Label label15;
    private TextBox textBox1;
    private Label label23;
    private ComboBox comboBox22;
    private Label label25;
    private ComboBox comboBox23;
    private ComboBox comboBox24;
    private Label label26;
    private ComboBox comboBox21;
    private Label label24;
    private ComboBox comboBox20;
    private ComboBox comboBox4;
    private ComboBox comboBox3;
    private Label label5;
    private Label label2;
    private ComboBox comboBox25;
    private Label label27;
    private GroupBox groupBox3;
    private GroupBox groupBox6;
    private ComboBox comboBox26;
    private ComboBox comboBox27;
    private ComboBox comboBox28;
    private Label label28;
    private Label label29;
    private Label label30;
    private ComboBox comboBox29;
    private Label label31;
    private ComboBox comboBox30;
    private Label label32;
    private ComboBox comboBox31;
    private Label label33;
    private ComboBox comboBox32;
    private Label label34;
    public string GiFileName1 = "8890D_TempFile.icf";
    public int GiLogData = 0;
    private Label[] Label_Arr;
    private ComboBox[] ComboBoxl_Arr;
    private CheckBox[] CheckBox_Arr;
    private Button[] Button_Arr;
    public static string[,] lableArrName = new string[2, 31]
    {
      {
        "静噪等级",
        "     尾音消除",
        "音量大小",
        " 扫描方式",
        "扫描恢复时间",
        "发射限时",
        "显示方式",
        "副频显示内容",
        "    导频频率",
        "背光灯模式",
        " 自动关机",
        "发射提示音",
        "    开机界面",
        "     开机界面 行1",
        "     开机界面 行2",
        "开机密码",
        "按键音",
        "   语言选择",
        "   左旋钮",
        "             图标",
        "发射通道选择",
        " 按键锁",
        "锁键类型",
        " 省电模式",
        "     双守",
        "背光灯亮度",
        "声控开关",
        "声控等级",
        "声控延时时间",
        "收音机监听",
        "语音开关"
      },
      {
        " Sql Lev",
        "End_Tone_elim",
        "   Volume",
        "Scan Type",
        "  Resume Time",
        "     TOT",
        "Dis Mode",
        "   Sub Screen",
        "Repeater tone",
        "  LED Mode",
        "Power Off",
        "Tx    Tone",
        "Intro Screen",
        "Intro Screen Line1",
        "Intro Screen Line2",
        "    Code",
        "   Beep",
        "Language Sel",
        "Left Dail",
        "              Logo",
        "Tx Ch Select",
        "Key Lock",
        "Key Mode",
        "Save Mode",
        "Dual Wait",
        "     Light",
        "  Vox Sw",
        " Vox Lev",
        "    Vox Delay",
        "Radio Moni",
        "SW Audio"
      }
    };
    public static string[,] ChekcBox_EngCh = new string[2, 4]
    {
      {
        "启动开机密码           ",
        "禁止设置整机功能                      ",
        " 无信令尾音消除                                 ",
        "禁止初始化操作   "
      },
      {
        "Use Boot-Strap Password",
        "Inhibit To  Setup Backgroud Operations",
        "Eliminate Squelch Tail When No Ctc/Dcs Signaling",
        "inhibit intialize"
      }
    };
    public static string[,] Button_EngCh = new string[2, 2]
    {
      {
        " 确定",
        " 取消"
      },
      {
        "Enter",
        "Cancel"
      }
    };
    public static string[,] Group_EngCh = new string[2, 2]
    {
      {
        " 基本功能设置",
        "开机界面"
      },
      {
        "Basic",
        "Intro Screen"
      }
    };
    private string[,] SqlLev_EngCh = new string[2, 10]
    {
      {
        "0",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9"
      },
      {
        "0",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9"
      }
    };
    private string[,] EndTail_EngCh = new string[2, 4]
    {
      {
        "频率",
        "120",
        "180",
        "240"
      },
      {
        "Fre",
        "120",
        "180",
        "240"
      }
    };
    private string[,] OnOFF_EngCh = new string[2, 2]
    {
      {
        "关闭",
        "开启"
      },
      {
        "OFF",
        "ON"
      }
    };
    private string[,] ScanKind_EngCh = new string[2, 3]
    {
      {
        "时间",
        "载波",
        "停止"
      },
      {
        "To",
        "Co",
        "Stop"
      }
    };
    private string[,] ScanResumTm_EngCh = new string[2, 4]
    {
      {
        "2S",
        "5S",
        "10S",
        "15S"
      },
      {
        "2S",
        "5S",
        "10S",
        "15S"
      }
    };
    private string[,] TotTime_EngCh = new string[2, 9]
    {
      {
        "关闭",
        "30S",
        "60S",
        "90S",
        "120S",
        "150S",
        "180S",
        "210S",
        "240S"
      },
      {
        "OFF",
        "30S",
        "60S",
        "90S",
        "120S",
        "150S",
        "180S",
        "210S",
        "240S"
      }
    };
    private string[,] Voice_EngCh = new string[2, 3]
    {
      {
        "关闭",
        "中文",
        "英文"
      },
      {
        "OFF",
        "CHINESE",
        "ENGLISH"
      }
    };
    private string[,] PttKind_EngCh = new string[2, 2]
    {
      {
        "关闭",
        "结束"
      },
      {
        "OFF",
        "END"
      }
    };
    private string[,] VOXLev_EngCh = new string[2, 7]
    {
      {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7"
      },
      {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7"
      }
    };
    private string[,] VOXDlyTm_EngCh = new string[2, 10]
    {
      {
        "0.5S",
        "1.0S",
        "1.5S",
        "2.0S",
        "2.5S",
        "3.0S",
        "3.5S",
        "4.0S",
        "4.5S",
        "5.0S"
      },
      {
        "0.5S",
        "1.0S",
        "1.5S",
        "2.0S",
        "2.5S",
        "3.0S",
        "3.5S",
        "4.0S",
        "4.5S",
        "5.0S"
      }
    };
    private string[,] PowSave_EngCh = new string[2, 4]
    {
      {
        "关闭",
        "1:1",
        "1:2",
        "1:4"
      },
      {
        "OFF",
        "1:1",
        "1:2",
        "1:4"
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
      this.groupBox1 = new GroupBox();
      this.comboBox32 = new ComboBox();
      this.label34 = new Label();
      this.comboBox31 = new ComboBox();
      this.label33 = new Label();
      this.comboBox30 = new ComboBox();
      this.label32 = new Label();
      this.comboBox29 = new ComboBox();
      this.label31 = new Label();
      this.groupBox6 = new GroupBox();
      this.comboBox26 = new ComboBox();
      this.comboBox27 = new ComboBox();
      this.comboBox28 = new ComboBox();
      this.label28 = new Label();
      this.label29 = new Label();
      this.label30 = new Label();
      this.comboBox25 = new ComboBox();
      this.label27 = new Label();
      this.comboBox24 = new ComboBox();
      this.label26 = new Label();
      this.comboBox21 = new ComboBox();
      this.label24 = new Label();
      this.comboBox20 = new ComboBox();
      this.label23 = new Label();
      this.groupBox2 = new GroupBox();
      this.comboBox23 = new ComboBox();
      this.textBox1 = new TextBox();
      this.textBox3 = new TextBox();
      this.label22 = new Label();
      this.label1 = new Label();
      this.label15 = new Label();
      this.comboBox19 = new ComboBox();
      this.comboBox12 = new ComboBox();
      this.comboBox10 = new ComboBox();
      this.comboBox9 = new ComboBox();
      this.comboBox8 = new ComboBox();
      this.comboBox7 = new ComboBox();
      this.comboBox6 = new ComboBox();
      this.comboBox4 = new ComboBox();
      this.comboBox3 = new ComboBox();
      this.label17 = new Label();
      this.comboBox1 = new ComboBox();
      this.label13 = new Label();
      this.label10 = new Label();
      this.label9 = new Label();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.comboBox13 = new ComboBox();
      this.label2 = new Label();
      this.button1 = new Button();
      this.button2 = new Button();
      this.comboBox22 = new ComboBox();
      this.label25 = new Label();
      this.comboBox18 = new ComboBox();
      this.label14 = new Label();
      this.comboBox17 = new ComboBox();
      this.label21 = new Label();
      this.checkBox4 = new CheckBox();
      this.checkBox3 = new CheckBox();
      this.comboBox16 = new ComboBox();
      this.comboBox15 = new ComboBox();
      this.comboBox14 = new ComboBox();
      this.label20 = new Label();
      this.label19 = new Label();
      this.label18 = new Label();
      this.textBox2 = new TextBox();
      this.checkBox2 = new CheckBox();
      this.checkBox1 = new CheckBox();
      this.comboBox11 = new ComboBox();
      this.comboBox5 = new ComboBox();
      this.comboBox2 = new ComboBox();
      this.label16 = new Label();
      this.label12 = new Label();
      this.label11 = new Label();
      this.label3 = new Label();
      this.groupBox3 = new GroupBox();
      this.groupBox1.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.comboBox32);
      this.groupBox1.Controls.Add((Control) this.label34);
      this.groupBox1.Controls.Add((Control) this.comboBox31);
      this.groupBox1.Controls.Add((Control) this.label33);
      this.groupBox1.Controls.Add((Control) this.comboBox30);
      this.groupBox1.Controls.Add((Control) this.label32);
      this.groupBox1.Controls.Add((Control) this.comboBox29);
      this.groupBox1.Controls.Add((Control) this.label31);
      this.groupBox1.Controls.Add((Control) this.groupBox6);
      this.groupBox1.Controls.Add((Control) this.comboBox25);
      this.groupBox1.Controls.Add((Control) this.label27);
      this.groupBox1.Controls.Add((Control) this.comboBox24);
      this.groupBox1.Controls.Add((Control) this.label26);
      this.groupBox1.Controls.Add((Control) this.comboBox21);
      this.groupBox1.Controls.Add((Control) this.label24);
      this.groupBox1.Controls.Add((Control) this.comboBox20);
      this.groupBox1.Controls.Add((Control) this.label23);
      this.groupBox1.Controls.Add((Control) this.groupBox2);
      this.groupBox1.Controls.Add((Control) this.comboBox12);
      this.groupBox1.Controls.Add((Control) this.comboBox10);
      this.groupBox1.Controls.Add((Control) this.comboBox9);
      this.groupBox1.Controls.Add((Control) this.comboBox8);
      this.groupBox1.Controls.Add((Control) this.comboBox7);
      this.groupBox1.Controls.Add((Control) this.comboBox6);
      this.groupBox1.Controls.Add((Control) this.comboBox4);
      this.groupBox1.Controls.Add((Control) this.comboBox3);
      this.groupBox1.Controls.Add((Control) this.label17);
      this.groupBox1.Controls.Add((Control) this.comboBox1);
      this.groupBox1.Controls.Add((Control) this.label13);
      this.groupBox1.Controls.Add((Control) this.label10);
      this.groupBox1.Controls.Add((Control) this.label9);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.comboBox13);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.button1);
      this.groupBox1.Controls.Add((Control) this.button2);
      this.groupBox1.Location = new Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(708, 349);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "整机设定";
      this.comboBox32.FormattingEnabled = true;
      this.comboBox32.Location = new Point(312, 130);
      this.comboBox32.Name = "comboBox32";
      this.comboBox32.Size = new Size(100, 20);
      this.comboBox32.TabIndex = 77;
      this.label34.AutoSize = true;
      this.label34.Location = new Point(251, 138);
      this.label34.Name = "label34";
      this.label34.Size = new Size(53, 12);
      this.label34.TabIndex = 76;
      this.label34.Text = "Voice Sw";
      this.comboBox31.FormattingEnabled = true;
      this.comboBox31.Location = new Point(109, 263);
      this.comboBox31.Name = "comboBox31";
      this.comboBox31.Size = new Size(100, 20);
      this.comboBox31.TabIndex = 75;
      this.label33.AutoSize = true;
      this.label33.Location = new Point(23, 271);
      this.label33.Name = "label33";
      this.label33.Size = new Size(71, 12);
      this.label33.TabIndex = 74;
      this.label33.Text = "Radio  Moni";
      this.comboBox30.FormattingEnabled = true;
      this.comboBox30.Location = new Point(109, 230);
      this.comboBox30.Name = "comboBox30";
      this.comboBox30.Size = new Size(100, 20);
      this.comboBox30.TabIndex = 73;
      this.label32.AutoSize = true;
      this.label32.Location = new Point(35, 234);
      this.label32.Name = "label32";
      this.label32.Size = new Size(59, 12);
      this.label32.TabIndex = 72;
      this.label32.Text = "Save Mode";
      this.comboBox29.FormattingEnabled = true;
      this.comboBox29.Location = new Point(312, 258);
      this.comboBox29.Name = "comboBox29";
      this.comboBox29.Size = new Size(100, 20);
      this.comboBox29.TabIndex = 71;
      this.label31.AutoSize = true;
      this.label31.Location = new Point(251, 266);
      this.label31.Name = "label31";
      this.label31.Size = new Size(53, 12);
      this.label31.TabIndex = 70;
      this.label31.Text = "Key Mode";
      this.groupBox6.Controls.Add((Control) this.comboBox26);
      this.groupBox6.Controls.Add((Control) this.comboBox27);
      this.groupBox6.Controls.Add((Control) this.comboBox28);
      this.groupBox6.Controls.Add((Control) this.label28);
      this.groupBox6.Controls.Add((Control) this.label29);
      this.groupBox6.Controls.Add((Control) this.label30);
      this.groupBox6.Location = new Point(436, 161);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(262, 100);
      this.groupBox6.TabIndex = 69;
      this.groupBox6.TabStop = false;
      this.comboBox26.FormattingEnabled = true;
      this.comboBox26.Location = new Point(109, 67);
      this.comboBox26.Name = "comboBox26";
      this.comboBox26.Size = new Size(70, 20);
      this.comboBox26.TabIndex = 13;
      this.comboBox27.FormattingEnabled = true;
      this.comboBox27.Location = new Point(109, 39);
      this.comboBox27.Name = "comboBox27";
      this.comboBox27.Size = new Size(70, 20);
      this.comboBox27.TabIndex = 12;
      this.comboBox28.FormattingEnabled = true;
      this.comboBox28.Location = new Point(109, 10);
      this.comboBox28.Name = "comboBox28";
      this.comboBox28.Size = new Size(70, 20);
      this.comboBox28.TabIndex = 11;
      this.label28.AutoSize = true;
      this.label28.Location = new Point(17, 75);
      this.label28.Name = "label28";
      this.label28.Size = new Size(83, 12);
      this.label28.TabIndex = 2;
      this.label28.Text = "    Vox Delay";
      this.label28.TextAlign = ContentAlignment.MiddleRight;
      this.label29.AutoSize = true;
      this.label29.Location = new Point(34, 46);
      this.label29.Name = "label29";
      this.label29.Size = new Size(53, 12);
      this.label29.TabIndex = 1;
      this.label29.Text = " Vox Lev";
      this.label29.TextAlign = ContentAlignment.MiddleRight;
      this.label30.AutoSize = true;
      this.label30.Location = new Point(34, 17);
      this.label30.Name = "label30";
      this.label30.Size = new Size(53, 12);
      this.label30.TabIndex = 0;
      this.label30.Text = "  Vox Sw";
      this.label30.TextAlign = ContentAlignment.MiddleRight;
      this.comboBox25.FormattingEnabled = true;
      this.comboBox25.Location = new Point(312, 226);
      this.comboBox25.Name = "comboBox25";
      this.comboBox25.Size = new Size(100, 20);
      this.comboBox25.TabIndex = 59;
      this.label27.AutoSize = true;
      this.label27.Location = new Point(251, 234);
      this.label27.Name = "label27";
      this.label27.Size = new Size(53, 12);
      this.label27.TabIndex = 58;
      this.label27.Text = "Key Lock";
      this.comboBox24.FormattingEnabled = true;
      this.comboBox24.Location = new Point(109, 131);
      this.comboBox24.Name = "comboBox24";
      this.comboBox24.Size = new Size(100, 20);
      this.comboBox24.TabIndex = 57;
      this.label26.AutoSize = true;
      this.label26.Location = new Point(17, 135);
      this.label26.Name = "label26";
      this.label26.Size = new Size(77, 12);
      this.label26.TabIndex = 56;
      this.label26.Text = "Tx Ch Select";
      this.comboBox21.FormattingEnabled = true;
      this.comboBox21.Location = new Point(109, 98);
      this.comboBox21.Name = "comboBox21";
      this.comboBox21.Size = new Size(100, 20);
      this.comboBox21.TabIndex = 53;
      this.label24.AutoSize = true;
      this.label24.Location = new Point(29, 102);
      this.label24.Name = "label24";
      this.label24.Size = new Size(65, 12);
      this.label24.TabIndex = 52;
      this.label24.Text = "Tx    Tone";
      this.comboBox20.FormattingEnabled = true;
      this.comboBox20.Location = new Point(312, 98);
      this.comboBox20.Name = "comboBox20";
      this.comboBox20.Size = new Size(100, 20);
      this.comboBox20.TabIndex = 51;
      this.label23.AutoSize = true;
      this.label23.Location = new Point(227, 106);
      this.label23.Name = "label23";
      this.label23.Size = new Size(77, 12);
      this.label23.TabIndex = 50;
      this.label23.Text = "Language Sel";
      this.groupBox2.Controls.Add((Control) this.comboBox23);
      this.groupBox2.Controls.Add((Control) this.textBox1);
      this.groupBox2.Controls.Add((Control) this.textBox3);
      this.groupBox2.Controls.Add((Control) this.label22);
      this.groupBox2.Controls.Add((Control) this.label1);
      this.groupBox2.Controls.Add((Control) this.label15);
      this.groupBox2.Controls.Add((Control) this.comboBox19);
      this.groupBox2.Location = new Point(436, 43);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(262, 112);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Intro Screen";
      this.comboBox23.FormattingEnabled = true;
      this.comboBox23.Location = new Point(144, 54);
      this.comboBox23.Name = "comboBox23";
      this.comboBox23.Size = new Size(109, 20);
      this.comboBox23.TabIndex = 55;
      this.comboBox23.Visible = false;
      this.textBox1.Location = new Point(144, 55);
      this.textBox1.MaxLength = 8;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(109, 21);
      this.textBox1.TabIndex = 54;
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress_1);
      this.textBox3.Location = new Point(144, 82);
      this.textBox3.MaxLength = 8;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(109, 21);
      this.textBox3.TabIndex = 53;
      this.textBox3.KeyPress += new KeyPressEventHandler(this.textBox3_KeyPress);
      this.label22.AutoSize = true;
      this.label22.Location = new Point(17, 86);
      this.label22.Name = "label22";
      this.label22.Size = new Size(119, 12);
      this.label22.TabIndex = 52;
      this.label22.Text = "Intro Screen Line 2";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(47, 25);
      this.label1.Name = "label1";
      this.label1.Size = new Size(77, 12);
      this.label1.TabIndex = 3;
      this.label1.Text = "Intro Screen";
      this.label15.AutoSize = true;
      this.label15.Location = new Point(17, 57);
      this.label15.Name = "label15";
      this.label15.Size = new Size(119, 12);
      this.label15.TabIndex = 51;
      this.label15.Text = "Intro Screen Line 1";
      this.comboBox19.FormattingEnabled = true;
      this.comboBox19.Location = new Point(144, 21);
      this.comboBox19.Name = "comboBox19";
      this.comboBox19.Size = new Size(109, 20);
      this.comboBox19.TabIndex = 50;
      this.comboBox19.SelectedIndexChanged += new EventHandler(this.comboBox19_SelectedIndexChanged);
      this.comboBox12.FormattingEnabled = true;
      this.comboBox12.Location = new Point(109, 297);
      this.comboBox12.Name = "comboBox12";
      this.comboBox12.Size = new Size(100, 20);
      this.comboBox12.TabIndex = 31;
      this.comboBox12.SelectedIndexChanged += new EventHandler(this.comboBox12_SelectedIndexChanged);
      this.comboBox12.TabIndexChanged += new EventHandler(this.comboBox12_TabIndexChanged);
      this.comboBox10.FormattingEnabled = true;
      this.comboBox10.Location = new Point(312, 162);
      this.comboBox10.Name = "comboBox10";
      this.comboBox10.Size = new Size(100, 20);
      this.comboBox10.TabIndex = 29;
      this.comboBox10.SelectedIndexChanged += new EventHandler(this.comboBox10_SelectedIndexChanged);
      this.comboBox9.FormattingEnabled = true;
      this.comboBox9.Location = new Point(312, 66);
      this.comboBox9.Name = "comboBox9";
      this.comboBox9.Size = new Size(100, 20);
      this.comboBox9.TabIndex = 28;
      this.comboBox8.FormattingEnabled = true;
      this.comboBox8.Location = new Point(312, 34);
      this.comboBox8.Name = "comboBox8";
      this.comboBox8.Size = new Size(100, 20);
      this.comboBox8.TabIndex = 27;
      this.comboBox7.FormattingEnabled = true;
      this.comboBox7.Location = new Point(312, 194);
      this.comboBox7.Name = "comboBox7";
      this.comboBox7.Size = new Size(100, 20);
      this.comboBox7.TabIndex = 26;
      this.comboBox7.SelectedIndexChanged += new EventHandler(this.comboBox7_SelectedIndexChanged);
      this.comboBox6.FormattingEnabled = true;
      this.comboBox6.Location = new Point(109, 164);
      this.comboBox6.Name = "comboBox6";
      this.comboBox6.Size = new Size(100, 20);
      this.comboBox6.TabIndex = 25;
      this.comboBox4.FormattingEnabled = true;
      this.comboBox4.Location = new Point(527, 282);
      this.comboBox4.Name = "comboBox4";
      this.comboBox4.Size = new Size(100, 20);
      this.comboBox4.TabIndex = 23;
      this.comboBox4.Visible = false;
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new Point(109, 67);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new Size(100, 20);
      this.comboBox3.TabIndex = 22;
      this.label17.AutoSize = true;
      this.label17.Location = new Point(35, 204);
      this.label17.Name = "label17";
      this.label17.Size = new Size(59, 12);
      this.label17.TabIndex = 36;
      this.label17.Text = "Dual Wait";
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(109, 34);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(100, 20);
      this.comboBox1.TabIndex = 20;
      this.label13.AutoSize = true;
      this.label13.Location = new Point(41, 39);
      this.label13.Name = "label13";
      this.label13.Size = new Size(53, 12);
      this.label13.TabIndex = 15;
      this.label13.Text = "Dis Mode";
      this.label10.AutoSize = true;
      this.label10.Location = new Point(245, 170);
      this.label10.Name = "label10";
      this.label10.Size = new Size(59, 12);
      this.label10.TabIndex = 12;
      this.label10.Text = "Scan Type";
      this.label9.AutoSize = true;
      this.label9.Location = new Point(239, 42);
      this.label9.Name = "label9";
      this.label9.Size = new Size(65, 12);
      this.label9.TabIndex = 11;
      this.label9.Text = "  LED Mode";
      this.label8.AutoSize = true;
      this.label8.Location = new Point(18, 305);
      this.label8.Name = "label8";
      this.label8.Size = new Size(83, 12);
      this.label8.TabIndex = 10;
      this.label8.Text = "End_Tone_elim";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(41, 168);
      this.label7.Name = "label7";
      this.label7.Size = new Size(53, 12);
      this.label7.TabIndex = 9;
      this.label7.Text = "     TOT";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(257, 202);
      this.label6.Name = "label6";
      this.label6.Size = new Size(47, 12);
      this.label6.TabIndex = 8;
      this.label6.Text = "   Beep";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(435, 287);
      this.label5.Name = "label5";
      this.label5.Size = new Size(77, 12);
      this.label5.TabIndex = 7;
      this.label5.Text = "    导频频率";
      this.label5.Visible = false;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(239, 74);
      this.label4.Name = "label4";
      this.label4.Size = new Size(65, 12);
      this.label4.TabIndex = 6;
      this.label4.Text = "     Light";
      this.comboBox13.FormattingEnabled = true;
      this.comboBox13.Location = new Point(109, 196);
      this.comboBox13.Name = "comboBox13";
      this.comboBox13.Size = new Size(100, 20);
      this.comboBox13.TabIndex = 40;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(41, 72);
      this.label2.Name = "label2";
      this.label2.Size = new Size(53, 12);
      this.label2.TabIndex = 4;
      this.label2.Text = " Sql Lev";
      this.button1.Location = new Point(228, 297);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 43);
      this.button1.TabIndex = 1;
      this.button1.Text = "确定";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(337, 297);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 43);
      this.button2.TabIndex = 2;
      this.button2.Text = "取消";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.comboBox22.FormattingEnabled = true;
      this.comboBox22.Location = new Point(294, 170);
      this.comboBox22.Name = "comboBox22";
      this.comboBox22.Size = new Size(100, 20);
      this.comboBox22.TabIndex = 55;
      this.comboBox22.Visible = false;
      this.label25.AutoSize = true;
      this.label25.Location = new Point(232, 173);
      this.label25.Name = "label25";
      this.label25.Size = new Size(59, 12);
      this.label25.TabIndex = 54;
      this.label25.Text = "   左旋钮";
      this.label25.Visible = false;
      this.comboBox18.FormattingEnabled = true;
      this.comboBox18.Location = new Point(40, 120);
      this.comboBox18.Name = "comboBox18";
      this.comboBox18.Size = new Size(100, 20);
      this.comboBox18.TabIndex = 49;
      this.label14.AutoSize = true;
      this.label14.Location = new Point(17, 123);
      this.label14.Name = "label14";
      this.label14.Size = new Size(17, 12);
      this.label14.TabIndex = 48;
      this.label14.Text = "AB";
      this.comboBox17.FormattingEnabled = true;
      this.comboBox17.Location = new Point(70, 164);
      this.comboBox17.Name = "comboBox17";
      this.comboBox17.Size = new Size(100, 20);
      this.comboBox17.TabIndex = 47;
      this.comboBox17.Visible = false;
      this.label21.AutoSize = true;
      this.label21.Location = new Point(11, 164);
      this.label21.Name = "label21";
      this.label21.Size = new Size(53, 12);
      this.label21.TabIndex = 46;
      this.label21.Text = "音量大小";
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new Point(13, 254);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new Size(252, 16);
      this.checkBox4.TabIndex = 45;
      this.checkBox4.Text = "禁止设置整机功能                      ";
      this.checkBox4.UseVisualStyleBackColor = true;
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new Point(13, 314);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new Size(126, 16);
      this.checkBox3.TabIndex = 44;
      this.checkBox3.Text = "禁止初始化操作   ";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.comboBox16.FormattingEnabled = true;
      this.comboBox16.Location = new Point(40, 91);
      this.comboBox16.Name = "comboBox16";
      this.comboBox16.Size = new Size(100, 20);
      this.comboBox16.TabIndex = 43;
      this.comboBox15.FormattingEnabled = true;
      this.comboBox15.Location = new Point(40, 62);
      this.comboBox15.Name = "comboBox15";
      this.comboBox15.Size = new Size(100, 20);
      this.comboBox15.TabIndex = 42;
      this.comboBox14.FormattingEnabled = true;
      this.comboBox14.Location = new Point(40, 33);
      this.comboBox14.Name = "comboBox14";
      this.comboBox14.Size = new Size(100, 20);
      this.comboBox14.TabIndex = 41;
      this.label20.AutoSize = true;
      this.label20.Location = new Point(11, 94);
      this.label20.Name = "label20";
      this.label20.Size = new Size(23, 12);
      this.label20.TabIndex = 39;
      this.label20.Text = "V/M";
      this.label19.AutoSize = true;
      this.label19.Location = new Point(17, 64);
      this.label19.Name = "label19";
      this.label19.Size = new Size(17, 12);
      this.label19.TabIndex = 38;
      this.label19.Text = "CT";
      this.label18.AutoSize = true;
      this.label18.Location = new Point(17, 34);
      this.label18.Name = "label18";
      this.label18.Size = new Size(17, 12);
      this.label18.TabIndex = 37;
      this.label18.Text = "Mz";
      this.textBox2.Location = new Point(294, 219);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(100, 21);
      this.textBox2.TabIndex = 35;
      this.textBox2.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new Point(239, 204);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(162, 16);
      this.checkBox2.TabIndex = 34;
      this.checkBox2.Text = "启动开机密码           ";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(13, 282);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(294, 16);
      this.checkBox1.TabIndex = 33;
      this.checkBox1.Text = "信令尾音消除                                 ";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.comboBox11.FormattingEnabled = true;
      this.comboBox11.Location = new Point(294, 135);
      this.comboBox11.Name = "comboBox11";
      this.comboBox11.Size = new Size(100, 20);
      this.comboBox11.TabIndex = 30;
      this.comboBox5.FormattingEnabled = true;
      this.comboBox5.Location = new Point(80, 225);
      this.comboBox5.Name = "comboBox5";
      this.comboBox5.Size = new Size(100, 20);
      this.comboBox5.TabIndex = 24;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new Point(294, 95);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(100, 20);
      this.comboBox2.TabIndex = 21;
      this.label16.AutoSize = true;
      this.label16.Location = new Point(235, 227);
      this.label16.Name = "label16";
      this.label16.Size = new Size(53, 12);
      this.label16.TabIndex = 18;
      this.label16.Text = "开机密码";
      this.label12.AutoSize = true;
      this.label12.Location = new Point(21, 228);
      this.label12.Name = "label12";
      this.label12.Size = new Size(53, 12);
      this.label12.TabIndex = 14;
      this.label12.Text = "自动关机";
      this.label11.AutoSize = true;
      this.label11.Location = new Point(214, 137);
      this.label11.Name = "label11";
      this.label11.Size = new Size(77, 12);
      this.label11.TabIndex = 13;
      this.label11.Text = "扫描恢复时间";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(211, 101);
      this.label3.Name = "label3";
      this.label3.Size = new Size(77, 12);
      this.label3.TabIndex = 5;
      this.label3.Text = "副频显示内容";
      this.groupBox3.Controls.Add((Control) this.comboBox14);
      this.groupBox3.Controls.Add((Control) this.label12);
      this.groupBox3.Controls.Add((Control) this.comboBox2);
      this.groupBox3.Controls.Add((Control) this.label20);
      this.groupBox3.Controls.Add((Control) this.comboBox22);
      this.groupBox3.Controls.Add((Control) this.comboBox15);
      this.groupBox3.Controls.Add((Control) this.label25);
      this.groupBox3.Controls.Add((Control) this.label19);
      this.groupBox3.Controls.Add((Control) this.label3);
      this.groupBox3.Controls.Add((Control) this.comboBox16);
      this.groupBox3.Controls.Add((Control) this.comboBox11);
      this.groupBox3.Controls.Add((Control) this.comboBox5);
      this.groupBox3.Controls.Add((Control) this.label11);
      this.groupBox3.Controls.Add((Control) this.label18);
      this.groupBox3.Controls.Add((Control) this.textBox2);
      this.groupBox3.Controls.Add((Control) this.label16);
      this.groupBox3.Controls.Add((Control) this.checkBox4);
      this.groupBox3.Controls.Add((Control) this.checkBox2);
      this.groupBox3.Controls.Add((Control) this.checkBox3);
      this.groupBox3.Controls.Add((Control) this.label14);
      this.groupBox3.Controls.Add((Control) this.checkBox1);
      this.groupBox3.Controls.Add((Control) this.comboBox18);
      this.groupBox3.Controls.Add((Control) this.comboBox17);
      this.groupBox3.Controls.Add((Control) this.label21);
      this.groupBox3.Location = new Point(816, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(270, 344);
      this.groupBox3.TabIndex = 56;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "groupBox3";
      this.groupBox3.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(714, 352);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = "RadioSet";
      this.Text = "Настройки рации";
      this.Load += new EventHandler(this.RadioSet_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
    }

    public RadioSet()
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

    private void load_CmbBoxNPro(ComboBox cmbHelp, string[] StrArr, int Number)
    {
      for (int index = 0; index <= Number; ++index)
        cmbHelp.Items.Add((object) StrArr[index]);
      this.ComBoxResPro(cmbHelp, 0);
    }

    private void load_CmbBoxNumPro(ComboBox cmbHelp)
    {
      for (int index = 0; index <= 15; ++index)
        cmbHelp.Items.Add((object) index);
      this.ComBoxResPro(cmbHelp, 10);
    }

    private void load_GroBox1_comboBoxPro()
    {
      this.TextBoxResPro(this.textBox2, 6, "");
      this.checkBox1.Enabled = false;
      this.textBox2.Visible = false;
      this.label16.Visible = false;
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox1, Class1.ShowName_EngCh, Class1.ShowName_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox2, Class1.SubMainDis_EngCh, Class1.SubMainDis_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox3, Class1.SqlLevel_EngCh, Class1.SqlLevel_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox4, Class1.CallKind_EngCh, Class1.CallKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox5, Class1.AutopowOffKind_EngCh, Class1.AutopowOffKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox6, Class1.TotKind_EngCh, Class1.TotKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox7, Class1.BoolKind_EngCh, Class1.BoolKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox8, Class1.LedKind_EngCh, Class1.LedKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox25, Class1.KeylockKind_EngCh, Class1.KeylockKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox9, Class1.LIGlLevel_EngCh, Class1.LIGlLevel_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox10, Class1.ScanKind_EngCh, Class1.ScanKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox11, Class1.ScanResumTm_EngCh, Class1.ScanResumTm_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox12, Class1.EndTail_EngCh, Class1.EndTail_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox13, Class1.DoubleWatch_EngCh, Class1.DoubleWatch_EngCh.GetLength(1) - 1);
      this.load_CmbBoxNPro(this.comboBox14, Class1.KeyDefine, 7);
      this.load_CmbBoxNPro(this.comboBox15, Class1.KeyDefine, 7);
      this.load_CmbBoxNPro(this.comboBox16, Class1.KeyDefine, 7);
      this.load_CmbBoxNPro(this.comboBox18, Class1.KeyDefine, 7);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox20, Class1.LanguageSel_EngCh, Class1.LanguageSel_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox21, Class1.PttKind_EngCh, Class1.PttKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox22, Class1.DailDefne_EngCh, Class1.DailDefne_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox24, Class1.PttTxKind_EngCh, Class1.PttTxKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox28, Class1.BoolKind_EngCh, Class1.BoolKind_EngCh.GetLength(1) - 1);
      公共控件操作.Load_CmbBoxNumberPro(this.comboBox27, 1, 1, 6);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox26, Class1.VOXDlyTm_EngCh, Class1.VOXDlyTm_EngCh.GetLength(1) - 1);
      if (!Class1.FactoryEn)
      {
        公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox23, Class1.LogKind_EngCh, Class1.LogKind_EngCh.GetLength(1) - 2);
        this.comboBox22.Visible = false;
        this.label25.Visible = false;
      }
      else
      {
        公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox23, Class1.LogKind_EngCh, Class1.LogKind_EngCh.GetLength(1) - 1);
        this.comboBox22.Visible = true;
        this.label25.Visible = true;
      }
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox19, Class1.RadioKind_EngCh, Class1.RadioKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox29, Class1.KeyMode_EngCh, Class1.KeyMode_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox30, Class1.SaveMode_EngCh, Class1.SaveMode_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox31, Class1.BoolKind_EngCh, Class1.BoolKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox32, Class1.BoolKind_EngCh, Class1.BoolKind_EngCh.GetLength(1) - 1);
      this.comboBox23.Visible = false;
      this.load_CmbBoxNumPro(this.comboBox17);
    }

    private void DisSetDataPro(string Datastr)
    {
      string StrTemp1_1 = Datastr.Substring(0, 24);
      string str1 = Datastr.Substring(24, 2);
      string str2 = Datastr.Substring(26, 2);
      string str3 = Datastr.Substring(28, 2);
      string str4 = Datastr.Substring(30, 2);
      string str5 = Datastr.Substring(32, 2);
      string str6 = Datastr.Substring(36, 2);
      Datastr.Substring(38, 2);
      string str7 = Datastr.Substring(40, 2);
      string str8 = Datastr.Substring(42, 2);
      string str9 = Datastr.Substring(44, 2);
      string StrTemp1_2 = Datastr.Substring(52, 12);
      try
      {
        string str10 = Class2.StringChNamePro(StrTemp1_1);
        if (str10 == "            ")
          str10 = "";
        this.textBox1.Text = str10;
        string str11 = Class2.StringChNamePro(StrTemp1_2);
        if (str11 == "      ")
          str11 = "";
        this.textBox2.Text = str11;
        int int32_1 = Convert.ToInt32(str1, 16);
        int num1 = int32_1 & 31;
        if (num1 > 20)
          num1 = 20;
        this.comboBox3.SelectedIndex = num1;
        this.comboBox2.SelectedIndex = (int32_1 & 224) >> 5;
        int int32_2 = Convert.ToInt32(str2, 16);
        this.comboBox24.SelectedIndex = int32_2 & 1;
        int num2 = (int32_2 & 24) >> 3;
        if (num2 > 2)
          num2 = 1;
        this.comboBox19.SelectedIndex = num2;
        this.comboBox4.SelectedIndex = (int32_2 & 96) >> 5;
        if ((int32_2 & 128) != 0)
          this.comboBox7.SelectedIndex = 1;
        else
          this.comboBox7.SelectedIndex = 0;
        int int32_3 = Convert.ToInt32(str3, 16);
        this.comboBox6.SelectedIndex = int32_3 & 31;
        this.comboBox5.SelectedIndex = (int32_3 & 224) >> 5;
        int int32_4 = Convert.ToInt32(str4, 16);
        this.checkBox4.Checked = (int32_4 & 1) != 0;
        this.checkBox3.Checked = (int32_4 & 2) != 0;
        this.comboBox12.SelectedIndex = (int32_4 & 12) >> 2;
        this.comboBox20.SelectedIndex = (int32_4 & 16) >> 4;
        this.comboBox22.SelectedIndex = (int32_4 & 32) >> 5;
        this.comboBox21.SelectedIndex = (int32_4 & 192) >> 6;
        int int32_5 = Convert.ToInt32(str5, 16);
        this.comboBox8.SelectedIndex = int32_5 & 3;
        this.comboBox10.SelectedIndex = (int32_5 & 12) >> 2;
        this.comboBox1.SelectedIndex = (int32_5 & 48) >> 4;
        this.comboBox11.SelectedIndex = (int32_5 & 192) >> 6;
        int int32_6 = Convert.ToInt32(str6, 16);
        int num3 = (int32_6 & 16) >> 4;
        if (!Class1.FactoryEn)
        {
          this.comboBox23.SelectedIndex = 0;
          this.GiLogData = num3;
        }
        else
          this.comboBox23.SelectedIndex = num3;
        if ((int32_6 & 64) != 0)
        {
          if (this.checkBox1.Enabled)
            this.checkBox1.Checked = true;
        }
        else
          this.checkBox1.Checked = false;
        if ((int32_6 & 128) != 0)
        {
          this.checkBox2.Checked = true;
          this.label16.Visible = true;
          this.textBox2.Visible = true;
        }
        else
        {
          this.checkBox2.Checked = false;
          this.label16.Visible = false;
          this.textBox2.Visible = false;
        }
        int int32_7 = Convert.ToInt32(str7, 16);
        this.comboBox9.SelectedIndex = int32_7 & 15;
        this.comboBox13.SelectedIndex = (int32_7 & 16) >> 4;
        this.comboBox25.SelectedIndex = (int32_7 & 32) >> 5;
        this.comboBox31.SelectedIndex = (int32_7 & 64) >> 6;
        this.comboBox32.SelectedIndex = (int32_7 & 128) >> 7;
        int int32_8 = Convert.ToInt32(str8, 16);
        this.comboBox27.SelectedIndex = int32_8 & 7;
        this.comboBox26.SelectedIndex = (int32_8 & 120) >> 3;
        this.comboBox28.SelectedIndex = (int32_8 & 128) >> 7;
        int int32_9 = Convert.ToInt32(str9, 16);
        this.comboBox29.SelectedIndex = int32_9 & 3;
        this.comboBox30.SelectedIndex = (int32_9 & 12) >> 2;
      }
      catch
      {
      }
    }

    private void DisOpenRadioNamePro(string Datastr)
    {
      string coding1 = Datastr.Substring(0, 32);
      string coding2 = Datastr.Substring(32, 32);
      this.textBox1.Text = Class1.GBKTOHanzi_ChangePro(coding1);
      this.textBox3.Text = Class1.GBKTOHanzi_ChangePro(coding2);
    }

    private void LoadCurSetDataDisPro()
    {
      string m = "";
      string str;
      try
      {
        string[] strArray = Class1.ReadFileDataPro(this.GiFileName1).Split('\r');
        int num1 = Class1.ConSetBegAddr / Class1.ConOneRowDatCt;
        str = Class2.AutoAdd_n_Pro(strArray[Class1.FielBegRow + num1]);
        int num2 = Class1.OpenRadioNameAddr / Class1.ConOneRowDatCt;
        m = strArray[Class1.FielBegRow + num2];
        m = Class2.AutoAdd_n_Pro(m);
      }
      catch
      {
        str = "\n1160205459572D5556202039303030251F000809050500000000000000303030303030";
      }
      if (str == "")
        str = "\n1160205459542D5556202039303030251F000809050500000000000000303030303030";
      this.DisSetDataPro(str.Substring(7, 64));
      this.DisOpenRadioNamePro(m.Substring(7, 64));
    }

    private void load_WinDisplayPro() => this.LoadCurSetDataDisPro();

    private void SetContrlAs_arrPro()
    {
      this.Label_Arr = new Label[35];
      this.Label_Arr[0] = this.label2;
      this.Label_Arr[1] = this.label8;
      this.Label_Arr[2] = this.label21;
      this.Label_Arr[3] = this.label10;
      this.Label_Arr[4] = this.label11;
      this.Label_Arr[5] = this.label7;
      this.Label_Arr[6] = this.label13;
      this.Label_Arr[7] = this.label3;
      this.Label_Arr[8] = this.label5;
      this.Label_Arr[9] = this.label9;
      this.Label_Arr[10] = this.label12;
      this.Label_Arr[11] = this.label24;
      this.Label_Arr[12] = this.label1;
      this.Label_Arr[13] = this.label15;
      this.Label_Arr[14] = this.label22;
      this.Label_Arr[15] = this.label16;
      this.Label_Arr[16] = this.label6;
      this.Label_Arr[17] = this.label23;
      this.Label_Arr[18] = this.label25;
      this.Label_Arr[19] = this.label26;
      this.Label_Arr[20] = this.label27;
      this.Label_Arr[21] = this.label31;
      this.Label_Arr[22] = this.label32;
      this.Label_Arr[23] = this.label17;
      this.Label_Arr[24] = this.label4;
      this.Label_Arr[25] = this.label30;
      this.Label_Arr[26] = this.label29;
      this.Label_Arr[27] = this.label28;
      this.Label_Arr[28] = this.label33;
      this.Label_Arr[29] = this.label34;
      this.ComboBoxl_Arr = new ComboBox[19];
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
      this.ComboBoxl_Arr[13] = this.comboBox23;
      this.ComboBoxl_Arr[14] = this.comboBox24;
      this.ComboBoxl_Arr[15] = this.comboBox9;
      this.ComboBoxl_Arr[16] = this.comboBox31;
      this.CheckBox_Arr = new CheckBox[6];
      this.CheckBox_Arr[0] = this.checkBox2;
      this.CheckBox_Arr[1] = this.checkBox4;
      this.CheckBox_Arr[2] = this.checkBox1;
      this.CheckBox_Arr[3] = this.checkBox3;
      this.Button_Arr = new Button[2];
      this.Button_Arr[0] = this.button1;
      this.Button_Arr[1] = this.button2;
    }

    private void load_GroBox1_ButtonPro()
    {
      for (int index = 0; index <= 1; ++index)
        this.Button_Arr[index].Text = RadioSet.Button_EngCh[Class1.English_En, index];
    }

    private void load_GroBox1_LabelPro()
    {
      for (int index = 0; index < RadioSet.lableArrName.GetLength(1) - 1; ++index)
      {
        this.Label_Arr[index].Text = RadioSet.lableArrName[Class1.English_En, index];
        if (index >= 19)
          this.Label_Arr[index].Text = RadioSet.lableArrName[Class1.English_En, index + 1];
      }
    }

    private void load_GroBo1_CheckBoxPro()
    {
      for (int index = 0; index <= 3; ++index)
        this.CheckBox_Arr[index].Text = RadioSet.ChekcBox_EngCh[Class1.English_En, index];
    }

    private void RadioSet_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.SetContrlAs_arrPro();
      this.load_GroBox1_ButtonPro();
      this.load_GroBox1_LabelPro();
      this.load_GroBox1_comboBoxPro();
      this.load_GroBo1_CheckBoxPro();
      this.label25.Visible = false;
      this.comboBox22.Visible = false;
      this.groupBox1.Text = RadioSet.Group_EngCh[Class1.English_En, 0];
      this.groupBox2.Text = RadioSet.Group_EngCh[Class1.English_En, 1];
      this.load_WinDisplayPro();
      this.label5.Visible = false;
      this.comboBox4.Visible = false;
      if (Class1.FactoryEn)
        return;
      this.label23.Enabled = false;
      this.comboBox20.Enabled = false;
    }

    private string GetSetDataStringPro()
    {
      string[] strArray1 = Class1.ReadFileDataPro(this.GiFileName1).Split('\r');
      int num1 = Class1.ConSetBegAddr / Class1.ConOneRowDatCt;
      string str = Class2.AutoAdd_n_Pro(strArray1[Class1.FielBegRow + num1]).Substring(7, 64);
      string[] strArray2 = new string[14];
      strArray2[0] = Class2.ChgStringToAcsPro(this.textBox1.Text, 12);
      int Data1 = this.comboBox3.SelectedIndex | this.comboBox2.SelectedIndex << 5;
      strArray2[1] = Class1.DataToHexStr((long) Data1);
      int Data2 = this.comboBox24.SelectedIndex | this.comboBox19.SelectedIndex << 3 | this.comboBox4.SelectedIndex << 5 | this.comboBox7.SelectedIndex << 7;
      strArray2[2] = Class1.DataToHexStr((long) Data2);
      int Data3 = this.comboBox6.SelectedIndex | this.comboBox5.SelectedIndex << 5;
      strArray2[3] = Class1.DataToHexStr((long) Data3);
      int num2 = 0;
      if (this.checkBox4.Checked)
        num2 = 1;
      int num3 = num2;
      int num4 = 0;
      if (this.checkBox3.Checked)
        num4 = 1;
      int num5 = num4 << 1;
      int Data4 = num3 | num5 | this.comboBox12.SelectedIndex << 2 | this.comboBox20.SelectedIndex << 4;
      strArray2[4] = Class1.DataToHexStr((long) Data4);
      int num6 = this.comboBox20.SelectedIndex << 4;
      int Data5 = Data4 | num6 | this.comboBox22.SelectedIndex << 5 | this.comboBox21.SelectedIndex << 6;
      strArray2[4] = Class1.DataToHexStr((long) Data5);
      int Data6 = this.comboBox8.SelectedIndex | this.comboBox10.SelectedIndex << 2 | this.comboBox1.SelectedIndex << 4 | this.comboBox11.SelectedIndex << 6;
      strArray2[5] = Class1.DataToHexStr((long) Data6);
      strArray2[6] = "01";
      int num7 = Convert.ToInt32(str.Substring(36, 2), 16) & 47;
      int num8 = Class1.FactoryEn ? this.comboBox23.SelectedIndex : (this.comboBox19.SelectedIndex != 2 ? this.GiLogData : this.comboBox23.SelectedIndex);
      int num9 = 0;
      if (this.checkBox1.Checked)
        num9 = 1;
      int num10 = 0;
      if (this.checkBox2.Checked)
        num10 = 1;
      int Data7 = num7 | num8 << 4 | num9 << 6 | num10 << 7;
      strArray2[7] = Class1.DataToHexStr((long) Data7);
      strArray2[8] = str.Substring(38, 2);
      int Data8 = this.comboBox9.SelectedIndex | this.comboBox13.SelectedIndex << 4 | this.comboBox25.SelectedIndex << 5 | this.comboBox31.SelectedIndex << 6 | this.comboBox32.SelectedIndex << 7;
      strArray2[9] = Class1.DataToHexStr((long) Data8);
      int Data9 = this.comboBox27.SelectedIndex | this.comboBox26.SelectedIndex << 3 | this.comboBox28.SelectedIndex << 7;
      strArray2[10] = Class1.DataToHexStr((long) Data9);
      int Data10 = this.comboBox29.SelectedIndex | this.comboBox30.SelectedIndex << 2;
      strArray2[11] = Class1.DataToHexStr((long) Data10);
      strArray2[12] = str.Substring(46, 6);
      strArray2[13] = Class2.ChgStringToAcsPro(this.textBox2.Text, 6);
      for (int index = 1; index <= 13; ++index)
        strArray2[0] = strArray2[0] + strArray2[index];
      return Class1.Chga_z_ToA_Z(strArray2[0]);
    }

    private void SavSetModDataPro(string CurrStr)
    {
      string[] StrData = Class1.ReadFileDataPro(this.GiFileName1).Split('\r');
      int num = Class1.ConSetBegAddr / Class1.ConOneRowDatCt;
      string str = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num]);
      StrData[Class1.FielBegRow + num] = str.Substring(0, 7) + CurrStr;
      Class1.SaveFileDataPro(this.GiFileName1, StrData);
    }

    private string GetRadioNameDataStringPro()
    {
      string[] strArray = new string[14];
      strArray[0] = Class1.hanziTOGbk_ChangePro(this.textBox1.Text, 8);
      strArray[1] = Class1.hanziTOGbk_ChangePro(this.textBox3.Text, 8);
      strArray[0] = strArray[0] + strArray[1];
      return strArray[0];
    }

    private void SavOpenNameDataPro(string CurrStr)
    {
      string[] StrData = Class1.ReadFileDataPro(this.GiFileName1).Split('\r');
      int num = Class1.OpenRadioNameAddr / Class1.ConOneRowDatCt;
      string str = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num]);
      StrData[Class1.FielBegRow + num] = str.Substring(0, 7) + CurrStr;
      Class1.SaveFileDataPro(this.GiFileName1, StrData);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.SavSetModDataPro(this.GetSetDataStringPro());
      this.SavOpenNameDataPro(this.GetRadioNameDataStringPro());
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e) => this.Close();

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox2.Checked)
      {
        this.textBox2.Visible = true;
        this.label16.Visible = true;
      }
      else
      {
        this.textBox2.Visible = false;
        this.label16.Visible = false;
      }
    }

    private void comboBox12_TabIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (0 == this.comboBox12.SelectedIndex)
        this.checkBox1.Enabled = false;
      else
        this.checkBox1.Enabled = true;
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.textBox1.MaxLength = Class1.InputLengthSetPro(this.textBox1.Text, 8);
      if (e.KeyChar != '\r')
        ;
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool flag = Class1.KeyUseFul0_9ChkPro(e.KeyChar);
      e.KeyChar = Class1.ChgChar_a_z_ToA_Z(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar != '\r')
        ;
    }

    private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (this.comboBox19.SelectedIndex)
      {
        case 0:
        case 1:
          this.ComboBoxl_Arr[13].Visible = false;
          this.Label_Arr[13].Visible = false;
          this.label22.Visible = false;
          this.textBox1.Visible = false;
          this.textBox3.Visible = false;
          break;
        case 2:
          this.Label_Arr[13].Text = RadioSet.lableArrName[Class1.English_En, 13];
          this.Label_Arr[13].Visible = true;
          this.label22.Visible = true;
          this.ComboBoxl_Arr[13].Visible = false;
          this.textBox1.Visible = true;
          this.textBox3.Visible = true;
          this.textBox1.Enabled = true;
          this.textBox3.Enabled = true;
          this.textBox1.Text = "";
          this.textBox3.Text = "";
          break;
        case 3:
          this.ComboBoxl_Arr[13].Visible = true;
          this.Label_Arr[13].Text = RadioSet.lableArrName[Class1.English_En, 19];
          if (!Class1.FactoryEn)
            this.ComboBoxl_Arr[13].SelectedIndex = 0;
          this.Label_Arr[13].Visible = true;
          this.label22.Visible = false;
          this.textBox1.Visible = false;
          this.textBox3.Visible = false;
          this.textBox1.Enabled = false;
          this.textBox3.Enabled = false;
          break;
      }
      if (this.comboBox19.SelectedIndex == 1)
        ;
    }

    private void textBox3_KeyPress(object sender, KeyPressEventArgs e) => this.textBox3.MaxLength = Class1.InputLengthSetPro(this.textBox3.Text, 8);

    private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e) => this.textBox1.MaxLength = Class1.InputLengthSetPro(this.textBox1.Text, 8);

    private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox10.SelectedIndex == 0)
      {
        this.label11.Enabled = true;
        this.comboBox11.Enabled = true;
      }
      else
      {
        this.label11.Enabled = false;
        this.comboBox11.Enabled = false;
      }
    }
  }
}
