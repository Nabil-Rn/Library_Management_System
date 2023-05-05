using BookBST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBSTApplication
{
    static class Program
    {
        /// <summary>
        /// </summary>
        [STAThread]
        static void Main()
        {
            var Books = userForm.Books;
            Books.Add(new Book(50, "Author", "Book title", 5, 2023));
            Books.Add(new Book(17, "Author", "Book title", 3, 2023));
            Books.Add(new Book(55, "Author", "Book title", 5, 2023));
            Books.Add(new Book(10, "Author", "Book title", 2, 2023));
            Books.Add(new Book(23, "Author", "Book title", 5, 2023));
            Books.Add(new Book(51, "Author", "Book title", 1, 2023));
            Books.Add(new Book(67, "Author", "Book title", 5, 2023));
            Books.Add(new Book(92, "Author", "Book title", 4, 2023));
            Books.Add(new Book(12, "Author", "Book title", 3, 2023));
            Books.Add(new Book(20, "Author", "Book title", 1, 2023));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
