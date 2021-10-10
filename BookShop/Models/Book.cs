using System;

namespace BookShop.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public int CountPages { get; set; }

        public string Genre { get; set; }

        public int YearPublishing { get; set; }

        public int CostPrice { get; set; }

        public int SalePrice { get; set; }

        public string Description { get; set; }

        public int CountBook { get; set; }

        public DateTime DateAdded { get; set; }

        public int Descount { get; set; }

        public Book(int editId, string name, string author, string publisher, string description,
               int countPages, string genre, int year, int costPrice, int salePrice, int countBook,
               int discount)
        {
            Id = editId;
            Name = name;
            Author = author;
            Publisher = publisher;
            Description = description;
            CountPages = countPages;
            Genre = genre;
            YearPublishing = year;
            CostPrice = costPrice;
            SalePrice = salePrice;
            CountBook = countBook;
            Descount = discount;
        }

        public Book()
        {
            Id = 0;
            Name = null;
            Author = null;
            Publisher = null;
            Description = null;
            CountPages = 0;
            Genre = null;
            YearPublishing = 0;
            CostPrice = 0;
            SalePrice = 0;
            CountBook = 0;
            Descount = 0;
        }
    }

}
