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
    public partial class Tyontekija : Form
    {
        
        public void Clear()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows.RemoveAt(i);
                i--;
                while (dataGridView1.Rows.Count == 0) ;
            }
        }

        Form1 form1 = new Form1();
        public Tyontekija()
        {
            form1.lol = "main";
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form1.lol = "Kuukausittaiset";
            Clear();
            form1.Import();
            Nimike.Text = form1.lol;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form1.lol = "Vuosittaiset";
            Clear();
            form1.Import();
            Nimike.Text = form1.lol;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form1.lol = "Viikottaiset";
            Clear();
            form1.Import();
            Nimike.Text = form1.lol;
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

            form1.table1.Columns.Add("Nimike", typeof(string));
            form1.table1.Columns.Add("Tiedot", typeof(string));
            form1.table1.Columns.Add("Kuittaus", typeof(string));

            form1.table1.Rows.Add(00, "Esimerkki");

            dataGridView1.DataSource = form1.table1;
            styling();
            form1.Import();

        }

        public void Tallenna()
        {
            TextWriter writer = new StreamWriter(form1.lol + ".txt");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int x = 0; x < dataGridView1.Columns.Count; x++)
                {
                    if (x == dataGridView1.Columns.Count - 1) // if last column
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[x].Value.ToString());
                    }

                    else
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[x].Value.ToString() + "\t" + "|");

                }
                writer.WriteLine("");

            }
            writer.Close();
            MessageBox.Show("Completed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tallenna();      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form1.Tulosta();
        }

    }
}
