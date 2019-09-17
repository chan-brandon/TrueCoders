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
}
