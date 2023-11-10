// Decompiled with JetBrains decompiler
// Type: _8890DTest.company_Information
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _8890DTest
{
  public class company_Information : Form
  {
    public static string Warning = "警告版权所有(C)2016-2020，保留所有权利";
    private string[,] MessBoxName = new string[2, 5]
    {
      {
        "版本",
        "写频软件用于 ",
        "完成时间：",
        "警告版权所有(C)2016-2020，保留所有权利",
        "关于 "
      },
      {
        "Ver:",
        "The SoftWare Apply For ",
        "Compelete Time:",
        "警告版权所有(C)2016-2020，保留所有权利",
        "About "
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
        "Canel"
      }
    };
    private IContainer components = (IContainer) null;
    private PictureBox pictureBox1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button button1;
    private Label label5;

    public company_Information()
    {
      this.InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void company_Information_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Class1.MainFilePath + "logo.ico");
      this.label1.Text = Class1.RadioName;
      this.label2.Text = this.MessBoxName[Class1.English_En, 0] + Class1.SoftVer;
      this.label3.Text = this.MessBoxName[Class1.English_En, 1] + Class1.RadioName;
      this.label5.Text = this.MessBoxName[Class1.English_En, 2] + Class1.CompleteTime;
      this.Text = this.MessBoxName[Class1.English_En, 4];
      this.button1.Text = company_Information.Button_EngCh[Class1.English_En, 0];
      this.pictureBox1.Image = Image.FromFile(Class1.MainFilePath + "pictureBoxImag.jpg");
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void label5_Click(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (company_Information));
      this.pictureBox1 = new PictureBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.button1 = new Button();
      this.label5 = new Label();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(12, 24);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(59, 142);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.label1.Location = new Point(87, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(63, 14);
      this.label1.TabIndex = 1;
      this.label1.Text = "TH-9200";
      this.label1.Click += new EventHandler(this.label1_Click);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.label2.Location = new Point(87, 43);
      this.label2.Name = "label2";
      this.label2.Size = new Size(69, 14);
      this.label2.TabIndex = 2;
      this.label2.Text = "版本V1.0";
      this.label2.Click += new EventHandler(this.label2_Click);
      this.label3.AutoSize = true;
      this.label3.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.label3.Location = new Point(87, 70);
      this.label3.Name = "label3";
      this.label3.Size = new Size(183, 14);
      this.label3.TabIndex = 3;
      this.label3.Text = "TH-9200写频软件用于车台";
      this.label3.Click += new EventHandler(this.label3_Click);
      this.button1.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.button1.Location = new Point(117, 122);
      this.button1.Name = "button1";
      this.button1.Size = new Size(88, 44);
      this.button1.TabIndex = 5;
      this.button1.Text = "确定";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label5.AutoSize = true;
      this.label5.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.label5.Location = new Point(87, 97);
      this.label5.Name = "label5";
      this.label5.Size = new Size(131, 14);
      this.label5.TabIndex = 6;
      this.label5.Text = "完成时间2014.4.1";
      this.label5.Click += new EventHandler(this.label5_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(332, 173);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Name = nameof (company_Information);
      this.Text = "关于";
      this.Load += new EventHandler(this.company_Information_Load);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
