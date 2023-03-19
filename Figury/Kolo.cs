using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Kolo : FiguraPlaska, IObwod, IPole
    {
        public Punkt Srodek { get; set; }
        private double promien;
        public double Promien
        {
            get => promien;
            set
            {
                if (value < 0)
                {
                    throw new ApplicationException("Długość promienia nie może mieć wartości ujemniej");
                }
                promien = value;
            }
        }

        public Kolo(Punkt srodek, double promien, string nazwa)
            :base(nazwa)
        {
            Srodek = srodek;
            Promien = promien;
        }

        public override string Opis()
        {
            return string.Format("Koło\"{0}\" o środku w punkcie {1} i promieniu {2}", Nazwa, Srodek, Promien);
        }

        public double ObliczObwod()
        {
            return 2 * Math.PI * promien;
        }

        public double ObliczPole()
        {
            return Math.PI * promien * promien;
        }
    }
}
