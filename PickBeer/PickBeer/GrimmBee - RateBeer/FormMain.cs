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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd frmAdd = new FormAdd();
            frmAdd.ShowDialog();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            FormView frmView = new FormView();
            frmView.ShowDialog();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate frmUpdate = new FormUpdate();
            frmUpdate.ShowDialog();
        }

        private void btnStanje_Click(object sender, EventArgs e)
        {
            FormStanje frmStanje = new FormStanje();
            frmStanje.ShowDialog();
        }
    }
}
