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
using System.Drawing.Printing;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace Teräsmyynti2
{
    public partial class Form1 : Form
    {
        public DataTable table1 = new DataTable();
        public string lol = "";
        Database db = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
            //Yhteys databaseen
            db.connectDatabase();

            // Tarvittavat sarakkeet datagridiin
            sarakeLisa();

            //FillGrid();
            dataGridView1.DataSource = table1;

            Styling();
           
        }

        public void sarakeLisa()
        {

            lol = "gridi";

            // Tarvittavat sarakkeet datagridiin, datasourcen avulla
            table1.Columns.Add("id", typeof(Int64));
            table1.Columns.Add("Nimike", typeof(string));
            table1.Columns.Add("Tiedot", typeof(string));
            table1.Columns.Add("Kuittaus", typeof(string));

        }


        // Tekee datagridista jarkevan nakoisen
        private void Styling()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;

            dataGridView1.EnableHeadersVisualStyles = false;

            Nimike.Text = lol;
        }

        //Tayttaa datagridviewin
        public void FillGrid()
        {
            // Valitsee kaikki databasesta
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM " + lol, db.dbYhteys);

            // Tayttaa table1 tiedon databasesta tulleella tiedolla
            dataAdapter.Fill(table1);

        }

        // Poistaa kaiken kyseisesta databasen tablesta
        public void Cleari()
        {
            db.disconnectDatabase();
            db.connectDatabase();
            string Cleari = "DELETE FROM " + lol;
            MySqlCommand cmd = new MySqlCommand(Cleari, db.dbYhteys);
            cmd.ExecuteNonQuery();

        }


        // Tallentaa asiat databasen tableihin
        public void Tallenna()
        {
            Cleari();

            // Poistaa tallenuksesta viimeisen tyhjan rivin.
            dataGridView1.AllowUserToAddRows = false;


            db.disconnectDatabase();
            db.connectDatabase();


            string Tallenna = "INSERT INTO " + lol + "(Nimike,Tiedot,Kuittaus) VALUES (@Nimike, @Tiedot, @Kuittaus)";

            MySqlCommand cmd = new MySqlCommand(Tallenna, db.dbYhteys);


            cmd.Parameters.Add(new MySqlParameter("@Nimike", MySqlDbType.VarString));
            cmd.Parameters.Add(new MySqlParameter("@Tiedot", MySqlDbType.VarString));
            cmd.Parameters.Add(new MySqlParameter("@Kuittaus", MySqlDbType.VarString));

            db.disconnectDatabase();

            // Valitsee jokaisen datagridviewin "itemin" ja asettaa niille parameterit joilla niitä voi hakea mysql queryssä
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {

                cmd.Parameters["@Nimike"].Value = item.Cells["Nimike"].Value;
                cmd.Parameters["@Tiedot"].Value = item.Cells["Tiedot"].Value;
                cmd.Parameters["@Kuittaus"].Value = item.Cells["Kuittaus"].Value;


                db.connectDatabase();
                cmd.ExecuteNonQuery();
                db.disconnectDatabase();


                dataGridView1.DataSource = table1;


            }
            MessageBox.Show("Tallenettu");

            
            dataGridView1.AllowUserToAddRows = true;

        }


        // Tallentaa valitun rivin tiedot kuittaus tekstitiedostoon.
        public void Kuittaus()
        {
            db.disconnectDatabase();
            db.connectDatabase();


            string kuittaus = "INSERT INTO " + lol + "(Nimike,Tiedot,Kuittaus) VALUES (@Nimike, @Tiedot, @Kuittaus)";

            MySqlCommand cmd = new MySqlCommand(kuittaus, db.dbYhteys);


            cmd.Parameters.Add(new MySqlParameter("@Nimike", MySqlDbType.VarString));
            cmd.Parameters.Add(new MySqlParameter("@Tiedot", MySqlDbType.VarString));
            cmd.Parameters.Add(new MySqlParameter("@Kuittaus", MySqlDbType.VarString));

            db.disconnectDatabase();

            

            // Asettaa  valitun rivin toiseen tableen databasessa
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                cmd.Parameters["@Nimike"].Value = item.Cells["Nimike"].Value;
                cmd.Parameters["@Tiedot"].Value = item.Cells["Tiedot"].Value;
                cmd.Parameters["@Kuittaus"].Value = item.Cells["Kuittaus"].Value;


                db.connectDatabase();
                cmd.ExecuteNonQuery();
                db.disconnectDatabase();


                dataGridView1.DataSource = table1;

            }

            MessageBox.Show("Onnistuneesti siiretty claps");
        }

        

        // Poistaa valitun rivin kaikki tiedot jossa id on sama.
        public void Poista()
        {
            db.disconnectDatabase();


            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            string Poista = "Delete FROM " + lol + " WHERE id='" + id + "'";

            MySqlCommand cmd = new MySqlCommand(Poista, db.dbYhteys);

            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            db.connectDatabase();
            cmd.ExecuteNonQuery();



            MessageBox.Show("Poistettu");
        }




        // PDF TULOSTUS
        #region 


        public void txtpdf()
        {
            TextWriter writer = new StreamWriter(lol + ".txt");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int x = 0; x < dataGridView1.Columns.Count; x++)
                {
                    if (x == dataGridView1.Columns.Count - 1) // Jos viimeneinen sarake
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[x].Value.ToString());
                    }

                    else
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[x].Value.ToString() + "\t" + "|");

                }
                writer.WriteLine("");

            }
            writer.Close();
            MessageBox.Show("Suoritettu onnistuneesti");
        }

        public void Tulosta()
        {

            txtpdf();
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 16);
            PdfStringFormat format = new PdfStringFormat();
            StreamReader reader = new StreamReader(lol + ".txt", Encoding.ASCII);
            string text = reader.ReadToEnd();


            reader.Close();

            format.Alignment = PdfTextAlignment.Justify;
            format.LineAlignment = PdfVerticalAlignment.Top;
            format.ParagraphIndent = 15f;

            graphics.DrawString(text, font, PdfBrushes.Black, new RectangleF(new PointF(0, 0), page.GetClientSize()), format);

            document.Save(lol + ".pdf");

            document.Close(true);

            Process.Start(lol + ".pdf");
        }




        #endregion

        //Nappulat

        #region
        // Formin sisaiset toiminnot, kutsutaan kaikki voidit.


        private void kuittaaBTN_Click_1(object sender, EventArgs e)
        {
            lol = "yhteenveto";

            Kuittaus();

        }

        private void poistaBTN_Click(object sender, EventArgs e)
        {
            Poista();
        }

        private void tallennaBTN_Click(object sender, EventArgs e)
        {
            Tallenna();
        }

        private void vBTN_Click(object sender, EventArgs e)
        {
            table1.Clear();
            lol = "gridi3";

            FillGrid();
            Nimike.Text = lol;
        }

        private void kkBTN_Click(object sender, EventArgs e)
        {

            table1.Clear();

            lol = "gridi2";

            FillGrid();

            Nimike.Text = lol;
        }

        public void vkBTN_Click(object sender, EventArgs e)
        {

            table1.Clear();

            lol = "gridi";

            FillGrid();

            Nimike.Text = lol;
        }

        private void yhteenvetoBTN_Click(object sender, EventArgs e)
        {

            table1.Clear();

            lol = "yhteenveto";

            FillGrid();

            Nimike.Text = lol;
        }

        private void TulostaBTN_Click(object sender, EventArgs e)
        {
            Tulosta();
        }
        #endregion

    }
}
