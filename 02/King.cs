using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class King : IHuman
    {
        public event EventHandler KingAttack;
        public King(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public void Attack()
        {
            Console.WriteLine("King "+Name+" is under attack!");
            KingAttack?.Invoke(this, EventArgs.Empty);
        }
    }
}
