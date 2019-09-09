using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Ivar.Models
{
    public class BookRepository : IBookRepository
    {
        //......Adding XML books to the List:
        /*MATCHING books.xml: <catalog>
               <book id="B1">
                <author>Kutner, Joe</author>
                <title>Deploying with JRuby</title>
                <genre>Computer</genre>
                <price>33.00</price>
                <publish_date>2012-08-15</publish_date>
                <description>Deploying with JRuby is the...>
              </book>*/

        public IEnumerable<Book> GetAll()
        {


            XDocument doc = XDocument.Load("C:\\Users\\Petra Mellbrand\\OneDrive\\Webdev\\sigmasearch\\24aug\\Ivar\\Ivar\\App_Data\\books.xml");

            foreach (XElement element in doc.Descendants("catalog")

                .Descendants("book"))

            {

                Book book = new Book
                {
                    BookId = element.Attribute("id").Value,
                    Author = element.Element("author").Value,
                    Title = element.Element("title").Value,
                    Genre = element.Element("genre").Value,
                    Description = element.Element("description").Value,
                    Publish_Date = DateTime.Parse(element.Element("publish_date").Value),
                    Price = decimal.Parse(element.Element("price").Value, new NumberFormatInfo { NumberDecimalSeparator = "." })
                };

                books.Add(book);
            }
            return books;
        }

        //....Making a List of all Books in the XML
        private List<Book> books = new List<Book>();


        //private readonly int NextId = 1;


        public BookRepository()
        {
            Console.WriteLine(new Book());
        }

 //............................Get ID...................
 
        /*public Book Get(int id)
        {
            return books.Find(p => p.Id == id);
        }*/

//...........................................Add
        /*public Book Add(Book item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = NextId++;
            books.Add(item);
            return item;
        }
//...........................................Remove
        public void Remove(int id)
        {
            books.RemoveAll(p => p.Id == id);
        }

//...........................................Put (Update)
       /* public bool Update(Book item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = books.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            books.RemoveAt(index);
            books.Add(item);
            return true;
        }*/
        
    }
}