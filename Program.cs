using System;
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
                Console.WriteLine($"{player.Name} is the #{player.Rank} player " +
                    $"in the world that plays for {player.Team} and has earned " +
                    $"${player.Winnings}k in his career.");
                Console.WriteLine("press return to continue...");
                Console.ReadLine();
            }

            Teams navi = new Teams();
            navi.TeamName = "NaVi";
            navi.Members = "s1mple, electronic, flamie, Guardian, boombl4";
            navi.Colors = "Yellow and Black";
            navi.Location = "CIS";            

            Teams mibr = new Teams();
            mibr.TeamName = "MiBR";
            mibr.Members = "Fallen, Fer, Taco, kngV, Lucas1";
            mibr.Colors = "Blue and Silver";
            mibr.Location = "North America/Brazil";

            Teams astralis = new Teams();
            astralis.TeamName = "Astralis";
            astralis.Members = "dev1ce, dupreeh, gla1ve, xyp9x, magisk";
            astralis.Colors = "Red and Black";
            astralis.Location = "EU/Denmark";

            Teams liquid = new Teams();
            liquid.TeamName = "Team Liquid";
            liquid.Members = "stewie2k, nitro, twistzz, elige, Naffly";
            liquid.Colors = "Blue and White";
            liquid.Location = "North America";

            var teamList = new List<Teams>();
            teamList.Add(navi);
            teamList.Add(mibr);
            teamList.Add(astralis);
            teamList.Add(liquid);

            foreach (Teams team in teamList)
            {
                Console.WriteLine($"{team.TeamName} has been invited to ESL Birmingham. " +
                    $"We all look forward to seeing {team.Members} compete at the higest " +
                    $"level in their class {team.Colors}. We have spoken to them and " +
                    $"they are all hoping to make {team.Location} proud! GO {team.TeamName}!");
                Console.WriteLine("press return to continue...");
                Console.ReadLine();
            }
        }
    }
}
