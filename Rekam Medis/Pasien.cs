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
    public partial class Pasien : Form
    {
        public Pasien()
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
            txtno.Text = "";
            txtnama.Text = "";
            rbpria.Text = "";
            rbwanita.Text = "";
            cmbagama.Text = "";
            txtalamat.Text = "";
            dttgl.Text = "";
            txttelepon.Text = "";
            txttb.Text = "";
            txtbb.Text = "";
            txtalergi.Text = "";
            cmbpkr.Text = "";
            txtkk.Text = "";
        }

        private void Pasien_Load(object sender, EventArgs e)
        {
            MunculCombo1();
            MunculCombo2();
            LoadAllRecords();
        }

        void MunculCombo1()
        {
            cmbagama.Items.Add("Islam");
            cmbagama.Items.Add("Kristen");
            cmbagama.Items.Add("Hindu");
            cmbagama.Items.Add("Budha");
            cmbagama.Items.Add("Konghuchu");
        }

        void MunculCombo2()
        {
            cmbpkr.Items.Add("PNS");
            cmbpkr.Items.Add("Wiraswasta");
            cmbpkr.Items.Add("TNI");
            cmbpkr.Items.Add("Polri");
            cmbpkr.Items.Add("Buruh");
            cmbpkr.Items.Add("Pelajar");
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
            SqlCommand com = new SqlCommand("exec dbo.SP_Pasien_Insert '" + int.Parse(txtno.Text) + "','" + txtnama.Text + "','" + Jk + "','" + cmbagama.Text + "','" + txtalamat.Text + "','" + DateTime.Parse(dttgl.Text) + "','" + txttelepon.Text + "','" + txttb.Text + "','" + txtbb.Text + "','" + txtalergi.Text + "','" + cmbpkr.Text + "','" + txtkk.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
            LoadAllRecords();
            resetdata();
        }

        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.SP_Pasien_View", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvpasien.DataSource = dt;
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
            SqlCommand com = new SqlCommand("exec dbo.SP_Pasien_Update '" + int.Parse(txtno.Text) + "','" + txtnama.Text + "','" + Jk + "','" + cmbagama.Text + "','" + txtalamat.Text + "','" + DateTime.Parse(dttgl.Text) + "','" + txttelepon.Text + "','" + txttb.Text + "','" + txtbb.Text + "','" + txtalergi.Text + "','" + cmbpkr.Text + "','" + txtkk.Text + "'", con);
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
                SqlCommand com = new SqlCommand("exec dbo.SP_Pasien_Delete '" + int.Parse(txtno.Text) + "'", con);
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
            cmd.CommandText = "select * from Pasien where NoPasien like '%" + txtcaridata.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pasien");
            dgvpasien.DataSource = ds;
            dgvpasien.DataMember = "Pasien";
            dgvpasien.ReadOnly = true;
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
            cmd.CommandText = "select * from Pasien";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pasien");
            dgvpasien.DataSource = ds;
            dgvpasien.DataMember = "Pasien";
            dgvpasien.ReadOnly = true;
            //ini tiara
        }
    }
}
