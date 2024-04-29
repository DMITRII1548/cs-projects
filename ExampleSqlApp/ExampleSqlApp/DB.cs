using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSqlApp
{
    internal class DB
    {
        MySqlConnection connection =  new MySqlConnection("server=localhost;port=3306;username=root;password=;database=example_sql_app");
        
        public void openConnection()
        {
           // if (connection.State == System.Data.ConnectionState.Closed)
           //{
                connection.Open();
           // }
        }

        public void closeConnection()
        {

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

    }
}
