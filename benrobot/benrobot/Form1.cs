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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //152,94
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            parca.Left = tb.Value-20;
        }

        private void tb_MouseUp(object sender, MouseEventArgs e)
        {
            if (parca.Left<158 && 145<parca.Left)//145-158
            {
                MessageBox.Show("BAŞARILI");
            }
            else
            {
                MessageBox.Show("HATALI KONUM");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
