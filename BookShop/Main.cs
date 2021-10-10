using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class Main : Form
    {
        private static Main _instance;

        private int sum;

        private int id;

        public List<Book> selectedBooks = new();

        private Main()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }

        public static Main GetInstance()
        {
            return _instance ??= new Main();
        }

        public async void Loader()
        {
            await Task.Run(() =>
            {
                var user = Program.Database.Users.FirstOrDefault(u => u.Id == Program.CurrentId);
                if (user is null) Close();

                var books = Program.Database.Books.Where(n => n.Id > 0);

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

                Invoke(new Action(() =>
                {
                    userLoginLbl.Text = user.Login;

                }));
            });
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Loader();
            SellLoder();
        }

        public void SellLoder()
        {
            countBooksLbl.Text = selectedBooks.Count.ToString();

            foreach (var item in selectedBooks)
            {
                sum += item.SalePrice;
            }
            sumLbl.Text = sum.ToString();
            sum = 0;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            AutorizatingForm.GetInstance().Show();
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
                    DataGridViewCell countPages = new DataGridViewTextBoxCell();
                    DataGridViewCell genre = new DataGridViewTextBoxCell();
                    DataGridViewCell year = new DataGridViewTextBoxCell();
                    DataGridViewCell sale = new DataGridViewTextBoxCell();

                    id.Value = item.Id;
                    name.Value = item.Name;
                    author.Value = item.Author;
                    publisher.Value = item.Publisher;
                    countPages.Value = item.CountPages;
                    genre.Value = item.Genre;
                    year.Value = item.YearPublishing;
                    sale.Value = item.SalePrice;

                    dataGridView1.Rows.Clear();
                    DataGridViewRow row = new();
                    row.Cells.AddRange(id, name, author, publisher, countPages, genre, year, sale);
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
                    DataGridViewCell countPages = new DataGridViewTextBoxCell();
                    DataGridViewCell genre = new DataGridViewTextBoxCell();
                    DataGridViewCell year = new DataGridViewTextBoxCell();
                    DataGridViewCell sale = new DataGridViewTextBoxCell();

                    id.Value = item.Id;
                    name.Value = item.Name;
                    author.Value = item.Author;
                    publisher.Value = item.Publisher;
                    countPages.Value = item.CountPages;
                    genre.Value = item.Genre;
                    year.Value = item.YearPublishing;
                    sale.Value = item.SalePrice;

                    dataGridView1.Rows.Clear();
                    DataGridViewRow row = new();
                    row.Cells.AddRange(id, name, author, publisher, countPages, genre, year, sale);
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
                    DataGridViewCell countPages = new DataGridViewTextBoxCell();
                    DataGridViewCell genre = new DataGridViewTextBoxCell();
                    DataGridViewCell year = new DataGridViewTextBoxCell();
                    DataGridViewCell sale = new DataGridViewTextBoxCell();

                    id.Value = item.Id;
                    name.Value = item.Name;
                    author.Value = item.Author;
                    publisher.Value = item.Publisher;
                    countPages.Value = item.CountPages;
                    genre.Value = item.Genre;
                    year.Value = item.YearPublishing;
                    sale.Value = item.SalePrice;

                    dataGridView1.Rows.Clear();
                    DataGridViewRow row = new();
                    row.Cells.AddRange(id, name, author, publisher, countPages, genre, year, sale);
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
                var selectedBook = new SelectForm(book.Id, book.Name, book.Author, book.Description, book.SalePrice,
                    book.SalePrice - (book.SalePrice * book.Descount) / 100, book.Descount, book.YearPublishing, book.Publisher);
                selectedBook.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in selectedBooks)
            {
                var books = Program.Database.Books.Where(n => n.Id > 0);

                foreach (var book in books)
                {
                    if (item.Id == book.Id)
                    {
                        if (book.CountBook > 1)
                        {
                            book.CountBook--;
                        }
                        else
                        {
                            Program.Database.Books.Remove(book);
                        }
                    }
                }
            }
            Program.Database.SaveChanges();
            dataGridView1.Rows.Clear();
            Loader();
            selectedBooks.Clear();
            countBooksLbl.Text = null;
            sumLbl.Text = null;
        }
    }
}
