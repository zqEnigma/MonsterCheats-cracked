namespace Shit
{
    using Microsoft.VisualBasic.CompilerServices;
    using Microsoft.Win32;
    using SerializationObjectManager;
    using Shit.My;
    using Shit.My.Resources;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using TypeInfo;

    [DesignerGenerated]
    public class Form1 : Form
    {
        private string Msg;
        private string Nick;
        private string Nick2;
        private int Logged;
        private string Logged2;
        private bool Sended;
        private bool Sended2;
        private bool Sended3;
        public string NickPrefix;
        public string UserName;
        public bool choseee;
        public bool SEA;
        private string Game;
        public string Cheat_Process;
        public int Status;
        private string Coder;
        private string Link;
        private string Version;
        private string Engine;
        public int CheatId;
        public int BS;
        private Process[] p;
        private int existttt;
        private int vexistttt;
        private IContainer components;
        [CompilerGenerated, AccessedThroughProperty("NyX_Theme1")]
        private Shit.NYX_Theme _NyX_Theme1;
        [CompilerGenerated, AccessedThroughProperty("CrystalClearTabControl1")]
        private Shit.CrystalClearTabControl _CrystalClearTabControl1;
        [CompilerGenerated, AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;
        [CompilerGenerated, AccessedThroughProperty("NyX_GroupBox1")]
        private Shit.NYX_GroupBox _NyX_GroupBox1;
        [CompilerGenerated, AccessedThroughProperty("NyX_Button5")]
        private Shit.NYX_Button _NyX_Button5;
        [CompilerGenerated, AccessedThroughProperty("NyX_Button4")]
        private Shit.NYX_Button _NyX_Button4;
        [AccessedThroughProperty("NyX_Button3"), CompilerGenerated]
        private Shit.NYX_Button _NyX_Button3;
        [CompilerGenerated, AccessedThroughProperty("NyX_Button2")]
        private Shit.NYX_Button _NyX_Button2;
        [CompilerGenerated, AccessedThroughProperty("NyX_Button1")]
        private Shit.NYX_Button _NyX_Button1;
        [AccessedThroughProperty("CrystalClearTextBox1"), CompilerGenerated]
        private Shit.CrystalClearTextBox _CrystalClearTextBox1;
        [CompilerGenerated, AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("ListView2"), CompilerGenerated]
        private ListView _ListView2;
        [CompilerGenerated, AccessedThroughProperty("ColumnHeader1")]
        private ColumnHeader _ColumnHeader1;
        [AccessedThroughProperty("ColumnHeader6"), CompilerGenerated]
        private ColumnHeader _ColumnHeader6;
        [AccessedThroughProperty("ColumnHeader7"), CompilerGenerated]
        private ColumnHeader _ColumnHeader7;
        [AccessedThroughProperty("Timer7"), CompilerGenerated]
        private Timer _Timer7;
        [CompilerGenerated, AccessedThroughProperty("Timer8")]
        private Timer _Timer8;
        [CompilerGenerated, AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [CompilerGenerated, AccessedThroughProperty("Timer2")]
        private Timer _Timer2;
        [CompilerGenerated, AccessedThroughProperty("Timer3")]
        private Timer _Timer3;
        [CompilerGenerated, AccessedThroughProperty("Timer4")]
        private Timer _Timer4;
        [CompilerGenerated, AccessedThroughProperty("Timer5")]
        private Timer _Timer5;
        [CompilerGenerated, AccessedThroughProperty("Timer6")]
        private Timer _Timer6;
        [AccessedThroughProperty("Update"), CompilerGenerated]
        private Timer _Update;
        [CompilerGenerated, AccessedThroughProperty("NyX_ControlBox1")]
        private Shit.NYX_ControlBox _NyX_ControlBox1;
        [AccessedThroughProperty("NyX_Button6"), CompilerGenerated]
        private Shit.NYX_Button _NyX_Button6;
        [AccessedThroughProperty("TabPage2"), CompilerGenerated]
        private TabPage _TabPage2;
        [AccessedThroughProperty("ListView1"), CompilerGenerated]
        private ListView _ListView1;
        [AccessedThroughProperty("ColumnHeader2"), CompilerGenerated]
        private ColumnHeader _ColumnHeader2;
        [CompilerGenerated, AccessedThroughProperty("ColumnHeader3")]
        private ColumnHeader _ColumnHeader3;
        [CompilerGenerated, AccessedThroughProperty("ColumnHeader4")]
        private ColumnHeader _ColumnHeader4;

        public Form1()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0xb2136a28;
        Label_000C:
            num4 = 0x4c46e59c;
        Label_0017:;
            int num5 = 0x357d04c1;
            switch (((((num5 * 0x418acbe1) + ~(--665195512 - (0x60dc01f0 ^ 0x446df44c))) + num4) >> 0x10))
            {
                case 1:
                    goto Label_0157;

                case 2:
                    goto Label_0123;

                case 3:
                    *?(new FormClosedEventHandler(this.Form1_Closing));
                    *?(new EventHandler(this.Form1_Load));
                    this.Sended = false;
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x52];
                    goto Label_0017;

                case 4:
                    goto Label_00EE;

                case 5:
                    goto Label_000C;
            }
            goto Label_01AD;
            this.Sended2 = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x53];
            goto Label_0017;
            this.Sended3 = false;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0017;
            this.SEA = false;
            this.BS = 0;
            this.existttt = 0;
            this.vexistttt = 0;
            ®¶s(this);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x54];
            goto Label_0017;
        }

        public void ChangeStatus(string status)
        {
            this.CrystalClearTextBox1.Text = status;
        }

        public bool CheckIfRunning()
        {
            // This item is obfuscated and can not be translated.
            bool flag;
            int num4;
            if (ÿ­(
úÊ(this.CheatId, "process")).Count<Process>() <= 0)
            {
                goto Label_00FB;
            }
        Label_0030:
            num4 = 0x37f5e4b2;
        Label_003C:;
            int num5 = 0x1e232885;
            switch (((-(num5 + (-(--108404376 + (-2138345322 * 0x20b170a9)) + (-1888753535 * ~(-1362623502 + 0x3841eaf)))) + num4) % 4))
            {
                case 0:
                    goto Label_00FB;

                case 1:
                    flag = true;
                    num4 = -1282146615;
                    goto Label_003C;

                case 2:
                    goto Label_0030;
            }
            goto Label_0122;
            flag = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x65];
            goto Label_003C;
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                uint num;
                uint num2;
                int num4;
                int expressionStack_16F_0;
                int expressionStack_16F_1;
                if (!disposing)
                {
                    return;
                }
            Label_000C:
                num4 = -315576283;
                int expressionStack_17_0 = 0x5ed5ff2f;
            Label_0017:;
                int num5 = expressionStack_17_0;
                int num3 = 0x4d2;
                switch (((num2 = (uint) ((((0x6a70cee6 + -1322070727) - (-1858494058 - ((num5 - ((((0x41f55d7e * -2115626787) - -1861559068) ^ ~(-541937017 - -2095226295)) ^ (0x1582d394 ^ ((0x44698aa5 + -237645283) - (0x2f726945 ^ -924516330))))) * 0x746b4c63))) ^ -1594897533) + num4)) % 4))
                {
                    case 0:
                        goto Label_000C;

                    case 1:
                        return;

                    case 2:
                        if (this.components != null)
                        {
                            break;
                        }
                        num3 = 0x4d2;
                        expressionStack_16F_1 = 0xa30a19;
                        goto Label_016F;

                    case 3:
                        ÂÔç(this.components);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x6a];
                        expressionStack_17_0 = (((int) num2) - -898707763) ^ 0x21669aa9;
                        goto Label_0017;

                    default:
                        return;
                }
                expressionStack_16F_1 = -758126257;
            Label_016F:
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1836654478;
                expressionStack_17_0 = expressionStack_16F_1 ^ ((int) (num2 * 0x6a3a2eb4));
                goto Label_0017;
            }
            finally
            {
                VÛ(this, disposing);
            }
        }

        [DllImport("user32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        private static extern IntPtr FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);
        private void Form1_Closing(object sender, EventArgs e)
        {
            ¢ä°{();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0xc72b311a;
            this.existttt = 0;
        Label_000D:
            num4 = 0x52f74c42;
        Label_0018:;
            int num5 = -915148956;
            switch ((((((-((-(~0x44ab1c74 ^ (0x3b19b954 ^ -1692205049)) ^ (--1429692263 - ((0x6c5bdbd5 - 0x67727040) - (-1115797170 ^ -1582384562)))) - num5) + -(0x1a66d588 - 0x793c4621)) ^ 0x47909a9a) ^ 0x7e9510f) + num4) % 9))
            {
                case 0:
                    goto Label_0237;

                case 1:
                    goto Label_0111;

                case 2:
                    goto Label_01B4;

                case 3:
                    goto Label_0167;

                case 4:
                    this.vexistttt = 0;
                    *?(0x7d0);
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x67];
                    goto Label_0018;

                case 5:
                    goto Label_01FC;

                case 6:
                    goto Label_026F;

                case 7:
                    goto Label_000D;
            }
            goto Label_02B1;
            Ë6Q=(this.Timer5);
            *?(0x7d0);
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0018;
            Ë6Q=(this.Timer4);
            Ë6Q=(this.Timer7);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0018;
            ûµ(Shit.My.MyProject.Forms.Login, "3.0.0");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x68];
            goto Label_0018;
            iß«0();
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0018;
            æNö();
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0018;
            Z¯´();
            8çaÄÐ();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x69];
            goto Label_0018;
        }

        public string GetAppDataPath() => 
            N÷(Environment.SpecialFolder.ApplicationData);

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            // This item is obfuscated and can not be translated.
            ComponentResourceManager manager;
            int num4;
            uint num = 0x852da610;
            this.components = (IContainer) À%Ã±();
        Label_0016:
            num4 = 0x380949a3;
        Label_0022:;
            int num5 = 0x782f62a1;
            switch (((((~((-734261571 * -750133154) - ~num5) + (0x498158c4 - 0xb974bf2)) + -1621004321) + num4) % 0x8f))
            {
                case 0:
                    goto Label_1C04;

                case 1:
                    goto Label_0DB0;

                case 2:
                    goto Label_25E7;

                case 3:
                    goto Label_1644;

                case 4:
                    goto Label_0672;

                case 5:
                    goto Label_2358;

                case 6:
                    goto Label_2184;

                case 7:
                    goto Label_1044;

                case 8:
                    goto Label_3127;

                case 9:
                    goto Label_0504;

                case 10:
                    goto Label_1C53;

                case 11:
                    goto Label_250E;

                case 12:
                    goto Label_07A1;

                case 13:
                    goto Label_2E81;

                case 14:
                    goto Label_074F;

                case 15:
                    goto Label_2FBD;

                case 0x10:
                    goto Label_2B7E;

                case 0x11:
                    goto Label_0E10;

                case 0x12:
                    goto Label_2499;

                case 0x13:
                    goto Label_0A6F;

                case 20:
                    goto Label_09BF;

                case 0x15:
                    goto Label_031A;

                case 0x16:
                    goto Label_0400;

                case 0x17:
                    goto Label_2862;

                case 0x18:
                    goto Label_0FE1;

                case 0x19:
                    goto Label_2777;

                case 0x1a:
                    goto Label_2F7B;

                case 0x1b:
                    goto Label_23A6;

                case 0x1c:
                    manager = (ComponentResourceManager) bä(>+Zí(typeof(Shit.Form1).TypeHandle));
                    this.Timer7 = (Timer) ¾6ÊÜ(this.components);
                    num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                    goto Label_0022;

                case 0x1d:
                    goto Label_2BD0;

                case 30:
                    goto Label_1FF2;

                case 0x1f:
                    goto Label_13B6;

                case 0x20:
                    goto Label_140D;

                case 0x21:
                    goto Label_0470;

                case 0x22:
                    goto Label_1D78;

                case 0x23:
                    goto Label_0ADF;

                case 0x25:
                    goto Label_2145;

                case 0x26:
                    goto Label_19CA;

                case 0x27:
                    goto Label_2081;

                case 40:
                    goto Label_30EC;

                case 0x29:
                    goto Label_2448;

                case 0x2a:
                    goto Label_05F2;

                case 0x2b:
                    goto Label_2823;

                case 0x2c:
                    goto Label_0544;

                case 0x2d:
                    goto Label_15FD;

                case 0x2e:
                    goto Label_1A12;

                case 0x2f:
                    goto Label_0E78;

                case 0x30:
                    goto Label_185A;

                case 0x31:
                    goto Label_33E4;

                case 50:
                    goto Label_06B0;

                case 0x33:
                    goto Label_0D4F;

                case 0x34:
                    goto Label_0F47;

                case 0x35:
                    goto Label_2F38;

                case 0x36:
                    goto Label_31F4;

                case 0x37:
                    goto Label_0016;

                case 0x38:
                    goto Label_14B0;

                case 0x39:
                    goto Label_2DD4;

                case 0x3a:
                    goto Label_03BB;

                case 0x3b:
                    goto Label_1718;

                case 60:
                    goto Label_0593;

                case 0x3d:
                    goto Label_203A;

                case 0x3e:
                    goto Label_1092;

                case 0x3f:
                    goto Label_16CA;

                case 0x40:
                    goto Label_29B2;

                case 0x41:
                    goto Label_26ED;

                case 0x42:
                    goto Label_29F0;

                case 0x43:
                    goto Label_10FD;

                case 0x44:
                    goto Label_0A33;

                case 0x45:
                    goto Label_2C82;

                case 70:
                    goto Label_192A;

                case 0x47:
                    goto Label_1F07;

                case 0x48:
                    goto Label_137C;

                case 0x49:
                    goto Label_04C5;

                case 0x4a:
                    goto Label_1339;

                case 0x4b:
                    goto Label_1BB2;

                case 0x4c:
                    goto Label_1FAB;

                case 0x4d:
                    goto Label_3236;

                case 0x4e:
                    goto Label_20E1;

                case 0x4f:
                    goto Label_22CD;

                case 80:
                    goto Label_1503;

                case 0x51:
                    goto Label_2EC8;

                case 0x52:
                    goto Label_2A80;

                case 0x53:
                    goto Label_2E25;

                case 0x54:
                    goto Label_1246;

                case 0x55:
                    goto Label_1148;

                case 0x56:
                    goto Label_1760;

                case 0x57:
                    goto Label_0C17;

                case 0x58:
                    goto Label_0C66;

                case 0x59:
                    goto Label_2AD8;

                case 90:
                    goto Label_0B9E;

                case 0x5b:
                    goto Label_0833;

                case 0x5c:
                    goto Label_3283;

                case 0x5d:
                    goto Label_0D10;

                case 0x5e:
                    goto Label_093E;

                case 0x5f:
                    goto Label_2B23;

                case 0x60:
                    goto Label_24D4;

                case 0x61:
                    goto Label_12E6;

                case 0x62:
                    goto Label_06EF;

                case 0x63:
                    goto Label_27D2;

                case 100:
                    goto Label_08FF;

                case 0x65:
                    goto Label_3026;

                case 0x66:
                    goto Label_2638;

                case 0x67:
                    goto Label_0BDC;

                case 0x68:
                    goto Label_3426;

                case 0x69:
                    goto Label_2CD1;

                case 0x6a:
                    goto Label_1E7C;

                case 0x6b:
                    goto Label_035F;

                case 0x6c:
                    goto Label_231E;

                case 0x6d:
                    goto Label_12A7;

                case 110:
                    goto Label_0872;

                case 0x6f:
                    goto Label_07E0;

                case 0x70:
                    goto Label_1AA0;

                case 0x71:
                    goto Label_318C;

                case 0x72:
                    goto Label_3305;

                case 0x73:
                    goto Label_257E;

                case 0x74:
                    goto Label_1CD7;

                case 0x75:
                    goto Label_0CA1;

                case 0x76:
                    goto Label_2D2C;

                case 0x77:
                    goto Label_3347;

                case 120:
                    goto Label_228E;

                case 0x79:
                    goto Label_09F9;

                case 0x7a:
                    goto Label_155D;

                case 0x7b:
                    goto Label_1DC0;

                case 0x7c:
                    goto Label_097C;

                case 0x7d:
                    goto Label_30A4;

                case 0x7e:
                    goto Label_1B04;

                case 0x7f:
                    goto Label_1D2B;

                case 0x80:
                    goto Label_3384;

                case 0x81:
                    goto Label_1B4F;

                case 130:
                    goto Label_0632;

                case 0x83:
                    goto Label_1F64;

                case 0x84:
                    goto Label_2C44;

                case 0x85:
                    goto Label_0ECB;

                case 0x86:
                    goto Label_23FD;

                case 0x87:
                    goto Label_11E9;

                case 0x88:
                    goto Label_1975;

                case 0x89:
                    goto Label_2D91;

                case 0x8a:
                    goto Label_08C0;

                case 0x8b:
                    goto Label_18C3;

                case 140:
                    goto Label_272C;

                case 0x8d:
                    goto Label_28C9;

                case 0x8e:
                    goto Label_1194;
            }
            goto Label_34A9;
            this.Timer8 = (Timer) ¾6ÊÜ(this.components);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x6b];
            goto Label_0022;
            this.Timer1 = (Timer) ¾6ÊÜ(this.components);
            this.Timer2 = (Timer) ¾6ÊÜ(this.components);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x6c];
            goto Label_0022;
            this.Timer3 = (Timer) ¾6ÊÜ(this.components);
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.Timer4 = (Timer) ¾6ÊÜ(this.components);
            this.Timer5 = (Timer) ¾6ÊÜ(this.components);
            this.Timer6 = (Timer) ¾6ÊÜ(this.components);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.Update = (Timer) ¾6ÊÜ(this.components);
            this.NyX_Theme1 = (Shit.NYX_Theme) ä{Ãdâ();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x6d];
            goto Label_0022;
            this.NyX_ControlBox1 = (Shit.NYX_ControlBox) °9O();
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            this.Label3 = (Label) aÞCM2();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[110];
            goto Label_0022;
            this.CrystalClearTextBox1 = (Shit.CrystalClearTextBox) ÷R°á();
            this.CrystalClearTabControl1 = (Shit.CrystalClearTabControl) É×1À();
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.TabPage1 = (TabPage) ì¸xøs();
            this.ListView2 = (ListView) ÜDþ¢*();
            this.ColumnHeader1 = (ColumnHeader) @þr®Ì();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x6f];
            goto Label_0022;
            this.ColumnHeader6 = (ColumnHeader) @þr®Ì();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x70];
            goto Label_0022;
            this.ColumnHeader7 = (ColumnHeader) @þr®Ì();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x71];
            goto Label_0022;
            this.TabPage2 = (TabPage) ì¸xøs();
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.ListView1 = (ListView) ÜDþ¢*();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x72];
            goto Label_0022;
            this.ColumnHeader2 = (ColumnHeader) @þr®Ì();
            this.ColumnHeader3 = (ColumnHeader) @þr®Ì();
            this.ColumnHeader4 = (ColumnHeader) @þr®Ì();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x73];
            goto Label_0022;
            this.NyX_GroupBox1 = (Shit.NYX_GroupBox) ØúUÀø();
            this.NyX_Button6 = (Shit.NYX_Button) K7Dá();
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.NyX_Button5 = (Shit.NYX_Button) K7Dá();
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_Button4 = (Shit.NYX_Button) K7Dá();
            this.NyX_Button3 = (Shit.NYX_Button) K7Dá();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x74];
            goto Label_0022;
            this.NyX_Button2 = (Shit.NYX_Button) K7Dá();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x75];
            goto Label_0022;
            this.NyX_Button1 = (Shit.NYX_Button) K7Dá();
            CÕ(this.NyX_Theme1);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            CÕ(this.CrystalClearTabControl1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x76];
            goto Label_0022;
            CÕ(this.TabPage1);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            CÕ(this.TabPage2);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            CÕ(this.NyX_GroupBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x77];
            goto Label_0022;
            =µ§­(this);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[120];
            goto Label_0022;
            this.Update.Enabled = true;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_Theme1.Animated = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x79];
            goto Label_0022;
            this.NyX_Theme1.BorderStyle = FormBorderStyle.None;
            this.NyX_Theme1.Colors = new Shit.Bloom[0];
            yã\B(*?(), this.NyX_ControlBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x7a];
            goto Label_0022;
            yã\B(*?(), this.Label3);
            yã\B(*?(), this.CrystalClearTextBox1);
            yã\B(*?(), this.CrystalClearTabControl1);
            yã\B(*?(), this.NyX_GroupBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x7b];
            goto Label_0022;
            this.NyX_Theme1.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.NyX_Theme1.Dock = DockStyle.Fill;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_Theme1.Font = (Font) ·)©ê("Arial", 9f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x7c];
            goto Label_0022;
            this.NyX_Theme1.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x7d];
            goto Label_0022;
            *?(new Point(0, 0));
            this.NyX_Theme1.Movable = true;
            *?("NyX_Theme1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x7e];
            goto Label_0022;
            this.NyX_Theme1.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x7f];
            goto Label_0022;
            this.NyX_Theme1.Sizable = true;
            *?(new Size(0x35b, 0x1e9));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x80];
            goto Label_0022;
            this.NyX_Theme1.SmartBounds = true;
            this.NyX_Theme1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            *?(0);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x81];
            goto Label_0022;
            this.NyX_Theme1.Text = "~~ | Monster Cheats Loader | ~~";
            this.NyX_Theme1.TransparencyKey = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x23]();
            this.NyX_Theme1.Transparent = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[130];
            goto Label_0022;
            this.NyX_ControlBox1.Colors = new Shit.Bloom[0];
            this.NyX_ControlBox1.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.NyX_ControlBox1.Font = (Font) ·)©ê("Verdana", 8f);
            this.NyX_ControlBox1.Image = null;
            *?(new Point(0x323, 3));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x83];
            goto Label_0022;
            *?("NyX_ControlBox1");
            this.NyX_ControlBox1.NoRounding = false;
            *?(new Size(0x2c, 20));
            *?(0x1b);
            this.NyX_ControlBox1.Text = "NyX_ControlBox1";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x84];
            goto Label_0022;
            this.NyX_ControlBox1.Transparent = false;
            this.Label3.AutoSize = true;
            this.Label3.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x85];
            goto Label_0022;
            this.Label3.Font = (Font) ·)©ê("Microsoft Sans Serif", 8.25f);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            this.Label3.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            *?(new Point(0x13, 0x1c7));
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            *?("Label3");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x86];
            goto Label_0022;
            *?(new Size(0x1f, 13));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            *?(0x1a);
            this.Label3.Text = "1.0.0";
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.CrystalClearTextBox1.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x4f]();
            this.CrystalClearTextBox1.Colors = new Shit.Bloom[0];
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x87];
            goto Label_0022;
            this.CrystalClearTextBox1.Customization = "";
            this.CrystalClearTextBox1.Font = (Font) ·)©ê("Verdana", 8f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x88];
            goto Label_0022;
            this.CrystalClearTextBox1.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x89];
            goto Label_0022;
            *?(new Point(0x16, 0x163));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x8a];
            goto Label_0022;
            this.CrystalClearTextBox1.MaxLength = 0x7fff;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x8b];
            goto Label_0022;
            this.CrystalClearTextBox1.Multiline = false;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            *?("CrystalClearTextBox1");
            this.CrystalClearTextBox1.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[140];
            goto Label_0022;
            this.CrystalClearTextBox1.ReadOnly = false;
            *?(new Size(0x265, 0x18));
            *?(3);
            this.CrystalClearTextBox1.Text = "Waiting for your input ...";
            this.CrystalClearTextBox1.TextAlign = HorizontalAlignment.Left;
            this.CrystalClearTextBox1.Transparent = false;
            this.CrystalClearTextBox1.UseSystemPasswordChar = false;
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            yã\B(*?(), this.TabPage1);
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            yã\B(*?(), this.TabPage2);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x8d];
            goto Label_0022;
            *?(new Point(0x16, 0x34));
            *?("CrystalClearTabControl1");
            *?(0);
            *?(new Size(640, 0x12d));
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            *?(1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x8e];
            goto Label_0022;
            *?("");
            this.TabPage1.BackColor = åG¿îÛ(0x16, 0x16, 0x16);
            yã\B(*?(), this.ListView2);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            *?(new Point(4, 0x19));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x8f];
            goto Label_0022;
            *?("TabPage1");
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            *?(new Padding(3));
            *?(new Size(0x278, 0x110));
            *?(0);
            this.TabPage1.Text = "VIP";
            this.ListView2.BackColor = åG¿îÛ(0x20, 0x20, 0x20);
            *?(0);
            ColumnHeader[] headerArray1 = new ColumnHeader[] { this.ColumnHeader1, this.ColumnHeader6, this.ColumnHeader7 };
            SerializationObjectManager.SymbolToken.StaticArrayInitTypeSize=128(*?(), headerArray1);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.ListView2.Font = (Font) shYzt("Lato", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ListView2.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            *?(1);
            *?(new Point(7, 0x19));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x90];
            goto Label_0022;
            *?("ListView2");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x91];
            goto Label_0022;
            *?(new Size(0x26b, 0xce));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x92];
            goto Label_0022;
            *?(0x10);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x93];
            goto Label_0022;
            *?(0);
            *?(1);
            *?("Game");
            *?(230);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x94];
            goto Label_0022;
            *?("Coder");
            *?(0xba);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x95];
            goto Label_0022;
            *?("Status");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[150];
            goto Label_0022;
            *?(200);
            this.TabPage2.BackColor = åG¿îÛ(0x16, 0x16, 0x16);
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            yã\B(*?(), this.ListView1);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            *?(new Point(4, 0x19));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x97];
            goto Label_0022;
            *?("TabPage2");
            *?(new Padding(3));
            *?(new Size(0x278, 0x110));
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            *?(1);
            this.TabPage2.Text = "Public";
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            this.ListView1.BackColor = åG¿îÛ(0x20, 0x20, 0x20);
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            *?(0);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x98];
            goto Label_0022;
            ColumnHeader[] headerArray2 = new ColumnHeader[] { this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4 };
            SerializationObjectManager.SymbolToken.StaticArrayInitTypeSize=128(*?(), headerArray2);
            this.ListView1.Font = (Font) shYzt("Lato", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ListView1.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            *?(1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x99];
            goto Label_0022;
            *?(new Point(9, 0x19));
            *?("ListView1");
            *?(new Size(0x268, 0xce));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x9a];
            goto Label_0022;
            *?(0x11);
            *?(0);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x9b];
            goto Label_0022;
            *?(1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x9c];
            goto Label_0022;
            *?("Game");
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            *?(230);
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            *?("Coder");
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            *?(0xba);
            *?("Status");
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            *?(200);
            this.NyX_GroupBox1.Animated = true;
            this.NyX_GroupBox1.BorderStyle = FormBorderStyle.None;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x9d];
            goto Label_0022;
            this.NyX_GroupBox1.Colors = new Shit.Bloom[0];
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            yã\B(*?(), this.NyX_Button6);
            yã\B(*?(), this.NyX_Button5);
            yã\B(*?(), this.NyX_Button4);
            yã\B(*?(), this.NyX_Button3);
            yã\B(*?(), this.NyX_Button2);
            yã\B(*?(), this.NyX_Button1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x9e];
            goto Label_0022;
            this.NyX_GroupBox1.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_GroupBox1.Font = (Font) ·)©ê("Arial", 9f);
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.NyX_GroupBox1.Image = null;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            *?(new Point(0x29c, 0x34));
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_GroupBox1.Movable = true;
            *?("NyX_GroupBox1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x9f];
            goto Label_0022;
            this.NyX_GroupBox1.NoRounding = false;
            this.NyX_GroupBox1.Sizable = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[160];
            goto Label_0022;
            *?(new Size(0xb3, 0x1a0));
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.NyX_GroupBox1.SmartBounds = true;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_GroupBox1.StartPosition = FormStartPosition.Manual;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            *?(2);
            this.NyX_GroupBox1.Text = "Menu";
            this.NyX_GroupBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.NyX_GroupBox1.Transparent = false;
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.NyX_Button6.Colors = new Shit.Bloom[0];
            this.NyX_Button6.Cursor = (Cursor) *CONSOLESCREENBUFFERINFO[0x5c]();
            this.NyX_Button6.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_Button6.Font = (Font) ·)©ê("Arial", 8f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xa1];
            goto Label_0022;
            this.NyX_Button6.Image = null;
            *?(new Point(0x1f, 0xe3));
            *?("NyX_Button6");
            this.NyX_Button6.NoRounding = false;
            *?(new Size(120, 0x1d));
            *?(5);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xa2];
            goto Label_0022;
            this.NyX_Button6.Text = "Unbanner";
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.NyX_Button6.Transparent = false;
            this.NyX_Button5.Colors = new Shit.Bloom[0];
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_Button5.Cursor = (Cursor) *CONSOLESCREENBUFFERINFO[0x5c]();
            this.NyX_Button5.Customization = "";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xa3];
            goto Label_0022;
            this.NyX_Button5.Font = (Font) ·)©ê("Arial", 8f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xa4];
            goto Label_0022;
            this.NyX_Button5.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xa5];
            goto Label_0022;
            *?(new Point(0x1f, 0x16f));
            *?("NyX_Button5");
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.NyX_Button5.NoRounding = false;
            *?(new Size(120, 0x1d));
            *?(4);
            this.NyX_Button5.Text = "Load Cheat";
            this.NyX_Button5.Transparent = false;
            this.NyX_Button4.Colors = new Shit.Bloom[0];
            this.NyX_Button4.Cursor = (Cursor) *CONSOLESCREENBUFFERINFO[0x5c]();
            this.NyX_Button4.Customization = "";
            this.NyX_Button4.Font = (Font) ·)©ê("Arial", 8f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xa6];
            goto Label_0022;
            this.NyX_Button4.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xa7];
            goto Label_0022;
            *?(new Point(0x1f, 0xb7));
            *?("NyX_Button4");
            this.NyX_Button4.NoRounding = false;
            *?(new Size(120, 0x1d));
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            *?(3);
            this.NyX_Button4.Text = "Helper";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xa8];
            goto Label_0022;
            this.NyX_Button4.Transparent = false;
            this.NyX_Button3.Colors = new Shit.Bloom[0];
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.NyX_Button3.Cursor = (Cursor) *CONSOLESCREENBUFFERINFO[0x5c]();
            this.NyX_Button3.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_Button3.Font = (Font) ·)©ê("Arial", 8f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xa9];
            goto Label_0022;
            this.NyX_Button3.Image = null;
            *?(new Point(0x1f, 0x8a));
            *?("NyX_Button3");
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_Button3.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[170];
            goto Label_0022;
            *?(new Size(120, 0x1d));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xab];
            goto Label_0022;
            *?(2);
            this.NyX_Button3.Text = "Launch Game";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xac];
            goto Label_0022;
            this.NyX_Button3.Transparent = false;
            this.NyX_Button2.Colors = new Shit.Bloom[0];
            this.NyX_Button2.Cursor = (Cursor) *CONSOLESCREENBUFFERINFO[0x5c]();
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_Button2.Customization = "";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xad];
            goto Label_0022;
            this.NyX_Button2.Font = (Font) ·)©ê("Arial", 8f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xae];
            goto Label_0022;
            this.NyX_Button2.Image = null;
            *?(new Point(0x1f, 0x5e));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xaf];
            goto Label_0022;
            *?("NyX_Button2");
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_Button2.NoRounding = false;
            *?(new Size(120, 0x1d));
            *?(1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xb0];
            goto Label_0022;
            this.NyX_Button2.Text = "Settings";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xb1];
            goto Label_0022;
            this.NyX_Button2.Transparent = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xb2];
            goto Label_0022;
            this.NyX_Button1.Colors = new Shit.Bloom[0];
            this.NyX_Button1.Cursor = (Cursor) *CONSOLESCREENBUFFERINFO[0x5c]();
            this.NyX_Button1.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.NyX_Button1.Font = (Font) ·)©ê("Arial", 8f);
            this.NyX_Button1.Image = null;
            *?(new Point(0x1f, 50));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xb3];
            goto Label_0022;
            *?("NyX_Button1");
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_Button1.NoRounding = false;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            *?(new Size(120, 0x1d));
            *?(0);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[180];
            goto Label_0022;
            this.NyX_Button1.Text = "Website";
            this.NyX_Button1.Transparent = false;
            *?(new SizeF(6f, 13f));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            *?(1);
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            *?(new Size(0x35b, 0x1e9));
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            yã\B(*?(), this.NyX_Theme1);
            *?(0);
            *?((Icon) ]l¶+(manager, "$this.Icon"));
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            *?("Form1");
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.Text = "Main";
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            *?(*CONSOLESCREENBUFFERINFO[0x23]());
            4Ü'Ô(this.NyX_Theme1, false);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xb5];
            goto Label_0022;
            òS4É:(this.NyX_Theme1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xb6];
            goto Label_0022;
            4Ü'Ô(this.CrystalClearTabControl1, false);
            4Ü'Ô(this.TabPage1, false);
            4Ü'Ô(this.TabPage2, false);
            4Ü'Ô(this.NyX_GroupBox1, false);
            ©`Vñ(this, false);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xb7];
            goto Label_0022;
        }

        public bool IsProcessRunning(string name)
        {
            // This item is obfuscated and can not be translated.
            bool flag;
            int num4;
            object obj1 = f?sÓ ("ISO-8859-1");
            if (SerializationObjectManager.ModuleBuilderData.SHA1Managed(SerializationObjectManager.TypeBuilderInstantiation.KeyNotFoundException(SerializationObjectManager.Variant.SoapQName(obj1, SerializationObjectManager.ConsoleColor.MemoryStream(obj1, name)), "?", "")).Count<Process>() <= 0)
            {
                goto Label_0112;
            }
        Label_0042:
            num4 = 0x762c25e6;
        Label_004E:;
            int num5 = -220139782;
            switch (((-(--2016058197 - ((-1774045725 * (-16637161 + -1768521407)) - (-num5 * -1407097667))) + num4) % 4))
            {
                case 0:
                    goto Label_0112;

                case 2:
                    goto Label_0042;

                case 3:
                    flag = true;
                    num4 = 0x65fb00cf;
                    goto Label_004E;
            }
            goto Label_013B;
            flag = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x63];
            goto Label_004E;
        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void NyX_Button1_Click(object sender, EventArgs e)
        {
            ÔP#("http://monster-cheats.com");
        }

        private void NyX_Button2_Click(object sender, EventArgs e)
        {
            þÆm(Shit.My.MyProject.Forms.Settings);
        }

        private void NyX_Button3_Click(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            if (!­­`>(Shit.My.MyProject.Forms.Settings.path))
            {
                goto Label_084F;
            }
        Label_0024:
            num4 = -592890587;
        Label_0030:;
            int num5 = 0x64a46570;
            int num3 = 0x4d2;
            switch (((((num5 ^ ((((0x2ca49bed ^ 0x60d67bb1) - (-1544349672 - -1967221964)) * 0x2cdeace1) + --(0x2c03afff - -1010261484))) - -(-0x44853ad2 ^ (-449884983 - -1746487837))) + num4) >> 0x10))
            {
                case 0:
                    goto Label_04CF;

                case 1:
                    goto Label_0235;

                case 2:
                    goto Label_02B4;

                case 3:
                    goto Label_0473;

                case 4:
                    goto Label_0024;

                case 5:
                    goto Label_084F;

                case 6:
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = 0x16765cbd;
                    goto Label_0030;

                case 7:
                    goto Label_0425;

                case 8:
                    goto Label_0331;

                case 9:
                    goto Label_0810;

                case 10:
                    goto Label_0799;

                case 11:
                    goto Label_0630;

                case 13:
                    goto Label_07E1;

                case 14:
                    goto Label_074D;
            }
            goto Label_088B;
            object obj1 = Æ}Þ(Registry.CurrentUser, "SF2 Launcher v1.0.0");
            TypeInfo.SoapNonPositiveInteger.ASCIIEncoding(SerializationObjectManager.SyncStream.MethodBase(obj1, "SF2 Launcher v1.0.0"));
            object obj2 = SerializationObjectManager.SyncStream.MethodBase(obj1, "Settings");
            SerializationObjectManager.ContextLevelActivator.RealProxy(obj2, "Path", Shit.My.MyProject.Forms.Settings.path);
            SerializationObjectManager.ContextLevelActivator.RealProxy(obj2, "RememberMe", "True");
            num4 = -1837242755;
            goto Label_0030;
            object obj3 = Æ}Þ(Registry.CurrentUser, "SF2 Launcher v1.0.0");
            TypeInfo.SoapNonPositiveInteger.ASCIIEncoding(SerializationObjectManager.SyncStream.MethodBase(obj3, "SF2 Launcher v1.0.0"));
            object obj4 = SerializationObjectManager.SyncStream.MethodBase(obj3, "Settings");
            SerializationObjectManager.ContextLevelActivator.RealProxy(obj4, "Path", Shit.My.MyProject.Forms.Settings.path);
            SerializationObjectManager.ContextLevelActivator.RealProxy(obj4, "RememberMe", "False");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x57];
            goto Label_0030;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x7d57ebcf;
            goto Label_0030;
            string str = ý^¤)(Shit.My.MyProject.Forms.Settings.path, @"\SFGame\Splash\PC\EUR");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x58];
            goto Label_0030;
            ÖW¼(Shit.My.Resources.Resources.splash_01, ý^¤)(str, @"\splash_01.png"), *CONSOLESCREENBUFFERINFO[0x4a]());
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x59];
            goto Label_0030;
            object obj5 = SerializationObjectManager.RuntimeHelpers.SoapAttribute();
            *?(ý^¤)(Shit.My.MyProject.Forms.Settings.path, @"\Binaries\Win32\sf2.exe"));
            *?(1P(" -language=EUR -STARTFROMLAUNCHER -sublanguage=", Shit.My.MyProject.Forms.Settings.lang, " -ServerIP=79.110.88.183 -ServerPort=27932 -ClanServerIP=79.110.88.231 -ClanServerPort=8383 -MessengerServerIP=79.110.88.180 -MessengerServerPort=27935"));
            SerializationObjectManager.MTAThreadAttribute.WaitCallback((ProcessStartInfo) obj5);
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x16c15ada;
            goto Label_0030;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x6983dd77;
            goto Label_0030;
            *?(0x80);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[90];
            goto Label_0030;
            aeQ(Shit.My.MyProject.Forms.Settings.Timer1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x5b];
            goto Label_0030;
            Ë6Q=(Shit.My.MyProject.Forms.Settings.Timer2);
            return;
            *CONSOLESCREENBUFFERINFO[0x36]("Select SF2 Path !!", 0, null);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x5e];
            goto Label_0030;
        }

        private void NyX_Button4_Click(object sender, EventArgs e)
        {
            þÆm(Shit.My.MyProject.Forms.holper);
        }

        private void NyX_Button5_Click(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            this.CheatId = 'ûõ}();
        Label_0016:
            num4 = -1816011297;
        Label_0021:;
            int num5 = -1106987033;
            int num3 = 0x4d2;
            switch (((-~((-1851893883 * (-92805166 + 0xb766ff)) - ((0x47f15dd ^ --1801980496) - ~num5)) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0016;

                case 1:
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = 0xf8882fd;
                    goto Label_0021;

                case 2:
                    goto Label_01E1;

                case 4:
                    goto Label_01A3;
            }
            goto Label_0210;
            Ë6Q=(this.Timer1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x66];
            goto Label_0021;
            G/b(this, "Select cheat ..");
        }

        private void NyX_Button6_Click(object sender, EventArgs e)
        {
            þÆm(Shit.My.MyProject.Forms.Unbanner);
        }

        private void NyX_GroupBox1_Click(object sender, EventArgs e)
        {
        }

        private void NyX_Theme1_Click(object sender, EventArgs e)
        {
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            if (!{GÊ(this, 
úÊ(this.CheatId, "process")))
            {
                goto Label_01BD;
            }
        Label_002B:
            num4 = -975928833;
        Label_0036:;
            int num5 = -1947270869;
            switch (((-((((((-805326383 * ((-454753292 ^ 0x5ce3f3ad) * -1768046275)) + (0x137f3a99 * (0x1c5d33e0 ^ (0x3439318c ^ 0x63d8bdc6)))) - num5) ^ ((~-846505967 ^ (-2054931029 * -1829595845)) + (~0x4438438c - (-142910887 - 0x3c75d732)))) * -1102637947) - ~-792118661) + num4) >> 0x10))
            {
                case 1:
                    goto Label_018E;

                case 2:
                    aeQ(this.Timer1);
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x5f];
                    goto Label_0036;

                case 3:
                    goto Label_0127;

                case 4:
                    goto Label_002B;
            }
            goto Label_01BD;
            É~®(this.CheatId);
            *?(0x1388);
            Ë6Q=(this.Timer2);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x60];
            goto Label_0036;
            G/b(this, 1P("Waiting for ", 
úÊ(this.CheatId, "process"), ".exe .."));
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            aeQ(this.Timer2);
            G/b(this, "Ready for next injection ...");
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x8e6029e4;
            if (Shit.DW.completed1 != 1)
            {
                goto Label_009F;
            }
        Label_0011:
            num4 = -2044944181;
        Label_001C:;
            int num5 = 0x3d38b04;
            switch (((~(num5 * 0x79e2f1a9) + num4) % 3))
            {
                case 0:
                    goto Label_0011;

                case 1:
                    aeQ(this.Timer3);
                    num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                    goto Label_001C;
            }
            goto Label_009F;
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0xdd14af;
            if (!Shit.Inject.IsVip)
            {
                goto Label_00EB;
            }
        Label_0010:
            num4 = -199257929;
        Label_001B:;
            int num5 = 0x5fd5cc81;
            int num3 = 0x4d2;
            switch (((((~((num5 ^ ~~((-1599298242 * -1057575279) ^ (-977952893 + 0x4e746576))) ^ ((-958081283 * (-1069050502 - -1399207880)) - -0x24cc7c99)) * 0x9b8caeb) * 0x20f8cd1) + num4) % 5))
            {
                case 0:
                    break;

                case 1:
                    "oeé(this.CrystalClearTabControl1, 0);
                    return;

                case 2:
                    goto Label_0010;

                case 4:
                    goto Label_01CE;

                default:
                    goto Label_020C;
            }
        Label_00EB:;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x3a0af2fe;
            goto Label_001B;
            "oeé(this.CrystalClearTabControl1, 1);
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_001B;
        }

        internal virtual Shit.NYX_Theme NyX_Theme1
        {
            [CompilerGenerated]
            get => 
                this._NyX_Theme1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                Shit.NYX_Theme theme;
                int num4;
                uint num = 0xd33a2efd;
                EventHandler handler = new EventHandler(this.NyX_Theme1_Click);
            Label_0013:
                num4 = 0x6e66faeb;
            Label_001F:;
                int num5 = 0x4932daca;
                int num3 = 0x4d2;
                switch (((-~(((num5 - (-199246749 * ~((-870154642 ^ 0x3d7ee0b8) + (-207810916 ^ -1415061235)))) ^ -940045383) * 0x1e8b2cf3) + num4) % 6))
                {
                    case 1:
                        theme = this._NyX_Theme1;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = 0x78979e1;
                        goto Label_001F;

                    case 2:
                        goto Label_0315;

                    case 3:
                        goto Label_0210;

                    case 4:
                        goto Label_0013;

                    case 5:
                        goto Label_01D1;
                }
                goto Label_0358;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                goto Label_001F;
                this._NyX_Theme1 = value;
                theme = this._NyX_Theme1;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x5a379546;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xb8];
                goto Label_001F;
            }
        }

        internal virtual Shit.CrystalClearTabControl CrystalClearTabControl1
        {
            [CompilerGenerated]
            get => 
                this._CrystalClearTabControl1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._CrystalClearTabControl1 = value);
        }

        internal virtual TabPage TabPage1
        {
            [CompilerGenerated]
            get => 
                this._TabPage1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0xf8ca304b;
                EventHandler handler = new EventHandler(this.TabPage1_Click);
                TabPage page = this._TabPage1;
                if (page == null)
                {
                    goto Label_00F3;
                }
            Label_0020:
                num4 = -1934927176;
            Label_002C:;
                int num5 = -552262152;
                int num3 = 0x4d2;
                switch ((((-806828538 - -~(-num5 + (-0x321aeefd - ((-1428585789 ^ 0x5ccd9fa6) ^ (-1440148039 + -1174421134))))) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_0020;

                    case 1:
                        *?(handler);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xb9];
                        goto Label_002C;

                    case 2:
                        goto Label_00F3;

                    case 3:
                        goto Label_0122;

                    case 5:
                        goto Label_027F;

                    case 6:
                        goto Label_0158;
                }
                goto Label_02BF;
                this._TabPage1 = value;
                num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                goto Label_002C;
                page = this._TabPage1;
                num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                goto Label_002C;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x7f17ca43;
                goto Label_002C;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                goto Label_002C;
            }
        }

        internal virtual Shit.NYX_GroupBox NyX_GroupBox1
        {
            [CompilerGenerated]
            get => 
                this._NyX_GroupBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                Shit.NYX_GroupBox box;
                int num4;
                uint num = 0x18969240;
                EventHandler handler = new EventHandler(this.NyX_GroupBox1_Click);
            Label_0013:
                num4 = -1651512468;
            Label_001F:;
                int num5 = 0x798adff8;
                int num3 = 0x4d2;
                switch ((((-980407625 - ((~(num5 + ((((-1217948767 * -1408167111) ^ (0x7260096b + 0x7f6a745a)) ^ ~(0x1855824a ^ 0x244aad12)) - -((0x117d5582 - -66138936) ^ (-558380206 + 0x64713427)))) * -305964569) ^ --1354235836)) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_0013;

                    case 1:
                        goto Label_0272;

                    case 2:
                        goto Label_022F;

                    case 4:
                        goto Label_02A8;

                    case 5:
                        goto Label_03CB;

                    case 6:
                        box = this._NyX_GroupBox1;
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xbb];
                        goto Label_001F;

                    case 7:
                        goto Label_010C;
                }
                goto Label_040F;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -233560096;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xbc];
                goto Label_001F;
                this._NyX_GroupBox1 = value;
                box = this._NyX_GroupBox1;
                num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                goto Label_001F;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x6ff81fb7;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[190];
                goto Label_001F;
            }
        }

        internal virtual Shit.NYX_Button NyX_Button5
        {
            [CompilerGenerated]
            get => 
                this._NyX_Button5;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x52ea2d95;
                EventHandler handler = new EventHandler(this.NyX_Button5_Click);
                Shit.NYX_Button button = this._NyX_Button5;
            Label_001A:
                num4 = -1748794411;
            Label_0026:;
                int num5 = -562049427;
                int num3 = 0x4d2;
                switch ((((((~((--(-1470909365 ^ -2054747100) ^ ((-753930325 - ~-1053682299) - ((0x4ef6be65 + -52884918) - ~0x30b96dbb))) - num5) * -1509949983) + (-1538000043 + -1293208263)) ^ 0x19427307) + num4) % 7))
                {
                    case 0:
                        goto Label_001A;

                    case 2:
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = -427515614;
                        goto Label_0026;

                    case 3:
                        goto Label_01EC;

                    case 4:
                        goto Label_026E;

                    case 5:
                        goto Label_0230;

                    case 6:
                        goto Label_0390;
                }
                goto Label_03D0;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xbf];
                goto Label_0026;
                this._NyX_Button5 = value;
                button = this._NyX_Button5;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xc1];
                goto Label_0026;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1529231023;
                goto Label_0026;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                goto Label_0026;
            }
        }

        internal virtual Shit.NYX_Button NyX_Button4
        {
            [CompilerGenerated]
            get => 
                this._NyX_Button4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x5af6374;
                EventHandler handler = new EventHandler(this.NyX_Button4_Click);
                Shit.NYX_Button button = this._NyX_Button4;
            Label_001A:
                num4 = 0x1fac052b;
            Label_0026:;
                int num5 = -1951257420;
                int num3 = 0x4d2;
                switch ((((-(-(num5 - -~0x422c76c2) ^ -(0x741196fc + -71829969)) ^ -733659561) + num4) % 7))
                {
                    case 0:
                        goto Label_01CA;

                    case 1:
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = 0x693ebd25;
                        goto Label_0026;

                    case 2:
                        goto Label_0247;

                    case 3:
                        goto Label_036D;

                    case 5:
                        goto Label_001A;

                    case 6:
                        goto Label_020D;
                }
                goto Label_03B0;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xc2];
                goto Label_0026;
                this._NyX_Button4 = value;
                button = this._NyX_Button4;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xc4];
                goto Label_0026;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x7aca2784;
                goto Label_0026;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                goto Label_0026;
            }
        }

        internal virtual Shit.NYX_Button NyX_Button3
        {
            [CompilerGenerated]
            get => 
                this._NyX_Button3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                Shit.NYX_Button button;
                int num4;
                uint num = 0xae296799;
                EventHandler handler = new EventHandler(this.NyX_Button3_Click);
            Label_0013:
                num4 = 0x6a609c07;
            Label_001F:;
                int num5 = 0x1fede37e;
                int num3 = 0x4d2;
                switch ((((0xf416db6 - ((((num5 ^ --~(0x5ca209d7 - -1611060858)) ^ (-278834200 + -334686535)) + ~(0x7a0d5c0d - 0xad37ecb)) - (-1945770667 - -318097948))) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_0013;

                    case 1:
                        goto Label_03B0;

                    case 2:
                        goto Label_0287;

                    case 3:
                        button = this._NyX_Button3;
                        num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                        goto Label_001F;

                    case 4:
                        goto Label_0254;

                    case 5:
                        goto Label_00F2;

                    case 6:
                        goto Label_0214;
                }
                goto Label_03F3;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1062378025;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                goto Label_001F;
                this._NyX_Button3 = value;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xc6];
                goto Label_001F;
                button = this._NyX_Button3;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x48b7d074;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xc7];
                goto Label_001F;
            }
        }

        internal virtual Shit.NYX_Button NyX_Button2
        {
            [CompilerGenerated]
            get => 
                this._NyX_Button2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                Shit.NYX_Button button;
                int num4;
                uint num = 0xb131a35c;
                EventHandler handler = new EventHandler(this.NyX_Button2_Click);
            Label_0013:
                num4 = 0x7d450e72;
            Label_001F:;
                int num5 = -176472924;
                int num3 = 0x4d2;
                switch (((((num5 ^ (-711507879 * -2037336584)) - -(-1332484601 + (-1503789797 ^ -572492048))) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_023D;

                    case 1:
                        goto Label_020D;

                    case 2:
                        goto Label_0013;

                    case 3:
                        goto Label_0368;

                    case 4:
                        goto Label_01C9;

                    case 5:
                        button = this._NyX_Button2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = -75098576;
                        goto Label_001F;
                }
                goto Label_03A8;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[200];
                goto Label_001F;
                this._NyX_Button2 = value;
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_001F;
                button = this._NyX_Button2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1907682399;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                goto Label_001F;
            }
        }

        internal virtual Shit.NYX_Button NyX_Button1
        {
            [CompilerGenerated]
            get => 
                this._NyX_Button1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                Shit.NYX_Button button;
                int num4;
                uint num = 0xf95d4f92;
                EventHandler handler = new EventHandler(this.NyX_Button1_Click);
            Label_0013:
                num4 = -1535639170;
            Label_001F:;
                int num5 = -1341101616;
                int num3 = 0x4d2;
                switch ((((~(((~(0x410c1bd9 ^ 0x38f2da0c) ^ ((0x715b8451 - -1597472534) + (-1500099728 + -76316308))) - (num5 ^ (-972182526 ^ (-~0x22b020b + -131348987)))) * 0x1113df37) ^ -374874921) + num4) >> 0x10))
                {
                    case 1:
                        button = this._NyX_Button1;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = 0x648641ef;
                        goto Label_001F;

                    case 2:
                        goto Label_032B;

                    case 3:
                        goto Label_01E7;

                    case 4:
                        goto Label_0013;

                    case 5:
                        goto Label_022A;
                }
                goto Label_036A;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                goto Label_001F;
                this._NyX_Button1 = value;
                button = this._NyX_Button1;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x4c6bbd0e;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
                goto Label_001F;
            }
        }

        internal virtual Shit.CrystalClearTextBox CrystalClearTextBox1
        {
            [CompilerGenerated]
            get => 
                this._CrystalClearTextBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._CrystalClearTextBox1 = value);
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Label3 = value);
        }

        internal virtual ListView ListView2
        {
            [CompilerGenerated]
            get => 
                this._ListView2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x894d410e;
                EventHandler handler = new EventHandler(this.ListView2_SelectedIndexChanged);
                ListView view = this._ListView2;
            Label_001A:
                num4 = 0x8cabdcb;
            Label_0026:;
                int num5 = 0x5710dc0b;
                int num3 = 0x4d2;
                switch ((((0x5ec4ebb9 - (((((--674712681 + (-1323594544 + 0x490f4f60)) + (-232689223 + ~-559889110)) - (num5 * 0x330f4f)) ^ ((-1555477397 * -659241917) ^ (-1915400646 - -2105628991))) * 0x50d8fde7)) + num4) % 7))
                {
                    case 0:
                        goto Label_001A;

                    case 1:
                        goto Label_01EE;

                    case 2:
                        goto Label_0392;

                    case 3:
                        goto Label_0268;

                    case 4:
                        goto Label_0232;

                    case 6:
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = 0x50401b3e;
                        goto Label_0026;
                }
                goto Label_03D5;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xca];
                goto Label_0026;
                this._ListView2 = value;
                view = this._ListView2;
                num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
                goto Label_0026;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x810e957;
                goto Label_0026;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xcc];
                goto Label_0026;
            }
        }

        internal virtual ColumnHeader ColumnHeader1
        {
            [CompilerGenerated]
            get => 
                this._ColumnHeader1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._ColumnHeader1 = value);
        }

        internal virtual ColumnHeader ColumnHeader6
        {
            [CompilerGenerated]
            get => 
                this._ColumnHeader6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._ColumnHeader6 = value);
        }

        internal virtual ColumnHeader ColumnHeader7
        {
            [CompilerGenerated]
            get => 
                this._ColumnHeader7;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._ColumnHeader7 = value);
        }

        internal virtual Timer Timer7
        {
            [CompilerGenerated]
            get => 
                this._Timer7;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Timer7 = value);
        }

        internal virtual Timer Timer8
        {
            [CompilerGenerated]
            get => 
                this._Timer8;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Timer8 = value);
        }

        internal virtual Timer Timer1
        {
            [CompilerGenerated]
            get => 
                this._Timer1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x56d7310a;
                EventHandler handler = new EventHandler(this.Timer1_Tick);
                Timer timer = this._Timer1;
                if (timer == null)
                {
                    goto Label_00CB;
                }
            Label_0020:
                num4 = -673074478;
            Label_002C:;
                int num5 = -918982750;
                int num3 = 0x4d2;
                switch ((((---~num5 ^ -1536697668) + num4) % 6))
                {
                    case 0:
                        goto Label_022A;

                    case 1:
                        goto Label_00FF;

                    case 2:
                        goto Label_0020;

                    case 3:
                        *?(handler);
                        num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                        goto Label_002C;

                    case 5:
                        goto Label_00CB;
                }
                goto Label_0269;
                this._Timer1 = value;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xce];
                goto Label_002C;
                timer = this._Timer1;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1708801602;
                goto Label_002C;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                goto Label_002C;
            }
        }

        internal virtual Timer Timer2
        {
            [CompilerGenerated]
            get => 
                this._Timer2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x360d4cc9;
                EventHandler handler = new EventHandler(this.Timer2_Tick);
                Timer timer = this._Timer2;
                if (timer == null)
                {
                    goto Label_0111;
                }
            Label_0020:
                num4 = 0x66697384;
            Label_002C:;
                int num5 = -1745419429;
                int num3 = 0x4d2;
                switch (((-(-((num5 ^ (~((0x735559ce - -702608536) * 0x3a1ae7d5) - (-(0x6da6180a - -530245505) - (~-599476188 - (0x2a565bd5 - -1406734525))))) - -(--504027092 + (0x3d1b7489 * -355544691))) - (0x3b0ce53d * 0x52e50c3c)) + num4) % 5))
                {
                    case 0:
                        goto Label_0020;

                    case 1:
                        goto Label_0212;

                    case 2:
                        *?(handler);
                        num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                        goto Label_002C;

                    case 4:
                        goto Label_0111;
                }
                goto Label_0252;
                this._Timer2 = value;
                timer = this._Timer2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x2fa3eb81;
                goto Label_002C;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                goto Label_002C;
            }
        }

        internal virtual Timer Timer3
        {
            [CompilerGenerated]
            get => 
                this._Timer3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x270d04cc;
                EventHandler handler = new EventHandler(this.Timer3_Tick);
                Timer timer = this._Timer3;
                if (timer == null)
                {
                    goto Label_0106;
                }
            Label_0020:
                num4 = -632423446;
            Label_002C:;
                int num5 = -930757732;
                int num3 = 0x4d2;
                switch (((((((((-0xe968153 - (-574982803 + 0x448220ca)) - (0x12a11ff0 - (-852157198 ^ -845774993))) - (num5 - (-515687173 * --798445448))) * -757333577) + (0x4e1a8719 - 0x1f14c103)) - -937005463) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_0020;

                    case 1:
                        goto Label_0208;

                    case 2:
                        goto Label_0106;

                    case 4:
                        *?(handler);
                        num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                        goto Label_002C;
                }
                goto Label_024C;
                this._Timer3 = value;
                timer = this._Timer3;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -2026180847;
                goto Label_002C;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xcf];
                goto Label_002C;
            }
        }

        internal virtual Timer Timer4
        {
            [CompilerGenerated]
            get => 
                this._Timer4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Timer4 = value);
        }

        internal virtual Timer Timer5
        {
            [CompilerGenerated]
            get => 
                this._Timer5;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Timer5 = value);
        }

        internal virtual Timer Timer6
        {
            [CompilerGenerated]
            get => 
                this._Timer6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Timer6 = value);
        }

        internal virtual Timer Update
        {
            [CompilerGenerated]
            get => 
                this._Update;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                Timer timer;
                int num4;
                EventHandler handler = new EventHandler(this.Update_Tick);
            Label_0013:
                num4 = 0x18092d93;
            Label_001F:;
                int num5 = -1783627274;
                int num3 = 0x4d2;
                switch (((--(-~(-346987348 - 0x2d50753b) - -num5) + num4) % 6))
                {
                    case 0:
                        goto Label_0013;

                    case 1:
                        timer = this._Update;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = 0x1d7f6d3;
                        goto Label_001F;

                    case 2:
                        goto Label_01F6;

                    case 3:
                        goto Label_02FB;

                    case 5:
                        goto Label_01B2;
                }
                goto Label_033E;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xd0];
                goto Label_001F;
                this._Update = value;
                timer = this._Update;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x15f3e55c;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xd1];
                goto Label_001F;
            }
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

        internal virtual Shit.NYX_Button NyX_Button6
        {
            [CompilerGenerated]
            get => 
                this._NyX_Button6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                Shit.NYX_Button button;
                int num4;
                uint num = 0xbbd72572;
                EventHandler handler = new EventHandler(this.NyX_Button6_Click);
            Label_0013:
                num4 = -1547384002;
            Label_001F:;
                int num5 = -250166387;
                int num3 = 0x4d2;
                switch (((-(-((num5 ^ (((--1662405307 - ~0x47bac380) - ((-627853131 ^ 0x4d31dc11) ^ ~-2123764914)) - --974109013)) * 0x629e5b65) * 0x22fdbf19) + num4) % 8))
                {
                    case 0:
                        goto Label_0213;

                    case 1:
                        button = this._NyX_Button6;
                        num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                        goto Label_001F;

                    case 2:
                        goto Label_00EC;

                    case 3:
                        goto Label_0013;

                    case 4:
                        goto Label_0286;

                    case 5:
                        goto Label_0257;

                    case 6:
                        goto Label_03B0;
                }
                goto Label_03F3;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -519607908;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[210];
                goto Label_001F;
                this._NyX_Button6 = value;
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_001F;
                button = this._NyX_Button6;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x3396ca7e;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                goto Label_001F;
            }
        }

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this._TabPage2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._TabPage2 = value);
        }

        internal virtual ListView ListView1
        {
            [CompilerGenerated]
            get => 
                this._ListView1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._ListView1 = value);
        }

        internal virtual ColumnHeader ColumnHeader2
        {
            [CompilerGenerated]
            get => 
                this._ColumnHeader2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._ColumnHeader2 = value);
        }

        internal virtual ColumnHeader ColumnHeader3
        {
            [CompilerGenerated]
            get => 
                this._ColumnHeader3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._ColumnHeader3 = value);
        }

        internal virtual ColumnHeader ColumnHeader4
        {
            [CompilerGenerated]
            get => 
                this._ColumnHeader4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._ColumnHeader4 = value);
        }
    }
}

