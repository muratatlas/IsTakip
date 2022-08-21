using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Core;
using Enti;

namespace İsTakip
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Core.Methodlarim mymthd = new Methodlarim();
        
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(int usertipi)
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = mymthd.GorevlerGridGetir("",false);
            gwGorevler.RefreshData();
            gwGorevler.BestFitColumns();
            gwGorevler.OptionsBehavior.ReadOnly = true;
            
        }

        private void gwGorevler_DoubleClick(object sender, EventArgs e)
        {
            if (gwGorevler.FocusedRowHandle<0)
            {
                MessageBox.Show("Satir Seçiniz");
            }
            string kod = gwGorevler.GetRowCellValue(gwGorevler.FocusedRowHandle, gwGorevler.Columns["kod"]).ToString();
            frmGorevler mygorev = new frmGorevler(kod);
            mygorev.ShowDialog();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (gwGorevler.FocusedRowHandle < 0)
            {
                MessageBox.Show("Satir Seçiniz");
            }
            string kod = gwGorevler.GetRowCellValue(gwGorevler.FocusedRowHandle, gwGorevler.Columns["kod"]).ToString();
            frmGorevler mygorev = new frmGorevler(kod);
            mygorev.ShowDialog();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmGorevler mygorev = new frmGorevler();
            mygorev.ShowDialog();
        }

        

        private void btnCariler_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariler mycari = new frmCariler();
            mycari.ShowDialog();
            this.Hide();
        }

        private void btnCariYetkili_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariYetkili mycari = new frmCariYetkili();
            mycari.ShowDialog();
            this.Hide();
        }
    }
}