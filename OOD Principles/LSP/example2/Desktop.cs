using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Principles.LSP.example2
{
    internal class Desktop : Computer
    {
        public int RAM { get; set; }
        public double processorSpeed { get; set; }
        public int CasingColor { get; set; }
    }
}
