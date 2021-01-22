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

namespace Korelskiy.WSRProject
{
    public partial class ApplySheduleChangesForm : Form
    {
        PrivateFontCollection font;
        public ApplySheduleChangesForm()
        {
            InitializeComponent();

            FontsProjects();
            Fonts();
        }

        private void FontsProjects()
        {
            //Добавляем шрифт из указанного файла в em.Drawing.Text.PrivateFontCollection
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("Fonts/TeXGyreAdventor-Regular.ttf");
        }

        private void Fonts()
        {
            this.Font = new Font(font.Families[0], 12);
        }
    }
}
