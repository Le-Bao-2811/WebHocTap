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
    [Table(NameTable.SubjectTable)]
    public class Subject:BaseEntitty
    {
        public Subject() { 
            chapters=new HashSet<Chapter>();
            purchasedCourses=new HashSet<PurchasedCourse>();
        }
        public string NameSubject { get; set; }
        public int? IdCategorySub { get; set; }
        public CategorySub categorySub { get; set; }
        public ICollection<Chapter> chapters { get; set; }
        public ICollection<PurchasedCourse> purchasedCourses { get; set; }
    }
}
