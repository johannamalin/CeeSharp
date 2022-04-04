using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iän_laskeminen
{
    public partial class Ikä : Form
    {
        public Ikä()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            DateTime synttari = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosinaLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta.";
            KuukausinaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta.";
            PaivinaLB.Text = erotus + " päivää.";
            TunteinaLB.Text = (erotus * 24) + " tunteina.";
            MinuutteinaLB.Text = (erotus * 24 * 60) + " minuuttia.";
            SekuntteinaLB.Text = (erotus * 24 * 60 * 60) + " sekuntteina.";
            VuosinaLB.Visible = true;
            KuukausinaLB.Visible = true;
            PaivinaLB.Visible = true;
            MinuutteinaLB.Visible = true;
            SekuntteinaLB.Visible = true;
            TunteinaLB.Visible = true;

        }
    }
}
