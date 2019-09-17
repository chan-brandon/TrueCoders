using System;
using System.Linq;
using System.Collections.Generic;

namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamers simple = new Gamers("s1mple", 510, "NaVi", 1);
            Gamers fallen = new Gamers("Fallen", 957, "MiBR", 6);
            Gamers device = new Gamers("dev1ce", 1500, "Astralis", 3);
            Gamers zywoo = new Gamers("ZywOo", 157, "Vitality", 2);
            Gamers coldzera = new Gamers("coldzera", 924, "FaZe Clan", 4);
            Gamers niko = new Gamers("NiKo", 657, "FaZe Clan", 5);

            var playerList = new List<Gamers>();
            playerList.Add(simple);
            playerList.Add(zywoo);
            playerList.Add(device);
            playerList.Add(coldzera);
            playerList.Add(niko);
            playerList.Add(fallen);

            foreach (Gamers player in playerList)
            {
                Console.WriteLine($"{player.Name} is the #{player.Rank} player in the world that plays for {player.Team} and has earned ${player.Winnings}k in his career.");
            }
        }
    }
}
