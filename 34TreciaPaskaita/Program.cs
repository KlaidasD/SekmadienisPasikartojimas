using System;

namespace Sekmadienis
{
public class Program
    {
        public static void Main(string[] args)
        { 
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700 );

            Book book3 = new Book("Balta drobule", "Skema", 350);

            Book book4 = new Book();
            book4.title = "Title";
            book4.author = "Author";
            book4.pages = 500;


            Console.ReadLine();

        }
    }
}