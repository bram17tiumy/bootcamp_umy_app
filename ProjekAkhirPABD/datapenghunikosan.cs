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
    public partial class datapenghunikosan : Form
    {
        /// <summary>
        /// sebuah method awal yang berfungsi untuk menjalankan fungsi ketika halaman ini pertama kali dimuat
        /// </summary>
        public datapenghunikosan()
        {
            InitializeComponent();
            refreshhalaman();
            lihatdata();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-Q2F2C6F7;Initial Catalog=DataKosan;Integrated Security=True");
        int a;
        /// <summary>
        /// method untuk menampilkan data
        /// </summary>
        void lihatdata()
        {
            AksesDB cek = new AksesDB();
            dView1.DataSource = cek.datadb();
            dView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        /// <summary>
        /// sebagai method untuk merefresh textbox dan button
        /// </summary>
        private void refreshhalaman()
        {
            tbNoKamarr.Text = "";
            tbNamaa.Text = "";
            tbAlamatt.Text = "";
            tbPekerjaann.Text = "";
            dateTimePicker2.CustomFormat = " ";
            tbNotel.Text = "";
            btTambahh.Enabled = true;
            btEditt.Enabled = false;
            btHapuss.Enabled = false;
            btRefreshh.Enabled = false;
            btKeluarr.Enabled = true;
            
            tbNamaa.Enabled = false;
            tbAlamatt.Enabled = false;
            tbPekerjaann.Enabled = false;
            dateTimePicker2.Enabled = false;
            tbNoKamarr.Enabled = false;
            tbNotel.Enabled = false;
            btTambahh.Text = "Tambah Data";
            
        }

        private void datapenghunikosan_Load(object sender, EventArgs e) {}

        private void btTambahh_Click(object sender, EventArgs e) {}

        private void tbNoKamarr_TextChanged(object sender, EventArgs e) {}

        private void tbTtl_TextChanged(object sender, EventArgs e) {}

        private void tbNamaa_TextChanged(object sender, EventArgs e){}

        private void tbAlamatt_TextChanged(object sender, EventArgs e) {}

        private void btKeluarr_Click(object sender, EventArgs e) {}

        private void btRefreshh_Click(object sender, EventArgs e) {}

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {}

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e) {}

        private void tbNoKamarr_KeyPress(object sender, KeyPressEventArgs e) {}

        private void tbNamaa_KeyPress(object sender, KeyPressEventArgs e) {}

        private void tbPekerjaann_KeyPress(object sender, KeyPressEventArgs e) {}

        private void btEditt_Click(object sender, EventArgs e) {}

        private void btHapuss_Click(object sender, EventArgs e) {}

        private void datapenghunikosan_FormClosing(object sender, FormClosingEventArgs e) {}

        private void datapenghunikosan_Load_1(object sender, EventArgs e) {}
        /// <summary>
        /// button ini berfungsi untuk menutup aplikasi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datapenghunikosan_FormClosing_1(object sender, FormClosingEventArgs e)
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
        /// <summary>
        /// button ini berfungsi untuk menambahkan data ke database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btTambahh_Click_1(object sender, EventArgs e)
        {
            if (btTambahh.Text == "Tambah Data")
            {
                tbNoKamarr.Enabled = true;
                btHapuss.Enabled = false;
                btKeluarr.Enabled = false;
                btEditt.Enabled = false;
                btRefreshh.Enabled = true;
                btTambahh.Text = "Simpan Data";
                a++;

            }
            else if (btTambahh.Text == "Simpan Data")
            {
                string nokamar = tbNoKamarr.Text;
                string nama = tbNamaa.Text;
                string ttl = dateTimePicker2.Value.ToString("dd/MM/yyyy");
                string alamat = tbAlamatt.Text;
                string pekerjaan = tbPekerjaann.Text;
                string notel = tbNotel.Text;


                AksesDB data = new AksesDB();
                data.tambahdata(nokamar, nama, ttl, alamat, pekerjaan,notel);

                //view();
                //refreshForm();
                lihatdata();
                refreshhalaman();
                a--;
                //String ttl;
                //ttl = dateTimePicker1.Value.ToString();
                //MessageBox.Show(ttl);
            }
        }
        /// <summary>
        /// button ini berfungsi untuk menghapus data di database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btHapuss_Click_1(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show(this, "Apakah Anda Yakin Ingin Menghapus Data?", "Konfirmasi Penghapusan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                AksesDB data = new AksesDB();
                data.hapusdata(tbNoKamarr.Text);
                lihatdata();
                refreshhalaman();
            }
        }
        /// <summary>
        /// button ini berfungsi untuk mengubah data di database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEditt_Click_1(object sender, EventArgs e)
        {
            string nokamar = tbNoKamarr.Text;
            string nama = tbNamaa.Text;
            string tanggal = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            string alamat = tbAlamatt.Text;
            string pekerjaan = tbPekerjaann.Text;
            string notel = tbNotel.Text;


            AksesDB data = new AksesDB();
            data.edit(nokamar, nama, tanggal, alamat, pekerjaan, notel);
            //if (data.cekkamar(tbNoKamarr.Text) == true)
            //{
            //    //refreshhalaman();
            //    DialogResult dlg = MessageBox.Show("Kamar dengan nomor yang anda isi sudah terisi \nSilahkan pilih kamar yang lain.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    lihatdata();
            //    refreshhalaman();
            //    a--;
            //}
            //else
            //{
            //    data.edit(nokamar, nama, tanggal, alamat, pekerjaan, notel);
            //}

            

            lihatdata();
            refreshhalaman();
        }
        /// <summary>
        /// button untuk refresh tampilan dengan memanggil fungsi method refresh yang telah dibuat sebelumnya
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRefreshh_Click_1(object sender, EventArgs e)
        {
            lihatdata();
            refreshhalaman();
            if (btTambahh.Text == "Simpan Data")
            {
                a--;
            }
            
        }
        /// <summary>
        /// button ini berfungsi untuk kembali ke halaman sebelumnya
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btKeluarr_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
        /// <summary>
        /// button ini sudah dihapus di tampilan tapi belum dihapus dari sistem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReportt_Click(object sender, EventArgs e)
        {
            report r = new report();
            r.Show();
            this.Hide();
        }
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNoKamarr_TextChanged_1(object sender, EventArgs e)
        {
            tbNamaa.Enabled = true;
        }
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNamaa_TextChanged_1(object sender, EventArgs e)
        {
            AksesDB data = new AksesDB();
            if (a == 1)
            {
                if (tbNamaa.Text.Length > 0)
                {
                    if (data.cekkamar(tbNoKamarr.Text) == true)
                    {
                        //refreshhalaman();
                        DialogResult dlg = MessageBox.Show("Kamar dengan nomor yang anda isi sudah terisi \nSilahkan pilih kamar yang lain.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lihatdata();
                        refreshhalaman();
                        a--;
                    }
                    else
                    {
                        dateTimePicker2.Enabled = true;
                    }
                }
            }
            
        }
        /// <summary>
        /// method ini juga sama bedanya ini terjadi ketika mengubah tanggal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            if (tbNamaa.Text.Length >= 1)
            {
                //tbAlamat.Enabled = true;
                //dateTimePicker1.CustomFormat = "Pilih Waktu";
                dateTimePicker2.CustomFormat = "dd/MM/yyyy";
                tbAlamatt.Enabled = true;
            }
            else
            {
                tbAlamatt.Enabled = false;
            }
        }
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbAlamatt_TextChanged_1(object sender, EventArgs e)
        {
            tbPekerjaann.Enabled = true;
        }
        /// <summary>
        /// method yang akhirannya tidak ada angka 1 itu tidak berfungsi, tetapi jika dihapus maka akan error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPekerjaann_TextChanged(object sender, EventArgs e)
        {
            tbNotel.Enabled = true;
        }
        /// <summary>
        /// method ini berfungsi untuk memunculkan event ketika panel datanya di klik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// method ini untuk event yg akan terjadi ketika ada yang berubah
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                dateTimePicker2.CustomFormat = " ";
            }
        }
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNoKamarr_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            //e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
            e.Handled = char.IsNumber(ch) || ch == 8 ? false : false;

            if (e.Handled == char.IsDigit(ch) && ch != 8)
            //if (e.Handled == char.IsDigit(ch) && e.KeyChar == (char)Keys.Back)
            {
                //e.Handled = true;
                MessageBox.Show("input harus angka loh", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.KeyChar = (char)0;
            }
            else if (tbNoKamarr.Text.Length >= 3)
            {
                //e.Handled = true;
                if (e.KeyChar != (Char)8)
                {
                    MessageBox.Show("Maksimal angka yang bisa di masukkan berjumlah 3 angka saja", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.KeyChar = (char)0;
                }
            }
            else { }
        }
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNamaa_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            e.Handled = char.IsLetter(e.KeyChar) && e.KeyChar == (char)Keys.Back && e.KeyChar == (char)Keys.Space;
            if (e.Handled == char.IsLetter(ch) && ch != 8)
            //if (e.Handled == char.IsDigit(ch) && e.KeyChar == (char)Keys.Back)
            {
                MessageBox.Show("input harus huruf loh", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.KeyChar = (char)0;
            }
            else if (tbNamaa.Text.Length >= 30)
            {
                if (ch != 8)
                {
                    MessageBox.Show("Maksimal jumlah karakter adalah 30", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }

            }
        }
        /// <summary>
        /// method ini untuk event yang akan terjadi jika terjadi perubahan pada textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPekerjaann_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            //e.Handled = char.IsLetter(e.KeyChar) && e.KeyChar == (char)Keys.Back && e.KeyChar == (char)Keys.Space;
            if (tbPekerjaann.Text.Length >= 30)
            {
                if (ch != 8)
                {
                    MessageBox.Show("Maksimal jumlah karakter adalah 30", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }

                //if (ch != 8)
                //{
                //    MessageBox.Show("Maksimal jumlah karakter adalah 30", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    e.Handled = true;
                //}

            }
        }
        /// <summary>
        /// method yang akhirannya tidak ada angka 1 itu tidak berfungsi, tetapi jika dihapus maka akan error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNotel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            //e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
            e.Handled = char.IsNumber(ch) || ch == 8 ? false : false;

            if (e.Handled == char.IsDigit(ch) && ch != 8)
            //if (e.Handled == char.IsDigit(ch) && e.KeyChar == (char)Keys.Back)
            {
                //e.Handled = true;

                MessageBox.Show("input harus angka loh", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.KeyChar = (char)0;
            }
            else if (tbNotel.Text.Length >= 14)
            {
                //e.Handled = true;



                if (e.KeyChar != (Char)8)
                {
                    MessageBox.Show("Maksimal angka yang bisa di masukkan berjumlah 14 angka saja", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.KeyChar = (char)0;
                }

            }
            else{}
        }

        private void tbNotel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nokamar = Convert.ToString(dView1.Rows[e.RowIndex].Cells[0].Value);
            string nama = Convert.ToString(dView1.Rows[e.RowIndex].Cells[1].Value);
            string tanggal = Convert.ToString(dView1.Rows[e.RowIndex].Cells[2].Value);
            string alamat = Convert.ToString(dView1.Rows[e.RowIndex].Cells[3].Value);
            string pekerjaan = Convert.ToString(dView1.Rows[e.RowIndex].Cells[4].Value);
            string notel = Convert.ToString(dView1.Rows[e.RowIndex].Cells[5].Value);

            tbNoKamarr.Text = nokamar;
            tbNamaa.Text = nama;
            dateTimePicker2.CustomFormat = tanggal;
            tbAlamatt.Text = alamat;
            tbPekerjaann.Text = pekerjaan;
            tbNotel.Text = notel;

            tbNoKamarr.Enabled = false;
            btTambahh.Enabled = false;
            btEditt.Enabled = true;
            btHapuss.Enabled = true;
            btRefreshh.Enabled = true;
            btKeluarr.Enabled = false;
            tbNamaa.Enabled = true;
            tbAlamatt.Enabled = true;
            tbPekerjaann.Enabled = true;
            tbNotel.Enabled = true;
            dateTimePicker2.Enabled = true;

            //textBox1.Enabled = false;
            //textBox3.Enabled = true;
            //PlusBtn.Name = "Edit";
            //PlusBtn.Enabled = true;
            //PlusBtn.BackColor = Color.Transparent;
            //DeleteBtn.Enabled = true;
            //DeleteBtn.BackColor = Color.Transparent;
            //RefreshBtn.Enabled = true;
            //RefreshBtn.BackColor = Color.Transparent;
        }
    }
}
