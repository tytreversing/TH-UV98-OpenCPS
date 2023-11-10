// Decompiled with JetBrains decompiler
// Type: _8890DTest.编程注意事项
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class 编程注意事项 : Form
  {
    private IContainer components = (IContainer) null;
    private TextBox textBox1;
    private TextBox textBox2;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.SuspendLayout();
      this.textBox1.Location = new Point(12, 12);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = ScrollBars.Vertical;
      this.textBox1.Size = new Size(1101, 112);
      this.textBox1.TabIndex = 0;
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.textBox2.Location = new Point(12, 130);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ScrollBars = ScrollBars.Vertical;
      this.textBox2.Size = new Size(1101, 162);
      this.textBox2.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1133, 568);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Name = nameof (编程注意事项);
      this.Text = nameof (编程注意事项);
      this.Load += new EventHandler(this.编程注意事项_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public 编程注意事项() => this.InitializeComponent();

    private void 编程注意事项_Load(object sender, EventArgs e)
    {
      this.textBox1.Text = "编程注意事项1、在串口事件处理中（中断）改变除控件属性（串口控件外）必须通过跨线程操作。如 this.Invoke(new EventHandler(DisplayText))2、在串口事件处理中（中断）跨线程操作时，禁止关闭口串口否则会引起死机。3、串口属性serialPort1.RtsEnable = true  serialPort1.DtrEnable = true 必须视情况而开启，否则可能认写频线";
      this.textBox2.Text = "TreeView单击事件注意： 因为你每次在触发Click的时候Treeview选择的节点还是上次选中的节点如果你对同一节点点击两次以上就会显示正确的节点名称了！解决办法：原因是SelectedNode并不是你刚点上去的那个节点，而是之前选中的那一个。解决方法是在MouseDown事件里面写如下代码： if ((sender as TreeView) != null){treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);}";
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }
  }
}
