namespace курсовая_работа
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_caption = new System.Windows.Forms.Label();
            this.label_university = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_information = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_caption
            // 
            this.label_caption.AutoSize = true;
            this.label_caption.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_caption.ForeColor = System.Drawing.SystemColors.Info;
            this.label_caption.Location = new System.Drawing.Point(250, 9);
            this.label_caption.Name = "label_caption";
            this.label_caption.Size = new System.Drawing.Size(494, 58);
            this.label_caption.TabIndex = 0;
            this.label_caption.Text = "Приемная комиссия";
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_university.ForeColor = System.Drawing.SystemColors.Info;
            this.label_university.Location = new System.Drawing.Point(81, 516);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(769, 16);
            this.label_university.TabIndex = 1;
            this.label_university.Text = "ФГБОУ ВО «Сибирский государственный университет имени М.Ф. Решетнева» Лесосибирск" +
    "ий филиал";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_main.Controls.Add(this.label_exit);
            this.panel_main.Controls.Add(this.label_information);
            this.panel_main.Controls.Add(this.label_start);
            this.panel_main.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_main.Location = new System.Drawing.Point(0, 425);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(981, 66);
            this.panel_main.TabIndex = 2;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_exit.Location = new System.Drawing.Point(780, 12);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(121, 40);
            this.label_exit.TabIndex = 4;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_information.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_information.Location = new System.Drawing.Point(365, 12);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(235, 40);
            this.label_information.TabIndex = 3;
            this.label_information.Text = "Информация";
            this.label_information.Click += new System.EventHandler(this.label_information_Click);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_start.Location = new System.Drawing.Point(44, 12);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(128, 40);
            this.label_start.TabIndex = 3;
            this.label_start.Text = "Запуск";
            this.label_start.Click += new System.EventHandler(this.label_start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::курсовая_работа.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.label_caption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Приемная комиссия";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_caption;
        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_information;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

