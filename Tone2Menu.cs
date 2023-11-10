// Decompiled with JetBrains decompiler
// Type: _8890DTest.Tone2Menu
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class Tone2Menu : Form
  {
    private IContainer components = (IContainer) null;
    private TextBox textBox1;
    private DataGridView dataGridView1;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox4;
    private CheckBox checkBox1;
    private ComboBox CmbFirTm;
    private ComboBox CmbSendTm;
    private ComboBox CmbGroupCode;
    private ComboBox CmbSepa;
    private ComboBox CmbAckK;
    private Label label13;
    private Label label11;
    private Label label8;
    private Label label3;
    private ComboBox CmbResTm;
    private Label label2;
    private Label label1;
    private GroupBox groupBox3;
    private ComboBox CmbPttK;
    private TextBox textBox6;
    private TextBox textBox5;
    private Label label9;
    private Label label16;
    private Label label15;
    private Label label14;
    private Label label6;
    private TextBox textBox2;
    private TextBox textBox3;
    private Button button2;
    private Button button1;
    private NumericUpDown numericUpDown1;
    private Label label7;
    public string GiFileName2 = "8890D_TempFile.icf";
    private string[] Con2ToneDecKind = new string[15]
    {
      "A-B",
      "A-C",
      "A-D",
      "B-A",
      "B-C",
      "B-D",
      "C-A",
      "C-B",
      "C-D",
      "D-A",
      "D-B",
      "D-C",
      "Long A",
      "Long B",
      "Long C"
    };
    public static string[,] DataGridName = new string[2, 4]
    {
      {
        "组别",
        "第一音频",
        "第二音频",
        "名称"
      },
      {
        "No. ",
        "First Tone",
        "Second Tone",
        "Name"
      }
    };
    public static string[,] lableArrName = new string[2, 12]
    {
      {
        "     解码格式",
        "      解码响应",
        "A 音频率(HZ)",
        "B 音频率(HZ)",
        "C 音频率(HZ)",
        "D 音频率(HZ)",
        "第一音频持续时间(MS)",
        "第二音频持续时间(MS)",
        "长音频持续时间(MS)",
        "     间隔时间(MS)",
        "     自动复位时间(S)",
        " 选定信道"
      },
      {
        "Decode Format",
        "Decode Reponse",
        "  A Tone(HZ)",
        "  B Tone(HZ)",
        "  C Tone(HZ)",
        "  D Tone(HZ)",
        " First Tone Time(MS)",
        "Second Tone Time(MS)",
        "Long Tone Time(MS)",
        "Interval Time(MS)",
        "  Auto Reset Time(S)",
        "Select Ch"
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
    public static string[,] GroupBox_EngCh = new string[2, 3]
    {
      {
        "2 音 编码",
        "2 音 解码",
        "设置"
      },
      {
        "2 Tone Encode",
        "2 Tone Decode",
        "Setting"
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
      this.textBox1 = new TextBox();
      this.dataGridView1 = new DataGridView();
      this.groupBox1 = new GroupBox();
      this.groupBox2 = new GroupBox();
      this.groupBox4 = new GroupBox();
      this.CmbPttK = new ComboBox();
      this.textBox6 = new TextBox();
      this.CmbAckK = new ComboBox();
      this.textBox5 = new TextBox();
      this.label9 = new Label();
      this.label2 = new Label();
      this.label14 = new Label();
      this.textBox3 = new TextBox();
      this.label15 = new Label();
      this.label6 = new Label();
      this.label16 = new Label();
      this.textBox2 = new TextBox();
      this.groupBox3 = new GroupBox();
      this.numericUpDown1 = new NumericUpDown();
      this.label7 = new Label();
      this.CmbFirTm = new ComboBox();
      this.checkBox1 = new CheckBox();
      this.CmbGroupCode = new ComboBox();
      this.CmbSendTm = new ComboBox();
      this.label8 = new Label();
      this.CmbSepa = new ComboBox();
      this.label11 = new Label();
      this.CmbResTm = new ComboBox();
      this.label13 = new Label();
      this.label3 = new Label();
      this.label1 = new Label();
      this.button2 = new Button();
      this.button1 = new Button();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.numericUpDown1.BeginInit();
      this.SuspendLayout();
      this.textBox1.Location = new Point(224, 276);
      this.textBox1.MaxLength = 24;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 21);
      this.textBox1.TabIndex = 2;
      this.textBox1.TextAlign = HorizontalAlignment.Center;
      this.textBox1.Leave += new EventHandler(this.textBox1_Leave);
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new Point(3, 17);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new Size(136, 263);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Controls.Add((Control) this.dataGridView1);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(354, 412);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "2Tone编码";
      this.groupBox1.Enter += new EventHandler(this.groupBox1_Enter);
      this.groupBox2.Controls.Add((Control) this.groupBox4);
      this.groupBox2.Controls.Add((Control) this.groupBox3);
      this.groupBox2.Location = new Point(372, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(471, 412);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox4.Controls.Add((Control) this.CmbPttK);
      this.groupBox4.Controls.Add((Control) this.textBox6);
      this.groupBox4.Controls.Add((Control) this.CmbAckK);
      this.groupBox4.Controls.Add((Control) this.textBox5);
      this.groupBox4.Controls.Add((Control) this.label9);
      this.groupBox4.Controls.Add((Control) this.label2);
      this.groupBox4.Controls.Add((Control) this.label14);
      this.groupBox4.Controls.Add((Control) this.textBox3);
      this.groupBox4.Controls.Add((Control) this.label15);
      this.groupBox4.Controls.Add((Control) this.label6);
      this.groupBox4.Controls.Add((Control) this.label16);
      this.groupBox4.Controls.Add((Control) this.textBox2);
      this.groupBox4.Location = new Point(17, 20);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(443, 214);
      this.groupBox4.TabIndex = 28;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "2Tone解码";
      this.CmbPttK.FormattingEnabled = true;
      this.CmbPttK.Location = new Point(110, 21);
      this.CmbPttK.Name = "CmbPttK";
      this.CmbPttK.Size = new Size(100, 20);
      this.CmbPttK.TabIndex = 27;
      this.CmbPttK.SelectedIndexChanged += new EventHandler(this.CmbPttK_SelectedIndexChanged);
      this.textBox6.Location = new Point(110, 167);
      this.textBox6.MaxLength = 15;
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(149, 21);
      this.textBox6.TabIndex = 26;
      this.textBox6.Leave += new EventHandler(this.textBox6_Leave);
      this.CmbAckK.FormattingEnabled = true;
      this.CmbAckK.Location = new Point(110, 47);
      this.CmbAckK.Name = "CmbAckK";
      this.CmbAckK.Size = new Size(100, 20);
      this.CmbAckK.TabIndex = 38;
      this.textBox5.Location = new Point(110, 134);
      this.textBox5.MaxLength = 15;
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(149, 21);
      this.textBox5.TabIndex = 25;
      this.textBox5.Leave += new EventHandler(this.textBox5_Leave);
      this.label9.AutoSize = true;
      this.label9.Location = new Point(11, 24);
      this.label9.Name = "label9";
      this.label9.Size = new Size(83, 12);
      this.label9.TabIndex = 24;
      this.label9.Text = "     解码格式";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(7, 55);
      this.label2.Name = "label2";
      this.label2.Size = new Size(89, 12);
      this.label2.TabIndex = 29;
      this.label2.Text = "      解码响应";
      this.label14.AutoSize = true;
      this.label14.Location = new Point(23, 84);
      this.label14.Name = "label14";
      this.label14.Size = new Size(77, 12);
      this.label14.TabIndex = 21;
      this.label14.Text = "A 音频率(HZ)";
      this.textBox3.Location = new Point(110, 101);
      this.textBox3.MaxLength = 24;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(149, 21);
      this.textBox3.TabIndex = 5;
      this.textBox3.Leave += new EventHandler(this.textBox3_Leave);
      this.label15.AutoSize = true;
      this.label15.Location = new Point(23, 113);
      this.label15.Name = "label15";
      this.label15.Size = new Size(77, 12);
      this.label15.TabIndex = 22;
      this.label15.Text = "B 音频率(HZ)";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(23, 137);
      this.label6.Name = "label6";
      this.label6.Size = new Size(77, 12);
      this.label6.TabIndex = 20;
      this.label6.Text = "C 音频率(HZ)";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(23, 170);
      this.label16.Name = "label16";
      this.label16.Size = new Size(77, 12);
      this.label16.TabIndex = 23;
      this.label16.Text = "D 音频率(HZ)";
      this.textBox2.Location = new Point(110, 72);
      this.textBox2.MaxLength = 24;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(149, 21);
      this.textBox2.TabIndex = 4;
      this.textBox2.Leave += new EventHandler(this.textBox2_Leave);
      this.groupBox3.Controls.Add((Control) this.numericUpDown1);
      this.groupBox3.Controls.Add((Control) this.label7);
      this.groupBox3.Controls.Add((Control) this.CmbFirTm);
      this.groupBox3.Controls.Add((Control) this.checkBox1);
      this.groupBox3.Controls.Add((Control) this.CmbGroupCode);
      this.groupBox3.Controls.Add((Control) this.CmbSendTm);
      this.groupBox3.Controls.Add((Control) this.label8);
      this.groupBox3.Controls.Add((Control) this.CmbSepa);
      this.groupBox3.Controls.Add((Control) this.label11);
      this.groupBox3.Controls.Add((Control) this.CmbResTm);
      this.groupBox3.Controls.Add((Control) this.label13);
      this.groupBox3.Controls.Add((Control) this.label3);
      this.groupBox3.Controls.Add((Control) this.label1);
      this.groupBox3.Location = new Point(17, 240);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(437, 166);
      this.groupBox3.TabIndex = 20;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "设置";
      this.numericUpDown1.Location = new Point(343, 107);
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
      this.numericUpDown1.TabIndex = 47;
      this.numericUpDown1.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
      this.label7.AutoSize = true;
      this.label7.Location = new Point(224, 110);
      this.label7.Name = "label7";
      this.label7.Size = new Size(113, 12);
      this.label7.TabIndex = 46;
      this.label7.Text = "          选定信道";
      this.CmbFirTm.FormattingEnabled = true;
      this.CmbFirTm.Location = new Point(142, 69);
      this.CmbFirTm.Name = "CmbFirTm";
      this.CmbFirTm.Size = new Size(54, 20);
      this.CmbFirTm.TabIndex = 42;
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(289, 134);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(48, 16);
      this.checkBox1.TabIndex = 43;
      this.checkBox1.Text = "侧音";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.CmbGroupCode.FormattingEnabled = true;
      this.CmbGroupCode.Location = new Point(343, 39);
      this.CmbGroupCode.Name = "CmbGroupCode";
      this.CmbGroupCode.Size = new Size(54, 20);
      this.CmbGroupCode.TabIndex = 40;
      this.CmbSendTm.FormattingEnabled = true;
      this.CmbSendTm.Location = new Point(142, 31);
      this.CmbSendTm.Name = "CmbSendTm";
      this.CmbSendTm.Size = new Size(54, 20);
      this.CmbSendTm.TabIndex = 41;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(230, 39);
      this.label8.Name = "label8";
      this.label8.Size = new Size(107, 12);
      this.label8.TabIndex = 34;
      this.label8.Text = "     间隔时间(MS)";
      this.CmbSepa.FormattingEnabled = true;
      this.CmbSepa.Location = new Point(142, 107);
      this.CmbSepa.Name = "CmbSepa";
      this.CmbSepa.Size = new Size(54, 20);
      this.CmbSepa.TabIndex = 39;
      this.label11.AutoSize = true;
      this.label11.Location = new Point(17, 77);
      this.label11.Name = "label11";
      this.label11.Size = new Size(125, 12);
      this.label11.TabIndex = 35;
      this.label11.Text = "第二音频持续时间(MS)";
      this.label11.Click += new EventHandler(this.label11_Click);
      this.CmbResTm.FormattingEnabled = true;
      this.CmbResTm.Location = new Point(343, 69);
      this.CmbResTm.Name = "CmbResTm";
      this.CmbResTm.Size = new Size(54, 20);
      this.CmbResTm.TabIndex = 30;
      this.label13.AutoSize = true;
      this.label13.Location = new Point(212, 77);
      this.label13.Name = "label13";
      this.label13.Size = new Size(125, 12);
      this.label13.TabIndex = 36;
      this.label13.Text = "     自动复位时间(S)";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(17, 39);
      this.label3.Name = "label3";
      this.label3.Size = new Size(125, 12);
      this.label3.TabIndex = 31;
      this.label3.Text = "第一音频持续时间(MS)";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(29, 115);
      this.label1.Name = "label1";
      this.label1.Size = new Size(107, 12);
      this.label1.TabIndex = 28;
      this.label1.Text = "长音频持续时间(S)";
      this.button2.Location = new Point(391, 441);
      this.button2.Name = "button2";
      this.button2.Size = new Size(94, 47);
      this.button2.TabIndex = 5;
      this.button2.Text = "取 消";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.Location = new Point(252, 441);
      this.button1.Name = "button1";
      this.button1.Size = new Size(96, 47);
      this.button1.TabIndex = 4;
      this.button1.Text = "确 定";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(861, 509);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = nameof (Tone2Menu);
      this.Text = "2Tone Menu";
      this.Load += new EventHandler(this.Tone2Menu_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.numericUpDown1.EndInit();
      this.ResumeLayout(false);
    }

    public Tone2Menu()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void DataGridViewColumnAddPro(DataGridViewTextBoxColumn acCode, string name)
    {
      acCode.HeaderText = name;
      acCode.Width = 100;
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
      DataGridViewTextBoxColumn acCode4 = new DataGridViewTextBoxColumn();
      this.DataGridViewColumnAddPro(acCode1, Tone2Menu.DataGridName[Class1.English_En, 0]);
      acCode1.Width = 40;
      this.DataGridViewColumnAddPro(acCode2, Tone2Menu.DataGridName[Class1.English_En, 1]);
      this.DataGridViewColumnAddPro(acCode3, Tone2Menu.DataGridName[Class1.English_En, 2]);
      this.DataGridViewColumnAddPro(acCode4, Tone2Menu.DataGridName[Class1.English_En, 3]);
      this.dataGridView1.Rows.Add(15);
      for (int index = 0; index <= 15; ++index)
      {
        this.dataGridView1.Rows[index].Cells[0].Value = (object) (index + 1);
        this.dataGridView1.Rows[index].Cells[1].Value = (object) "";
        this.dataGridView1.Rows[index].Cells[2].Value = (object) "";
        this.dataGridView1.Rows[index].Cells[3].Value = (object) "";
        if (index == 0)
        {
          this.dataGridView1.Rows[index].Cells[1].Value = (object) "666.0";
          this.dataGridView1.Rows[index].Cells[2].Value = (object) "2222.0";
          this.dataGridView1.Rows[index].Cells[3].Value = (object) "2T-01";
        }
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
      this.TextBoxResPro(this.textBox1, 6, "");
      this.textBox1.Visible = false;
      this.loadDataGridViewPro();
    }

    private void CmbAdd_50_500MS_Pro(ComboBox cmbHelp)
    {
      for (int index = 5; index <= 100; ++index)
      {
        string str = index.ToString() + "00";
        cmbHelp.Items.Add((object) str);
      }
    }

    private void CmbAdd_0_2000MS_Pro(ComboBox cmbHelp)
    {
      for (int index = 0; index <= 20; ++index)
      {
        string str = index.ToString() + "00";
        cmbHelp.Items.Add((object) str);
      }
    }

    private void CmbAdd_0_25S_Pro(ComboBox cmbHelp)
    {
      for (int index = 0; index <= 25; ++index)
        cmbHelp.Items.Add((object) index);
    }

    private void load_CmbSepaKPro()
    {
      this.CmbAdd_50_500MS_Pro(this.CmbSepa);
      this.ComBoxResPro(this.CmbSepa, 5);
    }

    private void load_CmbSendTmPro()
    {
      this.CmbAdd_50_500MS_Pro(this.CmbSendTm);
      this.ComBoxResPro(this.CmbSendTm, 0);
    }

    private void load_CmbFirTmPro()
    {
      this.CmbAdd_50_500MS_Pro(this.CmbFirTm);
      this.ComBoxResPro(this.CmbFirTm, 0);
    }

    private void load_CmbResTmPro()
    {
      this.CmbAdd_0_25S_Pro(this.CmbResTm);
      this.ComBoxResPro(this.CmbResTm, 10);
    }

    private void load_CmbPttKPro() => 公共控件操作.Load_CmbBoxNPro(this.CmbPttK, this.Con2ToneDecKind, 14);

    private void load_CmbGroupCodePro()
    {
      this.CmbAdd_0_2000MS_Pro(this.CmbGroupCode);
      this.ComBoxResPro(this.CmbGroupCode, 10);
    }

    private void load_GroBox1_LabelPro()
    {
      for (int index = 0; index <= 11; ++index)
        this.Label_Arr[index].Text = Tone2Menu.lableArrName[Class1.English_En, index];
    }

    private void load_GroBox1_CheckBoxPro()
    {
      for (int index = 0; index <= 0; ++index)
        this.CheckBox_Arr[index].Text = Tone2Menu.ChekcBox_EngCh[Class1.English_En, index];
    }

    private void load_GroBox1_ButtonPro()
    {
      for (int index = 0; index <= 1; ++index)
        this.Button_Arr[index].Text = Tone2Menu.Button_EngCh[Class1.English_En, index];
    }

    private void load_GroBox1_comboBoxPro()
    {
      this.load_CmbPttKPro();
      公共控件操作.load_CmbBoxNProEng_Ch1(this.CmbAckK, Class1.ConAckKind_EngCh, Class1.ConAckKind_EngCh.GetLength(1) - 1);
      this.load_CmbSendTmPro();
      this.load_CmbFirTmPro();
      this.load_CmbSepaKPro();
      this.load_CmbGroupCodePro();
      this.load_CmbResTmPro();
    }

    private void load_GroupBox2Pro()
    {
      this.load_GroBox1_LabelPro();
      this.load_GroBox1_CheckBoxPro();
      this.load_GroBox1_ButtonPro();
      this.load_GroBox1_comboBoxPro();
      this.TextBoxResPro(this.textBox2, 6, "666.0");
      this.TextBoxResPro(this.textBox3, 6, "2222.0");
      this.TextBoxResPro(this.textBox5, 6, "626.5");
      this.textBox5.Enabled = false;
      this.TextBoxResPro(this.textBox6, 6, "2043.8");
      this.textBox6.Enabled = false;
      公共控件操作.numericUpDownXRes(this.numericUpDown1, 17, 0, 1);
    }

    private void Dis2ToneRxDataPro(string Datastr)
    {
      string StrTemp1 = Datastr.Substring(0, 4);
      string StrTemp2 = Datastr.Substring(4, 4);
      string StrTemp3 = Datastr.Substring(8, 4);
      string StrTemp4 = Datastr.Substring(12, 4);
      string str1 = Datastr.Substring(16, 2);
      string str2 = Datastr.Substring(18, 2);
      string str3 = Datastr.Substring(20, 2);
      string str4 = Datastr.Substring(22, 2);
      string str5 = Datastr.Substring(24, 2);
      string str6 = Datastr.Substring(26, 2);
      try
      {
        this.textBox2.Text = Class2.StringChgFrePro(StrTemp1, 1);
        this.textBox3.Text = Class2.StringChgFrePro(StrTemp2, 1);
        this.textBox5.Text = Class2.StringChgFrePro(StrTemp3, 1);
        this.textBox6.Text = Class2.StringChgFrePro(StrTemp4, 1);
        int int32 = Convert.ToInt32(str1, 16);
        this.CmbPttK.SelectedIndex = int32 & 15;
        this.CmbAckK.SelectedIndex = (int32 & 48) >> 4;
        this.checkBox1.Checked = 0 != (int32 & 64);
        this.CmbSendTm.SelectedIndex = Convert.ToInt32(str2, 16) & (int) sbyte.MaxValue;
        this.CmbFirTm.SelectedIndex = Convert.ToInt32(str3, 16) & (int) sbyte.MaxValue;
        this.CmbSepa.SelectedIndex = Convert.ToInt32(str4, 16) & (int) sbyte.MaxValue;
        this.CmbGroupCode.SelectedIndex = Convert.ToInt32(str5, 16) & 31;
        this.CmbResTm.SelectedIndex = Convert.ToInt32(str6, 16) & 31;
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 1], Class1.RadioName);
      }
    }

    private void Dis2ToneTxDataPro(string[] DtmfCh)
    {
      try
      {
        for (int index = 0; index <= 15; ++index)
        {
          if (!(index > 7 ? Class2.UseFulChkPro(DtmfCh[17], index - 8) : Class2.UseFulChkPro(DtmfCh[16], index)))
          {
            this.dataGridView1.Rows[index].Cells[1].Value = (object) "";
            this.dataGridView1.Rows[index].Cells[2].Value = (object) "";
            this.dataGridView1.Rows[index].Cells[3].Value = (object) "";
          }
          else
          {
            string str1 = Class2.StringChgFrePro(DtmfCh[index].Substring(0, 4), 1);
            this.dataGridView1.Rows[index].Cells[1].Value = (object) str1;
            string StrTemp = DtmfCh[index].Substring(4, 4);
            string str2 = !(StrTemp == "2020") ? Class2.StringChgFrePro(StrTemp, 1) : "";
            this.dataGridView1.Rows[index].Cells[2].Value = (object) str2;
            if (this.dataGridView1.Rows[index].Cells[1].Value.ToString() == "" && this.dataGridView1.Rows[index].Cells[2].Value.ToString() == "")
            {
              this.dataGridView1.Rows[index].Cells[3].Value = (object) "";
            }
            else
            {
              int length = Convert.ToInt32(DtmfCh[index].Substring(21, 1), 16) << 1;
              string str3 = Class2.StringChNamePro(DtmfCh[index].Substring(8, length));
              if (str3 == "            ")
                str3 = "";
              this.dataGridView1.Rows[index].Cells[3].Value = (object) str3;
            }
          }
        }
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 1], Class1.RadioName);
      }
    }

    private string GetOneToneChStringPro(string[] n, int i)
    {
      int num = Class1.Tone2BegAddr / Class1.ConOneRowDatCt + Class1.ConOneTone2ChDatCt * i / Class1.ConOneRowDatCt;
      string str1 = n[Class1.FielBegRow + num];
      string str2 = str1.Substring(Class1.ConUseChDatSta + 1, str1.Length - Class1.ConUseChDatSta - 1);
      string str3 = n[Class1.FielBegRow + num + 1];
      return (str2 + str3.Substring(Class1.ConUseChDatSta + 1, str3.Length - Class1.ConUseChDatSta - 1)).Substring(Class1.ConOneTone2ChDatCt * i % Class1.ConOneRowDatCt << 1, 2 * Class1.ConOneTone2ChDatCt);
    }

    private void LoadToneFileDataDisPro()
    {
      string[] n = Class1.ReadFileDataPro(this.GiFileName2).Split('\r');
      string[] DtmfCh = new string[18];
      for (int i = 0; i <= 15; ++i)
        DtmfCh[i] = this.GetOneToneChStringPro(n, i);
      int num1 = Class1.Tone2RxAddr / Class1.ConOneRowDatCt;
      string str = Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num1]);
      string Datastr = str.Substring(Class1.ConUseChDatSta + 1, str.Length - Class1.ConUseChDatSta - 1);
      DtmfCh[16] = Datastr.Substring(28, 2);
      DtmfCh[17] = Datastr.Substring(30, 2);
      this.Dis2ToneRxDataPro(Datastr);
      int num2 = Class1.ConSetBegAddr / Class1.ConOneRowDatCt;
      this.numericUpDown1.Value = (Decimal) (Convert.ToInt32(Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num2]).Substring(46, 1), 16) + 1);
      this.Dis2ToneTxDataPro(DtmfCh);
    }

    private void SetContrlAs_arrPro()
    {
      this.Label_Arr = new Label[23];
      this.Label_Arr[0] = this.label9;
      this.Label_Arr[1] = this.label2;
      this.Label_Arr[2] = this.label14;
      this.Label_Arr[3] = this.label15;
      this.Label_Arr[4] = this.label6;
      this.Label_Arr[5] = this.label16;
      this.Label_Arr[6] = this.label3;
      this.Label_Arr[7] = this.label11;
      this.Label_Arr[8] = this.label1;
      this.Label_Arr[9] = this.label8;
      this.Label_Arr[10] = this.label13;
      this.Label_Arr[11] = this.label7;
      this.ComboBoxl_Arr = new ComboBox[14];
      this.ComboBoxl_Arr[0] = this.CmbPttK;
      this.ComboBoxl_Arr[1] = this.CmbAckK;
      this.ComboBoxl_Arr[2] = this.CmbSendTm;
      this.ComboBoxl_Arr[3] = this.CmbFirTm;
      this.ComboBoxl_Arr[4] = this.CmbSepa;
      this.ComboBoxl_Arr[5] = this.CmbGroupCode;
      this.ComboBoxl_Arr[6] = this.CmbResTm;
      this.TextBoxl_Arr = new TextBox[5];
      this.TextBoxl_Arr[0] = this.textBox1;
      this.TextBoxl_Arr[1] = this.textBox2;
      this.TextBoxl_Arr[2] = this.textBox3;
      this.TextBoxl_Arr[3] = this.textBox5;
      this.TextBoxl_Arr[4] = this.textBox6;
      this.CheckBox_Arr = new CheckBox[6];
      this.CheckBox_Arr[0] = this.checkBox1;
      this.GroupBox_Arr = new GroupBox[3];
      this.GroupBox_Arr[0] = this.groupBox1;
      this.GroupBox_Arr[1] = this.groupBox4;
      this.GroupBox_Arr[2] = this.groupBox3;
      this.Button_Arr = new Button[2];
      this.Button_Arr[0] = this.button1;
      this.Button_Arr[1] = this.button2;
    }

    private void Tone2Menu_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.SetContrlAs_arrPro();
      this.load_GroupBox1Pro();
      this.load_GroupBox2Pro();
      for (int index = 0; index <= 2; ++index)
        this.GroupBox_Arr[index].Text = Tone2Menu.GroupBox_EngCh[Class1.English_En, index];
      this.LoadToneFileDataDisPro();
      this.CmbAckK.Visible = false;
      this.label2.Visible = false;
    }

    private string GetDtmfChUseFulStringPro()
    {
      string StrData = "";
      for (int index = 0; index <= 15; ++index)
      {
        if (this.dataGridView1.Rows[index].Cells[1].Value == null)
          this.dataGridView1.Rows[index].Cells[1].Value = (object) "";
        if (this.dataGridView1.Rows[index].Cells[2].Value == null)
          this.dataGridView1.Rows[index].Cells[2].Value = (object) "";
        StrData = !(this.dataGridView1.Rows[index].Cells[1].Value.ToString() == "") || !(this.dataGridView1.Rows[index].Cells[2].Value.ToString() == "") ? StrData + "1" : StrData + "0";
      }
      return Class2.GetChUseFulStringPro(16, StrData);
    }

    private string Get2ToneRxDataStringPro()
    {
      string[] strArray = new string[11];
      string text1 = this.textBox2.Text;
      strArray[0] = Class2.ChgToneToDataPro(text1);
      string text2 = this.textBox3.Text;
      strArray[1] = Class2.ChgToneToDataPro(text2);
      string text3 = this.textBox5.Text;
      strArray[2] = Class2.ChgToneToDataPro(text3);
      string text4 = this.textBox6.Text;
      strArray[3] = Class2.ChgToneToDataPro(text4);
      int Data = this.CmbPttK.SelectedIndex | this.CmbAckK.SelectedIndex << 4 | Class2.ChgBoolToDatPro(this.checkBox1.Checked) << 6;
      strArray[4] = Class1.DataToHexStr((long) Data);
      int selectedIndex1 = this.CmbSendTm.SelectedIndex;
      strArray[5] = Class1.DataToHexStr((long) selectedIndex1);
      int selectedIndex2 = this.CmbFirTm.SelectedIndex;
      strArray[6] = Class1.DataToHexStr((long) selectedIndex2);
      int selectedIndex3 = this.CmbSepa.SelectedIndex;
      strArray[7] = Class1.DataToHexStr((long) selectedIndex3);
      int selectedIndex4 = this.CmbGroupCode.SelectedIndex;
      strArray[8] = Class1.DataToHexStr((long) selectedIndex4);
      int selectedIndex5 = this.CmbResTm.SelectedIndex;
      strArray[9] = Class1.DataToHexStr((long) selectedIndex5);
      strArray[10] = this.GetDtmfChUseFulStringPro();
      for (int index = 1; index <= 10; ++index)
        strArray[0] = strArray[0] + strArray[index];
      return Class1.Chga_z_ToA_Z(strArray[0]) + "20202020202020202020202020202020";
    }

    private string Get2ToneChDataStringPro()
    {
      string[] strArray = new string[16];
      strArray[0] = "";
      for (int index = 0; index <= 15; ++index)
      {
        if (this.dataGridView1.Rows[index].Cells[1].Value == null)
          this.dataGridView1.Rows[index].Cells[1].Value = (object) "";
        if (this.dataGridView1.Rows[index].Cells[2].Value == null)
          this.dataGridView1.Rows[index].Cells[2].Value = (object) "";
        if (this.dataGridView1.Rows[index].Cells[3].Value == null)
          this.dataGridView1.Rows[index].Cells[3].Value = (object) "";
        string str = Class2.ChgToneToDataPro(this.dataGridView1.Rows[index].Cells[1].Value.ToString()) + Class2.ChgToneToDataPro(this.dataGridView1.Rows[index].Cells[2].Value.ToString());
        string StrTemp = this.dataGridView1.Rows[index].Cells[3].Value.ToString();
        int length = StrTemp.Length;
        string acsPro = Class2.ChgStringToAcsPro(StrTemp, 6);
        strArray[index] = str + acsPro + Class1.DataToHexStr((long) length);
        if (index != 0)
          strArray[0] = strArray[0] + strArray[index];
      }
      return Class1.Chga_z_ToA_Z(strArray[0]) + "20202020202020202020202020202020";
    }

    private string GetToneDataStringPro()
    {
      string str = this.Get2ToneRxDataStringPro();
      return this.Get2ToneChDataStringPro() + str;
    }

    private void SavToneDataPro(string CurrStr)
    {
      string[] StrData = Class1.ReadFileDataPro(this.GiFileName2).Split('\r');
      int num1 = Class1.Tone2BegAddr / Class1.ConOneRowDatCt;
      string str1 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num1]);
      int num2 = Class1.FielBegRow + num1;
      for (int index = 0; index < 7; ++index)
      {
        StrData[num2 + index] = Class2.AutoAdd_n_Pro(StrData[num2 + index]);
        StrData[num2 + index] = StrData[num2 + index].Substring(0, 7) + CurrStr.Substring(64 * index, 64);
      }
      int num3 = Class1.ConSetBegAddr / Class1.ConOneRowDatCt;
      str1 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num3]);
      string aZ = Class1.Chga_z_ToA_Z(Convert.ToString(this.numericUpDown1.Value--));
      string str2 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num3]);
      StrData[Class1.FielBegRow + num3] = str2.Substring(0, 46) + aZ + str2.Substring(47, str2.Length - 47);
      Class1.SaveFileDataPro(this.GiFileName2, StrData);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.SavToneDataPro(this.GetToneDataStringPro());
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e) => this.Close();

    private void label11_Click(object sender, EventArgs e)
    {
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
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
      int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
      if (1 == this.dataGridView1.CurrentCell.ColumnIndex || 2 == this.dataGridView1.CurrentCell.ColumnIndex || 3 == this.dataGridView1.CurrentCell.ColumnIndex)
      {
        if (this.dataGridView1.CurrentCell.ColumnIndex != 1 && this.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString() == "")
          return;
        Rectangle displayRectangle = this.dataGridView1.GetCellDisplayRectangle(this.dataGridView1.CurrentCell.ColumnIndex, this.dataGridView1.CurrentCell.RowIndex, false);
        this.textBox1.Left = displayRectangle.Left + 3;
        this.textBox1.Top = displayRectangle.Top + 17;
        this.textBox1.Width = displayRectangle.Width;
        this.textBox1.Height = displayRectangle.Height;
        this.textBox1.MaxLength = 6;
        this.textBox1.Visible = true;
        this.textBox1.Focus();
        this.textBox1.Text = this.GetCurrCellText();
      }
      else
        this.textBox1.Visible = false;
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this.dataGridView1.CurrentCell.ColumnIndex == 2 || this.dataGridView1.CurrentCell.ColumnIndex == 1)
      {
        bool flag = Class1.KeyUseFul0_9ChkPro(e.KeyChar);
        e.Handled = flag;
        if (e.KeyChar != '\r')
          return;
        if (Class2.DataUseFulToneChk(this.textBox1.Text) == "BandOver")
        {
          int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
          int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 0], Class1.RadioName);
          this.textBox1.Text = this.dataGridView1.Rows[rowIndex].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
          this.textBox1.SelectionLength = this.textBox1.Text.Length;
          this.textBox1.Focus();
        }
        else
        {
          this.textBox1.Visible = false;
          this.dataGridView1.CurrentCell = this.dataGridView1.CurrentRow.Cells[this.dataGridView1.SelectedCells[0].ColumnIndex + 1];
        }
      }
      else
      {
        if (this.dataGridView1.CurrentCell.ColumnIndex != 3)
          return;
        bool flag = Class1.AsciiKeyUseFulChkPro(e.KeyChar);
        e.KeyChar = Class1.ChgChar_a_z_ToA_Z(e.KeyChar);
        e.Handled = flag;
        if (e.KeyChar == '\r')
        {
          this.textBox1.Visible = false;
          this.dataGridView1.Focus();
        }
      }
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      string text = this.textBox1.Text;
      int rowIndex1 = this.dataGridView1.CurrentCell.RowIndex;
      if (this.dataGridView1.CurrentCell.ColumnIndex == 2 || this.dataGridView1.CurrentCell.ColumnIndex == 1)
      {
        string str1 = Class2.DataUseFulToneChk(text);
        if (str1 == "BandOver")
        {
          int rowIndex2 = this.dataGridView1.CurrentCell.RowIndex;
          int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 0], Class1.RadioName);
          this.textBox1.Text = this.dataGridView1.Rows[rowIndex2].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
          this.textBox1.SelectionLength = this.textBox1.Text.Length;
          this.textBox1.Focus();
        }
        else
        {
          this.textBox1.Visible = false;
          if (this.dataGridView1.CurrentCell.ColumnIndex == 1 && this.dataGridView1.Rows[rowIndex1].Cells[1].Value.ToString() == "")
          {
            this.dataGridView1.Rows[rowIndex1].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value = (object) str1;
            if (str1 != "")
            {
              this.dataGridView1.Rows[rowIndex1].Cells[3].Value = (object) ("2T-" + Class1.DataTo10Str((long) (rowIndex1 + 1)));
            }
            else
            {
              this.dataGridView1.Rows[rowIndex1].Cells[2].Value = (object) "";
              this.dataGridView1.Rows[rowIndex1].Cells[3].Value = (object) "";
            }
          }
          string str2 = str1.Replace(",", ".");
          this.dataGridView1.Rows[rowIndex1].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value = (object) str2;
          if (this.dataGridView1.Rows[rowIndex1].Cells[1].Value.ToString() == "")
          {
            this.dataGridView1.Rows[rowIndex1].Cells[2].Value = (object) "";
            this.dataGridView1.Rows[rowIndex1].Cells[3].Value = (object) "";
          }
          this.dataGridView1.Focus();
        }
      }
      else
      {
        if (this.dataGridView1.CurrentCell.ColumnIndex != 3)
          return;
        this.textBox1.Visible = false;
        if (this.dataGridView1.Rows[rowIndex1].Cells[1].Value.ToString() != "")
          this.dataGridView1.Rows[rowIndex1].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value = (object) text;
      }
    }

    private void CmbPttK_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (this.CmbPttK.SelectedIndex)
      {
        case 0:
          this.textBox2.Enabled = true;
          this.textBox3.Enabled = true;
          this.textBox5.Enabled = false;
          this.textBox6.Enabled = false;
          break;
        case 1:
          this.textBox2.Enabled = true;
          this.textBox3.Enabled = false;
          this.textBox5.Enabled = true;
          this.textBox6.Enabled = false;
          break;
        case 2:
          this.textBox2.Enabled = true;
          this.textBox3.Enabled = false;
          this.textBox5.Enabled = false;
          this.textBox6.Enabled = true;
          break;
        case 3:
          this.textBox2.Enabled = true;
          this.textBox3.Enabled = true;
          this.textBox5.Enabled = false;
          this.textBox6.Enabled = false;
          break;
        case 4:
          this.textBox2.Enabled = false;
          this.textBox3.Enabled = true;
          this.textBox5.Enabled = true;
          this.textBox6.Enabled = false;
          break;
        case 5:
          this.textBox2.Enabled = false;
          this.textBox3.Enabled = true;
          this.textBox5.Enabled = false;
          this.textBox6.Enabled = true;
          break;
        case 6:
          this.textBox2.Enabled = true;
          this.textBox3.Enabled = false;
          this.textBox5.Enabled = true;
          this.textBox6.Enabled = false;
          break;
        case 7:
          this.textBox2.Enabled = false;
          this.textBox3.Enabled = true;
          this.textBox5.Enabled = true;
          this.textBox6.Enabled = false;
          break;
        case 8:
          this.textBox2.Enabled = false;
          this.textBox3.Enabled = false;
          this.textBox5.Enabled = true;
          this.textBox6.Enabled = true;
          break;
        case 9:
          this.textBox2.Enabled = true;
          this.textBox3.Enabled = false;
          this.textBox5.Enabled = false;
          this.textBox6.Enabled = true;
          break;
        case 10:
          this.textBox2.Enabled = false;
          this.textBox3.Enabled = true;
          this.textBox5.Enabled = false;
          this.textBox6.Enabled = true;
          break;
        case 11:
          this.textBox2.Enabled = false;
          this.textBox3.Enabled = false;
          this.textBox5.Enabled = true;
          this.textBox6.Enabled = true;
          break;
        case 12:
          this.textBox2.Enabled = true;
          this.textBox3.Enabled = false;
          this.textBox5.Enabled = false;
          this.textBox6.Enabled = false;
          break;
        case 13:
          this.textBox2.Enabled = false;
          this.textBox3.Enabled = true;
          this.textBox5.Enabled = false;
          this.textBox6.Enabled = false;
          break;
        case 14:
          this.textBox2.Enabled = false;
          this.textBox3.Enabled = false;
          this.textBox5.Enabled = true;
          this.textBox6.Enabled = false;
          break;
      }
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e) => 公共控件操作.numericUpDown_ValueChanged(this.numericUpDown1);

    private void textBox_X_Leave(TextBox TextBox_X)
    {
      string str1 = Class2.DataUseFulToneChk(TextBox_X.Text);
      if (str1 == "BandOver")
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 0], Class1.RadioName);
        TextBox_X.Text = "";
        TextBox_X.Focus();
      }
      else
      {
        string text = TextBox_X.Text;
        if (text.Length >= 3)
        {
          text.Insert(text.Length - 1, ".");
          string str2 = str1.Replace(",", ".");
          TextBox_X.Text = str2;
        }
      }
    }

    private void textBox2_Leave(object sender, EventArgs e) => this.textBox_X_Leave(this.textBox2);

    private void textBox3_Leave(object sender, EventArgs e) => this.textBox_X_Leave(this.textBox3);

    private void textBox5_Leave(object sender, EventArgs e) => this.textBox_X_Leave(this.textBox5);

    private void textBox6_Leave(object sender, EventArgs e) => this.textBox_X_Leave(this.textBox6);
  }
}
