using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook.Models
{
    public class Book
    {
        public List<double> Grades { get; set; }
        public string Name { get; set; }
        

        public Book(string name = null)
        {
            Grades = new List<double>();
            if (name == null)
            {
                Name = "No name";
            }
            else
            {
                Name = name;
            }
        }
        public void AddGrade(double grade) => Grades.Add(grade);


        public Statistics GetStatistics()
        {
            var statObj = new Statistics();
            statObj.High = ComputeHighestgrade();
            statObj.Min = ComputeLowestGrade();
            statObj.Average = ComputeAverageGrade();

            return statObj;
        }

        private double ComputeHighestgrade()
        {
            var highGrade = double.MinValue;
            foreach (var grade in Grades)
            {
                highGrade = Math.Max(highGrade, grade);
            }
            return highGrade;
        }

        private double ComputeLowestGrade()
        {
            var lowestGrade = double.MaxValue;
            foreach (var grade in Grades)
            {
                lowestGrade = Math.Min(lowestGrade, grade);
            }

            return lowestGrade;
        }

        private double ComputeAverageGrade()
        {
            var averageGrade = Grades.Sum() / Grades.Count;
            return averageGrade;
        }
    }
}
