﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class IdGenerator
    {
      public string IdGen()
        {
            return new Random(DateTime.Now.Millisecond).Next(300, 999).ToString();
        }

    }
}
