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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        void tambahuser()
        {
            string conString = @"Data Source=DESKTOP-TIVTC5O\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=basabasi";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string cmdString = "INSERT INTO pengguna VALUES (@VALUE1,@VALUE2)";
            SqlCommand cmd = new SqlCommand(cmdString, con);
            cmd.Parameters.AddWithValue("@VALUE1", txtnewuser.Text);
            cmd.Parameters.AddWithValue("@VALUE2", txtnewpass.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil");
            txtnewuser.Text="";
            txtnewpass.Text="";

            con.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\project\aplikasi smt 4\basabasi\Sound\Discovery.wav");
            player.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
            SoundPlayer back = new SoundPlayer(@"D:\project\aplikasi smt 4\basabasi\Sound\button-16.wav");
            back.Play();
        }

        private void btntambahuser_Click(object sender, EventArgs e)
        {
            tambahuser();
        }
    }
}
