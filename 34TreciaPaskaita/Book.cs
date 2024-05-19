using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekmadienis
{

    /* Užduotis 1: Knygų Katalogas
Užduoties Aprašymas:
Sukurkite klasę Book, kuri turės šias savybes:

Title(string)
Author(string)
Pages(int)*/

    public class Book

    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {

        }
        
        public Book(string aTitle, string aAuthor, int aPages)
        {
            Console.WriteLine($"Creating a book.. {aTitle} autorius : {aAuthor} {aPages}psl. ");
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
        
    }
}
