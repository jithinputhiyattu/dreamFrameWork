/***
 * 
 * @Filename        :   TextBoxG.cs
 * @Description     :   Custom Textbox
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/01/23:42
 *
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Glx.Gui;

namespace Glx.Gui
{
    /// <summary>
    /// TextBoxG
    /// </summary>
    public partial class TextBoxG : TextBox
    {
        private TextBox ErrorLabel;
        private Timer TextTimer;
        private string _sErrorMessage;
        private ErrorToolTipG _errorToolTip;
        private InfoToolTipG _infoToolTip;

        int VisibleTime = 2000;  //in milliseconds
        /// <summary>
        /// Constructor
        /// </summary>
        public TextBoxG()
        {
            ErrorLabel = new TextBox();
            _errorToolTip = new ErrorToolTipG();
            _infoToolTip = new InfoToolTipG();
            InitializeComponent();
        }

        /// <summary>
        /// Show error message
        /// </summary>
        /// <param name="sErrorMessage"></param>
        public void ShowError(string sErrorMessage)
        {
            _sErrorMessage = sErrorMessage;

            //_ToolTip.BackColor = Color.DarkRed;
            //_ToolTip.ForeColor = Color.White;
            _errorToolTip.Show(sErrorMessage, this, 3, 0, 1000);

            /*ErrorLabel.Visible = true;
            ErrorLabel.Enabled = false;
            ErrorLabel.BorderStyle = BorderStyle.FixedSingle;
            //ErrorLabel.ReadOnly = true;
            //ErrorLabel.Multiline = true;
            //ErrorLabel.ScrollBars = ScrollBars.Horizontal;
            //ErrorLabel.Site
            ErrorLabel.Size = new Size(this.Width, this.Height);
            //ErrorLabel.Location = new Point( this.Left-10, this.Top - 13);
            ErrorLabel.BackColor = Color.DarkRed;
            ErrorLabel.Text = sErrorMessage;
            ErrorLabel.Font = new Font("Arial", 9, FontStyle.Bold);
            ErrorLabel.ForeColor = Color.Black;

            this.Controls.Add(ErrorLabel);
            */
            //tt.OwnerDraw = true;

            //tt.IsBalloon = true;
            //tt.UseAnimation = true;
            //tt.ToolTipTitle = "Error";

            //tt.Popup += new PopupEventHandler(CustomizedToolTip_Popup);
            //tt.Draw += new DrawToolTipEventHandler(CustomizedToolTip_Draw);


            //tt.Show(_sErrorMessage, this, 2,2, VisibleTime);
        }

        /// <summary>
        /// Show error message
        /// </summary>
        /// <param name="sErrorMessage"></param>
        public void ShowMessage(string sMessage)
        {
            _infoToolTip.Show(sMessage, this, 3, 0, 1000);
        }

        /// <summary>
        /// HideError
        /// </summary>
        public void HideError()
        {
            //ErrorLabel.Visible = false;
            _sErrorMessage = null;
        }

        /// <summary>
        /// TextBoxG_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxG_Click(object sender, EventArgs e)
        {
            //ErrorLabel.Visible = false;
        }

        /// <summary>
        /// Show error message at the top of the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxG_MouseHover(object sender, EventArgs e)
        {
            if (_sErrorMessage != null)
            {
                _errorToolTip.ShowAlways = true;
                _errorToolTip.Show( _sErrorMessage, this, 2, -this.Height+5);
            }
                
        }

        /// <summary>
        /// Error messages persists
        /// </summary>
        /// <param name="bTrue"></param>
        public void AlwaysShowError(bool bTrue)
        {
            _errorToolTip.ShowAlways = bTrue;
        }

        /// <summary>
        /// Info messages persists
        /// </summary>
        /// <param name="bTrue"></param>
        public void AlwaysShowInfo(bool bTrue)
        {
            _infoToolTip.ShowAlways = bTrue;
        }

        /// <summary>
        /// TextBoxG_MouseLeave - Hide error message at the top 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxG_MouseLeave(object sender, EventArgs e)
        {
            _errorToolTip.Hide(this);
        }
    }
}
