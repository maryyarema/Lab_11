using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string name) : base(name, 3)
        {
        }
        public override void OnKingAttack(object source, EventArgs args)
        {
            Console.WriteLine("Royal Guard "+Name+" is defending!");
        }
    }
}
