namespace BinaYonetimSistemi.Screens.AltEkranlar
{
    partial class BorcListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorcListele));
            this.label5 = new System.Windows.Forms.Label();
            this.BorcListesi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BorcListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 58);
            this.label5.TabIndex = 31;
            this.label5.Text = "Borçları Listele";
            // 
            // BorcListesi
            // 
            this.BorcListesi.AllowUserToAddRows = false;
            this.BorcListesi.AllowUserToOrderColumns = true;
            this.BorcListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BorcListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BorcListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.BorcListesi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BorcListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BorcListesi.ColumnHeadersHeight = 30;
            this.BorcListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.faturaNo,
            this.borcTuru,
            this.faturaTutari,
            this.borcTarihi,
            this.odemeZamani});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BorcListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.BorcListesi.Location = new System.Drawing.Point(12, 85);
            this.BorcListesi.Name = "BorcListesi";
            this.BorcListesi.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 10F);
            dataGridViewCellStyle3.NullValue = "Ödenmedi";
            this.BorcListesi.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.BorcListesi.Size = new System.Drawing.Size(844, 353);
            this.BorcListesi.TabIndex = 0;
            this.BorcListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BorcListesi_CellDoubleClick);
            this.BorcListesi.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // faturaNo
            // 
            this.faturaNo.HeaderText = "Fatura No";
            this.faturaNo.Name = "faturaNo";
            this.faturaNo.ReadOnly = true;
            // 
            // borcTuru
            // 
            this.borcTuru.HeaderText = "Borç Türü";
            this.borcTuru.Name = "borcTuru";
            this.borcTuru.ReadOnly = true;
            // 
            // faturaTutari
            // 
            this.faturaTutari.HeaderText = "Fatura Tutarı";
            this.faturaTutari.Name = "faturaTutari";
            this.faturaTutari.ReadOnly = true;
            // 
            // borcTarihi
            // 
            this.borcTarihi.HeaderText = "Borç Tarihi";
            this.borcTarihi.Name = "borcTarihi";
            this.borcTarihi.ReadOnly = true;
            // 
            // odemeZamani
            // 
            this.odemeZamani.HeaderText = "Ödeme Zamanı";
            this.odemeZamani.Name = "odemeZamani";
            this.odemeZamani.ReadOnly = true;
            // 
            // BorcListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BorcListesi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorcListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borçları Listele";
            this.Activated += new System.EventHandler(this.BorcListele_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.BorcListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView BorcListesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeZamani;
    }
}