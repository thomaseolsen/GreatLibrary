using System;

namespace TheGreatLibraryController.Models
{
    public class Book : IComparable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Book otherBook = obj as Book;
            if (otherBook != null)
                return this.Title.CompareTo(otherBook.Title);
            else
                throw new ArgumentException("Object is not a Book.");
        }
    }
}
