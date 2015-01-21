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
    public partial class FormOdaberiPivo : Form
    {
        public FormOdaberiPivo()
        {
            InitializeComponent();
            label4.Text = trackBarCijena.Value.ToString();

            
        }

        private void FormOdaberiPivo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet.Pivo);
            // TODO: This line of code loads data into the 't07_DBDataSet.Drzava_Select' table. You can move, or remove it, as needed.
            this.drzava_SelectTableAdapter.Fill(this.t07_DBDataSet.Drzava_Select);

        }

        private void Drzava_Podrijetla2comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String Drz = Drzava_Podrijetla2comboBox.SelectedValue.ToString();
            this.pivoTableAdapter.FillByDrzava(t07_DBDataSet.Pivo, Drz);


            
        }

        private void trackBarCijena_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBarCijena.Value.ToString();

            
        }

        private void comboBoxVrsta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string vrs = comboBoxVrsta.SelectedValue.ToString();
            this.pivoTableAdapter.FillByVrstaTab(t07_DBDataSet.Pivo, vrs);
        }

        
    }
}
