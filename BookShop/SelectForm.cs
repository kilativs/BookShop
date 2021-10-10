using BookShop.Models;
using System;
using System.Windows.Forms;

namespace BookShop
{
    public partial class SelectForm : Form
    {
        public SelectForm(int id, string name, string author, string description, int salePrice,
            int newPrice, int descount, int yearPublisher, string publisher)
        {
            InitializeComponent();
            idBookLbl.Text = id.ToString();
            authorBookLbl.Text = author;
            nameBookLbl.Text = name;
            descriptionBookTB.Text = description;
            yearPublisherLblb.Text = yearPublisher.ToString();
            publisherBookLbl.Text = publisher;
            descLbl.Text = descount.ToString();
            newPriceLbl.Text = (newPrice - (newPrice * descount) / 100).ToString();
            priceLbl.Text = salePrice.ToString();
        }

        private void canselBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            var book = new Book()
            {
                SalePrice = int.Parse(newPriceLbl.Text),
                Id = int.Parse(idBookLbl.Text)
            };

            Main.GetInstance().selectedBooks.Add(book);
            Main.GetInstance().SellLoder();
            Close();
        }
    }
}
