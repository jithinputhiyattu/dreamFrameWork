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
            this.buttonG_Launch = new Glx.Gui.ButtonG();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonG_Launch
            // 
            this.buttonG_Launch.BackColor = System.Drawing.Color.Transparent;
            this.buttonG_Launch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonG_Launch.BackgroundImage")));
            this.buttonG_Launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonG_Launch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonG_Launch.Font = new System.Drawing.Font("Arial", 12.75F);
            this.buttonG_Launch.ForeColor = System.Drawing.Color.White;
            this.buttonG_Launch.Location = new System.Drawing.Point(70, 12);
            this.buttonG_Launch.Name = "buttonG_Launch";
            this.buttonG_Launch.Size = new System.Drawing.Size(97, 33);
            this.buttonG_Launch.TabIndex = 0;
            this.buttonG_Launch.Text = "Calculator";
            this.buttonG_Launch.UseVisualStyleBackColor = true;
            this.buttonG_Launch.Click += new System.EventHandler(this.buttonG_Launch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Glx.AddIn.Properties.Resources.Close;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
