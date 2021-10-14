using System;
using System.Collections.Generic; 

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Son Hoang"); 
            book.AddGrade(89.1); 
            book.AddGrade(90.5); 
            book.AddGrade(77.5);
            var stat = book.GetStatistics(); 

            Console.WriteLine($"the low grade is {stat.Low:N1}");
            Console.WriteLine($"the high grade is {stat.High:N1}");
            Console.WriteLine($"the average grade is {stat.Average:N1}");
        }
    }
}
