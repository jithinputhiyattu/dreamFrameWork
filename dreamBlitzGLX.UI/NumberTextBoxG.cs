using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dreamBlitzGLX.UI
{

   public  class NumberTextBoxG : TextBox
    {
        /// <summary>
        /// Members
        /// </summary>
        private bool _bSupportFloatingPoint;
        private bool _bValidationRequired;

        /// <summary>
        /// Default Constructor
        /// </summary>

        public NumberTextBoxG()
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
            // NumberTextBoxG
            //
            this.TextChanged += new System.EventHandler(this.NumberTextBoxG_TextChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBoxG_KeyPress);
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

        private void NumberTextBoxG_KeyPress(object sender, KeyPressEventArgs keyPressEventArgs)
        {

            if (!char.IsControl(keyPressEventArgs.KeyChar) && !char.IsDigit(keyPressEventArgs.KeyChar) && keyPressEventArgs.KeyChar != '.')
            {

                keyPressEventArgs.Handled = true;

            }

            // only allow one decimal point

            else if ((keyPressEventArgs.KeyChar == '.' && (((sender as TextBox).Text.IndexOf('.') > -1) || (!_bSupportFloatingPoint))))
            {

                keyPressEventArgs.Handled = true;

            }

            // _bValidationRequired = false;

        }



        /// <summary>

        /// NumberTextBoxG_TextChanged

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="eventArgs"></param>

        private void NumberTextBoxG_TextChanged(object sender, EventArgs eventArgs)
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
            try
            {
                string sTextResult = "";
                for (int nIndex = 0; nIndex < TextLength; nIndex++)
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
            catch (Exception exception_ex)
            {
            }
          
        }
    }
}