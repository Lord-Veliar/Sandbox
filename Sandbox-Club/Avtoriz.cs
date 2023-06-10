using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sandbox_Club
{
    public partial class Avtoriz : Form
    {
        public Avtoriz()
        {
            InitializeComponent();
        }

        private void Avtoriz_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            GEmail.Enabled = false;
            GPass.Enabled = false;
            GEmail.Enabled = true;

            GPass.Enabled = true;
            string logss = @"dannie.txt";
            File.Delete(logss);
            using (var fileStream = File.Create(logss))
            {

            }
            string pokupki = @"pokp.txt";
            string tht = @"theni.txt";
            File.Delete(pokupki);
            File.Delete(tht);
            using (var fileStream = File.Create(pokupki))
            {

            }

            using (var fileStream = File.Create(tht))
            {

            }
        }
        private void GEmail_TextEnter(object sender, EventArgs e)
        {
            if (GEmail.Text == "Email")
            {
                GEmail.Text = "";

                GEmail.ForeColor = Color.Black;
            }
        }
        private void GEmail_TextLeave(object sender, EventArgs e)
        {

            if (GEmail.Text == "")
            {
                GEmail.Text = "Email";
                GEmail.ForeColor = Color.Gray;
            }
        }
        private void GPass_TextEnter(object sender, EventArgs e)
        {

            if (GPass.Text == "Пароль")
            {
                GPass.Text = "";

                GPass.ForeColor = Color.Black;
                GPass.UseSystemPasswordChar = false;
            }
        }
        private void GPass_TextLeave(object sender, EventArgs e)
        {

            if (GPass.Text == "")
            {
                GPass.Text = "Пароль";
                GPass.ForeColor = Color.Gray;
                GPass.UseSystemPasswordChar = false;
            }
        }

        private void GPass_TextChanged(object sender, EventArgs e)
        {
            GPass.UseSystemPasswordChar = true;
        }
        public string pe = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"Аккаунты.csv";
            List<string> people = new List<string>();
            List<string> bufer = new List<string>();
            int protect = 0;
         bufer = File.ReadAllLines(path).ToList();
            foreach (string st in bufer)
            {
                string[] bluf = st.Split(';');
                if (bluf[3] == GEmail.Text && bluf[4] == GPass.Text)
                {
                    protect++;
                    pe = bluf[3];
                }

            }
            if (protect > 0)
            {
                string logss = @"dannie.txt";
                File.WriteAllText(logss, pe);
                Glavnaya glavnaya = new Glavnaya();
                glavnaya.Show();
                glavnaya.WindowState = FormWindowState.Maximized;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.WindowState= FormWindowState.Maximized;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
