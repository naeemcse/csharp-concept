﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Entities
{
    public class Author : IEntity<Guid>
    {
        public Guid Id { get;set; }
        
    }
}
