namespace PickBeer_User
{
    partial class FormRulet
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
            System.Windows.Forms.Label volumenLabel;
            System.Windows.Forms.Label slikaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRulet));
            this.random_DrzavaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.random_DrzavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.random_DrzavaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.drzava_podrijetlaTextBox = new System.Windows.Forms.TextBox();
            this.ime_pivaTextBox = new System.Windows.Forms.TextBox();
            this.pivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.volumenTextBox = new System.Windows.Forms.TextBox();
            this.slikaTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.random_DrzavaTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.Random_DrzavaTableAdapter();
            this.tableAdapterManager = new PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager();
            this.pivoTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.PivoTableAdapter();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.iD_pivoTextBox = new System.Windows.Forms.TextBox();
            drzava_podrijetlaLabel = new System.Windows.Forms.Label();
            ime_pivaLabel = new System.Windows.Forms.Label();
            cijenaLabel = new System.Windows.Forms.Label();
            volumenLabel = new System.Windows.Forms.Label();
            slikaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.random_DrzavaBindingNavigator)).BeginInit();
            this.random_DrzavaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.random_DrzavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drzava_podrijetlaLabel
            // 
            drzava_podrijetlaLabel.AutoSize = true;
            drzava_podrijetlaLabel.Location = new System.Drawing.Point(18, 37);
            drzava_podrijetlaLabel.Name = "drzava_podrijetlaLabel";
            drzava_podrijetlaLabel.Size = new System.Drawing.Size(89, 13);
            drzava_podrijetlaLabel.TabIndex = 1;
            drzava_podrijetlaLabel.Text = "Država podrijetla:";
            // 
            // ime_pivaLabel
            // 
            ime_pivaLabel.AutoSize = true;
            ime_pivaLabel.Location = new System.Drawing.Point(334, 37);
            ime_pivaLabel.Name = "ime_pivaLabel";
            ime_pivaLabel.Size = new System.Drawing.Size(50, 13);
            ime_pivaLabel.TabIndex = 3;
            ime_pivaLabel.Text = "Ime piva:";
            // 
            // cijenaLabel
            // 
            cijenaLabel.AutoSize = true;
            cijenaLabel.Location = new System.Drawing.Point(334, 93);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 5;
            cijenaLabel.Text = "Cijena:";
            // 
            // volumenLabel
            // 
            volumenLabel.AutoSize = true;
            volumenLabel.Location = new System.Drawing.Point(334, 146);
            volumenLabel.Name = "volumenLabel";
            volumenLabel.Size = new System.Drawing.Size(51, 13);
            volumenLabel.TabIndex = 7;
            volumenLabel.Text = "Volumen:";
            // 
            // slikaLabel
            // 
            slikaLabel.AutoSize = true;
            slikaLabel.Location = new System.Drawing.Point(615, 272);
            slikaLabel.Name = "slikaLabel";
            slikaLabel.Size = new System.Drawing.Size(33, 13);
            slikaLabel.TabIndex = 9;
            slikaLabel.Text = "Slika:";
            // 
            // random_DrzavaBindingNavigator
            // 
            this.random_DrzavaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.random_DrzavaBindingNavigator.BindingSource = this.random_DrzavaBindingSource;
            this.random_DrzavaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.random_DrzavaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.random_DrzavaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.random_DrzavaBindingNavigatorSaveItem});
            this.random_DrzavaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.random_DrzavaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.random_DrzavaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.random_DrzavaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.random_DrzavaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.random_DrzavaBindingNavigator.Name = "random_DrzavaBindingNavigator";
            this.random_DrzavaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.random_DrzavaBindingNavigator.Size = new System.Drawing.Size(809, 25);
            this.random_DrzavaBindingNavigator.TabIndex = 0;
            this.random_DrzavaBindingNavigator.Text = "bindingNavigator1";
            this.random_DrzavaBindingNavigator.UseWaitCursor = true;
            this.random_DrzavaBindingNavigator.Visible = false;
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
            // random_DrzavaBindingSource
            // 
            this.random_DrzavaBindingSource.DataMember = "Random_Drzava";
            this.random_DrzavaBindingSource.DataSource = this.t07_DBDataSet;
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
            // random_DrzavaBindingNavigatorSaveItem
            // 
            this.random_DrzavaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.random_DrzavaBindingNavigatorSaveItem.Enabled = false;
            this.random_DrzavaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("random_DrzavaBindingNavigatorSaveItem.Image")));
            this.random_DrzavaBindingNavigatorSaveItem.Name = "random_DrzavaBindingNavigatorSaveItem";
            this.random_DrzavaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.random_DrzavaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // drzava_podrijetlaTextBox
            // 
            this.drzava_podrijetlaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.random_DrzavaBindingSource, "Drzava_podrijetla", true));
            this.drzava_podrijetlaTextBox.Location = new System.Drawing.Point(21, 53);
            this.drzava_podrijetlaTextBox.Name = "drzava_podrijetlaTextBox";
            this.drzava_podrijetlaTextBox.ReadOnly = true;
            this.drzava_podrijetlaTextBox.Size = new System.Drawing.Size(100, 20);
            this.drzava_podrijetlaTextBox.TabIndex = 2;
            // 
            // ime_pivaTextBox
            // 
            this.ime_pivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Ime_piva", true));
            this.ime_pivaTextBox.Location = new System.Drawing.Point(337, 53);
            this.ime_pivaTextBox.Name = "ime_pivaTextBox";
            this.ime_pivaTextBox.ReadOnly = true;
            this.ime_pivaTextBox.Size = new System.Drawing.Size(205, 20);
            this.ime_pivaTextBox.TabIndex = 4;
            // 
            // pivoBindingSource
            // 
            this.pivoBindingSource.DataMember = "Pivo";
            this.pivoBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Cijena", true));
            this.cijenaTextBox.Location = new System.Drawing.Point(337, 109);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.ReadOnly = true;
            this.cijenaTextBox.Size = new System.Drawing.Size(48, 20);
            this.cijenaTextBox.TabIndex = 6;
            // 
            // volumenTextBox
            // 
            this.volumenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Volumen", true));
            this.volumenTextBox.Location = new System.Drawing.Point(337, 162);
            this.volumenTextBox.Name = "volumenTextBox";
            this.volumenTextBox.ReadOnly = true;
            this.volumenTextBox.Size = new System.Drawing.Size(48, 20);
            this.volumenTextBox.TabIndex = 8;
            // 
            // slikaTextBox
            // 
            this.slikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "Slika", true));
            this.slikaTextBox.Location = new System.Drawing.Point(654, 269);
            this.slikaTextBox.Name = "slikaTextBox";
            this.slikaTextBox.Size = new System.Drawing.Size(100, 20);
            this.slikaTextBox.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(589, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(21, 146);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(170, 67);
            this.btnPokreni.TabIndex = 12;
            this.btnPokreni.Text = "Pokreni";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // random_DrzavaTableAdapter
            // 
            this.random_DrzavaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.KosaricaTableAdapter = null;
            this.tableAdapterManager.PivoTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavke_kosaricaTableAdapter = null;
            this.tableAdapterManager.Stavke_racunTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pivoTableAdapter
            // 
            this.pivoTableAdapter.ClearBeforeFill = true;
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(21, 261);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(170, 67);
            this.btnNaruci.TabIndex = 13;
            this.btnNaruci.Text = "Dodaj u košaricu";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // iD_pivoTextBox
            // 
            this.iD_pivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pivoBindingSource, "ID_pivo", true));
            this.iD_pivoTextBox.Location = new System.Drawing.Point(643, 285);
            this.iD_pivoTextBox.Name = "iD_pivoTextBox";
            this.iD_pivoTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_pivoTextBox.TabIndex = 15;
            // 
            // FormRulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 348);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iD_pivoTextBox);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(slikaLabel);
            this.Controls.Add(this.slikaTextBox);
            this.Controls.Add(volumenLabel);
            this.Controls.Add(this.volumenTextBox);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(ime_pivaLabel);
            this.Controls.Add(this.ime_pivaTextBox);
            this.Controls.Add(drzava_podrijetlaLabel);
            this.Controls.Add(this.drzava_podrijetlaTextBox);
            this.Controls.Add(this.random_DrzavaBindingNavigator);
            this.Name = "FormRulet";
            this.Text = "BeerRoulette";
            ((System.ComponentModel.ISupportInitialize)(this.random_DrzavaBindingNavigator)).EndInit();
            this.random_DrzavaBindingNavigator.ResumeLayout(false);
            this.random_DrzavaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.random_DrzavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private T07_DBDataSet t07_DBDataSet;
        private System.Windows.Forms.BindingSource random_DrzavaBindingSource;
        private T07_DBDataSetTableAdapters.Random_DrzavaTableAdapter random_DrzavaTableAdapter;
        private T07_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator random_DrzavaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton random_DrzavaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox drzava_podrijetlaTextBox;
        private System.Windows.Forms.BindingSource pivoBindingSource;
        private T07_DBDataSetTableAdapters.PivoTableAdapter pivoTableAdapter;
        private System.Windows.Forms.TextBox ime_pivaTextBox;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.TextBox volumenTextBox;
        private System.Windows.Forms.TextBox slikaTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.TextBox iD_pivoTextBox;
    }
}