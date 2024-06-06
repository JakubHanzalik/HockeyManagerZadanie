using HockeyManager.Db.Entities.Roles;

namespace HockeyManager.Db.Entities.Players
{
    public class Player
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public IEnumerable<IPlayerRole> Roles { get; set; }
    }
}
