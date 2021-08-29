using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Project2
{
    public partial class loadingscreen : Form
    {
        int move = 2;
        public loadingscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelslide.Left += 2;
           
            if (panelslide.Left >= 197)
            {
                panelslide.Left = 0;

            }
            if (panelslide.Left < 0)
            {
                move = 2;
            }
           


        }

        private void loadingscreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void loadingscreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
