namespace BinaYonetimSistemi
{
    partial class GirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();                
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.KullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ParolaTextBox = new System.Windows.Forms.TextBox();
            this.GirisButon = new System.Windows.Forms.Button();
            this.IptalButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KullaniciAdiTextBox
            // 
            this.KullaniciAdiTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.KullaniciAdiTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            resources.ApplyResources(this.KullaniciAdiTextBox, "KullaniciAdiTextBox");
            this.KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // ParolaTextBox
            // 
            resources.ApplyResources(this.ParolaTextBox, "ParolaTextBox");
            this.ParolaTextBox.Name = "ParolaTextBox";
            // 
            // GirisButon
            // 
            this.GirisButon.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.GirisButon, "GirisButon");
            this.GirisButon.ForeColor = System.Drawing.Color.Snow;
            this.GirisButon.Name = "GirisButon";
            this.GirisButon.UseVisualStyleBackColor = false;
            this.GirisButon.Click += new System.EventHandler(this.GirisButon_Click);
            // 
            // IptalButon
            // 
            this.IptalButon.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.IptalButon, "IptalButon");
            this.IptalButon.ForeColor = System.Drawing.Color.Snow;
            this.IptalButon.Name = "IptalButon";
            this.IptalButon.UseVisualStyleBackColor = false;
            this.IptalButon.Click += new System.EventHandler(this.IptalButon_Click);
            // 
            // GirisEkrani
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::BinaYonetimSistemi.Properties.Resources.background_Login;
            this.Controls.Add(this.IptalButon);
            this.Controls.Add(this.GirisButon);
            this.Controls.Add(this.ParolaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KullaniciAdiTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisEkrani";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KullaniciAdiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ParolaTextBox;
        private System.Windows.Forms.Button GirisButon;
        private System.Windows.Forms.Button IptalButon;
    }
}

