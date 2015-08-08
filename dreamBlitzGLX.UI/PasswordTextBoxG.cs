using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GlilooX.UI
{

   public  class PasswordTextBoxG : Panel
    {
        /// <summary>
        /// Members
        /// </summary>
       private bool _bValidationRequired;
       Label    _ErrorLabel;
       TextBox  _PasswordTextBox;
        /// <summary>
        /// Default Constructor
        /// </summary>

        public PasswordTextBoxG()
        {
            InitializeComponent();
            _PasswordTextBox.MaxLength = 25;
            _bValidationRequired = true;
        }


        /// <summary>
        /// InitializeComponent
        /// </summary>
        private void InitializeComponent()
        {
            this._ErrorLabel = new System.Windows.Forms.Label();
            this._PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _ErrorLabel
            // 
            this._ErrorLabel.AutoSize = true;
            this._ErrorLabel.BackColor = System.Drawing.Color.White;
            this._ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this._ErrorLabel.Location = new System.Drawing.Point(25, 3);
            this._ErrorLabel.Name = "_ErrorLabel";
            this._ErrorLabel.Size = new System.Drawing.Size(174, 13);
            this._ErrorLabel.TabIndex = 0;
            this._ErrorLabel.Text = "*Special characters are not allowed";
            this._ErrorLabel.Visible = false;
            // 
            // _PasswordTextBox
            // 
            this._PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._PasswordTextBox.Location = new System.Drawing.Point(0, 80);
            this._PasswordTextBox.Name = "_PasswordTextBox";
            this._PasswordTextBox.PasswordChar = '*';
            this._PasswordTextBox.ShortcutsEnabled = false;
            this._PasswordTextBox.Size = new System.Drawing.Size(200, 20);
            this._PasswordTextBox.TabIndex = 1;
            this._PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBoxG_TextChanged);
            this._PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBoxG_KeyPress);
            // 
            // PasswordTextBoxG
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this._ErrorLabel);
            this.Controls.Add(this._PasswordTextBox);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        /// <summary>

        /// NumberTextBoxG_KeyPress

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="keyPressEventArgs"></param>

        private void PasswordTextBoxG_KeyPress(object sender, KeyPressEventArgs keyPressEventArgs)
        {
            if (char.IsSymbol(keyPressEventArgs.KeyChar) || keyPressEventArgs.KeyChar =='\'')
            {
                keyPressEventArgs.Handled = true;
                _ErrorLabel.Visible = true;
            }
            else
            {
                _ErrorLabel.Visible = false;
            }
        }


        /// <summary>

        /// NumberTextBoxG_TextChanged

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="eventArgs"></param>

        private void PasswordTextBoxG_TextChanged(object sender, EventArgs eventArgs)
        {
            /*if (_bValidationRequired)
            {
                ValidateText();
            }
            _bValidationRequired = true;*/
        }

        public override string Text
        {
            get
            {
                return _PasswordTextBox.Text;
            }
            set
            {
                _PasswordTextBox.Text = value;
            }
        }
        /// <summary>
        /// ValidateText
        /// </summary>
        public void ValidateText()
        {
            string sTextResult = "";
            for (int nIndex = 0; nIndex < _PasswordTextBox.TextLength; nIndex++)
            {
                if ( !( Char.IsSymbol(Text[nIndex]) ))
                {
                    sTextResult += Text[nIndex];
                }
            }
            _bValidationRequired = false;
            Text = sTextResult;
        }

       //public Label ErrorLabel
       //{
       //    get
       //    {
       //        return _ErrorLabel;
       //    }
       //    set
       //    {
       //        if (value != _ErrorLabel )
       //        {
       //            _ErrorLabel = value;
       //        }
       //    }
       //}


    }
}