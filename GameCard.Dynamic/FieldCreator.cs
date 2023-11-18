using GameCard.TeamManagement;

namespace GameCard.Dynamic
{
    public class FieldCreator
    {
        private const int Height = 15;
        private const int Width = 28;

        private int[, ] Field = new int[Height, Width];

        public FieldCreator(Team teamHome, Team teamAway)
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Field[i, j] = 0;
                }
            }
        }
    }
}