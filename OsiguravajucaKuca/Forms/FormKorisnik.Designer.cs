namespace OsiguravajucaKuca.Forms
{
    partial class FormKorisnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.btnSteta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbSastanak = new System.Windows.Forms.ComboBox();
            this.cmbSteta = new System.Windows.Forms.ComboBox();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ovde mozete videti svoje polise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ako imate problem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zelite sastanak?";
            // 
            // btnZakazi
            // 
            this.btnZakazi.Location = new System.Drawing.Point(612, 148);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(137, 50);
            this.btnZakazi.TabIndex = 3;
            this.btnZakazi.Text = "Zakazite Odmah!";
            this.btnZakazi.UseVisualStyleBackColor = true;
            this.btnZakazi.Click += new System.EventHandler(this.btnZakazi_Click);
            // 
            // btnSteta
            // 
            this.btnSteta.Location = new System.Drawing.Point(612, 287);
            this.btnSteta.Name = "btnSteta";
            this.btnSteta.Size = new System.Drawing.Size(137, 50);
            this.btnSteta.TabIndex = 4;
            this.btnSteta.Text = "Prijavite Stetu";
            this.btnSteta.UseVisualStyleBackColor = true;
            this.btnSteta.Click += new System.EventHandler(this.btnSteta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 239);
            this.dataGridView1.TabIndex = 5;
            // 
            // cmbSastanak
            // 
            this.cmbSastanak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSastanak.FormattingEnabled = true;
            this.cmbSastanak.Items.AddRange(new object[] {
            "telefonski",
            "uzivo"});
            this.cmbSastanak.Location = new System.Drawing.Point(612, 121);
            this.cmbSastanak.Name = "cmbSastanak";
            this.cmbSastanak.Size = new System.Drawing.Size(137, 21);
            this.cmbSastanak.TabIndex = 6;
            // 
            // cmbSteta
            // 
            this.cmbSteta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSteta.FormattingEnabled = true;
            this.cmbSteta.Items.AddRange(new object[] {
            "telefonski",
            "uzivo"});
            this.cmbSteta.Location = new System.Drawing.Point(612, 260);
            this.cmbSteta.Name = "cmbSteta";
            this.cmbSteta.Size = new System.Drawing.Size(137, 21);
            this.cmbSteta.TabIndex = 7;
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.Location = new System.Drawing.Point(39, 19);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(191, 25);
            this.lblDobrodosli.TabIndex = 8;
            this.lblDobrodosli.Text = "Dobrodosli, pa ime";
            // 
            // FormKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.cmbSteta);
            this.Controls.Add(this.cmbSastanak);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSteta);
            this.Controls.Add(this.btnZakazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKorisnik";
            this.Text = "Korisnik";
            this.Load += new System.EventHandler(this.FormKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZakazi;
        private System.Windows.Forms.Button btnSteta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbSastanak;
        private System.Windows.Forms.ComboBox cmbSteta;
        private System.Windows.Forms.Label lblDobrodosli;
    }
}