using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class Job
    {
        public event EventHandler JobFinished;
        private Employee employee;
        public Job(string[] strarray, Employee employee)
        {
            this.employee = employee;
            Name = strarray[1];
            HoursRemaining = Convert.ToInt32(strarray[2]);
        }
        public string Name { get; }
        public int HoursRemaining { get; private set; }
        public void Update()
        {
            HoursRemaining -= employee.WorkHoursPerWeek;
            if (HoursRemaining <= 0)
            {
                Console.WriteLine("Job "+Name+" done!");
                JobFinished(this, new EventArgs());
            }
        }
    }
}
