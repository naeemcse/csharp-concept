﻿using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Repository
{
    public interface IRepository<T,G> where T : IEntity<G>
    {

    }
}
