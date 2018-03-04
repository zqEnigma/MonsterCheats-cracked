namespace Shit
{
    using Shit.My;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows.Forms;

    [DefaultEvent("CheckedChanged")]
    internal class NYX_CheckBox : Shit.ThemeControl154
    {
        private int X;
        private int Y;
        private bool _Checked;
        [CompilerGenerated]
        private CheckedChangedEventHandler CheckedChangedEvent;

        public event CheckedChangedEventHandler CheckedChanged
        {
            [CompilerGenerated] add
            {
                // This item is obfuscated and can not be translated.
                int num4;
                CheckedChangedEventHandler checkedChangedEvent = this.CheckedChangedEvent;
            Label_000D:
                num4 = 0x7b01eed6;
            Label_0019:;
                int num5 = 0x28805072;
                int num3 = 0x4d2;
                switch (((~~((num5 + ((~(-2039823297 ^ 0x2dc4876c) ^ -(-520516323 + 0x5b09f86d)) - ((-555351108 - ~-1938537597) ^ ((-374130025 * 0x29d34ce9) - (0x37ba2cbe - 0x5f2bb607))))) - ((-1606973065 * (0x1ed474af - 0x735730a6)) + 0x5b699cfb)) + num4) >> 0x10))
                {
                    case 0:
                        goto Label_000D;

                    case 2:
                    {
                        CheckedChangedEventHandler comparand = checkedChangedEvent;
                        CheckedChangedEventHandler handler3 = (CheckedChangedEventHandler) »"¯Ó¿(comparand, obj);
                        checkedChangedEvent = Interlocked.CompareExchange<CheckedChangedEventHandler>(ref this.CheckedChangedEvent, handler3, comparand);
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = -1387748847;
                        goto Label_0019;
                    }
                }
                goto Label_01D7;
            }
            [CompilerGenerated] remove
            {
                // This item is obfuscated and can not be translated.
                CheckedChangedEventHandler handler2;
                CheckedChangedEventHandler handler3;
                int num4;
                uint num = 0x34e263e1;
                CheckedChangedEventHandler checkedChangedEvent = this.CheckedChangedEvent;
            Label_000D:
                num4 = 0x61e8c632;
            Label_0019:;
                int num5 = -1140764891;
                int num3 = 0x4d2;
                switch (((~~num5 + num4) % 5))
                {
                    case 0:
                        goto Label_000D;

                    case 1:
                        handler2 = checkedChangedEvent;
                        handler3 = (CheckedChangedEventHandler) +î<(handler2, obj);
                        num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                        goto Label_0019;

                    case 2:
                        goto Label_00AC;

                    case 4:
                        goto Label_00F2;
                }
                goto Label_0217;
                checkedChangedEvent = Interlocked.CompareExchange<CheckedChangedEventHandler>(ref this.CheckedChangedEvent, handler3, handler2);
                num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x196];
                goto Label_0019;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -1422739476;
                goto Label_0019;
            }
        }

        public NYX_CheckBox()
        {
            *?(new Size(120, 20));
            base.LockHeight = 20;
        }

        protected override void ColorHook()
        {
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            Â~øR/(this, e);
            if (this.X > 0x10)
            {
                goto Label_0446;
            }
        Label_001F:
            num4 = 0x511bda81;
        Label_002B:;
            int num5 = 0x79f9061e;
            int num3 = 0x4d2;
            switch (((~(~-num5 * 0x2a7eb2c3) + num4) % 7))
            {
                case 1:
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = -938484049;
                    goto Label_002B;

                case 2:
                    goto Label_040C;

                case 3:
                    goto Label_001F;

                case 4:
                    goto Label_02FD;

                case 5:
                    goto Label_02B4;

                case 6:
                    goto Label_01A1;
            }
            goto Label_0446;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1464501023;
            goto Label_002B;
            this._Checked = !this._Checked;
            CheckedChangedEventHandler checkedChangedEvent = this.CheckedChangedEvent;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x193];
            goto Label_002B;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x2d93b383;
            goto Label_002B;
            checkedChangedEvent(this);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x194];
            goto Label_002B;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x6502ec46;
            ËÈ>}(this, e);
        Label_0012:
            num4 = 0x59251a7a;
        Label_001E:;
            int num5 = -1213780294;
            switch (((~-num5 + num4) % 4))
            {
                case 0:
                    goto Label_0012;

                case 2:
                    goto Label_00C5;

                case 3:
                    this.X = (int) *?();
                    num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                    goto Label_001E;
            }
            goto Label_0127;
            this.Y = (int) *?();
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x18a];
            goto Label_001E;
            ñÄ(this);
        }

        protected override void PaintHook()
        {
            // This item is obfuscated and can not be translated.
            Point[] pointArray2;
            int num4;
            uint num = 0xb7e1bb77;
            º,Ôë(base.G, åG¿îÛ(0x16, 0x16, 0x16));
            Point[] pointArray = new Point[] { new Point(3, 5), new Point(5, 3), new Point(14, 3), new Point(0x10, 5), new Point(0x10, 14), new Point(14, 0x10), new Point(5, 0x10), new Point(3, 14) };
        Label_00A6:
            num4 = -1055862513;
        Label_00B2:;
            int num5 = 0x1ced961a;
            int num3 = 0x4d2;
            switch ((((~-num5 ^ ((0x20bec711 - 0x3ebcbb6f) ^ 0x6611596b)) + num4) % 0x16))
            {
                case 0:
                    goto Label_0AD9;

                case 1:
                    pointArray2 = new Point[] { new Point(4, 6), new Point(6, 4), new Point(13, 4), new Point(15, 6), new Point(15, 13), new Point(13, 15), new Point(6, 15), new Point(4, 13) };
                    [_(base.G, *CONSOLESCREENBUFFERINFO[200](), pointArray);
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x18b];
                    goto Label_00B2;

                case 2:
                    goto Label_03B0;

                case 3:
                    goto Label_0E09;

                case 4:
                    goto Label_06F1;

                case 5:
                    goto Label_0882;

                case 6:
                    goto Label_0784;

                case 7:
                    goto Label_0C04;

                case 8:
                    goto Label_0327;

                case 10:
                    goto Label_03ED;

                case 11:
                    goto Label_071A;

                case 12:
                    goto Label_0497;

                case 13:
                    goto Label_0297;

                case 14:
                    goto Label_069E;

                case 15:
                    goto Label_0C9F;

                case 0x10:
                    goto Label_00A6;

                case 0x11:
                    goto Label_0C76;

                case 0x12:
                    goto Label_05E7;

                case 0x13:
                    goto Label_0D99;

                case 20:
                    goto Label_0637;

                case 0x15:
                    goto Label_09AC;
            }
            goto Label_0E52;
            ColorBlend blend = (ColorBlend) imÆÀ\(3);
            *?()[0] = åG¿îÛ(90, 0, 0);
            *?()[1] = åG¿îÛ(120, 0, 0);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x18c];
            goto Label_00B2;
            *?()[2] = åG¿îÛ(180, 0, 0);
            float[] singleArray1 = new float[3];
            singleArray1[1] = 0.7f;
            singleArray1[2] = 1f;
            *?(singleArray1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x18d];
            goto Label_00B2;
            ColorBlend blend2 = (ColorBlend) imÆÀ\(3);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_00B2;
            *?()[0] = åG¿îÛ(14, 14, 14);
            *?()[1] = åG¿îÛ(12, 12, 12);
            *?()[2] = åG¿îÛ(0x10, 0x10, 0x10);
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_00B2;
            float[] singleArray2 = new float[3];
            singleArray2[1] = 0.5f;
            singleArray2[2] = 1f;
            *?(singleArray2);
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x68c8531f;
            goto Label_00B2;
            øÐï(this, blend, new Rectangle(4, 4, 12, 12), -45f);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x18e];
            goto Label_00B2;
            [_(base.G, >vÆ(!Xg(åG¿îÛ(150, 0, 0))), pointArray2);
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_00B2;
            [_(base.G, *CONSOLESCREENBUFFERINFO[200](), pointArray);
            num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_00B2;
            num4 = 0x4498fd26;
            goto Label_00B2;
            øÐï(this, blend2, new Rectangle(4, 4, 12, 12), -45f);
            [_(base.G, *CONSOLESCREENBUFFERINFO[200](), pointArray);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[400];
            goto Label_00B2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x22a3a794;
            goto Label_00B2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -252049070;
            goto Label_00B2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x1cb201a5;
            goto Label_00B2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x5c70661f;
            goto Label_00B2;
            [_(base.G, >vÆ(!Xg(åG¿îÛ(210, 210, 210))), pointArray);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x191];
            goto Label_00B2;
            num4 = -1821050103;
            goto Label_00B2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1341217781;
            goto Label_00B2;
            [_(base.G, >vÆ(!Xg(åG¿îÛ(210, 210, 210))), pointArray);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_00B2;
            jA(this, *CONSOLESCREENBUFFERINFO[0xd0](), HorizontalAlignment.Left, 20, 1);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_00B2;
            jA(this, *CONSOLESCREENBUFFERINFO[0xd4](), HorizontalAlignment.Left, 0x13, 0);
        }

        public bool Checked
        {
            get => 
                this._Checked;
            set
            {
                this._Checked = value;
                ñÄ(this);
            }
        }

        public delegate void CheckedChangedEventHandler(object sender);
    }
}

