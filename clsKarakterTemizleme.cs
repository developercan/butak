using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butak
{
    class clsKarakterTemizleme
    {
        string kirliVeri = "";
        string temizVeri = "";

        public string KirliVeri
        {
            set
            {
                kirliVeri = value;
            }
        }
        public string TemizVeri
        {
            get
            {
                return temizVeri;
            }
        }

        string kirliKarakterler = @"+-_|*\/.:,;@ ";

        public void karakterTemizle()
         {
            for (int i = 0; i < kirliVeri.Length; i++)
            {
                string karakter = kirliVeri.Substring(i,1);

                if (kirliKarakterler.Contains(karakter) == false) temizVeri = temizVeri + karakter;
            }
        }
    }
}

