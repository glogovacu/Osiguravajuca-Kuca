namespace OsiguravajucaKuca.Forms
{
    partial class FormAgent
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
            this.dataKorisnici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZakaziSastanak = new System.Windows.Forms.Button();
            this.dateSastanka = new System.Windows.Forms.DateTimePicker();
            this.dataSastanci = new System.Windows.Forms.DataGridView();
            this.dataPlacanja = new System.Windows.Forms.DataGridView();
            this.dataStete = new System.Windows.Forms.DataGridView();
            this.numPolje = new System.Windows.Forms.NumericUpDown();
            this.cmbPolise = new System.Windows.Forms.ComboBox();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataKorisniciSvi = new System.Windows.Forms.DataGridView();
            this.dataUgovori = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFiltrirajKorisnika = new System.Windows.Forms.TextBox();
            this.btnPremija = new System.Windows.Forms.Button();
            this.btnSteta = new System.Windows.Forms.Button();
            this.btnUpisiDatumStete = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDatumPlacanja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSastanci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlacanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKorisniciSvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUgovori)).BeginInit();
            this.SuspendLayout();
            // 
            // dataKorisnici
            // 
            this.dataKorisnici.AllowUserToAddRows = false;
            this.dataKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKorisnici.Location = new System.Drawing.Point(17, 87);
            this.dataKorisnici.Name = "dataKorisnici";
            this.dataKorisnici.Size = new System.Drawing.Size(302, 194);
            this.dataKorisnici.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista korisnika koji su zakazali";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista Sastanaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista Placanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(937, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lista Stete";
            // 
            // btnZakaziSastanak
            // 
            this.btnZakaziSastanak.Location = new System.Drawing.Point(223, 313);
            this.btnZakaziSastanak.Name = "btnZakaziSastanak";
            this.btnZakaziSastanak.Size = new System.Drawing.Size(96, 23);
            this.btnZakaziSastanak.TabIndex = 9;
            this.btnZakaziSastanak.Text = "Zakazi Sastanak";
            this.btnZakaziSastanak.UseVisualStyleBackColor = true;
            this.btnZakaziSastanak.Click += new System.EventHandler(this.btnZakaziSastanak_Click);
            // 
            // dateSastanka
            // 
            this.dateSastanka.Location = new System.Drawing.Point(17, 316);
            this.dateSastanka.Name = "dateSastanka";
            this.dateSastanka.Size = new System.Drawing.Size(200, 20);
            this.dateSastanka.TabIndex = 10;
            // 
            // dataSastanci
            // 
            this.dataSastanci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSastanci.Location = new System.Drawing.Point(325, 87);
            this.dataSastanci.Name = "dataSastanci";
            this.dataSastanci.Size = new System.Drawing.Size(302, 194);
            this.dataSastanci.TabIndex = 11;
            // 
            // dataPlacanja
            // 
            this.dataPlacanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPlacanja.Location = new System.Drawing.Point(633, 87);
            this.dataPlacanja.Name = "dataPlacanja";
            this.dataPlacanja.Size = new System.Drawing.Size(302, 194);
            this.dataPlacanja.TabIndex = 12;
            // 
            // dataStete
            // 
            this.dataStete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStete.Location = new System.Drawing.Point(941, 87);
            this.dataStete.Name = "dataStete";
            this.dataStete.Size = new System.Drawing.Size(302, 194);
            this.dataStete.TabIndex = 13;
            // 
            // numPolje
            // 
            this.numPolje.DecimalPlaces = 2;
            this.numPolje.Location = new System.Drawing.Point(93, 429);
            this.numPolje.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numPolje.Name = "numPolje";
            this.numPolje.Size = new System.Drawing.Size(120, 20);
            this.numPolje.TabIndex = 14;
            // 
            // cmbPolise
            // 
            this.cmbPolise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPolise.FormattingEnabled = true;
            this.cmbPolise.Location = new System.Drawing.Point(92, 402);
            this.cmbPolise.Name = "cmbPolise";
            this.cmbPolise.Size = new System.Drawing.Size(121, 21);
            this.cmbPolise.TabIndex = 17;
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.Location = new System.Drawing.Point(17, 22);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(185, 25);
            this.lblDobrodosli.TabIndex = 18;
            this.lblDobrodosli.Text = "Dobordosli pa ime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Upisi Ugovor";
            // 
            // dataKorisniciSvi
            // 
            this.dataKorisniciSvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKorisniciSvi.Location = new System.Drawing.Point(633, 342);
            this.dataKorisniciSvi.Name = "dataKorisniciSvi";
            this.dataKorisniciSvi.Size = new System.Drawing.Size(302, 273);
            this.dataKorisniciSvi.TabIndex = 20;
            // 
            // dataUgovori
            // 
            this.dataUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUgovori.Location = new System.Drawing.Point(941, 342);
            this.dataUgovori.Name = "dataUgovori";
            this.dataUgovori.Size = new System.Drawing.Size(302, 273);
            this.dataUgovori.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(629, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Lista Korisnika";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(937, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Lista Ugovora";
            // 
            // txtFiltrirajKorisnika
            // 
            this.txtFiltrirajKorisnika.Location = new System.Drawing.Point(787, 313);
            this.txtFiltrirajKorisnika.Name = "txtFiltrirajKorisnika";
            this.txtFiltrirajKorisnika.Size = new System.Drawing.Size(144, 20);
            this.txtFiltrirajKorisnika.TabIndex = 24;
            this.txtFiltrirajKorisnika.TextChanged += new System.EventHandler(this.txtFiltrirajKorisnika_TextChanged);
            // 
            // btnPremija
            // 
            this.btnPremija.Location = new System.Drawing.Point(75, 455);
            this.btnPremija.Name = "btnPremija";
            this.btnPremija.Size = new System.Drawing.Size(75, 23);
            this.btnPremija.TabIndex = 26;
            this.btnPremija.Text = "Premija";
            this.btnPremija.UseVisualStyleBackColor = true;
            this.btnPremija.Click += new System.EventHandler(this.btnPremija_Click_1);
            // 
            // btnSteta
            // 
            this.btnSteta.Location = new System.Drawing.Point(156, 455);
            this.btnSteta.Name = "btnSteta";
            this.btnSteta.Size = new System.Drawing.Size(75, 23);
            this.btnSteta.TabIndex = 27;
            this.btnSteta.Text = "Steta";
            this.btnSteta.UseVisualStyleBackColor = true;
            this.btnSteta.Click += new System.EventHandler(this.btnSteta_Click_1);
            // 
            // btnUpisiDatumStete
            // 
            this.btnUpisiDatumStete.Location = new System.Drawing.Point(176, 592);
            this.btnUpisiDatumStete.Name = "btnUpisiDatumStete";
            this.btnUpisiDatumStete.Size = new System.Drawing.Size(163, 23);
            this.btnUpisiDatumStete.TabIndex = 28;
            this.btnUpisiDatumStete.Text = "Upisi datum isplate stete";
            this.btnUpisiDatumStete.UseVisualStyleBackColor = true;
            this.btnUpisiDatumStete.Click += new System.EventHandler(this.btnUpisiDatum_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 566);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Upisivanje datuma za placanje i stetu";
            // 
            // btnDatumPlacanja
            // 
            this.btnDatumPlacanja.Location = new System.Drawing.Point(7, 592);
            this.btnDatumPlacanja.Name = "btnDatumPlacanja";
            this.btnDatumPlacanja.Size = new System.Drawing.Size(163, 23);
            this.btnDatumPlacanja.TabIndex = 31;
            this.btnDatumPlacanja.Text = "Upisi datum placanja";
            this.btnDatumPlacanja.UseVisualStyleBackColor = true;
            this.btnDatumPlacanja.Click += new System.EventHandler(this.btnDatumPlacanja_Click);
            // 
            // FormAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 653);
            this.Controls.Add(this.btnDatumPlacanja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnUpisiDatumStete);
            this.Controls.Add(this.btnSteta);
            this.Controls.Add(this.btnPremija);
            this.Controls.Add(this.txtFiltrirajKorisnika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataUgovori);
            this.Controls.Add(this.dataKorisniciSvi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.cmbPolise);
            this.Controls.Add(this.numPolje);
            this.Controls.Add(this.dataStete);
            this.Controls.Add(this.dataPlacanja);
            this.Controls.Add(this.dataSastanci);
            this.Controls.Add(this.dateSastanka);
            this.Controls.Add(this.btnZakaziSastanak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataKorisnici);
            this.Name = "FormAgent";
            this.Text = "FormAgent";
            this.Load += new System.EventHandler(this.FormAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSastanci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlacanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKorisniciSvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUgovori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnZakaziSastanak;
        private System.Windows.Forms.DateTimePicker dateSastanka;
        private System.Windows.Forms.DataGridView dataSastanci;
        private System.Windows.Forms.DataGridView dataPlacanja;
        private System.Windows.Forms.DataGridView dataStete;
        private System.Windows.Forms.NumericUpDown numPolje;
        private System.Windows.Forms.ComboBox cmbPolise;
        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataKorisniciSvi;
        private System.Windows.Forms.DataGridView dataUgovori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFiltrirajKorisnika;
        private System.Windows.Forms.Button btnPremija;
        private System.Windows.Forms.Button btnSteta;
        private System.Windows.Forms.Button btnUpisiDatumStete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDatumPlacanja;
    }
}