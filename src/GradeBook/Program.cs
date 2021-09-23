using System;
using System.Collections.Generic;
using GradeBook.Models;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("Emmas grade book");

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            //get statistics

            var statObj = book.GetStatistics();

            foreach (var prop in statObj.GetType().GetProperties())
            {
                System.Console.WriteLine($"{prop.Name} - {prop.GetValue(statObj, null)}");
            }
           
        }
    }
}
