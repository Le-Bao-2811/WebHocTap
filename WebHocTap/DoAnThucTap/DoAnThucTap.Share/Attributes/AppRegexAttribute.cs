﻿using DoAnThucTap.Share.Const;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.Share.Attributes
{
    public class AppRegexAttribute : RegularExpressionAttribute
    {
        public AppRegexAttribute(string pattern) : base(pattern)
        {
            ErrorMessage = AttributeErrMesg.REGEX;
        }
    }
}
