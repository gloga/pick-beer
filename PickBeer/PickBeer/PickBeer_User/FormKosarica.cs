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
    public partial class FormKosarica : Form
    {
        public FormKosarica()
        {
            InitializeComponent();
        }

        private void stavke_kosaricaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stavke_kosaricaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

        }

        /*Popunjavanje pregleda tablice Stavke_košarice sa pivama koje su prethodno dodane u košaricu.
         Izračun cijene pojedinačnih stavki i ukupne cijene narudžbe*/
        private void FormKosarica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet.Kosarica' table. You can move, or remove it, as needed.
            this.kosaricaTableAdapter.Fill(this.t07_DBDataSet.Kosarica);
            // TODO: This line of code loads data into the 't07_DBDataSet.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet.Pivo);
            // TODO: This line of code loads data into the 't07_DBDataSet.Stavke_kosarica' table. You can move, or remove it, as needed.
            this.stavke_kosaricaTableAdapter.FillByIDgrup(this.t07_DBDataSet.Stavke_kosarica,BrojNarudbe.brojNarudbe);
            

            
            
            int sum = 0;
            for (int i = 0; i < stavke_kosaricaDataGridView.Rows.Count; i=i+1)
            {
                int prvi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[2].Value.ToString());
                int drugi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[3].FormattedValue.ToString());
                int zbroj = prvi *drugi ;
                
                stavke_kosaricaDataGridView.Rows[i].Cells[4].Value = zbroj.ToString()+",00 kn";
                sum = sum + zbroj;
            }

            txtUkupno.Text = sum.ToString()+",00 kn";
            
            

        }

        /*Brisanje označene stavke iz košarice*/
        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (stavke_kosaricaDataGridView.Rows.Count>0)
            {
            this.stavke_kosaricaTableAdapter.DeleteQuery(int.Parse(stavke_kosaricaDataGridView.CurrentRow.Cells[0].Value.ToString()), BrojNarudbe.brojNarudbe);
            this.stavke_kosaricaTableAdapter.FillByIDgrup(this.t07_DBDataSet.Stavke_kosarica, BrojNarudbe.brojNarudbe);
            MessageBox.Show("Stavka izbrisana");
            }

        }

        /*Potvrda narudžbe i prosljeđivanje iste konobaru sa stavkama i vremenom narudžbe. Nakon što se potvrdi
         postojeća narudžba kreira se nova*/
        private void btnNaruci_Click(object sender, EventArgs e)
        {
            if (stavke_kosaricaDataGridView.Rows.Count > 0)
            {
                T07_DBDataSet.KosaricaRow izmjenareda;
                izmjenareda = t07_DBDataSet.Kosarica.FindByID_kosarica(BrojNarudbe.brojNarudbe);

                izmjenareda.Vrijeme = DateTime.Now;
                izmjenareda.Status = false;

                this.kosaricaTableAdapter.Update(this.t07_DBDataSet.Kosarica);

                for (int i=0; i < stavke_kosaricaDataGridView.RowCount; i++)
                {
                    int trenutnoPuta;
                    int pivo = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[0].Value.ToString());
                    int puta = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[2].Value.ToString());
                    
                    trenutnoPuta = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[6].FormattedValue.ToString());
                    
                    

                    T07_DBDataSet.PivoRow putaNaruceno;
                    putaNaruceno = t07_DBDataSet.Pivo.FindByID_pivo(pivo);

                    putaNaruceno.Puta_narucivano = puta+trenutnoPuta;

                    this.pivoTableAdapter.Update(this.t07_DBDataSet.Pivo);
                }

                T07_DBDataSetTableAdapters.KosaricaTableAdapter kosarica = new T07_DBDataSetTableAdapters.KosaricaTableAdapter();

                kosaricaBindingSource.AddNew();
                this.Validate();
                this.kosaricaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

                txtUkupno.Text = "0,00 kn";
                BrojNarudbe.brojNarudbe++;


                BrojNarudbe.staraNarudba = 1;


                this.stavke_kosaricaTableAdapter.FillByID(this.t07_DBDataSet.Stavke_kosarica, BrojNarudbe.brojNarudbe);
                MessageBox.Show("Narudžba je zaprimljena");
            }
            else
                MessageBox.Show("Košarica je prazna");
        }

        /*Ponovno naručivanje prethodne narudžbe*/
        private void btnPonovi_Click(object sender, EventArgs e)
        {
            if (BrojNarudbe.staraNarudba == 1)
            {

                T07_DBDataSet.KosaricaRow izmjenareda;
                izmjenareda = t07_DBDataSet.Kosarica.FindByID_kosarica(BrojNarudbe.brojNarudbe);

                izmjenareda.Vrijeme = DateTime.Now;
                izmjenareda.Status = false;

                this.kosaricaTableAdapter.Update(this.t07_DBDataSet.Kosarica);
                MessageBox.Show("Runda je ponovljena.");

            }
            else
                MessageBox.Show("Nemate kreiranih narudžbi.");

        }
    }
}
