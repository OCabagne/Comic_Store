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
    public partial class Comic : Form
    {
        Int64 idCliente;
        Int64 idComic;
        float Precio;

        public Comic(Comics comic, Int64 id)
        {
            InitializeComponent();
            txtNombre.Text = comic.Nombre;
            txtEditorial.Text = "Editorial: " + comic.Editorial;
            txtFecha.Text = "Fecha Pub: " + comic.Fecha.ToString();
            txtPrecio.Text = "Precio: " + comic.Precio.ToString();
            txtStatus.Text = comic.Status;
            idComic = comic.IdComic;
            Precio = comic.Precio;
            idCliente = id;

            if(comic.Status == "Disponilbe")
            {
                txtStatus.ForeColor = Color.DarkGreen;
            }
            if(comic.Status == "Limitado")
            {
                txtStatus.ForeColor = Color.DarkOrange;
            }
            if(comic.Status == "Agotado")
            {
                txtStatus.ForeColor = Color.DarkRed;
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

        private void Comic_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comics compra = new Comics();
            if (compra.NuevaCompra(Precio, idCliente))
            {
                compra.NuevoComicComprado(idComic);

                int precio = Convert.ToInt32(Precio);
                Int64 puntos = 0;
                Cliente cliente = new Cliente();
                cliente.NCliente_id(idCliente);
                if (precio <= 84)
                {
                    puntos = cliente.Puntos1 + 3;
                }
                if (precio > 84 && Precio <= 250)
                {
                    puntos = cliente.Puntos1 + 5;
                }
                if (precio > 250 && Precio <= 500)
                {
                    puntos = cliente.Puntos1 + 7;
                }
                if (precio > 500)
                {
                    puntos = cliente.Puntos1 + 10;
                }

                cliente.ActualizarPuntos(idCliente, puntos);
                MessageBox.Show("Compra Exitosa :) ");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error :( ");
            }
        }
    }
}
