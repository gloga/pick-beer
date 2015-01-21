namespace GrimmBee___RateBeer
{
    partial class FormNedostaje
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
            this.t07_DBDataSet11 = new GrimmBee___RateBeer.T07_DBDataSet11();
            this.pivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pivoTableAdapter = new GrimmBee___RateBeer.T07_DBDataSet11TableAdapters.PivoTableAdapter();
            this.tableAdapterManager = new GrimmBee___RateBeer.T07_DBDataSet11TableAdapters.TableAdapterManager();
            this.pivoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava_podrijetla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // pivoDataGridView
            // 
            this.pivoDataGridView.AllowUserToAddRows = false;
            this.pivoDataGridView.AllowUserToDeleteRows = false;
            this.pivoDataGridView.AutoGenerateColumns = false;
            this.pivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pivoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Drzava_podrijetla});
            this.pivoDataGridView.DataSource = this.pivoBindingSource;
            this.pivoDataGridView.Location = new System.Drawing.Point(12, 12);
            this.pivoDataGridView.Name = "pivoDataGridView";
            this.pivoDataGridView.ReadOnly = true;
            this.pivoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pivoDataGridView.Size = new System.Drawing.Size(420, 522);
            this.pivoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_pivo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Šifra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime_piva";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cijena";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cijena";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Drzava_podrijetla
            // 
            this.Drzava_podrijetla.DataPropertyName = "Drzava_podrijetla";
            this.Drzava_podrijetla.HeaderText = "Drzava podrijetla";
            this.Drzava_podrijetla.Name = "Drzava_podrijetla";
            this.Drzava_podrijetla.ReadOnly = true;
            // 
            // FormNedostaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 546);
            this.Controls.Add(this.pivoDataGridView);
            this.Name = "FormNedostaje";
            this.Text = "Artikli koji nedostaju na skladištu";
            this.Load += new System.EventHandler(this.FormNedostaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private T07_DBDataSet11 t07_DBDataSet11;
        private System.Windows.Forms.BindingSource pivoBindingSource;
        private T07_DBDataSet11TableAdapters.PivoTableAdapter pivoTableAdapter;
        private T07_DBDataSet11TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pivoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava_podrijetla;
    }
}