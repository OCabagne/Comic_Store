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
    public partial class AddComic : Form
    {
        public AddComic()
        {
            InitializeComponent();
            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = "yyyy-MM-dd";
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

        private void AddComic_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comics comic = new Comics();
            if(comic.Registro(txtName.Text, txtEditorial.Text, txtStatus.Text, float.Parse(txtPrice.Text), txtDate.Text))
            {
                MessageBox.Show("Ha ocurrido un error :(");
            }
            else
            {
                MessageBox.Show("Comic Guardado");
            }
        }
    }
}
