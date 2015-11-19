using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5day3
{
    class LibraryManager
    {
        public LibraryManager()
        {
            checkedOutBooks = new List<Library>();
        }
        public List<Library> checkedOutBooks; 

        public Student SaveStudent(Student s)
        {
            s.Age = (int)(DateTime.Now.Subtract(s.dob).TotalDays / 365);
            return s;
        }
        public void CreateBook()
        {

        }
        public Library CheckOutBook(Book b, Student s, DateTime borrowdate)
        {
            var result = new Library();
            if (checkedOutBooks.Any())
            {
                result.Id = checkedOutBooks.Max(x => x.Id) + 1;
            }
            else
            {
                result.Id = 1;
            }
            result.Book = b;
            result.Student = s;
            result.BorrowDate = borrowdate;
            result.ExpectedReturnDate = borrowdate.AddMonths(1);
            checkedOutBooks.Add(result);
            return result;
        }

        internal object AddStudent(Student s)
        {
            throw new NotImplementedException();
        }

        internal Library CheckInBook(Book b, DateTime returndate)
        {
            var result = checkedOutBooks.FirstOrDefault(x => x.Book.Id == b.Id && x.ExpectedReturnDate != null);
            result.ExpectedReturnDate = null;
            result.ActualReturnDate = returndate;
            return result;
        }
    }
}
