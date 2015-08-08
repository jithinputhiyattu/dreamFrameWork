/***
 * 
 * @Filename        :   FormG.cs
 * @Description     :   Custom form
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/02/23:48
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
    /// FormG class
    /// </summary>
    public partial class FormG : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FormG()
        {
            InitializeComponent();        
        }

        /// <summary>
        /// Load event of form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormG_Load(object sender, EventArgs e)
        {
            this.Text = "";
        }
    }
}
