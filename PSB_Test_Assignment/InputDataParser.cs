using System.Text;

namespace PSB_Test_Assignment
{
    public class InputDataParser
    {
        public string ReadInputData(string path)
        {     
            if (File.Exists(path))
            {
                return File.ReadAllText(path, Encoding.UTF8);
            }

            return null;
        }

        public List<MatchResults> ParseInputData(string data)
        {
            var results = new List<MatchResults>();
            var stringResult = data.Split(",");
            foreach (var matchResult in stringResult)
            {
                var resultWithoutQuotes = matchResult.Replace("\"", "");
                var parsedResult = resultWithoutQuotes.Split(":");

                if (parsedResult.Length != 2) 
                {
                    Console.WriteLine($"Invalid match result (!= 2): {resultWithoutQuotes}");
                    continue;
                }

                if (int.TryParse(parsedResult[0], out var teamOne) && int.TryParse(parsedResult[1], out var teamTwo))
                {
                    if ((teamOne >= 0) && (teamTwo >= 0))
                    {                      
                        var match = new MatchResults(teamOne, teamTwo);
                        results.Add(match);
                    }
                }

                else
                {
                    Console.WriteLine($"Invalid match result (not integer or negative): {resultWithoutQuotes}");
                }
             
            }

            return results;
        }

    }
}
