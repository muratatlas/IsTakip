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
using Core;

namespace İsTakip
{
    public partial class frmGorevler : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string gorevkod;
        Methodlarim method = new Methodlarim();
        Entity mydb = new Entity();
        public frmGorevler()
        {
            InitializeComponent();
            DataTable dtlist = method.DurumlarComboGetir();
            for (int i = 0; i < dtlist.Rows.Count; i++)
            {
                cmbDurum.Properties.Items.Add(dtlist.Rows[i][0]);
            }
            cmbDurum.SelectedIndex = 0;
            chkaktif.Checked = true;
        }
        public frmGorevler(string kod)
        {
            InitializeComponent();
            DataTable dtlist = method.DurumlarComboGetir();
            for (int i = 0; i < dtlist.Rows.Count; i++)
            {
                cmbDurum.Properties.Items.Add(dtlist.Rows[i][0]);
            }
            gorevkod = kod;

            DataTable dtgorev= method.GorevBilgileriGetir(gorevkod);

            
            txtCariKod.Text = dtgorev.Rows[0]["cari"].ToString();
            txtGorevKod.Text = gorevkod;
            txtPersonel.Text = dtgorev.Rows[0]["personel"].ToString();
            txtKonu.Text = dtgorev.Rows[0]["konu"].ToString();
            txticerik.Text = dtgorev.Rows[0]["icerik"].ToString();
            cmbDurum.SelectedItem = dtgorev.Rows[0]["durum"].ToString();
            txtTip.Text = dtgorev.Rows[0]["tip"].ToString();
            txtNot.Text = "";
            chkaktif.Checked = dtgorev.Rows[0]["aktif"].getbool();
        }

        private void txtGorevKod_Click(object sender, EventArgs e)
        {
            DataTable dt = method.GorevleriGetir("");
            frmGrid grid = new frmGrid(dt, "Gorevler");
            grid.ShowDialog();
            this.Close();
        }

