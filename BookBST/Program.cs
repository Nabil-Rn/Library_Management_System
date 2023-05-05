using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBST
{
    class Program
    {
        static void Main(string[] args)
        {
            BookBST bst = new BookBST();


            bst.Add(new Book(50, "50", "Book title", 5, 2023));
            bst.Add(new Book(17, "17", "Another title", 5, 2023));
            bst.Add(new Book(55, "55", "Another title", 5, 2023));
            bst.Add(new Book(10, "10", "Another title", 5, 2023));
            bst.Add(new Book(23, "23", "Another title", 5, 2023));
            bst.Add(new Book(51, "51", "Another title", 5, 2023));
            bst.Add(new Book(67, "67", "Another title", 5, 2023));
            bst.Add(new Book(92, "92", "Another title", 5, 2023));
            bst.Add(new Book(12, "12", "Another title", 5, 2023));
            bst.Add(new Book(20, "20", "Another title", 5, 2023));

            //Book removed = bst.Remove(12);
            //List<Book> books = bst.GetBookList();
            bst.PrintSideways();
            Console.ReadLine();
        }
    }
}
