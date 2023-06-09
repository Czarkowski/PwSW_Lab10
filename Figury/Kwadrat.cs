﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Kwadrat : Wielobok
    {
        private double dlugoscBoku;

        public Kwadrat(double dlugoscBoku, Punkt punkt, string nazwa)
            : base(nazwa, 1)
        {
            DlugoscBoku = dlugoscBoku;
            this[0] = punkt;
        }

        public override Punkt this[int ktoryWierzcholek]
        {
            get
            {
                if (ktoryWierzcholek < 0 || ktoryWierzcholek > 3)
                {
                    throw new IndexOutOfRangeException("Zły indeks wierzchołka");
                }
                switch (ktoryWierzcholek)
                {
                    case 1:
                        return new Punkt()
                        {
                            X = punkty[0].X + dlugoscBoku,
                            Y = punkty[0].Y
                        };
                    case 2:
                        return new Punkt()
                        {
                            X = punkty[0].X + dlugoscBoku,
                            Y = punkty[0].Y + dlugoscBoku
                        };
                    case 3:
                        return new Punkt()
                        {
                            X = punkty[0].X,
                            Y = punkty[0].Y + dlugoscBoku
                        };

                }
                return punkty[0];
            }
            set
            {
                if (ktoryWierzcholek !=0)
                {
                    throw new ApplicationException("Dla kwadratu możesz ustawić tylko początkowy wierzchołek");
                }
                punkty[0] = value;
            }

        }



        public double DlugoscBoku
        {
            get => dlugoscBoku;
            set
            {
                if (value < 0)
                {
                    throw new ApplicationException("Długość boku nie może mieć wartości ujemniej");
                }
                dlugoscBoku = value;
            }
        }

        public sealed override int LiczbaWierzcholkow
        {
            get => 4;
        }

        public sealed override double ObliczObwod()
        {
            return dlugoscBoku * 4;
        }

        public sealed override double ObliczPole()
        {
            return dlugoscBoku * dlugoscBoku;
        }

        public override string Opis()
        {
            return string.Format("Kwadrat \"{0}\" o wierzchołkach w punktach: A={1}, B={2}, C={3}, D={4}",
                Nazwa, this[0], this[1], this[2], this[3]);
        }

        public sealed override double WyznaczDlugoscBoku(int ktoryBok)
        {
            if (ktoryBok < 0 || ktoryBok >3)
            {
                throw new IndexOutOfRangeException("Zły indeks boku");
            }
            return dlugoscBoku;
        }
    }
}
