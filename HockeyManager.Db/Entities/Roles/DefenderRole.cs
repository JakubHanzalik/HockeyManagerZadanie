namespace HockeyManager.Db.Entities.Roles
{
    public class DefenderRole : IPlayerRole
    {
        public int Hits { get; set; }

        public EPlayerRole GetEPlayerRole()
        {
            return EPlayerRole.Defender;
        }
    }
}
