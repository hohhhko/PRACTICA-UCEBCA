using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace POWERSTUDTS
{
    public partial class FormInsrt : Form
    {
        private SQLiteConnection DB;
        public FormInsrt()
        {
            InitializeComponent();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surna = textBox2.Text;
            string year = textBox3.Text;
            string Birth = textBox4.Text;
            string state = textBox5.Text;
            string info = textBox6.Text;
            string spec = textBox7.Text;
            string rol = comboBox1.Text;


            SQLiteCommand ins = new SQLiteCommand($"INSERT INTO {Table_Stydent.main} (Name,Surname,Year,DayOfBirth,Family_state,family_information,Speciality,Rolue) VALUES (@Name,@Surname,@Year,@DayOfBirth,@Family_state,@family_information,@Speciality,@Rolue)", DB);
            ins.Parameters.AddWithValue("Name",name);
            ins.Parameters.AddWithValue("Surname", surna);
            ins.Parameters.AddWithValue("Year", year);
            ins.Parameters.AddWithValue("DayOfBirth", Birth);
            ins.Parameters.AddWithValue("Family_state", state);
            ins.Parameters.AddWithValue("family_information", info);
            ins.Parameters.AddWithValue("Speciality", spec);
            ins.Parameters.AddWithValue("Rolue", rol);
            await ins.ExecuteNonQueryAsync();

            MessageBox.Show("dlahkisdolais");
        }

        private async void FormInsrt_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DATABSE.ConnetctionString);
            await DB.OpenAsync();
        }
    }
}
