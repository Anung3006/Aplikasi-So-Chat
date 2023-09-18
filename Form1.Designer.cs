namespace basabasi
{
    partial class Form1
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
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.adduser = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.keluar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adduser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keluar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Location = new System.Drawing.Point(181, 168);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(218, 13);
            this.txtuser.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.Window;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Location = new System.Drawing.Point(182, 230);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(218, 13);
            this.txtpass.TabIndex = 3;
            // 
            // adduser
            // 
            this.adduser.BackgroundImage = global::basabasi.Properties.Resources.adduser;
            this.adduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adduser.Location = new System.Drawing.Point(44, 36);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(30, 30);
            this.adduser.TabIndex = 9;
            this.adduser.TabStop = false;
            this.adduser.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::basabasi.Properties.Resources.masuk_tombol;
            this.pictureBox2.Location = new System.Drawing.Point(423, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // keluar
            // 
            this.keluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.keluar.Image = global::basabasi.Properties.Resources.pngwing_com__9_;
            this.keluar.Location = new System.Drawing.Point(548, 315);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(30, 30);
            this.keluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.keluar.TabIndex = 7;
            this.keluar.TabStop = false;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::basabasi.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 386);
            this.Controls.Add(this.adduser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adduser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keluar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.PictureBox keluar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox adduser;
    }
}

