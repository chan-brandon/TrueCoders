using System;
namespace TrueCoders
{
    public class Gamers : Teams
    {
        public string Name { get; set; }
        public decimal Winnings { get; set; }
        public int Rank { get; set; }

        public Gamers(string nickname, decimal winnings, string team, int rank, string location, string colors)
        {
            Name = nickname;
            Winnings = winnings;
            TeamName = team;
            Rank = rank;
            Location = location;
            Colors = colors;
        }
    }
}
