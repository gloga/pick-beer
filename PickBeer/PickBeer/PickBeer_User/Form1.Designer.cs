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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavni_izbornik));
            this.labelNaslov = new System.Windows.Forms.Label();
            this.buttonCjenik = new System.Windows.Forms.Button();
            this.buttonOdaberi = new System.Windows.Forms.Button();
            this.buttonBR = new System.Windows.Forms.Button();
            this.groupBoxGlavni_izb = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonKosarica = new System.Windows.Forms.Button();
            this.groupBoxGlavni_izb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaslov.Location = new System.Drawing.Point(13, 13);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(123, 31);
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
            this.buttonOdaberi.Location = new System.Drawing.Point(19, 157);
            this.buttonOdaberi.Name = "buttonOdaberi";
            this.buttonOdaberi.Size = new System.Drawing.Size(117, 39);
            this.buttonOdaberi.TabIndex = 2;
            this.buttonOdaberi.Text = "Odaberi pivo";
            this.buttonOdaberi.UseVisualStyleBackColor = true;
            this.buttonOdaberi.Click += new System.EventHandler(this.buttonOdaberi_Click);
            // 
            // buttonBR
            // 
            this.buttonBR.Location = new System.Drawing.Point(19, 202);
            this.buttonBR.Name = "buttonBR";
            this.buttonBR.Size = new System.Drawing.Size(117, 39);
            this.buttonBR.TabIndex = 3;
            this.buttonBR.Text = "BeerRoulette";
            this.buttonBR.UseVisualStyleBackColor = true;
            // 
            // groupBoxGlavni_izb
            // 
            this.groupBoxGlavni_izb.Controls.Add(this.pictureBox1);
            this.groupBoxGlavni_izb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxGlavni_izb.Location = new System.Drawing.Point(197, 13);
            this.groupBoxGlavni_izb.Name = "groupBoxGlavni_izb";
            this.groupBoxGlavni_izb.Size = new System.Drawing.Size(290, 376);
            this.groupBoxGlavni_izb.TabIndex = 4;
            this.groupBoxGlavni_izb.TabStop = false;
            this.groupBoxGlavni_izb.Text = "Upute";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonKosarica
            // 
            this.buttonKosarica.Location = new System.Drawing.Point(13, 365);
            this.buttonKosarica.Name = "buttonKosarica";
            this.buttonKosarica.Size = new System.Drawing.Size(75, 23);
            this.buttonKosarica.TabIndex = 5;
            this.buttonKosarica.Text = "Košarica";
            this.buttonKosarica.UseVisualStyleBackColor = true;
            this.buttonKosarica.Click += new System.EventHandler(this.buttonKosarica_Click);
            // 
            // Glavni_izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 401);
            this.Controls.Add(this.buttonKosarica);
            this.Controls.Add(this.groupBoxGlavni_izb);
            this.Controls.Add(this.buttonBR);
            this.Controls.Add(this.buttonOdaberi);
            this.Controls.Add(this.buttonCjenik);
            this.Controls.Add(this.labelNaslov);
            this.Name = "Glavni_izbornik";
            this.Text = "Glavni izbornik";
            this.groupBoxGlavni_izb.ResumeLayout(false);
            this.groupBoxGlavni_izb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Button buttonCjenik;
        private System.Windows.Forms.Button buttonOdaberi;
        private System.Windows.Forms.Button buttonBR;
        private System.Windows.Forms.GroupBox groupBoxGlavni_izb;
        private System.Windows.Forms.Button buttonKosarica;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

