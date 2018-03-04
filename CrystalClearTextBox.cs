namespace Shit
{
    using Shit.My;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    [DefaultEvent("TextChanged")]
    internal class CrystalClearTextBox : Shit.ThemeControl154
    {
        private HorizontalAlignment _TextAlign;
        private int _MaxLength;
        private bool _ReadOnly;
        private bool _UseSystemPasswordChar;
        private bool _Multiline;
        private TextBox Base;
        private System.Drawing.Color BG;
        private Pen P1;

        public CrystalClearTextBox()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0xe4d37b59;
        Label_000C:
            num4 = 0xe63b640;
        Label_0017:;
            int num5 = -1310748068;
            int num3 = 0x4d2;
            switch (((~((~(num5 - ~(0x286a35db * ((-551270624 + 0x56de8db2) + (-271049300 ^ 0x2e026eb9)))) + -~-384832163) + (0x50bdd032 - -1045029034)) + num4) >> 0x10))
            {
                case 0:
                    goto Label_000C;

                case 1:
                    this._TextAlign = HorizontalAlignment.Left;
                    num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                    goto Label_0017;

                case 3:
                    goto Label_01D1;

                case 4:
                    goto Label_02B8;

                case 5:
                    goto Label_03C9;

                case 6:
                    goto Label_0218;

                case 7:
                    goto Label_0114;

                case 8:
                    goto Label_0447;

                case 9:
                    goto Label_0193;

                case 10:
                    goto Label_0421;
            }
            goto Label_048E;
            this._MaxLength = 0x7fff;
            this.Base = (TextBox) ¨~º();
            this.Base.Font = this.Font;
            this.Base.Text = this.Text;
            this.Base.MaxLength = this._MaxLength;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x19c];
            goto Label_0017;
            this.Base.Multiline = this._Multiline;
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0017;
            *?(this._ReadOnly);
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0017;
            *?(this._UseSystemPasswordChar);
            *?(0);
            *?(new Point(4, 4));
            *?(*?() - 10);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0017;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1215270071;
            goto Label_0017;
            *?(*?() - 11);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x19d];
            goto Label_0017;
            num4 = 0xd909ea2;
            goto Label_0017;
            base.LockHeight = ((int) *?()) + 11;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0017;
            *?(new EventHandler(this.OnBaseTextChanged));
            *?(new KeyEventHandler(this.OnBaseKeyDown));
        }

        protected override void ColorHook()
        {
            this.Base.ForeColor = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0xcd]();
            this.Base.BackColor = åG¿îÛ(12, 12, 12);
        }

        private void OnBaseKeyDown(object s, KeyEventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x2fd6dc8;
            if (*?() == null)
            {
                goto Label_023E;
            }
        Label_001D:
            num4 = -1890467879;
        Label_0028:;
            int num5 = -1558376765;
            int num3 = 0x4d2;
            switch (((~~(num5 + (((-0x27aaa44c + -0x1ced545f) - ((0x1b85ca83 + 0x20eeabf9) ^ ~0x66e18de2)) - ~-739611402)) + num4) % 5))
            {
                case 1:
                    goto Label_01C1;

                case 2:
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = -1470454964;
                    goto Label_0028;

                case 3:
                    goto Label_01FE;

                case 4:
                    goto Label_001D;
            }
            goto Label_023E;
            0A(this.Base);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0028;
            *?(1);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0028;
        }

        private void OnBaseTextChanged(object s, EventArgs e)
        {
            this.Text = this.Base.Text;
        }

        protected override void OnCreation()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0xe266dc09;
            if (óÇ(*?(), this.Base))
            {
                goto Label_00ED;
            }
        Label_002A:
            num4 = -139633157;
        Label_0035:;
            int num5 = -612887143;
            switch ((((0x5002c452 - ~((~((-947846973 * 0x2ce8639) * -354489925) - (num5 * -608655451)) ^ 0x4d4bd88b)) + num4) >> 0x10))
            {
                case 0:
                    goto Label_002A;

                case 1:
                    yã\B(*?(), this.Base);
                    num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
                    goto Label_0035;
            }
            goto Label_00ED;
        }

        protected override void OnResize(EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            *?(new Point(4, 5));
            *?(*?() - 8);
            if (!this._Multiline)
            {
                goto Label_0107;
            }
        Label_0051:
            num4 = 0x35ddd5e;
        Label_005C:;
            int num5 = -1738575899;
            switch (((-((-~num5 * -943204969) * -1019314701) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0051;

                case 2:
                    *?(*?() - 5);
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x19f];
                    goto Label_005C;
            }
            goto Label_0107;
            ¦(this, e);
        }

        protected override void PaintHook()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x9279d61e;
            º,Ôë(base.G, åG¿îÛ(0x16, 0x16, 0x16));
        Label_0026:
            num4 = -1601247722;
        Label_0031:;
            int num5 = 0x333599b;
            switch ((((--((num5 - ((~~0x4155dd01 * 0x13e608ab) + (((0x293a58b5 ^ 0x20efb25a) + ~-757095434) + ((-713715017 - -517027700) ^ (0x77f04f5d ^ -1637787795))))) - (~-332424060 - (--1120160518 ^ (0x5e3fd9e1 * 0x87904c9)))) ^ -1159655941) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0026;

                case 1:
                    Zn-(base.G, !Xg(åG¿îÛ(12, 12, 12)), new Rectangle(0, 0, ((int) *?()) - 1, ((int) *?()) - 1));
                    num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                    goto Label_0031;

                case 2:
                    goto Label_0156;
            }
            goto Label_01A3;
            Ç=(this, *CONSOLESCREENBUFFERINFO[200]());
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0031;
        }

        public HorizontalAlignment TextAlign
        {
            get => 
                this._TextAlign;
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x57b8e3dc;
                this._TextAlign = value;
                if (this.Base == null)
                {
                    goto Label_00F3;
                }
            Label_0018:
                num4 = 0x2cacd593;
            Label_0023:;
                int num5 = -1867127500;
                switch ((((-810988817 - ((((-94273815 ^ -91870075) * 0x611c5591) - ((num5 ^ --((-728559475 - 0x6fca0078) ^ (-2094544530 - 0x2e8c5d26))) - (--661341722 - 0x58eac4f1))) + -1920422506)) + num4) >> 0x10))
                {
                    case 1:
                        *?(value);
                        num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                        goto Label_0023;

                    case 2:
                        goto Label_0018;
                }
                goto Label_00F3;
            }
        }

        public int MaxLength
        {
            get => 
                this._MaxLength;
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x76c3f34f;
                this._MaxLength = value;
                if (this.Base == null)
                {
                    goto Label_00D9;
                }
            Label_0018:
                num4 = -703741189;
            Label_0023:;
                int num5 = 0x7d2ccf7e;
                switch ((((((((num5 + ~(-(0x7ad0a303 * -1223212705) - -203222598)) - ((--1276400764 ^ 0x57cb8b62) * -321550595)) + ---1417241588) ^ -2122121246) + 0x7cb3d02a) + num4) % 3))
                {
                    case 0:
                        goto Label_0018;

                    case 2:
                        this.Base.MaxLength = value;
                        num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                        goto Label_0023;
                }
                goto Label_00D9;
            }
        }

        public bool ReadOnly
        {
            get => 
                this._ReadOnly;
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                this._ReadOnly = value;
            Label_000D:
                num4 = 0x7b6e1de8;
            Label_0018:;
                int num5 = -1837158623;
                int num3 = 0x4d2;
                switch (((((num5 * -1377859961) + (((-1081595713 - 0x1e9b8b89) ^ (0x4930848b ^ -1661089241)) - 0x1f0a11e9)) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_000D;

                    case 1:
                        goto Label_0198;

                    case 2:
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = -1037078055;
                        goto Label_0018;
                }
                goto Label_01DE;
                *?(value);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x197];
                goto Label_0018;
            }
        }

        public bool UseSystemPasswordChar
        {
            get => 
                this._UseSystemPasswordChar;
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x3d8cdee;
                this._UseSystemPasswordChar = value;
            Label_000D:
                num4 = 0x57ae19c8;
            Label_0018:;
                int num5 = -1336820676;
                int num3 = 0x4d2;
                switch ((((~(num5 - (~(-0x1c007bf7 - (-647845387 + 0x2945d3d1)) ^ ((--510537993 + (0x2e82aa0d + -2104992449)) + ~-1072544192))) ^ (-412778923 * (-1255630628 + 0x54bc82b))) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_000D;

                    case 1:
                        goto Label_01B3;

                    case 3:
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = 0x23ebd41;
                        goto Label_0018;
                }
                goto Label_01FC;
                *?(value);
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_0018;
            }
        }

        public bool Multiline
        {
            get => 
                this._Multiline;
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x7ec76adb;
                this._Multiline = value;
                if (this.Base == null)
                {
                    goto Label_02A1;
                }
            Label_0018:
                num4 = -716194885;
            Label_0023:;
                int num5 = -1060415687;
                int num3 = 0x4d2;
                switch (((~((num5 + ((~(0x2a6353fa - 0x4fc2b087) - (0x3e0e83d4 - ~0x59d5a128)) - ~~(-761780306 - 0x2bbc689b))) + (0x16bbb8af * (~0x29323542 + (0x79071357 + 0x3bc9975e)))) + num4) % 6))
                {
                    case 0:
                        goto Label_0018;

                    case 1:
                        this.Base.Multiline = value;
                        num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                        goto Label_0023;

                    case 2:
                        goto Label_025A;

                    case 3:
                        goto Label_00F1;

                    case 5:
                        goto Label_01FF;
                }
                goto Label_02A1;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x1a48bf70;
                goto Label_0023;
                base.LockHeight = 0;
                *?(*?() - 11);
                return;
                base.LockHeight = ((int) *?()) + 11;
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_0023;
            }
        }

        public override string Text
        {
            get => 
                base.Text;
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                base.Text = value;
                if (this.Base == null)
                {
                    goto Label_00F7;
                }
            Label_0018:
                num4 = 0x135ec30e;
            Label_0023:;
                int num5 = 0x51f26dd9;
                switch (((-(-((num5 ^ (0x30fde9f3 + -(0x251690c8 - (0x6bbec37d - 0x25e884ad)))) - (((-1664334722 + 0x5ed0312) * -1594645075) + ((0x72f4c7cf - 0x5c304b58) + (-1580193520 - 0x1c82462d)))) ^ (-785947361 + 0x2773ed67)) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_0018;

                    case 2:
                        this.Base.Text = value;
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x199];
                        goto Label_0023;
                }
                goto Label_00F7;
            }
        }

        public override System.Drawing.Font Font
        {
            get => 
                base.Font;
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                uint num = 0x6b9c34d3;
                base.Font = value;
            Label_000D:
                num4 = -41229688;
            Label_0018:;
                int num5 = -84122466;
                int num3 = 0x4d2;
                switch ((((((~(num5 - (((-1498803975 * -0xbbc1c8b) + (0x1aab8948 + (-29795442 ^ -802351291))) - -(~-1685551116 ^ (0x4d4ad3d0 + -1961837951)))) - ~(-591907729 * -767275587)) * 0x2fd982cb) + 0x485ebf13) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_000D;

                    case 1:
                        goto Label_02B2;

                    case 2:
                        goto Label_01D2;

                    case 3:
                        goto Label_020C;

                    case 4:
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = 0x8285841;
                        goto Label_0018;

                    case 5:
                        goto Label_0258;

                    case 7:
                        goto Label_03C9;
                }
                goto Label_0417;
                this.Base.Font = value;
                num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                goto Label_0018;
                *?(new Point(3, 5));
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[410];
                goto Label_0018;
                *?(*?() - 6);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x19b];
                goto Label_0018;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -805154710;
                goto Label_0018;
                base.LockHeight = ((int) *?()) + 11;
                num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                goto Label_0018;
            }
        }
    }
}

