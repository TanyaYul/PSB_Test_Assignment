namespace PSB_Test_Assignment
{
    public class ScoreCalculation
    {
        public (int, int) CalculateScore(List<MatchResults> matchResults)
        {
            int teamOneScore = 0;
            int teamTwoScore = 0;

            foreach (MatchResults matchResult in matchResults)
            {

                if (matchResult.TeamOne == matchResult.TeamTwo)
                {
                    teamOneScore ++;
                    teamTwoScore ++;
                }

                else if (matchResult.TeamOne > matchResult.TeamTwo)
                {
                    teamOneScore += 3;
                }

                else
                {
                    teamTwoScore += 3;
                }
            }

            return (teamOneScore, teamTwoScore);
        }
    }
}
