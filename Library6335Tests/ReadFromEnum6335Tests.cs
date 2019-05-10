using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library6335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library6335.Tests {
    [TestClass()]
    public class ReadFromEnum6335Tests {
        [TestMethod()]
        public void AllInformation6335Test1() {
            string[] expectedResult = new string[]
            {
                "6,Common",
                "7,Student",
                "8,Child",
                "9,Old"

            };
            string input = "CustomerType6335";
            Assert.AreEqual(true, Enumerable.SequenceEqual(expectedResult, ReadFromEnum6335.AllInformation6335(input)));
        }
        [TestMethod()]
        public void AllInformation6335Test2() {
            string[] expectedResult = new string[]
            {
                "1,高中",
                "2,中专",
                "11,大专",
                "12,本科",
                "13,硕士",
                "14,博士"
            };
            string input = "Degree6335";
            Assert.AreEqual(true, Enumerable.SequenceEqual(expectedResult, ReadFromEnum6335.AllInformation6335(input)));
        }
    }
}