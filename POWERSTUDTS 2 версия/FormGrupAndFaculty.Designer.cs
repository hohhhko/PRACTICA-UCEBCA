namespace POWERSTUDTS
{
    partial class FormGrupAndFaculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrupAndFaculty));
            this.DataGridFaculty = new System.Windows.Forms.DataGridView();
            this.DataGridGroup = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.ComboBoxFacult = new System.Windows.Forms.ComboBox();
            this.ComboBoxGup = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridFaculty
            // 
            this.DataGridFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFaculty.Location = new System.Drawing.Point(412, 14);
            this.DataGridFaculty.Name = "DataGridFaculty";
            this.DataGridFaculty.Size = new System.Drawing.Size(260, 176);
            this.DataGridFaculty.TabIndex = 4;
            // 
            // DataGridGroup
            // 
            this.DataGridGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridGroup.Location = new System.Drawing.Point(106, 12);
            this.DataGridGroup.Name = "DataGridGroup";
            this.DataGridGroup.Size = new System.Drawing.Size(282, 176);
            this.DataGridGroup.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ComboBoxFacult
            // 
            this.ComboBoxFacult.FormattingEnabled = true;
            this.ComboBoxFacult.Location = new System.Drawing.Point(233, 228);
            this.ComboBoxFacult.Name = "ComboBoxFacult";
            this.ComboBoxFacult.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxFacult.TabIndex = 6;
            // 
            // ComboBoxGup
            // 
            this.ComboBoxGup.FormattingEnabled = true;
            this.ComboBoxGup.Location = new System.Drawing.Point(106, 228);
            this.ComboBoxGup.Name = "ComboBoxGup";
            this.ComboBoxGup.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxGup.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Посчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(593, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(466, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Выбирете факультет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выбирете факультете и группу";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // FormGrupAndFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ComboBoxGup);
            this.Controls.Add(this.ComboBoxFacult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DataGridFaculty);
            this.Controls.Add(this.DataGridGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGrupAndFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Группы и факультетеы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGrupAndFaculty_FormClosed);
            this.Load += new System.EventHandler(this.FormGrupAndFaculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridFaculty;
        private System.Windows.Forms.DataGridView DataGridGroup;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox ComboBoxFacult;
        public System.Windows.Forms.ComboBox ComboBoxGup;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}