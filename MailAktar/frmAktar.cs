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
using System.Net.Mail;
using System.Reflection;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using İsTakip;
using Enti;
using Core;


namespace MailAktar
{
    public partial class frmAktar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAktar()
        {
            InitializeComponent();
            
        }
        
        public static string connectionstring = "";
        public static string veritabani = "";
        string id = "";
        string mailkonu = "";
        string mailicerik = "";
        int mailsayisi = 0;
        int epostasayisi = 0;
        string carikod = "";
        int myerecidrecno = 0;
        string yetkiliadi = "";
        string referansno = "";
        int i = 0;
        int mailbasarili = 0;
        int mailgonderentanimsiz = 0;
        public static string mailadres = "";
        Entity mydb = new Entity();
        
        private void btnAktar_ItemClick(object sender, ItemClickEventArgs e)
        {


            connectionstring = @"Data Source=DESKTOP-EE9HSPL\DBSERVER;Initial Catalog=İs_Takip;user id=sa;password=1475;Connect Timeout=200; pooling='true'; Max Pool Size=200";
                try
                {
                    veritabani = "İs_Takip";
                    // Create the Outlook application.  // in-line initialization
                    Outlook.Application oApp = new Outlook.Application();
                    
                    Outlook.NameSpace oNS = oApp.GetNamespace("mapi");
                   
                    oNS.Logon(Missing.Value, Missing.Value, false, true);
                   
                    Outlook.MAPIFolder oInbox = oNS.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
                    
                    Outlook.Items oItems = oInbox.Items;
                   
                    Outlook.MailItem oMsg = (Outlook.MailItem)oItems.GetLast();

                    int mailsay = oItems.Count;

                    using (var cn = new SqlConnection(connectionstring))
                    {
                        cn.Open();
                        cn.ChangeDatabase(veritabani);
                        var km = cn.CreateCommand();
                        foreach (Outlook.MailItem item in oItems)
                        {
                            i++;
                            
                           
                            id = item.EntryID;
                            if (string.IsNullOrEmpty(item.Subject)) // mail konusu null ise
                            {
                                mailkonu = "";
                            }
                            else
                            {
                                mailkonu = item.Subject;
                            }

                            if (string.IsNullOrEmpty(item.Body)) // mail içeriği null ise
                            {
                                mailicerik = "";
                            }
                            else
                            {
                                mailicerik = item.Body;
                            }

                            mailadres = item.SenderEmailAddress;
                            

                            try
                            {
                                mailsayisi = 0;
                                km.CommandText = @"select count(g.gor_Id) from dbo.Gorevler g with(nolock)  where  g.gor_lastup_date=@mailtarih AND g.gor_konu=@mailkonu and g.gor_icerik=@mailicerik ";
                                km.Parameters.Clear();
                                // km.Parameters.AddWithValue("@mailid", id);
                                km.Parameters.AddWithValue("@mailkonu", mailkonu);
                                km.Parameters.AddWithValue("@mailtarih", item.ReceivedTime);
                                km.Parameters.AddWithValue("@mailicerik", mailicerik);
                               // km.ExecuteNonQuery();
                                try
                                {
                                    mailsayisi = Convert.ToInt32(km.ExecuteScalar());
                                }
                                catch
                                {
                                    mailsayisi = 0;
                                }

                                if (mailsayisi == 0)
                                {
                                    km.CommandText = @"select count(cy.cariyet_Id) from dbo.Cari_Yetkilileri cy with(nolock) where cy.cariyet_personelmail=@eposta";
                                    km.Parameters.Clear();
                                    km.Parameters.AddWithValue("@eposta", item.SenderEmailAddress);
                                    try
                                    {
                                        epostasayisi = Convert.ToInt32(km.ExecuteScalar());
                                    }
                                    catch
                                    {
                                        epostasayisi = 0;
                                    }
                                    if (epostasayisi <= 0)
                                    {
                                        
                                        //frmCariYetkili yet = new frmCariYetkili(item.SenderEmailAddress,item.SenderEmailType);
                                        //yet.ShowDialog();
                                        

                                        km.CommandText = @"select count(cy.cariyet_Id) from dbo.Cari_Yetkilileri cy with(nolock) where cy.cariyet_personelmail=@eposta";
                                        km.Parameters.Clear();
                                        km.Parameters.AddWithValue("@eposta", item.SenderEmailAddress);
                                        try
                                        {
                                            epostasayisi = km.ExecuteScalar().tamsayim();
                                        }
                                        catch
                                        {
                                            epostasayisi = 0;
                                        }

                                        if (epostasayisi <= 0)
                                        {
                                            mailgonderentanimsiz += 1;
                                            Cari_Yetkilileri cariyet = new Cari_Yetkilileri();
                                            cariyet.cariyet_aktif = true;
                                            cariyet.cariyet_CariKod = "Deneme";
                                            cariyet.cariyet_personelmail = item.SenderEmailAddress;
                                            cariyet.cariyet_personeltipi = item.SenderEmailType;
                                            cariyet.cariyet_PersonelKod = item.SenderEmailAddress;
                                            km.CommandText = @"INSERT Cari_Yetkilileri
           (cariyet_CariKod
           ,cariyet_PersonelKod
           ,cariyet_PersonelFullName
           ,cariyet_personelmail
           ,cariyet_personeltipi
           ,cariyet_create_date
           ,cariyet_lastup_date
           ,cariyet_aktif)
     VALUES
           (@carikod
           ,@personel
           ,@personeladi
           ,@personelmail
           ,@tipi
           ,getdate()
           ,getdate()
           ,@aktif)";
                                            km.Parameters.Clear();
                                            km.Parameters.AddWithValue("@carikod",cariyet.cariyet_CariKod);
                                            km.Parameters.AddWithValue("@personel",cariyet.cariyet_PersonelKod);
                                            km.Parameters.AddWithValue("@personeladi",cariyet.cariyet_PersonelFullName.getString());
                                            km.Parameters.AddWithValue("@personelmail", cariyet.cariyet_personelmail);
                                            km.Parameters.AddWithValue("@tipi",cariyet.cariyet_personeltipi);
                                            km.Parameters.AddWithValue("@aktif",cariyet.cariyet_aktif.tamsayim());
                                            km.ExecuteNonQuery();
                                            continue;
                                        }
                                        else if (epostasayisi > 0)
                                        {
                                            
                                            //
                                            km.CommandText = "SELECT cy.cariyet_Id,cy.cariyet_CariKod,cy.cariyet_PersonelKod FROM dbo.Cari_Yetkilileri cy with(nolock) WHERE cy.cariyet_personelmail=@posta";
                                            km.Parameters.Clear();
                                            km.Parameters.AddWithValue("@eposta", item.SenderEmailAddress);
                                            DataTable dt = new DataTable();
                                            SqlDataAdapter da = new SqlDataAdapter(km);
                                            da.Fill(dt);

                                            if (dt.Rows.Count > 0)
                                            {
                                                //email adresi bulunuyor
                                                myerecidrecno = Convert.ToInt32(dt.Rows[0][0]);
                                               
                                                carikod = dt.Rows[0][1].ToString();
                                                yetkiliadi = dt.Rows[0][2].ToString();

                                            }
                                            else
                                            {
                                                //email adresi yok cari yetkililerinde kayıt açılabilir
                                                //carikod için kullanıcıya sorulur 
                                            }


                                            km.CommandText = "SELECT count(g.gor_Id) from dbo.Gorevler g with(nolock) WHERE g.gor_kod LIKE 'AKT%' ";
                                            km.Parameters.Clear();
                                            int satir = km.ExecuteScalar().tamsayim();
                                            if (satir > 0)
                                            {
                                                satir++;
                                                referansno = "AKT00000" + satir.ToString();

                                            }
                                            else
                                            {
                                                referansno = "AKT000001";
                                            }

                                            km.CommandText = @"INSERT dbo.Gorevler
(
    --gor_Id - this column value is auto-generated
    gor_kod,
    gor_carikod,
    gor_personelkod,
    gor_icerik,
    gor_konu,
    gor_not,
    gor_sirano,
    gor_durumkod,
    gor_create_date,
    gor_lastup_date,
    gor_bitis_date,
    gor_tipi,
    gor_aktif
)
VALUES
(
    -- gor_Id - int
   @referansno, -- gor_kod - nvarchar
   @cari, -- gor_carikod - nvarchar
    @yetkili, -- gor_personelkod - nvarchar
   @icerik, -- gor_icerik - nvarchar
   @mailsubject, -- gor_konu - nvarchar
    N'', -- gor_not - nvarchar
    0, -- gor_sirano - int
    'Tamamlanmadı', -- gor_durumkod - nvarchar
    @baslangiczamani, -- gor_create_date - datetime
    @baslangiczamani, -- gor_lastup_date - datetime
    @bitiszamani, -- gor_bitis_date - datetime
    N'Normal', -- gor_tipi - nvarchar
    1 -- gor_aktif - bit
)";

                                            km.Parameters.Clear();
                                            km.Parameters.AddWithValue("@baslangiczamani", item.ReceivedTime);
                                            km.Parameters.AddWithValue("@bitiszamani", item.ReceivedTime);
                                            km.Parameters.AddWithValue("@cari", "Deneme");
                                           
                                            km.Parameters.AddWithValue("@icerik", mailicerik);
                                            km.Parameters.AddWithValue("@yetkili", yetkiliadi);
                                            km.Parameters.AddWithValue("@mailsubject",
                                                mailkonu);
                                            
                                            km.Parameters.AddWithValue("@referansno", referansno);

                                            
                                            try
                                            {
                                                km.ExecuteNonQuery();
                                                
                                                mailbasarili += 1;
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.ToString());
                                                return;
                                            }


                                        }
                                    }
                                    else if (epostasayisi > 0)
                                    {
                                       
                                        //
                                        km.CommandText = "SELECT cy.cariyet_Id,cy.cariyet_CariKod,cy.cariyet_PersonelKod FROM dbo.Cari_Yetkilileri cy with(nolock) WHERE cy.cariyet_personelmail=@posta";
                                        km.Parameters.Clear();
                                        km.Parameters.AddWithValue("@posta", item.SenderEmailAddress);
                                        DataTable dt = new DataTable();
                                        SqlDataAdapter da = new SqlDataAdapter(km);
                                        da.Fill(dt);

                                        if (dt.Rows.Count > 0)
                                        {
                                            //email adresi bulunuyor
                                            myerecidrecno = Convert.ToInt32(dt.Rows[0][0]);

                                            carikod = dt.Rows[0][1].ToString();
                                            yetkiliadi = dt.Rows[0][2].ToString();

                                       
 km.CommandText = "SELECT count(g.gor_Id) from dbo.Gorevler g with(nolock) WHERE g.gor_kod LIKE 'AKT%' ";
                                            km.Parameters.Clear();
                                            int satir=km.ExecuteScalar().tamsayim();
                                            if(satir>0)
                                            {
                                                satir++;
                                                referansno = "AKT00000" + satir.ToString();

                                            }
                                            else
                                            {
                                                referansno = "AKT000001";
                                            }

                                       km.CommandText = @"INSERT dbo.Gorevler
(
    --gor_Id - this column value is auto-generated
    gor_kod,
    gor_carikod,
    gor_personelkod,
    gor_icerik,
    gor_konu,
    gor_not,
    gor_sirano,
    gor_durumkod,
    gor_create_date,
    gor_lastup_date,
    gor_bitis_date,
    gor_tipi,
    gor_aktif
)
VALUES
(
    -- gor_Id - int
   @referansno, -- gor_kod - nvarchar
   @cari, -- gor_carikod - nvarchar
    @yetkili, -- gor_personelkod - nvarchar
   @icerik, -- gor_icerik - nvarchar
   @mailsubject, -- gor_konu - nvarchar
    N'', -- gor_not - nvarchar
    0, -- gor_sirano - int
    '1', -- gor_durumkod - nvarchar
    @baslangiczamani, -- gor_create_date - datetime
    @baslangiczamani, -- gor_lastup_date - datetime
    @bitiszamani, -- gor_bitis_date - datetime
    N'Normal', -- gor_tipi - nvarchar
    1 -- gor_aktif - bit
)";

                                            km.Parameters.Clear();
                                            km.Parameters.AddWithValue("@baslangiczamani", item.ReceivedTime);
                                            km.Parameters.AddWithValue("@bitiszamani", item.ReceivedTime);
                                            km.Parameters.AddWithValue("@cari", carikod);
                                           
                                            km.Parameters.AddWithValue("@icerik", mailicerik);
                                            km.Parameters.AddWithValue("@yetkili", yetkiliadi);
                                            km.Parameters.AddWithValue("@mailsubject",
                                                mailkonu);
                                            
                                            km.Parameters.AddWithValue("@referansno", referansno);

                                            
                                            
                                                km.ExecuteNonQuery();
                                                
                                                mailbasarili += 1;
                                            

                                        }}}
                                else
                                {
                                    continue;
                                }

                           
                        }
                            catch  (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        
                    }
                    //Display the message.
                    // oMsg.Display(true);  //modal
                        km.Dispose();
                        cn.Close();
                    //Log off.
                    oNS.Logoff();

                    //Explicitly release objects.
                    oMsg = null;
                    oItems = null;
                    oInbox = null;
                    oNS = null;
                    oApp = null;
                }
        }
                catch (Exception ex)
                {
                    MessageBox.Show(i.ToString() + "\n" + ex.ToString());

                }
                //lbl_hatamesaji.Text = Convert.ToString(mailbasarili) + "  Adet Başarılı Aktarım  "+ Convert.ToString(mailgonderentanimsiz) + "  Adet Tanımsız Gönderen";
                MessageBox.Show("İşlem Tamamlanmıştır.");
            
            }

     
    }
    }
