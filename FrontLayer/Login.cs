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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Correo")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.SteelBlue;
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Correo";
                txtMail.ForeColor = Color.CadetBlue;
            }

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.SteelBlue;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.CadetBlue;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void cmdMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdLog_Click(object sender, EventArgs e)
        {
            Cliente Log = new Cliente();
            if(Log.log(txtMail.Text, txtPass.Text) == 1)
            {
                
                Cliente user = new Cliente();
                user.NCliente(txtMail.Text);
                if (user.Tipo1 == 1)
                {
                    ClientScreen cliente = new ClientScreen(txtMail.Text);
                    cliente.Show();
                    this.Hide();
                }
                if(user.Tipo1 == 2)
                {
                    AdminScreen admin = new AdminScreen(txtMail.Text);
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }
        }

        private void cmdReg_Click(object sender, EventArgs e)
        {
            Registro pag = new Registro();
            pag.Show();
        }
    }
}
