using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{


    public class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bName, string aName)
        {
            BookName = bName;
            AuthorName = aName;
        }

        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}, Author Name: {AuthorName}");
        }
    }

    public class BookShelf
    {
        private Books[] b = new Books[5];

        public Books this[int index]
        {
            get { return b[index]; }
            set { b[index] = value; }
        }

        public void DBooks()
        {
            foreach (var book in b)
            {
               book.Display();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            BookShelf shelf = new BookShelf();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the Book Name{i + 1}: ");
                string bName = Console.ReadLine();

                Console.Write($"Enter the author name {i + 1}: ");
                string aName = Console.ReadLine();

                shelf[i] = new Books(bName, aName);
            }

            Console.WriteLine("Displaying all books:");
            shelf.DBooks();
            Console.Read();
        }
    }
}