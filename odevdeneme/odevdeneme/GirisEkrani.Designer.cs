namespace odevdeneme
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yetkiliGirisBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtUser.Location = new System.Drawing.Point(73, 182);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(208, 28);
            this.txtUser.TabIndex = 0;
            this.txtUser.Tag = "";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(73, 254);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(208, 28);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(73, 301);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(208, 32);
            this.BtnGiris.TabIndex = 2;
            this.BtnGiris.Text = "GİRİŞ YAP";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            this.BtnGiris.Enter += new System.EventHandler(this.BtnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullancı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // yetkiliGirisBtn
            // 
            this.yetkiliGirisBtn.Location = new System.Drawing.Point(285, 373);
            this.yetkiliGirisBtn.Name = "yetkiliGirisBtn";
            this.yetkiliGirisBtn.Size = new System.Drawing.Size(75, 23);
            this.yetkiliGirisBtn.TabIndex = 6;
            this.yetkiliGirisBtn.Text = "Yetkili Giriş";
            this.yetkiliGirisBtn.UseVisualStyleBackColor = true;
            this.yetkiliGirisBtn.Click += new System.EventHandler(this.yetkiliGirisBtn_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(372, 408);
            this.Controls.Add(this.yetkiliGirisBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button yetkiliGirisBtn;
    }
}