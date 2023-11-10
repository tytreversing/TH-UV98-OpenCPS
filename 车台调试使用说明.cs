// Decompiled with JetBrains decompiler
// Type: _8890DTest.车台调试使用说明
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class 车台调试使用说明 : Form
  {
    private IContainer components = (IContainer) null;
    private ListBox listBox1;

    public 车台调试使用说明()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void 车音调试使用说明_Load(object sender, EventArgs e)
    {
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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
      this.listBox1 = new ListBox();
      this.SuspendLayout();
      this.listBox1.Font = new Font("宋体", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 21;
      this.listBox1.Items.AddRange(new object[10]
      {
        (object) "                            使用说明",
        (object) " 1 点击读取当前值，进入调试模式。",
        (object) " 2 点击开始发射调节，进放发射相关参数的调节，",
        (object) "   将光标切换到指定选项内按上下键，或滚动滚轮，调节相应选项。   ",
        (object) " 3 点击开如接收调节，进放接收相关参数的调节，",
        (object) "   将光标切换到指定选项内按上下键，或滚动滚轮，调节相应选项。     \t",
        (object) " 4 注:13.8V参考电压为自动较准选项。较准方法:将电源电压调到13.8V，",
        (object) "   调节选项按钮，当前值将自动获取。",
        (object) " 5 注:可在进入调试模式后，直接输入指定值后，直接点写入当前值。",
        (object) "   可完成批写。"
      });
      this.listBox1.Location = new Point(12, 12);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(721, 256);
      this.listBox1.TabIndex = 1;
      this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(736, 354);
      this.Controls.Add((Control) this.listBox1);
      this.Name = nameof (车台调试使用说明);
      this.Text = "车音调试使用说明";
      this.Load += new EventHandler(this.车音调试使用说明_Load);
      this.ResumeLayout(false);
    }
  }
}
