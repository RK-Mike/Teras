using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Teräsmyynti2
{
    public partial class Kirjautminen : Form
    {
        public Kirjautminen()
        {
            InitializeComponent();
        }

        private void Kirjautminen_Load(object sender, EventArgs e)
        {

        }


        // Mikael TEKI TAMAN
        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtPassword.Text == "admin123"))
            {
                using (StreamWriter Lukija = new StreamWriter("salis.txt"))
                {
                    Lukija.WriteLine(txtPassword.Text);
                }
                // Ettei softa jaa pyorimaan taustalle
                Form1 kirjaudu = new Form1();
                this.Hide();
                kirjaudu.ShowDialog();
                this.Close();
            
            }
            else
            {
                MessageBox.Show("Salasana on väärä, Yritä uudelleen!", "Kirjautuminen epäonnistui", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
