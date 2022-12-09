using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data;

namespace butak
{

    class clsInsert
    {
        public SqlConnection conn;
        SqlCommand comm;

        string ID;

        string parcaNo;
        string markaNo;
        string oemNo;
        string parcaAd;
        string model;
        string yil;
        string tedarikci;

        string aciklama;
        string eklenmeTarih;
        string marka;
        string maliyet;
        string satisFiyat;

        string kadet;
        string rafNo;
        string adet;

        string musteriID;
        string musteriAd;
        string seriASıraNo;
        string musteriVD;
        string vergiNo;
        string duTarih;
        string duSaat;
        string sevkTarih;

        string ciroID;

        string depoAd;

        string ad;
        string soyad;
        string telNo;
        string email;
        string grupID;

        string grupAd;

        public string ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }
        public string MusteriID
        {
            get
            {
                return musteriID;
            }

            set
            {
                musteriID = value;
            }
        }
        public string ParcaNo
        {
            get
            {
                return parcaNo;
            }

            set
            {
                parcaNo = value;
            }
        }
        public string OemNo
        {
            get
            {
                return oemNo;
            }

            set
            {
                oemNo = value;
            }
        }
        public string Aciklama
        {
            get
            {
                return aciklama;
            }

            set
            {
                aciklama = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }
        public string Yil
        {
            get
            {
                return yil;
            }

            set
            {
                yil = value;
            }
        }
        public string Adet
        {
            get
            {
                return adet;
            }

            set
            {
                adet = value;
            }
        }
        public string RafNo
        {
            get
            {
                return rafNo;
            }

            set
            {
                rafNo = value;
            }
        }
        public string Marka
        {
            get
            {
                return marka;
            }

            set
            {
                marka = value;
            }
        }
        public string Maliyet
        {
            get
            {
                return maliyet;
            }

            set
            {
                maliyet = value;
            }
        }
        public string SatisFiyat
        {
            get
            {
                return satisFiyat;
            }

            set
            {
                satisFiyat = value;
            }
        }
        public string Tedarikci
        {
            get
            {
                return tedarikci;
            }

            set
            {
                tedarikci = value;
            }
        }
        public string ParcaAd
        {
            get
            {
                return parcaAd;
            }

            set
            {
                parcaAd = value;
            }
        }
        public string Kadet
        {
            get
            {
                return kadet;
            }

            set
            {
                kadet = value;
            }
        }
        public string MusteriAd
        {
            get
            {
                return musteriAd;
            }

            set
            {
                musteriAd = value;
            }
        }
        public string SeriASıraNo
        {
            get
            {
                return seriASıraNo;
            }

            set
            {
                seriASıraNo = value;
            }
        }
        public string MusteriVD
        {
            get
            {
                return musteriVD;
            }

            set
            {
                musteriVD = value;
            }
        }
        public string VergiNo
        {
            get
            {
                return vergiNo;
            }

            set
            {
                vergiNo = value;
            }
        }
        public string DuTarih
        {
            get
            {
                return duTarih;
            }

            set
            {
                duTarih = value;
            }
        }
        public string DuSaat
        {
            get
            {
                return duSaat;
            }

            set
            {
                duSaat = value;
            }
        }
        public string SevkTarih
        {
            get
            {
                return sevkTarih;
            }

            set
            {
                sevkTarih = value;
            }
        }
        public string CiroID
        {
            get
            {
                return ciroID;
            }

            set
            {
                ciroID = value;
            }
        }
        public string DepoAd
        {
            get
            {
                return depoAd;
            }

            set
            {
                depoAd = value;
            }
        }
        public string EklenmeTarih
        {
            get
            {
                return eklenmeTarih;
            }

            set
            {
                eklenmeTarih = value;
            }
        }
        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }
        public string TelNo
        {
            get
            {
                return telNo;
            }

            set
            {
                telNo = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string GrupAd
        {
            get
            {
                return grupAd;
            }

            set
            {
                grupAd = value;
            }
        }
        public string GrupID
        {
            get
            {
                return grupID;
            }

            set
            {
                grupID = value;
            }
        }
        public string MarkaNo
        {
            get
            {
                return markaNo;
            }

            set
            {
                markaNo = value;
            }
        }

        public clsInsert()
        {
            string connstring = "Server=tcp:butakoto.database.windows.net,1433;Initial Catalog=butak;";
            connstring += "Persist Security Info=False;User ID=sipahi@butakoto.database.windows.net;";
            connstring += "Password=KOplE+-091WEr;MultipleActiveResultSets=False;Encrypt=True;";
            connstring += "TrustServerCertificate=False;Connection Timeout=30;";

            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.ToString()); }
        }

