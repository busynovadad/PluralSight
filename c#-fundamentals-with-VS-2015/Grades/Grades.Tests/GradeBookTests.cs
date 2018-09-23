using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHigestGrade()
        {
            GradeBook testbook = new GradeBook();
            testbook.AddGrade(10);
            testbook.AddGrade(90);
            GradeStatistics result = testbook.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook testbook = new GradeBook();
            testbook.AddGrade(10);
            testbook.AddGrade(90);
            GradeStatistics result = testbook.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }
    }
}
