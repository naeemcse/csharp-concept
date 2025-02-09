using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Principles.LSP.example2
{
    internal class Laptop : Computer
    {
        public int RAM { get; set; }
        public double processorSpeed { get; set; }
        string monitorSize {  get; set; }
    }
}
