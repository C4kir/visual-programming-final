namespace SigortaProgramı
{
    partial class police
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(police));
            this.btnSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataPolice = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSirket = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboMusteri = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblEnCok = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEnCok2 = new System.Windows.Forms.Label();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPolice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "sil.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(654, 127);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 67);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.ImageKey = "guncelle.png";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(578, 127);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(70, 67);
            this.btnGuncelle.TabIndex = 33;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // comboTur
            // 
            this.comboTur.DisplayMember = "sigorta_turu";
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Location = new System.Drawing.Point(219, 75);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(172, 21);
            this.comboTur.TabIndex = 32;
            this.comboTur.ValueMember = "sigorta_turu";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(219, 179);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(172, 20);
            this.txtID.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "ID :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(219, 153);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(172, 20);
            this.txtFiyat.TabIndex = 28;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fiyat :";
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(219, 127);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(172, 20);
            this.txtBitis.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Poliçe Bitiş Tarihi :";
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(219, 101);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(172, 20);
            this.txtBaslangic.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Poliçe Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sigorta Türü :";
            // 
            // dataPolice
            // 
            this.dataPolice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPolice.Location = new System.Drawing.Point(93, 235);
            this.dataPolice.Name = "dataPolice";
            this.dataPolice.Size = new System.Drawing.Size(642, 208);
            this.dataPolice.TabIndex = 21;
            this.dataPolice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPolice_CellDoubleClick);
            this.dataPolice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataPolice_KeyPress);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.ImageKey = "ekle.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(502, 127);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(70, 67);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Müşteri Seç :";
            // 
            // comboSirket
            // 
            this.comboSirket.FormattingEnabled = true;
            this.comboSirket.Location = new System.Drawing.Point(219, 48);
            this.comboSirket.Name = "comboSirket";
            this.comboSirket.Size = new System.Drawing.Size(172, 21);
            this.comboSirket.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Şirket Seç :";
            // 
            // comboMusteri
            // 
            this.comboMusteri.FormattingEnabled = true;
            this.comboMusteri.Location = new System.Drawing.Point(219, 21);
            this.comboMusteri.Name = "comboMusteri";
            this.comboMusteri.Size = new System.Drawing.Size(172, 21);
            this.comboMusteri.TabIndex = 39;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "ara.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(618, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 38);
            this.button3.TabIndex = 40;
            this.button3.Text = "Poliçe Ara";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblEnCok
            // 
            this.lblEnCok.AutoSize = true;
            this.lblEnCok.Location = new System.Drawing.Point(279, 446);
            this.lblEnCok.Name = "lblEnCok";
            this.lblEnCok.Size = new System.Drawing.Size(45, 13);
            this.lblEnCok.TabIndex = 41;
            this.lblEnCok.Text = "En Çok ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "En Çok Poliçe Kesilen Sigorta Türü :";
            // 
            // lblEnCok2
            // 
            this.lblEnCok2.AutoSize = true;
            this.lblEnCok2.Location = new System.Drawing.Point(279, 462);
            this.lblEnCok2.Name = "lblEnCok2";
            this.lblEnCok2.Size = new System.Drawing.Size(45, 13);
            this.lblEnCok2.TabIndex = 43;
            this.lblEnCok2.Text = "En Çok ";
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataSource = typeof(SigortaProgramı.musteri);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "En Çok Poliçe Kesilen Şirket :";
            // 
            // police
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 499);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEnCok2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEnCok);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboMusteri);
            this.Controls.Add(this.comboSirket);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.comboTur);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBaslangic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataPolice);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(828, 538);
            this.MinimumSize = new System.Drawing.Size(828, 538);
            this.Name = "police";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliçe Sayfası";
            this.Load += new System.EventHandler(this.police_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPolice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox comboTur;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataPolice;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private System.Windows.Forms.ComboBox comboSirket;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboMusteri;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lblEnCok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEnCok2;
        private System.Windows.Forms.Label label9;
    }
}