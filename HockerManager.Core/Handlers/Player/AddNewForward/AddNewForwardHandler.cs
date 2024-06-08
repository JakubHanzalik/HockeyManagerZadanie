using HockerManager.Core.Handlers.Player.AddNewDefender;
using HockeyManager.Db;
using HockeyManager.Db.Entities.Roles;
using MediatR;

namespace HockerManager.Core.Handlers.Player.AddNewForward
{
    public class AddNewForwardHandler : IRequestHandler<AddNewForwardRequest>
    {
        private readonly IPlayersResouce playersResource;

        public AddNewForwardHandler(IPlayersResouce _playersResource)
        {
            playersResource = _playersResource;
        }

        public async Task Handle(AddNewForwardRequest request, CancellationToken cancellationToken)
        {
            this.playersResource.AddPlayer(
                new HockeyManager.Db.Entities.Players.Player()
                {
                    Name = request.Name,
                    Surname = request.Surname,
                    BirthDate = request.BirthDate,
                    Roles = new List<IPlayerRole>() { new ForwardRole() { Goals = request.Goals } }
                }
            );

            await Task.CompletedTask;
        }
    }
}
