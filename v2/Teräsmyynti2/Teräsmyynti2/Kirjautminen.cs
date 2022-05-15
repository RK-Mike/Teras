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
using MySql.Data.MySqlClient;



namespace Teräsmyynti2
{
    public partial class Kirjautminen : Form
    {

        Database database = new Database();
        public Kirjautminen()
        {
            InitializeComponent();
        }

        private void Kirjautminen_Load(object sender, EventArgs e)
        {

        }



        // Kirjautuminen nappula mika vertaa tekstikentassa olevaa salasanaa user tablessa olevaan salasanaan.
        private void button1_Click(object sender, EventArgs e)
        {
               
                database.connectDatabase();

                string login = "SELECT * FROM users WHERE Password = ('" + txtPassword.Text + "')";

                MySqlCommand cmd = new MySqlCommand(login, database.dbYhteys);
                   
                MySqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read() == true)
            {
                this.Hide();
                new Form1().Show();
            }
            else
            {
                MessageBox.Show("Vaara salasana, Yrita uudelleen!", "Kirjautuminen epaonnistui", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtPassword.Text = "";
                
            }
             
                

        }

        // Kun checkboxia painaa muuttuu normi kirjaimit * merkeiksi
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
