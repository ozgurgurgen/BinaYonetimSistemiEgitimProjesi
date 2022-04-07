namespace BinaYonetimSistemi.Screens.AltEkranlar
{
    partial class DuyuruDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuyuruDuzenle));
            this.label5 = new System.Windows.Forms.Label();
            this.DuyuruList = new System.Windows.Forms.DataGridView();
            this.hareketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daireSakini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SilButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DuyuruList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 58);
            this.label5.TabIndex = 41;
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
            this.DuyuruList.Location = new System.Drawing.Point(12, 91);
            this.DuyuruList.Name = "DuyuruList";
            this.DuyuruList.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.DuyuruList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DuyuruList.Size = new System.Drawing.Size(776, 363);
            this.DuyuruList.TabIndex = 40;
            this.DuyuruList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DuyuruList_CellDoubleClick);
            this.DuyuruList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DuyuruList_CellEnter);
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
            this.ucret.HeaderText = "Duyuru Bitiş Tarihi";
            this.ucret.Name = "ucret";
            this.ucret.ReadOnly = true;
            // 
            // SilButon
            // 
            this.SilButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SilButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.SilButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SilButon.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold);
            this.SilButon.ForeColor = System.Drawing.Color.White;
            this.SilButon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SilButon.Location = new System.Drawing.Point(525, 460);
            this.SilButon.Name = "SilButon";
            this.SilButon.Size = new System.Drawing.Size(263, 42);
            this.SilButon.TabIndex = 45;
            this.SilButon.Text = "Duyuru Sil";
            this.SilButon.UseVisualStyleBackColor = false;
            this.SilButon.Click += new System.EventHandler(this.SilButon_Click);
            // 
            // DuyuruDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.SilButon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DuyuruList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DuyuruDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyuru Düzenle";
            this.Activated += new System.EventHandler(this.DuyuruDuzenle_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.DuyuruList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DuyuruList;
        private System.Windows.Forms.Button SilButon;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn daireSakini;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
    }
}