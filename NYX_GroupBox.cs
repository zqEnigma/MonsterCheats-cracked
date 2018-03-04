namespace Shit
{
    using Shit.My;
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;

    internal class NYX_GroupBox : Shit.ThemeContainer154
    {
        private int x;
        private bool gR;

        public NYX_GroupBox()
        {
            // This item is obfuscated and can not be translated.
            int num4;
        Label_000C:
            num4 = -1177311123;
        Label_0017:;
            int num5 = -735034553;
            switch (((((num5 ^ -(((0x287af815 ^ -1841511013) + (0x6e4fa227 + -474086113)) + ~(-850867563 - 0x3625091))) + ((-1385613003 * (-1795677708 + -758574547)) + (~-378332632 - --1627762789))) + num4) % 3))
            {
                case 0:
                    goto Label_000C;

                case 1:
                    this.x = 1;
                    this.gR = true;
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x177];
                    goto Label_0017;
            }
            goto Label_00DD;
            base.ControlMode = true;
            this.Font = (Font) ·)©ê("Arial", 9f);
            *?(new Size(150, 100));
            this.Animated = true;
        }

        protected override void ColorHook()
        {
        }

        protected override unsafe void OnAnimation()
        {
            // This item is obfuscated and can not be translated.
            ref int numRef;
            int num4;
            uint num = 0xa927c9c4;
            ø?&ôm(this);
        Label_0011:
            num4 = 0x34d973b2;
        Label_001D:;
            int num5 = 0x3a5780c6;
            int num3 = 0x4d2;
            switch (((-~((-num5 - (((-2128925638 ^ 0x3d6ad2fc) ^ (-316618048 * 0x4cf657b)) - (-1132173954 ^ -0x3e6446c5))) ^ 0x4140ab4) + num4) >> 0x10))
            {
                case 0:
                    goto Label_03AC;

                case 1:
                    goto Label_0258;

                case 2:
                    goto Label_02B5;

                case 3:
                    goto Label_03E6;

                case 4:
                    goto Label_040D;

                case 5:
                    goto Label_04F3;

                case 6:
                    goto Label_0218;

                case 7:
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = -1592787932;
                    goto Label_001D;

                case 8:
                    goto Label_0011;

                case 10:
                    goto Label_0280;
            }
            goto Label_052C;
            *(numRef = (int) &this.x) = numRef + 1;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x178];
            goto Label_001D;
            num4 = 0x26ca9bcd;
            goto Label_001D;
            *(numRef = (int) &this.x) = numRef - 1;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_001D;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x6ffb1649;
            goto Label_001D;
            this.x = -39;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x17a];
            goto Label_001D;
            num4 = 0x78d27c89;
            goto Label_001D;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1564074147;
            goto Label_001D;
            this.gR = true;
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_001D;
            ñÄ(this);
        }

        protected override void PaintHook()
        {
            // This item is obfuscated and can not be translated.
            int num;
            SizeF ef;
            int num7;
            uint num4 = 0x6d76fb15;
            º,Ôë(base.G, åG¿îÛ(30, 30, 30));
        Label_0027:
            num7 = 0x4256b724;
        Label_0033:;
            int num8 = -1446700116;
            int num6 = 0x4d2;
            switch (((-(-num8 * 0x32b026e5) + num7) >> 0x10))
            {
                case 0:
                    goto Label_0027;

                case 1:
                    goto Label_06D5;

                case 2:
                    goto Label_064E;

                case 3:
                    goto Label_04A5;

                case 4:
                    ef =  ÃÞ`Á(&v¡Ë(this), this.Text, this.Font);
                    num = (int) Þ±ª0((double) *?());
                    num7 = (int) (num4 ^ InternalSerializerTypeE.RemotingConfiguration);
                    goto Label_0033;

                case 5:
                    goto Label_07F1;

                case 6:
                    goto Label_03F4;

                case 7:
                    goto Label_078A;

                case 8:
                    goto Label_05FA;

                case 9:
                    goto Label_012B;

                case 10:
                    goto Label_0296;

                case 11:
                    goto Label_0365;

                case 12:
                    goto Label_02F0;

                case 14:
                    goto Label_072F;
            }
            goto Label_0947;
            ef =  ÃÞ`Á(&v¡Ë(this), this.Text, this.Font);
            int num2 = (int) Þ±ª0((double) *?());
            Point[] pointArray = new Point[] { new Point(0, 1), new Point(1, 0), new Point(((int) *?()) - 2, 0), new Point(((int) *?()) - 1, 1), new Point(((int) *?()) - 1, ((int) *?()) - 2), new Point(((int) *?()) - 2, ((int) *?()) - 1), new Point(1, ((int) *?()) - 1), new Point(0, ((int) *?()) - 2) };
            num7 = (int) (num4 ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0033;
            [_(base.G, *CONSOLESCREENBUFFERINFO[200](), pointArray);
            num7 = (int) Shit.My.MyApplication.StringSplitOptions[0x17b];
            goto Label_0033;
            ?]ÈÝÆ(base.G, *CONSOLESCREENBUFFERINFO[200](), new Point(0, num2 + 4), new Point(((int) *?()) - 1, num2 + 4));
            num7 = (int) (num4 ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0033;
            Rectangle rectangle = new Rectangle(1, num2 + 5, ((int) *?()) - 2, ((int) *?()) - (num2 + 6));
            Zn-(base.G, !Xg(åG¿îÛ(0x16, 0x16, 0x16)), rectangle);
            num7 = (int) Shit.My.MyApplication.StringSplitOptions[380];
            goto Label_0033;
            j:((base.G, >vÆ(!Xg(åG¿îÛ(12, 12, 12))), new Rectangle(1, num2 + 6, ((int) *?()) - 3, (((int) *?()) - (num2 + 6)) - 2));
            Rectangle rectangle2 = new Rectangle(1, 1, ((int) *?()) - 2, num2 + 5);
            num7 = (int) (num4 ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0033;
            Zn-(base.G, !Xg(åG¿îÛ(15, 15, 15)), rectangle2);
            num6 = 0x4d2;
            num6 = 0x4d2;
            num6 = 0x4d2;
            num6 = 0x4d2;
            num7 = -1254614790;
            goto Label_0033;
            Rectangle rectangle3 = new Rectangle(this.x, 1, 40, num2 + 4);
            ColorBlend blend = (ColorBlend) imÆÀ\(3);
            num7 = (int) Shit.My.MyApplication.StringSplitOptions[0x17d];
            goto Label_0033;
            *?()[0] = åG¿îÛ(15, 15, 15);
            *?()[1] = åG¿îÛ(150, 0, 0);
            num7 = (int) Shit.My.MyApplication.StringSplitOptions[0x17e];
            goto Label_0033;
            *?()[2] = åG¿îÛ(15, 15, 15);
            num7 = (int) (num4 ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0033;
            float[] singleArray1 = new float[3];
            singleArray1[1] = 0.5f;
            singleArray1[2] = 1f;
            *?(singleArray1);
            num7 = (int) (num4 ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0033;
            Üð)iD(this, blend, rectangle3, 0f);
            [_(base.G, *CONSOLESCREENBUFFERINFO[200](), pointArray);
            num7 = (int) (num4 ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0033;
            ?]ÈÝÆ(base.G, *CONSOLESCREENBUFFERINFO[200](), new Point(0, num2 + 5), new Point(((int) *?()) - 1, num2 + 5));
            int num3 = (int) Þ±ª0(((double) (*?() - 1)) / 2.0);
            û±!Tõ(base.G, this.Text, this.Font, *CONSOLESCREENBUFFERINFO[0xd0](), (PointF) *CONSOLESCREENBUFFERINFO[0xb3](new Point((int) Þ±ª0(num3 - (((double) num) / 2.0)), 4)));
            û±!Tõ(base.G, this.Text, this.Font, *CONSOLESCREENBUFFERINFO[0xd1](), (PointF) *CONSOLESCREENBUFFERINFO[0xb3](new Point((int) Þ±ª0(num3 - (((double) num) / 2.0)), 3)));
            num7 = (int) Shit.My.MyApplication.StringSplitOptions[0x180];
            goto Label_0033;
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

