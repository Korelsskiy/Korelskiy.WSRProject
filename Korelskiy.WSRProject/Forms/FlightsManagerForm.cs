using Korelskiy.WSRProject.Infrastructure;
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
    public partial class FlightsManagerForm : Form
    {
        IDbProccessorSession2 db = new DbProccessorSession2();
        PrivateFontCollection font;
        public FlightsManagerForm()
        {
            InitializeComponent();

            FontsProjects();
            Fonts();

            SetComboBoxes();
            flightsManagerDataGridView.DataSource = db.GetFlights();
        }
        private void SetComboBoxes()
        {
            foreach (var item in db.GetAirports())
            {
                selectFromComboBox.Items.Add(item.Name);
                selectToComboBox.Items.Add(item.Name);
            }
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
