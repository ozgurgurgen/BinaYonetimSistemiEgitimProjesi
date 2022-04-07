namespace BinaYonetimSistemi.Screens.AltEkranlar
{
    partial class YeniDuyuru
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
            this.DuyuruBaslangic = new System.Windows.Forms.DateTimePicker();
            this.DuyuruBitis = new System.Windows.Forms.DateTimePicker();
            this.DuyuruMetniRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DuyuruBasligiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DuyuruOlusturButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DuyuruBaslangic
            // 
            this.DuyuruBaslangic.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DuyuruBaslangic.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DuyuruBaslangic.Location = new System.Drawing.Point(169, 168);
            this.DuyuruBaslangic.Name = "DuyuruBaslangic";
            this.DuyuruBaslangic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DuyuruBaslangic.Size = new System.Drawing.Size(200, 26);
            this.DuyuruBaslangic.TabIndex = 0;
            // 
            // DuyuruBitis
            // 
            this.DuyuruBitis.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuyuruBitis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold);
            this.DuyuruBitis.Location = new System.Drawing.Point(582, 168);
            this.DuyuruBitis.Name = "DuyuruBitis";
            this.DuyuruBitis.Size = new System.Drawing.Size(200, 26);
            this.DuyuruBitis.TabIndex = 1;
            // 
            // DuyuruMetniRichTextBox
            // 
            this.DuyuruMetniRichTextBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DuyuruMetniRichTextBox.Location = new System.Drawing.Point(33, 251);
            this.DuyuruMetniRichTextBox.Name = "DuyuruMetniRichTextBox";
            this.DuyuruMetniRichTextBox.Size = new System.Drawing.Size(755, 286);
            this.DuyuruMetniRichTextBox.TabIndex = 5;
            this.DuyuruMetniRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(23, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 58);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yeni Duyuru";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(29, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Duyuru Başlığı";
            // 
            // DuyuruBasligiTextBox
            // 
            this.DuyuruBasligiTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.DuyuruBasligiTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DuyuruBasligiTextBox.Location = new System.Drawing.Point(33, 107);
            this.DuyuruBasligiTextBox.Name = "DuyuruBasligiTextBox";
            this.DuyuruBasligiTextBox.Size = new System.Drawing.Size(749, 30);
            this.DuyuruBasligiTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(29, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Duyuru Başlangıç :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(472, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Duyuru Bitiş :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(29, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Duyuru Metni";
            // 
            // DuyuruOlusturButon
            // 
            this.DuyuruOlusturButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.DuyuruOlusturButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DuyuruOlusturButon.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.DuyuruOlusturButon.ForeColor = System.Drawing.Color.Snow;
            this.DuyuruOlusturButon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DuyuruOlusturButon.Location = new System.Drawing.Point(32, 551);
            this.DuyuruOlusturButon.Name = "DuyuruOlusturButon";
            this.DuyuruOlusturButon.Size = new System.Drawing.Size(755, 42);
            this.DuyuruOlusturButon.TabIndex = 14;
            this.DuyuruOlusturButon.Text = "Yeni Duyuru Oluştur";
            this.DuyuruOlusturButon.UseVisualStyleBackColor = false;
            this.DuyuruOlusturButon.Click += new System.EventHandler(this.DuyuruOlusturButon_Click);
            // 
            // YeniDuyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 608);
            this.Controls.Add(this.DuyuruOlusturButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DuyuruBasligiTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DuyuruMetniRichTextBox);
            this.Controls.Add(this.DuyuruBitis);
            this.Controls.Add(this.DuyuruBaslangic);
            this.Name = "YeniDuyuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Duyuru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DuyuruBaslangic;
        private System.Windows.Forms.DateTimePicker DuyuruBitis;
        private System.Windows.Forms.RichTextBox DuyuruMetniRichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DuyuruBasligiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DuyuruOlusturButon;
    }
}