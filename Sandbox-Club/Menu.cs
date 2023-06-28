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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exx_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Prof_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profil profil= new Profil();
            profil.Show();
            profil.WindowState=FormWindowState.Maximized;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Glavnaya glavnaya = new Glavnaya();
            glavnaya.Show();
            glavnaya.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void Zap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Myz myz = new Myz();
            myz.Show();
            myz.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            profil.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Myz myz = new Myz();
            myz.Show();
            myz.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
