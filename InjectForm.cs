namespace Shit
{
    using Microsoft.VisualBasic.CompilerServices;
    using Shit.My;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class InjectForm : Form
    {
        private IContainer components;
        [CompilerGenerated, AccessedThroughProperty("SaveFileDialog1")]
        private SaveFileDialog _SaveFileDialog1;
        [AccessedThroughProperty("OpenFileDialog1"), CompilerGenerated]
        private OpenFileDialog _OpenFileDialog1;
        [AccessedThroughProperty("DllName"), CompilerGenerated]
        private ListBox _DllName;

        public InjectForm()
        {
            *?(new EventHandler(this.InjectForm_Load));
            :p(this);
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                uint num;
                uint num2;
                int num4;
                int expressionStack_15E_0;
                int expressionStack_15E_1;
                if (!disposing)
                {
                    return;
                }
            Label_000C:
                num4 = 0x17b740dd;
                int expressionStack_17_0 = -341902472;
            Label_0017:;
                int num5 = expressionStack_17_0;
                int num3 = 0x4d2;
                switch (((num2 = (uint) (-(((-num5 ^ (((-767285365 + 0x49d6b8d3) + (-2086532161 * 0x4a2289be)) + ((-1020713493 - 0x253a285e) ^ (-146445219 ^ 0x244f7f4a)))) ^ ~(-1057277246 ^ -651448076)) * 0x350c1207) + num4)) >> 0x10))
                {
                    case 0:
                        return;

                    case 1:
                        if (this.components != null)
                        {
                            break;
                        }
                        num3 = 0x4d2;
                        expressionStack_15E_1 = 0x45e6125a;
                        goto Label_015E;

                    case 2:
                        ÂÔç(this.components);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x30];
                        expressionStack_17_0 = (((int) num2) - 0x65f6bf12) ^ 0x7e493d1a;
                        goto Label_0017;

                    case 3:
                        goto Label_000C;

                    default:
                        return;
                }
                expressionStack_15E_1 = -864808358;
            Label_015E:
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -2076310829;
                expressionStack_17_0 = expressionStack_15E_1 ^ ((int) (num2 * 0x40b8475));
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
            uint num = 0xa284dfe7;
            ComponentResourceManager manager = (ComponentResourceManager) bä(>+Zí(typeof(Shit.InjectForm).TypeHandle));
            this.SaveFileDialog1 = (SaveFileDialog) ,();
            this.OpenFileDialog1 = (OpenFileDialog) a@ ^();
        Label_0040:
            num4 = -2097111607;
        Label_004C:;
            int num5 = 0x5ed53cc7;
            switch ((((-((~num5 ^ 0x391837c7) * 0x3eb24f53) - 0x55917e1c) + num4) >> 0x10))
            {
                case 0:
                    goto Label_0441;

                case 1:
                    this.DllName = (ListBox) æð	Ôr();
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x31];
                    goto Label_004C;

                case 2:
                    goto Label_0372;

                case 3:
                    goto Label_0111;

                case 4:
                    goto Label_0323;

                case 5:
                    goto Label_03C4;

                case 6:
                    goto Label_0212;

                case 7:
                    goto Label_0406;

                case 8:
                    goto Label_0040;

                case 9:
                    goto Label_02A8;

                case 10:
                    goto Label_017A;

                case 12:
                    goto Label_01CA;

                case 13:
                    goto Label_0264;
            }
            goto Label_047D;
            =µ§­(this);
            *?("OpenFileDialog1");
            *?(1);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[50];
            goto Label_004C;
            *?(new Point(0x15, 12));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x33];
            goto Label_004C;
            *?("DllName");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x34];
            goto Label_004C;
            *?(new Size(0xe5, 0xd4));
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x35];
            goto Label_004C;
            *?(0);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x36];
            goto Label_004C;
            *?(new SizeF(6f, 13f));
            *?(1);
            *?(new Size(0x11b, 0xed));
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_004C;
            yã\B(*?(), this.DllName);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x37];
            goto Label_004C;
            *?((Icon) ]l¶+(manager, "$this.Icon"));
            num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_004C;
            *?("InjectForm");
            num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
            goto Label_004C;
            this.Text = "Injection..";
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x38];
            goto Label_004C;
            ©`Vñ(this, false);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x39];
            goto Label_004C;
        }

        private void InjectForm_Load(object sender, EventArgs e)
        {
        }

        internal virtual SaveFileDialog SaveFileDialog1
        {
            [CompilerGenerated]
            get => 
                this._SaveFileDialog1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._SaveFileDialog1 = value);
        }

        internal virtual OpenFileDialog OpenFileDialog1
        {
            [CompilerGenerated]
            get => 
                this._OpenFileDialog1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._OpenFileDialog1 = value);
        }

        internal virtual ListBox DllName
        {
            [CompilerGenerated]
            get => 
                this._DllName;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this._DllName = value);
        }
    }
}

