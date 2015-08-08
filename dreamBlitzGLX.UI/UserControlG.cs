using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dreamBlitzGLX.UI
{
    public class UserControlG : UserControl
    {
        public UserControlG()
        {
     
        }
        /// <summary>
        /// RefreshEx
        /// </summary>
        public virtual void RefreshEx()
        {
        
        }
        /// <summary>
        /// MiniRefresh
        /// </summary>
        public virtual void MiniRefresh()
        {

        }
        /// <summary>
        /// ShowEx
        /// </summary>
        public virtual void ShowEx()
        {
            this.Show();
            RefreshEx();
        }
        /// <summary>
        /// HideEx
        /// </summary>
        public virtual void HideEx()
        {
            this.Hide();
        }

        /// <summary>
        /// PrintDataG
        /// </summary>
        public virtual void PrintDataG()
        {

        }

    }
}
