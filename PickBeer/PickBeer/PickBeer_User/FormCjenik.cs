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
    public partial class FormCjenik : Form
    {
        public FormCjenik()
        {
            InitializeComponent();
        }

        private void pivoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

        }

        /*Otvaranjem Cjenika se popunjava pregled tablice Pivo, padajući izbornik za odabir države i 
         popunjava se slika prvog piva u tablici*/
        private void FormCjenik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet.Kosarica' table. You can move, or remove it, as needed.
            this.kosaricaTableAdapter.Fill(this.t07_DBDataSet.Kosarica);
            // TODO: This line of code loads data into the 't07_DBDataSet.Stavke_kosarica' table. You can move, or remove it, as needed.
            this.stavke_kosaricaTableAdapter.Fill(this.t07_DBDataSet.Stavke_kosarica);
            // TODO: This line of code loads data into the 't07_DBDataSet.Drzava_Select' table. You can move, or remove it, as needed.
            this.drzava_SelectTableAdapter.Fill(this.t07_DBDataSet.Drzava_Select);
            // TODO: This line of code loads data into the 't07_DBDataSet.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.FillByStanje(this.t07_DBDataSet.Pivo);
            pictureBoxCjenik.ImageLocation = pivoDataGridViewCjenik.CurrentRow.Cells[12].Value.ToString();
        }

        /*Odabirom države iz padajućeg izbornika Država se prikazuju piva koja odgovaraju kriteriju odabrane države*/
        private void drzava_podrijetlaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String Drz = drzava_podrijetlaComboBox.SelectedValue.ToString();
            this.pivoTableAdapter.FillByDrzava(t07_DBDataSet.Pivo, Drz);
        }

        /*Svakom promjenom selektiranog se ažurira slika piva na formi*/
        private void pivoDataGridViewCjenik_SelectionChanged(object sender, EventArgs e)
        {
            if (pivoDataGridViewCjenik.RowCount > 0)
            {
                pictureBoxCjenik.ImageLocation = pivoDataGridViewCjenik.CurrentRow.Cells[12].Value.ToString();
            }
        }

        /*Pritiskom na tipku Prikaži sve pive se resetira filter za države i ponovno se prikazuju sve pive
         prema početnom rasporedu*/
        private void buttonSve_Click(object sender, EventArgs e)
        {
            this.pivoTableAdapter.FillByStanje(this.t07_DBDataSet.Pivo);
        }

        /*Pritiskom na tipku Dodaj u košaricu se odabrano pivo sa željenom količinom
         dodaje u prethodno izrađenu košaricu*/
        private void buttonDodajuK_Click(object sender, EventArgs e)
        {
            int Cjenik_ID = int.Parse(pivoDataGridViewCjenik.CurrentRow.Cells[0].Value.ToString());
            int Kolicina_cjenik = int.Parse(kolicinaTextBox.Text.ToString());

           T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter dodavanjeNovogArtikla = new T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter();
           dodavanjeNovogArtikla.Insert(Cjenik_ID, BrojNarudbe.brojNarudbe, Kolicina_cjenik);

            MessageBox.Show("Artikl dodan u košaricu");
        }

        /*Filtriranje piva prema ocjenama RateBeer-a i prikaz 20 najbolje ocijenjenih*/
        private void buttonTop10_RB_Click(object sender, EventArgs e)
        {
            this.pivoTableAdapter.FillByTOP20_RB(this.t07_DBDataSet.Pivo);
        }

        /*Filtriranje piva prema broju naručivanja i prikaz 20 najčešće naručivanih piva*/
        private void button1_Click(object sender, EventArgs e)
        {
            this.pivoTableAdapter.FillByPuta_narucivano(this.t07_DBDataSet.Pivo);
        }
        
    }
}
