using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];
            AddGrades(grades);
            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "scott";
            name.ToUpper();
            Assert.AreNotEqual("SCOTT", name);

        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);
            Assert.AreEqual(date.Day, 2);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number++;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            GiveBookAName(book2);
            Assert.AreEqual(book1.Name, book2.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A Gradebook";
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradebookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1 = new GradeBook();
            g1.Name = "First Grade Book";
            Assert.AreEqual(g1.Name, "First Grade Book");

        }

        [TestMethod]
        public void StringComparison()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = String.Equals(name1, name2,System.StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);

        }
    }
}
