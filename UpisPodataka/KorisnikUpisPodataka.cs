using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Projekt
{
    public partial class KorisnikUpisPodataka : Form
    {
        internal class Korisnik : IComparable
        {
            private string ime;
            private string oib;
            private string prezime;
            private string adresa;
            private string telefon;

            public string Ime { get { return ime; } set { ime = value; } }
            public string Prezime { get { return prezime; } set { prezime = value; } }
            public string Oib { get { return oib; } set { oib = value; } }
            public string Adresa { get { return adresa; } set { adresa = value; } }
            public string Telefon { get { return telefon; } set { telefon = value; } }

            public int CompareTo(object obj)
            {
                int rez = this.Prezime.CompareTo(((Korisnik)obj).Prezime);

                if (rez == 0)
                {
                    rez = this.Ime.CompareTo(((Korisnik)obj).Ime);
                    return rez;
                }

                return rez;
            }

            public override string ToString() => this.Prezime + " " + this.Ime;
        }

        class PodatkovniKontekstK
        {
            private List<Korisnik> _korisnici;
            private string datKorisnici = @"C:\Users\Korisnik\OneDrive\Radna površina\Korisnici.txt";

            public List<Korisnik> Korisnici { get { return this._korisnici; } }

            public PodatkovniKontekstK()
            {
                this._korisnici = UcitajKorisnike();
            }

            private List<Korisnik> UcitajKorisnike()
            {
                List<Korisnik> korisnici = new List<Korisnik>();
                if (File.Exists(datKorisnici))
                {
                    using (StreamReader sr = new StreamReader(datKorisnici))
                    {
                        while (!sr.EndOfStream)
                        {
                            string linija = sr.ReadLine();
                            string[] polja = linija.Split('|');
                            Korisnik k = new Korisnik();
                            k.Ime = polja[0];
                            k.Prezime = polja[1];
                            k.Oib = polja[2];
                            k.Adresa = polja[3];
                            k.Telefon = polja[4];

                            korisnici.Add(k);
                        }
                    }
                }
                return korisnici;
            }
        }

        private PodatkovniKontekstK _kontekstKorisnika = new PodatkovniKontekstK();


        private void KorisnikUpisPodataka_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korisnik noviKorisnik = new Korisnik();
            noviKorisnik.Ime = textBox1.Text;
            noviKorisnik.Prezime = textBox2.Text;
            noviKorisnik.Oib = textBox3.Text;
            noviKorisnik.Adresa = textBox4.Text;
            noviKorisnik.Telefon = textBox5.Text;

            _kontekstKorisnika.Korisnici.Add(noviKorisnik);

            SpremiKorisnikeUDatoteku();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void SpremiKorisnikeUDatoteku()
        {
            string filePath = @"C:\Users\Korisnik\OneDrive\Radna površina\Korisnici.txt";

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (Korisnik korisnik in _kontekstKorisnika.Korisnici)
                {
                    string linija = $"{korisnik.Ime}|{korisnik.Prezime}|{korisnik.Oib}|{korisnik.Adresa}|{korisnik.Telefon}";
                    sw.WriteLine(linija);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void KorisnikUpisPodataka_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner is KorisnikF korisnikForm)
            {
                korisnikForm.PrikaziPodatkeK(_kontekstKorisnika.Korisnici);
            }
        }

        public KorisnikUpisPodataka()
        {
            InitializeComponent();
            this.FormClosed += KorisnikUpisPodataka_FormClosed;
        }
    }
}
