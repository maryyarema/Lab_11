using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher(null);
            Handler handler = new Handler();
            dispatcher.NameChange += handler.DispatcherChangeName;
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "End")
                {
                    break;
                }
                else
                {
                    dispatcher.Name = str;
                }
            }
        }
    }
}
