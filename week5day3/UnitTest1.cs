using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace week5day3
{
    [TestClass]
    public class LibraryManagerTests

    {

        // When adding a student, their age is calculated correctly
        [TestMethod]
            public void CorrectStudentAge()
            {
            var s = new Student();
            s.Name = "Jo";
            var expectedAge = 27;
            var daysInYear = 365;
            s.dob = DateTime.Now.AddDays(-daysInYear * expectedAge);
            LibraryManager mgr = new LibraryManager();
            var savedStudent = mgr.SaveStudent(s);
            Assert.AreEqual(expectedAge, savedStudent.Age);
            }

        
        //When checking out a book the check out date is set correctly and the expected return date is set to 1 month after the check out date.
        [TestMethod]
        public void CheckedOoutBookDatesSetCorrectly()
        {
            var s = new Student();
            var b = new Book();
            var checkOutDate = DateTime.Parse("5/5/2000");
            LibraryManager mgr = new LibraryManager();
            Library result = mgr.CheckOutBook(b, s, checkOutDate);
            Assert.AreEqual(checkOutDate, result.BorrowDate);
            Assert.AreEqual(checkOutDate.AddMonths(1), result.ExpectedReturnDate);
        }




        //When a book is checked in - the actual return date is the right day and the expected return date is set to null.

        [TestMethod]
           
            public void CheckedInBookDatesSetCorrectly()
        {
            var s = new Student();
            var b = new Book();
            LibraryManager mgr = new LibraryManager();
            mgr.CheckOutBook(b, s, DateTime.Parse("5/5/2000"));
            Library result2 = mgr.CheckInBook(b, DateTime.Parse("5/9/2000"));
            Assert.AreEqual(DateTime.Parse("5/5/2000"), result2.BorrowDate);
            Assert.IsNull(result2.ExpectedReturnDate);
            Assert.AreEqual(DateTime.Parse("5/9/2000"), result2.ActualReturnDate);

        }
      

    }
}
