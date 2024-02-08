using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimploma
{
    internal class LecturesDB
    {
        string conString = "Data Source=DB.sqlite;Version=3;";
        SQLiteConnection m_dbConnection;
        SQLiteCommand command;

        public LecturesDB()
        {
         string sql = "Create Table if not exists Lectures (" +
                "id integer primary key, " +
                "number integer,"+
                "title text,"+
                "description text," +
                "path text);";
        
        m_dbConnection = new SQLiteConnection(conString);
        m_dbConnection.Open();
        command = new SQLiteCommand(sql, m_dbConnection);

        command.ExecuteNonQuery();
        m_dbConnection.Close();
        }

        public List<LecturesDB> GetLecturesList()
        {
            List<LecturesDB> lecturesList = new List<LecturesDB>();
            string query = "Select * from Lectures;";

            m_dbConnection = new SQLiteConnection(conString);
            m_dbConnection.Open();
            command = new SQLiteCommand(query, m_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Lecture lecture = new Lecture();
             //   lecture.title = reader.GetString();

/*                startdate.Text = reader.GetString(1);
                finishdate.Text = reader.GetString(2);
                requestStatusCombobox.SelectedItem = reader.GetString(3);
                eqTextBox.Text = reader.GetString(4);
                serialNumber.Text = reader.GetValue(5).ToString();
                problemDescTextBox.Text = reader.GetString(6);
                client.Text = reader.GetString(7);
                clientNumber.Text = reader.GetString(8);
                comboBox1Priority.SelectedItem = reader.GetString(9);
                workerTextBox.Text = reader.GetString(10);
                sparesTextBox.Text = reader.GetString(11);
                reasonTextBox.Text = reader.GetString(12);
                helptextBox.Text = reader.GetString(13);*/
            }
            m_dbConnection.Close();
            return lecturesList;
        }

    }
}
