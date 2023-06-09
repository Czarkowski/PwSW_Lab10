﻿using System;
using Figury;

namespace TestFigur
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt[] dlaTrojkata =
            {
                new Punkt{X=1,Y=1 },
                new Punkt{X=3,Y=3 },
                new Punkt{X=6,Y=1 }
            };

            FiguraPlaska[] figury =
            {
                new Odcinek(
                    new Punkt{X=12,Y=3 },
                    new Punkt{X=1,Y=23 },
                    "Figura1"),
                new Kolo(
                    new Punkt{X=3,Y=4 },
                    12,
                    "Figura 2"),
                new Trojkat("Figura 3",dlaTrojkata),
                new Kwadrat(
                    3,
                    new Punkt{X=6,Y=6 },
                    "Figura 4")
            };
            Console.WriteLine("Mamy do dyspozycji następujące figury: ");
            foreach (FiguraPlaska f in figury)
            {
                Console.WriteLine(f.Opis());
                if (f is IPole)
                {
                    Console.WriteLine($"Pole figury wynosi {((IPole)f).ObliczPole()}");
                }
                if (f is IObwod obwod)
                {
                    Console.WriteLine($"Obwód figury wynosi {obwod.ObliczObwod()}");
                }
                Wielobok w = f as Wielobok;
                if (w != null)
                {
                    Console.WriteLine("Figura posiada następujące wierzchołki: ");
                    for (int i = 0; i < w.LiczbaWierzcholkow; i++)
                    {
                        Console.WriteLine(" - {0}", w[i]);
                    }
                    Console.WriteLine("Figura posiada następujące długości boków: ");
                    for (int i = 0; i < w.LiczbaWierzcholkow; i++)
                    {
                        Console.WriteLine(" - {0}", w.WyznaczDlugoscBoku(i));
                    }
                }
                Console.WriteLine("--------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
