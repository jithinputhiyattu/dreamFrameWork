/***
 * 
 * @Filename        :   G.cs
 * @Description     :   
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/07/25/12:04
 *
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Glx.Gui
{
    /// <summary>
    /// Common class for Glx.GUI
    /// </summary>
    public  class GuiG
    {
        /// <summary>
        /// Constructor
        /// </summary>
        GuiG()
        {
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
            MsgBoxG msgBox = new MsgBoxG(sMessage_i, sCaption_i, messageBoxButtons_i );
            return msgBox.ShowDialog();
        }
    }
}
