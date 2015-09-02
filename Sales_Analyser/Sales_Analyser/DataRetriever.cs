using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modern_UI
{
    class DataRetriever
    {
        private static string region_string = "SELECT * FROM REGION";
        private DatabaseConnector db_connector;
        private MySqlConnection con;
        private MySqlCommand cmd;
        private DateTime date;

        public DataRetriever() {
            db_connector = DatabaseConnector.getDatabaseConnector();
        }

        public DataSet getAllCountries() {
            this.con = db_connector.getConnection();
            try
            {
                this.cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM country";
                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                DataSet ds = new DataSet();


                this.con.Open();
                adap.Fill(ds);
                con.Close();

                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally {
                con.Close();
            }
            return null;
        }

        private string GetDBString(string SqlFieldName, MySqlDataReader Reader)
        {
            return Reader[SqlFieldName].Equals(DBNull.Value) ? String.Empty : Reader.GetString(SqlFieldName);
        }

        public DataSet getRegionData(int region_id)
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "SELECT sales_id,unit_price,quantity,total_income,date_of_sale FROM sales NATURAL JOIN sales_region WHERE region_id = @value";
            
            cmd.Parameters.AddWithValue("@value",region_id);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet ds = new DataSet();

            this.con.Open();
            adap.Fill(ds);
            con.Close();

            return ds;
        }

        public DataSet getRegionsOfCountry(int num) 
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM region WHERE country_id = @value";
            //MySqlDataReader reader = cmd.ExecuteReader();
            //reader.Close();
            //return reader;
            cmd.Parameters.AddWithValue("@value", num);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet ds = new DataSet();

            this.con.Open();
            adap.Fill(ds);
            con.Close();

            return ds;
        }

        public DataSet getGraphDataOnMonth(int region_id, int month_min)
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "SELECT quantity,total_income,date_of_sale FROM sales NATURAL JOIN sales_region WHERE region_id = @val1 AND MONTH(date_of_sale) = @val2";
            cmd.Parameters.AddWithValue("@val1", region_id);
            cmd.Parameters.AddWithValue("@val2", month_min);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet ds = new DataSet();

            this.con.Open();
            adap.Fill(ds);
            con.Close();

            return ds;
        }

        internal DataSet getGraphDataOnRange(int region_id, int month_min, int month_max)
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM sales NATURAL JOIN sales_region WHERE region_id = @val1 AND MONTH(date_of_sale) <= @val2 AND MONTH(date_of_sale) >= @val3";
            cmd.Parameters.AddWithValue("@val1", region_id);
            cmd.Parameters.AddWithValue("@val2", month_max);
            cmd.Parameters.AddWithValue("@val3", month_min);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet ds = new DataSet();

            this.con.Open();
            adap.Fill(ds);
            con.Close();

            return ds;
        }

        public DataSet getAnalyser(string username, string password)
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM analysist WHERE username = @val1 AND password = @val2";
            cmd.Parameters.AddWithValue("@val1", username);
            cmd.Parameters.AddWithValue("@val2", password);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet ds = new DataSet();

            this.con.Open();
            adap.Fill(ds);
            con.Close();

            return ds;
        }

        internal DataSet getAnalystOnUsername(string username)
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM analysist WHERE username = @val1";
            cmd.Parameters.AddWithValue("@val1", username);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet ds = new DataSet();

            this.con.Open();
            adap.Fill(ds);
            con.Close();

            return ds;
        }

        internal void createNewAnalysist(string name, string email, string username, string password)
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO `analysist`(`analysist_id`, `name`, `email`, `username`, `password`) VALUES (0,@val1,@val2,@val3,@val4)";
            cmd.Parameters.AddWithValue("@val1", name);
            cmd.Parameters.AddWithValue("@val2", email);
            cmd.Parameters.AddWithValue("@val3", username);
            cmd.Parameters.AddWithValue("@val4", password);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        internal DataSet getDealerOnUsername(string username)
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM dealer WHERE username = @val1";
            cmd.Parameters.AddWithValue("@val1", username);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet ds = new DataSet();

            this.con.Open();
            adap.Fill(ds);
            con.Close();

            return ds;
        }

        internal void createNewDealer(string name, string email, string username, string password)
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO `dealer`(`dealer_id`, `name`, `email`, `username`, `password`) VALUES (0,@val1,@val2,@val3,@val4)";
            cmd.Parameters.AddWithValue("@val1", name);
            cmd.Parameters.AddWithValue("@val2", email);
            cmd.Parameters.AddWithValue("@val3", username);
            cmd.Parameters.AddWithValue("@val4", password);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        internal DataSet getAdminOnUsername(string username)
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM admin WHERE username = @val1";
            cmd.Parameters.AddWithValue("@val1", username);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet ds = new DataSet();

            this.con.Open();
            adap.Fill(ds);
            con.Close();

            return ds;
        }

        internal void createNewAdmin(string name, string email, string username, string password)
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO `admin`(`admin_id`, `name`, `email`, `username`, `password`) VALUES (0,@val1,@val2,@val3,@val4)";
            cmd.Parameters.AddWithValue("@val1", name);
            cmd.Parameters.AddWithValue("@val2", email);
            cmd.Parameters.AddWithValue("@val3", username);
            cmd.Parameters.AddWithValue("@val4", password);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        internal DataSet getAdmin(string username, string password)
        {
            this.con = db_connector.getConnection();
            this.cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM admin WHERE username = @val1 AND password = @val2";
            cmd.Parameters.AddWithValue("@val1", username);
            cmd.Parameters.AddWithValue("@val2", password);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet ds = new DataSet();

            this.con.Open();
            adap.Fill(ds);
            con.Close();

            return ds;
        }
    }
}
