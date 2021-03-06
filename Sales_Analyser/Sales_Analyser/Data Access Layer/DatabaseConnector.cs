using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net;

namespace Modern_UI
{
    /*
     * Class to create the cnnection to the database
     * This class is created using singleton design pattern
     */
    class DatabaseConnector
    {
        //string contains the database configuration
        //private string myString = "Server=localhost;Database=sales_analyser;Uid=root;Pwd=;";
        private string myString = "Server=db4free.net;Database=sales_analyser;Uid=dmmnissanka;Pwd=dinindu;";
        //private string myString = "Server=mysql.hostinger.co.uk;Database=u373391967_sep;Uid=u373391967_sep;Pwd=Dinindu;";
        
        private static DatabaseConnector con_instance;
        private MySqlConnection con;
        private DatabaseConnector() {
            con = new MySqlConnection(myString);
        }

        public static DatabaseConnector getDatabaseConnector(){
            if (con_instance == null) 
            {
                con_instance = new DatabaseConnector();
            }
            return con_instance;
        }

        //method to return the database connection
        public MySqlConnection getConnection() {
            if (con == null) 
            {
                Console.WriteLine("Connection is null");
            }
            return con;
        }
    }
}
