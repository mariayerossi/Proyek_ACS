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
    public partial class FormReport : Form
    {
        OracleConnection conn;
        public FormReport()
        {
            InitializeComponent();
            conn = Form1.conn;
            LoadCustomer();
        }

        OracleCommand query;
        OracleDataAdapter adapter;
        DataSet1 dataset;
        String queryStr;
        DataTable dtCust;
        OracleDataAdapter daC;

        private void LoadCustomer()
        {
            daC = new OracleDataAdapter("select * from jenis_jasa", conn);
            dtCust = new DataTable();
            daC.Fill(dtCust);
            cbJenis.DataSource = dtCust.DefaultView;
            cbJenis.DisplayMember = dtCust.Columns["nama_jenis"].ToString();
            cbJenis.ValueMember = "id";
            cbJenis.SelectedIndex = -1;
            cbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            string[] tgl = dtpAwal.Value.ToString().Split(' ');
            string[] tgl2 = dtpAkhir.Value.ToString().Split(' ');
            DateTime dt1 = DateTime.Parse(tgl[0]);
            DateTime dt2 = DateTime.Parse(tgl2[0]);

            query = new OracleCommand();
            query.Connection = conn;
            adapter = new OracleDataAdapter(query);
            dataset = new DataSet1();

            queryStr = "SELECT * FROM jenis_jasa";
            query.CommandText = queryStr;
            adapter.Fill(dataset, "jenis_jasa");

            queryStr = "SELECT * FROM harga";
            query.CommandText = queryStr;
            adapter.Fill(dataset, "harga");

            queryStr = "SELECT * FROM pegawai";
            query.CommandText = queryStr;
            adapter.Fill(dataset, "pegawai");

            queryStr = "SELECT * FROM customer";
            query.CommandText = queryStr;
            adapter.Fill(dataset, "customer");

            queryStr = "SELECT * FROM DELIVERY_ORDER";
            query.CommandText = queryStr;
            adapter.Fill(dataset, "DELIVERY_ORDER");

            queryStr = "SELECT * FROM PENGIRIMAN";
            query.CommandText = queryStr;
            adapter.Fill(dataset, "PENGIRIMAN");

            string jenis = cbJenis.Text;

            CrystalReport1 report = new CrystalReport1();
            report.SetDatabaseLogon("MARIA", "maria", "localhost", "");
            report.SetDataSource(dataset);
            report.SetParameterValue("tgl", dt1);
            report.SetParameterValue("tgl2", dt2);
            report.SetParameterValue("jenis", jenis);
            crystalReportViewer1.ReportSource = report;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPilih f = new FormPilih();
            f.Show();
            this.Close();
        }
    }
}
