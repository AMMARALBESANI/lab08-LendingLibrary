using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary.Casses
{
    public class Book
    {
        public override string ToString()
        {
            return $"Title:{Title}\n{FirstName} {LastName} {NumberOfPages}";
        }
        public string Title { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public int NumberOfPages { get; set; }
        public Book( string title , string firstname , string lastname , int numberofpages)
        {
            Title = title;
            FirstName = firstname;
            LastName = lastname;
            NumberOfPages = numberofpages;
        }
    }
}
