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
    public partial class Tyontekija : Form
    {
       

        Form1 form1 = new Form1();
        Database db = new Database();

        public Tyontekija()
        {
            form1.lol = "main";
            InitializeComponent();
        }


        private void styling()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;

            dataGridView1.EnableHeadersVisualStyles = false;

            Nimike.Text = form1.lol;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Yhteys databaseen
            db.connectDatabase();

            form1.sarakeLisa();

            dataGridView1.DataSource = form1.table1;
            styling();

        }

        public void Tallenna()
        {
            form1.Cleari();

            dataGridView1.AllowUserToAddRows = false;


            db.disconnectDatabase();
            db.connectDatabase();


            string Tallenna = "INSERT INTO " + form1.lol + "(Nimike,Tiedot,Kuittaus) VALUES (@Nimike, @Tiedot, @Kuittaus)";

            MySqlCommand cmd = new MySqlCommand(Tallenna, db.dbYhteys);


            cmd.Parameters.Add(new MySqlParameter("@Nimike", MySqlDbType.VarString));
            cmd.Parameters.Add(new MySqlParameter("@Tiedot", MySqlDbType.VarString));
            cmd.Parameters.Add(new MySqlParameter("@Kuittaus", MySqlDbType.VarString));

            db.disconnectDatabase();


            foreach (DataGridViewRow item in dataGridView1.Rows)
            {

                cmd.Parameters["@Nimike"].Value = item.Cells["Nimike"].Value;
                cmd.Parameters["@Tiedot"].Value = item.Cells["Tiedot"].Value;
                cmd.Parameters["@Kuittaus"].Value = item.Cells["Kuittaus"].Value;


                db.connectDatabase();
                cmd.ExecuteNonQuery();
                db.disconnectDatabase();

                dataGridView1.DataSource = form1.table1;


            }

            MessageBox.Show("Tallenettu");
            dataGridView1.AllowUserToAddRows = true;
        }












        // BUTTONEITA

        private void button1_Click(object sender, EventArgs e)
        {
            Tallenna();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            form1.table1.Clear();


            form1.lol = "gridi2";

            form1.FillGrid();

            Nimike.Text = form1.lol;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form1.table1.Clear();

            form1.lol = "gridi3";
            form1.FillGrid();

            Nimike.Text = form1.lol;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form1.table1.Clear();

            form1.lol = "gridi";
            form1.FillGrid();

            Nimike.Text = form1.lol;
        }


    }
}
