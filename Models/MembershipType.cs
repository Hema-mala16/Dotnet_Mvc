﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieCustomerMvcApp.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public short SignUpFree { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}