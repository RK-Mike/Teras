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
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace Teräsmyynti2
{
    public partial class Form1 : Form
    {
        public DataTable mainTable = new DataTable();
        public string tbl1Data = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tarvittavat sarakkeet datagridiin
            sarakeLisa();

            // Lisaa esimerkki rivin datagridii
            mainTable.Rows.Add(00, "Esimerkki");

            dataGridView1.DataSource = mainTable;

            Styling();
            Import();

        }


        // Raine TEKI
        public void sarakeLisa()
        {

            tbl1Data = "Main";
            // Tarvittavat sarakkeet datagridiin
            mainTable.Columns.Add("Nimike", typeof(string));
            mainTable.Columns.Add("Tiedot", typeof(string));
            mainTable.Columns.Add("Kuittaus", typeof(string));


        }


        // Raine TEKI
        // Tekee datagridista jarkevan nakoisen
        private void Styling()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;          
            dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;

            dataGridView1.EnableHeadersVisualStyles = false;
            Nimike.Text = tbl1Data;
        }


        // Tallentaa datagridin muutokset tekstitideostoon reaaliajassa.
        // MIKAEL TEKI
        public void Tallenna()
        {
            TextWriter writer = new StreamWriter(tbl1Data + ".txt");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int x = 0; x < dataGridView1.Columns.Count; x++)
                {
                    if (x == dataGridView1.Columns.Count - 1) 
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[x].Value.ToString());
                    }
                    else
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[x].Value.ToString() + "\t" + "|");
                    }

                }
                writer.WriteLine("");

            }
            writer.Close();
            MessageBox.Show("Suoritettu onnistuneesti");
        }

        // Tallentaa valitun rivin tiedot kuittaus tekstitiedostoon.
        // MIKAEL TEKI
        public void Kuittaus()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                TextWriter kuittaus = new StreamWriter("Yhteenveto.txt", true);
                kuittaus.Write("\t" + item.Cells[0].Value.ToString());
                kuittaus.Write("\t" + item.Cells[1].Value.ToString());
                kuittaus.Write("\t" + item.Cells[2].Value.ToString());

                kuittaus.WriteLine("");
                kuittaus.Close();

                MessageBox.Show("Suoritettu onnistuneesti");
                dataGridView1.DataSource = mainTable;


            }
        }

        // RAINE TEKI
        // Cleari tyhjentaan datagridin kun uudet tiedot tulevat tekstitideostoista.
        public void Clear()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows.RemoveAt(i);

                // Poistaa Esimerkki rivin
                i--;
            }
        }


        // Mikael TEKI
        // Poistaa valitun rivin kaikki tiedot.
        public void Poista()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        // RAINE TEKI
        // Lukee ja tuo tekstitiedostoista kaikki tiedot datagridiin.
        public void Import()
        {
            try
            {
            string[] lines = File.ReadAllLines(tbl1Data + ".txt");

            string[] data;

            for (int i = 0; i < lines.Length; i++)
            {
                data = lines[i].ToString().Split('|');

                string [] row = new string[data.Length];

                for(int j = 0; j < data.Length; j++)
                {
                    row[j] = data[j].Trim();
                }

                mainTable.Rows.Add(row);
            }
            }
            catch(Exception ex)
            {
                
                MessageBox.Show("Käy tarkistamassa tekstitiedostot virheistä    ", ex.Message);
            }

        }


       
        // Lukee tekstitiedoston sisallon ja tekee siita pdf tiedoston.
        public void Tulosta()
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 16);
            PdfStringFormat format = new PdfStringFormat();
            StreamReader reader = new StreamReader(tbl1Data + ".txt", Encoding.ASCII);            
            string text = reader.ReadToEnd();


            reader.Close();
                       
            format.Alignment = PdfTextAlignment.Justify;
            format.LineAlignment = PdfVerticalAlignment.Top;
            format.ParagraphIndent = 15f;
            
            graphics.DrawString(text, font, PdfBrushes.Black, new RectangleF(new PointF(0, 0), page.GetClientSize()), format);
           
            document.Save(tbl1Data + ".pdf");
            
            document.Close(true);
            
            Process.Start(tbl1Data + ".pdf");
        }


        //Nappulat
        #region
        // Formin sisaiset toiminnot, kutsutaan kaikki voidit.

        private void kuittaaBTN_Click_1(object sender, EventArgs e)
        {
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

        private void TulostaBTN_Click(object sender, EventArgs e)
        {
            Tulosta();
        }

        private void vBTN_Click(object sender, EventArgs e)
        {
            tbl1Data = "Vuosittaiset";
            Clear();
            Import();
            Nimike.Text = tbl1Data;
        }

        private void kkBTN_Click(object sender, EventArgs e)
        {
            tbl1Data = "Kuukausittaiset";
            Clear();
            Import();
            Nimike.Text = tbl1Data;
        }

        public void vkBTN_Click(object sender, EventArgs e)
        {
            tbl1Data = "Viikottaiset";
            Clear();
            Import();
            Nimike.Text = tbl1Data;
        }

        private void yhteenvetoBTN_Click(object sender, EventArgs e)
        {
            Process.Start("yhteenveto.txt");
            Nimike.Text = "Yhteenveto";
        }
        #endregion

    }
}
