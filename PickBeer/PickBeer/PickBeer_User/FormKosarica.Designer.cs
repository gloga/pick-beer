namespace PickBeer_User
{
    partial class FormKosarica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKosarica));
            this.stavke_kosaricaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.stavke_kosaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t07_DBDataSet = new PickBeer_User.T07_DBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stavke_kosaricaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnPonovi = new System.Windows.Forms.Button();
            this.stavke_kosaricaDataGridView = new System.Windows.Forms.DataGridView();
            this.pivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_kosaricaTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter();
            this.tableAdapterManager = new PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager();
            this.kosaricaTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.KosaricaTableAdapter();
            this.pivoTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.PivoTableAdapter();
            this.kosaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaBindingNavigator)).BeginInit();
            this.stavke_kosaricaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stavke_kosaricaBindingNavigator
            // 
            this.stavke_kosaricaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stavke_kosaricaBindingNavigator.BindingSource = this.stavke_kosaricaBindingSource;
            this.stavke_kosaricaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stavke_kosaricaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stavke_kosaricaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.stavke_kosaricaBindingNavigatorSaveItem});
            this.stavke_kosaricaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stavke_kosaricaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stavke_kosaricaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stavke_kosaricaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stavke_kosaricaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stavke_kosaricaBindingNavigator.Name = "stavke_kosaricaBindingNavigator";
            this.stavke_kosaricaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stavke_kosaricaBindingNavigator.Size = new System.Drawing.Size(679, 25);
            this.stavke_kosaricaBindingNavigator.TabIndex = 0;
            this.stavke_kosaricaBindingNavigator.Text = "bindingNavigator1";
            this.stavke_kosaricaBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // stavke_kosaricaBindingSource
            // 
            this.stavke_kosaricaBindingSource.DataMember = "Stavke_kosarica";
            this.stavke_kosaricaBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // t07_DBDataSet
            // 
            this.t07_DBDataSet.DataSetName = "T07_DBDataSet";
            this.t07_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // stavke_kosaricaBindingNavigatorSaveItem
            // 
            this.stavke_kosaricaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stavke_kosaricaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stavke_kosaricaBindingNavigatorSaveItem.Image")));
            this.stavke_kosaricaBindingNavigatorSaveItem.Name = "stavke_kosaricaBindingNavigatorSaveItem";
            this.stavke_kosaricaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stavke_kosaricaBindingNavigatorSaveItem.Text = "Save Data";
            this.stavke_kosaricaBindingNavigatorSaveItem.Click += new System.EventHandler(this.stavke_kosaricaBindingNavigatorSaveItem_Click);
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(426, 282);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(156, 34);
            this.btnNaruci.TabIndex = 2;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(32, 293);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(48, 13);
            this.lblUkupno.TabIndex = 3;
            this.lblUkupno.Text = "Ukupno:";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(86, 290);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(118, 20);
            this.txtUkupno.TabIndex = 4;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(445, 118);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(137, 34);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.Text = "Izbriši stavku";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnPonovi
            // 
            this.btnPonovi.Location = new System.Drawing.Point(426, 322);
            this.btnPonovi.Name = "btnPonovi";
            this.btnPonovi.Size = new System.Drawing.Size(156, 34);
            this.btnPonovi.TabIndex = 6;
            this.btnPonovi.Text = "Ponovi rundu";
            this.btnPonovi.UseVisualStyleBackColor = true;
            this.btnPonovi.Click += new System.EventHandler(this.btnPonovi_Click);
            // 
            // stavke_kosaricaDataGridView
            // 
            this.stavke_kosaricaDataGridView.AllowUserToAddRows = false;
            this.stavke_kosaricaDataGridView.AutoGenerateColumns = false;
            this.stavke_kosaricaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavke_kosaricaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Naziv,
            this.Kolicina,
            this.Cijena,
            this.Iznos,
            this.dataGridViewTextBoxColumn2,
            this.Puta});
            this.stavke_kosaricaDataGridView.DataSource = this.stavke_kosaricaBindingSource;
            this.stavke_kosaricaDataGridView.Location = new System.Drawing.Point(35, 28);
            this.stavke_kosaricaDataGridView.Name = "stavke_kosaricaDataGridView";
            this.stavke_kosaricaDataGridView.ReadOnly = true;
            this.stavke_kosaricaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stavke_kosaricaDataGridView.Size = new System.Drawing.Size(388, 220);
            this.stavke_kosaricaDataGridView.TabIndex = 6;
            // 
            // pivoBindingSource
            // 
            this.pivoBindingSource.DataMember = "Pivo";
            this.pivoBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // stavke_kosaricaTableAdapter
            // 
            this.stavke_kosaricaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KosaricaTableAdapter = this.kosaricaTableAdapter;
            this.tableAdapterManager.PivoTableAdapter = this.pivoTableAdapter;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavke_kosaricaTableAdapter = this.stavke_kosaricaTableAdapter;
            this.tableAdapterManager.Stavke_racunTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kosaricaTableAdapter
            // 
            this.kosaricaTableAdapter.ClearBeforeFill = true;
            // 
            // pivoTableAdapter
            // 
            this.pivoTableAdapter.ClearBeforeFill = true;
            // 
            // kosaricaBindingSource
            // 
            this.kosaricaBindingSource.DataMember = "Kosarica";
            this.kosaricaBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_pivo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Šifra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Naziv.DataPropertyName = "ID_pivo";
            this.Naziv.DataSource = this.pivoBindingSource;
            this.Naziv.DisplayMember = "Ime_piva";
            this.Naziv.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.ValueMember = "ID_pivo";
            this.Naziv.Width = 40;
            // 
            // Kolicina
            // 
            this.Kolicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            this.Kolicina.Width = 69;
            // 
            // Cijena
            // 
            this.Cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cijena.DataPropertyName = "ID_pivo";
            this.Cijena.DataSource = this.pivoBindingSource;
            this.Cijena.DisplayMember = "Cijena";
            this.Cijena.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.ValueMember = "ID_pivo";
            this.Cijena.Width = 42;
            // 
            // Iznos
            // 
            this.Iznos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            this.Iznos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Iznos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Iznos.Width = 38;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_kosarica";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_kosarica";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // Puta
            // 
            this.Puta.DataPropertyName = "ID_pivo";
            this.Puta.DataSource = this.pivoBindingSource;
            this.Puta.DisplayMember = "Puta_narucivano";
            this.Puta.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Puta.HeaderText = "Puta";
            this.Puta.Name = "Puta";
            this.Puta.ReadOnly = true;
            this.Puta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Puta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Puta.ValueMember = "ID_pivo";
            this.Puta.Visible = false;
            // 
            // FormKosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 367);
            this.Controls.Add(this.stavke_kosaricaDataGridView);
            this.Controls.Add(this.btnPonovi);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.stavke_kosaricaBindingNavigator);
            this.Name = "FormKosarica";
            this.Text = "Košarica";
            this.Load += new System.EventHandler(this.FormKosarica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaBindingNavigator)).EndInit();
            this.stavke_kosaricaBindingNavigator.ResumeLayout(false);
            this.stavke_kosaricaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private T07_DBDataSet t07_DBDataSet;
        private System.Windows.Forms.BindingSource stavke_kosaricaBindingSource;
        private T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter stavke_kosaricaTableAdapter;
        private T07_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stavke_kosaricaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton stavke_kosaricaBindingNavigatorSaveItem;
        private T07_DBDataSetTableAdapters.PivoTableAdapter pivoTableAdapter;
        private System.Windows.Forms.BindingSource pivoBindingSource;
        private System.Windows.Forms.Button btnNaruci;
        private T07_DBDataSetTableAdapters.KosaricaTableAdapter kosaricaTableAdapter;
        private System.Windows.Forms.BindingSource kosaricaBindingSource;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnPonovi;
        private System.Windows.Forms.DataGridView stavke_kosaricaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Puta;
    }
}