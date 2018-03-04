namespace Shit
{
    using Microsoft.VisualBasic.CompilerServices;
    using SerializationObjectManager;
    using Shit.My;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class DW2 : Form
    {
        private IContainer components;
        [CompilerGenerated, AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2"), CompilerGenerated]
        private Label _Label2;
        [AccessedThroughProperty("Label3"), CompilerGenerated]
        private Label _Label3;
        [AccessedThroughProperty("Timer1"), CompilerGenerated]
        private System.Windows.Forms.Timer _Timer1;
        [AccessedThroughProperty("ProgressBar1"), CompilerGenerated]
        private Shit.NYX_ProgressBar _ProgressBar1;
        [CompilerGenerated, AccessedThroughProperty("NyX_Theme1")]
        private Shit.NYX_Theme _NyX_Theme1;
        [CompilerGenerated, AccessedThroughProperty("ProgessBar1")]
        private Shit.NYX_ProgressBar _ProgessBar1;
        [AccessedThroughProperty("Label4"), CompilerGenerated]
        private Label _Label4;
        [CompilerGenerated, AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label6"), CompilerGenerated]
        private Label _Label6;
        public string NewLoader;

        public DW2()
        {
            *?(new EventHandler(this.DW2_Load));
            this.NewLoader = "Loader_NEW.exe";
            P½kð(this);
        }

        private void client_ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // This item is obfuscated and can not be translated.
            double num2;
            int num8;
            uint num5 = 0xc89952ce;
            long num3 = (long) *?();
        Label_0017:
            num8 = -350492870;
        Label_0023:;
            int num9 = -2038774246;
            switch (((~~(num9 ^ (~((0x2851e726 ^ -946440079) * -802744497) - ~~-1992874934)) + num8) >> 0x10))
            {
                case 0:
                    goto Label_0017;

                case 2:
                {
                    num3 = (long) *?();
                    num2 = (+¾®÷~(num3.ToString()) / +¾®÷~(num3.ToString())) * 100.0;
                    double num4 = ´:p(num2);
                    this.ProgressBar1.Value = Ï
%(num4.ToString());
                    num8 = (int) Shit.My.MyApplication.StringSplitOptions[0x25];
                    goto Label_0023;
                }
                case 3:
                    goto Label_012C;
            }
            goto Label_01A3;
            this.Label2.Text = 1P("Completed: ", h%¬("{0:00}", num2), "%");
            this.Label3.Text = this.NewLoader;
            num8 = (int) (num5 ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0023;
        }

        private void clientC_DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Lmå(this);
            ÔP#(this.NewLoader);
            ¢ä°{();
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                uint num;
                uint num2;
                int num4;
                int expressionStack_13D_0;
                int expressionStack_13D_1;
                if (!disposing)
                {
                    return;
                }
            Label_000C:
                num4 = -1919326575;
                int expressionStack_17_0 = -1370692928;
            Label_0017:;
                int num5 = expressionStack_17_0;
                int num3 = 0x4d2;
                switch (((num2 = (uint) (~(((-num5 ^ -(-1078864363 * ~0x589174d5)) ^ ((-2145694449 * -1600536796) - 0x782af5a7)) - -1232793813) + num4)) >> 0x10))
                {
                    case 0:
                        ÂÔç(this.components);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[6];
                        expressionStack_17_0 = (((int) num2) + 0x29572172) ^ 0x49ac21df;
                        goto Label_0017;

                    case 1:
                        if (this.components != null)
                        {
                            break;
                        }
                        num3 = 0x4d2;
                        expressionStack_13D_1 = 0x4b9a0d97;
                        goto Label_013D;

                    case 2:
                        return;

                    case 3:
                        goto Label_000C;

                    default:
                        return;
                }
                expressionStack_13D_1 = 0x4b9c0d97;
            Label_013D:
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1517253784;
                expressionStack_17_0 = expressionStack_13D_1 ^ ((int) (num2 * 0x9348fdd8));
                goto Label_0017;
            }
            finally
            {
                VÛ(this, disposing);
            }
        }

        public void DownloadUpdate()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x88478d42;
            this.ProgressBar1.Maximum = 100;
        Label_0013:
            num4 = -1522619090;
        Label_001E:;
            int num5 = -2063833791;
            switch (((-(((-num5 + (0x6f710147 * -323605878)) + -~-507778133) - -1323487357) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0013;

                case 2:
                {
                    object obj1 = eÐm();
                    *?(new DownloadProgressChangedEventHandler(this.client_ProgressChanged));
                    *?(new AsyncCompletedEventHandler(this.clientC_DownloadCompleted));
                    SerializationObjectManager.SecurityCriticalScope.IBuiltInEvidence(obj1, F¸¹ÛÚ("http://82.208.17.176/SF2/Loader.exe"), this.NewLoader);
                    num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
                    goto Label_001E;
                }
            }
            goto Label_010A;
        }

        private void DW2_Load(object sender, EventArgs e)
        {
            d#½É(this);
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0xbfd1e47b;
            this.components = (IContainer) À%Ã±();
            ComponentResourceManager manager = (ComponentResourceManager) bä(>+Zí(typeof(Shit.DW2).TypeHandle));
            this.Label1 = (Label) aÞCM2();
            this.Label2 = (Label) aÞCM2();
        Label_0050:
            num4 = 0x3a188f9d;
        Label_005C:;
            int num5 = -17113132;
            switch (((--((~num5 * 0x26ab44f3) * 0x55306b81) + num4) % 0x3d))
            {
                case 0:
                    goto Label_085F;

                case 1:
                    goto Label_0C70;

                case 2:
                    goto Label_0FD3;

                case 3:
                    goto Label_0E2A;

                case 4:
                    goto Label_1050;

                case 5:
                    goto Label_07E6;

                case 6:
                    goto Label_0BC3;

                case 8:
                    goto Label_15EF;

                case 9:
                    goto Label_02BC;

                case 10:
                    goto Label_0499;

                case 11:
                    goto Label_0EDB;

                case 12:
                    goto Label_05FD;

                case 13:
                    goto Label_090B;

                case 14:
                    goto Label_0A7E;

                case 15:
                    goto Label_0D06;

                case 0x10:
                    goto Label_0ABA;

                case 0x11:
                    goto Label_026D;

                case 0x12:
                    goto Label_0CC7;

                case 0x13:
                    goto Label_056F;

                case 20:
                    goto Label_0E8F;

                case 0x15:
                    goto Label_0D8F;

                case 0x16:
                    goto Label_022F;

                case 0x17:
                    goto Label_0DD5;

                case 0x18:
                    goto Label_11AA;

                case 0x19:
                    goto Label_149B;

                case 0x1a:
                    goto Label_14DD;

                case 0x1b:
                    goto Label_10EF;

                case 0x1c:
                    goto Label_0824;

                case 0x1d:
                    goto Label_064E;

                case 30:
                    goto Label_1311;

                case 0x1f:
                    goto Label_050A;

                case 0x20:
                    goto Label_112A;

                case 0x21:
                    goto Label_140F;

                case 0x22:
                    this.Label3 = (Label) aÞCM2();
                    this.Timer1 = (System.Windows.Forms.Timer) ¾6ÊÜ(this.components);
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[7];
                    goto Label_005C;

                case 0x23:
                    goto Label_0689;

                case 0x24:
                    goto Label_030F;

                case 0x25:
                    goto Label_05AE;

                case 0x26:
                    goto Label_1591;

                case 0x27:
                    goto Label_09EE;

                case 40:
                    goto Label_0C0F;

                case 0x29:
                    goto Label_07AB;

                case 0x2a:
                    goto Label_0445;

                case 0x2b:
                    goto Label_0B0B;

                case 0x2c:
                    goto Label_0B6A;

                case 0x2d:
                    goto Label_06E2;

                case 0x2e:
                    goto Label_09A4;

                case 0x2f:
                    goto Label_12C4;

                case 0x30:
                    goto Label_0737;

                case 0x31:
                    goto Label_11F2;

                case 50:
                    goto Label_0F50;

                case 0x33:
                    goto Label_0A29;

                case 0x34:
                    goto Label_109B;

                case 0x35:
                    goto Label_13BE;

                case 0x36:
                    goto Label_136D;

                case 0x37:
                    goto Label_1241;

                case 0x38:
                    goto Label_151F;

                case 0x39:
                    goto Label_1285;

                case 0x3a:
                    goto Label_0050;

                case 0x3b:
                    goto Label_01ED;

                case 60:
                    goto Label_0F8B;
            }
            goto Label_162E;
            this.ProgressBar1 = (Shit.NYX_ProgressBar) Äü`»x();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[8];
            goto Label_005C;
            this.NyX_Theme1 = (Shit.NYX_Theme) ä{Ãdâ();
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_005C;
            this.ProgessBar1 = (Shit.NYX_ProgressBar) Äü`»x();
            this.Label4 = (Label) aÞCM2();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[9];
            goto Label_005C;
            this.Label5 = (Label) aÞCM2();
            this.Label6 = (Label) aÞCM2();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[10];
            goto Label_005C;
            CÕ(this.NyX_Theme1);
            =µ§­(this);
            this.Label1.AutoSize = true;
            *?(new Point(0xcf, 9));
            *?("Label1");
            *?(new Size(0x95, 13));
            *?(0);
            this.Label1.Text = "Downloading Latest Loader ...";
            this.Label2.AutoSize = true;
            *?(new Point(0x21, 50));
            *?("Label2");
            *?(new Size(60, 13));
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            *?(1);
            this.Label2.Text = "Completed:";
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            this.Label3.AutoSize = true;
            *?(new Point(0x21, 0x21));
            *?("Label3");
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_005C;
            *?(new Size(0x33, 13));
            *?(3);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[11];
            goto Label_005C;
            this.Label3.Text = "New File:";
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_005C;
            this.ProgressBar1.Colors = new Shit.Bloom[0];
            this.ProgressBar1.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            this.ProgressBar1.Font = (Font) ·)©ê("Verdana", 8f);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            this.ProgressBar1.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[12];
            goto Label_005C;
            *?(new Point(0x24, 0x4e));
            this.ProgressBar1.Maximum = 100;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            *?("ProgressBar1");
            this.ProgressBar1.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[13];
            goto Label_005C;
            *?(new Size(0x1f1, 0x19));
            *?(4);
            this.ProgressBar1.Transparent = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[14];
            goto Label_005C;
            this.ProgressBar1.Value = 0;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[15];
            goto Label_005C;
            this.NyX_Theme1.Animated = true;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            this.NyX_Theme1.BorderStyle = FormBorderStyle.None;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            this.NyX_Theme1.Colors = new Shit.Bloom[0];
            yã\B(*?(), this.ProgessBar1);
            yã\B(*?(), this.Label4);
            yã\B(*?(), this.Label5);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x10];
            goto Label_005C;
            yã\B(*?(), this.Label6);
            this.NyX_Theme1.Customization = "";
            this.NyX_Theme1.Dock = DockStyle.Fill;
            this.NyX_Theme1.Font = (Font) ·)©ê("Arial", 9f);
            this.NyX_Theme1.Image = null;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            *?(new Point(0, 0));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            this.NyX_Theme1.Movable = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x11];
            goto Label_005C;
            *?("NyX_Theme1");
            this.NyX_Theme1.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x12];
            goto Label_005C;
            this.NyX_Theme1.Sizable = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x13];
            goto Label_005C;
            *?(new Size(0x221, 130));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            this.NyX_Theme1.SmartBounds = true;
            this.NyX_Theme1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            *?(5);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_005C;
            this.NyX_Theme1.Text = "Downloading ...";
            this.NyX_Theme1.TransparencyKey = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x23]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[20];
            goto Label_005C;
            this.NyX_Theme1.Transparent = false;
            this.ProgessBar1.Colors = new Shit.Bloom[0];
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x15];
            goto Label_005C;
            this.ProgessBar1.Customization = "";
            this.ProgessBar1.Font = (Font) ·)©ê("Verdana", 8f);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            this.ProgessBar1.Image = null;
            *?(new Point(0x16, 0x5d));
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            this.ProgessBar1.Maximum = 100;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_005C;
            *?("ProgessBar1");
            this.ProgessBar1.NoRounding = false;
            *?(new Size(0x1f1, 0x19));
            *?(8);
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_005C;
            this.ProgessBar1.Transparent = false;
            this.ProgessBar1.Value = 0;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_005C;
            this.Label4.AutoSize = true;
            this.Label4.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x16];
            goto Label_005C;
            this.Label4.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            *?(new Point(0x13, 0x39));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x17];
            goto Label_005C;
            *?("Label4");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x18];
            goto Label_005C;
            *?(new Size(0x3a, 15));
            *?(7);
            this.Label4.Text = "New File:";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x19];
            goto Label_005C;
            this.Label5.AutoSize = true;
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_005C;
            this.Label5.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1a];
            goto Label_005C;
            this.Label5.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            *?(new Point(0x13, 0x4a));
            *?("Label5");
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_005C;
            *?(new Size(0x47, 15));
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_005C;
            *?(6);
            this.Label5.Text = "Completed:";
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_005C;
            this.Label6.AutoSize = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1b];
            goto Label_005C;
            this.Label6.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            this.Label6.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            *?(new Point(0xc1, 0x21));
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            *?("Label6");
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_005C;
            *?(new Size(0xab, 15));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1c];
            goto Label_005C;
            *?(5);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1d];
            goto Label_005C;
            this.Label6.Text = "Downloading Latest Loader ...";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[30];
            goto Label_005C;
            *?(new SizeF(6f, 13f));
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_005C;
            *?(1);
            *?(new Size(0x221, 130));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_005C;
            yã\B(*?(), this.NyX_Theme1);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_005C;
            yã\B(*?(), this.ProgressBar1);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_005C;
            yã\B(*?(), this.Label3);
            yã\B(*?(), this.Label2);
            yã\B(*?(), this.Label1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1f];
            goto Label_005C;
            this.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_005C;
            *?(0);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_005C;
            *?((Icon) ]l¶+(manager, "$this.Icon"));
            *?("DW2");
            this.Text = "Downloading ..";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x20];
            goto Label_005C;
            *?(*CONSOLESCREENBUFFERINFO[0x23]());
            4Ü'Ô(this.NyX_Theme1, false);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x21];
            goto Label_005C;
            òS4É:(this.NyX_Theme1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x22];
            goto Label_005C;
            ©`Vñ(this, false);
            $,÷1e(this);
        }

        private void NyX_Theme1_Click(object sender, EventArgs e)
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
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

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Label2 = value);
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

        internal virtual System.Windows.Forms.Timer Timer1
        {
            [CompilerGenerated]
            get => 
                this._Timer1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                System.Windows.Forms.Timer timer;
                int num4;
                uint num = 0x1131fbb8;
                EventHandler handler = new EventHandler(this.Timer1_Tick);
            Label_0013:
                num4 = -254204672;
            Label_001F:;
                int num5 = 0x1a1af56d;
                int num3 = 0x4d2;
                switch (((~~(((0x54434cdb + 0x16ba32b3) ^ (-1749335207 * 0x550459a6)) - (~~(-1459727214 ^ 0x4443d714) - (num5 + ((((0x186076b8 - 0x5e908703) - (-1126052474 + -598701414)) - ((0x69f6561d ^ 0x448d31fb) * -387071219)) + ~((-417560555 * 0xb65bd9f) ^ (0x5c0828cd + -1807911359)))))) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_012B;

                    case 1:
                        goto Label_0416;

                    case 2:
                        goto Label_0013;

                    case 3:
                        goto Label_0252;

                    case 4:
                        goto Label_02BD;

                    case 5:
                        goto Label_02F4;

                    case 7:
                        goto Label_0291;

                    case 8:
                        timer = this._Timer1;
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x23];
                        goto Label_001F;
                }
                goto Label_0455;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -234243271;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                goto Label_001F;
                this._Timer1 = value;
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                goto Label_001F;
                timer = this._Timer1;
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_001F;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0xe5c750;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_001F;
            }
        }

        internal virtual Shit.NYX_ProgressBar ProgressBar1
        {
            [CompilerGenerated]
            get => 
                this._ProgressBar1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._ProgressBar1 = value);
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
                uint num = 0xb35439ab;
                EventHandler handler = new EventHandler(this.NyX_Theme1_Click);
            Label_0013:
                num4 = 0xc66c21a;
            Label_001F:;
                int num5 = -1745204597;
                int num3 = 0x4d2;
                switch (((((~-1622131071 - ~~(num5 + ((-679586763 + -~-2036246555) - -((0x4291bd21 * -330575188) - (-1592678567 - 0x2f460b13))))) - -854981364) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_0013;

                    case 1:
                        goto Label_0212;

                    case 2:
                        goto Label_00E8;

                    case 3:
                        theme = this._NyX_Theme1;
                        num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                        goto Label_001F;

                    case 4:
                        goto Label_0353;

                    case 6:
                        goto Label_0251;
                }
                goto Label_0392;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -603877885;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                goto Label_001F;
                this._NyX_Theme1 = value;
                theme = this._NyX_Theme1;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1847900434;
                goto Label_001F;
                *?(handler);
                num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                goto Label_001F;
            }
        }

        internal virtual Shit.NYX_ProgressBar ProgessBar1
        {
            [CompilerGenerated]
            get => 
                this._ProgessBar1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._ProgessBar1 = value);
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Label4 = value);
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

        internal virtual Label Label6
        {
            [CompilerGenerated]
            get => 
                this._Label6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Label6 = value);
        }
    }
}

