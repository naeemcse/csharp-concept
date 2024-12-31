using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Person(string name,int age,int salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;

        }

    }
}
