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
    public partial class FormHarga : Form
    {
        OracleConnection conn;
        DataTable dtBahan, dtCust;
        OracleDataAdapter da, daC;
        OracleCommand cmd;
        int selectedIndex = -1;
        public FormHarga()
        {
            InitializeComponent();
            conn = Form1.conn;
            loadData();
            LoadJenis();
        }

        public void loadData()
        {
            dtBahan = new DataTable();
            da = new OracleDataAdapter();
            cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT h.ID, h.kota_asal AS \"Kota Asal\", h.kota_tujuan AS \"Kota Tujuan\", j.nama_jenis as \"Jenis Jasa\", h.harga as \"Harga\" FROM harga h, jenis_jasa j where j.id = h.fk_jenis_jasa";

            conn.Open();
            cmd.ExecuteReader();
            da.SelectCommand = cmd;
            da.Fill(dtBahan);
            dgvData.DataSource = dtBahan;
            dgvData.Columns[0].Visible = false;

            conn.Close();
            dgvData.Columns[4].DefaultCellStyle.Format = "Rp###,###";
        }

        private void clear()
        {
            tbAsal.Text = "";
            tbTujuan.Text = "";
            tbHarga.Text = "";
            cbJasa.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = dtBahan.Rows[selectedIndex][0].ToString();
            string asal = tbAsal.Text;
            string tujuan = tbTujuan.Text;
            int jasa = cbJasa.SelectedIndex + 1;
            int harga = Convert.ToInt32(tbHarga.Text);

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"update harga set kota_asal='{asal}', kota_tujuan = '{tujuan}', fk_jenis_jasa = '{jasa}', harga = '{harga}' where id={Convert.ToInt32(id)}";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            loadData();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Belum ada data yang dipilih");
            }
            else
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from harga where id =:id";
                cmd.Parameters.Add(":id", dtBahan.Rows[selectedIndex][0].ToString());
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                loadData();
                MessageBox.Show("Berhasil Delete");
                clear();
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dgvData.CurrentCell.RowIndex;

            tbAsal.Text = dgvData.Rows[selectedIndex].Cells[1].Value.ToString();
            tbTujuan.Text = dgvData.Rows[selectedIndex].Cells[2].Value.ToString();
            cbJasa.Text = dgvData.Rows[selectedIndex].Cells[3].Value.ToString();
            tbHarga.Text = dgvData.Rows[selectedIndex].Cells[4].Value.ToString();
            tbHarga.Text = string.Format("{0:#,##0}", double.Parse(tbHarga.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPilih f = new FormPilih();
            f.Show();
            this.Close();
        }

        private void LoadJenis()
        {
            daC = new OracleDataAdapter("select * from jenis_jasa", conn);
            dtCust = new DataTable();
            daC.Fill(dtCust);
            cbJasa.DataSource = dtCust.DefaultView;
            cbJasa.DisplayMember = dtCust.Columns["nama_jenis"].ToString();
            cbJasa.ValueMember = "id";
            cbJasa.SelectedIndex = -1;
            cbJasa.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbAsal.Text != "" && tbTujuan.Text != "" && cbJasa.SelectedIndex != -1 && tbHarga.Text != "")
            {
                string asal = tbAsal.Text;
                string tujuan = tbTujuan.Text;
                int jasa = cbJasa.SelectedIndex + 1;
                int harga = Convert.ToInt32(tbHarga.Text);

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select max(id) from harga";
                conn.Open();
                int id = Int32.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();
                int id2 = id + 1;

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"insert into harga values('{id2}', '{asal}', '{tujuan}', '{jasa}', '{harga}')";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                loadData();
            }
            else
            {
                MessageBox.Show("Field Kosong!");
            }
        }
    }
}
