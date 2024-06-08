using HockeyManager.Db;
using HockeyManager.Db.Entities.Roles;
using MediatR;
using System.Net.NetworkInformation;

namespace HockerManager.Core.Handlers.Player.AddNewDefender
{
    public class AddNewDefenderHandler : IRequestHandler<AddNewDefenderRequest>
    {
        private readonly IPlayersResouce playersResource;

        public AddNewDefenderHandler(IPlayersResouce _playersResource)
        {
            playersResource = _playersResource;
        }

        public async Task Handle(AddNewDefenderRequest request, CancellationToken cancellationToken)
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

            await Task.CompletedTask;
        }
    }
}
