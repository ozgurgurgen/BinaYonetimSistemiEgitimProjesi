namespace BinaYonetimSistemi.Screens.AltEkranlar
{
    partial class DuyuruListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToplamDuyuruLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DuyuruList = new System.Windows.Forms.DataGridView();
            this.hareketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daireSakini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duyurularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DuyuruList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyurularBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ToplamDuyuruLabel
            // 
            this.ToplamDuyuruLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToplamDuyuruLabel.AutoSize = true;
            this.ToplamDuyuruLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamDuyuruLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ToplamDuyuruLabel.Location = new System.Drawing.Point(25, 127);
            this.ToplamDuyuruLabel.MaximumSize = new System.Drawing.Size(816, 40);
            this.ToplamDuyuruLabel.MinimumSize = new System.Drawing.Size(750, 0);
            this.ToplamDuyuruLabel.Name = "ToplamDuyuruLabel";
            this.ToplamDuyuruLabel.Size = new System.Drawing.Size(750, 39);
            this.ToplamDuyuruLabel.TabIndex = 39;
            this.ToplamDuyuruLabel.Text = "0";
            this.ToplamDuyuruLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(315, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 38;
            this.label1.Text = "Aktif Duyuru";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 58);
            this.label5.TabIndex = 37;
            this.label5.Text = "Duyurular";
            // 
            // DuyuruList
            // 
            this.DuyuruList.AllowUserToAddRows = false;
            this.DuyuruList.AllowUserToDeleteRows = false;
            this.DuyuruList.AllowUserToOrderColumns = true;
            this.DuyuruList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DuyuruList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DuyuruList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DuyuruList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DuyuruList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DuyuruList.ColumnHeadersHeight = 30;
            this.DuyuruList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hareketId,
            this.daireSakini,
            this.islemZamani,
            this.ucret});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DuyuruList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DuyuruList.Location = new System.Drawing.Point(12, 200);
            this.DuyuruList.Name = "DuyuruList";
            this.DuyuruList.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.DuyuruList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DuyuruList.Size = new System.Drawing.Size(776, 238);
            this.DuyuruList.TabIndex = 36;
            this.DuyuruList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DuyuruList_CellDoubleClick);
            // 
            // hareketId
            // 
            this.hareketId.HeaderText = "Id";
            this.hareketId.Name = "hareketId";
            this.hareketId.ReadOnly = true;
            this.hareketId.Visible = false;
            // 
            // daireSakini
            // 
            this.daireSakini.HeaderText = "Duyuru Başlığı";
            this.daireSakini.Name = "daireSakini";
            this.daireSakini.ReadOnly = true;
            // 
            // islemZamani
            // 
            this.islemZamani.HeaderText = "Duyuru Tarihi";
            this.islemZamani.Name = "islemZamani";
            this.islemZamani.ReadOnly = true;
            // 
            // ucret
            // 
            this.ucret.HeaderText = "Geçerlilik Süresi";
            this.ucret.Name = "ucret";
            this.ucret.ReadOnly = true;
            // 
            // duyurularBindingSource
            // 
            this.duyurularBindingSource.DataSource = typeof(BinaYonetimSistemi.Entities.Duyurular);
            // 
            // DuyuruListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToplamDuyuruLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DuyuruList);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "DuyuruListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyuru Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.DuyuruList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyurularBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ToplamDuyuruLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DuyuruList;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn daireSakini;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
        private System.Windows.Forms.BindingSource duyurularBindingSource;
    }
}