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
    [Table(NameTable.LessonTable)]
    public class Lesson :BaseEntitty
    {
        public Lesson() { 
            tests=new HashSet<Test>();
            comemts=new HashSet<Comemt>();
        }
        public string Content { get; set; }
        public string? Video { get; set; }
        public int? IdChapter { get; set; }
        public Chapter chapter { get; set; }
        public ICollection<Test> tests { get; set; }
        public ICollection<Comemt> comemts { get; set; }
    }
}
