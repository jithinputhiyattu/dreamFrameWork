using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Glx.AddIn
{
    public partial class Icon : UserControl
    {
        public Icon()
        {
            InitializeComponent();
        }

        private void buttonG_Launch_Click(object sender, EventArgs e)
        {
            CalculatorForm cForm = new CalculatorForm();
            cForm.ShowDialog();
        }
    }
}
