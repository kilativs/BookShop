using BookShop.Models;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class EditUsersForm : Form
    {
        private static EditUsersForm _instance;

        private int id;

        private User editUser;

        private EditUsersForm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }

        public static EditUsersForm GetInstance()
        {
            return _instance ??= new EditUsersForm();
        }

        public async void UserLoader()
        {
            await Task.Run(() =>
            {
                var users = Program.Database.Users.Where(n => n.Id > 0);
                if (users is null) Close();


                foreach (var user in users)
                {
                    DataGridViewCell id = new DataGridViewTextBoxCell();
                    DataGridViewCell login = new DataGridViewTextBoxCell();
                    DataGridViewCell password = new DataGridViewTextBoxCell();
                    DataGridViewCell firstName = new DataGridViewTextBoxCell();
                    DataGridViewCell lastName = new DataGridViewTextBoxCell();
                    DataGridViewCell address = new DataGridViewTextBoxCell();
                    DataGridViewCell email = new DataGridViewTextBoxCell();
                    DataGridViewCell phone = new DataGridViewTextBoxCell();
                    DataGridViewCell role = new DataGridViewTextBoxCell();

                    id.Value = user.Id;
                    login.Value = user.Login;
                    password.Value = user.Password;
                    firstName.Value = user.FirstName;
                    lastName.Value = user.LastName;
                    address.Value = user.Address;
                    email.Value = user.EmailAdrress;
                    phone.Value = user.Phone;
                    role.Value = user.UserRole;

                    Invoke(new Action(() =>
                    {
                        DataGridViewRow row = new();
                        row.Cells.AddRange(id, login, password, firstName, lastName, address, email, phone, role);
                        dataGridView1.Rows.Add(row);
                    }));
                }
            });
        }

        private void EditUsersForm_Load(object sender, EventArgs e)
        {
            UserLoader();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string selectId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            id = int.Parse(selectId);

            var users = Program.Database.Users.Where(n => n.Id == id);

            foreach (var user in users)
            {
                editUser = new User(user.Id, user.Login, user.Password, user.FirstName, user.LastName,
                    user.Address, user.Phone, user.EmailAdrress, user.UserRole);
            }
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            if (editUserBtn is null)
                MessageBox.Show("Вы не выбрали пользователя.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var edit = new EditUserForm(editUser.Id, editUser.Login, editUser.Password, editUser.FirstName, editUser.LastName,
                    editUser.Address, editUser.Phone, editUser.EmailAdrress, editUser.UserRole.ToString());
                edit.Show();
            }
        }

        private void delUserBtn_Click(object sender, EventArgs e)
        {
            string selId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            id = int.Parse(selId);
            var user = Program.Database.Users.FirstOrDefault(n => n.Id == id);
            if (user is null) return;

            Program.Database.Users.Remove(user);
            Program.Database.SaveChanges();
            dataGridView1.Rows.Clear();
            UserLoader();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            AdminForm.GetInstance().Show();
        }
    }
}
