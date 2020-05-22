using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class Form1 : Form
    {
        List<Parking> listaParking = new List<Parking>();
        public Form1()
        {
            InitializeComponent();
            zaladujAuta();
        }

        private void zaladujAuta()
        {
            Kierowca Jarek = new Kierowca("Jarek", 22, 185);
            Kierowca Azis = new Kierowca("Azis", 42, 187);
            Auta Bugatti = new Auta(KolorY.Różowy, "Veyron", 220, 42069);
            Auta Honda = new Auta(KolorY.Żółty, "Civic", 160, 1337);
            Parking Chumash = new Parking(69, false, 42, 77, new List<Auta>() { Honda, Bugatti }, "Jarek");
            Parking Tsq = new Parking(777, true, 333, 222, new List<Auta>() { Bugatti }, "Azis");
            listaParking.Add(Chumash);
            listaParking.Add(Tsq);
        }

        private void zaladujParkingi()
        {
            parkingBindingSource.DataSource = listaParking.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            zaladujParkingi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var temp = parkingBindingSource.Current;
            listaParking.Remove((Parking)temp);
            zaladujParkingi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var temp = parkingBindingSource.Current;
            listaParking.Add((Parking)temp);
            zaladujParkingi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listaParking.Clear();
            foreach(var temp in parkingBindingSource)
            {
                listaParking.Add((Parking)temp);
            }
            zaladujParkingi();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
