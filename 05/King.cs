using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    public class King : IHuman
    {
        public event EventHandler KingAttack;
        public King(string str)
        {
            Name = str;
        }
        public string Name { get; }
        public void Attack()
        {
            Console.WriteLine("King "+Name+" is under attack!");
            KingAttack?.Invoke(this, EventArgs.Empty);
        }
    }
}
