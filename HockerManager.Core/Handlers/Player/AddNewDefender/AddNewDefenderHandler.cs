using HockeyManager.Db;
using HockeyManager.Db.Entities.Roles;

namespace HockerManager.Core.Handlers.Player.AddNewDefender
{
    public class AddNewDefenderHandler
    {
        private readonly IPlayersResouce playersResource;

        public AddNewDefenderHandler(IPlayersResouce _playersResource)
        {
            playersResource = _playersResource;
        }

        public void Handle(AddNewDefenderRequest request)
        {
            this.playersResource.AddPlayer(new HockeyManager.Db.Entities.Players.Player()
            {
                Name = request.Name,
                Surname = request.Surname,
                BirthDate = request.BirthDate,
                Roles = new List<IPlayerRole>() {
                    new DefenderRole() {
                        Hits = request.Hits
                    }
                }
            });
        }
    }
}
