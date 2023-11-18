namespace GameCard.TeamManagement
{
    internal class Player
    {
        private readonly int _id;
        private readonly string _name;

        public Player(int id, string name, int number, NbaTeamEnum nbaTeam, PlayerStatus playerStatus)
        {
            _id = id;
            _name = name;
            Number = number;
            NbaTeam = nbaTeam;
            PlayerStatus = playerStatus;
        }

        public int Number { get; }
        public NbaTeamEnum NbaTeam { get; }
        public PlayerStatus PlayerStatus { get; }
    }
}
