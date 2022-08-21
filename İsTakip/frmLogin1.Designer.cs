namespace İsTakip
{
    partial class frmLogin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKullaniciAdi = new DevExpress.XtraEditors.ButtonEdit();
            this.txtSifre = new System.Windows.Forms.MaskedTextBox();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnKullaniciAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre";
            // 
            // btnKullaniciAdi
            // 
            this.btnKullaniciAdi.Location = new System.Drawing.Point(226, 74);
            this.btnKullaniciAdi.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnKullaniciAdi.Name = "btnKullaniciAdi";
            this.btnKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.btnKullaniciAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnKullaniciAdi.Size = new System.Drawing.Size(184, 34);
            this.btnKullaniciAdi.TabIndex = 1;
            this.btnKullaniciAdi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnKullaniciAdi_ButtonClick);
            this.btnKullaniciAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnKullaniciAdi_KeyDown);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(226, 173);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(180, 34);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyDown);
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(110, 292);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(240, 77);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // frmLogin1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 579);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "frmLogin1";
            this.Text = "HoşGeldiniz";
            ((System.ComponentModel.ISupportInitialize)(this.btnKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ButtonEdit btnKullaniciAdi;
        private System.Windows.Forms.MaskedTextBox txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnGiris;

    }
}