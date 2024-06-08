using HockeyManager.Db;
using HockeyManager.Db.Entities.Roles;
using MediatR;

namespace HockerManager.Core.Handlers.Player.AddNewGoalie
{
    public class AddNewGoalieHandler : IRequestHandler<AddNewGoalieRequest>
    {
        private readonly IPlayersResouce playersResource;

        public AddNewGoalieHandler(IPlayersResouce _playersResource)
        {
            playersResource = _playersResource;
        }

        public async Task Handle(AddNewGoalieRequest request, CancellationToken cancellationToken)
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

            await Task.CompletedTask;
        }
    }
}
