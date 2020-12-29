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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            lihatdata();
            
        }
        /// <summary>
        /// Ini Variabel untuk memulai fungsi - fungsi dari fitur aplikasi
        /// </summary>
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-Q2F2C6F7;Initial Catalog=DataKosan;Integrated Security=True");

        /// <summary>
        /// method ini untuk melihat data di database
        /// </summary>
        void lihatdata()
        {
            AksesDB cek = new AksesDB();
            dView.DataSource = cek.datadb();
            dView.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            //dView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //dView.AllowUserToOrderColumns = true;
            //dView.AllowUserToResizeColumns = true;
            //dView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// fungsi dari button ini untuk menampilkan pesan selamat datang ditambah dengan nama admin
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">e parameter</param>
        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = "Selamat Datang  " + Form1.namauser;
        }
        /// <summary>
        /// ini fitur untuk berpindah halaman
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            datapenghunikosan d = new datapenghunikosan();
            d.Show();
            this.Hide();
        }
        /// <summary>
        /// ini fitur untuk logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Apakah anda ingin logout? ", "Confirm Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();

            }
            else if (d == DialogResult.No){}
        }
        /// <summary>
        /// fitur untuk menutup aplikasi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Apakah anda ingin menutup aplikasi? ","Menutup Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
        /// <summary>
        /// ini fitur untuk mencari data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            AksesDB data = new AksesDB();
            String datacari = tbSearch.Text;
            dt = data.caridata(datacari);
            if (tbSearch.Text != "")
            {
            //    koneksi.Open();

            //    string query = "select * from penghunikoskosan where Nama like '%" + datacari + "%' or NoKamar like'%"+datacari+"%'";
            //    da = new SqlDataAdapter(query, koneksi);
            //    dt = new DataTable();
            //    da.Fill(dt);
                
            //    koneksi.Close();
                dView.DataSource = dt;
            }
            else if (tbSearch.Text == "")
            {
                dView.DataSource = data.datadb();
                dView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btkeloladata_Click(object sender, EventArgs e)
        {
            datapenghunikosan d = new datapenghunikosan();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Apakah anda ingin logout? ", "Confirm Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();

            }
            else if (d == DialogResult.No) { }
        }
    }
}
