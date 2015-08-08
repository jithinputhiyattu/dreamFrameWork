using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dreamBlitzGLX.UI
{
  public  class NumberComboBoxG : ComboBox
    {
        /// <summary>
        /// Members
        /// </summary>
        private bool _bSupportFloatingPoint;
        private bool _bValidationRequired;

        /// <summary>
        /// Default Constructor
        /// </summary>

        public NumberComboBoxG()
        {
            InitializeComponent();
            MaxLength = 12;
            _bSupportFloatingPoint = false;
            _bValidationRequired = true;
        }


        /// <summary>
        /// InitializeComponent
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            //
            // NumberComboBoxG
            //
            this.TextChanged += new System.EventHandler(this.NumberComboBoxG_TextChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberComboBoxG_KeyPress);
            this.ResumeLayout(false);
        }

        /// <summary>
        /// SupportFloatingPoint
        /// </summary>

        public bool SupportFloatingPoint
        {
            get
            {
                return _bSupportFloatingPoint;
            }
            set
            {
                if (value != _bSupportFloatingPoint)
                {
                    _bSupportFloatingPoint = value;
                }
            }
        }

        /// <summary>
        /// NumberTextBoxG_KeyPress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="keyPressEventArgs"></param>
        private void NumberComboBoxG_KeyPress(object sender, KeyPressEventArgs keyPressEventArgs)
        {
            if (!char.IsControl(keyPressEventArgs.KeyChar) && !char.IsDigit(keyPressEventArgs.KeyChar) && keyPressEventArgs.KeyChar != '.')
            {
                keyPressEventArgs.Handled = true;
            }
            // only allow one decimal point
            else if ((keyPressEventArgs.KeyChar == '.' && (((sender as ComboBox).Text.IndexOf('.') > -1) || (!_bSupportFloatingPoint))))
            {
                keyPressEventArgs.Handled = true;
            }
        }
        /// <summary>
        /// NumberTextBoxG_TextChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void NumberComboBoxG_TextChanged(object sender, EventArgs eventArgs)
        {
            if (_bValidationRequired)
            {
                ValidateText();
            }
            _bValidationRequired = true;
        }


        /// <summary>
        /// ValidateText
        /// </summary>
        public void ValidateText()
        {
            string sTextResult = "";
            for (int nIndex = 0; nIndex < Text.Length; nIndex++)
            {
                if (Char.IsDigit(Text[nIndex]) || '.' == Text[nIndex])
                {
                    if (('.' == Text[nIndex]) && (!_bSupportFloatingPoint))
                    {
                        continue;
                    }
                    if ((sTextResult.IndexOf('.') > -1) && ('.' == Text[nIndex]))
                    {
                        continue;
                    }
                    sTextResult += Text[nIndex];
                }
            }
            _bValidationRequired = false;
            Text = sTextResult;
        }
    }
}
