using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Principles.LSP
{
    internal class Square : Shape
    {
        public int side { get; set; }
        public override int GetArea()
        {
            return side*side;
        }
    }
}
