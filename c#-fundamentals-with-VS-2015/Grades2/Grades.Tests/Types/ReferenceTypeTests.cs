using Grades2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNubmer(x);
            Assert.AreEqual(x, 46);
        }

        private void IncrementNubmer(int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            GiveBookAName(book2);
            Assert.AreEqual(book1.Name, "A book");
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A book";
            //DateTime.UtcNow.ToString();
        }

        [TestMethod]
        public void StringComparison()
        {
            string name1 = "Scott";
            string name2 = "scott";
            bool result = String.Equals(name1, name2, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void VariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "g1name";
            Assert.AreEqual(g2.Name, "g1name");
        }

        [TestMethod]
        public void NamesAreEqual()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "g1name";
            Assert.AreEqual(g2.Name, g1.Name);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 4;
            Assert.AreNotEqual(x1, x2);
           
        }

    }
}
