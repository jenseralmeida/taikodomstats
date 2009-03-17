namespace TaikodomStats.DataSL
{
    public class Rank
    {
        public Rank(byte rankNumber, byte totalPoints)
        {
            RankNumber = rankNumber;
            TotalPoints = totalPoints;
        }

        public byte RankNumber { get; private set; }

        public byte TotalPoints { get; private set; }

        public override string ToString()
        {
            return RankNumber.ToString();
        }
    }
}
