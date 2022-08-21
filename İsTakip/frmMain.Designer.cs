namespace İsTakip
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnMenuler = new DevExpress.XtraBars.BarSubItem();
            this.btnCariler = new DevExpress.XtraBars.BarButtonItem();
            this.btnCariYetkili = new DevExpress.XtraBars.BarButtonItem();
            this.btnGorevler = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gwGorevler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwGorevler)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barSubItem1,
            this.mnMenuler,
            this.btnCariler,
            this.btnCariYetkili,
            this.btnGorevler});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(815, 168);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 1;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mnMenuler
            // 
            this.mnMenuler.Caption = "Menuler";
            this.mnMenuler.Id = 2;
            this.mnMenuler.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCariler),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCariYetkili)});
            this.mnMenuler.Name = "mnMenuler";
            // 
            // btnCariler
            // 
            this.btnCariler.Caption = "Cariler";
            this.btnCariler.Id = 3;
            this.btnCariler.Name = "btnCariler";
            this.btnCariler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCariler_ItemClick);
            // 
            // btnCariYetkili
            // 
            this.btnCariYetkili.Caption = "Cari Yetkilileri";
            this.btnCariYetkili.Id = 4;
            this.btnCariYetkili.Name = "btnCariYetkili";
            this.btnCariYetkili.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCariYetkili_ItemClick);
            // 
            // btnGorevler
            // 
            this.btnGorevler.Id = 6;
            this.btnGorevler.Name = "btnGorevler";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mnMenuler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 604);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(815, 36);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 168);
            this.gridControl1.MainView = this.gwGorevler;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(815, 436);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwGorevler});
            // 
            // gwGorevler
            // 
            this.gwGorevler.GridControl = this.gridControl1;
            this.gwGorevler.Name = "gwGorevler";
            this.gwGorevler.DoubleClick += new System.EventHandler(this.gwGorevler_DoubleClick);
            // 
            // btnYeni
            // 
            this.btnYeni.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Appearance.Options.UseFont = true;
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.Location = new System.Drawing.Point(153, 105);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(124, 37);
            this.btnYeni.TabIndex = 11;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Appearance.Options.UseFont = true;
            this.btnGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(322, 106);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(137, 36);
            this.btnGüncelle.TabIndex = 12;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 640);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Görevler Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwGorevler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem mnMenuler;
        private DevExpress.XtraBars.BarButtonItem btnCariler;
        private DevExpress.XtraBars.BarButtonItem btnCariYetkili;
        private DevExpress.XtraBars.BarButtonItem btnGorevler;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gwGorevler;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
    }
}