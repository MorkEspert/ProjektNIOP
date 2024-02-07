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
    public partial class RacunUpisPodataka : Form
    {
        internal class Racun : IComparable
        {
            private int brojRacuna;
            private double stanje;
            private KorisnikF korisnik; 
            private DateTime datumOtvaranja; 


            public int BrojRacuna { get { return brojRacuna; } set { this.brojRacuna = value; } }
            public double Stanje { get { return stanje; } set { this.stanje = value; } }
            public KorisnikF Korisnik { get { return korisnik; } set { this.korisnik = value; } } 
            public DateTime DatumOtvaranja { get { return datumOtvaranja; } set { this.datumOtvaranja = value; } } 



            public int CompareTo(object obj) => this.BrojRacuna.CompareTo(((Racun)obj).BrojRacuna);


            public override string ToString() => this.BrojRacuna.ToString();
        }
        public RacunUpisPodataka()
        {
            InitializeComponent();
        }

        private void RacunUpisPodataka_Load(object sender, EventArgs e)
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
