using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая_работа.View
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form1 result = new Form1();
            result.Show();
            result.Location = this.Location;
            this.Hide();

        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_start_Click(object sender, EventArgs e)
        {
            Form2 result = new Form2();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }
    }
}
