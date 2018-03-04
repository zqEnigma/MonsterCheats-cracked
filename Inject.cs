namespace Shit
{
    using Microsoft.VisualBasic.CompilerServices;
    using SerializationObjectManager;
    using Shit.My;
    using System;
    using System.Management;
    using System.Net;

    [StandardModule]
    internal sealed class Inject
    {
        public static bool IsVip;
        public static string Statused;
        public static string lversion;
        public static bool HWIDChecked = false;
        public static bool[] AlreadyAdded = new bool[12];

        public static void AddCheats(int max)
        {
            // This item is obfuscated and can not be translated.
            int num = max;
            goto Label_0AC3;
        }

        public static void checkhwid()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0xc202b6b8;
            HttpWebResponse response = (HttpWebResponse) ctü((HttpWebRequest) ûz±(îò¾a("http://82.208.17.176/Loader/checkguid.php?hwid=",  }k÷(), "&nick=", Shit.My.MyProject.Forms.Login.CrystalClearTextBox1.Text)));
        Label_0057:
            num4 = -2116355571;
        Label_0063:;
            int num5 = -1955828321;
            int num3 = 0x4d2;
            switch (((~((-~num5 * -1570772375) - (0x79aee585 * -992045948)) + num4) >> 0x10))
            {
                case 1:
                    goto Label_0275;

                case 2:
                    goto Label_0057;

                case 3:
                {
                    string text1 = Øãa(¡vö({Ôú(response)));
                    if (SerializationObjectManager.ArgumentOutOfRangeException.LifetimeEntry(text1, "WS_NEED_WRITE_NEW_ONE"))
                    {
                        ®|();
                        *CONSOLESCREENBUFFERINFO[0x36]("HWID has been saved !", 0, null);
                    }
                    if (SerializationObjectManager.ArgumentOutOfRangeException.LifetimeEntry(text1, "WS_HWID_NOT_FOUND"))
                    {
                        *CONSOLESCREENBUFFERINFO[0x36]("Sorry you are not owner of the account or you had different HWID !", 0, null);
                        ¢ä°{();
                    }
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = -513831175;
                    goto Label_0063;
                }
                case 4:
                    goto Label_0231;
            }
            goto Label_02AD;
            *CONSOLESCREENBUFFERINFO[0x36]("Unknown error when HWID Checking .. !", 0, null);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0063;
            ¢ä°{();
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0063;
            HWIDChecked = true;
        }

        public static void checkifcanuse()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            HttpWebResponse response = (HttpWebResponse) ctü((HttpWebRequest) ûz±("http://82.208.17.176/Loader00285/LStatus.txt"));
        Label_002A:
            num4 = 0x30077de1;
        Label_0036:;
            int num5 = 0x5140bb9e;
            int num3 = 0x4d2;
            switch (((((num5 - (~((-37779911 - -2115529566) * 0x7b48faa9) - ~-226146426)) ^ (((0x2081833c - 0x5f5b01cb) ^ (-1178524573 - 0x798e58ca)) * 0x2c6f6657)) + num4) >> 0x10))
            {
                case 0:
                    goto Label_002A;

                case 1:
                    goto Label_01F6;

                case 2:
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = -949938905;
                    goto Label_0036;
            }
            goto Label_024F;
            *CONSOLESCREENBUFFERINFO[0x36]("Loader is stopped by Developer !", 0, null);
            G¥ÛõW(Shit.My.MyProject.Forms.Form1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x29];
            goto Label_0036;
        }

        public static void checktrial()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0xc565e07e;
            HttpWebResponse response = (HttpWebResponse) ctü((HttpWebRequest) ûz±("http://82.208.17.176/VIPS/status2.txt"));
            string text1 = Øãa(¡vö({Ôú(response)));
            if (SerializationObjectManager.ArgumentOutOfRangeException.LifetimeEntry(text1, "CU0"))
            {
                *CONSOLESCREENBUFFERINFO[0x36]("Public is stopped by Developer ! (Expired)", 0, null);
                Shit.Injektion.allowtrial = 0;
            }
            if (!SerializationObjectManager.ArgumentOutOfRangeException.LifetimeEntry(text1, "CU1"))
            {
                goto Label_011D;
            }
        Label_0081:
            num4 = -1490189673;
        Label_008D:;
            int num5 = 0x7fc94931;
            switch (((((-((num5 * -1867116505) * 0x458ac061) * 0x69e36b31) * -858602927) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0081;

                case 2:
                    Shit.Injektion.allowtrial = 1;
                    num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                    goto Label_008D;
            }
            goto Label_011D;
        }

        public static void checkusergroup()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x82c90f57;
            HttpWebResponse response = (HttpWebResponse) ctü((HttpWebRequest) ûz±(ý^¤)("http://82.208.17.176/5.php?username=", Shit.My.MyProject.Forms.Login.CrystalClearTextBox1.Text)));
            string text1 = Øãa(¡vö({Ôú(response)));
            if (SerializationObjectManager.ArgumentOutOfRangeException.LifetimeEntry(text1, "<usergroup>2</usergroup>"))
            {
                IsVip = false;
                iv(10);
            }
            if (SerializationObjectManager.ArgumentOutOfRangeException.LifetimeEntry(text1, "<usergroup>8</usergroup>"))
            {
                IsVip = true;
                iv(10);
            }
            if (SerializationObjectManager.ArgumentOutOfRangeException.LifetimeEntry(text1, "<usergroup>10</usergroup>"))
            {
                *CONSOLESCREENBUFFERINFO[0x36]("Welcome WaterSmoke", 0, null);
                IsVip = true;
                iv(10);
            }
            if (SerializationObjectManager.ArgumentOutOfRangeException.LifetimeEntry(text1, "<usergroup>6</usergroup>"))
            {
                IsVip = true;
                iv(10);
            }
            if (!SerializationObjectManager.ArgumentOutOfRangeException.LifetimeEntry(text1, "<usergroup>7</usergroup>"))
            {
                goto Label_01C0;
            }
        Label_0108:
            num4 = 0x644e8136;
        Label_0114:;
            int num5 = -1157477672;
            switch (((~(-~((-285924932 - 0x2f29eaf9) ^ ~0x5f7b0530) - num5) + num4) >> 0x10))
            {
                case 1:
                    *CONSOLESCREENBUFFERINFO[0x36]("You have been banned by a Forum Staff member! Please contact anyone of the staff to appeal your ban. In order to secure the loader you have been banned on the loader and forums!", 0x10, "Monster Cheats");
                    ¢ä°{();
                    num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                    goto Label_0114;

                case 2:
                    goto Label_0108;
            }
            goto Label_01C0;
        }

        public static void checkversion()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x125e2b3f;
            HttpWebResponse response = (HttpWebResponse) ctü((HttpWebRequest) ûz±("http://82.208.17.176/Loader00285/Version.txt"));
        Label_002A:
            num4 = 0x5a2a684b;
        Label_0036:;
            int num5 = -1647250402;
            int num3 = 0x4d2;
            switch (((((num5 ^ (-(-0x61d426d6 + (0x66e15b51 ^ -1079437978)) + -((-778806067 + -2036640998) ^ (0x6a13f5b * 0x13b4d39b)))) * -131839093) + num4) >> 0x10))
            {
                case 1:
                    goto Label_01F6;

                case 2:
                    goto Label_023B;

                case 3:
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = 0x54348f38;
                    goto Label_0036;

                case 4:
                    goto Label_002A;
            }
            goto Label_027D;
            *CONSOLESCREENBUFFERINFO[0x36]("New Version is Available ! Downloading ...", 0, null);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[40];
            goto Label_0036;
            þÆm(Shit.My.MyProject.Forms.DW2);
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0036;
        }

        public static string GetAppDataPathD() => 
            N÷(Environment.SpecialFolder.ApplicationData);

        public static int GetCheatId()
        {
            // This item is obfuscated and can not be translated.
            int num;
            int num5;
            uint num2 = 0x552cd289;
            if (*?().Count <= 0)
            {
                goto Label_01A6;
            }
        Label_002E:
            num5 = 0x5f886d44;
        Label_003A:;
            int num6 = -2037659161;
            int num4 = 0x4d2;
            switch ((((~((((--1832418223 - (-864596731 * 0x47da8901)) - ~(0xfa76ca0 ^ 0x46cae53a)) - (num6 - -~((0x52e21354 + -1570146908) ^ ~0x1b25bd9b))) ^ 0x225cbe60) * -1259223417) + num5) >> 0x10))
            {
                case 0:
                    goto Label_002E;

                case 1:
                    goto Label_0310;

                case 2:
                    goto Label_01A6;

                case 3:
                    goto Label_02AC;

                case 5:
                    num = (((int) *?()) + *?().Count) + 1;
                    num5 = -544070964;
                    goto Label_003A;
            }
            goto Label_0337;
            num4 = 0x4d2;
            num4 = 0x4d2;
            num5 = -1575984170;
            goto Label_003A;
            num = ((int) *?()) + 1;
            num5 = -1266052194;
            goto Label_003A;
            num = 0;
            num5 = (int) (num2 ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_003A;
        }

        public static string GetHWID()
        {
            // This item is obfuscated and can not be translated.
            ManagementObjectCollection.ManagementObjectEnumerator enumerator;
            uint num2;
            int num3;
            int num4;
            int num5;
            string str = string.Empty;
            ManagementObjectCollection objects = (ManagementObjectCollection) #¤1§(
»("win32_processor"));
            try
            {
                enumerator = (ManagementObjectCollection.ManagementObjectEnumerator) ªiîÍ(objects);
            Label_0033:
                num4 = -110065233;
            Label_003F:;
                num5 = 0x1cc98b70;
                num3 = 0x4d2;
                switch (((num2 = (uint) ((0x3828673b - ((((num5 * 0x2674220b) ^ ((0x5aade715 * 0x21703b11) ^ ((0x70be72f4 + -1849541868) ^ ~-1891160492))) * 0x1d14f2f3) ^ 0x5f929555)) + num4)) % 6))
                {
                    case 0:
                        goto Label_023A;

                    case 1:
                        num4 = 0x7dd39067;
                        goto Label_003F;

                    case 2:
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = 0x3b4324d2;
                        goto Label_003F;

                    case 3:
                        goto Label_0033;

                    case 4:
                        goto Label_0121;
                }
                goto Label_0398;
                ManagementObject obj2 = (ManagementObject) *?();
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -228346416;
                goto Label_003F;
            }
            finally
            {
                if (enumerator == null)
                {
                    goto Label_0474;
                }
            Label_03AA:
                num4 = -1896369919;
            Label_03B6:;
                num5 = -564039681;
                num3 = 0x4d2;
                switch (((num2 = (uint) ((0x3828673b - ((((num5 * 0x2674220b) ^ ((0x5aade715 * 0x21703b11) ^ ((0x70be72f4 + -1849541868) ^ ~-1891160492))) * 0x1d14f2f3) ^ 0x5f929555)) + num4)) >> 0x10))
                {
                    case 0:
                        goto Label_03AA;

                    case 1:
                        ÂÔç(enumerator);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x27];
                        goto Label_03B6;
                }
                goto Label_0474;
            }
            return str;
        }

        public static int GetRank(int cheatid)
        {
            // This item is obfuscated and can not be translated.
            int num;
            int num5;
            uint num2 = 0x2a76d278;
            object obj1 = f?sÓ ("ISO-8859-1");
            string str = SerializationObjectManager.TypeBuilderInstantiation.KeyNotFoundException(SerializationObjectManager.Variant.SoapQName(obj1, SerializationObjectManager.ConsoleColor.MemoryStream(obj1, 
úÊ(cheatid, "rank"))), "?", "");
            if (°qX¬ï(str, "VIP", false) != 0)
            {
                goto Label_016D;
            }
        Label_0058:
            num5 = 0x27d92b65;
        Label_0064:;
            int num6 = -262972681;
            int num4 = 0x4d2;
            switch (((((~(~num6 - -((0x6bbffcff - -1193782024) - 0x677ceb17)) - (-716387250 + -1146223705)) * 0x1de88b37) + num5) % 6))
            {
                case 0:
                    goto Label_0143;

                case 1:
                    num = 1;
                    num5 = (int) (num2 ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                    goto Label_0064;

                case 2:
                    goto Label_016D;

                case 3:
                    goto Label_0058;

                case 4:
                    goto Label_0270;
            }
            goto Label_02A3;
            num5 = 0x67eb2120;
            goto Label_0064;
            num4 = 0x4d2;
            num4 = 0x4d2;
            num5 = 0x2d0d79d9;
            goto Label_0064;
            num = 2;
            num5 = (int) (num2 ^ InternalSerializerTypeE.SoapOption);
            goto Label_0064;
        }

        public static void nSaveHWID()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x4dbe3f03;
            HttpWebResponse response = (HttpWebResponse) ctü((HttpWebRequest) ûz±(îò¾a("http://82.208.17.176/Loader/savehwid.php?hwid=",  }k÷(), "&nick=", Shit.My.MyProject.Forms.Login.CrystalClearTextBox1.Text)));
        Label_0057:
            num4 = -1173517252;
        Label_0063:;
            int num5 = 0x4cd712ae;
            int num3 = 0x4d2;
            switch ((((~(~num5 * 0x22138f63) + ~0x2591cf8e) + num4) % 4))
            {
                case 1:
                {
                    string text1 = Øãa(¡vö({Ôú(response)));
                    if (SerializationObjectManager.ArgumentOutOfRangeException.LifetimeEntry(text1, "ERROR"))
                    {
                        *CONSOLESCREENBUFFERINFO[0x36]("Error when saving HWID !", 0, null);
                        ¢ä°{();
                    }
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = -170223466;
                    goto Label_0063;
                }
                case 2:
                    goto Label_0057;

                case 3:
                    goto Label_01F1;
            }
            goto Label_022D;
            ±/<b«();
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0063;
        }

        public static bool strValid(string input)
        {
            // This item is obfuscated and can not be translated.
            bool flag;
            int num4;
            object obj1 = f?sÓ ("ISO-8859-1");
            if (*?() <= 0)
            {
                goto Label_0153;
            }
        Label_0046:
            num4 = -2057832310;
        Label_0052:;
            int num5 = 0x7da40e6d;
            switch (((~(((-num5 - ~(-1308215163 - ~0x6920601)) + ((0x7d7d468 * -213432917) + -938192127)) ^ -2011655139) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0046;

                case 1:
                    goto Label_012B;

                case 3:
                    goto Label_0153;

                case 4:
                    flag = true;
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x2a];
                    goto Label_0052;
            }
            goto Label_017F;
            num4 = 0x3a29c4bb;
            goto Label_0052;
            flag = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x2c];
            goto Label_0052;
        }
    }
}

