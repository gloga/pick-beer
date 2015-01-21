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
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }

        private void pivoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet11);

        }

        private void FormView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet11.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet11.Pivo);
            pictureBoxView.ImageLocation = pivoDataGridViewView.CurrentRow.Cells[12].Value.ToString();
        }
        /*Ažuriranje prikazane slike sa promjenom selektiranog piva iz pregleda tablice*/
        private void pivoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (pivoDataGridViewView.RowCount > 0)
            {
                String img_loc = pivoDataGridViewView.CurrentRow.Cells[12].Value.ToString();
                pictureBoxView.ImageLocation = img_loc;
            }
        }
    }
}
