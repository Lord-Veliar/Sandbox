using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandbox_Club
{
    public partial class Glavnaya : Form
    {
        public Glavnaya()
        {
            InitializeComponent();
        }


        private void PicBox_Paint_1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.ClientRectangle, Color.FromArgb(255, 214, 0), ButtonBorderStyle.Solid);
        }

        private void ggg_Click(object sender, EventArgs e)
        {
            Holidays g = new Holidays();
            g.Show();
            g.WindowState= FormWindowState.Maximized;
            this.Close();
        }

        private void ebru_Click(object sender, EventArgs e)
        {
            Holidays g = new Holidays();
            g.Show();
            g.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void holiday_Click(object sender, EventArgs e)
        {
            Holidays g = new Holidays();
            g.Show();
            g.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void music_Click(object sender, EventArgs e)
        {
            Holidays g = new Holidays();
            g.Show();
            g.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void drawing_Click(object sender, EventArgs e)
        {
            Holidays g = new Holidays();
            g.Show();
            g.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
