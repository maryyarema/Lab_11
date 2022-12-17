using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name) : base(name)
        {

        }
        public override int WorkHoursPerWeek => 20;
    }
}
