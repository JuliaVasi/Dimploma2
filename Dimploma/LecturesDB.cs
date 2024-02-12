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
         string query = "Create Table if not exists Lectures (" +
                "id integer primary key, " +
                "lectureNumber integer, "+
                "title text,"+
                "description text," +
                "file text," +
                "saved bool);";
         ExecuteCommand(query);
         m_dbConnection.Close();

            for (int i = 0; i < 1000; i++)
            {
                DeleteLecture(i);
            }


              SaveAllLectures();
        }

        private void SaveLecture(Lecture lecture)
        {
            string query = "INSERT INTO  Lectures (" +
                "lectureNumber, " +
                "title," +
                "description, " +
                "file, " +
                "saved)" +
                "VALUES (" +
                $"'{lecture.lectureNumber}', " +
                $"'{lecture.title}', " +
                $"'{lecture.description}'," +
                $"'{lecture.file}'," +
                $"'{lecture.saved}');";
            ExecuteCommand(query);
            m_dbConnection.Close();       
        }
        // to delete
        private void DeleteLecture(int lectureId)
        {
            string query = $"Delete  from  Lectures where id = {lectureId};";
            ExecuteCommand(query);
            m_dbConnection.Close();
        }

        // to delete
        private void TruncateTable()
        {
            string query = "TRUNCATE TABLE Lectures;";
            ExecuteCommand(query);
            m_dbConnection.Close();
        }

        private void ExecuteCommand(string query)
        {
            m_dbConnection = new SQLiteConnection(conString);
            m_dbConnection.Open();
            command = new SQLiteCommand(query, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public List<Lecture> GetLecturesList()
        {
            List<Lecture> lecturesList = new List<Lecture>();
            string query = "SELECT  id, lectureNumber, title, description, saved from Lectures order by lectureNumber where title not like '';";
            string query = "SELECT  id, lectureNumber, title, description, saved from Lectures order by lectureNumber where title not like '';";
           // string query = "SELECT * from Lectures ;";

            m_dbConnection = new SQLiteConnection(conString);
            m_dbConnection.Open();
            command = new SQLiteCommand(query, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Lecture lecture = new Lecture();
                lecture.id = reader.GetInt32(0);
                lecture.lectureNumber = reader.GetInt32(1);
                lecture.title = reader.GetString(2);
                lecture.description = reader.GetString(3);
               // lecture.saved = reader.GetBoolean(4);
                lecturesList.Add(lecture);
            }
            m_dbConnection.Close();
            return lecturesList;
        }    

        public List<string> GetLectureFiles()
        {
            List<string> lecturesFiles = new List<string>();
           // string query = $"SELECT id, file FROM Lectures WHERE lectureNumber = {lectureNumber};";
            string query = $"SELECT id, file FROM Lectures WHERE lectureNumber = {Global.currentLecture.lectureNumber};";
            m_dbConnection = new SQLiteConnection(conString);
            m_dbConnection.Open();
            command = new SQLiteCommand(query, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                lecturesFiles.Add(reader.GetString(1));
            }
            m_dbConnection.Close();
            return lecturesFiles;
        }

        private void SaveAllLectures()
        {
            List<string> docs = new List<string>();
            //0.1 
            
            Lecture lecture = new Lecture();
            lecture.description = "Крупнейший веб-сервис для хостинга IT-проектов и их совместной разработки.Крупнейший веб-сервис для хостинга IT-проектов и их совместной разработки.Крупнейший веб-сервис для хостинга IT-проектов и их совместной разработки.";
            lecture.saved = false;

            lecture.lectureNumber = 1;
            lecture.title = "Основы языка C#";
            docs.Add("Основы языка C#.pptx");
            docs.Add("Практическая работа (трассировочные таблицы).docx");

          for(int i = 0; i<docs.Count; i++)
            {
                lecture.file = docs[i];
                SaveLecture(lecture);
                lecture.title = "";
                lecture.file = docs[i].Substring(0, docs[i].Length -4)+"pdf";
                SaveLecture(lecture);
            }
        }
    }
}
