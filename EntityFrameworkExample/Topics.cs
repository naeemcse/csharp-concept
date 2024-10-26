using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class Topics
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }
        
        public Course Course { get; set; }
        public int CourseId { get; set; }

    }
}
