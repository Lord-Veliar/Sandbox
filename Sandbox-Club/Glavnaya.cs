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
       g.button1.Enabled = false;
            g.WindowState= FormWindowState.Maximized;
            g.Nazv.Text = "Гончарное дело";
            g.Opis.Text = "Освойте одно из самых загадочных и древнейших ремесел человечества. Профессионалы научат вас из обычного куска глины создавать настоящие шедевры. Они не только красивые, но и полезные в хозяйстве";
            this.Close();
        }

        private void ebru_Click(object sender, EventArgs e)
        {
   
            Holidays g = new Holidays();
            g.Show();
            g.button2.Enabled = false;
            g.WindowState = FormWindowState.Maximized;
            g.Nazv.Text = "Эбру";
            g.Opis.Text = "Рисование на воде - современный и необычный вид искусства. Если вдруг на обычных мастер-классах стало скучно, то Вам определенно нужно попробовать что-то новое. Именно эти недостающие впечатления способно дать Эбру";
            this.Close();
        }

        private void holiday_Click(object sender, EventArgs e)
        {
            Holidays g = new Holidays();
            g.Show();
            g.WindowState = FormWindowState.Maximized;
            g.button3.Enabled = false;
            g.Nazv.Text = "Организация праздников";
            g.Opis.Text = "Хочется отдохнуть и расслабиться, но при этом не скучать? Вы точно по адресу! Для Вас - праздники на любой вкус: крио-мороженное, шоколадный фантан, хрустящий попкорн с житким азотом и многое другое";
            this.Close();
        }

        private void music_Click(object sender, EventArgs e)
        {
            Holidays g = new Holidays();
            g.Show();
            g.WindowState = FormWindowState.Maximized;
            g.button4.Enabled = false;
            g.Nazv.Text = "Музыкальные вечера";
            g.Opis.Text = "Классическая музыка - один из сильнейших источников дофамина (гормона счастья) для нашего мозга. Добавьте к этому стол с чаем и другими напитками и вкусными угощениями. А еще - приятную компанию. Вот и все, вечер удался!";
            this.Close();
        }

        private void drawing_Click(object sender, EventArgs e)
        {
            Holidays g = new Holidays();
            g.Show();
            g.WindowState = FormWindowState.Maximized;
            g.button5.Enabled = false;
            g.Nazv.Text = "Рисование песком";
            g.Opis.Text = "Рисование песком - это то, с чего начинала свое существование наша организация. Здесь Вы пожете проявить свои творческие способности крайне необычным способом. Вы не только сможете создать настоящее произведение искусства, а еще - расслабиться и отдохнуть душевно. Вам будут помогать наши специалисты, а на фоне этой успокаивающей тишины в полумраке будет играть едва слышная приятная музыка";
            this.Close();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            menu.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
