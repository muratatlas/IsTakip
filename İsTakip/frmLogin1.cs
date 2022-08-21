using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core;

namespace İsTakip
{
    public partial class frmLogin1 : DevExpress.XtraEditors.XtraForm
    {
        Core.Methodlarim mymethod = new Methodlarim();
        public frmLogin1()
        {
            InitializeComponent();
        }
        public frmLogin1(string kod)
        {
            InitializeComponent();
            btnKullaniciAdi.Text = kod;
        }

        private void btnKullaniciAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataTable dtlist = mymethod.KullaniciListesi("");
            frmGrid grid = new frmGrid(dtlist,"Login");
            grid.ShowDialog();
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            int tip = mymethod.KullaniciKontrolEt(btnKullaniciAdi.Text, txtSifre.Text).tamsayim();
            Core.Staticlerim.kullanicitipistatic = tip;
            if (tip==0)
            {
                MessageBox.Show("Bilgiler Doğrulanamadı", "UYARI");
                return;
            }
            else if (tip==1)//admin paneli gelcek
            {
                frmMain main = new frmMain(1);
                main.Show();
                this.Close();
            }
            else if(tip==2)
            {
                frmMain main = new frmMain(2);//user paneli gelecek.
                main.ShowDialog();
                this.Close();
            }
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {

        }

        private void btnKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtSifre.Focus(); 
            }

        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            btnGiris_Click(null, null);
        }
    }
}