using System;
using System.Collections.Generic;
using System.Linq;

public class TravelCompany
{
    public static void Main()
    {
        SortedDictionary<string, Dictionary<string, int>> database =
            new SortedDictionary<string, Dictionary<string, int>>();
        string input = Console.ReadLine();

        while (!input.Contains("ready"))
        {
            string[] elements = input.Split(new char[] {':', ',', '-'}, StringSplitOptions.RemoveEmptyEntries);
            string city = elements[0];
            int capacity = 0;
            for (int i = 1; i < elements.Length; i += 2)
            {
                for (int j = i + 1; j < i + 2; j++)
                {
                    if (int.TryParse(elements[j], out capacity))
                    {
                        if (!database.ContainsKey(city))
                        {
                            database[city] = new Dictionary<string, int>();
                        }
                        if (!database[city].ContainsKey(elements[i]))
                        {
                            database[city][elements[i]] = 0;
                            database[city][elements[i]] = capacity;
                        }
                        else
                        {
                            database[city][elements[i]] = capacity;
                        }

                    }
                }
            }

            input = Console.ReadLine();
        }
        Dictionary<string, int> passengersDatabase = new Dictionary<string, int>();
        input = Console.ReadLine();
        while (input != "travel time!")
        {
            string[] elements = input.Split();
            string city = elements[0];
            string numberOfPassengers = elements[1];
            if (!passengersDatabase.ContainsKey(city))
            {
                passengersDatabase[city] = 0;
            }
            passengersDatabase[city] = int.Parse(numberOfPassengers);

            input = Console.ReadLine();
        }

        foreach (var databaseKvp in database)
        {
            foreach (var passengersDatabaseKvp in passengersDatabase)
            {
                if (databaseKvp.Key == passengersDatabaseKvp.Key)
                {
                    foreach (var component in databaseKvp.Value)
                        {
                          int total= databaseKvp.Value.Select(a => component.Value).Sum();

                            if (total >= passengersDatabaseKvp.Value)
                            {
                                Console.WriteLine($"{passengersDatabaseKvp.Key} " +
                                                  $"-> all {passengersDatabaseKvp.Value} accommodated");
                                break;
                            }
                            else
                            {
                                int passengersShort = Math.Abs(total - passengersDatabaseKvp.Value);
                                Console.WriteLine($"{passengersDatabaseKvp.Key} " +
                                                  $"-> all except {passengersShort} accommodated");
                                break;

                            }
                        }
                        }
                    }
                }
            }
        }
    
