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
    public partial class FormCustomer : Form
    {
        String connStr;
        OracleConnection conn;

        String queryStr;
        OracleCommand query;
        OracleDataAdapter adapter;
        DataSet dataset;

        String cmdStr;
        OracleCommand cmd;

        String cmdStr2;
        OracleCommand cmd2;

        int ctrCustomer;
        int idx;
        public FormCustomer()
        {
            InitializeComponent();
            conn = Form1.conn;
            loadDGV();
        }
        void loadDGV()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = "SELECT ID, KODE AS \"Kode\", NAMA AS \"Nama\", USERNAME AS \"Username\", PASSWORD, case jenis_kelamin when 'L' then 'Laki-Laki' else 'Perempuan' end AS \"Jenis Kelamin\", NO_TELP AS \"No Telpon\", ALAMAT AS \"Alamat\" FROM CUSTOMER WHERE STATUS = 1";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                dataset = new DataSet();

                adapter.Fill(dataset, "CUSTOMER");

                dgvData.DataSource = dataset;
                dgvData.DataMember = "CUSTOMER";

                dgvData.Columns["PASSWORD"].Visible = false;
                dgvData.Columns["ID"].Visible = false;

                ctrCustomer = dgvData.Rows.Count;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            lblKode.Text = dgvData.Rows[idx].Cells[1].Value.ToString();
            tbNama.Text = dgvData.Rows[idx].Cells[2].Value.ToString();
            tbUsername.Text = dgvData.Rows[idx].Cells[3].Value.ToString();
            tbPassword.Text = dgvData.Rows[idx].Cells[4].Value.ToString();
            tbTelp.Text = dgvData.Rows[idx].Cells[6].Value.ToString();
            tbAlamat.Text = dgvData.Rows[idx].Cells[7].Value.ToString();
            String jenis = dgvData.Rows[idx].Cells[5].Value.ToString();
            if (jenis == "Laki-Laki")
            {
                rbLaki.Checked = true;
            }
            else
            {
                rbPerempuan.Checked = true;
            }
        }

        public Boolean checkNama(String nama)
        {
            String[] temp = nama.Split(' ');
            if (temp.Length >= 2)
            {
                if (temp[0].Length < 2 || temp[1].Length < 2)
                {
                    return false;
                }
            }
            else
            {
                if (nama.Length < 4)
                {
                    return false;
                }
            }
            return true;
        }
        public String checkValid(String gndr, String pw)
        {
            String err = "";
            if (pw.Equals("") || tbUsername.Text.Equals(""))
            {
                err = "Username dan password tidak boleh kosong";
            }
            else if (gndr.Equals(""))
            {
                err = "Gender belum dipilih";
            }
            else if (tbTelp.Text.Equals(""))
            {
                err = "Nomor telepon tidak boleh kosong";
            }
            else if (!checkNama(tbNama.Text))
            {
                err = "Panjang nama invalid! Minimal tiap kata terdiri dari 2 huruf atau 4 huruf";
            }
            else if (tbAlamat.Text.Equals(""))
            {
                err = "Alamat tidak boleh kosong";
            }
            return err;
        }
        public String generateKode(String nama)
        {
            String[] temp = nama.Split(' ');
            String kode_final = "";
            int ctr = 1;

            if (temp.Length >= 2)
            {
                kode_final += temp[0].Substring(0, 2);
                kode_final += temp[1].Substring(0, 2);
            }
            else
            {
                kode_final += nama.Substring(0, 4);
            }
            kode_final = kode_final.ToUpper();
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();
                cmdStr2 = "select LPAD(count(*)+1,4,'0') from CUSTOMER where KODE like '%" + kode_final + "%'";
                cmd2 = new OracleCommand(cmdStr2, conn);
                ctr = Int32.Parse(cmd2.ExecuteScalar().ToString());

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }

            String kd = "0000" + ctr + "";
            kode_final += kd;
            return kode_final;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String nama = tbNama.Text;
            String pw = tbPassword.Text;
            String gndr = "";
            String alamat = tbAlamat.Text;
            String username = tbUsername.Text;
            String notelp = tbTelp.Text;
            ctrCustomer += 1;
            int status = 1;
            if (rbLaki.Checked)
            {
                gndr = "L";
            }
            else if (rbPerempuan.Checked)
            {
                gndr = "P";
            }
            String err = checkValid(gndr, pw);
            if (err.Equals(""))
            {
                String kode = generateKode(nama);
                cmdStr = "INSERT INTO CUSTOMER(ID,KODE,USERNAME,PASSWORD,NAMA,JENIS_KELAMIN,NO_TELP,ALAMAT,STATUS) VALUES ('" + ctrCustomer + "','" + kode + "','" + username + "','" + pw + "','" + nama + "','" + gndr + "','" + notelp + "','" + alamat + "','" + status + "')";
                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                    conn.Open();

                    cmd = new OracleCommand(cmdStr, conn);



                    cmd.ExecuteNonQuery();

                    conn.Close();
                    loadDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String kode = dgvData.Rows[idx].Cells["KODE"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Yakin Hapus Customer", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmdStr = "UPDATE Customer SET STATUS = 0 WHERE KODE = :kode";
                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                    conn.Open();

                    cmd = new OracleCommand(cmdStr, conn);

                    cmd.Parameters.Add(new OracleParameter(":kode", OracleDbType.Varchar2, 12, kode, ParameterDirection.Input));

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    loadDGV();
                    MessageBox.Show("Berhasil hapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            idx = 0;
            lblKode.Text = "[Kode]";
            tbNama.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbTelp.Text = "";
            tbAlamat.Text = "";
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String kode = dgvData.Rows[idx].Cells["KODE"].Value.ToString();
            String nama = tbNama.Text;
            String pw = tbPassword.Text;
            String gndr = "";
            String alamat = tbAlamat.Text;
            String username = tbUsername.Text;
            String notelp = tbTelp.Text;
            if (rbLaki.Checked)
            {
                gndr = "L";
            }
            else if (rbPerempuan.Checked)
            {
                gndr = "P";
            }
            cmdStr = "UPDATE CUSTOMER SET USERNAME = :puser, PASSWORD = :ppass, NAMA = :pnama, JENIS_KELAMIN = :pjenis, NO_TELP = :pnotelp, ALAMAT = :palamat WHERE KODE = :kode";
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                cmd = new OracleCommand(cmdStr, conn);
                cmd.Parameters.Add(new OracleParameter(":puser", OracleDbType.Varchar2, 20, username, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter(":ppass", OracleDbType.Varchar2, 20, pw, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter(":pnama", OracleDbType.Varchar2, 30, nama, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter(":pjenis", OracleDbType.Varchar2, 1, gndr, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter(":pnotelp", OracleDbType.Varchar2, 15, notelp, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter(":palamat", OracleDbType.Varchar2, 10, alamat, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter(":kode", OracleDbType.Varchar2, 12, kode, ParameterDirection.Input));

                cmd.ExecuteNonQuery();

                conn.Close();
                loadDGV();
                MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPilih f = new FormPilih();
            f.Show();
            this.Close();
        }
    }
}
