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
            date.MinDate = DateTime.Now;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.YellowGreen;
            button2.BackColor = Color.Orange;
            button3.BackColor = Color.Orange;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
            button2.BackColor = Color.YellowGreen;
            button3.BackColor = Color.Orange;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
            button2.BackColor = Color.Orange;
            button3.BackColor = Color.YellowGreen;
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
            //zap= File.ReadAllLines(path2).ToList();
            dan = File.ReadAllText(logss);
            string dr1;
            foreach (string st in bufer)
            {
                string[] bluf = st.Split(';');
                if (bluf[3] == dan)
                {
                    zap.Add(bluf[0]);
                    zap.Add(bluf[1]);
                    zap.Add(label1.Text);
                    string[] dr = date.Text.Split(' ');
                    switch (dr[1])
                    {
                        case "января":
                            dr[1] = "01";
                            break;
                        case "февраля":
                            dr[1] = "02";
                            break;
                        case "марта":
                            dr[1] = "03";
                            break;
                        case "апреля":
                            dr[1] = "04";
                            break;
                        case "мая":
                            dr[1] = "05";
                            break;
                        case "июня":
                            dr[1] = "06";
                            break;
                        case "июля":
                            dr[1] = "07";
                            break;
                        case "августа":
                            dr[1] = "08";
                            break;
                        case "сентября":
                            dr[1] = "09";
                            break;
                        case "октября":
                            dr[1] = "10";
                            break;
                        case "ноября":
                            dr[1] = "11";
                            break;
                        case "декабря":
                            dr[1] = "12";
                            break;
                    }
                    dr1 = dr[0] + "." + dr[1] + "." + dr[2];
                    zap.Add(dr1);
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
                    using (StreamWriter writer = new StreamWriter(path2, true))
                    {
                        await writer.WriteLineAsync(zap[0] + ';' + zap[1] + ';' + zap[2] + ';' + zap[3] + ';' + zap[4]);
                        writer.Close();
                    }
                    //File.WriteAllText(path2, "");
                    //File.WriteAllLines(path2, zap);
                }

            }
        }
    }
}
