using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class Serie
    {
        private Int64 id;
        private string nombre;
        private string editorial;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public long Id { get => id; set => id = value; }

        public Serie() { }

        public Serie(Int64 id)
        {
            ReadData read = new ReadData();
            this.Id = read.idsuscripciones(id);
            this.Nombre = read.getSerieName(this.Id);
            this.Editorial = read.getSerieEdit(this.Id);
        }
    }
}
