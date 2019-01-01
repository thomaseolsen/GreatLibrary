using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheGreatLibraryController.Models;

namespace TheGreatLibrary.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }
        public List<Book> Books { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
            Books = new List<Book>();
            var book1 = new Book();
            var book2 = new Book();
            var book3 = new Book();
            book1.Title = "War and Peace";
            book1.Author = "Leo Tolstoy";
            book1.Description = "This is a test description.";
            Books.Add(book1);
            book2.Title = "The Double";
            book2.Author = "Fyodor Dostoyevsky";
            book2.Description = "This is a test description.";
            Books.Add(book2);
            book3.Title = "Crime and Punishment";
            book3.Author = "Fyodor Dostoyevsky";
            book3.Description = "This is a test description.";
            Books.Add(book3);
            Books.Sort();
        }
    }
}
