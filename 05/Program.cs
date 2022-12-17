using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _05
{
    internal class Program
    {
        public static void Main()
        {
            string str=Console.ReadLine();
            King king = new King(str);
            List<Soldier> soldiers = new List<Soldier>();
            string[] strarray = Console.ReadLine().Split(' ');
            for (int i = 0; i < strarray.Length; i++)
            {
                RoyalGuard guard = new RoyalGuard(strarray[i]);
                king.KingAttack += guard.OnKingAttack;
                soldiers.Add(guard);
            }
            strarray = Console.ReadLine().Split(' ');
            for (int i = 0; i < strarray.Length; i++)
            {
                Footman footman = new Footman(strarray[i]);
                king.KingAttack += footman.OnKingAttack;
                soldiers.Add(footman);
            }
            foreach (var soldier in soldiers)
            {
                soldier.SoldierDeath += (obj, args) =>
                {
                    Soldier killed = (Soldier)obj;
                    king.KingAttack -= killed.OnKingAttack;
                    soldiers.Remove(killed);
                };
            }
            while (true)
            {
                string[] array = Console.ReadLine().Split(' ');
                if (array[0] == "Attack")
                {
                    king.Attack();
                }
                else if (array[0]=="Kill")
                {
                    Soldier soldier = soldiers.FirstOrDefault(s => s.Name == array[1]);
                    soldier.TakeDamage();
                }
                else
                {
                    break;
                }
            }

        }
    }
}
