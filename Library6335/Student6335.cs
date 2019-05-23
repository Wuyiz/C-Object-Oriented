/*
                        d*##$.
   zP"""""$e.           $"    $o
  4$       '$          $"      $
  '$        '$        J$       $F
   'b        $k       $>       $
    $k        $r     J$       d$
    '$         $     $"       $~
     '$        "$   '$E       $
      $         $L   $"      $F ...
       $.       4B   $      $$$*"""*b
       '$        $.  $$     $$      $F
        "$       R$  $F     $"      $
         $k      ?$ u*     dF      .$
         ^$.      $$"     z$      u$$$$e
          #$b             $E.dW@e$"    ?$
           #$           .o$$# d$$$$c    ?F
            $      .d$$#" . zo$>   #$r .uF
            $L .u$*"      $&$$$k   .$$d$$F
             $$"            ""^"$$$P"$P9$
            JP              .o$$$$u:$P $$
            $          ..ue$"      ""  $"
           d$          $F              $
           $$     ....udE             4B
            #$    """"` $r            @$
             ^$L        '$            $F
               RN        4N           $
                *$b                  d$
                 $$k                 $F
                 $$b                $F
                   $""               $F
                   '$                $
                    $L               $
                    '$               $
                     $               $
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library6335 {
    public class Student6335 : IComparable<Student6335> {
        public string Name { get; set; } //学生姓名

        public string ID { get; set; } //学号

        public int Score { get; set; } //入学成绩

        public string Source { get; set; } //生源地

        //定义与委托Comparison<T>兼容的方法
        public static int SortByName(Student6335 x, Student6335 y) {
            return string.Compare(x.Name, y.Name);
        }

        //定义与委托匹配的方法作为FindAll方法的参数
        public static bool FindByName6335(Student6335 stu) {
            return stu.Name.StartsWith("李");
        }

        public int CompareTo(Student6335 other) {
            if (other == null) {
                return -1;
            }

            return Convert.ToInt32(ID) - Convert.ToInt32(other.ID);
        }

        public override string ToString() {
            return $"ID={Name} \t{ID}\t{Score}\t{Source}";
        }
    }
}
