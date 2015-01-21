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
    public partial class FormIzdane_narudbe : Form
    {
        public FormIzdane_narudbe()
        {
            InitializeComponent();
        }

        private void kosaricaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kosaricaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

        }

        private void FormIzdane_narudbe_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 't07_DBDataSet1.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet1.Pivo);
            // TODO: This line of code loads data into the 't07_DBDataSet.Izdane_narudžbe' table. You can move, or remove it, as needed.
            this.izdane_narudžbeTableAdapter.Fill(this.t07_DBDataSet.Izdane_narudžbe);
            // TODO: This line of code loads data into the 't07_DBDataSet.Stavke_kosarica' table. You can move, or remove it, as needed.
            int trenutna2 = int.Parse(kosaricaDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.stavke_kosaricaTableAdapter.FillByIDgrup(this.t07_DBDataSet.Stavke_kosarica,trenutna2);
            // TODO: This line of code loads data into the 't07_DBDataSet.Kosarica' table. You can move, or remove it, as needed.
            this.kosaricaTableAdapter.Fill(this.t07_DBDataSet.Kosarica);

            // TODO: This line of code loads data into the 't07_DBDataSet.Pregled_narudbe' table. You can move, or remove it, as needed.
            this.pregled_narudbeTableAdapter.FillByIDkosaricaGrup(this.t07_DBDataSet.Pregled_narudbe,trenutna2);
            int sum = 0;
            for (int i = 0; i < stavke_kosaricaDataGridView.Rows.Count; i = i + 1)
            {

                int prvi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[2].Value.ToString());
                int drugi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[3].FormattedValue.ToString());
                int zbroj = prvi * drugi;

                stavke_kosaricaDataGridView.Rows[i].Cells[4].Value = zbroj.ToString() + ",00 kn";
                sum = sum + zbroj;
            }

            txtUkupno.Text = sum.ToString() + ",00 kn";

        }

        /*Izračun cijene pojedine stavke narudžbe i ukupne cijene narudžbe*/
        private void kosaricaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int trenutna = int.Parse(kosaricaDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.stavke_kosaricaTableAdapter.FillByIDgrup(this.t07_DBDataSet.Stavke_kosarica, trenutna);
            int sum = 0;
            for (int i = 0; i < stavke_kosaricaDataGridView.Rows.Count; i = i + 1)
            {

                int prvi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[2].Value.ToString());
                int drugi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[3].FormattedValue.ToString());
                int zbroj = prvi * drugi;

                stavke_kosaricaDataGridView.Rows[i].Cells[4].Value = zbroj.ToString() + ",00 kn";
                sum = sum + zbroj;
            }

            txtUkupno.Text = sum.ToString() + ",00 kn";

        }
    }
}
