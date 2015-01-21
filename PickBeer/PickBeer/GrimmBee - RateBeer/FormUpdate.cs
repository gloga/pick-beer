using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrimmBee___RateBeer
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void pivoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet11);

        }
        /*Dohvaćanje podataka i popunjavanje polja za izmejnu istim*/
        private void FormUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet11.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet11.Pivo);
            pictureBoxUpdate.ImageLocation = pivoDataGridViewUpdate.CurrentRow.Cells[12].Value.ToString();
        }
        /*Pohrana izmjena nazad u bazu podataka*/
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet11);
            MessageBox.Show("Artikl je ažuriran");
        }
        /*Ažuriranje prikazane slike sa promjenom selektiranog piva iz pregleda tablice*/
        private void pivoDataGridViewUpdate_SelectionChanged(object sender, EventArgs e)
        {
            if (pivoDataGridViewUpdate.RowCount > 0)
            {
                String img_loc = pivoDataGridViewUpdate.CurrentRow.Cells[12].Value.ToString();
                pictureBoxUpdate.ImageLocation = img_loc;
            }
        }
    }
}
