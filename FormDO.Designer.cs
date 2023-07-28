
namespace Proyek_ACS
{
    partial class FormDO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDO));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKode = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudBerat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLayanan = new System.Windows.Forms.ComboBox();
            this.cbPengirim = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudP = new System.Windows.Forms.NumericUpDown();
            this.nudL = new System.Windows.Forms.NumericUpDown();
            this.nudT = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPenerima = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbKurir = new System.Windows.Forms.ComboBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.rbLangsung = new System.Windows.Forms.RadioButton();
            this.rbPeriode = new System.Windows.Forms.RadioButton();
            this.lblHarga = new System.Windows.Forms.Label();
            this.cbMetode = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbJenis = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBerat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 60);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(756, 312);
            this.dgvData.TabIndex = 7;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delivery Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama Barang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(50, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kode Resi :";
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.BackColor = System.Drawing.Color.Transparent;
            this.lblKode.Location = new System.Drawing.Point(151, 412);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(57, 19);
            this.lblKode.TabIndex = 10;
            this.lblKode.Text = "[KODE]";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(155, 442);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(211, 23);
            this.tbNama.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(26, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Berat Barang :";
            // 
            // nudBerat
            // 
            this.nudBerat.Location = new System.Drawing.Point(155, 478);
            this.nudBerat.Name = "nudBerat";
            this.nudBerat.Size = new System.Drawing.Size(179, 23);
            this.nudBerat.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(340, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(35, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kota Tujuan :";
            // 
            // cbLayanan
            // 
            this.cbLayanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayanan.FormattingEnabled = true;
            this.cbLayanan.Location = new System.Drawing.Point(155, 554);
            this.cbLayanan.Name = "cbLayanan";
            this.cbLayanan.Size = new System.Drawing.Size(211, 25);
            this.cbLayanan.TabIndex = 16;
            this.cbLayanan.SelectedIndexChanged += new System.EventHandler(this.cbLayanan_SelectedIndexChanged);
            // 
            // cbPengirim
            // 
            this.cbPengirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPengirim.FormattingEnabled = true;
            this.cbPengirim.Location = new System.Drawing.Point(590, 409);
            this.cbPengirim.Name = "cbPengirim";
            this.cbPengirim.Size = new System.Drawing.Size(178, 25);
            this.cbPengirim.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(10, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Volume Barang :";
            // 
            // nudP
            // 
            this.nudP.Location = new System.Drawing.Point(155, 516);
            this.nudP.Name = "nudP";
            this.nudP.Size = new System.Drawing.Size(52, 23);
            this.nudP.TabIndex = 21;
            // 
            // nudL
            // 
            this.nudL.Location = new System.Drawing.Point(235, 515);
            this.nudL.Name = "nudL";
            this.nudL.Size = new System.Drawing.Size(52, 23);
            this.nudL.TabIndex = 22;
            // 
            // nudT
            // 
            this.nudT.Location = new System.Drawing.Point(314, 516);
            this.nudT.Name = "nudT";
            this.nudT.Size = new System.Drawing.Size(52, 23);
            this.nudT.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 519);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(452, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Nama Pengirim :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(445, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "Nama Penerima :";
            // 
            // tbPenerima
            // 
            this.tbPenerima.Location = new System.Drawing.Point(590, 442);
            this.tbPenerima.Name = "tbPenerima";
            this.tbPenerima.Size = new System.Drawing.Size(178, 23);
            this.tbPenerima.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(458, 480);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "Alamat Tujuan :";
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(590, 477);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(178, 73);
            this.tbAlamat.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(499, 557);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 19);
            this.label15.TabIndex = 31;
            this.label15.Text = "Pilih Kurir :";
            // 
            // cbKurir
            // 
            this.cbKurir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKurir.FormattingEnabled = true;
            this.cbKurir.Location = new System.Drawing.Point(590, 554);
            this.cbKurir.Name = "cbKurir";
            this.cbKurir.Size = new System.Drawing.Size(178, 25);
            this.cbKurir.TabIndex = 32;
            // 
            // btnKirim
            // 
            this.btnKirim.BackColor = System.Drawing.Color.Green;
            this.btnKirim.FlatAppearance.BorderSize = 0;
            this.btnKirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKirim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKirim.ForeColor = System.Drawing.Color.White;
            this.btnKirim.Location = new System.Drawing.Point(631, 702);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(137, 50);
            this.btnKirim.TabIndex = 33;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = false;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(26, 633);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 19);
            this.label16.TabIndex = 34;
            this.label16.Text = "Pembayaran :";
            // 
            // rbLangsung
            // 
            this.rbLangsung.AutoSize = true;
            this.rbLangsung.BackColor = System.Drawing.Color.Transparent;
            this.rbLangsung.Checked = true;
            this.rbLangsung.Location = new System.Drawing.Point(156, 630);
            this.rbLangsung.Name = "rbLangsung";
            this.rbLangsung.Size = new System.Drawing.Size(140, 23);
            this.rbLangsung.TabIndex = 35;
            this.rbLangsung.TabStop = true;
            this.rbLangsung.Text = "Bayar Langsung";
            this.rbLangsung.UseVisualStyleBackColor = false;
            this.rbLangsung.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbLangsung_MouseClick);
            // 
            // rbPeriode
            // 
            this.rbPeriode.AutoSize = true;
            this.rbPeriode.BackColor = System.Drawing.Color.Transparent;
            this.rbPeriode.Location = new System.Drawing.Point(302, 630);
            this.rbPeriode.Name = "rbPeriode";
            this.rbPeriode.Size = new System.Drawing.Size(207, 23);
            this.rbPeriode.TabIndex = 36;
            this.rbPeriode.TabStop = true;
            this.rbPeriode.Text = "Bayar Akhir Bulan/Periode";
            this.rbPeriode.UseVisualStyleBackColor = false;
            this.rbPeriode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbPeriode_MouseClick);
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.BackColor = System.Drawing.Color.Transparent;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(564, 14);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(27, 29);
            this.lblHarga.TabIndex = 38;
            this.lblHarga.Text = "0";
            // 
            // cbMetode
            // 
            this.cbMetode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetode.FormattingEnabled = true;
            this.cbMetode.Items.AddRange(new object[] {
            "Tunai",
            "GO-PAY",
            "SHOPEE-PAY",
            "BCA"});
            this.cbMetode.Location = new System.Drawing.Point(181, 669);
            this.cbMetode.Name = "cbMetode";
            this.cbMetode.Size = new System.Drawing.Size(185, 25);
            this.cbMetode.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(8, 669);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 19);
            this.label17.TabIndex = 40;
            this.label17.Text = "Metode Pembayaran :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(498, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "Rp. ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(47, 597);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 19);
            this.label18.TabIndex = 42;
            this.label18.Text = "Jenis Jasa :";
            // 
            // cbJenis
            // 
            this.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Location = new System.Drawing.Point(155, 594);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(211, 25);
            this.cbJenis.TabIndex = 43;
            this.cbJenis.SelectedIndexChanged += new System.EventHandler(this.cbJenis_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(488, 702);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 50);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 718);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 34);
            this.button1.TabIndex = 45;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(179, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // FormDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 762);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbJenis);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbMetode);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.rbPeriode);
            this.Controls.Add(this.rbLangsung);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.cbKurir);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbPenerima);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudT);
            this.Controls.Add(this.nudL);
            this.Controls.Add(this.nudP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPengirim);
            this.Controls.Add(this.cbLayanan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudBerat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblKode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBerat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudBerat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLayanan;
        private System.Windows.Forms.ComboBox cbPengirim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudP;
        private System.Windows.Forms.NumericUpDown nudL;
        private System.Windows.Forms.NumericUpDown nudT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPenerima;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbKurir;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbLangsung;
        private System.Windows.Forms.RadioButton rbPeriode;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.ComboBox cbMetode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbJenis;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}