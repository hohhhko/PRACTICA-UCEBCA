namespace POWERSTUDTS
{
    partial class FormEnter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnter));
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.рукодтсвоПользованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рукодтсвоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Location = new System.Drawing.Point(276, 50);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(75, 45);
            this.ButtonEnter.TabIndex = 0;
            this.ButtonEnter.Text = "Вход";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(23, 72);
            this.TextBoxName.MaxLength = 20;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxName.TabIndex = 1;
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(145, 75);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSurname.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рукодтсвоПользованияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // рукодтсвоПользованияToolStripMenuItem
            // 
            this.рукодтсвоПользованияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рукодтсвоToolStripMenuItem,
            this.таблицаToolStripMenuItem,
            this.диограммаToolStripMenuItem});
            this.рукодтсвоПользованияToolStripMenuItem.Name = "рукодтсвоПользованияToolStripMenuItem";
            this.рукодтсвоПользованияToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.рукодтсвоПользованияToolStripMenuItem.Text = "Нужные документы";
            // 
            // рукодтсвоToolStripMenuItem
            // 
            this.рукодтсвоToolStripMenuItem.Name = "рукодтсвоToolStripMenuItem";
            this.рукодтсвоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рукодтсвоToolStripMenuItem.Text = "Рукодтсво";
            this.рукодтсвоToolStripMenuItem.Click += new System.EventHandler(this.РукодтсвоToolStripMenuItem_Click);
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            this.таблицаToolStripMenuItem.Click += new System.EventHandler(this.ТаблицаToolStripMenuItem_Click);
            // 
            // диограммаToolStripMenuItem
            // 
            this.диограммаToolStripMenuItem.Name = "диограммаToolStripMenuItem";
            this.диограммаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.диограммаToolStripMenuItem.Text = "Диограмма";
            this.диограммаToolStripMenuItem.Click += new System.EventHandler(this.ДиограммаToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // FormEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 119);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEnter_FormClosed);
            this.Load += new System.EventHandler(this.FormEnter_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxSurname;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рукодтсвоПользованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рукодтсвоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диограммаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}