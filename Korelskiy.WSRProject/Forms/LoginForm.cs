using System;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using Korelskiy.WSRProject.Infrastructure;
using Korelskiy.WSRProject.Models;

namespace Korelskiy.WSRProject
{
    public partial class LoginForm : Form
    {
        private int uncorrectLoginTimes = 0;
        private IDbProccessor dbProcessor;
        private DbProcessor processor = new DbProcessor();
        int seconds = 10;
        PrivateFontCollection font;
        public LoginForm()
        {
            InitializeComponent();
            dbProcessor = new DbProcessor();
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
            usernameLabel.Font = new Font(font.Families[0], 12);
            passwordLabel.Font = new Font(font.Families[0], 12);
            loginButton.Font = new Font(font.Families[0], 12);
            exitButton.Font = new Font(font.Families[0], 12);
            userNameTextBox.Font = new Font(font.Families[0], 12);
            passwordTextBox.Font = new Font(font.Families[0], 12);
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            Login(userNameTextBox.Text, passwordTextBox.Text);
        }
        private void Login(string userName, string password)
        {
            if (dbProcessor.Login(userName, password))
            {
                Form form = new Form();
                int role = processor.GetUserRole(userName);
                User currentUser = processor.GetUsers().FirstOrDefault(x => x.EmailAddress == userName);
                UserActivity activity = new UserActivity();
                activity.LoginTime = DateTime.Now.TimeOfDay;
                activity.UserId = currentUser.Id;
                if (role == 1)
                {
                    form = new AdminForm(currentUser, activity);
                }
                if (role == 2)
                {
                    form = new UserForm(currentUser, activity);
                }
                this.Hide();
                form.Show();
            }
            else
            {
                uncorrectLoginTimes++;
                if (uncorrectLoginTimes > 3)
                {
                    uncorrectLoginTimes = 0;
                    secondsLabel.Visible = true;
                    loginButton.Enabled = false;
                    timer1.Enabled = true;
                    timer1.Start();
                }
                       
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                seconds = 10;
                secondsLabel.Visible = false;
                loginButton.Enabled = true;
            }
            secondsLabel.Text = $"{seconds--}";
            
        }
    }
}

