// Decompiled with JetBrains decompiler
// Type: _8890DTest.Class2
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using System;

namespace _8890DTest
{
  internal class Class2
  {
    public static int StringChUsefulPro(string strtemp, int i)
    {
      strtemp = strtemp.Substring(7 + i / 8 * 2, 2);
      int int32 = Convert.ToInt32(strtemp, 16);
      i %= 8;
      switch (i)
      {
        case 0:
          int32 &= 1;
          break;
        case 1:
          int32 &= 2;
          break;
        case 2:
          int32 &= 4;
          break;
        case 3:
          int32 &= 8;
          break;
        case 4:
          int32 &= 16;
          break;
        case 5:
          int32 &= 32;
          break;
        case 6:
          int32 &= 64;
          break;
        case 7:
          int32 &= 128;
          break;
      }
      return int32 != 0 ? 1 : 0;
    }

    public static string GetOneChStringPro(string[] n, int i)
    {
      int num = Class1.ConOneChDatCt * i / Class1.ConOneRowDatCt + Class1.ChInfAddr / Class1.ConOneRowDatCt;
      string str1 = Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num]);
      string str2 = str1.Substring(Class1.ConUseChDatSta + 1, str1.Length - Class1.ConUseChDatSta - 1);
      string str3 = Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num + 1]);
      return (str2 + str3.Substring(Class1.ConUseChDatSta + 1, str3.Length - Class1.ConUseChDatSta - 1)).Substring(Class1.ConOneChDatCt * i % Class1.ConOneRowDatCt << 1, 2 * Class1.ConOneChDatCt);
    }

    public static string GetOneChStringAddNamePro(string[] n, int i)
    {
      int num = Class1.ConOneChNameDatCt * i / Class1.ConOneRowDatCt + Class1.ChInfNameAddr / Class1.ConOneRowDatCt;
      string str1 = Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num]);
      string str2 = str1.Substring(Class1.ConUseChDatSta + 1, str1.Length - Class1.ConUseChDatSta - 1);
      string str3 = Class2.AutoAdd_n_Pro(n[Class1.FielBegRow + num + 1]);
      return (str2 + str3.Substring(Class1.ConUseChDatSta + 1, str3.Length - Class1.ConUseChDatSta - 1)).Substring(Class1.ConOneChNameDatCt * i % Class1.ConOneRowDatCt << 1, 2 * Class1.ConOneChNameDatCt);
    }

    public static string StringChgPro(string StrTemp1, int data)
    {
      string str = "";
      for (int index = 0; index < data; ++index)
        str = StrTemp1.Substring(2 * index, 2) + str;
      return str;
    }

    public static string StringChgFrePro(string StrTemp, int data)
    {
      StrTemp = Convert.ToInt32(StrTemp, 16).ToString();
      StrTemp = StrTemp.Insert(StrTemp.Length - data, ".");
      return StrTemp;
    }

    public static string StringGetDcsPro(string StrTemp)
    {
      StrTemp = Convert.ToString(Convert.ToInt32(StrTemp, 16) & 511, 8);
      int length = StrTemp.Length;
      if (length < 3)
      {
        for (int index = 0; index < 3 - length; ++index)
          StrTemp = "0" + StrTemp;
      }
      return StrTemp;
    }

    private static string ChgToSubDataPro(string StrTemp, int Temp)
    {
      if (0 == Temp)
        StrTemp = Class1.CtcTone[0];
      else if (1 == Temp)
        StrTemp = Class2.StringChgFrePro(StrTemp, 1);
      else if (2 == Temp)
      {
        StrTemp = Class2.StringGetDcsPro(StrTemp);
        StrTemp += "N";
      }
      else if (3 == Temp)
      {
        StrTemp = Class2.StringGetDcsPro(StrTemp);
        StrTemp += "I";
      }
      return StrTemp;
    }

    public static string Rx_TxChgToSubDataPro(string StrTemp, int DcsI)
    {
      StrTemp = StrTemp.Substring(1, 3);
      int num = Convert.ToInt32(StrTemp, 16) & 4095;
      StrTemp = num > 2600 ? Class2.ChgToSubDataPro(StrTemp, 0) : (num > 511 ? Class2.ChgToSubDataPro(StrTemp, 1) : (1 != DcsI ? Class2.ChgToSubDataPro(StrTemp, 2) : Class2.ChgToSubDataPro(StrTemp, 3)));
      return StrTemp;
    }

    public static string StringChNamePro(string StrTemp1)
    {
      string str1 = "";
      for (int index = 0; index < StrTemp1.Length / 2; ++index)
      {
        string str2 = Class1.AsciiToStr(Convert.ToInt32(StrTemp1.Substring(2 * index, 2), 16));
        str1 += str2;
      }
      return str1;
    }

    public static string DoubleDataChgPro(string StrTemp)
    {
      try
      {
        string str = Convert.ToDouble(StrTemp).ToString();
        int num1 = StrTemp.IndexOf(".");
        int num2 = StrTemp.IndexOf(",");
        int num3 = str.IndexOf(".");
        int num4 = str.IndexOf(",");
        int length = str.Length;
        if (num1 > 0)
        {
          if (num3 < 0)
          {
            if (length != num1)
              StrTemp = StrTemp.Replace(".", ",");
          }
        }
        else if (num2 > 0)
        {
          if (num4 < 0 && length != num2)
            StrTemp = StrTemp.Replace(",", ".");
        }
      }
      catch
      {
        StrTemp = StrTemp.IndexOf(".") <= -1 ? StrTemp.Replace(",", ".") : StrTemp.Replace(".", ",");
      }
      return StrTemp;
    }

    public static string StrDataPro(string StrTemp)
    {
      StrTemp = Class2.DoubleDataChgPro(StrTemp);
      StrTemp = Convert.ToDouble(StrTemp).ToString();
      return StrTemp;
    }

    public static string AutoAddFreBytePro(string StrTemp)
    {
      StrTemp = Class2.StrDataPro(StrTemp);
      int num1 = StrTemp.IndexOf('.');
      if (num1 == -1)
      {
        num1 = StrTemp.IndexOf(',');
        if (num1 == -1)
        {
          StrTemp += ".00000";
          return StrTemp;
        }
      }
      int num2 = num1 + 1;
      if (StrTemp.Length > num2)
      {
        string str = StrTemp.Substring(num2 + 1, StrTemp.Length - num2 - 1);
        if (str.Length < 5)
        {
          int num3 = 5 - str.Length;
          for (int index = 1; index < num3; ++index)
            StrTemp += "0";
        }
      }
      else
        StrTemp += "00000";
      return StrTemp;
    }

    public static string DataUseFulFreChk(string StrTemp, int TxFreData)
    {
      try
      {
        if (StrTemp == "")
          return StrTemp;
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num1 = Convert.ToDouble(StrTemp) * 100000.0;
        if ((num1 < (double) Class1.FreBandData[0, TxFreData] || num1 > (double) Class1.FreBandData[0, TxFreData + 1] || 0 == Class1.FreBandData[0, TxFreData]) && (num1 < (double) Class1.FreBandData[1, TxFreData] || num1 > (double) Class1.FreBandData[1, TxFreData + 1] || 0 == Class1.FreBandData[1, TxFreData]) && (num1 < (double) Class1.FreBandData[2, TxFreData] || num1 > (double) Class1.FreBandData[2, TxFreData + 1] || 0 == Class1.FreBandData[2, TxFreData]))
        {
          StrTemp = "BandOver";
          return StrTemp;
        }
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num2 = Convert.ToDouble(StrTemp) * 1000.0;
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

    public static string DataUseFulFreChk1(string StrTemp, int TxFreData, int band)
    {
      try
      {
        if (StrTemp == "")
          return StrTemp;
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num1 = Convert.ToDouble(StrTemp) * 100000.0;
        if (num1 < (double) Class1.FreBandData[band, TxFreData] || num1 > (double) Class1.FreBandData[band, TxFreData + 1] || 0 == Class1.FreBandData[band, TxFreData])
        {
          StrTemp = "BandOver";
          return StrTemp;
        }
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num2 = Convert.ToDouble(StrTemp) * 1000.0;
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

    public static int DataUseFulFreChk02(string StrTemp)
    {
      try
      {
        if (StrTemp == "")
          return 0;
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num = Convert.ToDouble(StrTemp);
        int index = 0;
        while (index <= 2 && (num < (double) Class1.FreBand[0, index] || num > (double) Class1.FreBand[1, index]))
          ++index;
        return index >= 3 ? 0 : index;
      }
      catch
      {
        return 0;
      }
    }

    public static string DataUseFulFreChk01(string StrTemp, int TxFreData)
    {
      try
      {
        if (StrTemp == "")
          return StrTemp;
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num = Convert.ToDouble(StrTemp) * 100000.0;
        if ((num < (double) Class1.FreBandData[0, TxFreData] || num > (double) Class1.FreBandData[0, TxFreData + 1] || 0 == Class1.FreBandData[0, TxFreData]) && (num < (double) Class1.FreBandData[1, TxFreData] || num > (double) Class1.FreBandData[1, TxFreData + 1] || 0 == Class1.FreBandData[1, TxFreData]) && (num < (double) Class1.FreBandData[2, TxFreData] || num > (double) Class1.FreBandData[2, TxFreData + 1] || 0 == Class1.FreBandData[2, TxFreData]))
        {
          StrTemp = "BandOver";
          return StrTemp;
        }
        StrTemp = Class2.AutoAddFreBytePro(StrTemp);
      }
      catch
      {
        StrTemp = "";
      }
      return StrTemp;
    }

    public static string AutoRetFreBytePro(string StrTemp, int TxFreData)
    {
      if (Class2.DataUseFulFreChk01(StrTemp, TxFreData) == "BandOver")
      {
        int index = Class2.DataUseFulFreChk02(StrTemp);
        StrTemp = Class2.AutoAddFreBytePro((Class1.FreBandData[index, 0] / 100000).ToString());
      }
      return StrTemp;
    }

    public static string DataUseFulFreChk5(string StrTemp, int TxFreData, int FreBand)
    {
      try
      {
        if (StrTemp == "")
          return StrTemp;
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num1 = Convert.ToDouble(StrTemp) * 100000.0;
        if (num1 < (double) Class1.FreBandData[FreBand, TxFreData] || num1 > (double) Class1.FreBandData[FreBand, TxFreData + 1] || 0 == Class1.FreBandData[FreBand, TxFreData])
        {
          StrTemp = "BandOver";
          return StrTemp;
        }
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num2 = Convert.ToDouble(StrTemp) * 1000.0;
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

    public static string DataUseFulFreShiftChk(string StrTemp, int Band)
    {
      try
      {
        if (StrTemp == "")
          return StrTemp;
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num1 = Convert.ToDouble(StrTemp) * 100000.0;
        if (num1 > 12000000.0 && Band == 1 || num1 > 12000000.0 && Band == 3)
        {
          StrTemp = "BandOver";
          return StrTemp;
        }
        if (num1 > 4000000.0 && Band == 0 || num1 > 4000000.0 && Band == 2)
        {
          StrTemp = "BandOver";
          return StrTemp;
        }
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num2 = Convert.ToDouble(StrTemp) * 1000.0;
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

    public static string ChgRxFreToDataPro(string StrTemp)
    {
      if (StrTemp == "")
      {
        StrTemp = "FFFFFFFF";
        return StrTemp;
      }
      StrTemp = Class2.DoubleDataChgPro(StrTemp);
      double num1 = Convert.ToDouble(StrTemp) * 100000.0;
      int num2 = (int) num1;
      if (num1 % 1.0 >= 0.5)
        ++num2;
      StrTemp = num2.ToString();
      StrTemp = Class1.ConvertString(StrTemp, 10, 16);
      if (StrTemp.Length < 8)
      {
        num2 = 8 - StrTemp.Length;
        for (int index = 0; index < num2; ++index)
          StrTemp = "0" + StrTemp;
      }
      StrTemp = Class2.StringChgPro(StrTemp, 4);
      return StrTemp;
    }

    private static string AutoAdd2ToneBytePro(string StrTemp)
    {
      StrTemp = Class2.StrDataPro(StrTemp);
      int num1 = StrTemp.IndexOf('.');
      if (num1 == -1)
      {
        num1 = StrTemp.IndexOf(',');
        if (num1 == -1)
        {
          StrTemp += ".0";
          return StrTemp;
        }
      }
      int num2 = num1 + 1;
      if (StrTemp.Length <= num2)
        StrTemp += "0";
      return StrTemp;
    }

    public static string DataUseFulToneChk(string StrTemp)
    {
      try
      {
        if (StrTemp == "")
          return StrTemp;
        StrTemp = Class2.DoubleDataChgPro(StrTemp);
        double num = Convert.ToDouble(StrTemp);
        if (num < (double) Class1.Tone2Band[0] || num > (double) Class1.Tone2Band[1])
        {
          StrTemp = "BandOver";
          return StrTemp;
        }
        StrTemp = num.ToString();
        StrTemp = Class2.AutoAdd2ToneBytePro(StrTemp);
      }
      catch
      {
        StrTemp = "";
      }
      return StrTemp;
    }

    public static string ChgToneToDataPro(string StrTemp)
    {
      if (StrTemp == "")
      {
        StrTemp = "2020";
        return StrTemp;
      }
      StrTemp = Class2.DoubleDataChgPro(StrTemp);
      int num = (int) (Convert.ToDouble(StrTemp) * 10.0);
      StrTemp = num.ToString();
      StrTemp = Class1.ConvertString(StrTemp, 10, 16);
      if (StrTemp.Length < 4)
      {
        num = 4 - StrTemp.Length;
        for (int index = 0; index < num; ++index)
          StrTemp = "0" + StrTemp;
      }
      return StrTemp;
    }

    public static string ChgCtcToDataPro(string StrTemp)
    {
      StrTemp = Class2.DoubleDataChgPro(StrTemp);
      StrTemp = ((int) (Convert.ToDouble(StrTemp) * 10.0)).ToString();
      StrTemp = Class1.ConvertString(StrTemp, 10, 16);
      if (StrTemp.Length < 4)
      {
        int num = 4 - StrTemp.Length;
        for (int index = 0; index < num; ++index)
          StrTemp = "0" + StrTemp;
      }
      StrTemp = Class2.StringChgPro(StrTemp, 2);
      return StrTemp;
    }

    public static string ChgDcsToDataPro(string StrTemp)
    {
      StrTemp = Convert.ToInt32(StrTemp).ToString();
      StrTemp = Class1.ConvertString(StrTemp, 8, 16);
      if (StrTemp.Length < 4)
      {
        int num = 4 - StrTemp.Length;
        for (int index = 0; index < num; ++index)
          StrTemp = "0" + StrTemp;
      }
      StrTemp = Class2.StringChgPro(StrTemp, 2);
      return StrTemp;
    }

    private static string GetDcsToDataPro(string StrTemp)
    {
      StrTemp = StrTemp.Substring(0, StrTemp.Length - 1);
      StrTemp = Convert.ToInt32(StrTemp).ToString();
      StrTemp = Class1.ConvertString(StrTemp, 8, 16);
      StrTemp = Class1.StrAutoAdd0Pro(StrTemp, (byte) 3);
      return StrTemp;
    }

    private static string GetCtcToDataPro(string StrTemp)
    {
      StrTemp = Class2.DoubleDataChgPro(StrTemp);
      StrTemp = ((int) (Convert.ToDouble(StrTemp) * 10.0)).ToString();
      StrTemp = Class1.ConvertString(StrTemp, 10, 16);
      StrTemp = "0" + StrTemp;
      return StrTemp;
    }

    public static string ChgSubToDataPro(string StrTemp)
    {
      if (StrTemp.Length == 4)
      {
        string str = StrTemp.Substring(StrTemp.Length - 1, 1);
        if (str == "N" || str == "n" || str == "I" || str == "i")
        {
          StrTemp = Class2.GetDcsToDataPro(StrTemp);
          StrTemp = "0" + StrTemp;
        }
        else
          StrTemp = Class2.GetCtcToDataPro(StrTemp);
      }
      else
        StrTemp = !(StrTemp == Class1.CtcTone[0]) ? Class2.GetCtcToDataPro(StrTemp) : "0FFF";
      StrTemp = Class2.StringChgPro(StrTemp, 2);
      return StrTemp;
    }

    public static string ChgStringToAcsPro(string StrTemp, int length)
    {
      if (StrTemp.Length < length)
      {
        int num = length - StrTemp.Length;
        for (int index = 0; index < num; ++index)
          StrTemp += " ";
      }
      StrTemp = Class1.StrToAscii(StrTemp);
      StrTemp = StrTemp.Substring(0, length << 1);
      return StrTemp;
    }

    public static int GetShiftDirPro(string StrTemp, string StrTemp1)
    {
      int shiftDirPro = 0;
      if (StrTemp != "FFFFFFFF" && StrTemp != "FFFFFFFF")
      {
        int int32_1 = Convert.ToInt32(StrTemp, 16);
        int int32_2 = Convert.ToInt32(StrTemp1, 16);
        if (int32_1 > int32_2)
          shiftDirPro = 1;
        else if (int32_1 > int32_2)
          shiftDirPro = 2;
      }
      return shiftDirPro;
    }

    public static string SetSttEn_DisablePro(string strtemp, int i, bool ChEnable)
    {
      int int32 = Convert.ToInt32(strtemp.Substring(7 + i / 8 * 2, 2), 16);
      int num = i % 8;
      if (ChEnable)
      {
        switch (num)
        {
          case 0:
            int32 |= 1;
            break;
          case 1:
            int32 |= 2;
            break;
          case 2:
            int32 |= 4;
            break;
          case 3:
            int32 |= 8;
            break;
          case 4:
            int32 |= 16;
            break;
          case 5:
            int32 |= 32;
            break;
          case 6:
            int32 |= 64;
            break;
          case 7:
            int32 |= 128;
            break;
        }
      }
      else
      {
        switch (num)
        {
          case 0:
            int32 &= 254;
            break;
          case 1:
            int32 &= 253;
            break;
          case 2:
            int32 &= 251;
            break;
          case 3:
            int32 &= 247;
            break;
          case 4:
            int32 &= 239;
            break;
          case 5:
            int32 &= 223;
            break;
          case 6:
            int32 &= 191;
            break;
          case 7:
            int32 &= (int) sbyte.MaxValue;
            break;
        }
      }
      string str1 = strtemp.Substring(0, 7 + i / 8 * 2);
      string str2 = Convert.ToString(int32, 16);
      if (str2.Length <= 1)
        str2 = "0" + str2;
      string str3 = strtemp.Substring(7 + i / 8 * 2 + 2, strtemp.Length - (7 + i / 8 * 2 + 2));
      strtemp = str1 + str2 + str3;
      return strtemp;
    }

    public static int ChgBoolToDatPro(bool TempBit) => !TempBit ? 0 : 1;

    public static string ChgToDatPro(string StrTemp, int ByteNum, int ByteBit)
    {
      int length = StrTemp.Length;
      if (length < ByteNum)
      {
        StrTemp = StrTemp.Substring(0, length);
        for (int index = length + 1; index <= ByteNum; ++index)
        {
          int num = index % 16;
          StrTemp += Convert.ToString(num, 16);
        }
      }
      else
        StrTemp = StrTemp.Substring(0, length);
      if (0 == ByteNum % 2)
      {
        string str = Convert.ToString(length, 16);
        if (str.Length <= 1)
          str = "0" + str;
        StrTemp = StrTemp.Substring(0, ByteNum) + str;
      }
      else
      {
        int num = Convert.ToInt32(StrTemp.Substring(ByteNum - 1, 1), 16) << ByteBit | length;
        StrTemp = StrTemp.Substring(0, ByteNum - 1) + Convert.ToString(num, 16);
      }
      return StrTemp;
    }

    public static bool UseFulChkPro(string DtmfChData, int Chnum)
    {
      int int32 = Convert.ToInt32(DtmfChData, 16);
      switch (Chnum)
      {
        case 0:
          int32 &= 1;
          break;
        case 1:
          int32 &= 2;
          break;
        case 2:
          int32 &= 4;
          break;
        case 3:
          int32 &= 8;
          break;
        case 4:
          int32 &= 16;
          break;
        case 5:
          int32 &= 32;
          break;
        case 6:
          int32 &= 64;
          break;
        case 7:
          int32 &= 128;
          break;
      }
      return int32 != 0;
    }

    public static int LookCharDataPro(string[] ArrTemp, string StringTemp)
    {
      int index = 0;
      while (index < ArrTemp.Length && !(ArrTemp[index] == StringTemp))
        ++index;
      if (index >= ArrTemp.Length)
        index = 0;
      return index;
    }

    public static string AutoAdd0Pro(string StrTemp, int TalCt)
    {
      if (StrTemp.Length < TalCt)
      {
        int num = TalCt - StrTemp.Length;
        for (int index = 0; index < num; ++index)
          StrTemp = "0" + StrTemp;
      }
      return StrTemp;
    }

    public static string GetChUseFulStringPro(int TotalCt, string StrData)
    {
      int[] numArray = new int[TotalCt / 8];
      for (int startIndex = 0; startIndex < TotalCt; ++startIndex)
      {
        numArray[startIndex / 8] >>= 1;
        if (StrData.Substring(startIndex, 1) == "1")
          numArray[startIndex / 8] = numArray[startIndex / 8] | 128;
      }
      string chUseFulStringPro = "";
      if (TotalCt % 8 != 0)
        TotalCt = TotalCt / 8 + 1;
      else
        TotalCt /= 8;
      for (int index = 0; index < TotalCt; ++index)
        chUseFulStringPro += Class2.AutoAdd0Pro(Convert.ToString(numArray[index], 16), 2);
      return chUseFulStringPro;
    }

    private static void GetRfRangOnePro(string Datastr, int i)
    {
      string str1 = Class2.StringChgPro(Datastr.Substring(0, 8), 4);
      string str2 = Class2.StringChgPro(Datastr.Substring(8, 8), 4);
      string str3 = Class2.StringChgPro(Datastr.Substring(16, 8), 4);
      string str4 = Class2.StringChgPro(Datastr.Substring(24, 8), 4);
      try
      {
        int int32_1 = Convert.ToInt32(str1, 16);
        int32_1 = Convert.ToInt32(str2, 16);
        int32_1 = Convert.ToInt32(str3, 16);
        int32_1 = Convert.ToInt32(str4, 16);
        if (str1 == "FFFFFFFF" || str2 == "FFFFFFFF")
        {
          Class1.FreBandData[i, 0] = 0;
          Class1.FreBandData[i, 1] = 0;
          Class1.FreBandData[i, 2] = 0;
          Class1.FreBandData[i, 3] = 0;
        }
        else
        {
          int int32_2 = Convert.ToInt32(str1, 16);
          Class1.FreBandData[i, 0] = int32_2;
          int int32_3 = Convert.ToInt32(str2, 16);
          Class1.FreBandData[i, 1] = int32_3;
          if (str1 == "FFFFFFFF" || str2 == "FFFFFFFF")
          {
            Class1.FreBandData[i, 2] = 0;
            Class1.FreBandData[i, 3] = 0;
          }
          else
          {
            int int32_4 = Convert.ToInt32(str3, 16);
            Class1.FreBandData[i, 2] = int32_4;
            int int32_5 = Convert.ToInt32(str4, 16);
            Class1.FreBandData[i, 3] = int32_5;
          }
        }
      }
      catch
      {
        Class1.FreBandData[i, 0] = 0;
        Class1.FreBandData[i, 1] = 0;
        Class1.FreBandData[i, 2] = 0;
        Class1.FreBandData[i, 3] = 0;
      }
    }

    public static void GetRfRangPro(string FileName)
    {
      string[] strArray = Class1.ReadFileDataPro(FileName).Split('\r');
      int num = Class1.FreBandBegAddr / Class1.ConOneRowDatCt;
      int index = Class1.FielBegRow + num;
      string str1 = Class2.AutoAdd_n_Pro(strArray[index]);
      string str2 = str1.Substring(Class1.ConUseChDatSta + 1, str1.Length - Class1.ConUseChDatSta - 1);
      string str3 = Class2.AutoAdd_n_Pro(strArray[index + 1]);
      string str4 = str3.Substring(Class1.ConUseChDatSta + 1, str3.Length - Class1.ConUseChDatSta - 1);
      string str5 = str2 + str4;
      if (str5.Length >= 96)
        str5 = str5.Substring(0, 96);
      Class2.GetRfRangOnePro(str5.Substring(0, 32), 0);
      Class2.GetRfRangOnePro(str5.Substring(32, 32), 1);
      Class2.GetRfRangOnePro(str5.Substring(64, 32), 2);
    }

    public static string AutoAdd_n_Pro(string m)
    {
      string str = m.Substring(0, 1);
      if (str != "\n" && str != "n")
        m = "\n" + m;
      return m;
    }

    public static string WannengCode()
    {
      string str = string.Format("{0:yyyyMMddHH}", (object) DateTime.Now);
      Convert.ToInt32(str.Substring(2, 4), 16);
      int int32_1 = Convert.ToInt32(str.Substring(4, 2), 16);
      int int32_2 = Convert.ToInt32(str.Substring(6, 2), 16);
      int Data1 = Convert.ToInt32(str.Substring(8, 2), 16) ^ int32_1 ^ 53;
      int Data2 = int32_2 ^ Data1 ^ 53;
      int Data3 = Data2 ^ Data1 ^ 53;
      int Data4 = Data3 ^ Data2 ^ 53;
      return Class1.DataToHexStr((long) Data1) + Class1.DataToHexStr((long) Data2) + Class1.DataToHexStr((long) Data3) + Class1.DataToHexStr((long) Data4);
    }
  }
}
