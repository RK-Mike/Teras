using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace aspTeräs
{
    public partial class TyoUkko : System.Web.UI.Page
    {

        database db = new database();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = "gridi";
                FillGrid();
            }

            db.connectDatabase();
        }

        private void FillGrid()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM " + Label1.Text, db.dbYhteys);

            dataAdapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                GridView1.DataSource = table;
                GridView1.DataBind();

            }
            else
            {
                table.Rows.Add(table.NewRow());
                GridView1.DataSource = table;
                GridView1.DataBind();
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = table.Columns.Count;
                GridView1.Rows[0].Cells[0].Text = "No Data Found ..!";
                GridView1.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("AddNew"))
                {
                    string query = "INSERT INTO " + Label1.Text + "(Nimike,Tiedot) VALUES (@Nimike, @Tiedot)";
                    MySqlCommand sqlCmd = new MySqlCommand(query, db.dbYhteys);

                    sqlCmd.Parameters.AddWithValue("@Nimike", (GridView1.FooterRow.FindControl("txtNimikeFooter") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Tiedot", (GridView1.FooterRow.FindControl("txtTiedotFooter") as TextBox).Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    FillGrid();

                    lblSuccessMessage.Text = "New Record Added";
                    lblErrorMessage.Text = "";

                }
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;

            }

        }

        protected void Button9_Click(object sender, EventArgs e)
        {

            Label1.Text = "gridi";
            FillGrid();

            //Clear();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Label1.Text = "gridi2";

            FillGrid();
            //Clear();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Label1.Text = "gridi3";
            //Clear();
            FillGrid();
        }
    }
}