using System;
using System.Collections.Generic;
using System.Linq;

class NoteStatistics
{
    public static void Main()
    {
        List<double> inputFrequences = Console.ReadLine().Split().Select(double.Parse).ToList();
        List<string> notes = new List<string> {"C","C#","D","D#","E","F","F#","G","G#","A","A#","B"};

        List<double> frequences = new List<double>
        {
            261.63,277.18,293.66,311.13,329.63,349.23,369.99,392.00,415.30,440.00,466.16,493.88};
        List<string> outputNotes = new List<string>();
        List<string> naturalNotes = new List<string>();
        List<string> sharpNotes = new List<string>();
        double naturalNotesSum = 0;
        double sharpnotesSum = 0;
        for (int i = 0; i < inputFrequences.Count; i++)
        {
            double currentFrequency = inputFrequences[i];
            int index = frequences.IndexOf(currentFrequency);
            outputNotes.Add(notes[index]);

            if (outputNotes[i].Contains("#"))
            {
                sharpNotes.Add(outputNotes[i]);
                sharpnotesSum += currentFrequency;
            }
            else
            {
                naturalNotes.Add(outputNotes[i]);
                naturalNotesSum += currentFrequency;
            }
        }
        Console.WriteLine("Notes: " + string.Join(" ", outputNotes));
        Console.WriteLine("Naturals: " + string.Join(", ", naturalNotes));
        Console.WriteLine("Sharps: " + string.Join(", ", sharpNotes));
        Console.WriteLine("Naturals sum: " + naturalNotesSum);
        Console.WriteLine("Sharps sum: " + sharpnotesSum);
    }
}