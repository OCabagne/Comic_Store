using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class Admin
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

        public Admin() { }

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public long Puntos1 { get => Puntos; set => Puntos = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public string SusType1 { get => SusType; set => SusType = value; }
        public long Tipo1 { get => Tipo; set => Tipo = value; }
        public long IdSuscripcion { get => idSuscripcion; set => idSuscripcion = value; }
        public long IdApartado { get => idApartado; set => idApartado = value; }

        public List<string> Nombres()
        {
            List<string> Opciones = new List<string>();

            ReadData read = new ReadData();
            Opciones = read.getNames();
            return Opciones;
        }

        public List<string> Correos()
        {
            List<string> Opciones = new List<string>();

            ReadData read = new ReadData();
            Opciones = read.getMails();
            return Opciones;
        }

        public List<string> Series()
        {
            List<string> Opciones = new List<string>();

            ReadData read = new ReadData();
            Opciones = read.getSerie();
            return Opciones;
        }

        public List<string> Comics()
        {
            List<string> Opciones = new List<string>();

            ReadData read = new ReadData();
            Opciones = read.getComics();
            return Opciones;
        }
    }
}
