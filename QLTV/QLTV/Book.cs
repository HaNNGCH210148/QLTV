using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public DateTime Published { get; set; }

        public Book(string title, string author, string category, DateTime published)
        {
            Title = title;
            Author = author;
            Category = category;
            Published = published;
        }
        public override string ToString()
        {
            return $"{Title} by {Author} ({Category}) - Published: {Published}";
        }
    }
    public class Borrower
    {
        public string Name { get; set; }
        public int BorrowerID { get; set; }
        public List<Book> CheckedOutBooks { get; set; }

        public Borrower(string name, int borrowerId)
        {
            Name = name;
            BorrowerID = borrowerId;
            CheckedOutBooks = new List<Book>();
        }
    }
}
