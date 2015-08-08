namespace Glx.Gui
{
    partial class HidePanelG
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
            this.panel_Button = new System.Windows.Forms.Panel();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label_Caption = new System.Windows.Forms.Label();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Button
            // 
            this.panel_Button.BackgroundImage = global::Glx.Gui.Properties.Resources.PanelLeft;
            this.panel_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Button.Location = new System.Drawing.Point(127, 0);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(38, 31);
            this.panel_Button.TabIndex = 0;
            this.panel_Button.Click += new System.EventHandler(this.panel_Button_Click);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.Silver;
            this.panel_Title.Controls.Add(this.label_Caption);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(127, 31);
            this.panel_Title.TabIndex = 1;
            // 
            // label_Caption
            // 
            this.label_Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Caption.Location = new System.Drawing.Point(0, 0);
            this.label_Caption.Name = "label_Caption";
            this.label_Caption.Size = new System.Drawing.Size(127, 31);
            this.label_Caption.TabIndex = 0;
            this.label_Caption.Text = "Caption";
            this.label_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HidePanelG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_Button);
            this.DoubleBuffered = true;
            this.Name = "HidePanelG";
            this.Size = new System.Drawing.Size(165, 31);
            this.panel_Title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Button;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label label_Caption;
    }
}
