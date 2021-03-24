// Decompiled with JetBrains decompiler
// Type: OpenCV_Vision_Functions.HelperMethods
// Assembly: OpenCV Vision Functions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E5A0CF8-8488-48EA-B6F7-00ACD339AED9
// Assembly location: C:\JabilTest\OpenCV Vision Functions.dll

using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

namespace OpenCV_Vision_Functions
{
  internal class HelperMethods
  {
    public static Dictionary<string, int> Codec = new Dictionary<string, int>();

    [DllImport("JabilOpenCVFunctions.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int AverageImages(IntPtr image1, IntPtr image2, IntPtr outImage);

    [DllImport("JabilOpenCVFunctions.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int CompareImages(IntPtr image1, IntPtr image2);

    [DllImport("JabilOpenCVFunctions.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int CompareImagesWithTolerance(IntPtr image1, IntPtr image2, int rTolerance, int gTolerance, int bTolerance);

    [DllImport("JabilOpenCVFunctions.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int AddConstantToImage(IntPtr image1, IntPtr image2, int constToAdd);

    [DllImport("JabilOpenCVFunctions.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ThreshBetweenLimits(IntPtr image1, IntPtr image2, int minR, int minG, int minB, int maxR, int maxG, int maxB);

    [DllImport("JabilOpenCVFunctions.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ApplyGrayMask(IntPtr imageIn, IntPtr imageMask, IntPtr imageOut);

    public HelperMethods()
    {
      this.FillDictionary();
    }

    public static void LoadLanguage(string folderName, string language)
    {
      string str = Path.Combine(folderName, language + ".traineddata");
      if (System.IO.File.Exists(str))
        return;
      using (WebClient webClient = new WebClient())
      {
        string address = "https://github.com/tesseract-ocr/tessdata/blob/4592b8d453889181e01982d22328b5846765eaad/" + language + ".traineddata?raw=true";
        //webClient.DownloadFile(address, str);
      }
    }

    private void FillDictionary()
    {
      HelperMethods.Codec.Add("0000", -1);
      HelperMethods.Codec.Add("USER", -1);
      HelperMethods.Codec.Add("1978", 943143217);
      HelperMethods.Codec.Add("2VUY", 1498764850);
      HelperMethods.Codec.Add("3IV0", 810961203);
      HelperMethods.Codec.Add("3IV1", 827738419);
      HelperMethods.Codec.Add("3IV2", 844515635);
      HelperMethods.Codec.Add("3IVD", 1146505523);
      HelperMethods.Codec.Add("3IVX", 1482049843);
      HelperMethods.Codec.Add("8BPS", 1397768760);
      HelperMethods.Codec.Add("AAS4", 877871425);
      HelperMethods.Codec.Add("AASC", 1129529665);
      HelperMethods.Codec.Add("ABYR", 1381581377);
      HelperMethods.Codec.Add("ACTL", 1280590657);
      HelperMethods.Codec.Add("ADV1", 827737153);
      HelperMethods.Codec.Add("ADVJ", 1247167553);
      HelperMethods.Codec.Add("AEIK", 1263093057);
      HelperMethods.Codec.Add("AEMI", 1229800769);
      HelperMethods.Codec.Add("AFLC", 1129072193);
      HelperMethods.Codec.Add("AFLI", 1229735489);
      HelperMethods.Codec.Add("AHDV", 1447315521);
      HelperMethods.Codec.Add("AJPG", 1196444225);
      HelperMethods.Codec.Add("AMPG", 1196444993);
      HelperMethods.Codec.Add("ANIM", 1296649793);
      HelperMethods.Codec.Add("AP41", 825512001);
      HelperMethods.Codec.Add("AP42", 842289217);
      HelperMethods.Codec.Add("ASLC", 1129075521);
      HelperMethods.Codec.Add("ASV1", 827740993);
      HelperMethods.Codec.Add("ASV2", 844518209);
      HelperMethods.Codec.Add("ASVX", 1482052417);
      HelperMethods.Codec.Add("ATM4", 877483073);
      HelperMethods.Codec.Add("AUR2", 844256577);
      HelperMethods.Codec.Add("AURA", 1095914817);
      HelperMethods.Codec.Add("AVC1", 826496577);
      HelperMethods.Codec.Add("AVRN", 1314018881);
      HelperMethods.Codec.Add("BA81", 825770306);
      HelperMethods.Codec.Add("BINK", 1263421762);
      HelperMethods.Codec.Add("BLZ0", 811224130);
      HelperMethods.Codec.Add("BT20", 808604738);
      HelperMethods.Codec.Add("BTCV", 1447253058);
      HelperMethods.Codec.Add("BW10", 808539970);
      HelperMethods.Codec.Add("BYR1", 827480386);
      HelperMethods.Codec.Add("BYR2", 844257602);
      HelperMethods.Codec.Add("CC12", 842089283);
      HelperMethods.Codec.Add("CDVC", 1129727043);
      HelperMethods.Codec.Add("CFCC", 1128482371);
      HelperMethods.Codec.Add("CGDI", 1229211459);
      HelperMethods.Codec.Add("CHAM", 1296123971);
      HelperMethods.Codec.Add("CJPG", 1196444227);
      HelperMethods.Codec.Add("CMYK", 1264143683);
      HelperMethods.Codec.Add("CPLA", 1095520323);
      HelperMethods.Codec.Add("CRAM", 1296126531);
      HelperMethods.Codec.Add("CSCD", 1145262915);
      HelperMethods.Codec.Add("CTRX", 1481790531);
      HelperMethods.Codec.Add("CVID", 1145656899);
      HelperMethods.Codec.Add("CWLT", 1414289219);
      HelperMethods.Codec.Add("CXY1", 827938883);
      HelperMethods.Codec.Add("CXY2", 844716099);
      HelperMethods.Codec.Add("CYUV", 1448433987);
      HelperMethods.Codec.Add("CYUY", 1498765635);
      HelperMethods.Codec.Add("D261", 825635396);
      HelperMethods.Codec.Add("D263", 859189828);
      HelperMethods.Codec.Add("DAVC", 1129726276);
      HelperMethods.Codec.Add("DCL1", 827081540);
      HelperMethods.Codec.Add("DCL2", 843858756);
      HelperMethods.Codec.Add("DCL3", 860635972);
      HelperMethods.Codec.Add("DCL4", 877413188);
      HelperMethods.Codec.Add("DCL5", 894190404);
      HelperMethods.Codec.Add("DIV3", 861292868);
      HelperMethods.Codec.Add("DIV4", 878070084);
      HelperMethods.Codec.Add("DIV5", 894847300);
      HelperMethods.Codec.Add("DIVX", 1482049860);
      HelperMethods.Codec.Add("DM4V", 1446268228);
      HelperMethods.Codec.Add("DMB1", 826428740);
      HelperMethods.Codec.Add("DMB2", 843205956);
      HelperMethods.Codec.Add("DMK2", 843795780);
      HelperMethods.Codec.Add("DSVD", 1146508100);
      HelperMethods.Codec.Add("DUCK", 1262703940);
      HelperMethods.Codec.Add("DV25", 892491332);
      HelperMethods.Codec.Add("DV50", 808801860);
      HelperMethods.Codec.Add("DVAN", 1312904772);
      HelperMethods.Codec.Add("DVCS", 1396921924);
      HelperMethods.Codec.Add("DVE2", 843404868);
      HelperMethods.Codec.Add("DVH1", 826824260);
      HelperMethods.Codec.Add("DVHD", 1145591364);
      HelperMethods.Codec.Add("DVSD", 1146312260);
      HelperMethods.Codec.Add("DVSL", 1280529988);
      HelperMethods.Codec.Add("DVX1", 827872836);
      HelperMethods.Codec.Add("DVX2", 844650052);
      HelperMethods.Codec.Add("DVX3", 861427268);
      HelperMethods.Codec.Add("DX50", 808802372);
      HelperMethods.Codec.Add("DXGM", 1296521284);
      HelperMethods.Codec.Add("DXTC", 1129601092);
      HelperMethods.Codec.Add("DXTN", 1314150468);
      HelperMethods.Codec.Add("EKQ0", 810634053);
      HelperMethods.Codec.Add("ELK0", 810241093);
      HelperMethods.Codec.Add("EM2V", 1446137157);
      HelperMethods.Codec.Add("ES07", 925913925);
      HelperMethods.Codec.Add("ESCP", 1346589509);
      HelperMethods.Codec.Add("ETV1", 827741253);
      HelperMethods.Codec.Add("ETV2", 844518469);
      HelperMethods.Codec.Add("ETVC", 1129731141);
      HelperMethods.Codec.Add("FFV1", 827737670);
      HelperMethods.Codec.Add("FLJP", 1347046470);
      HelperMethods.Codec.Add("FMP4", 877677894);
      HelperMethods.Codec.Add("FMVC", 1129729350);
      HelperMethods.Codec.Add("FPS1", 827543622);
      HelperMethods.Codec.Add("FRWA", 1096241734);
      HelperMethods.Codec.Add("FRWD", 1146573382);
      HelperMethods.Codec.Add("FVF1", 826693190);
      HelperMethods.Codec.Add("GEOX", 1481590087);
      HelperMethods.Codec.Add("GJPG", 1196444231);
      HelperMethods.Codec.Add("GLZW", 1465535559);
      HelperMethods.Codec.Add("GPEG", 1195724871);
      HelperMethods.Codec.Add("GWLT", 1414289223);
      HelperMethods.Codec.Add("H260", 808858184);
      HelperMethods.Codec.Add("H261", 825635400);
      HelperMethods.Codec.Add("H262", 842412616);
      HelperMethods.Codec.Add("H263", 859189832);
      HelperMethods.Codec.Add("H264", 875967048);
      HelperMethods.Codec.Add("H265", 892744264);
      HelperMethods.Codec.Add("H266", 909521480);
      HelperMethods.Codec.Add("H267", 926298696);
      HelperMethods.Codec.Add("H268", 943075912);
      HelperMethods.Codec.Add("H269", 959853128);
      HelperMethods.Codec.Add("HDYC", 1129923656);
      HelperMethods.Codec.Add("HEVC", 1129727304);
      HelperMethods.Codec.Add("HFYU", 1431914056);
      HelperMethods.Codec.Add("HMCR", 1380142408);
      HelperMethods.Codec.Add("HMRR", 1381125448);
      HelperMethods.Codec.Add("I263", 859189833);
      HelperMethods.Codec.Add("ICLB", 1112294217);
      HelperMethods.Codec.Add("IGOR", 1380927305);
      HelperMethods.Codec.Add("IJPG", 1196444233);
      HelperMethods.Codec.Add("ILVC", 1129729097);
      HelperMethods.Codec.Add("ILVR", 1381387337);
      HelperMethods.Codec.Add("IPDV", 1447317577);
      HelperMethods.Codec.Add("IR21", 825381449);
      HelperMethods.Codec.Add("IRAW", 1463898697);
      HelperMethods.Codec.Add("ISME", 1162695497);
      HelperMethods.Codec.Add("IV30", 808670793);
      HelperMethods.Codec.Add("IV31", 825448009);
      HelperMethods.Codec.Add("IV32", 842225225);
      HelperMethods.Codec.Add("IV33", 859002441);
      HelperMethods.Codec.Add("IV34", 875779657);
      HelperMethods.Codec.Add("IV35", 892556873);
      HelperMethods.Codec.Add("IV36", 909334089);
      HelperMethods.Codec.Add("IV37", 926111305);
      HelperMethods.Codec.Add("IV38", 942888521);
      HelperMethods.Codec.Add("IV39", 959665737);
      HelperMethods.Codec.Add("IV40", 808736329);
      HelperMethods.Codec.Add("IV41", 825513545);
      HelperMethods.Codec.Add("IV42", 842290761);
      HelperMethods.Codec.Add("IV43", 859067977);
      HelperMethods.Codec.Add("IV44", 875845193);
      HelperMethods.Codec.Add("IV45", 892622409);
      HelperMethods.Codec.Add("IV46", 909399625);
      HelperMethods.Codec.Add("IV47", 926176841);
      HelperMethods.Codec.Add("IV48", 942954057);
      HelperMethods.Codec.Add("IV49", 959731273);
      HelperMethods.Codec.Add("IV50", 808801865);
      HelperMethods.Codec.Add("IYUV", 1448433993);
      HelperMethods.Codec.Add("JBYR", 1381581386);
      HelperMethods.Codec.Add("JPEG", 1195724874);
      HelperMethods.Codec.Add("JPGL", 1279742026);
      HelperMethods.Codec.Add("KMVC", 1129729355);
      HelperMethods.Codec.Add("L261", 825635404);
      HelperMethods.Codec.Add("L263", 859189836);
      HelperMethods.Codec.Add("LBYR", 1381581388);
      HelperMethods.Codec.Add("LCMW", 1464681292);
      HelperMethods.Codec.Add("LCW2", 844579660);
      HelperMethods.Codec.Add("LEAD", 1145128268);
      HelperMethods.Codec.Add("LGRY", 1498564428);
      HelperMethods.Codec.Add("LJ11", 825313868);
      HelperMethods.Codec.Add("LJ22", 842156620);
      HelperMethods.Codec.Add("LJ2K", 1261587020);
      HelperMethods.Codec.Add("LJ44", 875842124);
      HelperMethods.Codec.Add("LJPG", 1196444236);
      HelperMethods.Codec.Add("LMP2", 844123468);
      HelperMethods.Codec.Add("LMP4", 877677900);
      HelperMethods.Codec.Add("LSVC", 1129730892);
      HelperMethods.Codec.Add("LSVM", 1297503052);
      HelperMethods.Codec.Add("LSVX", 1482052428);
      HelperMethods.Codec.Add("LZO1", 827284044);
      HelperMethods.Codec.Add("M261", 825635405);
      HelperMethods.Codec.Add("M263", 859189837);
      HelperMethods.Codec.Add("M4CC", 1128477773);
      HelperMethods.Codec.Add("M4S2", 844313677);
      HelperMethods.Codec.Add("MC12", 842089293);
      HelperMethods.Codec.Add("MCAM", 1296122701);
      HelperMethods.Codec.Add("MJ2C", 1127369293);
      HelperMethods.Codec.Add("MJPG", 1196444237);
      HelperMethods.Codec.Add("MMES", 1397050701);
      HelperMethods.Codec.Add("MP2A", 1093816397);
      HelperMethods.Codec.Add("MP2T", 1412583501);
      HelperMethods.Codec.Add("MP2V", 1446137933);
      HelperMethods.Codec.Add("MP42", 842289229);
      HelperMethods.Codec.Add("MP43", 859066445);
      HelperMethods.Codec.Add("MP4A", 1093947469);
      HelperMethods.Codec.Add("MP4S", 1395937357);
      HelperMethods.Codec.Add("MP4T", 1412714573);
      HelperMethods.Codec.Add("MP4V", 1446269005);
      HelperMethods.Codec.Add("MPEG", 1195724877);
      HelperMethods.Codec.Add("MPG4", 877088845);
      HelperMethods.Codec.Add("MPGI", 1229410381);
      HelperMethods.Codec.Add("MR16", 909201997);
      HelperMethods.Codec.Add("MRCA", 1094931021);
      HelperMethods.Codec.Add("MRLE", 1162629709);
      HelperMethods.Codec.Add("MSVC", 1129730893);
      HelperMethods.Codec.Add("MSZH", 1213879117);
      HelperMethods.Codec.Add("MTX1", 827872333);
      HelperMethods.Codec.Add("MTX2", 844649549);
      HelperMethods.Codec.Add("MTX3", 861426765);
      HelperMethods.Codec.Add("MTX4", 878203981);
      HelperMethods.Codec.Add("MTX5", 894981197);
      HelperMethods.Codec.Add("MTX6", 911758413);
      HelperMethods.Codec.Add("MTX7", 928535629);
      HelperMethods.Codec.Add("MTX8", 945312845);
      HelperMethods.Codec.Add("MTX9", 962090061);
      HelperMethods.Codec.Add("MVI1", 826889805);
      HelperMethods.Codec.Add("MVI2", 843667021);
      HelperMethods.Codec.Add("MWV1", 827742029);
      HelperMethods.Codec.Add("NAVI", 1230389582);
      HelperMethods.Codec.Add("NDSC", 1129530446);
      HelperMethods.Codec.Add("NDSM", 1297302606);
      HelperMethods.Codec.Add("NDSP", 1347634254);
      HelperMethods.Codec.Add("NDSS", 1397965902);
      HelperMethods.Codec.Add("NDXC", 1129858126);
      HelperMethods.Codec.Add("NDXH", 1213744206);
      HelperMethods.Codec.Add("NDXP", 1347961934);
      HelperMethods.Codec.Add("NDXS", 1398293582);
      HelperMethods.Codec.Add("NHVU", 1431717966);
      HelperMethods.Codec.Add("NTN1", 827216974);
      HelperMethods.Codec.Add("NTN2", 843994190);
      HelperMethods.Codec.Add("NVDS", 1396987470);
      HelperMethods.Codec.Add("NVHS", 1397249614);
      HelperMethods.Codec.Add("NVS0", 810767950);
      HelperMethods.Codec.Add("NVS1", 827545166);
      HelperMethods.Codec.Add("NVS2", 844322382);
      HelperMethods.Codec.Add("NVS3", 861099598);
      HelperMethods.Codec.Add("NVS4", 877876814);
      HelperMethods.Codec.Add("NVS5", 894654030);
      HelperMethods.Codec.Add("NVT0", 810833486);
      HelperMethods.Codec.Add("NVT1", 827610702);
      HelperMethods.Codec.Add("NVT2", 844387918);
      HelperMethods.Codec.Add("NVT3", 861165134);
      HelperMethods.Codec.Add("NVT4", 877942350);
      HelperMethods.Codec.Add("NVT5", 894719566);
      HelperMethods.Codec.Add("PDVC", 1129727056);
      HelperMethods.Codec.Add("PGVV", 1448494928);
      HelperMethods.Codec.Add("PHMO", 1330464848);
      HelperMethods.Codec.Add("PIM1", 827148624);
      HelperMethods.Codec.Add("PIM2", 843925840);
      HelperMethods.Codec.Add("PIMJ", 1246579024);
      HelperMethods.Codec.Add("PIXL", 1280854352);
      HelperMethods.Codec.Add("PJPG", 1196444240);
      HelperMethods.Codec.Add("PVEZ", 1514493520);
      HelperMethods.Codec.Add("PVMM", 1296914000);
      HelperMethods.Codec.Add("PVW2", 844584528);
      HelperMethods.Codec.Add("QPEG", 1195724881);
      HelperMethods.Codec.Add("QPEQ", 1363497041);
      HelperMethods.Codec.Add("RGBT", 1413629778);
      HelperMethods.Codec.Add("RLE", 1162629727);
      HelperMethods.Codec.Add("RLE4", 876956754);
      HelperMethods.Codec.Add("RLE8", 944065618);
      HelperMethods.Codec.Add("RMP4", 877677906);
      HelperMethods.Codec.Add("RPZA", 1096437842);
      HelperMethods.Codec.Add("RT21", 825381970);
      HelperMethods.Codec.Add("RV20", 808605266);
      HelperMethods.Codec.Add("RV30", 808670802);
      HelperMethods.Codec.Add("RV40", 808736338);
      HelperMethods.Codec.Add("S422", 842150995);
      HelperMethods.Codec.Add("SAN3", 860766547);
      HelperMethods.Codec.Add("SDCC", 1128481875);
      HelperMethods.Codec.Add("SEDG", 1195656531);
      HelperMethods.Codec.Add("SFMC", 1129137747);
      HelperMethods.Codec.Add("SMP4", 877677907);
      HelperMethods.Codec.Add("SMSC", 1129532755);
      HelperMethods.Codec.Add("SMSD", 1146309971);
      HelperMethods.Codec.Add("SMSV", 1448299859);
      HelperMethods.Codec.Add("SP40", 808734803);
      HelperMethods.Codec.Add("SP44", 875843667);
      HelperMethods.Codec.Add("SP54", 875909203);
      HelperMethods.Codec.Add("SPIG", 1195987027);
      HelperMethods.Codec.Add("SQZ2", 844779859);
      HelperMethods.Codec.Add("STVA", 1096176723);
      HelperMethods.Codec.Add("STVB", 1112953939);
      HelperMethods.Codec.Add("STVC", 1129731155);
      HelperMethods.Codec.Add("STVX", 1482052691);
      HelperMethods.Codec.Add("STVY", 1498829907);
      HelperMethods.Codec.Add("SV10", 808539731);
      HelperMethods.Codec.Add("SVQ1", 827414099);
      HelperMethods.Codec.Add("SVQ3", 860968531);
      HelperMethods.Codec.Add("TLMS", 1397574740);
      HelperMethods.Codec.Add("TLST", 1414745172);
      HelperMethods.Codec.Add("TM20", 808602964);
      HelperMethods.Codec.Add("TM2X", 1479691604);
      HelperMethods.Codec.Add("TMIC", 1128877396);
      HelperMethods.Codec.Add("TMOT", 1414483284);
      HelperMethods.Codec.Add("TR20", 808604244);
      HelperMethods.Codec.Add("TSCC", 1128485716);
      HelperMethods.Codec.Add("TV10", 808539732);
      HelperMethods.Codec.Add("TVJP", 1347049044);
      HelperMethods.Codec.Add("TVMJ", 1246582356);
      HelperMethods.Codec.Add("TY0N", 1311791444);
      HelperMethods.Codec.Add("TY2C", 1127373140);
      HelperMethods.Codec.Add("TY2N", 1311922516);
      HelperMethods.Codec.Add("UCOD", 1146045269);
      HelperMethods.Codec.Add("ULTI", 1230261333);
      HelperMethods.Codec.Add("V210", 808530518);
      HelperMethods.Codec.Add("V261", 825635414);
      HelperMethods.Codec.Add("V655", 892679766);
      HelperMethods.Codec.Add("VCR1", 827474774);
      HelperMethods.Codec.Add("VCR2", 844251990);
      HelperMethods.Codec.Add("VCR3", 861029206);
      HelperMethods.Codec.Add("VCR4", 877806422);
      HelperMethods.Codec.Add("VCR5", 894583638);
      HelperMethods.Codec.Add("VCR6", 911360854);
      HelperMethods.Codec.Add("VCR7", 928138070);
      HelperMethods.Codec.Add("VCR8", 944915286);
      HelperMethods.Codec.Add("VCR9", 961692502);
      HelperMethods.Codec.Add("VDCT", 1413694550);
      HelperMethods.Codec.Add("VDOM", 1297040470);
      HelperMethods.Codec.Add("VDOW", 1464812630);
      HelperMethods.Codec.Add("VDTZ", 1515471958);
      HelperMethods.Codec.Add("VGPX", 1481656150);
      HelperMethods.Codec.Add("VIDS", 1396984150);
      HelperMethods.Codec.Add("VIFP", 1346783574);
      HelperMethods.Codec.Add("VIVO", 1331054934);
      HelperMethods.Codec.Add("VIXL", 1280854358);
      HelperMethods.Codec.Add("VLV1", 827739222);
      HelperMethods.Codec.Add("VP30", 808669270);
      HelperMethods.Codec.Add("VP31", 825446486);
      HelperMethods.Codec.Add("VP40", 808734806);
      HelperMethods.Codec.Add("VP50", 808800342);
      HelperMethods.Codec.Add("VP60", 808865878);
      HelperMethods.Codec.Add("VP61", 825643094);
      HelperMethods.Codec.Add("VP62", 842420310);
      HelperMethods.Codec.Add("VP70", 808931414);
      HelperMethods.Codec.Add("VP80", 808996950);
      HelperMethods.Codec.Add("VQC1", 826495318);
      HelperMethods.Codec.Add("VQC2", 843272534);
      HelperMethods.Codec.Add("VQJC", 1128943958);
      HelperMethods.Codec.Add("VSSV", 1448301398);
      HelperMethods.Codec.Add("VUUU", 1431655766);
      HelperMethods.Codec.Add("VX1K", 1261525078);
      HelperMethods.Codec.Add("VX2K", 1261590614);
      HelperMethods.Codec.Add("VXSP", 1347639382);
      HelperMethods.Codec.Add("VYU9", 961894742);
      HelperMethods.Codec.Add("VYUY", 1498765654);
      HelperMethods.Codec.Add("WBVC", 1129726551);
      HelperMethods.Codec.Add("WHAM", 1296123991);
      HelperMethods.Codec.Add("WINX", 1481525591);
      HelperMethods.Codec.Add("WJPG", 1196444247);
      HelperMethods.Codec.Add("WMV1", 827739479);
      HelperMethods.Codec.Add("WMV2", 844516695);
      HelperMethods.Codec.Add("WMV3", 861293911);
      HelperMethods.Codec.Add("WMVA", 1096174935);
      HelperMethods.Codec.Add("WNV1", 827739735);
      HelperMethods.Codec.Add("WVC1", 826496599);
      HelperMethods.Codec.Add("X263", 859189848);
      HelperMethods.Codec.Add("X264", 875967064);
      HelperMethods.Codec.Add("XLV0", 810962008);
      HelperMethods.Codec.Add("XMPG", 1196445016);
      HelperMethods.Codec.Add("XVID", 1145656920);
      HelperMethods.Codec.Add("XWV0", 810964824);
      HelperMethods.Codec.Add("XWV1", 827742040);
      HelperMethods.Codec.Add("XWV2", 844519256);
      HelperMethods.Codec.Add("XWV3", 861296472);
      HelperMethods.Codec.Add("XWV4", 878073688);
      HelperMethods.Codec.Add("XWV5", 894850904);
      HelperMethods.Codec.Add("XWV6", 911628120);
      HelperMethods.Codec.Add("XWV7", 928405336);
      HelperMethods.Codec.Add("XWV8", 945182552);
      HelperMethods.Codec.Add("XWV9", 961959768);
      HelperMethods.Codec.Add("XXAN", 1312905304);
      HelperMethods.Codec.Add("Y16", 909203807);
      HelperMethods.Codec.Add("Y411", 825308249);
      HelperMethods.Codec.Add("Y41P", 1345401945);
      HelperMethods.Codec.Add("Y444", 875836505);
      HelperMethods.Codec.Add("Y8", 945381215);
      HelperMethods.Codec.Add("YC12", 842089305);
      HelperMethods.Codec.Add("YUV8", 945182041);
      HelperMethods.Codec.Add("YUV9", 961959257);
      HelperMethods.Codec.Add("YUVP", 1347835225);
      HelperMethods.Codec.Add("YUY2", 844715353);
      HelperMethods.Codec.Add("YUYV", 1448695129);
      HelperMethods.Codec.Add("YV12", 842094169);
      HelperMethods.Codec.Add("YV16", 909203033);
      HelperMethods.Codec.Add("YV92", 842618457);
      HelperMethods.Codec.Add("ZLIB", 1112099930);
      HelperMethods.Codec.Add("ZMBV", 1447185754);
      HelperMethods.Codec.Add("ZPEG", 1195724890);
      HelperMethods.Codec.Add("ZYGO", 1330075994);
      HelperMethods.Codec.Add("ZYYY", 1499027802);
    }

    public Image<Bgr, byte> averageImages(Image<Bgr, byte> image1, Image<Bgr, byte> image2)
    {
      Image<Bgr, byte> image = new Image<Bgr, byte>(image1.Size);
      for (int index1 = 0; index1 < image1.Size.Width; ++index1)
      {
        for (int index2 = 0; index2 < image1.Size.Height; ++index2)
        {
          Bgr bgr1 = image1[index2, index1];
          Bgr bgr2 = image2[index2, index1];
          image[index2, index1] = new Bgr()
          {
            Blue = (bgr1.Blue + bgr2.Blue) / 2.0,
            Green = (bgr1.Green + bgr2.Green) / 2.0,
            Red = (bgr1.Red + bgr2.Red) / 2.0
          };
        }
      }
      return image;
    }

    public Image<Bgr, byte> averageImages(Image<Bgr, byte>[] imageArray)
    {
      Bgr bgr1 = new Bgr();
      Bgr bgr2 = new Bgr();
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      if (imageArray.Length == 0)
        return (Image<Bgr, byte>) null;
      Image<Bgr, byte> image1 = new Image<Bgr, byte>(imageArray[0].Size);
      Size size = imageArray[0].Size;
      int width = size.Width;
      size = imageArray[0].Size;
      int height = size.Height;
      for (int index1 = 0; index1 < width; ++index1)
      {
        for (int index2 = 0; index2 < height; ++index2)
        {
          foreach (Image<Bgr, byte> image2 in imageArray)
          {
            Bgr bgr3 = image2[index2, index1];
            num1 += bgr3.Blue;
            num2 += bgr3.Green;
            num3 += bgr3.Red;
          }
          bgr2.Blue = num1 / (double) imageArray.Length;
          bgr2.Green = num2 / (double) imageArray.Length;
          bgr2.Red = num3 / (double) imageArray.Length;
          image1[index2, index1] = bgr2;
          num1 = 0.0;
          num2 = 0.0;
          num3 = 0.0;
        }
      }
      return image1;
    }

    public Image<Bgr, byte> averageImagesFast(Image<Bgr, byte>[] imageArray)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      if (imageArray.Length == 0)
        return (Image<Bgr, byte>) null;
      Image<Bgr, byte> image = new Image<Bgr, byte>(imageArray[0].Size);
      int width = imageArray[0].Size.Width;
      int height = imageArray[0].Size.Height;
      Array[] arrayArray = new Array[imageArray.Length];
      object obj1 = new object();
      for (int index = 0; index < imageArray.Length; ++index)
        arrayArray[index] = imageArray[index].ManagedArray;
      for (int index2 = 0; index2 < width; ++index2)
      {
        for (int index1 = 0; index1 < height; ++index1)
        {
          foreach (Array array in arrayArray)
          {
            object obj2 = array.GetValue(index1, index2, 0);
            num1 += double.Parse(obj2.ToString());
            object obj3 = array.GetValue(index1, index2, 1);
            num2 += double.Parse(obj3.ToString());
            object obj4 = array.GetValue(index1, index2, 2);
            num3 += double.Parse(obj4.ToString());
          }
          image.ManagedArray.SetValue((object) num1, index1, index2, 0);
        }
      }
      return image;
    }
  }
}
