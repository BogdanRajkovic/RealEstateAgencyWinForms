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
    public partial class Administrator : Form
    {
        
        public Administrator()
        {
            InitializeComponent();
        }
        int ID = 0;
        void resetuj()
        {

            tbIme.Clear();
            tbPrezime.Clear();
            tbJMBG.Clear();
            tbBrojLicne.Clear();
            tbBrojLicence.Clear();
            cbOpstina.SelectedIndex = 0;
        }
        void setButton()
        {
            btnPotvrdi.Enabled = (tbIme.Text != "" && tbPrezime.Text != "" && tbJMBG.Text != "" && tbBrojLicne.Text != "" && tbBrojLicence.Text != "" && cbOpstina.Text != "");
        }
        void prikaziAgente()
        {
            SqlConnection konekcija = new SqlConnection(Konekcija.konekcija);
            try
            {

                konekcija.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Agent", konekcija);
                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                dataGridView1.DataSource = tabel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();

            }
        }
       
        private void samoSlova(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void samoBrojevi(KeyPressEventArgs e)
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

        private void tbBrojLicne_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbBrojLicence_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void tbOpstina_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = new SqlConnection(Konekcija.konekcija);
            SqlCommand komand = new SqlCommand("INSERT INTO Agent(Ime, Prezime, JMBG, BrojLicneKarte, BrojLicence, OpstinaRada) VALUES (@Ime, @Prezime, @JMBG, @BrojLicneKarte, @BrojLicence, @OpstinaRada)", konekcija);
            komand.Parameters.AddWithValue("@Ime",tbIme.Text);
            komand.Parameters.AddWithValue("@Prezime", tbPrezime.Text);
            komand.Parameters.AddWithValue("@JMBG", tbJMBG.Text);
            komand.Parameters.AddWithValue("@BrojLicneKarte", tbBrojLicne.Text);
            komand.Parameters.AddWithValue("@BrojLicence", tbBrojLicence.Text);
            komand.Parameters.AddWithValue("@OpstinaRada", cbOpstina.Text);
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
                prikaziAgente();
                resetuj();
            }
            MessageBox.Show("Uspesno ste uneli novog agenta", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jel ste sigurni da zelite da zatvorite prozor?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                resetuj();
            }
        }

        private void tbBrojAgenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbBrojLicne_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbBrojLicence_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoBrojevi(e);
        }

        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoSlova(e);
        }

        private void tbPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoSlova(e);
        }

        private void tbOpstina_KeyPress(object sender, KeyPressEventArgs e)
        {
            samoSlova(e);
        }

        private void cbOpstina_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            resetuj();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if(tbIme.Text !="" && tbPrezime.Text != "" && tbJMBG.Text != "" && tbBrojLicne.Text != "" && tbBrojLicence.Text != "" && cbOpstina.Text != "")
            {
                SqlConnection konekcija = new SqlConnection(Konekcija.konekcija);
                SqlCommand komand = new SqlCommand("UPDATE Agent SET Ime =@Ime, Prezime = @Prezime, JMBG = @JMBG, BrojLicneKarte = @BrojLicneKarte, BrojLicence = @BrojLicence, OpstinaRada = @OpstinaRada WHERE IdAgenta=@IdAgenta", konekcija);
                komand.Parameters.AddWithValue("@IdAgenta",ID );
                komand.Parameters.AddWithValue("@Ime", tbIme.Text);
                komand.Parameters.AddWithValue("@Prezime", tbPrezime.Text);
                komand.Parameters.AddWithValue("@JMBG", tbJMBG.Text);
                komand.Parameters.AddWithValue("@BrojLicneKarte", tbBrojLicne.Text);
                komand.Parameters.AddWithValue("@BrojLicence", tbBrojLicence.Text);
                komand.Parameters.AddWithValue("@OpstinaRada", cbOpstina.Text);
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
                    prikaziAgente();
                    resetuj();
                }

            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            prikaziAgente();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbIme.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbPrezime.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbJMBG.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbBrojLicne.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbBrojLicence.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbOpstina.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnIzbrsi_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                SqlConnection konekcija = new SqlConnection(Konekcija.konekcija);
                SqlCommand komand = new SqlCommand("DELETE Agent WHERE IdAgenta=@IdAgenta", konekcija);
                try
                {
                    konekcija.Open();
                    komand.Parameters.AddWithValue("@IdAgenta", ID);
                    komand.ExecuteNonQuery();
                    
                    MessageBox.Show("Uspesno Izbrisan Agent!");
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    konekcija.Close();
                    prikaziAgente();
                }
                
            }
            else
            {
                MessageBox.Show("Izaberite agenta kojeg zelite da izbrisete");
            }

        }
    }
}
