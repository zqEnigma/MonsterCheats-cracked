namespace Shit.My
{
    using Microsoft.VisualBasic.ApplicationServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [EditorBrowsable(EditorBrowsableState.Never), GeneratedCode("MyTemplate", "11.0.0.0")]
    internal class MyApplication : WindowsFormsApplicationBase
    {
        public static uint[] StringSplitOptions;

        [DebuggerStepThrough]
        public MyApplication() : base(AuthenticationMode.Windows)
        {
            *?(0);
            *?(1);
            *?(1);
            *?(0);
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining), DebuggerHidden, EditorBrowsable(EditorBrowsableState.Advanced), STAThread]
        internal static void Main(string[] Args)
        {
            // This item is obfuscated and can not be translated.
            int num4;
        Label_0007:
            num4 = 0x6c37d369;
        Label_0012:;
            int num5 = -2133525003;
            switch (((-((-1058148718 + 0x7186d8b3) - (((num5 ^ ((~(0x18c62c17 * 0x2192cd61) + ((-1158609529 * 0x1109cae1) - (0x6ac4f1ff - 0x47463bb0))) + ((0x17b3ee96 - (-275580694 + 0x4c014452)) + -~-1406599499))) - (0x4df5ac9 * 0x4b9de802)) + ((-100754499 ^ -298655188) - --1405611537))) + num4) % 4))
            {
                case 0:
                    goto Label_0007;

                case 1:
                    goto Label_010D;

                case 3:
                    *CONSOLESCREENBUFFERINFO[10](*CONSOLESCREENBUFFERINFO[9]());
                    num4 = (int) StringSplitOptions[0];
                    goto Label_0012;
            }
            goto Label_014E;
            *?(Args);
            num4 = (int) StringSplitOptions[1];
            goto Label_0012;
        }

        [DebuggerStepThrough]
        protected override void OnCreateMainForm()
        {
            *?(Shit.My.MyProject.Forms.Login);
        }

        [DebuggerStepThrough]
        protected override void OnCreateSplashScreen()
        {
            *?(Shit.My.MyProject.Forms.Splash);
        }
    }
}

