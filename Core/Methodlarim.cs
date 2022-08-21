using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sql;
using System.Configuration;
using System.Data;
using Enti;
using System.Windows.Forms;
using System.Net.Mail;

namespace Core
{
  public  class Methodlarim
    {
      Entity mydb = new Entity();

        SqlSet _s = new SqlSet(@"Data Source=DESKTOP-EE9HSPL\DBSERVER;Initial Catalog=İs_Takip;user id=sa;password=1475;Connect Timeout=200; pooling='true'; Max Pool Size=200");
        DataTable dt = new DataTable();
     
        public int KullaniciKontrolEt(string kadi, string pass)
        {
            Account kullanici = new Account();
            _s.Cmd.CommandText = @"SELECT a.Ac_Login_tipi FROM	dbo.Account a WHERE a.Ac_Name=@kod AND a.Ac_Password=@pass";

            _s.Cmd.Parameters.Clear();
            _s.Cmd.Parameters.AddWithValue("@kod", kadi);
            _s.Cmd.Parameters.AddWithValue("@pass", pass);
            return _s.Cmd.ExecuteScalar().tamsayim();
        }
        public DataTable KullaniciListesi(string kod)
        {
            dt.Clear();
            _s.Cmd.CommandText = @"EXEC dbo.sp_KullaniciGetir @kod";
            _s.Cmd.Parameters.Clear();
            _s.Cmd.Parameters.AddWithValue("@kod", kod);
            _s.Da.Fill(dt);
            return dt;
        }
        public DataTable CariListesiGetir(string kod)
        {
            dt.Clear();
            _s.Cmd.CommandText = @"EXEC dbo.sp_CariGetir @kod";
            _s.Cmd.Parameters.Clear();
            _s.Cmd.Parameters.AddWithValue("@kod", kod);
            _s.Da.Fill(dt);
            return dt;
        }
        public void kullaniciKaydet(Account ac)
        {
            _s.Cmd.CommandText = @"INSERT INTO [dbo].[Account]
           ([Ac_Name]
           ,[Ac_Password]
           ,[Ac_Create_date]
           ,[Ac_Lastup_date]
           ,[Ac_Online]
           ,[Ac_Login_tipi]
           ,[Ac_Aktif])
     VALUES
           (@name
           ,@pass
           ,getdate()
           ,getdate()
           ,@online
           ,@online
           ,@aktif)";
            _s.Cmd.Parameters.AddWithValue("@name", ac.Ac_Name);
            _s.Cmd.Parameters.AddWithValue("@pass", ac.Ac_Password);
            _s.Cmd.Parameters.AddWithValue("@name", ac.Ac_Name);
            _s.Cmd.Parameters.AddWithValue("@aktif", ac.Ac_Aktif);
            _s.Cmd.Parameters.AddWithValue("@online", ac.Ac_Online);
            _s.Cmd.Parameters.AddWithValue("@login", ac.Ac_Login_tipi);
            _s.Cmd.ExecuteNonQuery();
        }
        public void kullaniciSil(string kod)
        {
            _s.Cmd.CommandText = @"delete Account where Ac_Name=@kod";
            _s.Cmd.Parameters.AddWithValue("@kod", kod);
            _s.Cmd.ExecuteNonQuery();
        }
        public void kullaniciGüncelle(Account ac,string kod)
        {
            _s.Cmd.CommandText = @"UPDATE [dbo].[Account]
   SET [Ac_Name] = @name
      ,[Ac_Password] = @pass
      ,[Ac_Lastup_date] = getdate()
      ,[Ac_Online] = @online
      ,[Ac_Login_tipi] = @login
      ,[Ac_Aktif] = @aktif
 WHERE Ac_Name=@kod";
            _s.Cmd.Parameters.AddWithValue("@name", ac.Ac_Name);
            _s.Cmd.Parameters.AddWithValue("@pass", ac.Ac_Password);
            _s.Cmd.Parameters.AddWithValue("@name", ac.Ac_Name);
            _s.Cmd.Parameters.AddWithValue("@aktif", ac.Ac_Aktif);
            _s.Cmd.Parameters.AddWithValue("@online", ac.Ac_Online);
            _s.Cmd.Parameters.AddWithValue("@login", ac.Ac_Login_tipi);
            _s.Cmd.Parameters.AddWithValue("@kod", kod);
            _s.Cmd.ExecuteNonQuery();

        }
        public void CariKaydet(Cariler cari,Cari_Adresleri cariadr)
        {
            _s.Cmd.CommandText = @"INSERT INTO [dbo].[Cariler]
           ([cari_kod]
           ,[cari_unvan]
           ,[cari_vergino]
           ,[cari_vergidaire_adi]
           ,[cari_create_date]
           ,[cari_lastup_date]
           ,[cari_aktif])
     VALUES
           (@cari
           ,@unvan
           ,@vergino
           ,@vergiadi
           ,getdate()
           ,getdate()
           ,@aktif)";
            _s.Cmd.Parameters.Clear();
            _s.Cmd.Parameters.AddWithValue("@cari", cari.cari_kod);
            _s.Cmd.Parameters.AddWithValue("@unvan", cari.cari_unvan);
            _s.Cmd.Parameters.AddWithValue("@vergino",cari.cari_vergino);
            _s.Cmd.Parameters.AddWithValue("@vergiadi", cari.cari_vergidaire_adi);
            _s.Cmd.Parameters.AddWithValue("@aktif", cari.cari_aktif.getbool());
            _s.Cmd.ExecuteNonQuery();
            _s.Cmd.CommandText = @"INSERT INTO [dbo].[Cari_Adresleri]
           ([cariadr_carikod]
           ,[cariadr_ulke]
           ,[cariadr_il]
           ,[cariadr_ilce]
           ,[cariadr_adres]
           ,[cariadr_websitesi]
           ,[cariadr_aktif])
     VALUES
           (@cari
           ,@ulke
           ,@il
           ,@ilce
           ,@adres
           ,@web
           ,@aktif
)";
            _s.Cmd.Parameters.Clear();
            _s.Cmd.Parameters.AddWithValue("@cari", cariadr.cariadr_carikod);
            _s.Cmd.Parameters.AddWithValue("@ulke", cariadr.cariadr_ulke);
            _s.Cmd.Parameters.AddWithValue("@il", cariadr.cariadr_il);
            _s.Cmd.Parameters.AddWithValue("@ilce", cariadr.cariadr_ilce);
            _s.Cmd.Parameters.AddWithValue("@web", cariadr.cariadr_websitesi);
            _s.Cmd.Parameters.AddWithValue("@aktif", cari.cari_aktif.getbool());
            _s.Cmd.ExecuteNonQuery();

        }
        public void CariSil(string kod,bool neoldu)
        {
            _s.Cmd.CommandText = @"exec sp_CariSil @kod,@bool";
            _s.Cmd.Parameters.Clear();
            _s.Cmd.Parameters.AddWithValue("@kod", kod);
            _s.Cmd.Parameters.AddWithValue("@bool", neoldu);
            _s.Cmd.ExecuteNonQuery();
        }
      public void CariGüncelle(Cariler cari,Cari_Adresleri cariadr,string kod)
        {
           _s.Cmd.CommandText=@"UPDATE [dbo].[Cariler]
   SET [cari_kod] = @cari
      ,[cari_unvan] = @unvan
      ,[cari_vergino] = @vergino
      ,[cari_vergidaire_adi] = @vergiadi
      ,[cari_lastup_date] = getdate()
      ,[cari_aktif] = @aktif
 WHERE cari_kod=@kod";
           _s.Cmd.Parameters.Clear();
           _s.Cmd.Parameters.AddWithValue("@kod", kod);
           _s.Cmd.Parameters.AddWithValue("@cari", cari.cari_kod);
           _s.Cmd.Parameters.AddWithValue("@unvan", cari.cari_unvan);
           _s.Cmd.Parameters.AddWithValue("@vergino", cari.cari_vergino);
           _s.Cmd.Parameters.AddWithValue("@vergiadi", cari.cari_vergidaire_adi);
           _s.Cmd.Parameters.AddWithValue("@aktif", cari.cari_aktif.getbool());
           _s.Cmd.ExecuteNonQuery();
           _s.Cmd.CommandText = @"UPDATE [dbo].[Cari_Adresleri]
   SET [cariadr_carikod] = @cari
      ,[cariadr_ulke] = @ulke
      ,[cariadr_il] = @il
      ,[cariadr_ilce] = @ilce
      ,[cariadr_adres] =@adres
      ,[cariadr_websitesi] = @web
      ,[cariadr_aktif] = @aktif
 WHERE cariadr_carikod=@kod";
           _s.Cmd.Parameters.Clear();
           _s.Cmd.Parameters.AddWithValue("@cari", cariadr.cariadr_carikod);
           _s.Cmd.Parameters.AddWithValue("@ulke", cariadr.cariadr_ulke);
           _s.Cmd.Parameters.AddWithValue("@il", cariadr.cariadr_il);
           _s.Cmd.Parameters.AddWithValue("@ilce", cariadr.cariadr_ilce);
           _s.Cmd.Parameters.AddWithValue("@kod", kod);
           _s.Cmd.Parameters.AddWithValue("@web", cariadr.cariadr_websitesi);
           _s.Cmd.Parameters.AddWithValue("@aktif", cari.cari_aktif.getbool());
           _s.Cmd.ExecuteNonQuery();
            if (cari.cari_aktif==true)
            {
                _s.Cmd.CommandText = @"exec sp_CariAktif @kod";
                _s.Cmd.Parameters.Clear();
                _s.Cmd.Parameters.AddWithValue("@kod", kod);
                _s.Cmd.ExecuteNonQuery();
            }
        }
      public DataTable PersonelGetir(string kod)
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_CariYetkilileriGetir @kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
      }
      public DataTable caribilgileriGetir(string kod)
      {
           dt.Clear();
          _s.Cmd.CommandText = @"exec sp_CariBilgileriGetir @kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
      }

