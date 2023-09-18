namespace basabasi
{
    partial class Form4
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
            this.btntambahuser = new System.Windows.Forms.Button();
            this.txtnewuser = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntambahuser
            // 
            this.btntambahuser.BackColor = System.Drawing.Color.Lime;
            this.btntambahuser.Location = new System.Drawing.Point(394, 212);
            this.btntambahuser.Name = "btntambahuser";
            this.btntambahuser.Size = new System.Drawing.Size(93, 32);
            this.btntambahuser.TabIndex = 0;
            this.btntambahuser.Text = "Tambah";
            this.btntambahuser.UseVisualStyleBackColor = false;
            this.btntambahuser.Click += new System.EventHandler(this.btntambahuser_Click);
            // 
            // txtnewuser
            // 
            this.txtnewuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnewuser.Location = new System.Drawing.Point(169, 162);
            this.txtnewuser.Name = "txtnewuser";
            this.txtnewuser.Size = new System.Drawing.Size(196, 13);
            this.txtnewuser.TabIndex = 2;
            // 
            // txtnewpass
            // 
            this.txtnewpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnewpass.Location = new System.Drawing.Point(169, 222);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(196, 13);
            this.txtnewpass.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::basabasi.Properties.Resources.pngwing_com__10_;
            this.pictureBox1.Location = new System.Drawing.Point(507, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::basabasi.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.txtnewuser);
            this.Controls.Add(this.btntambahuser);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntambahuser;
        private System.Windows.Forms.TextBox txtnewuser;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}