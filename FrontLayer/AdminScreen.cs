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
    public partial class AdminScreen : Form
    {
        string psw;

        public AdminScreen(string pass)
        {
            InitializeComponent();
            abrirPagina(new Inicio(pass));
            psw = pass;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

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

        private void cmdMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdComic_Click(object sender, EventArgs e)
        {
            abrirPagina(new AdminComic());
        }

        private void AdminScreen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdCuenta_Click(object sender, EventArgs e)
        {
            abrirPagina(new Cuenta(psw));
        }

        private void cmdUser_Click(object sender, EventArgs e)
        {
            abrirPagina(new User());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirPagina(new Inicio(psw));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
