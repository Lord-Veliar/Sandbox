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
            Opis.Text = "Рисование песком - это то, с чего начинала свое существование наша организация. Здесь Вы пожете проявить свои творческие способности крайне необычным способом. Вы не только сможете создать настоящее произведение искусства, а еще - расслабиться и отдохнуть душевно. Вам будут помогать наши специалисты, а на фоне этой успокаивающей тишины в полумраке будет играть едва слышная приятная музыка";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            menu.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
