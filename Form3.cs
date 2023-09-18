using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace basabasi
{

    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer back = new SoundPlayer(@"D:\project\aplikasi smt 4\basabasi\Sound\button-16.wav");
            back.Play();
            Form2 go = new Form2();
            go.Show();
            this.Hide();
        }
        void tambah()
        {

            string connectionString = @"Data Source=DESKTOP-TIVTC5O\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=basabasi"; // Ganti dengan string koneksi database Anda
            string insertQuery = "INSERT INTO etika (Sapaan) VALUES (@Value1)"; // Ganti TableName dengan nama tabel Anda

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, con))
                {
                    command.Parameters.AddWithValue("@Value1", txtinsert.Text); // Ganti @Value1 dengan nama parameter dan value1 dengan nilai yang ingin Anda sisipkan
                    // Tambahkan parameter dan nilai untuk setiap kolom yang ingin Anda sisipkan
                 
                    command.ExecuteNonQuery();
                    MessageBox.Show("Berhasil");
                    txtinsert.Text = "";
                    }
                con.Close();
                }
                
            }
        void hapus()
        {
            string connectionString = @"Data Source=DESKTOP-TIVTC5O\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=basabasi";
            String keyword = txtdelete.Text;
            // Ganti dengan string koneksi database Anda
            string delQuery = "DELETE FROM etika WHERE Sapaan LIKE @keyword";   // Ganti TableName dengan nama tabel Anda

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(delQuery, con))
                {
                    command.Parameters.AddWithValue("@Keyword", keyword);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Dihapus");
                    txtdelete.Text = "";
                }
                con.Close();
            }
        }

        private void btntmbh_Click(object sender, EventArgs e)
        {
            tambah();
        }

        private void btnhps_Click(object sender, EventArgs e)
        {
            hapus();
        }
    }
}

