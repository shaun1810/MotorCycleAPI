using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grade.Tests
{
    [TestClass]
    public class GradeBookTest
    {
        [TestMethod]
        public void computesHighestGrade()
        {
            Grades.GradeBook book = new Grades.GradeBook();
            book.AddGrade(78);
            book.AddGrade(99);
            book.AddGrade(1);
            Grades.Statistics result = book.ComputeStatistics();
            Assert.AreEqual(99,result.GetHighestGrade());
        }

        [TestMethod]
        public void computesLowestGrade()
        {
            Grades.GradeBook book = new Grades.GradeBook();
            book.AddGrade(78);
            book.AddGrade(99);
            book.AddGrade(1);
            Grades.Statistics result = book.ComputeStatistics();
            Assert.AreEqual(1,result.GetLowestGrade());
        }

        [TestMethod]
        public void computeAverageGrade()
        {
          Grades.GradeBook book = new Grades.GradeBook();
          book.AddGrade(78);
          book.AddGrade(99);
          book.AddGrade(1);
          Grades.Statistics result = book.ComputeStatistics();
          Assert.AreEqual(59.33, result.GetAverGrade(), 0.01);
        }

        [TestMethod]
        public void computeLetterGrade()
        {
            Grades.GradeBook book = new Grades.GradeBook();
            book.AddGrade(78);
            book.AddGrade(99);
            book.AddGrade(1);
            Grades.Statistics result = book.ComputeStatistics();
            Assert.AreEqual("F", result.LetterGrade);

        }

    }
}  