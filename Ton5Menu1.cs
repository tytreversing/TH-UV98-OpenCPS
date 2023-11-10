// Decompiled with JetBrains decompiler
// Type: _8890DTest.Ton5Menu1
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class Ton5Menu1 : Form
  {
    private IContainer components = (IContainer) null;
    private GroupBox groupBox7;
    private Button button2;
    private Button button1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private GroupBox groupBox1;
    private TextBox textBox1;
    private ComboBox comboBox1;
    private DataGridView dataGridView1;
    private TabPage tabPage2;
    private GroupBox groupBox2;
    private ComboBox comboBox3;
    private TextBox textBox2;
    private ComboBox comboBox2;
    private DataGridView dataGridView2;
    private GroupBox groupBox6;
    private TextBox textBox12;
    private TextBox textBox13;
    private ComboBox comboBox7;
    private Label label12;
    private TextBox textBox14;
    private Label label22;
    private Label label23;
    private Label label24;
    private Label label4;
    private TextBox textBox9;
    private TextBox textBox10;
    private ComboBox comboBox5;
    private TextBox textBox11;
    private Label label16;
    private Label label8;
    private Label label17;
    private Label label18;
    private Label label7;
    private TextBox textBox21;
    private Label label31;
    private ComboBox CmbSepa;
    private TextBox textBox18;
    private TextBox textBox6;
    private ComboBox CmbGroupCode;
    private TextBox textBox8;
    private TextBox textBox19;
    private TextBox textBox7;
    private TextBox textBox20;
    private Label label28;
    private Label label29;
    private Label label30;
    private TextBox textBox15;
    private TextBox textBox16;
    private TextBox textBox17;
    private Label label25;
    private Label label26;
    private Label label27;
    private Label label19;
    private Label label20;
    private Label label21;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private NumericUpDown numericUpDown1;
    private Label label32;
    private ComboBox comboBox6;
    private ComboBox comboBox4;
    private Label label10;
    private CheckBox checkBox1;
    private ComboBox CmbFirTm;
    private ComboBox CmbSendTm;
    private ComboBox CmbAckK;
    private TextBox textBox4;
    private Label label6;
    private Label label13;
    private Label label11;
    private Label label3;
    private ComboBox CmbResTm;
    private Label label2;
    private Label label1;
    private GroupBox groupBox5;
    private ComboBox CmbPttK;
    private Label label9;
    private Label label15;
    private Label label14;
    private TextBox textBox3;
    private TextBox textBox5;
    private NumericUpDown numericUpDown2;
    private float[] ZVEI1 = new float[16]
    {
      2400f,
      1060f,
      1160f,
      1270f,
      1400f,
      1530f,
      1670f,
      1830f,
      2000f,
      2200f,
      2800f,
      810f,
      970f,
      885f,
      2600f,
      680f
    };
    private float[] PZVEI = new float[16]
    {
      2400f,
      1060f,
      1160f,
      1270f,
      1400f,
      1530f,
      1670f,
      1830f,
      2000f,
      2200f,
      970f,
      810f,
      2800f,
      885f,
      2600f,
      680f
    };
    private float[] ZVEI2 = new float[16]
    {
      2400f,
      1060f,
      1160f,
      1270f,
      1400f,
      1530f,
      1670f,
      1830f,
      2000f,
      2200f,
      885f,
      810f,
      740f,
      680f,
      970f,
      2600f
    };
    private float[] ZVEI3 = new float[16]
    {
      2200f,
      970f,
      1060f,
      1160f,
      1270f,
      1400f,
      1530f,
      1670f,
      1830f,
      2000f,
      885f,
      10f,
      10f,
      10f,
      2400f,
      10f
    };
    private float[] DZVEI = new float[16]
    {
      2200f,
      970f,
      1060f,
      1160f,
      1270f,
      1400f,
      1530f,
      1670f,
      1830f,
      2000f,
      825f,
      740f,
      2600f,
      885f,
      2400f,
      680f
    };
    private float[] PDZVEI = new float[16]
    {
      2200f,
      970f,
      1060f,
      1160f,
      1270f,
      1400f,
      1530f,
      1670f,
      1830f,
      2000f,
      825f,
      886f,
      2600f,
      856f,
      2400f,
      10f
    };
    private float[] CCIR12 = new float[16]
    {
      1981f,
      1124f,
      1197f,
      1275f,
      1358f,
      1446f,
      1540f,
      1640f,
      1747f,
      1860f,
      2400f,
      930f,
      2247f,
      991f,
      2110f,
      1055f
    };
    private float[] PCCIR = new float[16]
    {
      1981f,
      1124f,
      1197f,
      1275f,
      1358f,
      1446f,
      1540f,
      1640f,
      1747f,
      1860f,
      1050f,
      930f,
      2400f,
      991f,
      2110f,
      10f
    };
    private float[] EEA = new float[16]
    {
      1981f,
      1124f,
      1197f,
      1275f,
      1358f,
      1446f,
      1540f,
      1640f,
      1747f,
      1860f,
      1055f,
      930f,
      2400f,
      991f,
      2110f,
      2247f
    };
    private float[] EuroSg = new float[16]
    {
      979.8f,
      903.1f,
      832.5f,
      767.4f,
      707.4f,
      652f,
      601f,
      554f,
      510.7f,
      470.8f,
      10f,
      10f,
      10f,
      10f,
      1062.9f,
      10f
    };
    private float[] Natel = new float[16]
    {
      1633f,
      631f,
      697f,
      770f,
      852f,
      941f,
      1040f,
      1209f,
      1336f,
      1477f,
      1995f,
      571f,
      2205f,
      2437f,
      1805f,
      2694f
    };
    private float[] Modat = new float[16]
    {
      637.5f,
      787.5f,
      937.5f,
      1087.5f,
      1237.5f,
      1387.5f,
      1537.5f,
      1687.5f,
      1837.5f,
      1987.5f,
      10f,
      10f,
      10f,
      10f,
      487.5f,
      10f
    };
    private float[] CCITT = new float[16]
    {
      400f,
      697f,
      770f,
      852f,
      941f,
      1209f,
      1335f,
      1447f,
      1633f,
      1800f,
      1900f,
      2000f,
      2100f,
      2200f,
      2300f,
      1f
    };
    private float[] EIA = new float[16]
    {
      600f,
      741f,
      882f,
      1023f,
      1164f,
      1305f,
      1446f,
      1587f,
      1728f,
      1869f,
      2151f,
      2433f,
      2010f,
      2292f,
      459f,
      1091f
    };
    public string GiFileName2 = "8890D_TempFile.icf";
    public static string[,] tabContro_EngCh = new string[2, 2]
    {
      {
        "5 音编码",
        "5 音解码"
      },
      {
        "5Tone Encode",
        "5Tone Decode"
      }
    };
    public static string[,] DataGridName = new string[2, 5]
    {
      {
        "组别",
        "类型",
        "呼叫 ID",
        "数传信息",
        "信道名称"
      },
      {
        "No. ",
        "Type",
        "Call ID",
        "Message",
        "Ch Name"
      }
    };
    public static string[,] DataGridName1 = new string[2, 5]
    {
      {
        "组别",
        "功能选项",
        "解码响应",
        "编码",
        "信道名称"
      },
      {
        "No. ",
        "Function",
        "Decode Reponse",
        "Code",
        "Ch Name"
      }
    };
    public static string[,] lableArrName = new string[2, 13]
    {
      {
        "本机ID码",
        "      解码响应",
        "   分隔符",
        "   组呼码",
        "  重复音",
        "首位数码时间(MS)",
        "   自动复位时间(S)",
        " 选定信道",
        "PTT ID 类型",
        " PTT ID 开始",
        "PTT ID 结束",
        "当前标准",
        "发码音长(MS)"
      },
      {
        "  Own ID",
        "Decode Reponse",
        "Delimiter",
        "Group Code",
        "Repeater",
        " First Digit(MS)",
        "Auto Reset Time(S)",
        "Select Ch",
        "PTT ID Type",
        "PTT ID Begin",
        " PTT ID End",
        "Standard",
        "    Time(MS)"
      }
    };
    public static string[,] ChekcBox_EngCh = new string[2, 1]
    {
      {
        "侧音     "
      },
      {
        "Side Tone"
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
    public static string[,] GroupBox_EngCh = new string[2, 4]
    {
      {
        "5 音编码",
        "5 音解码",
        "5 设置",
        "标准频率表(HZ)"
      },
      {
        "5Tone Encode",
        "5Tone Decode",
        "5 Setting",
        "Standard Fre(HZ)"
      }
    };
    public static string[,] Tone5DecodeK_EngCh = new string[2, 4]
    {
      {
        "选呼",
        "遥晕",
        "遥毙",
        "唤醒"
      },
      {
        "Select",
        "Stun",
        "Kill",
        "Wake"
      }
    };
    private string[,] MessBoxName = new string[2, 2]
    {
      {
        "当前频率超出范围  [300HZ,3116HZ]！",
        "行数据非法！"
      },
      {
        "Frequency Out Off Rang  [300HZ,3116HZ]!",
        "Line Data Error!"
      }
    };
    private Label[] Label_Arr;
    private ComboBox[] ComboBoxl_Arr;
    private TextBox[] TextBoxl_Arr;
    private CheckBox[] CheckBox_Arr;
    private GroupBox[] GroupBox_Arr;
    private Button[] Button_Arr;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox7 = new GroupBox();
      this.button2 = new Button();
      this.button1 = new Button();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.groupBox1 = new GroupBox();
      this.textBox1 = new TextBox();
      this.comboBox1 = new ComboBox();
      this.dataGridView1 = new DataGridView();
      this.tabPage2 = new TabPage();
      this.groupBox2 = new GroupBox();
      this.comboBox3 = new ComboBox();
      this.textBox2 = new TextBox();
      this.comboBox2 = new ComboBox();
      this.dataGridView2 = new DataGridView();
      this.groupBox6 = new GroupBox();
      this.numericUpDown2 = new NumericUpDown();
      this.textBox12 = new TextBox();
      this.textBox13 = new TextBox();
      this.comboBox6 = new ComboBox();
      this.comboBox7 = new ComboBox();
      this.label10 = new Label();
      this.label12 = new Label();
      this.textBox14 = new TextBox();
      this.label22 = new Label();
      this.label23 = new Label();
      this.label24 = new Label();
      this.label4 = new Label();
      this.textBox9 = new TextBox();
      this.textBox10 = new TextBox();
      this.comboBox5 = new ComboBox();
      this.textBox11 = new TextBox();
      this.label16 = new Label();
      this.label8 = new Label();
      this.label17 = new Label();
      this.label18 = new Label();
      this.label7 = new Label();
      this.textBox21 = new TextBox();
      this.label31 = new Label();
      this.CmbSepa = new ComboBox();
      this.textBox18 = new TextBox();
      this.textBox6 = new TextBox();
      this.CmbGroupCode = new ComboBox();
      this.textBox8 = new TextBox();
      this.textBox19 = new TextBox();
      this.textBox7 = new TextBox();
      this.textBox20 = new TextBox();
      this.label28 = new Label();
      this.label29 = new Label();
      this.label30 = new Label();
      this.textBox15 = new TextBox();
      this.textBox16 = new TextBox();
      this.textBox17 = new TextBox();
      this.label25 = new Label();
      this.label26 = new Label();
      this.label27 = new Label();
      this.label19 = new Label();
      this.label20 = new Label();
      this.label21 = new Label();
      this.groupBox3 = new GroupBox();
      this.groupBox4 = new GroupBox();
      this.numericUpDown1 = new NumericUpDown();
      this.label32 = new Label();
      this.comboBox4 = new ComboBox();
      this.checkBox1 = new CheckBox();
      this.CmbFirTm = new ComboBox();
      this.CmbSendTm = new ComboBox();
      this.CmbAckK = new ComboBox();
      this.textBox4 = new TextBox();
      this.label6 = new Label();
      this.label13 = new Label();
      this.label11 = new Label();
      this.label3 = new Label();
      this.CmbResTm = new ComboBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.groupBox5 = new GroupBox();
      this.CmbPttK = new ComboBox();
      this.label9 = new Label();
      this.label15 = new Label();
      this.label14 = new Label();
      this.textBox3 = new TextBox();
      this.textBox5 = new TextBox();
      this.groupBox7.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.tabPage2.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((ISupportInitialize) this.dataGridView2).BeginInit();
      this.groupBox6.SuspendLayout();
      this.numericUpDown2.BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.numericUpDown1.BeginInit();
      this.groupBox5.SuspendLayout();
      this.SuspendLayout();
      this.groupBox7.Controls.Add((Control) this.button2);
      this.groupBox7.Controls.Add((Control) this.button1);
      this.groupBox7.Controls.Add((Control) this.tabControl1);
      this.groupBox7.Location = new Point(2, 12);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(791, 526);
      this.groupBox7.TabIndex = 33;
      this.groupBox7.TabStop = false;
      this.button2.Location = new Point(437, 464);
      this.button2.Name = "button2";
      this.button2.Size = new Size(94, 47);
      this.button2.TabIndex = 12;
      this.button2.Text = "取 消";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button4_Click);
      this.button1.Location = new Point(298, 464);
      this.button1.Name = "button1";
      this.button1.Size = new Size(96, 47);
      this.button1.TabIndex = 11;
      this.button1.Text = "确 定";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button3_Click);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new Point(0, 11);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(862, 447);
      this.tabControl1.TabIndex = 1;
      this.tabPage1.BackColor = Color.Transparent;
      this.tabPage1.Controls.Add((Control) this.groupBox1);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(854, 421);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "5Tone编码";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.groupBox1.BackColor = SystemColors.Control;
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Controls.Add((Control) this.comboBox1);
      this.groupBox1.Controls.Add((Control) this.dataGridView1);
      this.groupBox1.Location = new Point(6, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(351, 412);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "5Tone编码";
      this.textBox1.Location = new Point(166, 261);
      this.textBox1.MaxLength = 24;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 21);
      this.textBox1.TabIndex = 2;
      this.textBox1.TextAlign = HorizontalAlignment.Center;
      this.textBox1.Leave += new EventHandler(this.textBox1_Leave);
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(145, 235);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(121, 20);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.Leave += new EventHandler(this.comboBox1_Leave);
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new Point(3, 17);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new Size(136, 263);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      this.tabPage2.BackColor = Color.Transparent;
      this.tabPage2.Controls.Add((Control) this.groupBox2);
      this.tabPage2.Controls.Add((Control) this.groupBox6);
      this.tabPage2.Controls.Add((Control) this.groupBox3);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(854, 421);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "5Tone解码";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.groupBox2.BackColor = SystemColors.Control;
      this.groupBox2.Controls.Add((Control) this.comboBox3);
      this.groupBox2.Controls.Add((Control) this.textBox2);
      this.groupBox2.Controls.Add((Control) this.comboBox2);
      this.groupBox2.Controls.Add((Control) this.dataGridView2);
      this.groupBox2.Location = new Point(8, 6);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(353, 232);
      this.groupBox2.TabIndex = 32;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "5Tone解码";
      this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new Point(178, 80);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new Size(121, 20);
      this.comboBox3.TabIndex = 3;
      this.comboBox3.Leave += new EventHandler(this.comboBox3_Leave);
      this.textBox2.Location = new Point(222, 101);
      this.textBox2.MaxLength = 24;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(100, 21);
      this.textBox2.TabIndex = 2;
      this.textBox2.TextAlign = HorizontalAlignment.Center;
      this.textBox2.Leave += new EventHandler(this.textBox2_Leave);
      this.textBox2.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
      this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new Point(178, 54);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(121, 20);
      this.comboBox2.TabIndex = 1;
      this.comboBox2.Leave += new EventHandler(this.comboBox2_Leave);
      this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new Point(3, 17);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowHeadersVisible = false;
      this.dataGridView2.RowTemplate.Height = 23;
      this.dataGridView2.Size = new Size(136, 167);
      this.dataGridView2.TabIndex = 0;
      this.dataGridView2.CellClick += new DataGridViewCellEventHandler(this.dataGridView2_CellClick);
      this.groupBox6.BackColor = SystemColors.Control;
      this.groupBox6.Controls.Add((Control) this.numericUpDown2);
      this.groupBox6.Controls.Add((Control) this.textBox12);
      this.groupBox6.Controls.Add((Control) this.textBox13);
      this.groupBox6.Controls.Add((Control) this.comboBox6);
      this.groupBox6.Controls.Add((Control) this.comboBox7);
      this.groupBox6.Controls.Add((Control) this.label10);
      this.groupBox6.Controls.Add((Control) this.label12);
      this.groupBox6.Controls.Add((Control) this.textBox14);
      this.groupBox6.Controls.Add((Control) this.label22);
      this.groupBox6.Controls.Add((Control) this.label23);
      this.groupBox6.Controls.Add((Control) this.label24);
      this.groupBox6.Controls.Add((Control) this.label4);
      this.groupBox6.Controls.Add((Control) this.textBox9);
      this.groupBox6.Controls.Add((Control) this.textBox10);
      this.groupBox6.Controls.Add((Control) this.comboBox5);
      this.groupBox6.Controls.Add((Control) this.textBox11);
      this.groupBox6.Controls.Add((Control) this.label16);
      this.groupBox6.Controls.Add((Control) this.label8);
      this.groupBox6.Controls.Add((Control) this.label17);
      this.groupBox6.Controls.Add((Control) this.label18);
      this.groupBox6.Controls.Add((Control) this.label7);
      this.groupBox6.Controls.Add((Control) this.textBox21);
      this.groupBox6.Controls.Add((Control) this.label31);
      this.groupBox6.Controls.Add((Control) this.CmbSepa);
      this.groupBox6.Controls.Add((Control) this.textBox18);
      this.groupBox6.Controls.Add((Control) this.textBox6);
      this.groupBox6.Controls.Add((Control) this.CmbGroupCode);
      this.groupBox6.Controls.Add((Control) this.textBox8);
      this.groupBox6.Controls.Add((Control) this.textBox19);
      this.groupBox6.Controls.Add((Control) this.textBox7);
      this.groupBox6.Controls.Add((Control) this.textBox20);
      this.groupBox6.Controls.Add((Control) this.label28);
      this.groupBox6.Controls.Add((Control) this.label29);
      this.groupBox6.Controls.Add((Control) this.label30);
      this.groupBox6.Controls.Add((Control) this.textBox15);
      this.groupBox6.Controls.Add((Control) this.textBox16);
      this.groupBox6.Controls.Add((Control) this.textBox17);
      this.groupBox6.Controls.Add((Control) this.label25);
      this.groupBox6.Controls.Add((Control) this.label26);
      this.groupBox6.Controls.Add((Control) this.label27);
      this.groupBox6.Controls.Add((Control) this.label19);
      this.groupBox6.Controls.Add((Control) this.label20);
      this.groupBox6.Controls.Add((Control) this.label21);
      this.groupBox6.Location = new Point(574, 6);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(210, 412);
      this.groupBox6.TabIndex = 29;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "当前标准频率表(HZ)";
      this.numericUpDown2.Location = new Point(158, 156);
      this.numericUpDown2.Maximum = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown2.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new Size(46, 21);
      this.numericUpDown2.TabIndex = 118;
      this.numericUpDown2.ThousandsSeparator = true;
      this.numericUpDown2.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown2.ValueChanged += new EventHandler(this.numericUpDown2_ValueChanged);
      this.textBox12.Location = new Point(29, 163);
      this.textBox12.Name = "textBox12";
      this.textBox12.Size = new Size(46, 21);
      this.textBox12.TabIndex = 117;
      this.textBox12.Text = "2260.0";
      this.textBox13.Location = new Point(29, 187);
      this.textBox13.Name = "textBox13";
      this.textBox13.Size = new Size(46, 21);
      this.textBox13.TabIndex = 115;
      this.textBox13.Text = "2260.0";
      this.comboBox6.FormattingEnabled = true;
      this.comboBox6.Location = new Point(113, 50);
      this.comboBox6.Name = "comboBox6";
      this.comboBox6.Size = new Size(91, 20);
      this.comboBox6.TabIndex = 48;
      this.comboBox6.SelectedIndexChanged += new EventHandler(this.comboBox6_SelectedIndexChanged);
      this.comboBox7.FormattingEnabled = true;
      this.comboBox7.Location = new Point(158, 180);
      this.comboBox7.Name = "comboBox7";
      this.comboBox7.Size = new Size(46, 20);
      this.comboBox7.TabIndex = 50;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(80, 28);
      this.label10.Name = "label10";
      this.label10.Size = new Size(53, 12);
      this.label10.TabIndex = 47;
      this.label10.Text = "当前标准";
      this.label12.AutoSize = true;
      this.label12.Location = new Point(80, 165);
      this.label12.Name = "label12";
      this.label12.Size = new Size(77, 12);
      this.label12.TabIndex = 49;
      this.label12.Text = "发码音长(MS)";
      this.textBox14.Location = new Point(29, 211);
      this.textBox14.Name = "textBox14";
      this.textBox14.Size = new Size(46, 21);
      this.textBox14.TabIndex = 116;
      this.textBox14.Text = "2260.0";
      this.label22.AutoSize = true;
      this.label22.Location = new Point(6, 165);
      this.label22.Name = "label22";
      this.label22.Size = new Size(17, 12);
      this.label22.TabIndex = 114;
      this.label22.Text = "6:";
      this.label23.AutoSize = true;
      this.label23.Location = new Point(6, 189);
      this.label23.Name = "label23";
      this.label23.Size = new Size(17, 12);
      this.label23.TabIndex = 113;
      this.label23.Text = "7:";
      this.label24.AutoSize = true;
      this.label24.Location = new Point(6, 213);
      this.label24.Name = "label24";
      this.label24.Size = new Size(17, 12);
      this.label24.TabIndex = 112;
      this.label24.Text = "8:";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(93, 137);
      this.label4.Name = "label4";
      this.label4.Size = new Size(59, 12);
      this.label4.TabIndex = 32;
      this.label4.Text = "   分隔符";
      this.textBox9.Location = new Point(29, 90);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new Size(46, 21);
      this.textBox9.TabIndex = 111;
      this.textBox9.Text = "2260.0";
      this.textBox10.Location = new Point(29, 113);
      this.textBox10.Name = "textBox10";
      this.textBox10.Size = new Size(46, 21);
      this.textBox10.TabIndex = 109;
      this.textBox10.Text = "2260.0";
      this.comboBox5.FormattingEnabled = true;
      this.comboBox5.Location = new Point(158, 103);
      this.comboBox5.Name = "comboBox5";
      this.comboBox5.Size = new Size(46, 20);
      this.comboBox5.TabIndex = 46;
      this.comboBox5.SelectedIndexChanged += new EventHandler(this.comboBox5_SelectedIndexChanged);
      this.textBox11.Location = new Point(29, 136);
      this.textBox11.Name = "textBox11";
      this.textBox11.Size = new Size(46, 21);
      this.textBox11.TabIndex = 110;
      this.textBox11.Text = "2260.0";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(6, 93);
      this.label16.Name = "label16";
      this.label16.Size = new Size(17, 12);
      this.label16.TabIndex = 108;
      this.label16.Text = "3:";
      this.label8.AutoSize = true;
      this.label8.Location = new Point(93, 84);
      this.label8.Name = "label8";
      this.label8.Size = new Size(59, 12);
      this.label8.TabIndex = 34;
      this.label8.Text = "   组呼码";
      this.label17.AutoSize = true;
      this.label17.Location = new Point(6, 117);
      this.label17.Name = "label17";
      this.label17.Size = new Size(17, 12);
      this.label17.TabIndex = 107;
      this.label17.Text = "4:";
      this.label18.AutoSize = true;
      this.label18.Location = new Point(6, 141);
      this.label18.Name = "label18";
      this.label18.Size = new Size(17, 12);
      this.label18.TabIndex = 106;
      this.label18.Text = "5:";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(99, 111);
      this.label7.Name = "label7";
      this.label7.Size = new Size(53, 12);
      this.label7.TabIndex = 45;
      this.label7.Text = "  重复音";
      this.textBox21.Location = new Point(29, 381);
      this.textBox21.Name = "textBox21";
      this.textBox21.Size = new Size(46, 21);
      this.textBox21.TabIndex = 105;
      this.textBox21.Text = "2260.0";
      this.label31.AutoSize = true;
      this.label31.Location = new Point(6, 381);
      this.label31.Name = "label31";
      this.label31.Size = new Size(17, 12);
      this.label31.TabIndex = 102;
      this.label31.Text = "F:";
      this.CmbSepa.FormattingEnabled = true;
      this.CmbSepa.Location = new Point(158, 130);
      this.CmbSepa.Name = "CmbSepa";
      this.CmbSepa.Size = new Size(46, 20);
      this.CmbSepa.TabIndex = 39;
      this.CmbSepa.SelectedIndexChanged += new EventHandler(this.CmbSepa_SelectedIndexChanged);
      this.textBox18.Location = new Point(29, 307);
      this.textBox18.Name = "textBox18";
      this.textBox18.Size = new Size(46, 21);
      this.textBox18.TabIndex = 99;
      this.textBox18.Text = "2260.0";
      this.textBox6.Location = new Point(29, 19);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(46, 21);
      this.textBox6.TabIndex = 87;
      this.textBox6.Text = "2260.0";
      this.CmbGroupCode.FormattingEnabled = true;
      this.CmbGroupCode.Location = new Point(158, 76);
      this.CmbGroupCode.Name = "CmbGroupCode";
      this.CmbGroupCode.Size = new Size(46, 20);
      this.CmbGroupCode.TabIndex = 40;
      this.CmbGroupCode.SelectedIndexChanged += new EventHandler(this.CmbGroupCode_SelectedIndexChanged);
      this.textBox8.Location = new Point(29, 67);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new Size(46, 21);
      this.textBox8.TabIndex = 85;
      this.textBox8.Text = "2260.0";
      this.textBox19.Location = new Point(29, 331);
      this.textBox19.Name = "textBox19";
      this.textBox19.Size = new Size(46, 21);
      this.textBox19.TabIndex = 98;
      this.textBox19.Text = "2260.0";
      this.textBox7.Location = new Point(29, 43);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new Size(46, 21);
      this.textBox7.TabIndex = 86;
      this.textBox7.Text = "2260.0";
      this.textBox20.Location = new Point(29, 356);
      this.textBox20.Name = "textBox20";
      this.textBox20.Size = new Size(46, 21);
      this.textBox20.TabIndex = 97;
      this.textBox20.Text = "2260.0";
      this.label28.AutoSize = true;
      this.label28.Location = new Point(6, 309);
      this.label28.Name = "label28";
      this.label28.Size = new Size(17, 12);
      this.label28.TabIndex = 96;
      this.label28.Text = "C:";
      this.label29.AutoSize = true;
      this.label29.Location = new Point(6, 333);
      this.label29.Name = "label29";
      this.label29.Size = new Size(17, 12);
      this.label29.TabIndex = 95;
      this.label29.Text = "D:";
      this.label30.AutoSize = true;
      this.label30.Location = new Point(6, 357);
      this.label30.Name = "label30";
      this.label30.Size = new Size(17, 12);
      this.label30.TabIndex = 94;
      this.label30.Text = "E:";
      this.textBox15.Location = new Point(29, 235);
      this.textBox15.Name = "textBox15";
      this.textBox15.Size = new Size(46, 21);
      this.textBox15.TabIndex = 93;
      this.textBox15.Text = "2260.0";
      this.textBox16.Location = new Point(29, 259);
      this.textBox16.Name = "textBox16";
      this.textBox16.Size = new Size(46, 21);
      this.textBox16.TabIndex = 92;
      this.textBox16.Text = "2260.0";
      this.textBox17.Location = new Point(29, 283);
      this.textBox17.Name = "textBox17";
      this.textBox17.Size = new Size(46, 21);
      this.textBox17.TabIndex = 91;
      this.textBox17.Text = "2260.0";
      this.label25.AutoSize = true;
      this.label25.Location = new Point(6, 237);
      this.label25.Name = "label25";
      this.label25.Size = new Size(17, 12);
      this.label25.TabIndex = 90;
      this.label25.Text = "9:";
      this.label26.AutoSize = true;
      this.label26.Location = new Point(6, 261);
      this.label26.Name = "label26";
      this.label26.Size = new Size(17, 12);
      this.label26.TabIndex = 89;
      this.label26.Text = "A:";
      this.label27.AutoSize = true;
      this.label27.Location = new Point(6, 285);
      this.label27.Name = "label27";
      this.label27.Size = new Size(17, 12);
      this.label27.TabIndex = 88;
      this.label27.Text = "B:";
      this.label19.AutoSize = true;
      this.label19.Location = new Point(6, 21);
      this.label19.Name = "label19";
      this.label19.Size = new Size(17, 12);
      this.label19.TabIndex = 72;
      this.label19.Text = "0:";
      this.label20.AutoSize = true;
      this.label20.Location = new Point(6, 45);
      this.label20.Name = "label20";
      this.label20.Size = new Size(17, 12);
      this.label20.TabIndex = 71;
      this.label20.Text = "1:";
      this.label21.AutoSize = true;
      this.label21.Location = new Point(6, 69);
      this.label21.Name = "label21";
      this.label21.Size = new Size(17, 12);
      this.label21.TabIndex = 70;
      this.label21.Text = "2:";
      this.groupBox3.BackColor = SystemColors.Control;
      this.groupBox3.Controls.Add((Control) this.groupBox4);
      this.groupBox3.Controls.Add((Control) this.groupBox5);
      this.groupBox3.Location = new Point(366, 6);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(202, 412);
      this.groupBox3.TabIndex = 10;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "5tone 设置";
      this.groupBox4.Controls.Add((Control) this.numericUpDown1);
      this.groupBox4.Controls.Add((Control) this.label32);
      this.groupBox4.Controls.Add((Control) this.comboBox4);
      this.groupBox4.Controls.Add((Control) this.checkBox1);
      this.groupBox4.Controls.Add((Control) this.CmbFirTm);
      this.groupBox4.Controls.Add((Control) this.CmbSendTm);
      this.groupBox4.Controls.Add((Control) this.CmbAckK);
      this.groupBox4.Controls.Add((Control) this.textBox4);
      this.groupBox4.Controls.Add((Control) this.label6);
      this.groupBox4.Controls.Add((Control) this.label13);
      this.groupBox4.Controls.Add((Control) this.label11);
      this.groupBox4.Controls.Add((Control) this.label3);
      this.groupBox4.Controls.Add((Control) this.CmbResTm);
      this.groupBox4.Controls.Add((Control) this.label2);
      this.groupBox4.Controls.Add((Control) this.label1);
      this.groupBox4.Location = new Point(6, 17);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(189, 283);
      this.groupBox4.TabIndex = 28;
      this.groupBox4.TabStop = false;
      this.numericUpDown1.Location = new Point(120, 154);
      this.numericUpDown1.Maximum = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      this.numericUpDown1.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new Size(40, 21);
      this.numericUpDown1.TabIndex = 54;
      this.numericUpDown1.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
      this.label32.AutoSize = true;
      this.label32.Location = new Point(55, 154);
      this.label32.Name = "label32";
      this.label32.Size = new Size(59, 12);
      this.label32.TabIndex = 53;
      this.label32.Text = " 选定信道";
      this.comboBox4.FormattingEnabled = true;
      this.comboBox4.Location = new Point(120, 239);
      this.comboBox4.Name = "comboBox4";
      this.comboBox4.Size = new Size(62, 20);
      this.comboBox4.TabIndex = 44;
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(98, 181);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(78, 16);
      this.checkBox1.TabIndex = 43;
      this.checkBox1.Text = "侧音     ";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.CmbFirTm.FormattingEnabled = true;
      this.CmbFirTm.Location = new Point(120, 90);
      this.CmbFirTm.Name = "CmbFirTm";
      this.CmbFirTm.Size = new Size(62, 20);
      this.CmbFirTm.TabIndex = 42;
      this.CmbSendTm.FormattingEnabled = true;
      this.CmbSendTm.Location = new Point(120, 213);
      this.CmbSendTm.Name = "CmbSendTm";
      this.CmbSendTm.Size = new Size(62, 20);
      this.CmbSendTm.TabIndex = 41;
      this.CmbAckK.FormattingEnabled = true;
      this.CmbAckK.Location = new Point(120, 61);
      this.CmbAckK.Name = "CmbAckK";
      this.CmbAckK.Size = new Size(62, 20);
      this.CmbAckK.TabIndex = 38;
      this.textBox4.Location = new Point(120, 32);
      this.textBox4.MaxLength = 5;
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(62, 21);
      this.textBox4.TabIndex = 37;
      this.textBox4.Text = "12345678";
      this.textBox4.KeyPress += new KeyPressEventHandler(this.textBox4_KeyPress);
      this.label6.AutoSize = true;
      this.label6.Location = new Point(5, 241);
      this.label6.Name = "label6";
      this.label6.Size = new Size(113, 12);
      this.label6.TabIndex = 20;
      this.label6.Text = "发码后延时时间(MS)";
      this.label13.AutoSize = true;
      this.label13.Location = new Point(5, 124);
      this.label13.Name = "label13";
      this.label13.Size = new Size(113, 12);
      this.label13.TabIndex = 36;
      this.label13.Text = "   自动复位时间(S)";
      this.label11.AutoSize = true;
      this.label11.Location = new Point(17, 94);
      this.label11.Name = "label11";
      this.label11.Size = new Size(101, 12);
      this.label11.TabIndex = 35;
      this.label11.Text = "首位数码时间(MS)";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(6, 218);
      this.label3.Name = "label3";
      this.label3.Size = new Size(113, 12);
      this.label3.TabIndex = 31;
      this.label3.Text = "发射预载波时间(MS)";
      this.CmbResTm.FormattingEnabled = true;
      this.CmbResTm.Location = new Point(120, 120);
      this.CmbResTm.Name = "CmbResTm";
      this.CmbResTm.Size = new Size(62, 20);
      this.CmbResTm.TabIndex = 30;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(30, 67);
      this.label2.Name = "label2";
      this.label2.Size = new Size(89, 12);
      this.label2.TabIndex = 29;
      this.label2.Text = "      解码响应";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(65, 41);
      this.label1.Name = "label1";
      this.label1.Size = new Size(53, 12);
      this.label1.TabIndex = 28;
      this.label1.Text = "本机ID码";
      this.groupBox5.Controls.Add((Control) this.CmbPttK);
      this.groupBox5.Controls.Add((Control) this.label9);
      this.groupBox5.Controls.Add((Control) this.label15);
      this.groupBox5.Controls.Add((Control) this.label14);
      this.groupBox5.Controls.Add((Control) this.textBox3);
      this.groupBox5.Controls.Add((Control) this.textBox5);
      this.groupBox5.Location = new Point(6, 295);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(189, 111);
      this.groupBox5.TabIndex = 20;
      this.groupBox5.TabStop = false;
      this.CmbPttK.FormattingEnabled = true;
      this.CmbPttK.Location = new Point(98, 16);
      this.CmbPttK.Name = "CmbPttK";
      this.CmbPttK.Size = new Size(84, 20);
      this.CmbPttK.TabIndex = 27;
      this.CmbPttK.SelectedIndexChanged += new EventHandler(this.CmbPttK_SelectedIndexChanged);
      this.label9.AutoSize = true;
      this.label9.Location = new Point(17, 22);
      this.label9.Name = "label9";
      this.label9.Size = new Size(71, 12);
      this.label9.TabIndex = 24;
      this.label9.Text = "PTT ID 类型";
      this.label15.AutoSize = true;
      this.label15.Location = new Point(17, 78);
      this.label15.Name = "label15";
      this.label15.Size = new Size(71, 12);
      this.label15.TabIndex = 22;
      this.label15.Text = "PTT ID 结束";
      this.label14.AutoSize = true;
      this.label14.Location = new Point(11, 49);
      this.label14.Name = "label14";
      this.label14.Size = new Size(77, 12);
      this.label14.TabIndex = 21;
      this.label14.Text = " PTT ID 开始";
      this.textBox3.Location = new Point(98, 40);
      this.textBox3.MaxLength = 24;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(84, 21);
      this.textBox3.TabIndex = 4;
      this.textBox3.Text = "12345678";
      this.textBox3.TextChanged += new EventHandler(this.textBox3_TextChanged);
      this.textBox3.KeyPress += new KeyPressEventHandler(this.textBox3_KeyPress);
      this.textBox5.Location = new Point(98, 69);
      this.textBox5.MaxLength = 24;
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(84, 21);
      this.textBox5.TabIndex = 5;
      this.textBox5.KeyPress += new KeyPressEventHandler(this.textBox5_KeyPress);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(800, 545);
      this.Controls.Add((Control) this.groupBox7);
      this.Name = nameof (Ton5Menu1);
      this.Text = "5Tone Menu";
      this.Load += new EventHandler(this.Ton5Menu1_Load);
      this.groupBox7.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((ISupportInitialize) this.dataGridView2).EndInit();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.numericUpDown2.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.numericUpDown1.EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.ResumeLayout(false);
    }

    public Ton5Menu1()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void DataGridViewColumnAddPro(
      DataGridView GridViewName,
      DataGridViewTextBoxColumn acCode,
      string name)
    {
      acCode.HeaderText = name;
      acCode.Width = 100;
      acCode.Name = "item";
      acCode.DataPropertyName = "item";
      acCode.ReadOnly = true;
      acCode.SortMode = DataGridViewColumnSortMode.NotSortable;
      GridViewName.Columns.Add((DataGridViewColumn) acCode);
    }

    private void loadDataGridViewPro()
    {
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dataGridView1.Dock = DockStyle.Fill;
      this.dataGridView1.AllowUserToResizeColumns = false;
      this.dataGridView1.AllowUserToResizeRows = false;
      DataGridViewTextBoxColumn acCode1 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode2 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode3 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode4 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode5 = new DataGridViewTextBoxColumn();
      this.DataGridViewColumnAddPro(this.dataGridView1, acCode1, Ton5Menu1.DataGridName[Class1.English_En, 0]);
      acCode1.Width = 60;
      this.DataGridViewColumnAddPro(this.dataGridView1, acCode2, Ton5Menu1.DataGridName[Class1.English_En, 1]);
      acCode2.Width = 60;
      this.DataGridViewColumnAddPro(this.dataGridView1, acCode3, Ton5Menu1.DataGridName[Class1.English_En, 2]);
      this.DataGridViewColumnAddPro(this.dataGridView1, acCode4, Ton5Menu1.DataGridName[Class1.English_En, 3]);
      acCode4.Width = 150;
      this.DataGridViewColumnAddPro(this.dataGridView1, acCode5, Ton5Menu1.DataGridName[Class1.English_En, 4]);
      this.dataGridView1.Rows.Add(15);
      for (int index = 0; index <= 15; ++index)
      {
        this.dataGridView1.Rows[index].Cells[0].Value = (object) (index + 1);
        this.dataGridView1.Rows[index].Cells[1].Value = (object) Class1.ConSigfTxKind_EngCh[Class1.English_En, 0];
        this.dataGridView1.Rows[index].Cells[2].Value = (object) "";
        this.dataGridView1.Rows[index].Cells[3].Value = (object) "";
        this.dataGridView1.Rows[index].Cells[4].Value = (object) "";
      }
    }

    private void GetComBoxTextToDataGridViewPro(
      ComboBox ComboBo,
      DataGridView dataGridViewAll,
      int Index)
    {
      string text = ComboBo.Text;
      int rowIndex = dataGridViewAll.CurrentCell.RowIndex;
      dataGridViewAll.Rows[rowIndex].Cells[Index].Value = (object) text;
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

    private void load_GroupBox1Pro()
    {
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox1, Class1.ConSigfTxKind_EngCh, Class1.ConSigfTxKind_EngCh.GetLength(1) - 1);
      this.comboBox1.Visible = false;
      this.TextBoxResPro(this.textBox1, 16, "");
      this.textBox1.Visible = false;
      this.loadDataGridViewPro();
    }

    private void loadDataGridView2Pro()
    {
      this.dataGridView2.RowHeadersVisible = false;
      this.dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dataGridView2.Dock = DockStyle.Fill;
      this.dataGridView2.AllowUserToResizeColumns = false;
      this.dataGridView2.AllowUserToResizeRows = false;
      DataGridViewTextBoxColumn acCode1 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode2 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode3 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode4 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode5 = new DataGridViewTextBoxColumn();
      this.DataGridViewColumnAddPro(this.dataGridView2, acCode1, Ton5Menu1.DataGridName1[Class1.English_En, 0]);
      acCode1.Width = 60;
      this.DataGridViewColumnAddPro(this.dataGridView2, acCode2, Ton5Menu1.DataGridName1[Class1.English_En, 1]);
      acCode2.Width = 60;
      this.DataGridViewColumnAddPro(this.dataGridView2, acCode3, Ton5Menu1.DataGridName1[Class1.English_En, 2]);
      acCode3.Width = 100;
      this.DataGridViewColumnAddPro(this.dataGridView2, acCode4, Ton5Menu1.DataGridName1[Class1.English_En, 3]);
      acCode4.Width = 90;
      this.DataGridViewColumnAddPro(this.dataGridView2, acCode5, Ton5Menu1.DataGridName1[Class1.English_En, 4]);
      acCode5.Width = 90;
      this.dataGridView2.Rows.Add(7);
      for (int index = 0; index <= 7; ++index)
      {
        this.dataGridView2.Rows[index].Cells[0].Value = (object) (index + 1);
        this.dataGridView2.Rows[index].Cells[1].Value = (object) Ton5Menu1.Tone5DecodeK_EngCh[Class1.English_En, 0];
        this.dataGridView2.Rows[index].Cells[2].Value = (object) Class1.ConAckKind_EngCh[Class1.English_En, 1];
        this.dataGridView2.Rows[index].Cells[3].Value = (object) "";
        this.dataGridView2.Rows[index].Cells[4].Value = (object) "";
      }
    }

    private void DisTone5FrePro(int Kind)
    {
      TextBox[] textBoxArray = new TextBox[16]
      {
        this.textBox6,
        this.textBox7,
        this.textBox8,
        this.textBox9,
        this.textBox10,
        this.textBox11,
        this.textBox12,
        this.textBox13,
        this.textBox14,
        this.textBox15,
        this.textBox16,
        this.textBox17,
        this.textBox18,
        this.textBox19,
        this.textBox20,
        this.textBox21
      };
      string StrTemp = "";
      公共控件操作.numericUpDownXRes(this.numericUpDown2, 256, 69, 70);
      if (Kind == 3 || Kind == 6 || Kind == 8 || Kind == 10)
        公共控件操作.numericUpDownXRes(this.numericUpDown2, 256, 69, 100);
      else if (Kind != 9 && Kind != 12)
        ;
      for (int index = 0; index <= 15; ++index)
      {
        switch (Kind)
        {
          case 0:
            StrTemp = this.ZVEI1[index].ToString();
            break;
          case 1:
            StrTemp = this.PZVEI[index].ToString();
            break;
          case 2:
            StrTemp = this.ZVEI2[index].ToString();
            break;
          case 3:
            StrTemp = this.ZVEI3[index].ToString();
            break;
          case 4:
            StrTemp = this.DZVEI[index].ToString();
            break;
          case 5:
            StrTemp = this.PDZVEI[index].ToString();
            break;
          case 6:
            StrTemp = this.CCIR12[index].ToString();
            break;
          case 7:
            StrTemp = this.PCCIR[index].ToString();
            break;
          case 8:
            StrTemp = this.PCCIR[index].ToString();
            break;
          case 9:
            StrTemp = this.EEA[index].ToString();
            break;
          case 10:
            StrTemp = this.EuroSg[index].ToString();
            break;
          case 11:
            StrTemp = this.Natel[index].ToString();
            break;
          case 12:
            StrTemp = this.Modat[index].ToString();
            break;
          case 13:
            StrTemp = this.CCITT[index].ToString();
            break;
          case 14:
            StrTemp = this.EIA[index].ToString();
            break;
        }
        textBoxArray[index].Enabled = false;
        if (StrTemp == "10" || StrTemp == "1")
        {
          textBoxArray[index].Text = "";
        }
        else
        {
          if (Class1.StrAddress(StrTemp, ".") == -1)
            StrTemp += ".0";
          textBoxArray[index].Text = StrTemp;
        }
      }
    }

    private void load_GroupBox2Pro()
    {
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox2, Ton5Menu1.Tone5DecodeK_EngCh, Ton5Menu1.Tone5DecodeK_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox3, Class1.ConAckKind_EngCh, Class1.ConAckKind_EngCh.GetLength(1) - 1);
      this.comboBox2.Visible = false;
      this.comboBox3.Visible = false;
      this.TextBoxResPro(this.textBox2, 8, "");
      this.textBox2.Visible = false;
      this.loadDataGridView2Pro();
    }

    private void load_GroBox3_LabelPro()
    {
      for (int index = 0; index <= 12; ++index)
        this.Label_Arr[index].Text = Ton5Menu1.lableArrName[Class1.English_En, index];
      this.label3.Visible = false;
      this.label6.Visible = false;
    }

    private void load_GroBox3_textBoxPro()
    {
      this.TextBoxResPro(this.textBox4, 8, "12345678");
      this.TextBoxResPro(this.textBox3, 8, "12345678");
      this.textBox3.Enabled = false;
      this.TextBoxResPro(this.textBox5, 8, "87654321");
      this.textBox5.Enabled = false;
    }

    private void CmbAdd_0_1S_Pro(ComboBox cmbHelp)
    {
      for (int index = 0; index <= 10; ++index)
        cmbHelp.Items.Add((object) (index * 100));
      this.ComBoxResPro(cmbHelp, 2);
    }

    private void CmbAdd_0_25S_Pro(ComboBox cmbHelp)
    {
      for (int index = 0; index <= 25; ++index)
        cmbHelp.Items.Add((object) index);
      this.ComBoxResPro(cmbHelp, 10);
    }

    private void CmbAdd_ABCDEF_Pro(ComboBox cmbHelp)
    {
      cmbHelp.Items.Add((object) "A");
      cmbHelp.Items.Add((object) "B");
      cmbHelp.Items.Add((object) "C");
      cmbHelp.Items.Add((object) "D");
      cmbHelp.Items.Add((object) "*");
      cmbHelp.Items.Add((object) "#");
      this.ComBoxResPro(cmbHelp, 0);
    }

    private void CmbAdd_40_100_Pro(ComboBox cmbHelp)
    {
      for (int index = 4; index <= 10; ++index)
        cmbHelp.Items.Add((object) (index * 10));
      this.ComBoxResPro(cmbHelp, 3);
    }

    private void CmbAdd_CurrStand_Pro(ComboBox cmbHelp)
    {
      cmbHelp.Items.Add((object) "ZVEI1");
      cmbHelp.Items.Add((object) "PZVEI");
      cmbHelp.Items.Add((object) "ZVEI2");
      cmbHelp.Items.Add((object) "ZVEI3");
      cmbHelp.Items.Add((object) "DZVEI");
      cmbHelp.Items.Add((object) "PDZVEI");
      cmbHelp.Items.Add((object) "CCIR1");
      cmbHelp.Items.Add((object) "CCIR2");
      cmbHelp.Items.Add((object) "PCCIR");
      cmbHelp.Items.Add((object) "EEA");
      cmbHelp.Items.Add((object) "Euro Signal");
      cmbHelp.Items.Add((object) "Natel");
      cmbHelp.Items.Add((object) "Modat");
      cmbHelp.Items.Add((object) "CCITT");
      this.ComBoxResPro(cmbHelp, 0);
    }

    private void load_GroBox3_comboBoxPro()
    {
      公共控件操作.load_CmbBoxNProEng_Ch1(this.CmbAckK, Class1.ConAckKind_EngCh, Class1.ConAckKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.CmbPttK, Class1.PttKind_EngCh, Class1.PttKind_EngCh.GetLength(1) - 1);
      this.CmbAdd_0_1S_Pro(this.CmbFirTm);
      this.CmbAdd_0_1S_Pro(this.comboBox4);
      this.CmbAdd_0_25S_Pro(this.CmbResTm);
      this.CmbAdd_CurrStand_Pro(this.comboBox6);
      this.CmbAdd_ABCDEF_Pro(this.comboBox5);
      this.comboBox5.SelectedIndex = 4;
      this.CmbAdd_ABCDEF_Pro(this.CmbSepa);
      this.CmbSepa.SelectedIndex = 5;
      this.CmbAdd_ABCDEF_Pro(this.CmbGroupCode);
      this.CmbAdd_40_100_Pro(this.comboBox7);
      this.CmbAdd_0_1S_Pro(this.CmbSendTm);
      this.CmbSendTm.SelectedIndex = 2;
      this.CmbAdd_0_1S_Pro(this.comboBox4);
      this.comboBox4.Visible = false;
      this.CmbSendTm.Visible = false;
      this.comboBox7.Visible = false;
      this.DisTone5FrePro(0);
    }

    private void load_GroBox3_numericUpDown()
    {
      公共控件操作.numericUpDownXRes(this.numericUpDown1, 17, 0, 1);
      公共控件操作.numericUpDownXRes(this.numericUpDown2, 256, 69, 70);
    }

    private void load_GroBox3_CheckBoxPro()
    {
      for (int index = 0; index <= 0; ++index)
        this.CheckBox_Arr[index].Text = Ton5Menu1.ChekcBox_EngCh[Class1.English_En, index];
    }

    private void load_GroBox3_ButtonPro()
    {
      for (int index = 0; index <= 1; ++index)
        this.Button_Arr[index].Text = Ton5Menu1.Button_EngCh[Class1.English_En, index];
    }

    private void load_GroupBox3Pro()
    {
      this.load_GroBox3_numericUpDown();
      this.load_GroBox3_CheckBoxPro();
      this.load_GroBox3_LabelPro();
      this.load_GroBox3_textBoxPro();
      this.load_GroBox3_comboBoxPro();
      this.load_GroBox3_ButtonPro();
      this.checkBox1.Checked = true;
    }

    private void groupBox4_Enter(object sender, EventArgs e)
    {
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private string GetCurrCellText(DataGridView dataGridViewAll)
    {
      string currCellText;
      try
      {
        int rowIndex = dataGridViewAll.SelectedCells[0].RowIndex;
        int columnIndex = dataGridViewAll.SelectedCells[0].ColumnIndex;
        currCellText = dataGridViewAll[columnIndex, rowIndex].Value.ToString();
      }
      catch
      {
        currCellText = "";
      }
      return currCellText;
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int rowIndex1 = this.dataGridView1.CurrentCell.RowIndex;
      string str1 = this.dataGridView1.Rows[rowIndex1].Cells[1].Value.ToString();
      if (1 == this.dataGridView1.CurrentCell.ColumnIndex)
      {
        this.textBox1.Visible = false;
        Rectangle displayRectangle = this.dataGridView1.GetCellDisplayRectangle(this.dataGridView1.CurrentCell.ColumnIndex, this.dataGridView1.CurrentCell.RowIndex, false);
        this.comboBox1.Left = displayRectangle.Left + 4;
        this.comboBox1.Top = displayRectangle.Top + 18;
        this.comboBox1.Width = displayRectangle.Width - 2;
        this.comboBox1.Height = displayRectangle.Height;
        this.comboBox1.Visible = true;
        this.comboBox1.Focus();
        this.comboBox1.SelectedIndex = 公共控件操作.GetCombo_XListPro_Eng_Ch(Class1.ConSigfTxKind_EngCh, this.GetCurrCellText(this.dataGridView1));
      }
      else if (2 == this.dataGridView1.CurrentCell.ColumnIndex)
      {
        this.comboBox1.Visible = false;
        if (str1 == Class1.ConSigfTxKind_EngCh[Class1.English_En, 0])
        {
          Rectangle displayRectangle = this.dataGridView1.GetCellDisplayRectangle(this.dataGridView1.CurrentCell.ColumnIndex, this.dataGridView1.CurrentCell.RowIndex, false);
          this.textBox1.Left = displayRectangle.Left + 3;
          this.textBox1.Top = displayRectangle.Top + 17;
          this.textBox1.Width = displayRectangle.Width;
          this.textBox1.Height = displayRectangle.Height;
          this.textBox1.MaxLength = 8;
          this.textBox1.Visible = true;
          this.textBox1.Focus();
          this.textBox1.Text = this.GetCurrCellText(this.dataGridView1);
        }
        else
        {
          if (!(str1 == Class1.ConSigfTxKind_EngCh[Class1.English_En, 1]))
            return;
          string str2 = this.dataGridView1.Rows[rowIndex1].Cells[2].Value.ToString();
          特叫类型 特叫类型 = new 特叫类型();
          特叫类型.GiCurrCh = rowIndex1;
          特叫类型.OwnId_String = "";
          特叫类型.Spilt_String = "";
          if (str1 == Class1.ConSigfTxKind_EngCh[Class1.English_En, 1])
          {
            特叫类型.GiKind = 1;
            特叫类型.CallId_String = str2;
          }
          int num = (int) 特叫类型.ShowDialog((IWin32Window) this);
          特叫类型.Dispose();
          if (str1 == Class1.ConSigfTxKind_EngCh[Class1.English_En, 1])
            this.dataGridView1[2, rowIndex1].Value = (object) Class1.GiCallId;
        }
      }
      else if (4 == this.dataGridView1.CurrentCell.ColumnIndex)
      {
        int rowIndex2 = this.dataGridView1.CurrentCell.RowIndex;
        this.comboBox1.Visible = false;
        if (this.dataGridView1.Rows[rowIndex2].Cells[2].Value.ToString() == "")
          return;
        Rectangle displayRectangle = this.dataGridView1.GetCellDisplayRectangle(this.dataGridView1.CurrentCell.ColumnIndex, this.dataGridView1.CurrentCell.RowIndex, false);
        this.textBox1.Left = displayRectangle.Left + 3;
        this.textBox1.Top = displayRectangle.Top + 17;
        this.textBox1.Width = displayRectangle.Width;
        this.textBox1.Height = displayRectangle.Height;
        this.textBox1.MaxLength = 6;
        this.textBox1.Visible = true;
        this.textBox1.Focus();
        this.textBox1.Text = this.GetCurrCellText(this.dataGridView1);
      }
      else
      {
        this.textBox1.Visible = false;
        this.comboBox1.Visible = false;
      }
    }

    private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int rowIndex = this.dataGridView2.CurrentCell.RowIndex;
      if (1 == this.dataGridView2.CurrentCell.ColumnIndex)
      {
        this.comboBox3.Visible = false;
        this.textBox2.Visible = false;
        Rectangle displayRectangle = this.dataGridView2.GetCellDisplayRectangle(this.dataGridView2.CurrentCell.ColumnIndex, this.dataGridView2.CurrentCell.RowIndex, false);
        this.comboBox2.Left = displayRectangle.Left + 4;
        this.comboBox2.Top = displayRectangle.Top + 18;
        this.comboBox2.Width = displayRectangle.Width - 2;
        this.comboBox2.Height = displayRectangle.Height;
        this.comboBox2.Visible = true;
        this.comboBox2.SelectedIndex = 公共控件操作.GetCombo_XListPro_Eng_Ch(Ton5Menu1.Tone5DecodeK_EngCh, this.GetCurrCellText(this.dataGridView2));
        this.comboBox2.Focus();
      }
      else if (2 == this.dataGridView2.CurrentCell.ColumnIndex)
      {
        this.comboBox2.Visible = false;
        this.textBox2.Visible = false;
        if (this.dataGridView2.Rows[rowIndex].Cells[3].Value.ToString() == "")
          return;
        Rectangle displayRectangle = this.dataGridView2.GetCellDisplayRectangle(this.dataGridView2.CurrentCell.ColumnIndex, this.dataGridView2.CurrentCell.RowIndex, false);
        this.comboBox3.Left = displayRectangle.Left + 4;
        this.comboBox3.Top = displayRectangle.Top + 18;
        this.comboBox3.Width = displayRectangle.Width - 2;
        this.comboBox3.Height = displayRectangle.Height;
        this.comboBox3.Visible = true;
        this.comboBox3.SelectedIndex = 公共控件操作.GetCombo_XListPro_Eng_Ch(Class1.ConAckKind_EngCh, this.GetCurrCellText(this.dataGridView2));
        this.comboBox3.Focus();
      }
      else if (3 == this.dataGridView2.CurrentCell.ColumnIndex)
      {
        this.comboBox3.Visible = false;
        this.comboBox2.Visible = false;
        Rectangle displayRectangle = this.dataGridView2.GetCellDisplayRectangle(this.dataGridView2.CurrentCell.ColumnIndex, this.dataGridView2.CurrentCell.RowIndex, false);
        this.textBox2.Left = displayRectangle.Left + 3;
        this.textBox2.Top = displayRectangle.Top + 17;
        this.textBox2.Width = displayRectangle.Width;
        this.textBox2.Height = displayRectangle.Height;
        this.textBox2.MaxLength = 12;
        this.textBox2.Visible = true;
        this.textBox2.Focus();
        this.textBox2.Text = this.GetCurrCellText(this.dataGridView2);
      }
      else if (4 == this.dataGridView2.CurrentCell.ColumnIndex)
      {
        this.comboBox3.Visible = false;
        this.comboBox2.Visible = false;
        this.comboBox1.Visible = false;
        if (this.dataGridView2.Rows[rowIndex].Cells[3].Value.ToString() == "")
          return;
        Rectangle displayRectangle = this.dataGridView2.GetCellDisplayRectangle(this.dataGridView2.CurrentCell.ColumnIndex, this.dataGridView2.CurrentCell.RowIndex, false);
        this.textBox2.Left = displayRectangle.Left + 3;
        this.textBox2.Top = displayRectangle.Top + 17;
        this.textBox2.Width = displayRectangle.Width;
        this.textBox2.Height = displayRectangle.Height;
        this.textBox2.MaxLength = 6;
        this.textBox2.Visible = true;
        this.textBox2.Focus();
        this.textBox2.Text = this.GetCurrCellText(this.dataGridView2);
      }
      else
      {
        this.textBox2.Visible = false;
        this.comboBox2.Visible = false;
        this.comboBox3.Visible = false;
      }
    }

    private string GetTxOneToneChStringPro(string[] n, int i)
    {
      int num = Class1.Tone5TxBegAddr / Class1.ConOneRowDatCt + Class1.ConOneTxTone5ChDatCt * i / Class1.ConOneRowDatCt;
      string str1 = n[Class1.FielBegRow + num];
      string str2 = str1.Substring(Class1.ConUseChDatSta + 1, str1.Length - Class1.ConUseChDatSta - 1);
      string str3 = n[Class1.FielBegRow + num + 1];
      return (str2 + str3.Substring(Class1.ConUseChDatSta + 1, str3.Length - Class1.ConUseChDatSta - 1)).Substring(Class1.ConOneTxTone5ChDatCt * i % Class1.ConOneRowDatCt << 1, 2 * Class1.ConOneTxTone5ChDatCt);
    }

    private string GetRxOneToneChStringPro(string[] n, int i)
    {
      int num = Class1.Tone5RxBegAddr / Class1.ConOneRowDatCt + Class1.ConOneRxTone5ChDatCt * i / Class1.ConOneRowDatCt;
      string str1 = n[Class1.FielBegRow + num];
      string str2 = str1.Substring(Class1.ConUseChDatSta + 1, str1.Length - Class1.ConUseChDatSta - 1);
      string str3 = n[Class1.FielBegRow + num + 1];
      return (str2 + str3.Substring(Class1.ConUseChDatSta + 1, str3.Length - Class1.ConUseChDatSta - 1)).Substring(Class1.ConOneRxTone5ChDatCt * i % Class1.ConOneRowDatCt << 1, 2 * Class1.ConOneRxTone5ChDatCt);
    }

    private void Dis5ToneTxDataPro(string[] DtmfCh)
    {
      try
      {
        for (int index1 = 0; index1 <= 15; ++index1)
        {
          if (!(index1 > 7 ? Class2.UseFulChkPro(DtmfCh[17], index1 - 8) : Class2.UseFulChkPro(DtmfCh[16], index1)))
          {
            this.dataGridView1.Rows[index1].Cells[1].Value = (object) "";
            this.dataGridView1.Rows[index1].Cells[2].Value = (object) "";
            this.dataGridView1.Rows[index1].Cells[3].Value = (object) "";
            this.dataGridView1.Rows[index1].Cells[4].Value = (object) "";
          }
          else
          {
            int length1 = Convert.ToInt32(DtmfCh[index1].Substring(8, 2), 16) & 31;
            this.dataGridView1.Rows[index1].Cells[2].Value = (object) DtmfCh[index1].Substring(0, length1);
            if (this.dataGridView1.Rows[index1].Cells[2].Value.ToString() == "")
            {
              this.dataGridView1.Rows[index1].Cells[1].Value = (object) "";
              this.dataGridView1.Rows[index1].Cells[3].Value = (object) "";
              this.dataGridView1.Rows[index1].Cells[4].Value = (object) "";
            }
            int num = length1 & 96;
            int int32 = Convert.ToInt32(DtmfCh[index1].Substring(42, 2), 16);
            int index2 = (int32 & 96) >> 5;
            if (index2 > 2)
              index2 = 0;
            this.dataGridView1.Rows[index1].Cells[1].Value = (object) Class1.ConSigfTxKind_EngCh[Class1.English_En, index2];
            int length2 = (int32 & 31) << 1;
            string str1 = DtmfCh[index1].Substring(10, length2);
            if (str1 == "            ")
              str1 = "";
            this.dataGridView1.Rows[index1].Cells[3].Value = (object) str1;
            int length3 = (Convert.ToInt32(DtmfCh[index1].Substring(56, 2), 16) & 15) << 1;
            string str2 = Class2.StringChNamePro(DtmfCh[index1].Substring(44, length3));
            if (str2 == "            ")
              str2 = "";
            this.dataGridView1.Rows[index1].Cells[4].Value = (object) str2;
          }
        }
      }
      catch
      {
      }
    }

    private void Dis5ToneRxDataPro(string[] DtmfCh)
    {
      try
      {
        for (int index1 = 0; index1 <= 7; ++index1)
        {
          if (!Class2.UseFulChkPro(DtmfCh[8], index1))
          {
            this.dataGridView2.Rows[index1].Cells[1].Value = (object) "";
            this.dataGridView2.Rows[index1].Cells[2].Value = (object) "";
            this.dataGridView2.Rows[index1].Cells[3].Value = (object) "";
          }
          else
          {
            int int32 = Convert.ToInt32(DtmfCh[index1].Substring(0, 2), 16);
            int index2 = int32 & 7;
            this.dataGridView2.Rows[index1].Cells[1].Value = (object) Ton5Menu1.Tone5DecodeK_EngCh[Class1.English_En, index2];
            int index3 = (int32 & 24) >> 3;
            this.dataGridView2.Rows[index1].Cells[2].Value = (object) Class1.ConAckKind_EngCh[Class1.English_En, index3];
            int length1 = Convert.ToInt32(DtmfCh[index1].Substring(14, 2), 16) & 15;
            this.dataGridView2.Rows[index1].Cells[3].Value = (object) DtmfCh[index1].Substring(2, length1);
            if (this.dataGridView2.Rows[index1].Cells[3].Value.ToString() == "")
            {
              this.dataGridView2.Rows[index1].Cells[1].Value = (object) "";
              this.dataGridView2.Rows[index1].Cells[2].Value = (object) "";
              this.dataGridView2.Rows[index1].Cells[4].Value = (object) "";
            }
            else
            {
              int length2 = (Convert.ToInt32(DtmfCh[index1].Substring(28, 2), 16) & 15) << 1;
              string str = Class2.StringChNamePro(DtmfCh[index1].Substring(16, length2));
              if (str == "            ")
                str = "";
              this.dataGridView2.Rows[index1].Cells[4].Value = (object) str;
            }
          }
        }
      }
      catch
      {
      }
    }

    private void Dis5ToneSetDataPro(string Datastr)
    {
      string str1 = Datastr.Substring(0, 10);
      string str2 = Datastr.Substring(10, 2);
      string str3 = Datastr.Substring(12, 2);
      string str4 = Datastr.Substring(14, 2);
      string str5 = Datastr.Substring(16, 2);
      string str6 = Datastr.Substring(18, 2);
      string str7 = Datastr.Substring(20, 2);
      string str8 = Datastr.Substring(22, 2);
      string str9 = Datastr.Substring(24, 10);
      string str10 = Datastr.Substring(34, 10);
      string str11 = Datastr.Substring(50, 2);
      try
      {
        int int32_1 = Convert.ToInt32(str1.Substring(9, 1), 16);
        this.textBox4.Text = str1.Substring(0, int32_1);
        this.CmbSendTm.SelectedIndex = Convert.ToInt32(str2, 16) & 31;
        this.CmbResTm.SelectedIndex = Convert.ToInt32(str3, 16) & 31;
        this.CmbFirTm.SelectedIndex = Convert.ToInt32(str4, 16) & 15;
        this.comboBox4.SelectedIndex = Convert.ToInt32(str5, 16) & 15;
        int int32_2 = Convert.ToInt32(str6, 16);
        this.CmbGroupCode.SelectedIndex = int32_2 & 7;
        this.comboBox5.SelectedIndex = (int32_2 & 56) >> 3;
        this.CmbAckK.SelectedIndex = (int32_2 & 192) >> 6;
        int int32_3 = Convert.ToInt32(str7, 16);
        int Kind = int32_3 & 15;
        this.comboBox6.SelectedIndex = Kind;
        this.DisTone5FrePro(Kind);
        this.CmbSepa.SelectedIndex = (int32_3 & 112) >> 4;
        this.checkBox1.Checked = 0 != (int32_3 & 128);
        int int32_4 = Convert.ToInt32(str8, 16);
        this.comboBox7.SelectedIndex = int32_4 & 7;
        this.CmbPttK.SelectedIndex = (int32_4 & 24) >> 3;
        int length1 = Convert.ToInt32(str9.Substring(8, 2), 16) & 15;
        this.textBox3.Text = str9.Substring(0, length1);
        int length2 = Convert.ToInt32(str10.Substring(8, 2), 16) & 15;
        this.textBox5.Text = str10.Substring(0, length2);
        this.numericUpDown2.Value = (Decimal) Convert.ToInt32(str11, 16);
      }
      catch
      {
      }
    }

    private void LoadToneFileDataDisPro()
    {
      try
      {
        string[] n = Class1.ReadFileDataPro(this.GiFileName2).Split('\r');
        int num1 = Class1.Tone5SetAddr / Class1.ConOneRowDatCt;
        string str = Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num1]);
        string Datastr = str.Substring(Class1.ConUseChDatSta + 1, str.Length - Class1.ConUseChDatSta - 1);
        string[] DtmfCh1 = new string[18];
        for (int i = 0; i <= 15; ++i)
          DtmfCh1[i] = this.GetTxOneToneChStringPro(n, i);
        DtmfCh1[16] = Datastr.Substring(44, 2);
        DtmfCh1[17] = Datastr.Substring(46, 2);
        string[] DtmfCh2 = new string[9];
        for (int i = 0; i <= 7; ++i)
          DtmfCh2[i] = this.GetRxOneToneChStringPro(n, i);
        DtmfCh2[8] = Datastr.Substring(48, 2);
        this.Dis5ToneTxDataPro(DtmfCh1);
        this.Dis5ToneRxDataPro(DtmfCh2);
        this.Dis5ToneSetDataPro(Datastr);
        int num2 = Class1.ConSetBegAddr / Class1.ConOneRowDatCt;
        this.numericUpDown1.Value = (Decimal) (Convert.ToInt32(Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num2]).Substring(44, 1), 16) + 1);
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 1], Class1.RadioName);
      }
    }

    private void SetContrlAs_arrPro()
    {
      this.Label_Arr = new Label[23];
      this.Label_Arr[0] = this.label1;
      this.Label_Arr[1] = this.label2;
      this.Label_Arr[2] = this.label4;
      this.Label_Arr[3] = this.label8;
      this.Label_Arr[4] = this.label7;
      this.Label_Arr[5] = this.label11;
      this.Label_Arr[6] = this.label13;
      this.Label_Arr[7] = this.label32;
      this.Label_Arr[8] = this.label9;
      this.Label_Arr[9] = this.label14;
      this.Label_Arr[10] = this.label15;
      this.Label_Arr[11] = this.label10;
      this.Label_Arr[12] = this.label12;
      this.ComboBoxl_Arr = new ComboBox[14];
      this.ComboBoxl_Arr[0] = this.CmbAckK;
      this.ComboBoxl_Arr[1] = this.CmbSepa;
      this.ComboBoxl_Arr[2] = this.CmbGroupCode;
      this.ComboBoxl_Arr[3] = this.CmbSendTm;
      this.ComboBoxl_Arr[4] = this.CmbFirTm;
      this.ComboBoxl_Arr[5] = this.CmbResTm;
      this.ComboBoxl_Arr[6] = this.CmbPttK;
      this.TextBoxl_Arr = new TextBox[3];
      this.TextBoxl_Arr[0] = this.textBox1;
      this.TextBoxl_Arr[1] = this.textBox2;
      this.TextBoxl_Arr[2] = this.textBox3;
      this.CheckBox_Arr = new CheckBox[6];
      this.CheckBox_Arr[0] = this.checkBox1;
      this.GroupBox_Arr = new GroupBox[4];
      this.GroupBox_Arr[0] = this.groupBox1;
      this.GroupBox_Arr[1] = this.groupBox2;
      this.GroupBox_Arr[2] = this.groupBox3;
      this.GroupBox_Arr[3] = this.groupBox6;
      this.Button_Arr = new Button[2];
      this.Button_Arr[0] = this.button1;
      this.Button_Arr[1] = this.button2;
    }

    private void Ton5Menu1_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.SetContrlAs_arrPro();
      this.tabPage1.Text = Ton5Menu1.tabContro_EngCh[Class1.English_En, 0];
      this.tabPage2.Text = Ton5Menu1.tabContro_EngCh[Class1.English_En, 1];
      for (int index = 0; index <= 3; ++index)
        this.GroupBox_Arr[index].Text = Ton5Menu1.GroupBox_EngCh[Class1.English_En, index];
      this.load_GroupBox1Pro();
      this.load_GroupBox2Pro();
      this.load_GroupBox3Pro();
      this.LoadToneFileDataDisPro();
      this.dataGridView1.Columns[3].Visible = false;
      this.dataGridView2.Columns[2].Visible = false;
      this.groupBox5.Visible = false;
      this.CmbAckK.Visible = false;
      this.label2.Visible = false;
    }

    private string Get5ToneTxChUseFulStringPro(DataGridView datGridView, int chnum)
    {
      string StrData = "";
      for (int index = 0; index < chnum; ++index)
      {
        if (datGridView.Rows[index].Cells[2].Value == null)
          datGridView.Rows[index].Cells[2].Value = (object) "";
        StrData = !(datGridView.Rows[index].Cells[2].Value.ToString() == "") ? StrData + "1" : StrData + "0";
      }
      return Class2.GetChUseFulStringPro(chnum, StrData);
    }

    private string Get5ToneRxChUseFulStringPro(DataGridView datGridView, int chnum)
    {
      string StrData = "";
      for (int index = 0; index < chnum; ++index)
      {
        if (datGridView.Rows[index].Cells[3].Value == null)
          datGridView.Rows[index].Cells[3].Value = (object) "";
        StrData = !(datGridView.Rows[index].Cells[3].Value.ToString() == "") ? StrData + "1" : StrData + "0";
      }
      return Class2.GetChUseFulStringPro(chnum, StrData);
    }

    private string Get5ToneSetDataStringPro()
    {
      string[] strArray = new string[14];
      strArray[0] = Class2.ChgToDatPro(this.textBox4.Text, 8, 0);
      int Data1 = 0;
      strArray[1] = Class1.DataToHexStr((long) Data1);
      int selectedIndex1 = this.CmbResTm.SelectedIndex;
      strArray[2] = Class1.DataToHexStr((long) selectedIndex1);
      int selectedIndex2 = this.CmbFirTm.SelectedIndex;
      strArray[3] = Class1.DataToHexStr((long) selectedIndex2);
      int Data2 = 0;
      strArray[4] = Class1.DataToHexStr((long) Data2);
      int Data3 = this.CmbGroupCode.SelectedIndex | this.comboBox5.SelectedIndex << 3 | this.CmbAckK.SelectedIndex << 6;
      strArray[5] = Class1.DataToHexStr((long) Data3);
      int Data4 = this.comboBox6.SelectedIndex | this.CmbSepa.SelectedIndex << 4 | Class2.ChgBoolToDatPro(this.checkBox1.Checked) << 7;
      strArray[6] = Class1.DataToHexStr((long) Data4);
      int Data5 = 0 | this.CmbPttK.SelectedIndex << 3;
      strArray[7] = Class1.DataToHexStr((long) Data5);
      strArray[8] = Class2.ChgToDatPro(this.textBox3.Text, 8, 0);
      strArray[9] = Class2.ChgToDatPro(this.textBox5.Text, 8, 0);
      strArray[10] = this.Get5ToneTxChUseFulStringPro(this.dataGridView1, 16);
      strArray[11] = this.Get5ToneRxChUseFulStringPro(this.dataGridView2, 8);
      int Data6 = (int) this.numericUpDown2.Value;
      strArray[12] = Class1.DataToHexStr((long) Data6);
      for (int index = 1; index <= 12; ++index)
        strArray[0] = strArray[0] + strArray[index];
      strArray[0] = strArray[0] + "202020202020";
      return Class1.ChgCharTo_EF_Pro(Class1.Chga_z_ToA_Z(strArray[0]));
    }

    private string Get5ToneTxDataStringPro()
    {
      string[] strArray1 = new string[16];
      string[] strArray2 = new string[16];
      for (int index1 = 0; index1 <= 15; ++index1)
      {
        if (this.dataGridView1.Rows[index1].Cells[1].Value == null)
          this.dataGridView1.Rows[index1].Cells[1].Value = (object) "";
        if (this.dataGridView1.Rows[index1].Cells[2].Value == null)
          this.dataGridView1.Rows[index1].Cells[2].Value = (object) "";
        if (this.dataGridView1.Rows[index1].Cells[3].Value == null)
          this.dataGridView1.Rows[index1].Cells[3].Value = (object) "";
        if (this.dataGridView1.Rows[index1].Cells[4].Value == null)
          this.dataGridView1.Rows[index1].Cells[4].Value = (object) "";
        string StrTemp1 = this.dataGridView1.Rows[index1].Cells[2].Value.ToString();
        strArray2[0] = Class2.ChgToDatPro(StrTemp1, 8, 0);
        string StrTemp2 = this.dataGridView1.Rows[index1].Cells[3].Value.ToString();
        int num1 = StrTemp2.Length >> 1;
        string str = Class1.StrAutoAdd0X20Pro(StrTemp2, 32);
        string StringTemp = this.dataGridView1.Rows[index1].Cells[1].Value.ToString();
        int num2 = 公共控件操作.GetCombo_XListPro_Eng_Ch(Class1.ConSigfTxKind_EngCh, StringTemp) << 5;
        int Data = num1 | num2;
        strArray2[1] = str + Class1.DataToHexStr((long) Data);
        string StrTemp3 = this.dataGridView1.Rows[index1].Cells[4].Value.ToString();
        int length = StrTemp3.Length;
        string acsPro = Class2.ChgStringToAcsPro(StrTemp3, 6);
        strArray2[2] = acsPro + Class1.DataToHexStr((long) length);
        strArray1[index1] = "";
        for (int index2 = 0; index2 <= 2; ++index2)
          strArray1[index1] = strArray1[index1] + strArray2[index2];
        strArray1[index1] = strArray1[index1] + "202020";
        if (index1 != 0)
          strArray1[0] = strArray1[0] + strArray1[index1];
      }
      return Class1.ChgCharTo_EF_Pro(Class1.Chga_z_ToA_Z(strArray1[0]));
    }

    private string Get5ToneRxDataStringPro()
    {
      string[] strArray1 = new string[16];
      string[] strArray2 = new string[16];
      for (int index1 = 0; index1 <= 7; ++index1)
      {
        if (this.dataGridView2.Rows[index1].Cells[1].Value == null)
          this.dataGridView2.Rows[index1].Cells[1].Value = (object) "";
        if (this.dataGridView2.Rows[index1].Cells[2].Value == null)
          this.dataGridView2.Rows[index1].Cells[2].Value = (object) "";
        if (this.dataGridView2.Rows[index1].Cells[3].Value == null)
          this.dataGridView2.Rows[index1].Cells[3].Value = (object) "";
        if (this.dataGridView2.Rows[index1].Cells[4].Value == null)
          this.dataGridView2.Rows[index1].Cells[4].Value = (object) "";
        string StringTemp1 = this.dataGridView2.Rows[index1].Cells[1].Value.ToString();
        int comboXlistProEngCh = 公共控件操作.GetCombo_XListPro_Eng_Ch(Ton5Menu1.Tone5DecodeK_EngCh, StringTemp1);
        string StringTemp2 = this.dataGridView2.Rows[index1].Cells[2].Value.ToString();
        int num = 公共控件操作.GetCombo_XListPro_Eng_Ch(Class1.ConAckKind_EngCh, StringTemp2) << 3;
        int Data = comboXlistProEngCh | num;
        strArray2[0] = Class1.DataToHexStr((long) Data);
        string StrTemp1 = this.dataGridView2.Rows[index1].Cells[3].Value.ToString();
        strArray2[1] = Class2.ChgToDatPro(StrTemp1, 12, 0);
        string StrTemp2 = this.dataGridView2.Rows[index1].Cells[4].Value.ToString();
        int length = StrTemp2.Length;
        string acsPro = Class2.ChgStringToAcsPro(StrTemp2, 6);
        strArray2[2] = acsPro + Class1.DataToHexStr((long) length);
        strArray1[index1] = "";
        for (int index2 = 0; index2 <= 2; ++index2)
          strArray1[index1] = strArray1[index1] + strArray2[index2];
        strArray1[index1] = strArray1[index1] + "20";
        if (index1 != 0)
          strArray1[0] = strArray1[0] + strArray1[index1];
      }
      return Class1.ChgCharTo_EF_Pro(Class1.Chga_z_ToA_Z(strArray1[0]));
    }

    private void Sav5ToneDataPro(string CurrStr)
    {
      string[] StrData = Class1.ReadFileDataPro(this.GiFileName2).Split('\r');
      int num1 = Class1.Tone5TxBegAddr / Class1.ConOneRowDatCt;
      string str1 = StrData[Class1.FielBegRow + num1];
      int num2 = Class1.FielBegRow + num1;
      for (int index = 0; index < 21; ++index)
      {
        StrData[num2 + index] = Class2.AutoAdd_n_Pro(StrData[num2 + index]);
        StrData[num2 + index] = StrData[num2 + index].Substring(0, 7) + CurrStr.Substring(64 * index, 64);
      }
      int num3 = Class1.ConSetBegAddr / Class1.ConOneRowDatCt;
      str1 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num3]);
      string aZ = Class1.Chga_z_ToA_Z(Convert.ToString(this.numericUpDown1.Value--));
      string str2 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num3]);
      StrData[Class1.FielBegRow + num3] = str2.Substring(0, 44) + aZ + str2.Substring(45, str2.Length - 45);
      Class1.SaveFileDataPro(this.GiFileName2, StrData);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      string[] strArray = new string[3]
      {
        this.Get5ToneTxDataStringPro(),
        this.Get5ToneSetDataStringPro(),
        this.Get5ToneRxDataStringPro()
      };
      this.Sav5ToneDataPro(strArray[0] + strArray[1] + strArray[2]);
      this.Close();
    }

    private void button4_Click(object sender, EventArgs e) => this.Close();

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void comboBox6_SelectedIndexChanged(object sender, EventArgs e) => this.DisTone5FrePro(this.comboBox6.SelectedIndex);

    private void CmbPttK_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (this.CmbPttK.SelectedIndex)
      {
        case 0:
          this.textBox3.Enabled = false;
          this.textBox5.Enabled = false;
          break;
        case 1:
          this.textBox5.Enabled = false;
          this.textBox3.Enabled = true;
          break;
        case 2:
          this.textBox5.Enabled = true;
          this.textBox3.Enabled = false;
          break;
        case 3:
          this.textBox3.Enabled = true;
          this.textBox5.Enabled = true;
          break;
      }
    }

    private void ComBoxAutoChgPro(ComboBox ComboBo, ComboBox ComboBo1, ComboBox ComboBo2)
    {
      if (ComboBo.SelectedIndex == ComboBo1.SelectedIndex)
      {
        if (ComboBo1.SelectedIndex <= 4)
          ++ComboBo1.SelectedIndex;
        else
          ComboBo1.SelectedIndex = 0;
        if (ComboBo2.SelectedIndex != ComboBo1.SelectedIndex)
          return;
        do
        {
          if (ComboBo2.SelectedIndex <= 4)
            ++ComboBo2.SelectedIndex;
          else
            ComboBo2.SelectedIndex = 0;
        }
        while (ComboBo.SelectedIndex == ComboBo2.SelectedIndex);
      }
      else
      {
        if (ComboBo.SelectedIndex != ComboBo2.SelectedIndex)
          return;
        if (ComboBo2.SelectedIndex <= 4)
          ++ComboBo2.SelectedIndex;
        else
          ComboBo2.SelectedIndex = 0;
        if (ComboBo2.SelectedIndex == ComboBo1.SelectedIndex)
        {
          do
          {
            if (ComboBo1.SelectedIndex <= 4)
              ++ComboBo1.SelectedIndex;
            else
              ComboBo1.SelectedIndex = 0;
          }
          while (ComboBo.SelectedIndex == ComboBo1.SelectedIndex);
        }
      }
    }

    private void CmbGroupCode_SelectedIndexChanged(object sender, EventArgs e) => this.ComBoxAutoChgPro(this.CmbGroupCode, this.comboBox5, this.CmbSepa);

    private void comboBox5_SelectedIndexChanged(object sender, EventArgs e) => this.ComBoxAutoChgPro(this.comboBox5, this.CmbGroupCode, this.CmbSepa);

    private void CmbSepa_SelectedIndexChanged(object sender, EventArgs e) => this.ComBoxAutoChgPro(this.CmbSepa, this.CmbGroupCode, this.comboBox5);

    private void comboBox1_Leave(object sender, EventArgs e)
    {
      int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
      this.GetComBoxTextToDataGridViewPro(this.comboBox1, this.dataGridView1, 1);
      if (!(this.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString() == ""))
        return;
      this.dataGridView1.Rows[rowIndex].Cells[2].Value = (object) "12345";
      if (this.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString() == "")
        this.dataGridView1.Rows[rowIndex].Cells[3].Value = (object) "313233343536";
      if (this.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString() == "")
        this.dataGridView1.Rows[rowIndex].Cells[4].Value = (object) ("5T-" + Class1.DataTo10Str((long) (rowIndex + 1)));
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this.dataGridView1.CurrentCell.ColumnIndex == 2)
      {
        bool flag = Class1.DtmfKeyUseFulChkPro(e.KeyChar);
        e.Handled = flag;
        if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
        {
          int num = (int) e.KeyChar - 32;
          e.KeyChar = (char) num;
        }
        if (e.KeyChar != '\r')
          return;
        this.textBox1.Visible = false;
        this.dataGridView1.CurrentCell = this.dataGridView1.CurrentRow.Cells[this.dataGridView1.SelectedCells[0].ColumnIndex + 1];
        this.dataGridView1.Focus();
      }
      else
      {
        if (this.dataGridView1.CurrentCell.ColumnIndex != 3 && this.dataGridView1.CurrentCell.ColumnIndex != 4)
          return;
        bool flag = Class1.AsciiKeyUseFulChkPro(e.KeyChar);
        e.KeyChar = Class1.ChgChar_a_z_ToA_Z(e.KeyChar);
        e.Handled = flag;
        if (e.KeyChar == '\r')
        {
          this.textBox1.Visible = false;
          if (this.dataGridView1.CurrentCell.ColumnIndex == 3)
            this.dataGridView1.CurrentCell = this.dataGridView1.CurrentRow.Cells[this.dataGridView1.SelectedCells[0].ColumnIndex + 1];
          this.dataGridView1.Focus();
        }
      }
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      string text = this.textBox1.Text;
      int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
      if (this.dataGridView1.CurrentCell.ColumnIndex != 2 && this.dataGridView1.CurrentCell.ColumnIndex != 3 && this.dataGridView1.CurrentCell.ColumnIndex != 4)
        return;
      this.textBox1.Visible = false;
      if (this.dataGridView1.CurrentCell.ColumnIndex == 2)
      {
        this.dataGridView1.Rows[rowIndex].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value = (object) text;
        if (this.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString() == "")
          this.dataGridView1.Rows[rowIndex].Cells[1].Value = (object) Class1.ConSigfTxKind_EngCh[Class1.English_En, 0];
        if (this.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString() == "")
          this.dataGridView1.Rows[rowIndex].Cells[4].Value = (object) ("5T-" + Class1.DataTo10Str((long) (rowIndex + 1)));
      }
      if (this.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString() == "")
      {
        this.dataGridView1.Rows[rowIndex].Cells[1].Value = (object) "";
        this.dataGridView1.Rows[rowIndex].Cells[3].Value = (object) "";
        this.dataGridView1.Rows[rowIndex].Cells[4].Value = (object) "";
      }
      else
        this.dataGridView1.Rows[rowIndex].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value = (object) text;
    }

    private void comboBox3_Leave(object sender, EventArgs e)
    {
      if (this.dataGridView2.Rows[this.dataGridView2.CurrentCell.RowIndex].Cells[3].Value.ToString() == "")
        return;
      this.GetComBoxTextToDataGridViewPro(this.comboBox3, this.dataGridView2, 2);
    }

    private void comboBox2_Leave(object sender, EventArgs e)
    {
      int rowIndex = this.dataGridView2.CurrentCell.RowIndex;
      this.GetComBoxTextToDataGridViewPro(this.comboBox2, this.dataGridView2, 1);
      try
      {
        if (!(this.dataGridView2.Rows[rowIndex].Cells[3].Value.ToString() == ""))
          return;
        this.dataGridView2.Rows[rowIndex].Cells[2].Value = (object) Class1.ConAckKind_EngCh[Class1.English_En, 1];
        this.dataGridView2.Rows[rowIndex].Cells[3].Value = (object) "123456789";
        if (this.dataGridView2.Rows[rowIndex].Cells[4].Value.ToString() == "")
          this.dataGridView2.Rows[rowIndex].Cells[4].Value = (object) ("5T-" + Class1.DataTo10Str((long) (rowIndex + 1)));
      }
      catch
      {
        this.dataGridView2.Rows[rowIndex].Cells[2].Value = (object) Class1.ConAckKind_EngCh[Class1.English_En, 1];
        this.dataGridView2.Rows[rowIndex].Cells[3].Value = (object) "123456789";
        this.dataGridView2.Rows[rowIndex].Cells[4].Value = (object) ("5T-" + Class1.DataTo10Str((long) (rowIndex + 1)));
      }
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this.dataGridView2.CurrentCell.ColumnIndex == 3)
      {
        bool flag = Class1.DtmfKeyUseFulChkPro(e.KeyChar);
        e.Handled = flag;
        if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
        {
          int num = (int) e.KeyChar - 32;
          e.KeyChar = (char) num;
        }
        switch (this.comboBox6.SelectedIndex)
        {
          case 3:
            if (e.KeyChar >= 'B' && e.KeyChar <= 'D' || e.KeyChar == 'F')
            {
              e.Handled = true;
              break;
            }
            break;
          case 5:
          case 7:
          case 8:
          case 13:
            if (e.KeyChar == 'F')
            {
              e.Handled = true;
              break;
            }
            break;
          case 10:
          case 12:
            if (e.KeyChar >= 'A' && e.KeyChar <= 'D' || e.KeyChar == 'F')
            {
              e.Handled = true;
              break;
            }
            break;
        }
        if (e.KeyChar != '\r')
          return;
        this.textBox2.Visible = false;
        this.dataGridView1.CurrentCell = this.dataGridView1.CurrentRow.Cells[this.dataGridView1.SelectedCells[0].ColumnIndex + 1];
        this.dataGridView1.Focus();
      }
      else
      {
        if (this.dataGridView2.CurrentCell.ColumnIndex != 4)
          return;
        bool flag = Class1.AsciiKeyUseFulChkPro(e.KeyChar);
        e.KeyChar = Class1.ChgChar_a_z_ToA_Z(e.KeyChar);
        e.Handled = flag;
        if (e.KeyChar == '\r')
        {
          this.textBox2.Visible = false;
          if (this.dataGridView2.CurrentCell.ColumnIndex == 3)
            this.dataGridView2.CurrentCell = this.dataGridView2.CurrentRow.Cells[this.dataGridView2.SelectedCells[0].ColumnIndex + 1];
          this.dataGridView2.Focus();
        }
      }
    }

    private void textBox2_Leave(object sender, EventArgs e)
    {
      string text = this.textBox2.Text;
      int rowIndex = this.dataGridView2.CurrentCell.RowIndex;
      if (this.dataGridView2.CurrentCell.ColumnIndex == 3)
      {
        if (text == "")
        {
          this.dataGridView2.Rows[rowIndex].Cells[1].Value = (object) "";
          this.dataGridView2.Rows[rowIndex].Cells[2].Value = (object) "";
          this.dataGridView2.Rows[rowIndex].Cells[4].Value = (object) "";
        }
        else if (this.dataGridView2.Rows[rowIndex].Cells[3].Value.ToString() == "")
        {
          this.dataGridView2.Rows[rowIndex].Cells[1].Value = (object) Ton5Menu1.Tone5DecodeK_EngCh[Class1.English_En, 1];
          this.dataGridView2.Rows[rowIndex].Cells[2].Value = (object) Class1.ConAckKind_EngCh[Class1.English_En, 1];
          this.dataGridView2.Rows[rowIndex].Cells[4].Value = (object) ("5T-" + Class1.DataTo10Str((long) (rowIndex + 1)));
        }
      }
      if (this.dataGridView2.CurrentCell.ColumnIndex != 3 && this.dataGridView2.CurrentCell.ColumnIndex != 4)
        return;
      this.textBox2.Visible = false;
      this.dataGridView2.Rows[rowIndex].Cells[this.dataGridView2.CurrentCell.ColumnIndex].Value = (object) text;
      if (this.dataGridView2.CurrentCell.ColumnIndex == 3 && text == "")
      {
        this.dataGridView2.Rows[rowIndex].Cells[1].Value = (object) "";
        this.dataGridView2.Rows[rowIndex].Cells[2].Value = (object) "";
        this.dataGridView2.Rows[rowIndex].Cells[4].Value = (object) "";
      }
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e) => 公共控件操作.numericUpDown_ValueChanged(this.numericUpDown2);

    private void numericUpDown1_ValueChanged(object sender, EventArgs e) => 公共控件操作.numericUpDown_ValueChanged(this.numericUpDown1);

    private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool flag = Class1.KeyUseFul0_9ChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar != '\r')
        return;
      this.button1.Focus();
    }

    private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool flag = Class1.DtmfKeyUseFulChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar < 'a' || e.KeyChar > 'z')
        return;
      int num = (int) e.KeyChar - 32;
      e.KeyChar = (char) num;
    }

    private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool flag = Class1.DtmfKeyUseFulChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar < 'a' || e.KeyChar > 'z')
        return;
      int num = (int) e.KeyChar - 32;
      e.KeyChar = (char) num;
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
    }
  }
}
