using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ProjekAkhirPABD
{
    /// <summary>
    /// ini adalah class yang bernama AksesDB yang berfungsi untuk menghubungkan ke database
    /// </summary>
    public class AksesDB
    {
        SqlDataAdapter da;
        SqlCommandBuilder cmd;
        DataTable dt;

        //string strKoneksi = "Data Source = DESKTOP-V6C98QN; Initial Catalog=DataKosan; User ID = sa; password=inipassword";
        //SqlConnection koneksi = new SqlConnection();
        //koneksi.ConnectionString = strKoneksi;
        SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-Q2F2C6F7;Initial Catalog=DataKosan;Integrated Security=True");
        //SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-V6C98QN;Initial Catalog=DataKosan;User ID=sa;Password=inipassword");
        /// <summary>
        /// method untuk mengambil data dari database
        /// </summary>
        /// <returns></returns>
        public DataTable datadb()
        {
            DataTable datatable;

            string query = "SELECT * FROM penghunikoskosan";

            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            datatable = new DataTable();
            adapter.Fill(datatable);

            return datatable;
        }

        public string validasilogin(string uname, string pw)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-Q2F2C6F7;Initial Catalog=DataKosan;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from adminaplikasi where Username='" + uname + "' and Password='" + pw + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return ("valid");
            }
            else
            {
                return ("invalid");
            }
        }
        /// <summary>
        /// method untuk memvalidasi data jika terdapat data yang sama
        /// </summary>
        /// <param name="nokamar">Id Kamar yaitu no kamar</param>
        /// <returns></returns>
        public bool cekkamar(string nokamar)
        {
            bool result = false;
            try
            {
                
                koneksi.Open();

                string str = "select * from penghunikoskosan where NoKamar=@no";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("no", nokamar));

                string hasil = "";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    hasil = dr["NoKamar"].ToString();
                }
                dr.Close();
                koneksi.Close();
                if (hasil.Equals(nokamar))
                {
                    result = true;
                }
            }
            catch (Exception)
            {

            }

            return result;
        }
        /// <summary>
        /// method untuk menambah data
        /// </summary>
        /// <param name="nokamar">string nomor kamar</param>
        /// <param name="nama">string nama</param>
        /// <param name="ttl">string ttl</param>
        /// <param name="alamat">string alamat</param>
        /// <param name="pekerjaan">string pekerjaan</param>
        /// <param name="notel">string nomor telepon</param>
        public void tambahdata(string nokamar, string nama, string ttl, string alamat, string pekerjaan, string notel)
        {
            
            //string str = "";

            try
            {
                //koneksi.ConnectionString = koneksi;

                koneksi.Open();

                //if (PlusBtn == "Simpan") str = "insert into HRD.Mahasiswa (NIM, NamaMhs, AlamatMhs, Sex, PhoneMhs)"
                //        + " values(@Nim,@NMhs,@AMhs,@Jk,@NTlp)";
                //if (PlusBtn == "Edit") str = "update HRD.Mahasiswa set NamaMhs=@NMhs," +
                //        "AlamatMhs=@AMhs,Sex=@Jk,PhoneMhs=@NTlp where NIM=@Nim";
                //str = "insert into HRD.Mahasiswa (NIM, NamaMhs, AlamatMhs, Sex, PhoneMhs)"
                //        + " values(@Nim,@NMhs,@AMhs,@Jk,@NTlp)"
                string str = "insert into penghunikoskosan values(@NoKamar,@Nama,@TanggalLahir,@Alamat,@Pekerjaan,@NoTelepon)";
                SqlCommand cmd = new SqlCommand(str, koneksi);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("NoKamar", nokamar));
                cmd.Parameters.Add(new SqlParameter("Nama", nama));
                cmd.Parameters.Add(new SqlParameter("TanggalLahir", ttl));
                cmd.Parameters.Add(new SqlParameter("Alamat", alamat));
                cmd.Parameters.Add(new SqlParameter("Pekerjaan", pekerjaan));
                cmd.Parameters.Add(new SqlParameter("NoTelepon", notel));
                
                cmd.ExecuteNonQuery();

                koneksi.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
        /// <summary>
        /// method untuk mengedit data
        /// </summary>
        /// <param name="nokamar">string nokamar</param>
        /// <param name="nama">string nama</param>
        /// <param name="ttl">string ttl</param>
        /// <param name="alamat">string alamat</param>
        /// <param name="pekerjaan">string pekerjaan</param>
        /// <param name="notel">string notel</param>
        public void edit(string nokamar, string nama, string ttl, string alamat, string pekerjaan, string notel)
        {
            try
            {
                koneksi.Open();
                string str = "update penghunikoskosan set " +
                    "NoKamar=@NoKamar, Nama=@Nama, TanggalLahir=@TanggalLahir, Alamat=@Alamat, Pekerjaan=@Pekerjaan, NoTelepon=@NoTelepon where Nokamar = @NoKamar";
                SqlCommand cmd = new SqlCommand(str, koneksi);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("NoKamar", nokamar));
                cmd.Parameters.Add(new SqlParameter("Nama", nama));
                cmd.Parameters.Add(new SqlParameter("TanggalLahir", ttl));
                cmd.Parameters.Add(new SqlParameter("Alamat", alamat));
                cmd.Parameters.Add(new SqlParameter("Pekerjaan", pekerjaan));
                cmd.Parameters.Add(new SqlParameter("NoTelepon", notel));

                cmd.ExecuteNonQuery();

                koneksi.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            
        }
        /// <summary>
        /// method untuk menghapus data berdasar id
        /// </summary>
        /// <param name="nokamar">string nokamar</param>
        public void hapusdata(string nokamar)
        {           
            koneksi.Open();
            string str = "delete from penghunikoskosan where NoKamar = @nkmr";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("Nkmr", nokamar));
            cmd.ExecuteNonQuery();
            koneksi.Close();
        }
        public DataTable caridata(string datacari)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-Q2F2C6F7;Initial Catalog=DataKosan;Integrated Security=True");
            SqlDataAdapter da;
            DataTable dt;
            if (datacari != "")
            {

                koneksi.Open();
                string query = "select * from penghunikoskosan where Nama like '%" + datacari + "%' or NoKamar like'%" + datacari + "%'";
                da = new SqlDataAdapter(query, koneksi);
                dt = new DataTable();
                da.Fill(dt);
                koneksi.Close();
                return dt;
                

                
            }
            else if (datacari == "")
            {
                return null;
            }
            else
            {
                return null;
            }
        }

    }

}
