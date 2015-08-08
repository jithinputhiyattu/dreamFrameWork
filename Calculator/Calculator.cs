using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Glx.Common;
using Glx.Common.Evaluator;

namespace Glx.AddIn
{
    public partial class Executable : UserControl
    {
        private string sEvalutionString = "";

        public Executable()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            sEvalutionString += b.Text;
            textBoxG1.Text = sEvalutionString;
        }

        private void buttonG_Equals_Click(object sender, EventArgs e)
        {
            textBoxG1.Text = EvalG.EvalToString(sEvalutionString);
            sEvalutionString = "";
        }

    }
}
