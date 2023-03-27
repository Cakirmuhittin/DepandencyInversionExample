using Standarts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MGMServis: IHavaServis
    {
        public double Sicaklik(string sehir)
        {
            Random rnd = new Random();
            sehir= sehir.ToLower();
            if (sehir == "ankara") return 13.1;
            else if (sehir == "bursa") return 17.4;
            else if (sehir == "istanbul") return 15.5;
            else return rnd.Next(3, 20);
        }

        public double SicaklikGetir(string lokasyon)
        {
            return Sicaklik(lokasyon);
        }
    }
}
