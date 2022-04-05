namespace BinaYonetimSistemi.Screens.AltEkranlar
{
    partial class Tamamlandi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TamamButon = new System.Windows.Forms.Button();
            this.MesajLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BinaYonetimSistemi.Properties.Resources.ok;
            this.pictureBox1.Location = new System.Drawing.Point(112, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TamamButon
            // 
            this.TamamButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(151)))));
            this.TamamButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TamamButon.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.TamamButon.ForeColor = System.Drawing.Color.White;
            this.TamamButon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TamamButon.Location = new System.Drawing.Point(178, 383);
            this.TamamButon.Name = "TamamButon";
            this.TamamButon.Size = new System.Drawing.Size(173, 42);
            this.TamamButon.TabIndex = 15;
            this.TamamButon.Text = "Tamam";
            this.TamamButon.UseVisualStyleBackColor = false;
            this.TamamButon.Click += new System.EventHandler(this.TamamButon_Click);
            // 
            // MesajLabel
            // 
            this.MesajLabel.AutoSize = true;
            this.MesajLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MesajLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MesajLabel.Location = new System.Drawing.Point(-1, 332);
            this.MesajLabel.MaximumSize = new System.Drawing.Size(537, 0);
            this.MesajLabel.MinimumSize = new System.Drawing.Size(537, 0);
            this.MesajLabel.Name = "MesajLabel";
            this.MesajLabel.Size = new System.Drawing.Size(537, 23);
            this.MesajLabel.TabIndex = 16;
            this.MesajLabel.Text = "İşlem Başarıyla Tamamlanmıştır.";
            this.MesajLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tamamlandi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.MesajLabel);
            this.Controls.Add(this.TamamButon);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tamamlandi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamamlandı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TamamButon;
        private System.Windows.Forms.Label MesajLabel;
    }
}