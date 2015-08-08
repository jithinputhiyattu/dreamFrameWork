/***
 * 
 * @Filename        :   Common.cs
 * @Description     :   Common Functions and Constants
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/03/0:12
 *
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Glx.DB;
using Glx.Gui;
using Glx.Logger;
using System.IO;
using System.Reflection;


namespace Glx.Common
{
    /// <summary>
    /// Common class
    /// </summary>
    public static class G
    {
        public const string ID_OPEN_SYMBOL = "(";
        public const string ID_CLOSE_SYMBOL = ")";
        public const string ID_SPACE = "    ";
        public const string ID_NEWLINE = "\r\n";

        /// <summary>
        /// Enum holding Configuration items
        /// </summary>
        public enum Config
        {
            Font,
            FontSize,
            FontName,
            FontStyle,
        };

        /// <summary>
        /// Constructor
        /// </summary>
        static G()
        {
        }

        /// <summary>
        /// Clear Combobox items
        /// </summary>
        /// <param name="comboBox_i"></param>
        public static void ClearComboView(ComboBox comboBox_i)
        {
            using (Log log = new Log("Glx.Common.::ClearComboView()"))
            {
            	try
            	{
                    for (int nIndex = comboBox_i.Items.Count - 1; nIndex >= 0; nIndex--)
                    {
                        comboBox_i.Items.RemoveAt(nIndex);
                    }	
            	}
            	catch (Exception ex)
            	{
            		log.Error(ex);
            	}
            } 
        }

        /// <summary>
        /// Clear Datagridview
        /// </summary>
        /// <param name="dataGridView_i"></param>
        public static void ClearDataGridView(DataGridView dataGridView_i)
        {
            using (Log log = new Log("Glx.Common.::ClearDataGridView()"))
            {
            	try
            	{
                    for (int i = dataGridView_i.RowCount - 2; i >= 0; i--)
                    {
                        dataGridView_i.Rows.RemoveAt(i);
                    }
            	}
            	catch (Exception ex)
            	{
            		log.Error(ex);
            	}
            }
            
        }

        /// <summary>
        /// Export listview items to HTML
        /// </summary>
        /// <param name="listView_i"></param>
        /// <param name="sFileName_i"></param>
        /// <param name="sHeadingA_i"></param>
        /// <param name="sHeadingB_i"></param>
        public static void ExportList(ListView listView_i, string sFileName_i, string sHeadingA_i, string sHeadingB_i)
        {
            using (Log log = new Log("Glx.Common.::ExportList()"))
            {
                try
                {

                    File.WriteAllText(sFileName_i, "<html><center><body><table border ='1px'>");
                    int nColumCount = listView_i.Columns.Count;
                    ListView.ColumnHeaderCollection columheaders = listView_i.Columns;

                    File.AppendAllText(sFileName_i, "<tr><td colspan ='2'><h3>" + sHeadingA_i + "</h3></td>");
                    File.AppendAllText(sFileName_i, "<td colspan ='" + (nColumCount - 2).ToString() + "'><h3>" + sHeadingB_i + "</h3></td></tr>");


                    for (int nIndex = 0; nIndex < nColumCount; nIndex++)
                    {
                        File.AppendAllText(sFileName_i, "<th>");
                        File.AppendAllText(sFileName_i, columheaders[nIndex].Text + "</th>");
                    }

                    int nItemCount = listView_i.Items.Count;
                    ListViewItem.ListViewSubItemCollection lvSubItems = null;
                    int nSubItemCount = 0;
                    for (int nIndex = 0; nIndex < nItemCount; nIndex++)
                    {
                        lvSubItems = listView_i.Items[nIndex].SubItems;
                        nSubItemCount = lvSubItems.Count;
                        if ("" == lvSubItems[0].Text)
                        {
                            continue;
                        }

                        File.AppendAllText(sFileName_i, "<tr>");

                        for (int nColumnIndex = 0; nColumnIndex < nSubItemCount; nColumnIndex++)
                        {
                            File.AppendAllText(sFileName_i, "<td>" + lvSubItems[nColumnIndex].Text + "</td>");
                        }
                        File.AppendAllText(sFileName_i, "</tr>");
                    }
                    File.AppendAllText(sFileName_i, "<table></body></center></html>");

                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return;
                }
            }
            
        }

        /// <summary>
        /// Configure a settings
        /// </summary>
        /// <param name="sName"></param>
        /// <param name="sValue"></param>
        /// <returns></returns>
        public static bool ConfigureValue(Config sName, string sValue)
        {
            using (Log log = new Log("Glx.Common.::ConfigureValue()"))
            {
            	try
            	{
                    string sGetCmd = "Update Configuration set Value = '" + sValue + "' where Name = '";

                    switch (sName)
                    {
                        case Config.Font:
                            sGetCmd += "Font'";
                            break;
                        case Config.FontName:
                            sGetCmd += "FontName'";
                            break;
                        case Config.FontSize:
                            sGetCmd += "FontSize'";
                            break;
                        case Config.FontStyle:
                            sGetCmd += "FontStyle'";
                            break;
                    }

                    return DBWrapper.ExecuteNonQueryEx(sGetCmd);
            	}
            	catch (Exception ex)
            	{
            		log.Error(ex);
                    return false;
            	}
            }
        }

        /// <summary>
        /// Get a configured setting value
        /// </summary>
        /// <param name="sName"></param>
        /// <returns></returns>
        public static string GetConfiguration(Config sName)
        {
            using (Log log = new Log("Glx.Common.::GetConfiguration()"))
            {
            	try
            	{
                    string sGetCmd = "Select Value from Configuration where Name = '";
                    string sValue = "";

                    switch (sName)
                    {
                        case Config.Font:
                            sGetCmd += "Font'";
                            break;
                        case Config.FontName:
                            sGetCmd += "FontName'";
                            break;
                        case Config.FontSize:
                            sGetCmd += "FontSize'";
                            break;
                        case Config.FontStyle:
                            sGetCmd += "FontStyle'";
                            break;
                    }

                    SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(sGetCmd);

                    if (null != sqlDataReader)
                    {
                        while (sqlDataReader.Read())
                        {
                            if (!sqlDataReader.IsDBNull(0))
                            {
                                sValue = sqlDataReader.GetString(0);
                            }

                        }
                    }

                    sqlDataReader.Close();

                    return sValue;
            	}
            	catch (Exception ex)
            	{
            		log.Error(ex);
                    return null;
            	}
            } 
        }

        /// <summary>
        /// Display a message box using the custom message box MsgBoxG
        /// </summary>
        /// <param name="sMessage_i"></param>
        /// <param name="sCaption_i"></param>
        /// <param name="messageBoxButtons_i"></param>
        /// <returns></returns>
        public static DialogResult MsgBox(string sMessage_i, string sCaption_i, MessageBoxButtons messageBoxButtons_i)
        {
            using (Log log = new Log("Glx.Common.G::MsgBox()"))
            {
            	try
            	{
                    MsgBoxG msgBox = new MsgBoxG(sMessage_i, sCaption_i, messageBoxButtons_i);
                    return msgBox.ShowDialog();
            	}
            	catch (Exception ex)
            	{
            		log.Error(ex);
                    return DialogResult.None;
            	}
            }
        }

        /// <summary>
        /// Load a dll file and run the specified function
        /// </summary>
        /// <param name="sDllFileName"></param>
        /// <param name="sMethodName"></param>
        /// <returns></returns>
        public static bool RunFunctionFromDll(string sDllFileName, string sMethodName)
        {
            using (Log log = new Log("Glx.Common.::RunFunctionFromDll()"))
            {
                try
                {
                    Assembly assembly = Assembly.LoadFile(@sDllFileName);
                    MethodInfo method;
                    foreach (Type type in assembly.GetTypes())
                    {
                        if (type.IsClass)
                        {
                            method = type.GetMethod(sMethodName);
                            if (method != null)
                            {
                                method.Invoke(null, new Object[0]); // assumes no parameters
                                break; // no need to look for more methods, unless you got multiple?
                            }
                        }
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return false;
                }
            }
        }


        /// <summary>
        /// Get Application path
        /// </summary>
        /// <returns></returns>
        public static string GetAppPath()
        {
            using (Log log = new Log("Glx.Common.::CurDir()"))
            {
                try
                {
                    return Application.StartupPath;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return null;
                }
            }

        }
    }
}
