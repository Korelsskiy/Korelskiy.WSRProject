using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Linq;
using Korelskiy.WSRProject.Models;
using Korelskiy.WSRProject.Infrastructure;

namespace Korelskiy.WSRProject
{
    public partial class AdminForm : Form, IFormRequester
    {
        private List<User> users;
        private DbProcessor dbProcessor = new DbProcessor();
        PrivateFontCollection font;
        bool formCanBeChanged = false;
        public UserActivity Activity { get; set; }
        public User CurrentUser { get; set; }
        public AdminForm(User user, UserActivity activity)
        {
          
            InitializeComponent();

            users = dbProcessor.GetUsers();
            Activity = activity;
            CurrentUser = user;

            AddColumnsForDG();
            AddToDataGrid(users);
            SetBox();

            FontsProjects();
            Fonts();

           
        }

        private void SetBox()
        {
            selectOfficeComboBox.Items.Clear();
            selectOfficeComboBox.Items.Add("Abu dhabi");
            selectOfficeComboBox.Items.Add("Cairo");
            selectOfficeComboBox.Items.Add("Bahrain");
            selectOfficeComboBox.Items.Add("Doha");
            selectOfficeComboBox.Items.Add("Riyadh");
            selectOfficeComboBox.Items.Add("Show All Offices");

            selectOfficeComboBox.SelectedIndex = 5;
        }
        private void AddColumnsForDG()
        {
            usersDataGridView.Columns.Add("Column1", "Name");
            usersDataGridView.Columns.Add("Column2", "LastName");
            usersDataGridView.Columns.Add("Column3", "Age");
            usersDataGridView.Columns.Add("Column4", "User Role");
            usersDataGridView.Columns.Add("Column5", "Email Address");
            usersDataGridView.Columns.Add("Column6", "Office");
        }
        private void AddToDataGrid(List<User> users)
        {
            
            foreach (var i in users)
            {
                usersDataGridView.Rows.Add(i.Name, i.LastName, i.Age, i.UserRole, i.EmailAddress, i.Office);

                usersDataGridView.Rows[users.IndexOf(i)].DefaultCellStyle.BackColor = i.UserColorInDataGrid;
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
            addUserToolStripMenuItem.Font = new Font(font.Families[0], 12);
            exitToolStripMenuItem.Font = new Font(font.Families[0], 12);
            officeLabel.Font = new Font(font.Families[0], 12);
            selectOfficeComboBox.Font = new Font(font.Families[0], 12);
            usersDataGridView.Font = new Font(font.Families[0], 12);
            changeRoleButton.Font = new Font(font.Families[0], 12);
            loginControlButton.Font = new Font(font.Families[0], 12);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Close();
            form.Show();
        }


        private void loginControlButton_Click(object sender, EventArgs e)
        {
            string userEmail = usersDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            bool status = users.FirstOrDefault(x => x.EmailAddress == userEmail).Active;

            int active = status == true ? 0 : 1;

            dbProcessor.ChangeActiveStatus(active, userEmail);

            users = dbProcessor.GetUsers();
            usersDataGridView.Rows.Clear();
            AddToDataGrid(users);
        }

        private void changeRoleButton_Click(object sender, EventArgs e)
        {
            User userForEdit = users.FirstOrDefault(x => x.EmailAddress == usersDataGridView.SelectedRows[0].Cells[4].Value.ToString());
            EditRoleForm form = new EditRoleForm(this, userForEdit);
            this.Enabled = false;
            form.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm(this);
            this.Enabled = false;
            form.Show();
        }

        public void DeblockForm()
        {
            this.Enabled = true;
            users = dbProcessor.GetUsers();
            usersDataGridView.Rows.Clear();
            AddToDataGrid(users);
        }

        private void AdminForm_Shown(object sender, EventArgs e)
        {
            formCanBeChanged = true;
        }

        private void selectOfficeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formCanBeChanged)
            {
                usersDataGridView.Rows.Clear();
                if (selectOfficeComboBox.SelectedIndex == 5)
                {
                    AddToDataGrid(users);
                }
                List<User> filtredUsers = users.Where(x => x.Office == selectOfficeComboBox.SelectedItem.ToString()).ToList();
                AddToDataGrid(filtredUsers);
            }
            
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Activity.LogoutTime = DateTime.Now.TimeOfDay;
            Activity.LogoutReason = e.CloseReason.ToString();
            Activity.TimeSpentOnSystem = Activity.LogoutTime.Subtract(Activity.LoginTime);
            CurrentUser.TimeSpentOnSystem = CurrentUser.TimeSpentOnSystem.Add(Activity.LogoutTime.Subtract(Activity.LoginTime));

            dbProcessor.AddUserActivity(Activity);
            dbProcessor.UpdateUserTimeInSystem(CurrentUser.TimeSpentOnSystem, CurrentUser.EmailAddress);
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                dbProcessor.IncrementCrashes(CurrentUser.EmailAddress);
            }
        }
    }
}
