// Decompiled with JetBrains decompiler
// Type: _8890DTest.Properties.Resources
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace _8890DTest.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) _8890DTest.Properties.Resources.resourceMan, (object) null))
          _8890DTest.Properties.Resources.resourceMan = new ResourceManager("_8890DTest.Properties.Resources", typeof (_8890DTest.Properties.Resources).Assembly);
        return _8890DTest.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => _8890DTest.Properties.Resources.resourceCulture;
      set => _8890DTest.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap 未标题_1_拷贝 => (Bitmap) _8890DTest.Properties.Resources.ResourceManager.GetObject("未标题-1 拷贝", _8890DTest.Properties.Resources.resourceCulture);
  }
}
