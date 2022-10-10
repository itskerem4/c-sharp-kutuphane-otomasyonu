using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();

            logout.Show();

            this.Hide();

        }

        private void books_Click(object sender, EventArgs e)
        {
            bookmenu books = new bookmenu();

            books.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            date.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookadd bookaddpanel = new bookadd();

            bookaddpanel.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            emanetislemi emanetpanel = new emanetislemi();

            emanetpanel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            users userpanel = new users();

            userpanel.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            useredit usereditpanel = new useredit();

            usereditpanel.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            passupdate passpanel = new passupdate();

            passpanel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emanetverilen panelver = new emanetverilen();

            panelver.Show();
        }
    }
}
