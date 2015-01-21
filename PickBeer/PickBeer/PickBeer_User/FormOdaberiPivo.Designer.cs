namespace PickBeer_User
{
    partial class FormOdaberiPivo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDpivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imepivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavapodrijetlaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.udioalkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjenaRBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjenaKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putanarucivanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t07_DBDataSet = new PickBeer_User.T07_DBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.Drzava_Podrijetla2comboBox = new System.Windows.Forms.ComboBox();
            this.drzavaSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drzava_SelectTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.Drzava_SelectTableAdapter();
            this.pivoTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.PivoTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarCijena = new System.Windows.Forms.TrackBar();
            this.pivoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxVrsta = new System.Windows.Forms.ComboBox();
            this.fillByVrstaToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drzavaSelectBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpivoDataGridViewTextBoxColumn,
            this.imepivaDataGridViewTextBoxColumn,
            this.stanjeDataGridViewTextBoxColumn,
            this.drzavapodrijetlaDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn,
            this.udioalkDataGridViewTextBoxColumn,
            this.ocjenaRBDataGridViewTextBoxColumn,
            this.volumenDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.ocjenaKDataGridViewTextBoxColumn,
            this.proizvodacDataGridViewTextBoxColumn,
            this.putanarucivanoDataGridViewTextBoxColumn,
            this.slikaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pivoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(450, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(473, 533);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDpivoDataGridViewTextBoxColumn
            // 
            this.iDpivoDataGridViewTextBoxColumn.DataPropertyName = "ID_pivo";
            this.iDpivoDataGridViewTextBoxColumn.HeaderText = "ID_pivo";
            this.iDpivoDataGridViewTextBoxColumn.Name = "iDpivoDataGridViewTextBoxColumn";
            this.iDpivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDpivoDataGridViewTextBoxColumn.Visible = false;
            // 
            // imepivaDataGridViewTextBoxColumn
            // 
            this.imepivaDataGridViewTextBoxColumn.DataPropertyName = "Ime_piva";
            this.imepivaDataGridViewTextBoxColumn.HeaderText = "Naziv piva";
            this.imepivaDataGridViewTextBoxColumn.Name = "imepivaDataGridViewTextBoxColumn";
            this.imepivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stanjeDataGridViewTextBoxColumn
            // 
            this.stanjeDataGridViewTextBoxColumn.DataPropertyName = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.HeaderText = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.Name = "stanjeDataGridViewTextBoxColumn";
            this.stanjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.stanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // drzavapodrijetlaDataGridViewTextBoxColumn
            // 
            this.drzavapodrijetlaDataGridViewTextBoxColumn.DataPropertyName = "Drzava_podrijetla";
            this.drzavapodrijetlaDataGridViewTextBoxColumn.HeaderText = "Drzava_podrijetla";
            this.drzavapodrijetlaDataGridViewTextBoxColumn.Name = "drzavapodrijetlaDataGridViewTextBoxColumn";
            this.drzavapodrijetlaDataGridViewTextBoxColumn.ReadOnly = true;
            this.drzavapodrijetlaDataGridViewTextBoxColumn.Visible = false;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaDataGridViewTextBoxColumn.Visible = false;
            // 
            // udioalkDataGridViewTextBoxColumn
            // 
            this.udioalkDataGridViewTextBoxColumn.DataPropertyName = "Udio_alk";
            this.udioalkDataGridViewTextBoxColumn.HeaderText = "Udio_alk";
            this.udioalkDataGridViewTextBoxColumn.Name = "udioalkDataGridViewTextBoxColumn";
            this.udioalkDataGridViewTextBoxColumn.ReadOnly = true;
            this.udioalkDataGridViewTextBoxColumn.Visible = false;
            // 
            // ocjenaRBDataGridViewTextBoxColumn
            // 
            this.ocjenaRBDataGridViewTextBoxColumn.DataPropertyName = "OcjenaRB";
            this.ocjenaRBDataGridViewTextBoxColumn.HeaderText = "Ocjena";
            this.ocjenaRBDataGridViewTextBoxColumn.Name = "ocjenaRBDataGridViewTextBoxColumn";
            this.ocjenaRBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumenDataGridViewTextBoxColumn
            // 
            this.volumenDataGridViewTextBoxColumn.DataPropertyName = "Volumen";
            this.volumenDataGridViewTextBoxColumn.HeaderText = "Volumen";
            this.volumenDataGridViewTextBoxColumn.Name = "volumenDataGridViewTextBoxColumn";
            this.volumenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ocjenaKDataGridViewTextBoxColumn
            // 
            this.ocjenaKDataGridViewTextBoxColumn.DataPropertyName = "OcjenaK";
            this.ocjenaKDataGridViewTextBoxColumn.HeaderText = "OcjenaK";
            this.ocjenaKDataGridViewTextBoxColumn.Name = "ocjenaKDataGridViewTextBoxColumn";
            this.ocjenaKDataGridViewTextBoxColumn.ReadOnly = true;
            this.ocjenaKDataGridViewTextBoxColumn.Visible = false;
            // 
            // proizvodacDataGridViewTextBoxColumn
            // 
            this.proizvodacDataGridViewTextBoxColumn.DataPropertyName = "Proizvodac";
            this.proizvodacDataGridViewTextBoxColumn.HeaderText = "Proizvodac";
            this.proizvodacDataGridViewTextBoxColumn.Name = "proizvodacDataGridViewTextBoxColumn";
            this.proizvodacDataGridViewTextBoxColumn.ReadOnly = true;
            this.proizvodacDataGridViewTextBoxColumn.Visible = false;
            // 
            // putanarucivanoDataGridViewTextBoxColumn
            // 
            this.putanarucivanoDataGridViewTextBoxColumn.DataPropertyName = "Puta_narucivano";
            this.putanarucivanoDataGridViewTextBoxColumn.HeaderText = "Puta_narucivano";
            this.putanarucivanoDataGridViewTextBoxColumn.Name = "putanarucivanoDataGridViewTextBoxColumn";
            this.putanarucivanoDataGridViewTextBoxColumn.ReadOnly = true;
            this.putanarucivanoDataGridViewTextBoxColumn.Visible = false;
            // 
            // slikaDataGridViewTextBoxColumn
            // 
            this.slikaDataGridViewTextBoxColumn.DataPropertyName = "Slika";
            this.slikaDataGridViewTextBoxColumn.HeaderText = "Slika";
            this.slikaDataGridViewTextBoxColumn.Name = "slikaDataGridViewTextBoxColumn";
            this.slikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.slikaDataGridViewTextBoxColumn.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Država podrijetla:";
            // 
            // Drzava_Podrijetla2comboBox
            // 
            this.Drzava_Podrijetla2comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.drzavaSelectBindingSource, "Drzava_podrijetla", true));
            this.Drzava_Podrijetla2comboBox.DataSource = this.drzavaSelectBindingSource;
            this.Drzava_Podrijetla2comboBox.DisplayMember = "Drzava_podrijetla";
            this.Drzava_Podrijetla2comboBox.FormattingEnabled = true;
            this.Drzava_Podrijetla2comboBox.Location = new System.Drawing.Point(104, 23);
            this.Drzava_Podrijetla2comboBox.Name = "Drzava_Podrijetla2comboBox";
            this.Drzava_Podrijetla2comboBox.Size = new System.Drawing.Size(201, 21);
            this.Drzava_Podrijetla2comboBox.TabIndex = 3;
            this.Drzava_Podrijetla2comboBox.ValueMember = "Drzava_podrijetla";
            this.Drzava_Podrijetla2comboBox.SelectionChangeCommitted += new System.EventHandler(this.Drzava_Podrijetla2comboBox_SelectionChangeCommitted);
            // 
            // drzavaSelectBindingSource
            // 
            this.drzavaSelectBindingSource.DataMember = "Drzava_Select";
            this.drzavaSelectBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // drzava_SelectTableAdapter
            // 
            this.drzava_SelectTableAdapter.ClearBeforeFill = true;
            // 
            // pivoTableAdapter
            // 
            this.pivoTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vrsta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBarCijena);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cijena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // trackBarCijena
            // 
            this.trackBarCijena.Location = new System.Drawing.Point(15, 19);
            this.trackBarCijena.Maximum = 89;
            this.trackBarCijena.Name = "trackBarCijena";
            this.trackBarCijena.Size = new System.Drawing.Size(134, 45);
            this.trackBarCijena.TabIndex = 0;
            this.trackBarCijena.Value = 14;
            this.trackBarCijena.Scroll += new System.EventHandler(this.trackBarCijena_Scroll);
            // 
            // pivoBindingSource1
            // 
            this.pivoBindingSource1.DataMember = "Pivo";
            this.pivoBindingSource1.DataSource = this.t07_DBDataSet;
            // 
            // comboBoxVrsta
            // 
            this.comboBoxVrsta.DataSource = this.pivoBindingSource;
            this.comboBoxVrsta.DisplayMember = "Vrsta";
            this.comboBoxVrsta.FormattingEnabled = true;
            this.comboBoxVrsta.Location = new System.Drawing.Point(104, 50);
            this.comboBoxVrsta.Name = "comboBoxVrsta";
            this.comboBoxVrsta.Size = new System.Drawing.Size(201, 21);
            this.comboBoxVrsta.TabIndex = 9;
            this.comboBoxVrsta.ValueMember = "Vrsta";
            this.comboBoxVrsta.SelectionChangeCommitted += new System.EventHandler(this.comboBoxVrsta_SelectionChangeCommitted);
            // 
            // fillByVrstaToolStripButton
            // 
            this.fillByVrstaToolStripButton.Name = "fillByVrstaToolStripButton";
            this.fillByVrstaToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // FormOdaberiPivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 565);
            this.Controls.Add(this.comboBoxVrsta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Drzava_Podrijetla2comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormOdaberiPivo";
            this.Text = "Odaberi pivo";
            this.Load += new System.EventHandler(this.FormOdaberiPivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drzavaSelectBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Drzava_Podrijetla2comboBox;
        private T07_DBDataSet t07_DBDataSet;
        private System.Windows.Forms.BindingSource drzavaSelectBindingSource;
        private T07_DBDataSetTableAdapters.Drzava_SelectTableAdapter drzava_SelectTableAdapter;
        private System.Windows.Forms.BindingSource pivoBindingSource;
        private T07_DBDataSetTableAdapters.PivoTableAdapter pivoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imepivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavapodrijetlaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn udioalkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaRBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn putanarucivanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarCijena;
        private System.Windows.Forms.BindingSource pivoBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxVrsta;
        private System.Windows.Forms.ToolStripButton fillByVrstaToolStripButton;
    }
}