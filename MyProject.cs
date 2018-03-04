namespace Shit.My
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using Shit;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [HideModuleName, StandardModule, GeneratedCode("MyTemplate", "11.0.0.0"), Obfuscation(Exclude=true)]
    internal sealed class MyProject
    {
        private static readonly ThreadSafeObjectProvider<Shit.My.MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<Shit.My.MyComputer>();
        private static readonly ThreadSafeObjectProvider<Shit.My.MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<Shit.My.MyApplication>();
        private static readonly ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider = new ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();
        private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();
        private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

        [HelpKeyword("My.Computer")]
        internal static Shit.My.MyComputer Computer =>
            m_ComputerObjectProvider.GetInstance;

        [HelpKeyword("My.Application")]
        internal static Shit.My.MyApplication Application =>
            m_AppObjectProvider.GetInstance;

        [HelpKeyword("My.User")]
        internal static Microsoft.VisualBasic.ApplicationServices.User User =>
            m_UserObjectProvider.GetInstance;

        [HelpKeyword("My.Forms")]
        internal static MyForms Forms =>
            m_MyFormsObjectProvider.GetInstance;

        [HelpKeyword("My.WebServices")]
        internal static MyWebServices WebServices =>
            m_MyWebServicesObjectProvider.GetInstance;

        [EditorBrowsable(EditorBrowsableState.Never), MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), Obfuscation(Exclude=true)]
        internal sealed class MyForms
        {
            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Shit.DW2 m_DW2;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Shit.Form1 m_Form1;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Shit.holper m_holper;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Shit.InjectForm m_InjectForm;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Shit.Login m_Login;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Shit.Settings m_Settings;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Shit.Splash m_Splash;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Shit.Test m_Test;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Shit.Unbanner m_Unbanner;

            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T: Form, new()
            {
                if ((Instance == null) || Instance.IsDisposed)
                {
                    TargetInvocationException exception;
                    if (m_FormBeingCreated != null)
                    {
                        if (m_FormBeingCreated.ContainsKey(typeof(T)))
                        {
                            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
                        }
                    }
                    else
                    {
                        m_FormBeingCreated = new Hashtable();
                    }
                    m_FormBeingCreated.Add(typeof(T), null);
                    try
                    {
                        return Activator.CreateInstance<T>();
                    }
                    catch (TargetInvocationException exception1) when ((exception.InnerException > null))
                    {
                        ProjectData.SetProjectError(exception1);
                        string[] args = new string[] { exception.InnerException.Message };
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", args), exception.InnerException);
                    }
                    finally
                    {
                        m_FormBeingCreated.Remove(typeof(T));
                    }
                }
                return Instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T: Form
            {
                instance.Dispose();
                instance = default(T);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o) => 
                base.Equals(RuntimeHelpers.GetObjectValue(o));

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode() => 
                base.GetHashCode();

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal Type GetType() => 
                typeof(Shit.My.MyProject.MyForms);

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString() => 
                base.ToString();

            public Shit.DW2 DW2
            {
                get
                {
                    this.m_DW2 = Create__Instance__<Shit.DW2>(this.m_DW2);
                    return this.m_DW2;
                }
                set
                {
                    if (value != this.m_DW2)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Shit.DW2>(ref this.m_DW2);
                    }
                }
            }

            public Shit.Form1 Form1
            {
                get
                {
                    this.m_Form1 = Create__Instance__<Shit.Form1>(this.m_Form1);
                    return this.m_Form1;
                }
                set
                {
                    if (value != this.m_Form1)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Shit.Form1>(ref this.m_Form1);
                    }
                }
            }

            public Shit.holper holper
            {
                get
                {
                    this.m_holper = Create__Instance__<Shit.holper>(this.m_holper);
                    return this.m_holper;
                }
                set
                {
                    if (value != this.m_holper)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Shit.holper>(ref this.m_holper);
                    }
                }
            }

            public Shit.InjectForm InjectForm
            {
                get
                {
                    this.m_InjectForm = Create__Instance__<Shit.InjectForm>(this.m_InjectForm);
                    return this.m_InjectForm;
                }
                set
                {
                    if (value != this.m_InjectForm)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Shit.InjectForm>(ref this.m_InjectForm);
                    }
                }
            }

            public Shit.Login Login
            {
                get
                {
                    this.m_Login = Create__Instance__<Shit.Login>(this.m_Login);
                    return this.m_Login;
                }
                set
                {
                    if (value != this.m_Login)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Shit.Login>(ref this.m_Login);
                    }
                }
            }

            public Shit.Settings Settings
            {
                get
                {
                    this.m_Settings = Create__Instance__<Shit.Settings>(this.m_Settings);
                    return this.m_Settings;
                }
                set
                {
                    if (value != this.m_Settings)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Shit.Settings>(ref this.m_Settings);
                    }
                }
            }

            public Shit.Splash Splash
            {
                get
                {
                    this.m_Splash = Create__Instance__<Shit.Splash>(this.m_Splash);
                    return this.m_Splash;
                }
                set
                {
                    if (value != this.m_Splash)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Shit.Splash>(ref this.m_Splash);
                    }
                }
            }

            public Shit.Test Test
            {
                get
                {
                    this.m_Test = Create__Instance__<Shit.Test>(this.m_Test);
                    return this.m_Test;
                }
                set
                {
                    if (value != this.m_Test)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Shit.Test>(ref this.m_Test);
                    }
                }
            }

            public Shit.Unbanner Unbanner
            {
                get
                {
                    this.m_Unbanner = Create__Instance__<Shit.Unbanner>(this.m_Unbanner);
                    return this.m_Unbanner;
                }
                set
                {
                    if (value != this.m_Unbanner)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Shit.Unbanner>(ref this.m_Unbanner);
                    }
                }
            }
        }

        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), Obfuscation(Exclude=true), EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyWebServices
        {
            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T: new()
            {
                if (instance == null)
                {
                    return Activator.CreateInstance<T>();
                }
                return instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                instance = default(T);
            }

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o) => 
                base.Equals(RuntimeHelpers.GetObjectValue(o));

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override int GetHashCode() => 
                base.GetHashCode();

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            internal Type GetType() => 
                typeof(Shit.My.MyProject.MyWebServices);

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString() => 
                base.ToString();
        }

        [ComVisible(false), EditorBrowsable(EditorBrowsableState.Never), Obfuscation(Exclude=true)]
        internal sealed class ThreadSafeObjectProvider<T> where T: new()
        {
            [CompilerGenerated, ThreadStatic]
            private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if (Shit.My.MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                    {
                        Shit.My.MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
                    }
                    return Shit.My.MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }
        }
    }
}

