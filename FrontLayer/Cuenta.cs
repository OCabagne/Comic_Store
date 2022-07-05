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
    public partial class Cuenta : Form
    {

        public Cuenta(string pass)
        {
            InitializeComponent();
            Cliente user = new Cliente();
            user.NCliente(pass);
            txtNombre.Text = "Nombre: " + user.Nombre1;
            txtCorreo.Text = "Correo: " + user.Correo1;
            txtSus.Text = "Tipo de Suscripción: " + user.SusType1;
            txtPuntos.Text = user.Puntos1.ToString();
        }
    }
}
