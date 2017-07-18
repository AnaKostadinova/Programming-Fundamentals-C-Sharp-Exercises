using System;
using System.Collections.Generic;
using System.Linq;

class SoftUniBeerPong
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, int>> teamsResults = new Dictionary<string, Dictionary<string, int>>();

        string input = Console.ReadLine();

        while (input != "stop the game")
        {
            string[] elements = input.Split('|');
            string player = elements[0];
            string team = elements[1];
            int playersPoints = int.Parse(elements[2]);

            if (!teamsResults.ContainsKey(elements[1]))
            {
                teamsResults[team] = new Dictionary<string, int>();
            }
            if (teamsResults[team].Count < 3)
            {
                if (!teamsResults[team].ContainsKey(player))
                {
                    teamsResults[team][player] = 0;
                }

                teamsResults[team][player] = playersPoints;
            }

            input = Console.ReadLine();
        }

        teamsResults = teamsResults
            .Where(x => x.Value.Count == 3)
            .OrderByDescending(x => x.Value.Sum(y => y.Value))
            .ToDictionary(x => x.Key, x => x.Value);

        int ranking = 1;
        foreach (var kvp in teamsResults)
        {
            Console.WriteLine($"{ranking}. {kvp.Key}; Players:");

            Dictionary<string, int> playersResults = kvp.Value;

            var sortedPlayersResults = playersResults
                .OrderByDescending(x => x.Value);
            foreach (var kvp1 in sortedPlayersResults)
            {
                Console.WriteLine($"###{kvp1.Key}: {kvp1.Value}");
            }
            ranking++;
        }
    }
}