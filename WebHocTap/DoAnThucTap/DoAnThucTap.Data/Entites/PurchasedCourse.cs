using DoAnThucTap.Data.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.Data.Entites
{
    public class PurchasedCourse:BaseEntitty
    {
        public int IdSub { get; set; }
        public int IdUser { get; set; }
        public Subject subject { get; set; }
        public User user { get; set; }
    }
}
