namespace Glx.Gui
{
    partial class AutoPanelG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoPanelG));
            this.panel_Pop = new System.Windows.Forms.Panel();
            this.panel_tittle = new System.Windows.Forms.Panel();
            this.label_Caption = new System.Windows.Forms.Label();
            this.panel_tittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Pop
            // 
            this.panel_Pop.BackColor = System.Drawing.Color.DarkGray;
            this.panel_Pop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Pop.BackgroundImage")));
            this.panel_Pop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Pop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_Pop.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Pop.Location = new System.Drawing.Point(0, 1);
            this.panel_Pop.Name = "panel_Pop";
            this.panel_Pop.Size = new System.Drawing.Size(36, 32);
            this.panel_Pop.TabIndex = 25;
            this.panel_Pop.Click += new System.EventHandler(this.panel_Pop_Click);
            // 
            // panel_tittle
            // 
            this.panel_tittle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_tittle.BackColor = System.Drawing.Color.DarkGray;
            this.panel_tittle.Controls.Add(this.label_Caption);
            this.panel_tittle.Controls.Add(this.panel_Pop);
            this.panel_tittle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_tittle.Location = new System.Drawing.Point(-1, -1);
            this.panel_tittle.Name = "panel_tittle";
            this.panel_tittle.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panel_tittle.Size = new System.Drawing.Size(244, 33);
            this.panel_tittle.TabIndex = 26;
            // 
            // label_Caption
            // 
            this.label_Caption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Caption.BackColor = System.Drawing.Color.DarkGray;
            this.label_Caption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Caption.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Caption.ForeColor = System.Drawing.Color.White;
            this.label_Caption.Location = new System.Drawing.Point(36, 1);
            this.label_Caption.Name = "label_Caption";
            this.label_Caption.Size = new System.Drawing.Size(208, 32);
            this.label_Caption.TabIndex = 26;
            this.label_Caption.Text = "Caption";
            this.label_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Caption.DoubleClick += new System.EventHandler(this.label_Caption_DoubleClick);
            this.label_Caption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_Caption_MouseMove);
            this.label_Caption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Caption_MouseDown);
            this.label_Caption.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_Caption_MouseUp);
            // 
            // AutoPanelG
            // 
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel_tittle);
            this.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.Size = new System.Drawing.Size(244, 183);
            this.DockChanged += new System.EventHandler(this.AutoPanelG_DockChanged);
            this.Resize += new System.EventHandler(this.AutoPanelG_Resize);
            this.panel_tittle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Pop;
        private System.Windows.Forms.Panel panel_tittle;
        private System.Windows.Forms.Label label_Caption;
    }
}
