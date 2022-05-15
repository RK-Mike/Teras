using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace aspTeräs
{
    public partial class teräs : System.Web.UI.Page
    {

        database db = new database();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM users WHERE UserName='" + username.Text + "' AND Password= '" + password.Text + "'", db.yhteysTiedot);
            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                info.Text = "Onnistui!";
                info.ForeColor = System.Drawing.Color.Green;
                Response.Redirect("~/adminForm.aspx");
            }
            else
            {
                info.Text = "Yrita uudelleen nulikka";
                info.ForeColor = System.Drawing.Color.Black;
            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TyoUkko.aspx");
        }
    }
}