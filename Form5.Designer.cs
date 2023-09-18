namespace basabasi
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.btntambah = new System.Windows.Forms.Button();
            this.txtidkeperluan = new System.Windows.Forms.TextBox();
            this.txtkeperluan = new System.Windows.Forms.TextBox();
            this.dataSetkeperluan = new basabasi.DataSetkeperluan();
            this.keperluanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keperluanTableAdapter = new basabasi.DataSetkeperluanTableAdapters.keperluanTableAdapter();
            this.dgkeperluan = new System.Windows.Forms.DataGridView();
            this.dataSetkeperluan1 = new basabasi.DataSetkeperluan();
            this.keperluanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idkeperluanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namakeperluanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnkembali = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetkeperluan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keperluanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgkeperluan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetkeperluan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keperluanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.Lime;
            this.btntambah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntambah.Location = new System.Drawing.Point(55, 208);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 2;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // txtidkeperluan
            // 
            this.txtidkeperluan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidkeperluan.Location = new System.Drawing.Point(55, 137);
            this.txtidkeperluan.Name = "txtidkeperluan";
            this.txtidkeperluan.Size = new System.Drawing.Size(253, 13);
            this.txtidkeperluan.TabIndex = 3;
            // 
            // txtkeperluan
            // 
            this.txtkeperluan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkeperluan.Location = new System.Drawing.Point(55, 181);
            this.txtkeperluan.Name = "txtkeperluan";
            this.txtkeperluan.Size = new System.Drawing.Size(253, 13);
            this.txtkeperluan.TabIndex = 4;
            // 
            // dataSetkeperluan
            // 
            this.dataSetkeperluan.DataSetName = "DataSetkeperluan";
            this.dataSetkeperluan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // keperluanBindingSource
            // 
            this.keperluanBindingSource.DataMember = "keperluan";
            this.keperluanBindingSource.DataSource = this.dataSetkeperluan;
            // 
            // keperluanTableAdapter
            // 
            this.keperluanTableAdapter.ClearBeforeFill = true;
            // 
            // dgkeperluan
            // 
            this.dgkeperluan.AutoGenerateColumns = false;
            this.dgkeperluan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgkeperluan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgkeperluan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgkeperluan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkeperluanDataGridViewTextBoxColumn,
            this.namakeperluanDataGridViewTextBoxColumn});
            this.dgkeperluan.DataSource = this.keperluanBindingSource1;
            this.dgkeperluan.Location = new System.Drawing.Point(55, 261);
            this.dgkeperluan.Name = "dgkeperluan";
            this.dgkeperluan.Size = new System.Drawing.Size(413, 94);
            this.dgkeperluan.TabIndex = 5;
            // 
            // dataSetkeperluan1
            // 
            this.dataSetkeperluan1.DataSetName = "DataSetkeperluan";
            this.dataSetkeperluan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // keperluanBindingSource1
            // 
            this.keperluanBindingSource1.DataMember = "keperluan";
            this.keperluanBindingSource1.DataSource = this.dataSetkeperluan1;
            // 
            // idkeperluanDataGridViewTextBoxColumn
            // 
            this.idkeperluanDataGridViewTextBoxColumn.DataPropertyName = "id_keperluan";
            this.idkeperluanDataGridViewTextBoxColumn.HeaderText = "id_keperluan";
            this.idkeperluanDataGridViewTextBoxColumn.Name = "idkeperluanDataGridViewTextBoxColumn";
            // 
            // namakeperluanDataGridViewTextBoxColumn
            // 
            this.namakeperluanDataGridViewTextBoxColumn.DataPropertyName = "nama_keperluan";
            this.namakeperluanDataGridViewTextBoxColumn.HeaderText = "nama_keperluan";
            this.namakeperluanDataGridViewTextBoxColumn.Name = "namakeperluanDataGridViewTextBoxColumn";
            // 
            // btnkembali
            // 
            this.btnkembali.BackColor = System.Drawing.Color.White;
            this.btnkembali.BackgroundImage = global::basabasi.Properties.Resources.pngwing_com__10_;
            this.btnkembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkembali.Location = new System.Drawing.Point(639, 327);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(30, 30);
            this.btnkembali.TabIndex = 6;
            this.btnkembali.UseVisualStyleBackColor = false;
            this.btnkembali.Click += new System.EventHandler(this.btnkembali_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.Red;
            this.btnhapus.Location = new System.Drawing.Point(148, 208);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 7;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Aqua;
            this.btnupdate.Location = new System.Drawing.Point(245, 208);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::basabasi.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 399);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.dgkeperluan);
            this.Controls.Add(this.txtkeperluan);
            this.Controls.Add(this.txtidkeperluan);
            this.Controls.Add(this.btntambah);
            this.DoubleBuffered = true;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Keperluan";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetkeperluan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keperluanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgkeperluan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetkeperluan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keperluanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.TextBox txtidkeperluan;
        private System.Windows.Forms.TextBox txtkeperluan;
        private System.Windows.Forms.BindingSource keperluanBindingSource;
        private System.Windows.Forms.DataGridView dgkeperluan;
        private DataSetkeperluan dataSetkeperluan1;
        private System.Windows.Forms.BindingSource keperluanBindingSource1;
        private DataSetkeperluan dataSetkeperluan;
        private DataSetkeperluanTableAdapters.keperluanTableAdapter keperluanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkeperluanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namakeperluanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnkembali;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnupdate;
    }
}