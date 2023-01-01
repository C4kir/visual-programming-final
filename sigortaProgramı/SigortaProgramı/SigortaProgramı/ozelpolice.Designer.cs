namespace SigortaProgramı
{
    partial class ozelpolice
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
            this.comboMusteri = new System.Windows.Forms.ComboBox();
            this.comboSirket = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataPolice)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMusteri
            // 
            this.comboMusteri.FormattingEnabled = true;
            this.comboMusteri.Location = new System.Drawing.Point(152, 13);
            this.comboMusteri.Name = "comboMusteri";
            this.comboMusteri.Size = new System.Drawing.Size(172, 21);
            this.comboMusteri.TabIndex = 57;
            // 
            // comboSirket
            // 
            this.comboSirket.FormattingEnabled = true;
            this.comboSirket.Location = new System.Drawing.Point(152, 40);
            this.comboSirket.Name = "comboSirket";
            this.comboSirket.Size = new System.Drawing.Size(172, 21);
            this.comboSirket.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Şirket Seç :";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(391, 153);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(117, 38);
            this.btnSil.TabIndex = 54;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(391, 96);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 38);
            this.btnGuncelle.TabIndex = 53;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // comboTur
            // 
            this.comboTur.DisplayMember = "sigorta_turu";
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Location = new System.Drawing.Point(152, 67);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(172, 21);
            this.comboTur.TabIndex = 52;
            this.comboTur.ValueMember = "sigorta_turu";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(152, 171);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(172, 20);
            this.txtID.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "ID :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(152, 145);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(172, 20);
            this.txtFiyat.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Fiyat :";
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(152, 119);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(172, 20);
            this.txtBitis.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Poliçe Bitiş Tarihi :";
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(152, 93);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(172, 20);
            this.txtBaslangic.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Poliçe Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Sigorta Türü :";
            // 
            // dataPolice
            // 
            this.dataPolice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPolice.Location = new System.Drawing.Point(26, 227);
            this.dataPolice.Name = "dataPolice";
            this.dataPolice.Size = new System.Drawing.Size(642, 208);
            this.dataPolice.TabIndex = 42;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(391, 41);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(117, 38);
            this.btnEkle.TabIndex = 41;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Müşteri Seç :";
            // 
            // ozelpolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 460);
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
            this.Name = "ozelpolice";
            this.Text = "ozelpolice";
            this.Load += new System.EventHandler(this.ozelpolice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPolice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMusteri;
        private System.Windows.Forms.ComboBox comboSirket;
        private System.Windows.Forms.Label label7;
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
    }
}