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
    [Table(NameTable.RoleTable)]
    public class Role:BaseEntitty
    {
        public Role()
        {
            Users = new HashSet<User>();
            rolePermissions = new HashSet<RolePermission>();
        }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<RolePermission> rolePermissions { get; set; }
    }
}
