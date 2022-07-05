using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LogicLayer;

namespace FrontLayer
{
    public partial class AddSusc : Form
    {
        public AddSusc()
        {
            InitializeComponent();
            Admin opt = new Admin();
            List<string> Opciones = new List<string>();
            Opciones = opt.Correos();
            foreach (string correo in Opciones)
            {
                optMail.Items.Add(correo);
            }


            List<string> Opciones2 = new List<string>();
            Opciones2 = opt.Series();
            foreach (string serie in Opciones2)
            {
                optSerie.Items.Add(serie);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddSusc_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente user = new Cliente();
            user.NCliente(optMail.Text);
            if(user.NuevaSuscripcion(optSerie.Text, user.IdCliente))
            {
                MessageBox.Show("Ha ocurrido un error :(");
            }
            else
            {
                MessageBox.Show("Suscripcion Registrada");
            }
        }
    }
}
