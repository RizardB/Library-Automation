namespace kutuphane
{
    partial class Anasayfa
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
            this.buttonUyeListele = new System.Windows.Forms.Button();
            this.buttonEmanetListele = new System.Windows.Forms.Button();
            this.buttonKitapListele = new System.Windows.Forms.Button();
            this.buttonUyelikEkle = new System.Windows.Forms.Button();
            this.buttonEmanetEkle = new System.Windows.Forms.Button();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUyeListele
            // 
            this.buttonUyeListele.BackgroundImage = global::kutuphane.Properties.Resources.uyelik2;
            this.buttonUyeListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUyeListele.Location = new System.Drawing.Point(576, 246);
            this.buttonUyeListele.Name = "buttonUyeListele";
            this.buttonUyeListele.Size = new System.Drawing.Size(100, 115);
            this.buttonUyeListele.TabIndex = 6;
            this.buttonUyeListele.Text = "Üyeleri Listele";
            this.buttonUyeListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUyeListele.UseVisualStyleBackColor = true;
            this.buttonUyeListele.Click += new System.EventHandler(this.buttonUyeListele_Click);
            // 
            // buttonEmanetListele
            // 
            this.buttonEmanetListele.BackgroundImage = global::kutuphane.Properties.Resources.emanet2;
            this.buttonEmanetListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEmanetListele.Location = new System.Drawing.Point(339, 246);
            this.buttonEmanetListele.Name = "buttonEmanetListele";
            this.buttonEmanetListele.Size = new System.Drawing.Size(100, 115);
            this.buttonEmanetListele.TabIndex = 5;
            this.buttonEmanetListele.Text = "Emanetleri Listele";
            this.buttonEmanetListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEmanetListele.UseVisualStyleBackColor = true;
            this.buttonEmanetListele.Click += new System.EventHandler(this.buttonEmanetListele_Click);
            // 
            // buttonKitapListele
            // 
            this.buttonKitapListele.BackgroundImage = global::kutuphane.Properties.Resources.kitap_ekle2;
            this.buttonKitapListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonKitapListele.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonKitapListele.Location = new System.Drawing.Point(110, 246);
            this.buttonKitapListele.Name = "buttonKitapListele";
            this.buttonKitapListele.Size = new System.Drawing.Size(100, 115);
            this.buttonKitapListele.TabIndex = 4;
            this.buttonKitapListele.Text = "Kitap Listele";
            this.buttonKitapListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKitapListele.UseVisualStyleBackColor = true;
            this.buttonKitapListele.Click += new System.EventHandler(this.buttonKitapListele_Click);
            // 
            // buttonUyelikEkle
            // 
            this.buttonUyelikEkle.BackgroundImage = global::kutuphane.Properties.Resources.uyelik2;
            this.buttonUyelikEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUyelikEkle.Location = new System.Drawing.Point(576, 99);
            this.buttonUyelikEkle.Name = "buttonUyelikEkle";
            this.buttonUyelikEkle.Size = new System.Drawing.Size(100, 115);
            this.buttonUyelikEkle.TabIndex = 3;
            this.buttonUyelikEkle.Text = "Üyelik Ekle";
            this.buttonUyelikEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUyelikEkle.UseVisualStyleBackColor = true;
            this.buttonUyelikEkle.Click += new System.EventHandler(this.buttonUyelikEkle_Click);
            // 
            // buttonEmanetEkle
            // 
            this.buttonEmanetEkle.BackgroundImage = global::kutuphane.Properties.Resources.emanet2;
            this.buttonEmanetEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEmanetEkle.Location = new System.Drawing.Point(339, 98);
            this.buttonEmanetEkle.Name = "buttonEmanetEkle";
            this.buttonEmanetEkle.Size = new System.Drawing.Size(100, 115);
            this.buttonEmanetEkle.TabIndex = 2;
            this.buttonEmanetEkle.Text = "Emanet Ekle";
            this.buttonEmanetEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEmanetEkle.UseVisualStyleBackColor = true;
            this.buttonEmanetEkle.Click += new System.EventHandler(this.buttonEmanetEkle_Click);
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.BackgroundImage = global::kutuphane.Properties.Resources.kitap_ekle2;
            this.buttonKitapEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonKitapEkle.Location = new System.Drawing.Point(110, 98);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(100, 115);
            this.buttonKitapEkle.TabIndex = 1;
            this.buttonKitapEkle.Text = "Kitap Ekle";
            this.buttonKitapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKitapEkle.UseVisualStyleBackColor = true;
            this.buttonKitapEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonUyeListele);
            this.Controls.Add(this.buttonEmanetListele);
            this.Controls.Add(this.buttonKitapListele);
            this.Controls.Add(this.buttonUyelikEkle);
            this.Controls.Add(this.buttonEmanetEkle);
            this.Controls.Add(this.buttonKitapEkle);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonKitapEkle;
        private System.Windows.Forms.Button buttonEmanetEkle;
        private System.Windows.Forms.Button buttonUyelikEkle;
        private System.Windows.Forms.Button buttonKitapListele;
        private System.Windows.Forms.Button buttonEmanetListele;
        private System.Windows.Forms.Button buttonUyeListele;
    }
}

