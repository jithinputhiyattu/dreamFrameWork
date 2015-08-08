namespace Glx.Gui
{
    partial class TextBoxG
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TextBoxG
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Size = new System.Drawing.Size(144, 23);
            this.MouseLeave += new System.EventHandler(this.TextBoxG_MouseLeave);
            this.Click += new System.EventHandler(this.TextBoxG_Click);
            this.MouseHover += new System.EventHandler(this.TextBoxG_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
