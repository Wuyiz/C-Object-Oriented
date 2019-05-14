using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library6335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library6335.Tests {
    [TestClass()]
    public class ComplexNumber6335Tests {
        ComplexNumber6335 c = new ComplexNumber6335();
        [TestMethod()]
        public void ParseTest() {
            TestCase[] datas = new TestCase[]
            {
                new TestCase(" i  ",0,1),
                new TestCase(" - i",0,-1),
                new TestCase(" + i",0,1),
                new TestCase(" +8.5 i",0,8.5),
                new TestCase("02+ i  ",2,1),
                new TestCase("2 - i",2,-1),
                new TestCase(" -02- i",-2,-1),
                new TestCase(" -2+ i",-2,1),
                new TestCase("2 +3i",2,3),
                new TestCase("2-3 i",2,-3),
                new TestCase("- 2-3 i",-2,-3),
                new TestCase("- .2-3 i",-0.2,-3),
                new TestCase("- 2-.3 i",-2,-0.3),
                new TestCase("-1. 2-2.3 i",-1.2,-2.3),
                new TestCase("+2.5+8.3 i",2.5,8.3),
            };
            foreach (TestCase data in datas) {
                ComplexNumber6335 expected = ComplexNumber6335.Parse(data.Input);
                Assert.AreEqual(new ComplexNumber6335(data.A, data.B), expected);
            }
        }
        [TestMethod()]
        //[ExpectedException(typeof(FormatException))]
        public void ParseTest1() {
            string[] datas = new string[]
            {
                " 2 ",
               "3+0i",
                "+-i",
                "-2-2+i",
                "1.230.8i",
                "4i+8",
                "6+5ii",
                "..2i",
                "..2+3i",
                "a+3i",
                "a+bi"
            };
            int n = 0;
            foreach (string input in datas) {
                try {
                    ComplexNumber6335 expected = ComplexNumber6335.Parse(input);
                }
                catch (FormatException) {
                    n++;
                }
            }
            Assert.AreEqual(datas.Length, n);
        }






        [TestMethod()]

        public void TryParseTest() {
        }

        [TestMethod()]
        public void ToStringTest() {
            TestCase[] datas = new TestCase[]
{
                new TestCase("i",0,1),
                new TestCase("-i",0,-1),
                new TestCase("8.5i",0,8.5),
                new TestCase("2+i",2,1),
                new TestCase("-2.6-i",-2.6,-1),
                new TestCase("2.5+8.3i",2.5,8.3),
};
            foreach (TestCase data in datas) {

                Assert.AreEqual(data.Input, new ComplexNumber6335(data.A, data.B).ToString());
            }
        }
        struct TestCase {
            public double A { get; set; }
            public double B { get; set; }
            public string Input { get; set; }
            public TestCase(string input, double a, double b) {
                Input = input;
                A = a;
                B = b;
            }
        }
    }

}