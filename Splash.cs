namespace Shit
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Splash : Form
    {
        private IContainer components;

        public Splash()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x56dfeb54;
        Label_000C:
            num4 = 0x35391f7;
        Label_0017:;
            int num5 = 0x1e741d28;
            switch (((~-~((num5 + ((~(-577124289 + 0x1ba23fa6) - ~(0xbecdf77 + -1368781535)) - --1075256612)) - ((~0x75164977 + ~-2074030988) ^ (0x4e84d3af * 0x2f4a4b06))) + num4) % 3))
            {
                case 0:
                    goto Label_000C;

                case 2:
                    S9¶×(this);
                    num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                    goto Label_0017;
            }
            goto Label_00CE;
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                uint num2;
                int num4;
                int expressionStack_17_0;
                int expressionStack_12A_0;
                int expressionStack_12A_1;
                uint num = 0x63a14737;
                if (!disposing)
                {
                    return;
                }
            Label_000C:
                num4 = 0x3b3aefd;
                expressionStack_17_0 = 0x6582ab25;
            Label_0017:;
                int num5 = expressionStack_17_0;
                int num3 = 0x4d2;
                switch (((num2 = (uint) (-(~((~-1915662563 - num5) + 0x70a2d71a) * 0x1d8288bd) + num4)) % 4))
                {
                    case 0:
                        return;

                    case 1:
                        if (this.components == null)
                        {
                            break;
                        }
                        num3 = 0x4d2;
                        expressionStack_12A_1 = 0x706e25f1;
                        goto Label_012A;

                    case 2:
                        goto Label_000C;

                    case 3:
                        ÂÔç(this.components);
                        num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                        expressionStack_17_0 = ((int) (num2 >> 0x500f51c2)) ^ -932341038;
                        goto Label_0017;

                    default:
                        return;
                }
                expressionStack_12A_1 = -1436325962;
            Label_012A:
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = 0x1b799950;
                expressionStack_17_0 = expressionStack_12A_1 ^ ((int) (num2 * 0x8004f4b3));
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
            int num4;
            uint num = 0x932f9176;
            ComponentResourceManager manager = (ComponentResourceManager) bä(>+Zí(typeof(Shit.Splash).TypeHandle));
            =µ§­(this);
        Label_002B:
            num4 = 0x1ac94f16;
        Label_0037:;
            int num5 = 0x2bef4087;
            switch (((((-((num5 - ((0x121830ef * (-0x273d711e ^ --1888082517)) - ~~(0x358cfdd7 + 0x48b8caf4))) ^ -((0x69e9cb83 - 0x38be43d0) ^ 0x5e664940)) * -1856335105) - 0x6340d763) + num4) % 5))
            {
                case 0:
                    goto Label_0116;

                case 1:
                    *?(new SizeF(6f, 13f));
                    num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
                    goto Label_0037;

                case 2:
                    goto Label_020D;

                case 3:
                    goto Label_002B;
            }
            goto Label_0272;
            *?(1);
            this.BackColor = åG¿îÛ(0x40, 0x40, 0x40);
            this.BackgroundImage = (Image) ]l¶+(manager, "$this.BackgroundImage");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            *?(new Size(0x283, 0xcb));
            this.DoubleBuffered = true;
            *?(0);
            *?((Icon) ]l¶+(manager, "$this.Icon"));
            *?("Splash");
            *?(1);
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_0037;
            this.Text = "Splash";
            *?(åG¿îÛ(0x40, 0x40, 0x40));
            ©`Vñ(this, false);
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0037;
        }
    }
}

