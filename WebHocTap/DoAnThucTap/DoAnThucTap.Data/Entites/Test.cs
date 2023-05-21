using DoAnThucTap.Data.Entites.Base;
using DoAnThucTap.Share.Const;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.Data.Entites
{
    [Table(NameTable.TestTable)]
    public class Test:BaseEntitty
    {
        public Test() { 
            answers=new HashSet<Answer>();
        }
        public string Question { get; set; }
        public int? IdLesson { get; set; }
        public Lesson lesson { get; set; }
        public ICollection<Answer>answers { get; set; }
    }
}
