namespace İsTakip
{
    partial class frmCariYetkili
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariYetkili));
            this.lblaktif = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnİnsUpd = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKod = new DevExpress.XtraEditors.ButtonEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new DevExpress.XtraEditors.ButtonEdit();
            this.txtcari = new DevExpress.XtraEditors.ButtonEdit();
            this.txttip = new DevExpress.XtraEditors.ButtonEdit();
            this.txtmail = new DevExpress.XtraEditors.ButtonEdit();
            this.chkaktif = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lblaktif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkaktif.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblaktif
            // 
            this.lblaktif.ExpandCollapseItem.Id = 0;
            this.lblaktif.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblaktif.ExpandCollapseItem,
            this.btnİnsUpd,
            this.btnSil});
            this.lblaktif.Location = new System.Drawing.Point(0, 0);
            this.lblaktif.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.lblaktif.MaxItemId = 3;
            this.lblaktif.Name = "lblaktif";
            this.lblaktif.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.lblaktif.Size = new System.Drawing.Size(494, 168);
            this.lblaktif.StatusBar = this.ribbonStatusBar;
            // 
            // btnİnsUpd
            // 
            this.btnİnsUpd.Caption = "Kaydet/Güncele";
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
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 528);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.lblaktif;
            this.ribbonStatusBar.Size = new System.Drawing.Size(494, 36);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kod";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(208, 203);
            this.txtKod.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtKod.MenuManager = this.lblaktif;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKod.Size = new System.Drawing.Size(184, 22);
            this.txtKod.TabIndex = 3;
            this.txtKod.Click += new System.EventHandler(this.txtKod_Click);
            this.txtKod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKod_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cari Kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mail Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Aktif";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(208, 244);
            this.txtname.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtname.Name = "txtname";
            this.txtname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtname.Size = new System.Drawing.Size(184, 22);
            this.txtname.TabIndex = 3;
            this.txtname.Click += new System.EventHandler(this.txtKod_Click);
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKod_KeyDown);
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(208, 290);
            this.txtcari.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtcari.Name = "txtcari";
            this.txtcari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtcari.Size = new System.Drawing.Size(184, 22);
            this.txtcari.TabIndex = 3;
            this.txtcari.Click += new System.EventHandler(this.txtKod_Click);
            this.txtcari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKod_KeyDown);
            // 
            // txttip
            // 
            this.txttip.Location = new System.Drawing.Point(208, 339);
            this.txttip.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txttip.Name = "txttip";
            this.txttip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txttip.Size = new System.Drawing.Size(184, 22);
            this.txttip.TabIndex = 3;
            this.txttip.Click += new System.EventHandler(this.txtKod_Click);
            this.txttip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKod_KeyDown);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(208, 387);
            this.txtmail.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtmail.Name = "txtmail";
            this.txtmail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtmail.Size = new System.Drawing.Size(184, 22);
            this.txtmail.TabIndex = 3;
            this.txtmail.Click += new System.EventHandler(this.txtKod_Click);
            this.txtmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKod_KeyDown);
            // 
            // chkaktif
            // 
            this.chkaktif.Location = new System.Drawing.Point(208, 428);
            this.chkaktif.MenuManager = this.lblaktif;
            this.chkaktif.Name = "chkaktif";
            this.chkaktif.Properties.Caption = "";
            this.chkaktif.Size = new System.Drawing.Size(75, 19);
            this.chkaktif.TabIndex = 16;
            // 
            // frmCariYetkili
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 564);
            this.Controls.Add(this.chkaktif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txttip);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.lblaktif);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "frmCariYetkili";
            this.Ribbon = this.lblaktif;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Cari Yetkili";
            ((System.ComponentModel.ISupportInitialize)(this.lblaktif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkaktif.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl lblaktif;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnİnsUpd;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ButtonEdit txtKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ButtonEdit txtname;
        private DevExpress.XtraEditors.ButtonEdit txtcari;
        private DevExpress.XtraEditors.ButtonEdit txttip;
        private DevExpress.XtraEditors.ButtonEdit txtmail;
        private DevExpress.XtraEditors.CheckEdit chkaktif;
    }
}