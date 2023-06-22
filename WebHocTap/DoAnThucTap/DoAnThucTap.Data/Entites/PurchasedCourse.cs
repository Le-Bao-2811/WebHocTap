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
    [Table(NameTable.PurchasedCourseTable)]
    public class PurchasedCourse:BaseEntitty
    {
        public int IdSub { get; set; }
        public int IdUser { get; set; }
        public int? Price { get; set; }
        public CategorySub subject { get; set; }
        public User user { get; set; }
    }
}
