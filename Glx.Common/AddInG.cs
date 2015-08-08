/***
 * 
 * @Filename        :   DllFunctions.cs
 * @Description     :   Common Dll functions, including AddIn management
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/03/2:24
 *
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Glx.Logger;
using System.IO;
using System.Reflection;

namespace Glx.Common
{
    /// <summary>
    /// Dll class
    /// </summary>
    public static class AddInG
    {
        /// <summary>
        /// Load a dll file and get a specified object
        /// </summary>
        /// <param name="sDllFileName"></param>
        /// <param name="sUserControlName"></param>
        /// <returns></returns>
        public static object GetObjectFromDll(string sDllFileName, string sUserControlName)
        {
            using (Log log = new Log("Glx.Common.::GetObjectFromDll()"))
            {
                try
                {
                    Assembly assembly = Assembly.LoadFile(@sDllFileName);
                    object obj;
                    Type myType = assembly.GetType(sUserControlName);
                    obj = Activator.CreateInstance(myType);
                    return obj;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return false;
                }
            }

        }

        /// <summary>
        /// Load a dll file and get the specified Usercontrol
        /// </summary>
        /// <param name="sDllFileName"></param>
        /// <param name="sUserControlName"></param>
        /// <returns></returns>
        public static UserControl GetUserControlFromDll(string sDllFileName, string sUserControlName)
        {
            using (Log log = new Log("Glx.Common.::GetUserControlFromDll()"))
            {
                try
                {
                    Assembly assembly = Assembly.LoadFile(@sDllFileName);
                    object obj;
                    Type myType = assembly.GetType(sUserControlName);
                    obj = Activator.CreateInstance(myType);

                    UserControl userControl = (UserControl)obj;
                    return userControl;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return null;
                }
            }

        }

        /// <summary>
        /// Load a dll file( AddIn file ) and get a user control named 'Icon' for Executing the AddIn
        /// </summary>
        /// <param name="sDllFileName"></param>
        /// <param name="sUserControlName"></param>
        /// <returns></returns>
        public static UserControl GetAddInIconFromDll(string sDllFileName)
        {
            using (Log log = new Log("Glx.Common.::GetAddInIconFromDll()"))
            {
                try
                {
                    Assembly assembly = Assembly.LoadFile(@sDllFileName);
                    object obj;
                    Type myType = assembly.GetType("Glx.AddIn.Icon");
                    obj = Activator.CreateInstance(myType);

                    UserControl userControl = (UserControl)obj;
                    return userControl;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return null;
                }
            }

        }

        /// <summary>
        /// Load a dll file( AddIn file ) and get the user control named 'Executable' for use
        /// </summary>
        /// <param name="sDllFileName"></param>
        /// <param name="sUserControlName"></param>
        /// <returns></returns>
        public static UserControl GetAddInFromDll(string sDllFileName)
        {
            using (Log log = new Log("Glx.Common.::GetAddInIconFromDll()"))
            {
                try
                {
                    Assembly assembly = Assembly.LoadFile(@sDllFileName);
                    object obj;
                    Type myType = assembly.GetType("Glx.AddIn.Executable");
                    obj = Activator.CreateInstance(myType);

                    UserControl userControl = (UserControl)obj;
                    return userControl;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return null;
                }
            }

        }
   
        /// <summary>
        /// LoadAddInsToPanel
        /// </summary>
        /// <param name="PanelToLoadAddIns"></param>
        public static void LoadAddInsToPanel(Panel PanelToLoadAddIns)
        {
            using (Log log = new Log("Glx.Common.G::LoadAddInsToPanel()"))
            {
                try
                {
                    string sAddInpath = G.GetAppPath() + "\\AddIn\\";
                    System.IO.DirectoryInfo AddInDir = System.IO.Directory.CreateDirectory(sAddInpath);
                    int i = 0;

                    foreach (System.IO.FileInfo file in AddInDir.GetFiles())
                    {
                        UserControl ControlIcon = AddInG.GetAddInIconFromDll(file.FullName);
                        ControlIcon.Location = new System.Drawing.Point(0, i);
                        ControlIcon.TabIndex = i;
                        PanelToLoadAddIns.Controls.Add(ControlIcon);
                        i += 50;
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
            }
        }
    }
}
