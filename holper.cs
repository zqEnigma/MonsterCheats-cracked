namespace Shit
{
    using Microsoft.VisualBasic.CompilerServices;
    using SerializationObjectManager;
    using Shit.My;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class holper : Form
    {
        private IContainer components;
        [CompilerGenerated, AccessedThroughProperty("NyX_Theme1")]
        private Shit.NYX_Theme _NyX_Theme1;
        [CompilerGenerated, AccessedThroughProperty("NyX_ControlBox1")]
        private Shit.NYX_ControlBox _NyX_ControlBox1;
        [AccessedThroughProperty("Timer3"), CompilerGenerated]
        private Timer _Timer3;
        [CompilerGenerated, AccessedThroughProperty("Timer2")]
        private Timer _Timer2;
        [AccessedThroughProperty("FolderBrowserDialog1"), CompilerGenerated]
        private FolderBrowserDialog _FolderBrowserDialog1;
        [AccessedThroughProperty("Timer1"), CompilerGenerated]
        private Timer _Timer1;
        [CompilerGenerated, AccessedThroughProperty("NyX_GroupBox1")]
        private Shit.NYX_GroupBox _NyX_GroupBox1;
        [AccessedThroughProperty("NyX_Button1"), CompilerGenerated]
        private Shit.NYX_Button _NyX_Button1;
        [CompilerGenerated, AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;
        [AccessedThroughProperty("Label5"), CompilerGenerated]
        private Label _Label5;
        [CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label _Label2;
        [CompilerGenerated, AccessedThroughProperty("ComboBox2")]
        private ComboBox _ComboBox2;
        [CompilerGenerated, AccessedThroughProperty("Label1")]
        private Label _Label1;
        private bool activated;

        public holper()
        {
            // This item is obfuscated and can not be translated.
            int num4;
        Label_000C:
            num4 = 0x2c286e8c;
        Label_0017:;
            int num5 = 0x27a62822;
            switch (((((~((num5 + (-1672838509 * 0x3fdb87a7)) - 0x1c48b74c) ^ (0x6728a209 + -1208643546)) + 0x36cc45c7) + num4) % 3))
            {
                case 0:
                    goto Label_000C;

                case 2:
                    *?(new KeyPressEventHandler(this.holper_KeyPress));
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xd4];
                    goto Label_0017;
            }
            goto Label_00CD;
            this.activated = false;
            ón](this);
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                uint num;
                uint num2;
                int num4;
                int expressionStack_125_0;
                int expressionStack_125_1;
                if (!disposing)
                {
                    return;
                }
            Label_000C:
                num4 = 0x2cbe71c;
                int expressionStack_17_0 = 0x15f81b1;
            Label_0017:;
                int num5 = expressionStack_17_0;
                int num3 = 0x4d2;
                switch (((num2 = (uint) (((--146440527 - -~-num5) ^ -148104677) + num4)) >> 0x10))
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
                        expressionStack_125_1 = -424273843;
                        goto Label_0125;

                    case 3:
                        ÂÔç(this.components);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xd5];
                        expressionStack_17_0 = (((int) num2) + -42622812) ^ -1045131552;
                        goto Label_0017;

                    default:
                        return;
                }
                expressionStack_125_1 = -424667059;
            Label_0125:
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x72487c80;
                expressionStack_17_0 = expressionStack_125_1 ^ ((int) (num2 * 0x93b34bb6));
                goto Label_0017;
            }
            finally
            {
                VÛ(this, disposing);
            }
        }

        public Keys GetKey(string input)
        {
            // This item is obfuscated and can not be translated.
            Keys alt;
            int num4;
            uint num = 0x84c8f2df;
            if (°qX¬ï(input, "L.CTRL", false) != 0)
            {
                goto Label_091F;
            }
        Label_001C:
            num4 = 0x140c7678;
        Label_0028:;
            int num5 = 0x43bd08b1;
            int num3 = 0x4d2;
            switch ((((((-283570747 - ~(num5 * -900583119)) ^ (-175452361 + 0x129ef403)) + 0x5ccd2deb) + num4) >> 0x10))
            {
                case 0:
                    goto Label_22B1;

                case 1:
                    goto Label_2B22;

                case 2:
                    goto Label_35B1;

                case 3:
                    goto Label_2524;

                case 4:
                    goto Label_2280;

                case 5:
                    goto Label_1BD3;

                case 6:
                    goto Label_1B76;

                case 7:
                    goto Label_3317;

                case 8:
                    goto Label_31FC;

                case 9:
                    goto Label_1318;

                case 10:
                    goto Label_1A2C;

                case 11:
                    goto Label_2074;

                case 12:
                    goto Label_0A70;

                case 13:
                    goto Label_2FED;

                case 14:
                    goto Label_107B;

                case 15:
                    goto Label_2DB6;

                case 0x10:
                    goto Label_0A48;

                case 0x11:
                    goto Label_1EF8;

                case 0x12:
                    goto Label_3845;

                case 0x13:
                    goto Label_3970;

                case 20:
                    goto Label_0BBE;

                case 0x15:
                    goto Label_2790;

                case 0x16:
                    goto Label_1DDE;

                case 0x17:
                    goto Label_0CB3;

                case 0x18:
                    goto Label_349A;

                case 0x19:
                    goto Label_35DC;

                case 0x1a:
                    goto Label_0E08;

                case 0x1b:
                    goto Label_0CE8;

                case 0x1c:
                    goto Label_3BA8;

                case 0x1d:
                    goto Label_0A10;

                case 30:
                    goto Label_372A;

                case 0x1f:
                    goto Label_22D9;

                case 0x20:
                    goto Label_12E3;

                case 0x21:
                    goto Label_393A;

                case 0x22:
                    goto Label_2190;

                case 0x23:
                    goto Label_1669;

                case 0x24:
                    goto Label_0F26;

                case 0x25:
                    goto Label_2D8B;

                case 0x26:
                    goto Label_1A5D;

                case 0x27:
                    goto Label_2AED;

                case 40:
                    goto Label_30E2;

                case 0x29:
                    goto Label_2ED2;

                case 0x2a:
                    goto Label_1E08;

                case 0x2b:
                    goto Label_0E32;

                case 0x2c:
                    goto Label_1575;

                case 0x2d:
                    goto Label_3703;

                case 0x2e:
                    goto Label_1CEE;

                case 0x2f:
                    goto Label_1046;

                case 0x30:
                    goto Label_2B49;

                case 0x31:
                    goto Label_34C1;

                case 50:
                    goto Label_11C8;

                case 0x33:
                    goto Label_2EA8;

                case 0x34:
                    goto Label_3227;

                case 0x35:
                    goto Label_142F;

                case 0x36:
                    goto Label_3AB7;

                case 0x37:
                    goto Label_1F55;

                case 0x38:
                    goto Label_24EF;

                case 0x39:
                    goto Label_23C9;

                case 0x3a:
                    goto Label_2C65;

                case 0x3b:
                    goto Label_2881;

                case 60:
                    goto Label_3998;

                case 0x3d:
                    goto Label_2C3A;

                case 0x3e:
                    goto Label_11EF;

                case 0x3f:
                    goto Label_29D5;

                case 0x40:
                    goto Label_3A8C;

                case 0x41:
                    goto Label_18D8;

                case 0x42:
                    goto Label_17E4;

                case 0x44:
                    goto Label_2647;

                case 0x45:
                    goto Label_2672;

                case 70:
                    goto Label_2766;

                case 0x47:
                    goto Label_17BD;

                case 0x48:
                    goto Label_310C;

                case 0x49:
                    goto Label_28AB;

                case 0x4a:
                    goto Label_1697;

                case 0x4b:
                    goto Label_23F7;

                case 0x4c:
                    goto Label_08F7;

                case 0x4d:
                    goto Label_29FC;

                case 0x4e:
                    goto Label_2D5A;

                case 0x4f:
                    goto Label_0B65;

                case 80:
                    goto Label_10A2;

                case 0x51:
                    goto Label_0B97;

                case 0x52:
                    goto Label_1A84;

                case 0x53:
                    goto Label_3465;

                case 0x54:
                    goto Label_3374;

                case 0x55:
                    goto Label_1911;

                case 0x56:
                    goto Label_001C;

                case 0x57:
                    goto Label_2046;

                case 0x58:
                    goto Label_36CD;

                case 0x59:
                    goto Label_254F;

                case 90:
                    goto Label_1F2E;

                case 0x5b:
                    goto Label_334C;

                case 0x5c:
                    goto Label_091F;

                case 0x5d:
                    goto Label_1787;

                case 0x5e:
                    goto Label_1938;

                case 0x5f:
                    goto Label_154B;

                case 0x60:
                    goto Label_1BAC;

                case 0x61:
                    goto Label_2FC2;

                case 0x62:
                    goto Label_2166;

                case 0x63:
                    goto Label_0D10;

                case 100:
                    alt = Keys.LControlKey;
                    num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                    goto Label_0028;

                case 0x65:
                    goto Label_299F;

                case 0x66:
                    goto Label_1196;

                case 0x67:
                    goto Label_1CC4;

                case 0x68:
                    goto Label_0F54;

                case 0x69:
                    goto Label_145A;

                case 0x6a:
                    goto Label_381B;

                case 0x6b:
                    goto Label_133F;
            }
            goto Label_3BDD;
            num4 = 0x53e13aeb;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1483608924;
            goto Label_0028;
            alt = Keys.Alt;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xfc];
            goto Label_0028;
            num4 = -408410924;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -443432369;
            goto Label_0028;
            alt = Keys.Delete;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0028;
            num4 = -508630773;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x13d8e8b2;
            goto Label_0028;
            alt = Keys.Home;
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0028;
            num4 = -1573548387;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x30e4a655;
            goto Label_0028;
            alt = Keys.Insert;
            num4 = 0x63ae7de9;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x79b5181d;
            goto Label_0028;
            alt = Keys.End;
            num4 = 0x18e50ca1;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1989408695;
            goto Label_0028;
            alt = Keys.F1;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0028;
            num4 = -585105652;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1935302953;
            goto Label_0028;
            alt = Keys.F2;
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0028;
            num4 = 0x3be130f9;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x7aaafa5d;
            goto Label_0028;
            alt = Keys.F3;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xfd];
            goto Label_0028;
            num4 = -835844098;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x229f9247;
            goto Label_0028;
            alt = Keys.F4;
            num4 = -1787119031;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x6e1518f7;
            goto Label_0028;
            alt = Keys.F5;
            num4 = 0x3d742487;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -2103498868;
            goto Label_0028;
            alt = Keys.F6;
            num4 = 0x4ab522b1;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x13d3eee4;
            goto Label_0028;
            alt = Keys.F7;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xfe];
            goto Label_0028;
            num4 = 0x63b3a2b4;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x581cac1e;
            goto Label_0028;
            alt = Keys.F8;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xff];
            goto Label_0028;
            num4 = 0x6d09fcff;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x65be8f9f;
            goto Label_0028;
            alt = Keys.F9;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0028;
            num4 = -1430018702;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x7be808b4;
            goto Label_0028;
            alt = Keys.F10;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x100];
            goto Label_0028;
            num4 = -2013108728;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -319474772;
            goto Label_0028;
            alt = Keys.F11;
            num4 = 0x2f78b0cb;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x51bcaba1;
            goto Label_0028;
            alt = Keys.F12;
            num4 = 0x70f5f756;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1504516815;
            goto Label_0028;
            alt = Keys.A;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x101];
            goto Label_0028;
            num4 = 0x27440f58;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x68e65e2d;
            goto Label_0028;
            alt = Keys.B;
            num4 = -1173042065;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -433534831;
            goto Label_0028;
            alt = Keys.C;
            num4 = 0x2afbce13;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x703dc2a4;
            goto Label_0028;
            alt = Keys.D;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0028;
            num4 = -575323910;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -576105858;
            goto Label_0028;
            alt = Keys.E;
            num4 = 0x3f65dd3a;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -55892403;
            goto Label_0028;
            alt = Keys.F;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0028;
            num4 = -417553479;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x6239e4c2;
            goto Label_0028;
            alt = Keys.G;
            num4 = 0xcede8ed;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0xa002fea;
            goto Label_0028;
            alt = Keys.H;
            num4 = 0x12353714;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -536773026;
            goto Label_0028;
            alt = Keys.I;
            num4 = 0x7fabdd5c;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x2125c4b;
            goto Label_0028;
            alt = Keys.J;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x102];
            goto Label_0028;
            num4 = -1047091371;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -2094919396;
            goto Label_0028;
            alt = Keys.K;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x103];
            goto Label_0028;
            num4 = 0x57760858;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -81743232;
            goto Label_0028;
            alt = Keys.L;
            num4 = 0x67d2ef5d;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x6fae4b4e;
            goto Label_0028;
            alt = Keys.M;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0028;
            num4 = 0x763019b2;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1983468670;
            goto Label_0028;
            alt = Keys.N;
            num4 = 0x4f1d50b9;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -226974859;
            goto Label_0028;
            alt = Keys.O;
            num4 = 0x1f3e834;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x26430437;
            goto Label_0028;
            alt = Keys.P;
            num4 = -1628345336;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x60784b3e;
            goto Label_0028;
            alt = Keys.Q;
            num4 = 0x1d30612d;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -328452236;
            goto Label_0028;
            alt = Keys.R;
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0028;
            num4 = 0x1769caef;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -998465392;
            goto Label_0028;
            alt = Keys.S;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[260];
            goto Label_0028;
            num4 = -1751608225;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -255184356;
            goto Label_0028;
            alt = Keys.T;
            num4 = 0x4c81c5fe;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -6022154;
            goto Label_0028;
            alt = Keys.U;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x105];
            goto Label_0028;
            num4 = -1102609243;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1035264067;
            goto Label_0028;
            alt = Keys.V;
            num4 = -901162395;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x612de189;
            goto Label_0028;
            alt = Keys.X;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x106];
            goto Label_0028;
            num4 = 0x50af3e95;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -581631379;
            goto Label_0028;
            alt = Keys.Y;
            num4 = -286691435;
            goto Label_0028;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x1aad4a28;
            goto Label_0028;
            alt = Keys.Z;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x107];
            goto Label_0028;
        }

        private void holper_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            if (!this.activated)
            {
                goto Label_021A;
            }
        Label_0011:
            num4 = 0x23eb48a6;
        Label_001C:;
            int num5 = 0x6bf088fc;
            int num3 = 0x4d2;
            switch ((((((-~num5 - -(-1153978919 - 0x5b0c0407)) * 0x154f4875) - 0x3f8b941) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0011;

                case 1:
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = -824744003;
                    goto Label_001C;

                case 3:
                    goto Label_01BF;
            }
            goto Label_021A;
            È¸ÿÒ(¦VZÏ2((int) ;­Þsi(this, this.ComboBox2.Text)));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x108];
            goto Label_001C;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            // This item is obfuscated and can not be translated.
            ComponentResourceManager manager;
            int num4;
            uint num = 0x8942ed9b;
            this.components = (IContainer) À%Ã±();
        Label_0016:
            num4 = -801060059;
        Label_0022:;
            int num5 = 0x3514a148;
            switch (((((-num5 - ((-0x1a157d3f - (0x57d29c4e - 0x22182bd6)) + -(0x742d9de + 0x470327ba))) + ~(0x1c9821cc ^ -464087766)) + num4) % 0x4d))
            {
                case 0:
                    goto Label_0B0B;

                case 1:
                    goto Label_04C9;

                case 2:
                    goto Label_1A59;

                case 3:
                    goto Label_09AA;

                case 4:
                    goto Label_1216;

                case 5:
                    goto Label_1785;

                case 6:
                    goto Label_0363;

                case 7:
                    goto Label_0FF7;

                case 8:
                    goto Label_06BF;

                case 9:
                    goto Label_0873;

                case 10:
                    goto Label_1547;

                case 11:
                    goto Label_0C97;

                case 12:
                    goto Label_1B3E;

                case 13:
                    goto Label_1D4F;

                case 14:
                    goto Label_11BF;

                case 15:
                    goto Label_020E;

                case 0x10:
                    goto Label_0F67;

                case 0x11:
                    goto Label_0F18;

                case 0x12:
                    goto Label_0FA5;

                case 0x13:
                    goto Label_144F;

                case 20:
                    goto Label_1585;

                case 0x15:
                    goto Label_1272;

                case 0x16:
                    goto Label_02DA;

                case 0x17:
                    goto Label_0C49;

                case 0x18:
                    goto Label_14E6;

                case 0x19:
                    goto Label_08BE;

                case 0x1a:
                    goto Label_07A6;

                case 0x1b:
                    goto Label_0685;

                case 0x1c:
                    goto Label_1DA2;

                case 0x1d:
                    goto Label_1DF0;

                case 30:
                    goto Label_196B;

                case 0x1f:
                    goto Label_1CA0;

                case 0x20:
                    goto Label_0630;

                case 0x21:
                    goto Label_0CD5;

                case 0x22:
                    goto Label_0C01;

                case 0x23:
                    goto Label_173E;

                case 0x24:
                    goto Label_1A05;

                case 0x25:
                    goto Label_0016;

                case 0x26:
                    goto Label_0D78;

                case 0x27:
                    goto Label_0AAE;

                case 40:
                    goto Label_0D35;

                case 0x29:
                    goto Label_0E90;

                case 0x2a:
                    goto Label_1084;

                case 0x2b:
                    goto Label_0DC5;

                case 0x2c:
                    goto Label_1032;

                case 0x2d:
                    goto Label_024D;

                case 0x2f:
                    goto Label_0716;

                case 0x30:
                    goto Label_1C29;

                case 0x31:
                    goto Label_031E;

                case 50:
                    goto Label_07F0;

                case 0x33:
                    goto Label_029B;

                case 0x34:
                    goto Label_149A;

                case 0x35:
                    goto Label_041E;

                case 0x36:
                    goto Label_08F8;

                case 0x37:
                    goto Label_05C6;

                case 0x38:
                    goto Label_16B4;

                case 0x39:
                    goto Label_0754;

                case 0x3a:
                    goto Label_0E45;

                case 0x3b:
                    goto Label_1D10;

                case 60:
                    goto Label_10CB;

                case 0x3d:
                    goto Label_047C;

                case 0x3e:
                    goto Label_1ABD;

                case 0x3f:
                    manager = (ComponentResourceManager) bä(>+Zí(typeof(Shit.holper).TypeHandle));
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xd6];
                    goto Label_0022;

                case 0x40:
                    goto Label_0A6C;

                case 0x41:
                    goto Label_1652;

                case 0x42:
                    goto Label_0BB6;

                case 0x43:
                    goto Label_0ED9;

                case 0x44:
                    goto Label_19B6;

                case 0x45:
                    goto Label_0507;

                case 70:
                    goto Label_1147;

                case 0x47:
                    goto Label_1E82;

                case 0x48:
                    goto Label_15D0;

                case 0x49:
                    goto Label_03BC;

                case 0x4a:
                    goto Label_0942;

                case 0x4b:
                    goto Label_0834;

                case 0x4c:
                    goto Label_1185;
            }
            goto Label_1EC1;
            this.NyX_Theme1 = (Shit.NYX_Theme) ä{Ãdâ();
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.NyX_GroupBox1 = (Shit.NYX_GroupBox) ØúUÀø();
            this.NyX_Button1 = (Shit.NYX_Button) K7Dá();
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.NyX_ControlBox1 = (Shit.NYX_ControlBox) °9O();
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            this.Timer3 = (Timer) ¾6ÊÜ(this.components);
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.Timer2 = (Timer) ¾6ÊÜ(this.components);
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.FolderBrowserDialog1 = (FolderBrowserDialog) ¿úZ();
            this.Timer1 = (Timer) ¾6ÊÜ(this.components);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xd7];
            goto Label_0022;
            this.ComboBox1 = (ComboBox) £©L/¹();
            this.Label5 = (Label) aÞCM2();
            this.ComboBox2 = (ComboBox) £©L/¹();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xd8];
            goto Label_0022;
            this.Label1 = (Label) aÞCM2();
            this.Label2 = (Label) aÞCM2();
            CÕ(this.NyX_Theme1);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            CÕ(this.NyX_GroupBox1);
            =µ§­(this);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xd9];
            goto Label_0022;
            this.NyX_Theme1.Animated = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xda];
            goto Label_0022;
            this.NyX_Theme1.BorderStyle = FormBorderStyle.None;
            this.NyX_Theme1.Colors = new Shit.Bloom[0];
            yã\B(*?(), this.Label2);
            yã\B(*?(), this.NyX_GroupBox1);
            yã\B(*?(), this.NyX_ControlBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xdb];
            goto Label_0022;
            this.NyX_Theme1.Customization = "";
            this.NyX_Theme1.Dock = DockStyle.Fill;
            this.NyX_Theme1.Font = (Font) ·)©ê("Arial", 9f);
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.NyX_Theme1.Image = null;
            *?(new Point(0, 0));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.NyX_Theme1.Movable = true;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            *?("NyX_Theme1");
            this.NyX_Theme1.NoRounding = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[220];
            goto Label_0022;
            this.NyX_Theme1.Sizable = true;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            *?(new Size(550, 230));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.NyX_Theme1.SmartBounds = true;
            this.NyX_Theme1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xdd];
            goto Label_0022;
            *?(0);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            this.NyX_Theme1.Text = "Helper";
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            this.NyX_Theme1.TransparencyKey = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x23]();
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.NyX_Theme1.Transparent = false;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_GroupBox1.Animated = true;
            this.NyX_GroupBox1.BorderStyle = FormBorderStyle.None;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xde];
            goto Label_0022;
            this.NyX_GroupBox1.Colors = new Shit.Bloom[0];
            yã\B(*?(), this.ComboBox2);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xdf];
            goto Label_0022;
            yã\B(*?(), this.Label1);
            yã\B(*?(), this.ComboBox1);
            yã\B(*?(), this.NyX_Button1);
            yã\B(*?(), this.Label5);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xe0];
            goto Label_0022;
            this.NyX_GroupBox1.Customization = "";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xe1];
            goto Label_0022;
            this.NyX_GroupBox1.Font = (Font) ·)©ê("Arial", 9f);
            this.NyX_GroupBox1.Image = null;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xe2];
            goto Label_0022;
            *?(new Point(15, 0x27));
            this.NyX_GroupBox1.Movable = true;
            *?("NyX_GroupBox1");
            this.NyX_GroupBox1.NoRounding = false;
            this.NyX_GroupBox1.Sizable = true;
            *?(new Size(0x20b, 0x94));
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.NyX_GroupBox1.SmartBounds = true;
            this.NyX_GroupBox1.StartPosition = FormStartPosition.Manual;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xe3];
            goto Label_0022;
            *?(0x20);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xe4];
            goto Label_0022;
            this.NyX_GroupBox1.Text = "Key Helper";
            this.NyX_GroupBox1.TransparencyKey = System.Drawing.Color.Empty;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.NyX_GroupBox1.Transparent = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xe5];
            goto Label_0022;
            this.NyX_Button1.Colors = new Shit.Bloom[0];
            this.NyX_Button1.Cursor = (Cursor) *CONSOLESCREENBUFFERINFO[0x5c]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[230];
            goto Label_0022;
            this.NyX_Button1.Customization = "";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xe7];
            goto Label_0022;
            this.NyX_Button1.Font = (Font) ·)©ê("Arial", 8f);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            this.NyX_Button1.Image = null;
            *?(new Point(0x1a3, 0x73));
            *?("NyX_Button1");
            this.NyX_Button1.NoRounding = false;
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            *?(new Size(0x5b, 20));
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            *?(0x1b);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xe8];
            goto Label_0022;
            this.NyX_Button1.Text = "Activate";
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.NyX_Button1.Transparent = false;
            this.NyX_ControlBox1.Colors = new Shit.Bloom[0];
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xe9];
            goto Label_0022;
            this.NyX_ControlBox1.Customization = "";
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.NyX_ControlBox1.Font = (Font) ·)©ê("Verdana", 8f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xea];
            goto Label_0022;
            this.NyX_ControlBox1.Image = null;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            *?(new Point(0x1eb, 3));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xeb];
            goto Label_0022;
            *?("NyX_ControlBox1");
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            this.NyX_ControlBox1.NoRounding = false;
            *?(new Size(0x2f, 20));
            *?(7);
            this.NyX_ControlBox1.Text = "NyX_ControlBox1";
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.NyX_ControlBox1.Transparent = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xec];
            goto Label_0022;
            this.Timer3.Enabled = true;
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            this.Timer1.Enabled = true;
            this.ComboBox1.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x60]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xed];
            goto Label_0022;
            *?(0);
            this.ComboBox1.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            *?(1);
            object[] objArray1 = new object[] { 
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P",
                "Q", "R", "S", "T", "U", "V", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7",
                "F8", "F9", "F10", "F11", "F12", "END", "INSERT", "HOME", "DELETE", "L.CTRL", "L.ALT"
            };
            SerializationObjectManager.ITypeLib2.TypeNameStruct(*?(), objArray1);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            *?(new Point(70, 0x29));
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            *?("ComboBox1");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xee];
            goto Label_0022;
            *?(new Size(0x58, 0x17));
            *?(0x22);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.Label5.AutoSize = true;
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            this.Label5.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0022;
            this.Label5.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            *?(new Point(0x12, 0x2c));
            *?("Label5");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xef];
            goto Label_0022;
            *?(new Size(0x2e, 15));
            *?(0x21);
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            this.Label5.Text = "Key [1]:";
            this.ComboBox2.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x60]();
            *?(0);
            this.ComboBox2.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[240];
            goto Label_0022;
            *?(1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xf1];
            goto Label_0022;
            object[] objArray2 = new object[] { 
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P",
                "Q", "R", "S", "T", "U", "V", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7",
                "F8", "F9", "F10", "F11", "F12", "END", "INSERT", "HOME", "DELETE", "L.CTRL", "L.ALT"
            };
            SerializationObjectManager.ITypeLib2.TypeNameStruct(*?(), objArray2);
            *?(new Point(70, 0x49));
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            *?("ComboBox2");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xf2];
            goto Label_0022;
            *?(new Size(0x58, 0x17));
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0022;
            *?(0x24);
            this.Label1.AutoSize = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xf3];
            goto Label_0022;
            this.Label1.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            this.Label1.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xf4];
            goto Label_0022;
            *?(new Point(0x12, 0x4c));
            *?("Label1");
            *?(new Size(0x2e, 15));
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0022;
            *?(0x23);
            this.Label1.Text = "Key [2]:";
            this.Label2.AutoSize = true;
            this.Label2.BackColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]();
            this.Label2.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x25]();
            *?(new Point(13, 0xc5));
            *?("Label2");
            *?(new Size(0, 15));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xf5];
            goto Label_0022;
            *?(0x25);
            *?(new SizeF(6f, 13f));
            *?(1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xf6];
            goto Label_0022;
            *?(new Size(550, 230));
            yã\B(*?(), this.NyX_Theme1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xf7];
            goto Label_0022;
            *?(0);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0022;
            *?((Icon) ]l¶+(manager, "$this.Icon"));
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0022;
            *?("holper");
            this.Text = "Settings";
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0022;
            *?(*CONSOLESCREENBUFFERINFO[0x23]());
            4Ü'Ô(this.NyX_Theme1, false);
            òS4É:(this.NyX_Theme1);
            4Ü'Ô(this.NyX_GroupBox1, false);
            òS4É:(this.NyX_GroupBox1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xf8];
            goto Label_0022;
            ©`Vñ(this, false);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xf9];
            goto Label_0022;
        }

        private void NyX_Button1_Click(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x8c02ff4b;
            if (!this.activated)
            {
                goto Label_0111;
            }
        Label_0011:
            num4 = 0x54735f39;
        Label_001C:;
            int num5 = 0x2849d5fa;
            switch (((-((num5 - (((~0x295e176 ^ (-1645993125 * -951964521)) * -958314807) - (-~-1575407080 + -(-336415151 + 0x73be8f82)))) * 0x5c2d34cf) + num4) % 5))
            {
                case 0:
                    goto Label_0011;

                case 2:
                    goto Label_00DC;

                case 3:
                    this.NyX_Button1.Text = "Activate";
                    num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                    goto Label_001C;

                case 4:
                    goto Label_0111;
            }
            goto Label_014B;
            this.activated = false;
            return;
            this.NyX_Button1.Text = "Deactivate";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x10a];
            goto Label_001C;
            this.activated = true;
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

        internal virtual Shit.NYX_Button NyX_Button1
        {
            [CompilerGenerated]
            get => 
                this._NyX_Button1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0xaa411b13;
                EventHandler handler = new EventHandler(this.NyX_Button1_Click);
                Shit.NYX_Button button = this._NyX_Button1;
                if (button == null)
                {
                    goto Label_00FC;
                }
            Label_0020:
                num4 = 0x11b28819;
            Label_002C:;
                int num5 = 0x3ab1e51c;
                int num3 = 0x4d2;
                switch (((~((((num5 * -1103446753) - ~((-1429798732 + 0x6b1a73c1) ^ (-107529154 - 0x773265a7))) ^ -347122161) - (-358975109 + 0x567859b5)) + num4) >> 0x10))
                {
                    case 1:
                        goto Label_0161;

                    case 2:
                        goto Label_0020;

                    case 3:
                        goto Label_00FC;

                    case 4:
                        *?(handler);
                        num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                        goto Label_002C;

                    case 5:
                        goto Label_0283;

                    case 6:
                        goto Label_012B;
                }
                goto Label_02C7;
                this._NyX_Button1 = value;
                num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
                goto Label_002C;
                button = this._NyX_Button1;
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_002C;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -916868673;
                goto Label_002C;
                *?(handler);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0xfb];
                goto Label_002C;
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

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._Label2 = value);
        }

        internal virtual ComboBox ComboBox2
        {
            [CompilerGenerated]
            get => 
                this._ComboBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._ComboBox2 = value);
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

