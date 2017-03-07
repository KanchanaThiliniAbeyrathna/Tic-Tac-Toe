using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using log4net;

namespace WindowsFormsApplication1
{
    class Database
    {

        private MySqlConnection connection;

        private static readonly ILog log = LogManager.GetLogger(typeof(Database));
        public Database( Player p)
        {
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Server = "localhost";
            connBuilder.Database = "mydb";
            connBuilder.UserID = "root";
            connBuilder.Password = "597259";
            connection = new MySqlConnection(connBuilder.ToString());

            bool name_exist = nameCheck(connection, p);
            if (name_exist)
            {
                try
                {

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE statictics SET Wins=@Wins, Losses=@Losses ,HighScore=@HighScore WHERE Name = @Name;";
                    //cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Name", p.getPlayerName());
                    cmd.Parameters.AddWithValue("@Wins", p.getWins());
                    cmd.Parameters.AddWithValue("@Losses", p.getLosses());
                    cmd.Parameters.AddWithValue("@HighScore", p.getHighScore());
                    cmd.ExecuteNonQuery();
                }
                catch(Exception)
                {
                    log.Error("Error occured while updating database");
                    throw;
                }


            }
            else
            {
                try
                {
                    
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO statictics (Name,Wins,Losses,HighScore)VALUES(@Name,@Wins,@Losses,@HighScore)";
                    cmd.Parameters.AddWithValue("@Name", p.getPlayerName());
                    cmd.Parameters.AddWithValue("@Wins", p.getWins());
                    cmd.Parameters.AddWithValue("@Losses", p.getLosses());
                    cmd.Parameters.AddWithValue("@HighScore", p.getHighScore());
                    cmd.ExecuteNonQuery();


                }

                catch (Exception)
                {
                    log.Error("Error occured while inserting data to a database");
                    throw;
                }

            }
            /*using (connection)
            {
                string s = "mydb.statictics;";
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from " + s, connection);

                adapter.Fill(ds, s);

            }*/

        }
        public void fillTable(MySqlConnection con, DataSet ds)
        {
            using (con)
            {
                string s = "mydb.statictics;";
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from " + s, con);

                adapter.Fill(ds, s);

            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        public bool nameCheck(MySqlConnection con, Player p)
        {
            log.Debug("check player name");
            MySqlCommand cmd = new MySqlCommand("Select * from statictics where Name= @Name", con);
            cmd.Parameters.AddWithValue("@Name", p.getPlayerName());
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    log.Debug(p.getPlayerName()+" player already exists");
                    dr.Close();
                    return true;
                }
            }
            log.Debug(p.getPlayerName() + " player does not exist");
            dr.Close();
            return false;
        }
    }
}
