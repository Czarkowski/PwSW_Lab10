﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Odcinek : FiguraPlaska
    {
        public Punkt A { get; set; }
        public Punkt B { get; set; }

        public Odcinek(Punkt poczatek, Punkt koniec, string nazwa)
            :base(nazwa)
        {
            A = poczatek;
            B = koniec;
        }
        public override string Opis()
        {
            return string.Format("Punkt \"{0} o początku {1} i końcu {2}",
                Nazwa, A, B);
        }
    }
}
