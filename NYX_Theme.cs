namespace Shit
{
    using Shit.My;
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;

    internal class NYX_Theme : Shit.ThemeContainer154
    {
        private int H;
        private bool f;

        public NYX_Theme()
        {
            this.Animated = true;
            this.H = 0x19;
        }

        protected override void ColorHook()
        {
            base.TransparencyKey = (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x23]();
        }

        protected override unsafe void OnAnimation()
        {
            // This item is obfuscated and can not be translated.
            ref int numRef;
            int num4;
            if (!this.f)
            {
                goto Label_00D6;
            }
        Label_0011:
            num4 = -682804486;
        Label_001D:;
            int num5 = -1919990652;
            int num3 = 0x4d2;
            switch (((-~num5 + num4) % 8))
            {
                case 0:
                    goto Label_01F7;

                case 1:
                    goto Label_00D6;

                case 3:
                    goto Label_0231;

                case 4:
                    goto Label_032B;

                case 5:
                    goto Label_010F;

                case 6:
                    goto Label_0011;

                case 7:
                    *(numRef = (int) &this.H) = numRef - 1;
                    num4 = -260512118;
                    goto Label_001D;
            }
            goto Label_0364;
            *(numRef = (int) &this.H) = numRef + 1;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x14d];
            goto Label_001D;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x2f092e9e;
            goto Label_001D;
            this.f = false;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x14e];
            goto Label_001D;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1135710537;
            goto Label_001D;
            this.f = true;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x14f];
            goto Label_001D;
        }

        protected override void PaintHook()
        {
            // This item is obfuscated and can not be translated.
            Point[] pointArray;
            int num6;
            uint num3 = 0x48ae85c4;
            º,Ôë(base.G, (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x23]());
        Label_0025:
            num6 = 0x69fc4846;
        Label_0031:;
            int num7 = 0x7516cde;
            int num5 = 0x4d2;
            switch (((((~-1079292590 - num7) * 0x2fb2b149) + num6) % 0x12))
            {
                case 0:
                    goto Label_0546;

                case 1:
                    goto Label_098E;

                case 2:
                    goto Label_07BA;

                case 3:
                    goto Label_041D;

                case 4:
                    goto Label_075F;

                case 5:
                    goto Label_03CA;

                case 7:
                    pointArray = new Point[] { new Point(0, 1), new Point(1, 0), new Point(((int) *?()) - 2, 0), new Point(((int) *?()) - 1, 1), new Point(((int) *?()) - 1, 0x19), new Point(0, 0x19) };
                    num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x150];
                    goto Label_0031;

                case 8:
                    goto Label_026F;

                case 9:
                    goto Label_08EB;

                case 10:
                    goto Label_0218;

                case 11:
                    goto Label_0587;

                case 12:
                    goto Label_0688;

                case 13:
                    goto Label_084F;

                case 14:
                    goto Label_0940;

                case 15:
                    goto Label_0025;

                case 0x10:
                    goto Label_0187;

                case 0x11:
                    goto Label_036E;
            }
            goto Label_09E6;
            LinearGradientBrush brush = (LinearGradientBrush) >óù(new Rectangle(0, 0, ((int) *?()) - 1, 0x19), åG¿îÛ(60, 60, 60), åG¿îÛ(0x23, 0x23, 0x23), 90f);
            wìVW(base.G, brush, pointArray);
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x151];
            goto Label_0031;
            [_(base.G, *CONSOLESCREENBUFFERINFO[200](), pointArray);
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x152];
            goto Label_0031;
            Point[] pointArray2 = new Point[] { new Point(0, 0x19), new Point(((int) *?()) - 1, 0x19), new Point(((int) *?()) - 1, ((int) *?()) - 2), new Point(((int) *?()) - 2, ((int) *?()) - 1), new Point(1, ((int) *?()) - 1), new Point(0, ((int) *?()) - 2) };
            num6 = (int) (num3 ^ InternalSerializerTypeE.SoapOption);
            goto Label_0031;
            wìVW(base.G, !Xg(åG¿îÛ(0x23, 0x23, 0x23)), pointArray2);
            num6 = (int) (num3 ^ InternalSerializerTypeE.SoapOption);
            goto Label_0031;
            [_(base.G, *CONSOLESCREENBUFFERINFO[200](), pointArray2);
            num6 = (int) (num3 ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0031;
            num5 = 0x4d2;
            num5 = 0x4d2;
            num5 = 0x4d2;
            num5 = 0x4d2;
            num6 = 0x71b5e6ad;
            goto Label_0031;
            ColorBlend blend = (ColorBlend) imÆÀ\(3);
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x153];
            goto Label_0031;
            *?()[0] = åG¿îÛ(0x23, 0x23, 0x23);
            *?()[1] = åG¿îÛ(210, 0, 0);
            *?()[2] = åG¿îÛ(0x23, 0x23, 0x23);
            float[] singleArray1 = new float[3];
            singleArray1[1] = 0.6f;
            singleArray1[2] = 1f;
            *?(singleArray1);
            Le(this, blend, new Rectangle(1, this.H, (int) *?(), 0x4b));
            num6 = (int) (num3 ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0031;
            [_(base.G, *CONSOLESCREENBUFFERINFO[200](), pointArray);
            [_(base.G, *CONSOLESCREENBUFFERINFO[200](), pointArray2);
            ?]ÈÝÆ(base.G, *CONSOLESCREENBUFFERINFO[200](), new Point(0, ((int) *?()) - 9), new Point((int) *?(), ((int) *?()) - 9));
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[340];
            goto Label_0031;
            Rectangle rectangle = new Rectangle(8, 0x19, ((int) *?()) - 0x11, ((int) *?()) - 0x22);
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x156];
            goto Label_0031;
            Zn-(base.G, !Xg(åG¿îÛ(0x16, 0x16, 0x16)), rectangle);
            j:((base.G, *CONSOLESCREENBUFFERINFO[200](), rectangle);
            Font font = (Font) ÅøèN("Arial", 10f, FontStyle.Bold);
            num6 = (int) (num3 ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0031;
            SizeF ef =  ÃÞ`Á(&v¡Ë(this), this.Text, this.Font);
            int num = (int) Þ±ª0((double) *?());
            ef =  ÃÞ`Á(&v¡Ë(this), this.Text, this.Font);
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x157];
            goto Label_0031;
            int num1 = (int) Þ±ª0((double) *?());
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x158];
            goto Label_0031;
            SolidBrush brush2 = (SolidBrush) !Xg(åG¿îÛ(30, 0, 0));
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x159];
            goto Label_0031;
            int num2 = (int) Þ±ª0(((double) *?()) / 2.0);
            num6 = (int) (num3 ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0031;
            û±!Tõ(base.G, this.Text, font, brush2, (PointF) *CONSOLESCREENBUFFERINFO[0xb3](new Point((int) Þ±ª0((num2 - (((double) num) / 2.0)) + 1.0), 5)));
            û±!Tõ(base.G, this.Text, font, !Xg(åG¿îÛ(210, 10, 10)), (PointF) *CONSOLESCREENBUFFERINFO[0xb3](new Point((int) Þ±ª0(num2 - (((double) num) / 2.0)), 4)));
        }

        public bool Animated
        {
            get => 
                base.IsAnimated;
            set
            {
                base.IsAnimated = value;
                ñÄ(this);
            }
        }
    }
}

