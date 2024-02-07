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
    public partial class KorisnikF : Form
    {
        internal void PrikaziPodatke(List<KorisnikUpisPodataka.Korisnik> korisnici)
        {
            listBox1.Items.Clear(); 
            foreach (KorisnikUpisPodataka.Korisnik korisnik in korisnici)
            {
                listBox1.Items.Add(korisnik.ToString());
            }
        }
        public KorisnikF()
        {
            InitializeComponent();
        }

        private void Korisnik_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            KorisnikUpisPodataka form = new KorisnikUpisPodataka();
            form.Owner = this;
            form.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        internal void PrikaziPodatkeK(List<KorisnikUpisPodataka.Korisnik> korisnici)
        {
            listBox1.Items.Clear(); 
            foreach (KorisnikUpisPodataka.Korisnik korisnik in korisnici)
            {
                listBox1.Items.Add(korisnik.ToString());
            }
        }



    }
}
