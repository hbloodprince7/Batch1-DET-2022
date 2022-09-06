using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class CodeFirstApp
    {
        static void Main(string[] args)
        {
            AddNewBook();
        }
        private static void AddNewBook()
        {
            var ctx = new BookContext();
            Book book = new Book();
            book.BookID = 1;
            book.BookName = "SPIDERMAN #1";
            book.author = "Stan Lee";
            book.price = 69;

            try
            {
                ctx.Books.Add(book);
                ctx.SaveChanges();
                Console.WriteLine($"Added {book.BookName} Successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message) ;
            }
        }   
    }
}
