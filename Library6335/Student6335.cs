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
    /// <summary>
    /// Implement interface IComparable<Student>
    /// </summary>
    public class Student6335 : IComparable<Student6335> {
        public string Name { get; set; } //学生姓名

        public string ID { get; set; } //学号

        public int Score { get; set; } //入学成绩

        public string Source { get; set; } //生源地

        /// <summary>
        /// Custom compareTo method
        /// Achieve comparison by student number
        /// </summary>
        /// <param name="other">Accept the incoming Student6335 object</param>
        /// <returns>Return the size of the comparison</returns>
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
