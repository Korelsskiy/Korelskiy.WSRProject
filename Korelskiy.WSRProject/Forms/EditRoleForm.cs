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
using Korelskiy.WSRProject.Infrastructure;
using Korelskiy.WSRProject.Models;

namespace Korelskiy.WSRProject
{
    public partial class EditRoleForm : Form
    {
        PrivateFontCollection font;
        private readonly IFormRequester form;
        private bool roleChanged = false;
        DbProcessor processor = new DbProcessor();

        public User UserForEdit { get; set; }

        public EditRoleForm(IFormRequester form, User userForEdit)
        {
            InitializeComponent();
            FontsProjects();
            Fonts();
            this.form = form;
            UserForEdit = userForEdit;
            ShowUserInformation();
        }

        private void ShowUserInformation()
        {
            emailAddressTextBox.Text = UserForEdit.EmailAddress;
            firstNameTextBox.Text = UserForEdit.Name;
            lastNameTextBox.Text = UserForEdit.LastName;
            selectOfficeComboBox.Items.Add(UserForEdit.Office);
            selectOfficeComboBox.SelectedIndex = 0;
            if (UserForEdit.UserRole == "Сотрудник")
            {
                userRadioButton.Checked = true;
            }
            else
            {
                administratorRadioButton.Checked = true;
            }

            emailAddressTextBox.Enabled = false;
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            selectOfficeComboBox.Enabled = false;
        }

        private void FontsProjects()
        {
            //Добавляем шрифт из указанного файла в em.Drawing.Text.PrivateFontCollection
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("Fonts/TeXGyreAdventor-Regular.ttf");
        }
        private void Fonts()
        {
            emailAddressLabel.Font = new Font(font.Families[0], 12);
            emailAddressTextBox.Font = new Font(font.Families[0], 12);
            firstNameLabel.Font = new Font(font.Families[0], 12);
            firstNameTextBox.Font = new Font(font.Families[0], 12);
            lastNameLabel.Font = new Font(font.Families[0], 12);
            lastNameTextBox.Font = new Font(font.Families[0], 12);
            officeLabel.Font = new Font(font.Families[0], 12);
            selectOfficeComboBox.Font = new Font(font.Families[0], 12);
            roleLabel.Font = new Font(font.Families[0], 12);
            userRadioButton.Font = new Font(font.Families[0], 12);
            administratorRadioButton.Font = new Font(font.Families[0], 12);
            applyButton.Font = new Font(font.Families[0], 12);
            cancelButton.Font = new Font(font.Families[0], 12);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            form.DeblockForm();
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (roleChanged)
            {
                int roleId = UserForEdit.UserRole == "Сотрудник" ? 1 : 2;
                processor.ChangeUserRole(UserForEdit.EmailAddress, roleId);

                form.DeblockForm();
                this.Close();
            }
        }

        private void userRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            roleChanged = true;
        }

        private void administratorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            roleChanged = true;
        }
    }
}
