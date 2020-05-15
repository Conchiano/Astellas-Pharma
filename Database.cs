using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// importing Library
using MySql.Data.MySqlClient;
using System.Data;

namespace Astellas_Pharma
{
    class Database
    {
        protected MySqlConnection connection;
        protected MySqlDataAdapter ad;
        protected DataTable dt;
        protected MySqlCommand cmd;

        public Database()
        {
            //adding a constructor
            string connectionString = "Server=localhost; Port=3306; Database=db_astellas; Uid=root; Pwd=India@0214;";
            connection = new MySqlConnection(connectionString);
        }

        //Creating a CREATE Object
        protected void Create (string sqlQuery)
        {
            cmd = new MySqlCommand(sqlQuery, connection);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //Creating a READ Object
        public DataTable Read(string sqlQuery)
        {
            dt = new DataTable();
            ad = new MySqlDataAdapter(sqlQuery, connection);
            new MySqlCommandBuilder(ad);
            connection.Open();
            ad.Fill(dt);
            connection.Close();
            return dt;
        }

        //Creating a GetInterger Object

        protected int GetInteger(string sqlQuery)
        {
            Int32 returnValue;
            cmd = new MySqlCommand(sqlQuery, connection);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            returnValue = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return returnValue;
        }

        //Creating a GetString Object

        protected string GetString(string sqlQuery)
        {
            string returnValue;
            cmd = new MySqlCommand(sqlQuery, connection);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            returnValue = cmd.ExecuteScalar().ToString();
            connection.Close();
            return returnValue;
        }
    }

}
