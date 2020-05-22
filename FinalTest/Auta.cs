using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    class Auta
    {
        public Auta()
        {

        }
        public Auta(KolorY kolor, string marka, int predkosc, int przebieg)
        {
            Marka = marka;
            Kolor = kolor;
            Predkosc = predkosc;
            Przebieg = przebieg;
        }
        public KolorY Kolor { get; set; }
        public string Marka { get; set; }
        public int Predkosc { get; set; }
        public int Przebieg { get; set; }

    }
    enum KolorY
    {
        Żółty,
        Czarny,
        Czerwony,
        Różowy,
    }
}
