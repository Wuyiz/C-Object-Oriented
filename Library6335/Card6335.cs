/*
   　　　┏┓　　　┏┓
   　　┏┛┻━━━┛┻┓
   　　┃　　　　　　　 ┃
   　　┃　　　━　　　 ┃
   　　┃　┳┛　┗┳　┃
   　　┃　　　　　　　 ┃
   　　┃　　　┻　　　 ┃
   　　┃　　　　　　　 ┃
   　　┗━┓　　　┏━┛Codes are far away from bugs with the animal protecting
   　　　　┃　　　┃    神兽保佑,代码无bug
   　　　　┃　　　┃
   　　　　┃　　　┗━━━┓
   　　　　┃　　　　　 ┣┓
   　　　　┃　　　　 ┏┛
   　　　　┗┓┓┏━┳┓┏┛
   　　　　　┃┫┫　┃┫┫
   　　　　　┗┻┛　┗┻┛
*/

public enum Suits6335 {
    红桃,
    黑桃,
    方块,
    梅花
}

public enum Values6335 {
    PA,
    P2,
    P3,
    P4,
    P5,
    P6,
    P7,
    P8,
    P9,
    P10,
    PJ,
    PQ,
    PK
}

public struct Card6335 {
    private string[] names;

    /// <summary>
    /// Initializes a new instance of the <see cref="Card6335"/> struct.
    /// 结构体中定义有参构造函数，必须对所有字段赋初值
    /// </summary>
    /// <param name="suit">牌型</param>
    /// <param name="value">牌值</param>
    public Card6335(Suits6335 suit, Values6335 value) {
        Suit = suit;
        Value = value;
        names = new string[] {
        "♥A", "♥2", "♥3", "♥4", "♥5", "♥6", "♥7", "♥8", "♥9", "♥10", "♥J", "♥Q", "♥K",
        "♠A", "♠2", "♠3", "♠4", "♠5", "♠6", "♠7", "♠8", "♠9", "♠10", "♠J", "♠Q", "♠K",
        "♦A", "♦2", "♦3", "♦4", "♦5", "♦6", "♦7", "♦8", "♦9", "♦10", "♦J", "♦Q", "♦K",
        "♣A", "♣2", "♣3", "♣4", "♣5", "♣6", "♣7", "♣8", "♣9", "♣10", "♣J", "♣Q", "♣K"
        };
    }

    public Suits6335 Suit { get; set; }

    public Values6335 Value { get; set; }

    public override string ToString() {
        return names[((int)Suit * 13) + (int)Value];
    }

    public override bool Equals(object obj) {
        if (obj == null) {
            return false;
        }

        if (obj is Card6335) {
            Card6335 card = (Card6335)obj;
            return card.Suit == Suit && card.Value == Value;
        }

        return false;
    }
}
