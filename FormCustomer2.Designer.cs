
namespace Proyek_ACS
{
    partial class FormCustomer2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer2));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblNama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtStatus = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblKurir = new System.Windows.Forms.Label();
            this.lblJasa = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblPenerima = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblBerat = new System.Windows.Forms.Label();
            this.lblBarang = new System.Windows.Forms.Label();
            this.lblResi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(17, 87);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(324, 460);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.BackColor = System.Drawing.Color.Transparent;
            this.lblNama.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(12, 10);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(133, 27);
            this.lblNama.TabIndex = 7;
            this.lblNama.Text = "Welcome, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Detail Barang";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtStatus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblKurir);
            this.panel1.Controls.Add(this.lblJasa);
            this.panel1.Controls.Add(this.lblAlamat);
            this.panel1.Controls.Add(this.lblPenerima);
            this.panel1.Controls.Add(this.lblVolume);
            this.panel1.Controls.Add(this.lblBerat);
            this.panel1.Controls.Add(this.lblBarang);
            this.panel1.Controls.Add(this.lblResi);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblHarga);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(347, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 460);
            this.panel1.TabIndex = 9;
            // 
            // rtStatus
            // 
            this.rtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtStatus.Location = new System.Drawing.Point(346, 3);
            this.rtStatus.Name = "rtStatus";
            this.rtStatus.ReadOnly = true;
            this.rtStatus.Size = new System.Drawing.Size(434, 453);
            this.rtStatus.TabIndex = 20;
            this.rtStatus.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(168, 422);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(24, 19);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "[-]";
            // 
            // lblKurir
            // 
            this.lblKurir.AutoSize = true;
            this.lblKurir.Location = new System.Drawing.Point(62, 333);
            this.lblKurir.Name = "lblKurir";
            this.lblKurir.Size = new System.Drawing.Size(24, 19);
            this.lblKurir.TabIndex = 17;
            this.lblKurir.Text = "[-]";
            // 
            // lblJasa
            // 
            this.lblJasa.AutoSize = true;
            this.lblJasa.Location = new System.Drawing.Point(104, 288);
            this.lblJasa.Name = "lblJasa";
            this.lblJasa.Size = new System.Drawing.Size(24, 19);
            this.lblJasa.TabIndex = 16;
            this.lblJasa.Text = "[-]";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(131, 240);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(24, 19);
            this.lblAlamat.TabIndex = 15;
            this.lblAlamat.Text = "[-]";
            // 
            // lblPenerima
            // 
            this.lblPenerima.AutoSize = true;
            this.lblPenerima.Location = new System.Drawing.Point(95, 196);
            this.lblPenerima.Name = "lblPenerima";
            this.lblPenerima.Size = new System.Drawing.Size(24, 19);
            this.lblPenerima.TabIndex = 14;
            this.lblPenerima.Text = "[-]";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(137, 149);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(24, 19);
            this.lblVolume.TabIndex = 13;
            this.lblVolume.Text = "[-]";
            // 
            // lblBerat
            // 
            this.lblBerat.AutoSize = true;
            this.lblBerat.Location = new System.Drawing.Point(123, 103);
            this.lblBerat.Name = "lblBerat";
            this.lblBerat.Size = new System.Drawing.Size(24, 19);
            this.lblBerat.TabIndex = 12;
            this.lblBerat.Text = "[-]";
            // 
            // lblBarang
            // 
            this.lblBarang.AutoSize = true;
            this.lblBarang.Location = new System.Drawing.Point(125, 56);
            this.lblBarang.Name = "lblBarang";
            this.lblBarang.Size = new System.Drawing.Size(24, 19);
            this.lblBarang.TabIndex = 11;
            this.lblBarang.Text = "[-]";
            // 
            // lblResi
            // 
            this.lblResi.AutoSize = true;
            this.lblResi.Location = new System.Drawing.Point(111, 16);
            this.lblResi.Name = "lblResi";
            this.lblResi.Size = new System.Drawing.Size(24, 19);
            this.lblResi.TabIndex = 10;
            this.lblResi.Text = "[-]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Status Pembayaran :";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(8, 376);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(48, 24);
            this.lblHarga.TabIndex = 8;
            this.lblHarga.Text = "Rp. ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Kurir :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Jenis Jasa :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Alamat Tujuan :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Penerima :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Volume Barang :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nomor Resi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Berat Barang :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Barang :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1047, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 48;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCustomer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.dgvData);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCustomer2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblKurir;
        private System.Windows.Forms.Label lblJasa;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblPenerima;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblBerat;
        private System.Windows.Forms.Label lblBarang;
        private System.Windows.Forms.Label lblResi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtStatus;
        private System.Windows.Forms.Button button1;
    }
}