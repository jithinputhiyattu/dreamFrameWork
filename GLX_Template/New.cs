using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Glx.Gui;
using Glx.Common;
using Glx.DB;
using Glx.Logger;
using System.Reflection;
using System.Data.SqlClient;

namespace Glx.App
{
    public partial class New : FormG
    {
        Timer timer1;
        public New()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 16;
            timer1.Tick += new EventHandler(timer1_Tick);
            //panelG2.BackColor = Color.Aqua;
            mWidth = panelG2.Width;

            DBWrapper.InitializeDB("\\database\\GlxDB.mdf", true);
        }

        int mDir = 0;
        int mWidth;
        void timer1_Tick(object sender, EventArgs e)
        {
            int width = panelG2.Width + mDir;
            if (width >= mWidth)
            {
                width = mWidth;
                timer1.Enabled = false;
            }
            else if (width < Math.Abs(mDir))
            {
                width = 0;
                timer1.Enabled = false;
                panelG2.Visible = false;
            }
            panelG2.Width = width;
        }
        private void buttonG5_Click(object sender, EventArgs e)
        {
            mDir = panelG2.Visible ? -5 : 5;
            panelG2.Visible = true;
            timer1.Enabled = true;
        }

        private void buttonG12_Click(object sender, EventArgs e)
        {
            // GlxCalc.plg file is originally GlxCalc.dll. it just renamed to GlxCalc.plg
            /*Assembly assembly = Assembly.LoadFile(@"D:\dreamSafe\Devolopement\Template\GLX_Template\Bin\GlxCalc.dll");
            object o;
            Type myType = assembly.GetType("Glx.AddIn.Calc.Icon");



            for (int i = 0; i < 1000; i += 50)
            {
                // buttonG3
                // 

                o = Activator.CreateInstance(myType);


                UserControl _Calc = (UserControl)o;

                _Calc.Location = new System.Drawing.Point(0, i);
                //_Calc.Size = new System.Drawing.Size(100, 50);
                _Calc.TabIndex = i;

                panelG2.Controls.Add(_Calc);
            }*/
        }

        private void autoPanelG4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonG3_Click(object sender, EventArgs e)
        {
            string sCalcAddInFile = G.GetAppPath() + "\\GlxCalc.dll";
            

            for (int i = 0; i < 1000; i += 50)
            {
                UserControl _Calc = AddInG.GetAddInIconFromDll(sCalcAddInFile);
                _Calc.Location = new System.Drawing.Point(0, i);
                //_Calc.Size = new System.Drawing.Size(100, 50);
                _Calc.TabIndex = i;
                panelG2.Controls.Add(_Calc);
            }
        }

        private void buttonG4_Click(object sender, EventArgs e)
        {
            AddInG.LoadAddInsToPanel(panelG5);
        }

        private void buttonG20_Click(object sender, EventArgs e)
        {
            textBoxG3.ShowError("Internal Error occured in textbox. please stand by or try later");
        }

        private void buttonG21_Click(object sender, EventArgs e)
        {
            textBoxG3.HideError();
        }

        private void buttonG22_Click(object sender, EventArgs e)
        {
            textBoxG2.ShowError("Internal Error");
        }

        private void buttonG23_Click(object sender, EventArgs e)
        {
            textBoxG2.HideError();
        }

        private void buttonG24_Click(object sender, EventArgs e)
        {
            textBoxG3.ShowMessage("Sample Message");
        }

        private void buttonG25_Click(object sender, EventArgs e)
        {
            textBoxG3.HideError();
        }

        private void buttonG_Submit_Click(object sender, EventArgs e)
        {
            if (textBoxG2.Text != "io")
            {
                textBoxG1.ShowError("User not found");
                textBoxG2.ShowError("Enter the password 'io' ");
            }
            else
            {
                textBoxG1.HideError();
                textBoxG2.HideError();
                textBoxG2.ShowMessage("Correct Password");
            }

        }

        private void textBoxG3_Click(object sender, EventArgs e)
        {
            ToolTipG toolTip = new ToolTipG();

                 //toolTip.UseAnimation = true;

                //toolTip.AutoPopDelay = 500;

                //toolTip.AutomaticDelay = 500;

                toolTip.Show("hi there", textBoxG3, 2000);
        }

        private void buttonG8_Click(object sender, EventArgs e)
        {
            using (Log log = new Log("Glx.App.Main::buttonG2_Click()"))
            {
                try
                {
                    Table tNames = new Table("Name,Age");
                    string sQuerry = "select name, Age from Names";
                    SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(sQuerry);
                    if (sqlDataReader != null)
                    {
                        while (sqlDataReader.Read())
                        {
                            string sName = sqlDataReader.GetString(tNames / "name");
                            int nAge = sqlDataReader.GetInt32(tNames / "Age");

                            MessageBox.Show(sName + " is " + nAge.ToString() + " years old");
                        }
                        sqlDataReader.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    log.ErrorEx(ex);
                }
            }       
        }

        private void buttonG10_Click(object sender, EventArgs e)
        {
            DDL.CreateTable("Sample", "col1,int,col2,int,col3,varchar(10),col4,int,col5,int");
        }

        private void buttonG9_Click(object sender, EventArgs e)
        {
            DDL.InsertInto("Sample", "col1,col2", "10,20");
        }


    }
}
