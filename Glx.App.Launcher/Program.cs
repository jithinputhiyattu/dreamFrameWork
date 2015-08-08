using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Glx.App;
using System.Reflection;

namespace Glx.App.Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Assembly assembly = Assembly.LoadFile(@"D:\dreamSafe\Devolopement\Template\GLX_Template\GLX_Template\bin\Release\GlxWin32.dll");
            foreach (Type type in assembly.GetTypes())
            {
                if (type.IsClass)
                {
                    MethodInfo method = type.GetMethod("Main");
                    if (method != null)
                    {
                        method.Invoke(null, new Object[0]); // assumes no parameters
                        break; // no need to look for more methods, unless you got multiple?
                    }
                }
            }*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new New());

            
        }
    }
}
