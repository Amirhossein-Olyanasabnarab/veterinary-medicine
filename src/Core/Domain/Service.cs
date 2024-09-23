﻿using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Service : BaseEntity
    {
        public ServiceType  Type { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
