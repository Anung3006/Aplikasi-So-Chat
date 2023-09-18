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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void masuk()
        {
            string conString = @"Data Source=DESKTOP-TIVTC5O\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=basabasi";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string cmdString = "SELECT * FROM pengguna WHERE pengguna=@username AND katasandi=@password";
            SqlCommand cmd = new SqlCommand(cmdString, con);
            cmd.Parameters.AddWithValue("@username", txtuser.Text);
            cmd.Parameters.AddWithValue("@password", txtpass.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                SoundPlayer player = new SoundPlayer(@"D:\project\aplikasi smt 4\basabasi\Sound\Discovery.wav");
                player.Play();


                Form2 go = new Form2();
                go.Show();
                this.Hide();
                //tambahkan kode untuk membuka form utama disini
            }
            else
            {
                SoundPlayer eror = new SoundPlayer(@"D:\project\aplikasi smt 4\basabasi\Sound\beep-03.wav");
                eror.Play();
                MessageBox.Show("Username atau password salah!");
            }

            con.Close();

            


        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            masuk();

            
        }
        private void keluar_Click(object sender, EventArgs e)
        {
            SoundPlayer back = new SoundPlayer(@"C:\Users\WINDOWS\Downloads\button-16.wav");
            back.Play();
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 go = new Form4();
            go.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
