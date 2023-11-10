// Decompiled with JetBrains decompiler
// Type: _8890DTest.RfRangWin
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class RfRangWin : Form
  {
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private TextBox textBox1;
    private DataGridView dataGridView1;
    private TextBox textBox2;
    private Label label1;
    private Button button1;
    private Button button2;
    private Button button3;
    private ComboBox comboBox1;
    private ComboBox comboBox2;
    public static string[,] DataGridName = new string[2, 5]
    {
      {
        "频段",
        "接收下限",
        "接收上限",
        "发射下限",
        "发射上限"
      },
      {
        "Range ",
        "Rx Lower",
        " Rx Upper",
        "Tx Lower",
        "Tx Upper"
      }
    };
    public static string[,] Button_EngCh = new string[2, 3]
    {
      {
        "确定",
        "确定",
        "取消"
      },
      {
        "Enter",
        "Enter",
        "Canel"
      }
    };
    public static string[,] Other_EngCh = new string[2, 2]
    {
      {
        "请输入密码:",
        "频段范围"
      },
      {
        "Enter Code:",
        "Frequency Range"
      }
    };
    private string[,] MessBoxName = new string[2, 2]
    {
      {
        "当前频率超出范围   [",
        "密码错误！请重新输入！"
      },
      {
        "Frequency Out Off Rang   [  ",
        "Code Error!Input Again!"
      }
    };
    private string[,] FreBandSelName = new string[2, 12]
    {
      {
        "136M-174M  400M-480M",
        "136M-174M  240M-260M",
        "136M-174M  200M-260M",
        "136M-174M  400M-520M",
        "136M-174M",
        "200M-260M",
        "245M-246M",
        "400M-520M",
        "台湾版\t缩频",
        "欧洲版\t缩频",
        "美国版\t缩频",
        "加拿大版\t缩频"
      },
      {
        "136M-174M  400M-480M",
        "136M-174M  240M-260M",
        "136M-174M  200M-260M",
        "136M-174M  400M-520M",
        "136M-174M",
        "200M-260M",
        "245M-246M",
        "400M-520M",
        "Taiwan Ver",
        "Europe Ver",
        "USA\tVer",
        "Canada\tVer"
      }
    };
    public static string[] FreBandSel = new string[12]
    {
      "136M-174M  400M-480M",
      "136M-174M  240M-260M",
      "136M-174M  200M-260M",
      "136M-174M  400M-520M",
      "136M-174M",
      "200M-260M",
      "245M-246M",
      "400M-520M",
      "144M-146M  430M-432M",
      "144M-146M  430M-440M",
      "144M-148M  420M-450M",
      "144M-148M  430M-450M"
    };
    private Label[] Label_Arr;
    private ComboBox[] ComboBoxl_Arr;
    private TextBox[] TextBoxl_Arr;
    private CheckBox[] CheckBox_Arr;
    private GroupBox[] GroupBox_Arr;
    private Button[] Button_Arr;
    private int FirstLoad = 1;
    public string GiFileNameRang = "8890D_TempFile.icf";

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
      this.dataGridView1 = new DataGridView();
      this.textBox2 = new TextBox();
      this.label1 = new Label();
      this.button1 = new Button();
      this.button2 = new Button();
      this.button3 = new Button();
      this.comboBox1 = new ComboBox();
      this.comboBox2 = new ComboBox();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Controls.Add((Control) this.dataGridView1);
      this.groupBox1.Location = new Point(-3, -5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(450, 113);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.textBox1.Location = new Point(210, 44);
      this.textBox1.MaxLength = 24;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 21);
      this.textBox1.TabIndex = 6;
      this.textBox1.TextAlign = HorizontalAlignment.Center;
      this.textBox1.Visible = false;
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.textBox1.Leave += new EventHandler(this.textBox1_Leave);
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new Point(10, 22);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new Size(136, 43);
      this.dataGridView1.TabIndex = 5;
      this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      this.textBox2.Location = new Point(144, 143);
      this.textBox2.Name = "textBox2";
      this.textBox2.PasswordChar = '*';
      this.textBox2.Size = new Size(100, 21);
      this.textBox2.TabIndex = 7;
      this.textBox2.Visible = false;
      this.textBox2.KeyDown += new KeyEventHandler(this.textBox2_KeyDown_1);
      this.textBox2.KeyUp += new KeyEventHandler(this.textBox2_KeyUp);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(68, 153);
      this.label1.Name = "label1";
      this.label1.Size = new Size(71, 12);
      this.label1.TabIndex = 8;
      this.label1.Text = "请输入密码:";
      this.label1.Visible = false;
      this.button1.Location = new Point(260, 142);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 9;
      this.button1.Text = "确定";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(145, 143);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 7;
      this.button2.Text = "确定";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Visible = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Location = new Point(260, 142);
      this.button3.Name = "button3";
      this.button3.Size = new Size(75, 23);
      this.button3.TabIndex = 10;
      this.button3.Text = "取消";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Visible = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(301, 114);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(145, 20);
      this.comboBox1.TabIndex = 11;
      this.comboBox1.Visible = false;
      this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
      this.comboBox2.Enabled = false;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new Point(145, 114);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(145, 20);
      this.comboBox2.TabIndex = 12;
      this.comboBox2.Visible = false;
      this.comboBox2.SelectedIndexChanged += new EventHandler(this.comboBox2_SelectedIndexChanged);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(459, 171);
      this.Controls.Add((Control) this.comboBox2);
      this.Controls.Add((Control) this.comboBox1);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.KeyPreview = true;
      this.Name = nameof (RfRangWin);
      this.Text = "频段范围";
      this.Load += new EventHandler(this.i_Load);
      this.DoubleClick += new EventHandler(this.RfRangWin_DoubleClick);
      this.KeyPress += new KeyPressEventHandler(this.RfRangWin_KeyPress);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public RfRangWin()
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
      DataGridViewTextBoxColumn acCode5 = new DataGridViewTextBoxColumn();
      this.DataGridViewColumnAddPro(acCode1, RfRangWin.DataGridName[Class1.English_En, 0]);
      acCode1.Width = 40;
      this.DataGridViewColumnAddPro(acCode2, RfRangWin.DataGridName[Class1.English_En, 1]);
      this.DataGridViewColumnAddPro(acCode3, RfRangWin.DataGridName[Class1.English_En, 2]);
      this.DataGridViewColumnAddPro(acCode4, RfRangWin.DataGridName[Class1.English_En, 3]);
      this.DataGridViewColumnAddPro(acCode5, RfRangWin.DataGridName[Class1.English_En, 4]);
      this.dataGridView1.Rows.Add(2);
      this.dataGridView1.Rows[0].Cells[0].Value = (object) "150M";
      this.dataGridView1.Rows[0].Cells[1].Value = (object) "134.000";
      this.dataGridView1.Rows[0].Cells[2].Value = (object) "174.000";
      this.dataGridView1.Rows[0].Cells[3].Value = (object) "134.000";
      this.dataGridView1.Rows[0].Cells[4].Value = (object) "174.000";
      this.dataGridView1.Rows[1].Cells[0].Value = (object) "250M";
      this.dataGridView1.Rows[1].Cells[1].Value = (object) "200.000";
      this.dataGridView1.Rows[1].Cells[2].Value = (object) "260.000";
      this.dataGridView1.Rows[1].Cells[3].Value = (object) "200.000";
      this.dataGridView1.Rows[1].Cells[4].Value = (object) "260.000";
      this.dataGridView1.Rows[2].Cells[0].Value = (object) "450M";
      this.dataGridView1.Rows[2].Cells[1].Value = (object) "400.000";
      this.dataGridView1.Rows[2].Cells[2].Value = (object) "525.000";
      this.dataGridView1.Rows[2].Cells[3].Value = (object) "400.000";
      this.dataGridView1.Rows[2].Cells[4].Value = (object) "525.000";
    }

    private void DisdataGridViewPro(string Datastr, int i)
    {
      string StrTemp1 = Class2.StringChgPro(Datastr.Substring(0, 8), 4);
      string StrTemp2 = Class2.StringChgPro(Datastr.Substring(8, 8), 4);
      string StrTemp3 = Class2.StringChgPro(Datastr.Substring(16, 8), 4);
      string StrTemp4 = Class2.StringChgPro(Datastr.Substring(24, 8), 4);
      try
      {
        int int32 = Convert.ToInt32(StrTemp1, 16);
        int32 = Convert.ToInt32(StrTemp2, 16);
        int32 = Convert.ToInt32(StrTemp3, 16);
        int32 = Convert.ToInt32(StrTemp4, 16);
        if (StrTemp1 == "FFFFFFFF" || StrTemp1 == "00000000")
        {
          this.dataGridView1.Rows[i].Cells[1].Value = (object) "";
          this.dataGridView1.Rows[i].Cells[2].Value = (object) "";
          this.dataGridView1.Rows[i].Cells[3].Value = (object) "";
          this.dataGridView1.Rows[i].Cells[4].Value = (object) "";
        }
        else
        {
          string str1 = Class2.StringChgFrePro(StrTemp1, 5);
          this.dataGridView1.Rows[i].Cells[1].Value = (object) str1;
          if (StrTemp2 == "FFFFFFFF" || StrTemp2 == "00000000")
          {
            this.dataGridView1.Rows[i].Cells[2].Value = (object) "";
          }
          else
          {
            string str2 = Class2.StringChgFrePro(StrTemp2, 5);
            this.dataGridView1.Rows[i].Cells[2].Value = (object) str2;
          }
          if (StrTemp3 == "FFFFFFFF" || StrTemp3 == "00000000")
          {
            this.dataGridView1.Rows[i].Cells[3].Value = (object) "";
          }
          else
          {
            string str3 = Class2.StringChgFrePro(StrTemp3, 5);
            this.dataGridView1.Rows[i].Cells[3].Value = (object) str3;
          }
          if (StrTemp4 == "FFFFFFFF" || StrTemp4 == "00000000")
          {
            this.dataGridView1.Rows[i].Cells[4].Value = (object) "";
          }
          else
          {
            string str4 = Class2.StringChgFrePro(StrTemp4, 5);
            this.dataGridView1.Rows[i].Cells[4].Value = (object) str4;
          }
        }
      }
      catch
      {
      }
    }

    private void LoadToneFileDataDisPro()
    {
      int[,] numArray = new int[3, 3];
      string[] strArray = Class1.ReadFileDataPro(this.GiFileNameRang).Split('\r');
      int num = Class1.FreBandBegAddr / Class1.ConOneRowDatCt;
      int index = Class1.FielBegRow + num;
      string str1 = Class2.AutoAdd_n_Pro(strArray[index]);
      string str2 = str1.Substring(Class1.ConUseChDatSta + 1, str1.Length - Class1.ConUseChDatSta - 1);
      string str3 = Class2.AutoAdd_n_Pro(strArray[index + 1]);
      string str4 = str3.Substring(Class1.ConUseChDatSta + 1, str3.Length - Class1.ConUseChDatSta - 1);
      string str5 = str2 + str4;
      if (str5.Length >= 96)
        str5 = str5.Substring(0, 96);
      this.DisdataGridViewPro(str5.Substring(0, 32), 0);
      this.DisdataGridViewPro(str5.Substring(32, 32), 1);
      this.DisdataGridViewPro(str5.Substring(64, 32), 2);
    }

    private void SetContrlAs_arrPro()
    {
      this.Button_Arr = new Button[3];
      this.Button_Arr[0] = this.button1;
      this.Button_Arr[1] = this.button2;
      this.Button_Arr[2] = this.button3;
    }

    private void load_GroBox1_ButtonPro()
    {
      for (int index = 0; index <= 2; ++index)
        this.Button_Arr[index].Text = RfRangWin.Button_EngCh[Class1.English_En, index];
    }

    private void comboBox1_SelectedIndexSetPro()
    {
      int[,] numArray = new int[2, 12]
      {
        {
          136,
          240,
          400,
          400,
          200,
          245,
          144,
          144,
          420,
          430,
          430,
          430
        },
        {
          174,
          260,
          480,
          520,
          260,
          246,
          146,
          148,
          450,
          432,
          440,
          450
        }
      };
      for (int index = 0; index <= 11; ++index)
      {
        numArray[0, index] *= 100000;
        numArray[1, index] *= 100000;
      }
      if (Class1.FreBandData[0, 0] != 0)
      {
        if (Class1.FreBandData[1, 0] != 0)
        {
          if (Class1.FreBandData[0, 0] < numArray[0, 0] || Class1.FreBandData[0, 1] > numArray[1, 0])
            return;
          if (Class1.FreBandData[1, 0] >= numArray[0, 1] && Class1.FreBandData[1, 1] <= numArray[1, 1])
            this.comboBox1.SelectedIndex = 1;
          else if (Class1.FreBandData[1, 0] >= numArray[0, 4] && Class1.FreBandData[1, 1] <= numArray[1, 4])
            this.comboBox1.SelectedIndex = 2;
          else
            this.comboBox1.SelectedIndex = 1;
        }
        else if (Class1.FreBandData[2, 0] != 0)
        {
          if (Class1.FreBandData[0, 0] >= numArray[0, 6] && Class1.FreBandData[0, 1] <= numArray[1, 6])
          {
            if (Class1.FreBandData[2, 0] >= numArray[0, 9] && Class1.FreBandData[2, 1] <= numArray[1, 9])
              this.comboBox1.SelectedIndex = 8;
            else if (Class1.FreBandData[2, 0] >= numArray[0, 10] && Class1.FreBandData[2, 1] <= numArray[1, 10])
              this.comboBox1.SelectedIndex = 9;
            else
              this.comboBox1.SelectedIndex = 0;
          }
          else if (Class1.FreBandData[0, 0] >= numArray[0, 7] && Class1.FreBandData[0, 1] <= numArray[1, 7])
          {
            if (Class1.FreBandData[2, 0] >= numArray[0, 9] && Class1.FreBandData[2, 1] <= numArray[1, 9])
              this.comboBox1.SelectedIndex = 8;
            else if (Class1.FreBandData[2, 0] >= numArray[0, 11] && Class1.FreBandData[2, 1] <= numArray[1, 11])
              this.comboBox1.SelectedIndex = 11;
            else if (Class1.FreBandData[2, 0] >= numArray[0, 8] && Class1.FreBandData[2, 1] <= numArray[1, 8])
              this.comboBox1.SelectedIndex = 10;
            else
              this.comboBox1.SelectedIndex = 4;
          }
          else
          {
            if (Class1.FreBandData[0, 0] < numArray[0, 0] || Class1.FreBandData[0, 1] > numArray[1, 0])
              return;
            if (Class1.FreBandData[2, 0] >= numArray[0, 2] && Class1.FreBandData[2, 1] <= numArray[1, 2])
              this.comboBox1.SelectedIndex = 0;
            else if (Class1.FreBandData[2, 0] >= numArray[0, 3] && Class1.FreBandData[2, 1] <= numArray[1, 3])
              this.comboBox1.SelectedIndex = 3;
            else
              this.comboBox1.SelectedIndex = 4;
          }
        }
        else
          this.comboBox1.SelectedIndex = 4;
      }
      else if (Class1.FreBandData[1, 0] != 0)
      {
        if (Class1.FreBandData[1, 0] >= numArray[0, 5] && Class1.FreBandData[1, 1] < numArray[1, 5])
          this.comboBox1.SelectedIndex = 6;
        else
          this.comboBox1.SelectedIndex = 5;
      }
      else
      {
        if (Class1.FreBandData[2, 0] == 0)
          return;
        this.comboBox1.SelectedIndex = 7;
      }
    }

    private void i_Load(object sender, EventArgs e)
    {
      this.FirstLoad = 1;
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.SetContrlAs_arrPro();
      if (!Class1.EditEn)
      {
        this.button2.Visible = false;
        this.button3.Visible = false;
        this.KeyPreview = true;
      }
      else
      {
        this.button2.Visible = true;
        this.button3.Visible = true;
        this.KeyPreview = false;
      }
      this.load_GroBox1_ButtonPro();
      this.label1.Text = RfRangWin.Other_EngCh[Class1.English_En, 0];
      this.Text = RfRangWin.Other_EngCh[Class1.English_En, 1];
      this.loadDataGridViewPro();
      公共控件操作.Load_CmbBoxNPro(this.comboBox1, RfRangWin.FreBandSel, RfRangWin.FreBandSel.Length - 1);
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox2, this.FreBandSelName, this.FreBandSelName.GetLength(1) - 1);
      this.LoadToneFileDataDisPro();
      this.comboBox1_SelectedIndexSetPro();
      if (!Class1.EditEn)
      {
        this.comboBox2.Visible = false;
        this.comboBox1.Visible = false;
      }
      this.FirstLoad = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.textBox2.Text == "FF88" || this.textBox2.Text == "13636922224" || Class1.FactoryEn || Class1.GbOwnUsedEn)
      {
        this.label1.Visible = false;
        this.textBox2.Visible = false;
        this.button1.Visible = false;
        Class1.EditEn = true;
        this.button2.Visible = true;
        this.button3.Visible = true;
        this.comboBox1.Visible = true;
      }
      else
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 1], Class1.RadioName);
        this.textBox2.Text = "";
        Class1.EditEn = false;
        this.comboBox1.Visible = false;
      }
    }

    private void textBox2_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void RfRangWin_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != 'p')
        return;
      this.label1.Visible = true;
      this.textBox2.Visible = true;
      this.button1.Visible = true;
      Class1.EditEn = false;
      this.textBox2.Focus();
      this.KeyPreview = false;
    }

    private void RfRangWin_DoubleClick(object sender, EventArgs e)
    {
    }

    private void textBox2_KeyUp(object sender, KeyEventArgs e)
    {
    }

    private void textBox2_KeyDown_1(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      this.button1_Click(sender, (EventArgs) e);
      e.Handled = true;
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
      if (!Class1.EditEn)
        return;
      int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
      if (this.dataGridView1.CurrentCell.ColumnIndex < 1 || this.dataGridView1.CurrentCell.ColumnIndex > 4 || this.dataGridView1.CurrentCell.ColumnIndex != 1 && this.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString() == "")
        return;
      Rectangle displayRectangle = this.dataGridView1.GetCellDisplayRectangle(this.dataGridView1.CurrentCell.ColumnIndex, this.dataGridView1.CurrentCell.RowIndex, false);
      this.textBox1.Left = displayRectangle.Left + 3;
      this.textBox1.Top = displayRectangle.Top + 17;
      this.textBox1.Width = displayRectangle.Width;
      this.textBox1.Height = displayRectangle.Height;
      this.textBox1.MaxLength = 9;
      this.textBox1.Visible = true;
      this.textBox1.Focus();
      this.textBox1.Text = this.GetCurrCellText();
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool flag = Class1.KeyUseFul0_9ChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar != '\r')
        return;
      if (this.DataUseFulRfChk(this.textBox1.Text, this.dataGridView1.CurrentCell.RowIndex) == "BandOver")
      {
        int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 0] + (object) Class1.FreBand[0, rowIndex] + ".0MHZ-" + (object) Class1.FreBand[1, rowIndex] + ".0MHZ ]", Class1.RadioName);
        this.textBox1.Text = this.dataGridView1.Rows[rowIndex].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
        this.textBox1.SelectionLength = this.textBox1.Text.Length;
        this.textBox1.Focus();
      }
      else
      {
        this.textBox1.Visible = false;
        this.dataGridView1.Focus();
      }
    }

    private string DataUseFulRfChk(string StrTemp, int i)
    {
      try
      {
        if (StrTemp == "")
          return StrTemp;
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num1 = Convert.ToDouble(StrTemp);
        if (num1 < (double) Class1.FreBand[0, i] || num1 > (double) Class1.FreBand[1, i])
        {
          StrTemp = "BandOver";
          return StrTemp;
        }
        double num2 = num1 * 1000.0;
        if (num2 % 2.5 != 0.0 && num2 % 6.25 != 0.0)
        {
          int num3 = (int) (num2 / 2.5);
          int num4 = (int) (num2 / 6.25);
          int num5 = num3 * 250;
          int num6 = num4 * 625;
          StrTemp = (num6 <= num5 ? (double) num5 / 100000.0 : (double) num6 / 100000.0).ToString();
        }
        StrTemp = Class2.AutoAddFreBytePro(StrTemp);
      }
      catch
      {
        StrTemp = "";
      }
      return StrTemp;
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      int rowIndex1 = this.dataGridView1.CurrentCell.RowIndex;
      if (rowIndex1 > 2)
        return;
      string str1 = this.DataUseFulRfChk(this.textBox1.Text, rowIndex1);
      if (str1 == "BandOver")
      {
        int rowIndex2 = this.dataGridView1.CurrentCell.RowIndex;
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 0] + (object) Class1.FreBand[0, rowIndex2] + ".0MHZ-" + (object) Class1.FreBand[1, rowIndex2] + ".0MHZ]", Class1.RadioName);
        this.textBox1.Text = this.dataGridView1.Rows[rowIndex2].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
        this.textBox1.SelectionLength = this.textBox1.Text.Length;
        this.textBox1.Focus();
      }
      else
      {
        string str2 = str1.Replace(",", ".");
        string str3 = this.dataGridView1.Rows[rowIndex1].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
        if (str2 == "")
        {
          if (this.dataGridView1.CurrentCell.ColumnIndex == 1 || this.dataGridView1.CurrentCell.ColumnIndex == 2)
          {
            for (int index = 1; index <= 4; ++index)
              this.dataGridView1.Rows[rowIndex1].Cells[index].Value = (object) "";
          }
          else if (this.dataGridView1.CurrentCell.ColumnIndex == 3 || this.dataGridView1.CurrentCell.ColumnIndex == 4)
          {
            for (int index = 3; index <= 4; ++index)
              this.dataGridView1.Rows[rowIndex1].Cells[index].Value = (object) "";
          }
        }
        else if (str3 == "")
        {
          if (this.dataGridView1.CurrentCell.ColumnIndex == 1)
          {
            string str4 = Class2.AutoAddFreBytePro(Class1.FreBand[1, rowIndex1].ToString());
            this.dataGridView1.Rows[rowIndex1].Cells[2].Value = (object) str4;
            this.dataGridView1.Rows[rowIndex1].Cells[4].Value = (object) str4;
            string str5 = Class2.AutoAddFreBytePro(Class1.FreBand[0, rowIndex1].ToString());
            this.dataGridView1.Rows[rowIndex1].Cells[3].Value = (object) str5;
          }
          else if (this.dataGridView1.CurrentCell.ColumnIndex == 3)
          {
            string str6 = Class2.AutoAddFreBytePro(Class1.FreBand[1, rowIndex1].ToString());
            this.dataGridView1.Rows[rowIndex1].Cells[4].Value = (object) str6;
          }
        }
        this.dataGridView1.Rows[rowIndex1].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value = (object) str2;
      }
    }

    private string ChgChStringPro(int i)
    {
      string str = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
      string[] strArray = new string[4];
      for (int index = 1; index <= 4; ++index)
        strArray[index - 1] = this.dataGridView1.Rows[i].Cells[index].Value.ToString();
      if (strArray[0] == "")
        return str;
      strArray[0] = Class2.ChgRxFreToDataPro(strArray[0]);
      strArray[1] = !(strArray[1] == "") ? Class2.ChgRxFreToDataPro(strArray[1]) : "FFFFFFFF";
      strArray[2] = !(strArray[2] == "") ? Class2.ChgRxFreToDataPro(strArray[2]) : "FFFFFFFF";
      strArray[3] = !(strArray[3] == "") ? Class2.ChgRxFreToDataPro(strArray[3]) : "FFFFFFFF";
      strArray[0] = strArray[0] + strArray[1] + strArray[2] + strArray[3];
      return Class1.Chga_z_ToA_Z(strArray[0]);
    }

    private void SaveCurrenChData()
    {
      string str1 = this.ChgChStringPro(0);
      string str2 = this.ChgChStringPro(1);
      string str3 = this.ChgChStringPro(2);
      string[] StrData = Class1.ReadFileDataPro(this.GiFileNameRang).Split('\r');
      int num = Class1.FreBandBegAddr / Class1.ConOneRowDatCt;
      int index1 = Class1.FielBegRow + num;
      StrData[index1] = Class2.AutoAdd_n_Pro(StrData[index1]);
      string str4 = StrData[index1].Substring(0, 7) + str1 + str2;
      StrData[index1] = str4;
      int index2 = index1 + 1;
      string str5 = Class2.AutoAdd_n_Pro(StrData[index2]);
      string str6 = str5.Substring(0, 7) + str3 + str5.Substring(str5.Length - 32, 32);
      StrData[index2] = str6;
      Class1.SaveFileDataPro(this.GiFileNameRang, StrData);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.SaveCurrenChData();
      this.Close();
    }

    private void button3_Click(object sender, EventArgs e) => this.Close();

    private void FrerangClearPro(int j)
    {
      string str = "";
      this.dataGridView1.Rows[j].Cells[1].Value = (object) str;
      this.dataGridView1.Rows[j].Cells[2].Value = (object) str;
      this.dataGridView1.Rows[j].Cells[3].Value = (object) str;
      this.dataGridView1.Rows[j].Cells[4].Value = (object) str;
    }

    private void FrerangSetPro(int i, int j)
    {
      string str1 = Class2.AutoAddFreBytePro(Class1.FreBand1[0, i].ToString());
      this.dataGridView1.Rows[j].Cells[1].Value = (object) str1;
      string str2 = Class2.AutoAddFreBytePro(Class1.FreBand1[1, i].ToString());
      this.dataGridView1.Rows[j].Cells[2].Value = (object) str2;
      this.dataGridView1.Rows[j].Cells[4].Value = (object) str2;
      string str3 = Class2.AutoAddFreBytePro(Class1.FreBand1[0, i].ToString());
      this.dataGridView1.Rows[j].Cells[3].Value = (object) str3;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.FirstLoad == 1)
        return;
      if (this.comboBox1.SelectedIndex != this.comboBox2.SelectedIndex)
        this.comboBox2.SelectedIndex = this.comboBox1.SelectedIndex;
      switch (this.comboBox1.SelectedIndex)
      {
        case 0:
          this.FrerangSetPro(0, 0);
          this.FrerangSetPro(2, 2);
          this.FrerangClearPro(1);
          break;
        case 1:
          this.FrerangSetPro(0, 0);
          this.FrerangSetPro(1, 1);
          this.FrerangClearPro(2);
          break;
        case 2:
          this.FrerangSetPro(0, 0);
          this.FrerangSetPro(4, 1);
          this.FrerangClearPro(2);
          break;
        case 3:
          this.FrerangSetPro(0, 0);
          this.FrerangSetPro(3, 2);
          this.FrerangClearPro(1);
          break;
        case 4:
          this.FrerangSetPro(0, 0);
          this.FrerangClearPro(1);
          this.FrerangClearPro(2);
          break;
        case 5:
          this.FrerangSetPro(4, 1);
          this.FrerangClearPro(0);
          this.FrerangClearPro(2);
          break;
        case 6:
          this.FrerangSetPro(5, 1);
          this.FrerangClearPro(0);
          this.FrerangClearPro(2);
          break;
        case 7:
          this.FrerangSetPro(3, 2);
          this.FrerangClearPro(0);
          this.FrerangClearPro(1);
          break;
        case 8:
          this.FrerangSetPro(6, 0);
          this.FrerangSetPro(9, 2);
          this.FrerangClearPro(1);
          break;
        case 9:
          this.FrerangSetPro(6, 0);
          this.FrerangSetPro(10, 2);
          this.FrerangClearPro(1);
          break;
        case 10:
          this.FrerangSetPro(7, 0);
          this.FrerangSetPro(8, 2);
          this.FrerangClearPro(1);
          break;
        case 11:
          this.FrerangSetPro(7, 0);
          this.FrerangSetPro(11, 2);
          this.FrerangClearPro(1);
          break;
      }
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox1.SelectedIndex == this.comboBox2.SelectedIndex)
        return;
      this.comboBox1.SelectedIndex = this.comboBox2.SelectedIndex;
    }
  }
}
