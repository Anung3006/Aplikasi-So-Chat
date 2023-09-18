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
    public partial class Form2 : Form
    {
        //media
        SoundPlayer player = new SoundPlayer(@"D:\project\aplikasi smt 4\basabasi\Sound\Flick.wav");
        SoundPlayer proses = new SoundPlayer(@"D:\project\aplikasi smt 4\basabasi\Sound\Shuffle.wav");
        SoundPlayer reset = new SoundPlayer(@"D:\project\aplikasi smt 4\basabasi\Sound\Plonk.wav");
        SoundPlayer back = new SoundPlayer(@"D:\project\aplikasi smt 4\basabasi\Sound\button-16.wav");
        //variabel
        String sapaan;
        String nama;
        String NIM;
        String kelas;
        String prodi;
        String keperluan;
        String keperluan_opsi;
        //variabel koneksi sql
        string koneksi;
        SqlConnection sqlkoneksi;
        SqlCommand command;
        SqlDataReader reader;

        public Form2()
        {
            InitializeComponent();
            
            //koneksi sql server
            koneksi = @"Data Source=DESKTOP-TIVTC5O\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=basabasi";
            sqlkoneksi = new SqlConnection(koneksi);
            
        }
        void tampilsapaan()
        {
            sqlkoneksi.Open();

            string query = "SELECT Sapaan FROM etika";
            command = new SqlCommand(query, sqlkoneksi);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cbsapaan.Items.Add(reader["Sapaan"].ToString());
            }
            reader.Close();
            sqlkoneksi.Close();
        }
        void tampilkeperluan()
        {
            sqlkoneksi.Open();
            string query = "SELECT nama_keperluan FROM keperluan";
            command = new SqlCommand(query, sqlkoneksi);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cbkeperluan.Items.Add(reader["nama_keperluan"].ToString());
            }
            reader.Close();
            sqlkoneksi.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            tampilsapaan();
            tampilkeperluan();
        }
        void clear()
        {
            txtkelas.Clear();
            txtnama.Clear();
            txtnim.Clear();
            txtprodi.Clear();
            txthasil.Clear();
            txtkeperluan.Clear();
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
            cbsapaan.SelectedItem = null;
            cbkeperluan.SelectedItem = null;
        }
        void pemprosesan()
        {
            keperluan_opsi = cbkeperluan.SelectedItem.ToString();
            sapaan = cbsapaan.SelectedItem.ToString();
            String terimakasih="Atas waktunya, Saya ucapkan Terima Kasih.";

            nama = txtnama.Text;
            NIM = txtnim.Text;
            kelas = txtkelas.Text;
            prodi = txtprodi.Text;
            keperluan = txtkeperluan.Text;

            if (rb1.Checked)
            {
                txthasil.Text = sapaan + "\n" + 
                    "Saya " + nama + ",(" + NIM+")"+"\n"
                   + keperluan_opsi + " " + keperluan + "\n"
                    
                    +terimakasih;
            }
            else if (rb2.Checked)
            {
                txthasil.Text = sapaan + "\n" +
                    "Saya " + nama + ",(" + prodi +")"+ "\n"
                    + keperluan_opsi + " " + keperluan + "\n"
                    + terimakasih;
            }
            else if (rb3.Checked)
            {
                txthasil.Text = sapaan +"\n"+
                    "Saya " + nama + ", kelas " + kelas + "\n"
                    + keperluan_opsi +" "+ keperluan + "\n"
                    + terimakasih;
            }
            else
            {
                txthasil.Text = sapaan + "\n" +
                    "Saya " + nama + ",(" + NIM + ") kelas " + kelas + "\n"
                    + keperluan_opsi + " " + keperluan + "\n"
                    + terimakasih ;
            }
            
        }
        private void btnproses_Click(object sender, EventArgs e)
        {
            pemprosesan();
            proses.Play();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
            reset.Play();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            Form3 go = new Form3();
            go.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back.Play();
            Form1 kembali = new Form1();
            kembali.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\WINDOWS\Downloads\Flick.wav");
            player.Play();

            
            string textToCopy = txthasil.Text; // Ganti textBox1 dengan nama TextBox yang sesuai

            if (!string.IsNullOrEmpty(textToCopy))
            {
                Clipboard.SetText(textToCopy);
                MessageBox.Show("Tersimpan Di Clipboard");
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Form5 go = new Form5();
            go.Show();
            this.Hide();
        }

    }
}
