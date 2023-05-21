﻿using DoAnThucTap.Share.Const;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.Share.Attributes
{
    public class AppRequiredAttribute : RequiredAttribute
    {
        public AppRequiredAttribute() : base()
        {
            ErrorMessage = AttributeErrMesg.REQUIRED;
        }
    }
}
