using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using курсовая_работа.View;

namespace курсовая_работа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
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

        private void label_information_Click(object sender, EventArgs e)
        {
            Form3 result = new Form3();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }
        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }     
    }
}
