using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickBeer_User
{
    public partial class FormRulet : Form
    {
        public FormRulet()
        {
            InitializeComponent();
        }

        /*Pritiskom na tipku Pokreni se pokreće upit koji vraća nasumično odabranu državu, pokreće se prvi timer,
         a zatim i drugi timer*/
        private void btnPokreni_Click(object sender, EventArgs e)
        {
            this.random_DrzavaTableAdapter.Fill(this.t07_DBDataSet.Random_Drzava);
            timer1.Start();
            ime_pivaTextBox.Text = "█";
            cijenaTextBox.Text = "█";
            volumenTextBox.Text = "█";
            timer2.Start();
        }

        /*Popunjavanje polja sa ASCII simbolom 219 u svrhu animacije*/
        private void timer2_Tick(object sender, EventArgs e)
        {
            ime_pivaTextBox.Text = ime_pivaTextBox.Text + "█" + "█" + "█";
            cijenaTextBox.Text = cijenaTextBox.Text + "█";
            volumenTextBox.Text = volumenTextBox.Text + "█";
        }

        /*Zaustavlja prvi timer, popunjava polja Ime piva, Cijena i Volumen sa nasumično odabrnim pivom iz 
         države koja je prethodno odabrana*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            string drzava = drzava_podrijetlaTextBox.Text;
            this.pivoTableAdapter.FillByRuler(this.t07_DBDataSet.Pivo, drzava);
            string slika = slikaTextBox.Text;
            pictureBox1.ImageLocation = slika;
            timer1.Stop();
        }

        /*Dodavanje piva u košaricu sa pretpostavljenom količinom 1*/
        private void btnNaruci_Click(object sender, EventArgs e)
        {
            int IDpivoRulet = int.Parse(iD_pivoTextBox.Text.ToString());
            T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter dodavanjeNovogArtikla = new T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter();
            dodavanjeNovogArtikla.Insert(IDpivoRulet, BrojNarudbe.brojNarudbe, 1);
            MessageBox.Show("Artikl dodan u košaricu");
        }
    }
}
