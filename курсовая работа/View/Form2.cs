using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace курсовая_работа.View
{
    public partial class Form2 : Form
    {
        public List<List<string>> DemList1;
        public List<List<string>> DemList2;
        public List<List<string>> DemList3;
        public List<List<string>> DemList4;
        public List<List<string>> DemList5;
        public Form2()
        {
            InitializeComponent();
        }
        public void AddRow(string[] rowData)
        {
            dataGridView1.Rows.Add(rowData);
            if (comboBox1.SelectedIndex == 0)
            {
                DemList1 = new List<List<string>>();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    DemList1.Add(new List<string>());
                    for (int j = 0; j < 9; j++)
                        DemList1[i].Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                DemList2 = new List<List<string>>();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    DemList2.Add(new List<string>());
                    for (int j = 0; j < 9; j++)
                        DemList2[i].Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                DemList3 = new List<List<string>>();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    DemList3.Add(new List<string>());
                    for (int j = 0; j < 9; j++)
                        DemList3[i].Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                DemList4 = new List<List<string>>();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    DemList4.Add(new List<string>());
                    for (int j = 0; j < 9; j++)
                        DemList4[i].Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                DemList5 = new List<List<string>>();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    DemList5.Add(new List<string>());
                    for (int j = 0; j < 9; j++)
                        DemList5[i].Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
        private void label_nazad_Click(object sender, EventArgs e)
        {
            Form1 result = new Form1();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.ShowDialog();
        }
        public void HighlightAdmittedStudents(DataGridView dataGridView, int availableSeats)
        {
            try
            {
                int scoreColumnIndex = 8; 

                dataGridView.Rows.Cast<DataGridViewRow>()
                    .OrderByDescending(row => Convert.ToInt32(row.Cells[scoreColumnIndex].Value))
                    .ToList()
                    .ForEach(row =>
                    {
                        if (availableSeats > 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.White; //  цвет для принятых студентов
                            availableSeats--;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.LightPink; // Красный цвет для не принятых студентов
                        }
                    });
            }
            catch { };
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.WriteLine(string.Join("", comboBox1.Text));
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        List<string> cellValues = new List<string>();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                cellValues.Add(cell.Value.ToString());
                            }
                            else
                            {
                                cellValues.Add(""); 
                            }
                        }
                        sw.WriteLine(string.Join(",", cellValues));
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a File to Load";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                dataGridView1.Rows.Clear();
                for (int a=0; a<lines.Length;a++)
                {
                    if (a == 0) { }
                    else
                    {
                        string[] data = lines[a].Split(',');
                        AddRow(data);
                    }

                }
                
            }
            dataGridView1.Sort(ЕГЭ, ListSortDirection.Descending);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int availableSeats = int.Parse(textBox2.Text);

                HighlightAdmittedStudents(dataGridView1, availableSeats);
            }
            catch { HighlightAdmittedStudents(dataGridView1, 9999); }
        }
        private void comboBox1_SelectedValieChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Информатика и вычислительная техника")
                {
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < DemList1.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        for (int j = 0; j < 9; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = DemList1[i][j].ToString();
                        }
                        int availableSeats = 9999;
                        try
                        {
                            availableSeats = int.Parse(textBox2.Text);
                        }
                        catch { }
                        HighlightAdmittedStudents(dataGridView1, availableSeats);
                    }
                }
                if (comboBox1.Text == "Технология лесозаготовительных и деревоперерабатывающих производств")
                {
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < DemList2.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        for (int j = 0; j < 9; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = DemList2[i][j].ToString();
                        }
                        int availableSeats = 9999;
                        try
                        {
                            availableSeats = int.Parse(textBox2.Text);
                        }
                        catch { }
                        HighlightAdmittedStudents(dataGridView1, availableSeats);
                    }
                }
                if (comboBox1.Text == "Технологические машины и оборудование")
                {
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < DemList3.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        for (int j = 0; j < 9; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = DemList3[i][j].ToString();
                        }
                        int availableSeats = 9999;
                        try
                        {
                            availableSeats = int.Parse(textBox2.Text);
                        }
                        catch { }
                        HighlightAdmittedStudents(dataGridView1, availableSeats);
                    }
                }
                if (comboBox1.Text == "Социальная работа")
                {
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < DemList4.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        for (int j = 0; j < 9; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = DemList4[i][j].ToString();
                        }
                        int availableSeats = 9999;
                        try
                        {
                            availableSeats = int.Parse(textBox2.Text);
                        }
                        catch { }
                        HighlightAdmittedStudents(dataGridView1, availableSeats);
                    }
                }
                if (comboBox1.Text == "Экономика")
                {
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < DemList5.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        for (int j = 0; j < 9; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = DemList5[i][j].ToString();
                        }
                        int availableSeats = 9999;
                        try
                        {
                            availableSeats = int.Parse(textBox2.Text);
                        }
                        catch { }
                        HighlightAdmittedStudents(dataGridView1, availableSeats);
                    }
                }
                dataGridView1.Sort(ЕГЭ, ListSortDirection.Descending);
            }
            catch { }
        }
    }
}
