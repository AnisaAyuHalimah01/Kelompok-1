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
    public partial class Dokter : Form
    {
        public Dokter()
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

        private void resetdata()
        {
            txtnopraktek.Text = "";
            txtiddokter.Text = "";
            txtnamadokter.Text = "";
            txtalamat.Text = "";
            rbpria.Text = "";
            rbwanita.Text = "";
            txttelepon.Text = "";
        }

        private void Dokter_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            con.Open();
            string Jk = "";
            if (rbpria.Checked == true)
            {
                Jk = rbpria.Text;
            }
            else
            {
                Jk = rbwanita.Text;
            }
            SqlCommand com = new SqlCommand("exec dbo.SP_Dokter_Insert '" + int.Parse(txtiddokter.Text) + "','" + txtnamadokter.Text + "','" + txtalamat.Text + "','" + txttelepon.Text  + "','" + Jk + "','" + txtnopraktek.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
            LoadAllRecords();
            resetdata();
        }

        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.SP_Dokter_View", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvdokter.DataSource = dt;
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string Jk = "";
            if (rbpria.Checked == true)
            {
                Jk = rbpria.Text;
            }
            else
            {
                Jk = rbwanita.Text;
            }
            SqlCommand com = new SqlCommand("exec dbo.SP_Dokter_Update '" + int.Parse(txtiddokter.Text) + "','" + txtnamadokter.Text + "','" + txtalamat.Text + "','" + txttelepon.Text  + "','" + Jk + "','" + txtnopraktek + "'", con);
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
                SqlCommand com = new SqlCommand("exec dbo.SP_Dokter_Delete '" + int.Parse(txtiddokter.Text) + "'", con);
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
            cmd.CommandText = "select * from Dokter where IdDokter like '%" + txtcaridata.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Dokter");
            dgvdokter.DataSource = ds;
            dgvdokter.DataMember = "Dokter";
            dgvdokter.ReadOnly = true;
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
            cmd.CommandText = "select * from Dokter";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Dokter");
            dgvdokter.DataSource = ds;
            dgvdokter.DataMember = "Dokter";
            dgvdokter.ReadOnly = true;
        }
    }
}
