using System;
using System.Linq;
using System.Windows.Forms;

namespace BookShop
{
    public partial class AutorizatingForm : Form
    {
        private static AutorizatingForm _instance;

        private AutorizatingForm()
        {
            InitializeComponent();
        }

        public static AutorizatingForm GetInstance()
        {
            return _instance ??= new AutorizatingForm();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            var user = Program.Database.Users.FirstOrDefault(u => u.Login == LoginTB.Text && u.Password == paswwordTB.Text);

            if (user is null)
            {
                MessageBox.Show("Неверный логин или пароль.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.CurrentId = user.Id;
            Hide();
            if (user.UserRole == Models.UserRoles.Member)
            {
                Main.GetInstance().Show();
            }
            else
            {
                AdminForm.GetInstance().Show();
            }
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            Hide();
            RegForm.GetInstance().Show();
        }
    }
}
