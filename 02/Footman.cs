using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Footman : Soldier
    {
        public Footman(string name) : base(name)
        {
        }
        public override void OnKingAttack(object source, EventArgs args)
        {
            Console.WriteLine("Footman "+Name+" is panicking!");
        }
    }
}
