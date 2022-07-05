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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void Registro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdLog_Click(object sender, EventArgs e)
        {
            if(txtxPass1.Text == txtPass2.Text)
            {
                Cliente clien = new Cliente();
                if(clien.Registro(txtNombre.Text, txtxCorreo.Text, txtxPass1.Text))
                {
                    MessageBox.Show("Ha ocurrido un error :(");
                }
                else
                {
                    MessageBox.Show("Usuario guardado");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales");
            }
        }
    }
}
