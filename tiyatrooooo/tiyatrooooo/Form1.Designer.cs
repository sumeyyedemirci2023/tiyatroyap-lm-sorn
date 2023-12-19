namespace tiyatrooooo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.cmbAd = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbSahne = new System.Windows.Forms.ComboBox();
            this.chkMuzikal = new System.Windows.Forms.CheckBox();
            this.nupOyunSuresi = new System.Windows.Forms.NumericUpDown();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOyunSuresi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "OYUN ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "OYUN AD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TARİH - SAAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SAHNE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(429, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "FİYAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(429, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "OYUN SÜRESİ";
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(0, 181);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(716, 129);
            this.dgvListe.TabIndex = 6;
            this.dgvListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellContentClick);
            this.dgvListe.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellEnter);
            // 
            // cmbAd
            // 
            this.cmbAd.FormattingEnabled = true;
            this.cmbAd.Items.AddRange(new object[] {
            "DOĞA",
            "OKUL",
            "ŞAİR EVLENMESİ",
            "HEİDİ",
            "PAMUK PRENSES",
            "KÜL KEDİSİ",
            "RAPUNZEL"});
            this.cmbAd.Location = new System.Drawing.Point(138, 53);
            this.cmbAd.Name = "cmbAd";
            this.cmbAd.Size = new System.Drawing.Size(121, 21);
            this.cmbAd.TabIndex = 10;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(138, 102);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(138, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 12;
            // 
            // cmbSahne
            // 
            this.cmbSahne.FormattingEnabled = true;
            this.cmbSahne.Items.AddRange(new object[] {
            "DOĞA",
            "ÇAYIR",
            "AVM",
            "OKUL",
            "SPOR SALONU",
            "PARK",
            "BAHÇE",
            "SAHİL"});
            this.cmbSahne.Location = new System.Drawing.Point(138, 141);
            this.cmbSahne.Name = "cmbSahne";
            this.cmbSahne.Size = new System.Drawing.Size(121, 21);
            this.cmbSahne.TabIndex = 13;
            // 
            // chkMuzikal
            // 
            this.chkMuzikal.AutoSize = true;
            this.chkMuzikal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkMuzikal.Location = new System.Drawing.Point(429, 12);
            this.chkMuzikal.Name = "chkMuzikal";
            this.chkMuzikal.Size = new System.Drawing.Size(89, 20);
            this.chkMuzikal.TabIndex = 14;
            this.chkMuzikal.Text = "MÜZİKAL";
            this.chkMuzikal.UseVisualStyleBackColor = true;
            // 
            // nupOyunSuresi
            // 
            this.nupOyunSuresi.Location = new System.Drawing.Point(566, 71);
            this.nupOyunSuresi.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.nupOyunSuresi.Name = "nupOyunSuresi";
            this.nupOyunSuresi.Size = new System.Drawing.Size(120, 20);
            this.nupOyunSuresi.TabIndex = 15;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(566, 43);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(120, 20);
            this.txtFiyat.TabIndex = 16;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Image = global::tiyatrooooo.Properties.Resources._001_refresh;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(611, 108);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 54);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::tiyatrooooo.Properties.Resources._003_bin;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(520, 111);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 54);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = global::tiyatrooooo.Properties.Resources._002_diskette__1_;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.Location = new System.Drawing.Point(429, 111);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 54);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "ekle";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 317);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.nupOyunSuresi);
            this.Controls.Add(this.chkMuzikal);
            this.Controls.Add(this.cmbSahne);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbAd);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOyunSuresi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbAd;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbSahne;
        private System.Windows.Forms.CheckBox chkMuzikal;
        private System.Windows.Forms.NumericUpDown nupOyunSuresi;
        private System.Windows.Forms.TextBox txtFiyat;
    }
}

