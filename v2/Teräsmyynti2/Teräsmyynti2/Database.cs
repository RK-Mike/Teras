using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Teräsmyynti2
{
    internal class Database
    {
        public string yhteysTiedot;
        public MySqlConnection dbYhteys = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=teras2");
        

        public MySqlCommand cmd = new MySqlCommand();

        public Database()
        {
            yhteysTiedot = "datasource=localhost;port=3306;username=root;password=;database=teras2";
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
