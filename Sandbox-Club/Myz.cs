using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandbox_Club
{
    public partial class Myz : Form
    {
        public Myz()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Все", "Гончарное дело", "Эбру", "Организация праздников", "Музыкальные вечера", "Рисование песком" });
        }

        private void Myz_Load(object sender, EventArgs e)
        {
            radioButton1.Select();
            comboBox1.SelectedIndex = 0;

  
        }

        private void filtr_Click(object sender, EventArgs e)
        {
            label2.Text = "Мероприятие";
            label3.Text = "Дата";
            label4.Text = "Время";
            string logss = @"dannie.txt";
            string path2 = @"Записи.csv";
            List<string> people = new List<string>();
            List<string> rezerv = new List<string>();
            rezerv = File.ReadAllLines(path2).ToList();
            string dan;
            dan = File.ReadAllText(logss);
            foreach (string st in rezerv)
            {
                string[] bluf = st.Split(';');
                if (bluf[5] == dan)
                {
                    if (radioButton1.Checked==true)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            if (Convert.ToDateTime(bluf[3]) > DateTime.Today)
                            {

                                label2.Text = label2.Text + "\n" + bluf[2];
                                label3.Text = label3.Text + "\n" + bluf[3];
                                label4.Text = label4.Text + "\n" + bluf[4];

                            }
                        }
                        if (comboBox1.SelectedIndex == 1)
                        {
                            if (Convert.ToDateTime(bluf[3]) > DateTime.Today)
                            {
                                if (bluf[2]=="Гончарное дело")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }
                              

                            }
                        }
                        if (comboBox1.SelectedIndex == 2)
                        {
                            if (Convert.ToDateTime(bluf[3]) > DateTime.Today)
                            {
                                if (bluf[2] == "Эбру")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            }
                        }
                        if (comboBox1.SelectedIndex == 3)
                        {
                            if (Convert.ToDateTime(bluf[3]) > DateTime.Today)
                            {
                                if (bluf[2] == "Организация праздников")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            }
                        }
                        if (comboBox1.SelectedIndex == 4)
                        {
                            if (Convert.ToDateTime(bluf[3]) > DateTime.Today)
                            {
                                if (bluf[2] == "Музыкальные вечера")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            }
                        }
                        if (comboBox1.SelectedIndex == 5)
                        {
                            if (Convert.ToDateTime(bluf[3]) > DateTime.Today)
                            {
                                if (bluf[2] == "Рисование песком")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            }
                        }
                    }
                    if (radioButton2.Checked == true)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            if (Convert.ToDateTime(bluf[3]) <= DateTime.Today)
                            {

                                label2.Text = label2.Text + "\n" + bluf[2];
                                label3.Text = label3.Text + "\n" + bluf[3];
                                label4.Text = label4.Text + "\n" + bluf[4];

                            }
                        }
                        if (comboBox1.SelectedIndex == 1)
                        {
                            if (Convert.ToDateTime(bluf[3]) <= DateTime.Today)
                            {
                                if (bluf[2] == "Гончарное дело")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            }
                        }
                        if (comboBox1.SelectedIndex == 2)
                        {
                            if (Convert.ToDateTime(bluf[3]) <= DateTime.Today)
                            {
                                if (bluf[2] == "Эбру")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            }
                        }
                        if (comboBox1.SelectedIndex == 3)
                        {
                            if (Convert.ToDateTime(bluf[3]) <= DateTime.Today)
                            {
                                if (bluf[2] == "Организация праздников")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            }
                        }
                        if (comboBox1.SelectedIndex == 4)
                        {
                            if (Convert.ToDateTime(bluf[3]) <=DateTime.Today)
                            {
                                if (bluf[2] == "Музыкальные вечера")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            }
                        }
                        if (comboBox1.SelectedIndex == 5)
                        {
                            if (Convert.ToDateTime(bluf[3]) <= DateTime.Today)
                            {
                                if (bluf[2] == "Рисование песком")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            }
                        }
                    }
                    if (radioButton3.Checked == true)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            

                                label2.Text = label2.Text + "\n" + bluf[2];
                                label3.Text = label3.Text + "\n" + bluf[3];
                                label4.Text = label4.Text + "\n" + bluf[4];

                            
                        }
                        if (comboBox1.SelectedIndex == 1)
                        {
                            
                                if (bluf[2] == "Гончарное дело")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            
                        }
                        if (comboBox1.SelectedIndex == 2)
                        {
                            
                                if (bluf[2] == "Эбру")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            
                        }
                        if (comboBox1.SelectedIndex == 3)
                        {
                            
                                if (bluf[2] == "Организация праздников")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            
                        }
                        if (comboBox1.SelectedIndex == 4)
                        {
                            
                                if (bluf[2] == "Музыкальные вечера")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            
                        }
                        if (comboBox1.SelectedIndex == 5)
                        {
                            
                                if (bluf[2] == "Рисование песком")
                                {
                                    label2.Text = label2.Text + "\n" + bluf[2];
                                    label3.Text = label3.Text + "\n" + bluf[3];
                                    label4.Text = label4.Text + "\n" + bluf[4];
                                }


                            
                        }
                    }
                }
            }
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            menu.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
