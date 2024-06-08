using System;
using HockeyManager.Db.Entities.Players;
using HockeyManager.Db.Entities.Roles;

namespace HockeyManager.Db
{
    public class PlayersResource : IPlayersResouce
    {
        private List<Player> Players { get; set; }

        public PlayersResource()
        {
            Players = new List<Player>()
            {
                new Player()
                {
                    Name = "Jozef",
                    Surname = "Mrkvicka",
                    BirthDate = new DateTime(1990, 1, 1),
                    Roles = new List<IPlayerRole>()
                    {
                        new ForwardRole() { Goals = 10 },
                        new DefenderRole() { Hits = 20 }
                    }
                },
                new Player()
                {
                    Name = "Peter",
                    Surname = "Hruska",
                    BirthDate = new DateTime(1995, 1, 1),
                    Roles = new List<IPlayerRole>()
                    {
                        new ForwardRole() { Goals = 15 },
                        new GoalieRole() { Wins = 30 }
                    }
                },
            };
        }

        public IEnumerable<Player> GetPlayers()
        {
            return Players;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }
    }
}
