using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_ACS
{
    public partial class FormPilih : Form
    {
        public FormPilih()
        {
            InitializeComponent();
        }

        private void btnJasa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPegawai_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDO_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHarga_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            
        }

        private void FormPilih_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            //f.Show();
            this.Close();
        }

        private void FormPilih_Load(object sender, EventArgs e)
        {

        }

        private void pbJenisJasa_Click(object sender, EventArgs e)
        {
            FormJenisJasa f = new FormJenisJasa();
            f.Show();
            this.Hide();
        }

        private void pbPegawai_Click(object sender, EventArgs e)
        {
            FormPegawai f = new FormPegawai();
            f.Show();
            this.Hide();
        }

        private void pbHarga_Click(object sender, EventArgs e)
        {
            FormHarga f = new FormHarga();
            f.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormCustomer f = new FormCustomer();
            f.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormDO f = new FormDO();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport();
            f.Show();
            this.Hide();
        }
    }
}
