using System;
namespace TrueCoders
{

    public class Teams
    {
        public string TeamName { get; set; }
        public string Members { get; set; }
        public string Location { get; set; }
        public string Colors { get; set; }
        public string Game { get; set; }

        public Teams()
        {
            Game = "CSGO";
        }
    }

}
