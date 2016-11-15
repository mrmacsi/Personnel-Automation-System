namespace PersonelOtomasyonSistemi
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.GirisButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SozlukGirisPanel = new System.Windows.Forms.Panel();
            this.kullaniciSifreTxt = new System.Windows.Forms.TextBox();
            this.KullaniciAdiKutu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SozlukGirisPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PersonelOtomasyonSistemi.Properties.Resources.ZiyaretciBay;
            this.pictureBox1.Location = new System.Drawing.Point(83, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 23F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 42);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sisteme Giriş";
            // 
            // GirisButon
            // 
            this.GirisButon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GirisButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GirisButon.FlatAppearance.BorderSize = 0;
            this.GirisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisButon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButon.ForeColor = System.Drawing.Color.White;
            this.GirisButon.Location = new System.Drawing.Point(83, 345);
            this.GirisButon.Name = "GirisButon";
            this.GirisButon.Size = new System.Drawing.Size(113, 45);
            this.GirisButon.TabIndex = 2;
            this.GirisButon.Text = "Giriş Yap";
            this.GirisButon.UseVisualStyleBackColor = false;
            this.GirisButon.Click += new System.EventHandler(this.GirisButon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // SozlukGirisPanel
            // 
            this.SozlukGirisPanel.Controls.Add(this.kullaniciSifreTxt);
            this.SozlukGirisPanel.Controls.Add(this.KullaniciAdiKutu);
            this.SozlukGirisPanel.Controls.Add(this.pictureBox1);
            this.SozlukGirisPanel.Controls.Add(this.label5);
            this.SozlukGirisPanel.Controls.Add(this.label2);
            this.SozlukGirisPanel.Controls.Add(this.label4);
            this.SozlukGirisPanel.Controls.Add(this.GirisButon);
            this.SozlukGirisPanel.Location = new System.Drawing.Point(37, 13);
            this.SozlukGirisPanel.Name = "SozlukGirisPanel";
            this.SozlukGirisPanel.Size = new System.Drawing.Size(297, 439);
            this.SozlukGirisPanel.TabIndex = 3;
            // 
            // kullaniciSifreTxt
            // 
            this.kullaniciSifreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullaniciSifreTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "I",
            "You",
            "They"});
            this.kullaniciSifreTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.kullaniciSifreTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.kullaniciSifreTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciSifreTxt.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.kullaniciSifreTxt.Location = new System.Drawing.Point(25, 295);
            this.kullaniciSifreTxt.Name = "kullaniciSifreTxt";
            this.kullaniciSifreTxt.PasswordChar = '*';
            this.kullaniciSifreTxt.Size = new System.Drawing.Size(240, 24);
            this.kullaniciSifreTxt.TabIndex = 1;
            this.kullaniciSifreTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KullaniciAdiKutu
            // 
            this.KullaniciAdiKutu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KullaniciAdiKutu.AutoCompleteCustomSource.AddRange(new string[] {
            "I",
            "You",
            "They"});
            this.KullaniciAdiKutu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.KullaniciAdiKutu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.KullaniciAdiKutu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KullaniciAdiKutu.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.KullaniciAdiKutu.Location = new System.Drawing.Point(25, 222);
            this.KullaniciAdiKutu.Name = "KullaniciAdiKutu";
            this.KullaniciAdiKutu.Size = new System.Drawing.Size(240, 24);
            this.KullaniciAdiKutu.TabIndex = 0;
            this.KullaniciAdiKutu.TextChanged += new System.EventHandler(this.KullaniciAdiKutu_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.GirisButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(373, 464);
            this.Controls.Add(this.SozlukGirisPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SozlukGirisPanel.ResumeLayout(false);
            this.SozlukGirisPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button GirisButon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SozlukGirisPanel;
        private System.Windows.Forms.TextBox kullaniciSifreTxt;
        private System.Windows.Forms.TextBox KullaniciAdiKutu;
    }
}

