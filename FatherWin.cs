// Decompiled with JetBrains decompiler
// Type: _8890DTest.FatherWin
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace _8890DTest
{
  public class FatherWin : Form
  {
    private ChInformtion ChinfWin = new ChInformtion();
    private int CurrentRow = 12;
    private int CurrentCom = 1;
    private string baudradio = "9600";
    private string[,] toolStripName = new string[2, 6]
    {
      {
        "新 建",
        "打 开",
        "保 存",
        "读 频",
        "写 频",
        " 关 于....."
      },
      {
        "New",
        "Open",
        "Save",
        "Read",
        "Write",
        " About....."
      }
    };
    private string[,] MenuStrip1Name = new string[2, 6]
    {
      {
        "文 件",
        "新 建",
        "打 开",
        "保 存",
        "另 存 为 ",
        "退 出"
      },
      {
        "File",
        "New",
        "Open",
        "Save",
        "Save As",
        "Exit"
      }
    };
    private string[,] MenuStrip2Name = new string[2, 5]
    {
      {
        "编 程",
        "读 频",
        "写 频",
        "编 程 密 码",
        "机 型 信 息"
      },
      {
        "Program",
        "Read",
        "Write",
        "Program Code",
        "Radio Information"
      }
    };
    private string[,] MenuStrip3Name = new string[2, 9]
    {
      {
        "设 置",
        "选 择 端 口",
        "波 特 率 选 择(&B)",
        "语 言 选 择",
        "中 文(Chinese)",
        "英 文(English)",
        "进入测试模式",
        "Set1846S参数",
        "总体参数调节"
      },
      {
        "Setting",
        "ComPort Select",
        "Bit Rate",
        "Language",
        "Chinese(中文)",
        "English(英 文)",
        "Test mod",
        "Set1846S",
        "Basis Adj"
      }
    };
    private string[,] MenuStrip4Name = new string[2, 2]
    {
      {
        "帮 助",
        "关 于 ... ..."
      },
      {
        "Help",
        "About ... ..."
      }
    };
    private string[,] MessBoxName = new string[2, 5]
    {
      {
        "当前串口",
        "：被占用,请选择其它串口！",
        "当前文件禁止修改！请保存为其它名称！",
        "软件末注册,请先注册,谢谢！",
        "请先读频"
      },
      {
        "Comport",
        "：Occupancy!",
        "File Can Not Edit,Please Save As Other File!",
        "Please Regedit SoftWare!",
        "Read First！"
      }
    };
    private static Process p;
    private IContainer components = (IContainer) null;
    private MenuStrip menuStrip;
    private ToolStrip toolStrip;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem fileMenu;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem toolsMenu;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripButton newToolStripButton;
    private ToolStripButton openToolStripButton;
    private ToolStripButton saveToolStripButton;
    private ToolStripButton printToolStripButton;
    private ToolStripButton printPreviewToolStripButton;
    private ToolStripButton helpToolStripButton;
    private StatusStrip statusStrip;
    private OpenFileDialog openFileDialog1;
    private ToolTip toolTip;
    private ToolStripMenuItem 手动选择端口ToolStripMenuItem;
    private ToolStripStatusLabel CommSelect;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem 读频ToolStripMenuItem;
    private ToolStripMenuItem 写频ToolStripMenuItem;
    private ToolStripMenuItem 机型信息ToolStripMenuItem;
    private SerialPort serialPort1;
    private ToolStripMenuItem 波特率选择ToolStripMenuItem;
    private ToolStripMenuItem toolStripMenuItem3;
    private ToolStripMenuItem toolStripMenuItem4;
    private ToolStripMenuItem toolStripMenuItem5;
    private ToolStripMenuItem toolStripMenuItem6;
    private ToolStripMenuItem toolStripMenuItem7;
    private ToolStripStatusLabel SysTime;
    private Timer timer1;
    private ToolStripStatusLabel FileAdd;
    private ToolStripMenuItem 总体参数调节ToolStripMenuItem;
    private ToolStripMenuItem 语言选择ToolStripMenuItem;
    private ToolStripMenuItem 中文ToolStripMenuItem;
    private ToolStripMenuItem 英文ToolStripMenuItem;
    private ToolStripMenuItem 字库IC提取数据ToolStripMenuItem;
    private ToolStripMenuItem 简体ToolStripMenuItem;
    private ToolStripMenuItem 繁体ToolStripMenuItem;
    private ToolStripMenuItem 自动频率生成ToolStripMenuItem;

    public int SetCurrentRow
    {
      get => this.CurrentRow;
      set => this.CurrentRow = value;
    }

    public FatherWin()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void SaveDialogFilePro()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.RestoreDirectory = true;
      saveFileDialog.Filter = "（*.icf）|*.icf|（*.*）|*.*";
      saveFileDialog.FileName = "ConFile.icf";
      if (saveFileDialog.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      string str = this.ChinfWin.GiFilePath + "DefaulFile.icf";
      string fileName = saveFileDialog.FileName;
      if (str != fileName)
      {
        this.ChinfWin.GiCurFileName = fileName;
        this.FileAdd.Text = fileName;
        this.ChinfWin.SaveDataFile(fileName);
      }
      else
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 2], Class1.RadioName);
      }
    }

    private void ShowNewForm(object sender, EventArgs e)
    {
      this.ChinfWin.MdiParent = (Form) this;
      this.ChinfWin.Show();
      if (Class1.ReadForDis_En == 0)
        this.ChinfWin.Hide();
      else
        this.ChinfWin.Show();
      this.ChinfWin.WindowState = FormWindowState.Maximized;
      this.ChinfWin.ContrlVisibleDisPro();
      this.ChinfWin.SaveAllDataToTempFile(this.ChinfWin.GiFilePath + "DefaulFile.icf");
      this.FileAdd.Text = "";
      this.ChinfWin.dataGridView1.FirstDisplayedScrollingRowIndex = 0;
      this.ChinfWin.LoadFileDataDisPro();
    }

    private void OpenFile(object sender, EventArgs e)
    {
      this.ChinfWin.MdiParent = (Form) this;
      if (Class1.ReadForDis_En == 0)
        this.ChinfWin.Hide();
      else
        this.ChinfWin.Show();
      this.ChinfWin.WindowState = FormWindowState.Maximized;
      this.ChinfWin.ContrlVisibleDisPro();
      this.openFileDialog1.CheckFileExists = true;
      this.openFileDialog1.CheckPathExists = true;
      this.openFileDialog1.Multiselect = true;
      this.openFileDialog1.ReadOnlyChecked = true;
      this.openFileDialog1.ShowHelp = true;
      this.openFileDialog1.Filter = "（*.icf）|*.icf|（*.*）|*.*";
      this.openFileDialog1.FileName = "ConFile.icf";
      int num = (int) this.openFileDialog1.ShowDialog();
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) => this.SaveDialogFilePro();

    private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) => this.Close();

    private void CutToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.Cascade);

    private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileVertical);

    private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileHorizontal);

    private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.ArrangeIcons);

    private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (Form mdiChild in this.MdiChildren)
        mdiChild.Close();
    }

    private void editMenu_Click(object sender, EventArgs e)
    {
    }

    private void viewMenu_Click(object sender, EventArgs e)
    {
    }

    private void MenuResetPro()
    {
      if (this.baudradio == "9600")
        this.toolStripMenuItem3.Checked = true;
      else if (this.baudradio == "19200")
        this.toolStripMenuItem4.Checked = true;
      else if (this.baudradio == "38400")
        this.toolStripMenuItem5.Checked = true;
      else if (this.baudradio == "57600")
        this.toolStripMenuItem6.Checked = true;
      else if (this.baudradio == "115200")
      {
        this.toolStripMenuItem7.Checked = true;
      }
      else
      {
        this.baudradio = "9600";
        this.toolStripMenuItem3.Checked = true;
      }
    }

    private void loadStatusStripPro()
    {
      this.CommSelect.Text = "COM" + (object) this.CurrentCom;
      this.FileAdd.Text = "";
      this.FileAdd.Spring = true;
      this.FileAdd.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right;
      this.SysTime.Text = DateTime.Now.ToString();
    }



    public static void CreateOrOpenSettingsFile(string FileNameTemp)
    {
      if (File.Exists(FileNameTemp))
        return;
      using (FileStream fileStream = File.Create(FileNameTemp))
      {
        byte[] bytes = new UTF8Encoding(true).GetBytes("[setup]\r\nlanguage=english\r\ntestmode=0\r\nFactory=0\r\npassword=0\r\nRadioName=UV - 98\r\nCompanyName=TYT INC.(C)\r\nSoftVer=Ver1.0\r\nCompleteTime=2016.08.05\r\nCOMSelect=COM5\r\nBaudradio=57600\r\nexepassword=777777\r\nlanguagemenu=0\r\nOwnUsed=ARRVIN\r\nvoiceencrypt=1\r\ntimesetting=0\r\ngpssystem=0\r\nChinese=Simple\r\nNoReadFirst=Off Course\r\nNoReadForWrite=0\r\n");
        fileStream.Write(bytes, 0, bytes.Length);
      }
    }

    private void GetSettingFile()
    {
      FatherWin.CreateOrOpenSettingsFile("settings.ini");
      string[] strArray = Class1.ReadFileDataPro("settings.ini").Split('\r');
      int num1 = Class1.LookStringPt(strArray[1], "=");
      string str1 = strArray[1].Substring(num1 + 1, strArray[1].Length - num1 - 1);
      Class1.English_En = 0;
      this.中文ToolStripMenuItem.Checked = true;
      this.英文ToolStripMenuItem.Checked = false;
      if (str1 == "english")
      {
        this.中文ToolStripMenuItem.Checked = false;
        this.英文ToolStripMenuItem.Checked = true;
        Class1.English_En = 1;
      }
      int num2 = Class1.LookStringPt(strArray[2], "=");
      string str2 = strArray[2].Substring(num2 + 1, strArray[2].Length - num2 - 1);
      Class1.GbTestModEn = false;
      if (str2 == "TestAll")
        Class1.GbTestModEn = true;
      int num3 = Class1.LookStringPt(strArray[3], "=");
      string str3 = strArray[3].Substring(num3 + 1, strArray[3].Length - num3 - 1);
      Class1.FactoryEn = false;
      if (str3 == "FactoryEn")
        Class1.FactoryEn = true;
      int num4 = Class1.LookStringPt(strArray[5], "=");
      Class1.RadioName = strArray[5].Substring(num4 + 1, strArray[5].Length - num4 - 1);
      int num5 = Class1.LookStringPt(strArray[6], "=");
      Class1.CompanyName = strArray[6].Substring(num5 + 1, strArray[6].Length - num5 - 1);
      int num6 = Class1.LookStringPt(strArray[7], "=");
      string str4 = strArray[7].Substring(num6 + 1, strArray[7].Length - num6 - 1);
      int num7 = Class1.LookStringPt(strArray[8], "=");
      str4 = strArray[8].Substring(num7 + 1, strArray[8].Length - num7 - 1);
      int num8 = Class1.LookStringPt(strArray[9], "=");
      string str5 = strArray[9].Substring(num8 + 1, strArray[9].Length - num8 - 1);
            var z = str5.Substring(3, str5.Length - 3);
            var g = (int)Convert.ToInt16(z, 10);
      this.CurrentCom = (int) Convert.ToInt16(str5.Substring(3, str5.Length - 3), 10);
      int num9 = Class1.LookStringPt(strArray[10], "=");
      this.baudradio = strArray[10].Substring(num9 + 1, strArray[10].Length - num9 - 1);
      int num10 = Class1.LookStringPt(strArray[11], "=");
      Class1.GpsEable = strArray[11].Substring(num10 + 1, strArray[11].Length - num10 - 1);
      int num11 = Class1.LookStringPt(strArray[12], "=");
      Class1.LanguageDisEable = strArray[12].Substring(num11 + 1, strArray[12].Length - num11 - 1);
      int num12 = Class1.LookStringPt(strArray[13], "=");
      if (strArray[13].Substring(num12 + 1, strArray[13].Length - num12 - 1) == "ARRVIN")
      {
        Class1.LanguageDisEable = "Enable1";
        Class1.FactoryEn = true;
        Class1.GbTestModEn = true;
        Class1.GbOwnUsedEn = true;
      }
      else
        Class1.GbOwnUsedEn = false;
      int num13 = Class1.LookStringPt(strArray[17], "=");
      string str6 = strArray[17].Substring(num13 + 1, strArray[17].Length - num13 - 1);
      Class1.GIFontSel = 0;
      this.简体ToolStripMenuItem.Checked = true;
      this.繁体ToolStripMenuItem.Checked = false;
      if (str6 == "Traditional")
      {
        this.简体ToolStripMenuItem.Checked = false;
        this.繁体ToolStripMenuItem.Checked = true;
        Class1.GIFontSel = 1;
      }
      int num14 = Class1.LookStringPt(strArray[18], "=");
      string str7 = strArray[18].Substring(num14 + 1, strArray[18].Length - num14 - 1);
      Class1.ReadForDis_En = 0;
      if (str7 == "Off Course")
        Class1.ReadForDis_En = 1;
      int num15 = Class1.LookStringPt(strArray[19], "=");
      string str8 = strArray[19].Substring(num15 + 1, strArray[19].Length - num15 - 1);
      Class1.ReadForWrite_En = 0;
      if (!(str8 == "Yes1"))
        return;
      Class1.ReadForWrite_En = 1;
    }



    private void MDIParent1_Load(object sender, EventArgs e)
    {
      Class1.ReadForWrite_En = 0;
      this.GetSettingFile();
      this.FileAdd.Text = "0";
      this.ChinfWin.GiFilePath = AppDomain.CurrentDomain.BaseDirectory;
      Class1.MainFilePath = this.ChinfWin.GiFilePath;
      this.FileAdd.Text = "0";
      Class1.FatherWinClos = false;
      Class1.GetFreDefFilePro("DefaulFile.icf");
      Class1.ReadFileDataPro("DefaulFile.icf").Split('\r');
      this.ChinfWin.MdiParent = (Form) this;
      this.ChinfWin.WindowState = FormWindowState.Maximized;
      this.ChinfWin.Show();
      this.MenuResetPro();
      this.loadStatusStripPro();
      this.timer1.Interval = 500;
      this.timer1.Enabled = true;
      if (!Class1.FactoryEn)
      {
        this.总体参数调节ToolStripMenuItem.Visible = false;
      }
      else
      {
        this.总体参数调节ToolStripMenuItem.Visible = true;
        Class1.ReadForDis_En = 1;
        Class1.ReadForWrite_En = 1;
      }
      if (!Class1.GbTestModEn)
      {
        this.optionsToolStripMenuItem.Visible = false;
      }
      else
      {
        this.optionsToolStripMenuItem.Visible = true;
      }
      if (Class1.LanguageDisEable == "Enable1")
        this.语言选择ToolStripMenuItem.Visible = true;
      this.语言选择ToolStripMenuItem.Visible = false;
      if (Class1.GbOwnUsedEn)
      {
        this.自动频率生成ToolStripMenuItem.Visible = true;
        this.语言选择ToolStripMenuItem.Visible = true;
        this.optionsToolStripMenuItem.Visible = true;
        this.总体参数调节ToolStripMenuItem.Visible = true;
        this.字库IC提取数据ToolStripMenuItem.Visible = true;
        Class1.ReadForWrite_En = 1;
      }
      if (Class1.English_En == 0)
      {
        Class1.ReadForWrite_En = 1;
        Class1.ReadForDis_En = 1;
      }
      if (Class1.ReadForDis_En == 0)
        this.ChinfWin.Hide();
      else
        this.ChinfWin.Show();
    }

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      Class1.ReadForDis_En = 1;
      this.ChinfWin.Show();
      this.ChinfWin.SaveAllDataToTempFile1(this.openFileDialog1.FileName);
      this.ChinfWin.dataGridView1.FirstDisplayedScrollingRowIndex = 0;
      this.FileAdd.Text = this.openFileDialog1.FileName;
      this.ChinfWin.Show();
      this.ChinfWin.LoadFileDataDisPro();
    }

    private void MDIParent1_FormClosed(object sender, FormClosedEventArgs e)
    {
      File.Delete(this.ChinfWin.GiFileName);
      File.Delete(this.ChinfWin.GiFileName + ".bak");
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string giCurFileName = this.ChinfWin.GiCurFileName;
      this.ChinfWin.ContrlVisibleDisPro();
      int length = "DefaulFile.icf".Length;
      if (giCurFileName.Length >= length)
      {
        if (giCurFileName.Substring(giCurFileName.Length - length, length) == "DefaulFile.icf")
          this.SaveDialogFilePro();
        else
          this.ChinfWin.SaveDataFile(this.ChinfWin.GiCurFileName);
      }
      else
        this.ChinfWin.SaveDataFile(giCurFileName);
    }

    private void RfeRangChk()
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
      if (Class1.FreBandData[0, 0] >= numArray[0, 7] && Class1.FreBandData[0, 1] <= numArray[1, 7])
      {
        if (Class1.FreBandData[2, 0] >= numArray[0, 8] && Class1.FreBandData[2, 1] <= numArray[1, 8])
          Class1.Vfo_En = 0;
        else
          Class1.Vfo_En = 1;
      }
      else
        Class1.Vfo_En = 1;
    }

    private void ReadCommunicationPro(object sender, EventArgs e)
    {
      try
      {
        this.serialPort1.PortName = "COM" + (object) this.CurrentCom;
        this.serialPort1.Open();
        this.serialPort1.Close();
        TongXun tongXun = new TongXun()
        {
          BaudRadio = this.baudradio,
          GbReadMod = true,
          GbWriteMod = false,
          GiFilePathName = this.ChinfWin.GiFilePath + "ConTempFile.icf",
          CurrentCom = this.CurrentCom
        };
        tongXun.BaudRadio = this.baudradio;
        int num = (int) tongXun.ShowDialog((IWin32Window) this);
        if (!tongXun.R_W_Succeed)
          return;
        Class1.ReadForWrite_En = 1;
        Class1.ReadForDis_En = 1;
        this.ChinfWin.Show();
        this.ChinfWin.dataGridView1.FirstDisplayedScrollingRowIndex = 0;
        this.ChinfWin.LoadFileDataDisPro();
        this.RfeRangChk();
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 0] + (object) this.CurrentCom + this.MessBoxName[Class1.English_En, 1], Class1.RadioName);
        this.手动选择端口ToolStripMenuItem_Click(sender, e);
      }
    }


    private void WriteCommunicationPro(object sender, EventArgs e)
    {
      try
      {
        if (Class1.GbOwnUsedEn || Class1.FactoryEn || Class1.ReadForWrite_En == 1)
        {
          this.serialPort1.PortName = "COM" + (object) this.CurrentCom;
          this.serialPort1.Open();
          this.serialPort1.Close();
          int num = (int) new TongXun()
          {
            BaudRadio = this.baudradio,
            GbWriteMod = true,
            GbReadMod = false,
            GiFilePathName = (this.ChinfWin.GiFilePath + "ConTempFile.icf"),
            CurrentCom = this.CurrentCom
          }.ShowDialog((IWin32Window) this);
        }
        else
        {
          int num1 = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 4], Class1.RadioName);
        }
      }
      catch
      {
        int num = (int) MessageBox.Show(this.MessBoxName[Class1.English_En, 0] + (object) this.CurrentCom + this.MessBoxName[Class1.English_En, 1], Class1.RadioName);
        this.手动选择端口ToolStripMenuItem_Click(sender, e);
      }
    }

    private void 端口设置ToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void 手动选择端口ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ComSet comSet = new ComSet();
      comSet.StrPath = this.ChinfWin.GiFilePath + "settings.ini";
      int num = (int) comSet.ShowDialog((IWin32Window) this);
      this.CurrentCom = comSet.ChNumBer;
      this.CommSelect.Text = "COM" + this.CurrentCom.ToString();
    }

    private void helpToolStripButton_Click(object sender, EventArgs e)
    {
      int num = (int) new company_Information().ShowDialog((IWin32Window) this);
    }

    private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
    }

    private void SelectBaudradioPro()
    {
      if (this.toolStripMenuItem3.Checked)
        this.baudradio = "9600";
      else if (this.toolStripMenuItem4.Checked)
        this.baudradio = "19200";
      else if (this.toolStripMenuItem5.Checked)
        this.baudradio = "38400";
      else if (this.toolStripMenuItem6.Checked)
        this.baudradio = "57600";
      else if (this.toolStripMenuItem7.Checked)
        this.baudradio = "115200";
      string[] StrData = Class1.ReadFileDataPro(Class1.MainFilePath + "settings.ini").Split('\r');
      StrData[10] = "Baudradio=" + this.baudradio;
      Class1.SaveFileDataPro(Class1.MainFilePath + "settings.ini", StrData);
    }

    private void toolStripMenuItem4_Click(object sender, EventArgs e)
    {
      this.toolStripMenuItem3.Checked = false;
      this.toolStripMenuItem4.Checked = true;
      this.toolStripMenuItem5.Checked = false;
      this.toolStripMenuItem6.Checked = false;
      this.toolStripMenuItem7.Checked = false;
      this.SelectBaudradioPro();
    }

    private void toolStripMenuItem3_Click(object sender, EventArgs e)
    {
      this.toolStripMenuItem3.Checked = true;
      this.toolStripMenuItem4.Checked = false;
      this.toolStripMenuItem5.Checked = false;
      this.toolStripMenuItem6.Checked = false;
      this.toolStripMenuItem7.Checked = false;
      this.SelectBaudradioPro();
    }

    private void toolStripMenuItem5_Click(object sender, EventArgs e)
    {
      this.toolStripMenuItem3.Checked = false;
      this.toolStripMenuItem4.Checked = false;
      this.toolStripMenuItem5.Checked = true;
      this.toolStripMenuItem6.Checked = false;
      this.toolStripMenuItem7.Checked = false;
      this.SelectBaudradioPro();
    }

    private void toolStripMenuItem6_Click(object sender, EventArgs e)
    {
      this.toolStripMenuItem3.Checked = false;
      this.toolStripMenuItem4.Checked = false;
      this.toolStripMenuItem5.Checked = false;
      this.toolStripMenuItem6.Checked = true;
      this.toolStripMenuItem7.Checked = false;
      this.SelectBaudradioPro();
    }

    private void toolStripMenuItem7_Click(object sender, EventArgs e)
    {
      this.toolStripMenuItem3.Checked = false;
      this.toolStripMenuItem4.Checked = false;
      this.toolStripMenuItem5.Checked = false;
      this.toolStripMenuItem6.Checked = false;
      this.toolStripMenuItem7.Checked = true;
      this.SelectBaudradioPro();
    }

    private void timer1_Tick(object sender, EventArgs e) => this.SysTime.Text = DateTime.Now.ToString();

    private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new TestModWin()
      {
        BaudRadio = this.baudradio
      }.ShowDialog((IWin32Window) this);
    }



    private void FatherWin_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = false;

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new company_Information().ShowDialog((IWin32Window) this);
    }

    private void cmx138Set参数ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new Cmx138Set()
      {
        BaudRadio = this.baudradio
      }.ShowDialog((IWin32Window) this);
    }

    private void 总体参数调节ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new 模拟参数总体调节()
      {
        BaudRadio = this.baudradio,
        CurrentCom = this.CurrentCom
      }.ShowDialog((IWin32Window) this);
    }

    private void chgLanguaePeo()
    {
      string[] StrData = Class1.ReadFileDataPro(this.ChinfWin.GiFilePath + "settings.ini").Split('\r');
      string str = Class1.English_En != 1 ? "language=chinese" : "language=english";
      StrData[1] = str;
      Class1.SaveFileDataPro(Class1.MainFilePath + "settings.ini", StrData);
    }

    private void 英文ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.中文ToolStripMenuItem.Checked = false;
      this.英文ToolStripMenuItem.Checked = true;
      Class1.English_En = 1;
    }

    private void 中文ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.中文ToolStripMenuItem.Checked = true;
      this.英文ToolStripMenuItem.Checked = false;
      Class1.English_En = 0;
    }

    private void 密码ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new 编程密码()
      {
        GiFileName1 = this.ChinfWin.GiFileName
      }.ShowDialog((IWin32Window) this);
    }

    private void GpsButtonPro()
    {
      string[] StrData = Class1.ReadFileDataPro(this.ChinfWin.GiFilePath + "settings.ini").Split('\r');
      string str;
      if (Class1.GpsEable == "Enable")
      {
        str = "Gpsmode=Disable";
        Class1.GpsEable = "Disable";
      }
      else
      {
        str = "Gpsmode=Enable";
        Class1.GpsEable = "Enable";
      }
      StrData[11] = str;
      Class1.SaveFileDataPro(Class1.MainFilePath + "settings.ini", StrData);
    }

    private void gPS开关ToolStripMenuItem_Click(object sender, EventArgs e) => this.GpsButtonPro();

    private void 天翼写频软件接口ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (FatherWin.p == null)
      {
        FatherWin.p = new Process();
        FatherWin.p.StartInfo.FileName = "Test.exe";
        this.Hide();
        FatherWin.p.Start();
        FatherWin.p.WaitForExit();
        this.Show();
      }
      else if (FatherWin.p.HasExited)
      {
        this.Hide();
        FatherWin.p.Start();
        FatherWin.p.WaitForExit();
        this.Show();
      }
      FatherWin.p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
    }

    private void 字库IC提取数据ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new 字库IC提取数据().ShowDialog((IWin32Window) this);
    }

    private void toolStripMenuItem8_Click(object sender, EventArgs e)
    {
    }

    private void chgLanguae_Tra_SimplePro()
    {
      string[] StrData = Class1.ReadFileDataPro(this.ChinfWin.GiFilePath + "settings.ini").Split('\r');
      string str = Class1.GIFontSel != 1 ? "Chinese=Simple" : "Chinese=Traditional";
      StrData[17] = str;
      Class1.SaveFileDataPro(Class1.MainFilePath + "settings.ini", StrData);
    }

    private void 简体ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Class1.GIFontSel = 0;
      this.简体ToolStripMenuItem.Checked = true;
      this.繁体ToolStripMenuItem.Checked = false;
      this.chgLanguae_Tra_SimplePro();
    }

    private void 繁体ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Class1.GIFontSel = 1;
      this.繁体ToolStripMenuItem.Checked = true;
      this.简体ToolStripMenuItem.Checked = false;
      this.chgLanguae_Tra_SimplePro();
    }

    private void 自动频率生成ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Class1.AutoChSet(156.05, "ConTempFile.icf");
      this.saveToolStripMenuItem_Click(sender, e);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FatherWin));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.读频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.写频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.机型信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.手动选择端口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.波特率选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.语言选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.繁体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.总体参数调节ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字库IC提取数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动频率生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.CommSelect = new System.Windows.Forms.ToolStripStatusLabel();
            this.FileAdd = new System.Windows.Forms.ToolStripStatusLabel();
            this.SysTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.toolStripMenuItem1,
            this.toolsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1119, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(53, 23);
            this.fileMenu.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.newToolStripMenuItem.Text = "Новый";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.saveAsToolStripMenuItem.Text = "Сохранить как...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(199, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读频ToolStripMenuItem,
            this.写频ToolStripMenuItem,
            this.机型信息ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 23);
            this.toolStripMenuItem1.Text = "Программирование";
            // 
            // 读频ToolStripMenuItem
            // 
            this.读频ToolStripMenuItem.Name = "读频ToolStripMenuItem";
            this.读频ToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.读频ToolStripMenuItem.Text = "Считать кодплаг";
            this.读频ToolStripMenuItem.Click += new System.EventHandler(this.ReadCommunicationPro);
            // 
            // 写频ToolStripMenuItem
            // 
            this.写频ToolStripMenuItem.Name = "写频ToolStripMenuItem";
            this.写频ToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.写频ToolStripMenuItem.Text = "Записать кодплаг";
            this.写频ToolStripMenuItem.Click += new System.EventHandler(this.WriteCommunicationPro);
            // 
            // 机型信息ToolStripMenuItem
            // 
            this.机型信息ToolStripMenuItem.Name = "机型信息ToolStripMenuItem";
            this.机型信息ToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.机型信息ToolStripMenuItem.Text = "Информация о модели";
            this.机型信息ToolStripMenuItem.Visible = false;
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.手动选择端口ToolStripMenuItem,
            this.波特率选择ToolStripMenuItem,
            this.语言选择ToolStripMenuItem,
            this.总体参数调节ToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.字库IC提取数据ToolStripMenuItem,
            this.自动频率生成ToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(89, 23);
            this.toolsMenu.Text = "Настройки";
            // 
            // 手动选择端口ToolStripMenuItem
            // 
            this.手动选择端口ToolStripMenuItem.Name = "手动选择端口ToolStripMenuItem";
            this.手动选择端口ToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.手动选择端口ToolStripMenuItem.Text = "Выбор порта";
            this.手动选择端口ToolStripMenuItem.Click += new System.EventHandler(this.手动选择端口ToolStripMenuItem_Click);
            // 
            // 波特率选择ToolStripMenuItem
            // 
            this.波特率选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.波特率选择ToolStripMenuItem.Name = "波特率选择ToolStripMenuItem";
            this.波特率选择ToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.波特率选择ToolStripMenuItem.Text = "Битрейт";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(126, 24);
            this.toolStripMenuItem3.Text = "9600";
            this.toolStripMenuItem3.Visible = false;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(126, 24);
            this.toolStripMenuItem4.Text = "19200";
            this.toolStripMenuItem4.Visible = false;
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(126, 24);
            this.toolStripMenuItem5.Text = "38400";
            this.toolStripMenuItem5.Visible = false;
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(126, 24);
            this.toolStripMenuItem6.Text = "57600";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(126, 24);
            this.toolStripMenuItem7.Text = "115200";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // 语言选择ToolStripMenuItem
            // 
            this.语言选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.英文ToolStripMenuItem});
            this.语言选择ToolStripMenuItem.Name = "语言选择ToolStripMenuItem";
            this.语言选择ToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.语言选择ToolStripMenuItem.Text = "Язык";
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Checked = true;
            this.中文ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.中文ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简体ToolStripMenuItem,
            this.繁体ToolStripMenuItem});
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.中文ToolStripMenuItem.Text = "中文";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.中文ToolStripMenuItem_Click);
            // 
            // 简体ToolStripMenuItem
            // 
            this.简体ToolStripMenuItem.Name = "简体ToolStripMenuItem";
            this.简体ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.简体ToolStripMenuItem.Text = "简体";
            this.简体ToolStripMenuItem.Click += new System.EventHandler(this.简体ToolStripMenuItem_Click);
            // 
            // 繁体ToolStripMenuItem
            // 
            this.繁体ToolStripMenuItem.Name = "繁体ToolStripMenuItem";
            this.繁体ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.繁体ToolStripMenuItem.Text = "繁体";
            this.繁体ToolStripMenuItem.Click += new System.EventHandler(this.繁体ToolStripMenuItem_Click);
            // 
            // 英文ToolStripMenuItem
            // 
            this.英文ToolStripMenuItem.Name = "英文ToolStripMenuItem";
            this.英文ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.英文ToolStripMenuItem.Text = "英文";
            this.英文ToolStripMenuItem.Click += new System.EventHandler(this.英文ToolStripMenuItem_Click);
            // 
            // 总体参数调节ToolStripMenuItem
            // 
            this.总体参数调节ToolStripMenuItem.Name = "总体参数调节ToolStripMenuItem";
            this.总体参数调节ToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.总体参数调节ToolStripMenuItem.Text = "Базовые настройки";
            this.总体参数调节ToolStripMenuItem.Click += new System.EventHandler(this.总体参数调节ToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.optionsToolStripMenuItem.Text = "Режим тестов";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // 字库IC提取数据ToolStripMenuItem
            // 
            this.字库IC提取数据ToolStripMenuItem.Name = "字库IC提取数据ToolStripMenuItem";
            this.字库IC提取数据ToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.字库IC提取数据ToolStripMenuItem.Text = "Извлечение ICF";
            this.字库IC提取数据ToolStripMenuItem.Visible = false;
            this.字库IC提取数据ToolStripMenuItem.Click += new System.EventHandler(this.字库IC提取数据ToolStripMenuItem_Click);
            // 
            // 自动频率生成ToolStripMenuItem
            // 
            this.自动频率生成ToolStripMenuItem.Name = "自动频率生成ToolStripMenuItem";
            this.自动频率生成ToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.自动频率生成ToolStripMenuItem.Text = "Генерация списка каналов";
            this.自动频率生成ToolStripMenuItem.Visible = false;
            this.自动频率生成ToolStripMenuItem.Click += new System.EventHandler(this.自动频率生成ToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 27);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1119, 39);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.newToolStripButton.Text = "新建";
            this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.openToolStripButton.Text = "打开";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.saveToolStripButton.Text = "保存";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.printToolStripButton.Text = "读频";
            this.printToolStripButton.Click += new System.EventHandler(this.ReadCommunicationPro);
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.printPreviewToolStripButton.Text = "写频";
            this.printPreviewToolStripButton.Click += new System.EventHandler(this.WriteCommunicationPro);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.helpToolStripButton.Text = "本机信息";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CommSelect,
            this.FileAdd,
            this.SysTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 649);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1119, 28);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // CommSelect
            // 
            this.CommSelect.Name = "CommSelect";
            this.CommSelect.Size = new System.Drawing.Size(58, 23);
            this.CommSelect.Text = "COM15";
            // 
            // FileAdd
            // 
            this.FileAdd.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.FileAdd.Name = "FileAdd";
            this.FileAdd.Size = new System.Drawing.Size(30, 23);
            this.FileAdd.Text = "C:\\";
            this.FileAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // SysTime
            // 
            this.SysTime.Name = "SysTime";
            this.SysTime.Size = new System.Drawing.Size(139, 23);
            this.SysTime.Text = "toolStripStatusLabel2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FatherWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 677);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FatherWin";
            this.Text = "TYT TH-UV98 Open Source CPS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FatherWin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIParent1_FormClosed);
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
