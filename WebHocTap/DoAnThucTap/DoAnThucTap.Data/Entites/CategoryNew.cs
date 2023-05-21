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
    [Table(NameTable.CategoryNewTable)]
    public class CategoryNew :BaseEntitty
    {
        public CategoryNew() { 
            news=new HashSet<News>();
        }
        public string NameCategoryNew { get; set; }
        public ICollection<News> news { get; set; }
    }
}
