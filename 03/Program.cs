using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            while (true)
            {
                string[] str=Console.ReadLine().Split(' ');
                if (str[0] == "mode")
                {
                    calculator.ChangeStrategy(str[1]);
                }
                else if(str.Length == 2)
                {
                    Console.WriteLine(calculator.Calculation(int.Parse(str[0]), int.Parse(str[1])));
                }
                else
                {
                    break;
                }
            }
        }
    }
}
