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
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void PocetnaStranica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KorisnikF form = new KorisnikF();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Racun form = new Racun();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transakcija form = new Transakcija();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OdabirDatuma form = new OdabirDatuma();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
