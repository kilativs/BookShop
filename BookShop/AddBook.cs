using BookShop.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BookShop
{
    public partial class AddBook : Form
    {
        private int editId;

        public AddBook(int editId = 0, string name = null, string author = null, string publisher = null, string description = null,
               int countPages = 0, string genre = null, int year = 0, int costPrice = 0, int salePrice = 0, int countBook = 0,
               int discount = 0)
        {
            InitializeComponent();
            this.editId = editId;
            nameTb.Text = name;
            authorTb.Text = author;
            publisherTb.Text = publisher;
            countBookTb.Text = countBook.ToString();
            genreTb.Text = genre;
            yearTb.Text = year.ToString();
            countPagesTb.Text = countPages.ToString();
            costPriceTb.Text = costPrice.ToString();
            salePriceTb.Text = salePrice.ToString();
            descriptionTb.Text = description;
            discountPriceLbl.Text = salePrice.ToString();
            discontTB.Text = discount.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (editId != 0)
            {
                var n = Program.Database.Books.FirstOrDefault(n => n.Id == this.editId);
                if (n is null) return;

                float selDesc = int.Parse(salePriceTb.Text) - (int.Parse(salePriceTb.Text) * n.Descount) / 100;
                discountPriceLbl.Text = selDesc.ToString();
                n.Descount = int.Parse(discontTB.Text);
                n.Name = nameTb.Text;
                n.Author = authorTb.Text;
                n.Publisher = publisherTb.Text;
                n.Genre = genreTb.Text;
                n.CostPrice = int.Parse(costPriceTb.Text);
                n.SalePrice = int.Parse(salePriceTb.Text);
                n.YearPublishing = int.Parse(yearTb.Text);
                n.Description = descriptionTb.Text;
                n.CountBook = int.Parse(countBookTb.Text);
                n.CountPages = int.Parse(countPagesTb.Text);

                Program.Database.SaveChanges();

                Close();
                AdminForm.GetInstance().dataGridView1.Rows.Clear();
                AdminForm.GetInstance().AdminLoader();

                return;
            }

            var book = new Book()
            {
                Name = nameTb.Text,
                Author = authorTb.Text,
                Publisher = publisherTb.Text,
                Genre = genreTb.Text,
                CostPrice = int.Parse(costPriceTb.Text),
                SalePrice = int.Parse(salePriceTb.Text),
                YearPublishing = int.Parse(yearTb.Text),
                Description = descriptionTb.Text,
                CountBook = int.Parse(countBookTb.Text),
                CountPages = int.Parse(countPagesTb.Text),
                Descount = int.Parse(discontTB.Text),
                DateAdded = DateTime.Now.Date
            };

            Program.Database.Books.Add(book);
            Program.Database.SaveChanges();
            Close();
            AdminForm.GetInstance().dataGridView1.Rows.Clear();
            AdminForm.GetInstance().AdminLoader();
        }

        private void canselBtn_Click(object sender, EventArgs e)
        {
            AddBook.ActiveForm.Close();
        }
    }
}
