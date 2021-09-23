using System;
using GradeBook.Models;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculateStatistics()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);


            //act
            var statObj = book.GetStatistics();

            //assert
            Assert.Equal(85.6, statObj.Average, 1);
            Assert.Equal(90.5, statObj.High, 1);
            Assert.Equal(77.3, statObj.Min, 1);
        }
    }
}
