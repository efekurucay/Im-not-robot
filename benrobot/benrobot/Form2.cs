using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace benrobot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Point konum;
        private void resim_MouseDown(object sender, MouseEventArgs e)
        {
            konum = e.Location;
        }

        private void resim_MouseMove(object sender, MouseEventArgs e)
        {
           if (e.Button == MouseButtons.Left)
            {
                resim.Left += e.Location.X-(konum.X);
         
            }

        }
    }
}
