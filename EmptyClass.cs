using System;
namespace TrueCoders
{
    public class Gamers
    {
        public string Name { get; set; }
        public decimal Winnings { get; set; }
        public string Team { get; set; }
        public int Rank { get; set; }

        public Gamers(string nickname, decimal winnings, string team, int rank)
        {
            Name = nickname;
            Winnings = winnings;
            Team = team;
            Rank = rank;
        }
    }

    public class Teams
    {
        public string TeamName { get; set; }
        public string Members { get; set; }
        public string Location { get; set; }
        public string Colors { get; set; }
    }

    public class Casters
    {
        public string CasterName { get; set; }

        public Casters(string castname)
        {
            CasterName = castname;
        }
    }
}
