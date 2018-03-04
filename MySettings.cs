namespace Shit.My
{
    using Microsoft.VisualBasic.ApplicationServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [CompilerGenerated, GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced)]
    internal sealed class MySettings : ApplicationSettingsBase
    {
        private static Shit.My.MySettings defaultInstance = ((Shit.My.MySettings) *CONSOLESCREENBUFFERINFO[0x17](new Shit.My.MySettings()));
        private static bool addedHandler;
        private static object addedHandlerLockObject = *CONSOLESCREENBUFFERINFO[0x16](new object());

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Advanced)]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x8b341453;
            if (*?() == null)
            {
                goto Label_00A4;
            }
        Label_001E:
            num4 = -136831659;
        Label_0029:;
            int num5 = -1411180848;
            switch ((((~num5 * 0x39c4d7b3) + num4) % 3))
            {
                case 0:
                    goto Label_001E;

                case 1:
                    Shit.My.MySettingsProperty.Settings.Save();
                    num4 = (int) (num ^ InternalSerializerTypeE.RemotingConfiguration);
                    goto Label_0029;
            }
            goto Label_00A4;
        }

        public static Shit.My.MySettings Default
        {
            get
            {
                // This item is obfuscated and can not be translated.
                object addedHandlerLockObject;
                uint num2;
                int num4;
                uint num = 0x34b4a367;
                if (addedHandler)
                {
                    goto Label_02C4;
                }
            Label_0010:
                num4 = 0x61c12d14;
            Label_001C:;
                int num5 = -413739883;
                int num3 = 0x4d2;
                switch (((num2 = (uint) ((((0x32bcaef1 + -548619609) - (-1179251273 * 0x578573f3)) - ~(num5 - (-583691651 - --~0x3cff70d))) + num4)) % 4))
                {
                    case 0:
                        goto Label_0010;

                    case 1:
                        goto Label_00C3;

                    case 2:
                        addedHandlerLockObject = Shit.My.MySettings.addedHandlerLockObject;
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[3];
                        goto Label_001C;

                    case 3:
                        goto Label_0102;

                    default:
                    {
                        goto Label_0102;
                        *CONSOLESCREENBUFFERINFO[0x19](addedHandlerLockObject);
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[4];
                        goto Label_001C;
                        bool flag = false;
                        try
                        {
                            num = 0x34b4a367;
                            *CONSOLESCREENBUFFERINFO[0x1a](addedHandlerLockObject, &flag);
                            if (addedHandler)
                            {
                                goto Label_01F6;
                            }
                        Label_0125:
                            num4 = 0x797054a;
                        Label_0131:;
                            num5 = 0x513948c6;
                            num3 = 0x4d2;
                            switch (((num2 = (uint) ((((0x32bcaef1 + -548619609) - (-1179251273 * 0x578573f3)) - ~(num5 - (-583691651 - --~0x3cff70d))) + num4)) % 3))
                            {
                                case 0:
                                    goto Label_0125;

                                case 1:
                                    *?(new ShutdownEventHandler(Shit.My.MySettings.AutoSaveSettings));
                                    addedHandler = true;
                                    num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                                    goto Label_0131;
                            }
                            goto Label_01F6;
                        }
                        finally
                        {
                            num = 0x34b4a367;
                            if (!flag)
                            {
                                goto Label_02C3;
                            }
                        Label_0207:
                            num4 = 0x6c19a19;
                        Label_0213:;
                            num5 = 0x2946bf8e;
                            num3 = 0x4d2;
                            switch (((num2 = (uint) ((((0x32bcaef1 + -548619609) - (-1179251273 * 0x578573f3)) - ~(num5 - (-583691651 - --~0x3cff70d))) + num4)) >> 0x10))
                            {
                                case 0:
                                    goto Label_0207;

                                case 1:
                                    *CONSOLESCREENBUFFERINFO[0x1c](addedHandlerLockObject);
                                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[5];
                                    goto Label_0213;
                            }
                            goto Label_02C3;
                        }
                        break;
                    }
                }
            Label_02C4:
                return defaultInstance;
            }
        }
    }
}

