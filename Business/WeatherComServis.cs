using Standarts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class WeatherComServis:IHavaServis
    {
        public double Sicaklik(string yer)
        {
            switch(yer.ToLower()) 
            {
                case "ankara":
                    return 12;
                case "bursa":
                    return 15;
                case "istanbul":
                    return 16;
                default:
                    return new Random().Next(30);
            }
        }

        public double SicaklikGetir(string lokasyon)
        {
            return Sicaklik(lokasyon);
        }
    }
}
