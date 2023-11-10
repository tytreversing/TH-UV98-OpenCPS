// Decompiled with JetBrains decompiler
// Type: _8890DTest.DtmfMenu
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class DtmfMenu : Form
  {
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private DataGridView dataGridView1;
    private ComboBox comboBox1;
    private TextBox textBox1;
    private GroupBox groupBox2;
    private TextBox textBox3;
    private TextBox textBox2;
    private GroupBox groupBox3;
    private ComboBox CmbPttK;
    private TextBox textBox6;
    private TextBox textBox5;
    private Label label9;
    private Label label16;
    private Label label15;
    private Label label14;
    private Label label6;
    private Button button1;
    private Button button2;
    private GroupBox groupBox4;
    private CheckBox checkBox1;
    private ComboBox CmbFirTm;
    private ComboBox CmbSendTm;
    private ComboBox CmbGroupCode;
    private ComboBox CmbSepa;
    private ComboBox CmbAckK;
    private TextBox textBox4;
    private Label label13;
    private Label label11;
    private Label label8;
    private Label label4;
    private Label label3;
    private ComboBox CmbResTm;
    private Label label2;
    private Label label1;
    private NumericUpDown numericUpDown1;
    private Label label7;
    private CheckBox checkBox2;
    public string GiFileName2 = "8890D_TempFile.icf";
    public static string[,] DataGridName = new string[2, 3]
    {
      {
        "组别",
        "类型",
        "编码"
      },
      {
        "No. ",
        "  Type",
        "Code"
      }
    };
    public static string[,] lableArrName = new string[2, 13]
    {
      {
        "本机ID码",
        "      解码响应",
        "   分隔符",
        "   组呼码",
        "DTMF发送时间(MS)",
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
        "  Own ID",
        "Decode Reponse",
        "Delimiter",
        "Group Code",
        "  Dtmf Speed(MS)",
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
    public static string[,] ChekcBox_EngCh = new string[2, 2]
    {
      {
        "DTMF ANI",
        "侧音     "
      },
      {
        "DTMF ANI",
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
    public static string[,] CmbGroupCode_EngCh = new string[2, 1]
    {
      {
        "无"
      },
      {
        "OFF"
      }
    };
    public static string[,] GroupBox_EngCh = new string[2, 2]
    {
      {
        "Dtmf编码",
        "Dtmf 设置"
      },
      {
        "Dtmf Encode",
        "Dtmf Setting"
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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.textBox1 = new TextBox();
      this.comboBox1 = new ComboBox();
      this.dataGridView1 = new DataGridView();
      this.groupBox2 = new GroupBox();
      this.groupBox4 = new GroupBox();
      this.checkBox2 = new CheckBox();
      this.numericUpDown1 = new NumericUpDown();
      this.label7 = new Label();
      this.checkBox1 = new CheckBox();
      this.CmbFirTm = new ComboBox();
      this.CmbSendTm = new ComboBox();
      this.CmbGroupCode = new ComboBox();
      this.CmbSepa = new ComboBox();
      this.CmbAckK = new ComboBox();
      this.textBox4 = new TextBox();
      this.label13 = new Label();
      this.label11 = new Label();
      this.label8 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.CmbResTm = new ComboBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.groupBox3 = new GroupBox();
      this.CmbPttK = new ComboBox();
      this.textBox6 = new TextBox();
      this.textBox5 = new TextBox();
      this.label9 = new Label();
      this.label16 = new Label();
      this.label15 = new Label();
      this.label14 = new Label();
      this.label6 = new Label();
      this.textBox2 = new TextBox();
      this.textBox3 = new TextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.groupBox2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.numericUpDown1.BeginInit();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Controls.Add((Control) this.comboBox1);
      this.groupBox1.Controls.Add((Control) this.dataGridView1);
      this.groupBox1.Location = new Point(-1, 1);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(382, 436);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "DTMF 编码";
      this.textBox1.Location = new Point(224, 276);
      this.textBox1.MaxLength = 24;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 21);
      this.textBox1.TabIndex = 2;
      this.textBox1.TextAlign = HorizontalAlignment.Center;
      this.textBox1.Leave += new EventHandler(this.textBox1_Leave);
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(224, 229);
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
      this.groupBox2.Controls.Add((Control) this.groupBox4);
      this.groupBox2.Controls.Add((Control) this.groupBox3);
      this.groupBox2.Location = new Point(387, 1);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(490, 436);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Dtmf 设置";
      this.groupBox2.Enter += new EventHandler(this.groupBox2_Enter);
      this.groupBox4.Controls.Add((Control) this.checkBox2);
      this.groupBox4.Controls.Add((Control) this.numericUpDown1);
      this.groupBox4.Controls.Add((Control) this.label7);
      this.groupBox4.Controls.Add((Control) this.checkBox1);
      this.groupBox4.Controls.Add((Control) this.CmbFirTm);
      this.groupBox4.Controls.Add((Control) this.CmbSendTm);
      this.groupBox4.Controls.Add((Control) this.CmbGroupCode);
      this.groupBox4.Controls.Add((Control) this.CmbSepa);
      this.groupBox4.Controls.Add((Control) this.CmbAckK);
      this.groupBox4.Controls.Add((Control) this.textBox4);
      this.groupBox4.Controls.Add((Control) this.label13);
      this.groupBox4.Controls.Add((Control) this.label11);
      this.groupBox4.Controls.Add((Control) this.label8);
      this.groupBox4.Controls.Add((Control) this.label4);
      this.groupBox4.Controls.Add((Control) this.label3);
      this.groupBox4.Controls.Add((Control) this.CmbResTm);
      this.groupBox4.Controls.Add((Control) this.label2);
      this.groupBox4.Controls.Add((Control) this.label1);
      this.groupBox4.Location = new Point(17, 20);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(462, 214);
      this.groupBox4.TabIndex = 28;
      this.groupBox4.TabStop = false;
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new Point(253, 164);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(72, 16);
      this.checkBox2.TabIndex = 4;
      this.checkBox2.Text = "DTMF ANI";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.numericUpDown1.Location = new Point(408, 179);
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
      this.numericUpDown1.TabIndex = 45;
      this.numericUpDown1.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
      this.label7.AutoSize = true;
      this.label7.Location = new Point(343, 188);
      this.label7.Name = "label7";
      this.label7.Size = new Size(59, 12);
      this.label7.TabIndex = 44;
      this.label7.Text = " 选定信道";
      this.label7.Click += new EventHandler(this.label7_Click);
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(253, 186);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(78, 16);
      this.checkBox1.TabIndex = 43;
      this.checkBox1.Text = "侧音     ";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.CmbFirTm.FormattingEnabled = true;
      this.CmbFirTm.Location = new Point(348, 87);
      this.CmbFirTm.Name = "CmbFirTm";
      this.CmbFirTm.Size = new Size(100, 20);
      this.CmbFirTm.TabIndex = 42;
      this.CmbSendTm.FormattingEnabled = true;
      this.CmbSendTm.Location = new Point(348, 49);
      this.CmbSendTm.Name = "CmbSendTm";
      this.CmbSendTm.Size = new Size(100, 20);
      this.CmbSendTm.TabIndex = 41;
      this.CmbGroupCode.FormattingEnabled = true;
      this.CmbGroupCode.Location = new Point(103, 116);
      this.CmbGroupCode.Name = "CmbGroupCode";
      this.CmbGroupCode.Size = new Size(100, 20);
      this.CmbGroupCode.TabIndex = 40;
      this.CmbGroupCode.SelectedIndexChanged += new EventHandler(this.CmbGroupCode_SelectedIndexChanged);
      this.CmbSepa.FormattingEnabled = true;
      this.CmbSepa.Location = new Point(103, 83);
      this.CmbSepa.Name = "CmbSepa";
      this.CmbSepa.Size = new Size(100, 20);
      this.CmbSepa.TabIndex = 39;
      this.CmbSepa.SelectedIndexChanged += new EventHandler(this.CmbSepa_SelectedIndexChanged);
      this.CmbAckK.FormattingEnabled = true;
      this.CmbAckK.Location = new Point(103, 151);
      this.CmbAckK.Name = "CmbAckK";
      this.CmbAckK.Size = new Size(100, 20);
      this.CmbAckK.TabIndex = 38;
      this.textBox4.Location = new Point(103, 51);
      this.textBox4.MaxLength = 5;
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(100, 21);
      this.textBox4.TabIndex = 37;
      this.textBox4.KeyPress += new KeyPressEventHandler(this.textBox4_KeyPress);
      this.label13.AutoSize = true;
      this.label13.Location = new Point(231, 133);
      this.label13.Name = "label13";
      this.label13.Size = new Size(113, 12);
      this.label13.TabIndex = 36;
      this.label13.Text = "   自动复位时间(S)";
      this.label11.AutoSize = true;
      this.label11.Location = new Point(243, 90);
      this.label11.Name = "label11";
      this.label11.Size = new Size(101, 12);
      this.label11.TabIndex = 35;
      this.label11.Text = "首位数码时间(MS)";
      this.label8.AutoSize = true;
      this.label8.Location = new Point(38, 124);
      this.label8.Name = "label8";
      this.label8.Size = new Size(59, 12);
      this.label8.TabIndex = 34;
      this.label8.Text = "   组呼码";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(38, 88);
      this.label4.Name = "label4";
      this.label4.Size = new Size(59, 12);
      this.label4.TabIndex = 32;
      this.label4.Text = "   分隔符";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(241, 57);
      this.label3.Name = "label3";
      this.label3.Size = new Size(101, 12);
      this.label3.TabIndex = 31;
      this.label3.Text = "DTMF发送时间(MS)";
      this.CmbResTm.FormattingEnabled = true;
      this.CmbResTm.Location = new Point(348, 125);
      this.CmbResTm.Name = "CmbResTm";
      this.CmbResTm.Size = new Size(100, 20);
      this.CmbResTm.TabIndex = 30;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(8, 159);
      this.label2.Name = "label2";
      this.label2.Size = new Size(89, 12);
      this.label2.TabIndex = 29;
      this.label2.Text = "      解码响应";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(44, 60);
      this.label1.Name = "label1";
      this.label1.Size = new Size(53, 12);
      this.label1.TabIndex = 28;
      this.label1.Text = "本机ID码";
      this.label1.Click += new EventHandler(this.label1_Click);
      this.groupBox3.Controls.Add((Control) this.CmbPttK);
      this.groupBox3.Controls.Add((Control) this.textBox6);
      this.groupBox3.Controls.Add((Control) this.textBox5);
      this.groupBox3.Controls.Add((Control) this.label9);
      this.groupBox3.Controls.Add((Control) this.label16);
      this.groupBox3.Controls.Add((Control) this.label15);
      this.groupBox3.Controls.Add((Control) this.label14);
      this.groupBox3.Controls.Add((Control) this.label6);
      this.groupBox3.Controls.Add((Control) this.textBox2);
      this.groupBox3.Controls.Add((Control) this.textBox3);
      this.groupBox3.Location = new Point(17, 256);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(462, 174);
      this.groupBox3.TabIndex = 20;
      this.groupBox3.TabStop = false;
      this.CmbPttK.FormattingEnabled = true;
      this.CmbPttK.Location = new Point(159, 21);
      this.CmbPttK.Name = "CmbPttK";
      this.CmbPttK.Size = new Size(100, 20);
      this.CmbPttK.TabIndex = 27;
      this.CmbPttK.SelectedIndexChanged += new EventHandler(this.CmbPttK_SelectedIndexChanged);
      this.textBox6.Location = new Point(159, 137);
      this.textBox6.MaxLength = 15;
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(211, 21);
      this.textBox6.TabIndex = 26;
      this.textBox6.KeyPress += new KeyPressEventHandler(this.textBox6_KeyPress);
      this.textBox5.Location = new Point(159, 107);
      this.textBox5.MaxLength = 15;
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(211, 21);
      this.textBox5.TabIndex = 25;
      this.textBox5.KeyPress += new KeyPressEventHandler(this.textBox5_KeyPress);
      this.label9.AutoSize = true;
      this.label9.Location = new Point(82, 28);
      this.label9.Name = "label9";
      this.label9.Size = new Size(71, 12);
      this.label9.TabIndex = 24;
      this.label9.Text = "PTT ID 类型";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(94, 140);
      this.label16.Name = "label16";
      this.label16.Size = new Size(59, 12);
      this.label16.TabIndex = 23;
      this.label16.Text = "   遥毙码";
      this.label15.AutoSize = true;
      this.label15.Location = new Point(82, 83);
      this.label15.Name = "label15";
      this.label15.Size = new Size(71, 12);
      this.label15.TabIndex = 22;
      this.label15.Text = "PTT ID 结束";
      this.label14.AutoSize = true;
      this.label14.Location = new Point(76, 54);
      this.label14.Name = "label14";
      this.label14.Size = new Size(77, 12);
      this.label14.TabIndex = 21;
      this.label14.Text = " PTT ID 开始";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(94, 110);
      this.label6.Name = "label6";
      this.label6.Size = new Size(59, 12);
      this.label6.TabIndex = 20;
      this.label6.Text = "   遥晕码";
      this.textBox2.Location = new Point(159, 45);
      this.textBox2.MaxLength = 24;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(211, 21);
      this.textBox2.TabIndex = 4;
      this.textBox2.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
      this.textBox3.Location = new Point(159, 74);
      this.textBox3.MaxLength = 24;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(211, 21);
      this.textBox3.TabIndex = 5;
      this.textBox3.KeyPress += new KeyPressEventHandler(this.textBox3_KeyPress);
      this.button1.Location = new Point(291, 443);
      this.button1.Name = "button1";
      this.button1.Size = new Size(96, 47);
      this.button1.TabIndex = 2;
      this.button1.Text = "确 定";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(430, 443);
      this.button2.Name = "button2";
      this.button2.Size = new Size(94, 47);
      this.button2.TabIndex = 3;
      this.button2.Text = "取 消";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(884, 538);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = nameof (DtmfMenu);
      this.Text = "DTMF MENU ";
      this.Load += new EventHandler(this.DtmfMenu_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.numericUpDown1.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
    }

    public DtmfMenu()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void DataGridViewColumnAddPro(DataGridViewTextBoxColumn acCode, string name)
    {
      acCode.HeaderText = name;
      acCode.Width = 60;
      acCode.Name = "item";
      acCode.DataPropertyName = "item";
      acCode.ReadOnly = true;
      acCode.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.dataGridView1.Columns.Add((DataGridViewColumn) acCode);
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
      this.DataGridViewColumnAddPro(acCode1, DtmfMenu.DataGridName[Class1.English_En, 0]);
      this.DataGridViewColumnAddPro(acCode2, DtmfMenu.DataGridName[Class1.English_En, 1]);
      this.DataGridViewColumnAddPro(acCode3, DtmfMenu.DataGridName[Class1.English_En, 2]);
      acCode2.Width = 70;
      acCode3.Width = 250;
      this.dataGridView1.Rows.Add(15);
      for (int index = 0; index <= 15; ++index)
      {
        this.dataGridView1.Rows[index].Cells[0].Value = (object) (index + 1);
        this.dataGridView1.Rows[index].Cells[1].Value = (object) Class1.ConSigfTxKind_EngCh[Class1.English_En, 0];
        this.dataGridView1.Rows[index].Cells[2].Value = (object) "";
      }
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
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox1, Class1.ConSigfTxKind_EngCh, Class1.ConSigfTxKind_EngCh.GetLength(1) - 1);
      this.comboBox1.Visible = false;
      this.TextBoxResPro(this.textBox1, 24, "");
      this.textBox1.Visible = false;
      this.loadDataGridViewPro();
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

    private void CmbAdd_50_500MS_Pro(ComboBox cmbHelp)
    {
      cmbHelp.Items.Add((object) "50");
      cmbHelp.Items.Add((object) "100");
      cmbHelp.Items.Add((object) "200");
      cmbHelp.Items.Add((object) "300");
      cmbHelp.Items.Add((object) "500");
    }

    private void CmbAdd_0_1S_Pro(ComboBox cmbHelp)
    {
      for (int index = 0; index <= 10; ++index)
        cmbHelp.Items.Add((object) (index * 100));
    }

    private void CmbAdd_0_25S_Pro(ComboBox cmbHelp)
    {
      for (int index = 0; index <= 25; ++index)
        cmbHelp.Items.Add((object) index);
    }

    private void load_CmbSepaKPro() => 公共控件操作.Load_CmbBoxNPro(this.CmbSepa, 公共控件操作.ConSpeChar, 5);

    private void load_CmbGroupCodePro()
    {
      this.CmbGroupCode.Items.Add((object) DtmfMenu.CmbGroupCode_EngCh[Class1.English_En, 0]);
      公共控件操作.Load_CmbBoxNPro(this.CmbGroupCode, 公共控件操作.ConSpeChar, 5);
    }

    private void load_CmbSendTmPro()
    {
      this.CmbAdd_50_500MS_Pro(this.CmbSendTm);
      this.ComBoxResPro(this.CmbSendTm, 1);
    }

    private void load_CmbFirTmPro()
    {
      this.CmbAdd_0_1S_Pro(this.CmbFirTm);
      this.ComBoxResPro(this.CmbFirTm, 2);
    }

    private void load_CmbResTmPro()
    {
      this.CmbAdd_0_25S_Pro(this.CmbResTm);
      this.ComBoxResPro(this.CmbResTm, 10);
    }

    private void load_GroBox1_LabelPro()
    {
      for (int index = 0; index <= 12; ++index)
        this.Label_Arr[index].Text = DtmfMenu.lableArrName[Class1.English_En, index];
    }

    private void load_GroBox1_CheckBoxPro()
    {
      for (int index = 0; index <= 1; ++index)
        this.CheckBox_Arr[index].Text = DtmfMenu.ChekcBox_EngCh[Class1.English_En, index];
    }

    private void load_GroBox1_ButtonPro()
    {
      for (int index = 0; index <= 1; ++index)
        this.Button_Arr[index].Text = DtmfMenu.Button_EngCh[Class1.English_En, index];
    }

    private void load_GroBox1_comboBoxPro()
    {
      公共控件操作.load_CmbBoxNProEng_Ch1(this.CmbAckK, Class1.ConAckKind_EngCh, Class1.ConAckKind_EngCh.GetLength(1) - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.CmbPttK, Class1.PttKind_EngCh, Class1.PttKind_EngCh.GetLength(1) - 1);
      this.load_CmbSepaKPro();
      this.load_CmbGroupCodePro();
      this.load_CmbSendTmPro();
      this.load_CmbFirTmPro();
      this.load_CmbResTmPro();
    }

    private void load_GroupBox2Pro()
    {
      this.load_GroBox1_LabelPro();
      this.load_GroBox1_CheckBoxPro();
      this.load_GroBox1_ButtonPro();
      this.load_GroBox1_comboBoxPro();
      公共控件操作.numericUpDownXRes(this.numericUpDown1, 17, 0, 1);
      this.TextBoxResPro(this.textBox4, 8, "12345");
      this.TextBoxResPro(this.textBox2, 24, "123456789012345678901234");
      this.textBox2.Enabled = false;
      this.TextBoxResPro(this.textBox3, 24, "123456789012345678901234");
      this.textBox3.Enabled = false;
      this.TextBoxResPro(this.textBox5, 15, "123456789012345");
      this.TextBoxResPro(this.textBox6, 15, "12345ACD89012345");
      this.checkBox1.Checked = true;
    }

    private string GetOneDtmfChStringPro(string[] n, int i)
    {
      int num = Class1.ConDtmfChBegAddr / Class1.ConOneRowDatCt + Class1.ConOneDtmfChDatCt * i / Class1.ConOneRowDatCt;
      string str1 = n[Class1.FielBegRow + num];
      string str2 = str1.Substring(Class1.ConUseChDatSta + 1, str1.Length - Class1.ConUseChDatSta - 1);
      string str3 = n[Class1.FielBegRow + num + 1];
      return (str2 + str3.Substring(Class1.ConUseChDatSta + 1, str3.Length - Class1.ConUseChDatSta - 1)).Substring(Class1.ConOneDtmfChDatCt * i % Class1.ConOneRowDatCt << 1, 2 * Class1.ConOneDtmfChDatCt);
    }

    private void DisDtmfSetDataPro(string Datastr)
    {
      string str1 = Datastr.Substring(0, 2);
      string str2 = Datastr.Substring(2, 2);
      string str3 = Datastr.Substring(4, 2);
      string str4 = Datastr.Substring(8, 2);
      Datastr.Substring(14, 4);
      string str5 = Datastr.Substring(18, 10);
      string str6 = Datastr.Substring(32, 26);
      string str7 = Datastr.Substring(64, 26);
      string str8 = Datastr.Substring(96, 16);
      string str9 = Datastr.Substring(112, 16);
      try
      {
        int int32_1 = Convert.ToInt32(str1, 16);
        this.checkBox2.Checked = 0 != (int32_1 & 1);
        this.CmbSendTm.SelectedIndex = (int32_1 & 14) >> 1;
        this.CmbSepa.SelectedIndex = (int32_1 & 112) >> 4;
        this.checkBox1.Checked = 0 != (int32_1 & 128);
        int int32_2 = Convert.ToInt32(str2, 16);
        this.CmbGroupCode.SelectedIndex = int32_2 & 7;
        this.CmbAckK.SelectedIndex = (int32_2 & 24) >> 3;
        this.CmbPttK.SelectedIndex = (int32_2 & 96) >> 5;
        this.CmbFirTm.SelectedIndex = Convert.ToInt32(str3, 16) & 15;
        this.CmbResTm.SelectedIndex = Convert.ToInt32(str4, 16) & 31;
        int int32_3 = Convert.ToInt32(str5.Substring(9, 1), 16);
        this.textBox4.Text = str5.Substring(0, int32_3);
        int length1 = Convert.ToInt32(str6.Substring(24, 2), 16) & 31;
        this.textBox2.Text = str6.Replace("E", "*").Replace("F", "#").Substring(0, length1);
        int length2 = Convert.ToInt32(str7.Substring(24, 2), 16) & 31;
        this.textBox3.Text = str7.Replace("E", "*").Replace("F", "#").Substring(0, length2);
        int int32_4 = Convert.ToInt32(str8.Substring(15, 1), 16);
        this.textBox5.Text = str8.Replace("E", "*").Replace("F", "#").Substring(0, int32_4);
        int int32_5 = Convert.ToInt32(str9.Substring(15, 1), 16);
        this.textBox6.Text = str9.Replace("E", "*").Replace("F", "#").Substring(0, int32_5);
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 2], Class1.RadioName);
      }
    }

    private void DisDtmfChDataPro(string[] DtmfCh)
    {
      try
      {
        for (int index = 0; index <= 15; ++index)
        {
          if (!(index > 7 ? Class2.UseFulChkPro(DtmfCh[17], index - 8) : Class2.UseFulChkPro(DtmfCh[16], index)))
          {
            this.dataGridView1.Rows[index].Cells[1].Value = (object) "";
            this.dataGridView1.Rows[index].Cells[2].Value = (object) "";
          }
          else
          {
            int int32 = Convert.ToInt32(DtmfCh[index].Substring(24, 2), 16);
            int length = int32 & 31;
            string charPro = Class1.Chg_EF_ToCharPro(DtmfCh[index].Substring(0, length));
            this.dataGridView1.Rows[index].Cells[2].Value = (object) charPro;
            if (length == 0)
            {
              this.dataGridView1.Rows[index].Cells[1].Value = (object) "";
            }
            else
            {
              int num = (int32 & 96) >> 5;
              if (0 == num)
                this.dataGridView1.Rows[index].Cells[1].Value = (object) Class1.ConSigfTxKind_EngCh[Class1.English_En, 0];
              else if (1 == num)
                this.dataGridView1.Rows[index].Cells[1].Value = (object) Class1.ConSigfTxKind_EngCh[Class1.English_En, 1];
            }
          }
        }
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 2], Class1.RadioName);
      }
    }

    private void LoadDtmfFileDataDisPro()
    {
      try
      {
        string[] n = Class1.ReadFileDataPro(this.GiFileName2).Split('\r');
        string[] DtmfCh = new string[18];
        for (int i = 0; i <= 15; ++i)
          DtmfCh[i] = this.GetOneDtmfChStringPro(n, i);
        int num1 = Class1.ConDtmfSetAddr / Class1.ConOneRowDatCt;
        string str1 = Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num1]);
        string str2 = str1.Substring(Class1.ConUseChDatSta + 1, str1.Length - Class1.ConUseChDatSta - 1);
        string str3 = Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num1 + 1]);
        string Datastr = (str2 + str3.Substring(Class1.ConUseChDatSta + 1, str3.Length - Class1.ConUseChDatSta - 1)).Substring(Class1.ConDtmfSetAddr % Class1.ConOneRowDatCt << 1, 128);
        this.DisDtmfSetDataPro(Datastr);
        DtmfCh[16] = Datastr.Substring(14, 2);
        DtmfCh[17] = Datastr.Substring(16, 2);
        int num2 = Class1.ConSetBegAddr / Class1.ConOneRowDatCt;
        this.numericUpDown1.Value = (Decimal) (Convert.ToInt32(Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num2]).Substring(45, 1), 16) + 1);
        this.DisDtmfChDataPro(DtmfCh);
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 2], Class1.RadioName);
      }
    }

    private void SetContrlAs_arrPro()
    {
      this.Label_Arr = new Label[23];
      this.Label_Arr[0] = this.label1;
      this.Label_Arr[1] = this.label2;
      this.Label_Arr[2] = this.label4;
      this.Label_Arr[3] = this.label8;
      this.Label_Arr[4] = this.label3;
      this.Label_Arr[5] = this.label11;
      this.Label_Arr[6] = this.label13;
      this.Label_Arr[7] = this.label7;
      this.Label_Arr[8] = this.label9;
      this.Label_Arr[9] = this.label14;
      this.Label_Arr[10] = this.label15;
      this.Label_Arr[11] = this.label6;
      this.Label_Arr[12] = this.label16;
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
      this.CheckBox_Arr[0] = this.checkBox2;
      this.CheckBox_Arr[1] = this.checkBox1;
      this.GroupBox_Arr = new GroupBox[3];
      this.GroupBox_Arr[0] = this.groupBox1;
      this.GroupBox_Arr[1] = this.groupBox2;
      this.Button_Arr = new Button[2];
      this.Button_Arr[0] = this.button1;
      this.Button_Arr[1] = this.button2;
    }

    private void DtmfMenu_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.SetContrlAs_arrPro();
      this.load_GroupBox1Pro();
      this.load_GroupBox2Pro();
      for (int index = 0; index <= 1; ++index)
        this.GroupBox_Arr[index].Text = DtmfMenu.GroupBox_EngCh[Class1.English_En, index];
      this.LoadDtmfFileDataDisPro();
      this.CmbAckK.Visible = false;
      this.label2.Visible = false;
    }

    private string GetCurrCellText()
    {
      string currCellText;
      try
      {
        currCellText = this.dataGridView1[this.dataGridView1.SelectedCells[0].ColumnIndex, this.dataGridView1.SelectedCells[0].RowIndex].Value.ToString();
      }
      catch
      {
        currCellText = "";
      }
      return currCellText;
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
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
        string currCellText = this.GetCurrCellText();
        this.comboBox1.SelectedIndex = 公共控件操作.GetCombo_XListPro_Eng_Ch(Class1.ConSigfTxKind_EngCh, currCellText);
      }
      else if (2 == this.dataGridView1.CurrentCell.ColumnIndex)
      {
        int rowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
        int columnIndex = this.dataGridView1.SelectedCells[0].ColumnIndex;
        string str = this.dataGridView1[1, rowIndex].Value.ToString();
        this.comboBox1.Visible = false;
        if (str == Class1.ConSigfTxKind_EngCh[Class1.English_En, 0])
        {
          Rectangle displayRectangle = this.dataGridView1.GetCellDisplayRectangle(this.dataGridView1.CurrentCell.ColumnIndex, this.dataGridView1.CurrentCell.RowIndex, false);
          this.textBox1.Left = displayRectangle.Left + 3;
          this.textBox1.Top = displayRectangle.Top + 17;
          this.textBox1.Width = displayRectangle.Width;
          this.textBox1.Height = displayRectangle.Height;
          this.textBox1.Visible = true;
          this.textBox1.Focus();
          this.textBox1.Text = this.GetCurrCellText();
        }
        else
        {
          if (!(str == Class1.ConSigfTxKind_EngCh[Class1.English_En, 1]))
            return;
          string StrTemp = this.dataGridView1[2, rowIndex].Value.ToString();
          特叫类型 特叫类型 = new 特叫类型();
          特叫类型.GiCurrCh = rowIndex;
          特叫类型.MaxLength = 4;
          特叫类型.OwnId_String = this.textBox4.Text;
          特叫类型.Spilt_String = this.CmbSepa.Text;
          int length = Class1.LookStringPt(StrTemp, this.CmbSepa.Text);
          if (str == Class1.ConSigfTxKind_EngCh[Class1.English_En, 1])
          {
            特叫类型.GiKind = 1;
            特叫类型.CallId_String = length != -1 ? StrTemp.Substring(0, length) : "";
          }
          else if (str == Class1.ConSigfTxKind_EngCh[Class1.English_En, 2])
          {
            特叫类型.GiKind = 2;
            if (length == -1)
            {
              特叫类型.CallId_String = "";
            }
            else
            {
              特叫类型.CallId_String = StrTemp.Substring(0, length);
              string CharData = this.CmbSepa.Text + this.CmbSepa.Text;
              int num = Class1.LookStringPt(StrTemp, CharData);
              if (num == -1)
              {
                特叫类型.Inf_String = "";
              }
              else
              {
                特叫类型.Inf_String = StrTemp.Substring(num + 2, StrTemp.Length - num - 2);
                特叫类型.Inf_String = 特叫类型.Inf_String.Replace("*", "E");
                特叫类型.Inf_String = 特叫类型.Inf_String.Replace("#", "F");
              }
            }
          }
          int num1 = (int) 特叫类型.ShowDialog((IWin32Window) this);
          特叫类型.Dispose();
          this.dataGridView1[2, rowIndex].Value = (object) Class1.GiDailData;
        }
      }
      else
      {
        this.textBox1.Visible = false;
        this.comboBox1.Visible = false;
      }
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e) => this.Close();

    private string GetDtmfChUseFulStringPro()
    {
      int[] numArray = new int[2];
      string StrData = "";
      for (int index = 0; index <= 15; ++index)
      {
        if (this.dataGridView1.Rows[index].Cells[2].Value == null)
          this.dataGridView1.Rows[index].Cells[2].Value = (object) "";
        StrData = !(this.dataGridView1.Rows[index].Cells[2].Value.ToString() == "") ? StrData + "1" : StrData + "0";
      }
      return Class2.GetChUseFulStringPro(16, StrData);
    }

    private string GetDtmfSetDataStringPro()
    {
      string[] strArray = new string[14];
      int Data1 = Class2.ChgBoolToDatPro(this.checkBox2.Checked) | this.CmbSendTm.SelectedIndex << 1 | this.CmbSepa.SelectedIndex << 4 | Class2.ChgBoolToDatPro(this.checkBox1.Checked) << 7;
      strArray[0] = Class1.DataToHexStr((long) Data1);
      int Data2 = this.CmbGroupCode.SelectedIndex | this.CmbAckK.SelectedIndex << 3 | this.CmbPttK.SelectedIndex << 5;
      strArray[1] = Class1.DataToHexStr((long) Data2);
      int selectedIndex1 = this.CmbFirTm.SelectedIndex;
      strArray[2] = Class1.DataToHexStr((long) selectedIndex1);
      strArray[3] = "F0";
      int selectedIndex2 = this.CmbResTm.SelectedIndex;
      strArray[4] = Class1.DataToHexStr((long) selectedIndex2);
      strArray[5] = "F0";
      strArray[6] = "05";
      strArray[7] = this.GetDtmfChUseFulStringPro();
      strArray[9] = Class2.ChgToDatPro(this.textBox4.Text, 8, 0);
      strArray[9] = strArray[9] + "2020";
      strArray[10] = Class2.ChgToDatPro(this.textBox2.Text, 24, 0);
      strArray[10] = strArray[10] + "202020";
      strArray[11] = Class2.ChgToDatPro(this.textBox3.Text, 24, 0);
      strArray[11] = strArray[11] + "202020";
      strArray[12] = Class2.ChgToDatPro(this.textBox5.Text, 15, 4);
      strArray[13] = Class2.ChgToDatPro(this.textBox6.Text, 15, 4);
      for (int index = 1; index <= 13; ++index)
        strArray[0] = strArray[0] + strArray[index];
      return Class1.ChgCharTo_EF_Pro(Class1.Chga_z_ToA_Z(strArray[0]) + "20202020202020202020202020202020");
    }

    private string GetDtmfChDataStringPro()
    {
      string[] strArray = new string[16];
      strArray[0] = "";
      for (int index = 0; index <= 15; ++index)
      {
        string efPro = Class1.ChgCharTo_EF_Pro(this.dataGridView1.Rows[index].Cells[2].Value.ToString());
        strArray[index] = Class2.ChgToDatPro(efPro, 24, 0);
        int int32 = Convert.ToInt32(strArray[index].Substring(24, 2), 16);
        if (this.dataGridView1.Rows[index].Cells[1].Value.ToString() == Class1.ConSigfTxKind_EngCh[Class1.English_En, 1])
          int32 |= 32;
        string hexStr = Class1.DataToHexStr((long) int32);
        strArray[index] = strArray[index].Substring(0, 24) + hexStr;
        if (index != 0)
          strArray[0] = strArray[0] + strArray[index];
      }
      return Class1.Chga_z_ToA_Z(strArray[0]) + "20202020202020202020202020202020";
    }

    private string GetDtmfDataStringPro()
    {
      string setDataStringPro = this.GetDtmfSetDataStringPro();
      return this.GetDtmfChDataStringPro() + setDataStringPro;
    }

    private void SavDtmfDataPro(string CurrStr)
    {
      string[] StrData = Class1.ReadFileDataPro(this.GiFileName2).Split('\r');
      int num1 = Class1.ConDtmfChBegAddr / Class1.ConOneRowDatCt;
      string str1 = StrData[Class1.FielBegRow + num1];
      int num2 = Class1.FielBegRow + num1;
      for (int index = 0; index < 9; ++index)
      {
        StrData[num2 + index] = Class2.AutoAdd_n_Pro(StrData[num2 + index]);
        StrData[num2 + index] = StrData[num2 + index].Substring(0, 7) + CurrStr.Substring(64 * index, 64);
      }
      int num3 = Class1.ConSetBegAddr / Class1.ConOneRowDatCt;
      str1 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num3]);
      string aZ = Class1.Chga_z_ToA_Z(Convert.ToString(this.numericUpDown1.Value--));
      string str2 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num3]);
      StrData[Class1.FielBegRow + num3] = str2.Substring(0, 45) + aZ + str2.Substring(46, str2.Length - 46);
      Class1.SaveFileDataPro(this.GiFileName2, StrData);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.SavDtmfDataPro(this.GetDtmfDataStringPro());
      this.Close();
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void comboBox1_Leave(object sender, EventArgs e)
    {
      string text = this.comboBox1.Text;
      int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
      this.dataGridView1.Rows[rowIndex].Cells[1].Value = (object) text;
      if (this.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString() == "" && text == Class1.ConSigfTxKind_EngCh[Class1.English_En, 0])
      {
        this.dataGridView1.Rows[rowIndex].Cells[2].Value = (object) "123456789";
      }
      else
      {
        if (!(this.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString() == "") || !(text == Class1.ConSigfTxKind_EngCh[Class1.English_En, 1]))
          return;
        this.dataGridView1.Rows[rowIndex].Cells[2].Value = (object) ("123" + this.CmbSepa.Text + this.textBox4.Text);
      }
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      string text = this.textBox1.Text;
      int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
      this.dataGridView1.Rows[rowIndex].Cells[2].Value = (object) text;
      if (text == "")
        this.dataGridView1.Rows[rowIndex].Cells[1].Value = (object) "";
      else if (this.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString() == "")
        this.dataGridView1.Rows[rowIndex].Cells[1].Value = (object) Class1.ConSigfTxKind_EngCh[Class1.English_En, 0];
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
    }

    private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool flag = Class1.KeyUseFul0_9ChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar != '\r')
        return;
      this.button1.Focus();
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
      this.button1.Focus();
    }

    private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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
      this.button1.Focus();
    }

    private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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
      this.button1.Focus();
    }

    private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
      this.button1.Focus();
    }

    private void label7_Click(object sender, EventArgs e)
    {
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e) => 公共控件操作.numericUpDown_ValueChanged(this.numericUpDown1);

    private void CmbPttK_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (this.CmbPttK.SelectedIndex)
      {
        case 0:
          this.textBox3.Enabled = false;
          this.textBox2.Enabled = false;
          break;
        case 1:
          this.textBox3.Enabled = false;
          this.textBox2.Enabled = true;
          break;
        case 2:
          this.textBox3.Enabled = true;
          this.textBox2.Enabled = false;
          break;
        case 3:
          this.textBox3.Enabled = true;
          this.textBox2.Enabled = true;
          break;
      }
    }

    private void ComBoxAutoChgPro(ComboBox ComboBo, ComboBox ComboBo1)
    {
      if (!(ComboBo.Text == ComboBo1.Text))
        return;
      if (ComboBo1.SelectedIndex <= 4)
        ++ComboBo1.SelectedIndex;
      else
        ComboBo1.SelectedIndex = 0;
    }

    private void CmbSepa_SelectedIndexChanged(object sender, EventArgs e) => this.ComBoxAutoChgPro(this.CmbSepa, this.CmbGroupCode);

    private void CmbGroupCode_SelectedIndexChanged(object sender, EventArgs e) => this.ComBoxAutoChgPro(this.CmbGroupCode, this.CmbSepa);
  }
}
