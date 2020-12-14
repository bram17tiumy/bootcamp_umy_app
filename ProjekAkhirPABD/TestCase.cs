using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ProjekAkhirPABD
{
    [TestFixture]
    class TestCase
    {
        /// <summary>
        /// Test Case 1.1 Mengetes fungsi login username dan password valid
        /// </summary>
        [TestCase]
        public void login1()
        {
            AksesDB adb = new AksesDB();
            Assert.AreEqual("valid", adb.validasilogin("Silvi", "ibukosbaik"));
        }
        /// <summary>
        /// Test Case 1.2 Mengetes fungsi login username tidak valid dan password valid
        /// </summary>
        [TestCase]
        public void login2()
        {
            AksesDB adb = new AksesDB();
            Assert.AreEqual("invalid", adb.validasilogin("Budi", "ibukosbaik"));
        }
        /// <summary>
        /// Test Case 1.3 Mengetes fungsi login username valid dan password tidak valid
        /// </summary>
        [TestCase]
        public void login3()
        {
            AksesDB adb = new AksesDB();
            Assert.AreEqual("invalid", adb.validasilogin("Silvi", "kosberkah"));
        }
        /// <summary>
        /// Test Case 1.4 Mengetes fungsi login username dan password tidak valid
        /// </summary>
        [TestCase]
        public void login4()
        {
            AksesDB adb = new AksesDB();
            Assert.AreEqual("invalid", adb.validasilogin("Budi", "kosberkah"));
        }
        /// <summary>
        /// Test Case 1.5 Mengetes fungsi login username dan password kosong
        /// </summary>
        [TestCase]
        public void login5()
        {
            AksesDB adb = new AksesDB();
            Assert.AreEqual("invalid", adb.validasilogin("", ""));
        }
        /// <summary>
        /// Test Case 2
        /// </summary>
        [TestCase]
        public void search1()
        {
            AksesDB adb = new AksesDB();
            Assert.AreEqual(null, adb.caridata(""));
        }
        
        /// <summary>
        /// Test Case 3.1 : Mengecek sistem ketika memasukkan nomor kamar yang sudah ada.
        /// </summary>
        [TestCase]
        public void cekkamar()
        {
            AksesDB adb = new AksesDB();
            Assert.AreEqual(true, adb.cekkamar("1"));
        }
    }
}
