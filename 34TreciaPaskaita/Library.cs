using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Sekmadienis
{
    /*Sukurkite klasę Library, kuri turės:

Book masyvą
Funkciją AddBook(Book book), kuri pridės knygą į nurodytą vietą į masyvą
Funkciją GetBooksByAuthor(string author), kuri grąžins visas tam tikro autoriaus knygas
Funckija kuria atspausdina GetBooksByAuthor grazinta masyva*/

    /*Patobilinti AddBook metodą, kad jis praplėstų masyvo dydį kaskart pridėdamas naują knygą.
Sukurti funkciją RemoveBook(int index) kuri pašalina knyga iš masyvo pagal norodytą index'ą ir sumažina masyvą, nepalieka tarpo, paslenka knygas taip kad nebūtų null elementų.
(Masyvas inicializavus klasę Library turi būti [0])*/



   /* public class Library
    {
        Book[] book = new Book[0];

        public void AddBook(Book naujaBook)
        {
            Book[] bookPl = new Book[book.Length + 1];

            for (int i = 0; i < book.Length; i++)
            {
                bookPl[i] = book[i];
            }

            bookPl[bookPl.Length - 1] = naujaBook;

            book = bookPl;

        }

        public Book[] GetBooksByAuthor(string author)
        {
            int skaicius = 0;

            foreach (Book b in book)
            {
                if (b.author == author)
                {
                    skaicius++;
                }
            }

            // Create an array to store the matching books
            Book[] matchingBooks = new Book[skaicius];

            // Populate the array with books by the specified author
            int index = 0;
            foreach (Book b in book)
            {
                if (b.author == author)
                {
                    matchingBooks[index] = b;
                    index++;
                }
            }

            return matchingBooks;
        }

        public void AtspausdinkMasyva(Book[] books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {book.title}, Author: {book.author}, Pages: {book.pages}");
            }

        }


    }     ChatGPT sprendimasm, nelabai kazka suprantu..*/
}
    


