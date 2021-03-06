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
    public partial class AdminComic : Form
    {
        public AdminComic()
        {
            InitializeComponent();
        }

        private void cmdLog_Click(object sender, EventArgs e)
        {
            Buscar busc = new Buscar();
            busc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddComic add = new AddComic();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateComic up = new UpdateComic();
            up.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddSerie serie = new AddSerie();
            serie.Show();
        }
    }
}
