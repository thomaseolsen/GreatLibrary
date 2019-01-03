using System;

namespace TheGreatLibraryController.Models
{
    public class Book
    {
        public Book()
        {
            BookGUID = Guid.Empty;
            GoogleID = "";
            Title = "";
            Subtitle = "";
            Authors = "";
            Editors = "";
            MediaType = "";
            Publisher = "";
            PublicationYear = "";
            Description = "";
            ISBN10 = "";
            ISBN13 = "";
            PageCount = 0;
            HaveRead = false;
            Notes = "";
        }

        public Guid BookGUID { get; set; }
        public string GoogleID { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Authors { get; set; }
        public string Editors { get; set; }
        public string MediaType { get; set; }
        public string Publisher { get; set; }
        public string PublicationYear { get; set; }
        public string Description { get; set; }
        public string ISBN10 { get; set; }
        public string ISBN13 { get; set; }
        public int PageCount { get; set; }
        public bool HaveRead { get; set; }
        public string Notes { get; set; }
    }
}
