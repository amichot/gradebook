using System.Globalization;
using System;
using System.Collections.Generic;

namespace GradeBook

{
    class Book
    {
        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            //var midGrade = double.MinValue;
            var length = grades.Count;
            //var middleIndex = Math.Round(0, length / 2);

            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            };
            result /= grades.Count;

            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The Average grade is {result}");
        }

        private List<double> grades;
    }
}