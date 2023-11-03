using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace POWERSTUDTS
{
    public partial class FormEnter : Form
    {
        private SQLiteConnection DB;
        public FormEnter()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string surnmae = TextBoxSurname.Text;

            if (name != "" && surnmae != "")
            {
                SQLiteDataReader read;
                SQLiteCommand commandRead = new SQLiteCommand($"SELECT * FROM [{Table_Stydent.main}] " +
                $"WHERE {Table_Stydent.Name}=@Name " +
                $"AND {Table_Stydent.Surname}=@Surname ", DB);
                commandRead.Parameters.AddWithValue("Name",name);
                commandRead.Parameters.AddWithValue("Surname", surnmae);
                read = (SQLiteDataReader)await commandRead.ExecuteReaderAsync();
                if (await read.ReadAsync())
                {
                    if (read[$"{Table_Stydent.Rolue}"].ToString() == "Студент")
                    {
                        FormMain frm = new FormMain();
                        frm.Show();
                        this.Hide();
                        frm.button5.Visible = false;
                        frm.labelyear.Visible = false;
                        frm.labelname.Visible = false;
                        frm.TextBoxYaer.Visible = false;
                        frm.comboBox1.Visible = false;
                        frm.ButtonYear.Visible = false;
                        frm.button4.Visible = false;

                        FormGrupAndFaculty mrf = new FormGrupAndFaculty();
                        mrf.Show();
                        mrf.comboBox1.Visible = false;
                        mrf.ComboBoxFacult.Visible = false;
                        mrf.ComboBoxGup.Visible = false;
                        mrf.button3.Visible = false;
                        mrf.button4.Visible = false;
                        mrf.label1.Visible = false;
                        mrf.label2.Visible = false;
                    }
                    if (read[$"{Table_Stydent.Rolue}"].ToString() == "Секретарь")
                    {
                        FormMain frm = new FormMain();
                        frm.Show();
                        this.Hide();
                        frm.button5.Visible = true;
                        frm.labelyear.Visible = true;
                        frm.labelname.Visible = true;
                        frm.TextBoxYaer.Visible = true;
                        frm.comboBox1.Visible = true;
                        frm.ButtonYear.Visible = true;
                        frm.button4.Visible = true;

                        FormGrupAndFaculty frm2 = new FormGrupAndFaculty();
                        frm2.Show();
                        frm2.comboBox1.Visible = true;
                        frm2.ComboBoxFacult.Visible = true;
                        frm2.ComboBoxGup.Visible = true;
                        frm2.button3.Visible = true;
                        frm2.button4.Visible = true;
                        frm2.label1.Visible = true;
                        frm2.label2.Visible = true;

                    }
                }
                else 
                {
                    MessageBox.Show("Проеарете данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                read.Close();
            }
        }

        private async void FormEnter_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DATABSE.ConnetctionString);
            await DB.OpenAsync();  
        }

        private void РукодтсвоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Руковдтсво часть его.doc");
        }

        private void ТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Задние 1 сревнение.xlsx");
        }

        private void ДиограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Students.mdj");
        }

        private void FormEnter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}