namespace SigortaProgramı
{
    partial class sigorta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sigorta));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSigortaTuru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSigorta = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSigortaAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSigorta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "sil.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(112, 228);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(158, 42);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageKey = "guncelle.png";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(112, 180);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(158, 42);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSigortaTuru
            // 
            this.txtSigortaTuru.Location = new System.Drawing.Point(112, 91);
            this.txtSigortaTuru.Name = "txtSigortaTuru";
            this.txtSigortaTuru.Size = new System.Drawing.Size(158, 20);
            this.txtSigortaTuru.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sigorta Türü :";
            // 
            // dataSigorta
            // 
            this.dataSigorta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSigorta.Location = new System.Drawing.Point(351, 65);
            this.dataSigorta.Name = "dataSigorta";
            this.dataSigorta.Size = new System.Drawing.Size(242, 205);
            this.dataSigorta.TabIndex = 13;
            this.dataSigorta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSigorta_CellDoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageKey = "ekle.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(112, 132);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(158, 42);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(112, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 20);
            this.txtID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID :";
            // 
            // btnSigortaAra
            // 
            this.btnSigortaAra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSigortaAra.ImageKey = "ara.png";
            this.btnSigortaAra.ImageList = this.ımageList1;
            this.btnSigortaAra.Location = new System.Drawing.Point(501, 276);
            this.btnSigortaAra.Name = "btnSigortaAra";
            this.btnSigortaAra.Size = new System.Drawing.Size(92, 58);
            this.btnSigortaAra.TabIndex = 20;
            this.btnSigortaAra.Text = "Sigorta Ara";
            this.btnSigortaAra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSigortaAra.UseVisualStyleBackColor = true;
            this.btnSigortaAra.Click += new System.EventHandler(this.btnSigortaAra_Click);
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
            // sigorta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 361);
            this.Controls.Add(this.btnSigortaAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtSigortaTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataSigorta);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(673, 400);
            this.MinimumSize = new System.Drawing.Size(673, 400);
            this.Name = "sigorta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sigorta Sayfası";
            this.Load += new System.EventHandler(this.sigorta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSigorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSigortaTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataSigorta;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSigortaAra;
        private System.Windows.Forms.ImageList ımageList1;
    }
}