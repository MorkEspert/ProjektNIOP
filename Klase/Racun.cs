using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt {
    public partial class Racun : Form
    {
        public Racun()
        {
            InitializeComponent();
        }

        private void Racun_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RacunUpisPodataka form = new RacunUpisPodataka();
            form.Show();
        }

      
        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
