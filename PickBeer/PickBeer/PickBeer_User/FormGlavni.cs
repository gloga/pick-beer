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
            FormKosarica frmKos = new FormKosarica();
            frmKos.ShowDialog();
        }

        /*Na pokretanje programa se kreiran novi zapis u tablici Košarica i broj kreirane košarice se zapisuje u klasu BrojNarudbe*/
        private void Glavni_izbornik_Load(object sender, EventArgs e)
        {
            this.kosaricaTableAdapter.Fill(this.t07_DBDataSet.Kosarica);
            
            T07_DBDataSetTableAdapters.KosaricaTableAdapter kosarica = new T07_DBDataSetTableAdapters.KosaricaTableAdapter();

            kosaricaBindingSource.AddNew();
            this.Validate();
            this.kosaricaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);
            
            this.mAX_ID_KosaricaTableAdapter.Fill(this.t07_DBDataSet.MAX_ID_Kosarica);
            BrojNarudbe.brojNarudbe = int.Parse(ZadnjaNarudba.Text);
            
        }

        private void kosaricaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kosaricaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

        }

        private void buttonBR_Click(object sender, EventArgs e)
        {
            FormRulet frmRulet = new FormRulet();
            frmRulet.ShowDialog();
        }

        /*Pritiskom na tipku F1 na tikovnici se otvaraju upute za korištenje aplikacije*/
        private void Glavni_izbornik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FormHelp frmHelp = new FormHelp();
                frmHelp.ShowDialog();
            }
        }

        }
}

