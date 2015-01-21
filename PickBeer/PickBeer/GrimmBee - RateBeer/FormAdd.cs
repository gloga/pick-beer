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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void pivoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet11);

        }
        /*Stvaranje novoga zapisa prilikom otvaranja forme za dodavanje novg artikla*/
        private void FormAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet11.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet11.Pivo);
            pivoBindingSource.AddNew(); 
        }
        /*Pohranjivanje unesenih vrijednosti kao novi artikl u tablicu Pivo*/
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet11);
            MessageBox.Show("Artikl je dodan");
        }
    }
}
