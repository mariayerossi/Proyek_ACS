using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Proyek_ACS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1 f;
        public static OracleConnection conn;
        DataTable dtKaryawan, dtCust;
        OracleDataAdapter daK, daC;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.Silver;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
                tbPassword.UseSystemPasswordChar = true;

            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.Silver;
                tbPassword.UseSystemPasswordChar = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (tbPassword.UseSystemPasswordChar == true) 
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else if (tbPassword.UseSystemPasswordChar == false)
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        OracleCommand cmd;

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection("DATA SOURCE=localhost:1521/XEPDB1;PERSIST SECURITY INFO=True;USER ID=MARIA;PASSWORD=maria");
                conn.Open();
                conn.Close();
                dtKaryawan = new DataTable();
                daK = new OracleDataAdapter();
                cmd = new OracleCommand();
                daK = new OracleDataAdapter("select username, password, nama, jabatan, id from pegawai", conn);
                dtKaryawan = new DataTable();
                daK.Fill(dtKaryawan);
                int ada = 0;
                for (int i = 0; i < dtKaryawan.Rows.Count; i++)
                {
                    if (tbUsername.Text == dtKaryawan.Rows[i][0].ToString() && tbPassword.Text == dtKaryawan.Rows[i][1].ToString() && dtKaryawan.Rows[i][3].ToString() == "Admin")
                    {
                        ada = 1;
                        FormPilih f = new FormPilih();
                        f.Show();
                        this.Hide();
                    }
                    else if (tbUsername.Text == dtKaryawan.Rows[i][0].ToString() && tbPassword.Text == dtKaryawan.Rows[i][1].ToString() && dtKaryawan.Rows[i][3].ToString() == "Kurir")
                    {
                        ada = 1;
                        string nama = dtKaryawan.Rows[i][2].ToString();
                        int id = Convert.ToInt32(dtKaryawan.Rows[i][4].ToString());
                        FormPengiriman f = new FormPengiriman(nama, id);
                        f.Show();
                        this.Hide();
                    }
                    
                }

                dtCust = new DataTable();
                daC = new OracleDataAdapter();
                daC = new OracleDataAdapter("select username, password, nama, id from customer", conn);
                dtCust = new DataTable();
                daC.Fill(dtCust);
                for (int i = 0; i < dtCust.Rows.Count; i++)
                {
                    if (tbUsername.Text == dtCust.Rows[i][0].ToString() && tbPassword.Text == dtCust.Rows[i][1].ToString())
                    {
                        ada = 1;
                        string nama = dtCust.Rows[i][2].ToString();
                        int id = Convert.ToInt32(dtCust.Rows[i][3].ToString());
                        FormCustomer2 f = new FormCustomer2(nama, id);
                        f.Show();
                        this.Hide();
                    }
                    
                }
                if (ada == 0)
                {
                    MessageBox.Show("User Tidak ada!");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                
            }
        }
    }
}
