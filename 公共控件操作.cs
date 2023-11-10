// Decompiled with JetBrains decompiler
// Type: _8890DTest.公共控件操作
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class 公共控件操作 : Form
  {
    public static string[] ConSpeChar = new string[6]
    {
      "A",
      "B",
      "C",
      "D",
      "*",
      "#"
    };
    private IContainer components = (IContainer) null;

    public 公共控件操作() => this.InitializeComponent();

    public static void TextBoxResPro(TextBox Textbo, int length, string name)
    {
      Textbo.Text = name;
      Textbo.MaxLength = length;
      Textbo.TextAlign = HorizontalAlignment.Center;
      Textbo.Visible = true;
    }

    public static void ComBoxResPro(ComboBox ComboBo, int Index)
    {
      ComboBo.SelectedIndex = Index;
      ComboBo.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBo.Visible = true;
    }

    public static void Load_CmbBoxNumberPro(
      ComboBox cmbHelp,
      int NumberStep,
      int BegainNumber,
      int Number)
    {
      for (int index = 0; index <= Number; ++index)
      {
        cmbHelp.Items.Add((object) BegainNumber.ToString());
        BegainNumber += NumberStep;
      }
      公共控件操作.ComBoxResPro(cmbHelp, 0);
    }

    public static void Load_CmbBoxNPro(ComboBox cmbHelp, string[] StrArr, int Number)
    {
      for (int index = 0; index <= Number; ++index)
        cmbHelp.Items.Add((object) StrArr[index]);
      公共控件操作.ComBoxResPro(cmbHelp, 0);
    }

    public static void load_CmbBoxNProEng_Ch1(ComboBox cmbHelp, string[,] StrArr, int Number)
    {
      for (int index = 0; index <= Number; ++index)
        cmbHelp.Items.Add((object) StrArr[Class1.English_En, index]);
      公共控件操作.ComBoxResPro(cmbHelp, 0);
    }

    public static void SetCombo_XListProEng_Ch(
      ComboBox comboBox_x,
      string[,] ArrTemp,
      string StringTemp,
      bool AddEn)
    {
      int num = 0;
      if (AddEn)
        comboBox_x.Items.Clear();
      for (int index = 0; index < ArrTemp.GetLength(1); ++index)
      {
        if (AddEn)
          comboBox_x.Items.Add((object) ArrTemp[Class1.English_En, index]);
        if (ArrTemp[Class1.English_En, index] == StringTemp)
          num = index;
      }
      if (num >= ArrTemp.Length)
        comboBox_x.SelectedIndex = 0;
      else
        comboBox_x.SelectedIndex = num;
    }

    public static int GetCombo_XListPro_Eng_Ch(string[,] ArrTemp, string StringTemp)
    {
      byte comboXlistProEngCh = 0;
      for (byte index = 0; (int) index < ArrTemp.GetLength(1); ++index)
      {
        if (ArrTemp[Class1.English_En, (int) index] == StringTemp)
          comboXlistProEngCh = index;
      }
      if ((int) comboXlistProEngCh >= ArrTemp.Length)
        comboXlistProEngCh = (byte) 0;
      return (int) comboXlistProEngCh;
    }

    public static void DataGridViewResPro(DataGridView GridViewName)
    {
      GridViewName.Dock = DockStyle.Fill;
      GridViewName.RowHeadersVisible = false;
      GridViewName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      GridViewName.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      GridViewName.Dock = DockStyle.Fill;
      GridViewName.AllowUserToResizeColumns = false;
      GridViewName.AllowUserToResizeRows = false;
    }

    public static void DataGridViewColumnAddPro(
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

    public static void numericUpDown_ValueChanged(NumericUpDown numericUpDownx)
    {
      if (numericUpDownx.Value == numericUpDownx.Maximum)
      {
        numericUpDownx.Value = numericUpDownx.Minimum++;
      }
      else
      {
        if (!(numericUpDownx.Value == numericUpDownx.Minimum))
          return;
        numericUpDownx.Value = numericUpDownx.Maximum--;
      }
    }

    public static void numericUpDownXRes(
      NumericUpDown numericUpDownx,
      int Maximum,
      int Minimum,
      int Value)
    {
      numericUpDownx.Maximum = (Decimal) Maximum;
      numericUpDownx.Minimum = (Decimal) Minimum;
      numericUpDownx.Value = (Decimal) Value;
    }

    public static int LookCombo_XAddPro(ComboBox comboBox_x, string[] ArrTemp, string StringTemp)
    {
      int num1 = ArrTemp.Length;
      for (int index = 0; index < ArrTemp.Length; ++index)
      {
        if (ArrTemp[index] == StringTemp)
        {
          num1 = index;
          break;
        }
        double num2;
        try
        {
          StringTemp = Class2.DoubleDataChgPro(StringTemp);
          num2 = Convert.ToDouble(StringTemp);
        }
        catch
        {
          num2 = 0.0;
        }
        double num3;
        try
        {
          ArrTemp[index] = Class2.DoubleDataChgPro(ArrTemp[index]);
          num3 = Convert.ToDouble(ArrTemp[index]);
        }
        catch
        {
          num3 = 0.0;
        }
        if (num2 < num3)
        {
          num1 = index - 1;
          break;
        }
      }
      if (num1 >= ArrTemp.Length)
        num1 = 0;
      return num1;
    }

    public static void LookCombo_XAdd_QtTDqtPro(ComboBox comboBox_x, string StrTemp)
    {
      string str = StrTemp.Substring(StrTemp.Length - 1, 1);
      if (str == "N" || str == "n" || str == "I" || str == "i")
      {
        string StringTemp = StrTemp.Substring(0, StrTemp.Length - 1);
        int num = 公共控件操作.LookCombo_XAddPro(comboBox_x, Class1.DcsTone, StringTemp);
        if (str == "I" || str == "i")
          comboBox_x.SelectedIndex = num + 155;
        else
          comboBox_x.SelectedIndex = num + 51;
      }
      else
        comboBox_x.SelectedIndex = 公共控件操作.LookCombo_XAddPro(comboBox_x, Class1.CtcTone, StrTemp);
    }

    private void PubContrl_Load(object sender, EventArgs e) => this.Icon = new Icon(Class1.MainFilePath + "logo.ico");

    public static void LookCombo_XAddPtPro(
      ComboBox comboBox_x,
      string[] ArrTemp,
      string StringTemp)
    {
      int num1 = ArrTemp.Length;
      for (int index = 0; index < ArrTemp.Length; ++index)
      {
        if (ArrTemp[index] == StringTemp)
        {
          num1 = index;
          break;
        }
        double num2;
        try
        {
          StringTemp = Class2.DoubleDataChgPro(StringTemp);
          num2 = Convert.ToDouble(StringTemp);
        }
        catch
        {
          num2 = 0.0;
        }
        double num3;
        try
        {
          ArrTemp[index] = Class2.DoubleDataChgPro(ArrTemp[index]);
          num3 = Convert.ToDouble(ArrTemp[index]);
        }
        catch
        {
          num3 = 0.0;
        }
        if (num2 == num3)
        {
          num1 = index;
          break;
        }
      }
      if (num1 >= ArrTemp.Length)
        comboBox_x.SelectedIndex = 0;
      else
        comboBox_x.SelectedIndex = num1;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(284, 262);
      this.Name = nameof (公共控件操作);
      this.Text = "PubContrl";
      this.Load += new EventHandler(this.PubContrl_Load);
      this.ResumeLayout(false);
    }
  }
}
