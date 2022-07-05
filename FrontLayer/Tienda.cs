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
    public partial class Tienda : Form
    {
        public Tienda(string mail)
        {
            InitializeComponent();
            abrirPagina(new Catalogo(mail));

        }


        private void abrirPagina(object pag)
        {
            if (this.Pagina.Controls.Count > 0)
            {
                this.Pagina.Controls.RemoveAt(0);
            }

            Form pagina = pag as Form;
            pagina.TopLevel = false;
            pagina.Dock = DockStyle.Fill;
            this.Pagina.Controls.Add(pagina);
            this.Pagina.Tag = pagina;
            pagina.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
