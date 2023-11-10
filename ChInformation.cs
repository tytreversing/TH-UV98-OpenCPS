// Decompiled with JetBrains decompiler
// Type: _8890DTest.ChInformtion
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _8890DTest
{
  public class ChInformtion : Form
  {
    public string GiFileName = "8890D_TempFile.icf";
    public string GiCurFileName = "8890D_TempFile.icf";
    public string GiFilePath;
    public bool GbFirstchg = true;
    private ChinfDetail ChWin = new ChinfDetail();
    private RadioSet SetWin = new RadioSet();
    private DtmfMenu DtmfWin = new DtmfMenu();
    private Tone2Menu Tone2Win = new Tone2Menu();
    private Ton5Menu1 Tone5Win = new Ton5Menu1();
    public static string[,] DataGridName = new string[2, 12]
    {
      {
        "信道",
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
        "信道名称"
      },
      {
        "No. ",
        "  Rx Fre",
        "  Tx Fre",
        "  Decode",
        "  Encode",
        "Scramble",
        "Power",
        "   B_Lock",
        "Step",
        "Wide",
        " Signal",
        " Ch Name"
      }
    };
    public static string[,] TreedName = new string[2, 8]
    {
      {
        "信道信息",
        "频率信道",
        "整机设定",
        "DTMF",
        "2 音",
        "5 音",
        "频段范围      ",
        "收音机 "
      },
      {
        "Channel  ",
        "VFo　Ch ",
        "Basic 　",
        "DTMF",
        "2Tone",
        "5Tone",
        "Frequency Rang",
        "Radio "
      }
    };
    private string[,] MessBoxName = new string[2, 4]
    {
      {
        "当前频率超出范围，请重新输入！[",
        "第",
        "行数据非法！",
        "请先读频!"
      },
      {
        "Frequency Out Off Rang  [",
        "No:",
        "Line Data Error!",
        "Read First!"
      }
    };
    private IContainer components = (IContainer) null;
    private GroupBox groupBox3;
    private GroupBox groupBox2;
    private TreeView treeView1;
    public DataGridView dataGridView1;
    public TextBox textBox1;
    public ComboBox comboBox2;
    public ComboBox comboBox1;
    public ComboBox comboBox3;

    public ChInformtion() => this.InitializeComponent();

    public void SaveAllDataToTempFile1(string FileNameTemp)
    {
      this.GiCurFileName = FileNameTemp;
      string[] strArray = Class1.ReadFileDataPro(FileNameTemp).Split('\r');
      string[] StrData = Class1.ReadFileDataPro(this.GiFilePath + "ConTempFile.icf").Split('\r');
      int num = StrData.GetLength(0) - 1;
      int index1;
      for (index1 = strArray.GetLength(0) - 1; index1 != 0; --index1)
      {
        string str = strArray[index1];
        if (str.Length != 0 && str != "\n" && str != "n")
          break;
      }
      if (num > index1)
      {
        for (int index2 = 0; index2 < index1; ++index2)
          StrData[index2] = strArray[index2];
      }
      Class1.SaveFileDataPro(this.GiFilePath + "ConTempFile.icf", StrData);
      this.GiFileName = this.GiFilePath + "ConTempFile.icf";
    }

    public void SaveAllDataToTempFile(string FileNameTemp)
    {
      this.GiCurFileName = FileNameTemp;
      Class1.SaveFileDataPro(this.GiFilePath + "ConTempFile.icf", Class1.ReadFileDataPro(FileNameTemp).Split('\r'));
      this.GiFileName = this.GiFilePath + "ConTempFile.icf";
    }

    public void SaveDataFile(string FileNameTemp)
    {
      string[] StrData = Class1.ReadFileDataPro(this.GiFilePath + "ConTempFile.icf").Split('\r');
      Class1.SaveFileDataPro(FileNameTemp, StrData);
    }

    private void DataGridViewColumnAddPro(DataGridViewTextBoxColumn acCode, string name)
    {
      acCode.HeaderText = name;
      acCode.Width = 65;
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
      DataGridViewTextBoxColumn acCode6 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode7 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode8 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode9 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode10 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode11 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn acCode12 = new DataGridViewTextBoxColumn();
      this.DataGridViewColumnAddPro(acCode1, ChInformtion.DataGridName[Class1.English_En, 0]);
      acCode1.Width = 40;
      this.DataGridViewColumnAddPro(acCode2, ChInformtion.DataGridName[Class1.English_En, 1]);
      acCode2.Width = 80;
      this.DataGridViewColumnAddPro(acCode3, ChInformtion.DataGridName[Class1.English_En, 2]);
      acCode3.Width = 80;
      this.DataGridViewColumnAddPro(acCode12, ChInformtion.DataGridName[Class1.English_En, 3]);
      acCode12.Width = 80;
      this.DataGridViewColumnAddPro(acCode4, ChInformtion.DataGridName[Class1.English_En, 4]);
      this.DataGridViewColumnAddPro(acCode5, ChInformtion.DataGridName[Class1.English_En, 5]);
      this.DataGridViewColumnAddPro(acCode6, ChInformtion.DataGridName[Class1.English_En, 6]);
      this.DataGridViewColumnAddPro(acCode7, ChInformtion.DataGridName[Class1.English_En, 7]);
      acCode7.Width = 80;
      this.DataGridViewColumnAddPro(acCode8, ChInformtion.DataGridName[Class1.English_En, 8]);
      this.DataGridViewColumnAddPro(acCode9, ChInformtion.DataGridName[Class1.English_En, 9]);
      this.DataGridViewColumnAddPro(acCode10, ChInformtion.DataGridName[Class1.English_En, 10]);
      this.DataGridViewColumnAddPro(acCode11, ChInformtion.DataGridName[Class1.English_En, 11]);
      acCode11.Width = 110;
      this.dataGridView1.Rows.Add(199);
      int num = 0;
      while (num <= 35)
        ++num;
    }

    private void loadtreeViewPro()
    {
      TreeNode node1 = new TreeNode(Class1.RadioName);
      this.treeView1.Nodes.Add(node1);
      TreeNode node2 = new TreeNode(ChInformtion.TreedName[Class1.English_En, 0]);
      TreeNode node3 = new TreeNode(ChInformtion.TreedName[Class1.English_En, 1]);
      TreeNode node4 = new TreeNode(ChInformtion.TreedName[Class1.English_En, 2]);
      TreeNode node5 = new TreeNode(ChInformtion.TreedName[Class1.English_En, 3]);
      TreeNode node6 = new TreeNode(ChInformtion.TreedName[Class1.English_En, 4]);
      TreeNode node7 = new TreeNode(ChInformtion.TreedName[Class1.English_En, 5]);
      TreeNode node8 = new TreeNode(ChInformtion.TreedName[Class1.English_En, 6]);
      TreeNode node9 = new TreeNode(ChInformtion.TreedName[Class1.English_En, 7]);
      node1.Nodes.Add(node2);
      node1.Nodes.Add(node3);
      node1.Nodes.Add(node4);
      node1.Nodes.Add(node5);
      node1.Nodes.Add(node6);
      node1.Nodes.Add(node7);
      node1.Nodes.Add(node8);
      node1.Nodes.Add(node9);
      this.treeView1.ExpandAll();
      this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[0];
    }

    private void loadtreeViewPro1()
    {
    }

    private void loadDefaulFilePro()
    {
      Class1.GetFreDefFilePro("DefaulFile.icf");
      using (FileStream fileStream = File.Create("ConTempFile.icf"))
      {
        byte[] bytes = new UTF8Encoding(true).GetBytes("COM1\r\n#Comment=" + Class1.CompanyName + "  2013\r\n#MapRev=1\r\n000010000050000c0000000c00000100000000\r");
        fileStream.Write(bytes, 0, bytes.Length);
      }
      this.SaveAllDataToTempFile("DefaulFile.icf");
    }

    public void DisdataGridViewPro(string Datastr, int i)
    {
      if (Datastr == "")
      {
        for (int index = 0; index <= 11; ++index)
          this.dataGridView1.Rows[i].Cells[index].Value = (object) "";
      }
      else
      {
        string StrTemp1 = Class2.StringChgPro(Datastr.Substring(0, 8), 4);
        string StrTemp2 = Class2.StringChgPro(Datastr.Substring(8, 8), 4);
        string StrTemp3 = Class2.StringChgPro(Datastr.Substring(16, 4), 2);
        string StrTemp4 = Class2.StringChgPro(Datastr.Substring(20, 4), 2);
        string str1 = Datastr.Substring(24, 2);
        string str2 = Datastr.Substring(26, 2);
        string str3 = Datastr.Substring(28, 2);
        Datastr.Substring(30, 12);
        try
        {
          int int32_1 = Convert.ToInt32(StrTemp1, 16);
          int32_1 = Convert.ToInt32(StrTemp2, 16);
          int int32_2 = Convert.ToInt32(StrTemp3, 16);
          int int32_3 = Convert.ToInt32(StrTemp4, 16);
          string str4 = Class2.AutoRetFreBytePro(Class2.StringChgFrePro(StrTemp1, 5), 0);
          this.dataGridView1.Rows[i].Cells[1].Value = (object) str4;
          string str5 = Class2.AutoRetFreBytePro(!(StrTemp2 == "FFFFFFFF") ? Class2.StringChgFrePro(StrTemp2, 5) : "", 2);
          this.dataGridView1.Rows[i].Cells[2].Value = (object) str5;
          string str6 = Class1.GBKTOHanzi_ChangePro(Datastr.Substring(30, 32));
          if (str6 == "                ")
            str6 = "";
          this.dataGridView1.Rows[i].Cells[11].Value = (object) str6;
          int num = int32_3 & 49152;
          string str7 = (num & 16384) == 0 ? Class2.Rx_TxChgToSubDataPro(StrTemp3, 0) : Class2.Rx_TxChgToSubDataPro(StrTemp3, 1);
          this.dataGridView1.Rows[i].Cells[3].Value = (object) str7;
          string str8 = (num & 32768) == 0 ? Class2.Rx_TxChgToSubDataPro(StrTemp4, 0) : Class2.Rx_TxChgToSubDataPro(StrTemp4, 1);
          this.dataGridView1.Rows[i].Cells[4].Value = (object) str8;
          int index1 = (int32_2 & 61440) >> 12;
          if (index1 >= 9)
            index1 = 0;
          this.dataGridView1.Rows[i].Cells[5].Value = (object) Class1.ScrChSet_EngCh[Class1.English_En, index1];
          int int32_4 = Convert.ToInt32(str1, 16);
          int index2 = (int32_4 & 12) >> 2;
          this.dataGridView1.Rows[i].Cells[7].Value = (object) Class1.BusyKind_EngCh[Class1.English_En, index2];
          int index3 = (int32_4 & 48) >> 4;
          this.dataGridView1.Rows[i].Cells[9].Value = (object) Class1.WideNar_EngCh[Class1.English_En, index3];
          int index4 = (int32_4 & 192) >> 6;
          this.dataGridView1.Rows[i].Cells[6].Value = (object) Class1.TxPower_EngCh[Class1.English_En, index4];
          int index5 = (Convert.ToInt32(str2, 16) & 24) >> 3;
          this.dataGridView1.Rows[i].Cells[10].Value = (object) Class1.OptSig_EngCh[Class1.English_En, index5];
          int index6 = Convert.ToInt32(str3, 16) & 15;
          this.dataGridView1.Rows[i].Cells[8].Value = (object) Class1.ConStep[index6];
        }
        catch
        {
          ++i;
          int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 1] + (object) i + this.MessBoxName[Class1.English_En, 2], Class1.RadioName);
        }
      }
    }

    public void LoadFileDataDisPro()
    {
      byte[] numArray = new byte[4];
      string[] n = Class1.ReadFileDataPro(this.GiFileName).Split('\r');
      Class2.GetRfRangPro(this.GiFileName);
      this.ContrlVisibleDisPro();
      int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
      int scrollingRowIndex1 = this.dataGridView1.FirstDisplayedScrollingRowIndex;
      int num1 = scrollingRowIndex1 + 20;
      if (num1 > 199)
        num1 = 199;
      for (; scrollingRowIndex1 <= num1; ++scrollingRowIndex1)
      {
        string Datastr;
        try
        {
          if (Class2.StringChUsefulPro(Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + Class1.ChinfBegAddr / Class1.ConOneRowDatCt]), scrollingRowIndex1) == 0)
          {
            Datastr = "";
          }
          else
          {
            string str = Class2.GetOneChStringPro(n, scrollingRowIndex1) + Class2.GetOneChStringAddNamePro(n, scrollingRowIndex1);
            Datastr = str.Substring(0, str.Length - 12) + "202020202020";
          }
        }
        catch
        {
          Datastr = "";
        }
        this.DisdataGridViewPro(Datastr, scrollingRowIndex1);
      }
      int scrollingRowIndex2 = this.dataGridView1.FirstDisplayedScrollingRowIndex;
      for (int index = scrollingRowIndex2; scrollingRowIndex2 <= index + 20 && scrollingRowIndex2 <= 199; ++scrollingRowIndex2)
      {
        if (scrollingRowIndex2 > 199)
        {
          int num2 = scrollingRowIndex2 - 199;
          if (0 == num2 % 2)
          {
            int num3 = num2 / 2;
            this.dataGridView1.Rows[scrollingRowIndex2].Cells[0].Value = (object) ("U" + (object) num3);
          }
          else
          {
            int num4 = num2 / 2 + 1;
            this.dataGridView1.Rows[scrollingRowIndex2].Cells[0].Value = (object) ("L" + (object) num4);
          }
        }
        else
          this.dataGridView1.Rows[scrollingRowIndex2].Cells[0].Value = (object) (scrollingRowIndex2 + 1);
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
      ComboBo.Visible = false;
    }

    private void load_CmbBoxNPro(ComboBox cmbHelp, string[] StrArr, int Number)
    {
      for (int index = 0; index <= Number; ++index)
        cmbHelp.Items.Add((object) StrArr[index]);
      this.ComBoxResPro(cmbHelp, 0);
    }

    private void loadOtherContrlPro()
    {
      string[] StrArr = new string[104];
      this.textBox1.Visible = false;
      公共控件操作.Load_CmbBoxNPro(this.comboBox1, Class1.CtcTone, 51);
      for (int index = 0; index < Class1.DcsTone.Length; ++index)
        StrArr[index] = Class1.DcsTone[index] + "N";
      公共控件操作.Load_CmbBoxNPro(this.comboBox1, StrArr, 103);
      for (int index = 0; index < Class1.DcsTone.Length; ++index)
        StrArr[index] = Class1.DcsTone[index] + "I";
      公共控件操作.Load_CmbBoxNPro(this.comboBox1, StrArr, 103);
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
      this.comboBox1.MaxLength = 5;
      this.load_CmbBoxNPro(this.comboBox2, Class1.DcsTone, 103);
      this.comboBox2.DropDownStyle = ComboBoxStyle.DropDown;
      this.comboBox2.MaxLength = 3;
      公共控件操作.load_CmbBoxNProEng_Ch1(this.comboBox3, Class1.Spkind_EngCh, Class1.Spkind_EngCh.GetLength(1) - 1);
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

    public void ContrlVisibleDisPro()
    {
      if (this.textBox1.Visible)
        this.textBox1.Visible = false;
      if (this.comboBox1.Visible)
        this.comboBox1.Visible = false;
      if (this.comboBox2.Visible)
        this.comboBox2.Visible = false;
      if (!this.comboBox3.Visible)
        return;
      this.comboBox3.Visible = false;
    }

    private void FreEditPro(char KeyDat, bool TempBit)
    {
      this.ContrlVisibleDisPro();
      Rectangle displayRectangle = this.dataGridView1.GetCellDisplayRectangle(this.dataGridView1.CurrentCell.ColumnIndex, this.dataGridView1.CurrentCell.RowIndex, false);
      this.textBox1.Left = displayRectangle.Left + 3;
      this.textBox1.Top = displayRectangle.Top + 17;
      this.textBox1.Width = displayRectangle.Width;
      this.textBox1.Height = displayRectangle.Height;
      this.textBox1.TextAlign = HorizontalAlignment.Center;
      this.textBox1.Visible = true;
      this.textBox1.Focus();
      string currCellText;
      if (TempBit)
      {
        if (KeyDat >= '0' && KeyDat <= '9')
        {
          currCellText = KeyDat.ToString();
        }
        else
        {
          currCellText = this.GetCurrCellText();
          this.textBox1.SelectionLength = this.textBox1.Text.Length;
        }
      }
      else
      {
        currCellText = this.GetCurrCellText();
        this.textBox1.SelectionLength = this.textBox1.Text.Length;
      }
      this.TextBoxResPro(this.textBox1, 9, currCellText);
      if (this.textBox1.Text.Length != 1)
        return;
      this.textBox1.SelectionStart = this.textBox1.Text.Length;
    }

    private void SetCombo_XListPro(
      ComboBox comboBox_x,
      string[] ArrTemp,
      string StringTemp,
      bool AddEn)
    {
      int num = 0;
      if (AddEn)
        comboBox_x.Items.Clear();
      for (int index = 0; index < ArrTemp.Length; ++index)
      {
        if (AddEn)
          comboBox_x.Items.Add((object) ArrTemp[index]);
        if (ArrTemp[index] == StringTemp)
          num = index;
      }
      if (num >= ArrTemp.Length)
        comboBox_x.SelectedIndex = 0;
      else
        comboBox_x.SelectedIndex = num;
    }

    private void DisComBoTextToDataGridPro(ComboBox comboBox_x) => this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value = (object) comboBox_x.Text;

    private void LoadContrRetPro(char KeyData, bool TempBit)
    {
      int index = this.dataGridView1.CurrentRow.Index;
      string str = this.dataGridView1[1, index].Value != null ? this.dataGridView1[1, index].Value.ToString() : "";
      if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
      {
        this.ContrlVisibleDisPro();
        ChinfDetail chinfDetail = new ChinfDetail();
        chinfDetail.GiCurrentCh = this.dataGridView1.CurrentCell.RowIndex;
        chinfDetail.GiFileName1 = this.GiFileName;
        int num = (int) chinfDetail.ShowDialog((IWin32Window) this);
        chinfDetail.Dispose();
        this.LoadFileDataDisPro();
      }
      else
      {
        if (str == "")
          this.dataGridView1.CurrentCell = this.dataGridView1.CurrentRow.Cells[1];
        if (this.dataGridView1.CurrentCell.ColumnIndex == 2 || this.dataGridView1.CurrentCell.ColumnIndex == 1)
          this.FreEditPro(KeyData, TempBit);
        else if (3 == this.dataGridView1.CurrentCell.ColumnIndex || 4 == this.dataGridView1.CurrentCell.ColumnIndex)
        {
          this.ContrlVisibleDisPro();
          Rectangle displayRectangle = this.dataGridView1.GetCellDisplayRectangle(this.dataGridView1.CurrentCell.ColumnIndex, this.dataGridView1.CurrentCell.RowIndex, false);
          this.comboBox1.Left = displayRectangle.Left + 4;
          this.comboBox1.Top = displayRectangle.Top + 18;
          this.comboBox1.Width = displayRectangle.Width - 2;
          this.comboBox1.Height = displayRectangle.Height;
          this.comboBox1.Visible = true;
          this.comboBox1.Focus();
          string currCellText = this.GetCurrCellText();
          公共控件操作.LookCombo_XAdd_QtTDqtPro(this.comboBox1, currCellText);
          this.comboBox1.Text = currCellText;
          if (KeyData >= '0' && KeyData <= '9')
          {
            this.comboBox1.Text = KeyData.ToString();
            this.comboBox1.SelectionStart = this.comboBox1.Text.Length;
          }
          this.GbFirstchg = false;
        }
        else if (this.dataGridView1.CurrentCell.ColumnIndex >= 5 && this.dataGridView1.CurrentCell.ColumnIndex <= 10)
        {
          this.ContrlVisibleDisPro();
          Rectangle displayRectangle = this.dataGridView1.GetCellDisplayRectangle(this.dataGridView1.CurrentCell.ColumnIndex, this.dataGridView1.CurrentCell.RowIndex, false);
          this.comboBox3.Left = displayRectangle.Left + 4;
          this.comboBox3.Top = displayRectangle.Top + 18;
          this.comboBox3.Width = displayRectangle.Width - 2;
          this.comboBox3.Height = displayRectangle.Height;
          this.comboBox3.Visible = true;
          this.comboBox3.Focus();
          string currCellText = this.GetCurrCellText();
          if (5 == this.dataGridView1.CurrentCell.ColumnIndex)
            公共控件操作.SetCombo_XListProEng_Ch(this.comboBox3, Class1.ScrChSet_EngCh, currCellText, true);
          else if (6 == this.dataGridView1.CurrentCell.ColumnIndex)
            公共控件操作.SetCombo_XListProEng_Ch(this.comboBox3, Class1.TxPower_EngCh, currCellText, true);
          else if (7 == this.dataGridView1.CurrentCell.ColumnIndex)
            公共控件操作.SetCombo_XListProEng_Ch(this.comboBox3, Class1.BusyKind_EngCh, currCellText, true);
          else if (8 == this.dataGridView1.CurrentCell.ColumnIndex)
            this.SetCombo_XListPro(this.comboBox3, Class1.ConStep, currCellText, true);
          else if (9 == this.dataGridView1.CurrentCell.ColumnIndex)
          {
            公共控件操作.SetCombo_XListProEng_Ch(this.comboBox3, Class1.WideNar_EngCh, currCellText, true);
          }
          else
          {
            if (10 != this.dataGridView1.CurrentCell.ColumnIndex)
              return;
            公共控件操作.SetCombo_XListProEng_Ch(this.comboBox3, Class1.OptSig_EngCh, currCellText, true);
          }
        }
        else
        {
          if (this.dataGridView1.CurrentCell.ColumnIndex != 11)
            return;
          this.FreEditPro(KeyData, TempBit);
          this.textBox1.MaxLength = 8;
        }
      }
    }

    private int GetCombo_XListPro(string[] ArrTemp, string StringTemp)
    {
      byte comboXlistPro = 0;
      for (byte index = 0; (int) index < ArrTemp.Length; ++index)
      {
        if (ArrTemp[(int) index] == StringTemp)
          comboXlistPro = index;
      }
      if ((int) comboXlistPro >= ArrTemp.Length)
        comboXlistPro = (byte) 0;
      return (int) comboXlistPro;
    }

    private string ChgChStringPro()
    {
      string str1 = "";
      string[] n = Class1.ReadFileDataPro(this.GiFileName).Split('\r');
      int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
      string oneChStringPro = Class2.GetOneChStringPro(n, rowIndex);
      string[] strArray = new string[12];
      for (int index = 1; index <= 11; ++index)
        strArray[index - 1] = this.dataGridView1.Rows[rowIndex].Cells[index].Value != null ? this.dataGridView1.Rows[rowIndex].Cells[index].Value.ToString() : "";
      if (strArray[0] == "")
        return str1;
      strArray[0] = Class2.ChgRxFreToDataPro(strArray[0]);
      strArray[1] = Class2.ChgRxFreToDataPro(strArray[1]);
      strArray[10] = Class1.hanziTOGbk_ChangePro(strArray[10], 8);
      int comboXlistProEngCh1 = 公共控件操作.GetCombo_XListPro_Eng_Ch(Class1.BusyKind_EngCh, strArray[6]);
      int comboXlistProEngCh2 = 公共控件操作.GetCombo_XListPro_Eng_Ch(Class1.WideNar_EngCh, strArray[8]);
      int comboXlistProEngCh3 = 公共控件操作.GetCombo_XListPro_Eng_Ch(Class1.TxPower_EngCh, strArray[5]);
      int comboXlistProEngCh4 = 公共控件操作.GetCombo_XListPro_Eng_Ch(Class1.OptSig_EngCh, strArray[9]);
      int comboXlistPro = this.GetCombo_XListPro(Class1.ConStep, strArray[7]);
      string hexStr1 = Class1.DataToHexStr((long) (Convert.ToInt32(oneChStringPro.Substring(18, 2), 16) & 15 | 公共控件操作.GetCombo_XListPro_Eng_Ch(Class1.ScrChSet_EngCh, strArray[4]) << 4));
      int num1 = Convert.ToInt32(oneChStringPro.Substring(22, 2), 16) & 48;
      int num2 = 0;
      int num3 = 0;
      string str2 = strArray[2].Substring(strArray[2].Length - 1, 1);
      if (str2 == "I" || str2 == "i")
        num2 = 1;
      string str3 = strArray[3].Substring(strArray[3].Length - 1, 1);
      if (str3 == "I" || str3 == "i")
        num3 = 1;
      int num4 = num2 << 6;
      string hexStr2 = Class1.DataToHexStr((long) (num1 | num4 | num3 << 7));
      strArray[2] = Class2.ChgSubToDataPro(strArray[2]);
      strArray[3] = Class2.ChgSubToDataPro(strArray[3]);
      string hexStr3 = Class1.DataToHexStr((long) (Convert.ToInt32(oneChStringPro.Substring(24, 2), 16) & 3 | comboXlistProEngCh1 << 2 | comboXlistProEngCh2 << 4 | comboXlistProEngCh3 << 6));
      int int32 = Convert.ToInt32(oneChStringPro.Substring(26, 2), 16);
      int num5 = 0;
      if (strArray[10] != "20202020202020202020202020202020")
        num5 = 1;
      string hexStr4 = Class1.DataToHexStr((long) ((int32 & 251 | num5 << 2) & 231 | comboXlistProEngCh4 << 3));
      string hexStr5 = Class1.DataToHexStr((long) (Convert.ToInt32(oneChStringPro.Substring(24, 2), 16) & 240 | comboXlistPro));
      strArray[0] = strArray[0] + strArray[1] + strArray[2].Substring(0, 2) + hexStr1.Substring(0, 1) + strArray[2].Substring(3, 1) + strArray[3].Substring(0, 2) + hexStr2.Substring(0, 1) + strArray[3].Substring(3, 1) + hexStr3 + hexStr4 + hexStr5 + strArray[10];
      return Class1.Chga_z_ToA_Z(strArray[0]);
    }

    private void SaveCurrenChData()
    {
      Class1.SavOneChgDatPro(this.ChgChStringPro(), this.dataGridView1.CurrentCell.RowIndex, this.GiFileName);
      Class1.SavOneChgSkipSttPro(0, this.dataGridView1.CurrentCell.RowIndex, this.GiFileName);
    }

    private void SetGridHeadNamePro()
    {
      for (int index = 0; index <= 11; ++index)
        this.dataGridView1.Columns[index].HeaderCell.Value = (object) ChInformtion.DataGridName[Class1.English_En, index];
    }

    private void ReloadTreePro()
    {
      this.treeView1.Nodes.Clear();
      this.loadtreeViewPro();
    }

    public void LanguageChgSetPro()
    {
      this.ReloadTreePro();
      this.SetGridHeadNamePro();
      this.LoadFileDataDisPro();
    }

    private void ChInformtion_Load(object sender, EventArgs e)
    {
      this.loadtreeViewPro();
      this.loadDataGridViewPro();
      this.loadOtherContrlPro();
      this.loadDefaulFilePro();
      this.dataGridView1.FirstDisplayedScrollingRowIndex = 0;
      this.textBox1.Text = "";
      this.LoadFileDataDisPro();
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
    }

    private void treeView1_Click(object sender, EventArgs e)
    {
      this.ContrlVisibleDisPro();
      if (this.treeView1.SelectedNode.Level != 1)
        return;
      if (Class1.GbOwnUsedEn || Class1.FactoryEn || Class1.ReadForWrite_En == 1)
      {
        switch (this.treeView1.SelectedNode.Index)
        {
          case 0:
            ChinfDetail chinfDetail = new ChinfDetail();
            chinfDetail.GiCurrentCh = this.dataGridView1.CurrentCell.RowIndex;
            chinfDetail.GiFileName1 = this.GiFileName;
            int num1 = (int) chinfDetail.ShowDialog((IWin32Window) this);
            chinfDetail.Dispose();
            this.LoadFileDataDisPro();
            break;
          case 1:
            if (Class1.GbOwnUsedEn || Class1.FactoryEn || Class1.ReadForWrite_En == 1 && Class1.Vfo_En == 1)
            {
              VFO_CH vfoCh = new VFO_CH();
              vfoCh.GiFileName1 = this.GiFileName;
              int num2 = (int) vfoCh.ShowDialog((IWin32Window) this);
              vfoCh.Dispose();
              break;
            }
            break;
          case 2:
            RadioSet radioSet = new RadioSet();
            radioSet.GiFileName1 = this.GiFileName;
            int num3 = (int) radioSet.ShowDialog((IWin32Window) this);
            radioSet.Dispose();
            break;
          case 3:
            DtmfMenu dtmfMenu = new DtmfMenu();
            dtmfMenu.GiFileName2 = this.GiFileName;
            int num4 = (int) dtmfMenu.ShowDialog((IWin32Window) this);
            dtmfMenu.Dispose();
            break;
          case 4:
            Tone2Menu tone2Menu = new Tone2Menu();
            tone2Menu.GiFileName2 = this.GiFileName;
            int num5 = (int) tone2Menu.ShowDialog((IWin32Window) this);
            tone2Menu.Dispose();
            break;
          case 5:
            Ton5Menu1 ton5Menu1 = new Ton5Menu1();
            ton5Menu1.GiFileName2 = this.GiFileName;
            int num6 = (int) ton5Menu1.ShowDialog((IWin32Window) this);
            ton5Menu1.Dispose();
            break;
          case 6:
            if (Class1.GbOwnUsedEn || Class1.FactoryEn)
            {
              RfRangWin rfRangWin = new RfRangWin();
              rfRangWin.GiFileNameRang = this.GiFileName;
              int num7 = (int) rfRangWin.ShowDialog((IWin32Window) this);
              rfRangWin.Dispose();
              Class2.GetRfRangPro(this.GiFileName);
              break;
            }
            break;
          case 7:
            RadioSYS radioSys = new RadioSYS();
            radioSys.GiFileName = this.GiFileName;
            int num8 = (int) radioSys.ShowDialog((IWin32Window) this);
            radioSys.Dispose();
            break;
        }
      }
      else
      {
        int num9 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 3], Class1.RadioName);
      }
    }

    private void treeView1_MouseClick(object sender, MouseEventArgs e)
    {
    }

    private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
    }

    private void treeView1_MouseDown(object sender, MouseEventArgs e)
    {
      if (!(sender is TreeView))
        return;
      this.treeView1.SelectedNode = this.treeView1.GetNodeAt(e.X, e.Y);
    }

    private void dataGridView1_Scroll(object sender, ScrollEventArgs e) => this.LoadFileDataDisPro();

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (Class1.GbOwnUsedEn || Class1.FactoryEn || Class1.ReadForWrite_En == 1)
      {
        this.GbFirstchg = true;
        this.LoadContrRetPro('\r', false);
      }
      else
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 3], Class1.RadioName);
      }
    }

    private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e) => this.LoadContrRetPro(e.KeyChar, true);

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      e.Handled = true;
    }

    private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool flag = Class1.KeyUseFulQt_DqtChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar != '\r')
        return;
      this.comboBox1.Visible = false;
      this.dataGridView1.CurrentCell = this.dataGridView1.CurrentRow.Cells[this.dataGridView1.SelectedCells[0].ColumnIndex + 1];
      this.dataGridView1.Focus();
    }

    private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool flag = Class1.KeyUseFul0_9ChkPro(e.KeyChar);
      e.Handled = flag;
      if (e.KeyChar == '.')
        e.Handled = true;
      if (e.KeyChar != '\r')
        return;
      this.comboBox2.Visible = false;
      this.dataGridView1.CurrentCell = this.dataGridView1.CurrentRow.Cells[this.dataGridView1.SelectedCells[0].ColumnIndex + 1];
      this.dataGridView1.Focus();
    }

    private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.comboBox3.Visible = false;
      this.dataGridView1.CurrentCell = this.dataGridView1.CurrentRow.Cells[this.dataGridView1.SelectedCells[0].ColumnIndex + 1];
      this.dataGridView1.Focus();
    }

    private void comboBox1_Leave(object sender, EventArgs e)
    {
      try
      {
        try
        {
          double num = Convert.ToDouble(Class2.DoubleDataChgPro(this.comboBox1.Text));
          if (num < 50.0 || num > 260.0)
          {
            this.comboBox1.SelectedIndex = 0;
          }
          else
          {
            string str = ((int) (num * 10.0)).ToString();
            this.comboBox1.Text = str.Insert(str.Length - 1, ".");
          }
        }
        catch
        {
          string text = this.comboBox1.Text;
          string str1 = text.Substring(text.Length - 1, 1);
          if (this.comboBox1.Text.Length == 4)
          {
            if (str1 == "N" || str1 == "n" || str1 == "I" || str1 == "i")
            {
              string StrTemp = this.comboBox1.Text.Substring(0, this.comboBox1.Text.Length - 1);
              string str2;
              try
              {
                str2 = Class1.ConvertString(StrTemp, 8, 10);
              }
              catch
              {
                str2 = "512";
              }
              if ((double) Convert.ToInt16(str2, 10) > 511.0)
                this.comboBox1.SelectedIndex = 0;
            }
            else
              this.comboBox1.SelectedIndex = 0;
          }
          else
            this.comboBox1.SelectedIndex = 0;
        }
      }
      catch
      {
        this.comboBox1.Text = "100.0";
      }
      if (this.dataGridView1.SelectedCells[0].ColumnIndex == 3)
        this.dataGridView1.CurrentRow.Cells[4].Value = (object) this.comboBox1.Text;
      this.DisComBoTextToDataGridPro(this.comboBox1);
      this.SaveCurrenChData();
    }

    private void comboBox2_Leave(object sender, EventArgs e)
    {
      try
      {
        string StrTemp = this.comboBox2.Text;
        if (StrTemp.Length != 3)
          this.comboBox2.Text = "023";
        else
          StrTemp = Class1.ConvertString(StrTemp, 8, 10);
        if (Convert.ToInt16(StrTemp, 10) > (short) 511)
          this.comboBox2.Text = "023";
      }
      catch
      {
        this.comboBox2.Text = "023";
      }
      this.DisComBoTextToDataGridPro(this.comboBox2);
      this.SaveCurrenChData();
    }

    private void comboBox3_Leave(object sender, EventArgs e)
    {
      this.DisComBoTextToDataGridPro(this.comboBox3);
      this.SaveCurrenChData();
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      string text1 = "";
      int[] numArray1 = new int[3];
      int[] numArray2 = new int[3];
      int[] numArray3 = new int[3];
      int[] numArray4 = new int[3];
      if (this.dataGridView1.CurrentCell.ColumnIndex == 2 || this.dataGridView1.CurrentCell.ColumnIndex == 1)
      {
        bool flag = Class1.KeyUseFul0_9ChkPro(e.KeyChar);
        e.Handled = flag;
        if (e.KeyChar != '\r')
          return;
        string text2 = this.textBox1.Text;
        int columnIndex = this.dataGridView1.CurrentCell.ColumnIndex;
        if ((1 != columnIndex ? Class2.DataUseFulFreChk(text2, 2) : Class2.DataUseFulFreChk(text2, 0)) == "BandOver")
        {
          if (1 == columnIndex)
          {
            numArray1[0] = Class1.FreBandData[0, 0] / 100000;
            numArray2[0] = Class1.FreBandData[0, 1] / 100000;
            numArray3[0] = Class1.FreBandData[0, 2] / 100000;
            numArray4[0] = Class1.FreBandData[0, 3] / 100000;
            numArray1[1] = Class1.FreBandData[1, 0] / 100000;
            numArray2[1] = Class1.FreBandData[1, 1] / 100000;
            numArray3[1] = Class1.FreBandData[1, 2] / 100000;
            numArray4[1] = Class1.FreBandData[1, 3] / 100000;
            numArray1[2] = Class1.FreBandData[2, 0] / 100000;
            numArray2[2] = Class1.FreBandData[2, 1] / 100000;
            numArray3[2] = Class1.FreBandData[2, 2] / 100000;
            numArray4[2] = Class1.FreBandData[2, 3] / 100000;
            if (numArray1[0] != 0 && numArray2[0] != 0)
              text1 = this.MessBoxName[Class1.English_En, 0] + (object) numArray1[0] + "M," + (object) numArray2[0] + "M]";
            if (numArray1[1] != 0 && numArray2[1] != 0)
              text1 = text1 + "||" + (object) numArray1[1] + "M," + (object) numArray2[1] + "M]";
            if (numArray1[2] != 0 && numArray2[2] != 0)
              text1 = text1 + "||" + (object) numArray1[2] + "M," + (object) numArray2[2] + "M]";
            int num = (int) MessageBox.Show(text1, Class1.RadioName);
          }
          else
          {
            numArray1[0] = Class1.FreBandData[0, 0] / 100000;
            numArray2[0] = Class1.FreBandData[0, 1] / 100000;
            numArray3[0] = Class1.FreBandData[0, 2] / 100000;
            numArray4[0] = Class1.FreBandData[0, 3] / 100000;
            numArray1[1] = Class1.FreBandData[1, 0] / 100000;
            numArray2[1] = Class1.FreBandData[1, 1] / 100000;
            numArray3[1] = Class1.FreBandData[1, 2] / 100000;
            numArray4[1] = Class1.FreBandData[1, 3] / 100000;
            numArray1[2] = Class1.FreBandData[2, 0] / 100000;
            numArray2[2] = Class1.FreBandData[2, 1] / 100000;
            numArray3[2] = Class1.FreBandData[2, 2] / 100000;
            numArray4[2] = Class1.FreBandData[2, 3] / 100000;
            if (numArray3[0] != 0 && numArray4[0] != 0)
              text1 = this.MessBoxName[Class1.English_En, 0] + (object) numArray3[0] + "M," + (object) numArray4[0] + "M]";
            if (numArray3[1] != 0 && numArray4[1] != 0)
              text1 = text1 + "||" + (object) numArray3[1] + "M," + (object) numArray4[1] + "M]";
            if (numArray3[2] != 0 && numArray4[2] != 0)
              text1 = text1 + "||" + (object) numArray3[2] + "M," + (object) numArray4[2] + "M]";
            int num = (int) MessageBox.Show(text1, Class1.RadioName);
          }
          int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
          string str;
          try
          {
            str = this.dataGridView1.Rows[rowIndex].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
          }
          catch
          {
            str = "";
          }
          this.textBox1.Text = str.Replace(",", ".");
          this.textBox1.SelectionLength = this.textBox1.Text.Length;
          this.textBox1.Focus();
        }
        else
        {
          this.textBox1.Visible = false;
          if (this.textBox1.Text != "")
            this.dataGridView1.CurrentCell = this.dataGridView1.CurrentRow.Cells[this.dataGridView1.SelectedCells[0].ColumnIndex + 1];
          this.dataGridView1.Focus();
        }
      }
      else
      {
        if (this.dataGridView1.CurrentCell.ColumnIndex != 11)
          return;
        this.textBox1.MaxLength = Class1.InputLengthSetPro(this.textBox1.Text, 5);
        if (e.KeyChar == '\r')
        {
          this.textBox1.Visible = false;
          this.dataGridView1.Focus();
        }
      }
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      int[] numArray1 = new int[3];
      int[] numArray2 = new int[3];
      int[] numArray3 = new int[3];
      int[] numArray4 = new int[3];
      int index1 = 0;
      string text1 = this.textBox1.Text;
      int columnIndex = this.dataGridView1.CurrentCell.ColumnIndex;
      if (this.dataGridView1.CurrentCell.ColumnIndex == 2 || this.dataGridView1.CurrentCell.ColumnIndex == 1)
      {
        string StrTemp = text1;
        string str1;
        if (1 == columnIndex)
        {
          index1 = Class2.DataUseFulFreChk02(text1);
          str1 = Class2.DataUseFulFreChk(text1, 0);
        }
        else
          str1 = Class2.DataUseFulFreChk(text1, 2);
        int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
        if (str1 == "BandOver")
        {
          numArray1[0] = Class1.FreBandData[0, 0] / 100000;
          numArray2[0] = Class1.FreBandData[0, 1] / 100000;
          numArray3[0] = Class1.FreBandData[0, 2] / 100000;
          numArray4[0] = Class1.FreBandData[0, 3] / 100000;
          numArray1[1] = Class1.FreBandData[1, 0] / 100000;
          numArray2[1] = Class1.FreBandData[1, 1] / 100000;
          numArray3[1] = Class1.FreBandData[1, 2] / 100000;
          numArray4[1] = Class1.FreBandData[1, 3] / 100000;
          numArray1[2] = Class1.FreBandData[2, 0] / 100000;
          numArray2[2] = Class1.FreBandData[2, 1] / 100000;
          numArray3[2] = Class1.FreBandData[2, 2] / 100000;
          numArray4[2] = Class1.FreBandData[2, 3] / 100000;
          string text2 = "";
          if (1 == columnIndex)
          {
            if (numArray1[0] != 0 && numArray2[0] != 0)
              text2 = this.MessBoxName[Class1.English_En, 0] + (object) numArray1[0] + "M," + (object) numArray2[0] + "M]";
            if (numArray1[1] != 0 && numArray2[1] != 0)
              text2 = text2 + "||" + (object) numArray1[1] + "M," + (object) numArray2[1] + "M]";
            if (numArray1[2] != 0 && numArray2[2] != 0)
              text2 = text2 + "||" + (object) numArray1[2] + "M," + (object) numArray2[2] + "M]";
            int num = (int) MessageBox.Show(text2, Class1.RadioName);
          }
          else
          {
            if (numArray3[0] != 0 && numArray4[0] != 0)
              text2 = this.MessBoxName[Class1.English_En, 0] + (object) numArray3[0] + "M," + (object) numArray4[0] + "M]";
            if (numArray3[1] != 0 && numArray4[1] != 0)
              text2 = text2 + "||" + (object) numArray3[1] + "M," + (object) numArray4[1] + "M]";
            if (numArray3[2] != 0 && numArray4[2] != 0)
              text2 = text2 + "||" + (object) numArray3[2] + "M," + (object) numArray4[2] + "M]";
            int num = (int) MessageBox.Show(text2, Class1.RadioName);
          }
          string str2;
          try
          {
            str2 = this.dataGridView1.Rows[rowIndex].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
          }
          catch
          {
            str2 = "";
          }
          this.textBox1.Text = str2.Replace(",", ".");
          this.textBox1.Focus();
        }
        else
        {
          string str3;
          try
          {
            str3 = this.dataGridView1.Rows[rowIndex].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
          }
          catch
          {
            str3 = "";
          }
          if (str1 == "")
          {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 1)
            {
              for (int index2 = 1; index2 <= 11; ++index2)
                this.dataGridView1.Rows[rowIndex].Cells[index2].Value = (object) "";
            }
          }
          else
          {
            str1 = str1.Replace(",", ".");
            if (str3 == "" && this.dataGridView1.CurrentCell.ColumnIndex == 1)
            {
              string str4 = str1;
              if (Class2.DataUseFulFreChk(StrTemp, 2) == "BandOver")
                str4 = Class2.DataUseFulFreChk((Class1.FreBandData[index1, 2] / 100000).ToString(), 2);
              this.dataGridView1.Rows[rowIndex].Cells[2].Value = (object) str4;
              this.dataGridView1.Rows[rowIndex].Cells[3].Value = (object) Class1.CtcTone[0];
              this.dataGridView1.Rows[rowIndex].Cells[4].Value = (object) Class1.CtcTone[0];
              this.dataGridView1.Rows[rowIndex].Cells[5].Value = (object) Class1.ScrChSet_EngCh[Class1.English_En, 0];
              this.dataGridView1.Rows[rowIndex].Cells[6].Value = (object) Class1.TxPower_EngCh[Class1.English_En, 0];
              this.dataGridView1.Rows[rowIndex].Cells[7].Value = (object) Class1.BusyKind_EngCh[Class1.English_En, 0];
              this.dataGridView1.Rows[rowIndex].Cells[8].Value = (object) Class1.ConStep[6];
              this.dataGridView1.Rows[rowIndex].Cells[9].Value = (object) Class1.WideNar_EngCh[Class1.English_En, 0];
              this.dataGridView1.Rows[rowIndex].Cells[10].Value = (object) Class1.OptSig_EngCh[Class1.English_En, 0];
              this.dataGridView1.Rows[rowIndex].Cells[11].Value = (object) "";
            }
          }
          this.dataGridView1.Rows[rowIndex].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value = (object) str1;
        }
        this.SaveCurrenChData();
      }
      else
      {
        if (this.dataGridView1.CurrentCell.ColumnIndex != 11)
          return;
        this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[this.dataGridView1.CurrentCell.ColumnIndex].Value = (object) this.textBox1.Text;
        this.SaveCurrenChData();
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void comboBox1_Click(object sender, EventArgs e)
    {
      公共控件操作.LookCombo_XAdd_QtTDqtPro(this.comboBox1, this.comboBox1.Text);
      this.GbFirstchg = false;
    }

    private void comboBox2_Click(object sender, EventArgs e) => 公共控件操作.LookCombo_XAdd_QtTDqtPro(this.comboBox1, this.comboBox1.Text);

    private void ChInformtion_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.dataGridView1.CurrentCell.ColumnIndex == 5 || this.dataGridView1.CurrentCell.ColumnIndex != 10)
        ;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.GbFirstchg)
      {
        this.GbFirstchg = false;
      }
      else
      {
        string str = "OFF";
        if (this.dataGridView1.CurrentCell.ColumnIndex == 3)
        {
          int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
          if (this.dataGridView1.Rows[rowIndex].Cells[5].Value != null)
            str = this.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
          if (this.comboBox1.Text == Class1.CtcTone[0])
          {
            if (str == Class1.Spkind_EngCh[Class1.English_En, 1])
              this.dataGridView1.Rows[rowIndex].Cells[5].Value = (object) Class1.Spkind_EngCh[Class1.English_En, 0];
            else if (str == Class1.Spkind_EngCh[Class1.English_En, 3] || str == Class1.Spkind_EngCh[Class1.English_En, 4])
              this.dataGridView1.Rows[rowIndex].Cells[5].Value = (object) Class1.Spkind_EngCh[Class1.English_En, 2];
          }
          else if (str == Class1.Spkind_EngCh[Class1.English_En, 0])
            this.dataGridView1.Rows[rowIndex].Cells[5].Value = (object) Class1.Spkind_EngCh[Class1.English_En, 1];
        }
      }
    }

    private void groupBox3_Enter(object sender, EventArgs e)
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
      this.groupBox3 = new GroupBox();
      this.comboBox2 = new ComboBox();
      this.comboBox1 = new ComboBox();
      this.comboBox3 = new ComboBox();
      this.textBox1 = new TextBox();
      this.dataGridView1 = new DataGridView();
      this.groupBox2 = new GroupBox();
      this.treeView1 = new TreeView();
      this.groupBox3.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.groupBox3.Controls.Add((Control) this.comboBox2);
      this.groupBox3.Controls.Add((Control) this.comboBox1);
      this.groupBox3.Controls.Add((Control) this.comboBox3);
      this.groupBox3.Controls.Add((Control) this.textBox1);
      this.groupBox3.Controls.Add((Control) this.dataGridView1);
      this.groupBox3.Location = new Point(118, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(884, 529);
      this.groupBox3.TabIndex = 1;
      this.groupBox3.TabStop = false;
      this.groupBox3.Enter += new EventHandler(this.groupBox3_Enter);
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new Point(709, 138);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(121, 20);
      this.comboBox2.TabIndex = 5;
      this.comboBox2.Text = "Dcs";
      this.comboBox2.Leave += new EventHandler(this.comboBox2_Leave);
      this.comboBox2.KeyPress += new KeyPressEventHandler(this.comboBox2_KeyPress);
      this.comboBox2.Click += new EventHandler(this.comboBox2_Click);
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(709, 112);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(121, 20);
      this.comboBox1.TabIndex = 4;
      this.comboBox1.Text = "Ctcss";
      this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
      this.comboBox1.Leave += new EventHandler(this.comboBox1_Leave);
      this.comboBox1.KeyPress += new KeyPressEventHandler(this.comboBox1_KeyPress);
      this.comboBox1.Click += new EventHandler(this.comboBox1_Click);
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new Point(709, 164);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new Size(121, 20);
      this.comboBox3.TabIndex = 3;
      this.comboBox3.Text = "其它";
      this.comboBox3.SelectedIndexChanged += new EventHandler(this.comboBox3_SelectedIndexChanged);
      this.comboBox3.Leave += new EventHandler(this.comboBox3_Leave);
      this.comboBox3.KeyPress += new KeyPressEventHandler(this.comboBox3_KeyPress);
      this.textBox1.Location = new Point(709, 59);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 21);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "频率输入\\名称";
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.textBox1.Leave += new EventHandler(this.textBox1_Leave);
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = DockStyle.Fill;
      this.dataGridView1.Location = new Point(3, 17);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new Size(878, 509);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.Scroll += new ScrollEventHandler(this.dataGridView1_Scroll);
      this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      this.dataGridView1.KeyDown += new KeyEventHandler(this.dataGridView1_KeyDown);
      this.dataGridView1.KeyPress += new KeyPressEventHandler(this.dataGridView1_KeyPress);
      this.groupBox2.Controls.Add((Control) this.treeView1);
      this.groupBox2.Location = new Point(3, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(112, 529);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.treeView1.Dock = DockStyle.Fill;
      this.treeView1.Location = new Point(3, 17);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new Size(106, 509);
      this.treeView1.TabIndex = 0;
      this.treeView1.MouseClick += new MouseEventHandler(this.treeView1_MouseClick);
      this.treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
      this.treeView1.MouseDown += new MouseEventHandler(this.treeView1_MouseDown);
      this.treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
      this.treeView1.Click += new EventHandler(this.treeView1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1014, 541);
      this.ControlBox = false;
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Name = nameof (ChInformtion);
      this.ShowIcon = false;
      this.Load += new EventHandler(this.ChInformtion_Load);
      this.FormClosing += new FormClosingEventHandler(this.ChInformtion_FormClosing);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
