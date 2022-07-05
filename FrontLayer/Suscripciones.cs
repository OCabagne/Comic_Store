using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;

namespace FrontLayer
{
    public partial class Suscripciones : Form
    {
        public Suscripciones(string mail)
        {
            InitializeComponent();
            Cliente user = new Cliente();
            user.NCliente(mail);

            List<Int64> Suscripciones = new List<Int64>();
            Suscripciones = user.idSuscripciones(user.IdCliente);

            List<Serie> Series = new List<Serie>();
            foreach(Int64 id in Suscripciones)
            {
                Serie serie = new Serie(id);
                Series.Add(serie);
            }

            dataGridView1.DataSource = Series;

            List<Int64> Apartados = new List<Int64>();
            Apartados = user.idApartados(user.IdCliente);

            List<Comics> ComicApartado = new List<Comics>();
            foreach(Int64 id in Apartados)
            {
                Comics comic = new Comics(id);
                ComicApartado.Add(comic);
            }

            dataGridView2.DataSource = ComicApartado;
        }
    }
}
