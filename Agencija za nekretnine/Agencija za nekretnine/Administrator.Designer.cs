namespace Agencija_za_nekretnine
{
    partial class Administrator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbOpstina = new System.Windows.Forms.ComboBox();
            this.tbBrojLicence = new System.Windows.Forms.TextBox();
            this.tbBrojLicne = new System.Windows.Forms.TextBox();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAgentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jMBGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojLicneKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojLicenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opstinaRadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agencija_za_nekretnineFinalni = new Agencija_za_nekretnine.Agencija_za_nekretnineFinalni();
            this.agencijazanekretnineFinalniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnIzbrsi = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.agencijazanekretnineFinalniBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agentTableAdapter = new Agencija_za_nekretnine.Agencija_za_nekretnineFinalniTableAdapters.AgentTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencija_za_nekretnineFinalni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencijazanekretnineFinalniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencijazanekretnineFinalniBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbOpstina);
            this.panel1.Controls.Add(this.tbBrojLicence);
            this.panel1.Controls.Add(this.tbBrojLicne);
            this.panel1.Controls.Add(this.tbJMBG);
            this.panel1.Controls.Add(this.tbPrezime);
            this.panel1.Controls.Add(this.tbIme);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 358);
            this.panel1.TabIndex = 0;
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
            this.cbOpstina.Location = new System.Drawing.Point(109, 306);
            this.cbOpstina.Name = "cbOpstina";
            this.cbOpstina.Size = new System.Drawing.Size(140, 21);
            this.cbOpstina.TabIndex = 52;
            this.cbOpstina.SelectedIndexChanged += new System.EventHandler(this.cbOpstina_SelectedIndexChanged);
            // 
            // tbBrojLicence
            // 
            this.tbBrojLicence.Location = new System.Drawing.Point(109, 260);
            this.tbBrojLicence.MaxLength = 10;
            this.tbBrojLicence.Name = "tbBrojLicence";
            this.tbBrojLicence.Size = new System.Drawing.Size(140, 20);
            this.tbBrojLicence.TabIndex = 13;
            this.tbBrojLicence.TextChanged += new System.EventHandler(this.tbBrojLicence_TextChanged);
            this.tbBrojLicence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBrojLicence_KeyPress);
            // 
            // tbBrojLicne
            // 
            this.tbBrojLicne.Location = new System.Drawing.Point(109, 213);
            this.tbBrojLicne.MaxLength = 9;
            this.tbBrojLicne.Name = "tbBrojLicne";
            this.tbBrojLicne.Size = new System.Drawing.Size(140, 20);
            this.tbBrojLicne.TabIndex = 12;
            this.tbBrojLicne.TextChanged += new System.EventHandler(this.tbBrojLicne_TextChanged);
            this.tbBrojLicne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBrojLicne_KeyPress);
            // 
            // tbJMBG
            // 
            this.tbJMBG.Location = new System.Drawing.Point(109, 162);
            this.tbJMBG.MaxLength = 13;
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.Size = new System.Drawing.Size(140, 20);
            this.tbJMBG.TabIndex = 11;
            this.tbJMBG.TextChanged += new System.EventHandler(this.tbJMBG_TextChanged);
            this.tbJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJMBG_KeyPress);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(109, 113);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(140, 20);
            this.tbPrezime.TabIndex = 10;
            this.tbPrezime.TextChanged += new System.EventHandler(this.tbPrezime_TextChanged);
            this.tbPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrezime_KeyPress);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(109, 65);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(140, 20);
            this.tbIme.TabIndex = 9;
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Opstina rada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Broj licne karte:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broj Licence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "JMBG:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unos novog agenta";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(787, 485);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(111, 46);
            this.btnOdustani.TabIndex = 16;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Enabled = false;
            this.btnPotvrdi.Location = new System.Drawing.Point(13, 485);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(111, 46);
            this.btnPotvrdi.TabIndex = 15;
            this.btnPotvrdi.Text = "Unesi Agenta";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAgentaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.jMBGDataGridViewTextBoxColumn,
            this.brojLicneKarteDataGridViewTextBoxColumn,
            this.brojLicenceDataGridViewTextBoxColumn,
            this.opstinaRadaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(322, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 358);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // idAgentaDataGridViewTextBoxColumn
            // 
            this.idAgentaDataGridViewTextBoxColumn.DataPropertyName = "IdAgenta";
            this.idAgentaDataGridViewTextBoxColumn.HeaderText = "IdAgenta";
            this.idAgentaDataGridViewTextBoxColumn.Name = "idAgentaDataGridViewTextBoxColumn";
            this.idAgentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // jMBGDataGridViewTextBoxColumn
            // 
            this.jMBGDataGridViewTextBoxColumn.DataPropertyName = "JMBG";
            this.jMBGDataGridViewTextBoxColumn.HeaderText = "JMBG";
            this.jMBGDataGridViewTextBoxColumn.Name = "jMBGDataGridViewTextBoxColumn";
            // 
            // brojLicneKarteDataGridViewTextBoxColumn
            // 
            this.brojLicneKarteDataGridViewTextBoxColumn.DataPropertyName = "BrojLicneKarte";
            this.brojLicneKarteDataGridViewTextBoxColumn.HeaderText = "BrojLicneKarte";
            this.brojLicneKarteDataGridViewTextBoxColumn.Name = "brojLicneKarteDataGridViewTextBoxColumn";
            // 
            // brojLicenceDataGridViewTextBoxColumn
            // 
            this.brojLicenceDataGridViewTextBoxColumn.DataPropertyName = "BrojLicence";
            this.brojLicenceDataGridViewTextBoxColumn.HeaderText = "BrojLicence";
            this.brojLicenceDataGridViewTextBoxColumn.Name = "brojLicenceDataGridViewTextBoxColumn";
            // 
            // opstinaRadaDataGridViewTextBoxColumn
            // 
            this.opstinaRadaDataGridViewTextBoxColumn.DataPropertyName = "OpstinaRada";
            this.opstinaRadaDataGridViewTextBoxColumn.HeaderText = "OpstinaRada";
            this.opstinaRadaDataGridViewTextBoxColumn.Name = "opstinaRadaDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Agent";
            this.bindingSource1.DataSource = this.agencija_za_nekretnineFinalni;
            // 
            // agencija_za_nekretnineFinalni
            // 
            this.agencija_za_nekretnineFinalni.DataSetName = "Agencija_za_nekretnineFinalni";
            this.agencija_za_nekretnineFinalni.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agencijazanekretnineFinalniBindingSource
            // 
            this.agencijazanekretnineFinalniBindingSource.DataSource = this.agencija_za_nekretnineFinalni;
            this.agencijazanekretnineFinalniBindingSource.Position = 0;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(343, 485);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(111, 46);
            this.btnAzuriraj.TabIndex = 17;
            this.btnAzuriraj.Text = "Azuriraj Agenta";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnIzbrsi
            // 
            this.btnIzbrsi.Location = new System.Drawing.Point(485, 485);
            this.btnIzbrsi.Name = "btnIzbrsi";
            this.btnIzbrsi.Size = new System.Drawing.Size(111, 46);
            this.btnIzbrsi.TabIndex = 18;
            this.btnIzbrsi.Text = "Izbrsi Agenta";
            this.btnIzbrsi.UseVisualStyleBackColor = true;
            this.btnIzbrsi.Click += new System.EventHandler(this.btnIzbrsi_Click);
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(646, 485);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(111, 46);
            this.btnResetuj.TabIndex = 19;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(173, 485);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(111, 46);
            this.btnPrikazi.TabIndex = 20;
            this.btnPrikazi.Text = "Prikazi Agente";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // agencijazanekretnineFinalniBindingSource1
            // 
            this.agencijazanekretnineFinalniBindingSource1.DataSource = this.agencija_za_nekretnineFinalni;
            this.agencijazanekretnineFinalniBindingSource1.Position = 0;
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 578);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.btnIzbrsi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPotvrdi);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencija_za_nekretnineFinalni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencijazanekretnineFinalniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencijazanekretnineFinalniBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.TextBox tbBrojLicence;
        private System.Windows.Forms.TextBox tbBrojLicne;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOpstina;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource agencijazanekretnineFinalniBindingSource;
        private Agencija_za_nekretnineFinalni agencija_za_nekretnineFinalni;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnIzbrsi;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.BindingSource agencijazanekretnineFinalniBindingSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Agencija_za_nekretnineFinalniTableAdapters.AgentTableAdapter agentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAgentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jMBGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojLicneKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojLicenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opstinaRadaDataGridViewTextBoxColumn;
    }
}