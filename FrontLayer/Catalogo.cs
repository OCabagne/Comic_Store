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
    public partial class Catalogo : Form
    {
        Int64 idCliente;

        public Catalogo(string mail)
        {
            InitializeComponent();
            Admin opt = new Admin();
            List<string> Opciones = new List<string>();
            Opciones = opt.Comics();
            foreach (string comic in Opciones)
            {
                optComic.Items.Add(comic);
            }

            Cliente cliente = new Cliente();
            cliente.NCliente(mail);
            idCliente = cliente.IdCliente;

        }

        private void cmdLog_Click(object sender, EventArgs e)
        {
            Comics comic = new Comics();
            comic.NComic(optComic.Text);
            Comic pagina = new Comic(comic, idCliente);
            pagina.Show();
        }
    }
}
