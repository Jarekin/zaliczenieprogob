using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    class Kierowca
    {
        public Kierowca()
        {

        }
        public Kierowca(string imie, int wiek, int wzrost)
        {
            Imie = imie;
            Wiek = wiek;
            Wzrost = wzrost;

        }
        public string Imie { get; set; }
        public int Wiek { get; set; }
        public int Wzrost { get; set; }

    }
}
