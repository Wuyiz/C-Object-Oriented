using System;
using System.Drawing;
using Library6335;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Library6335Tests {
    
    [TestClass]
    public class BigNum6335Tests {
        BigNum6335 bigNum = new BigNum6335();
        [TestMethod]
        public void ToStringTest1() {
            decimal input = 23.12m;
            string expectedResult = "贰拾叁元壹角贰分";
            Color expectedColor = Color.Blue;
            bigNum.Money = input;
            Assert.AreEqual(expectedResult, bigNum.ToString());
            Assert.AreEqual(expectedColor, bigNum.Color);
        }
        [TestMethod]
        public void ToStringTest2() {
            decimal input =- 0.25m;
            string expectedResult = "贰角伍分";
            Color expectedColor = Color.Red;
            bigNum.Money = input;
            Assert.AreEqual(expectedResult, bigNum.ToString());
            Assert.AreEqual(expectedColor, bigNum.Color);
        }
        [TestMethod]
        public void ToStringTest3() {
            decimal input = 1000000;
            string expectedResult = "壹佰万零十万零万零千零佰零拾零元零角零分";
            Color expectedColor = Color.Blue;
            bigNum.Money = input;
            Assert.AreEqual(expectedResult, bigNum.ToString());
            Assert.AreEqual(expectedColor, bigNum.Color);
        }
        [TestMethod]
        public void ToStringTest4() {
            decimal input = decimal.Parse("251200.");
            string expectedResult = "贰十万伍万壹千贰佰零拾零元零角零分";
            Color expectedColor = Color.Blue;
            bigNum.Money = input;
            Assert.AreEqual(expectedResult, bigNum.ToString());
            Assert.AreEqual(expectedColor, bigNum.Color);
        }
        [TestMethod]
        public void ToStringTest5() {
            decimal input = -12002.125m;
            string expectedResult = "壹万贰千零佰零拾贰元壹角叁分";
            Color expectedColor = Color.Red;
            bigNum.Money = input;
            Assert.AreEqual(expectedResult, bigNum.ToString());
            Assert.AreEqual(expectedColor, bigNum.Color);
        }
        [TestMethod]
        public void ToStringTest6() {
            decimal input = -112000.1m;
            string expectedResult = "壹十万壹万贰千零佰零拾零元壹角零分";
            Color expectedColor = Color.Red;
            bigNum.Money = input;
            Assert.AreEqual(expectedResult, bigNum.ToString());
            Assert.AreEqual(expectedColor, bigNum.Color);
        }
    }
}
