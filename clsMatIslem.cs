using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butak
{
    class clsMatIslem
    {

        double satfiyat = 0;
        double malfiyat = 0;
        double kazanc;
        double toplamkazanc;

        public double kazanchesaplama(string satisFiyati, string maliyetFiyati)
        {
            satfiyat = double.Parse(satisFiyati);
            malfiyat = double.Parse(maliyetFiyati);

            kazanc = satfiyat - malfiyat;

            return kazanc;
        }

        public double topKazanc(string adet)
        {
            toplamkazanc = kazanc * double.Parse(adet);

            return toplamkazanc;
        }

    }
}

