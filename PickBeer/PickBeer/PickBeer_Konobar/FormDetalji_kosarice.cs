using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickBeer_Konobar
{
    public partial class FormDetalji_kosarice : Form
    {
        public FormDetalji_kosarice()
        {
            InitializeComponent();
        }

        private void stavke_kosaricaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stavke_kosaricaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

        }

        /*Popunjavanje pregleda tablice stavki otvorene narudžbe, izračun cijene stavki i cijele narudžbe, */
        private void FormDetalji_kosarice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet.MAX_ID_Racun' table. You can move, or remove it, as needed.
            this.mAX_ID_RacunTableAdapter.Fill(this.t07_DBDataSet.MAX_ID_Racun);
            // TODO: This line of code loads data into the 't07_DBDataSet.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet.Pivo);
            // TODO: This line of code loads data into the 't07_DBDataSet.Stavke_kosarica' table. You can move, or remove it, as needed.
            this.stavke_kosaricaTableAdapter.FillByIDgrup(this.t07_DBDataSet.Stavke_kosarica,Broj_kosarice.br_kos);

            this.Pregled_narudbeTableAdapter.FillByIDkosaricaGrup(this.t07_DBDataSet.Pregled_narudbe, Broj_kosarice.br_kos);

            this.KosaricaTableAdapter.Fill(this.t07_DBDataSet.Kosarica);

            int sum = 0;
            for (int i = 0; i < stavke_kosaricaDataGridView.Rows.Count; i = i + 1)
            {
                
                int prvi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[2].Value.ToString());
                int drugi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[3].FormattedValue.ToString());
                int zbroj = prvi * drugi;

                stavke_kosaricaDataGridView.Rows[i].Cells[4].Value = zbroj.ToString()+",00 kn";
                sum = sum + zbroj;
            }

            txtUkupno.Text = sum.ToString()+",00 kn";
        }

        /*Potvrda narudžbe od strane konobara, upis u tablicu Račun, umanjivanje naručene količine artikala sa skladišta
         izrada izvještaja računa i prikaz računa*/
        private void btnIspis_Click(object sender, EventArgs e)
        {
            T07_DBDataSet.KosaricaRow izmjenareda;
            izmjenareda = t07_DBDataSet.Kosarica.FindByID_kosarica(Broj_kosarice.br_kos);

            izmjenareda.Vrijeme = DateTime.Now;
            izmjenareda.Status = true;

            this.KosaricaTableAdapter.Update(this.t07_DBDataSet.Kosarica);

            racunTableAdapter.NoviRacun(Broj_kosarice.br_kos, DateTime.Now);

            this.mAX_ID_RacunTableAdapter.Fill(this.t07_DBDataSet.MAX_ID_Racun);
            
            int racunID = int.Parse(maxID.Text.ToString());

            for (int i = 0; i < stavke_kosaricaDataGridView.Rows.Count; i = i + 1)
            {
                int idPiva = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[0].Value.ToString());
                int kolicina = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[2].Value.ToString());
                int kolicinadb = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[5].FormattedValue.ToString());
                stavke_racunTableAdapter1.DodavanjeStavkeRacuna(idPiva, racunID, kolicina);

                T07_DBDataSet.PivoRow izmjenakolicine;
                izmjenakolicine = t07_DBDataSet.Pivo.FindByID_pivo(idPiva);

                izmjenakolicine.Stanje = kolicinadb-kolicina ;

                this.pivoTableAdapter.Update(this.t07_DBDataSet.Pivo);
            }


            this.pregled_racunaTableAdapter.FillByIDracun(this.t07_DBDataSet.Pregled_racuna, racunID);

            MessageBox.Show("Račun pohranjen");
            
            this.reportViewer2.RefreshReport();            
        }

        private void fillByIDMaxToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.racunTableAdapter.FillByIDMax(this.t07_DBDataSet.Racun);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        /*Otvaranje izbornika za ispis računa*/
        private void btnPrint_Click(object sender, EventArgs e)
        {
            reportViewer2.PrintDialog();
        }
    }
}
