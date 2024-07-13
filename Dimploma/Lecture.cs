using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;

namespace Dimploma
{
    public class Lecture
    {
      public  string title, file;
      public int id, lectureNumber;
      public bool saved = false;
      public string description = "Крупнейший веб-сервис для хостинга IT-проектов и" +
            " их совместной разработки.Крупнейший веб-сервис для хостинга IT-проектов " +
            "и их совместной разработки.Крупнейший веб-сервис для хостинга IT-проектов и их совместной разработки.";

        public Lecture(int lectureNumber, string title, string description)
        {
            this.lectureNumber = lectureNumber;
            this.title = title;
            this.description = description;
        }
        public Lecture()
        {

        }
    }
}
