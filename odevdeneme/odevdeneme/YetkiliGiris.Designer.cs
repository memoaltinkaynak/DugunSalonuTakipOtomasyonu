namespace odevdeneme
{
    partial class YetkiliGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliGiris));
            this.txtYetkiliUser = new System.Windows.Forms.TextBox();
            this.txtYetkiliPassword = new System.Windows.Forms.TextBox();
            this.yetkiliGirisBtn = new System.Windows.Forms.Button();
            this.yetkiliBackbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYetkiliUser
            // 
            this.txtYetkiliUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYetkiliUser.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYetkiliUser.Location = new System.Drawing.Point(106, 197);
            this.txtYetkiliUser.Multiline = true;
            this.txtYetkiliUser.Name = "txtYetkiliUser";
            this.txtYetkiliUser.Size = new System.Drawing.Size(159, 28);
            this.txtYetkiliUser.TabIndex = 0;
            // 
            // txtYetkiliPassword
            // 
            this.txtYetkiliPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYetkiliPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYetkiliPassword.Location = new System.Drawing.Point(106, 266);
            this.txtYetkiliPassword.Multiline = true;
            this.txtYetkiliPassword.Name = "txtYetkiliPassword";
            this.txtYetkiliPassword.PasswordChar = '*';
            this.txtYetkiliPassword.Size = new System.Drawing.Size(159, 28);
            this.txtYetkiliPassword.TabIndex = 1;
            // 
            // yetkiliGirisBtn
            // 
            this.yetkiliGirisBtn.Location = new System.Drawing.Point(142, 300);
            this.yetkiliGirisBtn.Name = "yetkiliGirisBtn";
            this.yetkiliGirisBtn.Size = new System.Drawing.Size(87, 35);
            this.yetkiliGirisBtn.TabIndex = 3;
            this.yetkiliGirisBtn.Text = "Giriş";
            this.yetkiliGirisBtn.UseVisualStyleBackColor = true;
            this.yetkiliGirisBtn.Click += new System.EventHandler(this.yetkiliGirisBtn_Click);
            // 
            // yetkiliBackbtn
            // 
            this.yetkiliBackbtn.Location = new System.Drawing.Point(12, 361);
            this.yetkiliBackbtn.Name = "yetkiliBackbtn";
            this.yetkiliBackbtn.Size = new System.Drawing.Size(87, 35);
            this.yetkiliBackbtn.TabIndex = 4;
            this.yetkiliBackbtn.Text = "Geri Dön";
            this.yetkiliBackbtn.UseVisualStyleBackColor = true;
            this.yetkiliBackbtn.Click += new System.EventHandler(this.yetkiliBackbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // YetkiliGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 408);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yetkiliBackbtn);
            this.Controls.Add(this.yetkiliGirisBtn);
            this.Controls.Add(this.txtYetkiliPassword);
            this.Controls.Add(this.txtYetkiliUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YetkiliGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili Giris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYetkiliUser;
        private System.Windows.Forms.TextBox txtYetkiliPassword;
        private System.Windows.Forms.Button yetkiliGirisBtn;
        private System.Windows.Forms.Button yetkiliBackbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}