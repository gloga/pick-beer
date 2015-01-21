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
    public partial class Glavni_izbornik : Form
    {
        public Glavni_izbornik()
        {
            InitializeComponent();
        }

        private void buttonCjenik_Click(object sender, EventArgs e)
        {
            FormCjenik frmCjenik = new FormCjenik();
            frmCjenik.ShowDialog();
        }

        private void buttonKosarica_Click(object sender, EventArgs e)
        {
            FormKosarica frmKosarica = new FormKosarica();
            frmKosarica.ShowDialog();
        }

        private void buttonOdaberi_Click(object sender, EventArgs e)
        {
            FormOdaberiPivo frmOdaberiPivo = new FormOdaberiPivo();
            frmOdaberiPivo.ShowDialog();
        }
    }
}
