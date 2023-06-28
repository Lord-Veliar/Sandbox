using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandbox_Club
{
    public partial class Holidays : Form
    {
        public Holidays()
        {
            InitializeComponent();
        }

        private void Pic_paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.ClientRectangle, Color.FromArgb(255, 214, 0), ButtonBorderStyle.Solid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            Nazv.Text = "Гончарное дело";
            Opis.Text = "Освойте одно из самых загадочных и древнейших ремесел человечества. Профессионалы научат вас из обычного куска глины создавать настоящие шедевры. Они не только красивые, но и полезные в хозяйстве";
            pictureBox2.Image = Properties.Resources.гончар;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            Nazv.Text = "Эбру";
            Opis.Text = "Рисование на воде - современный и необычный вид искусства. Если вдруг на обычных мастер-классах стало скучно, то Вам определенно нужно попробовать что-то новое. Именно эти недостающие впечатления способно дать Эбру";
            pictureBox2.Image = Properties.Resources.эбру;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            Nazv.Text = "Организация праздников";
            Opis.Text = "Хочется отдохнуть и расслабиться, но при этом не скучать? Вы точно по адресу! Для Вас - праздники на любой вкус: крио-мороженное, шоколадный фантан, хрустящий попкорн с житким азотом и многое другое";
            pictureBox2.Image = Properties.Resources.праздники;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;
            Nazv.Text = "Музыкальные вечера";
            Opis.Text = "Классическая музыка - один из сильнейших источников дофамина (гормона счастья) для нашего мозга. Добавьте к этому стол с чаем и другими напитками и вкусными угощениями. А еще - приятную компанию. Вот и все, вечер удался!";
            pictureBox2.Image = Properties.Resources.музыка;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = true;
            Nazv.Text = "Рисование песком";
            Opis.Text = "Рисование песком - это то, с чего начинала свое существование наша организация. Здесь Вы можете проявить свои творческие способности крайне необычным способом. Вы не только сможете создать настоящее произведение искусства, а еще - расслабиться и отдохнуть душевно. Вам будут помогать наши специалисты, а на фоне этой успокаивающей тишины в полумраке будет играть едва слышная приятная музыка";
            pictureBox2.Image = Properties.Resources.песок;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            menu.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Zapis zapis = new Zapis();
            zapis.Show();
            if (Nazv.Text == "Гончарное дело")
            {
                zapis.label1.Text = "Гончарное дело";

                zapis.button1.Text = "10:00-11:00";

                zapis.button2.Text = "12:30-13:30";

                zapis.button3.Text = "16:00-17:00";

            }
            if (Nazv.Text == "Эбру")
            {
                zapis.label1.Text = "Эбру";

                zapis.button1.Text = "8:30-10:00";

                zapis.button2.Text = "11:00-12:30";
            }
            if (Nazv.Text == "Организация праздников")
            {
                zapis.label1.Text = "Организация праздников";

                zapis.button1.Text = "13:30-15:30";

                zapis.button2.Text = "18:00-20:00";
            }
            if (Nazv.Text == "Музыкальные вечера")
            {
                zapis.label1.Text = "Музыкальные вечера";

                zapis.button1.Text = "20:00-21:30";

                zapis.button2.Text = "21:30-23:00";
            }
            if (Nazv.Text == "Рисование песком")
            {
                zapis.label1.Text = "Рисование песком";

                zapis.button1.Text = "17:00-18:00";

            }
            string logss = @"dannie.txt";
            string path2 = @"Записи.csv";
            List<string> people = new List<string>();
            people = File.ReadAllLines(path2).ToList();
            string dan;
            dan = File.ReadAllText(logss);
            int sh1 = 0;
            int sh2 = 0;
            int sh3 = 0;
            int cv1 = 0;
            int cv2 = 0;
            int cv3 = 0;
            foreach (string st in people)
            {
                string[] bluf = st.Split(';');
                if (bluf[2] == zapis.label1.Text && bluf[3] == zapis.date.Text)
                {
                    if (bluf[4] == zapis.button1.Text)
                    {
                        sh1++;
                    }
                    if (bluf[4] == zapis.button2.Text)
                    {
                        sh2++;
                    }
                    if (bluf[4] == zapis.button3.Text)
                    {
                        sh3++;
                    }
                }

            }
            if (zapis.label1.Text == "Музыкальные вечера")
            {
                //cv1 = 1 - sh1;
                //cv2 = 1 - sh2;
                //cv3 = 1 - sh3;
                //ost1.Text = Convert.ToString(cv1);
                //ost2.Text = Convert.ToString(cv2);
                //ost3.Text = Convert.ToString(cv3);
                zapis.label3.Text = "Данное мероприятие-приватное. Вход только для Вас и Ваших друзей.";
                zapis.la1.Text = "";
                zapis.la2.Text = "";
                zapis.la3.Text = "";
                zapis.ost1.Text = "";
                zapis.ost2.Text = "";
                zapis.ost3.Text = "";
            }
            if (zapis.label1.Text == "Гончарное дело")
            {
                cv1 = 7 - sh1;
                cv2 = 7 - sh2;
                cv3 = 7 - sh3;
                zapis.ost1.Text = Convert.ToString(cv1);
                zapis.ost2.Text = Convert.ToString(cv2);
                zapis.ost3.Text = Convert.ToString(cv3);
            }
            if (zapis.label1.Text == "Эбру")
            {
                cv1 = 6 - sh1;
                cv2 = 6 - sh2;
                cv3 = 6 - sh3;
                zapis.ost1.Text = Convert.ToString(cv1);
                zapis.ost2.Text = Convert.ToString(cv2);
                zapis.ost3.Text = Convert.ToString(cv3);
            }
            if (zapis.label1.Text == "Организация праздников")
            {
                //cv1 = 1 - sh1;
                //cv2 = 1 - sh2;
                //cv3 = 1 - sh3;
                //ost1.Text = Convert.ToString(cv1);
                //ost2.Text = Convert.ToString(cv2);
                //ost3.Text = Convert.ToString(cv3);
                zapis.label3.Text = "Данное мероприятие-приватное. Вход только для Вас и Ваших друзей.";
                zapis.la1.Text = "";
                zapis.la2.Text = "";
                zapis.la3.Text = "";
                zapis.ost1.Text = "";
                zapis.ost2.Text = "";
                zapis.ost3.Text = "";
            }
            if (zapis.label1.Text == "Рисование песком")
            {
                cv1 = 10 - sh1;
                cv2 = 10 - sh2;
                cv3 = 10 - sh3;
                zapis.ost1.Text = Convert.ToString(cv1);
                zapis.ost2.Text = Convert.ToString(cv2);
                zapis.ost3.Text = Convert.ToString(cv3);
            }
            if (zapis.button1.Text != "Нет записи" && ((zapis.label1.Text == "Гончарное дело" && 7 - sh1 >= 1) || (zapis.label1.Text == "Эбру" && 6 - sh1 >= 1) || (zapis.label1.Text == "Организация праздников" && 1 - sh1 >= 1) || (zapis.label1.Text == "Музыкальные вечера" && 1 - sh1 >= 1) || (zapis.label1.Text == "Рисование песком" && 10 - sh1 >= 1)))
            {
                zapis.button1.Enabled = true;
            }
            zapis.button1.BackColor = Color.Orange;
            if (zapis.button2.Text != "Нет записи" && ((zapis.label1.Text == "Гончарное дело" && 7 - sh2 >= 1) || (zapis.label1.Text == "Эбру" && 6 - sh2 >= 1) || (zapis.label1.Text == "Организация праздников" && 1 - sh2 >= 1) || (zapis.label1.Text == "Музыкальные вечера" && 1 - sh2 >= 1) || (zapis.label1.Text == "Рисование песком" && 10 - sh2 >= 1)))
            {
                zapis.button2.Enabled = true;
            }
            zapis.button2.BackColor = Color.Orange;
            if (zapis.button3.Text != "Нет записи" && ((zapis.label1.Text == "Гончарное дело" && 7 - sh3 >= 1) || (zapis.label1.Text == "Эбру" && 6 - sh3 >= 1) || (zapis.label1.Text == "Организация праздников" && 1 - sh3 >= 1) || (zapis.label1.Text == "Музыкальные вечера" && 1 - sh3 >= 1) || (zapis.label1.Text == "Рисование песком" && 10 - sh3 >= 1)))
            {
                zapis.button3.Enabled = true;
            }
            if (Convert.ToString(zapis.date.Text + " 0:00:00") == Convert.ToString(zapis.date.MinDate))
            {
                zapis.button1.Enabled = false;
                zapis.button2.Enabled = false;
                zapis.button3.Enabled = false;
                zapis.oform.Enabled = false;
            }
            zapis.button3.BackColor = Color.Orange;

            foreach (string st in people)
            {
                string[] bluf = st.Split(';');
                if (bluf[5] == dan && bluf[2] == zapis.label1.Text && bluf[3] == zapis.date.Text)
                {
                    zapis.oform.Enabled = false;
                    zapis.label4.Text = "Вы уже записаны на данное мероприятие в этот день";
                    if (bluf[4] == zapis.button1.Text)
                    {
                        zapis.button1.BackColor = Color.YellowGreen;
                        zapis.button1.Enabled = false;
                        zapis.button2.Enabled = false;
                        zapis.button3.Enabled = false;
                    }
                    if (bluf[4] == zapis.button2.Text)
                    {
                        zapis.button2.BackColor = Color.YellowGreen;
                        zapis.button1.Enabled = false;
                        zapis.button2.Enabled = false;
                        zapis.button3.Enabled = false;
                    }
                    if (bluf[4] == zapis.button3.Text)
                    {
                        zapis.button3.BackColor = Color.YellowGreen;
                        zapis.button1.Enabled = false;
                        zapis.button2.Enabled = false;
                        zapis.button3.Enabled = false;
                    }
                }
            }
        }
    }
}
