using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheGreatLibraryController.Controllers;
using TheGreatLibraryController.Models;

namespace TheGreatLibrary.Pages
{
    public class ContactModel : PageModel
    {
        public List<Book> Books { get; set; }
        public 

        public void OnGet()
        {
            //BookController bc = new TheGreatLibraryController.Controllers.BookController()
            Books = new List<Book>();
            var book1 = new Book();
            var book2 = new Book();
            var book3 = new Book();
            book1.Title = "War and Peace";
            book1.Authors = "Leo Tolstoy";
            book1.Description = "This is a test description.";
            Books.Add(book1);
            book2.Title = "The Double";
            book2.Authors = "Fyodor Dostoyevsky";
            book2.Description = "This is a test description.";
            Books.Add(book2);
            book3.Title = "Crime and Punishment";
            book3.Authors = "Fyodor Dostoyevsky";
            book3.Description = "This is a test description.";
            Books.Add(book3);
            Books.OrderBy(c => c.Title).ThenBy(c => c.Authors).ThenBy(c => c.Editors);
        }
    }
}
