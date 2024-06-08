using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HockeyManager.Db.Entities.Players;

namespace HockeyManager.Db
{
    public interface IPlayersResouce
    {
        public IEnumerable<Player> GetPlayers();
        public void AddPlayer(Player player);
        public void RemovePlayer(Player player);
    }
}
