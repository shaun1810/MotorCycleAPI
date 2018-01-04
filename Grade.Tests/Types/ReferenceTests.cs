using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Tests.Types
{

[TestClass]
public class TypeTests
{
    [TestMethod]
    public void UsingArrays()
    {
        const int gradeNumber = 3;
        float[] grades;
        grades= new float[gradeNumber];
        AddGrades(grades);
        Assert.AreEqual(89.9f, grades[1]);
    }
    private void AddGrades(float[] grades)
    {
        grades[1] = 89.9f;    
    }

    [TestMethod]
    public void UpperCaseString()
    {
        string name = "shaun";
        name = name.ToUpper();
        Assert.AreEqual("SHAUN", name);
    }

    [TestMethod]
    public void AddDaysToDateTime()
    {
        DateTime date = new DateTime(2018 , 1, 2);
        date = date.AddDays(1);

        Assert.AreEqual(3, date.Day);
    }

    [TestMethod]
    public void stringComparison()
    {
        string name = "Shaun";
        string name2 ="shaun";
        bool result = String.Equals(name,name2,StringComparison.InvariantCultureIgnoreCase);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void GradeBookVariableholdRefernce()
    {
        GradeBook grade1 = new GradeBook();
        GradeBook grade2 = grade1;
        grade1 = new GradeBook();
        grade1.Name = "Grade Book";
        Assert.AreNotEqual(grade1.Name, grade2.Name);
    }

    [TestMethod]
    public void VariableholdValue()
    {
        int x1 = 100;
        int x2 = x1;
        x1 = 3;
        Assert.AreNotEqual(x1,x2);

    }

    public void ValueTypesPassByValue()
    {
        int x = 46; 
        incrementValue(x);
        Assert.AreEqual(46,x);
    }

    private void incrementValue(int x)
    {
        x = x++;
    }

    [TestMethod]
    public void RefernceTypesPassByValue()
    {
        GradeBook book1 = new GradeBook();
        GradeBook book2 = book1;
        GiveBookName(book2);
        Assert.AreEqual("Shaun's Book", book1.Name);
    }

    private void GiveBookName(GradeBook book)
    {
        book.Name = "Shaun's Book";
    }

}

}
