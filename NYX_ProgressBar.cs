namespace Shit
{
    using Shit.My;
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;

    internal class NYX_ProgressBar : Shit.ThemeControl154
    {
        private int _Maximum;
        private int _Value;
        private int Progress;

        public NYX_ProgressBar()
        {
            // This item is obfuscated and can not be translated.
            int num4;
        Label_000C:
            num4 = 0x6f5d26f6;
        Label_0017:;
            int num5 = 0x4de9dddf;
            switch (((~(((-1162830577 ^ -1285485140) + ~0x6b5f1fb6) - ~(num5 ^ -(~(0x2d49acaa + 0x74994df5) ^ 0x3ce29149))) + num4) >> 0x10))
            {
                case 0:
                    goto Label_000C;

                case 1:
                    this._Maximum = 100;
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x171];
                    goto Label_0017;
            }
            goto Label_00BB;
            *?(new Size(200, 0x19));
        }

        protected override void ColorHook()
        {
        }

        protected override void PaintHook()
        {
            // This item is obfuscated and can not be translated.
            ColorBlend blend;
            int num4;
            uint num = 0x21ebfc7f;
            º,Ôë(base.G, åG¿îÛ(0x16, 0x16, 0x16));
        Label_0026:
            num4 = 0x1be1f62e;
        Label_0032:;
            int num5 = -525549776;
            switch ((((((~(-((-1098208589 * 0x683914d) ^ ---1760569483) - num5) + ((0x40cd3bdf ^ 0x3da8c951) + (0x605644aa - 0x4d9c17a0))) * -187711041) ^ 0x65182285) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0026;

                case 2:
                    goto Label_0258;

                case 3:
                    goto Label_041F;

                case 4:
                    goto Label_0218;

                case 5:
                    goto Label_0163;

                case 6:
                    blend = (ColorBlend) imÆÀ\(3);
                    *?()[0] = åG¿îÛ(20, 20, 20);
                    *?()[1] = åG¿îÛ(15, 15, 15);
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[370];
                    goto Label_0032;

                case 7:
                    goto Label_0396;

                case 8:
                    goto Label_02B7;

                case 9:
                    goto Label_033A;
            }
            goto Label_054E;
            *?()[2] = åG¿îÛ(20, 20, 20);
            float[] singleArray1 = new float[3];
            singleArray1[1] = 0.5f;
            singleArray1[2] = 1f;
            *?(singleArray1);
            e@\dÎ(this, blend, new Rectangle(1, 1, ((int) *?()) - 2, ((int) *?()) - 2));
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0032;
            ColorBlend blend2 = (ColorBlend) imÆÀ\(3);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x173];
            goto Label_0032;
            *?()[0] = åG¿îÛ(210, 10, 10);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x174];
            goto Label_0032;
            *?()[1] = åG¿îÛ(120, 10, 10);
            *?()[2] = åG¿îÛ(0xa5, 10, 10);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0032;
            float[] singleArray2 = new float[3];
            singleArray2[1] = 0.5f;
            singleArray2[2] = 1f;
            *?(singleArray2);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x175];
            goto Label_0032;
            e@\dÎ(this, blend2, new Rectangle(1, 1, (int) Þ±ª0(((((double) *?()) / ((double) this._Maximum)) * this._Value) - 2.0), ((int) *?()) - 2));
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0032;
            Point[] pointArray = new Point[] { new Point(0, 2), new Point(2, 0), new Point(((int) *?()) - 3, 0), new Point(((int) *?()) - 1, 2), new Point(((int) *?()) - 1, ((int) *?()) - 3), new Point(((int) *?()) - 3, ((int) *?()) - 1), new Point(2, ((int) *?()) - 1), new Point(0, ((int) *?()) - 3) };
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x176];
            goto Label_0032;
            [_(base.G, *CONSOLESCREENBUFFERINFO[200](), pointArray);
        }

        public int Maximum
        {
            get => 
                this._Maximum;
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                if (value >= 1)
                {
                    goto Label_00D6;
                }
            Label_000D:
                num4 = -86810539;
            Label_0018:;
                int num5 = -108510637;
                int num3 = 0x4d2;
                switch (((((((-465922193 * (-1925314993 + 0x4c59a7e2)) - ((-369755937 * -1096840905) ^ ~0x6203598b)) - -num5) ^ (-1126996651 * (0x6483910b - 0x1421fa25))) + num4) >> 0x10))
                {
                    case 1:
                        goto Label_01BC;

                    case 2:
                        goto Label_01F5;

                    case 3:
                        goto Label_00D6;

                    case 4:
                        value = 1;
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x16a];
                        goto Label_0018;

                    case 5:
                        goto Label_000D;
                }
                goto Label_022A;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0xf80b07;
                goto Label_0018;
                this._Value = value;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x16b];
                goto Label_0018;
                this._Maximum = value;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x16d];
                goto Label_0018;
                ñÄ(this);
            }
        }

        public int Value
        {
            get => 
                this._Value;
            set
            {
                // This item is obfuscated and can not be translated.
                int num4;
                if (value <= this._Maximum)
                {
                    goto Label_00CD;
                }
            Label_0012:
                num4 = -378534384;
            Label_001D:;
                int num5 = -650778752;
                switch ((((-(num5 - (~(-479733026 ^ ~0x6f3578b3) * 0x4f7893b)) - ((0x5c62d2a6 - 0x2a2e04df) - (-2049706564 ^ -1559617884))) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_0012;

                    case 1:
                        goto Label_00CD;

                    case 2:
                        value = this.Maximum;
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x16e];
                        goto Label_001D;
                }
                goto Label_00FF;
                this._Value = value;
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x170];
                goto Label_001D;
                ñÄ(this);
            }
        }
    }
}

