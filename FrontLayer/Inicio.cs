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
    public partial class Inicio : Form
    {
        public Inicio(string mail)
        {
            InitializeComponent();
            Cliente user = new Cliente();
            user.NCliente(mail);
            txtUser.Text = user.Nombre1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