        private void txtGorevKod_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode==Keys.Enter)
            {
                if (txtGorevKod.Text == null)
            {
                MessageBox.Show("Gorev Kodunu Kontrol ediniz");
                return;
            }
            DataTable dtgorev= method.GorevBilgileriGetir(txtGorevKod.Text);

            
            txtCariKod.Text = dtgorev.Rows[0]["cari"].ToString();
            txtPersonel.Text = dtgorev.Rows[0]["personel"].ToString();
            txtKonu.Text = dtgorev.Rows[0]["konu"].ToString();
            txticerik.Text = dtgorev.Rows[0]["icerik"].ToString();
            cmbDurum.SelectedItem = dtgorev.Rows[0]["durum"].ToString();
            txtTip.Text = dtgorev.Rows[0]["tip"].ToString();
            txtNot.Text = "";
            chkaktif.Checked = dtgorev.Rows[0]["aktif"].getbool();
            }
        }
        string mailto = "";
        private void btnİnsUpd_ItemClick(object sender, ItemClickEventArgs e)
        {
            mailto = method.MailMetniOluştur(txtCariKod.Text, txtPersonel.Text);
            //Cari_Yetkilileri yetkili = mydb.Cari_Yetkilileri.FirstOrDefault(x => x.cariyet_PersonelKod == txtPersonel.Text);
            DataTable dtmailbilgileri = method.MailBilgileriGetir();
            if (gorevkod == "")
            {
                Gorevler mygorev = new Gorevler();
                mygorev.gor_aktif = chkaktif.Checked;
                if (cmbDurum.SelectedItem == "Tamanlandi")
                {
                    mygorev.gor_aktif = false;
                    mygorev.gor_bitis_date = DateTime.Now.Date;
                }
                mygorev.gor_lastup_date = DateTime.Now.getdate();
                mygorev.gor_create_date = DateTime.Now.getdate();
                mygorev.gor_carikod = txtCariKod.Text;
                mygorev.gor_durumkod = cmbDurum.SelectedIndex.ToString();
                mygorev.gor_icerik = txtNot.Text + "\n------------------------------------------------------------\n" + txticerik.Text;
                mygorev.gor_kod = txtGorevKod.Text;
                mygorev.gor_konu = txtKonu.Text;
                mygorev.gor_not = txtNot.Text + "\n------------------------------------------------------------\n" + mygorev.gor_not;
                mygorev.gor_personelkod = txtPersonel.Text;
                mygorev.gor_sirano = 0;
                mygorev.gor_tipi = txtTip.Text;

                method.GorevleriKaydet(mygorev);
            }
            else
            {
                Gorevler mygorev = new Gorevler();
                //mygorev = mydb.Gorevler.FirstOrDefault(x => x.gor_kod == txtGorevKod.Text);
                if (cmbDurum.SelectedItem == "Tamanlandi")
                {
                    mygorev.gor_aktif = false;
                    mygorev.gor_bitis_date = DateTime.Now.Date;
                }
                else
                {
                    string tarih = "";
                    mygorev.gor_aktif = true;
                    mygorev.gor_bitis_date = tarih.getdate();
                }
                mygorev.gor_lastup_date = DateTime.Now.getdate();
                mygorev.gor_create_date = DateTime.Now.getdate();
                mygorev.gor_carikod = txtCariKod.Text;
                mygorev.gor_durumkod = cmbDurum.SelectedIndex.getString();
                mygorev.gor_icerik = txtNot.Text + "\n------------------------------------------------------------\n" + txticerik.Text;
                mygorev.gor_kod = txtGorevKod.Text;
                mygorev.gor_konu = txtKonu.Text;
                mygorev.gor_not = txtNot.Text + "\n------------------------------------------------------------\n" + mygorev.gor_not;
                mygorev.gor_personelkod = txtPersonel.Text;
                mygorev.gor_sirano = 0;
                mygorev.gor_tipi = txtTip.Text;


                method.GorevleriGüncelle(mygorev, gorevkod);
            }
        }

        private void btnSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string kod = mydb.Gorevler.FirstOrDefault(x => x.gor_kod == txtGorevKod.Text).getString();
            DataTable dtmailbilgileri = method.MailBilgileriGetir();
            if (dtmailbilgileri.Rows.Count ==0)
            {
                MessageBox.Show("Görev Kodu Seçiniz");
            }
            else
            {

                method.GorevleriSil(dtmailbilgileri.Rows[0]["kod"].ToString());
            }
        }

        private void txtGorevKod_TextChanged(object sender, EventArgs e)
        {
            //txtGorevKod_KeyDown(null, null);
        }

        private void frmGorevler_Load(object sender, EventArgs e)
        {
            if (Core.Staticlerim.kullanicitipistatic != 1)
            {
                chkaktif.Visible = lblaktif.Visible = false;
            }
        }

        private void btnKaydetGönder_ItemClick(object sender, ItemClickEventArgs e)
        {
            mailto = method.MailMetniOluştur(txtCariKod.Text, txtPersonel.Text);
            //Cari_Yetkilileri yetkili = mydb.Cari_Yetkilileri.FirstOrDefault(x => x.cariyet_PersonelKod == txtPersonel.Text);
            string mail=method.maildon(txtPersonel.Text);
            DataTable dtmailbilgileri = method.MailBilgileriGetir();
            if (gorevkod == "")
            {
                Gorevler mygorev = new Gorevler();
                mygorev.gor_aktif = chkaktif.Checked;
                if (cmbDurum.SelectedItem == "Tamanlandi")
                {
                    mygorev.gor_aktif = false;
                    mygorev.gor_bitis_date = DateTime.Now.Date;
                }
                mygorev.gor_lastup_date = DateTime.Now.getdate();
                mygorev.gor_create_date = DateTime.Now.getdate();
                mygorev.gor_carikod = txtCariKod.Text;
                mygorev.gor_durumkod = cmbDurum.SelectedIndex.ToString();
                mygorev.gor_icerik = txtNot.Text + "\n------------------------------------------------------------\n" + txticerik.Text;
                mygorev.gor_kod = txtGorevKod.Text;
                mygorev.gor_konu = txtKonu.Text;
                mygorev.gor_not = txtNot.Text + "\n------------------------------------------------------------\n" + mygorev.gor_not;
                mygorev.gor_personelkod = txtPersonel.Text;
                mygorev.gor_sirano = 0;
                mygorev.gor_tipi = txtTip.Text;
                method.MailGonder(dtmailbilgileri.Columns["adres"].ToString(), mail, dtmailbilgileri.Columns["useradi"].ToString(), mailto, "", mygorev.gor_konu, mygorev.gor_icerik, mail, dtmailbilgileri.Columns["sifre"].ToString(), dtmailbilgileri.Columns["sunucu"].ToString(), dtmailbilgileri.Columns["port"].tamsayim(), dtmailbilgileri.Columns["sll"].getbool(), true);
                method.GorevleriKaydet(mygorev);
            }
            else
            {
                Gorevler mygorev = new Gorevler();
                mygorev = mydb.Gorevler.FirstOrDefault(x => x.gor_kod == txtGorevKod.Text);
                if (cmbDurum.SelectedItem == "Tamanlandi")
                {
                    mygorev.gor_aktif = false;
                    mygorev.gor_bitis_date = DateTime.Now.Date;
                }
                else
                {
                    string tarih = "";
                    mygorev.gor_aktif = true;
                    mygorev.gor_bitis_date = tarih.getdate();
                }
                mygorev.gor_lastup_date = DateTime.Now.getdate();
                mygorev.gor_create_date = DateTime.Now.getdate();
                mygorev.gor_carikod = txtCariKod.Text;
                mygorev.gor_durumkod = cmbDurum.SelectedIndex.getString();
                mygorev.gor_icerik = txtNot.Text + "\n------------------------------------------------------------\n" + txticerik.Text;
                mygorev.gor_kod = txtGorevKod.Text;
                mygorev.gor_konu = txtKonu.Text;
                mygorev.gor_not = txtNot.Text + "\n------------------------------------------------------------\n" + mygorev.gor_not;
                mygorev.gor_personelkod = txtPersonel.Text;
                mygorev.gor_sirano = 0;
                mygorev.gor_tipi = txtTip.Text;

                method.MailGonder(dtmailbilgileri.Columns["adres"].ToString(), mail, dtmailbilgileri.Columns["useradi"].ToString(), mailto, "", mygorev.gor_konu, mygorev.gor_icerik, mail, dtmailbilgileri.Columns["sifre"].ToString(), dtmailbilgileri.Columns["sunucu"].ToString(), dtmailbilgileri.Columns["port"].tamsayim(), dtmailbilgileri.Columns["sll"].getbool(), true);
                method.GorevleriGüncelle(mygorev, gorevkod);
            }
        }
    }
}
    
