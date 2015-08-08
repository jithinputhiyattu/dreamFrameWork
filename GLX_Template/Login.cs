using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Glx.Gui;
using Glx.DB;
using Glx.Logger;

namespace Glx.App
{
    public partial class Login : LoginG
    {
        public Login()
        { 
            using (Log log = new Log("Glx.App.Login::Login()"))
            {
            	try
            	{
                    DBWrapper.InitializeDB("\\database\\GlxDB.mdf", true);
                    InitializeComponent();
            	}
            	catch (Exception ex)
            	{
            		log.Error(ex);
            	}
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //G.MsgBox("Hdsssl", "Success", MessageBoxButtons.AbortRetryIgnore);
            this.Hide();
            new MainForm().ShowDialog();
        }
    }
}
