namespace Shit
{
    using Microsoft.VisualBasic.CompilerServices;
    using Microsoft.Win32;
    using SerializationObjectManager;
    using Shit.My;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Management;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Unbanner : Form
    {
        private IContainer components;
        [CompilerGenerated, AccessedThroughProperty("NyX_Theme1")]
        private Shit.NYX_Theme _NyX_Theme1;
        [AccessedThroughProperty("NyX_ControlBox1"), CompilerGenerated]
        private Shit.NYX_ControlBox _NyX_ControlBox1;
        [CompilerGenerated, AccessedThroughProperty("Timer3")]
        private Timer _Timer3;
        [CompilerGenerated, AccessedThroughProperty("Timer2")]
        private Timer _Timer2;
        [CompilerGenerated, AccessedThroughProperty("FolderBrowserDialog1")]
        private FolderBrowserDialog _FolderBrowserDialog1;
        [CompilerGenerated, AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [CompilerGenerated, AccessedThroughProperty("NyX_GroupBox1")]
        private Shit.NYX_GroupBox _NyX_GroupBox1;
        [CompilerGenerated, AccessedThroughProperty("bt_update")]
        private Shit.NYX_Button _bt_update;
        [CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("combo_network"), CompilerGenerated]
        private ComboBox _combo_network;
        [AccessedThroughProperty("Label5"), CompilerGenerated]
        private Label _Label5;
        [CompilerGenerated, AccessedThroughProperty("mac_text")]
        private Shit.CrystalClearTextBox _mac_text;
        [AccessedThroughProperty("Label1"), CompilerGenerated]
        private Label _Label1;

        public Unbanner()
        {
            *?(new EventHandler(this.Unbanner_Load));
            BÚ2m²(this);
        }

        private void combo_network_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mac_text.Text = cIx(this, ³5¥(*?()));
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                uint num;
                uint num2;
                int num4;
                int expressionStack_158_0;
                int expressionStack_158_1;
                if (!disposing)
                {
                    return;
                }
            Label_000C:
                num4 = 0x14e37ca4;
                int expressionStack_17_0 = 0x53a56fc0;
            Label_0017:;
                int num5 = expressionStack_17_0;
                int num3 = 0x4d2;
                switch (((num2 = (uint) ((-(((num5 ^ (((-1853589019 * -0x4d5e0c1c) - (-0x76510678 - (0x7a3fd695 ^ -1240209321))) + ~---798529840)) * -1047587671) ^ ~(0x37e3c45b ^ -1763678335)) + 0x66ac44dc) + num4)) >> 0x10))
                {
                    case 0:
                        goto Label_000C;

                    case 1:
                        return;

                    case 2:
                        ÂÔç(this.components);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x21d];
                        expressionStack_17_0 = (((int) num2) + 0x1a92b5f1) ^ -594983613;
                        goto Label_0017;

                    case 3:
                        if (this.components == null)
                        {
                            break;
                        }
                        num3 = 0x4d2;
                        expressionStack_158_1 = 0x5c572b49;
                        goto Label_0158;

                    default:
                        return;
                }
                expressionStack_158_1 = 0x6dfc2b49;
            Label_0158:
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1553470923;
                expressionStack_17_0 = expressionStack_158_1 ^ ((int) (num2 * 0x419fc547));
                goto Label_0017;
            }
            finally
            {
                VÛ(this, disposing);
            }
        }

        private string DoPadding(string x)
        {
            // This item is obfuscated and can not be translated.
            int num6;
            uint num3 = 0xe6b4b54b;
            string str = x;
        Label_0008:
            num6 = -1666596529;
        Label_0014:;
            int num7 = 0x4094d8b5;
            int num5 = 0x4d2;
            switch (((~((-num7 - --(0x402c2d27 * -1483371293)) + (--203042653 - ~-1716533190)) + num6) >> 0x10))
            {
                case 0:
                    goto Label_0008;

                case 1:
                    goto Label_01F5;

                case 2:
                    goto Label_0262;

                case 3:
                    goto Label_02D7;

                case 4:
                    goto Label_029B;

                case 5:
                    num5 = 0x4d2;
                    num5 = 0x4d2;
                    num5 = 0x4d2;
                    num5 = 0x4d2;
                    num6 = -131621026;
                    goto Label_0014;

                case 6:
                    goto Label_0237;
            }
            goto Label_03CD;
            int num2 = 4 - Ì'ÃÐu(x);
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x24f];
            goto Label_0014;
            int num = 1;
            num6 = -178106741;
            goto Label_0014;
            str = ý^¤)("0", str);
            num6 = (int) (num3 ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0014;
            num++;
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x251];
            goto Label_0014;
            num5 = 0x4d2;
            num5 = 0x4d2;
            num6 = 0x1b74828b;
            goto Label_0014;
        }

        private void FillNetworkAdapters()
        {
            // This item is obfuscated and can not be translated.
            ManagementObjectCollection.ManagementObjectEnumerator enumerator;
            uint num2;
            int num3;
            int num4;
            int num5;
            ManagementObjectCollection objects = (ManagementObjectCollection) #¤1§(
»("Win32_NetworkAdapterConfiguration"));
            try
            {
                enumerator = (ManagementObjectCollection.ManagementObjectEnumerator) ªiîÍ(objects);
                goto Label_030A;
            Label_0032:
                num4 = -1387749627;
            Label_003E:;
                num5 = -1482862705;
                num3 = 0x4d2;
                switch (((num2 = (uint) ((-((((-0x8c23c35 - (0x2d06e27 * 0x2f6b20f)) * -1649871305) - ~num5) + -(0x499e9a83 * -1800379407)) * -1697687527) + num4)) % 7))
                {
                    case 0:
                        goto Label_0253;

                    case 2:
                    {
                        ManagementObject obj2 = (ManagementObject) *?();
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x24b];
                        goto Label_003E;
                    }
                    case 3:
                        goto Label_02B6;

                    case 4:
                        goto Label_030A;

                    case 5:
                        goto Label_0032;

                    case 6:
                        goto Label_0109;
                }
                goto Label_040B;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x7d8b41cd;
                goto Label_003E;
                string str = cN²(³5¥(*?("Caption")), 11);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x24c];
                goto Label_003E;
                ¬2M ´(*?(), str);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x24d];
                goto Label_003E;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x1340cf1;
                goto Label_003E;
            }
            finally
            {
                if (enumerator == null)
                {
                    goto Label_04DD;
                }
            Label_041D:
                num4 = -216731297;
            Label_0429:;
                num5 = -556977768;
                num3 = 0x4d2;
                switch (((num2 = (uint) ((-((((-0x8c23c35 - (0x2d06e27 * 0x2f6b20f)) * -1649871305) - ~num5) + -(0x499e9a83 * -1800379407)) * -1697687527) + num4)) % 3))
                {
                    case 0:
                        goto Label_041D;

                    case 1:
                        ÂÔç(enumerator);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[590];
                        goto Label_0429;
                }
                goto Label_04DD;
            }
        }

        private string GetMACAddress(string Adapter)
        {
            // This item is obfuscated and can not be translated.
            string str;
            ManagementObjectCollection.ManagementObjectEnumerator enumerator;
            uint num;
            uint num2;
            int num3;
            int num4;
            int num5;
            ManagementObjectCollection objects = (ManagementObjectCollection) #¤1§(
»("Win32_NetworkAdapterConfiguration"));
            try
            {
                num = 0xd560014b;
                enumerator = (ManagementObjectCollection.ManagementObjectEnumerator) ªiîÍ(objects);
            Label_002D:
                num4 = -1655661706;
            Label_0039:;
                num5 = -1475240631;
                num3 = 0x4d2;
                switch (((num2 = (uint) ((0x6b31002 - ((-434514107 - ((num5 * 0x743589c3) - -0x297f60c9)) - (0x2dfbac2 - -671429973))) + num4)) % 9))
                {
                    case 0:
                        goto Label_0159;

                    case 1:
                        goto Label_03FF;

                    case 2:
                        num4 = 0x10476682;
                        goto Label_0039;

                    case 3:
                        goto Label_002D;

                    case 4:
                        goto Label_0453;

                    case 5:
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = -1103502158;
                        goto Label_0039;

                    case 6:
                        goto Label_02A3;

                    case 8:
                        goto Label_011B;
                }
                goto Label_0586;
                ManagementObject obj2 = (ManagementObject) *?();
                num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                goto Label_0039;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -379797922;
                goto Label_0039;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x2ae5a9b2;
                goto Label_0039;
                str = ³5¥(*?("MacAddress"));
                num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                goto Label_0039;
            }
            finally
            {
                num = 0xd560014b;
                if (enumerator == null)
                {
                    goto Label_064C;
                }
            Label_0598:
                num4 = 0x6a948a24;
            Label_05A4:;
                num5 = 0x2ae8afd5;
                num3 = 0x4d2;
                switch (((num2 = (uint) ((0x6b31002 - ((-434514107 - ((num5 * 0x743589c3) - -0x297f60c9)) - (0x2dfbac2 - -671429973))) + num4)) >> 0x10))
                {
                    case 0:
                        goto Label_0598;

                    case 2:
                        ÂÔç(enumerator);
                        num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                        goto Label_05A4;
                }
                goto Label_064C;
            }
            return str;
        }

        private string GetRoot(string Adapter)
        {
            string str;
            string str2;
            string str3;
            uint num3;
            int num5;
            uint num2 = 0x4f2d4ddf;
            int num = 0;
        Label_0009:
            num5 = -1975647573;
            int expressionStack_15_0 = -31136971;
        Label_0015:;
            int num6 = expressionStack_15_0;
            int num4 = 0x4d2;
            switch (((num3 = (uint) (~(num6 - (-((-1905716905 * 0x6c20b765) ^ (0x16d57e ^ 0x33449c91)) + (-1797518230 ^ ((0x411cf121 ^ -466661840) - --1346596271)))) + num5)) % 4))
            {
                case 0:
                    goto Label_0009;

                case 1:
                    break;

                case 2:
                    str3 = üRæ¬(this, ¦VZÏ2(num));
                    num5 = (int) Shit.My.MyApplication.StringSplitOptions[0x260];
                    expressionStack_15_0 = ((int) (num3 << -1605966507)) ^ -1727946664;
                    goto Label_0015;

                default:
                {
                    RegistryKey key = (RegistryKey) ³¾Vö(Registry.LocalMachine, ý^¤)(str2, str3), true);
                    try
                    {
                        num2 = 0x4f2d4ddf;
                        if (°qX¬ï(³5¥(¨~öf(key, "DriverDesc")), Adapter, false) != 0)
                        {
                            goto Label_0244;
                        }
                    Label_015D:
                        num5 = 0x567d961;
                        num6 = -1431833428;
                        num4 = 0x4d2;
                        switch (((num3 = (uint) (~(num6 - (-((-1905716905 * 0x6c20b765) ^ (0x16d57e ^ 0x33449c91)) + (-1797518230 ^ ((0x411cf121 ^ -466661840) - --1346596271)))) + num5)) >> 0x10))
                        {
                            case 0:
                                goto Label_015D;

                            case 1:
                                return ý^¤)(str2, str3);

                            case 2:
                                goto Label_0244;
                        }
                    }
                    catch (Exception exception2)
                    {
                        SerializationObjectManager.Object.StackFrameHelper(exception2);
                        ¯3U();
                        return str;
                    }
                    goto Label_0244;
                }
            }
        Label_0092:
            str2 = @"SYSTEM\CurrentControlSet\Control\Class\{4D36E972-E325-11CE-BFC1-08002BE10318}\";
            num5 = (int) (num2 ^ InternalSerializerTypeE.SoapOption);
            expressionStack_15_0 = (int) Shit.My.MyApplication.StringSplitOptions[0x25f];
            goto Label_0015;
        Label_0244:
            num++;
        Label_0248:
            num5 = 0x3931cbd6;
            num6 = -1364078048;
            num4 = 0x4d2;
            switch (((num3 = (uint) (~(num6 - (-((-1905716905 * 0x6c20b765) ^ (0x16d57e ^ 0x33449c91)) + (-1797518230 ^ ((0x411cf121 ^ -466661840) - --1346596271)))) + num5)) % 3))
            {
                case 0:
                    goto Label_0248;

                case 1:
                    goto Label_0092;

                case 2:
                    return str;
            }
            return str;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x3b79221d;
            this.components = (IContainer) À%Ã±();
            ComponentResourceManager manager = (ComponentResourceManager) bä(>+Zí(typeof(Shit.Unbanner).TypeHandle));
        Label_0030:
            num4 = 0x1d726c72;
        Label_003C:;
            int num5 = 0x3658ff16;
            switch (((-(-((num5 * 0x4847b43b) - --(-1627140878 ^ -425225444)) ^ -1011955642) + num4) % 0x49))
            {
                case 0:
                    goto Label_0B2D;

                case 1:
                    goto Label_0BB6;

                case 2:
                    goto Label_0E9B;

                case 3:
                    goto Label_18C1;

                case 4:
                    goto Label_1446;

                case 5:
                    goto Label_05BD;

                case 6:
                    goto Label_110C;

                case 7:
                    goto Label_0C02;

                case 8:
                    goto Label_0CE0;

                case 9:
                    goto Label_0B7C;

                case 10:
                    goto Label_11DA;

                case 11:
                    goto Label_15DF;

                case 12:
                    goto Label_03E9;

                case 13:
                    goto Label_066D;

                case 14:
                    goto Label_190D;

                case 15:
                    goto Label_03B0;

                case 0x10:
                    goto Label_1489;

                case 0x11:
                    goto Label_158F;

                case 0x12:
                    goto Label_1887;

                case 0x13:
                    goto Label_036E;

                case 20:
                    goto Label_10C4;

                case 0x15:
                    goto Label_1196;

                case 0x16:
                    goto Label_1085;

                case 0x17:
                    goto Label_179E;

                case 0x18:
                    goto Label_0AF3;

                case 0x19:
                    goto Label_1043;

                case 0x1a:
                    goto Label_199F;

                case 0x1b:
                    goto Label_1228;

                case 0x1c:
                    goto Label_0F4E;

                case 0x1d:
                    goto Label_194F;

                case 30:
                    goto Label_1841;

                case 0x1f:
                    goto Label_175F;

                case 0x21:
                    goto Label_0AA1;

                case 0x22:
                    goto Label_032C;

                case 0x23:
                    goto Label_0C9E;

                case 0x24:
                    goto Label_0616;

                case 0x25:
                    goto Label_0030;

                case 0x26:
                    goto Label_16CA;

                case 0x27:
                    goto Label_114F;

                case 40:
                    this.NyX_Theme1 = (Shit.NYX_Theme) ä{Ãdâ();
                    this.Label2 = (Label) aÞCM2();
                    this.NyX_GroupBox1 = (Shit.NYX_GroupBox) ØúUÀø();
                    this.Label1 = (Label) aÞCM2();
                    this.mac_text = (Shit.CrystalClearTextBox) ÷R°á();
                    this.combo_network = (ComboBox) £©L/¹();
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x21e];
                    goto Label_003C;

                case 0x29:
                    goto Label_06CA;

                case 0x2a:
                    goto Label_0287;

                case 0x2b:
                    goto Label_13DE;

                case 0x2c:
                    goto Label_0E59;

                case 0x2d:
                    goto Label_134B;

                case 0x2e:
                    goto Label_0445;

                case 0x2f:
                    goto Label_08F8;

                case 0x30:
                    goto Label_12A9;

                case 0x31:
                    goto Label_1628;

                case 50:
                    goto Label_1688;

                case 0x33:
                    goto Label_0543;

                case 0x34:
                    goto Label_0DF4;

                case 0x35:
                    goto Label_139A;

                case 0x36:
                    goto Label_0758;

                case 0x37:
                    goto Label_085F;

                case 0x38:
                    goto Label_07FB;

                case 0x39:
                    goto Label_1538;

                case 0x3a:
                    goto Label_0248;

                case 0x3b:
                    goto Label_0936;

                case 60:
                    goto Label_0704;

                case 0x3d:
                    goto Label_0FBC;

                case 0x3e:
                    goto Label_1AA3;

                case 0x3f:
                    goto Label_049B;

                case 0x40:
                    goto Label_04ED;

                case 0x41:
                    goto Label_1001;

                case 0x42:
                    goto Label_14DA;

                case 0x43:
                    goto Label_1A38;

                case 0x44:
                    goto Label_079B;

                case 0x45:
                    goto Label_1803;

                case 70:
                    goto Label_0A63;

                case 0x47:
                    goto Label_0970;

                case 0x48:
                    goto Label_0D2E;
            }
            goto Label_1B06;
            this.Label5 = (Label) aÞCM2();
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_003C;
            this.bt_update = (Shit.NYX_Button) K7Dá();
            this.NyX_ControlBox1 = (Shit.NYX_ControlBox) °9O();
            this.Timer3 = (Timer) ¾6ÊÜ(this.components);
            this.Timer2 = (Timer) ¾6ÊÜ(this.components);
            this.FolderBrowserDialog1 = (FolderBrowserDialog) ¿úZ();
            this.Timer1 = (Timer) ¾6ÊÜ(this.components);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x21f];
            goto Label_003C;
            CÕ(this.NyX_Theme1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x220];
            goto Label_003C;
            CÕ(this.NyX_GroupBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x221];
            goto Label_003C;
            =µ§­(this);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_003C;
            this.NyX_Theme1.Animated = true;
            this.NyX_Theme1.BorderStyle = FormBorderStyle.None;
            this.NyX_Theme1.Colors = new Shit.Bloom[0];
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x222];
            goto Label_003C;
            yã\B(*?(), this.Label2);
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_003C;
            yã\B(*?(), this.NyX_GroupBox1);
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_003C;
            yã\B(*?(), this.NyX_ControlBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x223];
            goto Label_003C;
            this.NyX_Theme1.Customization = "";
            this.NyX_Theme1.Dock = DockStyle.Fill;
            this.NyX_Theme1.Font = (Font) ·)©ê("Arial", 9f);
            this.NyX_Theme1.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x224];
            goto Label_003C;
            *?(new Point(0, 0));
            this.NyX_Theme1.Movable = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x225];
            goto Label_003C;
            *?("NyX_Theme1");
            this.NyX_Theme1.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[550];
            goto Label_003C;
            this.NyX_Theme1.Sizable = true;
            *?(new Size(550, 230));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_003C;
            this.NyX_Theme1.SmartBounds = true;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_003C;
            this.NyX_Theme1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            *?(0);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x227];
            goto Label_003C;
            this.NyX_Theme1.Text = "Helper";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x228];
            goto Label_003C;
            this.NyX_Theme1.TransparencyKey = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x23]();
            this.NyX_Theme1.Transparent = false;
            this.Label2.AutoSize = true;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_003C;
            this.Label2.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            this.Label2.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x229];
            goto Label_003C;
            *?(new Point(13, 0xc5));
            *?("Label2");
            *?(new Size(0, 15));
            *?(0x25);
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_003C;
            this.NyX_GroupBox1.Animated = true;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_003C;
            this.NyX_GroupBox1.BorderStyle = FormBorderStyle.None;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_003C;
            this.NyX_GroupBox1.Colors = new Shit.Bloom[0];
            yã\B(*?(), this.Label1);
            yã\B(*?(), this.mac_text);
            yã\B(*?(), this.combo_network);
            yã\B(*?(), this.Label5);
            yã\B(*?(), this.bt_update);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_003C;
            this.NyX_GroupBox1.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_003C;
            this.NyX_GroupBox1.Font = (Font) ·)©ê("Arial", 9f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x22a];
            goto Label_003C;
            this.NyX_GroupBox1.Image = null;
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_003C;
            *?(new Point(15, 0x27));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x22b];
            goto Label_003C;
            this.NyX_GroupBox1.Movable = true;
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_003C;
            *?("NyX_GroupBox1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x22c];
            goto Label_003C;
            this.NyX_GroupBox1.NoRounding = false;
            this.NyX_GroupBox1.Sizable = true;
            *?(new Size(0x20b, 0x94));
            this.NyX_GroupBox1.SmartBounds = true;
            this.NyX_GroupBox1.StartPosition = FormStartPosition.Manual;
            *?(0x20);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x22d];
            goto Label_003C;
            this.NyX_GroupBox1.Text = "Mac Unbanner";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x22e];
            goto Label_003C;
            this.NyX_GroupBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.NyX_GroupBox1.Transparent = false;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_003C;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            this.Label1.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            *?(new Point(0x81, 0x61));
            *?("Label1");
            *?(new Size(0x23, 15));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x22f];
            goto Label_003C;
            *?(0x26);
            this.Label1.Text = "MAC:";
            this.mac_text.Colors = new Shit.Bloom[0];
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_003C;
            this.mac_text.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_003C;
            this.mac_text.Font = (Font) ·)©ê("Verdana", 8f);
            this.mac_text.Image = null;
            *?(new Point(170, 0x5d));
            this.mac_text.MaxLength = 0x7fff;
            this.mac_text.Multiline = false;
            *?("mac_text");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[560];
            goto Label_003C;
            this.mac_text.NoRounding = false;
            this.mac_text.ReadOnly = false;
            *?(new Size(0xd9, 0x18));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x231];
            goto Label_003C;
            *?(0x25);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_003C;
            this.mac_text.TextAlign = HorizontalAlignment.Left;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x232];
            goto Label_003C;
            this.mac_text.Transparent = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x233];
            goto Label_003C;
            this.mac_text.UseSystemPasswordChar = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x234];
            goto Label_003C;
            this.combo_network.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x60]();
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_003C;
            *?(0);
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_003C;
            this.combo_network.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_003C;
            *?(1);
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_003C;
            *?(new Point(170, 0x30));
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_003C;
            *?("combo_network");
            *?(new Size(340, 0x17));
            *?(0x24);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x235];
            goto Label_003C;
            this.Label5.AutoSize = true;
            this.Label5.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            this.Label5.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            *?(new Point(0x1c, 0x33));
            *?("Label5");
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_003C;
            *?(new Size(0x88, 15));
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_003C;
            *?(0x23);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_003C;
            this.Label5.Text = "Select Network Adapter:";
            this.bt_update.Colors = new Shit.Bloom[0];
            this.bt_update.Cursor = (Cursor) *CONSOLESCREENBUFFERINFO[0x5c]();
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_003C;
            this.bt_update.Customization = "";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x236];
            goto Label_003C;
            this.bt_update.Font = (Font) ·)©ê("Arial", 8f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x237];
            goto Label_003C;
            this.bt_update.Image = null;
            *?(new Point(0x19e, 0x60));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x238];
            goto Label_003C;
            *?("bt_update");
            this.bt_update.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x239];
            goto Label_003C;
            *?(new Size(0x5b, 20));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[570];
            goto Label_003C;
            *?(0x1b);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x23b];
            goto Label_003C;
            this.bt_update.Text = "Change MAC";
            this.bt_update.Transparent = false;
            this.NyX_ControlBox1.Colors = new Shit.Bloom[0];
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x23c];
            goto Label_003C;
            this.NyX_ControlBox1.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_003C;
            this.NyX_ControlBox1.Font = (Font) ·)©ê("Verdana", 8f);
            this.NyX_ControlBox1.Image = null;
            *?(new Point(0x1eb, 3));
            *?("NyX_ControlBox1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x23d];
            goto Label_003C;
            this.NyX_ControlBox1.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x23e];
            goto Label_003C;
            *?(new Size(0x2f, 20));
            *?(7);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x23f];
            goto Label_003C;
            this.NyX_ControlBox1.Text = "NyX_ControlBox1";
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_003C;
            this.NyX_ControlBox1.Transparent = false;
            this.Timer3.Enabled = true;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_003C;
            this.Timer1.Enabled = true;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_003C;
            *?(new SizeF(6f, 13f));
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_003C;
            *?(1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x240];
            goto Label_003C;
            *?(new Size(550, 230));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x241];
            goto Label_003C;
            yã\B(*?(), this.NyX_Theme1);
            *?(0);
            *?((Icon) ]l¶+(manager, "$this.Icon"));
            *?("Unbanner");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x242];
            goto Label_003C;
            this.Text = "Settings";
            *?(*CONSOLESCREENBUFFERINFO[0x23]());
            4Ü'Ô(this.NyX_Theme1, false);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x243];
            goto Label_003C;
            òS4É:(this.NyX_Theme1);
            4Ü'Ô(this.NyX_GroupBox1, false);
            òS4É:(this.NyX_GroupBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[580];
            goto Label_003C;
            ©`Vñ(this, false);
        }

        private bool IsHex(string l)
        {
            // This item is obfuscated and can not be translated.
            int num;
            int num6;
            uint num3 = 0x1e65f211;
        Label_000D:
            num6 = 0x704b8f67;
        Label_0019:;
            int num7 = -1040439184;
            int num5 = 0x4d2;
            switch (((-((((num7 * 0x5a513411) + -1405018560) ^ ((0x4d090a7 + 0x2f13f891) - (0x6035acd1 * -1963825966))) * 0x595cf23) + num6) % 8))
            {
                case 0:
                    goto Label_0392;

                case 1:
                    goto Label_0243;

                case 2:
                    goto Label_026E;

                case 3:
                    goto Label_0138;

                case 4:
                    goto Label_029E;

                case 5:
                {
                    int num2 = ((int) *?()) - 1;
                    num = 0;
                    num6 = -117780235;
                    goto Label_0019;
                }
                case 6:
                    goto Label_000D;
            }
            goto Label_03C5;
            num5 = 0x4d2;
            num5 = 0x4d2;
            num6 = -39909093;
            goto Label_0019;
            bool flag = true;
            num6 = 0x7ba58629;
            goto Label_0019;
            num++;
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x254];
            goto Label_0019;
            num5 = 0x4d2;
            num5 = 0x4d2;
            num6 = -244206862;
            goto Label_0019;
            flag = false;
            num6 = (int) (num3 ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0019;
        }

        private bool IsOkay()
        {
            bool flag;
            string str;
            int num2;
            uint num4;
            int num6;
            int expressionStack_25B_0;
            int expressionStack_25B_1;
            int expressionStack_3CF_0;
            int expressionStack_91E_0;
            int expressionStack_91E_1;
            int expressionStack_63C_0;
            int expressionStack_7B6_0;
            int expressionStack_7B6_1;
            int expressionStack_52B_0;
            uint num3 = 0x2418c1;
            if (°qX¬ï(this.mac_text.Text, "", false) != 0)
            {
                goto Label_0141;
            }
        Label_0027:
            num6 = 0x3562d829;
            uint expressionStack_33_0 = 0x764b2121;
        Label_0033:;
            int num7 = (int) expressionStack_33_0;
            int num5 = 0x4d2;
            switch (((num4 = (uint) (((0xf3aa4f1 * ((-113719453 - -334192670) - (-1807810744 - -2015422548))) - ~num7) + num6)) % 9))
            {
                case 0:
                    if (*?() == 12)
                    {
                        expressionStack_25B_1 = -133147997;
                    }
                    else
                    {
                        num5 = 0x4d2;
                        expressionStack_25B_1 = 0x63c58cfd;
                    }
                    num5 = 0x4d2;
                    num5 = 0x4d2;
                    num5 = 0x4d2;
                    num5 = 0x4d2;
                    num6 = -230760978;
                    expressionStack_33_0 = ((uint) expressionStack_25B_1) ^ (num4 * 0x3cf2d1c5);
                    goto Label_0033;

                case 1:
                    *CONSOLESCREENBUFFERINFO[0x36]("You didn't enter a MAC Address", 0x10, null);
                    num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x255];
                    expressionStack_33_0 = (num4 << -321173247) ^ 0xcb0aa455;
                    goto Label_0033;

                case 2:
                    return flag;

                case 3:
                    goto Label_0027;

                case 4:
                    break;

                case 6:
                    flag = false;
                    num6 = (int) Shit.My.MyApplication.StringSplitOptions[600];
                    expressionStack_33_0 = (num4 + 0x106ddaa1) ^ 0x4370b367;
                    goto Label_0033;

                case 7:
                    *CONSOLESCREENBUFFERINFO[0x36]("A MAC Address must have a length of 12", 0x10, null);
                    num6 = (int) (num3 ^ InternalSerializerTypeE.FormatterConverter);
                    expressionStack_33_0 = (num4 << -1941569359) ^ 0x4c695eab;
                    goto Label_0033;

                case 8:
                    return false;

                default:
                    try
                    {
                        num3 = 0x2418c1;
                        if (°qX¬ï(³5¥(*?()), "", false) != 0)
                        {
                            goto Label_0617;
                        }
                    Label_03C3:
                        num6 = -281705817;
                        expressionStack_3CF_0 = -1170562365;
                    Label_03CF:;
                        num7 = expressionStack_3CF_0;
                        num5 = 0x4d2;
                        switch (((num4 = (uint) (((0xf3aa4f1 * ((-113719453 - -334192670) - (-1807810744 - -2015422548))) - ~num7) + num6)) >> 0x10))
                        {
                            case 0:
                                goto Label_03C3;

                            case 1:
                                *CONSOLESCREENBUFFERINFO[0x36]("No Network Adapter selected", 0x10, null);
                                num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x25a];
                                expressionStack_3CF_0 = ((int) (num4 >> 0x2888d3da)) ^ -488883047;
                                goto Label_03CF;

                            case 2:
                                return flag;

                            case 3:
                                goto Label_0617;

                            case 4:
                                flag = false;
                                num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x25b];
                                expressionStack_3CF_0 = (((int) num4) - -1616304979) ^ -2128544298;
                                goto Label_03CF;
                        }
                    }
                    catch (Exception exception1)
                    {
                        num3 = 0x2418c1;
                        SerializationObjectManager.Object.StackFrameHelper(exception1);
                        *CONSOLESCREENBUFFERINFO[0x36]("No Network Adapter selected", 0x10, null);
                    Label_051F:
                        num6 = -1540694723;
                        expressionStack_52B_0 = 0x546482d;
                    Label_052B:;
                        num7 = expressionStack_52B_0;
                        num5 = 0x4d2;
                        switch (((num4 = (uint) (((0xf3aa4f1 * ((-113719453 - -334192670) - (-1807810744 - -2015422548))) - ~num7) + num6)) >> 0x10))
                        {
                            case 0:
                                goto Label_051F;

                            case 1:
                                return flag;

                            case 2:
                                flag = false;
                                num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x25c];
                                expressionStack_52B_0 = (((int) num4) + -1343663145) ^ -955165198;
                                goto Label_052B;

                            case 3:
                                ¯3U();
                                num6 = (int) (num3 ^ InternalSerializerTypeE.IContextPropertyActivator);
                                expressionStack_52B_0 = ((int) (num4 << -1164838925)) ^ 0x6823af73;
                                goto Label_052B;
                        }
                        return flag;
                    }
                    goto Label_0617;
            }
        Label_0141:
            str = R©ÿ~(this.mac_text.Text, ":", "");
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x257];
            expressionStack_33_0 = Shit.My.MyApplication.StringSplitOptions[0x256];
            goto Label_0033;
        Label_0617:
            num2 = ((int) *?()) - 1;
            int num = 0;
        Label_0860:;
            if (num > num2)
            {
                num5 = 0x4d2;
                expressionStack_91E_1 = 0x473de7b7;
            }
            else
            {
                expressionStack_91E_1 = 0x4741e7b7;
            }
            num5 = 0x4d2;
            num5 = 0x4d2;
            num6 = 0x62313db3;
            expressionStack_63C_0 = expressionStack_91E_1;
        Label_063C:;
            num7 = expressionStack_63C_0;
            num5 = 0x4d2;
            switch (((num4 = (uint) (((0xf3aa4f1 * ((-113719453 - -334192670) - (-1807810744 - -2015422548))) - ~num7) + num6)) >> 0x10))
            {
                case 0:
                    flag = true;
                    num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x25e];
                    expressionStack_63C_0 = (((int) num4) + 0x37085be6) ^ 0xb00b6a2;
                    goto Label_063C;

                case 1:
                    goto Label_0860;

                case 2:
                    return flag;

                case 3:
                    num6 = -11150404;
                    expressionStack_63C_0 = -1440921170;
                    goto Label_063C;

                case 4:
                    if (!«×'j(this, N¨øÌB(str, num, 1)))
                    {
                        expressionStack_7B6_1 = -1427702504;
                        break;
                    }
                    num5 = 0x4d2;
                    expressionStack_7B6_1 = -1427636968;
                    break;

                case 5:
                    *CONSOLESCREENBUFFERINFO[0x36]("MAC Address in wrong format", 0x10, null);
                    flag = false;
                    num6 = -93710043;
                    expressionStack_63C_0 = ((int) (num4 * 0x2c842659)) ^ 0x10ba0c45;
                    goto Label_063C;

                case 6:
                    num++;
                    num6 = (int) (num3 ^ InternalSerializerTypeE.IContextPropertyActivator);
                    expressionStack_63C_0 = (int) Shit.My.MyApplication.StringSplitOptions[0x25d];
                    goto Label_063C;

                default:
                    return flag;
            }
            num5 = 0x4d2;
            num5 = 0x4d2;
            num6 = -24303534;
            expressionStack_63C_0 = expressionStack_7B6_1;
            goto Label_063C;
        }

        private void NyX_Button1_Click(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x4f1228ec;
            if (!­êÿ(this))
            {
                goto Label_0137;
            }
        Label_0016:
            num4 = 0x1ab40084;
        Label_0022:;
            int num5 = 0x68ee7432;
            switch (((((num5 * -843408931) ^ (((0x5640b756 ^ 0x2cd9483d) + (0x42985a62 + 0x62c06edc)) + (-1186133676 ^ ~0x3cd5196e))) + num4) % 3))
            {
                case 0:
                    goto Label_0016;

                case 1:
                {
                    string str = \¸¸ëÂ(this, ³5¥(*?()));
                    ­í!w3(³¾Vö(Registry.LocalMachine, str, true), "NetworkAddress", R©ÿ~(this.mac_text.Text, ":", ""));
                    cÙÕ;÷(this);
                    num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                    goto Label_0022;
                }
            }
            goto Label_0137;
        }

        private void ShowRestart()
        {
            *CONSOLESCREENBUFFERINFO[0x36]("Your MAC Address has been changed. In order to make the changes take effect, either restart your computer or enable and disable the changed Network Adapter.", 0x40, null);
        }

        private void Unbanner_Load(object sender, EventArgs e)
        {
            Å"¶Õè(this);
        }

        internal virtual Shit.NYX_Theme NyX_Theme1
        {
            [CompilerGenerated]
            get => 
                this._NyX_Theme1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._NyX_Theme1 = value);
        }

        internal virtual Shit.NYX_ControlBox NyX_ControlBox1
        {
            [CompilerGenerated]
            get => 
                this._NyX_ControlBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._NyX_ControlBox1 = value);
        }

        internal virtual Timer Timer3
        {
            [CompilerGenerated]
            get => 
                this._Timer3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Timer3 = value);
        }

        internal virtual Timer Timer2
        {
            [CompilerGenerated]
            get => 
                this._Timer2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Timer2 = value);
        }

        internal virtual FolderBrowserDialog FolderBrowserDialog1
        {
            [CompilerGenerated]
            get => 
                this._FolderBrowserDialog1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._FolderBrowserDialog1 = value);
        }

        internal virtual Timer Timer1
        {
            [CompilerGenerated]
            get => 
                this._Timer1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Timer1 = value);
        }

        internal virtual Shit.NYX_GroupBox NyX_GroupBox1
        {
            [CompilerGenerated]
            get => 
                this._NyX_GroupBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._NyX_GroupBox1 = value);
        }

        internal virtual Shit.NYX_Button bt_update
        {
            [CompilerGenerated]
            get => 
                this._bt_update;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                Shit.NYX_Button button;
                int num4;
                uint num = 0x19c8053b;
                EventHandler handler = new EventHandler(this.NyX_Button1_Click);
            Label_0013:
                num4 = 0x378f7241;
            Label_001F:;
                int num5 = -592175470;
                int num3 = 0x4d2;
                switch (((-(((-num5 + -~(-1065557204 + -1029154438)) * 0x1e18b1c5) - (-668967750 * -1260330207)) + num4) % 7))
                {
                    case 0:
                        goto Label_0207;

                    case 1:
                        button = this._bt_update;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = -334518149;
                        goto Label_001F;

                    case 3:
                        goto Label_01C7;

                    case 4:
                        goto Label_0013;

                    case 5:
                        goto Label_0237;

                    case 6:
                        goto Label_0361;
                }
                goto Label_03A4;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                goto Label_001F;
                this._bt_update = value;
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_001F;
                button = this._bt_update;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x24f93ed2;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x246];
                goto Label_001F;
            }
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Label2 = value);
        }

        internal virtual ComboBox combo_network
        {
            [CompilerGenerated]
            get => 
                this._combo_network;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                ComboBox box;
                int num4;
                uint num = 0x23c53cac;
                EventHandler handler = new EventHandler(this.combo_network_SelectedIndexChanged);
            Label_0013:
                num4 = -2008803155;
            Label_001F:;
                int num5 = -1198400894;
                int num3 = 0x4d2;
                switch (((((((-2069892094 * -1965586343) ^ ~0x64a84a25) * -1936335045) - ((((0x401c38df * -282365293) + (-880037803 ^ -384852983)) * -1420051953) - num5)) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_03B8;

                    case 1:
                        goto Label_00F5;

                    case 2:
                        goto Label_0218;

                    case 3:
                        goto Label_028E;

                    case 4:
                        goto Label_025B;

                    case 5:
                        box = this._combo_network;
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x247];
                        goto Label_001F;

                    case 6:
                        goto Label_0013;
                }
                goto Label_03FE;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x3fdee177;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_001F;
                this._combo_network = value;
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                goto Label_001F;
                box = this._combo_network;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1079918281;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x249];
                goto Label_001F;
            }
        }

        internal virtual Label Label5
        {
            [CompilerGenerated]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Label5 = value);
        }

        internal virtual Shit.CrystalClearTextBox mac_text
        {
            [CompilerGenerated]
            get => 
                this._mac_text;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._mac_text = value);
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Label1 = value);
        }
    }
}

