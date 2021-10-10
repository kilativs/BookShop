using BookShop.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BookShop
{
    public partial class EditUserForm : Form
    {
        private int editId;

        public EditUserForm(int id, string login, string password, string firstName, string lastName, string address, string phone,
            string email, string role)
        {
            InitializeComponent();
            editId = id;
            logTb.Text = login;
            pasTB.Text = password;
            firstNameTb.Text = firstName;
            lastNameTb.Text = lastName;
            adressTb.Text = address;
            phoneTb.Text = phone;
            emailTb.Text = email;
            roleCb.DataSource = Enum.GetValues(typeof(UserRoles));
        }

        private UserRoles ReadComboBox()
        {
            UserRoles selectedTypeParsing;
            Enum.TryParse(roleCb.SelectedValue.ToString(), out selectedTypeParsing);

            return selectedTypeParsing;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (editId != 0)
            {
                var n = Program.Database.Users.FirstOrDefault(n => n.Id == editId);
                if (n is null) return;

                var role = ReadComboBox();

                n.UserRole = (UserRoles)role;

                Program.Database.SaveChanges();

                Close();
                EditUsersForm.GetInstance().dataGridView1.Rows.Clear();
                EditUsersForm.GetInstance().UserLoader();

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
