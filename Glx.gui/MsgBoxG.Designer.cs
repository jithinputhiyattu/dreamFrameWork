namespace Glx.Gui
{
    partial class MsgBoxG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBoxG));
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_Caption = new System.Windows.Forms.Label();
            this.btn_Two = new System.Windows.Forms.Button();
            this.btn_Three = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.text_Msg = new System.Windows.Forms.TextBox();
            this.pnl_Top.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Top.Controls.Add(this.lbl_Caption);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(422, 45);
            this.pnl_Top.TabIndex = 4;
            // 
            // lbl_Caption
            // 
            this.lbl_Caption.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Caption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caption.ForeColor = System.Drawing.Color.White;
            this.lbl_Caption.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Caption.Image")));
            this.lbl_Caption.Location = new System.Drawing.Point(0, 0);
            this.lbl_Caption.Name = "lbl_Caption";
            this.lbl_Caption.Size = new System.Drawing.Size(422, 45);
            this.lbl_Caption.TabIndex = 0;
            this.lbl_Caption.Text = "Message Box";
            this.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Two
            // 
            this.btn_Two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Two.Enabled = false;
            this.btn_Two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Two.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Two.ForeColor = System.Drawing.Color.White;
            this.btn_Two.Image = ((System.Drawing.Image)(resources.GetObject("btn_Two.Image")));
            this.btn_Two.Location = new System.Drawing.Point(105, 0);
            this.btn_Two.Name = "btn_Two";
            this.btn_Two.Size = new System.Drawing.Size(212, 40);
            this.btn_Two.TabIndex = 6;
            this.btn_Two.Text = "No";
            this.btn_Two.UseVisualStyleBackColor = true;
            // 
            // btn_Three
            // 
            this.btn_Three.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Three.BackgroundImage")));
            this.btn_Three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Three.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Three.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Three.ForeColor = System.Drawing.Color.White;
            this.btn_Three.Location = new System.Drawing.Point(317, 0);
            this.btn_Three.Name = "btn_Three";
            this.btn_Three.Size = new System.Drawing.Size(105, 40);
            this.btn_Three.TabIndex = 5;
            this.btn_Three.Text = "Cancel";
            this.btn_Three.UseVisualStyleBackColor = true;
            // 
            // btn_one
            // 
            this.btn_one.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_one.BackgroundImage")));
            this.btn_one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_one.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_one.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_one.ForeColor = System.Drawing.Color.White;
            this.btn_one.Location = new System.Drawing.Point(0, 0);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(105, 40);
            this.btn_one.TabIndex = 4;
            this.btn_one.Text = "OK";
            this.btn_one.UseVisualStyleBackColor = true;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.Transparent;
            this.pnl_bottom.Controls.Add(this.btn_Two);
            this.pnl_bottom.Controls.Add(this.btn_Three);
            this.pnl_bottom.Controls.Add(this.btn_one);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 208);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(422, 40);
            this.pnl_bottom.TabIndex = 3;
            // 
            // text_Msg
            // 
            this.text_Msg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_Msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_Msg.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.text_Msg.ForeColor = System.Drawing.Color.Black;
            this.text_Msg.Location = new System.Drawing.Point(0, 45);
            this.text_Msg.Multiline = true;
            this.text_Msg.Name = "text_Msg";
            this.text_Msg.ReadOnly = true;
            this.text_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_Msg.Size = new System.Drawing.Size(422, 163);
            this.text_Msg.TabIndex = 6;
            this.text_Msg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MsgBoxG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 248);
            this.ControlBox = false;
            this.Controls.Add(this.text_Msg);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pnl_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MsgBoxG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Top.ResumeLayout(false);
            this.pnl_bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnl_Top;
        public System.Windows.Forms.Label lbl_Caption;
        public System.Windows.Forms.Button btn_Two;
        public System.Windows.Forms.Button btn_Three;
        public System.Windows.Forms.Button btn_one;
        public System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.TextBox text_Msg;


    }
}