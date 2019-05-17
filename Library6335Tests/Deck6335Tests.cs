using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library6335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library6335.Tests {
    [TestClass()]
    public class Deck6335Tests {
        [TestMethod()]
        public void ShuffleDeck6335Test() {
            string[] expected = new string[] {
                "♥A","♥2","♥3","♥4","♥5","♥6","♥7","♥8","♥9","♥10","♥J","♥Q","♥K",
                "♠A","♠2","♠3","♠4","♠5","♠6","♠7","♠8","♠9","♠10","♠J","♠Q","♠K",
                "♦A","♦2","♦3","♦4","♦5","♦6","♦7","♦8","♦9","♦10","♦J","♦Q","♦K",
                "♣A","♣2","♣3","♣4","♣5","♣6","♣7","♣8","♣9","♣10","♣J","♣Q","♣K"
            };
            Deck6335 deck = new Deck6335();
            //调用洗牌方法，得到一副牌（52张牌的顺序是随机的）
            deck.ShuffleDeck6335();
            string[] result = deck.ToString().Split(' ');
            //对数组进行排序
            Array.Sort(expected);
            Array.Sort(result);
            //对比两个数组
            Assert.AreEqual(true, Enumerable.SequenceEqual(expected, result));
        }
    }
}