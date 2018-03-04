namespace Shit
{
    using Shit.My;
    using System;
    using System.Net;
    using System.Runtime.InteropServices;

    public abstract class Forum
    {
        private string _logindata;
        private string _loginUrl;
        private string _url;
        private string _username;
        private string _defaultCookieName;
        private string _defaultCookieSearch;

        public Forum(string url, string loginUrl, string username, string cookieName, string cookieSearch, string data = "")
        {
            // This item is obfuscated and can not be translated.
            int num4;
            uint num = 0x53e96801;
        Label_000C:
            num4 = 0x3685998d;
        Label_0017:;
            int num5 = -1339084297;
            switch ((((((~(num5 + ~~~--1346315314) * 0x61dd2625) * -1415891781) * 0x4e40504f) + num4) >> 0x10))
            {
                case 1:
                    goto Label_0147;

                case 2:
                    this._url = url;
                    *?(loginUrl);
                    num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x4c];
                    goto Label_0017;

                case 3:
                    goto Label_0109;

                case 4:
                    goto Label_00CB;

                case 5:
                    goto Label_000C;
            }
            goto Label_0185;
            *?(data);
            num4 = (int) (num ^ InternalSerializerTypeE.SoapOption);
            goto Label_0017;
            *?(username);
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x4d];
            goto Label_0017;
            this._defaultCookieName = cookieName;
            this._defaultCookieSearch = cookieSearch;
            num4 = (int) Shit.My.MyApplication.StringSplitOptions[0x4e];
            goto Label_0017;
        }

        public abstract bool isLoggedIn(CookieContainer cookies);

        public string logindata
        {
            get => 
                this._logindata;
            set => 
                (this._logindata = value);
        }

        public string url
        {
            get => 
                this._url;
            set => 
                (this._url = value);
        }

        public string loginUrl
        {
            get => 
                this._loginUrl;
            set => 
                (this._loginUrl = value);
        }

        public string username
        {
            get => 
                this._username;
            set => 
                (this._username = value);
        }

        public string defaultCookieName
        {
            get => 
                this._defaultCookieName;
            set => 
                (this._defaultCookieName = value);
        }

        public string defaultCookieSearch
        {
            get => 
                this._defaultCookieSearch;
            set => 
                (this._defaultCookieSearch = value);
        }
    }
}

