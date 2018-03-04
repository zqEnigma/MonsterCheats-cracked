namespace Shit
{
    using SerializationObjectManager;
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct Bloom
    {
        public string _Name;
        private System.Drawing.Color _Value;
        public string Name =>
            this._Name;
        public System.Drawing.Color Value
        {
            get => 
                this._Value;
            set => 
                (this._Value = value);
        }
        public string ValueHex
        {
            get => 
                îò¾a("#", ((byte) *?()).ToString("X2", null), ((byte) *?()).ToString("X2", null), ((byte) *?()).ToString("X2", null));
            set
            {
                try
                {
                    this._Value = 7@LÓd(value);
                }
                catch (Exception exception1)
                {
                    SerializationObjectManager.Object.StackFrameHelper(exception1);
                    ¯3U();
                }
            }
        }
        public Bloom(string name, System.Drawing.Color value)
        {
            this = new Shit.Bloom();
            this._Name = name;
            this._Value = value;
        }
    }
}

