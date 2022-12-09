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
    class clsSelect
    {
        public SqlConnection conn;
        SqlCommand comm;
        public SqlDataAdapter ad;
        public SqlDataReader dr;
        public DataTable dt;


        string ID;
        int stok;
        string grupAd;
        string toplamFiyat;
        string satisfiyat;
        string depoAdı;
        string yil;
        string ay;
        DateTime tarih;
        string ilktarih;
        string sonTarih;
        string arama;
        string temizArama;
        string toplamSatisFiyat;
        string toplamSatilanFiyat;
        string topKDV;
        string topKar;
        string topAdet;

        public string[] aranan;

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
        public int Stok
        {
            get
            {
                return stok;
            }

            set
            {
                stok = value;
            }
        }
        public string ToplamFiyat
        {
            get
            {
                return toplamFiyat;
            }

            set
            {
                toplamFiyat = value;
            }
        }
        public string Satisfiyat
        {
            get
            {
                return satisfiyat;
            }

            set
            {
                satisfiyat = value;
            }
        }
        public string DepoAdı
        {
            get
            {
                return depoAdı;
            }

            set
            {
                depoAdı = value;
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
        public string Ay
        {
            get
            {
                return ay;
            }

            set
            {
                ay = value;
            }
        }
        public DateTime Tarih
        {
            get
            {
                return tarih;
            }

            set
            {
                tarih = value;
            }
        }
        public string Ilktarih
        {
            get
            {
                return ilktarih;
            }

            set
            {
                ilktarih = value;
            }
        }
        public string SonTarih
        {
            get
            {
                return sonTarih;
            }

            set
            {
                sonTarih = value;
            }
        }
        public string Arama
        {
            get
            {
                return arama;
            }

            set
            {
                arama = value;
            }
        }
        public string TemizArama
        {
            get
            {
                return temizArama;
            }

            set
            {
                temizArama = value;
            }
        }
        public string ToplamSatisFiyat
        {
            get
            {
                return toplamSatisFiyat;
            }

            set
            {
                toplamSatisFiyat = value;
            }
        }
        public string ToplamSatilanFiyat
        {
            get
            {
                return toplamSatilanFiyat;
            }

            set
            {
                toplamSatilanFiyat = value;
            }
        }
        public string TopKDV
        {
            get
            {
                return topKDV;
            }

            set
            {
                topKDV = value;
            }
        }
        public string TopKar
        {
            get
            {
                return topKar;
            }

            set
            {
                topKar = value;
            }
        }
        public string TopAdet
        {
            get
            {
                return topAdet;
            }

            set
            {
                topAdet = value;
            }
        }

        public clsSelect()
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

        public void ParcaArama()
        {
            dt = new DataTable();

            comm = new SqlCommand("ParcaArama", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.Add("@temizArama", SqlDbType.NVarChar, 50).SqlValue = "%" + TemizArama + "%";
            comm.Parameters.Add("@arama", SqlDbType.NVarChar, 50).SqlValue = "%" + Arama + "%";

            ad = new SqlDataAdapter();
            ad.SelectCommand = comm;
            ad.Fill(dt);

            conn.Close();
        }

        public void parcaAramaGelismis()
        {
            dt = new DataTable();

            string tsql = "Select Parcalar.ID,parcaNo as 'Parça No',oemNo as 'OEM No',parcaAd as 'Parça Ad',model as ";
            tsql += "'Model',yil as 'Yıl',tedarikci as 'Tedarikçi',satisFiyat as 'Satış Fiyatı' ";
            tsql += "from Parcalar JOIN ParcalarDetay on Parcalar.ID = ParcalarDetay.ParcaID ";
            tsql += "JOIN Lokasyon on Parcalar.ID = Lokasyon.parcaID where ";
            string tsqlwhere = "parcaNo + ' ' + markaNo + ' ' + oemNo + ' ' + parcaAd + ' ' + model + ' ' + marka + ' '+tedarikci + ' ' + yil + ' ' + depoAd LIKE ";

            for (int i = 0; i < aranan.Length; i++)
            {
                tsql += tsqlwhere + "'%" + aranan[i] + "%'" + " and ";
            }

            tsql = tsql.Substring(0, tsql.Length - 5);

            comm = new SqlCommand(tsql, conn);

            ad = new SqlDataAdapter(comm);
            ad.Fill(dt);

            conn.Close();
        }

        public void satilanParcaArama()
        {
            dt = new DataTable();

            comm = new SqlCommand("SatilanParcaArama", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@parcaNo", SqlDbType.NVarChar, 50).SqlValue = "%" + TemizArama + "%";
            comm.Parameters.Add("@veri", SqlDbType.NVarChar, 50).SqlValue = "%" + Arama + "%";

            ad = new SqlDataAdapter(comm);
            ad.Fill(dt);

            conn.Close();
        }

        public void satilanParcaDetay()
        {

            comm = new SqlCommand("SatilanParcaDetay", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = ID1;
            dr = comm.ExecuteReader();
        }

        public void ıdParcaCekme()
        {
            comm = new SqlCommand("IDParcaCekme", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = ID1;

            dr = comm.ExecuteReader();
            dr.Read();
        }

        public void sepetVeri()
        {
            comm = new SqlCommand("SepetVeri", conn);
            comm.CommandType = CommandType.StoredProcedure;
            dr = comm.ExecuteReader();
        }

        public void tumParcalar()
        {
            dt = new DataTable();

            ad = new SqlDataAdapter("TumParcalar", conn);
            ad.Fill(dt);

            conn.Close();
        }

        public void stokSorgulama()
        {
            comm = new SqlCommand("StokSorgulama", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.Add("@parcaID", SqlDbType.Int).SqlValue = ID1;
            Stok = int.Parse(comm.ExecuteScalar().ToString());

            conn.Close();
        }

        public void sepetToplam()
        {
            comm = new SqlCommand("SepetToplam", conn);
            comm.CommandType = CommandType.StoredProcedure;
            ToplamFiyat = comm.ExecuteScalar().ToString();
        }

        public void kritikParcalar()
        {
            dt = new DataTable();

            ad = new SqlDataAdapter("KritikParcalar", conn);
            ad.Fill(dt);

            conn.Close();
        }

        public void satisFiyat()
        {
            comm = new SqlCommand("SatisFiyat", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.Add("@ParcaID", SqlDbType.Int).SqlValue = ID1;
            Satisfiyat = comm.ExecuteScalar().ToString();

        }

        public void rprSatis()
        {
            dt = new DataTable();

            ad = new SqlDataAdapter("RaporSatis", conn);
            ad.Fill(dt);

            conn.Close();
        }

        public void satisAyYil()
        {
            dt = new DataTable();

            comm = new SqlCommand("SatisAyYil", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.Add("@yil", SqlDbType.NVarChar, 50).SqlValue = Yil;

            ad = new SqlDataAdapter(comm);
            ad.Fill(dt);

            conn.Close();
        }

        public void satisYillar()
        {
            dt = new DataTable();

            ad = new SqlDataAdapter("SatisYillar", conn);
            ad.Fill(dt);

            conn.Close();
        }

        public void rprGunlukSatis()
        {
            dt = new DataTable();

            comm = new SqlCommand("RaporGunlukSatis", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@tarih", SqlDbType.Date).SqlValue = Tarih;

            ad = new SqlDataAdapter(comm);

            ad.Fill(dt);

            conn.Close();
        }

        public void rprAylikSatis()
        {
            dt = new DataTable();

            comm = new SqlCommand("RaporAylikSatis", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ay", SqlDbType.NVarChar, 50).SqlValue = Ay;
            comm.Parameters.Add("@yil", SqlDbType.NVarChar, 50).SqlValue = Yil;

            ad = new SqlDataAdapter(comm);

            ad.Fill(dt);

            conn.Close();
        }



        public void rprYillikSatis()
        {
            dt = new DataTable();

            comm = new SqlCommand("RaporYillikSatis", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@yil", SqlDbType.NVarChar).SqlValue = Yil;

            ad = new SqlDataAdapter(comm);

            ad.Fill(dt);

            conn.Close();
        }

        public void rprBetweenSatis()
        {

            dt = new DataTable();

            comm = new SqlCommand("RaporBetweenSatis", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ilkTarih", SqlDbType.Date).SqlValue = Ilktarih;
            comm.Parameters.Add("@sonTarih", SqlDbType.Date).SqlValue = SonTarih;

            ad = new SqlDataAdapter();
            ad.SelectCommand = comm;

            ad.Fill(dt);

            conn.Close();
        }

        public void rprGunToplamlari()
        {
            comm = new SqlCommand("RaporGunToplamlari", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@tarih", SqlDbType.Date).SqlValue = Tarih;
            dr = comm.ExecuteReader();
        }

        public void rprAyToplamlari()
        {
            comm = new SqlCommand("RaporAyToplamlari", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ay", SqlDbType.NVarChar).SqlValue = Ay;
            comm.Parameters.Add("@yil", SqlDbType.NVarChar).SqlValue = Yil;
            dr = comm.ExecuteReader();
        }

        public void rprYilToplamlari()
        {
            comm = new SqlCommand("RaporYilToplamlari", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@yil", SqlDbType.NVarChar, 4).SqlValue = Yil;
            dr = comm.ExecuteReader();
        }

        public void rprBetweenToplamlari()
        {
            comm = new SqlCommand("RaporBetweenToplamlari", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ilkTarih", SqlDbType.Date).SqlValue = Ilktarih;
            comm.Parameters.Add("@sonTarih", SqlDbType.Date).SqlValue = SonTarih;
            dr = comm.ExecuteReader();
        }

        public void ayGunlerCiro()
        {
            dt = new DataTable();

            ad = new SqlDataAdapter("AygunlerCiro", conn);
            ad.Fill(dt);

            conn.Close();
        }

        public void satisFiyatCiroGun()
        {
            dt = new DataTable();

            comm = new SqlCommand("SatisFiyatCiroGun", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@tarih", SqlDbType.Date).SqlValue = Tarih;

            ad = new SqlDataAdapter(comm);
            ad.Fill(dt);

            conn.Close();
        }

        public void satilanFiyatCiroGun()
        {
            dt = new DataTable();

            comm = new SqlCommand("SatilanFiyatCiroGun", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@tarih", SqlDbType.Date).SqlValue = Tarih;

            ad = new SqlDataAdapter(comm);
            ad.Fill(dt);

            conn.Close();
        }

        public void ciroGunIstatistik()
        {
            comm = new SqlCommand("CirogunIstatistik", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@tarih", SqlDbType.Date).SqlValue = Tarih;
            dr = comm.ExecuteReader();
        }

        public void satisFiyatCiroAy()
        {
            dt = new DataTable();

            comm = new SqlCommand("SatisFiyatCiroAy", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@yil", SqlDbType.NVarChar, 50).SqlValue = Yil;
            comm.Parameters.Add("@ay", SqlDbType.NVarChar, 50).SqlValue = Ay;

            ad = new SqlDataAdapter(comm);
            ad.Fill(dt);

            conn.Close();
        }

        public void satilanFiyatCiroAy()
        {
            dt = new DataTable();

            comm = new SqlCommand("SatilanFiyatCiroAy", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@yil", SqlDbType.NVarChar, 50).SqlValue = Yil;
            comm.Parameters.Add("@ay", SqlDbType.NVarChar, 50).SqlValue = Ay;

            ad = new SqlDataAdapter(comm);
            ad.Fill(dt);

            conn.Close();
        }

        public void ciroAyIstatistik()
        {
            comm = new SqlCommand("CiroAyIstatistik", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@yil", SqlDbType.NVarChar, 50).SqlValue = Yil;
            comm.Parameters.Add("@ay", SqlDbType.NVarChar, 50).SqlValue = Ay;
            dr = comm.ExecuteReader();
        }

        public void gruplar()
        {
            dt = new DataTable();
            ad = new SqlDataAdapter("GrupAdları", conn);
            ad.Fill(dt);

            conn.Close();
        }

        public void grupAdı()
        {
            comm = new SqlCommand("GrupAdi", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = ID1;
            GrupAd = comm.ExecuteScalar().ToString();


            conn.Close();
        }

        public void grupGoruntuleme()
        {
            dt = new DataTable();

            comm = new SqlCommand("GrupGoruntuleme", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = frmRehber.GrupID;

            ad = new SqlDataAdapter(comm);
            ad.Fill(dt);

            conn.Close();
        }

        public void grupKisiler()
        {
            dt = new DataTable();

            comm = new SqlCommand("GrupKisiler", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = ID1;

            ad = new SqlDataAdapter(comm);
            ad.Fill(dt);

            conn.Close();
        }

        public void kisiArama()
        {
            comm = new SqlCommand("KisiArama", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@arama", SqlDbType.NVarChar, 50).SqlValue = Arama;

            dt = new DataTable();
            ad = new SqlDataAdapter(comm);
            ad.Fill(dt);

            conn.Close();
        }

        public void kisiBilgileri()
        {
            comm = new SqlCommand("KisiBilgileri", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = frmRehber.KisiID;
            dr = comm.ExecuteReader();
        }

        public void disAktarmaVeri()
        {
            dt = new DataTable();

            ad = new SqlDataAdapter("DisAktarmaVeri", conn);
            ad.Fill(dt);

            conn.Close();
        }
    }
}