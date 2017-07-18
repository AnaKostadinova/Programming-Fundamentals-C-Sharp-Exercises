using System;
using System.Collections.Generic;
using System.Linq;

public class UnunionLists
{
    public static void Main()
    {
        
        string[] notes = {
           "C",
           "C#",
           "D",
           "D#",
           "E",
           "F",
           "F#",
           "G",
           "G#",
           "A",
           "A#",
           "B"
        };
        double[] notesValues =
        {
            261.63,
            277.18,
            293.66,
            311.13,
            329.63,
            349.23,
            369.99,
            392.00,
            415.30,
            440.00,
            466.16,
            493.88

        };

        
        List<string> sharps = new List<string>();
        List<string> naturals = new List<string>();
        List<string> selectedNotes = new List<string>();

        for (int i = 0; i < notes.Length; i++)
        {
            selectedNotes.ad
        }
        for (int i = 0; i < notes.Length; i++)
        {
            if (notes[i].Contains('#'))
            {
                sharps.Add(notes[i]);
            }
            else
            {
                naturals.Add(notes[i]);
            }     
                }

        