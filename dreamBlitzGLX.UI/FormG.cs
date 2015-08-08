using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dreamBlitzGLX.UI
{
    /// <summary>
    /// FormG
    /// </summary>
    public  class FormG : Form 
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public FormG()
        {
        }

        /// <summary>
        /// InitialiseComponentsG
        /// </summary>
        protected void InitialiseComponentsG()
        {

          this.Padding=  new System.Windows.Forms.Padding(3);
          this.BackColor = Color.Silver;
          this.WindowState = FormWindowState.Normal;
          this.FormBorderStyle = FormBorderStyle.None;
          this.ShowInTaskbar = false;
          this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// ShowEx
        /// </summary>
        public virtual void ShowEx()
        {
            this.ShowDialog();
        }

        /// <summary>
        /// HideEx()
        /// </summary>
        public virtual void HideEx()
        {
            this.Hide();
        }

        /// <summary>
        /// PrintDataG()
        /// </summary>
        public virtual void PrintDataG()
        {

        }

    }
}
