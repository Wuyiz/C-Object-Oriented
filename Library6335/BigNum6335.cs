﻿using System;
using System.Drawing;
namespace Library6335 {
    public class BigNum6335 {
        private string[] bits = { "分", "角", "元", "拾", "佰", "千", "万", "十万", "佰万", "仟万", "亿" };
        private string[] nums = { "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };

        public Color Color {
            get {
                if (Money < Convert.ToDecimal(0)) {
                    return Color.Red;
                } else {
                    return Color.Blue;
                }
            }
        }
        public decimal Money { get; set; }

        public BigNum6335() {
            Money = Math.Round(Money, 2, MidpointRounding.AwayFromZero);    //四舍五入
        }

        private string getIntString(string intString) {
            char[] chArr = intString.ToCharArray();    //转换成字符数组
            string strUpper = "";   //初始化大写金额
            string strUnit = "";    //初始化金额单位
            intString = ""; //初始化string
            int iTemp = 1;  //位数

            if (chArr.Length == 1 && chArr[0]=='0') {
                return intString;
            }

            while (iTemp <= chArr.Length) {
                switch (chArr[chArr.Length - iTemp]) {
                    case '0':
                        strUpper = nums[0];
                        break;
                    case '1':
                        strUpper = nums[1];
                        break;
                    case '2':
                        strUpper = nums[2];
                        break;
                    case '3':
                        strUpper = nums[3];
                        break;
                    case '4':
                        strUpper = nums[4];
                        break;
                    case '5':
                        strUpper = nums[5];
                        break;
                    case '6':
                        strUpper = nums[6];
                        break;
                    case '7':
                        strUpper = nums[7];
                        break;
                    case '8':
                        strUpper = nums[8];
                        break;
                    case '9':
                        strUpper = nums[9];
                        break;
                }
                switch (iTemp) {
                    case 1:
                        strUnit = bits[iTemp + 1];
                        break;
                    case 2:
                        strUnit = bits[iTemp + 1];
                        break;
                    case 3:
                        strUnit = bits[iTemp + 1];
                        break;
                    case 4:
                        strUnit = bits[iTemp + 1];
                        break;
                    case 5:
                        strUnit = bits[iTemp + 1];
                        break;
                    case 6:
                        strUnit = bits[iTemp + 1];
                        break;
                    case 7:
                        strUnit = bits[iTemp + 1];
                        break;
                    case 8:
                        strUnit = bits[iTemp + 1];
                        break;
                    case 9:
                        strUnit = bits[iTemp + 1];
                        break;
                    default:
                        strUnit = "";
                        break;
                }
                iTemp++;
                intString = strUpper + strUnit + intString;
            }
            return intString;
        }

        private string getDotString(string dotString) {
            char[] chArr = dotString.ToCharArray();    //转化成字符数组
            string strUpper = "";   //初始化大写金额
            string strUnit = "";    //初始化金额单位
            dotString = ""; //初始化string
            int iTemp = 1;  //位数

            while (iTemp <= chArr.Length) {
                switch (chArr[iTemp - 1]) {
                    case '0':
                        strUpper = nums[0];
                        break;
                    case '1':
                        strUpper = nums[1];
                        break;
                    case '2':
                        strUpper = nums[2];
                        break;
                    case '3':
                        strUpper = nums[3];
                        break;
                    case '4':
                        strUpper = nums[4];
                        break;
                    case '5':
                        strUpper = nums[5];
                        break;
                    case '6':
                        strUpper = nums[6];
                        break;
                    case '7':
                        strUpper = nums[7];
                        break;
                    case '8':
                        strUpper = nums[8];
                        break;
                    case '9':
                        strUpper = nums[9];
                        break;
                }
                switch (iTemp) {
                    case 1:
                        strUnit = bits[iTemp];
                        break;
                    case 2:
                        strUnit = bits[iTemp - 2];
                        break;
                    default:
                        strUnit = "";
                        break;
                }
                iTemp++;
                dotString += strUpper + strUnit;
            }
            return dotString;
        }

        public override string ToString() {
            string @int;
            string dot;

            Money = Math.Round(Money, 2, MidpointRounding.AwayFromZero);    //四舍五入
            decimal money = Math.Abs(Money);   //绝对值
            //判断是否存在小数点
            int index = money.ToString().IndexOf(".");
            if (index >= 0) {
                string[] str = money.ToString().Split('.');
                @int = getIntString(str[0]);
                //小数点后不足两位补齐0
                if (str[1].Length == 1) {
                    str[1] += "0";
                    dot = getDotString(str[1]);
                } else {
                    dot = getDotString(str[1]);
                }
            } else {
                @int = getIntString(money.ToString());
                dot = getDotString("00");
            }
            return $"{@int}{dot}";
        }
    }
}