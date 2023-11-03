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
            this.DataGridGroup = new System.Windows.Forms.DataGridView();
            this.DataGridFaculty = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridStudent
            // 
            this.DataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridStudent.Location = new System.Drawing.Point(93, 12);
            this.DataGridStudent.Name = "DataGridStudent";
            this.DataGridStudent.Size = new System.Drawing.Size(636, 193);
            this.DataGridStudent.TabIndex = 0;
            // 
            // DataGridGroup
            // 
            this.DataGridGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridGroup.Location = new System.Drawing.Point(93, 212);
            this.DataGridGroup.Name = "DataGridGroup";
            this.DataGridGroup.Size = new System.Drawing.Size(324, 170);
            this.DataGridGroup.TabIndex = 1;
            // 
            // DataGridFaculty
            // 
            this.DataGridFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFaculty.Location = new System.Drawing.Point(427, 213);
            this.DataGridFaculty.Name = "DataGridFaculty";
            this.DataGridFaculty.Size = new System.Drawing.Size(301, 168);
            this.DataGridFaculty.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 394);
            this.Controls.Add(this.DataGridFaculty);
            this.Controls.Add(this.DataGridGroup);
            this.Controls.Add(this.DataGridStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о студентах";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridStudent;
        private System.Windows.Forms.DataGridView DataGridGroup;
        private System.Windows.Forms.DataGridView DataGridFaculty;
    }
}

