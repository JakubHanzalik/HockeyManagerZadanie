using MediatR;

namespace HockerManager.Core.Handlers.Player.GetYoungestPlayerFullNameAndAge
{
    public class GetYoungestPlayerFullNameAndAgeRequest
        : IRequest<GetYoungestPlayerFullNameAndAgeResponse> { }
}
