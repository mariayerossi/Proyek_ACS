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
    public partial class FormCustomer2 : Form
    {
        OracleConnection conn;
        DataTable dtBahan, dtSt;
        OracleDataAdapter da, daS;
        OracleCommand cmd;
        int selectedIndex = -1;
        int id;
        public FormCustomer2(String nama, int id)
        {
            InitializeComponent();
            conn = Form1.conn;
            lblNama.Text = "Welcome, " + nama;
            this.id = id;
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        public void LoadData()
        {
            dtBahan = new DataTable();
            da = new OracleDataAdapter();
            cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = $"select d.kode_resi as \"Nomor Resi\", d.nama_barang as \"Nama Barang\", d.berat_barang, d.volume_barang, d.harga, d.penerima as \"Penerima\", d.alamat_tujuan, h.kota_asal, h.kota_tujuan, j.nama_jenis, p.nama, d.status, d.metode_pembayaran from delivery_order d, harga h, jenis_jasa j, pegawai p where d.fk_harga = h.id and h.fk_jenis_jasa = j.id and d.fk_pegawai = p.id and d.fk_customer = '{id}'";

            conn.Open();
            cmd.ExecuteReader();
            da.SelectCommand = cmd;
            da.Fill(dtBahan);
            dgvData.DataSource = dtBahan;
            dgvData.Columns[2].Visible = false;
            dgvData.Columns[3].Visible = false;
            dgvData.Columns[4].Visible = false;
            dgvData.Columns[6].Visible = false;
            dgvData.Columns[7].Visible = false;
            dgvData.Columns[8].Visible = false;
            dgvData.Columns[9].Visible = false;
            dgvData.Columns[10].Visible = false;
            dgvData.Columns[11].Visible = false;
            dgvData.Columns[12].Visible = false;
            conn.Close();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dgvData.CurrentCell.RowIndex;

            if (selectedIndex < 0)
            {
                MessageBox.Show("Belum ada data yang dipilih");
            }
            else
            {
                lblResi.Text = dgvData.Rows[selectedIndex].Cells[0].Value.ToString();
                lblBarang.Text = dgvData.Rows[selectedIndex].Cells[1].Value.ToString();
                lblBerat.Text = dgvData.Rows[selectedIndex].Cells[2].Value.ToString() + " kg";
                lblVolume.Text = dgvData.Rows[selectedIndex].Cells[3].Value.ToString() + " cm";
                lblPenerima.Text = dgvData.Rows[selectedIndex].Cells[5].Value.ToString();
                lblAlamat.Text = dgvData.Rows[selectedIndex].Cells[6].Value.ToString() + ", " + dgvData.Rows[selectedIndex].Cells[8].Value.ToString();
                lblJasa.Text = dgvData.Rows[selectedIndex].Cells[9].Value.ToString();
                lblKurir.Text = dgvData.Rows[selectedIndex].Cells[10].Value.ToString();
                lblHarga.Text = dgvData.Rows[selectedIndex].Cells[4].Value.ToString();
                lblHarga.Text = string.Format("Rp {0:#,##0}", double.Parse(lblHarga.Text));
                if (Convert.ToInt32(dgvData.Rows[selectedIndex].Cells[11].Value.ToString()) == 0)
                {
                    lblStatus.Text = "Pembayaran Langsung";
                }
                else if (Convert.ToInt32(dgvData.Rows[selectedIndex].Cells[11].Value.ToString()) == 1)
                {
                    lblStatus.Text = "Pembayaran Periode";
                }

                daS = new OracleDataAdapter($"select status_pengiriman, tanggal_pengiriman from pengiriman where kode_resi = '{lblResi.Text}'", conn);
                dtSt = new DataTable();
                daS.Fill(dtSt);
                rtStatus.Text = "";
                foreach (DataRow row in dtSt.Rows)
                {
                    //string[] tgl = new string[5];
                    //string b = row[1].ToString();
                    //tgl = b.Split(' ');
                    string k = dgvData.Rows[selectedIndex].Cells[10].Value.ToString();
                    rtStatus.Text += "⬤  " + row[1].ToString() + " " + " [" + k + "] " + row[0].ToString() + "\n" + "\n";
                }
            }
        }
    }
}
