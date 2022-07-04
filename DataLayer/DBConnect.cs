using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class DBConnect
    {
        MySqlConnection connect = new MySqlConnection("server = 127.0.0.1; database = ComicStore; Uid = root; pwd = saintseiyaomega");

        public MySqlConnection Conexion()
        {
            MySqlConnection conectar;
            conectar = connect;
            return conectar;
        }

        public MySqlConnection connectDB()
        {
            if(connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
            return connect;
        }

        public MySqlConnection closeDB()
        {
            if(connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
            return connect;
        }
    }
}
