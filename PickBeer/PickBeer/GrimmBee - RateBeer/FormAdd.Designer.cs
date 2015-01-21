namespace GrimmBee___RateBeer
{
    partial class FormAdd
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
            System.Windows.Forms.Label iD_pivoLabel;
            System.Windows.Forms.Label ime_pivaLabel;
            System.Windows.Forms.Label cijenaLabel;
            System.Windows.Forms.Label stanjeLabel;
            System.Windows.Forms.Label drzava_podrijetlaLabel;
            System.Windows.Forms.Label vrstaLabel;
            System.Windows.Forms.Label udio_alkLabel;
            System.Windows.Forms.Label volumenLabel;
            System.Windows.Forms.Label ocjenaRBLabel;
            System.Windows.Forms.Label proizvodacLabel;
            System.Windows.Forms.Label slikaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.t07_DBDataSet11 = new GrimmBee___RateBeer.T07_DBDataSet11();
            this.pivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pivoTableAdapter = new GrimmBee___RateBeer.T07_DBDataSet11TableAdapters.PivoTableAdapter();
            this.tableAdapterManager = new GrimmBee___RateBeer.T07_DBDataSet11TableAdapters.TableAdapterManager();
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
            this.iD_pivoTextBox = new System.Windows.Forms.TextBox();
            this.ime_pivaTextBox = new System.Windows.Forms.TextBox();
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.stanjeTextBox = new System.Windows.Forms.TextBox();
            this.drzava_podrijetlaTextBox = new System.Windows.Forms.TextBox();
            this.vrstaTextBox = new System.Windows.Forms.TextBox();
            this.udio_alkTextBox = new System.Windows.Forms.TextBox();
            this.volumenTextBox = new System.Windows.Forms.TextBox();
            this.ocjenaRBTextBox = new System.Windows.Forms.TextBox();
            this.proizvodacTextBox = new System.Windows.Forms.TextBox();
            this.slikaTextBox = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelStanje = new System.Windows.Forms.Label();
            this.labelAlk = new System.Windows.Forms.Label();
            this.labelVol = new System.Windows.Forms.Label();
            iD_pivoLabel = new System.Windows.Forms.Label();
            ime_pivaLabel = new System.Windows.Forms.Label();
            cijenaLabel = new System.Windows.Forms.Label();
            stanjeLabel = new System.Windows.Forms.Label();
            drzava_podrijetlaLabel = new System.Windows.Forms.Label();
            vrstaLabel = new System.Windows.Forms.Label();
            udio_alkLabel = new System.Windows.Forms.Label();
            volumenLabel = new System.Windows.Forms.Label();
            ocjenaRBLabel = new System.Windows.Forms.Label();
            proizvodacLabel = new System.Windows.Forms.Label();
            slikaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingNavigator)).BeginInit();
            this.pivoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_pivoLabel
            // 
            iD_pivoLabel.AutoSize = true;
            iD_pivoLabel.Location = new System.Drawing.Point(12, 45);
            iD_pivoLabel.Name = "iD_pivoLabel";
            iD_pivoLabel.Size = new System.Drawing.Size(21, 13);
            iD_pivoLabel.TabIndex = 1;
            iD_pivoLabel.Text = "ID:";
            // 
            // ime_pivaLabel
            // 
            ime_pivaLabel.AutoSize = true;
            ime_pivaLabel.Location = new System.Drawing.Point(12, 71);
            ime_pivaLabel.Name = "ime_pivaLabel";
            ime_pivaLabel.Size = new System.Drawing.Size(50, 13);
            ime_pivaLabel.TabIndex = 3;
            ime_pivaLabel.Text = "Ime piva:";
            // 
            // cijenaLabel
            // 
            cijenaLabel.AutoSize = true;
            cijenaLabel.Location = new System.Drawing.Point(12, 97);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 5;
            cijenaLabel.Text = "Cijena:";
            // 
            // stanjeLabel
            // 
            stanjeLabel.AutoSize = true;
            stanjeLabel.Location = new System.Drawing.Point(12, 123);
            stanjeLabel.Name = "stanjeLabel";
            stanjeLabel.Size = new System.Drawing.Size(40, 13);
            stanjeLabel.TabIndex = 7;
            stanjeLabel.Text = "Stanje:";
            // 
            // drzava_podrijetlaLabel
            // 
            drzava_podrijetlaLabel.AutoSize = true;
            drzava_podrijetlaLabel.Location = new System.Drawing.Point(290, 45);
            drzava_podrijetlaLabel.Name = "drzava_podrijetlaLabel";
            drzava_podrijetlaLabel.Size = new System.Drawing.Size(89, 13);
            drzava_podrijetlaLabel.TabIndex = 9;
            drzava_podrijetlaLabel.Text = "Država podrijetla:";
            // 
            // vrstaLabel
            // 
            vrstaLabel.AutoSize = true;
            vrstaLabel.Location = new System.Drawing.Point(290, 71);
            vrstaLabel.Name = "vrstaLabel";
            vrstaLabel.Size = new System.Drawing.Size(34, 13);
            vrstaLabel.TabIndex = 11;
            vrstaLabel.Text = "Vrsta:";
            // 
            // udio_alkLabel
            // 
            udio_alkLabel.AutoSize = true;
            udio_alkLabel.Location = new System.Drawing.Point(290, 97);
            udio_alkLabel.Name = "udio_alkLabel";
            udio_alkLabel.Size = new System.Drawing.Size(75, 13);
            udio_alkLabel.TabIndex = 13;
            udio_alkLabel.Text = "Udio alkohola:";
            // 
            // volumenLabel
            // 
            volumenLabel.AutoSize = true;
            volumenLabel.Location = new System.Drawing.Point(290, 123);
            volumenLabel.Name = "volumenLabel";
            volumenLabel.Size = new System.Drawing.Size(51, 13);
            volumenLabel.TabIndex = 15;
            volumenLabel.Text = "Volumen:";
            // 
            // ocjenaRBLabel
            // 
            ocjenaRBLabel.AutoSize = true;
            ocjenaRBLabel.Location = new System.Drawing.Point(290, 149);
            ocjenaRBLabel.Name = "ocjenaRBLabel";
            ocjenaRBLabel.Size = new System.Drawing.Size(92, 13);
            ocjenaRBLabel.TabIndex = 17;
            ocjenaRBLabel.Text = "Ocjena RateBeer:";
            // 
            // proizvodacLabel
            // 
            proizvodacLabel.AutoSize = true;
            proizvodacLabel.Location = new System.Drawing.Point(290, 175);
            proizvodacLabel.Name = "proizvodacLabel";
            proizvodacLabel.Size = new System.Drawing.Size(64, 13);
            proizvodacLabel.TabIndex = 19;
            proizvodacLabel.Text = "Proizvođač:";
            // 
            // slikaLabel
            // 
            slikaLabel.AutoSize = true;
            slikaLabel.Location = new System.Drawing.Point(290, 201);
            slikaLabel.Name = "slikaLabel";
            slikaLabel.Size = new System.Drawing.Size(33, 13);
            slikaLabel.TabIndex = 21;
            slikaLabel.Text = "Slika:";
            // 
            // t07_DBDataSet11
            // 
            this.t07_DBDataSet11.DataSetName = "T07_DBDataSet11";
            this.t07_DBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pivoBindingSource
            // 
            this.pivoBindingSource.DataMember = "Pivo";
            this.pivoBindingSource.DataSource = this.t07_DBDataSet11;
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
            this.tableAdapterManager.Table_testTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GrimmBee___RateBeer.T07_DBDataSet11TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.bindingNavigatorDeleteItem,
            this.pivoBindingNavigatorSaveItem,
            this.bindingNavigatorAddNewItem});
            this.pivoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pivoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pivoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pivoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pivoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pivoBindingNavigator.Name = "pivoBindingNavigator";
            this.pivoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pivoBindingNavigator.Size = new System.Drawing.Size(624, 25);
            this.pivoBindingNavigator.TabIndex = 0;
            this.pivoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Visible = false;
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
            this.bindingNavigatorPositionItem.ReadOnly = true;
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
            this.bindingNavigatorMoveNextItem.Visible = false;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Visible = false;
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
            this.pivoBindingNavigatorSaveItem.Visible = false;
            this.pivoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pivoBindingNavigatorSaveItem_Click);
            // 
            // iD_pivoTextBox
            // 
            this.iD_pivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "ID_pivo", true));
            this.iD_pivoTextBox.Location = new System.Drawing.Point(68, 42);
            this.iD_pivoTextBox.Name = "iD_pivoTextBox";
            this.iD_pivoTextBox.Size = new System.Drawing.Size(50, 20);
            this.iD_pivoTextBox.TabIndex = 2;
            // 
            // ime_pivaTextBox
            // 
            this.ime_pivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Ime_piva", true));
            this.ime_pivaTextBox.Location = new System.Drawing.Point(68, 68);
            this.ime_pivaTextBox.Name = "ime_pivaTextBox";
            this.ime_pivaTextBox.Size = new System.Drawing.Size(148, 20);
            this.ime_pivaTextBox.TabIndex = 4;
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Cijena", true));
            this.cijenaTextBox.Location = new System.Drawing.Point(68, 94);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(63, 20);
            this.cijenaTextBox.TabIndex = 6;
            // 
            // stanjeTextBox
            // 
            this.stanjeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Stanje", true));
            this.stanjeTextBox.Location = new System.Drawing.Point(68, 120);
            this.stanjeTextBox.Name = "stanjeTextBox";
            this.stanjeTextBox.Size = new System.Drawing.Size(50, 20);
            this.stanjeTextBox.TabIndex = 8;
            // 
            // drzava_podrijetlaTextBox
            // 
            this.drzava_podrijetlaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Drzava_podrijetla", true));
            this.drzava_podrijetlaTextBox.Location = new System.Drawing.Point(388, 42);
            this.drzava_podrijetlaTextBox.Name = "drzava_podrijetlaTextBox";
            this.drzava_podrijetlaTextBox.Size = new System.Drawing.Size(100, 20);
            this.drzava_podrijetlaTextBox.TabIndex = 10;
            // 
            // vrstaTextBox
            // 
            this.vrstaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Vrsta", true));
            this.vrstaTextBox.Location = new System.Drawing.Point(388, 68);
            this.vrstaTextBox.Name = "vrstaTextBox";
            this.vrstaTextBox.Size = new System.Drawing.Size(100, 20);
            this.vrstaTextBox.TabIndex = 12;
            // 
            // udio_alkTextBox
            // 
            this.udio_alkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Udio_alk", true));
            this.udio_alkTextBox.Location = new System.Drawing.Point(388, 94);
            this.udio_alkTextBox.Name = "udio_alkTextBox";
            this.udio_alkTextBox.Size = new System.Drawing.Size(55, 20);
            this.udio_alkTextBox.TabIndex = 14;
            // 
            // volumenTextBox
            // 
            this.volumenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Volumen", true));
            this.volumenTextBox.Location = new System.Drawing.Point(388, 120);
            this.volumenTextBox.Name = "volumenTextBox";
            this.volumenTextBox.Size = new System.Drawing.Size(55, 20);
            this.volumenTextBox.TabIndex = 16;
            // 
            // ocjenaRBTextBox
            // 
            this.ocjenaRBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "OcjenaRB", true));
            this.ocjenaRBTextBox.Location = new System.Drawing.Point(388, 146);
            this.ocjenaRBTextBox.Name = "ocjenaRBTextBox";
            this.ocjenaRBTextBox.Size = new System.Drawing.Size(55, 20);
            this.ocjenaRBTextBox.TabIndex = 18;
            // 
            // proizvodacTextBox
            // 
            this.proizvodacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Proizvodac", true));
            this.proizvodacTextBox.Location = new System.Drawing.Point(388, 172);
            this.proizvodacTextBox.Name = "proizvodacTextBox";
            this.proizvodacTextBox.Size = new System.Drawing.Size(186, 20);
            this.proizvodacTextBox.TabIndex = 20;
            // 
            // slikaTextBox
            // 
            this.slikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Slika", true));
            this.slikaTextBox.Location = new System.Drawing.Point(388, 198);
            this.slikaTextBox.Name = "slikaTextBox";
            this.slikaTextBox.Size = new System.Drawing.Size(227, 20);
            this.slikaTextBox.TabIndex = 22;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(68, 212);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(138, 97);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(19, 13);
            this.labelCijena.TabIndex = 24;
            this.labelCijena.Text = "kn";
            // 
            // labelStanje
            // 
            this.labelStanje.AutoSize = true;
            this.labelStanje.Location = new System.Drawing.Point(125, 123);
            this.labelStanje.Name = "labelStanje";
            this.labelStanje.Size = new System.Drawing.Size(45, 13);
            this.labelStanje.TabIndex = 25;
            this.labelStanje.Text = "komada";
            // 
            // labelAlk
            // 
            this.labelAlk.AutoSize = true;
            this.labelAlk.Location = new System.Drawing.Point(450, 97);
            this.labelAlk.Name = "labelAlk";
            this.labelAlk.Size = new System.Drawing.Size(15, 13);
            this.labelAlk.TabIndex = 26;
            this.labelAlk.Text = "%";
            // 
            // labelVol
            // 
            this.labelVol.AutoSize = true;
            this.labelVol.Location = new System.Drawing.Point(450, 123);
            this.labelVol.Name = "labelVol";
            this.labelVol.Size = new System.Drawing.Size(29, 13);
            this.labelVol.TabIndex = 27;
            this.labelVol.Text = "litara";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 258);
            this.Controls.Add(this.labelVol);
            this.Controls.Add(this.labelAlk);
            this.Controls.Add(this.labelStanje);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(slikaLabel);
            this.Controls.Add(this.slikaTextBox);
            this.Controls.Add(proizvodacLabel);
            this.Controls.Add(this.proizvodacTextBox);
            this.Controls.Add(ocjenaRBLabel);
            this.Controls.Add(this.ocjenaRBTextBox);
            this.Controls.Add(volumenLabel);
            this.Controls.Add(this.volumenTextBox);
            this.Controls.Add(udio_alkLabel);
            this.Controls.Add(this.udio_alkTextBox);
            this.Controls.Add(vrstaLabel);
            this.Controls.Add(this.vrstaTextBox);
            this.Controls.Add(drzava_podrijetlaLabel);
            this.Controls.Add(this.drzava_podrijetlaTextBox);
            this.Controls.Add(stanjeLabel);
            this.Controls.Add(this.stanjeTextBox);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(ime_pivaLabel);
            this.Controls.Add(this.ime_pivaTextBox);
            this.Controls.Add(iD_pivoLabel);
            this.Controls.Add(this.iD_pivoTextBox);
            this.Controls.Add(this.pivoBindingNavigator);
            this.Name = "FormAdd";
            this.Text = "Novi artikl";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingNavigator)).EndInit();
            this.pivoBindingNavigator.ResumeLayout(false);
            this.pivoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private T07_DBDataSet11 t07_DBDataSet11;
        private System.Windows.Forms.BindingSource pivoBindingSource;
        private T07_DBDataSet11TableAdapters.PivoTableAdapter pivoTableAdapter;
        private T07_DBDataSet11TableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox iD_pivoTextBox;
        private System.Windows.Forms.TextBox ime_pivaTextBox;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.TextBox stanjeTextBox;
        private System.Windows.Forms.TextBox drzava_podrijetlaTextBox;
        private System.Windows.Forms.TextBox vrstaTextBox;
        private System.Windows.Forms.TextBox udio_alkTextBox;
        private System.Windows.Forms.TextBox volumenTextBox;
        private System.Windows.Forms.TextBox ocjenaRBTextBox;
        private System.Windows.Forms.TextBox proizvodacTextBox;
        private System.Windows.Forms.TextBox slikaTextBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelStanje;
        private System.Windows.Forms.Label labelAlk;
        private System.Windows.Forms.Label labelVol;
    }
}