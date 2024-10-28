using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class StudentEnrollment
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Course Courses { get; set; }
        public Student Student { get; set; }
    }
}
