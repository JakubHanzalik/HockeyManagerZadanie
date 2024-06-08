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
