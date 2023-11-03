namespace POWERSTUDTS
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.DataGridStudent = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.TextBoxYaer = new System.Windows.Forms.TextBox();
            this.ButtonYear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelyear = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridStudent
            // 
            this.DataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridStudent.Location = new System.Drawing.Point(190, 12);
            this.DataGridStudent.Name = "DataGridStudent";
            this.DataGridStudent.Size = new System.Drawing.Size(649, 279);
            this.DataGridStudent.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Обновить таблицу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextBoxYaer
            // 
            this.TextBoxYaer.Location = new System.Drawing.Point(275, 333);
            this.TextBoxYaer.MaxLength = 1;
            this.TextBoxYaer.Name = "TextBoxYaer";
            this.TextBoxYaer.Size = new System.Drawing.Size(132, 20);
            this.TextBoxYaer.TabIndex = 6;
            // 
            // ButtonYear
            // 
            this.ButtonYear.Location = new System.Drawing.Point(413, 330);
            this.ButtonYear.Name = "ButtonYear";
            this.ButtonYear.Size = new System.Drawing.Size(84, 23);
            this.ButtonYear.TabIndex = 7;
            this.ButtonYear.Text = "Найти";
            this.ButtonYear.UseVisualStyleBackColor = true;
            this.ButtonYear.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(688, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(545, 336);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // labelyear
            // 
            this.labelyear.AutoSize = true;
            this.labelyear.Location = new System.Drawing.Point(281, 317);
            this.labelyear.Name = "labelyear";
            this.labelyear.Size = new System.Drawing.Size(75, 13);
            this.labelyear.TabIndex = 10;
            this.labelyear.Text = "Введите курс";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(542, 307);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(258, 26);
            this.labelname.TabIndex = 11;
            this.labelname.Text = "Выбрать кому на момент поступления будет < 18\r\n (также можно кому будет больше)\r\n" +
    "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(52, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 44);
            this.button5.TabIndex = 12;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 369);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelyear);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ButtonYear);
            this.Controls.Add(this.TextBoxYaer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о студентах";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridStudent;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox TextBoxYaer;
        public System.Windows.Forms.Button ButtonYear;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label labelyear;
        public System.Windows.Forms.Label labelname;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}

