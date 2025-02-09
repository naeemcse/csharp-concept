using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Principles.ISP
{
    internal class Human : IWorkable, IEatable
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
