using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace POWERSTUDTS
{
    public partial class FormGrupAndFaculty : Form
    {
        private SQLiteConnection DB;
        public FormGrupAndFaculty()
        {
            InitializeComponent();
        }

        private async void FormGrupAndFaculty_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DATABSE.ConnetctionString);
            await DB.OpenAsync();

            SQLiteDataReader read;
            SQLiteCommand commandRead = new SQLiteCommand($"SELECT NumberGrup FROM {Table_Grup.main}", DB);
            read = (SQLiteDataReader)await commandRead.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                ComboBoxGup.Items.Add((string)read["NumberGrup"]);
            }
            SQLiteCommand commandRead1 = new SQLiteCommand($"SELECT Facult FROM {Table_Grup.main}", DB);
            read = (SQLiteDataReader)await commandRead1.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                ComboBoxFacult.Items.Add((string)read["Facult"]);
            }
            SQLiteCommand commandRead2 = new SQLiteCommand($"SELECT NameOfFaculty FROM {Table_Faculty.main}", DB);
            read = (SQLiteDataReader)await commandRead2.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                comboBox1.Items.Add((string)read["NameOfFaculty"]);
            }
            read.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("SELECT * FROM Faculty", DB);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "Info");
            DataGridFaculty.DataSource = ds.Tables[0];

            SQLiteDataAdapter dataadapter2 = new SQLiteDataAdapter("SELECT * FROM Grup", DB);
            DataSet dt = new DataSet();

            dataadapter2.Fill(dt, "Info");
            DataGridGroup.DataSource = dt.Tables[0];
        }

        private void FormGrupAndFaculty_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter2 = new SQLiteDataAdapter($"SELECT sum(Grands) FROM [{Table_Grup.main}] " +
            $"WHERE {Table_Grup.Facult} = '{ComboBoxFacult.Text}' " +
            $"AND {Table_Grup.NumberGrup} = '{ComboBoxGup.Text}'", DB);
            DataSet dt = new DataSet();

            dataadapter2.Fill(dt, "Info");
            DataGridGroup.DataSource = dt.Tables[0];
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter2 = new SQLiteDataAdapter($"SELECT NumberGrup,Facult,Palces " +
            $"FROM Grup,Faculty " +
            $"WHERE Facult = '{comboBox1.Text}' " +
            $"GROUP by NumberGrup",DB);
            DataSet dt = new DataSet();

            dataadapter2.Fill(dt, "Info");
            DataGridFaculty.DataSource = dt.Tables[0];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}