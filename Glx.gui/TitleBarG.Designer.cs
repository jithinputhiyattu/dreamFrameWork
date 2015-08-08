namespace Glx.Gui
{
    partial class TitleBarG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleBarG));
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.panel_Control_Box = new System.Windows.Forms.Panel();
            this.panel_Minimize = new Glx.Gui.PanelG();
            this.panel_Maximize = new System.Windows.Forms.Panel();
            this.panel_Close = new System.Windows.Forms.Panel();
            this.label_Form_Name = new System.Windows.Forms.Label();
            this.panel_TitleBar.SuspendLayout();
            this.panel_Control_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_TitleBar.BackgroundImage")));
            this.panel_TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_TitleBar.Controls.Add(this.panel_Control_Box);
            this.panel_TitleBar.Controls.Add(this.label_Form_Name);
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(741, 37);
            this.panel_TitleBar.TabIndex = 25;
            this.panel_TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_TitleBar_MouseMove);
            this.panel_TitleBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel_TitleBar_MouseDoubleClick);
            this.panel_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TitleBar_MouseDown);
            this.panel_TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_TitleBar_MouseUp);
            // 
            // panel_Control_Box
            // 
            this.panel_Control_Box.BackColor = System.Drawing.Color.Transparent;
            this.panel_Control_Box.Controls.Add(this.panel_Minimize);
            this.panel_Control_Box.Controls.Add(this.panel_Maximize);
            this.panel_Control_Box.Controls.Add(this.panel_Close);
            this.panel_Control_Box.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Control_Box.Location = new System.Drawing.Point(584, 0);
            this.panel_Control_Box.Name = "panel_Control_Box";
            this.panel_Control_Box.Size = new System.Drawing.Size(157, 37);
            this.panel_Control_Box.TabIndex = 16;
            // 
            // panel_Minimize
            // 
            this.panel_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.panel_Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Minimize.BackgroundImage")));
            this.panel_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Minimize.Location = new System.Drawing.Point(7, 0);
            this.panel_Minimize.Name = "panel_Minimize";
            this.panel_Minimize.Size = new System.Drawing.Size(50, 37);
            this.panel_Minimize.TabIndex = 25;
            this.panel_Minimize.MouseLeave += new System.EventHandler(this.panel_Minimize_MouseLeave);
            this.panel_Minimize.Click += new System.EventHandler(this.panel_Minimize_Click);
            this.panel_Minimize.MouseHover += new System.EventHandler(this.panel_Minimize_MouseHover);
            // 
            // panel_Maximize
            // 
            this.panel_Maximize.BackColor = System.Drawing.Color.Transparent;
            this.panel_Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Maximize.BackgroundImage")));
            this.panel_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Maximize.Location = new System.Drawing.Point(57, 0);
            this.panel_Maximize.Name = "panel_Maximize";
            this.panel_Maximize.Size = new System.Drawing.Size(50, 37);
            this.panel_Maximize.TabIndex = 26;
            this.panel_Maximize.MouseLeave += new System.EventHandler(this.panel_Maximize_MouseLeave);
            this.panel_Maximize.Click += new System.EventHandler(this.panel_Maximize_Click);
            this.panel_Maximize.MouseHover += new System.EventHandler(this.panel_Maximize_MouseHover);
            // 
            // panel_Close
            // 
            this.panel_Close.BackColor = System.Drawing.Color.Transparent;
            this.panel_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Close.BackgroundImage")));
            this.panel_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Close.Location = new System.Drawing.Point(107, 0);
            this.panel_Close.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Close.Name = "panel_Close";
            this.panel_Close.Size = new System.Drawing.Size(50, 37);
            this.panel_Close.TabIndex = 27;
            this.panel_Close.MouseLeave += new System.EventHandler(this.panel_Close_MouseLeave);
            this.panel_Close.Click += new System.EventHandler(this.panel_Close_Click);
            this.panel_Close.MouseHover += new System.EventHandler(this.panel_Close_MouseHover);
            // 
            // label_Form_Name
            // 
            this.label_Form_Name.AutoSize = true;
            this.label_Form_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Form_Name.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Form_Name.ForeColor = System.Drawing.Color.White;
            this.label_Form_Name.Location = new System.Drawing.Point(6, 6);
            this.label_Form_Name.Name = "label_Form_Name";
            this.label_Form_Name.Size = new System.Drawing.Size(39, 18);
            this.label_Form_Name.TabIndex = 0;
            this.label_Form_Name.Text = "Title";
            this.label_Form_Name.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_Form_Name_MouseDoubleClick);
            // 
            // TitleBarG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_TitleBar);
            this.Name = "TitleBarG";
            this.Size = new System.Drawing.Size(741, 37);
            this.panel_TitleBar.ResumeLayout(false);
            this.panel_TitleBar.PerformLayout();
            this.panel_Control_Box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel_Control_Box;
        protected PanelG panel_Minimize;
        protected System.Windows.Forms.Panel panel_Maximize;
        protected System.Windows.Forms.Panel panel_Close;
        protected System.Windows.Forms.Label label_Form_Name;
        protected System.Windows.Forms.Panel panel_TitleBar;
    }
}
