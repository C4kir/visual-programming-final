namespace SigortaProgramı
{
    partial class policeListele
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtPoliceIDAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Police ID :";
            // 
            // txtPoliceIDAra
            // 
            this.txtPoliceIDAra.Location = new System.Drawing.Point(413, 231);
            this.txtPoliceIDAra.Name = "txtPoliceIDAra";
            this.txtPoliceIDAra.Size = new System.Drawing.Size(100, 20);
            this.txtPoliceIDAra.TabIndex = 51;
            this.txtPoliceIDAra.TextChanged += new System.EventHandler(this.txtPoliceIDAra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 196);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // policeListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 277);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPoliceIDAra);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(562, 316);
            this.MinimumSize = new System.Drawing.Size(562, 316);
            this.Name = "policeListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliçe Listele";
            this.Load += new System.EventHandler(this.policeListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPoliceIDAra;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}