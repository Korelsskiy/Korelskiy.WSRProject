using Korelskiy.WSRProject.Infrastructure;
using Korelskiy.WSRProject.Models;
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
    public partial class UserForm : Form
    {
        public User CurrentUser { get; set; }
        private List<UserActivity> activities;
        DbProcessor dbProcessor = new DbProcessor();
        PrivateFontCollection font;
        public UserActivity Activity { get; set; }
        public UserForm(User user, UserActivity activity)
        {
            InitializeComponent();
            FontsProjects();
            Fonts();

            CurrentUser = user;
            activities = dbProcessor.GetUserActivities();
            Activity = activity;

            welcomeTextLabel.Text = $"Hi, {CurrentUser.Name}, welcome to AMONIC Airlines";
            timeSpentLabel.Text = $"time spent on system: {CurrentUser.TimeSpentOnSystem.ToString(@"hh\:mm\:ss")}";
            numberOfCrashesLabel.Text = $"number of crashes: {CurrentUser.NumberOfCrashes}";
            userFormDataGridView.DataSource = activities.Where(x => x.UserId == CurrentUser.Id).ToList();
        }

        private void FontsProjects()
        {
            //Добавляем шрифт из указанного файла в em.Drawing.Text.PrivateFontCollection
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("Fonts/TeXGyreAdventor-Regular.ttf");
        }
        private void Fonts()
        {
            welcomeTextLabel.Font = new Font(font.Families[0], 12);
            timeSpentLabel.Font = new Font(font.Families[0], 12);
            numberOfCrashesLabel.Font = new Font(font.Families[0], 12);
            menuStrip1.Font = new Font(font.Families[0], 12);
            userFormDataGridView.Font = new Font(font.Families[0], 12);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Close();
            form.Show();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
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
