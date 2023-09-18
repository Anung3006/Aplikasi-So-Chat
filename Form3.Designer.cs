namespace basabasi
{
    partial class Form3
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
            this.btntmbh = new System.Windows.Forms.Button();
            this.btnhps = new System.Windows.Forms.Button();
            this.txtinsert = new System.Windows.Forms.TextBox();
            this.txtdelete = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntmbh
            // 
            this.btntmbh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btntmbh.Location = new System.Drawing.Point(353, 154);
            this.btntmbh.Name = "btntmbh";
            this.btntmbh.Size = new System.Drawing.Size(100, 35);
            this.btntmbh.TabIndex = 1;
            this.btntmbh.Text = "Tambah";
            this.btntmbh.UseVisualStyleBackColor = false;
            this.btntmbh.Click += new System.EventHandler(this.btntmbh_Click);
            // 
            // btnhps
            // 
            this.btnhps.BackColor = System.Drawing.Color.Red;
            this.btnhps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhps.Location = new System.Drawing.Point(353, 215);
            this.btnhps.Name = "btnhps";
            this.btnhps.Size = new System.Drawing.Size(100, 35);
            this.btnhps.TabIndex = 1;
            this.btnhps.Text = "Hapus";
            this.btnhps.UseVisualStyleBackColor = false;
            this.btnhps.Click += new System.EventHandler(this.btnhps_Click);
            // 
            // txtinsert
            // 
            this.txtinsert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtinsert.Location = new System.Drawing.Point(153, 164);
            this.txtinsert.Name = "txtinsert";
            this.txtinsert.Size = new System.Drawing.Size(192, 13);
            this.txtinsert.TabIndex = 2;
            // 
            // txtdelete
            // 
            this.txtdelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdelete.Location = new System.Drawing.Point(154, 225);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(192, 13);
            this.txtdelete.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.BackgroundImage = global::basabasi.Properties.Resources.pngwing_com__10_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(470, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::basabasi.Properties.Resources._4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 377);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtdelete);
            this.Controls.Add(this.txtinsert);
            this.Controls.Add(this.btnhps);
            this.Controls.Add(this.btntmbh);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Sapaan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntmbh;
        private System.Windows.Forms.Button btnhps;
        private System.Windows.Forms.TextBox txtinsert;
        private System.Windows.Forms.TextBox txtdelete;
        private System.Windows.Forms.Button button3;
    }
}