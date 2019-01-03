using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TheGreatLibraryController.Models;

namespace TheGreatLibraryController.Controllers
{
    class BookController
    {
        public BookController(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void GetBooks(string filterType, string filter)
        {
            Books = new List<Book>();
            DataTable dt = new DataTable();

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT *\n");
            sql.Append("FROM viwBookDetail\n");
            if (filterType == "Author")
            {
                sql.Append("WHERE Author LIKE '%" + filter + "%'");
            }
            else if (filterType == "ISBN")
            {
                if (filter.Length > 10)
                {
                    sql.Append("WHERE ISBN13 LIKE '%" + filter + "%'");
                }
                else
                {
                    sql.Append("WHERE ISBN10 LIKE '%" + filter + "%'");
                }
            }
            else if (filterType == "Notes")
            {
                sql.Append("WHERE Notes LIKE '%" + filter + "%'");
            }
            //else if (filterType == "Read")
            //{
            //    sql.Append("WHERE Read LIKE '%" + filter + "%'");
            //}
            else if (filterType == "Title")
            {
                sql.Append("WHERE Title LIKE '%" + filter + "%'");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql.ToString(), conn);

                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    ad.Fill(dt);
                }
            }

            Books = MakeBooks(dt);
        }

        public List<Book> MakeBooks(DataTable dt)
        {
            var retVal = new List<Book>();

            foreach (DataRow row in dt.Rows)
                retVal.Add(MakeBook(row));

            return retVal;
        }

        public Book MakeBook(DataRow row)
        {
            var retVal = new Book();

            retVal.BookGUID = Guid.Parse(row["BookGUID"].ToString());
            retVal.GoogleID = row["GoogleID"].ToString();
            retVal.Title = row["Title"].ToString();
            retVal.Subtitle = row["Subtitle"].ToString();
            retVal.Authors = row["Authors"].ToString();
            retVal.Editors = row["Editors"].ToString();
            retVal.MediaType = row["MediaType"].ToString();
            retVal.Publisher = row["Publisher"].ToString();
            retVal.PublicationYear = row["PublicationYear"].ToString();
            retVal.Description = row["Description"].ToString();
            retVal.ISBN10 = row["ISBN10"].ToString();
            retVal.ISBN13 = row["ISBN13"].ToString();
            retVal.PageCount = int.Parse(row["PageCount"].ToString());
            retVal.HaveRead = bool.Parse(row["HaveRead"].ToString());
            retVal.Notes = row["Notes"].ToString();

            return retVal;
        }

        public string ConnectionString { get; set; }
        public List<Book> Books { get; set; }
    }
}
