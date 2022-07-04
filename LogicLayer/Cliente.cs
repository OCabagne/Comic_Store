using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace LogicLayer
{
    public class Cliente
    {
        private Int64 idCliente;
        private Int64 Puntos;
        private string Nombre;
        private string Correo;
        private string Contraseña;
        private string SusType;
        private Int64 Tipo;
        private Int64 idSuscripcion;
        private Int64 idApartado;


        public long IdCliente { get => idCliente; set => idCliente = value; }
        public long Puntos1 { get => Puntos; set => Puntos = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public long IdSuscripcion { get => idSuscripcion; set => idSuscripcion = value; }
        public long IdApartado { get => idApartado; set => idApartado = value; }
        public string SusType1 { get => SusType; set => SusType = value; }
        public long Tipo1 { get => Tipo; set => Tipo = value; }

        public Cliente()
        {

        }

        public byte log(string mail, string pass)       //Login - comprobar que el correo exista y que la contraseña coincida
        {
            byte log;
            ReadData login = new ReadData();
            if(login.Log(mail, pass))
            {
                log = 1;
                
            }
            else
            {
                log = 0;
            }

            return log;
        }

        public void NCliente(string mail)               //Objeto Cliente - Descarga los datos del cliente logeado de la DB
        {
            ReadData read = new ReadData();

            this.IdCliente = Int64.Parse(read.GetUserID(mail).ToString());
            this.Puntos1 = read.GetUserPoints(this.idCliente);
            this.Nombre1 = read.GetUserName(this.idCliente);
            this.Correo1 = read.GetUserMail(this.idCliente);
            this.Tipo1 = read.GetUserType(this.idCliente);
            //this.IdSuscripcion = read.GetIdSus(this.idCliente);
            this.IdApartado = read.GetIdAp(this.idCliente);
            this.SusType1 = read.GetSusType(this.idCliente);
        }

        public void NCliente_nombre(string nombre)               //Objeto Cliente - Descarga los datos del cliente logeado de la DB
        {
            ReadData read = new ReadData();

            this.IdCliente = Int64.Parse(read.GetUserID_name(nombre).ToString());
            this.Puntos1 = read.GetUserPoints(this.idCliente);
            this.Nombre1 = read.GetUserName(this.idCliente);
            this.Correo1 = read.GetUserMail(this.idCliente);
            this.Tipo1 = read.GetUserType(this.idCliente);
            //this.IdSuscripcion = read.GetIdSus(this.idCliente);
            this.IdApartado = read.GetIdAp(this.idCliente);
            this.SusType1 = read.GetSusType(this.idCliente);
        }

        public void NCliente_id(Int64 idCliente)               //Objeto Cliente - Descarga los datos del cliente logeado de la DB
        {
            ReadData read = new ReadData();

            this.IdCliente = idCliente;
            this.Puntos1 = read.GetUserPoints(this.idCliente);
            this.Nombre1 = read.GetUserName(this.idCliente);
            this.Correo1 = read.GetUserMail(this.idCliente);
            this.Tipo1 = read.GetUserType(this.idCliente);
            //this.IdSuscripcion = read.GetIdSus(this.idCliente);
            this.IdApartado = read.GetIdAp(this.idCliente);
            this.SusType1 = read.GetSusType(this.idCliente);
        }

        public bool Registro(string nombre, string correo, string pass)
        {
            bool regis;
            Register reg = new Register();
            if(reg.newClient(nombre, correo, pass)){
                regis = true;
            }
            else
            {
                regis = false;
            }

            return regis;
        }

        public List<Int64> idSuscripciones(Int64 id)
        {
            List<Int64> Ids = new List<Int64>();

            ReadData read = new ReadData();
            Ids = read.idsuscripcionesList(id);

            return Ids;
        }

        public List<Int64> idApartados(Int64 id)
        {
            List<Int64> Ids = new List<Int64>();

            ReadData read = new ReadData();
            Ids = read.idapartados(id);

            return Ids;
        }

        public DataTable Informacion(Int64 id)
        {
            ReadData read = new ReadData();
            DataTable cons = new DataTable();
            cons = read.info(id);

            return cons;
        }

        public bool NuevaSuscripcion(string Nombre, Int64 id)
        {
            bool done;
            Register registro = new Register();
            if (registro.newSerieEnSus(Nombre, id))
            {
                done = true;
            }
            else
            {
                done = false;
            }
            return done;
        }

        public bool ActualizarPuntos(Int64 idCliente, Int64 Puntos)
        {
            bool done = false;
            Register reg = new Register();
            if(reg.UpdatePoints(idCliente, Puntos))
            {
                done = true;
            }

            return done;
        }
    }
}
