namespace BinaYonetimSistemi.Screens.AltEkranlar
{
    partial class BorcluAyrinti
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
            this.label2 = new System.Windows.Forms.Label();
            this.BinaDaireTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BorcList = new System.Windows.Forms.DataGridView();
            this.borcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daireSakini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binaDaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SilButon = new System.Windows.Forms.Button();
            this.borcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BorcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(309, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 68;
            this.label2.Text = "Bina ve Daire No";
            // 
            // BinaDaireTextBox
            // 
            this.BinaDaireTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BinaDaireTextBox.BackColor = System.Drawing.Color.White;
            this.BinaDaireTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BinaDaireTextBox.Enabled = false;
            this.BinaDaireTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.BinaDaireTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BinaDaireTextBox.Location = new System.Drawing.Point(313, 135);
            this.BinaDaireTextBox.Name = "BinaDaireTextBox";
            this.BinaDaireTextBox.ReadOnly = true;
            this.BinaDaireTextBox.Size = new System.Drawing.Size(233, 23);
            this.BinaDaireTextBox.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(38, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Adı Soyadı";
            // 
            // AdTextBox
            // 
            this.AdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AdTextBox.BackColor = System.Drawing.Color.White;
            this.AdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdTextBox.Enabled = false;
            this.AdTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.AdTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AdTextBox.Location = new System.Drawing.Point(42, 135);
            this.AdTextBox.Name = "AdTextBox";
            this.AdTextBox.ReadOnly = true;
            this.AdTextBox.Size = new System.Drawing.Size(233, 23);
            this.AdTextBox.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 58);
            this.label5.TabIndex = 64;
            this.label5.Text = "Borçlu";
            // 
            // BorcList
            // 
            this.BorcList.AllowUserToAddRows = false;
            this.BorcList.AllowUserToDeleteRows = false;
            this.BorcList.AllowUserToOrderColumns = true;
            this.BorcList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BorcList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BorcList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.BorcList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BorcList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BorcList.ColumnHeadersHeight = 30;
            this.BorcList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borcId,
            this.daireSakini,
            this.binaDaire,
            this.islemZamani,
            this.ucret});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BorcList.DefaultCellStyle = dataGridViewCellStyle2;
            this.BorcList.Location = new System.Drawing.Point(22, 201);
            this.BorcList.Name = "BorcList";
            this.BorcList.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.BorcList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.BorcList.Size = new System.Drawing.Size(554, 326);
            this.BorcList.TabIndex = 69;
            this.BorcList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.BorcList_CellEnter);
            // 
            // borcId
            // 
            this.borcId.HeaderText = "Borç ID";
            this.borcId.Name = "borcId";
            this.borcId.ReadOnly = true;
            this.borcId.Visible = false;
            // 
            // daireSakini
            // 
            this.daireSakini.HeaderText = "Borc Türü";
            this.daireSakini.Name = "daireSakini";
            this.daireSakini.ReadOnly = true;
            // 
            // binaDaire
            // 
            this.binaDaire.HeaderText = "Borç Adı";
            this.binaDaire.Name = "binaDaire";
            this.binaDaire.ReadOnly = true;
            // 
            // islemZamani
            // 
            this.islemZamani.HeaderText = "Borç Tarihi";
            this.islemZamani.Name = "islemZamani";
            this.islemZamani.ReadOnly = true;
            // 
            // ucret
            // 
            this.ucret.HeaderText = "Borç Tutarı";
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
            this.SilButon.Location = new System.Drawing.Point(313, 533);
            this.SilButon.Name = "SilButon";
            this.SilButon.Size = new System.Drawing.Size(263, 42);
            this.SilButon.TabIndex = 70;
            this.SilButon.Text = "Borç Sil";
            this.SilButon.UseVisualStyleBackColor = false;
            this.SilButon.Click += new System.EventHandler(this.SilButon_Click);
            // 
            // borcBindingSource
            // 
            this.borcBindingSource.DataSource = typeof(BinaYonetimSistemi.Entities.Borc);
            // 
            // BorcluAyrinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 587);
            this.Controls.Add(this.SilButon);
            this.Controls.Add(this.BorcList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BinaDaireTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdTextBox);
            this.Controls.Add(this.label5);
            this.Name = "BorcluAyrinti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borçlu Ayrıntısı";
            ((System.ComponentModel.ISupportInitialize)(this.BorcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BinaDaireTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView BorcList;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn daireSakini;
        private System.Windows.Forms.DataGridViewTextBoxColumn binaDaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
        private System.Windows.Forms.Button SilButon;
        private System.Windows.Forms.BindingSource borcBindingSource;
    }
}