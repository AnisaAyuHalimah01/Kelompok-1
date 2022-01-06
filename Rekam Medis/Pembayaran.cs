using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rekam_Medis
{
    public partial class Pembayaran : Form
    {
        public Pembayaran()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
       (@"Data Source=LAPTOP-TIOR7MTC;Initial Catalog=rekammedis;Integrated Security = True");


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Base panggil = new Base();
            panggil.Show();
        }
    }
}
