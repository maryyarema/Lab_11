using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _04
{
    internal class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            List<Job> jobs = new List<Job>();
            while (true)
            {
                var strarray =Console.ReadLine().Split(' ');
                if (strarray[0] == "Job")
                {
                    Employee employee = employees.FirstOrDefault(e => e.Name == strarray[3]);
                    Job job = new Job(strarray, employee);
                    job.JobFinished += (obj, args) => jobs.Remove((Job)obj);
                    jobs.Add(job);
                }else if(strarray[0] == "StandardEmployee")
                {
                    employees.Add(new StandardEmployee(strarray[1]));
                }else if (strarray[0] == "PartTimeEmployee")
                {
                    employees.Add(new PartTimeEmployee(strarray[1]));
                }else if (strarray[0] == "Pass")
                {
                    foreach (var job in jobs.ToArray())
                    {
                        job.Update();
                    }
                }else if (strarray[0] == "Status")
                {
                    foreach (var job in jobs)
                    {
                        Console.WriteLine("Job: "+job.Name+" Hours Remaining:"+ job.HoursRemaining);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
