namespace Shit
{
    using Shit.My;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal class PrecisionTimer : IDisposable
    {
        private bool _Enabled;
        private IntPtr Handle;
        private TimerDelegate TimerCallback;

        public void Create(uint dueTime, uint period, TimerDelegate callback)
        {
            // This item is obfuscated and can not be translated.
            bool flag;
            int num4;
            uint num = 0xfc4b96e8;
            if (this._Enabled)
            {
                goto Label_02B8;
            }
        Label_0011:
            num4 = 0x377dd891;
        Label_001D:;
            int num5 = 0x1b1c0dc3;
            int num3 = 0x4d2;
            switch (((~(-((num5 ^ -(((0x568e73fb * -1418300433) ^ (0x57a142ef - 0x7758123)) + ((-1551506991 * 0x431f325b) - (0x3313a47 * -1856886993)))) - (((0x7431e736 * 0x7c4ebd2f) ^ --19756655) ^ ((-49341186 ^ 0x78c8532e) - (-653398588 ^ -1866043985)))) + (0x1e39c339 ^ -652026163)) + num4) % 6))
            {
                case 0:
                    goto Label_0134;

                case 1:
                    goto Label_0285;

                case 2:
                    goto Label_0011;

                case 4:
                    this.TimerCallback = callback;
                    flag = F)¨(ref this.Handle, IntPtr.Zero, this.TimerCallback, IntPtr.Zero, dueTime, period, 0);
                    num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                    goto Label_001D;

                case 5:
                    goto Label_0243;
            }
            goto Label_02B8;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = 0x5473ab77;
            goto Label_001D;
            nc	´(this, "CreateTimerQueueTimer");
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_001D;
            this._Enabled = flag;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x149];
            goto Label_001D;
        }

        [DllImport("kernel32.dll")]
        private static extern bool CreateTimerQueueTimer(ref IntPtr handle, IntPtr queue, TimerDelegate callback, IntPtr state, uint dueTime, uint period, uint flags);
        public void Delete()
        {
            // This item is obfuscated and can not be translated.
            bool flag;
            int num4;
            uint num = 0x945de24b;
            if (!this._Enabled)
            {
                goto Label_0397;
            }
        Label_0011:
            num4 = -1174795222;
        Label_001D:;
            int num5 = -692702291;
            int num3 = 0x4d2;
            switch ((((-(((0x702feac1 - -1360763906) + (0x1278679a ^ -1466849150)) - (0x64dfa6f3 - ((((-0x67c6d8dc + (0x44a2fe37 + -1834241707)) - 0x4b173a43) - ((--514098908 + (-676047987 * 0x49dcfd11)) - (--1682261223 + (-1045702610 - -1646207309)))) - num5))) ^ -80026119) + num4) >> 0x10))
            {
                case 0:
                    goto Label_031F;

                case 1:
                    flag = OÕN(IntPtr.Zero, this.Handle, IntPtr.Zero);
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num3 = 0x4d2;
                    num4 = -1746692512;
                    goto Label_001D;

                case 2:
                    goto Label_0011;

                case 4:
                    goto Label_0202;

                case 5:
                    goto Label_0365;
            }
            goto Label_0397;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num3 = 0x4d2;
            num4 = -1240722777;
            goto Label_001D;
            nc	´(this, "DeleteTimerQueueTimer");
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[330];
            goto Label_001D;
            this._Enabled = !flag;
            num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
            goto Label_001D;
        }

        [DllImport("kernel32.dll")]
        private static extern bool DeleteTimerQueueTimer(IntPtr queue, IntPtr handle, IntPtr callback);
        public void Dispose()
        {
            <åh(this);
        }

        private void ThrowNewException(string name)
        {
            throw gä´áo(£{ôÐ¤("{0} failed. Win32Error: {1}", name, qÇ[ ()));
        }

        public bool Enabled =>
            this._Enabled;

        public delegate void TimerDelegate(IntPtr r1, bool r2);
    }
}

