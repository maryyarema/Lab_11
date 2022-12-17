using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            King king = new King(Console.ReadLine());
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
            while (true)
            {
                string[] str=Console.ReadLine().Split(' ');
                if (str[0]=="Attack"&& str[1]=="King")
                {
                    king.Attack();
                }
                else if (str[0]=="Kill")
                {
                    Soldier soldier = soldiers.FirstOrDefault(s => s.Name == str[1]);
                    king.KingAttack -= soldier.OnKingAttack;
                    soldiers.Remove(soldier);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
