﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.MediatR.Queries
{
    public class GetProductViewModel
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
    }
}
