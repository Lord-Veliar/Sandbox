using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sandbox_Club
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            NameText.Enabled = false;
            NameText.Enabled = true;
            FFF.Enabled = false;
            FFF.Enabled = true;
            DataRozd.Enabled = false;
            DataRozd.Enabled = true;
            Email.Enabled = false;
            Email.Enabled = true;
            Pass.Enabled = false;
            Pass.Enabled = true;
            Pass2.Enabled = false;
            Pass2.Enabled = true;
        }



        private void Name_TextEnter(object sender, EventArgs e)
        {
            if (NameText.Text == "Имя")
            {
                NameText.Text = "";

                NameText.ForeColor = Color.Black;
            }
        }
        private void Name_TextLeave(object sender, EventArgs e)
        {

            if (NameText.Text == "")
            {
                NameText.Text = "Имя";
                NameText.ForeColor = Color.Gray;
            }
        }

      
        private void FFF_TextEnter(object sender, EventArgs e)
        {
            if (FFF.Text == "Фамилия")
            {
                FFF.Text = "";

                FFF.ForeColor = Color.Black;
            }
        }
        private void FFF_TextLeave(object sender, EventArgs e)
        {

            if (FFF.Text == "")
            {
                FFF.Text = "Фамилия";
               FFF.ForeColor = Color.Gray;
            }
        }
        private void DR_TextEnter(object sender, EventArgs e)
        {
            if (DataRozd.Text == "Дата рождения")
            {
                DataRozd.Text = "";

                DataRozd.ForeColor = Color.Black;
            }
        }
        private void DR_TextLeave(object sender, EventArgs e)
        {

            if (DataRozd.Text == "")
            {
                DataRozd.Text = "Дата рождения";
                DataRozd.ForeColor = Color.Gray;
            }
        }
        private void Email_TextEnter(object sender, EventArgs e)
        {
            if (Email.Text == "Email")
            {
                Email.Text = "";

                Email.ForeColor = Color.Black;
            }
        }
        private void Email_TextLeave(object sender, EventArgs e)
        {

            if (Email.Text == "")
            {
                Email.Text = "Email";
                Email.ForeColor = Color.Gray;
            }
        }
        private void Pass_TextEnter(object sender, EventArgs e)
        {
          
            if (Pass.Text == "Пароль")
            {
                Pass.Text = "";

                Pass.ForeColor = Color.Black;
            }
        }
        private void Pass_TextLeave(object sender, EventArgs e)
        {

            if (Pass.Text == "")
            {
                Pass.Text = "Пароль";
                Pass.ForeColor = Color.Gray;
                Pass.UseSystemPasswordChar = false;
            }
        }
        private void Pass2_TextEnter(object sender, EventArgs e)
        {
            if (Pass2.Text == "Повторите пароль")
            {
                Pass2.Text = "";

                Pass2.ForeColor = Color.Black;
            }
        }
        private void Pass2_TextLeave(object sender, EventArgs e)
        {

            if (Pass2.Text == "")
            {
                Pass2.Text = "Повторите пароль";
                Pass2.ForeColor = Color.Gray;
                Pass2.UseSystemPasswordChar = false;
            }
        }
        private void FFF_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataRozd_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^(?:0[1-9]|[12]\\d|3[01])([\\/.-])(?:0[1-9]|1[012])\\1(?:19|20)\\d\\d$");
            regex.IsMatch(DataRozd.Text);
        }

        private async void Reg_Click(object sender, EventArgs e)
        {
            
            string logss = @"dannie.txt";
            string ddan;
            ddan = Email.Text;
            File.WriteAllText(logss, ddan);
            string path = @"Аккаунты.csv";
            List<string> people = new List<string>();
            List<string> bufer = new List<string>();
            int ind = 0;
            int protect = 0;
            bufer = File.ReadAllLines(path).ToList();
            foreach (string st in bufer)
            {
                string[] bluf = st.Split(';');
                if (bluf[2] == Email.Text)
                {
                    protect++;
                }

            }
            Regex par = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+=])[0-9a-zA-z!@#$%^&*()_+=]{6,}$");
           
            if (protect == 0 && NameText.Text != "Имя" && FFF.Text != "Фамилия" && Email.Text != "Email" && Pass.Text != "Пароль"&&DataRozd.Text!="Дата рождения"&&Pass2.Text!="Повторите пароль"&&Pass.Text==Pass2.Text&&par.IsMatch(Pass.Text))
            {
                people.Add(NameText.Text);
                people.Add(FFF.Text);
                people.Add(DataRozd.Text);
                people.Add(Email.Text);
                people.Add(Pass.Text);
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    await writer.WriteLineAsync(people[ind] + ';' + people[ind + 1] + ';' + people[ind + 2] + ';' + people[ind + 3] + ';' + people[ind + 4]);
                    writer.Close();
                }
                ind++;
                Glavnaya glavnaya = new Glavnaya();
                glavnaya.Show();
                glavnaya.WindowState = FormWindowState.Maximized;
            }
            if (protect != 0)
            {
                MessageBox.Show("Этот E-mail уже используется для другого аккаунта", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (NameText.Text == "Имя" || FFF.Text == "Фамилия" || Email.Text == "Email" || Pass.Text == "Пароль"||Pass2.Text=="Повторите пароль"||DataRozd.Text=="Дата рождения")
            {
                MessageBox.Show("Заполните все обязательные поля", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Pass2.Text!=Pass.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (par.IsMatch(Pass.Text)==false)
            {
                MessageBox.Show("Требования:\nМинимум одна цифра\nМинимум одна строчная латинская буква\nМинимум одна прописная латинская буква\nМинимум один специальный символ\nПароль должен содержать не менее 6 символов", "Пароль не соответствует требованиям", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
         
            Pass.UseSystemPasswordChar=true;
        }

        private void Pass2_TextChanged(object sender, EventArgs e)
        {
            Pass2.UseSystemPasswordChar = true;
        }
 

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Avtoriz avtoriz = new Avtoriz();
            avtoriz.Show();
            avtoriz.WindowState = FormWindowState.Maximized;
        }
    }
}
