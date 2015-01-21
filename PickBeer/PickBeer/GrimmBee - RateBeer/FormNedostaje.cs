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
    public partial class FormNedostaje : Form
    {
        public FormNedostaje()
        {
            InitializeComponent();
        }

        private void pivoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet11);

        }

        private void FormNedostaje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet11.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.FillByNedostaje(this.t07_DBDataSet11.Pivo);

        }
    }
}
