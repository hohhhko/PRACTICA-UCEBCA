using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace POWERSTUDTS
{
    public partial class FormMain : Form
    {
        private SQLiteConnection DB;
        public FormMain()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DATABSE.ConnetctionString);
            await DB.OpenAsync();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormEnter frm = new FormEnter();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter3 = new SQLiteDataAdapter("SELECT * FROM Stydent", DB);
            DataSet dst = new DataSet();

            dataadapter3.Fill(dst, "Info");
            DataGridStudent.DataSource = dst.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter3 = new SQLiteDataAdapter($"SELECT * FROM Stydent WHERE Year = {TextBoxYaer.Text}", DB);
            DataSet dst = new DataSet();

            dataadapter3.Fill(dst, "Info");
            DataGridStudent.DataSource = dst.Tables[0];
            if (TextBoxYaer.Text == "4 > 9")
            {
                MessageBox.Show("Такого курса не существует");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter3 = new SQLiteDataAdapter($"SELECT name,Surname, DATE(YearOfEnrollment) - DATE(DayOfBirth) as AgeOfEmplament " +
            $"FROM Grup,Stydent " +
            $"WHERE AgeOfEmplament <20 " +
            $"GROUP BY Surname " +
            $"HAVING AgeOfEmplament <{comboBox1.Text} " +
             $"ORDER by AgeOfEmplament DESC", DB);
            DataSet dst = new DataSet();

            dataadapter3.Fill(dst, "Info");
            DataGridStudent.DataSource = dst.Tables[0];
            if (TextBoxYaer.Text == "4 > 9")
            {
                MessageBox.Show("Такого курса не существует");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormInsrt frm = new FormInsrt();
            frm.Show();
        }
    }
}
