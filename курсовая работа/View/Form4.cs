using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace курсовая_работа.View
{
    public partial class Form4 : Form
    {
        DateTime date;
        public Form2 mF;
        public string text;
        public int index;
        public Form4(Form2 form2)
        {
            InitializeComponent();
            mF = form2;
            index = -1;
        }
        public Form4()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("При выходе данные не будут сохранены,вы уверены,что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
            }
            else
            {
                Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
                bool a = false, b = false, c = false, d = false, f = false, g = false, h = false, l = false, m = false, n = false;
                try
                {
                    a = Regex.IsMatch(textBox1.Text, @"^[а-яА-ЯёЁ]+$");
                    if (a == false) { throw new Exception(); }
                }
                catch (Exception) { textBox1.Text = "Ошибка"; }
                try
                {
                    b = Regex.IsMatch(textBox2.Text, @"^[а-яА-ЯёЁ]+$");
                    if (b == false) { throw new Exception(); }
                }
                catch (Exception) { textBox2.Text = "Ошибка"; }
                try
                {
                if (textBox3.Text == "М" || textBox3.Text == "Ж") { c = true; }
                else { throw new Exception(); }
                }
                catch (Exception) { textBox3.Text = "Ошибка"; }
                 string aa = "" + dateTimePicker1.Value;
                 string[] text = aa.Split(' ');
                 string s = text[0];
                 string[] dat = s.Split('.');
                 string day = dat[0];
                 string mount = dat[1];
                 string year = dat[2];
                try
                {
                    if (int.Parse(textBox5.Text) <= 100&& int.Parse(textBox5.Text) >= 39) { d = true; }
                    else { throw new Exception(); }
                }
                catch (Exception) { textBox5.Text = "Ошибка"; }
                try
                {
                    if (int.Parse(textBox6.Text) <= 100&& int.Parse(textBox6.Text)>=40) { f = true; }
                    else { throw new Exception(); }
                }
                catch (Exception) { textBox6.Text = "Ошибка"; }
                try
                {
                    if (int.Parse(textBox7.Text) <= 100&& int.Parse(textBox7.Text)>=44) { g = true; }
                    else { throw new Exception(); }
                }
                catch (Exception) { textBox7.Text = "Ошибка"; }
                try
                {
                    if (int.Parse(day) > 0 && int.Parse(day) < 32)
                        h = true;
                }
                catch { }
                try
                {
                    if (int.Parse(mount) > 0 && int.Parse(mount) < 13)
                        l = true;
                }
                catch {  }
                try
                {
                    if (int.Parse(year) > 1924 && int.Parse(year) < 2007)
                        m = true;
                }
                catch {  }
                try
                {

                    date = new DateTime(int.Parse(year), int.Parse(mount), int.Parse(day));
                    n = true;
                }
                catch {  }
                int Age()
                {
                    DateTime now = DateTime.Today;
                    int age = now.Year - int.Parse(year);
                    now = now.AddYears(-age);
                    if (date > now) age--;
                    return age;
                }
                if ( b & c & d & f & g & h & l & m & n)
                {
                    int availableSeats = 999;
                    try
                    {
                        availableSeats = int.Parse(mF.textBox2.Text);
                    }
                    catch { }
                    int i = CYMMEGE();
                    string[] rowData = new string[] { textBox2.Text, textBox1.Text, textBox3.Text, $"{day}.{mount}.{year}", "" + Age(), textBox5.Text, textBox6.Text, textBox7.Text, "" + i };
                    mF.AddRow(rowData);
                    mF.dataGridView1.Sort(mF.ЕГЭ,ListSortDirection.Descending);
                    mF.HighlightAdmittedStudents(mF.dataGridView1, availableSeats);
                    this.Hide();
                }

        }   public int CYMMEGE() 
        {return int.Parse(textBox7.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text); }
    }
    
}