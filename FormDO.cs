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
    public partial class FormDO : Form
    {
        OracleConnection conn;
        DataTable dta, dtCust, dtLay, dtJn, dtPg;
        OracleDataAdapter da, daC, daL, daJ, daP;
        OracleCommand cmd;
        int selectedIndex = -1;
        public FormDO()
        {
            InitializeComponent();
            conn = Form1.conn;
            LoadData();
            LoadCustomer();
            LoadKurir();
            LoadKota();
        }

        private void LoadData()
        {
            dta = new DataTable();
            da = new OracleDataAdapter();
            cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = "select d.kode_resi as \"Resi\", d.nama_barang as \"Nama Barang\", d.berat_barang, d.volume_barang, d.harga as \"Harga\", d.penerima, d.alamat_tujuan, h.kota_asal || ' - ' || h.kota_tujuan as \"Kota Tujuan\", j.nama_jenis as \"Jenis\", c.nama, p.nama, d.status, d.metode_pembayaran from delivery_order d, harga h, jenis_jasa j, customer c, pegawai p where d.fk_harga = h.id and h.fk_jenis_jasa = j.id and d.fk_customer = c.id and d.fk_pegawai = p.id";

            conn.Open();
            cmd.ExecuteReader();
            da.SelectCommand = cmd;
            da.Fill(dta);
            dgvData.DataSource = dta;
            dgvData.Columns[2].Visible = false;
            dgvData.Columns[3].Visible = false;
            dgvData.Columns[5].Visible = false;
            dgvData.Columns[6].Visible = false;
            dgvData.Columns[9].Visible = false;
            dgvData.Columns[10].Visible = false;
            dgvData.Columns[11].Visible = false;
            dgvData.Columns[12].Visible = false;
            conn.Close();
            dgvData.Columns[4].DefaultCellStyle.Format = "Rp###,###";
            lblHarga.Text = "0";
            GenereteNota();
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            string kode = lblKode.Text;
            string nama = tbNama.Text;
            int berat = Convert.ToInt32(nudBerat.Value);
            int p = Convert.ToInt32(nudP.Value);
            int l = Convert.ToInt32(nudL.Value);
            int t = Convert.ToInt32(nudT.Value);
            string vol = p + "x" + l + "x" + t;
            int harga = Convert.ToInt32(lblHarga.Text);
            string penerima = tbPenerima.Text;
            string alamat = tbAlamat.Text;
            string kota = cbLayanan.Text;
            string jenis = cbJenis.Text;
            cmd.CommandText = $"select h.id from harga h, jenis_jasa j where h.fk_jenis_jasa = j.id and h.kota_tujuan like '%{kota}%' and j.nama_jenis like '%{jenis}%'";
            conn.Open();
            int tujuan = Int32.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            int cust = cbPengirim.SelectedIndex + 1;
            string kurir = cbKurir.Text;
            cmd.CommandText = $"select p.id from pegawai p where p.nama like '%{kurir}%'";
            conn.Open();
            int kurir2 = Int32.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            string metode = cbMetode.Text;
            conn.Open();
            DateTime date = DateTime.Now;
            string[] tgl = new string[5];
            string tgl1 = date.ToString();
            tgl = tgl1.Split(' ');
            using (OracleTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    if (nama != "" && berat != 0 && p != 0 && l != 0 && t != 0 && penerima != "" && alamat != "" && kota != "" && jenis != "")
                    {
                        if (rbLangsung.Checked)
                        {
                            cmd = new OracleCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = $"insert into delivery_order values('{kode}','{nama}','{berat}','{vol}','{harga}','{penerima}','{alamat}','{tujuan}','{cust}','{kurir2}',0,'{metode}', TO_DATE('" + tgl[0] + "', 'dd/mm/yyyy'))";
                            cmd.ExecuteNonQuery();
                        }
                        else if (rbPeriode.Checked)
                        {
                            cmd = new OracleCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = $"insert into delivery_order values('{kode}','{nama}','{berat}','{vol}','{harga}','{penerima}','{alamat}','{tujuan}','{cust}','{kurir2}',1,null, TO_DATE('" + tgl[0] + "', 'dd/mm/yyyy'))";
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                        conn.Close();
                        Clear();
                        LoadData();
                        GenereteNota();
                    }
                    else
                    {
                        conn.Close();
                        Clear();
                        MessageBox.Show("Tidak dapat melakukan transaksi");
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbLayanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idx = cbLayanan.Text;
            LoadJenis(idx);
        }

        private void LoadJenis(string idx)
        {
            daJ = new OracleDataAdapter($"select * from jenis_jasa j, harga h where h.fk_jenis_jasa = j.id and h.kota_tujuan like '%{idx}%'", conn);
            dtJn = new DataTable();
            daJ.Fill(dtJn);
            cbJenis.DataSource = dtJn.DefaultView;
            cbJenis.DisplayMember = dtJn.Columns["nama_jenis"].ToString();
            cbJenis.ValueMember = "id";
            cbJenis.SelectedIndex = -1;
        }

        private void Clear()
        {
            tbNama.Text = "";
            nudBerat.Value = 0;
            nudP.Value = 0;
            nudL.Value = 0;
            nudT.Value = 0;
            cbLayanan.SelectedIndex = -1;
            cbJenis.SelectedIndex = -1;
            cbPengirim.SelectedIndex = -1;
            tbPenerima.Text = "";
            tbAlamat.Text = "";
            cbKurir.SelectedIndex = -1;
            rbLangsung.Checked = true;
            label17.Visible = true;
            cbMetode.Visible = true;
            cbMetode.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            GenereteNota();
            LoadData();
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
                lblKode.Text = dgvData.Rows[selectedIndex].Cells[0].Value.ToString();
                tbNama.Text = dgvData.Rows[selectedIndex].Cells[1].Value.ToString();
                nudBerat.Value = Convert.ToInt32(dgvData.Rows[selectedIndex].Cells[2].Value);
                string[] vol = new string[5];
                string a = dgvData.Rows[selectedIndex].Cells[3].Value.ToString(); ;
                vol = a.Split('x');
                nudP.Value = Convert.ToInt32(vol[0]);
                nudL.Value = Convert.ToInt32(vol[1]);
                nudT.Value = Convert.ToInt32(vol[2]);
                lblHarga.Text = dgvData.Rows[selectedIndex].Cells[4].Value.ToString();
                string[] kota = new string[5];
                string b = dgvData.Rows[selectedIndex].Cells[7].Value.ToString(); ;
                kota = b.Split(' ');
                cbLayanan.Text = kota[2];
                cbJenis.Text = dgvData.Rows[selectedIndex].Cells[8].Value.ToString();
                cbPengirim.Text = dgvData.Rows[selectedIndex].Cells[9].Value.ToString();
                tbPenerima.Text = dgvData.Rows[selectedIndex].Cells[5].Value.ToString();
                tbAlamat.Text = dgvData.Rows[selectedIndex].Cells[6].Value.ToString();
                cbKurir.Text = dgvData.Rows[selectedIndex].Cells[10].Value.ToString();
                if (Convert.ToInt32(dgvData.Rows[selectedIndex].Cells[11].Value.ToString()) == 0)
                {
                    rbLangsung.Checked = true;
                    label17.Visible = true;
                    cbMetode.Visible = true;
                    cbMetode.Text = dgvData.Rows[selectedIndex].Cells[12].Value.ToString();
                }
                else if (Convert.ToInt32(dgvData.Rows[selectedIndex].Cells[11].Value.ToString()) == 1)
                {
                    rbPeriode.Checked = true;
                    label17.Visible = false;
                    cbMetode.Visible = false;
                }
                lblHarga.Text = string.Format("{0:#,##0}", double.Parse(lblHarga.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPilih f = new FormPilih();
            f.Show();
            this.Close();
        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idx = cbJenis.Text;
            GenereteHarga(Convert.ToInt32(nudBerat.Value), Convert.ToInt32(nudP.Value), Convert.ToInt32(nudL.Value), Convert.ToInt32(nudT.Value), cbLayanan.Text, cbJenis.Text);
        }

        private void LoadCustomer()
        {
            daC = new OracleDataAdapter("select * from customer", conn);
            dtCust = new DataTable();
            daC.Fill(dtCust);
            cbPengirim.DataSource = dtCust.DefaultView;
            cbPengirim.DisplayMember = dtCust.Columns["nama"].ToString();
            cbPengirim.ValueMember = "id";
            cbPengirim.SelectedIndex = -1;
        }

        private void LoadKurir()
        {
            daP = new OracleDataAdapter("select * from pegawai where jabatan like '%Kurir%'", conn);
            dtPg = new DataTable();
            daP.Fill(dtPg);
            cbKurir.DataSource = dtPg.DefaultView;
            cbKurir.DisplayMember = dtPg.Columns["nama"].ToString();
            cbKurir.ValueMember = "id";
            cbKurir.SelectedIndex = -1;
        }

        private void LoadKota()
        {
            daL = new OracleDataAdapter("select distinct kota_tujuan from harga", conn);
            dtLay = new DataTable();
            daL.Fill(dtLay);
            cbLayanan.DataSource = dtLay.DefaultView;
            cbLayanan.DisplayMember = dtLay.Columns[0].ToString();
            //cbLayanan.ValueMember = "id";
            cbLayanan.SelectedIndex = -1;
        }

        private void GenereteHarga(int brt, int p, int l, int t, string kota, string jenis)
        {
            cmd.CommandText = $"select h.harga from harga h, jenis_jasa j where h.fk_jenis_jasa = j.id and h.kota_tujuan like '%{kota}%' and j.nama_jenis like '%{jenis}%'";
            conn.Open();
            int jmlh = Int32.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            int vol = p * l * t / 6000;
            if (brt >= vol)
            {
                int total = brt * jmlh;
                lblHarga.Text = total.ToString();
            }
            else if (vol > brt)
            {
                int total = vol * jmlh;
                lblHarga.Text = total.ToString();
            }
        }

        private void GenereteNota()
        {
            string skrg1 = DateTime.Now.ToString();
            string[] tgl = new string[5];
            tgl = skrg1.Split(' ');
            //MessageBox.Show(tgl[0]);
            string[] tgl2 = new string[5];
            tgl2 = tgl[0].Split('/');
            //MessageBox.Show(tgl2[2] + tgl2[1] + tgl2[0]);
            string nota = "NOTA" + tgl2[2] + tgl2[1] + tgl2[0];
            cmd.CommandText = $"select count(kode_resi) from delivery_order where (kode_resi like '%{nota}%')";
            conn.Open();
            int jmlh = Int32.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            int urut = jmlh + 1;
            if (urut < 10)
            {
                lblKode.Text = nota + "00" + urut;
            }
            else if (urut >= 10)
            {
                lblKode.Text = nota + "0" + urut;
            }
        }

        private void rbPeriode_MouseClick(object sender, MouseEventArgs e)
        {
            label17.Visible = false;
            cbMetode.Visible = false;
        }

        private void rbLangsung_MouseClick(object sender, MouseEventArgs e)
        {
            label17.Visible = true;
            cbMetode.Visible = true;
        }
    }
}
