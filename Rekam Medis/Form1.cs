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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-TIOR7MTC;Initial Catalog=rekammedis;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Login where NamaUser = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'",koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Base panggil = new Base();
                panggil.Show();
                }
            else
            {
                MessageBox.Show("Mohon Isi user name dan password dengan benar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
