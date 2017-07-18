using System;
using System.Collections.Generic;
using System.Linq;

public class TrackDownloader
{
    public static void Main()
    {
        List<string> blacklistedSongs = Console.ReadLine().Split(' ').ToList();
        List<string> tracklist = new List<string>();
        int counter = 0;

        string songs = Console.ReadLine();

        while (songs != "end")
        {
            bool isContained = false;

            for (int i = 0; i < blacklistedSongs.Count; i++)
            {
                if (songs.Contains(blacklistedSongs[i]))
                {
                    isContained = true;
                }
            }
            if (!isContained)
            {
                tracklist.Add(songs);
            }
            songs = Console.ReadLine();
        }
        tracklist.Sort();
        Console.WriteLine(string.Join(Environment.NewLine, tracklist));
    }
}