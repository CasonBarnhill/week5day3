using System;

namespace week5day3
{
    public class Student
    {
        public DateTime dob;
        public int Id { get; set; }
        public int Age { get; internal set; }
        public string Name { get; internal set; }
     
    }
}