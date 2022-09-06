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
            //AddNewBook();
            //DeleteBook();
            //UpdateBook();
            GetBooks();
        }
        private static void AddNewBook()
        {
            var ctx = new BookContext();
            Book book = new Book();
            book.BookID = 2;
            book.BookName = "THOR #77";
            book.author = "Stan Lee";
            book.price = 60;

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
        private static void DeleteBook()
        {
            var ctx = new BookContext();
            var book = ctx.Books.Where(e => e.BookID == 73).SingleOrDefault();
            book.BookID = 73;
            book.BookName = "SPIDERMAN SPECIAL EDITION";


            try
            {
                ctx.Books.Remove(book);
                ctx.SaveChanges() ;
                Console.WriteLine($"Removed {book.BookName} Succesfully");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message) ;
            }
        }
        private static void UpdateBook()
        {
            var ctx = new BookContext();
            var book = ctx.Books.Where(e => e.BookID == 73).SingleOrDefault();
            book.BookID = 73;
            book.BookName = "SPIDERMAN SPECIAL EDITION";
            try
            {

                ctx.Update(book);
                ctx.SaveChanges();
                Console.WriteLine($"Updated {book.BookID}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void GetBooks()
        {
            var ctx = new BookContext();
            var book = ctx.Books;
            try
            {
                foreach (var b in book)
                    Console.WriteLine($"{b.BookName} by {b.author}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
