using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teräsmyynti2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }


        // Button clicking avulle piilotetaan Login formi ja siirrytään Kirjautuminen formiin
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kirjautminen kirjaudu = new Kirjautminen();
            kirjaudu.Closed += (s, args) => this.Close();
            kirjaudu.Show();
        }

        // Button clicking avulle piilotetaan Login formi ja siirrytään Tyontekija formiin
        private void button2_Click(object sender, EventArgs e)
        {

            Tyontekija tyoukkoForm = new Tyontekija();
            this.Hide();
            tyoukkoForm.ShowDialog();
            this.Close();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

 }
