namespace Glx.AddIn
{
    partial class Icon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Icon));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonG_Launch = new Glx.Gui.ButtonG();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonG_Launch
            // 
            this.buttonG_Launch.BackColor = System.Drawing.Color.Transparent;
            this.buttonG_Launch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonG_Launch.BackgroundImage")));
            this.buttonG_Launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonG_Launch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonG_Launch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonG_Launch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonG_Launch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonG_Launch.Font = new System.Drawing.Font("Arial", 12.75F);
            this.buttonG_Launch.ForeColor = System.Drawing.Color.White;
            this.buttonG_Launch.Location = new System.Drawing.Point(59, 3);
            this.buttonG_Launch.Name = "buttonG_Launch";
            this.buttonG_Launch.Size = new System.Drawing.Size(115, 48);
            this.buttonG_Launch.TabIndex = 0;
            this.buttonG_Launch.Text = "Caption";
            this.buttonG_Launch.UseVisualStyleBackColor = true;
            this.buttonG_Launch.Click += new System.EventHandler(this.buttonG_Launch_Click);
            // 
            // Icon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonG_Launch);
            this.Name = "Icon";
            this.Size = new System.Drawing.Size(177, 54);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Glx.Gui.ButtonG buttonG_Launch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
