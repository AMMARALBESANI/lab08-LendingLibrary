using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary.Casses
{
    public class Library : ILIbrary
    {
        private Dictionary<string , Book> newLibrary ;
        public Library()
        {
            newLibrary = new Dictionary<string , Book>();
        }
        public int Count => newLibrary.Count;

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
           Book addingBook = new Book(title , firstName, lastName, numberOfPages);   
           newLibrary.Add(title , addingBook);
        }

       public void Return(Book book)
        {
            newLibrary.Add (book.Title , book);
        }

       public Book Borrow(string title)
        {
            foreach (var item in newLibrary)
            {
                if (item.Key==title)
                {

                    Book selectingBook= item.Value;
                    newLibrary.Remove(item.Key);
                    return selectingBook;
                }
                
            }
            
            return null;
        }

        IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
        {
            return newLibrary.Values.GetEnumerator();
        }
        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

        public void print()
        {
            foreach (var item in newLibrary)
            {
                Console.Write(item.Value.Title+"\t" );
                Console.Write(item.Value.FirstName+" ");
                Console.Write(item.Value.LastName+"\t");
                Console.WriteLine(item.Value.NumberOfPages);

            }
        }

    }
}
