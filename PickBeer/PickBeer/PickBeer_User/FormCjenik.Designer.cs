namespace PickBeer_User
{
    partial class FormCjenik
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
            System.Windows.Forms.Label drzava_podrijetlaLabel;
            System.Windows.Forms.Label ime_pivaLabel;
            System.Windows.Forms.Label cijenaLabel;
            System.Windows.Forms.Label drzava_podrijetlaLabel1;
            System.Windows.Forms.Label vrstaLabel;
            System.Windows.Forms.Label volumenLabel;
            System.Windows.Forms.Label udio_alkLabel;
            System.Windows.Forms.Label ocjenaRBLabel;
            System.Windows.Forms.Label proizvodacLabel;
            System.Windows.Forms.Label kolicinaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCjenik));
            this.groupBoxCjenik = new System.Windows.Forms.GroupBox();
            this.pivoDataGridViewCjenik = new System.Windows.Forms.DataGridView();
            this.pivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t07_DBDataSet = new PickBeer_User.T07_DBDataSet();
            this.pivoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.pivoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pivoTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.PivoTableAdapter();
            this.tableAdapterManager = new PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager();
            this.drzava_SelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drzava_SelectTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.Drzava_SelectTableAdapter();
            this.drzava_podrijetlaComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBoxCjenik = new System.Windows.Forms.PictureBox();
            this.buttonSve = new System.Windows.Forms.Button();
            this.ime_pivaTextBox = new System.Windows.Forms.TextBox();
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.drzava_podrijetlaTextBox = new System.Windows.Forms.TextBox();
            this.vrstaTextBox = new System.Windows.Forms.TextBox();
            this.volumenTextBox = new System.Windows.Forms.TextBox();
            this.udio_alkTextBox = new System.Windows.Forms.TextBox();
            this.ocjenaRBTextBox = new System.Windows.Forms.TextBox();
            this.proizvodacTextBox = new System.Windows.Forms.TextBox();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelVol = new System.Windows.Forms.Label();
            this.labelAlk = new System.Windows.Forms.Label();
            this.buttonDodajuK = new System.Windows.Forms.Button();
            this.stavke_kosaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_kosaricaTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter();
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
            this.kosaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kosaricaTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.KosaricaTableAdapter();
            this.buttonTop20_RB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            drzava_podrijetlaLabel = new System.Windows.Forms.Label();
            ime_pivaLabel = new System.Windows.Forms.Label();
            cijenaLabel = new System.Windows.Forms.Label();
            drzava_podrijetlaLabel1 = new System.Windows.Forms.Label();
            vrstaLabel = new System.Windows.Forms.Label();
            volumenLabel = new System.Windows.Forms.Label();
            udio_alkLabel = new System.Windows.Forms.Label();
            ocjenaRBLabel = new System.Windows.Forms.Label();
            proizvodacLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            this.groupBoxCjenik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivoDataGridViewCjenik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingNavigator)).BeginInit();
            this.pivoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drzava_SelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCjenik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // drzava_podrijetlaLabel
            // 
            drzava_podrijetlaLabel.AutoSize = true;
            drzava_podrijetlaLabel.Location = new System.Drawing.Point(12, 9);
            drzava_podrijetlaLabel.Name = "drzava_podrijetlaLabel";
            drzava_podrijetlaLabel.Size = new System.Drawing.Size(89, 13);
            drzava_podrijetlaLabel.TabIndex = 2;
            drzava_podrijetlaLabel.Text = "Drzava podrijetla:";
            // 
            // ime_pivaLabel
            // 
            ime_pivaLabel.AutoSize = true;
            ime_pivaLabel.Location = new System.Drawing.Point(606, 99);
            ime_pivaLabel.Name = "ime_pivaLabel";
            ime_pivaLabel.Size = new System.Drawing.Size(50, 13);
            ime_pivaLabel.TabIndex = 6;
            ime_pivaLabel.Text = "Ime piva:";
            // 
            // cijenaLabel
            // 
            cijenaLabel.AutoSize = true;
            cijenaLabel.Location = new System.Drawing.Point(606, 128);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 8;
            cijenaLabel.Text = "Cijena:";
            // 
            // drzava_podrijetlaLabel1
            // 
            drzava_podrijetlaLabel1.AutoSize = true;
            drzava_podrijetlaLabel1.Location = new System.Drawing.Point(403, 401);
            drzava_podrijetlaLabel1.Name = "drzava_podrijetlaLabel1";
            drzava_podrijetlaLabel1.Size = new System.Drawing.Size(44, 13);
            drzava_podrijetlaLabel1.TabIndex = 10;
            drzava_podrijetlaLabel1.Text = "Država:";
            // 
            // vrstaLabel
            // 
            vrstaLabel.AutoSize = true;
            vrstaLabel.Location = new System.Drawing.Point(403, 427);
            vrstaLabel.Name = "vrstaLabel";
            vrstaLabel.Size = new System.Drawing.Size(34, 13);
            vrstaLabel.TabIndex = 12;
            vrstaLabel.Text = "Vrsta:";
            // 
            // volumenLabel
            // 
            volumenLabel.AutoSize = true;
            volumenLabel.Location = new System.Drawing.Point(606, 154);
            volumenLabel.Name = "volumenLabel";
            volumenLabel.Size = new System.Drawing.Size(51, 13);
            volumenLabel.TabIndex = 14;
            volumenLabel.Text = "Volumen:";
            // 
            // udio_alkLabel
            // 
            udio_alkLabel.AutoSize = true;
            udio_alkLabel.Location = new System.Drawing.Point(403, 453);
            udio_alkLabel.Name = "udio_alkLabel";
            udio_alkLabel.Size = new System.Drawing.Size(75, 13);
            udio_alkLabel.TabIndex = 16;
            udio_alkLabel.Text = "Udio alkohola:";
            // 
            // ocjenaRBLabel
            // 
            ocjenaRBLabel.AutoSize = true;
            ocjenaRBLabel.Location = new System.Drawing.Point(403, 505);
            ocjenaRBLabel.Name = "ocjenaRBLabel";
            ocjenaRBLabel.Size = new System.Drawing.Size(98, 13);
            ocjenaRBLabel.TabIndex = 18;
            ocjenaRBLabel.Text = "Ocjena RateBeera:";
            // 
            // proizvodacLabel
            // 
            proizvodacLabel.AutoSize = true;
            proizvodacLabel.Location = new System.Drawing.Point(403, 479);
            proizvodacLabel.Name = "proizvodacLabel";
            proizvodacLabel.Size = new System.Drawing.Size(64, 13);
            proizvodacLabel.TabIndex = 20;
            proizvodacLabel.Text = "Proizvođač:";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(393, 595);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(47, 13);
            kolicinaLabel.TabIndex = 30;
            kolicinaLabel.Text = "Količina:";
            // 
            // groupBoxCjenik
            // 
            this.groupBoxCjenik.AutoSize = true;
            this.groupBoxCjenik.Controls.Add(this.pivoDataGridViewCjenik);
            this.groupBoxCjenik.Location = new System.Drawing.Point(12, 40);
            this.groupBoxCjenik.Name = "groupBoxCjenik";
            this.groupBoxCjenik.Size = new System.Drawing.Size(369, 629);
            this.groupBoxCjenik.TabIndex = 0;
            this.groupBoxCjenik.TabStop = false;
            this.groupBoxCjenik.Text = "Cjenik";
            // 
            // pivoDataGridViewCjenik
            // 
            this.pivoDataGridViewCjenik.AllowUserToAddRows = false;
            this.pivoDataGridViewCjenik.AllowUserToDeleteRows = false;
            this.pivoDataGridViewCjenik.AutoGenerateColumns = false;
            this.pivoDataGridViewCjenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pivoDataGridViewCjenik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.pivoDataGridViewCjenik.DataSource = this.pivoBindingSource;
            this.pivoDataGridViewCjenik.Location = new System.Drawing.Point(10, 21);
            this.pivoDataGridViewCjenik.MultiSelect = false;
            this.pivoDataGridViewCjenik.Name = "pivoDataGridViewCjenik";
            this.pivoDataGridViewCjenik.ReadOnly = true;
            this.pivoDataGridViewCjenik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pivoDataGridViewCjenik.Size = new System.Drawing.Size(349, 589);
            this.pivoDataGridViewCjenik.TabIndex = 0;
            this.pivoDataGridViewCjenik.SelectionChanged += new System.EventHandler(this.pivoDataGridViewCjenik_SelectionChanged);
            // 
            // pivoBindingSource
            // 
            this.pivoBindingSource.DataMember = "Pivo";
            this.pivoBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // t07_DBDataSet
            // 
            this.t07_DBDataSet.DataSetName = "T07_DBDataSet";
            this.t07_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pivoBindingNavigator
            // 
            this.pivoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pivoBindingNavigator.BindingSource = this.pivoBindingSource;
            this.pivoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pivoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pivoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pivoBindingNavigatorSaveItem});
            this.pivoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pivoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pivoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pivoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pivoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pivoBindingNavigator.Name = "pivoBindingNavigator";
            this.pivoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pivoBindingNavigator.Size = new System.Drawing.Size(826, 25);
            this.pivoBindingNavigator.TabIndex = 1;
            this.pivoBindingNavigator.Text = "bindingNavigator1";
            this.pivoBindingNavigator.Visible = false;
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
            // pivoBindingNavigatorSaveItem
            // 
            this.pivoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pivoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pivoBindingNavigatorSaveItem.Image")));
            this.pivoBindingNavigatorSaveItem.Name = "pivoBindingNavigatorSaveItem";
            this.pivoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pivoBindingNavigatorSaveItem.Text = "Save Data";
            this.pivoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pivoBindingNavigatorSaveItem_Click);
            // 
            // pivoTableAdapter
            // 
            this.pivoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KosaricaTableAdapter = null;
            this.tableAdapterManager.PivoTableAdapter = this.pivoTableAdapter;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavke_kosaricaTableAdapter = null;
            this.tableAdapterManager.Stavke_racunTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // drzava_SelectBindingSource
            // 
            this.drzava_SelectBindingSource.DataMember = "Drzava_Select";
            this.drzava_SelectBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // drzava_SelectTableAdapter
            // 
            this.drzava_SelectTableAdapter.ClearBeforeFill = true;
            // 
            // drzava_podrijetlaComboBox
            // 
            this.drzava_podrijetlaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drzava_SelectBindingSource, "Drzava_podrijetla", true));
            this.drzava_podrijetlaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.drzava_SelectBindingSource, "Drzava_podrijetla", true));
            this.drzava_podrijetlaComboBox.DataSource = this.drzava_SelectBindingSource;
            this.drzava_podrijetlaComboBox.DisplayMember = "Drzava_podrijetla";
            this.drzava_podrijetlaComboBox.FormattingEnabled = true;
            this.drzava_podrijetlaComboBox.Location = new System.Drawing.Point(107, 6);
            this.drzava_podrijetlaComboBox.Name = "drzava_podrijetlaComboBox";
            this.drzava_podrijetlaComboBox.Size = new System.Drawing.Size(121, 21);
            this.drzava_podrijetlaComboBox.TabIndex = 3;
            this.drzava_podrijetlaComboBox.ValueMember = "Drzava_podrijetla";
            this.drzava_podrijetlaComboBox.SelectionChangeCommitted += new System.EventHandler(this.drzava_podrijetlaComboBox_SelectionChangeCommitted);
            // 
            // pictureBoxCjenik
            // 
            this.pictureBoxCjenik.Location = new System.Drawing.Point(396, 61);
            this.pictureBoxCjenik.Name = "pictureBoxCjenik";
            this.pictureBoxCjenik.Size = new System.Drawing.Size(200, 300);
            this.pictureBoxCjenik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCjenik.TabIndex = 4;
            this.pictureBoxCjenik.TabStop = false;
            // 
            // buttonSve
            // 
            this.buttonSve.Location = new System.Drawing.Point(234, 6);
            this.buttonSve.Name = "buttonSve";
            this.buttonSve.Size = new System.Drawing.Size(147, 35);
            this.buttonSve.TabIndex = 6;
            this.buttonSve.Text = "Prikaži sve pive";
            this.buttonSve.UseVisualStyleBackColor = true;
            this.buttonSve.Click += new System.EventHandler(this.buttonSve_Click);
            // 
            // ime_pivaTextBox
            // 
            this.ime_pivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Ime_piva", true));
            this.ime_pivaTextBox.Location = new System.Drawing.Point(663, 99);
            this.ime_pivaTextBox.Name = "ime_pivaTextBox";
            this.ime_pivaTextBox.ReadOnly = true;
            this.ime_pivaTextBox.Size = new System.Drawing.Size(151, 20);
            this.ime_pivaTextBox.TabIndex = 7;
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Cijena", true));
            this.cijenaTextBox.Location = new System.Drawing.Point(663, 125);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.ReadOnly = true;
            this.cijenaTextBox.Size = new System.Drawing.Size(34, 20);
            this.cijenaTextBox.TabIndex = 9;
            // 
            // drzava_podrijetlaTextBox
            // 
            this.drzava_podrijetlaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Drzava_podrijetla", true));
            this.drzava_podrijetlaTextBox.Location = new System.Drawing.Point(507, 398);
            this.drzava_podrijetlaTextBox.Name = "drzava_podrijetlaTextBox";
            this.drzava_podrijetlaTextBox.ReadOnly = true;
            this.drzava_podrijetlaTextBox.Size = new System.Drawing.Size(100, 20);
            this.drzava_podrijetlaTextBox.TabIndex = 11;
            // 
            // vrstaTextBox
            // 
            this.vrstaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Vrsta", true));
            this.vrstaTextBox.Location = new System.Drawing.Point(507, 424);
            this.vrstaTextBox.Name = "vrstaTextBox";
            this.vrstaTextBox.ReadOnly = true;
            this.vrstaTextBox.Size = new System.Drawing.Size(60, 20);
            this.vrstaTextBox.TabIndex = 13;
            // 
            // volumenTextBox
            // 
            this.volumenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Volumen", true));
            this.volumenTextBox.Location = new System.Drawing.Point(663, 151);
            this.volumenTextBox.Name = "volumenTextBox";
            this.volumenTextBox.ReadOnly = true;
            this.volumenTextBox.Size = new System.Drawing.Size(34, 20);
            this.volumenTextBox.TabIndex = 15;
            // 
            // udio_alkTextBox
            // 
            this.udio_alkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Udio_alk", true));
            this.udio_alkTextBox.Location = new System.Drawing.Point(507, 450);
            this.udio_alkTextBox.Name = "udio_alkTextBox";
            this.udio_alkTextBox.ReadOnly = true;
            this.udio_alkTextBox.Size = new System.Drawing.Size(42, 20);
            this.udio_alkTextBox.TabIndex = 17;
            // 
            // ocjenaRBTextBox
            // 
            this.ocjenaRBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "OcjenaRB", true));
            this.ocjenaRBTextBox.Location = new System.Drawing.Point(507, 502);
            this.ocjenaRBTextBox.Name = "ocjenaRBTextBox";
            this.ocjenaRBTextBox.ReadOnly = true;
            this.ocjenaRBTextBox.Size = new System.Drawing.Size(42, 20);
            this.ocjenaRBTextBox.TabIndex = 19;
            // 
            // proizvodacTextBox
            // 
            this.proizvodacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Proizvodac", true));
            this.proizvodacTextBox.Location = new System.Drawing.Point(507, 476);
            this.proizvodacTextBox.Name = "proizvodacTextBox";
            this.proizvodacTextBox.ReadOnly = true;
            this.proizvodacTextBox.Size = new System.Drawing.Size(190, 20);
            this.proizvodacTextBox.TabIndex = 21;
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(703, 128);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(19, 13);
            this.labelCijena.TabIndex = 24;
            this.labelCijena.Text = "kn";
            // 
            // labelVol
            // 
            this.labelVol.AutoSize = true;
            this.labelVol.Location = new System.Drawing.Point(703, 154);
            this.labelVol.Name = "labelVol";
            this.labelVol.Size = new System.Drawing.Size(9, 13);
            this.labelVol.TabIndex = 25;
            this.labelVol.Text = "l";
            // 
            // labelAlk
            // 
            this.labelAlk.AutoSize = true;
            this.labelAlk.Location = new System.Drawing.Point(552, 453);
            this.labelAlk.Name = "labelAlk";
            this.labelAlk.Size = new System.Drawing.Size(15, 13);
            this.labelAlk.TabIndex = 26;
            this.labelAlk.Text = "%";
            // 
            // buttonDodajuK
            // 
            this.buttonDodajuK.Location = new System.Drawing.Point(396, 614);
            this.buttonDodajuK.Name = "buttonDodajuK";
            this.buttonDodajuK.Size = new System.Drawing.Size(127, 36);
            this.buttonDodajuK.TabIndex = 27;
            this.buttonDodajuK.Text = "Dodaj u košaricu";
            this.buttonDodajuK.UseVisualStyleBackColor = true;
            this.buttonDodajuK.Click += new System.EventHandler(this.buttonDodajuK_Click);
            // 
            // stavke_kosaricaBindingSource
            // 
            this.stavke_kosaricaBindingSource.DataMember = "Stavke_kosarica";
            this.stavke_kosaricaBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // stavke_kosaricaTableAdapter
            // 
            this.stavke_kosaricaTableAdapter.ClearBeforeFill = true;
            // 
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stavke_kosaricaBindingSource, "Kolicina", true));
            this.kolicinaTextBox.Location = new System.Drawing.Point(446, 588);
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(77, 20);
            this.kolicinaTextBox.TabIndex = 31;
            // 
            // kosaricaBindingSource
            // 
            this.kosaricaBindingSource.DataMember = "Kosarica";
            this.kosaricaBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // kosaricaTableAdapter
            // 
            this.kosaricaTableAdapter.ClearBeforeFill = true;
            // 
            // buttonTop20_RB
            // 
            this.buttonTop20_RB.Location = new System.Drawing.Point(687, 531);
            this.buttonTop20_RB.Name = "buttonTop20_RB";
            this.buttonTop20_RB.Size = new System.Drawing.Size(127, 57);
            this.buttonTop20_RB.TabIndex = 32;
            this.buttonTop20_RB.Text = "TOP 20 najbolje ocijenjenih piva od RateBeer-a";
            this.buttonTop20_RB.UseVisualStyleBackColor = true;
            this.buttonTop20_RB.Click += new System.EventHandler(this.buttonTop10_RB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 57);
            this.button1.TabIndex = 33;
            this.button1.Text = "TOP 20 najčešće naručivanih piva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_pivo";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_pivo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime_piva";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 59;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cijena";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cijena";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 61;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Stanje";
            this.dataGridViewTextBoxColumn4.HeaderText = "Stanje";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Drzava_podrijetla";
            this.dataGridViewTextBoxColumn5.HeaderText = "Drzava_podrijetla";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Vrsta";
            this.dataGridViewTextBoxColumn6.HeaderText = "Vrsta";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Udio_alk";
            this.dataGridViewTextBoxColumn7.HeaderText = "Udio_alk";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Volumen";
            this.dataGridViewTextBoxColumn8.HeaderText = "Volumen";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 73;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OcjenaRB";
            this.dataGridViewTextBoxColumn9.HeaderText = "OcjenaRB";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OcjenaK";
            this.dataGridViewTextBoxColumn10.HeaderText = "OcjenaK";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Proizvodac";
            this.dataGridViewTextBoxColumn11.HeaderText = "Proizvodac";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Puta_narucivano";
            this.dataGridViewTextBoxColumn12.HeaderText = "Puta_narucivano";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Slika";
            this.dataGridViewTextBoxColumn13.HeaderText = "Slika";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // FormCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTop20_RB);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.kolicinaTextBox);
            this.Controls.Add(this.buttonDodajuK);
            this.Controls.Add(this.labelAlk);
            this.Controls.Add(this.labelVol);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(proizvodacLabel);
            this.Controls.Add(this.proizvodacTextBox);
            this.Controls.Add(ocjenaRBLabel);
            this.Controls.Add(this.ocjenaRBTextBox);
            this.Controls.Add(udio_alkLabel);
            this.Controls.Add(this.udio_alkTextBox);
            this.Controls.Add(volumenLabel);
            this.Controls.Add(this.volumenTextBox);
            this.Controls.Add(vrstaLabel);
            this.Controls.Add(this.vrstaTextBox);
            this.Controls.Add(drzava_podrijetlaLabel1);
            this.Controls.Add(this.drzava_podrijetlaTextBox);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(ime_pivaLabel);
            this.Controls.Add(this.ime_pivaTextBox);
            this.Controls.Add(this.buttonSve);
            this.Controls.Add(this.pictureBoxCjenik);
            this.Controls.Add(drzava_podrijetlaLabel);
            this.Controls.Add(this.drzava_podrijetlaComboBox);
            this.Controls.Add(this.pivoBindingNavigator);
            this.Controls.Add(this.groupBoxCjenik);
            this.Name = "FormCjenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cjenik";
            this.Load += new System.EventHandler(this.FormCjenik_Load);
            this.groupBoxCjenik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivoDataGridViewCjenik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingNavigator)).EndInit();
            this.pivoBindingNavigator.ResumeLayout(false);
            this.pivoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drzava_SelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCjenik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCjenik;
        private T07_DBDataSet t07_DBDataSet;
        private System.Windows.Forms.BindingSource pivoBindingSource;
        private T07_DBDataSetTableAdapters.PivoTableAdapter pivoTableAdapter;
        private T07_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pivoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pivoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pivoDataGridViewCjenik;
        private System.Windows.Forms.BindingSource drzava_SelectBindingSource;
        private T07_DBDataSetTableAdapters.Drzava_SelectTableAdapter drzava_SelectTableAdapter;
        private System.Windows.Forms.ComboBox drzava_podrijetlaComboBox;
        private System.Windows.Forms.PictureBox pictureBoxCjenik;
        private System.Windows.Forms.Button buttonSve;
        private System.Windows.Forms.TextBox ime_pivaTextBox;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.TextBox drzava_podrijetlaTextBox;
        private System.Windows.Forms.TextBox vrstaTextBox;
        private System.Windows.Forms.TextBox volumenTextBox;
        private System.Windows.Forms.TextBox udio_alkTextBox;
        private System.Windows.Forms.TextBox ocjenaRBTextBox;
        private System.Windows.Forms.TextBox proizvodacTextBox;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelVol;
        private System.Windows.Forms.Label labelAlk;
        private System.Windows.Forms.Button buttonDodajuK;
        private System.Windows.Forms.BindingSource stavke_kosaricaBindingSource;
        private T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter stavke_kosaricaTableAdapter;
        private System.Windows.Forms.TextBox kolicinaTextBox;
        private System.Windows.Forms.BindingSource kosaricaBindingSource;
        private T07_DBDataSetTableAdapters.KosaricaTableAdapter kosaricaTableAdapter;
        private System.Windows.Forms.Button buttonTop20_RB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}