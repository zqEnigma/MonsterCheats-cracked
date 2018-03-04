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
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;
    using TypeInfo;

    [DesignerGenerated]
    public class Settings : Form
    {
        private IContainer components;
        [AccessedThroughProperty("NyX_Theme1"), CompilerGenerated]
        private Shit.NYX_Theme _NyX_Theme1;
        [AccessedThroughProperty("NyX_ControlBox1"), CompilerGenerated]
        private Shit.NYX_ControlBox _NyX_ControlBox1;
        [CompilerGenerated, AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("CrystalClearTextBox1"), CompilerGenerated]
        private Shit.CrystalClearTextBox _CrystalClearTextBox1;
        [AccessedThroughProperty("NyX_Button1"), CompilerGenerated]
        private Shit.NYX_Button _NyX_Button1;
        [CompilerGenerated, AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;
        [CompilerGenerated, AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Timer3"), CompilerGenerated]
        private Timer _Timer3;
        [CompilerGenerated, AccessedThroughProperty("Timer2")]
        private Timer _Timer2;
        [AccessedThroughProperty("FolderBrowserDialog1"), CompilerGenerated]
        private FolderBrowserDialog _FolderBrowserDialog1;
        [CompilerGenerated, AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [CompilerGenerated, AccessedThroughProperty("NyX_CheckBox1")]
        private Shit.NYX_CheckBox _NyX_CheckBox1;
        [AccessedThroughProperty("NyX_GroupBox1"), CompilerGenerated]
        private Shit.NYX_GroupBox _NyX_GroupBox1;
        [CompilerGenerated, AccessedThroughProperty("NyX_GroupBox2")]
        private Shit.NYX_GroupBox _NyX_GroupBox2;
        [AccessedThroughProperty("NyX_CheckBox3"), CompilerGenerated]
        private Shit.NYX_CheckBox _NyX_CheckBox3;
        [AccessedThroughProperty("NyX_CheckBox2"), CompilerGenerated]
        private Shit.NYX_CheckBox _NyX_CheckBox2;
        public string lang;
        public string path;

        public Settings()
        {
            *?(new EventHandler(this.Settings_Load));
            ¢f(this);
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                uint num;
                uint num2;
                int num4;
                int expressionStack_11F_0;
                int expressionStack_11F_1;
                if (!disposing)
                {
                    return;
                }
            Label_000C:
                num4 = -176668154;
                int expressionStack_17_0 = 0x734ca4c0;
            Label_0017:;
                int num5 = expressionStack_17_0;
                int num3 = 0x4d2;
                switch (((num2 = (uint) ((~---num5 ^ 0x79c41945) + num4)) >> 0x10))
                {
                    case 0:
                        ÂÔç(this.components);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1ac];
                        expressionStack_17_0 = (((int) num2) + -1682161201) ^ -757465332;
                        goto Label_0017;

                    case 1:
                        if (this.components != null)
                        {
                            break;
                        }
                        num3 = 0x4d2;
                        expressionStack_11F_1 = -727844369;
                        goto Label_011F;

                    case 2:
                        return;

                    case 3:
                        goto Label_000C;

                    default:
                        return;
                }
                expressionStack_11F_1 = -727713297;
            Label_011F:
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1464656043;
                expressionStack_17_0 = expressionStack_11F_1 ^ ((int) (num2 * 0x5efcfa17));
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
            ComponentResourceManager manager;
            int num4;
            uint num = 0x5501ea67;
            this.components = (IContainer) À%Ã±();
        Label_0016:
            num4 = -1618777654;
        Label_0022:;
            int num5 = -736955894;
            switch (((~~-(~num5 ^ ~~(-159481380 ^ -483859867)) + num4) % 0x63))
            {
                case 0:
                    goto Label_0E8F;

                case 1:
                    goto Label_112A;

                case 2:
                    goto Label_23B1;

                case 3:
                    goto Label_0B07;

                case 4:
                    goto Label_18CD;

                case 5:
                    goto Label_0DC2;

                case 6:
                    goto Label_2350;

                case 7:
                    goto Label_177B;

                case 8:
                    goto Label_034E;

                case 9:
                    goto Label_0696;

                case 10:
                    goto Label_187B;

                case 11:
                    goto Label_1821;

                case 12:
                    goto Label_225D;

                case 13:
                    goto Label_1E37;

                case 14:
                    goto Label_0554;

                case 15:
                    goto Label_128D;

                case 0x10:
                    goto Label_1EED;

                case 0x11:
                    goto Label_0FB9;

                case 0x12:
                    goto Label_1168;

                case 0x13:
                    goto Label_0CDB;

                case 20:
                    goto Label_0AC5;

                case 0x15:
                    goto Label_08B7;

                case 0x16:
                    goto Label_12E1;

                case 0x17:
                    goto Label_1486;

                case 0x18:
                    goto Label_1732;

                case 0x19:
                    goto Label_2192;

                case 0x1a:
                    goto Label_1437;

                case 0x1c:
                    goto Label_0704;

                case 0x1d:
                    goto Label_16DA;

                case 30:
                    goto Label_17D5;

                case 0x1f:
                    goto Label_0A80;

                case 0x20:
                    goto Label_1977;

                case 0x21:
                    goto Label_04D1;

                case 0x22:
                    goto Label_0F36;

                case 0x23:
                    goto Label_1D99;

                case 0x24:
                    goto Label_07AF;

                case 0x25:
                    goto Label_15BB;

                case 0x26:
                    goto Label_206D;

                case 0x27:
                    goto Label_0BB7;

                case 40:
                    goto Label_0B75;

                case 0x29:
                    goto Label_1348;

                case 0x2a:
                    goto Label_02A9;

                case 0x2b:
                    goto Label_0016;

                case 0x2c:
                    goto Label_05EC;

                case 0x2d:
                    goto Label_1C05;

                case 0x2e:
                    goto Label_0D84;

                case 0x2f:
                    goto Label_0410;

                case 0x30:
                    goto Label_084E;

                case 0x31:
                    goto Label_080F;

                case 50:
                    goto Label_1606;

                case 0x33:
                    goto Label_1070;

                case 0x34:
                    goto Label_1F38;

                case 0x35:
                    goto Label_19BA;

                case 0x36:
                    goto Label_1FC7;

                case 0x37:
                    goto Label_22FC;

                case 0x38:
                    goto Label_0F7A;

                case 0x39:
                    goto Label_1B29;

                case 0x3a:
                    goto Label_2422;

                case 0x3b:
                    goto Label_13E9;

                case 60:
                    goto Label_1578;

                case 0x3d:
                    goto Label_1A9E;

                case 0x3e:
                    goto Label_1EAF;

                case 0x3f:
                    goto Label_1CCD;

                case 0x40:
                    goto Label_0267;

                case 0x41:
                    goto Label_1D0B;

                case 0x42:
                    goto Label_121B;

                case 0x43:
                    goto Label_0D3E;

                case 0x44:
                    goto Label_153D;

                case 0x45:
                    goto Label_09B3;

                case 70:
                    goto Label_0A35;

                case 0x47:
                    goto Label_0C40;

                case 0x48:
                    goto Label_0E06;

                case 0x49:
                    goto Label_0C94;

                case 0x4a:
                    goto Label_1924;

                case 0x4b:
                    goto Label_11DC;

                case 0x4c:
                    goto Label_0953;

                case 0x4d:
                    goto Label_102E;

                case 0x4e:
                    goto Label_1A47;

                case 0x4f:
                    goto Label_090B;

                case 80:
                    goto Label_045C;

                case 0x51:
                    manager = (ComponentResourceManager) bä(>+Zí(typeof(Shit.Settings).TypeHandle));
                    this.NyX_Theme1 = (Shit.NYX_Theme) ä{Ãdâ();
                    this.Label1 = (Label) aÞCM2();
                    num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                    goto Label_0022;

                case 0x52:
                    goto Label_1663;

                case 0x53:
                    goto Label_0C02;

                case 0x54:
                    goto Label_213E;

                case 0x55:
                    goto Label_03BC;

                case 0x56:
                    goto Label_0765;

                case 0x57:
                    goto Label_14FA;

                case 0x58:
                    goto Label_13AA;

                case 0x59:
                    goto Label_1D45;

                case 90:
                    goto Label_1BB8;

                case 0x5b:
                    goto Label_030C;

                case 0x5c:
                    goto Label_0FF4;

                case 0x5d:
                    goto Label_20D5;

                case 0x5e:
                    goto Label_21D9;

                case 0x5f:
                    goto Label_1F80;

                case 0x60:
                    goto Label_050F;

                case 0x61:
                    goto Label_0EDE;

                case 0x62:
                    goto Label_0643;
            }
            goto Label_24C4;
            this.CrystalClearTextBox1 = (Shit.CrystalClearTextBox) ÷R°á();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1ad];
            goto Label_0022;
            this.NyX_ControlBox1 = (Shit.NYX_ControlBox) °9O();
            this.NyX_GroupBox1 = (Shit.NYX_GroupBox) ØúUÀø();
            this.NyX_CheckBox1 = (Shit.NYX_CheckBox) ÿÆãL();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[430];
            goto Label_0022;
            this.NyX_Button1 = (Shit.NYX_Button) K7Dá();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1af];
            goto Label_0022;
            this.NyX_GroupBox2 = (Shit.NYX_GroupBox) ØúUÀø();
            this.NyX_CheckBox3 = (Shit.NYX_CheckBox) ÿÆãL();
            this.NyX_CheckBox2 = (Shit.NYX_CheckBox) ÿÆãL();
            this.ComboBox1 = (ComboBox) £©L/¹();
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.Label5 = (Label) aÞCM2();
            this.Timer3 = (Timer) ¾6ÊÜ(this.components);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.Timer2 = (Timer) ¾6ÊÜ(this.components);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1b0];
            goto Label_0022;
            this.FolderBrowserDialog1 = (FolderBrowserDialog) ¿úZ();
            this.Timer1 = (Timer) ¾6ÊÜ(this.components);
            CÕ(this.NyX_Theme1);
            CÕ(this.NyX_GroupBox1);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            CÕ(this.NyX_GroupBox2);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            =µ§­(this);
            this.NyX_Theme1.Animated = true;
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            this.NyX_Theme1.BorderStyle = FormBorderStyle.None;
            this.NyX_Theme1.Colors = new Shit.Bloom[0];
            yã\B(*?(), this.Label1);
            yã\B(*?(), this.CrystalClearTextBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1b1];
            goto Label_0022;
            yã\B(*?(), this.NyX_ControlBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1b2];
            goto Label_0022;
            yã\B(*?(), this.NyX_GroupBox1);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            yã\B(*?(), this.NyX_GroupBox2);
            this.NyX_Theme1.Customization = "";
            this.NyX_Theme1.Dock = DockStyle.Fill;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.NyX_Theme1.Font = (Font) ·)©ê("Arial", 9f);
            this.NyX_Theme1.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1b3];
            goto Label_0022;
            *?(new Point(0, 0));
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.NyX_Theme1.Movable = true;
            *?("NyX_Theme1");
            this.NyX_Theme1.NoRounding = false;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_Theme1.Sizable = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1b4];
            goto Label_0022;
            *?(new Size(0x237, 0x14d));
            this.NyX_Theme1.SmartBounds = true;
            this.NyX_Theme1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            *?(0);
            this.NyX_Theme1.Text = "Launch Game Settings";
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_Theme1.TransparencyKey = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x23]();
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.NyX_Theme1.Transparent = false;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.Label1.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            *?(new Point(0x13, 0x34));
            *?("Label1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1b5];
            goto Label_0022;
            *?(new Size(0x6b, 15));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            *?(0x1a);
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.Label1.Text = "Select SF2 Folder:";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1b6];
            goto Label_0022;
            this.CrystalClearTextBox1.Colors = new Shit.Bloom[0];
            this.CrystalClearTextBox1.Customization = "";
            this.CrystalClearTextBox1.Font = (Font) ·)©ê("Verdana", 8f);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.CrystalClearTextBox1.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1b7];
            goto Label_0022;
            *?(new Point(0x16, 70));
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.CrystalClearTextBox1.MaxLength = 0x7fff;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.CrystalClearTextBox1.Multiline = false;
            *?("CrystalClearTextBox1");
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.CrystalClearTextBox1.NoRounding = false;
            this.CrystalClearTextBox1.ReadOnly = false;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            *?(new Size(0x1f5, 0x18));
            *?(8);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.CrystalClearTextBox1.TextAlign = HorizontalAlignment.Left;
            this.CrystalClearTextBox1.Transparent = false;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.CrystalClearTextBox1.UseSystemPasswordChar = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[440];
            goto Label_0022;
            this.NyX_ControlBox1.Colors = new Shit.Bloom[0];
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1b9];
            goto Label_0022;
            this.NyX_ControlBox1.Customization = "";
            this.NyX_ControlBox1.Font = (Font) ·)©ê("Verdana", 8f);
            this.NyX_ControlBox1.Image = null;
            *?(new Point(0x1ff, 3));
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            *?("NyX_ControlBox1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1ba];
            goto Label_0022;
            this.NyX_ControlBox1.NoRounding = false;
            *?(new Size(0x2f, 20));
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            *?(7);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_ControlBox1.Text = "NyX_ControlBox1";
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_ControlBox1.Transparent = false;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.NyX_GroupBox1.Animated = true;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.NyX_GroupBox1.BorderStyle = FormBorderStyle.None;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1bb];
            goto Label_0022;
            this.NyX_GroupBox1.Colors = new Shit.Bloom[0];
            yã\B(*?(), this.NyX_CheckBox1);
            yã\B(*?(), this.NyX_Button1);
            this.NyX_GroupBox1.Customization = "";
            this.NyX_GroupBox1.Font = (Font) ·)©ê("Arial", 9f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1bc];
            goto Label_0022;
            this.NyX_GroupBox1.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1bd];
            goto Label_0022;
            *?(new Point(15, 0x1d));
            this.NyX_GroupBox1.Movable = true;
            *?("NyX_GroupBox1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1be];
            goto Label_0022;
            this.NyX_GroupBox1.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1bf];
            goto Label_0022;
            this.NyX_GroupBox1.Sizable = true;
            *?(new Size(0x20b, 100));
            this.NyX_GroupBox1.SmartBounds = true;
            this.NyX_GroupBox1.StartPosition = FormStartPosition.Manual;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            *?(0x1f);
            this.NyX_GroupBox1.Text = "Path";
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_GroupBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.NyX_GroupBox1.Transparent = false;
            this.NyX_CheckBox1.Checked = false;
            this.NyX_CheckBox1.Colors = new Shit.Bloom[0];
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_CheckBox1.Customization = "";
            this.NyX_CheckBox1.Font = (Font) ·)©ê("Verdana", 8f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1c0];
            goto Label_0022;
            this.NyX_CheckBox1.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1c1];
            goto Label_0022;
            *?(new Point(7, 0x47));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[450];
            goto Label_0022;
            *?("NyX_CheckBox1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1c3];
            goto Label_0022;
            this.NyX_CheckBox1.NoRounding = false;
            *?(new Size(0x8f, 20));
            *?(30);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1c4];
            goto Label_0022;
            this.NyX_CheckBox1.Text = "Remember Me";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1c5];
            goto Label_0022;
            this.NyX_CheckBox1.Transparent = false;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_Button1.Colors = new Shit.Bloom[0];
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1c6];
            goto Label_0022;
            this.NyX_Button1.Cursor = (Cursor) *CONSOLESCREENBUFFERINFO[0x5c]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1c7];
            goto Label_0022;
            this.NyX_Button1.Customization = "";
            this.NyX_Button1.Font = (Font) ·)©ê("Arial", 8f);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_Button1.Image = null;
            *?(new Point(0x1c8, 0x47));
            *?("NyX_Button1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1c8];
            goto Label_0022;
            this.NyX_Button1.NoRounding = false;
            *?(new Size(0x34, 0x11));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            *?(0x1b);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1c9];
            goto Label_0022;
            this.NyX_Button1.Text = "Browse";
            this.NyX_Button1.Transparent = false;
            this.NyX_GroupBox2.Animated = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1ca];
            goto Label_0022;
            this.NyX_GroupBox2.BorderStyle = FormBorderStyle.None;
            this.NyX_GroupBox2.Colors = new Shit.Bloom[0];
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            yã\B(*?(), this.NyX_CheckBox3);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1cb];
            goto Label_0022;
            yã\B(*?(), this.NyX_CheckBox2);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            yã\B(*?(), this.ComboBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[460];
            goto Label_0022;
            yã\B(*?(), this.Label5);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            this.NyX_GroupBox2.Customization = "";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1cd];
            goto Label_0022;
            this.NyX_GroupBox2.Font = (Font) ·)©ê("Arial", 9f);
            this.NyX_GroupBox2.Image = null;
            *?(new Point(15, 0x87));
            this.NyX_GroupBox2.Movable = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1ce];
            goto Label_0022;
            *?("NyX_GroupBox2");
            this.NyX_GroupBox2.NoRounding = false;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.NyX_GroupBox2.Sizable = true;
            *?(new Size(0x20b, 0xae));
            this.NyX_GroupBox2.SmartBounds = true;
            this.NyX_GroupBox2.StartPosition = FormStartPosition.Manual;
            *?(0x20);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            this.NyX_GroupBox2.Text = "Main Configuration";
            this.NyX_GroupBox2.TransparencyKey = System.Drawing.Color.Empty;
            this.NyX_GroupBox2.Transparent = false;
            this.NyX_CheckBox3.Checked = false;
            this.NyX_CheckBox3.Colors = new Shit.Bloom[0];
            this.NyX_CheckBox3.Customization = "";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1cf];
            goto Label_0022;
            this.NyX_CheckBox3.Font = (Font) ·)©ê("Verdana", 8f);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            this.NyX_CheckBox3.Image = null;
            *?(new Point(3, 0x87));
            *?("NyX_CheckBox3");
            this.NyX_CheckBox3.NoRounding = false;
            *?(new Size(0xb3, 20));
            *?(0x20);
            this.NyX_CheckBox3.Text = "Change SF2 Splash Screen";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1d0];
            goto Label_0022;
            this.NyX_CheckBox3.Transparent = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1d1];
            goto Label_0022;
            this.NyX_CheckBox2.Checked = false;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.NyX_CheckBox2.Colors = new Shit.Bloom[0];
            this.NyX_CheckBox2.Customization = "";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1d2];
            goto Label_0022;
            this.NyX_CheckBox2.Font = (Font) ·)©ê("Verdana", 8f);
            this.NyX_CheckBox2.Image = null;
            *?(new Point(3, 0x6d));
            *?("NyX_CheckBox2");
            this.NyX_CheckBox2.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1d3];
            goto Label_0022;
            *?(new Size(0x8f, 20));
            *?(0x1f);
            this.NyX_CheckBox2.Text = "Fast Launch";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1d4];
            goto Label_0022;
            this.NyX_CheckBox2.Transparent = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1d5];
            goto Label_0022;
            this.ComboBox1.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x60]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[470];
            goto Label_0022;
            *?(0);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1d7];
            goto Label_0022;
            this.ComboBox1.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            *?(1);
            object[] objArray1 = new object[] { "ita", "cze", "rus", "swe", "tur", "pol", "fra", "deu" };
            SerializationObjectManager.ITypeLib2.TypeNameStruct(*?(), objArray1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1d8];
            goto Label_0022;
            *?(new Point(0x4c, 0x37));
            *?("ComboBox1");
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            *?(new Size(0x4a, 0x17));
            *?(0x1d);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1d9];
            goto Label_0022;
            this.Label5.AutoSize = true;
            this.Label5.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.Label5.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            *?(new Point(4, 0x3a));
            *?("Label5");
            *?(new Size(0x42, 15));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1da];
            goto Label_0022;
            *?(0x1c);
            this.Label5.Text = "Language:";
            this.Timer3.Enabled = true;
            this.Timer1.Enabled = true;
            *?(new SizeF(6f, 13f));
            *?(1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1db];
            goto Label_0022;
            *?(new Size(0x237, 0x14d));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1dc];
            goto Label_0022;
            yã\B(*?(), this.NyX_Theme1);
            *?(0);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1dd];
            goto Label_0022;
            *?((Icon) ]l¶+(manager, "$this.Icon"));
            *?("Settings");
            this.Text = "Settings";
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            *?(*CONSOLESCREENBUFFERINFO[0x23]());
            4Ü'Ô(this.NyX_Theme1, false);
            òS4É:(this.NyX_Theme1);
            4Ü'Ô(this.NyX_GroupBox1, false);
            4Ü'Ô(this.NyX_GroupBox2, false);
            òS4É:(this.NyX_GroupBox2);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1de];
            goto Label_0022;
            ©`Vñ(this, false);
        }

        private void NyX_Button1_Click(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x7065d9c4;
            if (­þO\Æ(this.FolderBrowserDialog1) != DialogResult.OK)
            {
                goto Label_0105;
            }
        Label_001C:
            num4 = -1309381506;
        Label_0027:;
            int num5 = 0x121ee401;
            switch (((~((((num5 - ~~((-148659584 + -1231690589) ^ 0x1211e576)) + (((-1354678439 + 0x4270d9c3) ^ 0x34958dad) + ~(-997878527 * 0x5b15453d))) ^ ~(-956826602 ^ -1750922792)) - --1311567281) + num4) >> 0x10))
            {
                case 0:
                    goto Label_001C;

                case 1:
                    this.CrystalClearTextBox1.Text = (string) *?();
                    num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                    goto Label_0027;
            }
            goto Label_0105;
        }

        private void NyX_GroupBox2_Click(object sender, EventArgs e)
        {
        }

        private void NyX_Theme1_Click(object sender, EventArgs e)
        {
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            object obj1 = Æ}Þ(Registry.CurrentUser, "SF2 Launcher v1.0.0");
            TypeInfo.SoapNonPositiveInteger.ASCIIEncoding(SerializationObjectManager.SyncStream.MethodBase(obj1, "SF2 Launcher v1.0.0"));
            RegistryKey key = (RegistryKey) SerializationObjectManager.SyncStream.MethodBase(obj1, "Settings");
        Label_0035:
            num4 = -1774730179;
        Label_0041:;
            int num5 = 0x1b3d99ef;
            int num3 = 0x4d2;
            switch (((~~~((-(((0x7aa8777a + -1341404854) ^ (0x5aacc502 + 0x4e7d52f1)) ^ -(0x6f5ecc27 * -1370107967)) - num5) ^ -((-1303876105 ^ -1553231783) ^ ~-676023568)) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0035;

                case 1:
                    goto Label_0228;

                case 2:
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = -840442565;
                    goto Label_0041;

                case 4:
                    goto Label_0282;
            }
            goto Label_02C2;
            string str = Ü8(¨~öf(key, "Path"));
            this.CrystalClearTextBox1.Text = str;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1ed];
            goto Label_0041;
            this.NyX_CheckBox1.Checked = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1ee];
            goto Label_0041;
            Ë6Q=(this.Timer1);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x8b2ecf41;
            if (°qX¬ï(this.CrystalClearTextBox1.Text, "", false) != 0)
            {
                goto Label_0161;
            }
        Label_0026:
            num4 = -1982217330;
        Label_0031:;
            int num5 = -1983285310;
            switch (((~((-2020118659 + -1033805307) - -((num5 + ((((-1490774285 * 0x766cc067) + 0x525c721f) - -~-1396863426) - (-(0xe44f233 + -1124190072) + (~-1789625304 ^ ~-1328667783)))) - (((0x24ab1f86 + 0x105f1be0) ^ (0x42a7d32 + -556734178)) - -(0x484580f6 - 0x2990ad66)))) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0026;

                case 1:
                    goto Label_0161;

                case 2:
                    goto Label_012E;

                case 3:
                    *?(1);
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1f1];
                    goto Label_0031;
            }
            goto Label_019D;
            *?(0);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0031;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            aeQ(this.Timer2);
        Label_0016:
            num4 = -460491445;
        Label_0021:;
            int num5 = 0x7141e67d;
            switch ((((((((num5 - --577454725) + ~-(0x53ea47e2 ^ -1763979918)) * -557677601) * -1130384319) - 0x4ba15f36) + num4) % 4))
            {
                case 0:
                    goto Label_0016;

                case 2:
                    aeQ(this.Timer1);
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1ef];
                    goto Label_0021;

                case 3:
                    goto Label_00CE;
            }
            goto Label_010A;
            gë^Ñ(this);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1f0];
            goto Label_0021;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            this.lang = this.ComboBox1.Text;
            this.path = this.CrystalClearTextBox1.Text;
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
                uint num = 0xe6ec5f1a;
                EventHandler handler = new EventHandler(this.NyX_Theme1_Click);
            Label_0013:
                num4 = -1875168231;
            Label_001F:;
                int num5 = -522252452;
                int num3 = 0x4d2;
                switch (((((((((0x67a6ac13 * 0x2fd7d4c7) * -1492924099) - num5) - 0xf1ec38c) * 0x67146cb7) * -1603802359) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_0013;

                    case 1:
                        goto Label_0278;

                    case 2:
                        theme = this._NyX_Theme1;
                        num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                        goto Label_001F;

                    case 3:
                        goto Label_00DF;

                    case 4:
                        goto Label_02AF;

                    case 5:
                        goto Label_03D3;

                    case 6:
                        goto Label_0249;

                    case 8:
                        goto Label_0205;
                }
                goto Label_0413;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -68448103;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1df];
                goto Label_001F;
                this._NyX_Theme1 = value;
                num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                goto Label_001F;
                theme = this._NyX_Theme1;
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                goto Label_001F;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -756547392;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Label1 = value);
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
                uint num = 0x3b492667;
                EventHandler handler = new EventHandler(this.NyX_Button1_Click);
            Label_0013:
                num4 = -1596495159;
            Label_001F:;
                int num5 = -1596560695;
                int num3 = 0x4d2;
                switch (((~~-num5 + num4) >> 0x10))
                {
                    case 0:
                        goto Label_01AC;

                    case 1:
                        button = this._NyX_Button1;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = 0xc068695;
                        goto Label_001F;

                    case 2:
                        goto Label_0225;

                    case 3:
                        goto Label_0013;

                    case 4:
                        goto Label_0347;

                    case 6:
                        goto Label_01EB;
                }
                goto Label_038A;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                goto Label_001F;
                this._NyX_Button1 = value;
                button = this._NyX_Button1;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1e2];
                goto Label_001F;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1728293836;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1e3];
                goto Label_001F;
            }
        }

        internal virtual ComboBox ComboBox1
        {
            [CompilerGenerated]
            get => 
                this._ComboBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._ComboBox1 = value);
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
                uint num = 0x4131dbd4;
                EventHandler handler = new EventHandler(this.Timer3_Tick);
                Timer timer = this._Timer3;
                if (timer == null)
                {
                    goto Label_00FD;
                }
            Label_0020:
                num4 = 0x711b55bb;
            Label_002C:;
                int num5 = 0x75b6e123;
                int num3 = 0x4d2;
                switch ((((((((num5 ^ (~(-2037957775 * -0x6479ca01) - (~(0x341e766 ^ -1690738633) ^ (-0x60ba764 ^ --1881517806)))) * -1698869973) * 0x223a99d7) - -987904308) ^ 0x5dc49814) + num4) % 5))
                {
                    case 0:
                        goto Label_00FD;

                    case 1:
                        goto Label_01FF;

                    case 2:
                        goto Label_0020;

                    case 4:
                        *?(handler);
                        num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                        goto Label_002C;
                }
                goto Label_0242;
                this._Timer3 = value;
                timer = this._Timer3;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -380234957;
                goto Label_002C;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1e4];
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
                Timer timer;
                int num4;
                uint num = 0x719649c9;
                EventHandler handler = new EventHandler(this.Timer2_Tick);
            Label_0013:
                num4 = 0x5fc159a3;
            Label_001F:;
                int num5 = 0x60f85301;
                int num3 = 0x4d2;
                switch (((((-(-num5 + ~-(-593005567 ^ 0x554c1c12)) ^ (0x7b06e48b ^ -1195113079)) * -1218374095) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_0242;

                    case 1:
                        goto Label_039F;

                    case 2:
                        goto Label_0275;

                    case 4:
                        goto Label_0013;

                    case 5:
                        timer = this._Timer2;
                        num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                        goto Label_001F;

                    case 6:
                        goto Label_01FF;

                    case 7:
                        goto Label_00D9;
                }
                goto Label_03E2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x8174202;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1e5];
                goto Label_001F;
                this._Timer2 = value;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1e7];
                goto Label_001F;
                timer = this._Timer2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -268087048;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_001F;
            }
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
            set
            {
                // This item is obfuscated and can not be translated.
                Timer timer;
                int num4;
                uint num = 0xe5c24b25;
                EventHandler handler = new EventHandler(this.Timer1_Tick);
            Label_0013:
                num4 = -1974818518;
            Label_001F:;
                int num5 = -780952326;
                int num3 = 0x4d2;
                switch (((~~((~num5 - (-955483577 * ((0x189ccadd * 0x7c655529) - (0xacdb9d8 * 0x56ca482d)))) + (-0xeb15e - ~-1726559128)) + num4) % 9))
                {
                    case 0:
                        goto Label_03DF;

                    case 1:
                        timer = this._Timer1;
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1e8];
                        goto Label_001F;

                    case 2:
                        goto Label_0210;

                    case 3:
                        goto Label_0287;

                    case 4:
                        goto Label_02BD;

                    case 5:
                        goto Label_00EE;

                    case 6:
                        goto Label_0253;

                    case 7:
                        goto Label_0013;
                }
                goto Label_041F;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -865975498;
                goto Label_001F;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1e9];
                goto Label_001F;
                this._Timer1 = value;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1eb];
                goto Label_001F;
                timer = this._Timer1;
                num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                goto Label_001F;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -234394858;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
                goto Label_001F;
            }
        }

        internal virtual Shit.NYX_CheckBox NyX_CheckBox1
        {
            [CompilerGenerated]
            get => 
                this._NyX_CheckBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._NyX_CheckBox1 = value);
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

        internal virtual Shit.NYX_GroupBox NyX_GroupBox2
        {
            [CompilerGenerated]
            get => 
                this._NyX_GroupBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x28d27146;
                EventHandler handler = new EventHandler(this.NyX_GroupBox2_Click);
                Shit.NYX_GroupBox box = this._NyX_GroupBox2;
                if (box == null)
                {
                    goto Label_00E0;
                }
            Label_0020:
                num4 = 0x73376948;
            Label_002C:;
                int num5 = 0x4c10e261;
                int num3 = 0x4d2;
                switch (((((~(~num5 - 0x3adfa791) + (0x563894e0 + -441606688)) ^ 0x4e1f2a0a) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_0020;

                    case 1:
                        *?(handler);
                        num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
                        goto Label_002C;

                    case 3:
                        goto Label_00E0;

                    case 4:
                        goto Label_0238;

                    case 5:
                        goto Label_010F;
                }
                goto Label_0278;
                this._NyX_GroupBox2 = value;
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_002C;
                box = this._NyX_GroupBox2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x25a2b67c;
                goto Label_002C;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                goto Label_002C;
            }
        }

        internal virtual Shit.NYX_CheckBox NyX_CheckBox3
        {
            [CompilerGenerated]
            get => 
                this._NyX_CheckBox3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._NyX_CheckBox3 = value);
        }

        internal virtual Shit.NYX_CheckBox NyX_CheckBox2
        {
            [CompilerGenerated]
            get => 
                this._NyX_CheckBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._NyX_CheckBox2 = value);
        }
    }
}

