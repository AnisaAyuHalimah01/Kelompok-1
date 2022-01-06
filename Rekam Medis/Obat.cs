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
    public partial class Obat : Form
    {
        public Obat()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
       (@"Data Source=LAPTOP-TIOR7MTC;Initial Catalog=rekammedis;Integrated Security = True");

        private void Obat_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
            MunculCombo1();
        }

        void MunculCombo1()
        {
            cmbsatuan.Items.Add("Pcs");
            cmbsatuan.Items.Add("Botol");
            cmbsatuan.Items.Add("Box");
            cmbsatuan.Items.Add("Strip");
            cmbsatuan.Items.Add("Pak");
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

        private void resetdata()
        {
            txtkodeobat.Text = "";
            txtnamaobat.Text = "";
            txtspesifikasi.Text = "";
            txtketerangan.Text = "";
            cmbsatuan.Text = "";
            txtharga.Text = "";
            txtstok.Text = "";
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.SP_Obat_Insert '" + int.Parse(txtkodeobat.Text) + "','" + txtnamaobat.Text + "','" + txtspesifikasi.Text + "','" + txtketerangan.Text + "','" + cmbsatuan.Text + "','" + txtharga.Text + "','" + txtstok.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
            LoadAllRecords();
            resetdata();
        }

        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.SP_Obat_View", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvobat.DataSource = dt;
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.SP_Obat_Update '" + int.Parse(txtkodeobat.Text) + "','" + txtnamaobat.Text + "','" + txtspesifikasi.Text + "','" + txtketerangan.Text + "','" + cmbsatuan.Text + "','" + txtharga.Text + "','" + txtstok.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            LoadAllRecords();
            resetdata();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirm to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand com = new SqlCommand("exec dbo.SP_Obat_Delete '" + int.Parse(txtkodeobat.Text) + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted");
                LoadAllRecords();
                resetdata();
            }
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Obat where KodeObat like '%" + txtcaridata.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Obat");
            dgvobat.DataSource = ds;
            dgvobat.DataMember = "Obat";
            dgvobat.ReadOnly = true;
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            resetdata();
            showdata();
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Obat";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Obat");
            dgvobat.DataSource = ds;
            dgvobat.DataMember = "Obat";
            dgvobat.ReadOnly = true;
        }
    }
}
