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
    public partial class Poli : Form
    {
        public Poli()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection
        (@"Data Source=LAPTOP-TIOR7MTC;Initial Catalog=rekammedis;Integrated Security = True");

        private void resetdata()
        {
            txtkodepoli.Text = "";
            txtnama.Text = "";
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Poli";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Poli");
            dgvkelas.DataSource = ds;
            dgvkelas.DataMember = "Poli";
            dgvkelas.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Base panggil = new Base();
            panggil.Show();
        }

        private void Kelas_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Poli where KodePoli like'%" + txtcaridata.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Poli");
            dgvkelas.DataSource = ds;
            dgvkelas.DataMember = "Poli";
            dgvkelas.ReadOnly = true;
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (txtkodepoli.Text == "" | txtnama.Text == "" )
            {
                MessageBox.Show("Semua data poli harus diisi", "Peringatan");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Poli values('" + txtkodepoli.Text + "','" + txtnama.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

            berhenti:
            ;
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            if (txtkodepoli.Text == "" | txtnama.Text == "" )
            {
                MessageBox.Show("Semua data poli harus diisi", "Peringatan");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Poli SET NamaPoli= '" + txtnama.Text + "'where KodePoli='" + txtkodepoli.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

            berhenti:
            ;
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (txtkodepoli.Text == "")
            {
                MessageBox.Show("Isi Kode Poli yang akan dihapus");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Poli where KodePoli = '" + txtkodepoli.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

            berhenti:
            ;
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }
    }
}
