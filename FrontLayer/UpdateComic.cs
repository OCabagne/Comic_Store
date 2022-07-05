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
    public partial class UpdateComic : Form
    {
        public UpdateComic()
        {
            InitializeComponent();
            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = "yyyy-MM-dd";
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

        private void UpdateComic_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comics comic = new Comics();
            comic.NComic(optComic.Text);

            txtEditorial.Text = comic.Editorial;
            txtPrecio.Text = comic.Precio.ToString();
            txtStatus.Text = comic.Status;
            txtDate.Text = comic.Fecha.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comics comic = new Comics();
            comic.NComic(optComic.Text);
            if(comic.Actualizar(txtEditorial.Text, float.Parse(txtPrecio.Text), txtStatus.Text, txtDate.Text, comic.IdComic))
            {
                MessageBox.Show("Ha ocurrido un error :(");
            }
            else
            {
                MessageBox.Show("Datos Actualizados");
                this.Close();
            }
        }
    }
}
