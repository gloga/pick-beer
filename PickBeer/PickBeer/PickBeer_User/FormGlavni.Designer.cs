namespace PickBeer_User
{
    partial class Glavni_izbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavni_izbornik));
            this.labelNaslov = new System.Windows.Forms.Label();
            this.buttonCjenik = new System.Windows.Forms.Button();
            this.buttonOdaberi = new System.Windows.Forms.Button();
            this.buttonBR = new System.Windows.Forms.Button();
            this.buttonKosarica = new System.Windows.Forms.Button();
            this.t07_DBDataSet = new PickBeer_User.T07_DBDataSet();
            this.kosaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kosaricaTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.KosaricaTableAdapter();
            this.tableAdapterManager = new PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager();
            this.mAX_ID_KosaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAX_ID_KosaricaTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.MAX_ID_KosaricaTableAdapter();
            this.ZadnjaNarudba = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAX_ID_KosaricaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.BackColor = System.Drawing.Color.Transparent;
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaslov.Location = new System.Drawing.Point(13, 13);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(131, 31);
            this.labelNaslov.TabIndex = 0;
            this.labelNaslov.Text = "PickBeer";
            // 
            // buttonCjenik
            // 
            this.buttonCjenik.Location = new System.Drawing.Point(19, 112);
            this.buttonCjenik.Name = "buttonCjenik";
            this.buttonCjenik.Size = new System.Drawing.Size(117, 39);
            this.buttonCjenik.TabIndex = 1;
            this.buttonCjenik.Text = "Cjenik";
            this.buttonCjenik.UseVisualStyleBackColor = true;
            this.buttonCjenik.Click += new System.EventHandler(this.buttonCjenik_Click);
            // 
            // buttonOdaberi
            // 
            this.buttonOdaberi.Location = new System.Drawing.Point(227, 202);
            this.buttonOdaberi.Name = "buttonOdaberi";
            this.buttonOdaberi.Size = new System.Drawing.Size(117, 39);
            this.buttonOdaberi.TabIndex = 2;
            this.buttonOdaberi.Text = "Odaberi pivo";
            this.buttonOdaberi.UseVisualStyleBackColor = true;
            this.buttonOdaberi.Visible = false;
            // 
            // buttonBR
            // 
            this.buttonBR.Location = new System.Drawing.Point(227, 112);
            this.buttonBR.Name = "buttonBR";
            this.buttonBR.Size = new System.Drawing.Size(117, 39);
            this.buttonBR.TabIndex = 3;
            this.buttonBR.Text = "BeerRoulette";
            this.buttonBR.UseVisualStyleBackColor = true;
            this.buttonBR.Click += new System.EventHandler(this.buttonBR_Click);
            // 
            // buttonKosarica
            // 
            this.buttonKosarica.Location = new System.Drawing.Point(19, 285);
            this.buttonKosarica.Name = "buttonKosarica";
            this.buttonKosarica.Size = new System.Drawing.Size(117, 39);
            this.buttonKosarica.TabIndex = 5;
            this.buttonKosarica.Text = "Košarica";
            this.buttonKosarica.UseVisualStyleBackColor = true;
            this.buttonKosarica.Click += new System.EventHandler(this.buttonKosarica_Click);
            // 
            // t07_DBDataSet
            // 
            this.t07_DBDataSet.DataSetName = "T07_DBDataSet";
            this.t07_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KosaricaTableAdapter = this.kosaricaTableAdapter;
            this.tableAdapterManager.PivoTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavke_kosaricaTableAdapter = null;
            this.tableAdapterManager.Stavke_racunTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mAX_ID_KosaricaBindingSource
            // 
            this.mAX_ID_KosaricaBindingSource.DataMember = "MAX ID_Kosarica";
            this.mAX_ID_KosaricaBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // mAX_ID_KosaricaTableAdapter
            // 
            this.mAX_ID_KosaricaTableAdapter.ClearBeforeFill = true;
            // 
            // ZadnjaNarudba
            // 
            this.ZadnjaNarudba.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAX_ID_KosaricaBindingSource, "Expr1", true));
            this.ZadnjaNarudba.Location = new System.Drawing.Point(25, 298);
            this.ZadnjaNarudba.Name = "ZadnjaNarudba";
            this.ZadnjaNarudba.Size = new System.Drawing.Size(100, 23);
            this.ZadnjaNarudba.TabIndex = 7;
            this.ZadnjaNarudba.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pritisnite F1 za pomoć";
            // 
            // Glavni_izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 335);
            this.Controls.Add(this.buttonKosarica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZadnjaNarudba);
            this.Controls.Add(this.buttonBR);
            this.Controls.Add(this.buttonOdaberi);
            this.Controls.Add(this.buttonCjenik);
            this.Controls.Add(this.labelNaslov);
            this.KeyPreview = true;
            this.Name = "Glavni_izbornik";
            this.Text = "Glavni izbornik";
            this.Load += new System.EventHandler(this.Glavni_izbornik_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Glavni_izbornik_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAX_ID_KosaricaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Button buttonCjenik;
        private System.Windows.Forms.Button buttonOdaberi;
        private System.Windows.Forms.Button buttonBR;
        private System.Windows.Forms.Button buttonKosarica;
        private T07_DBDataSet t07_DBDataSet;
        private System.Windows.Forms.BindingSource kosaricaBindingSource;
        private T07_DBDataSetTableAdapters.KosaricaTableAdapter kosaricaTableAdapter;
        private T07_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource mAX_ID_KosaricaBindingSource;
        private T07_DBDataSetTableAdapters.MAX_ID_KosaricaTableAdapter mAX_ID_KosaricaTableAdapter;
        private System.Windows.Forms.Label ZadnjaNarudba;
        private System.Windows.Forms.Label label1;
    }
}

