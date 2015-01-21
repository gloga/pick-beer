namespace PickBeer_Konobar
{
    partial class FormRacun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRacun));
            this.racunBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t07_DBDataSet = new PickBeer_Konobar.T07_DBDataSet();
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
            this.racunBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.racunDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavke_racunDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavke_racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new PickBeer_Konobar.T07_DBDataSetTableAdapters.RacunTableAdapter();
            this.tableAdapterManager = new PickBeer_Konobar.T07_DBDataSetTableAdapters.TableAdapterManager();
            this.stavke_racunTableAdapter = new PickBeer_Konobar.T07_DBDataSetTableAdapters.Stavke_racunTableAdapter();
            this.pivoTableAdapter = new PickBeer_Konobar.T07_DBDataSetTableAdapters.PivoTableAdapter();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingNavigator)).BeginInit();
            this.racunBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_racunDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // racunBindingNavigator
            // 
            this.racunBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.racunBindingNavigator.BindingSource = this.racunBindingSource;
            this.racunBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.racunBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.racunBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.racunBindingNavigatorSaveItem});
            this.racunBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.racunBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.racunBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.racunBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.racunBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.racunBindingNavigator.Name = "racunBindingNavigator";
            this.racunBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.racunBindingNavigator.Size = new System.Drawing.Size(621, 25);
            this.racunBindingNavigator.TabIndex = 0;
            this.racunBindingNavigator.Text = "bindingNavigator1";
            this.racunBindingNavigator.Visible = false;
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
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.t07_DBDataSet;
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
            // racunBindingNavigatorSaveItem
            // 
            this.racunBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.racunBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("racunBindingNavigatorSaveItem.Image")));
            this.racunBindingNavigatorSaveItem.Name = "racunBindingNavigatorSaveItem";
            this.racunBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.racunBindingNavigatorSaveItem.Text = "Save Data";
            this.racunBindingNavigatorSaveItem.Click += new System.EventHandler(this.racunBindingNavigatorSaveItem_Click_1);
            // 
            // racunDataGridView
            // 
            this.racunDataGridView.AllowUserToAddRows = false;
            this.racunDataGridView.AllowUserToDeleteRows = false;
            this.racunDataGridView.AutoGenerateColumns = false;
            this.racunDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racunDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.racunDataGridView.DataSource = this.racunBindingSource;
            this.racunDataGridView.Location = new System.Drawing.Point(12, 12);
            this.racunDataGridView.Name = "racunDataGridView";
            this.racunDataGridView.ReadOnly = true;
            this.racunDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.racunDataGridView.Size = new System.Drawing.Size(247, 220);
            this.racunDataGridView.TabIndex = 1;
            this.racunDataGridView.SelectionChanged += new System.EventHandler(this.racunDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_racun";
            this.dataGridViewTextBoxColumn1.HeaderText = "Broj računa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_kosarica";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_kosarica";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vrijeme";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vrijeme";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // stavke_racunDataGridView
            // 
            this.stavke_racunDataGridView.AllowUserToAddRows = false;
            this.stavke_racunDataGridView.AllowUserToDeleteRows = false;
            this.stavke_racunDataGridView.AutoGenerateColumns = false;
            this.stavke_racunDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavke_racunDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Naziv,
            this.dataGridViewTextBoxColumn7,
            this.Cijena,
            this.Iznos,
            this.dataGridViewTextBoxColumn6});
            this.stavke_racunDataGridView.DataSource = this.stavke_racunBindingSource;
            this.stavke_racunDataGridView.Location = new System.Drawing.Point(12, 251);
            this.stavke_racunDataGridView.Name = "stavke_racunDataGridView";
            this.stavke_racunDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stavke_racunDataGridView.Size = new System.Drawing.Size(570, 220);
            this.stavke_racunDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_pivo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Šifra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "ID_pivo";
            this.Naziv.DataSource = this.pivoBindingSource;
            this.Naziv.DisplayMember = "Ime_piva";
            this.Naziv.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ValueMember = "ID_pivo";
            // 
            // pivoBindingSource
            // 
            this.pivoBindingSource.DataMember = "Pivo";
            this.pivoBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn7.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "ID_pivo";
            this.Cijena.DataSource = this.pivoBindingSource;
            this.Cijena.DisplayMember = "Cijena";
            this.Cijena.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ValueMember = "ID_pivo";
            // 
            // Iznos
            // 
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_racun";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_racun";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // stavke_racunBindingSource
            // 
            this.stavke_racunBindingSource.DataMember = "Stavke_racun";
            this.stavke_racunBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KosaricaTableAdapter = null;
            this.tableAdapterManager.PivoTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = this.racunTableAdapter;
            this.tableAdapterManager.Stavke_kosaricaTableAdapter = null;
            this.tableAdapterManager.Stavke_racunTableAdapter = this.stavke_racunTableAdapter;
            this.tableAdapterManager.Table_testTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PickBeer_Konobar.T07_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stavke_racunTableAdapter
            // 
            this.stavke_racunTableAdapter.ClearBeforeFill = true;
            // 
            // pivoTableAdapter
            // 
            this.pivoTableAdapter.ClearBeforeFill = true;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(444, 489);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(138, 20);
            this.txtUkupno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ukupno:";
            // 
            // FormRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.stavke_racunDataGridView);
            this.Controls.Add(this.racunDataGridView);
            this.Controls.Add(this.racunBindingNavigator);
            this.Name = "FormRacun";
            this.Text = "Pregled izdanih računa";
            this.Load += new System.EventHandler(this.FormRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingNavigator)).EndInit();
            this.racunBindingNavigator.ResumeLayout(false);
            this.racunBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_racunDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_racunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private T07_DBDataSet t07_DBDataSet;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private T07_DBDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private T07_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator racunBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton racunBindingNavigatorSaveItem;
        private T07_DBDataSetTableAdapters.Stavke_racunTableAdapter stavke_racunTableAdapter;
        private System.Windows.Forms.DataGridView racunDataGridView;
        private System.Windows.Forms.BindingSource stavke_racunBindingSource;
        private System.Windows.Forms.DataGridView stavke_racunDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource pivoBindingSource;
        private T07_DBDataSetTableAdapters.PivoTableAdapter pivoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label label1;
    }
}