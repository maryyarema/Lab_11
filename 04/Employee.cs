using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public abstract class Employee
    {
        protected Employee(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public abstract int WorkHoursPerWeek { get; }
    }
}
