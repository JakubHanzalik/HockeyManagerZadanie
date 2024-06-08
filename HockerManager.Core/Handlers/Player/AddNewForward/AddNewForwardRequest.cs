using MediatR;

namespace HockerManager.Core.Handlers.Player.AddNewForward
{
    public class AddNewForwardRequest : IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int Goals { get; set; }
    }
}
