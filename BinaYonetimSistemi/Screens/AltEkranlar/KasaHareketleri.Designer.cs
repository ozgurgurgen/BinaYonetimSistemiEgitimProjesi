namespace BinaYonetimSistemi.Screens.AltEkranlar
{
    partial class KasaHareketleri
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
            this.label5 = new System.Windows.Forms.Label();
            this.KasaHareketleriList = new System.Windows.Forms.DataGridView();
            this.hareketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daireSakini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasadanMi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ToplamKasaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KasaHareketleriList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 58);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kasa Hareketleri";
            // 
            // KasaHareketleriList
            // 
            this.KasaHareketleriList.AllowUserToAddRows = false;
            this.KasaHareketleriList.AllowUserToDeleteRows = false;
            this.KasaHareketleriList.AllowUserToOrderColumns = true;
            this.KasaHareketleriList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KasaHareketleriList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KasaHareketleriList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.KasaHareketleriList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KasaHareketleriList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.KasaHareketleriList.ColumnHeadersHeight = 30;
            this.KasaHareketleriList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hareketId,
            this.daireSakini,
            this.islemZamani,
            this.ucret,
            this.kasadanMi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KasaHareketleriList.DefaultCellStyle = dataGridViewCellStyle2;
            this.KasaHareketleriList.Location = new System.Drawing.Point(12, 200);
            this.KasaHareketleriList.Name = "KasaHareketleriList";
            this.KasaHareketleriList.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.KasaHareketleriList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.KasaHareketleriList.Size = new System.Drawing.Size(776, 238);
            this.KasaHareketleriList.TabIndex = 32;
            this.KasaHareketleriList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KasaHareketleriList_CellDoubleClick);
            // 
            // hareketId
            // 
            this.hareketId.HeaderText = "Harket Id";
            this.hareketId.Name = "hareketId";
            this.hareketId.ReadOnly = true;
            this.hareketId.Visible = false;
            // 
            // daireSakini
            // 
            this.daireSakini.HeaderText = "Ödeme Yapan";
            this.daireSakini.Name = "daireSakini";
            this.daireSakini.ReadOnly = true;
            // 
            // islemZamani
            // 
            this.islemZamani.HeaderText = "İşlem Zamanı";
            this.islemZamani.Name = "islemZamani";
            this.islemZamani.ReadOnly = true;
            // 
            // ucret
            // 
            this.ucret.HeaderText = "Ücret";
            this.ucret.Name = "ucret";
            this.ucret.ReadOnly = true;
            // 
            // kasadanMi
            // 
            this.kasadanMi.HeaderText = "Kasadan Mı?";
            this.kasadanMi.Name = "kasadanMi";
            this.kasadanMi.ReadOnly = true;
            this.kasadanMi.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(287, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Kasa Hareketleri";
            // 
            // ToplamKasaLabel
            // 
            this.ToplamKasaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToplamKasaLabel.AutoSize = true;
            this.ToplamKasaLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamKasaLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ToplamKasaLabel.Location = new System.Drawing.Point(25, 127);
            this.ToplamKasaLabel.MaximumSize = new System.Drawing.Size(816, 40);
            this.ToplamKasaLabel.MinimumSize = new System.Drawing.Size(750, 0);
            this.ToplamKasaLabel.Name = "ToplamKasaLabel";
            this.ToplamKasaLabel.Size = new System.Drawing.Size(750, 39);
            this.ToplamKasaLabel.TabIndex = 35;
            this.ToplamKasaLabel.Text = "0 ₺";
            this.ToplamKasaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToplamKasaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KasaHareketleriList);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "KasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.KasaHareketleriList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView KasaHareketleriList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ToplamKasaLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn daireSakini;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasadanMi;
    }
}