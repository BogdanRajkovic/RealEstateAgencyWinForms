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
    public partial class frmUnosNekretnine : Form
    {
        string pom = "";

        public frmUnosNekretnine()
        {
            InitializeComponent();
        }

       private void resetuj()
        {
            tbIme.Clear();
            tbPrezime.Clear();
            tbJMBG.Clear();
            tbMail.Clear();
            tbAdresaProdavca.Clear();
            tbAdresa.Clear();
            tbSprat.Clear();
            tbPovrsina.Clear();
            tbCena.Clear();
            tbSpratnost.Clear();
            tbSprat.Clear();
            tbNapomena.Clear();
            cbNamestenost.SelectedIndex = 0;
            cbVrsta.SelectedIndex = 0;
            cbStruktura.SelectedIndex = 0;
            cbStanje.SelectedIndex = 0;
            cbOpstina.SelectedIndex = 0;
            foreach(CheckBox cb in groupBox1.Controls)
            {
                cb.Checked = false;
            }
        }
        
        void setButton()
        {
            btnPotvrdi.Enabled = (tbIme.Text != "" && tbPrezime.Text != "" && tbJMBG.Text !="" && tbTelefon.Text != "" && tbAdresa.Text !="" && tbMail.Text != "" && tbAdresa.Text != "" && tbSpratnost.Text != "" && tbPovrsina.Text != "" && tbCena.Text != "" && tbSprat.Text != "" && cbNamestenost.Text != "" && cbVrsta.Text != "" && cbStruktura.Text != "" && cbStanje.Text != "" && cbOpstina.Text != "");
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jel ste sigurni da zelite da izadjete?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                resetuj();
                this.Close();
            }
            else { }
        }
        public void samoSlova(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        public void samoBrojevi(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        private void tbMail_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }
        private void tbAdresaKupca_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbAdresa_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbSpratnost_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbPovrsina_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbCena_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void cbNamestenost_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void cbVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void cbStruktura_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void cbStanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbSprat_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void cbOpstina_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija1 = new SqlConnection(Konekcija.konekcija);
            try
            {
                SqlCommand komandaProdavac = new SqlCommand("INSERT INTO Prodavac(Ime, Prezime, JMBG, Telefon, Adresa, Mail) VALUES (@Ime, @Prezime, @JMBG, @Telefon, @Adresa, @Mail)", konekcija1);
                komandaProdavac.Parameters.AddWithValue("@Ime",tbIme.Text);
                komandaProdavac.Parameters.AddWithValue("@Prezime",tbPrezime.Text);
                komandaProdavac.Parameters.AddWithValue("@JMBG",tbJMBG.Text);
                komandaProdavac.Parameters.AddWithValue("@Telefon",tbTelefon.Text);
                komandaProdavac.Parameters.AddWithValue("@Adresa",tbAdresa.Text);
                komandaProdavac.Parameters.AddWithValue("@Mail",tbMail.Text);
                konekcija1.Open();
                komandaProdavac.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija1.Close();
            }
            foreach (CheckBox cb in groupBox1.Controls)
                if (cb.Checked)
                {
                    pom += cb.Text + "; ";
                }
            SqlConnection konekcija = new SqlConnection(Konekcija.konekcija);
            try {
            SqlCommand komand1 = new SqlCommand("SELECT IdAgenta FROM Agent WHERE OpstinaRada='"+cbOpstina.Text+ "'", konekcija);
            SqlCommand komand2 = new SqlCommand("SELECT IdProdavac from Prodavac WHERE Adresa = '"+tbAdresa.Text+"'", konekcija);
            konekcija.Open();
            int idAgenta = Convert.ToInt32(komand1.ExecuteScalar());
            int idProdavac = Convert.ToInt32(komand2.ExecuteScalar()); 
            SqlCommand komand = new SqlCommand("INSERT INTO Nekretnina (Adresa, Spratnost, Povrsina, Cena, Namestenost, VrstaNekretnine, Struktura, Stanje, Sprat, Opstina, DodatneKarakteristike, Napomena, IdAgenta,idProdavca) VALUES (@Adresa, @Spratnost, @Povrsina, @Cena, @Namestenost, @VrstaNekretnine, @Struktura, @Stanje, @Sprat, @Opstina,@DodatneKarakteristike,@Napomena, @IdAgenta,@idProdavac);", konekcija);
            komand.Parameters.AddWithValue("@Adresa", tbAdresa.Text);
            komand.Parameters.AddWithValue("@Spratnost", tbSpratnost.Text);
            komand.Parameters.AddWithValue("@Povrsina", tbPovrsina.Text);
            komand.Parameters.AddWithValue("@Cena", tbCena.Text);
            komand.Parameters.AddWithValue("@Namestenost", cbNamestenost.Text);
            komand.Parameters.AddWithValue("@VrstaNekretnine", cbVrsta.Text);
            komand.Parameters.AddWithValue("@Struktura", cbStruktura.Text);
            komand.Parameters.AddWithValue("@Stanje", cbStanje.Text);
            komand.Parameters.AddWithValue("@Sprat", tbSprat.Text);
            komand.Parameters.AddWithValue("@Opstina", cbOpstina.Text);
            komand.Parameters.AddWithValue("@DodatneKarakteristike", pom);
            komand.Parameters.AddWithValue("@Napomena", tbNapomena.Text);
            komand.Parameters.AddWithValue("@IdAgenta", idAgenta);
            komand.Parameters.AddWithValue("@IdProdavac", idProdavac);
            
                
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
            pom = "";
            MessageBox.Show("Uspesno ste uneli podatke.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tbSpratnost_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbPovrsina_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbSprat_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