          public DataTable cariyetkilibilgileriGetir(string kod)
      {
           dt.Clear();
          _s.Cmd.CommandText = @"exec sp_CariYetkilileriniGetir @kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
      }
      public void YetkiliDeaktif(string kod)
          {
              _s.Cmd.CommandText = @"UPDATE Cari_Yetkilileri set cariyet_aktif=false where cariyet_PersonelKod=";
              _s.Cmd.Parameters.Clear();
              _s.Cmd.Parameters.AddWithValue("@kod", kod);
              _s.Cmd.ExecuteNonQuery();
          }
      public void PersonelSil(string kod)
      {
          _s.Cmd.CommandText = @"delete Cari_Yetkilileri where cariyet_PersonelKod=@kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Cmd.ExecuteNonQuery();
      }
      public void PersonelKaydet(Cari_Yetkilileri cariyet)
      {
          _s.Cmd.CommandText = @"INSERT INTO [dbo].[Cari_Yetkilileri]
           ([cariyet_CariKod]
           ,[cariyet_PersonelKod]
           ,[cariyet_PersonelFullName]
           ,[cariyet_personelmail]
           ,[cariyet_personeltipi]
           ,[cariyet_create_date]
           ,[cariyet_lastup_date]
           ,[cariyet_aktif])
     VALUES
           (@cari
           ,@personel
           ,@ad
           ,@mail
           ,@tip
           ,getdate()
           ,getdate()
           ,@aktif)";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@cari", cariyet.cariyet_CariKod);
          _s.Cmd.Parameters.AddWithValue("@personel", cariyet.cariyet_PersonelKod);
          _s.Cmd.Parameters.AddWithValue("@ad", cariyet.cariyet_PersonelFullName);
          _s.Cmd.Parameters.AddWithValue("@mail", cariyet.cariyet_personelmail);
          _s.Cmd.Parameters.AddWithValue("@aktif", cariyet.cariyet_aktif);
          _s.Cmd.Parameters.AddWithValue("@tip", cariyet.cariyet_personeltipi);

