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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
            Admin opt = new Admin();

            List<string> Opciones = new List<string>();
            Opciones = opt.Nombres();
            foreach(string nombre in Opciones)
            {
                optName.Items.Add(nombre);
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void UserInfo_MouseDown(object sender, MouseEventArgs e)
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

        private void UserInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdLog_Click(object sender, EventArgs e)
        {
            Cliente user = new Cliente();
            user.NCliente_nombre(optName.Text);
            dataGridView1.DataSource = user.Informacion(user.IdCliente);
        }
    }
}
