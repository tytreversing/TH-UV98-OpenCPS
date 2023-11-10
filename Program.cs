// Decompiled with JetBrains decompiler
// Type: _8890DTest.Program
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;
using System.Windows.Forms;

namespace _8890DTest
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.Run((Form) new FatherWin());
    }
  }
}
