namespace Shit
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;

    [Obfuscation(Exclude=true)]
    internal abstract class ThemeContainer154 : ContainerControl
    {
        protected Graphics G;
        protected Bitmap B;
        private bool DoneCreation;
        private bool HasShown;
        private Rectangle Frame;
        protected Shit.MouseState State;
        private bool WM_LMBUTTONDOWN;
        private Point GetIndexPoint;
        private bool B1;
        private bool B2;
        private bool B3;
        private bool B4;
        private int Current;
        private int Previous;
        private Message[] Messages = new Message[9];
        private bool _BackColor;
        private bool _SmartBounds = true;
        private bool _Movable = true;
        private bool _Sizable = true;
        private Color _TransparencyKey;
        private FormBorderStyle _BorderStyle;
        private FormStartPosition _StartPosition;
        private bool _NoRounding;
        private System.Drawing.Image _Image;
        private Dictionary<string, Color> Items = new Dictionary<string, Color>();
        private string _Customization;
        private bool _Transparent;
        private Size _ImageSize;
        private bool _IsParentForm;
        private int _LockWidth;
        private int _LockHeight;
        private int _Header = 0x18;
        private bool _ControlMode;
        private bool _IsAnimated;
        private Rectangle OffsetReturnRectangle;
        private Size OffsetReturnSize;
        private Point OffsetReturnPoint;
        private Point CenterReturn;
        private Bitmap MeasureBitmap;
        private Graphics MeasureGraphics;
        private SolidBrush DrawPixelBrush;
        private SolidBrush DrawCornersBrush;
        private Point DrawTextPoint;
        private Size DrawTextSize;
        private Point DrawImagePoint;
        private LinearGradientBrush DrawGradientBrush;
        private Rectangle DrawGradientRectangle;
        private GraphicsPath DrawRadialPath;
        private PathGradientBrush DrawRadialBrush1;
        private LinearGradientBrush DrawRadialBrush2;
        private Rectangle DrawRadialRectangle;
        private GraphicsPath CreateRoundPath;
        private Rectangle CreateRoundRectangle;

        [Obfuscation(Exclude=true)]
        public ThemeContainer154()
        {
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque | ControlStyles.UserPaint, true);
            this._ImageSize = Size.Empty;
            this.Font = new System.Drawing.Font("Arial", 9f);
            this.MeasureBitmap = new Bitmap(1, 1);
            this.MeasureGraphics = Graphics.FromImage(this.MeasureBitmap);
            this.DrawRadialPath = new GraphicsPath();
            this.InvalidateCustimization();
        }

        [Obfuscation(Exclude=true)]
        protected Point Center(Rectangle child) => 
            this.Center(base.Width, base.Height, child.Width, child.Height);

        [Obfuscation(Exclude=true)]
        protected Point Center(Size child) => 
            this.Center(base.Width, base.Height, child.Width, child.Height);

        [Obfuscation(Exclude=true)]
        protected Point Center(Rectangle p, Rectangle c)
        {
            this.CenterReturn = new Point((((p.Width / 2) - (c.Width / 2)) + p.X) + c.X, (((p.Height / 2) - (c.Height / 2)) + p.Y) + c.Y);
            return this.CenterReturn;
        }

        [Obfuscation(Exclude=true)]
        protected Point Center(Rectangle p, Size c)
        {
            this.CenterReturn = new Point(((p.Width / 2) - (c.Width / 2)) + p.X, ((p.Height / 2) - (c.Height / 2)) + p.Y);
            return this.CenterReturn;
        }

        [Obfuscation(Exclude=true)]
        protected Point Center(Size p, Size c) => 
            this.Center(p.Width, p.Height, c.Width, c.Height);

        [Obfuscation(Exclude=true)]
        protected Point Center(int childWidth, int childHeight) => 
            this.Center(base.Width, base.Height, childWidth, childHeight);

        [Obfuscation(Exclude=true)]
        protected Point Center(int pWidth, int pHeight, int cWidth, int cHeight)
        {
            this.CenterReturn = new Point((pWidth / 2) - (cWidth / 2), (pHeight / 2) - (cHeight / 2));
            return this.CenterReturn;
        }

        [Obfuscation(Exclude=true)]
        protected abstract void ColorHook();
        [Obfuscation(Exclude=true)]
        private void CorrectBounds(Rectangle bounds)
        {
            if (base.Parent.Width > bounds.Width)
            {
                base.Parent.Width = bounds.Width;
            }
            if (base.Parent.Height > bounds.Height)
            {
                base.Parent.Height = bounds.Height;
            }
            int x = base.Parent.Location.X;
            int y = base.Parent.Location.Y;
            if (x < bounds.X)
            {
                x = bounds.X;
            }
            if (y < bounds.Y)
            {
                y = bounds.Y;
            }
            int num3 = bounds.X + bounds.Width;
            int num4 = bounds.Y + bounds.Height;
            if ((x + base.Parent.Width) > num3)
            {
                x = num3 - base.Parent.Width;
            }
            if ((y + base.Parent.Height) > num4)
            {
                y = num4 - base.Parent.Height;
            }
            base.Parent.Location = new Point(x, y);
        }

        [Obfuscation(Exclude=true)]
        public GraphicsPath CreateRound(Rectangle r, int slope)
        {
            this.CreateRoundPath = new GraphicsPath(FillMode.Winding);
            this.CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180f, 90f);
            this.CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270f, 90f);
            this.CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0f, 90f);
            this.CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90f, 90f);
            this.CreateRoundPath.CloseFigure();
            return this.CreateRoundPath;
        }

        [Obfuscation(Exclude=true)]
        public GraphicsPath CreateRound(int x, int y, int width, int height, int slope)
        {
            this.CreateRoundRectangle = new Rectangle(x, y, width, height);
            return this.CreateRound(this.CreateRoundRectangle, slope);
        }

        [Obfuscation(Exclude=true)]
        private void DoAnimation(bool i)
        {
            this.OnAnimation();
            if (i)
            {
                base.Invalidate();
            }
        }

        [Obfuscation(Exclude=true)]
        protected void DrawBorders(Pen p1)
        {
            this.DrawBorders(p1, 0, 0, base.Width, base.Height);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawBorders(Pen p1, Rectangle r)
        {
            this.DrawBorders(p1, r.X, r.Y, r.Width, r.Height);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawBorders(Pen p1, int offset)
        {
            this.DrawBorders(p1, 0, 0, base.Width, base.Height, offset);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawBorders(Pen p1, Rectangle r, int offset)
        {
            this.DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawBorders(Pen p1, int x, int y, int width, int height)
        {
            this.G.DrawRectangle(p1, x, y, width - 1, height - 1);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawBorders(Pen p1, int x, int y, int width, int height, int offset)
        {
            this.DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        [Obfuscation(Exclude=true)]
        protected void DrawCorners(Color c1)
        {
            this.DrawCorners(c1, 0, 0, base.Width, base.Height);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawCorners(Color c1, Rectangle r1)
        {
            this.DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawCorners(Color c1, int offset)
        {
            this.DrawCorners(c1, 0, 0, base.Width, base.Height, offset);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawCorners(Color c1, Rectangle r1, int offset)
        {
            this.DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawCorners(Color c1, int x, int y, int width, int height)
        {
            if (!this._NoRounding)
            {
                if (this._Transparent)
                {
                    this.B.SetPixel(x, y, c1);
                    this.B.SetPixel(x + (width - 1), y, c1);
                    this.B.SetPixel(x, y + (height - 1), c1);
                    this.B.SetPixel(x + (width - 1), y + (height - 1), c1);
                }
                else
                {
                    this.DrawCornersBrush = new SolidBrush(c1);
                    this.G.FillRectangle(this.DrawCornersBrush, x, y, 1, 1);
                    this.G.FillRectangle(this.DrawCornersBrush, x + (width - 1), y, 1, 1);
                    this.G.FillRectangle(this.DrawCornersBrush, x, y + (height - 1), 1, 1);
                    this.G.FillRectangle(this.DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1);
                }
            }
        }

        [Obfuscation(Exclude=true)]
        protected void DrawCorners(Color c1, int x, int y, int width, int height, int offset)
        {
            this.DrawCorners(c1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        [Obfuscation(Exclude=true)]
        protected void DrawGradient(ColorBlend blend, Rectangle r)
        {
            this.DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, 90f);
            this.DrawGradientBrush.InterpolationColors = blend;
            this.G.FillRectangle(this.DrawGradientBrush, r);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawGradient(Color c1, Color c2, Rectangle r)
        {
            this.DrawGradientBrush = new LinearGradientBrush(r, c1, c2, 90f);
            this.G.FillRectangle(this.DrawGradientBrush, r);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawGradient(ColorBlend blend, Rectangle r, float angle)
        {
            this.DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, angle);
            this.DrawGradientBrush.InterpolationColors = blend;
            this.G.FillRectangle(this.DrawGradientBrush, r);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawGradient(Color c1, Color c2, Rectangle r, float angle)
        {
            this.DrawGradientBrush = new LinearGradientBrush(r, c1, c2, angle);
            this.G.FillRectangle(this.DrawGradientBrush, r);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height)
        {
            this.DrawGradientRectangle = new Rectangle(x, y, width, height);
            this.DrawGradient(blend, this.DrawGradientRectangle);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height)
        {
            this.DrawGradientRectangle = new Rectangle(x, y, width, height);
            this.DrawGradient(c1, c2, this.DrawGradientRectangle);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height, float angle)
        {
            this.DrawGradientRectangle = new Rectangle(x, y, width, height);
            this.DrawGradient(blend, this.DrawGradientRectangle, angle);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height, float angle)
        {
            this.DrawGradientRectangle = new Rectangle(x, y, width, height);
            this.DrawGradient(c1, c2, this.DrawGradientRectangle, angle);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawImage(Point p1)
        {
            this.DrawImage(this._Image, p1.X, p1.Y);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawImage(System.Drawing.Image image, Point p1)
        {
            this.DrawImage(image, p1.X, p1.Y);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawImage(int x, int y)
        {
            this.DrawImage(this._Image, x, y);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawImage(System.Drawing.Image image, int x, int y)
        {
            if (image != null)
            {
                this.G.DrawImage(image, x, y, image.Width, image.Height);
            }
        }

        [Obfuscation(Exclude=true)]
        protected void DrawImage(HorizontalAlignment a, int x, int y)
        {
            this.DrawImage(this._Image, a, x, y);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawImage(System.Drawing.Image image, HorizontalAlignment a, int x, int y)
        {
            if (image != null)
            {
                this.DrawImagePoint = new Point((base.Width / 2) - (image.Width / 2), (this.Header / 2) - (image.Height / 2));
                switch (a)
                {
                    case HorizontalAlignment.Left:
                        this.G.DrawImage(image, x, this.DrawImagePoint.Y + y, image.Width, image.Height);
                        return;

                    case HorizontalAlignment.Right:
                        this.G.DrawImage(image, (base.Width - image.Width) - x, this.DrawImagePoint.Y + y, image.Width, image.Height);
                        break;

                    case HorizontalAlignment.Center:
                        this.G.DrawImage(image, this.DrawImagePoint.X + x, this.DrawImagePoint.Y + y, image.Width, image.Height);
                        return;

                    default:
                        return;
                }
            }
        }

        [Obfuscation(Exclude=true)]
        protected void DrawPixel(Color c1, int x, int y)
        {
            if (this._Transparent)
            {
                this.B.SetPixel(x, y, c1);
            }
            else
            {
                this.DrawPixelBrush = new SolidBrush(c1);
                this.G.FillRectangle(this.DrawPixelBrush, x, y, 1, 1);
            }
        }

        [Obfuscation(Exclude=true)]
        public void DrawRadial(ColorBlend blend, Rectangle r)
        {
            this.DrawRadial(blend, r, r.Width / 2, r.Height / 2);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawRadial(Color c1, Color c2, Rectangle r)
        {
            this.DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, 90f);
            this.G.FillRectangle(this.DrawGradientBrush, r);
        }

        [Obfuscation(Exclude=true)]
        public void DrawRadial(ColorBlend blend, Rectangle r, Point center)
        {
            this.DrawRadial(blend, r, center.X, center.Y);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawRadial(Color c1, Color c2, Rectangle r, float angle)
        {
            this.DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, angle);
            this.G.FillEllipse(this.DrawGradientBrush, r);
        }

        [Obfuscation(Exclude=true)]
        public void DrawRadial(ColorBlend blend, Rectangle r, int cx, int cy)
        {
            this.DrawRadialPath.Reset();
            this.DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1);
            this.DrawRadialBrush1 = new PathGradientBrush(this.DrawRadialPath);
            this.DrawRadialBrush1.CenterPoint = (PointF) new Point(r.X + cx, r.Y + cy);
            this.DrawRadialBrush1.InterpolationColors = blend;
            if (this.G.SmoothingMode == SmoothingMode.AntiAlias)
            {
                this.G.FillEllipse(this.DrawRadialBrush1, (int) (r.X + 1), (int) (r.Y + 1), (int) (r.Width - 3), (int) (r.Height - 3));
            }
            else
            {
                this.G.FillEllipse(this.DrawRadialBrush1, r);
            }
        }

        [Obfuscation(Exclude=true)]
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height)
        {
            this.DrawRadialRectangle = new Rectangle(x, y, width, height);
            this.DrawRadial(blend, this.DrawRadialRectangle, width / 2, height / 2);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height)
        {
            this.DrawRadialRectangle = new Rectangle(x, y, width, height);
            this.DrawRadial(c1, c2, this.DrawGradientRectangle);
        }

        [Obfuscation(Exclude=true)]
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, Point center)
        {
            this.DrawRadialRectangle = new Rectangle(x, y, width, height);
            this.DrawRadial(blend, this.DrawRadialRectangle, center.X, center.Y);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height, float angle)
        {
            this.DrawRadialRectangle = new Rectangle(x, y, width, height);
            this.DrawRadial(c1, c2, this.DrawGradientRectangle, angle);
        }

        [Obfuscation(Exclude=true)]
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, int cx, int cy)
        {
            this.DrawRadialRectangle = new Rectangle(x, y, width, height);
            this.DrawRadial(blend, this.DrawRadialRectangle, cx, cy);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawText(Brush b1, Point p1)
        {
            if (this.Text.Length != 0)
            {
                this.G.DrawString(this.Text, this.Font, b1, (PointF) p1);
            }
        }

        [Obfuscation(Exclude=true)]
        protected void DrawText(Brush b1, int x, int y)
        {
            if (this.Text.Length != 0)
            {
                this.G.DrawString(this.Text, this.Font, b1, (float) x, (float) y);
            }
        }

        [Obfuscation(Exclude=true)]
        protected void DrawText(Brush b1, HorizontalAlignment a, int x, int y)
        {
            this.DrawText(b1, this.Text, a, x, y);
        }

        [Obfuscation(Exclude=true)]
        protected void DrawText(Brush b1, string text, HorizontalAlignment a, int x, int y)
        {
            if (text.Length != 0)
            {
                this.DrawTextSize = this.Measure(text);
                this.DrawTextPoint = new Point((base.Width / 2) - (this.DrawTextSize.Width / 2), (this.Header / 2) - (this.DrawTextSize.Height / 2));
                switch (a)
                {
                    case HorizontalAlignment.Left:
                        this.G.DrawString(text, this.Font, b1, (float) x, (float) (this.DrawTextPoint.Y + y));
                        return;

                    case HorizontalAlignment.Right:
                        this.G.DrawString(text, this.Font, b1, (float) ((base.Width - this.DrawTextSize.Width) - x), (float) (this.DrawTextPoint.Y + y));
                        break;

                    case HorizontalAlignment.Center:
                        this.G.DrawString(text, this.Font, b1, (float) (this.DrawTextPoint.X + x), (float) (this.DrawTextPoint.Y + y));
                        return;

                    default:
                        return;
                }
            }
        }

        [Obfuscation(Exclude=true)]
        private void FormShown(object sender, EventArgs e)
        {
            if (!this._ControlMode && !this.HasShown)
            {
                if ((this._StartPosition == FormStartPosition.CenterParent) || (this._StartPosition == FormStartPosition.CenterScreen))
                {
                    Rectangle bounds = Screen.PrimaryScreen.Bounds;
                    Rectangle rectangle2 = base.ParentForm.Bounds;
                    base.ParentForm.Location = new Point((bounds.Width / 2) - (rectangle2.Width / 2), (bounds.Height / 2) - (rectangle2.Width / 2));
                }
                this.HasShown = true;
            }
        }

        [Obfuscation(Exclude=true)]
        protected SolidBrush GetBrush(string name) => 
            new SolidBrush(this.Items[name]);

        [Obfuscation(Exclude=true)]
        protected Color GetColor(string name) => 
            this.Items[name];

        [Obfuscation(Exclude=true)]
        private int GetIndex()
        {
            this.GetIndexPoint = base.PointToClient(Control.MousePosition);
            this.B1 = this.GetIndexPoint.X < 7;
            this.B2 = this.GetIndexPoint.X > (base.Width - 7);
            this.B3 = this.GetIndexPoint.Y < 7;
            this.B4 = this.GetIndexPoint.Y > (base.Height - 7);
            if (this.B1 && this.B3)
            {
                return 4;
            }
            if (this.B1 && this.B4)
            {
                return 7;
            }
            if (this.B2 && this.B3)
            {
                return 5;
            }
            if (this.B2 && this.B4)
            {
                return 8;
            }
            if (this.B1)
            {
                return 1;
            }
            if (this.B2)
            {
                return 2;
            }
            if (this.B3)
            {
                return 3;
            }
            if (this.B4)
            {
                return 6;
            }
            return 0;
        }

        [Obfuscation(Exclude=true)]
        protected Pen GetPen(string name) => 
            new Pen(this.Items[name]);

        [Obfuscation(Exclude=true)]
        protected Pen GetPen(string name, float width) => 
            new Pen(this.Items[name], width);

        [Obfuscation(Exclude=true)]
        private void InitializeMessages()
        {
            this.Messages[0] = Message.Create(base.Parent.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            int index = 1;
            do
            {
                this.Messages[index] = Message.Create(base.Parent.Handle, 0xa1, new IntPtr(index + 9), IntPtr.Zero);
                index++;
            }
            while (index <= 8);
        }

        [Obfuscation(Exclude=true)]
        private void InvalidateBitmap()
        {
            if (this._Transparent && this._ControlMode)
            {
                if ((base.Width != 0) && (base.Height != 0))
                {
                    this.B = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppPArgb);
                    this.G = Graphics.FromImage(this.B);
                }
            }
            else
            {
                this.G = null;
                this.B = null;
            }
        }

        [Obfuscation(Exclude=true)]
        private void InvalidateCustimization()
        {
            MemoryStream stream = new MemoryStream(this.Items.Count * 4);
            foreach (Shit.Bloom bloom in this.Colors)
            {
                stream.Write(BitConverter.GetBytes(bloom.Value.ToArgb()), 0, 4);
            }
            stream.Close();
            this._Customization = Convert.ToBase64String(stream.ToArray());
        }

        [Obfuscation(Exclude=true)]
        private void InvalidateMouse()
        {
            this.Current = this.GetIndex();
            if (this.Current != this.Previous)
            {
                this.Previous = this.Current;
                switch (this.Previous)
                {
                    case 0:
                        this.Cursor = Cursors.Default;
                        return;

                    case 1:
                    case 2:
                        this.Cursor = Cursors.SizeWE;
                        return;

                    case 3:
                    case 6:
                        this.Cursor = Cursors.SizeNS;
                        return;

                    case 4:
                    case 8:
                        this.Cursor = Cursors.SizeNWSE;
                        return;

                    case 5:
                    case 7:
                        this.Cursor = Cursors.SizeNESW;
                        break;

                    default:
                        return;
                }
            }
        }

        [Obfuscation(Exclude=true)]
        private void InvalidateTimer()
        {
            if (!base.DesignMode && this.DoneCreation)
            {
                if (this._IsAnimated)
                {
                    Shit.ThemeShare.AddAnimationCallback(new Shit.ThemeShare.AnimationDelegate(this.DoAnimation));
                }
                else
                {
                    Shit.ThemeShare.RemoveAnimationCallback(new Shit.ThemeShare.AnimationDelegate(this.DoAnimation));
                }
            }
        }

        [Obfuscation(Exclude=true)]
        protected Size Measure()
        {
            object measureGraphics = this.MeasureGraphics;
            lock (measureGraphics)
            {
                return this.MeasureGraphics.MeasureString(this.Text, this.Font, base.Width).ToSize();
            }
        }

        [Obfuscation(Exclude=true)]
        protected Size Measure(string text)
        {
            object measureGraphics = this.MeasureGraphics;
            lock (measureGraphics)
            {
                return this.MeasureGraphics.MeasureString(text, this.Font, base.Width).ToSize();
            }
        }

        [Obfuscation(Exclude=true)]
        protected Point Offset(Point p, int amount)
        {
            this.OffsetReturnPoint = new Point(p.X + amount, p.Y + amount);
            return this.OffsetReturnPoint;
        }

        [Obfuscation(Exclude=true)]
        protected Rectangle Offset(Rectangle r, int amount)
        {
            this.OffsetReturnRectangle = new Rectangle(r.X + amount, r.Y + amount, r.Width - (amount * 2), r.Height - (amount * 2));
            return this.OffsetReturnRectangle;
        }

        [Obfuscation(Exclude=true)]
        protected Size Offset(Size s, int amount)
        {
            this.OffsetReturnSize = new Size(s.Width + amount, s.Height + amount);
            return this.OffsetReturnSize;
        }

        [Obfuscation(Exclude=true)]
        protected virtual void OnAnimation()
        {
        }

        [Obfuscation(Exclude=true)]
        protected virtual void OnCreation()
        {
        }

        [Obfuscation(Exclude=true)]
        protected override void OnEnabledChanged(EventArgs e)
        {
            if (base.Enabled)
            {
                this.SetState(Shit.MouseState.None);
            }
            else
            {
                this.SetState(Shit.MouseState.Block);
            }
            base.OnEnabledChanged(e);
        }

        [Obfuscation(Exclude=true)]
        protected sealed override void OnHandleCreated(EventArgs e)
        {
            if (this.DoneCreation)
            {
                this.InitializeMessages();
            }
            this.InvalidateCustimization();
            this.ColorHook();
            if (this._LockWidth != 0)
            {
                base.Width = this._LockWidth;
            }
            if (this._LockHeight != 0)
            {
                base.Height = this._LockHeight;
            }
            if (!this._ControlMode)
            {
                base.Dock = DockStyle.Fill;
            }
            this.Transparent = this._Transparent;
            if (this._Transparent && this._BackColor)
            {
                this.BackColor = Color.Transparent;
            }
            base.OnHandleCreated(e);
        }

        [Obfuscation(Exclude=true)]
        protected override void OnHandleDestroyed(EventArgs e)
        {
            Shit.ThemeShare.RemoveAnimationCallback(new Shit.ThemeShare.AnimationDelegate(this.DoAnimation));
            base.OnHandleDestroyed(e);
        }

        [Obfuscation(Exclude=true)]
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.SetState(Shit.MouseState.Down);
            }
            if ((!this._IsParentForm || (base.ParentForm.WindowState != FormWindowState.Maximized)) && !this._ControlMode)
            {
                if (this._Movable && this.Frame.Contains(e.Location))
                {
                    base.Capture = false;
                    this.WM_LMBUTTONDOWN = true;
                    this.DefWndProc(ref this.Messages[0]);
                }
                else if (this._Sizable && (this.Previous != 0))
                {
                    base.Capture = false;
                    this.WM_LMBUTTONDOWN = true;
                    this.DefWndProc(ref this.Messages[this.Previous]);
                }
            }
            base.OnMouseDown(e);
        }

        [Obfuscation(Exclude=true)]
        protected override void OnMouseEnter(EventArgs e)
        {
            this.SetState(Shit.MouseState.Over);
            base.OnMouseEnter(e);
        }

        [Obfuscation(Exclude=true)]
        protected override void OnMouseLeave(EventArgs e)
        {
            this.SetState(Shit.MouseState.None);
            if (((base.GetChildAtPoint(base.PointToClient(Control.MousePosition)) != null) && this._Sizable) && !this._ControlMode)
            {
                this.Cursor = Cursors.Default;
                this.Previous = 0;
            }
            base.OnMouseLeave(e);
        }

        [Obfuscation(Exclude=true)]
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if ((!this._IsParentForm || (base.ParentForm.WindowState != FormWindowState.Maximized)) && (this._Sizable && !this._ControlMode))
            {
                this.InvalidateMouse();
            }
            base.OnMouseMove(e);
        }

        [Obfuscation(Exclude=true)]
        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.SetState(Shit.MouseState.Over);
            base.OnMouseUp(e);
        }

        [Obfuscation(Exclude=true)]
        protected sealed override void OnPaint(PaintEventArgs e)
        {
            if ((base.Width != 0) && (base.Height != 0))
            {
                if (this._Transparent && this._ControlMode)
                {
                    this.PaintHook();
                    e.Graphics.DrawImage(this.B, 0, 0);
                }
                else
                {
                    this.G = e.Graphics;
                    this.PaintHook();
                }
            }
        }

        [Obfuscation(Exclude=true)]
        protected sealed override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            if (base.Parent != null)
            {
                this._IsParentForm = base.Parent is Form;
                if (!this._ControlMode)
                {
                    this.InitializeMessages();
                    if (this._IsParentForm)
                    {
                        base.ParentForm.FormBorderStyle = this._BorderStyle;
                        base.ParentForm.TransparencyKey = this._TransparencyKey;
                        if (!base.DesignMode)
                        {
                            base.ParentForm.Shown += new EventHandler(this.FormShown);
                        }
                    }
                    base.Parent.BackColor = this.BackColor;
                }
                this.OnCreation();
                this.DoneCreation = true;
                this.InvalidateTimer();
            }
        }

        [Obfuscation(Exclude=true)]
        protected sealed override void OnSizeChanged(EventArgs e)
        {
            if (this._Movable && !this._ControlMode)
            {
                this.Frame = new Rectangle(7, 7, base.Width - 14, this._Header - 7);
            }
            this.InvalidateBitmap();
            base.Invalidate();
            base.OnSizeChanged(e);
        }

        [Obfuscation(Exclude=true)]
        protected abstract void PaintHook();
        [Obfuscation(Exclude=true)]
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            if (this._LockWidth != 0)
            {
                width = this._LockWidth;
            }
            if (this._LockHeight != 0)
            {
                height = this._LockHeight;
            }
            base.SetBoundsCore(x, y, width, height, specified);
        }

        [Obfuscation(Exclude=true)]
        protected void SetColor(string name, Color value)
        {
            if (this.Items.ContainsKey(name))
            {
                this.Items[name] = value;
            }
            else
            {
                this.Items.Add(name, value);
            }
        }

        [Obfuscation(Exclude=true)]
        protected void SetColor(string name, byte a, Color value)
        {
            this.SetColor(name, Color.FromArgb(a, value));
        }

        [Obfuscation(Exclude=true)]
        protected void SetColor(string name, byte r, byte g, byte b)
        {
            this.SetColor(name, Color.FromArgb(r, g, b));
        }

        [Obfuscation(Exclude=true)]
        protected void SetColor(string name, byte a, byte r, byte g, byte b)
        {
            this.SetColor(name, Color.FromArgb(a, r, g, b));
        }

        [Obfuscation(Exclude=true)]
        private void SetState(Shit.MouseState current)
        {
            this.State = current;
            base.Invalidate();
        }

        [Obfuscation(Exclude=true)]
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (this.WM_LMBUTTONDOWN && (m.Msg == 0x201))
            {
                this.WM_LMBUTTONDOWN = false;
                this.SetState(Shit.MouseState.Over);
                if (this._SmartBounds)
                {
                    if (this.IsParentMdi)
                    {
                        this.CorrectBounds(new Rectangle(Point.Empty, base.Parent.Parent.Size));
                    }
                    else
                    {
                        this.CorrectBounds(Screen.FromControl(base.Parent).WorkingArea);
                    }
                }
            }
        }

        public override DockStyle Dock
        {
            [Obfuscation(Exclude=true)]
            get => 
                base.Dock;
            [Obfuscation(Exclude=true)]
            set
            {
                if (this._ControlMode)
                {
                    base.Dock = value;
                }
            }
        }

        [Category("Misc")]
        public override Color BackColor
        {
            [Obfuscation(Exclude=true)]
            get => 
                base.BackColor;
            [Obfuscation(Exclude=true)]
            set
            {
                if (value != base.BackColor)
                {
                    if ((!base.IsHandleCreated && this._ControlMode) && (value == Color.Transparent))
                    {
                        this._BackColor = true;
                    }
                    else
                    {
                        base.BackColor = value;
                        if (base.Parent != null)
                        {
                            if (!this._ControlMode)
                            {
                                base.Parent.BackColor = value;
                            }
                            this.ColorHook();
                        }
                    }
                }
            }
        }

        public override Size MinimumSize
        {
            [Obfuscation(Exclude=true)]
            get => 
                base.MinimumSize;
            [Obfuscation(Exclude=true)]
            set
            {
                base.MinimumSize = value;
                if (base.Parent != null)
                {
                    base.Parent.MinimumSize = value;
                }
            }
        }

        public override Size MaximumSize
        {
            [Obfuscation(Exclude=true)]
            get => 
                base.MaximumSize;
            [Obfuscation(Exclude=true)]
            set
            {
                base.MaximumSize = value;
                if (base.Parent != null)
                {
                    base.Parent.MaximumSize = value;
                }
            }
        }

        public override string Text
        {
            [Obfuscation(Exclude=true)]
            get => 
                base.Text;
            [Obfuscation(Exclude=true)]
            set
            {
                base.Text = value;
                base.Invalidate();
            }
        }

        public override System.Drawing.Font Font
        {
            [Obfuscation(Exclude=true)]
            get => 
                base.Font;
            [Obfuscation(Exclude=true)]
            set
            {
                base.Font = value;
                base.Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public override Color ForeColor
        {
            [Obfuscation(Exclude=true)]
            get => 
                Color.Empty;
            [Obfuscation(Exclude=true)]
            set
            {
            }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override System.Drawing.Image BackgroundImage
        {
            [Obfuscation(Exclude=true)]
            get => 
                null;
            [Obfuscation(Exclude=true)]
            set
            {
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override ImageLayout BackgroundImageLayout
        {
            [Obfuscation(Exclude=true)]
            get => 
                ImageLayout.None;
            [Obfuscation(Exclude=true)]
            set
            {
            }
        }

        public bool SmartBounds
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._SmartBounds;
            [Obfuscation(Exclude=true)]
            set => 
                (this._SmartBounds = value);
        }

        public bool Movable
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._Movable;
            [Obfuscation(Exclude=true)]
            set => 
                (this._Movable = value);
        }

        public bool Sizable
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._Sizable;
            [Obfuscation(Exclude=true)]
            set => 
                (this._Sizable = value);
        }

        public Color TransparencyKey
        {
            [Obfuscation(Exclude=true)]
            get
            {
                if (this._IsParentForm && !this._ControlMode)
                {
                    return base.ParentForm.TransparencyKey;
                }
                return this._TransparencyKey;
            }
            [Obfuscation(Exclude=true)]
            set
            {
                if (!(value == this._TransparencyKey))
                {
                    this._TransparencyKey = value;
                    if (this._IsParentForm && !this._ControlMode)
                    {
                        base.ParentForm.TransparencyKey = value;
                        this.ColorHook();
                    }
                }
            }
        }

        public FormBorderStyle BorderStyle
        {
            [Obfuscation(Exclude=true)]
            get
            {
                if (this._IsParentForm && !this._ControlMode)
                {
                    return base.ParentForm.FormBorderStyle;
                }
                return this._BorderStyle;
            }
            [Obfuscation(Exclude=true)]
            set
            {
                this._BorderStyle = value;
                if (this._IsParentForm && !this._ControlMode)
                {
                    base.ParentForm.FormBorderStyle = value;
                    if (value != FormBorderStyle.None)
                    {
                        this.Movable = false;
                        this.Sizable = false;
                    }
                }
            }
        }

        public FormStartPosition StartPosition
        {
            [Obfuscation(Exclude=true)]
            get
            {
                if (this._IsParentForm && !this._ControlMode)
                {
                    return base.ParentForm.StartPosition;
                }
                return this._StartPosition;
            }
            [Obfuscation(Exclude=true)]
            set
            {
                this._StartPosition = value;
                if (this._IsParentForm && !this._ControlMode)
                {
                    base.ParentForm.StartPosition = value;
                }
            }
        }

        public bool NoRounding
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._NoRounding;
            [Obfuscation(Exclude=true)]
            set
            {
                this._NoRounding = value;
                base.Invalidate();
            }
        }

        public System.Drawing.Image Image
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._Image;
            [Obfuscation(Exclude=true)]
            set
            {
                if (value == null)
                {
                    this._ImageSize = Size.Empty;
                }
                else
                {
                    this._ImageSize = value.Size;
                }
                this._Image = value;
                base.Invalidate();
            }
        }

        public Shit.Bloom[] Colors
        {
            [Obfuscation(Exclude=true)]
            get
            {
                List<Shit.Bloom> list = new List<Shit.Bloom>();
                Dictionary<string, Color>.Enumerator enumerator = this.Items.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    KeyValuePair<string, Color> current = enumerator.Current;
                    current = enumerator.Current;
                    list.Add(new Shit.Bloom(current.Key, current.Value));
                }
                return list.ToArray();
            }
            [Obfuscation(Exclude=true)]
            set
            {
                foreach (Shit.Bloom bloom in value)
                {
                    if (this.Items.ContainsKey(bloom.Name))
                    {
                        this.Items[bloom.Name] = bloom.Value;
                    }
                }
                this.InvalidateCustimization();
                this.ColorHook();
                base.Invalidate();
            }
        }

        public string Customization
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._Customization;
            [Obfuscation(Exclude=true)]
            set
            {
                if (value != this._Customization)
                {
                    Shit.Bloom[] colors = this.Colors;
                    try
                    {
                        byte[] buffer = Convert.FromBase64String(value);
                        int num = colors.Length - 1;
                        for (int i = 0; i <= num; i++)
                        {
                            colors[i].Value = Color.FromArgb(BitConverter.ToInt32(buffer, i * 4));
                        }
                    }
                    catch (Exception exception1)
                    {
                        ProjectData.SetProjectError(exception1);
                        ProjectData.ClearProjectError();
                        return;
                    }
                    this._Customization = value;
                    this.Colors = colors;
                    this.ColorHook();
                    base.Invalidate();
                }
            }
        }

        public bool Transparent
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._Transparent;
            [Obfuscation(Exclude=true)]
            set
            {
                this._Transparent = value;
                if (base.IsHandleCreated || this._ControlMode)
                {
                    if (!value && (this.BackColor.A != 0xff))
                    {
                        throw new Exception("Unable to change value to false while a transparent BackColor is in use.");
                    }
                    base.SetStyle(ControlStyles.Opaque, !value);
                    base.SetStyle(ControlStyles.SupportsTransparentBackColor, value);
                    this.InvalidateBitmap();
                    base.Invalidate();
                }
            }
        }

        protected Size ImageSize =>
            this._ImageSize;

        protected bool IsParentForm =>
            this._IsParentForm;

        protected bool IsParentMdi =>
            (base.Parent?.Parent > null);

        protected int LockWidth
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._LockWidth;
            [Obfuscation(Exclude=true)]
            set
            {
                this._LockWidth = value;
                if ((this.LockWidth != 0) && base.IsHandleCreated)
                {
                    base.Width = this.LockWidth;
                }
            }
        }

        protected int LockHeight
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._LockHeight;
            [Obfuscation(Exclude=true)]
            set
            {
                this._LockHeight = value;
                if ((this.LockHeight != 0) && base.IsHandleCreated)
                {
                    base.Height = this.LockHeight;
                }
            }
        }

        protected int Header
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._Header;
            [Obfuscation(Exclude=true)]
            set
            {
                this._Header = value;
                if (!this._ControlMode)
                {
                    this.Frame = new Rectangle(7, 7, base.Width - 14, value - 7);
                    base.Invalidate();
                }
            }
        }

        protected bool ControlMode
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._ControlMode;
            [Obfuscation(Exclude=true)]
            set
            {
                this._ControlMode = value;
                this.Transparent = this._Transparent;
                if (this._Transparent && this._BackColor)
                {
                    this.BackColor = Color.Transparent;
                }
                this.InvalidateBitmap();
                base.Invalidate();
            }
        }

        protected bool IsAnimated
        {
            [Obfuscation(Exclude=true)]
            get => 
                this._IsAnimated;
            [Obfuscation(Exclude=true)]
            set
            {
                this._IsAnimated = value;
                this.InvalidateTimer();
            }
        }
    }
}

