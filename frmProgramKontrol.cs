using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace butak
{
    public partial class frmProgramKontrol : DevExpress.XtraEditors.XtraForm
    {
        public frmProgramKontrol()
        {
            InitializeComponent();
        }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        private void frmProgramKontrol_Load(object sender, EventArgs e)
        {

            if (IsConnectedToInternet())
            {
                lblInternet.Text = "Başarılı";
                lblInternet.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblInternet.Text = "Başarısız";
                lblInternet.ForeColor = Color.Red;
            }

            try
            {
                SqlConnection conn;

                string connstring = "Server=tcp:stakoto.database.windows.net,1433;Initial Catalog=butak;";
                connstring += "Persist Security Info=False;User ID=sipahi@stakoto.database.windows.net;";
                connstring += "Password=3edc_4rfv;MultipleActiveResultSets=False;Encrypt=True;";
                connstring += "TrustServerCertificate=False;Connection Timeout=30;";

                conn = new SqlConnection(connstring);
                conn.Open();

                lblVeriTabani.Text = "Başarılı";
                lblVeriTabani.ForeColor = Color.LimeGreen;
            }
            catch (Exception)
            {
                lblVeriTabani.Text = "Başarısız";
                lblVeriTabani.ForeColor = Color.Red;
            }



        }
    }
}