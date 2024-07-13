using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimploma
{
    public partial class ProgInfoUserCont : UserControl
    {
        PrivateFontCollection fonts;

        public ProgInfoUserCont(PrivateFontCollection fonts)
        {
            InitializeComponent();
            this.fonts = fonts;
            Global.infoTextBox = infoTextBox;
        }

        private void SetFonts()
        {
            devLabel.Font = new Font(fonts.Families[3], 14);
            infoTextBox.Font = new Font(fonts.Families[3], 14);
            infoTextBox.ForeColor = Color.Black;

        }

        private void ProgInfoUserCont_Load(object sender, EventArgs e)
        {
            SetFonts();
        }
    }
}
