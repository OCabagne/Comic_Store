using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class Register
    {
        private DBConnect Conn = new DBConnect();
        private MySqlCommand cmd = new MySqlCommand();
        private MySqlDataReader read;

        public bool newClient(string Name, string Mail, string Password)
        {
            bool reg;
            cmd.Connection = Conn.connectDB();
            string insert = "Insert into cliente(Puntos, Nombre, Correo, Contraseña, Tipo) values(0, '" + Name + "', '" + Mail + "', '" + Password + "', 1); Insert into apartado() values();";

            cmd.CommandText = insert;
            read = cmd.ExecuteReader();     //Inserta nuevo usuario
            if (read.Read())
            {
                reg = true;
            }
            else
            {
                reg = false;
            }

            read.Close();

            string selectid = "Select Max(idCliente) from cliente; ";
            Int64 id = 0;
            cmd.CommandText = selectid;
            read = cmd.ExecuteReader();     // Encuentra el nuevo id
            if (read.Read())
            {
                id = read.GetInt64(0);
            }

            read.Close();

            string update = " Update cliente set idApartado = (Select Max(idApartado) from apartado) where idCliente = " + id + "; ";
            cmd.CommandText = update;
            read = cmd.ExecuteReader();     // Asocia un nuevo apartado al cliente nuevo
            if (read.Read())
            {
                reg = true;
            }

            read.Close();
            cmd.Connection = Conn.closeDB();
            return reg;
        }

        public bool UpdatePoints(Int64 idCliente, Int64 Puntos)
        {
            bool done = false;
            cmd.Connection = Conn.connectDB();
            string insert = "Update Cliente set Puntos = " + Puntos + " where idCliente = " + idCliente + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                done = true;
            }
            cmd.Connection = Conn.closeDB();
            return done;
        }

        public bool newComic(string Name, string Editorial, string Status, float Price, string Date)
        {
            bool reg;
            cmd.Connection = Conn.connectDB();
            string insert = "Insert into comic(Nombre, Editorial, Status, Precio, FechaPub) values('" + Name + "', '" + Editorial + "', '" + Status + "', " + Price + ", '" + Date + "');";

            cmd.CommandText = insert;
            read = cmd.ExecuteReader();     //Inserta nuevo comic
            if (read.Read())
            {
                reg = true;
            }
            else
            {
                reg = false;
            }

            read.Close();
            cmd.Connection = Conn.closeDB();
            return reg;
        }

       /* public void newComic(string Fecha, string status, string editorial, float precio, string nombre)
        {
            cmd.Connection = Conn.connectDB();
            string insert = "Insert into comic(Nombre, fechaPub, Editorial, Status, Precio) values('" + nombre + "', '" + Fecha + "' , '" + editorial + "', '" + status + "'," + precio + ");";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            cmd.Connection = Conn.closeDB();
        }*/

        public bool newSerie(string Nombre, string Editorial)
        {
            bool done;
            cmd.Connection = Conn.connectDB();
            string insert = " Insert into Serie(Nombre, Editoral) values('" + Nombre + "', '" + Editorial + "');";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                done = true;
            }
            else
            {
                done = false;
            }

            cmd.Connection = Conn.closeDB();
            return done;
        }

        public void newSuscripcion(String tipo, int idCliente)
        {
            cmd.Connection = Conn.connectDB();
            string insert = "Insert into suscripcion(Tipo, FechaInicio) values('"+ tipo + "', now()); Update cliente set idSuscripcion = (Select LAST_INSERT_ID()) where idCliente = " + idCliente +";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            cmd.Connection = Conn.closeDB();
        }

        public void newComicEnApartado(string NombreComic, int idCliente)
        {
            cmd.Connection = Conn.connectDB();
            string insert = "Insert into comicapartado(idComic, idApartado values((Select idComic from comic where Nombre like '" + NombreComic + "'),(Select idApartado from Cliente where idCliente = " + idCliente +"));";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            cmd.Connection = Conn.closeDB();
        }

        public bool newSerieEnSus(string NombreSerie, Int64 idCliente)
        {
            bool done;
            cmd.Connection = Conn.connectDB();
            string insert = "Insert into suscripcionaserie(idSuscripcion, idSerie) values((Select idSuscripcion from Cliente where idCliente = " + idCliente + "),(Select idSerie from serie where Nombre like '" + NombreSerie + "'));";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                done = true;
            }
            else
            {
                done = false;
            }
            cmd.Connection = Conn.closeDB();
            return done;
        }

        public void newTipoComic(byte Tipo, string NombreComic)//tp, hc, gr
        {
            if(Tipo == 1)   // GR
            {
                cmd.Connection = Conn.connectDB();
                string insert = "Insert into comic_gr(idComic) values((Select idComic from comic where Nombre like '" + NombreComic + "'));";
                cmd.CommandText = insert;
                read = cmd.ExecuteReader();
                cmd.Connection = Conn.closeDB();
            }
            if(Tipo == 2)   // TP
            {
                cmd.Connection = Conn.connectDB();
                string insert = "Insert into comic_tp(idComic) values((Select idComic from comic where Nombre like '" + NombreComic + "'));";
                cmd.CommandText = insert;
                read = cmd.ExecuteReader();
                cmd.Connection = Conn.closeDB();
            }
            if (Tipo == 3)   // HC
            {
                cmd.Connection = Conn.connectDB();
                string insert = "Insert into comic_hc(idComic) values((Select idComic from comic where Nombre like '" + NombreComic + "'));";
                cmd.CommandText = insert;
                read = cmd.ExecuteReader();
                cmd.Connection = Conn.closeDB();
            }
        }

        public bool newCompra(float Costo, Int64 idCliente)
        {
            bool done = false;
            cmd.Connection = Conn.connectDB();
            string insert = "Insert into Compra(Costo, idCliente) values(" + Costo + ", " + idCliente + ");";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                done = true;
            }

            cmd.Connection = Conn.closeDB();
            return done;
        }

        public bool newComicComprado(Int64 idComic)
        {
            bool done;
            cmd.Connection = Conn.connectDB();
            string insert = "Insert into ComicComprado(idCompra, idComic) values((Select Max(idCompra) from Compra), " + idComic + ");";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                done = true;
            }
            else
            {
                done = false;
            }

            cmd.Connection = Conn.closeDB();
            return done;
        }

        public bool UpdateComic(Int64 id, string Editorial, float Price, string Status, string Date)
        {
            bool done;
            cmd.Connection = Conn.connectDB();
            string insert = "Update comic set Editorial = '" + Editorial + "' where idComic = " + id + "; Update comic set Precio = " + Price + " where idComic = " + id + "; Update comic set Status = '" + Status + "' where idComic = " + id + "; Update comic set fechaPub = '" + Date + "' where idComic = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                done = true;
            }
            else
            {
                done = false;
            }

            cmd.Connection = Conn.closeDB();
            return done;
        }

        public void UpdateComicEd(Int64 id, string Editorial)
        {
            cmd.Connection = Conn.connectDB();
            string insert = "Update comic set Editorial = '" + Editorial + "' where idComic = " + id + "; ";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            cmd.Connection = Conn.closeDB();
        }

        public void UpdateComicPrice(Int64 id, float Price)
        {
            cmd.Connection = Conn.connectDB();
            string insert = "Update comic set Precio = " + Price + " where idComic = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            cmd.Connection = Conn.closeDB();
        }

        public void UpdateComicStatus(Int64 id, string Status)
        {
            cmd.Connection = Conn.connectDB();
            string insert = "Update comic set Editorial = '" + Status + "' where idComic = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            cmd.Connection = Conn.closeDB();
        }

        public void UpdateComicDate(Int64 id, DateTime Date)
        {
            cmd.Connection = Conn.connectDB();
            string insert = "Update comic set Editorial = '" + Date + "' where idComic = " + id + ";";
            cmd.CommandText = insert;
            read = cmd.ExecuteReader();
            cmd.Connection = Conn.closeDB();
        }
    }
}