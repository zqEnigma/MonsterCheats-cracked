namespace Shit
{
    using SerializationObjectManager;
    using Shit.My;
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    internal class CrystalClearTabControl : TabControl
    {
        private System.Drawing.Color _BG;

        public CrystalClearTabControl()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0xcbd28c2d;
        Label_000C:
            num4 = -636149131;
        Label_0017:;
            int num5 = -2093610906;
            switch ((((((-(num5 ^ (0x16e6fd5d + -620410048)) * 0x47db65fd) - (-589900743 - -419279776)) - -1741111376) + num4) % 4))
            {
                case 0:
                    goto Label_00CA;

                case 1:
                    öv(this, ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
                    this.DoubleBuffered = true;
                    num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                    goto Label_0017;

                case 2:
                    goto Label_000C;
            }
            goto Label_0112;
            this.BackColor = åG¿îÛ(0x16, 0x16, 0x16);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x1a0];
            goto Label_0017;
        }

        protected override void CreateHandle()
        {
            îüßÁ(this);
            *?(0);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // This item is obfuscated and can not be translated.
            uint num3;
            int num6;
            Bitmap bitmap = (Bitmap) áéCks((int) *?(), (int) *?());
            Graphics graphics = (Graphics)  &é(bitmap);
            try
            {
                *?().BackColor = this.BackColor;
            }
            catch (Exception exception1)
            {
                SerializationObjectManager.Object.StackFrameHelper(exception1);
                ¯3U();
            }
            º,Ôë(graphics, this.BackColor);
        Label_007D:
            num6 = -1873864115;
        Label_0089:;
            int num7 = -1100656198;
            int num5 = 0x4d2;
            switch (((((~num7 + ~0x3b67fb84) - -1769943795) + num6) >> 0x10))
            {
                case 0:
                    goto Label_06D0;

                case 1:
                {
                    int num = ((int) *?()) - 1;
                    num6 = (int) (num3 ^ InternalSerializerTypeE.IContextPropertyActivator);
                    goto Label_0089;
                }
                case 2:
                    goto Label_064E;

                case 3:
                    goto Label_0B49;

                case 4:
                    goto Label_07AE;

                case 5:
                    goto Label_0DDB;

                case 6:
                    goto Label_0C56;

                case 7:
                    goto Label_05A0;

                case 8:
                    goto Label_068C;

                case 9:
                    goto Label_0D4F;

                case 10:
                    goto Label_007D;

                case 11:
                    goto Label_0E97;

                case 12:
                    goto Label_0207;

                case 13:
                    goto Label_03F2;

                case 14:
                    goto Label_01D1;

                case 15:
                    goto Label_0ED7;

                case 0x10:
                    goto Label_0A44;

                case 0x11:
                    goto Label_060B;

                case 0x12:
                    goto Label_0338;

                case 0x13:
                    goto Label_053A;

                case 0x15:
                    goto Label_0231;

                case 0x16:
                    goto Label_0C29;
            }
            goto Label_0F17;
            int num2 = 0;
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x1a1];
            goto Label_0089;
            num6 = 0x305989d1;
            goto Label_0089;
            num5 = 0x4d2;
            num5 = 0x4d2;
            num6 = 0x7b206302;
            goto Label_0089;
            Rectangle rectangle = new Rectangle(((int) *?()) - 2, (int) *?(), (int) *?(), ((int) *?()) - 2);
            num6 = (int) (num3 ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0089;
            Rectangle rectangle2 = new Rectangle(((int) *?()) - 2, (int) *?(), (int) *?(), ((int) *?()) - 1);
            Rectangle rectangle3 = new Rectangle(((int) *?()) - 2, (int) *?(), (int) *?(), (int) *?());
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x1a2];
            goto Label_0089;
            LinearGradientBrush brush = (LinearGradientBrush) >óù(rectangle2, 
åô(10, 0, 0, 0), åG¿îÛ(0x23, 0x23, 0x23), 90f);
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x1a3];
            goto Label_0089;
            HatchBrush brush2 = (HatchBrush) ßùDb(HatchStyle.LightDownwardDiagonal, ²âÏÓ(10, (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[100]()), (System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0x24]());
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[420];
            goto Label_0089;
            Zn-(graphics, brush2, rectangle2);
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x1a5];
            goto Label_0089;
            µ³´(brush2);
            num6 = (int) (num3 ^ InternalSerializerTypeE.RemotingConfiguration);
            goto Label_0089;
            Zn-(graphics, brush, rectangle2);
            num6 = (int) (num3 ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0089;
            µ³´(brush);
            ?]ÈÝÆ(graphics, 57ÕX¦(åG¿îÛ(10, 10, 10)), (Point) *?(), new Point((int) *?(), (int) (*?() + *?())));
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x1a6];
            goto Label_0089;
            ?]ÈÝÆ(graphics, 57ÕX¦(åG¿îÛ(10, 10, 10)), new Point((int) (*?() + *?()), (int) *?()), new Point((int) (*?() + *?()), (int) (*?() + *?())));
            ?]ÈÝÆ(graphics, 57ÕX¦(åG¿îÛ(10, 10, 10)), new Point((int) *?(), (int) *?()), new Point((int) (*?() + *?()), (int) *?()));
            object obj1 = ¼Y*Ò();
            *?(1);
            *?(1);
            SerializationObjectManager.Fusion.AssemblyReferenceDependentAssemblyEntry(graphics, *?()[num2].Text, this.Font, !Xg((System.Drawing.Color) *CONSOLESCREENBUFFERINFO[0xcd]()), (RectangleF) *CONSOLESCREENBUFFERINFO[0xe2](rectangle3), obj1);
            num6 = -1835783338;
            goto Label_0089;
            Rectangle rectangle5 = new Rectangle(((int) *?()) - 2, ((int) *?()) + 3, (int) *?(), ((int) *?()) - 5);
            LinearGradientBrush brush3 = (LinearGradientBrush) >óù(rectangle5, åG¿îÛ(30, 30, 30), åG¿îÛ(0x23, 0x23, 0x23), -90f);
            Zn-(graphics, brush3, rectangle5);
            µ³´(brush3);
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x1a8];
            goto Label_0089;
            j:((graphics, 57ÕX¦(åG¿îÛ(15, 15, 15)), rectangle5);
            object obj2 = ¼Y*Ò();
            *?(1);
            *?(1);
            SerializationObjectManager.Fusion.AssemblyReferenceDependentAssemblyEntry(graphics, *?()[num2].Text, this.Font, !Xg((System.Drawing.Color) *CONSOLESCREENBUFFERINFO[100]()), (RectangleF) *CONSOLESCREENBUFFERINFO[0xe2](rectangle5), obj2);
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x1a9];
            goto Label_0089;
            num2++;
            num6 = (int) (num3 ^ InternalSerializerTypeE.SoapOption);
            goto Label_0089;
            num5 = 0x4d2;
            num5 = 0x4d2;
            num6 = 0x4f01a145;
            goto Label_0089;
            j:((graphics, >vÆ(!Xg(åG¿îÛ(10, 10, 10))), new Rectangle(0, 0x15, ((int) *?()) - 1, ((int) *?()) - 0x16));
            num6 = (int) (num3 ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0089;
            object[] objArray1 = new object[] { ãÄü(bitmap), 0, 0 };
            SerializationObjectManager.DecoratedNameAttribute.CategoryMembershipDataEntryFieldId(*?(), null, "DrawImage", objArray1, null, null, null, true);
            j:((graphics, *CONSOLESCREENBUFFERINFO[200](), new Rectangle(0, 0, ((int) *?()) - 1, ((int) *?()) - 1));
            num6 = (int) (num3 ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0089;
            áÎ9Ïå(graphics);
            num6 = (int) Shit.My.MyApplication.StringSplitOptions[0x1ab];
            goto Label_0089;
            iTp%(bitmap);
            num6 = (int) (num3 ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0089;
        }

        public Brush ToBrush(System.Drawing.Color color) => 
            ((Brush) !Xg(color));

        public Pen ToPen(System.Drawing.Color color) => 
            ((Pen) 57ÕX¦(color));

        public override System.Drawing.Color BackColor
        {
            get => 
                this._BG;
            set => 
                (this._BG = value);
        }
    }
}

