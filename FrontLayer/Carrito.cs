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
    public partial class Carrito : Form
    {
        public Carrito(string mail)
        {
            InitializeComponent();
            Cliente user = new Cliente();
            user.NCliente(mail);

            Comics comic = new Comics();
            List<Int64> idcompras = new List<Int64>();
            idcompras = comic.idCompras(user.IdCliente);

            List<Int64> idcomics = new List<Int64>();
            foreach(Int64 id in idcompras)
            {
                Int64 id1 = comic.idComics(id);
                idcomics.Add(id1);
            }

            List<Comics> comics = new List<Comics>();
            foreach (Int64 id in idcomics)
            {
                Comics comic1 = new Comics(id);
                comics.Add(comic1);
            }

            dataGridView1.DataSource = comics;
        }
    }
}
