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
    public partial class frmCariYetkili : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Entity mydb = new Entity();
        Core.Methodlarim method = new Methodlarim();
        string personelkod = "";
        public frmCariYetkili()
        {
            InitializeComponent();
        }
        public frmCariYetkili(string kod)
        {
            InitializeComponent();
            personelkod = kod;
            //Cari_Yetkilileri myyetkili = new Cari_Yetkilileri();
            //myyetkili = mydb.Cari_Yetkilileri.FirstOrDefault(x => x.cariyet_PersonelKod == kod);
            DataTable dtyetkili = method.cariyetkilibilgileriGetir(txtKod.Text);
            txtcari.Text = dtyetkili.Rows[0]["carikod"].ToString();
            txtKod.Text = dtyetkili.Rows[0]["kod"].ToString();
            txtmail.Text = dtyetkili.Rows[0]["mail"].ToString();
            txtname.Text = dtyetkili.Rows[0]["personelad"].ToString();
            txttip.Text = dtyetkili.Rows[0]["tip"].ToString();
            chkaktif.Checked = dtyetkili.Rows[0]["aktif"].getbool();
        }
        public frmCariYetkili (string mail,string isim)
        {
            InitializeComponent();
            txtmail.Text = mail;
            chkaktif.Checked = true;
        }

        private void txtKod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                frmCariYetkili yetkili = new frmCariYetkili(txtKod.Text);
            this.Close();
            yetkili.ShowDialog();
            }
        }

        private void txtKod_Click(object sender, EventArgs e)
        {
            DataTable dtlist = method.CariYetkilileriGridGetir("");
            frmGrid grid = new frmGrid(dtlist, "CariYetkili");
            grid.ShowDialog();
            this.Close();
        }

        private void btnSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            method.YetkiliDeaktif(txtKod.Text);
            
        }

        private void btnİnsUpd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cari_Yetkilileri myyet = new Cari_Yetkilileri();
            if (myyet==null)
            {
                myyet.cariyet_aktif = chkaktif.Checked.getbool();
                myyet.cariyet_CariKod = txtcari.Text;
                myyet.cariyet_create_date =myyet.cariyet_lastup_date= DateTime.Now.Date;
                myyet.cariyet_PersonelFullName = txtname.Text;
                myyet.cariyet_PersonelKod = txtKod.Text;
                myyet.cariyet_personelmail = txtmail.Text;
                myyet.cariyet_personeltipi = txttip.Text;
                method.PersonelKaydet(myyet);
            }
            else
            {
                
                myyet.cariyet_aktif = chkaktif.Checked.getbool();
                myyet.cariyet_CariKod = txtcari.Text;
                myyet.cariyet_lastup_date = DateTime.Now.Date;
                myyet.cariyet_PersonelFullName = txtname.Text;
                myyet.cariyet_PersonelKod = txtKod.Text;
                myyet.cariyet_personelmail = txtmail.Text;
                myyet.cariyet_personeltipi = txttip.Text;
                method.PersonelGüncele(myyet, txtKod.Text);
            }
        }
    }
}