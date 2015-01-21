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
    public partial class FormOtvorene_kosarice : Form
    {
        public FormOtvorene_kosarice()
        {
            InitializeComponent();
        }

        /*Popunjavanje pregleda tablice otvorenih narudžbi i pokretanje timera za osvježavanje liste*/
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet.Otvorene_narudžbe' table. You can move, or remove it, as needed.
            this.otvorene_narudžbeTableAdapter.Fill(this.t07_DBDataSet.Otvorene_narudžbe);
            Broj_kosarice.br_kos = int.Parse(this.otvorene_narudžbeDataGridView.CurrentRow.Cells[0].Value.ToString());
            // TODO: This line of code loads data into the 't07_DBDataSet.Stavke_kosarica' table. You can move, or remove it, as needed.
            this.stavke_kosaricaTableAdapter.FillByIDkosarice(this.t07_DBDataSet.Stavke_kosarica,Broj_kosarice.br_kos);
            timer1.Start();
        }
        
        /*Na svaki istek timera se ponovno učita lista otvorenih narudžbi*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.otvorene_narudžbeTableAdapter.Fill(this.t07_DBDataSet.Otvorene_narudžbe);            
        }

        /*Otvaranje forme za pregled stavki označene otvorene narudžbe*/
        private void buttonDetalji_Click(object sender, EventArgs e)
        {
            Broj_kosarice.br_kos = int.Parse(otvorene_narudžbeDataGridView.CurrentRow.Cells[0].Value.ToString());

            FormDetalji_kosarice frmDetalji = new FormDetalji_kosarice();
            frmDetalji.ShowDialog();
        }
        
        /*Pregled svih izvršenih narudžbi*/
        private void btnStare_Click(object sender, EventArgs e)
        {
            FormIzdane_narudbe frmIzdane = new FormIzdane_narudbe();
            frmIzdane.ShowDialog();
        }

        /*Pregled izdanih računa*/
        private void btnRacun_Click(object sender, EventArgs e)
        {
            FormRacun frmRacun = new FormRacun();
            frmRacun.ShowDialog();
        }
    }
}
