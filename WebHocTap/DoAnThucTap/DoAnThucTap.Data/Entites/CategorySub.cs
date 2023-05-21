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
    [Table(NameTable.CategorySubTable)]
    public class CategorySub:BaseEntitty
    {
        public CategorySub() { 
            subjects=new HashSet<Subject>();
        }
        public string NameCategorySub { get; set; }
        public bool isPayment { get; set; }
        public string pathImg { get; set; }
        public ICollection<Subject> subjects { get; set; }
    }
}
