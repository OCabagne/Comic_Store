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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();
            user.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSusc susc = new AddSusc();
            susc.Show();
        }
    }
}
