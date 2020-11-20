using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencija_za_nekretnine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(230, 184, 0);
            label2.ForeColor = Color.FromArgb(230, 184, 0);
            button1.ForeColor = Color.FromArgb(230, 184, 0);
            button2.ForeColor = Color.FromArgb(230, 184, 0);
            button3.ForeColor = Color.FromArgb(230, 184, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUnosNekretnine unos = new frmUnosNekretnine();
            if(DialogResult.OK == unos.ShowDialog())
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            if(DialogResult.OK == admin.ShowDialog())
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKupovinaNekretnine kupovina = new frmKupovinaNekretnine();
            if(DialogResult.OK == kupovina.ShowDialog())
            {

            }
        }
    }
}
