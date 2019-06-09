using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Win6335.DB6335 {
    [Table(Name = "xslist")]
    class Student6335 {
        public Student6335() {
        }

        [Column(IsPrimaryKey =true, IsDbGenerated = true)]
        public int ID { get; set; }

        [Column(Name = "SNo")]
        public string No { get; set; }

        [Column(Name = "SName")]
        public string Name { get; set; }

        [Column]
        public char? Sex { get; set; }

        [Column]
        public int? Age { get; set; }
    }
}
