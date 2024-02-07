using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class TransakcijaUpisPodataka : Form
    {
        internal class Transakcija : IComparable
        {
            private Racun racun;
            private KorisnikF korisnik;
            private DateTime datumTransakcije;
            private double iznosTransakcije;

            public Racun Racun { get { return racun; } set { racun = value; } }
            public KorisnikF Korisnik { get { return korisnik; } set { korisnik = value; } }
            public DateTime DatumTransakcije { get { return datumTransakcije; } set { datumTransakcije = value; } }
            public double IznosTransakcije { get { return iznosTransakcije; } set { iznosTransakcije = value; } }

            public int CompareTo(object obj)
            {
                int rez = this.DatumTransakcije.CompareTo(((Transakcija)obj).DatumTransakcije);

                if (rez == 0)
                {
                   
                    rez = this.IznosTransakcije.CompareTo(((Transakcija)obj).IznosTransakcije);
                }

                return rez;
            }


            public override string ToString() => this.Racun + " " + this.DatumTransakcije;
        }
        public TransakcijaUpisPodataka()
        {
            InitializeComponent();
        }

        private void TransakcijaUpisPodataka_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
