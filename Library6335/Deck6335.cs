/*
                   _ooOoo_
                  o8888888o
                  88" . "88
                  (| -_- |)
                  O\  =  /O
               ____/`---'\____
             .'  \\|     |//  `.
            /  \\|||  :  |||//  \
           /  _||||| -:- |||||-  \
           |   | \\\  -  /// |   |
           | \_|  ''\---/''  |   |
           \  .-\__  `-`  ___/-. /
         ___`. .'  /--.--\  `. . __
      ."" '<  `.___\_<|>_/___.'  >'"".
     | | :  `- \`.;`\ _ /`;.`/ - ` : | |
     \  \ `-.   \_ __\ /__ _/   .-` /  /
======`-.____`-.___\_____/___.-`____.-'======
                   `=---='
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            佛祖保佑       永无BUG
*/
using System;
using System.Collections.Generic;

namespace Library6335 {
    public class Deck6335 {
        private List<Card6335> cards = new List<Card6335>();

        public void ShuffleDeck6335() {
            Card6335 card;
            Suits6335 suit;
            Values6335 value;
            Random r = new Random();

            for (int i = 0; i < 52; i++) {
                suit = (Suits6335)r.Next(4);
                value = (Values6335)r.Next(13);
                card = new Card6335(suit, value);

                if (!cards.Contains(card)) {
                    cards.Add(card);
                } else {
                    i--;
                }
            }
        }

        public override string ToString() {
            string result = "";
            foreach (var item in cards) {
                result += item + " ";
            }

            return result.TrimEnd();
        }
    }
}