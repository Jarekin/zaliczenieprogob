using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    class Parking
    {
        public Parking()
        {

        }
        public Parking(int miejsca, bool czyPietrowy, int metrazX, int metrazY, List<Auta> autaParking, string kierowca)
        {
            Miejsca = miejsca;
            CzyPietrowy = czyPietrowy;
            MetrazX = metrazX;
            MetrazY = metrazY;
            Auta = autaParking;
            Kierowca = kierowca;
        }
        public int Miejsca
        { get; set; }
        public bool CzyPietrowy
        { get; set; }
        public int MetrazX
        { get; set; }
        public int MetrazY
        { get; set; }
        public List<Auta> Auta { get; set; }
        public string Kierowca { get; set; } 

    }

}
