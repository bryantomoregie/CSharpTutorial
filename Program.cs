using CSharpTutorial.Algo;
using CSharpTutorial.Connection3;
using CSharpTutorial.Workflow;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            BookRepository bookRepository = new BookRepository();
            var books = bookRepository.GetBooks();
            var cheapBooks = from book in books
                             where book.Price < 10 
                             orderby book.Title select book;

            var cheapBooks2 = books.Where(book => book.Price < 10).OrderBy(book => book.Title).Select(book => book.Title);
            var book1 = books.FirstOrDefault(book => book.Title == "c#");
            Console.ReadLine(); 
                
                //"SELECT * Book FROM BOOKS WHERE " +
                //"Books.Price < 10 ORDER BY Books.Title;";
            

        }

    }
}


