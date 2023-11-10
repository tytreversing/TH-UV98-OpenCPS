// Decompiled with JetBrains decompiler
// Type: _8890DTest.Class1
// Assembly: TH-UV98, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08C2362D-09D4-47BA-95BA-76236319AA37
// Assembly location: C:\UV98 V1.00\Uv98_SoftWare_Eng\TH-UV98.exe

using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _8890DTest
{
  internal class Class1
  {
    public const string ConSettingFile = "settings.ini";
    public const string ConDefaulFile = "DefaulFile.icf";
    public const string ConFile = "ConFile.icf";
    public const string ConTempFile = "ConTempFile.icf";
    public const ushort ConTotalRow = 199;
    public const ushort ConMaxRowNum = 199;
    public const ushort ConMaxBand = 0;
    public const ushort ConMaxVfo = 6;
    public const ushort ConMaxOneTm = 20;
    public const string ConHandCom = "FEFEEEEFE055563938FD";
    public const string ConHandAckCom = "FEFEEFEEE155563938";
    public const string ConBaudRateCom = "FEFEEEEFE65556393801FD";
    public const string ConEntReadCom = "FEFEEEEFE255563938FD";
    public const string ConEntWriteCom = "FEFEEEEFE355563938FD";
    public const string ConEndCom = "FEFEEEEFE555563938FD";
    public const string ConCodeCom = "FEFEEEEFE7";
    public const string ConTxReadCom = "FEFEEEEFEB";
    public const string ConTxWriteCom = "FEFEEEEFE4";
    public const string ConAckCom = "FEFEEFEEE600FD";
    public const string ConAckFailCom = "FEFEEFEEE603FD";
    public const string ConReadDatAckCom = "FEFEEFEEE4";
    public const string ConKiilCodeBuf = "3445";
    public const string ConCodeEnAckCom = "3435";
    public const string ConKillCodeEnAckCom = "3533";
    public const string ConStunCodeEnAckCom = "3442";
    public const string ConDigFreCom = "FEFEEEEFA030303034";
    public const string ConFreAdj_Com = "FEFEEEEFA031323031";
    public const string ConSqlAdj_Com = "FEFEEEEFA031333031";
    public const string ConLowPAdj_Com = "FEFEEEEFA031343031";
    public const string ConHigPAdj_Com = "FEFEEEEFA031353031";
    public const string ConDevAdj_Com = "FEFEEEEFA031363031";
    public const string ConDcsAdj_Com = "FEFEEEEFA031373031";
    public const string ConCtcAdj_Com = "FEFEEEEFA031383031";
    public const string ConEntItemCom = "FEFEEEEFFA5556";
    public const string ConExitItemCom = "FEFEEEEFF355563838093039FD";
    public const string ConPttonCom = "FEFEEEEFA0353530313333FD";
    public const string ConPttOffCom = "FEFEEEEFA0363630313636FD";
    public const string ConWriTestCom = "FEFEEEEFF255563838000000FD";
    public const string ConExtWriModCom = "FEFEEEEFF755563838000000FD";
    public const string ConEntTestCom = "FEFEEEEFF055563838000000FD";
    public const string ConExitTestCom = "FEFEEEEFF155563838000000FD";
    public const string ConPttpressCom = "FEFEEEEFF4555638";
    public const string ConPttupCom = "FEFEEEEFF5555638";
    public static string RadioName = "UV-88";
    public static string CompanyName = "TYT INC.(C)";
    public static string SoftVer = "Ver1.21";
    public static string CompleteTime = "2020.09.28";
    public static string GpsEable = "Disable";
    public static string LanguageDisEable = "Disable1";
    public static int GIFontSel = 0;
    public static int GITraditionalChEn = 1;
    public static string GiRightCode = "FFFFFFFF";
    public static string MainFilePath;
    public static string GiDailData = "";
    public static string GiCallId = "";
    public static string GiInfData = "";
    public static int Vfo_En = 1;
    public static int ReadForWrite_En = 0;
    public static int ReadForDis_En = 0;
    public static int English_En = 0;
    public static int FielBegRow = 3;
    public static int ConOneChDatCt = 21;
    public static int ConOneChNameDatCt = 10;
    public static int ConOneRowDatCt = 32;
    public static int ConUseChDatSta = 6;
    public static int ChInfAddr = 0;
    public static int Left_VFoChInfAddr0 = 4284;
    public static int Left_VFoChInfAddr1 = 4305;
    public static int Left_VFoChInfAddr2 = 4326;
    public static int Right_VFoChInfAddr0 = 4347;
    public static int Right_VFoChInfAddr1 = 4368;
    public static int Right_VFoChInfAddr2 = 4389;
    public static int ChInfNameAddr = 6496;
    public static int ChinfBegAddr = 4480;
    public static int ChSkipBegAddr = 4512;
    public static int ConSetBegAddr = 4448;
    public static int ConDtmfChBegAddr = 4544;
    public static int ConDtmfSetAddr = 4768;
    public static int ConOneDtmfChDatCt = 13;
    public static int Tone2BegAddr = 4864;
    public static int Tone2RxAddr = 5056;
    public static int ConOneTone2ChDatCt = 11;
    public static int Tone5TxBegAddr = 5088;
    public static int Tone5SetAddr = 5600;
    public static int Tone5RxBegAddr = 5632;
    public static int ConOneTxTone5ChDatCt = 32;
    public static int ConOneRxTone5ChDatCt = 16;
    public static int FreBandBegAddr = 5760;
    public static int OpenRadioNameAddr = 6464;
    public static int ConFreCodeBegAddr = 8544;
    public static int ConRadioBegAdd = 8576;
    public static int ConRadioEnableBegAdd = Class1.ConRadioBegAdd + 96;
    public static int ConOneRadioChDatCt = 4;
    public static int ConFMVfoBegAdd = 8676;
    public static bool FatherWinClos = false;
    public static bool EditEn = false;
    public static bool GbOnlyOneLine = false;
    public static int[,] FreBand = new int[2, 3]
    {
      {
        134,
        200,
        400
      },
      {
        174,
        260,
        520
      }
    };
    public static int[,] FreBand1 = new int[2, 12]
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
    public static int[] Tone2Band = new int[2]{ 300, 3116 };
    public static int[,] FreBandData = new int[3, 4];
    public static bool FactoryEn = true;
    public static bool GbTestModEn = true;
    public static bool GbOwnUsedEn = true;
    public static string ConCodeBuf = "3433";
    public static string[] CtcTone = new string[52]
    {
      "OFF",
      "62.5",
      "67.0",
      "69.3",
      "71.9",
      "74.4",
      "77.0",
      "79.7",
      "82.5",
      "85.4",
      "88.5",
      "91.5",
      "94.8",
      "97.4",
      "100.0",
      "103.5",
      "107.2",
      "110.9",
      "114.8",
      "118.8",
      "123.0",
      "127.3",
      "131.8",
      "136.5",
      "141.3",
      "146.2",
      "151.4",
      "156.7",
      "159.8",
      "162.2",
      "165.5",
      "167.9",
      "171.3",
      "173.8",
      "177.3",
      "179.9",
      "183.5",
      "186.2",
      "189.9",
      "192.8",
      "196.6",
      "199.5",
      "203.5",
      "206.5",
      "210.7",
      "218.1",
      "225.7",
      "229.1",
      "233.6",
      "241.8",
      "250.3",
      "254.1"
    };
    public static string[] DcsTone = new string[104]
    {
      "023",
      "025",
      "026",
      "031",
      "032",
      "036",
      "043",
      "047",
      "051",
      "053",
      "054",
      "065",
      "071",
      "072",
      "073",
      "074",
      "114",
      "115",
      "116",
      "122",
      "125",
      "131",
      "132",
      "134",
      "143",
      "145",
      "152",
      "155",
      "156",
      "162",
      "165",
      "172",
      "174",
      "205",
      "212",
      "223",
      "225",
      "226",
      "243",
      "244",
      "245",
      "246",
      "251",
      "252",
      "255",
      "261",
      "263",
      "265",
      "266",
      "271",
      "274",
      "306",
      "311",
      "315",
      "325",
      "331",
      "332",
      "343",
      "346",
      "351",
      "356",
      "364",
      "365",
      "371",
      "411",
      "412",
      "413",
      "423",
      "431",
      "432",
      "445",
      "446",
      "452",
      "454",
      "455",
      "462",
      "464",
      "465",
      "466",
      "503",
      "506",
      "516",
      "523",
      "526",
      "532",
      "546",
      "565",
      "606",
      "612",
      "624",
      "627",
      "631",
      "632",
      "654",
      "662",
      "664",
      "703",
      "712",
      "723",
      "731",
      "732",
      "734",
      "743",
      "754"
    };
    public static string[] DcsToneAll = new string[512]
    {
      "000",
      "001",
      "002",
      "003",
      "004",
      "005",
      "006",
      "007",
      "010",
      "011",
      "012",
      "013",
      "014",
      "015",
      "016",
      "017",
      "020",
      "021",
      "022",
      "023",
      "024",
      "025",
      "026",
      "027",
      "030",
      "031",
      "032",
      "033",
      "034",
      "035",
      "036",
      "037",
      "040",
      "041",
      "042",
      "043",
      "044",
      "045",
      "046",
      "047",
      "050",
      "051",
      "052",
      "053",
      "054",
      "055",
      "056",
      "057",
      "060",
      "061",
      "062",
      "063",
      "064",
      "065",
      "066",
      "067",
      "070",
      "071",
      "072",
      "073",
      "074",
      "075",
      "076",
      "077",
      "100",
      "101",
      "102",
      "103",
      "104",
      "105",
      "106",
      "107",
      "110",
      "111",
      "112",
      "113",
      "114",
      "115",
      "116",
      "117",
      "120",
      "121",
      "122",
      "123",
      "124",
      "125",
      "126",
      "127",
      "130",
      "131",
      "132",
      "133",
      "134",
      "135",
      "136",
      "137",
      "140",
      "141",
      "142",
      "143",
      "144",
      "145",
      "146",
      "147",
      "150",
      "151",
      "152",
      "153",
      "154",
      "155",
      "156",
      "157",
      "160",
      "161",
      "162",
      "163",
      "164",
      "165",
      "166",
      "167",
      "170",
      "171",
      "172",
      "173",
      "174",
      "175",
      "176",
      "177",
      "200",
      "201",
      "202",
      "203",
      "204",
      "205",
      "206",
      "207",
      "210",
      "211",
      "212",
      "213",
      "214",
      "215",
      "216",
      "217",
      "220",
      "221",
      "222",
      "223",
      "224",
      "225",
      "226",
      "227",
      "230",
      "231",
      "232",
      "233",
      "234",
      "235",
      "236",
      "237",
      "240",
      "241",
      "242",
      "243",
      "244",
      "245",
      "246",
      "247",
      "250",
      "251",
      "252",
      "253",
      "254",
      "255",
      "256",
      "257",
      "260",
      "261",
      "262",
      "263",
      "264",
      "265",
      "266",
      "267",
      "270",
      "271",
      "272",
      "273",
      "274",
      "275",
      "276",
      "277",
      "300",
      "301",
      "302",
      "303",
      "304",
      "305",
      "306",
      "307",
      "310",
      "311",
      "312",
      "313",
      "314",
      "315",
      "316",
      "317",
      "320",
      "321",
      "322",
      "323",
      "324",
      "325",
      "326",
      "327",
      "330",
      "331",
      "332",
      "333",
      "334",
      "335",
      "336",
      "337",
      "340",
      "341",
      "342",
      "343",
      "344",
      "345",
      "346",
      "347",
      "350",
      "351",
      "352",
      "353",
      "354",
      "355",
      "356",
      "357",
      "360",
      "361",
      "362",
      "363",
      "364",
      "365",
      "366",
      "367",
      "370",
      "371",
      "372",
      "373",
      "374",
      "375",
      "376",
      "377",
      "400",
      "401",
      "402",
      "403",
      "404",
      "405",
      "406",
      "407",
      "410",
      "411",
      "412",
      "413",
      "414",
      "415",
      "416",
      "417",
      "420",
      "421",
      "422",
      "423",
      "424",
      "425",
      "426",
      "27",
      "430",
      "431",
      "432",
      "433",
      "434",
      "435",
      "436",
      "437",
      "440",
      "441",
      "442",
      "443",
      "444",
      "445",
      "446",
      "447",
      "450",
      "451",
      "452",
      "453",
      "454",
      "455",
      "456",
      "457",
      "460",
      "461",
      "462",
      "463",
      "464",
      "465",
      "466",
      "467",
      "470",
      "471",
      "472",
      "473",
      "474",
      "475",
      "476",
      "477",
      "500",
      "501",
      "502",
      "503",
      "504",
      "505",
      "506",
      "507",
      "510",
      "511",
      "512",
      "513",
      "514",
      "515",
      "516",
      "517",
      "520",
      "521",
      "522",
      "523",
      "524",
      "525",
      "526",
      "527",
      "530",
      "531",
      "532",
      "533",
      "534",
      "535",
      "536",
      "537",
      "540",
      "541",
      "542",
      "43",
      "544",
      "545",
      "546",
      "547",
      "550",
      "551",
      "552",
      "553",
      "554",
      "555",
      "556",
      "557",
      "560",
      "561",
      "562",
      "563",
      "564",
      "565",
      "566",
      "567",
      "70",
      "571",
      "572",
      "573",
      "74",
      "575",
      "576",
      "577",
      "600",
      "601",
      "602",
      "603",
      "604",
      "605",
      "606",
      "607",
      "610",
      "611",
      "612",
      "613",
      "614",
      "615",
      "616",
      "617",
      "620",
      "621",
      "622",
      "623",
      "624",
      "625",
      "626",
      "267",
      "630",
      "631",
      "632",
      "633",
      "634",
      "635",
      "636",
      "637",
      "640",
      "641",
      "642",
      "643",
      "644",
      "645",
      "646",
      "647",
      "650",
      "651",
      "652",
      "653",
      "654",
      "655",
      "656",
      "657",
      "660",
      "661",
      "662",
      "663",
      "664",
      "665",
      "666",
      "667",
      "670",
      "671",
      "672",
      "673",
      "674",
      "675",
      "676",
      "677",
      "700",
      "701",
      "702",
      "703",
      "704",
      "705",
      "706",
      "707",
      "710",
      "711",
      "712",
      "713",
      "714",
      "715",
      "716",
      "717",
      "720",
      "721",
      "722",
      "723",
      "724",
      "725",
      "726",
      "727",
      "730",
      "731",
      "732",
      "733",
      "734",
      "735",
      "736",
      "737",
      "740",
      "741",
      "742",
      "743",
      "744",
      "745",
      "746",
      "747",
      "750",
      "751",
      "752",
      "753",
      "754",
      "755",
      "756",
      "757",
      "760",
      "761",
      "762",
      "763",
      "764",
      "765",
      "766",
      "767",
      "770",
      "771",
      "772",
      "773",
      "774",
      "775",
      "776",
      "777"
    };
    public static string[] ConStep = new string[8]
    {
      "2.5K",
      "5K",
      "6.25K",
      "10K",
      "12.5K",
      "25K",
      "50K",
      "100K"
    };
    public static string[] ScrChSet = new string[10]
    {
      "OFF",
      "01",
      "02",
      "03",
      "04",
      "05",
      "06",
      "07",
      "08",
      "DEF"
    };
    public static string[] LedlightLev = new string[32]
    {
      "关闭",
      "1",
      "2",
      "3",
      "4",
      "5",
      "6",
      "7",
      "8",
      "9",
      "10",
      "11",
      "12",
      "13",
      "14",
      "15",
      "16",
      "17",
      "18",
      "19",
      "20",
      "21",
      "22",
      "23",
      "24",
      "25",
      "26",
      "27",
      "28",
      "29",
      "30",
      "31"
    };
    public static string[] KeyDefine = new string[8]
    {
      "KEY-A/B",
      "KEY-Low",
      "KEY-MONI",
      "KEY-SCAN",
      "KEY-TONE",
      "KEY-M/V",
      "KEY-MHZ",
      "KEY-MUTE"
    };
    public static string[,] lableArrName_Ch_En = new string[2, 21]
    {
      {
        "接收频率",
        "发射频率",
        "接收亚音",
        "信道名称",
        "发射亚音",
        "功率",
        "步进",
        "带宽",
        "可选信令",
        "静噪模式",
        "DTMF PTTID",
        "5TONE PTTID",
        "扰频",
        "遇忙禁发",
        "扫描",
        "压扩器",
        "发射禁止",
        "倒频",
        "脱 网",
        "差频频率",
        "差频方向"
      },
      {
        "  Rx Fre",
        "  Tx Fre",
        "  Decode",
        " Ch Name",
        "  Encode",
        "Power",
        "Step",
        "Wide",
        "Signal",
        "SQL Mod",
        "DTMF PTTID",
        "5TONE PTTID",
        "Scrambler",
        "Busy Lock",
        "Scan",
        "Compander",
        "  Tx Inh",
        "  Rev",
        "Talk Off",
        "Offset Freq",
        "Offset Dir"
      }
    };
    public static string[,] OffsetDir_EngCh = new string[2, 3]
    {
      {
        "关闭",
        "-",
        "+"
      },
      {
        "OFF",
        "-",
        "+"
      }
    };
    public static string[,] VOXDlyTm_EngCh = new string[2, 10]
    {
      {
        "0.5S",
        "1.0S",
        "1.5S",
        "2.0S",
        "2.5S",
        "3.0S",
        "3.5S",
        "4.0S",
        "4.5S",
        "5.0S"
      },
      {
        "0.5S",
        "1.0S",
        "1.5S",
        "2.0S",
        "2.5S",
        "3.0S",
        "3.5S",
        "4.0S",
        "4.5S",
        "5.0S"
      }
    };
    public static string[,] Spkind_EngCh = new string[2, 5]
    {
      {
        "静噪",
        "亚音频",
        "信令",
        "亚音频/信令",
        "亚音频&信令"
      },
      {
        "SQ",
        "CT",
        "Tone",
        "CT / Tone",
        "CTC & Tone"
      }
    };
    public static string[,] TxPower_EngCh = new string[2, 3]
    {
      {
        "高",
        "中",
        "低"
      },
      {
        "Hig",
        "Mid",
        "Low"
      }
    };
    public static string[,] WideNar_EngCh = new string[2, 3]
    {
      {
        "宽",
        "中",
        "窄"
      },
      {
        "Wide",
        "Mid",
        "Narrow"
      }
    };
    public static string[,] PttTxKind_EngCh = new string[2, 2]
    {
      {
        "最后信道",
        "主信道"
      },
      {
        "Last CH",
        "Main CH"
      }
    };
    public static string[,] PttKind_EngCh = new string[2, 4]
    {
      {
        "关闭",
        "开始",
        "结束",
        "两者"
      },
      {
        "OFF",
        "BEGIN",
        "END",
        "BOTH"
      }
    };
    public static string[,] ConAckKind_EngCh = new string[2, 3]
    {
      {
        " 无",
        "提示音",
        "提示音且回复"
      },
      {
        "OFF",
        "ReMind",
        "ReMind And Replay"
      }
    };
    public static string[,] ConSigfTxKind_EngCh = new string[2, 2]
    {
      {
        " 无",
        "ANI"
      },
      {
        "OFF",
        "ANI"
      }
    };
    public static string[,] BusyKind_EngCh = new string[2, 3]
    {
      {
        "关闭",
        "亚音",
        "载波"
      },
      {
        "OFF",
        "Sub",
        "Carrier"
      }
    };
    public static string[,] ScanSkip_EngCh = new string[2, 2]
    {
      {
        "允许",
        "跳过"
      },
      {
        "Allow",
        "Skip"
      }
    };
    public static string[,] OptSig_EngCh = new string[2, 4]
    {
      {
        "OFF",
        "DTMF",
        "2TONE",
        "5TONE"
      },
      {
        "OFF",
        "DTMF",
        "2TONE",
        "5TONE"
      }
    };
    public static string[,] ScrChSet_EngCh = new string[2, 9]
    {
      {
        "关",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8"
      },
      {
        "OFF",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8"
      }
    };
    public static string[,] ShowName_EngCh = new string[2, 3]
    {
      {
        "频率",
        "信道",
        "名称"
      },
      {
        "Frequency",
        "Chanel",
        "Name"
      }
    };
    public static string[,] SubMainDis_EngCh = new string[2, 3]
    {
      {
        "关闭",
        "频率",
        "电压"
      },
      {
        "OFF",
        "Frequency",
        "Voltage"
      }
    };
    public static string[,] SqlLevel_EngCh = new string[2, 10]
    {
      {
        "关闭",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9"
      },
      {
        "OFF",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9"
      }
    };
    public static string[,] LIGlLevel_EngCh = new string[2, 7]
    {
      {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7"
      },
      {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7"
      }
    };
    public static string[,] CallKind_EngCh = new string[2, 4]
    {
      {
        "1750",
        "2100",
        "1000",
        "1450"
      },
      {
        "1750",
        "2100",
        "1000",
        "1450"
      }
    };
    public static string[,] AutopowOffKind_EngCh = new string[2, 4]
    {
      {
        "关闭",
        "30分",
        "1小时",
        "2小时"
      },
      {
        "OFF",
        "30 Minute",
        "1 Hour",
        "2 Hour"
      }
    };
    public static string[,] TotKind_EngCh = new string[2, 10]
    {
      {
        "关闭",
        "30  秒",
        "60  秒",
        "90  秒",
        "120 秒",
        "150 秒",
        "180 秒",
        "210 秒",
        "240 秒",
        "270 秒"
      },
      {
        "OFF",
        "30 Second",
        "60 Second",
        "90 Second",
        "120 Second",
        "150 Second",
        "180 Second",
        "210 Second",
        "240 Second",
        "270 Second"
      }
    };
    public static string[,] BoolKind_EngCh = new string[2, 2]
    {
      {
        "关闭",
        "打开"
      },
      {
        "OFF",
        "On"
      }
    };
    public static string[,] DoubleWatch_EngCh = new string[2, 2]
    {
      {
        "关闭",
        "打开"
      },
      {
        "OFF",
        "On"
      }
    };
    public static string[,] LedKind_EngCh = new string[2, 3]
    {
      {
        "关闭",
        "常开",
        "自动"
      },
      {
        "OFF",
        "ON",
        "Auto"
      }
    };
    public static string[,] ScanKind_EngCh = new string[2, 3]
    {
      {
        "时间",
        "载波",
        "停止"
      },
      {
        "To",
        "Co",
        "Se"
      }
    };
    public static string[,] ScanResumTm_EngCh = new string[2, 4]
    {
      {
        "2秒",
        "5秒",
        "10秒",
        "15秒"
      },
      {
        "2S",
        "5S",
        "10S",
        "15S"
      }
    };
    public static string[,] EndTail_EngCh = new string[2, 2]
    {
      {
        "关闭",
        "频率"
      },
      {
        "OFF",
        "Frequency"
      }
    };
    public static string[,] LanguageSel_EngCh = new string[2, 2]
    {
      {
        "中文",
        "英文"
      },
      {
        "Chinese",
        "English"
      }
    };
    public static string[,] DailDefne_EngCh = new string[2, 2]
    {
      {
        "频率",
        "音量"
      },
      {
        "Frequency",
        "Volume"
      }
    };
    public static string[,] RadioKind_EngCh = new string[2, 3]
    {
      {
        "关闭",
        "电压",
        "自定义字符"
      },
      {
        "OFF",
        "voltage",
        "Char String"
      }
    };
    public static string[,] LogKind_EngCh = new string[2, 2]
    {
      {
        "公共图标",
        "公司图标"
      },
      {
        "Com Logo",
        "TYT Logo"
      }
    };
    public static string[,] KeylockKind_EngCh = new string[2, 2]
    {
      {
        "手动",
        "自动"
      },
      {
        "OFF",
        "Auto"
      }
    };
    public static string[,] KeyMode_EngCh = new string[2, 4]
    {
      {
        "全部",
        "发射",
        "按键",
        "按&侧键"
      },
      {
        "ALL",
        "PTT",
        "KEY",
        "KEY & Side Key"
      }
    };
    public static string[,] SaveMode_EngCh = new string[2, 4]
    {
      {
        "关闭",
        "1:1",
        "1:2",
        "1:4"
      },
      {
        "OFF",
        "1:1",
        "1:2",
        "1:4"
      }
    };

    public void DataGridViewColumnAddPro1(
      DataGridViewTextBoxColumn acCode,
      string name,
      DataGridViewColumnCollection ColN)
    {
      acCode.HeaderText = name;
      acCode.Width = 60;
      acCode.Name = "item";
      acCode.DataPropertyName = "item";
      acCode.ReadOnly = true;
      acCode.SortMode = DataGridViewColumnSortMode.NotSortable;
      ColN.Add((DataGridViewColumn) acCode);
    }

    public static int StrAddress(string StrTemp, string StrTemp1) => StrTemp.IndexOf(StrTemp1);

    public static string AsciiToStr(int asciiCode) => asciiCode >= 0 && asciiCode <= (int) byte.MaxValue ? new ASCIIEncoding().GetString(new byte[1]
    {
      (byte) asciiCode
    }) : throw new Exception("ASCII Code is not valid.");

    public static string AllAsciiToStr(string StrTemp)
    {
      string str = "";
      for (int index = 0; index < StrTemp.Length / 2; ++index)
      {
        int int16 = (int) Convert.ToInt16(StrTemp.Substring(2 * index, 2), 16);
        str += Class1.AsciiToStr(int16);
      }
      return str;
    }

    public static char ChgChar_a_z_ToA_Z(char CharTemp)
    {
      if (CharTemp < 'a' && CharTemp > 'z')
        return CharTemp;
      switch (CharTemp)
      {
        case 'a':
          CharTemp = 'A';
          break;
        case 'b':
          CharTemp = 'B';
          break;
        case 'c':
          CharTemp = 'C';
          break;
        case 'd':
          CharTemp = 'D';
          break;
        case 'e':
          CharTemp = 'E';
          break;
        case 'f':
          CharTemp = 'F';
          break;
        case 'g':
          CharTemp = 'G';
          break;
        case 'h':
          CharTemp = 'H';
          break;
        case 'i':
          CharTemp = 'I';
          break;
        case 'j':
          CharTemp = 'J';
          break;
        case 'k':
          CharTemp = 'K';
          break;
        case 'l':
          CharTemp = 'L';
          break;
        case 'm':
          CharTemp = 'M';
          break;
        case 'n':
          CharTemp = 'N';
          break;
        case 'o':
          CharTemp = 'O';
          break;
        case 'p':
          CharTemp = 'P';
          break;
        case 'q':
          CharTemp = 'Q';
          break;
        case 'r':
          CharTemp = 'R';
          break;
        case 's':
          CharTemp = 'S';
          break;
        case 't':
          CharTemp = 'T';
          break;
        case 'u':
          CharTemp = 'U';
          break;
        case 'v':
          CharTemp = 'V';
          break;
        case 'w':
          CharTemp = 'W';
          break;
        case 'x':
          CharTemp = 'X';
          break;
        case 'y':
          CharTemp = 'Y';
          break;
        case 'z':
          CharTemp = 'Z';
          break;
      }
      return CharTemp;
    }

    public static string Chga_z_ToA_Z(string strTest)
    {
      strTest = strTest.ToUpper();
      return strTest;
    }

    public static string ChgA_Z_Toa_z(string strTest)
    {
      strTest = strTest.ToLower();
      return strTest;
    }

    public static string DataToStrPro(long Data, int Length)
    {
      string strTest = Convert.ToString(Data, 16);
      int length = strTest.Length;
      for (int index = 1; index <= Length - length; ++index)
        strTest = "0" + strTest;
      return Class1.Chga_z_ToA_Z(strTest);
    }

    public static string StrToAscii(string StrTemp)
    {
      StrTemp = Class1.Chga_z_ToA_Z(StrTemp);
      byte[] bytes = Encoding.ASCII.GetBytes(StrTemp);
      StrTemp = "";
      for (int index = 0; index < bytes.Length; ++index)
        StrTemp += Convert.ToString((long) bytes[index], 16);
      return StrTemp;
    }

    public static string StrChe_nPro(string StrTemp)
    {
      if (StrTemp.Substring(1, 1) != "n")
        StrTemp = "\n" + StrTemp;
      return StrTemp;
    }

    public static string StrAutoAdd0Pro(string StrTemp, byte Length)
    {
      if (StrTemp.Length < (int) Length)
      {
        int num = (int) Length - StrTemp.Length;
        for (int index = 0; index < num; ++index)
          StrTemp = "0" + StrTemp;
      }
      return StrTemp;
    }

    public static string StrAutoAddEnd0Pro(string StrTemp, byte Length)
    {
      if (StrTemp.Length < (int) Length)
      {
        int num = (int) Length - StrTemp.Length;
        for (int index = 0; index < num; ++index)
          StrTemp += "0";
      }
      return StrTemp;
    }

    public static string StrAutoAdd0X20Pro(string StrTemp, int Length)
    {
      if (StrTemp.Length < Length)
      {
        int num = Length - StrTemp.Length;
        for (int index = 0; index < num; index = index + 1 + 1)
          StrTemp += "20";
      }
      else if (StrTemp.Length > Length)
        StrTemp = StrTemp.Substring(0, Length);
      return StrTemp;
    }

    public static string StrHexAutoAdd0Pro(long Data, byte Length) => Class1.StrAutoAdd0Pro(Convert.ToString(Data, 16), Length);

    public static string DataToHexStr(long Data)
    {
      string hexStr = Convert.ToString(Data, 16);
      if (hexStr.Length <= 1)
        hexStr = "0" + hexStr;
      return hexStr;
    }

    public static string DataTo10Str(long Data)
    {
      string str = Convert.ToString(Data, 10);
      if (str.Length <= 1)
        str = "0" + str;
      return str;
    }

    public static string DataToAscii(long Data, int Length)
    {
      string StrTemp = Convert.ToString(Data, 16);
      int length = StrTemp.Length;
      for (int index = 1; index <= Length - length; ++index)
        StrTemp = "0" + StrTemp;
      return Class1.StrToAscii(StrTemp);
    }

    public static byte[] ConvertFromToBcd(string strTemp)
    {
      try
      {
        if (Convert.ToBoolean(strTemp.Length & 1))
          strTemp = "0" + strTemp;
        byte[] bcd = new byte[strTemp.Length / 2];
        for (int index = 0; index < strTemp.Length / 2; ++index)
          bcd[index] = (byte) ((int) strTemp[index * 2] - 48 << 4 | (int) strTemp[index * 2 + 1] - 48);
        return bcd;
      }
      catch
      {
        return (byte[]) null;
      }
    }

    public static void GetFreDefFilePro(string FileNameTemp)
    {
      if (File.Exists(FileNameTemp))
        return;
      using (FileStream fileStream = File.Create(FileNameTemp))
      {
        byte[] bytes = new UTF8Encoding(true).GetBytes("COM1\r\n#Comment=TYT INC.(C)  2013  #MapRev=1\r\n38400\r\n00002070CE910270CE9102FF0FFF0F000005202020202020B067DD00B067DD00FF0FFF\r\n0020200F00000620202020202040A5AE0240A5AE02FF0FFF0F00000520202020202000\r\n004020C19702E0C19702E8031300000006202020202020E0C19702E0C19702E8031300\r\n006020000006202020202020E0C19702E0C19702E8031300000006202020202020E0C1\r\n0080209702E0C19702E8031300000006202020202020186CDC02186CDC027503130000\r\n00A0200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n00C02002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n00E02006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n010020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n012020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n0140206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n0160202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n018020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n01A02020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n01C0200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n01E020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n02002075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n0220202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n024020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n02602020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n0280201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n02A020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n02C02000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n02E0206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n030020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n032020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n0340200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n03602002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n03802006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n03A020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n03C020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n03E0206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n0400202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n042020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n04402020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n0460200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n048020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n04A02075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n04C0202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n04E020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n05002020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n0520201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n054020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n05602000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n0580206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n05A020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n05C020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n05E0200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n06002002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n06202006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n064020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n066020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n0680206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n06A0202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n06C020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n06E02020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n0700200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n072020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n07402075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n0760202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n078020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n07A02020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n07C0201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n07E020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n08002000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n0820206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n084020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n086020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n0880200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n08A02002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n08C02006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n08E020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n090020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n0920206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n0940202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n096020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n09802020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n09A0200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n09C020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n09E02075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n0A00202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n0A2020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n0A402020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n0A60201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n0A8020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n0AA02000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n0AC0206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n0AE020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n0B0020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n0B20200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n0B402002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n0B602006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n0B8020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n0BA020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n0BC0206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n0BE0202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n0C0020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n0C202020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n0C40200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n0C6020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n0C802075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n0CA0202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n0CC020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n0CE02020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n0D00201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n0D2020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n0D402000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n0D60206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n0D8020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n0DA020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n0DC0200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n0DE02002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n0E002006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n0E2020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n0E4020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n0E60206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n0E80202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n0EA020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n0EC02020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n0EE0200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n0F0020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n0F202075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n0F40202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n0F6020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n0F802020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n0FA0201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n0FC020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n0FE02000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n1000206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n102020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n104020DC02186CDC0275031300000006202020202020E0C19702E0C19702E803130000\r\n1060200006202020202020E0C19702E0C19702E8031300000006202020202020186CDC\r\n10802002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n10A02006202020202020186CDC02186CDC0275031300000006202020202020B067DD00\r\n10C020B067DD00FF0FFF0F00000520202020202020D7750120D77501FF0FFF0F000005\r\n10E02020202020202070CE910270CE9102FF0FFF0F000005202020202020B067DD00B0\r\n11002067DD00FF0FFF0F00000520202020202020D7750120D77501FF0FFF0F00000520\r\n112020202020202070CE910270CE9102FF0FFF0F000005202020202020040000002020\r\n11402008000000000021420000050000E000E0F141F10104000000202020202020E0C1\r\n11602054482D383630302020202020258900040401500061540C420000303030303030\r\n11802003000000000000000000000000000000000000000000000000007249F308F141\r\n11A0200300000000000000000000000000000000000000000000000000F10104000000\r\n11C020001E00189ABCDEF01234567827123456789ABCDEF01234567809987654321ABC\r\n11E020DEF01234567809123456789ABCDEF01234567800123456789ABCDEF012345678\r\n12002000123456789ABCDEF01234567800123456789ABCDEF01234567800123456789A\r\n122020BCDEF01234567800123456789ABCDEF01234567800123456789ABCDEF0123456\r\n1240207800123456789ABCDEF01234567800123456789ABCDEF0123456780012345678\r\n1260209ABCDEF01234567800123456789ABCDEF01234567800123456789ABCDEF01234\r\n128020567800123456789ABCDEF0123456780020202020202020202020202020202020\r\n12A020C30902F00AF005070000145678032020123456789ABCDEF01234567800202020\r\n12C020123456789ABCDEF01234567800202020323457989012345F423465789012345F\r\n12E02020202020E0C19702E0C197027249F308F141F10104000000202020202020E0C1\r\n1300201A0456CC32542D30312005202020202020202020200020202020202020202020\r\n1320200020202020202020202020002020202020202020202000202020202020202020\r\n1340202000202020202020202020200020202020202020202020002020202020202020\r\n1360202020002020202020202020202000202020202020202020200020202020202020\r\n1380202020200020202020202020202020002020202020202020202000202020202020\r\n13A0202020202000202020202020202020200020202020202020202020202020202020\r\n13C0201A0456CC18794FD6500000050A0A010020202020202020202020202020202020\r\n13E0201234567805202020202020202020202020202020202035542D30312005202020\r\n1400201234567808202020202020202020202020202020200035542D30322005202020\r\n1420201234567805446174612020202020202020202020204435542D30332005202020\r\n1440201234567800202020202020202020202020202020200020202020202000202020\r\n1460201234567800202020202020202020202020202020200020202020202000202020\r\n1480201234567800202020202020202020202020202020200020202020202000202020\r\n14A0201234567800202020202020202020202020202020200020202020202000202020\r\n14C0201234567800202020202020202020202020202020200020202020202000202020\r\n14E0201234567800202020202020202020202020202020200020202020202000202020\r\n1500201234567800202020202020202020202020202020200020202020202000202020\r\n1520201234567800202020202020202020202020202020200020202020202000202020\r\n1540201234567800202020202020202020202020202020200020202020202000202020\r\n1560201234567800202020202020202020202020202020200020202020202000202020\r\n1580201234567800202020202020202020202020202020200020202020202000202020\r\n15A0201234567800202020202020202020202020202020200020202020202000202020\r\n15C0201234567800202020202020202020202020202020200020202020202000202020\r\n15E0201234567805000A020060D0001234567808876543210807000146202020202020\r\n16002008123456789ABC0835542D303120052000123456789ABC002020202020200020\r\n16202000123456789ABC00202020202020002000123456789ABC002020202020200020\r\n16402000123456789ABC00202020202020002000123456789ABC002020202020200020\r\n16602000123456789ABC00202020202020002000123456789ABC002020202020200020\r\n1680200085CF00C08009010085CF00C0800901FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF\r\n16A020005A6202006CDC02005A6202006CDC02283C506482A0BED2E63C3C3C28282867\r\n16C020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n16E02020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n1700200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n172020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n17402075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n1760202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n178020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n17A02020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n17C0201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n17E020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n18002000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n1820206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n184020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n186020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n1880200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n18A02002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n18C02006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n18E020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n190020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n1920206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n19402054482D383630302020202020202020205648465F554846202020202020202020\r\n1960202020202020202020202020202020202020202020202020202020202020202020\r\n19802020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n19A0200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n19C020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n19E02075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n1A00202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n1A2020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n1A402020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n1A60201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n1A8020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n1AA02000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n1AC0206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n1AE020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n1B0020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n1B20200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n1B402002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n1B602006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n1B8020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n1BA020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n1BC0206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n1BE0202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n1C0020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n1C202020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n1C40200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n1C6020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n1C802075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n1CA0202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n1CC020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n1CE02020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n1D00201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n1D2020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n1D402000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n1D60206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n1D8020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n1DA020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n1DC0200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n1DE02002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n1E002006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n1E2020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n1E4020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n1E60206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n1E80202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n1EA020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n1EC02020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n1EE0200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n1F0020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n1F202075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n1F40202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n1F6020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n1F802020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n1FA0201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n1FC020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n1FE02000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n200020C48ECF00C48ECF00FF0FFF0F000006202020202020A4CB9702A4CB9702FF0FFF\r\n2020200F000006202020202020A4CB9702A4CB9702FF0FFF0F00000620202020202000\r\n204020C19702E0C19702E8031300000006202020202020E0C19702E0C19702E8031300\r\n206020000006202020202020E0C19702E0C19702E8031300000006202020202020E0C1\r\n2080209702E0C19702E8031300000006202020202020186CDC02186CDC027503130000\r\n20A0200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n20C02002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n20E02006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n210020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n212020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n2140206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n216020FFFFFFFF20186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n2180201234567808000000123456780000000012345678000000001234567800000000\r\n21A0201234567800000000123456780000000012345678000000001234567800000000\r\n21C0201234567800000000123456780000000012345678000000001234567800000000\r\n21E0201234567800000000123456780000000012345678000000001234567800000000\r\n2200201234567800000000123456780000000012345678000000001234567800000000\r\n2220201234567800000000123456780000000012345678000000001234567800000000\r\n2240201234567800000000123456780000000012345678000000001234567800000000\r\n2260201234567800000000123456780000000012345678000000001234567800000000\r\n22802001000000123456780800000006202020202020186CDC02186CDC027503130000\r\n22A0200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n22C02002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n22E02006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n230020C48ECF00C48ECF00FF0FFF0F000006202020202020A4CB9702A4CB9702FF0FFF\r\n2320200F000006202020202020A4CB9702A4CB9702FF0FFF0F00000620202020202000\r\n234020C19702E0C19702E8031300000006202020202020E0C19702E0C19702E8031300\r\n236020000006202020202020E0C19702E0C19702E8031300000006202020202020E0C1\r\n2380209702E0C19702E8031300000006202020202020186CDC02186CDC027503130000\r\n23A0200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n23C02002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n23E02006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\r\r\r\r\r\r\r\r\r\r\r\r\r\r\r\r\r\r\r\r\r");
        fileStream.Write(bytes, 0, bytes.Length);
      }
    }

    public static void GetTestDefFilePro(string FileNameTemp)
    {
      if (File.Exists(FileNameTemp))
        return;
      using (FileStream fileStream = File.Create(FileNameTemp))
      {
        byte[] bytes = new UTF8Encoding(true).GetBytes("COM1\r\n#Comment=TYT INC.(C)  2013  #MapRev=1\r\n38400\r\n000020283c506482a0bed2e63c3c3c282828679b3737322d2d2d2828282828282d2d2d\r\n0020202d2d2d2d32324b46464141413c3c3c3c373c3c3c3c3c3c3c4646466464646464\r\n0040206464646464646464646464646464646413131332323246464646464646464646\r\n00602046464b4b4baaaaaa787878780000000000000000000000000000000000000000\r\n008020030f01ff00000000000000000000000000000000000000000000000000000000\r\n00A020ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff\r\n00C020ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff\r\n00E020ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff\r\n010020ffffffffffffffffffffffffffffffffffffffffff0000000000000000000000\r\n0120203c506e8296aabed2e6faf5ffff3c3c3c3c3c3c3c282828282828284a90373737\r\n0140203737373737373737373737373737323232323232323232323232323232323232\r\n0160203232373737373737373737372323232323232323232323232323464646464646\r\n0180204646464646464646464646464646464646464646464646464646464646464646\r\n01A02046464646464646464646464646464646464646464646465a5a5f5f6464646464\r\n01C0206464646464646464646464646464646464646464646464646464676a6c6e6e6e\r\n01E0206e6e6e6e6e6e6464646464646464646464646464131313131313133232323232\r\n0200203232464646464646464646464646464646464646464646464646464646465050\r\n0220205050505050aaaaaaaaaaaaaa6e6e6e6e6e6e6e78000000000000000000000000\r\n024020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n02602020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n0280201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n02A020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n02C02000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n02E0206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n030020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n032020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n0340200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n03602002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n03802006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n03A020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n03C020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n03E0206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n0400202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n042020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n04402020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n0460200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n048020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n04A02075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n04C0202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n04E020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n05002020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n0520201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n054020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n05602000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n0580206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n05A020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n05C020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n05E0200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n06002002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n06202006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n064020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n066020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n0680206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n06A0202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n06C020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n06E02020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n0700200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n072020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n07402075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n0760202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n078020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n07A02020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n07C0201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n07E020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n08002000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n0820206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n084020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n086020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n0880200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n08A02002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n08C02006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n08E020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n090020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n0920206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n0940202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n096020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n09802020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n09A0200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n09C020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n09E02075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n0A00202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n0A2020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n0A402020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n0A60201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n0A8020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n0AA02000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n0AC0206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n0AE020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n0B0020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n0B20200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n0B402002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n0B602006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n0B8020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n0BA020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n0BC0206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n0BE0202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n0C0020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n0C202020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n0C40200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n0C6020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n0C802075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n0CA0202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n0CC020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n0CE02020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n0D00201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n0D2020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n0D402000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n0D60206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n0D8020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n0DA020DC02186CDC0275031300000006202020202020186CDC02186CDC027503130000\r\n0DC0200006202020202020186CDC02186CDC0275031300000006202020202020186CDC\r\n0DE02002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n0E002006202020202020186CDC02186CDC0275031300000006202020202020186CDC02\r\n0E2020186CDC0275031300000006202020202020186CDC02186CDC0275031300000006\r\n0E4020202020202020186CDC02186CDC0275031300000006202020202020186CDC0218\r\n0E60206CDC0275031300000006202020202020186CDC02186CDC027503130000000620\r\n0E80202020202020186CDC02186CDC0275031300000006202020202020186CDC02186C\r\n0EA020DC0275031300000006202020202020186CDC02186CDC02750313000000062020\r\n0EC02020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC\r\n0EE0200275031300000006202020202020186CDC02186CDC0275031300000006202020\r\n0F0020202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02\r\n0F202075031300000006202020202020186CDC02186CDC027503130000000620202020\r\n0F40202020186CDC02186CDC0275031300000006202020202020186CDC02186CDC0275\r\n0F6020031300000006202020202020186CDC02186CDC02750313000000062020202020\r\n0F802020186CDC02186CDC0275031300000006202020202020186CDC02186CDC027503\r\n0FA0201300000006202020202020186CDC02186CDC0275031300000006202020202020\r\n0FC020186CDC02186CDC0275031300000006202020202020186CDC02186CDC02750313\r\n0FE02000000006202020202020186CDC02186CDC027503130000000620202020202018\r\n1000206CDC02186CDC0275031300000006202020202020186CDC02186CDC0275031300\r\n102020000006202020202020186CDC02186CDC0275031300000006202020202020186C\r\n104020DC02186CDC0275031300000006202020202020E0C19702E0C19702E803130000\r\n1060200006202020202020E0C19702E0C19702E8031300000006202020202020186CDC\r\n10802002186CDC0275031300000006202020202020186CDC02186CDC02750313000000\r\n10A02006202020202020186CDC02186CDC0275031300000006202020202020E0C19702\r\n10C020E0C19702E8031300000006202020202020E0C19702E0C19702E8031300000006\r\n10E020202020202020186CDC02186CDC0275031300000006202020202020E082EC00E0\r\n11002082EC007503130000000620202020202020D7750120D775017503130000000620\r\n11202020202020203008980230089802E8031300400006202020202020040000002020\r\n1140203800000000000000000005000000001AF141F10104000000202020202020E0C1\r\n1160205459542D5556202039303030259F022A01044000501400000000303030303030\r\n11802007000000000000000000000000000000000000000000000000007249F308F141\r\n11A0207F00000000000000000000000000000000000000000000008031F10104000000\r\n11C02012345678901234567890123418123456789ABCDEF01234567800123456789ABC\r\n11E020DEF01234567800123456789ABCDEF01234567800123456789ABCDEF012345678\r\n12002000123456789ABCDEF01234567800123456789ABCDEF01234567800123456789A\r\n122020BCDEF01234567800123456789ABCDEF01234567800123456789ABCDEF0123456\r\n1240207800123456789ABCDEF01234567800123456789ABCDEF0123456780012345678\r\n1260209ABCDEF01234567800123456789ABCDEF01234567800123456789ABCDEF01234\r\n128020567800123456789ABCDEF0123456780020202020202020202020202020202020\r\n12A020B30D04F00AF00501001234652020202012345678901234567890123418202020\r\n12C02022345678901234567890123418202020323456789012345F423456789012345F\r\n12E02020202020E0C19702E0C197027249F308F141F10104000000202020202020E0C1\r\n1300201A0456CC32542D30312005202020202020202020200020202020202020202020\r\n1320200020202020202020202020002020202020202020202000202020202020202020\r\n1340202000202020202020202020200020202020202020202020002020202020202020\r\n1360202020002020202020202020202000202020202020202020200020202020202020\r\n1380202020200020202020202020202020002020202020202020202000202020202020\r\n13A0202020202000202020202020202020200020202020202020202020202020202020\r\n13C0201A0456CC18794FD6400000000A0A010020202020202020202020202020202020\r\n13E0201234567808313233343536373839303132333435361035542D30312005202020\r\n1400201234567800202020202020202020202020202020200020202020202000202020\r\n1420201234567800202020202020202020202020202020200020202020202000202020\r\n1440201234567800202020202020202020202020202020200020202020202000202020\r\n1460201234567800202020202020202020202020202020200020202020202000202020\r\n1480201234567800202020202020202020202020202020200020202020202000202020\r\n14A0201234567800202020202020202020202020202020200020202020202000202020\r\n14C0201234567800202020202020202020202020202020200020202020202000202020\r\n14E0201234567800202020202020202020202020202020200020202020202000202020\r\n1500201234567800202020202020202020202020202020200020202020202000202020\r\n1520201234567800202020202020202020202020202020200020202020202000202020\r\n1540201234567800202020202020202020202020202020200020202020202000202020\r\n1560201234567800202020202020202020202020202020200020202020202000202020\r\n1580201234567800202020202020202020202020202020200020202020202000202020\r\n15A0201234567800202020202020202020202020202020200020202020202000202020\r\n15C0201234567800202020202020202020202020202020200020202020202000202020\r\n15E02012345678080010020045C000123456780887654321080100FF46202020202020\r\n1600200812345678901C0B35542D3031200520081234567890120C35542D3032200520\r\n1620200812345678901C0B35542D30332005200812345678901C0B35542D3034200520\r\n1640200812345678901C0B35542D30352005200812345678901C0B35542D3036200520\r\n1660200812345678901C0B35542D30372005200812345678901C0B35542D3038200520\r\n168020FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF\r\n16A020FFFF480000254800002539C839C803FF03FF00000080010101010101FFFFFFFF\r\r\r\r\r\r\r\r");
        fileStream.Write(bytes, 0, bytes.Length);
      }
    }

    public static void GetAllTestDefFilePro(string FileNameTemp)
    {
      if (File.Exists(FileNameTemp))
        return;
      using (FileStream fileStream = File.Create(FileNameTemp))
      {
        byte[] bytes = new UTF8Encoding(true).GetBytes("COM1\r\n#Comment=TYT INC.(C)  2013  #MapRev=1\r\n38400\r\n1900204040404040404040404040404040404040404040404040404040404040E0FFFF\r\n");
        fileStream.Write(bytes, 0, bytes.Length);
      }
    }

    public static void SaveFileDataPro(string FileName, string[] StrData)
    {
      Class1.GetFreDefFilePro(FileName);
      File.Open(FileName, FileMode.Truncate).Dispose();
      using (StreamWriter streamWriter = new StreamWriter((Stream) File.OpenWrite(FileName)))
      {
        for (int index = 0; index < StrData.Length; ++index)
          streamWriter.Write(StrData[index] + "\r");
        streamWriter.Dispose();
      }
    }

    public static void AutoChSet(double RxFreData, string GiFileName)
    {
      for (int i = 0; i <= 199; ++i)
      {
        string dataPro = Class2.ChgRxFreToDataPro(RxFreData.ToString());
        Class1.SavOneChgDatPro(dataPro + dataPro + "FF0FFF0F00000120202020202020202020202020202020", i, GiFileName);
        Class1.SavOneChgSkipSttPro(0, i, GiFileName);
        RxFreData += 0.05;
      }
    }

    public static void SavOneChgDatPro(string CurrStr, int i, string FileName)
    {
      string[] StrData = Class1.ReadFileDataPro(FileName).Split('\r');
      if (CurrStr != "")
      {
        string str1 = CurrStr.Substring(CurrStr.Length - 20, 20);
        CurrStr = CurrStr.Substring(0, Class1.ConOneChDatCt * 2);
        int num1 = Class1.ConOneChDatCt * i / Class1.ConOneRowDatCt + Class1.ChInfAddr / Class1.ConOneRowDatCt;
        string str2 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num1]);
        string str3 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num1 + 1]);
        int num2 = Class1.ConOneChDatCt * i % Class1.ConOneRowDatCt;
        if (num2 + Class1.ConOneChDatCt > Class1.ConOneRowDatCt)
        {
          string str4 = str2.Substring(0, 2 * num2 + Class1.ConUseChDatSta + 1);
          string str5 = CurrStr.Substring(0, (Class1.ConOneRowDatCt - num2) * 2);
          string str6 = str3.Substring(0, Class1.ConUseChDatSta + 1);
          string str7 = CurrStr.Substring((Class1.ConOneRowDatCt - num2) * 2, CurrStr.Length - 2 * (Class1.ConOneRowDatCt - num2));
          string str8 = str3.Substring(Class1.ConUseChDatSta + 1 + CurrStr.Length - 2 * (Class1.ConOneRowDatCt - num2), str3.Length - (Class1.ConUseChDatSta + 1 + CurrStr.Length - 2 * (Class1.ConOneRowDatCt - num2)));
          StrData[Class1.FielBegRow + num1] = str4 + str5;
          StrData[Class1.FielBegRow + num1 + 1] = str6 + str7 + str8;
        }
        else
        {
          string str9 = str2.Substring(0, 2 * num2 + Class1.ConUseChDatSta + 1);
          string str10 = CurrStr.Substring(0, CurrStr.Length);
          string str11 = str2.Substring(CurrStr.Length + str9.Length, str2.Length - (2 * num2 + Class1.ConUseChDatSta + 1 + CurrStr.Length));
          StrData[Class1.FielBegRow + num1] = str9 + str10 + str11;
        }
        if (i < 204)
        {
          CurrStr = str1;
          int num3 = Class1.ConOneChNameDatCt * i / Class1.ConOneRowDatCt + Class1.ChInfNameAddr / Class1.ConOneRowDatCt;
          string str12 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num3]);
          string str13 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + num3 + 1]);
          int num4 = Class1.ConOneChNameDatCt * i % Class1.ConOneRowDatCt;
          if (num4 + Class1.ConOneChNameDatCt > Class1.ConOneRowDatCt)
          {
            string str14 = str12.Substring(0, 2 * num4 + Class1.ConUseChDatSta + 1);
            string str15 = CurrStr.Substring(0, (Class1.ConOneRowDatCt - num4) * 2);
            string str16 = str13.Substring(0, Class1.ConUseChDatSta + 1);
            string str17 = CurrStr.Substring((Class1.ConOneRowDatCt - num4) * 2, CurrStr.Length - 2 * (Class1.ConOneRowDatCt - num4));
            string str18 = str13.Substring(Class1.ConUseChDatSta + 1 + CurrStr.Length - 2 * (Class1.ConOneRowDatCt - num4), str13.Length - (Class1.ConUseChDatSta + 1 + CurrStr.Length - 2 * (Class1.ConOneRowDatCt - num4)));
            StrData[Class1.FielBegRow + num3] = str14 + str15;
            StrData[Class1.FielBegRow + num3 + 1] = str16 + str17 + str18;
          }
          else
          {
            string str19 = str12.Substring(0, 2 * num4 + Class1.ConUseChDatSta + 1);
            string str20 = CurrStr.Substring(0, CurrStr.Length);
            string str21 = str12.Substring(CurrStr.Length + str19.Length, str12.Length - (2 * num4 + Class1.ConUseChDatSta + 1 + CurrStr.Length));
            StrData[Class1.FielBegRow + num3] = str19 + str20 + str21;
          }
        }
      }
      if (i < 204)
      {
        string strtemp1 = StrData[Class1.FielBegRow + Class1.ChinfBegAddr / Class1.ConOneRowDatCt];
        StrData[Class1.FielBegRow + Class1.ChinfBegAddr / Class1.ConOneRowDatCt] = !(CurrStr == "") ? Class2.SetSttEn_DisablePro(strtemp1, i, true) : Class2.SetSttEn_DisablePro(strtemp1, i, false);
        string strtemp2 = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + Class1.ChSkipBegAddr / Class1.ConOneRowDatCt]);
        StrData[Class1.FielBegRow + Class1.ChSkipBegAddr / Class1.ConOneRowDatCt] = !(CurrStr == "") ? Class2.SetSttEn_DisablePro(strtemp2, i, false) : Class2.SetSttEn_DisablePro(strtemp2, i, true);
      }
      Class1.SaveFileDataPro(FileName, StrData);
    }

    public static void SavOneChgSkipSttPro(int CurScanStt, int i, string FileName)
    {
      string[] StrData = Class1.ReadFileDataPro(FileName).Split('\r');
      string strtemp = Class2.AutoAdd_n_Pro(StrData[Class1.FielBegRow + Class1.ChSkipBegAddr / Class1.ConOneRowDatCt]);
      StrData[Class1.FielBegRow + Class1.ChSkipBegAddr / Class1.ConOneRowDatCt] = CurScanStt != 1 ? Class2.SetSttEn_DisablePro(strtemp, i, true) : Class2.SetSttEn_DisablePro(strtemp, i, false);
      Class1.SaveFileDataPro(FileName, StrData);
    }

    public static string ReadFileDataPro(string GiFileNameTemp)
    {
      StreamReader streamReader = new StreamReader(GiFileNameTemp);
      string end = streamReader.ReadToEnd();
      streamReader.Close();
      return end;
    }

    public static byte GetChkSumPro(byte[] Data)
    {
      int chkSumPro = 0;
      for (int index = 0; index < Data.Length; ++index)
        chkSumPro += (int) Data[index];
      return (byte) chkSumPro;
    }

    public static int ChgToCurDat(int DataTemp)
    {
      if (DataTemp >= 48 && DataTemp <= 57)
        DataTemp -= 48;
      else if (DataTemp >= 65 && DataTemp <= 90)
        DataTemp = DataTemp - 65 + 10;
      else if (DataTemp >= 91 && DataTemp <= 95)
        DataTemp = DataTemp - 91 + 59;
      else if (DataTemp >= 58 && DataTemp <= 64)
        DataTemp = DataTemp - 58 + 52;
      else if (DataTemp >= 32 && DataTemp <= 47)
        DataTemp = DataTemp - 32 + 36;
      return DataTemp;
    }

    public static int ChgToAscIIDat(int DataTemp)
    {
      if (DataTemp >= 0 && DataTemp <= 9)
        DataTemp += 48;
      else if (DataTemp >= 10 && DataTemp <= 35)
        DataTemp = DataTemp + 65 - 10;
      else if (DataTemp >= 59 && DataTemp <= 63)
        DataTemp = DataTemp + 91 - 59;
      else if (DataTemp >= 52 && DataTemp <= 58)
        DataTemp = DataTemp + 58 - 52;
      else if (DataTemp >= 36 && DataTemp <= 51)
        DataTemp = DataTemp + 32 - 36;
      return DataTemp;
    }

    public static bool KeyUseFul0_9ChkPro(char Keychar)
    {
      bool flag = true;
      if (Keychar >= '0' && Keychar <= '9')
      {
        flag = false;
      }
      else
      {
        switch (Keychar)
        {
          case '\u0003':
            flag = false;
            break;
          case '\b':
            flag = false;
            break;
          case '\r':
            flag = false;
            break;
          case '\u0016':
            flag = false;
            break;
          case '\u0018':
            flag = false;
            break;
          case ',':
            flag = false;
            break;
          case '.':
            flag = false;
            break;
        }
      }
      return flag;
    }

    public static bool KeyUseFulQt_DqtChkPro(char Keychar)
    {
      bool flag = Class1.KeyUseFul0_9ChkPro(Keychar);
      if (flag && (Keychar >= 'N' || Keychar <= 'n' || Keychar >= 'I' || Keychar <= 'i'))
        flag = false;
      return flag;
    }

    public static bool DtmfKeyUseFulChkPro(char Keychar)
    {
      bool flag = true;
      if (Keychar >= '0' && Keychar <= '9')
        flag = false;
      else if (Keychar >= 'A' && Keychar <= 'F')
        flag = false;
      else if (Keychar >= 'a' && Keychar <= 'f')
      {
        flag = false;
      }
      else
      {
        switch (Keychar)
        {
          case '\u0003':
            flag = false;
            break;
          case '\b':
            flag = false;
            break;
          case '\r':
            flag = false;
            break;
          case '\u0016':
            flag = false;
            break;
          case '\u0018':
            flag = false;
            break;
          case '#':
            flag = false;
            break;
          case '*':
            flag = false;
            break;
        }
      }
      return flag;
    }

    public static bool AsciiKeyUseFulChkPro(char Keychar)
    {
      bool flag = true;
      if (Keychar >= '0' && Keychar <= '9')
        flag = false;
      else if (Keychar >= 'A' && Keychar <= 'Z')
        flag = false;
      else if (Keychar >= 'a' && Keychar <= 'z')
      {
        flag = false;
      }
      else
      {
        switch (Keychar)
        {
          case '\b':
            flag = false;
            break;
          case '\r':
            flag = false;
            break;
          case ' ':
            flag = false;
            break;
          case '-':
            flag = false;
            break;
        }
      }
      return flag;
    }

    public static string ConvertString(string StrTemp, int fromBase, int toBase) => Convert.ToString(Convert.ToInt32(StrTemp, fromBase), toBase);

    public static string ChgCharTo_EF_Pro(string StrTemp)
    {
      StrTemp = StrTemp.Replace("*", "E");
      StrTemp = StrTemp.Replace("#", "F");
      return StrTemp;
    }

    public static string Chg_EF_ToCharPro(string StrTemp)
    {
      StrTemp = StrTemp.Replace("E", "*");
      StrTemp = StrTemp.Replace("F", "#");
      StrTemp = StrTemp.Replace("e", "*");
      StrTemp = StrTemp.Replace("f", "#");
      return StrTemp;
    }

    public static string SimplifiedToTraditional(string Text) => ChineseConverter.Convert(Text, ChineseConversionDirection.SimplifiedToTraditional);

    public static string TraditionalToSimplified(string Text) => ChineseConverter.Convert(Text, ChineseConversionDirection.TraditionalToSimplified);

    public static string hanziTOGbk_ChangePro1(string StrTemp)
    {
      string gbkChangePro1 = "";
      switch (Class1.GIFontSel)
      {
        case 0:
          foreach (byte num in Encoding.GetEncoding("GBK").GetBytes(StrTemp))
            gbkChangePro1 += string.Format("{0:X2}", (object) num);
          break;
        case 1:
          byte[] bytes;
          if (1 == Class1.GITraditionalChEn)
          {
            StrTemp = Class1.TraditionalToSimplified(StrTemp);
            bytes = Encoding.GetEncoding("GBK").GetBytes(StrTemp);
          }
          else
            bytes = Encoding.GetEncoding("big5").GetBytes(StrTemp);
          foreach (byte num in bytes)
            gbkChangePro1 += string.Format("{0:X2}", (object) num);
          break;
      }
      return gbkChangePro1;
    }

    public static int InputLengthSetPro(string StrTemp, int Length)
    {
      int length = Class1.hanziTOGbk_ChangePro1(StrTemp).Length;
      Length *= 4;
      int num;
      if (length > Length)
        num = 0;
      else
        num = (Length - length) / 2;
      Length = StrTemp.Length + num;
      return Length;
    }

    public static string hanziTOGbk_ChangePro(string StrTemp, int Length) => Class1.StrAutoAdd0X20Pro(Class1.hanziTOGbk_ChangePro1(StrTemp), 4 * Length);

    public static string GBKTOHanzi_ChangePro(string coding)
    {
      string str1 = string.Empty;
      try
      {
        if (0 == Class1.GIFontSel)
        {
          if (coding.Length % 2 != 0)
            throw new Exception("Code Error");
          int startIndex = 0;
          while (startIndex < coding.Length)
          {
            byte[] bytes1 = new byte[2];
            string str2 = coding.Substring(startIndex, 2);
            startIndex += 2;
            bytes1[0] = Convert.ToByte(str2, 16);
            if (bytes1[0] >= (byte) 161)
            {
              string str3 = coding.Substring(startIndex, 2);
              startIndex += 2;
              bytes1[1] = Convert.ToByte(str3, 16);
              try
              {
                string str4 = Encoding.GetEncoding("GBK").GetString(bytes1);
                str1 += str4;
              }
              catch
              {
              }
            }
            else
            {
              byte[] bytes2 = new byte[1]{ bytes1[0] };
              str1 += Convert.ToString(Encoding.ASCII.GetString(bytes2));
            }
          }
          int length = str1.Length;
          for (string str5 = str1.Substring(length - 1, 1); str5 == " "; str5 = str1.Substring(str1.Length - 1, 1))
          {
            str1 = str1.Substring(0, str1.Length - 1);
            if (0 == str1.Length)
              break;
          }
        }
        else if (1 == Class1.GIFontSel)
        {
          if (coding.Length % 2 != 0)
            throw new Exception("Code Error");
          int startIndex = 0;
          while (startIndex < coding.Length)
          {
            byte[] bytes3 = new byte[2];
            string str6 = coding.Substring(startIndex, 2);
            startIndex += 2;
            bytes3[0] = Convert.ToByte(str6, 16);
            if (bytes3[0] >= (byte) 161 || bytes3[0] >= (byte) 64 && bytes3[0] <= (byte) 127)
            {
              string str7 = coding.Substring(startIndex, 2);
              startIndex += 2;
              bytes3[1] = Convert.ToByte(str7, 16);
              try
              {
                string str8 = 1 != Class1.GITraditionalChEn ? Encoding.GetEncoding("big5").GetString(bytes3) : Class1.SimplifiedToTraditional(Encoding.GetEncoding("GBK").GetString(bytes3));
                str1 += str8;
              }
              catch
              {
              }
            }
            else
            {
              byte[] bytes4 = new byte[1]{ bytes3[0] };
              str1 += Convert.ToString(Encoding.ASCII.GetString(bytes4));
            }
          }
          int length = str1.Length;
          for (string str9 = str1.Substring(length - 1, 1); str9 == " "; str9 = str1.Substring(str1.Length - 1, 1))
          {
            str1 = str1.Substring(0, str1.Length - 1);
            if (0 == str1.Length)
              break;
          }
        }
      }
      catch
      {
        str1 = "";
      }
      return str1;
    }

    public static int LookStringPt(string StrTemp, string CharData) => StrTemp.IndexOf(CharData);
  }
}
