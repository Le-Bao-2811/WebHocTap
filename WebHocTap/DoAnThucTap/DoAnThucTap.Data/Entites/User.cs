﻿using DoAnThucTap.Data.Entites.Base;
using DoAnThucTap.Share.Const;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.Data.Entites
{
    [Table(NameTable.UserTable)]
    public class User :BaseEntitty
    {
        public User() { 
            purchasedCourses=new HashSet<PurchasedCourse>();
        }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gmail { get; set; }
        public string PhoneNumber { get; set; }
        public int? IdRole { get; set; }
        public Role role { get; set; }
        public ICollection<PurchasedCourse> purchasedCourses { get; set; }
    }
}
