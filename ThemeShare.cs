namespace Shit
{
    using Microsoft.VisualBasic.CompilerServices;
    using Shit.My;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [StandardModule]
    internal sealed class ThemeShare
    {
        private static int Frames;
        private static bool Invalidate;
        public static Shit.PrecisionTimer ThemeTimer = ((Shit.PrecisionTimer) uÜºß·());
        private const int FPS = 50;
        private const int Rate = 10;
        private static List<AnimationDelegate> Callbacks = new List<AnimationDelegate>();

        public static void AddAnimationCallback(AnimationDelegate callback)
        {
            // This item is obfuscated and can not be translated.
            uint num;
            uint num2;
            int num3;
            int num4;
            int num5;
            object callbacks = Callbacks;
            bool flag = false;
            try
            {
                num = 0xa564a6c7;
                ×Fi(callbacks, ref flag);
            Label_001B:
                num4 = 0x28676d64;
            Label_0027:;
                num5 = 0x2ebd3d56;
                num3 = 0x4d2;
                switch (((num2 = (uint) (-(~(-num5 * -2129098183) - (0x47da838d + 0x11041334)) + num4)) >> 0x10))
                {
                    case 0:
                        goto Label_01BD;

                    case 1:
                        Callbacks.Add(callback);
                        num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                        goto Label_0027;

                    case 2:
                        goto Label_001B;

                    case 3:
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num3 = 0x4d2;
                        num4 = -909134744;
                        goto Label_0027;
                }
                goto Label_0229;
                CÛÄk();
            }
            finally
            {
                num = 0xa564a6c7;
                if (!flag)
                {
                    goto Label_02EA;
                }
            Label_0244:
                num4 = 0x1eec634;
            Label_0250:;
                num5 = -1847616346;
                num3 = 0x4d2;
                switch (((num2 = (uint) (-(~(-num5 * -2129098183) - (0x47da838d + 0x11041334)) + num4)) >> 0x10))
                {
                    case 0:
                        goto Label_0244;

                    case 2:
                        »úm(callbacks);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x146];
                        goto Label_0250;
                }
                goto Label_02EA;
            }
        }

        private static void HandleCallbacks(IntPtr state, bool reserve)
        {
            // This item is obfuscated and can not be translated.
            uint num4;
            int num6;
            uint num3 = 0xbfe13499;
            Invalidate = Frames >= 50;
        Label_0018:
            num6 = -1111405200;
        Label_0024:;
            int num7 = -1665094286;
            int num5 = 0x4d2;
            switch (((num4 = (uint) (((-((num7 - (~-125334468 ^ (((0x76a91b1d * 0x4252da3c) ^ ~0x225d350e) + ((-1500769663 - 0xb78c444) * 0x6af69fdd)))) - ~(~-989816125 ^ (-773635856 * 0x62529ecf))) * 0x3f2487f5) - -937604422) + num6)) % 5))
            {
                case 1:
                    num5 = 0x4d2;
                    num5 = 0x4d2;
                    num5 = 0x4d2;
                    num5 = 0x4d2;
                    num6 = -629453768;
                    goto Label_0024;

                case 2:
                    goto Label_01EC;

                case 3:
                    goto Label_0018;

                case 4:
                    goto Label_0223;
            }
            goto Label_0253;
            Frames = 0;
            num6 = (int) (num3 ^ InternalSerializerTypeE.SoapOption);
            goto Label_0024;
            object callbacks = Callbacks;
            num6 = (int) (num3 ^ InternalSerializerTypeE.IContextPropertyActivator);
            goto Label_0024;
            bool flag = false;
            try
            {
                num3 = 0xbfe13499;
                ×Fi(callbacks, ref flag);
            Label_0269:
                num6 = -1053827451;
            Label_0275:;
                num7 = -2040164937;
                num5 = 0x4d2;
                switch (((num4 = (uint) (((-((num7 - (~-125334468 ^ (((0x76a91b1d * 0x4252da3c) ^ ~0x225d350e) + ((-1500769663 - 0xb78c444) * 0x6af69fdd)))) - ~(~-989816125 ^ (-773635856 * 0x62529ecf))) * 0x3f2487f5) - -937604422) + num6)) >> 0x10))
                {
                    case 0:
                        goto Label_03B7;

                    case 2:
                        goto Label_042B;

                    case 3:
                        goto Label_0269;

                    case 4:
                        goto Label_034A;

                    case 5:
                        goto Label_038B;

                    case 6:
                        goto Label_03F6;
                }
                goto Label_0520;
                int num = Callbacks.Count - 1;
                num6 = (int) Shit.My.MyApplication.StringSplitOptions[320];
                goto Label_0275;
                int num2 = 0;
                num6 = -1101768259;
                goto Label_0275;
                Callbacks[num2](Invalidate);
                num6 = (int) (num3 ^ InternalSerializerTypeE.SoapOption);
                goto Label_0275;
                num2++;
                num6 = (int) (num3 ^ InternalSerializerTypeE.FormatterConverter);
                goto Label_0275;
                num5 = 0x4d2;
                num5 = 0x4d2;
                num6 = -1204351339;
                goto Label_0275;
            }
            finally
            {
                num3 = 0xbfe13499;
                if (!flag)
                {
                    goto Label_060F;
                }
            Label_0532:
                num6 = -1692799975;
            Label_053E:;
                num7 = -1588728709;
                num5 = 0x4d2;
                switch (((num4 = (uint) (((-((num7 - (~-125334468 ^ (((0x76a91b1d * 0x4252da3c) ^ ~0x225d350e) + ((-1500769663 - 0xb78c444) * 0x6af69fdd)))) - ~(~-989816125 ^ (-773635856 * 0x62529ecf))) * 0x3f2487f5) - -937604422) + num6)) >> 0x10))
                {
                    case 0:
                        goto Label_0532;

                    case 2:
                        »úm(callbacks);
                        num6 = (int) (num3 ^ InternalSerializerTypeE.RemotingConfiguration);
                        goto Label_053E;
                }
                goto Label_060F;
            }
            Frames += 10;
        }

        private static void InvalidateThemeTimer()
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x1ead7a73;
            if (Callbacks.Count != 0)
            {
                goto Label_0106;
            }
        Label_0015:
            num4 = 0x22e952fb;
        Label_0020:;
            int num5 = 0x3fc39205;
            switch ((((--((num5 ^ (-0x63a4fb77 ^ -((-315956455 * -1104428353) + 0x608a2cd5))) * 0x3e2e28cb) - -1624151579) + num4) % 5))
            {
                case 0:
                    goto Label_00D4;

                case 2:
                    goto Label_0015;

                case 3:
                    goto Label_0106;

                case 4:
                    àÀ]&Y(ThemeTimer);
                    num4 = (int) (num ^ InternalSerializerTypeE.IContextPropertyActivator);
                    goto Label_0020;
            }
            goto Label_014A;
            ôH(ThemeTimer, 0, 10, new Shit.PrecisionTimer.TimerDelegate(Shit.ThemeShare.HandleCallbacks));
            num4 = (int) (num ^ InternalSerializerTypeE.XmlToFieldTypeMap);
            goto Label_0020;
        }

        public static void RemoveAnimationCallback(AnimationDelegate callback)
        {
            // This item is obfuscated and can not be translated.
            uint num;
            uint num2;
            int num3;
            int num4;
            int num5;
            object callbacks = Callbacks;
            bool flag = false;
            try
            {
                num = 0x1bb4612a;
                ×Fi(callbacks, ref flag);
                if (Callbacks.Contains(callback))
                {
                    goto Label_00CA;
                }
            Label_002B:
                num4 = 0x67ceaf47;
            Label_0037:;
                num5 = 0x479b2978;
                num3 = 0x4d2;
                switch (((num2 = (uint) ((-((~num5 * 0x3250f71) * 0x2895b6e3) ^ 0x4ef5c2a2) + num4)) >> 0x10))
                {
                    case 0:
                        break;

                    case 1:
                        return;

                    case 2:
                        goto Label_002B;

                    default:
                        goto Label_00FE;
                }
            Label_00CA:
                Callbacks.Remove(callback);
                num4 = (int) (num ^ InternalSerializerTypeE.StaticArrayInitTypeSize=392);
                goto Label_0037;
                CÛÄk();
            }
            finally
            {
                num = 0x1bb4612a;
                if (!flag)
                {
                    goto Label_01B8;
                }
            Label_0119:
                num4 = -710576372;
            Label_0125:;
                num5 = 0x74766920;
                num3 = 0x4d2;
                switch (((num2 = (uint) ((-((~num5 * 0x3250f71) * 0x2895b6e3) ^ 0x4ef5c2a2) + num4)) % 3))
                {
                    case 0:
                        goto Label_0119;

                    case 2:
                        »úm(callbacks);
                        num4 = (int) (num ^ InternalSerializerTypeE.FormatterConverter);
                        goto Label_0125;
                }
                goto Label_01B8;
            }
        }

        public delegate void AnimationDelegate(bool invalidate);
    }
}

