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
        public void UpdateLecture()
        {
            string query = $"UPDATE Lectures SET saved = '{Global.currentLecture.saved}' WHERE lectureNumber = '{Global.currentLecture.lectureNumber}';";

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
            string query = "SELECT DISTINCT lectureNumber, title, description, saved from Lectures order by lectureNumber;";
            return GetLectures(query);
        }
        public List<Lecture> GetSavedLectList()
        {
            string query = "SELECT DISTINCT lectureNumber, title, description, saved from Lectures  WHERE saved = 'True'  ORDER BY lectureNumber;";
            return GetLectures(query);          
        }

        private List<Lecture> GetLectures(string query)
        {
            List<Lecture> lecturesList = new List<Lecture>();
            m_dbConnection = new SQLiteConnection(conString);
            m_dbConnection.Open();
            command = new SQLiteCommand(query, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Lecture lecture = new Lecture();
                lecture.lectureNumber = reader.GetInt32(0);
                lecture.title = reader.GetString(1);
                lecture.description = reader.GetString(2);
                lecture.saved = (bool)reader.GetValue(3);
                lecturesList.Add(lecture);
            }
            m_dbConnection.Close();
            return lecturesList;
        }

        public List<Lecture> GetLectureData()
        {
            List<Lecture> lectureData= new List<Lecture>();
            string query = $"SELECT id, lectureNumber, title, description, file, saved  FROM Lectures WHERE lectureNumber = {Global.currentLecture.lectureNumber};";
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
                lecture.file = reader.GetString(4);
                lecture.saved = (bool)reader.GetValue(5);
                lectureData.Add(lecture);
            }
            m_dbConnection.Close();
            return lectureData;
        }

        private void SaveAllLectures()
        {
            // new Lecture(lectureNumber, LectureTitle, List of files)
            //0.1 
            string desc;
            List<string> files = new List<string>();
            files.Add("Практическая работа (трассировочные таблицы).docx");
            files.Add("Основы языка C#.pptx");
            desc = "В данном разделе рассматриваются основы языка C#: основные понятия языка, состав языка, алфавит, лексемы, идентификаторы, ключевые слова, операторы и разделители, комментарии.";
            saveLect(new Lecture(1, "Основы языка C#", desc), files);

            //2
            files = new List<string>();
            files.Add("Создание графического приложения.pptx");
            files.Add("Практическая работа.docx");
            files.Add("Практическая работа №1.docx");
            files.Add("Практическая работа №2.docx");
            saveLect(new Lecture(2, "Создание графического приложения", desc), files);

            //3
            files = new List<string>();
            files.Add("Элементы управления.pptx");
            files.Add("Практическая работа.docx");
            files.Add("Практическая работа №3.docx");
            saveLect(new Lecture(3, "Элементы управления", desc), files);

            //4
            files = new List<string>();
            files.Add("Объектно-ориентированное программирование. Общие принципы.pptx");
            files.Add("Объектно-ориентированное программирование. Продолжение.pptx");
            files.Add("Объектно-ориентированное программирование. Принципы ООП.pptx");
            files.Add("Практическая работа №4.docx");
            files.Add("Практическая работа №4.1.docx");
            saveLect(new Lecture(4, "Объектно-ориентированное программирование", desc), files);

            //5
            files = new List<string>();
            files.Add("Работа с файловой системой.pptx");
            files.Add("Практическая работа №5.docx");
            saveLect(new Lecture(5, "Работа с файловой системой", desc), files);

            //6
            files = new List<string>();
            files.Add("Управление памятью и указатели.pptx");
            files.Add("Практическая работа №6.docx");
            saveLect(new Lecture(6, "Управление памятью и указатели", desc), files);

            //7
            files = new List<string>();
            files.Add("Системы контроля версий.pptx");
            saveLect(new Lecture(7, "Системы контроля версий", desc), files);


            //8
            files = new List<string>();
            files.Add("Основы работы с сетями в C# и платформой.NET.pptx");
            files.Add("Практическая работа №7.docx");
            files.Add("Практическая работа 8.docx");
            saveLect(new Lecture(8, "Основы работы с сетями в C# и платформой.NET", desc), files);


            //9
            files = new List<string>();
            files.Add("Делегаты, события и лямбды.pptx");
            files.Add("Практическая работа 9.docx");
            saveLect(new Lecture(9, "Делегаты, события и лямбды", desc), files);


            //10
            files = new List<string>();
            files.Add("Цветовые модели.pptx");
            files.Add("Практическая работа 10.docx");
            files.Add("Практическая работа№11.docx");
            saveLect(new Lecture(10, "Цветовые модели", desc), files);


            //11
            files = new List<string>();
            files.Add("Операторные методы.pptx");
            saveLect(new Lecture(11, "Операторные методы", desc), files);


            //12
            files = new List<string>();
            files.Add("Статические методы.pptx");
            saveLect(new Lecture(12, "Статические методы", desc), files);
        }

        private void saveLect(Lecture lecture, List<string> docs)
        {
            for (int i = 0; i < docs.Count; i++)
            {
                lecture.file = docs[i];
                SaveLecture(lecture);
                //  lecture.title = "";
                lecture.file = docs[i].Substring(0, docs[i].Length - 4) + "pdf";
                SaveLecture(lecture);
            }
        }

    }
}
