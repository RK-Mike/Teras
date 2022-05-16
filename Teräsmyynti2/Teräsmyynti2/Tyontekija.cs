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
             
            }
        }

        Form1 form1 = new Form1();
        public Tyontekija()
        {
            form1.tbl1Data = "main";
            InitializeComponent();
        }

        private void styling()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;

            dataGridView1.EnableHeadersVisualStyles = false;

            Nimike.Text = form1.tbl1Data;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            form1.mainTable.Columns.Add("Nimike", typeof(string));
            form1.mainTable.Columns.Add("Tiedot", typeof(string));
            form1.mainTable.Columns.Add("Kuittaus", typeof(string));

            form1.mainTable.Rows.Add(00, "Esimerkki");

            dataGridView1.DataSource = form1.mainTable;
            styling();
            form1.Import();

        }

        public void Tallenna()
        {
            TextWriter writer = new StreamWriter(form1.tbl1Data + ".txt");

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


        //Nappulat
        #region

        private void button1_Click(object sender, EventArgs e)
        {
            Tallenna();      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form1.Tulosta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form1.tbl1Data = "Kuukausittaiset";
            Clear();
            form1.Import();
            Nimike.Text = form1.tbl1Data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form1.tbl1Data = "Vuosittaiset";
            Clear();
            form1.Import();
            Nimike.Text = form1.tbl1Data;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form1.tbl1Data = "Viikottaiset";
            Clear();
            form1.Import();
            Nimike.Text = form1.tbl1Data;
        }
#endregion

    }
}
