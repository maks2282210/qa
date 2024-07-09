namespace курсовая_работа.View
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_university = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_information = new System.Windows.Forms.Label();
            this.label_nazad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Возраст = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пол = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЕГЭ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_university.ForeColor = System.Drawing.SystemColors.Info;
            this.label_university.Location = new System.Drawing.Point(81, 516);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(769, 16);
            this.label_university.TabIndex = 0;
            this.label_university.Text = "ФГБОУ ВО «Сибирский государственный университет имени М.Ф. Решетнева» Лесосибирск" +
    "ий филиал";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_main.Controls.Add(this.label_exit);
            this.panel_main.Controls.Add(this.label_information);
            this.panel_main.Controls.Add(this.label_nazad);
            this.panel_main.Location = new System.Drawing.Point(0, 425);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(981, 66);
            this.panel_main.TabIndex = 1;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_exit.Location = new System.Drawing.Point(780, 12);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(121, 40);
            this.label_exit.TabIndex = 3;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_information.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_information.Location = new System.Drawing.Point(387, 12);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(235, 40);
            this.label_information.TabIndex = 2;
            this.label_information.Text = "Информация";
            this.label_information.Click += new System.EventHandler(this.label_information_Click);
            // 
            // label_nazad
            // 
            this.label_nazad.AutoSize = true;
            this.label_nazad.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_nazad.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_nazad.Location = new System.Drawing.Point(44, 12);
            this.label_nazad.Name = "label_nazad";
            this.label_nazad.Size = new System.Drawing.Size(245, 40);
            this.label_nazad.TabIndex = 0;
            this.label_nazad.Text = "Главное меню";
            this.label_nazad.Click += new System.EventHandler(this.label_nazad_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(26, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(181, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(335, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 58);
            this.button3.TabIndex = 4;
            this.button3.Text = "Загрузить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Фамилия,
            this.Имя,
            this.Возраст,
            this.Column4,
            this.Пол,
            this.Column1,
            this.Column2,
            this.Column3,
            this.ЕГЭ});
            this.dataGridView1.Location = new System.Drawing.Point(0, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 253);
            this.dataGridView1.TabIndex = 5;
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.MinimumWidth = 6;
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Width = 130;
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Имя";
            this.Имя.MinimumWidth = 6;
            this.Имя.Name = "Имя";
            this.Имя.Width = 130;
            // 
            // Возраст
            // 
            this.Возраст.HeaderText = "Пол";
            this.Возраст.MinimumWidth = 6;
            this.Возраст.Name = "Возраст";
            this.Возраст.Width = 45;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата рождения";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 95;
            // 
            // Пол
            // 
            this.Пол.HeaderText = "Возраст";
            this.Пол.MinimumWidth = 6;
            this.Пол.Name = "Пол";
            this.Пол.Width = 70;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Егэ по математике";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Егэ по русскому языку";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Егэ по информатике";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // ЕГЭ
            // 
            this.ЕГЭ.HeaderText = "Общее кол-во баллов";
            this.ЕГЭ.MinimumWidth = 6;
            this.ЕГЭ.Name = "ЕГЭ";
            this.ЕГЭ.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Наиминование направления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(487, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество мест \r\nдля приема";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(680, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Информатика и вычислительная техника",
            "Технология лесозаготовительных и деревоперерабатывающих производств",
            "Технологические машины и оборудование",
            "Социальная работа",
            "Экономика"});
            this.comboBox1.Location = new System.Drawing.Point(335, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(631, 27);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValieChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 549);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label_university);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Данные абитуриента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_information;
        private System.Windows.Forms.Label label_nazad;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Возраст;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пол;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridViewTextBoxColumn ЕГЭ;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}