namespace HockeyManager.Db.Entities.Roles
{
    public class GoalieRole : IPlayerRole
    {
        public int Wins { get; set; }
        public EPlayerRole GetEPlayerRole()
        {
            return EPlayerRole.Goalie;
        }
    }
}
