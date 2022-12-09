using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace butak
{
    class clsExcelSelect
    {
        public OleDbConnection conn;
        OleDbCommand comm;
        OleDbDataAdapter ad;
        public OleDbDataReader dr;

        public DataTable dt;

        public static string excelYol;

        string secilenSayfa;
        string tsql;

        public string SecilenSayfa
        {
            get
            {
                return secilenSayfa;
            }

            set
            {
                secilenSayfa = value;
            }
        }
        public string Tsql
        {
            get
            {
                return tsql;
            }

            set
            {
                tsql = value;
            }
        }

        public clsExcelSelect()
        {
            conn = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + excelYol + "';Extended Properties='Excel 12.0;IMEX=1'");
            conn.Open();
        }


        public void Kolonlar()
        {
            dt = new DataTable();
            ad = new OleDbDataAdapter("Select * from [" + secilenSayfa + "$]", conn);
            ad.Fill(dt);

            conn.Close();
        }

        public void SecilenKolonVeri()
        {
            dt = new DataTable();

            comm = new OleDbCommand(Tsql, conn);
            dr = comm.ExecuteReader();

        }
    }
}
