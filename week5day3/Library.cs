using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5day3
{
    class Library
    {
        internal object ExpectedReturnDate;

        public object BorrowDate { get; internal set; }
        public DateTime? ActualReturnDate { get; internal set; }
        public int Id { get; internal set; }
        public Book Book { get; internal set; }
        public Student Student { get; internal set; }

        public static implicit operator Library(LibraryManager v)
        {
            throw new NotImplementedException();
        }

        internal Library CheckOutBook(Student s, Book b)
        {
            throw new NotImplementedException();
        }
    }
}
