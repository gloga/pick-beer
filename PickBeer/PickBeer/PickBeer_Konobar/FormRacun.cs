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
    public partial class FormRacun : Form
    {
        public FormRacun()
        {
            InitializeComponent();
        }
        int brojRac;
        private void racunBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.racunBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

        }

        private void FormRacun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet.Pivo);
            // TODO: This line of code loads data into the 't07_DBDataSet.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.t07_DBDataSet.Racun);
            // TODO: This line of code loads data into the 't07_DBDataSet.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.t07_DBDataSet.Racun);

            brojRac = int.Parse(racunDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.stavke_racunTableAdapter.FillBybrRacuna(this.t07_DBDataSet.Stavke_racun,brojRac);
            if (stavke_racunDataGridView.RowCount > 0)
                {
                    int sum = 0;
                    for (int i = 0; i < stavke_racunDataGridView.Rows.Count; i = i + 1)
                    {
                        
                      int prvi = int.Parse(stavke_racunDataGridView.Rows[i].Cells[2].Value.ToString());
                      int drugi = int.Parse(stavke_racunDataGridView.Rows[i].Cells[3].FormattedValue.ToString());
                      int zbroj = prvi * drugi;

                      stavke_racunDataGridView.Rows[i].Cells[4].Value = zbroj.ToString() +",00 kn";
                      sum = sum + zbroj;
                       
                    }

                    txtUkupno.Text = sum.ToString() + ",00 kn";
                }

        }

        private void racunBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.racunBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

        }

        private void racunDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (racunDataGridView.RowCount > 0)
            {
                int brojRac2 = int.Parse(racunDataGridView.CurrentRow.Cells[0].Value.ToString());
                this.stavke_racunTableAdapter.FillBybrRacuna(this.t07_DBDataSet.Stavke_racun, brojRac2);
                
                if (stavke_racunDataGridView.RowCount > 0)
                {
                    int sum = 0;
                    for (int i = 0; i < stavke_racunDataGridView.Rows.Count; i = i + 1)
                    {
                        
                      int prvi = int.Parse(stavke_racunDataGridView.Rows[i].Cells[2].Value.ToString());
                      int drugi = int.Parse(stavke_racunDataGridView.Rows[i].Cells[3].FormattedValue.ToString());
                      int zbroj = prvi * drugi;

                      stavke_racunDataGridView.Rows[i].Cells[4].Value = zbroj.ToString() + ",00 kn";
                      sum = sum + zbroj;
                       
                    }

                    txtUkupno.Text = sum.ToString() + ",00 kn";
                }


            }
        }
    }
}
