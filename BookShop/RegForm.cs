using BookShop.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BookShop
{
    public partial class RegForm : Form
    {
        private static RegForm _instance;

        private RegForm()
        {
            InitializeComponent();
        }

        public static RegForm GetInstance()
        {
            return _instance ??= new RegForm();
        }

        private void logBtn_TextChanged(object sender, EventArgs e)
        {
            var user = Program.Database.Users.FirstOrDefault(u => u.Login == logTb.Text);
            if (user is not null)
            {
                pasStatusLbl.Text = "Данное имя пользователя занято!!!";
                regBtn.Enabled = false;
            }
            else
            {
                pasStatusLbl.Text = null;
                regBtn.Enabled = true;
            }
        }

        private void passBtn_TextChanged(object sender, EventArgs e)
        {
            if (passTb.Text != repeatPassTb.Text)
            {
                pasStatusLbl.Text = "Пароли не совпадают!!!";
                regBtn.Enabled = false;
            }
            else
            {
                pasStatusLbl.Text = null;
                regBtn.Enabled = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
            AutorizatingForm.GetInstance().Show();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            var user = Program.Database.Users.FirstOrDefault(u => u.Login == logTb.Text);
            if (user is not null) return;

            if (passTb.Text != repeatPassTb.Text) return;

            var newUser = new User()
            {
                Login = logTb.Text,
                FirstName = firstNameTb.Text,
                LastName = lastNameTb.Text,
                Password = passTb.Text,
                Address = adressTb.Text,
                Phone = phoneTb.Text,
                EmailAdrress = emailTb.Text,
                UserRole = UserRoles.Member
            };

            Program.Database.Users.Add(newUser);
            Program.Database.SaveChanges();

            var id = Program.Database.Users.FirstOrDefault(u => u.Login == logTb.Text);
            Program.CurrentId = id.Id;
            Hide();
            Main.GetInstance().Show();

        }
    }
}
