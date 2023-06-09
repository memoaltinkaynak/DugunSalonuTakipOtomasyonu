namespace odevdeneme
{
    partial class YetkiliEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliEkran));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDongiris = new System.Windows.Forms.Button();
            this.btnAnaekrangit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(123, 111);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(185, 33);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(123, 171);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(185, 33);
            this.txtSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Üye Kayıt Formu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 263);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightGreen;
            this.btnKaydet.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnKaydet.Location = new System.Drawing.Point(354, 77);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 86);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnListele.Location = new System.Drawing.Point(445, 77);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(85, 86);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.btnGuncelle.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuncelle.Location = new System.Drawing.Point(354, 171);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 86);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSil.Location = new System.Drawing.Point(445, 169);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 86);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDongiris
            // 
            this.btnDongiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDongiris.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDongiris.Location = new System.Drawing.Point(354, 12);
            this.btnDongiris.Name = "btnDongiris";
            this.btnDongiris.Size = new System.Drawing.Size(85, 59);
            this.btnDongiris.TabIndex = 10;
            this.btnDongiris.Text = "Üye Giriş Ekranına Dön";
            this.btnDongiris.UseVisualStyleBackColor = false;
            this.btnDongiris.Click += new System.EventHandler(this.btnDongiris_Click);
            // 
            // btnAnaekrangit
            // 
            this.btnAnaekrangit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnaekrangit.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaekrangit.Location = new System.Drawing.Point(445, 12);
            this.btnAnaekrangit.Name = "btnAnaekrangit";
            this.btnAnaekrangit.Size = new System.Drawing.Size(85, 59);
            this.btnAnaekrangit.TabIndex = 11;
            this.btnAnaekrangit.Text = "Ana Ekrana Git";
            this.btnAnaekrangit.UseVisualStyleBackColor = false;
            this.btnAnaekrangit.Click += new System.EventHandler(this.btnAnaekrangit_Click);
            // 
            // YetkiliEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 538);
            this.Controls.Add(this.btnAnaekrangit);
            this.Controls.Add(this.btnDongiris);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YetkiliEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili Ekran";
            this.Load += new System.EventHandler(this.YetkiliEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDongiris;
        private System.Windows.Forms.Button btnAnaekrangit;
    }
}