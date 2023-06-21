using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandbox_Club
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            string logss = @"dannie.txt";
            string path = @"Аккаунты.csv";
            List<string> people = new List<string>();
            List<string> bufer = new List<string>();
            string dan;
            dan = File.ReadAllText(logss);


            bufer = File.ReadAllLines(path).ToList();
            foreach (string st in bufer)
            {
                string[] bluf = st.Split(';');
                if (bluf[3] == dan)
                {

                    RedIm.Text = bluf[0];
                    RedFm.Text = bluf[1];
                    RedEm.Text = bluf[3];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RedIm.Text != "" && RedFm.Text != "")
            {
                int cub = 0;
                int vc = 0;
                string logss = @"dannie.txt";
                string path = @"Аккаунты.csv";
                List<string> bufer = new List<string>();
                string dan;
                dan = File.ReadAllText(logss);
                bufer = File.ReadAllLines(path).ToList();

                for (int i = 0; i < bufer.Count; i++)
                {

                    string[] bluf = bufer[i].Split(';');
                    bufer[vc] = bluf[0] + ';' + bluf[1] + ';' + bluf[2] + ';' + bluf[3] + ';' + bluf[4];
                    if (bluf[3] == dan)
                    {
                        cub = vc;
                        bufer[cub] = RedIm.Text + ';' + RedFm.Text + ';' + bluf[2] + ';' + bluf[3] + ';' + bluf[4];

                        break;
                    }
                    vc++;


                }

                File.WriteAllText(path, "");
                File.WriteAllLines(path, bufer);
                bufer = File.ReadAllLines(path).ToList();
                MessageBox.Show("Изменения сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Введенные данные некорректны", "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int protect = 0;
            int cub = 0;
            int vc = 0;
            string test;
            int testr = 0;
            string logss = @"dannie.txt";
            string path = @"Аккаунты.csv";
            List<string> bufer = new List<string>();
            string dan;
            dan = File.ReadAllText(logss);
            bufer = File.ReadAllLines(path).ToList();
            if (RedEm.Text != "")
            {

                for (int i = 0; i < bufer.Count; i++)
                {

                    string[] bluf = bufer[i].Split(';');
                    if (bluf[3] == RedEm.Text)
                        testr++;
                    //bufer[vc] = bluf[0] + ';' + bluf[1] + ';' + bluf[2] + ';' + bluf[3];
                    if (bluf[3] == dan && testr == 0)
                    {
                        test = bluf[3];
                        cub = vc;
                        bufer[cub] = bluf[0] + ';' + bluf[1] + ';' +bluf[2]+';'+ RedEm.Text + ';' + bluf[4];
                        File.WriteAllText(logss, RedEm.Text);
                        //break;
                        protect++;
                    }
                    vc++;



                }


            }
            if (RedEm.Text == "")
            {
                MessageBox.Show("Введенные данные некорректны", "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (protect > 0 && testr == 0)
            {

                File.WriteAllLines(path, bufer);
                MessageBox.Show("Изменения сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (protect <= 0 && testr > 0)
            {
                MessageBox.Show("Аккаунт с этим Email уже существует", "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cub = 0;
            int vc = 0;
            int xzx = 0;
            string suc = "";
            string logss = @"dannie.txt";
            string path = @"Аккаунты.csv";
            List<string> bufer = new List<string>();
            string dan;
            dan = File.ReadAllText(logss);
            bufer = File.ReadAllLines(path).ToList();
            Regex par = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+=])[0-9a-zA-z!@#$%^&*()_+=]{6,}$");
            for (int i = 0; i < bufer.Count; i++)
            {

                string[] bluf = bufer[i].Split(';');
                bufer[vc] = bluf[0] + ';' + bluf[1] + ';' + bluf[2] + ';' + bluf[3] + ';' + bluf[4];
                if (bluf[3] == dan)
                {
                    cub = vc;
                    suc = bluf[4];
                    bufer[cub] = bluf[0] + ';' + bluf[1] + ';' + bluf[2] + ';' + bluf[3] + ';' + Rednpass.Text;
                    break;
                }
                vc++;

            }
            if(par.IsMatch(Rednpass.Text))
            {
                xzx++;
            }
            if (RedPass.Text == suc && Rednpass.Text != ""&&par.IsMatch(Rednpass.Text))
            {
                File.WriteAllText(path, "");
                File.WriteAllLines(path, bufer);
                MessageBox.Show("Изменения сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (RedPass.Text == "" || Rednpass.Text == "" || RedPass.Text != suc)
            {
                MessageBox.Show("Введенные данные некорректны", "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if(RedPass.Text == suc && Rednpass.Text != "" && xzx==0)
            {
                MessageBox.Show("Требования:\nМинимум одна цифра\nМинимум одна строчная латинская буква\nМинимум одна прописная латинская буква\nМинимум один специальный символ\nПароль должен содержать не менее 6 символов", "Пароль не соответствует требованиям", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
