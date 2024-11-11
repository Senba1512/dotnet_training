using Assignment4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Doctor

    {

        private string regNo;
        private string name;
        private decimal feesCharged;


        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal FeesCharged
        {
            get { return feesCharged; }
            set { feesCharged = value; }
        }


        public void Display()
        {
            Console.WriteLine($"Doctor Registration No: {RegNo}");
            Console.WriteLine($"Doctor Name: {Name}");
            Console.WriteLine($"Fees Charged: {FeesCharged}");
        }
    }


    public class Book
    {

        public string BookName { get; set; }
        public string AuthorName { get; set; }


        public Book(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }


        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}");
            Console.WriteLine($"Author Name: {AuthorName}");
        }
    }


    public class BookShelf
    {

        private Book[] books = new Book[5];


        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                {
                    return books[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
            }
            set
            {
                if (index >= 0 && index < books.Length)
                {
                    books[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
            }
        }


        public void DisplayBooks()
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    Console.WriteLine($"Book {i + 1}:");
                    books[i].Display();
                    Console.WriteLine();
                }
            }
        }
    }

    
    public class Program
    {
        public static void Main()
        {
            
            Doctor doctor = new Doctor();
            doctor.RegNo = "CH1";
            doctor.Name = "Christe";
            doctor.FeesCharged = 1500;
            doctor.Display();


            BookShelf bookShelf = new BookShelf();


            bookShelf[0] = new Book("Jayakanthan", "Unnaipol oruvan");
            bookShelf[1] = new Book("Kalki", "Ponniyin Selvan");
            bookShelf[2] = new Book("Perumal murugan", "Goat Thief");
            bookShelf[3] = new Book("Ashokamitran", "Aalayam");
            bookShelf[4] = new Book("Indira Parthasarathy", "kovil");


            Console.WriteLine("Books in the BookShelf:");
            bookShelf.DisplayBooks();
            Console.Read();
        }
    }
}