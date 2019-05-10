using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Library6335 {
    public class ReadFromEnum6335 {
        public static IEnumerable<string> AllInformation6335(string input) {
            Type type = Type.GetType("Library6335." + input);   //type的静态方法 全部名称

            string enum_str = "";   //存储枚举类型

            //遍历枚举类型的常数值
            foreach (var item in Enum.GetValues(type)) {
                enum_str += (int)item + "," + item + " ";   //按照“常数值，常数名称”存储枚举
            }

            string[] enum_arr = enum_str.Split(' ');    //通过空格切割字符串并返回新数组

            return enum_arr.Where(s => !string.IsNullOrEmpty(s)).ToArray(); //使用lambda表达式过滤空字符串数组
            throw new NotImplementedException();
        }
    }
}