using MediatR;

namespace HockerManager.Core.Handlers.Player.AddNewDefender
{
    public class AddNewDefenderRequest : IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int Hits { get; set; }
    }
}
