namespace Glx.Gui
{
    partial class SidePanelG
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
            this.panel_SideBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_SideBar
            // 
            this.panel_SideBar.BackColor = System.Drawing.Color.DarkGray;
            this.panel_SideBar.BackgroundImage = global::Glx.Gui.Properties.Resources.PanelLeft;
            this.panel_SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_SideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_SideBar.Location = new System.Drawing.Point(0, 0);
            this.panel_SideBar.Name = "panel_SideBar";
            this.panel_SideBar.Size = new System.Drawing.Size(32, 28);
            this.panel_SideBar.TabIndex = 0;
            this.panel_SideBar.Click += new System.EventHandler(this.panel_Sidebar_Click);
            // 
            // SidePanelG
            // 
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel_SideBar);
            this.Padding = new System.Windows.Forms.Padding(33, 1, 1, 1);
            this.Size = new System.Drawing.Size(173, 415);
            this.Resize += new System.EventHandler(this.SidePanelG_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_SideBar;




    }
}
