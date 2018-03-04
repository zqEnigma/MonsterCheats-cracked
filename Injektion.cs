namespace Shit
{
    using InjectionLibrary;
    using JLibrary.PortableExecutable;
    using Microsoft.VisualBasic.CompilerServices;
    using SerializationObjectManager;
    using Shit.My;
    using System;
    using System.Net;
    using System.Security.Cryptography;
    using System.Text;

    [StandardModule]
    internal sealed class Injektion
    {
        public static int allowtrial = 0;
        private static TripleDESCryptoServiceProvider TripleDes = ((TripleDESCryptoServiceProvider) íèù());

        public static bool CheckHash(string firsthash, string nexthash)
        {
            // This item is obfuscated and can not be translated.
            StringBuilder builder;
            int num8;
            uint num5 = 0x486217e9;
            ASCIIEncoding encoding = (ASCIIEncoding) !Ý©ù¤();
            object obj1 = ºá();
            byte[] buffer = SerializationObjectManager.IRegistrationServices.BinaryObject(obj1, =¿Óù(encoding, firsthash));
            byte[] buffer2 = SerializationObjectManager.IRegistrationServices.BinaryObject(obj1, =¿Óù(encoding, nexthash));
        Label_0041:
            num8 = 0x5e5dcaee;
        Label_004D:;
            int num9 = 0x33a81697;
            int num7 = 0x4d2;
            switch (((-(-(num9 * -1315448157) - (~-95682263 + -0x255ac1e9)) + num8) >> 0x10))
            {
                case 0:
                    goto Label_01EC;

                case 1:
                    goto Label_0531;

                case 2:
                    goto Label_0375;

                case 3:
                    goto Label_01A7;

                case 4:
                    goto Label_03AD;

                case 5:
                    goto Label_0041;

                case 7:
                    goto Label_043B;

                case 8:
                    goto Label_03D9;

                case 9:
                    goto Label_0247;

                case 10:
                    goto Label_06AB;

                case 11:
                    builder = (StringBuilder) @@­(buffer.Length * 2);
                    num8 = (int) (num5 ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                    goto Label_004D;

                case 12:
                    goto Label_0566;

                case 13:
                    goto Label_06D7;

                case 14:
                    goto Label_027E;
            }
            goto Label_0704;
            StringBuilder builder2 = (StringBuilder) @@­(buffer2.Length * 2);
            int num3 = buffer.Length - 1;
            int index = 0;
            num8 = 0x5841f59;
            goto Label_004D;
            íRØÊ(builder, EJô(ý^¤)("0", &ÚsX(buffer[index])), 2));
            num8 = (int) (num5 ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_004D;
            index++;
            num8 = (int) (num5 ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_004D;
            num7 = 0x4d2;
            num7 = 0x4d2;
            num8 = 0x251dd462;
            goto Label_004D;
            int num4 = buffer2.Length - 1;
            num8 = (int) (num5 ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_004D;
            int num2 = 0;
            num8 = 0x5a347154;
            goto Label_004D;
            íRØÊ(builder2, EJô(ý^¤)("0", &ÚsX(buffer2[num2])), 2));
            num2++;
            num8 = (int) Shit.My.MyApplication.StringSplitOptions[60];
            goto Label_004D;
            num7 = 0x4d2;
            num7 = 0x4d2;
            num8 = 0x59f7c5c6;
            goto Label_004D;
            bool flag = false;
            num8 = (int) Shit.My.MyApplication.StringSplitOptions[0x3d];
            goto Label_004D;
            num7 = 0x4d2;
            num7 = 0x4d2;
            num7 = 0x4d2;
            num7 = 0x4d2;
            num8 = 0xf9031e6;
            goto Label_004D;
            flag = true;
            num8 = 0x22f2dafd;
            goto Label_004D;
            flag = false;
            num8 = (int) Shit.My.MyApplication.StringSplitOptions[0x3f];
            goto Label_004D;
        }

        public static string ConvertDateToHash(DateTime datumm)
        {
            // This item is obfuscated and can not be translated.
            StringBuilder builder;
            int num6;
            uint num3 = 0xa74680a6;
            ASCIIEncoding encoding = (ASCIIEncoding) !Ý©ù¤();
            byte[] buffer = Á#¾Æ(ºá(), =¿Óù(encoding, TÏnB(datumm)));
        Label_003D:
            num6 = 0x3ce9f07d;
        Label_0049:;
            int num7 = -1473689294;
            int num5 = 0x4d2;
            switch (((~~(((((((0x5ec7be3b + -1982088125) + (0x3d304baf - -1298234644)) + ((-344951103 ^ 0x22e99c1b) ^ (-119787166 + -1182209359))) + (~--439898223 - -0x4a13563c)) - num7) ^ (((-2025556943 * 0x10966a10) - -0x14bfb249) * 0x6d94441)) * 0x41fbeaa9) + num6) % 8))
            {
                case 0:
                    goto Label_01D8;

                case 1:
                    goto Label_0175;

                case 2:
                    builder = (StringBuilder) @@­(buffer.Length * 2);
                    num6 = (int) (num3 ^ InternalSerializerTypeE.IContextPropertyActivator);
                    goto Label_0049;

                case 4:
                    goto Label_026A;

                case 5:
                    goto Label_0231;

                case 6:
                    goto Label_01AD;

                case 7:
                    goto Label_003D;
            }
            goto Label_0361;
            int num2 = buffer.Length - 1;
            num6 = (int) (num3 ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0049;
            int index = 0;
            num6 = 0x62375cf;
            goto Label_0049;
            íRØÊ(builder, EJô(ý^¤)("0", &ÚsX(buffer[index])), 2));
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x44];
            goto Label_0049;
            index++;
            num6 = (int) (num3 ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0049;
            num5 = 0x4d2;
            num5 = 0x4d2;
            num6 = -345613787;
            goto Label_0049;
        }

        public static string ConvertToHash(string data)
        {
            // This item is obfuscated and can not be translated.
            StringBuilder builder;
            int num;
            int num6;
            ASCIIEncoding encoding = (ASCIIEncoding) !Ý©ù¤();
            byte[] buffer = Á#¾Æ(ºá(), =¿Óù(encoding, data));
        Label_0033:
            num6 = -1679914882;
        Label_003F:;
            int num7 = -704708876;
            int num5 = 0x4d2;
            switch (((((((~num7 * 0x5098594d) * 0x33cca259) ^ (0x14672c95 * -1767889812)) + -154079017) + num6) >> 0x10))
            {
                case 0:
                    goto Label_0159;

                case 1:
                {
                    builder = (StringBuilder) @@­(buffer.Length * 2);
                    int num2 = buffer.Length - 1;
                    num = 0;
                    num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x40];
                    goto Label_003F;
                }
                case 2:
                    goto Label_0033;

                case 3:
                    goto Label_0130;

                case 4:
                    goto Label_01B7;
            }
            goto Label_02B0;
            num6 = 0x36f041a4;
            goto Label_003F;
            íRØÊ(builder, EJô(ý^¤)("0", &ÚsX(buffer[num])), 2));
            num++;
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x42];
            goto Label_003F;
            num5 = 0x4d2;
            num5 = 0x4d2;
            num6 = 0x54e57076;
            goto Label_003F;
        }

        public static string GetData(int chid, string show)
        {
            HttpWebResponse response = (HttpWebResponse) ctü((HttpWebRequest) ûz±(îò¾a("http://82.208.17.176/Loader/getcheatplz82.php?cheat_id=", ¦VZÏ2(chid), "&show=", show)));
            return Øãa(¡vö({Ôú(response)));
        }

        public static void InjectDll(int chid)
        {
            // This item is obfuscated and can not be translated.
            IntPtr zero;
            byte[] buffer2;
            string str2;
            uint num3;
            int num5;
            WebClient client = (WebClient) eÐm();
            InjectionMethod method = (InjectionMethod) {Q$ö¹(InjectionMethodType.ManualMap);
        Label_001E:
            num5 = 0x2b069ef0;
        Label_002A:;
            int num6 = -875745938;
            int num4 = 0x4d2;
            switch (((num3 = (uint) (~(-(-num6 * 0x24fabdf1) ^ (0x37d57bef * -953805649)) + num5)) >> 0x10))
            {
                case 0:
                    goto Label_001E;

                case 1:
                {
                    zero = IntPtr.Zero;
                    object obj1 = f?sÓ ("ISO-8859-1");
                    byte[] buffer = SerializationObjectManager.ConsoleColor.MemoryStream(obj1, 
úÊ(chid, "link"));
                    string str = SerializationObjectManager.TypeBuilderInstantiation.KeyNotFoundException(SerializationObjectManager.Variant.SoapQName(obj1, buffer), "?", "");
                    buffer2 = d}Â(client, str);
                    str2 = SerializationObjectManager.TypeBuilderInstantiation.KeyNotFoundException(SerializationObjectManager.Variant.SoapQName(obj1, SerializationObjectManager.ConsoleColor.MemoryStream(obj1, 
úÊ(chid, "process"))), "?", "");
                    num5 = (int) Shit.My.MyApplication.StringSplitOptions[0x47];
                    goto Label_002A;
                }
                case 2:
                    goto Label_0145;

                case 3:
                    goto Label_0190;

                default:
                {
                    goto Label_0190;
                    qÅ(Shit.My.MyProject.Forms.Form1, str2);
                    num5 = (int) Shit.My.MyApplication.StringSplitOptions[0x48];
                    goto Label_002A;
                    int num = (int) *?();
                    JLibrary.PortableExecutable.PortableExecutable executable = (JLibrary.PortableExecutable.PortableExecutable) ¯ì(buffer2);
                    try
                    {
                        zero = OqËä(method, executable, num);
                        goto Label_028E;
                    }
                    finally
                    {
                        if (executable == null)
                        {
                            goto Label_0286;
                        }
                    Label_01DD:
                        num5 = -2112286870;
                    Label_01E9:;
                        num6 = 0x10bcb388;
                        num4 = 0x4d2;
                        switch (((num3 = (uint) (~(-(-num6 * 0x24fabdf1) ^ (0x37d57bef * -953805649)) + num5)) >> 0x10))
                        {
                            case 0:
                                goto Label_01DD;

                            case 1:
                                ÂÔç(executable);
                                num5 = (int) Shit.My.MyApplication.StringSplitOptions[0x49];
                                goto Label_01E9;
                        }
                        goto Label_0286;
                    }
                    if (*CONSOLESCREENBUFFERINFO[0x41](zero, IntPtr.Zero) == IntPtr.Zero)
                    {
                        goto Label_0390;
                    }
                    break;
                }
            }
        Label_02A7:
            num5 = 0x728398e5;
        Label_02B3:;
            num6 = -1945033771;
            num4 = 0x4d2;
            switch (((num3 = (uint) (~(-(-num6 * 0x24fabdf1) ^ (0x37d57bef * -953805649)) + num5)) >> 0x10))
            {
                case 0:
                    goto Label_035E;

                case 2:
                    goto Label_02A7;

                case 3:
                    qÅ(Shit.My.MyProject.Forms.Form1, "Loaded ..");
                    num5 = (int) Shit.My.MyApplication.StringSplitOptions[0x4a];
                    goto Label_02B3;
            }
            goto Label_0390;
            qÅ(Shit.My.MyProject.Forms.Form1, ±Ôf¥Ý(method).Message);
        }

        public static bool isProtectedDateValid(string lastdatehashinstring)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            if (!8("Loader.exe"))
            {
                goto Label_0255;
            }
        Label_001A:
            num4 = -324033490;
        Label_0026:;
            int num5 = 0x70e7c472;
            int num3 = 0x4d2;
            switch (((~((-~-2011281681 - ((((-1760345033 ^ 0x726d7a45) ^ -0x648a3c8a) - (-486058922 * -311983529)) - ~num5)) - -0x7f804568) + num4) % 5))
            {
                case 0:
                    goto Label_001A;

                case 1:
                    goto Label_022D;

                case 2:
                    goto Label_0204;

                case 3:
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = -1157118590;
                    goto Label_0026;
            }
            goto Label_0255;
            bool flag = true;
            num4 = 0x2243c5fa;
            goto Label_0026;
            flag = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[70];
            goto Label_0026;
        }
    }
}

