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
    public partial class Rekammedis : Form
    {
        public Rekammedis()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection
       (@"Data Source=LAPTOP-TIOR7MTC;Initial Catalog=rekammedis;Integrated Security = True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Base panggil = new Base();
            panggil.Show();
        }

        private void btncari_Click(object sender, EventArgs e)
        {

        }
    }
}
