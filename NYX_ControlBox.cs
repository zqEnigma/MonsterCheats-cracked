namespace Shit
{
    using SerializationObjectManager;
    using Shit.My;
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    internal class NYX_ControlBox : Shit.ThemeControl154
    {
        private int X;
        private bool minOver;
        private bool xOver;

        public NYX_ControlBox()
        {
            // This item is obfuscated and can not be translated.
            int num4;
        Label_000C:
            num4 = 0x4d8a5cd6;
        Label_0017:;
            int num5 = -1971864959;
            switch (((-((~(num5 - ((~(-820316546 - -1358437090) ^ ((0x6b715001 - -946863030) * 0x5a5afbeb)) ^ 0x627638f5)) + 0xaad834d) * 0x59a59063) + num4) % 3))
            {
                case 1:
                    *?(new Size(0x2c, 20));
                    base.IsAnimated = true;
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x181];
                    goto Label_0017;

                case 2:
                    goto Label_000C;
            }
            goto Label_00DC;
        }

        protected override void ColorHook()
        {
        }

        protected override void OnAnimation()
        {
            	ÿÛK(this);
        }

        protected override void OnClick(EventArgs e)
        {
            int num4;
            s(Nw(this, e);
            if (this.X > 0x16)
            {
                goto Label_00E9;
            }
        Label_001F:
            num4 = 0x88a6dcc;
            int num5 = 0x578a8909;
            switch (((-~((-num5 + ((-0x1592f020 + (0x172b2d5f - -597411951)) * -294529105)) ^ (-654188701 - (0x1736d4d * 0x7a8bc02d))) + num4) >> 0x10))
            {
                case 0:
                    goto Label_001F;

                case 1:
                    *?(1);
                    return;
            }
        Label_00E9:
            G¥ÛõW(Ïâ6)(this));
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            ËÈ>}(this, e);
            this.X = (int) *?();
            ñÄ(this);
        }

        protected override void PaintHook()
        {
            // This item is obfuscated and can not be translated.
            Rectangle rectangle;
            int num4;
            uint num = 0x5b59864;
            º,Ôë(base.G, åG¿îÛ(30, 30, 30));
        Label_0027:
            num4 = 0x54eb27a8;
        Label_0033:;
            int num5 = -1868519185;
            int num3 = 0x4d2;
            switch (((((((0x44da0141 * -556476235) ^ ~0x173fe2de) - ((num5 + ((((0x34b0281b * 0x64da097d) - (-1470071373 * -232472619)) - (~0x2853b1bf ^ (-1839475734 - -1804349469))) + ((~0x79f4cfc0 - 0x7e7eb553) + -13692433))) ^ (~--1350436807 + ~~-134006400))) + (-1464232891 * -1230238861)) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0905;

                case 1:
                    goto Label_0AB6;

                case 2:
                    goto Label_0B15;

                case 3:
                    goto Label_035D;

                case 4:
                    goto Label_0A38;

                case 5:
                    goto Label_086F;

                case 6:
                    goto Label_048A;

                case 7:
                    goto Label_09FF;

                case 8:
                    goto Label_0771;

                case 9:
                    rectangle = new Rectangle(0, 0, (int) Þ±ª0(((double) *?()) / 2.0), ((int) *?()) - 1);
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x183];
                    goto Label_0033;

                case 11:
                    goto Label_08DC;

                case 12:
                    goto Label_05B1;

                case 13:
                    goto Label_022C;

                case 14:
                    goto Label_0027;

                case 15:
                    goto Label_02F8;

                case 0x10:
                    goto Label_06DB;

                case 0x11:
                    goto Label_0747;

                case 0x12:
                    goto Label_0A74;
            }
            goto Label_0B98;
            Rectangle rectangle2 = new Rectangle((int) Þ±ª0(((double) *?()) / 2.0), 0, (int) Þ±ª0((((double) *?()) / 2.0) - 1.0), ((int) *?()) - 1);
            Rectangle rectangle3 = new Rectangle(0, 0, ((int) *?()) - 1, ((int) *?()) - 1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x184];
            goto Label_0033;
            LinearGradientBrush brush = (LinearGradientBrush) >óù(rectangle3, åG¿îÛ(30, 30, 30), åG¿îÛ(0x23, 0x23, 0x23), 90f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x185];
            goto Label_0033;
            Shit.MouseState state = base.State;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -115262814;
            goto Label_0033;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -2051652580;
            goto Label_0033;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x5ef69996;
            goto Label_0033;
            Zn-(base.G, !Xg(²âÏÓ(50, (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0xcd]())), rectangle);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[390];
            goto Label_0033;
            num4 = -865994226;
            goto Label_0033;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x6397c154;
            goto Label_0033;
            Zn-(base.G, !Xg(²âÏÓ(50, (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0xcd]())), rectangle2);
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0033;
            num4 = -1352431046;
            goto Label_0033;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -910842115;
            goto Label_0033;
            this.X = -1;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0033;
            Zn-(base.G, brush, rectangle3);
            num4 = -639181866;
            goto Label_0033;
            Zn-(base.G, brush, rectangle3);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x188];
            goto Label_0033;
            Rectangle[] rectangleArray1 = new Rectangle[] { rectangle, rectangle2 };
            SerializationObjectManager.AsyncReplySink.ResourceAttributesFixedAddressValueTypeAttribute(base.G, *CONSOLESCREENBUFFERINFO[200](), rectangleArray1);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0033;
            û±!Tõ(base.G, "0", ·)©ê("Marlett", 8.25f), *CONSOLESCREENBUFFERINFO[0xd1](), (PointF) *CONSOLESCREENBUFFERINFO[0xb3](new Point(5, 5)));
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_0033;
            û±!Tõ(base.G, "r", ·)©ê("Marlett", 10f), *CONSOLESCREENBUFFERINFO[0xd1](), (PointF) *CONSOLESCREENBUFFERINFO[0xb3](new Point(0x1a, 4)));
        }
    }
}

