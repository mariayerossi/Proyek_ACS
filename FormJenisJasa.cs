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
    public partial class FormJenisJasa : Form
    {
        OracleConnection conn;
        DataTable dtBahan;
        OracleDataAdapter da;
        OracleCommand cmd;
        int selectedIndex = -1;
        public FormJenisJasa()
        {
            InitializeComponent();
            conn = Form1.conn;
            loadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "" && nudWaktu.Value != 0)
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select max(id) from jenis_jasa";
                conn.Open();
                int id = Int32.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();
                int id2 = id + 1;
                string nama = tbNama.Text;
                int waktu = Convert.ToInt32(nudWaktu.Value.ToString());

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"insert into jenis_jasa values('{id2}', '{nama}', '{waktu}')";
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

        private void clear()
        {
            tbNama.Text = "";
            nudWaktu.Value = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = dtBahan.Rows[selectedIndex][0].ToString();
            string nama = tbNama.Text;
            int waktu = Convert.ToInt32(nudWaktu.Value.ToString());
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"update jenis_jasa set nama_jenis='{nama}', waktu = '{waktu}' where id={Convert.ToInt32(id)}";

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
                cmd.CommandText = "delete from jenis_jasa where id =:id";
                cmd.Parameters.Add(":id", dtBahan.Rows[selectedIndex][0].ToString());
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                loadData();
                MessageBox.Show("Berhasil Delete");
                clear();
            }
        }

        public void loadData()
        {
            dtBahan = new DataTable();
            da = new OracleDataAdapter();
            cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT ID, NAMA_JENIS AS \"Jenis Jasa\", WAKTU AS \"Waktu\" FROM JENIS_JASA";

            conn.Open();
            cmd.ExecuteReader();
            da.SelectCommand = cmd;
            da.Fill(dtBahan);
            dgvData.DataSource = dtBahan;
            dgvData.Columns[0].Visible = false;

            conn.Close();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dgvData.CurrentCell.RowIndex;

            nudWaktu.Value = Convert.ToInt32(dgvData.Rows[selectedIndex].Cells[2].Value.ToString());
            tbNama.Text = dgvData.Rows[selectedIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPilih f = new FormPilih();
            f.Show();
            this.Close();
        }
    }
}
