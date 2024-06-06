using HockeyManager.Db;
using HockeyManager.Db.Entities.Roles;

namespace HockerManager.Core.Handlers.Player.GetYoungestPlayerFullName
{
    public class GetYoungestPlayerFullNameHandler
    {
        private readonly IPlayersResouce playersResource;

        public GetYoungestPlayerFullNameHandler(IPlayersResouce _playersResource)
        {
            playersResource = _playersResource;
        }

        public HockeyManager.Db.Entities.Players.Player? Handle()
        {
            return this.playersResource.GetPlayers().OrderBy(p => p.BirthDate).FirstOrDefault();
        }
    }
}
