using HockeyManager.Db;
using HockeyManager.Db.Entities.Roles;

namespace HockerManager.Core.Handlers.Player.AddNewGoalie
{
    public class AddNewGoalieHandler
    {
        private readonly IPlayersResouce playersResource;

        public AddNewGoalieHandler(IPlayersResouce _playersResource)
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
                    new GoalieRole() {
                        Wins = request.Wins
                    }
                }
            });
        }
    }
}
