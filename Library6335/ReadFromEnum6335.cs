using System;
using System.Collections.Generic;
using System.Linq;

namespace Library6335 {
    public class ReadFromEnum6335 {
        public static IEnumerable<string> AllInformation6335(string input) {
            Type type = Type.GetType("Library6335." + input);   //type的静态方法 全部名称

            List<string> enum_arr = new List<string>();   //存储枚举类型

            //遍历枚举类型的常数值
            foreach (var item in Enum.GetValues(type)) {
                enum_arr.Add((int)item + "," + item);   //按照“常数值，常数名称”存储枚举
            }

            return enum_arr;
            throw new NotImplementedException();
        }
    }
}