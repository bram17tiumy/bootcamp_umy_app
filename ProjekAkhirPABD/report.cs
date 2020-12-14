using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekAkhirPABD
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
            this.Controls.Add(this.reportViewer1);

        }

        private void report_Load(object sender, EventArgs e)
        {

        }
    }
}