          _s.Cmd.ExecuteNonQuery();
      }
      public void PersonelGüncele(Cari_Yetkilileri cariyet,string kod)
      {
          _s.Cmd.CommandText = @"UPDATE [dbo].[Cari_Yetkilileri]
   SET [cariyet_CariKod] = @cair
      ,[cariyet_PersonelKod] = @personel
      ,[cariyet_PersonelFullName] = @ad
      ,[cariyet_personelmail] = @mail
      ,[cariyet_personeltipi] = @tip
      ,[cariyet_lastup_date] = getdate()
      ,[cariyet_aktif] = @aktif
 WHERE cariyet_PersonelKod=@kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Cmd.Parameters.AddWithValue("@cari", cariyet.cariyet_CariKod);
          _s.Cmd.Parameters.AddWithValue("@personel", cariyet.cariyet_PersonelKod);
          _s.Cmd.Parameters.AddWithValue("@ad", cariyet.cariyet_PersonelFullName);
          _s.Cmd.Parameters.AddWithValue("@mail", cariyet.cariyet_personelmail);
          _s.Cmd.Parameters.AddWithValue("@aktif", cariyet.cariyet_aktif);
          _s.Cmd.Parameters.AddWithValue("@tip", cariyet.cariyet_personeltipi);

          _s.Cmd.ExecuteNonQuery();
      }
      public DataTable DurumlariGetir(string kod)
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_DurumlariGetir @kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
      }
      //public void DurumKaydet(Durumlar dur)
      //{
      //    mydb.Durumlar.Add(dur);
      //    mydb.SaveChanges();
      //}
      //public void DurumSil(string kod)
      //{
      //    Durumlar dur = null;
      //    dur = mydb.Durumlar.FirstOrDefault(x0 => x0.dur_kodu == kod);
      //    dur.dur_aktif = false;
      //    mydb.SaveChanges();
      //}
      //public void DurumGüncelle (Durumlar mydur,string kod)
      //{
      //    Durumlar dur = null;
      //    dur = mydb.Durumlar.FirstOrDefault(x0 => x0.dur_kodu == kod);
      //    dur.dur_adi = mydur.dur_adi;
      //    dur.dur_aktif = mydur.dur_aktif;
      //    dur.dur_kodu = mydur.dur_kodu;
      //    dur.dur_lastup_date = mydur.dur_lastup_date;
      //    mydb.SaveChanges();
      //}
      //public DataTable İliskiGetir(string kod)
      //{
      //    dt.Clear();
      //    _s.Cmd.CommandText = @"exec sp_İliskileriGetir @kod";
      //    _s.Cmd.Parameters.Clear();
      //    _s.Cmd.Parameters.AddWithValue("@kod", kod);
      //    _s.Da.Fill(dt);
      //    return dt;
      //}
      //public void İliskiKaydet(İliskiler ilis)
      //{
      //    mydb.İliskiler.Add(ilis);
      //    mydb.SaveChanges();
      //}
      //public void İliskiSil(string kod)
      //{
      //    İliskiler ilis = null;
      //    ilis = mydb.İliskiler.FirstOrDefault(x => x.ilis_kodu == kod);
      //    ilis.ilis_aktif = false;
      //    mydb.SaveChanges();
      //}
      //public void İlslkiGüncelle(İliskiler myilis,string kod)
      //{
      //    İliskiler ilis = null;
      //    ilis = mydb.İliskiler.FirstOrDefault(x => x.ilis_kodu == kod);
      //    ilis.ilis_adi = myilis.ilis_adi;
      //    ilis.ilis_aktif = myilis.ilis_aktif;
      //    ilis.ilis_kodu = myilis.ilis_kodu;
      //    ilis.ilis_lastup_date = myilis.ilis_lastup_date;
      //    mydb.SaveChanges();
      //}
      public DataTable GorevleriGetir(string kod)
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_GorevleriGetir @kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
      }
      public void GorevleriKaydet(Gorevler gorev)
      {
          _s.Cmd.CommandText = @"INSERT INTO [dbo].[Gorevler]
           ([gor_kod]
           ,[gor_carikod]
           ,[gor_personelkod]
           ,[gor_icerik]
           ,[gor_konu]
           ,[gor_not]
           ,[gor_sirano]
           ,[gor_durumkod]
           ,[gor_create_date]
           ,[gor_lastup_date]
           ,[gor_bitis_date]
           ,[gor_tipi]
           ,[gor_aktif])
     VALUES
           (@gor
           ,@cari
           ,@personel
           ,@icerik
           ,@konu
           ,@not
           ,@sira
           ,@durum
           ,getdate()
           ,getdate()
           ,'18991212'
           ,@tip
           ,@aktif)";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@gor", gorev.gor_kod);
          _s.Cmd.Parameters.AddWithValue("@cari", gorev.gor_carikod);
          _s.Cmd.Parameters.AddWithValue("@personel", gorev.gor_personelkod);
          _s.Cmd.Parameters.AddWithValue("@icerik", gorev.gor_icerik);
          _s.Cmd.Parameters.AddWithValue("@sira", gorev.gor_sirano);
          _s.Cmd.Parameters.AddWithValue("@konu", gorev.gor_konu);
          _s.Cmd.Parameters.AddWithValue("@durum", gorev.gor_durumkod);
          _s.Cmd.Parameters.AddWithValue("@tip", gorev.gor_tipi);
          _s.Cmd.Parameters.AddWithValue("@aktif", gorev.gor_aktif.getbool());
          _s.Cmd.Parameters.AddWithValue("@not", gorev.gor_not);

          _s.Cmd.ExecuteNonQuery();
      }
      public void GorevleriSil(string kod)
      {
          _s.Cmd.CommandText=@"update Gorevler set gor_aktif=0 where gor_kod="+kod+" ";
              _s.Cmd.ExecuteNonQuery();
      }
      public void GorevleriGüncelle(Gorevler gorev,string kod)
      {
          _s.Cmd.CommandText = @"UPDATE [dbo].[Gorevler]
   SET [gor_kod] = @gor
      ,[gor_carikod] = @cari
      ,[gor_personelkod] = @personel
      ,[gor_icerik] = @icerik
      ,[gor_konu] = @konu
      ,[gor_not] = @not
      ,[gor_sirano] = @sira
      ,[gor_durumkod] = @durum
      ,[gor_lastup_date] = getdate()
      ,[gor_bitis_date] = @bitis
      ,[gor_tipi] = @tip
      ,[gor_aktif] =@aktif
 WHERE gor_kod=@kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Cmd.Parameters.AddWithValue("@gor", gorev.gor_kod);
          _s.Cmd.Parameters.AddWithValue("@cari", gorev.gor_carikod);
          _s.Cmd.Parameters.AddWithValue("@personel", gorev.gor_personelkod);
          _s.Cmd.Parameters.AddWithValue("@icerik", gorev.gor_icerik);
          _s.Cmd.Parameters.AddWithValue("@sira", gorev.gor_sirano);
          _s.Cmd.Parameters.AddWithValue("@konu", gorev.gor_konu);
          _s.Cmd.Parameters.AddWithValue("@durum", gorev.gor_durumkod);
          _s.Cmd.Parameters.AddWithValue("@bitis", gorev.gor_bitis_date);         
          _s.Cmd.Parameters.AddWithValue("@tip", gorev.gor_tipi);
          _s.Cmd.Parameters.AddWithValue("@aktif", gorev.gor_aktif.getbool());
          _s.Cmd.Parameters.AddWithValue("@not", gorev.gor_not);

          _s.Cmd.ExecuteNonQuery();
      }
      public DataTable CariGridGetir(string kod)
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_CariGridGoster @kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
      }
      public DataTable CariYetkilileriGridGetir(string kod)
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_CariYetkilileriGridGoster @kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
      }
      public DataTable GorevlerGridGetir(string kod,bool falsemi)
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_GorevlerGridGoster @kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
      }
      public DataTable GorevBilgileriGetir (string kod)
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_GorevBilgileriGetir @kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
      }
      public string maildon(string kod)
      {
          _s.Cmd.CommandText = @"select fn_MailDon(@kod)";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          return _s.Cmd.ExecuteScalar().ToString();
      }
      public void MailGonder(string gonderen, string gidecek,string cc, string gidecek_bcc, string gonderilceklerpath, string konu, string icerik, string gonderenmailbilgisi, string gonderensifre, string gonderenmailsunucu, int gonderenportu, bool sslmi, bool tekthread)
      {
          MailMessage email = new MailMessage();
          email.From = new MailAddress(gonderen);
          string[] toadd = gidecek.Split(';');
          foreach (var item in toadd)
          {
              if (item == "")
              {
                  continue;
              }
              email.To.Add(item);
          }
          string[] ccadd = cc.Split(';');
          foreach (var item in ccadd)
          {
              email.CC.Add(item);
          }
          string[] bccadd = gidecek_bcc.Split(';');
          foreach (var item in ccadd)
          {
              email.Bcc.Add(item);
          }
          string[] atachadd = gonderilceklerpath.Split(';');
          foreach (var item in atachadd)
          {
              email.Attachments.Add(new Attachment(item));
          }
          email.Subject = konu;
          email.Body = icerik;
          SmtpClient smtp = new SmtpClient();
          smtp.Credentials = new System.Net.NetworkCredential(gonderenmailbilgisi, gonderensifre);
          smtp.Port = gonderenportu;
          smtp.Host = gonderenmailsunucu;
          smtp.EnableSsl = sslmi;
          try
          {
              if (tekthread == true)
              {
                  smtp.SendAsync(email, (object)email);
              }
              else
              {
                  smtp.Send(email);
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message.getString());
          }
      }
      public string MailMetniOluştur(string carikod,string personelkod)
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_MailleriGoster @kod,@kod1";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", carikod);
          _s.Cmd.Parameters.AddWithValue("@kod1", personelkod);
          _s.Da.Fill(dt);
          string mailler = "(";
          for (int i = 0; i < dt.Rows.Count; i++)
          {
              mailler = mailler + dt.Columns[i] + ";";
          }
          mailler=mailler+")";
          mailler = mailler.Replace("(;", "(");
          mailler = mailler.Replace(";)", ")");
          if (mailler=="()")
          {
              mailler = "";
          }
          return mailler;
      }
      public DataTable DurumlarComboGetir()
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_DurumlariComboGetir";
          _s.Cmd.Parameters.Clear();
          _s.Da.Fill(dt);
          return dt;
          
      }
      public DataTable MailBilgileriGetir()
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_MailBilgileri";
          _s.Cmd.Parameters.Clear();
          _s.Da.Fill(dt);
          return dt;
      }
      public DataTable UlkeGridGetir(string kod)
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_UlkeGridGoster @kod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
      }
      public DataTable İlGridGetir(string kod,string ulkekod)
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_İlGridGoster @kod,@ulkekod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@ulkekod", ulkekod);
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
      }
      public DataTable İlceGridGetir(string kod,string ilkod)
      {
          dt.Clear();
          _s.Cmd.CommandText = @"exec sp_İlceGridGoster @kod,@ilkod";
          _s.Cmd.Parameters.Clear();
          _s.Cmd.Parameters.AddWithValue("@ilkod", ilkod);
          _s.Cmd.Parameters.AddWithValue("@kod", kod);
          _s.Da.Fill(dt);
          return dt;
           
      }
     


   
    }
}
