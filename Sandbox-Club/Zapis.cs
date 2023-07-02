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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sandbox_Club
{
    public partial class Zapis : Form
    {
        public Zapis()
        {
            InitializeComponent();
            date.MinDate = DateTime.Today;
            date.Format = DateTimePickerFormat.Short;
  
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.YellowGreen;
            button2.BackColor = Color.Orange;
            button3.BackColor = Color.Orange;
            oform.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
            button2.BackColor = Color.YellowGreen;
            button3.BackColor = Color.Orange;
            oform.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
            button2.BackColor = Color.Orange;
            button3.BackColor = Color.YellowGreen;
            oform.Enabled = true;
        }

        private void ost1_Click(object sender, EventArgs e)
        {

        }

        public async void oform_Click(object sender, EventArgs e)
        {
            string logss = @"dannie.txt";
            string path = @"Аккаунты.csv";
            string path2 = @"Записи.csv";
            List<string> people = new List<string>();
            List<string> bufer = new List<string>();
            List<string> zap = new List<string>();
            bufer = File.ReadAllLines(path).ToList();
            string dan;
            dan = File.ReadAllText(logss);
            foreach (string st in bufer)
            {
                string[] bluf = st.Split(';');
                if (bluf[3] == dan)
                {
                    zap.Add(bluf[0]);
                    zap.Add(bluf[1]);
                    zap.Add(label1.Text);
                    //string[] dr = date.Text.Split(' ');
                    //switch (dr[1])
                    //{
                    //    case "января":
                    //        dr[1] = "01";
                    //        break;
                    //    case "февраля":
                    //        dr[1] = "02";
                    //        break;
                    //    case "марта":
                    //        dr[1] = "03";
                    //        break;
                    //    case "апреля":
                    //        dr[1] = "04";
                    //        break;
                    //    case "мая":
                    //        dr[1] = "05";
                    //        break;
                    //    case "июня":
                    //        dr[1] = "06";
                    //        break;
                    //    case "июля":
                    //        dr[1] = "07";
                    //        break;
                    //    case "августа":
                    //        dr[1] = "08";
                    //        break;
                    //    case "сентября":
                    //        dr[1] = "09";
                    //        break;
                    //    case "октября":
                    //        dr[1] = "10";
                    //        break;
                    //    case "ноября":
                    //        dr[1] = "11";
                    //        break;
                    //    case "декабря":
                    //        dr[1] = "12";
                    //        break;
                    //}
                    //dr1 = dr[0] + "." + dr[1] + "." + dr[2];
                    zap.Add(date.Text);
                    if (button1.BackColor == Color.YellowGreen)
                    {

                        zap.Add(button1.Text);
                    }
                if (button2.BackColor == Color.YellowGreen)
                    {
                        zap.Add(button2.Text);
                    }
                    if (button3.BackColor == Color.YellowGreen)
                    {
                        zap.Add(button3.Text);
                    }
                    zap.Add(dan);
                    using (StreamWriter writer = new StreamWriter(path2, true))
                    {
                        await writer.WriteLineAsync(zap[0] + ';' + zap[1] + ';' + zap[2] + ';' + zap[3] + ';' + zap[4] + ';' + zap[5]);
                        writer.Close();
                    }
                    //File.WriteAllText(path2, "");
                    //File.WriteAllLines(path2, zap);
                }

            }
            this.Close();
        
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            //button1.Enabled = true;
            //button2.Enabled = true;
            //button3.Enabled = true;
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
                if (bluf[2] == label1.Text && bluf[3] == date.Text)
                {
                    if (bluf[4] == button1.Text)
                    {
                        sh1++;
                    }
                    if (bluf[4] == button2.Text)
                    {
                        sh2++;
                    }
                    if (bluf[4] == button3.Text)
                    {
                        sh3++;
                    }
                }
               
            }
            if (label1.Text == "Музыкальные вечера")
            {
                //cv1 = 1 - sh1;
                //cv2 = 1 - sh2;
                //cv3 = 1 - sh3;
                //ost1.Text = Convert.ToString(cv1);
                //ost2.Text = Convert.ToString(cv2);
                //ost3.Text = Convert.ToString(cv3);
                label3.Text = "Данное мероприятие-приватное. Вход только для Вас и Ваших друзей.";
                la1.Text = "";
                la2.Text = "";
                la3.Text = "";
                ost1.Text = "";
                ost2.Text = "";
                ost3.Text = "";
            }
            if (label1.Text == "Гончарное дело")
            {
                cv1 = 7 - sh1;
                cv2 = 7 - sh2;
                cv3 = 7 - sh3;
                ost1.Text = Convert.ToString(cv1);
                ost2.Text = Convert.ToString(cv2);
                ost3.Text = Convert.ToString(cv3);
            }
            if (label1.Text == "Эбру")
            {
                cv1 = 6 - sh1;
                cv2 = 6 - sh2;
                cv3 = 6 - sh3;
                ost1.Text = Convert.ToString(cv1);
                ost2.Text = Convert.ToString(cv2);
                ost3.Text = Convert.ToString(cv3);
            }
            if (label1.Text == "Организация праздников")
            {
                //cv1 = 1 - sh1;
                //cv2 = 1 - sh2;
                //cv3 = 1 - sh3;
                //ost1.Text = Convert.ToString(cv1);
                //ost2.Text = Convert.ToString(cv2);
                //ost3.Text = Convert.ToString(cv3);
                label3.Text = "Данное мероприятие-приватное. Вход только для Вас и Ваших друзей.";
                la1.Text = "";
                la2.Text = "";
                la3.Text = "";
                ost1.Text = "";
                ost2.Text = "";
                ost3.Text = "";
            }
            if (label1.Text == "Рисование песком")
            {
                cv1 = 10 - sh1;
                cv2 = 10 - sh2;
                cv3 = 10 - sh3;
                ost1.Text = Convert.ToString(cv1);
                ost2.Text = Convert.ToString(cv2);
                ost3.Text = Convert.ToString(cv3);
            }
            if (button1.Text != "Нет записи"&&((label1.Text=="Гончарное дело"&&7-sh1>=1)||(label1.Text == "Эбру" && 6 - sh1 >= 1) || (label1.Text == "Организация праздников" && 1 - sh1 >= 1) || (label1.Text == "Музыкальные вечера" && 1 - sh1 >= 1) || (label1.Text == "Рисование песком" && 10 - sh1 >= 1)))
            {
                button1.Enabled = true;
            }
            button1.BackColor = Color.Orange;
            if (button2.Text != "Нет записи" && ((label1.Text == "Гончарное дело" && 7 - sh2 >= 1) || (label1.Text == "Эбру" && 6 - sh2 >= 1) || (label1.Text == "Организация праздников" && 1 - sh2 >= 1) || (label1.Text == "Музыкальные вечера" && 1 - sh2 >= 1) || (label1.Text == "Рисование песком" && 10 - sh2 >= 1)))
            {
                button2.Enabled = true;
            }
            button2.BackColor = Color.Orange;
            if (button3.Text != "Нет записи" && ((label1.Text == "Гончарное дело" && 7 - sh3>= 1) || (label1.Text == "Эбру" && 6 - sh3 >= 1) || (label1.Text == "Организация праздников" && 1 - sh3 >= 1) || (label1.Text == "Музыкальные вечера" && 1 - sh3 >= 1) || (label1.Text == "Рисование песком" && 10 - sh3 >= 1)))
            {
                button3.Enabled = true;
            }
            if (Convert.ToString(date.Text + " 0:00:00") == Convert.ToString(date.MinDate))
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                oform.Enabled = false;
            }
            button3.BackColor = Color.Orange;
      
            foreach (string st in people)
            {
                string[] bluf = st.Split(';');
                if (bluf[5] == dan && bluf[2] == label1.Text && bluf[3] == date.Text)
                {
                    oform.Enabled = false;
                    label6.Text = "Вы уже записаны на данное мероприятие в этот день";
                    if (bluf[4] == button1.Text)
                    {
                        button1.BackColor = Color.YellowGreen;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                    }
                    if (bluf[4] == button2.Text)
                    {
                        button2.BackColor = Color.YellowGreen;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                    }
                    if (bluf[4] == button3.Text)
                    {
                        button3.BackColor = Color.YellowGreen;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                    }
                }
            }
        }

      
    }
}
