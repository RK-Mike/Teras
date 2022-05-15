using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace aspTeräs
{
    public class database
    {

        public string yhteysTiedot;
        public MySqlConnection dbYhteys = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=webteras;Allow User Variables=True");
        MySqlCommand cmd = new MySqlCommand();

        public database()
        {
            yhteysTiedot = "datasource=localhost;port=3306;username=root;password=;database=webteras";
        }



        public void connectDatabase()
        {
            dbYhteys.Open();
        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();

        }



    }
}