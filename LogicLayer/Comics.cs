using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class Comics
    {
        private Int64 idComic;
        private string nombre;
        private string editorial;
        private string status;
        private float precio;
        private string fecha;

        public long IdComic { get => idComic; set => idComic = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string Status { get => status; set => status = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Fecha { get => fecha; set => fecha = value; }

        public Comics() { }

        public Comics(Int64 id)
        {
            ReadData read = new ReadData();

            this.IdComic = id;
            this.Nombre = read.GetComicName(this.IdComic);
            this.Editorial = read.GetComicEditorial(this.IdComic);
            this.Status = read.GetComicStatus(this.IdComic);
            this.Precio = read.GetComicPrice(this.IdComic);
            this.Fecha = read.GetComicDate(this.IdComic);
        }

        public void NComic(string Name)
        {
            ReadData read = new ReadData();

            this.IdComic = read.GetComicID(Name);
            this.Nombre = read.GetComicName(this.IdComic);
            this.Editorial = read.GetComicEditorial(this.IdComic);
            this.Status = read.GetComicStatus(this.IdComic);
            this.Precio = read.GetComicPrice(this.IdComic);
            this.Fecha = read.GetComicDate(this.IdComic);
        }

        public bool Registro(string nombre, string editorial, string status, float precio, string fecha)
        {
            bool regis;
            Register reg = new Register();
            if (reg.newComic(nombre, editorial, status, precio, fecha))
            {
                regis = true;
            }
            else
            {
                regis = false;
            }

            return regis;
        }

        public bool Actualizar(string editorial, float precio, string status, string fecha, Int64 id)
        {
            bool done;
            Register reg = new Register();
            if (reg.UpdateComic(id, editorial, precio, status, fecha)) 
            {
                done = true;
            }
            else
            {
                done = false;
            }
            return done;
        }

        public bool NuevaSerie(string Nombre, string Editorial)
        {
            bool done;
            Register reg = new Register();
            if (reg.newSerie(Nombre, Editorial))
            {
                done = true;
            }
            else
            {
                done = false;
            }

            return done;
        }

        public bool NuevaCompra(float Precio, Int64 idCliente)
        {
            bool done;
            Register reg = new Register();
            if (reg.newCompra(Precio, idCliente))
            {
                done = false;
            }
            else
            {
                done = true;
            }

            return done;
        }

        public bool NuevoComicComprado(Int64 idComic)
        {
            bool done;
            Register reg = new Register();
            if (reg.newComicComprado(idComic))
            {
                done = true;
            }
            else
            {
                done = false;
            }

            return done;
        }

        public List<Int64> idCompras(Int64 idCliente)
        {
            List<Int64> ids = new List<Int64>();

            ReadData read = new ReadData();
            ids = read.getIdCompra(idCliente);

            return ids;
        }

        public Int64 idComics(Int64 idCompra)
        {
            Int64 ids;

            ReadData read = new ReadData();
            ids = read.getIdComic(idCompra);

            return ids;
        }

        public string NombreComic(Int64 idComic)
        {
            string ids;

            ReadData read = new ReadData();
            ids = read.getComic(idComic);

            return ids;
        }
    }
}
