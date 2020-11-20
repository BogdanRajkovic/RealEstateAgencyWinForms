namespace Agencija_za_nekretnine
{
    partial class frmKupovinaNekretnine
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSacuvajKupca = new System.Windows.Forms.Button();
            this.tbAdresaKupca = new System.Windows.Forms.TextBox();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStruktura = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.tbPovrsina = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbOpstina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nekretninaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agencija_za_nekretnineFinalni = new Agencija_za_nekretnine.Agencija_za_nekretnineFinalni();
            this.btnPrikazNekretnine = new System.Windows.Forms.Button();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nekretninaTableAdapter1 = new Agencija_za_nekretnine.Agencija_za_nekretnineFinalniTableAdapters.NekretninaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agencijazanekretnineFinalniBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nekretninaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencija_za_nekretnineFinalni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencijazanekretnineFinalniBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.btnSacuvajKupca);
            this.panel2.Controls.Add(this.tbAdresaKupca);
            this.panel2.Controls.Add(this.tbJMBG);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.tbPrezime);
            this.panel2.Controls.Add(this.tbTelefon);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbMail);
            this.panel2.Controls.Add(this.tbIme);
            this.panel2.Location = new System.Drawing.Point(15, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 276);
            this.panel2.TabIndex = 73;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 75;
            this.label19.Text = "Adresa";
            // 
            // btnSacuvajKupca
            // 
            this.btnSacuvajKupca.Enabled = false;
            this.btnSacuvajKupca.Location = new System.Drawing.Point(76, 210);
            this.btnSacuvajKupca.Name = "btnSacuvajKupca";
            this.btnSacuvajKupca.Size = new System.Drawing.Size(125, 48);
            this.btnSacuvajKupca.TabIndex = 7;
            this.btnSacuvajKupca.Text = "Sacuvaj kupca";
            this.btnSacuvajKupca.UseVisualStyleBackColor = true;
            this.btnSacuvajKupca.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // tbAdresaKupca
            // 
            this.tbAdresaKupca.Location = new System.Drawing.Point(76, 137);
            this.tbAdresaKupca.Name = "tbAdresaKupca";
            this.tbAdresaKupca.Size = new System.Drawing.Size(126, 20);
            this.tbAdresaKupca.TabIndex = 5;
            this.tbAdresaKupca.TextChanged += new System.EventHandler(this.tbAdresaKupca_TextChanged);
            // 
            // tbJMBG
            // 
            this.tbJMBG.Location = new System.Drawing.Point(76, 77);
            this.tbJMBG.MaxLength = 13;
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.Size = new System.Drawing.Size(126, 20);
            this.tbJMBG.TabIndex = 3;
            this.tbJMBG.TextChanged += new System.EventHandler(this.tbJMBG_TextChanged);
            this.tbJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJMBG_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 72;
            this.label18.Text = "JMBG";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(76, 42);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(126, 20);
            this.tbPrezime.TabIndex = 2;
            this.tbPrezime.TextChanged += new System.EventHandler(this.tbPrezime_TextChanged);
            this.tbPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrezime_KeyPress);
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(76, 104);
            this.tbTelefon.MaxLength = 12;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(126, 20);
            this.tbTelefon.TabIndex = 4;
            this.tbTelefon.TextChanged += new System.EventHandler(this.tbTelefon_TextChanged);
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Ime";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 71;
            this.label17.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "E-mail";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(76, 171);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(196, 20);
            this.tbMail.TabIndex = 6;
            this.tbMail.TextChanged += new System.EventHandler(this.tbMail_TextChanged);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(76, 13);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(126, 20);
            this.tbIme.TabIndex = 1;
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStruktura);
            this.panel1.Controls.Add(this.btnSacuvaj);
            this.panel1.Controls.Add(this.tbPovrsina);
            this.panel1.Controls.Add(this.tbCena);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbOpstina);
            this.panel1.Location = new System.Drawing.Point(360, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 276);
            this.panel1.TabIndex = 74;
            // 
            // cbStruktura
            // 
            this.cbStruktura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStruktura.FormattingEnabled = true;
            this.cbStruktura.Items.AddRange(new object[] {
            "Garsonjera",
            "Jednosoban",
            "Jednoiposoban",
            "Dvosoban",
            "Dvoiposoban",
            "Trosoban",
            "Troiposoban",
            "Cetvorosoban i veci"});
            this.cbStruktura.Location = new System.Drawing.Point(96, 165);
            this.cbStruktura.Name = "cbStruktura";
            this.cbStruktura.Size = new System.Drawing.Size(121, 21);
            this.cbStruktura.TabIndex = 78;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Enabled = false;
            this.btnSacuvaj.Location = new System.Drawing.Point(50, 210);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(125, 48);
            this.btnSacuvaj.TabIndex = 79;
            this.btnSacuvaj.Text = "Sacuvaj zahtev";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // tbPovrsina
            // 
            this.tbPovrsina.Location = new System.Drawing.Point(96, 117);
            this.tbPovrsina.Name = "tbPovrsina";
            this.tbPovrsina.Size = new System.Drawing.Size(121, 20);
            this.tbPovrsina.TabIndex = 6;
            this.tbPovrsina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKvadratura_KeyPress);
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(96, 69);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(121, 20);
            this.tbCena.TabIndex = 5;
            this.tbCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCena_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Struktura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Povrsina";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Opstina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cena";
            // 
            // cbOpstina
            // 
            this.cbOpstina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpstina.FormattingEnabled = true;
            this.cbOpstina.Items.AddRange(new object[] {
            "Cukarica",
            "Novi Beograd",
            "Palilula",
            "Rakovica",
            "Savski venac",
            "Stari grad",
            "Vozdovac",
            "Vracar",
            "Zemun",
            "Zvezdara",
            "Barajevo",
            "Grocka",
            "Lazarevac",
            "Mladenovac",
            "Obrenovac",
            "Sopot",
            "Surcin"});
            this.cbOpstina.Location = new System.Drawing.Point(96, 16);
            this.cbOpstina.Name = "cbOpstina";
            this.cbOpstina.Size = new System.Drawing.Size(121, 21);
            this.cbOpstina.TabIndex = 0;
            this.cbOpstina.SelectedIndexChanged += new System.EventHandler(this.cbOpstina_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Podaci o kupcu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 76;
            // 
            // nekretninaBindingSource
            // 
            this.nekretninaBindingSource.DataMember = "Nekretnina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Zahtev";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(621, 49);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 48);
            this.btnOdustani.TabIndex = 80;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Nekretnina";
            this.bindingSource1.DataSource = this.agencija_za_nekretnineFinalni;
            // 
            // agencija_za_nekretnineFinalni
            // 
            this.agencija_za_nekretnineFinalni.DataSetName = "Agencija_za_nekretnineFinalni";
            this.agencija_za_nekretnineFinalni.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrikazNekretnine
            // 
            this.btnPrikazNekretnine.Location = new System.Drawing.Point(621, 362);
            this.btnPrikazNekretnine.Name = "btnPrikazNekretnine";
            this.btnPrikazNekretnine.Size = new System.Drawing.Size(125, 48);
            this.btnPrikazNekretnine.TabIndex = 81;
            this.btnPrikazNekretnine.Text = "Prikazi nekretnine";
            this.btnPrikazNekretnine.UseVisualStyleBackColor = true;
            this.btnPrikazNekretnine.Click += new System.EventHandler(this.button1_Click);
            // 
            // nekretninaTableAdapter1
            // 
            this.nekretninaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(577, 265);
            this.dataGridView1.TabIndex = 82;
            // 
            // agencijazanekretnineFinalniBindingSource2
            // 
            this.agencijazanekretnineFinalniBindingSource2.DataSource = this.agencija_za_nekretnineFinalni;
            this.agencijazanekretnineFinalniBindingSource2.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 48);
            this.button1.TabIndex = 83;
            this.button1.Text = "Sortiraj po ceni (Min->Max)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmKupovinaNekretnine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrikazNekretnine);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmKupovinaNekretnine";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.frmKupovinaNekretnine_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nekretninaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencija_za_nekretnineFinalni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencijazanekretnineFinalniBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSacuvajKupca;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbAdresaKupca;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOpstina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox tbPovrsina;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cbStruktura;
        private System.Windows.Forms.Button btnPrikazNekretnine;
        private System.Windows.Forms.BindingSource nekretninaBindingSource;
        private System.Windows.Forms.BindingSource bindingSource2;
        private Agencija_za_nekretnineFinalni agencija_za_nekretnineFinalni;
        private Agencija_za_nekretnineFinalniTableAdapters.NekretninaTableAdapter nekretninaTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource agencijazanekretnineFinalniBindingSource2;
    }
}