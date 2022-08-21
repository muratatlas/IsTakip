namespace İsTakip
{
    partial class frmGorevler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGorevler));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnİnsUpd = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydetGönder = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGorevKod = new DevExpress.XtraEditors.ButtonEdit();
            this.txtCariKod = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKonu = new DevExpress.XtraEditors.TextEdit();
            this.cmbDurum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTip = new DevExpress.XtraEditors.TextEdit();
            this.txtNot = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblaktif = new System.Windows.Forms.Label();
            this.chkaktif = new System.Windows.Forms.CheckBox();
            this.txticerik = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTip.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnİnsUpd,
            this.btnSil,
            this.btnKaydetGönder});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(665, 168);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnİnsUpd
            // 
            this.btnİnsUpd.Caption = "Kaydet/Güncelle";
            this.btnİnsUpd.Glyph = ((System.Drawing.Image)(resources.GetObject("btnİnsUpd.Glyph")));
            this.btnİnsUpd.Id = 1;
            this.btnİnsUpd.Name = "btnİnsUpd";
            this.btnİnsUpd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnİnsUpd_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSil.Glyph")));
            this.btnSil.Id = 2;
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // btnKaydetGönder
            // 
            this.btnKaydetGönder.Caption = "Kaydet ve Gönder";
            this.btnKaydetGönder.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKaydetGönder.Glyph")));
            this.btnKaydetGönder.Id = 3;
            this.btnKaydetGönder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKaydetGönder.LargeGlyph")));
            this.btnKaydetGönder.Name = "btnKaydetGönder";
            this.btnKaydetGönder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKaydetGönder_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnİnsUpd);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaydetGönder);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 613);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(665, 36);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cari";
            // 
            // txtGorevKod
            // 
            this.txtGorevKod.Location = new System.Drawing.Point(128, 201);
            this.txtGorevKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGorevKod.MenuManager = this.ribbon;
            this.txtGorevKod.Name = "txtGorevKod";
            this.txtGorevKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtGorevKod.Size = new System.Drawing.Size(117, 22);
            this.txtGorevKod.TabIndex = 3;
            this.txtGorevKod.TextChanged += new System.EventHandler(this.txtGorevKod_TextChanged);
            this.txtGorevKod.Click += new System.EventHandler(this.txtGorevKod_Click);
            this.txtGorevKod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGorevKod_KeyDown);
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(128, 251);
            this.txtCariKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCariKod.MenuManager = this.ribbon;
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(117, 22);
            this.txtCariKod.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Görev Kod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel";
            // 
            // txtPersonel
            // 
            this.txtPersonel.Location = new System.Drawing.Point(128, 302);
            this.txtPersonel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Size = new System.Drawing.Size(117, 22);
            this.txtPersonel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Konu";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(128, 354);
            this.txtKonu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(117, 22);
            this.txtKonu.TabIndex = 4;
            // 
            // cmbDurum
            // 
            this.cmbDurum.Location = new System.Drawing.Point(401, 208);
            this.cmbDurum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDurum.MenuManager = this.ribbon;
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDurum.Size = new System.Drawing.Size(117, 22);
            this.cmbDurum.TabIndex = 6;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(401, 254);
            this.txtTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(117, 22);
            this.txtTip.TabIndex = 4;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(365, 298);
            this.txtNot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(273, 75);
            this.txtNot.TabIndex = 5;
            this.txtNot.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "İçerik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(278, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Durum Kod";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(278, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tip";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(295, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Not";
            // 
            // lblaktif
            // 
            this.lblaktif.AutoSize = true;
            this.lblaktif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaktif.Location = new System.Drawing.Point(539, 229);
            this.lblaktif.Name = "lblaktif";
            this.lblaktif.Size = new System.Drawing.Size(55, 28);
            this.lblaktif.TabIndex = 12;
            this.lblaktif.Text = "Aktif";
            // 
            // chkaktif
            // 
            this.chkaktif.AutoSize = true;
            this.chkaktif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkaktif.Location = new System.Drawing.Point(600, 236);
            this.chkaktif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkaktif.Name = "chkaktif";
            this.chkaktif.Size = new System.Drawing.Size(18, 17);
            this.chkaktif.TabIndex = 13;
            this.chkaktif.UseVisualStyleBackColor = true;
            // 
            // txticerik
            // 
            this.txticerik.Location = new System.Drawing.Point(128, 396);
            this.txticerik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txticerik.Name = "txticerik";
            this.txticerik.Size = new System.Drawing.Size(510, 186);
            this.txticerik.TabIndex = 5;
            this.txticerik.Text = "";
            // 
            // frmGorevler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 649);
            this.Controls.Add(this.chkaktif);
            this.Controls.Add(this.lblaktif);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.txticerik);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtPersonel);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtCariKod);
            this.Controls.Add(this.txtGorevKod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGorevler";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Görevler";
            this.Load += new System.EventHandler(this.frmGorevler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTip.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnİnsUpd;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ButtonEdit txtGorevKod;
        private DevExpress.XtraEditors.TextEdit txtCariKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtPersonel;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtKonu;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDurum;
        private DevExpress.XtraEditors.TextEdit txtTip;
        private System.Windows.Forms.RichTextBox txtNot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private System.Windows.Forms.Label lblaktif;
        private System.Windows.Forms.CheckBox chkaktif;
        private DevExpress.XtraBars.BarButtonItem btnKaydetGönder;
        private System.Windows.Forms.RichTextBox txticerik;
    }
}