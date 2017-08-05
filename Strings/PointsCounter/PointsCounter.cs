using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCounter
{
    public class PointsCounter
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> teamScorePair =
                new Dictionary<string, Dictionary<string, int>>();

            while (input != "Result")
            {
                input = input.Replace("@", "");
                input = input.Replace("%", "");
                input = input.Replace("$", "");
                input = input.Replace("*", "");

                string[] elements = input.Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries);

                if (elements[1].Any(char.IsLower))
                {
                    string team = elements[0];
                    string player = elements[1];
                    int score = int.Parse(elements[2]);
                    if (!teamScorePair.ContainsKey(team))
                    {
                        teamScorePair[team] = new Dictionary<string, int>();

                        if (!teamScorePair[team].ContainsKey(player))
                        {
                            teamScorePair[team][player] = 0;
                        }
                    }
                    teamScorePair[team][player] = score;
                    }
                

                else if (elements[0].Any(char.IsLower))
                {
                    string team = elements[1];
                    string player = elements[0];
                    int score = int.Parse(elements[2]);
                    if (!teamScorePair.ContainsKey(team))
                    {
                        teamScorePair[team] = new Dictionary<string, int>();

                        if (!teamScorePair[team].ContainsKey(player))
                        {
                            teamScorePair[team][player] = 0;
                        }
                    }

                    teamScorePair[team][player] = score;
                    
                }

                input = Console.ReadLine();
            }
            List<string> bestTeams = new List<string>();
            List<string> totalScores = new List<string>();
            List<string> bestPlayers = new List<string>();

            var bestTeam = teamScorePair
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ToDictionary(x => x.Key, y => y.Value);
            foreach (var team in bestTeam)
            {
                bestTeams.Add(team.Key);
            }

            foreach (var kvp in bestTeam)
            {
                var totalScore = kvp.Value
                    .Sum(x => x.Value)
                    .ToString();

                totalScores.Add(totalScore);
            }

            foreach (var item in bestTeam)
            {
                var bestPlayer = item.Value
                    .OrderByDescending(x => x.Value)
                    .Take(1)
                    .ToDictionary(x => x.Key, y => y.Value);

                foreach (var player in bestPlayer)
                {
                    bestPlayers.Add(player.Key);
                }
            }

            for (int i = 0; i < bestTeams.Count; i++)
            {
                Console.WriteLine($"{bestTeams[i]} => {totalScores[i]}");
                Console.WriteLine($"Most points scored by {bestPlayers[i]}");
            }
        }
    }
}