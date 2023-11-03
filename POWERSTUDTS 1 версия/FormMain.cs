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

            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("SELECT * FROM Faculty", DB);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "Info");
            DataGridFaculty.DataSource = ds.Tables[0];

            SQLiteDataAdapter dataadapter2 = new SQLiteDataAdapter("SELECT * FROM Grup", DB);
            DataSet dt = new DataSet();

            dataadapter2.Fill(dt, "Info");
            DataGridGroup.DataSource = dt.Tables[0];

            SQLiteDataAdapter dataadapter3 = new SQLiteDataAdapter("SELECT * FROM Stydents", DB);
            DataSet dst = new DataSet();

            dataadapter3.Fill(dst, "Info");
            DataGridStudent.DataSource = dst.Tables[0];
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
