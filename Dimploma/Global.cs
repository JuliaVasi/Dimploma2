using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimploma
{
    public static class Global
    {
       public static FlowLayoutPanel themeItemsPanel;
       public static MainForm mainForm;
        public static Action ClearThemeItemsPanel;
        public static Action ShowLesson;
        public static int ColorNumber;

        public static Lecture currentLecture;
    }
}
