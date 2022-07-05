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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();

            Admin opt = new Admin();
            List<string> Opciones = new List<string>();
            Opciones = opt.Comics();
            foreach (string comic in Opciones)
            {
                optComic.Items.Add(comic);
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

        private void Buscar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdLog_Click(object sender, EventArgs e)
        {
            Comics comic = new Comics();
            comic.NComic(optComic.Text);
            lblStatus.Text = comic.Status;
            if (comic.Status == "Disponible")
            {
                lblStatus.ForeColor = Color.DarkGreen;
            }
            if (comic.Status == "Limitado")
            {
                lblStatus.ForeColor = Color.Orange;
            }
            if(comic.Status == "Agotado")
            {
                lblStatus.ForeColor = Color.Red;
            }
            lblPrecio.Text = comic.Precio.ToString();
        }
    }
}
