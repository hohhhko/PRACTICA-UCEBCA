using System;
using System.Windows.Forms;

namespace POWERSTUDTS
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormEnter());
        }

    }

    static class DATABSE
    {
        public static string ConnetctionString = @"Data Source=Students.db; Integrated Security=False; MultipleActiveResultSets=True";
    }

    #region table
    static class Table_Faculty
    {
        public static string main = "Faculty";
        public static string ID = "ID";
        public static string NameOfFaculty = "NameOfFaculty";
        public static string Palces = "Palces";
    }
    static class Table_Grup
    {
        public static string main = "Grup";
        public static string ID = "ID";
        public static string YearOfEnrollment = "YearOfEnrollment";
        public static string Students = "Students";
        public static string NumberGrup = "NumberGrup";
        public static string Facult = "Facult";
        public static string Grands = "Grands";
    }
    static class Table_Stydent
    {
        public static string main = "Stydent";
        public static string ID = "ID";
        public static string Name = "Name";
        public static string Surname = "Surname";
        public static string Year = "Year";
        public static string DayOfBirth = "DayOfBirth";
        public static string Family_state = "Family_state";
        public static string family_information = "family_information";
        public static string Speciality = "Speciality";
        public static string Rolue = "Rolue";
    }
    #endregion
}
