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
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 panggil = new Form1();
            panggil.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pasien panggil = new Pasien();
            panggil.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Poli panggil = new Poli();
            panggil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pembayaran panggil = new Pembayaran();
            panggil.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rekammedis panggil = new Rekammedis();
            panggil.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Obat panggil = new Obat();
            panggil.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dokter panggil = new Dokter();
            panggil.Show();
        }
    }
}
