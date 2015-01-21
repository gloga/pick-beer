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

    public partial class FormStol : Form
    {
        

        public FormStol()
        {
            InitializeComponent();

            txtVrijeme.Text = DateTime.Now.TimeOfDay.ToString();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrojNarudbe.brojNarudbe = int.Parse(txtBrojStola.Text);

            this.Validate();
            this.kosaricaBindingSource.EndEdit();
            this.kosaricaTableAdapter.Update(this.t07_DBDataSet);

            
           
            Close();
        }

        private void FormStol_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet.Kosarica' table. You can move, or remove it, as needed.
            this.kosaricaTableAdapter.Fill(this.t07_DBDataSet.Kosarica);
            kosaricaBindingSource.AddNew();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
