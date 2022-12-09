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
    class clsDelete
    {
        SqlCommand comm;
        SqlConnection conn;

        string ID;
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

        public clsDelete()
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

        public void parcaSilme()
        {  
            try
            {
                comm = new SqlCommand("ParcaSilme", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = ID1;
                comm.ExecuteNonQuery();

                XtraMessageBox.Show("Parça Silme İşlemi Başarılı");
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.ToString()); }

            conn.Close();
        }

        public void sepetParcaSilme()
        {
            comm = new SqlCommand("SepetParcaSilme", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = ID1;
            comm.ExecuteNonQuery();

            conn.Close();
        }

        public void sepetBosaltma()
        {
            comm = new SqlCommand("SepetBosaltma", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.ExecuteNonQuery();

            conn.Close();
        }

        public void grupSilme()
        {
            comm = new SqlCommand("GrupSilme", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = ID1;
            comm.ExecuteNonQuery();
        }

        public void kisiSilme()
        {
            comm = new SqlCommand("KisiSilme", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@ID", SqlDbType.Int).SqlValue = ID1;
            comm.ExecuteNonQuery();
        }
    }
}
