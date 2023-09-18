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
    public partial class Form5 : Form
    {
        //media
        SoundPlayer back = new SoundPlayer(@"D:\project\aplikasi smt 4\basabasi\Sound\button-16.wav");
        //variabel koneksi
        SqlConnection sqlkoneksi;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        string koneksi;

        public Form5()
        {
            InitializeComponent();
            //isi variabel koneksi
            koneksi = @"Data Source=DESKTOP-TIVTC5O\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=basabasi";
            sqlkoneksi = new SqlConnection(koneksi);
        }
        void tampil()
        {
            sqlkoneksi.Open();
            DataTable tabelkeperluan = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter = new SqlDataAdapter("select * from keperluan", sqlkoneksi);
            adapter.Fill(tabelkeperluan);
            dgkeperluan.DataSource = tabelkeperluan;
            sqlkoneksi.Close();
        }
        void kode()
        {
            long hitung;
            string urut;
            sqlkoneksi.Open();
            cmd = new SqlCommand("select id_keperluan from keperluan where id_keperluan in(select max(id_keperluan) from keperluan) order by id_keperluan desc", sqlkoneksi);
            reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {

                hitung = Convert.ToInt64(reader["id_keperluan"]) + 1;
                string joinstr = "0000" + hitung;
                urut = joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {

                urut = "0001";
            }
            reader.Close();
            txtidkeperluan.Text = urut;
            sqlkoneksi.Close();
        }
        void tambah()
        {
            string Query = "INSERT INTO keperluan (id_keperluan, nama_keperluan) VALUES (@1, @2)";

            using (SqlConnection sqlkoneksi = new SqlConnection(koneksi))
            {
                sqlkoneksi.Open();

                using (SqlCommand cmd = new SqlCommand(Query, sqlkoneksi))
                {
                    cmd.Parameters.AddWithValue("@1", txtidkeperluan.Text);
                    cmd.Parameters.AddWithValue("@2", txtkeperluan.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Ditambah");
                    kode();
                    txtkeperluan.Clear();
                    tampil();
                }
                sqlkoneksi.Close();
            }
        }
        void hapus()
        {
            string delQuery = "DELETE FROM keperluan WHERE id_keperluan = @keyword";   
            using (SqlConnection sqlkoneksi = new SqlConnection(koneksi))
            {
                sqlkoneksi.Open();

                using (SqlCommand command = new SqlCommand(delQuery, sqlkoneksi))
                {
                    command.Parameters.AddWithValue("@Keyword", txtidkeperluan.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Dihapus");
                    tampil();
                }
                sqlkoneksi.Close();
            }
        }
        void update()
        {
            string update = "UPDATE keperluan SET nama_keperluan = @2 WHERE id_keperluan=@1";
            using (SqlConnection sqlkoneksi = new SqlConnection(koneksi))
            {
                sqlkoneksi.Open();

                using (SqlCommand command = new SqlCommand(update, sqlkoneksi))
                {
                    command.Parameters.AddWithValue("@2", txtkeperluan.Text);
                    command.Parameters.AddWithValue("@1", txtidkeperluan.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Berhasil Diupdate");
                    tampil();
                }
                sqlkoneksi.Close();
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetkeperluan1.keperluan' table. You can move, or remove it, as needed.
            this.keperluanTableAdapter.Fill(this.dataSetkeperluan1.keperluan);
            tampil();
            kode();
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Form2 go = new Form2();
            go.Show();
            this.Hide();
            back.Play();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            tambah();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            hapus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
