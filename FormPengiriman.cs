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
    public partial class FormPengiriman : Form
    {
        String connStr;
        OracleConnection conn;

        String queryStr;
        OracleCommand query;
        OracleDataAdapter adapter;
        DataSet dataset;
        DataSet datakirim;

        String cmdStr;
        OracleCommand cmd;
        String kode;
        int id;
        public FormPengiriman(string nama, int id)
        {
            InitializeComponent();
            conn = Form1.conn;
            this.id = id;
            label1.Text = "Welcome, " + nama;
            loadDGVDelivery();
        }

        void loadDGVDelivery()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = $"SELECT KODE_RESI AS \"Kode Resi\", PENERIMA AS \"Nama Penerima\", ALAMAT_TUJUAN AS \"Alamat Tujuan\"FROM DELIVERY_ORDER WHERE FK_PEGAWAI = '{id}'";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                dataset = new DataSet();

                adapter.Fill(dataset, "DELIVERY");

                dgvDelivery.DataSource = dataset;
                dgvDelivery.DataMember = "DELIVERY";

                dgvDelivery.Columns[0].Width = 120;
                dgvDelivery.Columns[2].Width = 150;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }
        void loadDGVStatus()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = "SELECT KODE_RESI AS \"Kode Resi\", STATUS_PENGIRIMAN AS \"Status Pengiriman\", TANGGAL_PENGIRIMAN AS \"Tanggal Pengiriman\"FROM PENGIRIMAN WHERE KODE_RESI like '%" + kode + "%'";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                datakirim = new DataSet();

                adapter.Fill(datakirim, "PENGIRIMAN");

                dgvStatus.DataSource = datakirim;
                dgvStatus.DataMember = "PENGIRIMAN";

                dgvStatus.Columns[1].Width = 150;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void dgvDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            kode = dgvDelivery.Rows[idx].Cells[0].Value.ToString();
            loadDGVStatus();
            btnAdd.Enabled = true;
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("dd/MMM/yyyy HH:mm:ss");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            //DateTime dateOnly = date.Date;

            if (!tbKeterangan.Text.Equals(""))
            {
                String keterangan = tbKeterangan.Text;
                string timeStamp = GetTimestamp(DateTime.Now);
                MessageBox.Show(timeStamp);
                cmdStr = "INSERT INTO PENGIRIMAN(KODE_RESI,STATUS_PENGIRIMAN,TANGGAL_PENGIRIMAN) VALUES ('" + kode + "','" + keterangan + "', '" + timeStamp + "')";
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
                    loadDGVStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void tbKeterangan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
