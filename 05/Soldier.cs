using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    public abstract class Soldier : IHuman
    {
        public event EventHandler SoldierDeath;
        protected Soldier(string name, int health)
        {
            Name = name;
            Health = health;
        }
        public int Health { get; private set; }
        public string Name { get; }
        public abstract void OnKingAttack(object source, EventArgs args);
        public void TakeDamage()
        {
            if (--Health == 0)
            {
                SoldierDeath(this, new EventArgs());
            }
        }
    }
}
