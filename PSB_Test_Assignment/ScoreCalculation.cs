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
                    teamOneScore += 1;
                    teamTwoScore += 1;
                }

                else if (matchResult.TeamOne > matchResult.TeamTwo)
                {
                    teamOneScore += 3;
                }

                else
                {
                    teamTwoScore += 3;
                }

                //Исходя из логики, что за победу в домашних матчах дается 3 очка, за ничью 1 очко,  за поражение 0 очков.
                //Вывести на экран количество очков, набранных каждой командой по итогам проведенных матчей.
            }

            return (teamOneScore, teamTwoScore);
        }
    }
}
