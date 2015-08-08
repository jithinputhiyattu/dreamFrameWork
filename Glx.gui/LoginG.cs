/***
 * 
 * @Filename        :   LoginG.cs
 * @Description     :   Login form template
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
    /// LoginG class
    /// </summary>
    public partial class LoginG : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LoginG()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cancel button action : Close()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
