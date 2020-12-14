using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekAkhirPABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// variabel nama user berfungsi sebagai penyimpan data nama admin yang akan dipindahkan ke halaman berikutnya
        /// </summary>
        public static string namauser;
        
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Enter(object sender, EventArgs e)
        {}
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Leave(object sender, EventArgs e)
        {
            //if (textBox1.Text == "")
            //{
            //    textBox1.Text = "Username";
            //    textBox1.ForeColor = Color.Silver;
            //}
        }
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_Enter(object sender, EventArgs e)
        {
            //if (textBox2.Text == "Password")
            //{
            //    textBox2.Text = "";
            //    textBox2.ForeColor = Color.Black;
            //}
        }
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_Leave(object sender, EventArgs e)
        {
            //if (textBox2.Text == "")
            //{
            //    textBox2.Text = "Password";
            //    textBox2.ForeColor = Color.Silver;
            //}
        }
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Char ch = e.KeyChar;
            ////e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
            //e.Handled = char.IsNumber(ch) || ch == 8 ? false : false;

            //if (e.Handled == char.IsDigit(ch) && ch != 8)
            //{
            //    //e.Handled = true;

            //    MessageBox.Show("input harus angka loh");
            //    e.KeyChar = (char)0;
            //}
            //else if (tbUname.Text.Length >= 10)
            //{
            //    if (e.KeyChar != (char)8) //&& e.KeyChar != 13 && e.KeyChar != 32)
            //    {
            //        e.Handled = true;
            //        MessageBox.Show("maks 10");
            //    }
                //ch = (char)Keys.Back;
                //e.Handled = true;
                //MessageBox.Show("maks 10");
                //e.KeyChar = (char)0;
                //e.Handled = true;

            //}
            //else
            //{

            //}
            //Char ch = e.KeyChar;
            //e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
            //e.Handled = !char.IsDigit(e.KeyChar);


            //else if (e.Handled == char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Input Harus Angka yah kwkwkwk");
            //}

        }
        /// <summary>
        /// method ini untuk button login sebagai proses validasi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = tbUname.Text;
            string pswd = tbPswd.Text;
            AksesDB a = new AksesDB();
            string hasilvalidasi = a.validasilogin(uname, pswd);
            if (hasilvalidasi == "valid")
            {
                Home h = new Home();
                namauser = tbUname.Text;
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah.\n" +
                   "\nPastikan Username dan Password yang anda ketikkan sudah benar!", "Login Error! "+hasilvalidasi, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbUname.Clear();
                tbPswd.Clear();
            }
    }
        /// <summary>
        /// method ini berfungsi untuk menutup aplikasi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Apakah anda ingin menutup aplikasi? ", "Menutup Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
