namespace HockeyManager.Db.Entities.Roles
{
    public class ForwardRole : IPlayerRole
    {
        public int Goals { get; set; }

        public EPlayerRole GetEPlayerRole()
        {
            return EPlayerRole.Forward;
        }
    }
}