        public void parcaEkle()
        {
            comm = new SqlCommand("ParcaEkleme", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@parcaNo", SqlDbType.NVarChar).SqlValue = ParcaNo;
            comm.Parameters.Add("@markaNo", SqlDbType.NVarChar, 50).SqlValue = MarkaNo;
            comm.Parameters.Add("@oemNo", SqlDbType.NVarChar).SqlValue = OemNo;
            comm.Parameters.Add("@parcaAd", SqlDbType.NVarChar).SqlValue = ParcaAd;
            comm.Parameters.Add("@model", SqlDbType.NVarChar).SqlValue = Model;
            comm.Parameters.Add("@yil", SqlDbType.NVarChar).SqlValue = Yil;
            comm.Parameters.Add("@tedarikci", SqlDbType.NVarChar).SqlValue = Tedarikci;
            comm.Parameters.Add("@marka", SqlDbType.NVarChar).SqlValue = Marka;
            comm.Parameters.Add("@maliyet", SqlDbType.Decimal).SqlValue = Maliyet;
            comm.Parameters.Add("@satisFiyat", SqlDbType.Decimal).SqlValue = SatisFiyat;
            comm.Parameters.Add("@aciklama", SqlDbType.NVarChar).SqlValue = Aciklama;
            comm.Parameters.Add("@eklenmeTarih", SqlDbType.Date).SqlValue = EklenmeTarih;
            comm.Parameters.Add("@depoAd", SqlDbType.NVarChar, 50).SqlValue = depoAd;
            comm.Parameters.Add("@rafNo", SqlDbType.NVarChar).SqlValue = RafNo;
            comm.Parameters.Add("@adet", SqlDbType.Int).SqlValue = Adet;
            comm.Parameters.Add("@kadet", SqlDbType.Int).SqlValue = Kadet;
            comm.ExecuteNonQuery();
        }

        public void sepeteUrunEkle()
        {
            comm = new SqlCommand("SepeteUrunEkle", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ParcaID", SqlDbType.Int).SqlValue = ID1;
            comm.Parameters.Add("@adet", SqlDbType.Int).SqlValue = Adet;
            comm.Parameters.Add("@fiyat", SqlDbType.Decimal).SqlValue = SatisFiyat;
            comm.ExecuteNonQuery();

            conn.Close();

            XtraMessageBox.Show("Parça Başarılı Bir Şekilde Sepete Eklendi");
        }

        public void urunSatis()
        {
            comm = new SqlCommand("UrunSatis", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@musteriAd", SqlDbType.NVarChar, 50).SqlValue = MusteriAd;
            comm.Parameters.Add("@seriASıraNo", SqlDbType.NVarChar, 50).SqlValue = SeriASıraNo;
            comm.Parameters.Add("@musteriVD", SqlDbType.NVarChar, 50).SqlValue = MusteriVD;
            comm.Parameters.Add("@vergiNo", SqlDbType.NVarChar, 50).SqlValue = VergiNo;
            comm.Parameters.Add("@duTarih", SqlDbType.NVarChar, 50).SqlValue = DuTarih;
            comm.Parameters.Add("@duSaat", SqlDbType.NVarChar, 50).SqlValue = DuSaat;
            comm.Parameters.Add("@sevkTarih", SqlDbType.NVarChar, 50).SqlValue = sevkTarih;
            comm.ExecuteNonQuery();

            conn.Close();
        }

        public void grupEkle()
        {
            comm = new SqlCommand("GrupEkle", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@grupAd", SqlDbType.NVarChar).SqlValue = GrupAd;
            comm.ExecuteNonQuery();

            XtraMessageBox.Show("Grup Ekleme Başarılı");
        }

        public void kisiEkle()
        {
            comm = new SqlCommand("KisiEkle", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("grupID", SqlDbType.Int).SqlValue = GrupID;
            comm.Parameters.Add("ad", SqlDbType.NVarChar).SqlValue = Ad;
            comm.Parameters.Add("soyad", SqlDbType.NVarChar).SqlValue = Soyad;
            comm.Parameters.Add("tel", SqlDbType.NVarChar).SqlValue = TelNo;
            comm.Parameters.Add("eposta", SqlDbType.NVarChar).SqlValue = Email;
            comm.ExecuteNonQuery();

            XtraMessageBox.Show("Kişi Ekleme Başarılı");
        }
    }
}
