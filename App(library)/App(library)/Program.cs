
using Library.Book;
using Library.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
    namespace Layout_Library
{
        class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hyu Library");
            Console.WriteLine("Choose an option");
            Console.WriteLine("0 - GetBook");
            Console.WriteLine("1 - AddBook");
            Console.WriteLine("2 - UpdateBook");
            Console.WriteLine("3 - RemoveBook");
            Console.Write("Enter your option - Function number: ");
            int number = int.Parse(Console.ReadLine());
             

            int GetBook = 0;
            int AddBook = 1;
            int UpdateBook = 2;
            int RemoveBook = 3;
            do
            {
                if (number == 0)
                {
                    Console.WriteLine("View cart");
                    Console.WriteLine("Into money");
                    Console.WriteLine("Select a payment");
                    Console.WriteLine("Choose shipping method");
                }
                else if (number == 1)
                {
                    Console.WriteLine("Enter Information please...");
                    Console.ReadLine();
                    Console.Write("ID code: ");

                    Console.ReadLine();
                    Console.Write("Name: ");

                    Console.ReadLine();
                    Console.Write("Description: ");

                    Console.ReadLine();
                    Console.Write("Author: ");

                    Console.ReadLine();
                    Console.Write("PublishDate: ");

                    Console.ReadLine();
                    Console.Write("Translator: ");
                }
                else if (number == 2)
                {
                    Console.ReadLine();
                    Console.WriteLine("Alternative name: ");

                    Console.ReadLine();
                    Console.WriteLine("Author: ");

                    Console.ReadLine();
                    Console.WriteLine("Publishing house: ");

                    Console.ReadLine();
                    Console.WriteLine("Publishing year: ");

                    Console.ReadLine();
                    Console.WriteLine("Topic: ");

                    Console.ReadLine();
                    Console.WriteLine("Language: ");

                    Console.ReadLine();
                    Console.WriteLine("Page number: ");
                }
                else if (number == 3)
                {
                    var books = GetBooks();
                    var book = books.Find(e => e.Id == id);
                    books.Remove(book);
                    Console.WriteLine("Book removed!");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            }
            while (number > 4);
            Console.ReadKey();
        }
    }
}
