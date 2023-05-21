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
    [Table(NameTable.RolePermissionTable)]
    public class RolePermission : BaseEntitty
    {
        public int RoleId { get; set; }
        public int MStPermissionId { get; set; }
        public Role role { get; set; }
        public MstPerMission mstPerMission { get; set; }
    }
}
