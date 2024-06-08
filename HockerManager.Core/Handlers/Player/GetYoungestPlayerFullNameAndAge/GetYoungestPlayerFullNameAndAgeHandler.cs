using HockeyManager.Db;
using MediatR;

namespace HockerManager.Core.Handlers.Player.GetYoungestPlayerFullNameAndAge
{
    public class GetYoungestPlayerFullNameAndAgeHandler : IRequestHandler<GetYoungestPlayerFullNameAndAgeRequest, GetYoungestPlayerFullNameAndAgeResponse?>
    {
        private readonly IPlayersResouce playersResource;

        public GetYoungestPlayerFullNameAndAgeHandler(IPlayersResouce _playersResource)
        {
            playersResource = _playersResource;
        }

        public async Task<GetYoungestPlayerFullNameAndAgeResponse?> Handle(GetYoungestPlayerFullNameAndAgeRequest request, CancellationToken cancellationToken)
        {
            var youngestPlayer = this.playersResource.GetPlayers().OrderByDescending(p => p.BirthDate).FirstOrDefault();

            if (youngestPlayer is null) 
                return await Task.FromResult<GetYoungestPlayerFullNameAndAgeResponse?>(null);

            return await Task.FromResult<GetYoungestPlayerFullNameAndAgeResponse?>(
                new GetYoungestPlayerFullNameAndAgeResponse()
                {
                    Name = youngestPlayer.Name,
                    Surname = youngestPlayer.Surname,
                    Age = DateTime.Now.Year - youngestPlayer.BirthDate.Year
                });
                
        }
    }
}
