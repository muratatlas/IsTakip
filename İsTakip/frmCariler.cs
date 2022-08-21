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
using Enti;

namespace İsTakip
{
    using Core;
    public partial class frmCariler : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string carikod = "";
        Entity mydb = new Entity();
        Core.Methodlarim method = new Core.Methodlarim();
        public frmCariler()
        {
            InitializeComponent();
            DataTable dtlist = method.UlkeGridGetir("");
            for (int i = 0; i < dtlist.Rows.Count; i++)
            {
                cmbülke.Properties.Items.Add(dtlist.Rows[i][0]);
            }
            cmbülke.SelectedIndex = 0;
            DataTable dtlist1 = method.İlGridGetir("",cmbülke.SelectedItem.ToString());
            for (int i = 0; i < dtlist1.Rows.Count; i++)
            {
                cmbil.Properties.Items.Add(dtlist1.Rows[i][0]);
            }
            cmbil.SelectedIndex = 0;
            DataTable dtlist2 = method.İlceGridGetir("",cmbil.SelectedItem.ToString());
            for (int i = 0; i < dtlist.Rows.Count; i++)
            {
                cmbilce.Properties.Items.Add(dtlist2.Rows[i][0]);
            }
            cmbilce.SelectedIndex = 0;
            chkaktif.Checked = true;
        }
        public frmCariler(string kod)
        {
            InitializeComponent();
            DataTable dtlist = method.UlkeGridGetir("");
            for (int i = 0; i < dtlist.Rows.Count; i++)
            {
                cmbülke.Properties.Items.Add(dtlist.Rows[i][0]);
            }
            
            
            carikod = kod;
            //Cariler mycari = mydb.Cariler.FirstOrDefault(x => x.cari_kod == kod);
            //Cari_Adresleri myadres=mydb.Cari_Adresleri.FirstOrDefault(x => x.cariadr_carikod == kod);
            DataTable dtcariler = method.caribilgileriGetir(txtkod.Text);
            txtkod.Text = dtcariler.Rows[0]["carikod"].ToString();
            txtadres.Text = dtcariler.Rows[0]["adres"].ToString();
            txtUnvan.Text = dtcariler.Rows[0]["unvan"].ToString();
            txtvergiadi.Text = dtcariler.Rows[0]["vdaireadi"].ToString();
            txtvergino.Text = dtcariler.Rows[0]["vergino"].ToString();
            txtwebsitesi.Text = dtcariler.Rows[0]["websitesi"].ToString();
            cmbülke.SelectedItem = dtcariler.Rows[0]["ulke"].ToString();
            DataTable dtlist1 = method.İlGridGetir("", cmbülke.SelectedItem.ToString());
            for (int i = 0; i < dtlist1.Rows.Count; i++)
            {
                cmbil.Properties.Items.Add(dtlist1.Rows[i][0]);
            }
            cmbil.SelectedItem = dtcariler.Rows[0]["il"].ToString();
            DataTable dtlist2 = method.İlceGridGetir("", cmbil.SelectedItem.ToString());
            for (int i = 0; i < dtlist.Rows.Count; i++)
            {
                cmbilce.Properties.Items.Add(dtlist2.Rows[i][0]);
            }
            cmbilce.SelectedItem = dtcariler.Rows[0]["ilce"].ToString();
            chkaktif.Checked = dtcariler.Rows[0]["aktif"].getbool();

        }

        private void frmCariler_Load(object sender, EventArgs e)
        {
            if (Core.Staticlerim.kullanicitipistatic!=1)
            {
                chkaktif.Visible = lblaktif.Visible = false;
            }
        }

        private void btnSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            method.CariSil(txtkod.Text, false);
        }

        private void btnİnsUpd_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (carikod=="")
            {
                Cariler mycari = new Cariler();
                Cari_Adresleri myadr = new Cari_Adresleri();
                mycari.cari_aktif =myadr.cariadr_aktif= chkaktif.Checked;
                mycari.cari_create_date = DateTime.Now.Date;
                mycari.cari_kod = txtkod.Text;
                mycari.cari_lastup_date = DateTime.Now.Date;
                mycari.cari_unvan = txtUnvan.Text;
                mycari.cari_vergidaire_adi = txtvergiadi.Text;
                mycari.cari_vergino = txtvergino.Text;
                myadr.cariadr_adres = txtadres.Text;
                myadr.cariadr_aktif = true;
                myadr.cariadr_carikod = txtkod.Text;
                myadr.cariadr_il = cmbil.SelectedItem.ToString();
                myadr.cariadr_ilce = cmbilce.SelectedItem.ToString();
                myadr.cariadr_ulke = cmbülke.SelectedItem.ToString();
                myadr.cariadr_websitesi = txtwebsitesi.Text;
                method.CariKaydet(mycari, myadr);
            }
            else
            {
                Cariler mycari = new Cariler();
                Cari_Adresleri myadr = new Cari_Adresleri();
                
                
                mycari.cari_aktif = myadr.cariadr_aktif = chkaktif.Checked;
                mycari.cari_kod = txtkod.Text;
                mycari.cari_lastup_date = DateTime.Now.Date;
                mycari.cari_unvan = txtUnvan.Text;
                mycari.cari_vergidaire_adi = txtvergiadi.Text;
                mycari.cari_vergino = txtvergino.Text;
                myadr.cariadr_adres = txtadres.Text;
                myadr.cariadr_aktif = true;
                myadr.cariadr_carikod = txtkod.Text;
                myadr.cariadr_il = cmbil.SelectedItem.ToString();
                myadr.cariadr_ilce = cmbilce.SelectedItem.ToString();
                myadr.cariadr_ulke = cmbülke.SelectedItem.ToString();
                myadr.cariadr_websitesi = txtwebsitesi.Text;
                method.CariGüncelle(mycari,myadr, txtkod.Text);
              
            }
            
           
        }

        private void txtkod_Click(object sender, EventArgs e)
        {
           
            DataTable dtlist = method.CariGridGetir("");
            frmGrid grid = new frmGrid(dtlist,"Cariler");
            grid.ShowDialog();
            this.Close();
        }

        private void txtkod_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode==Keys.Enter)
            {
                DataTable sayi = method.caribilgileriGetir(txtkod.Text);
            if (sayi.Rows.Count!=0)
            {
               frmCariler cari = new frmCariler(txtkod.Text);
                this.Close();
                cari.ShowDialog()
                    ;
            } 
            }
                
            
        }
    }
}