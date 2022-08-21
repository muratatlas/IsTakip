namespace İsTakip
{
    partial class frmCariler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariler));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnİnsUpd = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtkod = new DevExpress.XtraEditors.ButtonEdit();
            this.cmbülke = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblaktif = new System.Windows.Forms.Label();
            this.txtUnvan = new DevExpress.XtraEditors.ButtonEdit();
            this.txtvergiadi = new DevExpress.XtraEditors.ButtonEdit();
            this.txtvergino = new DevExpress.XtraEditors.ButtonEdit();
            this.txtwebsitesi = new DevExpress.XtraEditors.ButtonEdit();
            this.chkaktif = new DevExpress.XtraEditors.CheckButton();
            this.txtadres = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbülke.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvergiadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvergino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtwebsitesi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnİnsUpd,
            this.btnSil});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(761, 168);
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
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 526);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(761, 36);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ünvan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vergi Daire Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vergi Daire No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Web Sitesi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(426, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ülke";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(426, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "İl";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(426, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "İlçe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(426, 322);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Adres";
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(174, 195);
            this.txtkod.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtkod.MenuManager = this.ribbon;
            this.txtkod.Name = "txtkod";
            this.txtkod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtkod.Size = new System.Drawing.Size(184, 22);
            this.txtkod.TabIndex = 4;
            this.txtkod.Click += new System.EventHandler(this.txtkod_Click);
            this.txtkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkod_KeyDown);
            // 
            // cmbülke
            // 
            this.cmbülke.Location = new System.Drawing.Point(501, 195);
            this.cmbülke.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cmbülke.MenuManager = this.ribbon;
            this.cmbülke.Name = "cmbülke";
            this.cmbülke.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbülke.Size = new System.Drawing.Size(184, 22);
            this.cmbülke.TabIndex = 7;
            // 
            // cmbil
            // 
            this.cmbil.Location = new System.Drawing.Point(501, 236);
            this.cmbil.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cmbil.Name = "cmbil";
            this.cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbil.Size = new System.Drawing.Size(184, 22);
            this.cmbil.TabIndex = 7;
            // 
            // cmbilce
            // 
            this.cmbilce.Location = new System.Drawing.Point(501, 283);
            this.cmbilce.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbilce.Size = new System.Drawing.Size(184, 22);
            this.cmbilce.TabIndex = 7;
            // 
            // lblaktif
            // 
            this.lblaktif.AutoSize = true;
            this.lblaktif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaktif.Location = new System.Drawing.Point(21, 411);
            this.lblaktif.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblaktif.Name = "lblaktif";
            this.lblaktif.Size = new System.Drawing.Size(55, 28);
            this.lblaktif.TabIndex = 14;
            this.lblaktif.Text = "Aktif";
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(174, 236);
            this.txtUnvan.MenuManager = this.ribbon;
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtUnvan.Size = new System.Drawing.Size(180, 22);
            this.txtUnvan.TabIndex = 19;
            // 
            // txtvergiadi
            // 
            this.txtvergiadi.Location = new System.Drawing.Point(174, 281);
            this.txtvergiadi.Name = "txtvergiadi";
            this.txtvergiadi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtvergiadi.Size = new System.Drawing.Size(180, 22);
            this.txtvergiadi.TabIndex = 19;
            // 
            // txtvergino
            // 
            this.txtvergino.Location = new System.Drawing.Point(174, 329);
            this.txtvergino.Name = "txtvergino";
            this.txtvergino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtvergino.Size = new System.Drawing.Size(180, 22);
            this.txtvergino.TabIndex = 19;
            // 
            // txtwebsitesi
            // 
            this.txtwebsitesi.Location = new System.Drawing.Point(174, 381);
            this.txtwebsitesi.Name = "txtwebsitesi";
            this.txtwebsitesi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtwebsitesi.Size = new System.Drawing.Size(180, 22);
            this.txtwebsitesi.TabIndex = 19;
            // 
            // chkaktif
            // 
            this.chkaktif.Checked = true;
            this.chkaktif.Location = new System.Drawing.Point(174, 415);
            this.chkaktif.Name = "chkaktif";
            this.chkaktif.Size = new System.Drawing.Size(75, 23);
            this.chkaktif.TabIndex = 20;
            // 
            // txtadres
            // 
            this.txtadres.EnableToolTips = true;
            this.txtadres.Location = new System.Drawing.Point(416, 353);
            this.txtadres.MenuManager = this.ribbon;
            this.txtadres.Name = "txtadres";
            this.txtadres.Options.Bookmarks.AllowNameResolution = false;
            this.txtadres.Size = new System.Drawing.Size(301, 163);
            this.txtadres.TabIndex = 21;
            // 
            // frmCariler
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 562);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.chkaktif);
            this.Controls.Add(this.txtwebsitesi);
            this.Controls.Add(this.txtvergino);
            this.Controls.Add(this.txtvergiadi);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.lblaktif);
            this.Controls.Add(this.cmbilce);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.cmbülke);
            this.Controls.Add(this.txtkod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.Name = "frmCariler";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Cari Tanitim";
            this.Load += new System.EventHandler(this.frmCariler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbülke.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvergiadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvergino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtwebsitesi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnİnsUpd;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.ButtonEdit txtkod;
        private DevExpress.XtraEditors.ComboBoxEdit cmbülke;
        private DevExpress.XtraEditors.ComboBoxEdit cmbil;
        private DevExpress.XtraEditors.ComboBoxEdit cmbilce;
        private System.Windows.Forms.Label lblaktif;
        private DevExpress.XtraEditors.ButtonEdit txtUnvan;
        private DevExpress.XtraEditors.ButtonEdit txtvergiadi;
        private DevExpress.XtraEditors.ButtonEdit txtvergino;
        private DevExpress.XtraEditors.ButtonEdit txtwebsitesi;
        private DevExpress.XtraEditors.CheckButton chkaktif;
        private DevExpress.XtraRichEdit.RichEditControl txtadres;
    }
}