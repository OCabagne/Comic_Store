using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataLayer
{
    public class ReadData
    {
        private DBConnect Conn = new DBConnect();
        private MySqlCommand cmd = new MySqlCommand();
        private MySqlDataReader read;

        public bool Log(string mail, string pass)
        {
            bool login;
            cmd.Connection = Conn.connectDB();
            string insert = "Select * from cliente where Correo ='" + mail + "' and Contraseña = '" + pass + "';";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                login = true;
            }
            else
            {
                login = false;
            }

            cmd.Connection = Conn.closeDB();
            return login;
        }

        public Int64 LastidCompra()
        {
            Int64 id = 0;
            cmd.Connection = Conn.connectDB();
            string insert = "Select LAST_INSERT_ID();";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                id = read.GetInt64(0);
            }
            cmd.Connection = Conn.closeDB();
            return id;
        }

        public Int64 GetUserID(string mail)
        {
            Int64 id = 4;
            cmd.Connection = Conn.connectDB();
            string insert = "Select idCliente from cliente where Correo = '" + mail + "';";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                id = read.GetInt64(0);
            }
            cmd.Connection = Conn.closeDB();
            return id;
        }

        public Int64 GetUserID_name(string nombre)
        {
            Int64 id = 4;
            cmd.Connection = Conn.connectDB();
            string insert = "Select idCliente from cliente where Nombre = '" + nombre + "';";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                id = read.GetInt64(0);
            }
            cmd.Connection = Conn.closeDB();
            return id;
        }

        public Int64 GetUserType(Int64 id)
        {
            Int64 type = 0;
            cmd.Connection = Conn.connectDB();
            string insert = "Select tipo from cliente where idCliente = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                type = read.GetInt64(0);
            }
            cmd.Connection = Conn.closeDB();
            return type;
        }

        public string GetUserName(Int64 id)
        {
            string name = "blablabla";
            cmd.Connection = Conn.connectDB();
            string insert = "Select nombre from cliente where idCliente = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                name = read.GetString(0).ToString();
            }
            read.Close();
            cmd.Connection = Conn.closeDB();
            return name;
        }

        public Int64 GetUserPoints(Int64 id)
        {
            Int64 points = 0;
            cmd.Connection = Conn.connectDB();
            string insert = "Select puntos from cliente where idCliente = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                points = read.GetInt64(0);
            }
            cmd.Connection = Conn.closeDB();
            return points;
        }

        public string GetUserMail(Int64 id)
        {
            string name = "";
            cmd.Connection = Conn.connectDB();
            string insert = "Select Correo from cliente where idCliente = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                name = read.GetString(0);
            }
            cmd.Connection = Conn.closeDB();
            return name;
        }

        public Int64 GetIdSus(Int64 id)
        {
            Int64 idsus = 1;
            cmd.Connection = Conn.connectDB();
            string insert = "Select idSuscripcion from cliente where idCliente = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                if((read.GetInt64(0).ToString()) == null)
                {
                    idsus = 0;
                }
                else
                {
                    idsus = read.GetInt64(0);
                }
            }
            cmd.Connection = Conn.closeDB();
            return idsus;
        }

        public Int64 GetIdAp(Int64 id)
        {
            Int64 idap = 1;
            cmd.Connection = Conn.connectDB();
            string insert = "Select idApartado from cliente where idCliente = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                idap = read.GetInt64(0);
            }
            cmd.Connection = Conn.closeDB();
            return idap;
        }

        public string GetSusType(Int64 id)
        {
            string type = "";
            cmd.Connection = Conn.connectDB();
            string insert = "Select tipo from suscripcion where idSuscripcion = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                type = read.GetString(0);
            }
            cmd.Connection = Conn.closeDB();
            return type;
        }

        public Int64 idsuscripciones(Int64 id)
        {
            Int64 id1 = 0;

            cmd.Connection = Conn.connectDB();
            string insert = "Select idSerie from suscripcionaserie where idSuscripcion = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if(read.Read())
            {
                id1 = read.GetInt64(0);
            }

            cmd.Connection = Conn.closeDB();
            return id1;
        }

        public string getSerieName(Int64 id)
        {
            string Serie = "";

            cmd.Connection = Conn.connectDB();
            string insert = "Select Nombre from Serie where idSerie = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                Serie = read.GetString(0);
            }
            cmd.Connection = Conn.closeDB();

            return Serie;
        }

        public string getSerieEdit(Int64 id)
        {
            string Serie = "";

            cmd.Connection = Conn.connectDB();
            string insert = "Select Editoral from Serie where idSerie = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                Serie = read.GetString(0);
            }
            cmd.Connection = Conn.closeDB();

            return Serie;
        }

        public List<Int64> idsuscripcionesList(Int64 id)
        {
            List<Int64> ids = new List<Int64>();
            Int64 id1;

            cmd.Connection = Conn.connectDB();
            string insert = "Select idSerie from suscripcionaserie where idSuscripcion = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                id1 = read.GetInt64(0);
                ids.Add(id1);
            }

            return ids;
        }

        public List<Int64> idapartados(Int64 id)
        {
            List<Int64> ids = new List<Int64>();
            Int64 id1;

            cmd.Connection = Conn.connectDB();
            string insert = "select idComic from comicapartado where idApartado = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                id1 = read.GetInt64(0);
                ids.Add(id1);
            }

            return ids;
        }

        public List<string> getNames()
        {
            List<string> opciones = new List<string>();
            string Name;

            cmd.Connection = Conn.connectDB();
            string insert = "Select Nombre from cliente;";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                Name = read.GetString(0);
                opciones.Add(Name);
            }

            cmd.Connection = Conn.closeDB();
            return opciones;
        }

        public List<string> getMails()
        {
            List<string> opciones = new List<string>();
            string Mail;

            cmd.Connection = Conn.connectDB();
            string insert = "Select Correo from cliente;";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                Mail = read.GetString(0);
                opciones.Add(Mail);
            }

            cmd.Connection = Conn.closeDB();
            return opciones;
        }

        public List<string> getSerie()
        {
            List<string> opciones = new List<string>();
            string Serie;

            cmd.Connection = Conn.connectDB();
            string insert = "Select Nombre from Serie;";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                Serie = read.GetString(0);
                opciones.Add(Serie);
            }

            cmd.Connection = Conn.closeDB();
            return opciones;
        }

        public List<string> getComics()
        {
            List<string> opciones = new List<string>();
            string Comic;

            cmd.Connection = Conn.connectDB();
            string insert = "Select Nombre from Comic;";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                Comic = read.GetString(0);
                opciones.Add(Comic);
            }

            cmd.Connection = Conn.closeDB();
            return opciones;
        }

        public List<Int64> getIdCompra(Int64 idCliente)
        {
            List<Int64> opciones = new List<Int64>();
            Int64 Comic;

            cmd.Connection = Conn.connectDB();
            string insert = "Select idCompra from Compra where idCliente = " + idCliente + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                Comic = read.GetInt64(0);
                opciones.Add(Comic);
            }

            cmd.Connection = Conn.closeDB();
            return opciones;
        }

        public Int64 getIdComic(Int64 idCompra)
        {
            Int64 opciones = 0;
            Int64 Comic;

            cmd.Connection = Conn.connectDB();
            string insert = "Select idComic from ComicComprado where idCompra = " + idCompra + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                Comic = read.GetInt64(0);
                opciones = Comic;
            }

            cmd.Connection = Conn.closeDB();
            return opciones;
        }

        public string getComic(Int64 idComic)
        {
            string opciones = "";
            string Comic;

            cmd.Connection = Conn.connectDB();
            string insert = "Select Nombre from Comic where idComic = " + idComic + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                Comic = read.GetString(0);
                opciones = Comic;
            }

            cmd.Connection = Conn.closeDB();
            return opciones;
        }

        public DataTable info(Int64 id)
        {
            string insert = "Select nombre, correo, puntos from cliente where idCliente = " + id + "";
            MySqlDataAdapter adap = new MySqlDataAdapter(insert, Conn.Conexion());
            DataTable cons = new DataTable();
            adap.Fill(cons);

            return cons;
        }

        public Int64 GetComicID(string nombre)
        {
            Int64 id = 4;
            cmd.Connection = Conn.connectDB();
            string insert = "Select idComic from comic where Nombre = '" + nombre + "';";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                id = read.GetInt64(0);
            }
            cmd.Connection = Conn.closeDB();
            return id;
        }

        public string GetComicName(Int64 id)
        {
            string name = "blablabla";
            cmd.Connection = Conn.connectDB();
            string insert = "Select nombre from comic where idComic = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                name = read.GetString(0).ToString();
            }
            read.Close();
            cmd.Connection = Conn.closeDB();
            return name;
        }

        public string GetComicEditorial(Int64 id)
        {
            string editorial = "blablabla";
            cmd.Connection = Conn.connectDB();
            string insert = "Select Editorial from Comic where idComic = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                editorial = read.GetString(0).ToString();
            }
            read.Close();
            cmd.Connection = Conn.closeDB();
            return editorial;
        }

        public string GetComicStatus(Int64 id)
        {
            string status = "blablabla";
            cmd.Connection = Conn.connectDB();
            string insert = "Select Status from Comic where idComic = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                status = read.GetString(0).ToString();
            }
            read.Close();
            cmd.Connection = Conn.closeDB();
            return status;
        }

        public float GetComicPrice(Int64 id)
        {
            float price = 0;
            cmd.Connection = Conn.connectDB();
            string insert = "Select Precio from Comic where idComic = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                price = read.GetInt64(0);
            }

            cmd.Connection = Conn.closeDB();
            return price;
        }

        public string GetComicDate(Int64 id)
        {
            string date;
            cmd.Connection = Conn.connectDB();
            string insert = "Select FechaPub from Comic where idComic = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                date = read.GetMySqlDateTime(0).ToString();
            }
            else
            {
                date = read.GetMySqlDateTime(0).ToString();
            }

            cmd.Connection = Conn.closeDB();
            return date;
        }

    }
}
