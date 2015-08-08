/***
 * 
 * @Filename        :   MsgBoxG.cs
 * @Description     :   Custom message box
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/02/6:30
 *
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Glx.Gui
{
    /// <summary>
    /// Messagebox class
    /// </summary>
    public partial class MsgBoxG : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MsgBoxG()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Call this constructor to display the messsage box
        /// </summary>
        /// <param name="sMessage_i"></param>
        /// <param name="sCaption_i"></param>
        /// <param name="messageBoxButtons_i"></param>
        public MsgBoxG(string sMessage_i, string sCaption_i, MessageBoxButtons messageBoxButtons_i)
        {
            InitializeComponent();
            CreateDialog(sMessage_i, sCaption_i, messageBoxButtons_i);
        }

        /// <summary>
        /// Create message box with various Buttons, caption and Message
        /// </summary>
        /// <param name="sMessage_i"></param>
        /// <param name="sCaption_i"></param>
        /// <param name="messageBoxButtons_i"></param>
        private void CreateDialog(string sMessage_i, string sCaption_i, MessageBoxButtons messageBoxButtons_i)
        {
            text_Msg.Text = sMessage_i;
            if (null == sCaption_i)
            {

            }
            else
            {
                lbl_Caption.Text = sCaption_i;
            }

            switch (messageBoxButtons_i)
            {
                case MessageBoxButtons.OKCancel:
                    {
                        btn_one.Text        = "OK";
                        btn_Two.Text         = "";
                        btn_Three.Text     = "Cancel";

                        btn_one.Enabled     = true;
                        btn_Two.Enabled      = false;
                        btn_Three.Enabled  = true;

                        btn_one.DialogResult    = DialogResult.OK;
                        btn_Two.DialogResult     = DialogResult.None;
                        btn_Three.DialogResult = DialogResult.Cancel;

                        break;
                    }

                case MessageBoxButtons.YesNo:
                    {
                        btn_one.Text = "Yes";
                        btn_Two.Text = "";
                        btn_Three.Text = "No";

                        btn_one.Enabled = true;
                        btn_Two.Enabled = false;
                        btn_Three.Enabled = true;

                        btn_one.DialogResult = DialogResult.Yes;
                        btn_Two.DialogResult = DialogResult.None;
                        btn_Three.DialogResult = DialogResult.No;

                        break;
                    }

                case MessageBoxButtons.RetryCancel:
                    {
                        btn_one.Text = "Retry";
                        btn_Two.Text = "";
                        btn_Three.Text = "Cancel";

                        btn_one.Enabled = true;
                        btn_Two.Enabled = false;
                        btn_Three.Enabled = true;

                        btn_one.DialogResult = DialogResult.Retry;
                        btn_Two.DialogResult = DialogResult.None;
                        btn_Three.DialogResult = DialogResult.Cancel;

                        break;
                    }

                case MessageBoxButtons.AbortRetryIgnore:
                    {
                        btn_one.Text = "Abort";
                        btn_Two.Text = "Retry";
                        btn_Three.Text = "Ignore";

                        btn_one.Enabled = true;
                        btn_Two.Enabled = true;
                        btn_Three.Enabled = true;

                        btn_one.DialogResult = DialogResult.Abort;
                        btn_Two.DialogResult = DialogResult.Retry;
                        btn_Three.DialogResult = DialogResult.Ignore;

                        break;
                    }

                case MessageBoxButtons.YesNoCancel:
                    {
                        btn_one.Text = "Yes";
                        btn_Two.Text = "No";
                        btn_Three.Text = "Cancel";

                        btn_one.Enabled = true;
                        btn_Two.Enabled = true;
                        btn_Three.Enabled = true;

                        btn_one.DialogResult = DialogResult.Yes;
                        btn_Two.DialogResult = DialogResult.No;
                        btn_Three.DialogResult = DialogResult.Cancel;

                        break;
                    }

                default:
                    {
                        btn_one.Text    = "";
                        btn_Two.Text     = "OK";
                        btn_Three.Text = "";

                        btn_one.Enabled     = false;
                        btn_Two.Enabled      = true;
                        btn_Three.Enabled  = false;

                        btn_one.DialogResult    = DialogResult.None;
                        btn_Two.DialogResult     = DialogResult.OK;
                        btn_Three.DialogResult = DialogResult.None;
                        break;
                    }
            }
        }
    }
    
}
