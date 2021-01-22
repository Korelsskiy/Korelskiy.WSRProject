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
using Korelskiy.WSRProject.Models;
using Korelskiy.WSRProject.Infrastructure;

namespace Korelskiy.WSRProject
{
    public partial class AddUserForm : Form
    {
        PrivateFontCollection font;
        DbProcessor db = new DbProcessor();
        IFormRequester form;
        public AddUserForm(IFormRequester form)
        {
            InitializeComponent();
            FontsProjects();
            Fonts();
            this.form = form;
            SetBox();
        }
        private void SetBox()
        {
            selectOfficeComboBox.Items.Add("Abu dhabi");
            selectOfficeComboBox.Items.Add("Cairo");
            selectOfficeComboBox.Items.Add("Bahrain");
            selectOfficeComboBox.Items.Add("Doha");
            selectOfficeComboBox.Items.Add("Riyadh");

            selectOfficeComboBox.SelectedIndex = 0;
        }
        private void FontsProjects()
        {
            //Добавляем шрифт из указанного файла в em.Drawing.Text.PrivateFontCollection
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("Fonts/TeXGyreAdventor-Regular.ttf");
        }
        private void Fonts()
        {
            firstNameLabel.Font = new Font(font.Families[0], 12);
            firstNameTextBox.Font = new Font(font.Families[0], 12);
            lastNameLabel.Font = new Font(font.Families[0], 12);
            lastNameTextBox.Font = new Font(font.Families[0], 12);
            officeLabel.Font = new Font(font.Families[0], 12);
            selectOfficeComboBox.Font = new Font(font.Families[0], 12);
            emailAddressLabel.Font = new Font(font.Families[0], 12);
            emailAddressTextBox.Font = new Font(font.Families[0], 12);
            birthdayLabel.Font = new Font(font.Families[0], 12);
            birthdayTextBox.Font = new Font(font.Families[0], 12);
            passwordLabel.Font = new Font(font.Families[0], 12);
            passwordTextBox.Font = new Font(font.Families[0], 12);
            saveButton.Font = new Font(font.Families[0], 12);
            cancelButton.Font = new Font(font.Families[0], 12);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Name = firstNameTextBox.Text;
            user.LastName = lastNameTextBox.Text;
            user.Birthday = Convert.ToDateTime(birthdayTextBox.Text);
            user.Age = DateTime.Now.Year - user.Birthday.Year;
            user.EmailAddress = emailAddressTextBox.Text;
            user.Office = selectOfficeComboBox.SelectedItem.ToString();
            user.UserRole = "Сотрудник";
            user.Password = passwordTextBox.Text;

            db.AddUser(user);

            form.DeblockForm();
            this.Close(); 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            form.DeblockForm();
            this.Close();
        }
    }
    
}

