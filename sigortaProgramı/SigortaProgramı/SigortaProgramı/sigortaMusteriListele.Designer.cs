namespace SigortaProgramı
{
    partial class sigortaMusteriListele
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sigortaMusteriListele));
            this.label6 = new System.Windows.Forms.Label();
            this.txtSigortaAdi = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSigortaTuru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSirketIsmi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoliceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoliceBaslangic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPoliceBitis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Sigorta Türü :";
            // 
            // txtSigortaAdi
            // 
            this.txtSigortaAdi.Location = new System.Drawing.Point(652, 273);
            this.txtSigortaAdi.Name = "txtSigortaAdi";
            this.txtSigortaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSigortaAdi.TabIndex = 55;
            this.txtSigortaAdi.TextChanged += new System.EventHandler(this.txtSigortaAdi_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "sil.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(677, 299);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 57);
            this.btnSil.TabIndex = 54;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 205);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageKey = "guncelle.png";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(132, 244);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 35);
            this.btnGuncelle.TabIndex = 65;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSigortaTuru
            // 
            this.txtSigortaTuru.Location = new System.Drawing.Point(132, 140);
            this.txtSigortaTuru.Name = "txtSigortaTuru";
            this.txtSigortaTuru.Size = new System.Drawing.Size(100, 20);
            this.txtSigortaTuru.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Sigorta Türü :";
            // 
            // txtSirketIsmi
            // 
            this.txtSirketIsmi.Location = new System.Drawing.Point(132, 114);
            this.txtSirketIsmi.Name = "txtSirketIsmi";
            this.txtSirketIsmi.Size = new System.Drawing.Size(100, 20);
            this.txtSirketIsmi.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Şirket İsmi :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(132, 88);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Ad Soyad :";
            // 
            // txtPoliceID
            // 
            this.txtPoliceID.Location = new System.Drawing.Point(132, 62);
            this.txtPoliceID.Name = "txtPoliceID";
            this.txtPoliceID.Size = new System.Drawing.Size(100, 20);
            this.txtPoliceID.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Poliçe ID :";
            // 
            // txtPoliceBaslangic
            // 
            this.txtPoliceBaslangic.Location = new System.Drawing.Point(132, 166);
            this.txtPoliceBaslangic.Name = "txtPoliceBaslangic";
            this.txtPoliceBaslangic.Size = new System.Drawing.Size(100, 20);
            this.txtPoliceBaslangic.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Poliçe Başlangıç :";
            // 
            // txtPoliceBitis
            // 
            this.txtPoliceBitis.Location = new System.Drawing.Point(132, 192);
            this.txtPoliceBitis.Name = "txtPoliceBitis";
            this.txtPoliceBitis.Size = new System.Drawing.Size(100, 20);
            this.txtPoliceBitis.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Poliçe Bitiş :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(132, 218);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Fiyat :";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekle.png");
            this.ımageList1.Images.SetKeyName(1, "guncelle.png");
            this.ımageList1.Images.SetKeyName(2, "sil.png");
            this.ımageList1.Images.SetKeyName(3, "ara.png");
            // 
            // sigortaMusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 362);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPoliceBitis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPoliceBaslangic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtSigortaTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSirketIsmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPoliceID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSigortaAdi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(824, 401);
            this.MinimumSize = new System.Drawing.Size(824, 401);
            this.Name = "sigortaMusteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sigorta Müşteri Listele";
            this.Load += new System.EventHandler(this.sigortaMusteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSigortaAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSigortaTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSirketIsmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoliceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoliceBaslangic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPoliceBitis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList ımageList1;
    }
}