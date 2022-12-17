using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public abstract class Soldier : IHuman
    {
        protected Soldier(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public abstract void OnKingAttack(object source, EventArgs args);
    }
}
