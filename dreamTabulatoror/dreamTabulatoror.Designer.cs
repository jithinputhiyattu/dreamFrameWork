namespace dreamTabulatoror
{
    partial class dreamTabulatoror
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
            this.titleBarG1 = new Glx.Gui.TitleBarG();
            this.numberTextBoxG1 = new dreamBlitzGLX.UI.NumberTextBoxG();
            this.gelButton1 = new dreamBlitzGLX.UI.GelButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gelButton2 = new dreamBlitzGLX.UI.GelButton();
            this.panelG1 = new Glx.Gui.PanelG();
            this.panelG2 = new Glx.Gui.PanelG();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.panelG2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBarG1
            // 
            this.titleBarG1.CloseButtonAction = Glx.Gui.TitleBarG.eCloseButtonAction.Close;
            this.titleBarG1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarG1.Location = new System.Drawing.Point(0, 0);
            this.titleBarG1.Name = "titleBarG1";
            this.titleBarG1.Size = new System.Drawing.Size(574, 37);
            this.titleBarG1.TabIndex = 0;
            this.titleBarG1.Title = "The dreamTabulator";
            // 
            // numberTextBoxG1
            // 
            this.numberTextBoxG1.Location = new System.Drawing.Point(16, 22);
            this.numberTextBoxG1.MaxLength = 2;
            this.numberTextBoxG1.Name = "numberTextBoxG1";
            this.numberTextBoxG1.Size = new System.Drawing.Size(51, 20);
            this.numberTextBoxG1.SupportFloatingPoint = false;
            this.numberTextBoxG1.TabIndex = 2;
            this.numberTextBoxG1.TextChanged += new System.EventHandler(this.numberTextBoxG1_TextChanged);
            // 
            // gelButton1
            // 
            this.gelButton1.Enabled = false;
            this.gelButton1.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(198)))), ((int)(((byte)(241)))));
            this.gelButton1.Location = new System.Drawing.Point(73, 22);
            this.gelButton1.Name = "gelButton1";
            this.gelButton1.Size = new System.Drawing.Size(63, 23);
            this.gelButton1.TabIndex = 3;
            this.gelButton1.Text = "Add";
            this.gelButton1.UseVisualStyleBackColor = true;
            this.gelButton1.Click += new System.EventHandler(this.gelButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.gelButton2);
            this.groupBox1.Controls.Add(this.gelButton1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.numberTextBoxG1);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 189);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mintems";
            // 
            // gelButton2
            // 
            this.gelButton2.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(198)))), ((int)(((byte)(241)))));
            this.gelButton2.Location = new System.Drawing.Point(16, 149);
            this.gelButton2.Name = "gelButton2";
            this.gelButton2.Size = new System.Drawing.Size(120, 23);
            this.gelButton2.TabIndex = 5;
            this.gelButton2.Text = "Submit";
            this.gelButton2.UseVisualStyleBackColor = true;
            this.gelButton2.Click += new System.EventHandler(this.gelButton2_Click);
            // 
            // panelG1
            // 
            this.panelG1.BackColor = System.Drawing.Color.Transparent;
            this.panelG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelG1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelG1.Location = new System.Drawing.Point(0, 345);
            this.panelG1.Name = "panelG1";
            this.panelG1.Size = new System.Drawing.Size(574, 48);
            this.panelG1.TabIndex = 6;
            // 
            // panelG2
            // 
            this.panelG2.BackColor = System.Drawing.Color.Transparent;
            this.panelG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelG2.Controls.Add(this.groupBox1);
            this.panelG2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelG2.Location = new System.Drawing.Point(0, 37);
            this.panelG2.Name = "panelG2";
            this.panelG2.Size = new System.Drawing.Size(186, 308);
            this.panelG2.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(186, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(388, 308);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Column A";
            // 
            // dreamTabulatoror
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 393);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panelG2);
            this.Controls.Add(this.panelG1);
            this.Controls.Add(this.titleBarG1);
            this.MinimizeBox = false;
            this.Name = "dreamTabulatoror";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The dreamTabulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelG2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Glx.Gui.TitleBarG titleBarG1;
        private dreamBlitzGLX.UI.NumberTextBoxG numberTextBoxG1;
        private dreamBlitzGLX.UI.GelButton gelButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private dreamBlitzGLX.UI.GelButton gelButton2;
        private Glx.Gui.PanelG panelG1;
        private Glx.Gui.PanelG panelG2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

