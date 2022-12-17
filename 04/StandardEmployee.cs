using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class StandardEmployee : Employee
    {
        public StandardEmployee(string name) : base(name)
        {

        }
        public override int WorkHoursPerWeek => 40;
    }
}
