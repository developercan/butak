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
    class clsUpdate
    {
        SqlConnection conn;
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

        string rafNo;
        string adet;
        string kadet;
        string depoAd;

        string ad;
        string soyad;
        string tel;
        string eposta;

        string grupID;
        string akGrupID;
        string grupAd;

        string fiyat;


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
        public string AkGrupID
        {
            get
            {
                return akGrupID;
            }

            set
            {
                akGrupID = value;
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
        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }
        public string Eposta
        {
            get
            {
                return eposta;
            }

            set
            {
                eposta = value;
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
        public string Fiyat
        {
            get
            {
                return fiyat;
            }

            set
            {
                fiyat = value;
            }
        }

        public clsUpdate()
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

        public void parcaGuncelleme()
        {
            comm = new SqlCommand("ParcaGuncelleme", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@parcaNo", SqlDbType.NVarChar,50).SqlValue = ParcaNo;
            comm.Parameters.Add("@markaNo",SqlDbType.NVarChar,50).SqlValue=MarkaNo;
            comm.Parameters.Add("@oemNo", SqlDbType.NVarChar,50).SqlValue = OemNo;
            comm.Parameters.Add("@parcaAd", SqlDbType.NVarChar,50).SqlValue = parcaAd;
            comm.Parameters.Add("@model", SqlDbType.NVarChar,50).SqlValue = Model;
            comm.Parameters.Add("@yil", SqlDbType.NVarChar,50).SqlValue = Yil;
            comm.Parameters.Add("@tedarikci", SqlDbType.NVarChar,50).SqlValue = Tedarikci;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = ID1;
            comm.Parameters.Add("@marka", SqlDbType.NVarChar,50).SqlValue = Marka;
            comm.Parameters.Add("@maliyet", SqlDbType.Decimal).SqlValue = Maliyet;
            comm.Parameters.Add("@satisFiyat", SqlDbType.Decimal).SqlValue = SatisFiyat;
            comm.Parameters.Add("@eklenmeTarih", SqlDbType.Date).SqlValue = EklenmeTarih;
            comm.Parameters.Add("@aciklama", SqlDbType.NVarChar,50).SqlValue = Aciklama;
            comm.Parameters.Add("@DepoAd", SqlDbType.NVarChar,50).SqlValue = DepoAd;
            comm.Parameters.Add("@rafNo", SqlDbType.NVarChar,50).SqlValue = RafNo;
            comm.Parameters.Add("@adet", SqlDbType.Int).SqlValue = Adet; ;
            comm.Parameters.Add("@kadet", SqlDbType.Int).SqlValue = Kadet;
            comm.Parameters.Add("@parcaID", SqlDbType.Int).SqlValue = ID1;
            comm.ExecuteNonQuery();

            conn.Close();

            XtraMessageBox.Show("Parça Başarılı Bir Şekilde Güncellendi");
        }

        public void sepetFiyatGuncelleme()
        {
            comm = new SqlCommand("SepetFiyatGuncelleme", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@fiyat", SqlDbType.Decimal).SqlValue = Fiyat;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = ID1;
            comm.ExecuteNonQuery();

            conn.Close();
        }

        public void kisiAktarma()
        {
            comm = new SqlCommand("KisiAktarma", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@grupID", SqlDbType.Int).SqlValue = AkGrupID;
            comm.Parameters.Add("@grupID2", SqlDbType.Int).SqlValue = GrupID;
            comm.ExecuteNonQuery();

        }

        public void grupGuncelle()
        {
            comm = new SqlCommand("GrupGuncelle",conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@grupAd", SqlDbType.NVarChar,50).SqlValue = GrupAd;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = GrupID;
            comm.ExecuteNonQuery();
        }

        public void kisiGrupGuncelle()
        {
            comm = new SqlCommand("KisiGrupGuncelle", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@grupID", SqlDbType.Int).SqlValue = GrupID;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = frmRehber.KisiID;
            comm.ExecuteNonQuery();
        }

        public void kisiGuncelle()
        {
            comm = new SqlCommand("KisiGuncelle", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ad", SqlDbType.NVarChar).SqlValue = Ad;
            comm.Parameters.Add("@soyad", SqlDbType.NVarChar).SqlValue = Soyad;
            comm.Parameters.Add("@tel", SqlDbType.NVarChar).SqlValue = Tel;
            comm.Parameters.Add("@eposta", SqlDbType.NVarChar).SqlValue = eposta;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = frmRehber.KisiID;
            comm.ExecuteNonQuery();
        }
    }
}
