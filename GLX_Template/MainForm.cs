
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Glx.Gui;
using System.Data.SqlClient;
using Glx.DB;
using Glx.Logger;
using Glx.Secure;
using Glx.Common;
using System.Reflection;
//using Glx.AddIn.Calc;


namespace Glx.App
{
    public partial class MainForm : FormG
    {
        public MainForm()
        {     
            using (Log log = new Log("Glx.App.Main::Main()"))
            {
            	try
            	{
            		InitializeComponent();
            	}
            	catch (Exception ex)
            	{
            		log.Error(ex);
            	}
            }
        }

        private void buttonG1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new AnotherForm().ShowDialog();
        }

        private void panel_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonG2_Click(object sender, EventArgs e)
        {
            using (Log log = new Log("Glx.App.Main::buttonG2_Click()"))
            {
            	try
            	{
                    Table tNames = new Table( "Name,Age" );
                    string sQuerry = "select name, Age from Names";
            		SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(sQuerry);
                    while (sqlDataReader.Read())
                    {
                        string sName = sqlDataReader.GetString(tNames/"name");
                        int nAge = sqlDataReader.GetInt32(tNames/"Age");

                        MessageBox.Show(sName + " is " + nAge.ToString() + " years old");
                    }
                    sqlDataReader.Close();
            	}
            	catch (Exception ex)
            	{
            		log.ErrorEx(ex);
            	}
            }       
        }

        private void buttonG3_Click(object sender, EventArgs e)
        {
            DDL.CreateTable( "Sample", "col1,int,col2,int,col3,varchar(10),col4,int,col5,int");
        }

        private void buttonG4_Click(object sender, EventArgs e)
        {
            DDL.InsertInto("Sample", "col1,col2", "10,20");
        }

        private void buttonG5_Click(object sender, EventArgs e)
        {
            // GlxCalc.plg file is originally GlxCalc.dll. it just renamed to GlxCalc.plg
            Assembly assembly = Assembly.LoadFile(@"D:\dreamSafe\Devolopement\Template\GLX_Template\Bin\GlxCalc.dll");
            object o;
            Type myType = assembly.GetType("Glx.AddIn.Calc.Icon");
            


            for (int i = 100; i < 1000; i += 50)
            {
                // buttonG3
                // 

                o = Activator.CreateInstance(myType);


                UserControl _Calc = (UserControl)o;

                _Calc.Location = new System.Drawing.Point(0, i);
                //_Calc.Size = new System.Drawing.Size(100, 50);
                _Calc.TabIndex = i;

                panelG2.Controls.Add(_Calc);
            }



            //panelG1.Controls.Add(_Calc);
            //autoPanelG1.Width = _Calc.Width+8;
            //autoPanelG1.Height = _Calc.Height+45;
          
        }

        private void buttonG6_Click(object sender, EventArgs e)
        {
            // GlxCalc.plg file is originally GlxCalc.dll. it just renamed to GlxCalc.plg
            Assembly assembly = Assembly.LoadFile(@"D:\dreamSafe\Devolopement\Template\GLX_Template\Bin\GlxCalc.dll");
            object o;
            Type myType = assembly.GetType("Glx.AddIn.Calc.Icon");


            o = Activator.CreateInstance(myType);


             UserControl _Calc = (UserControl)o;



            panelG1.Controls.Add(_Calc);
            autoPanelG1.Width = _Calc.Width+8;
            autoPanelG1.Height = _Calc.Height+45;
          
        }
      
    }
}
