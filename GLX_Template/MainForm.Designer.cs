namespace Glx.App
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleBarG1 = new Glx.Gui.TitleBarG();
            this.sidePanelG1 = new Glx.Gui.SidePanelG();
            this.buttonG5 = new Glx.Gui.ButtonG();
            this.buttonG6 = new Glx.Gui.ButtonG();
            this.buttonG4 = new Glx.Gui.ButtonG();
            this.autoPanelG1 = new Glx.Gui.AutoPanelG();
            this.panelG1 = new Glx.Gui.PanelG();
            this.buttonG2 = new Glx.Gui.ButtonG();
            this.buttonG3 = new Glx.Gui.ButtonG();
            this.buttonG1 = new Glx.Gui.ButtonG();
            this.panelG2 = new Glx.Gui.SidePanelG();
            this.autoPanelG3 = new Glx.Gui.AutoPanelG();
            this.sidePanelG1.SuspendLayout();
            this.autoPanelG1.SuspendLayout();
            this.autoPanelG3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBarG1
            // 
            this.titleBarG1.CloseButtonAction = Glx.Gui.TitleBarG.eCloseButtonAction.Exit;
            this.titleBarG1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarG1.Location = new System.Drawing.Point(0, 0);
            this.titleBarG1.Name = "titleBarG1";
            this.titleBarG1.Size = new System.Drawing.Size(963, 38);
            this.titleBarG1.TabIndex = 1;
            this.titleBarG1.Title = "Main Form";
            // 
            // sidePanelG1
            // 
            this.sidePanelG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sidePanelG1.Controls.Add(this.buttonG5);
            this.sidePanelG1.Controls.Add(this.buttonG6);
            this.sidePanelG1.Controls.Add(this.buttonG4);
            this.sidePanelG1.Controls.Add(this.autoPanelG1);
            this.sidePanelG1.Controls.Add(this.buttonG2);
            this.sidePanelG1.Controls.Add(this.buttonG3);
            this.sidePanelG1.Controls.Add(this.buttonG1);
            this.sidePanelG1.Location = new System.Drawing.Point(197, 40);
            this.sidePanelG1.Name = "sidePanelG1";
            this.sidePanelG1.Size = new System.Drawing.Size(757, 453);
            this.sidePanelG1.TabIndex = 244;
            // 
            // buttonG5
            // 
            this.buttonG5.BackColor = System.Drawing.Color.Transparent;
            this.buttonG5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonG5.BackgroundImage")));
            this.buttonG5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonG5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonG5.Font = new System.Drawing.Font("Arial", 12.75F);
            this.buttonG5.ForeColor = System.Drawing.Color.White;
            this.buttonG5.Location = new System.Drawing.Point(52, 44);
            this.buttonG5.Name = "buttonG5";
            this.buttonG5.Size = new System.Drawing.Size(636, 33);
            this.buttonG5.TabIndex = 29;
            this.buttonG5.Text = "Load Calculator launch icon from Glxcalc.dll to sidebar";
            this.buttonG5.UseVisualStyleBackColor = true;
            this.buttonG5.Click += new System.EventHandler(this.buttonG5_Click);
            // 
            // buttonG6
            // 
            this.buttonG6.BackColor = System.Drawing.Color.Transparent;
            this.buttonG6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonG6.BackgroundImage")));
            this.buttonG6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonG6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonG6.Font = new System.Drawing.Font("Arial", 12.75F);
            this.buttonG6.ForeColor = System.Drawing.Color.White;
            this.buttonG6.Location = new System.Drawing.Point(52, 83);
            this.buttonG6.Name = "buttonG6";
            this.buttonG6.Size = new System.Drawing.Size(636, 33);
            this.buttonG6.TabIndex = 31;
            this.buttonG6.Text = "Load Calculator launch icon from Glxcalc.dll to AutopanelG";
            this.buttonG6.UseVisualStyleBackColor = true;
            this.buttonG6.Click += new System.EventHandler(this.buttonG6_Click);
            // 
            // buttonG4
            // 
            this.buttonG4.BackColor = System.Drawing.Color.Transparent;
            this.buttonG4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonG4.BackgroundImage")));
            this.buttonG4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonG4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonG4.Font = new System.Drawing.Font("Arial", 12.75F);
            this.buttonG4.ForeColor = System.Drawing.Color.White;
            this.buttonG4.Location = new System.Drawing.Point(284, 216);
            this.buttonG4.Name = "buttonG4";
            this.buttonG4.Size = new System.Drawing.Size(404, 47);
            this.buttonG4.TabIndex = 28;
            this.buttonG4.Text = "Insert";
            this.buttonG4.UseVisualStyleBackColor = true;
            this.buttonG4.Click += new System.EventHandler(this.buttonG4_Click);
            // 
            // autoPanelG1
            // 
            this.autoPanelG1.BackColor = System.Drawing.Color.DarkGray;
            this.autoPanelG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoPanelG1.Caption = "AutopanelG";
            this.autoPanelG1.ControlboxPosition = Glx.Gui.AutoPanelG.eControlBoxPositions.Top;
            this.autoPanelG1.Controls.Add(this.panelG1);
            this.autoPanelG1.Location = new System.Drawing.Point(52, 122);
            this.autoPanelG1.Name = "autoPanelG1";
            this.autoPanelG1.Size = new System.Drawing.Size(215, 268);
            this.autoPanelG1.TabIndex = 28;
            // 
            // panelG1
            // 
            this.panelG1.BackColor = System.Drawing.Color.DarkGray;
            this.panelG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelG1.Location = new System.Drawing.Point(3, 37);
            this.panelG1.Name = "panelG1";
            this.panelG1.Size = new System.Drawing.Size(208, 216);
            this.panelG1.TabIndex = 27;
            // 
            // buttonG2
            // 
            this.buttonG2.BackColor = System.Drawing.Color.Transparent;
            this.buttonG2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonG2.BackgroundImage")));
            this.buttonG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonG2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonG2.Font = new System.Drawing.Font("Arial", 12.75F);
            this.buttonG2.ForeColor = System.Drawing.Color.White;
            this.buttonG2.Location = new System.Drawing.Point(284, 269);
            this.buttonG2.Name = "buttonG2";
            this.buttonG2.Size = new System.Drawing.Size(404, 47);
            this.buttonG2.TabIndex = 26;
            this.buttonG2.Text = "DB";
            this.buttonG2.UseVisualStyleBackColor = true;
            this.buttonG2.Click += new System.EventHandler(this.buttonG2_Click);
            // 
            // buttonG3
            // 
            this.buttonG3.BackColor = System.Drawing.Color.Transparent;
            this.buttonG3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonG3.BackgroundImage")));
            this.buttonG3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonG3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonG3.Font = new System.Drawing.Font("Arial", 12.75F);
            this.buttonG3.ForeColor = System.Drawing.Color.White;
            this.buttonG3.Location = new System.Drawing.Point(284, 163);
            this.buttonG3.Name = "buttonG3";
            this.buttonG3.Size = new System.Drawing.Size(404, 47);
            this.buttonG3.TabIndex = 27;
            this.buttonG3.Text = "Create Table";
            this.buttonG3.UseVisualStyleBackColor = true;
            this.buttonG3.Click += new System.EventHandler(this.buttonG3_Click);
            // 
            // buttonG1
            // 
            this.buttonG1.BackColor = System.Drawing.Color.Transparent;
            this.buttonG1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonG1.BackgroundImage")));
            this.buttonG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonG1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonG1.Font = new System.Drawing.Font("Arial", 12.75F);
            this.buttonG1.ForeColor = System.Drawing.Color.White;
            this.buttonG1.Location = new System.Drawing.Point(283, 122);
            this.buttonG1.Name = "buttonG1";
            this.buttonG1.Size = new System.Drawing.Size(405, 35);
            this.buttonG1.TabIndex = 25;
            this.buttonG1.Text = "Goto Another form";
            this.buttonG1.UseVisualStyleBackColor = true;
            this.buttonG1.Click += new System.EventHandler(this.buttonG1_Click);
            // 
            // panelG2
            // 
            this.panelG2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelG2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelG2.Location = new System.Drawing.Point(0, 0);
            this.panelG2.Name = "panelG2";
            this.panelG2.Size = new System.Drawing.Size(158, 661);
            this.panelG2.TabIndex = 248;
            // 
            // autoPanelG3
            // 
            this.autoPanelG3.BackColor = System.Drawing.Color.DarkGray;
            this.autoPanelG3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoPanelG3.Caption = "Caption";
            this.autoPanelG3.ControlboxPosition = Glx.Gui.AutoPanelG.eControlBoxPositions.Top;
            this.autoPanelG3.Controls.Add(this.panelG2);
            this.autoPanelG3.Controls.Add(this.sidePanelG1);
            this.autoPanelG3.Location = new System.Drawing.Point(0, 44);
            this.autoPanelG3.Name = "autoPanelG3";
            this.autoPanelG3.Size = new System.Drawing.Size(963, 663);
            this.autoPanelG3.TabIndex = 249;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 707);
            this.Controls.Add(this.autoPanelG3);
            this.Controls.Add(this.titleBarG1);
            this.Name = "MainForm";
            this.sidePanelG1.ResumeLayout(false);
            this.autoPanelG1.ResumeLayout(false);
            this.autoPanelG3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Glx.Gui.TitleBarG titleBarG1;
        private Glx.Gui.SidePanelG sidePanelG1;
        private Glx.Gui.ButtonG buttonG5;
        private Glx.Gui.ButtonG buttonG6;
        private Glx.Gui.ButtonG buttonG4;
        private Glx.Gui.AutoPanelG autoPanelG1;
        private Glx.Gui.PanelG panelG1;
        private Glx.Gui.ButtonG buttonG2;
        private Glx.Gui.ButtonG buttonG3;
        private Glx.Gui.ButtonG buttonG1;
        private Glx.Gui.SidePanelG panelG2;
        private Glx.Gui.AutoPanelG autoPanelG3;


    }
}