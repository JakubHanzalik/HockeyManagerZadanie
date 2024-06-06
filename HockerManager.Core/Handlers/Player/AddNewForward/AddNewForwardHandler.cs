using HockeyManager.Db;
using HockeyManager.Db.Entities.Roles;

namespace HockerManager.Core.Handlers.Player.AddNewForward
{
    public class AddNewForwardHandler
    {
        private readonly IPlayersResouce playersResource;

        public AddNewForwardHandler(IPlayersResouce _playersResource)
        {
            playersResource = _playersResource;
        }

        public void Handle(AddNewGoalieRequest request)
        {
            this.playersResource.AddPlayer(new HockeyManager.Db.Entities.Players.Player()
            {
                Name = request.Name,
                Surname = request.Surname,
                BirthDate = request.BirthDate,
                Roles = new List<IPlayerRole>() {
                    new ForwardRole() {
                        Goals = request.Goals
                    }
                }
            });
        }
    }
}
