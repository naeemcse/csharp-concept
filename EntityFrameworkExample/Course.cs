using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Fees { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }

        public List<Topics> Topics { get; set; }



    }
}
