using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Agencija_za_nekretnine
{
    public partial class frmKupovinaNekretnine : Form
    {
        public frmKupovinaNekretnine()
        {
            InitializeComponent();
        }
        public void samoSlova(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        public void samoBrojevi(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
         void setButton()
        {
            btnSacuvajKupca.Enabled = tbIme.Text != "" && tbPrezime.Text != "" && tbJMBG.Text != "" && tbTelefon.Text != "" && tbAdresaKupca.Text != "" && tbMail.Text != ""; 
        }
        void setButtonZahtev()
        {
            btnSacuvaj.Enabled = cbOpstina.Text != "";
        }
        void resetuj()
        {
            cbOpstina.SelectedIndex = 0;
            tbCena.Clear();
            tbPovrsina.Clear();
            cbStruktura.SelectedIndex = 0; 
            tbIme.Clear();
            tbPrezime.Clear();
            tbJMBG.Clear();
            tbTelefon.Clear();
            tbAdresaKupca.Clear();
            tbMail.Clear();
        }
        void popuniPodatke()
        {
            SqlConnection konekcija = new SqlConnection(Konekcija.konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Opstina, Adresa, Spratnost, Povrsina, Cena, Namestenost, VrstaNekretnine, Struktura, Stanje, Sprat,  DodatneKarakteristike, Napomena FROM Nekretnina", konekcija);
            DataTable tabel = new DataTable();
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;
        }
        void selektujCenu()
        {
            SqlConnection konekcija = new SqlConnection(Konekcija.konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Opstina, Adresa, Spratnost, Povrsina, Cena, Namestenost, VrstaNekretnine, Struktura, Stanje, Sprat,  DodatneKarakteristike, Napomena FROM Nekretnina ORDER BY Cena", konekcija);
            DataTable tabel = new DataTable();
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;

        }
        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoSlova(e);
        }

        private void tbPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoSlova(e);
        }

        private void tbJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbKvadratura_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbStruktura_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbPrezime_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbJMBG_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbTelefon_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbAdresaKupca_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbMail_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = new SqlConnection(Konekcija.konekcija);
            SqlCommand komand = new SqlCommand("INSERT INTO Kupac(Ime, Prezime, JMBG, Telefon, Mail ) VALUES (@Ime, @Prezime, @JMBG, @Telefon, @Mail)", konekcija);
            komand.Parameters.AddWithValue("@Ime", tbIme.Text);
            komand.Parameters.AddWithValue("@Prezime", tbPrezime.Text);
            komand.Parameters.AddWithValue("@JMBG", tbJMBG.Text);
            komand.Parameters.AddWithValue("@Telefon", tbTelefon.Text);
            komand.Parameters.AddWithValue("@Mail", tbMail.Text);
            try
            {
                konekcija.Open();
                komand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            MessageBox.Show("Uspesno ste sacuvali svoje podatke!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetuj();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Jel ste sigurni da zelite da zatvorite prozor?","Pitanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                resetuj();
            }
        }

        private void cbOpstina_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButtonZahtev();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = new SqlConnection(Konekcija.konekcija);
            try
            {
                SqlCommand komand1 = new SqlCommand("SELECT IdAgenta FROM Agent WHERE OpstinaRada='" + cbOpstina.Text + "'", konekcija);
                SqlCommand komand2 = new SqlCommand("SELECT MAX (IdKupac)from Kupac", konekcija);
                konekcija.Open();
                int idAgenta = Convert.ToInt32(komand1.ExecuteScalar());
                int idProdavac = Convert.ToInt32(komand2.ExecuteScalar());
                SqlCommand komand = new SqlCommand("INSERT INTO  Zahtev(Opstina,Cena,Povrsina, Struktura, IdAgenta, IdKupca) VALUES (@Opstina, @Cena, @Povrsina, @Struktura, @IdAgenta, @IdKupca)", konekcija);
                komand.Parameters.AddWithValue("@Opstina", cbOpstina.Text);
                komand.Parameters.AddWithValue("@Cena", tbCena.Text);
                komand.Parameters.AddWithValue("@Povrsina", tbPovrsina.Text);
                komand.Parameters.AddWithValue("@Struktura", cbStruktura.Text);
                komand.Parameters.AddWithValue("@IdAgenta",idAgenta);
                komand.Parameters.AddWithValue("@IdKupca",idProdavac);

                komand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            MessageBox.Show("Uspesno ste sacuvali svoje podatke!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetuj();
        }

        private void frmKupovinaNekretnine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agencija_za_nekretnineFinalni.Nekretnina' table. You can move, or remove it, as needed.
            this.nekretninaTableAdapter1.Fill(this.agencija_za_nekretnineFinalni.Nekretnina);
            // TODO: This line of code loads data into the 'agencija_za_nekretnineDataSet.Nekretnina' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            popuniPodatke();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            selektujCenu();
        }

        
    }
}
