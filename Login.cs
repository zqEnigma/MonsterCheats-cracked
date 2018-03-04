namespace Shit
{
    using Microsoft.VisualBasic.CompilerServices;
    using Shit.My;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Login : Form
    {
        private IContainer components;
        [CompilerGenerated, AccessedThroughProperty("NyX_Theme1")]
        private Shit.NYX_Theme _NyX_Theme1;
        [AccessedThroughProperty("NyX_Button2"), CompilerGenerated]
        private Shit.NYX_Button _NyX_Button2;
        [AccessedThroughProperty("NyX_Button1"), CompilerGenerated]
        private Shit.NYX_Button _NyX_Button1;
        [CompilerGenerated, AccessedThroughProperty("PictureBox2")]
        private PictureBox _PictureBox2;
        [AccessedThroughProperty("PictureBox1"), CompilerGenerated]
        private PictureBox _PictureBox1;
        [CompilerGenerated, AccessedThroughProperty("CrystalClearTextBox2")]
        private Shit.CrystalClearTextBox _CrystalClearTextBox2;
        [CompilerGenerated, AccessedThroughProperty("CrystalClearTextBox1")]
        private Shit.CrystalClearTextBox _CrystalClearTextBox1;
        [AccessedThroughProperty("NyX_ControlBox1"), CompilerGenerated]
        private Shit.NYX_ControlBox _NyX_ControlBox1;
        [AccessedThroughProperty("TextBox1"), CompilerGenerated]
        private TextBox _TextBox1;
        [AccessedThroughProperty("LoLz"), CompilerGenerated]
        private Timer _LoLz;
        public string web;
        public string forum;
        public string dlUrl;

        public Login()
        {
            // This item is obfuscated and can not be translated.
            int num4;
        Label_000C:
            num4 = -1071372751;
        Label_0017:;
            int num5 = 0x34c80bdb;
            switch ((((-(((num5 - ((-(-1358721191 * 0x66eaa529) * 0x27c66a2d) - ((0x202da869 * ~0x19b09fd9) ^ ~(0x4ab12439 * -1295275423)))) ^ (((0x1552e810 ^ -1531989068) - (0x76ca57f * 0x3d7d2719)) - ((0x7085ec61 + -737293248) * 0x77aba1cb))) + ((0x504e5018 - 0x112557b5) + ~0x641e9a01)) ^ 0x61a0c551) + num4) % 4))
            {
                case 0:
                    goto Label_000C;

                case 1:
                    *?(new EventHandler(this.Login_Load));
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x10b];
                    goto Label_0017;

                case 3:
                    goto Label_011C;
            }
            goto Label_0172;
            this.web = "http://82.208.17.176/";
            this.forum = "http://82.208.17.176/";
            /¶õ(this);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x10c];
            goto Label_0017;
        }

        public void ChangeVersion(string version)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            Shit.My.MyProject.Forms.Form1.Label3.Text = version;
        Label_001B:
            num4 = 0x27cd699;
        Label_0026:;
            int num5 = -1032676982;
            switch ((((~(~(num5 - ((~(-1067579165 + 0x42147330) + -~0x4d74cafb) ^ (0x450fd407 + ~(-137593611 * 0xdb96360)))) + ~~0x660e99bb) * -2119798425) + num4) >> 0x10))
            {
                case 0:
                    goto Label_001B;

                case 2:
                    Shit.Inject.lversion = version;
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x13b];
                    goto Label_0026;
            }
            goto Label_00DC;
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                uint num;
                uint num2;
                int num4;
                int expressionStack_121_0;
                int expressionStack_121_1;
                if (!disposing)
                {
                    return;
                }
            Label_000C:
                num4 = 0x7fc8349a;
                int expressionStack_17_0 = -1880035330;
            Label_0017:;
                int num5 = expressionStack_17_0;
                int num3 = 0x4d2;
                switch (((num2 = (uint) (((num5 * -1454122351) - -1326092424) + num4)) >> 0x10))
                {
                    case 0:
                        ÂÔç(this.components);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x10d];
                        expressionStack_17_0 = (((int) num2) - 0x1f203965) ^ -719116484;
                        goto Label_0017;

                    case 1:
                        return;

                    case 2:
                        goto Label_000C;

                    case 3:
                        if (this.components == null)
                        {
                            break;
                        }
                        num3 = 0x4d2;
                        expressionStack_121_1 = 0x2325cbb1;
                        goto Label_0121;

                    default:
                        return;
                }
                expressionStack_121_1 = -978662479;
            Label_0121:
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -855943625;
                expressionStack_17_0 = expressionStack_121_1 ^ ((int) (num2 * 0x3fd2735e));
                goto Label_0017;
            }
            finally
            {
                VÛ(this, disposing);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x623589ba;
            this.components = (IContainer) À%Ã±();
            ComponentResourceManager manager = (ComponentResourceManager) bä(>+Zí(typeof(Shit.Login).TypeHandle));
            this.NyX_Theme1 = (Shit.NYX_Theme) ä{Ãdâ();
            this.TextBox1 = (TextBox) ¨~º();
        Label_0050:
            num4 = -141275639;
        Label_005C:;
            int num5 = 0x77a9fc5f;
            switch (((((~(num5 ^ --~(-1754251749 + -201306012)) - ~-0x116e4fd6) + (0x46099f94 * -441090161)) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0612;

                case 1:
                    goto Label_12B9;

                case 2:
                    goto Label_0997;

                case 3:
                    goto Label_06BA;

                case 4:
                    goto Label_0220;

                case 5:
                    goto Label_1064;

                case 6:
                    goto Label_084E;

                case 7:
                    goto Label_0050;

                case 8:
                    goto Label_0355;

                case 9:
                    goto Label_0B40;

                case 10:
                    goto Label_14BE;

                case 11:
                    goto Label_1198;

                case 12:
                    goto Label_18BA;

                case 13:
                    goto Label_09D1;

                case 14:
                    goto Label_143C;

                case 15:
                    goto Label_0C61;

                case 0x10:
                    goto Label_0DDF;

                case 0x11:
                    goto Label_0B06;

                case 0x12:
                    goto Label_17A9;

                case 0x13:
                    goto Label_1A1B;

                case 20:
                    goto Label_05D8;

                case 0x15:
                    goto Label_122B;

                case 0x16:
                    goto Label_0D93;

                case 0x17:
                    goto Label_0587;

                case 0x18:
                    goto Label_1917;

                case 0x19:
                    goto Label_0E45;

                case 0x1a:
                    goto Label_0765;

                case 0x1b:
                    goto Label_0F64;

                case 0x1c:
                    goto Label_0D55;

                case 0x1d:
                    goto Label_114D;

                case 30:
                    goto Label_11E8;

                case 0x1f:
                    goto Label_0AB5;

                case 0x20:
                    goto Label_06F8;

                case 0x21:
                    goto Label_0CC4;

                case 0x22:
                    goto Label_13A9;

                case 0x23:
                    goto Label_1807;

                case 0x24:
                    goto Label_04F1;

                case 0x25:
                    goto Label_135D;

                case 0x26:
                    goto Label_0663;

                case 0x27:
                    goto Label_16A8;

                case 40:
                    goto Label_0A51;

                case 0x29:
                    goto Label_091B;

                case 0x2a:
                    goto Label_126E;

                case 0x2b:
                    goto Label_199C;

                case 0x2d:
                    goto Label_15BB;

                case 0x2e:
                    this.NyX_ControlBox1 = (Shit.NYX_ControlBox) °9O();
                    this.CrystalClearTextBox2 = (Shit.CrystalClearTextBox) ÷R°á();
                    num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                    goto Label_005C;

                case 0x2f:
                    goto Label_080C;

                case 0x30:
                    goto Label_13F0;

                case 0x31:
                    goto Label_1305;

                case 50:
                    goto Label_1A6E;

                case 0x33:
                    goto Label_186A;

                case 0x34:
                    goto Label_0B91;

                case 0x35:
                    goto Label_0263;

                case 0x36:
                    goto Label_1705;

                case 0x37:
                    goto Label_1568;

                case 0x38:
                    goto Label_0E98;

                case 0x39:
                    goto Label_0895;

                case 0x3a:
                    goto Label_0F22;

                case 0x3b:
                    goto Label_049A;

                case 60:
                    goto Label_0ED3;

                case 0x3d:
                    goto Label_07C4;

                case 0x3e:
                    goto Label_164C;

                case 0x3f:
                    goto Label_175A;

                case 0x40:
                    goto Label_02C1;

                case 0x41:
                    goto Label_08D8;

                case 0x42:
                    goto Label_0440;

                case 0x43:
                    goto Label_0BE0;

                case 0x44:
                    goto Label_0FF1;
            }
            goto Label_1AAD;
            this.CrystalClearTextBox1 = (Shit.CrystalClearTextBox) ÷R°á();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[270];
            goto Label_005C;
            this.PictureBox2 = (PictureBox) â9Å();
            this.PictureBox1 = (PictureBox) â9Å();
            this.NyX_Button2 = (Shit.NYX_Button) K7Dá();
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            this.NyX_Button1 = (Shit.NYX_Button) K7Dá();
            this.LoLz = (Timer) ¾6ÊÜ(this.components);
            CÕ(this.NyX_Theme1);
            BÁ(fÓ(this.PictureBox2);
            BÁ(fÓ(this.PictureBox1);
            =µ§­(this);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x10f];
            goto Label_005C;
            this.NyX_Theme1.Animated = true;
            this.NyX_Theme1.BorderStyle = FormBorderStyle.None;
            this.NyX_Theme1.Colors = new Shit.Bloom[0];
            yã\B(*?(), this.TextBox1);
            yã\B(*?(), this.NyX_ControlBox1);
            yã\B(*?(), this.CrystalClearTextBox2);
            yã\B(*?(), this.CrystalClearTextBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x110];
            goto Label_005C;
            yã\B(*?(), this.PictureBox2);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x111];
            goto Label_005C;
            yã\B(*?(), this.PictureBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x112];
            goto Label_005C;
            yã\B(*?(), this.NyX_Button2);
            yã\B(*?(), this.NyX_Button1);
            this.NyX_Theme1.Customization = "";
            this.NyX_Theme1.Dock = DockStyle.Fill;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x113];
            goto Label_005C;
            this.NyX_Theme1.Font = (Font) ·)©ê("Arial", 9f);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            this.NyX_Theme1.Image = null;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            *?(new Point(0, 0));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x114];
            goto Label_005C;
            this.NyX_Theme1.Movable = true;
            *?("NyX_Theme1");
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_005C;
            this.NyX_Theme1.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x115];
            goto Label_005C;
            this.NyX_Theme1.Sizable = true;
            *?(new Size(420, 0x1eb));
            this.NyX_Theme1.SmartBounds = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x116];
            goto Label_005C;
            this.NyX_Theme1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            *?(0);
            this.NyX_Theme1.Text = "Login";
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_005C;
            this.NyX_Theme1.TransparencyKey = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x23]();
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_005C;
            this.NyX_Theme1.Transparent = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x117];
            goto Label_005C;
            this.TextBox1.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[100]();
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_005C;
            *?(0);
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_005C;
            *?(0);
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            this.TextBox1.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            *?(0);
            *?(new Point(0x58, 0x114));
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            this.TextBox1.Multiline = true;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            *?("TextBox1");
            *?(1);
            *?(new Size(0xda, 0x65));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[280];
            goto Label_005C;
            *?(7);
            this.NyX_ControlBox1.Colors = new Shit.Bloom[0];
            this.NyX_ControlBox1.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_005C;
            this.NyX_ControlBox1.Font = (Font) ·)©ê("Verdana", 8f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x119];
            goto Label_005C;
            this.NyX_ControlBox1.Image = null;
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_005C;
            *?(new Point(0x169, 3));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x11a];
            goto Label_005C;
            *?("NyX_ControlBox1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x11b];
            goto Label_005C;
            this.NyX_ControlBox1.NoRounding = false;
            *?(new Size(0x2f, 20));
            *?(6);
            this.NyX_ControlBox1.Text = "NyX_ControlBox1";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x11c];
            goto Label_005C;
            this.NyX_ControlBox1.Transparent = false;
            this.CrystalClearTextBox2.Colors = new Shit.Bloom[0];
            this.CrystalClearTextBox2.Customization = "";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x11d];
            goto Label_005C;
            this.CrystalClearTextBox2.Font = (Font) ·)©ê("Verdana", 8f);
            this.CrystalClearTextBox2.Image = null;
            *?(new Point(130, 0x9d));
            this.CrystalClearTextBox2.MaxLength = 0x7fff;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x11e];
            goto Label_005C;
            this.CrystalClearTextBox2.Multiline = false;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            *?("CrystalClearTextBox2");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x11f];
            goto Label_005C;
            this.CrystalClearTextBox2.NoRounding = false;
            this.CrystalClearTextBox2.ReadOnly = false;
            *?(new Size(0xb0, 0x18));
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            *?(5);
            this.CrystalClearTextBox2.TextAlign = HorizontalAlignment.Left;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_005C;
            this.CrystalClearTextBox2.Transparent = false;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            this.CrystalClearTextBox2.UseSystemPasswordChar = true;
            this.CrystalClearTextBox1.Colors = new Shit.Bloom[0];
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x120];
            goto Label_005C;
            this.CrystalClearTextBox1.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_005C;
            this.CrystalClearTextBox1.Font = (Font) ·)©ê("Verdana", 8f);
            this.CrystalClearTextBox1.Image = null;
            *?(new Point(130, 0x69));
            this.CrystalClearTextBox1.MaxLength = 0x7fff;
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_005C;
            this.CrystalClearTextBox1.Multiline = false;
            *?("CrystalClearTextBox1");
            this.CrystalClearTextBox1.NoRounding = false;
            this.CrystalClearTextBox1.ReadOnly = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x121];
            goto Label_005C;
            *?(new Size(0xb0, 0x18));
            *?(4);
            this.CrystalClearTextBox1.TextAlign = HorizontalAlignment.Left;
            this.CrystalClearTextBox1.Transparent = false;
            this.CrystalClearTextBox1.UseSystemPasswordChar = false;
            this.PictureBox2.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            *?((Image) ]l¶+(manager, "PictureBox2.Image"));
            *?(new Point(0x58, 0x99));
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_005C;
            *?("PictureBox2");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[290];
            goto Label_005C;
            *?(new Size(0x20, 0x20));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x123];
            goto Label_005C;
            *?(1);
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            *?(3);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_005C;
            *?(0);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x124];
            goto Label_005C;
            this.PictureBox1.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x125];
            goto Label_005C;
            *?((Image) ]l¶+(manager, "PictureBox1.Image"));
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            *?(new Point(0x58, 0x65));
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_005C;
            *?("PictureBox1");
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            *?(new Size(0x20, 0x20));
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_005C;
            *?(1);
            *?(2);
            *?(0);
            this.NyX_Button2.Colors = new Shit.Bloom[0];
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x126];
            goto Label_005C;
            this.NyX_Button2.Cursor = (Cursor) *CONSOLESCREENBUFFERINFO[0x5c]();
            this.NyX_Button2.Customization = "";
            this.NyX_Button2.Font = (Font) ·)©ê("Arial", 8f);
            this.NyX_Button2.Image = null;
            *?(new Point(0x10d, 0x1c3));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x127];
            goto Label_005C;
            *?("NyX_Button2");
            this.NyX_Button2.NoRounding = false;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_005C;
            *?(new Size(0x85, 0x1c));
            *?(1);
            this.NyX_Button2.Text = "Register";
            this.NyX_Button2.Transparent = false;
            this.NyX_Button1.Colors = new Shit.Bloom[0];
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            this.NyX_Button1.Cursor = (Cursor) *CONSOLESCREENBUFFERINFO[0x5c]();
            this.NyX_Button1.Customization = "";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x128];
            goto Label_005C;
            this.NyX_Button1.Font = (Font) ·)©ê("Arial", 8f);
            this.NyX_Button1.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x129];
            goto Label_005C;
            *?(new Point(130, 0xd1));
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_005C;
            *?("NyX_Button1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x12a];
            goto Label_005C;
            this.NyX_Button1.NoRounding = false;
            *?(new Size(0x85, 0x1c));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x12b];
            goto Label_005C;
            *?(0);
            this.NyX_Button1.Text = "Login";
            this.NyX_Button1.Transparent = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[300];
            goto Label_005C;
            *?(new SizeF(6f, 13f));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x12d];
            goto Label_005C;
            *?(1);
            *?(new Size(420, 0x1eb));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            yã\B(*?(), this.NyX_Theme1);
            *?(0);
            *?((Icon) ]l¶+(manager, "$this.Icon"));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x12e];
            goto Label_005C;
            *?("Login");
            this.Text = "Login";
            *?(*CONSOLESCREENBUFFERINFO[0x23]());
            4Ü'Ô(this.NyX_Theme1, false);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x12f];
            goto Label_005C;
            òS4É:(this.NyX_Theme1);
            ­ªáh(this.PictureBox2);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x130];
            goto Label_005C;
            ­ªáh(this.PictureBox1);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            ©`Vñ(this, false);
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void LoLz_Tick(object sender, EventArgs e)
        {
        }

        private void NyX_Button1_Click(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x5b6855fc;
            if (!((°qX¬ï(this.CrystalClearTextBox1.Text, "", false) == 0) | (°qX¬ï(this.CrystalClearTextBox2.Text, "", false) == 0)))
            {
                goto Label_0120;
            }
        Label_0048:
            num4 = 0x3801bbaf;
        Label_0054:;
            int num5 = 0x60c43ef2;
            int num3 = 0x4d2;
            switch (((~(-((num5 * -210214683) * -765519445) * 0x23861c75) + num4) % 7))
            {
                case 0:
                    goto Label_0178;

                case 2:
                    break;

                case 3:
                    goto Label_0048;

                case 4:
                    CDsè(this.TextBox1, ý^¤)("Please enter your username and password!", (string) *CONSOLESCREENBUFFERINFO[0x6d]()));
                    return;

                case 5:
                    goto Label_032A;

                case 6:
                    goto Label_02C0;

                default:
                    goto Label_0371;
            }
        Label_0120:
            CDsè(this.TextBox1, ý^¤)("Logging ..", (string) *CONSOLESCREENBUFFERINFO[0x6d]()));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x13e];
            goto Label_0054;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x1e41836c;
            goto Label_0054;
            CDsè(this.TextBox1, ý^¤)("Logged !", (string) *CONSOLESCREENBUFFERINFO[0x6d]()));
            Lmå(this);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0054;
            þÆm(Shit.My.MyProject.Forms.Test);
            return;
            CDsè(this.TextBox1, îò¾a("Invalid account, please try again!", (string) *CONSOLESCREENBUFFERINFO[0x6d](), "Register if you don't have an account.", (string) *CONSOLESCREENBUFFERINFO[0x6d]()));
        }

        private void NyX_Button2_Click(object sender, EventArgs e)
        {
            ÔP#("http://monster-cheats.com/member.php?action=register");
        }

        private void NyX_Theme1_Click(object sender, EventArgs e)
        {
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
                uint num = 0xa5901b39;
                EventHandler handler = new EventHandler(this.NyX_Theme1_Click);
            Label_0013:
                num4 = 0x62955e80;
            Label_001F:;
                int num5 = -856841933;
                int num3 = 0x4d2;
                switch ((((~(num5 ^ (-410675080 - (0x1224de25 - ~(0x387dd59 - 0xe7bb245)))) - ~(0x66cd89fe + -1756443512)) + num4) % 9))
                {
                    case 0:
                        goto Label_0279;

                    case 2:
                        goto Label_03D7;

                    case 3:
                        goto Label_00E1;

                    case 4:
                        goto Label_0207;

                    case 5:
                        goto Label_0013;

                    case 6:
                        goto Label_02B4;

                    case 7:
                        theme = this._NyX_Theme1;
                        num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                        goto Label_001F;

                    case 8:
                        goto Label_024A;
                }
                goto Label_041A;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x139c5225;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x131];
                goto Label_001F;
                this._NyX_Theme1 = value;
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                goto Label_001F;
                theme = this._NyX_Theme1;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x133];
                goto Label_001F;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x1770aa6a;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
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
                int num4;
                uint num = 0x142609e6;
                EventHandler handler = new EventHandler(this.NyX_Button2_Click);
                Shit.NYX_Button button = this._NyX_Button2;
                if (button == null)
                {
                    goto Label_012E;
                }
            Label_0020:
                num4 = -1593948966;
            Label_002C:;
                int num5 = -1185677641;
                int num3 = 0x4d2;
                switch ((((-(((num5 - (((0x7c49b47 + (0x9ff0e0d - -984575682)) * 0x78755003) ^ (((0x2a529ecd * -439204064) - (-1119663953 + 0x37099b83)) ^ ((0x3647f213 ^ -1753466250) - (0x3db19189 ^ 0x537e9c05))))) * -1620266195) - ((-1340974009 * 0x1e44cd03) * -1596145649)) * -327671345) + num4) % 7))
                {
                    case 1:
                        *?(handler);
                        num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                        goto Label_002C;

                    case 2:
                        goto Label_0020;

                    case 3:
                        goto Label_0198;

                    case 4:
                        goto Label_012E;

                    case 5:
                        goto Label_0161;

                    case 6:
                        goto Label_02BB;
                }
                goto Label_02FF;
                this._NyX_Button2 = value;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x135];
                goto Label_002C;
                button = this._NyX_Button2;
                num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
                goto Label_002C;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x7322035a;
                goto Label_002C;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[310];
                goto Label_002C;
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
                uint num = 0x1e7ef31f;
                EventHandler handler = new EventHandler(this.NyX_Button1_Click);
            Label_0013:
                num4 = 0x559a55fc;
            Label_001F:;
                int num5 = 0x57d14abf;
                int num3 = 0x4d2;
                switch (((-((((num5 * -540538115) - ~((0x1ff54583 ^ -581994172) ^ -0x3a8e9642)) ^ -0x132392e3) ^ (0x59abf671 * 0x13cac69c)) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_027F;

                    case 1:
                        goto Label_02B9;

                    case 2:
                        goto Label_00EA;

                    case 3:
                        goto Label_024B;

                    case 4:
                        button = this._NyX_Button1;
                        num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                        goto Label_001F;

                    case 5:
                        goto Label_03DB;

                    case 6:
                        goto Label_020C;

                    case 8:
                        goto Label_0013;
                }
                goto Label_041A;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x1246c0c1;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
                goto Label_001F;
                this._NyX_Button1 = value;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x138];
                goto Label_001F;
                button = this._NyX_Button1;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x139];
                goto Label_001F;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -30234621;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                goto Label_001F;
            }
        }

        internal virtual PictureBox PictureBox2
        {
            [CompilerGenerated]
            get => 
                this._PictureBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._PictureBox2 = value);
        }

        internal virtual PictureBox PictureBox1
        {
            [CompilerGenerated]
            get => 
                this._PictureBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._PictureBox1 = value);
        }

        internal virtual Shit.CrystalClearTextBox CrystalClearTextBox2
        {
            [CompilerGenerated]
            get => 
                this._CrystalClearTextBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._CrystalClearTextBox2 = value);
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

        internal virtual Shit.NYX_ControlBox NyX_ControlBox1
        {
            [CompilerGenerated]
            get => 
                this._NyX_ControlBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._NyX_ControlBox1 = value);
        }

        internal virtual TextBox TextBox1
        {
            [CompilerGenerated]
            get => 
                this._TextBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._TextBox1 = value);
        }

        internal virtual Timer LoLz
        {
            [CompilerGenerated]
            get => 
                this._LoLz;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                Timer timer;
                int num4;
                uint num = 0x26da81f2;
                EventHandler handler = new EventHandler(this.LoLz_Tick);
            Label_0013:
                num4 = 0x5554d5fe;
            Label_001F:;
                int num5 = -618938484;
                int num3 = 0x4d2;
                switch ((((-(~~num5 ^ (~0x1e850dcb + (-1186595517 * 0x56afe56e))) - -1535820165) + num4) % 8))
                {
                    case 0:
                        goto Label_0013;

                    case 1:
                        timer = this._LoLz;
                        num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                        goto Label_001F;

                    case 2:
                        goto Label_0263;

                    case 3:
                        goto Label_00D2;

                    case 4:
                        goto Label_0390;

                    case 6:
                        goto Label_0234;

                    case 7:
                        goto Label_01F5;
                }
                goto Label_03D0;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x2e8659a5;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_001F;
                this._LoLz = value;
                num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
                goto Label_001F;
                timer = this._LoLz;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x1a53e273;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                goto Label_001F;
            }
        }
    }
}

