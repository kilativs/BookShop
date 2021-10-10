using BookShop.Models;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class AdminForm : Form
    {
        private static AdminForm _instance;

        private Book editBook;

        private int id;

        private AdminForm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }

        public static AdminForm GetInstance()
        {
            return _instance ??= new AdminForm();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            AdminLoader();
        }

        public async void AdminLoader()
        {
            await Task.Run(() =>
            {
                var user = Program.Database.Users.FirstOrDefault(u => u.Id == Program.CurrentId);
                if (user is null) Close();

                var books = Program.Database.Books.Where(n => n.Id > 0);

                Invoke(new Action(() =>
                {
                    if (user.UserRole == UserRoles.Administrator) usersBtn.Enabled = true;
                }));

                foreach (var item in books)
                {
                    DataGridViewCell id = new DataGridViewTextBoxCell();
                    DataGridViewCell name = new DataGridViewTextBoxCell();
                    DataGridViewCell author = new DataGridViewTextBoxCell();
                    DataGridViewCell publisher = new DataGridViewTextBoxCell();
                    DataGridViewCell genre = new DataGridViewTextBoxCell();
                    DataGridViewCell year = new DataGridViewTextBoxCell();
                    DataGridViewCell sale = new DataGridViewTextBoxCell();
                    DataGridViewCell descount = new DataGridViewTextBoxCell();

                    id.Value = item.Id;
                    name.Value = item.Name;
                    author.Value = item.Author;
                    publisher.Value = item.Publisher;
                    genre.Value = item.Genre;
                    year.Value = item.YearPublishing;
                    sale.Value = item.SalePrice;
                    descount.Value = item.Descount;

                    Invoke(new Action(() =>
                    {
                        DataGridViewRow row = new();
                        row.Cells.AddRange(id, name, author, publisher, genre, year, sale, descount);
                        dataGridView1.Rows.Add(row);
                    }));
                }
            });
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            var createdBooks = new AddBook();
            var res = createdBooks.ShowDialog();

            if (res == DialogResult.OK)
            {
                AdminLoader();
            }
        }

        private void editBookBtn_Click(object sender, EventArgs e)
        {
            if (editBook is null)
                MessageBox.Show("Вы не выбрали книгу.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var edit = new AddBook(editBook.Id, editBook.Name, editBook.Author, editBook.Publisher, editBook.Description,
                    editBook.CountPages, editBook.Genre, editBook.YearPublishing, editBook.CostPrice,
                    editBook.SalePrice, editBook.CountBook, editBook.Descount);
                edit.Show();
            }
        }

        private void SearchBook()
        {
            if (nameSearchTb.Text != null)
            {
                var bookName = Program.Database.Books.Where(n => n.Name == nameSearchTb.Text);

                foreach (var item in bookName)
                {
                    DataGridViewCell id = new DataGridViewTextBoxCell();
                    DataGridViewCell name = new DataGridViewTextBoxCell();
                    DataGridViewCell author = new DataGridViewTextBoxCell();
                    DataGridViewCell publisher = new DataGridViewTextBoxCell();
                    DataGridViewCell genre = new DataGridViewTextBoxCell();
                    DataGridViewCell year = new DataGridViewTextBoxCell();
                    DataGridViewCell sale = new DataGridViewTextBoxCell();
                    DataGridViewCell descount = new DataGridViewTextBoxCell();

                    id.Value = item.Id;
                    name.Value = item.Name;
                    author.Value = item.Author;
                    publisher.Value = item.Publisher;
                    genre.Value = item.Genre;
                    year.Value = item.YearPublishing;
                    sale.Value = item.SalePrice;
                    descount.Value = item.Descount;

                    dataGridView1.Rows.Clear();
                    DataGridViewRow row = new();
                    row.Cells.AddRange(id, name, author, publisher, genre, year, sale, descount);
                    dataGridView1.Rows.Add(row);
                }
            }

            if (genreSearchTb != null)
            {
                var bookGenre = Program.Database.Books.Where(n => n.Genre == genreSearchTb.Text);

                foreach (var item in bookGenre)
                {
                    DataGridViewCell id = new DataGridViewTextBoxCell();
                    DataGridViewCell name = new DataGridViewTextBoxCell();
                    DataGridViewCell author = new DataGridViewTextBoxCell();
                    DataGridViewCell publisher = new DataGridViewTextBoxCell();
                    DataGridViewCell genre = new DataGridViewTextBoxCell();
                    DataGridViewCell year = new DataGridViewTextBoxCell();
                    DataGridViewCell sale = new DataGridViewTextBoxCell();
                    DataGridViewCell descount = new DataGridViewTextBoxCell();

                    id.Value = item.Id;
                    name.Value = item.Name;
                    author.Value = item.Author;
                    publisher.Value = item.Publisher;
                    genre.Value = item.Genre;
                    year.Value = item.YearPublishing;
                    sale.Value = item.SalePrice;
                    descount.Value = item.Descount;

                    dataGridView1.Rows.Clear();
                    DataGridViewRow row = new();
                    row.Cells.AddRange(id, name, author, publisher, genre, year, sale, descount);
                    dataGridView1.Rows.Add(row);
                }
            }

            if (authorSearchTb.Text != null)
            {
                var bookAuthor = Program.Database.Books.Where(n => n.Author == authorSearchTb.Text);

                foreach (var item in bookAuthor)
                {
                    DataGridViewCell id = new DataGridViewTextBoxCell();
                    DataGridViewCell name = new DataGridViewTextBoxCell();
                    DataGridViewCell author = new DataGridViewTextBoxCell();
                    DataGridViewCell publisher = new DataGridViewTextBoxCell();
                    DataGridViewCell genre = new DataGridViewTextBoxCell();
                    DataGridViewCell year = new DataGridViewTextBoxCell();
                    DataGridViewCell sale = new DataGridViewTextBoxCell();
                    DataGridViewCell descount = new DataGridViewTextBoxCell();

                    id.Value = item.Id;
                    name.Value = item.Name;
                    author.Value = item.Author;
                    publisher.Value = item.Publisher;
                    genre.Value = item.Genre;
                    year.Value = item.YearPublishing;
                    sale.Value = item.SalePrice;
                    descount.Value = item.Descount;

                    dataGridView1.Rows.Clear();
                    DataGridViewRow row = new();
                    row.Cells.AddRange(id, name, author, publisher, genre, year, sale, descount);
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchBook();
            nameSearchTb.Text = string.Empty;
            genreSearchTb.Text = string.Empty;
            authorSearchTb.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string selId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            id = int.Parse(selId);

            var books = Program.Database.Books.Where(n => n.Id == id);

            foreach (var book in books)
            {
                editBook = new Book(book.Id, book.Name, book.Author, book.Publisher, book.Description,
                    book.CountPages, book.Genre, book.YearPublishing, book.CostPrice, book.SalePrice,
                    book.CountBook, book.Descount);
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            id = int.Parse(selId);
            var books = Program.Database.Books.FirstOrDefault(n => n.Id == id);
            if (books is null) return;

            Program.Database.Books.Remove(books);
            Program.Database.SaveChanges();
            dataGridView1.Rows.Clear();
            AdminLoader();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            Hide();
            EditUsersForm.GetInstance().Show();
        }
    }
}
