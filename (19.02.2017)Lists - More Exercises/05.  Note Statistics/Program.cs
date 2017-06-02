using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            var notes = new List<string>();

            var natural = new List<string>();
            var naturalNotesFrequency = new List<string>();
            

            var sharps = new List<string>();
            var sharpsNotesFrequency = new List<string>();
            

            ConvertFrequencyToMusicalNotes(input, natural, naturalNotesFrequency, sharps, sharpsNotesFrequency,notes);

            sumNotesFrequency(naturalNotesFrequency);
            sumNotesFrequency(sharpsNotesFrequency);

            Console.WriteLine($"Notes: {string.Join(" ", notes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", natural)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
            Console.WriteLine($"Naturals sum: {string.Join(", ", sumNotesFrequency(naturalNotesFrequency))}");
            Console.WriteLine($"Sharps sum: {string.Join(", ", sumNotesFrequency(sharpsNotesFrequency))}");

        }
        private static double sumNotesFrequency(List<string> NotesFrequency)
        {
            var sum = 0.0;

            for (int i = 0; i < NotesFrequency.Count; i++)
            {
                sum += double.Parse(NotesFrequency[i]);
            }

            return sum;
        }

        

        private static void ConvertFrequencyToMusicalNotes(List<string> input, List<string> natural, List<string> naturalNotesFrequency, List<string> sharps, List<string> sharpsNotesFrequency, List<string> notes)
        {
            for (int i = 0; i < input.Count; i++)
            {
                switch (input[i])
                {
                    case "261.63":
                        natural.Add("C");
                        naturalNotesFrequency.Add("261.63");
                        notes.Add("C");
                        break;
                    case "277.18":
                        sharps.Add("C#");
                        sharpsNotesFrequency.Add("277.18");
                        notes.Add("C#");
                        break;
                    case "293.66":
                        natural.Add("D");
                        naturalNotesFrequency.Add("293.66");
                        notes.Add("D");
                        break;
                    case "311.13":
                        sharps.Add("D#");
                        sharpsNotesFrequency.Add("311.13");
                        notes.Add("D#");
                        break;
                    case "329.63":
                        natural.Add("E");
                        naturalNotesFrequency.Add("329.63");
                        notes.Add("E");
                        break;                       
                    case "349.23":
                        natural.Add("F");
                        naturalNotesFrequency.Add("349.23");
                        notes.Add("F");
                        break;
                    case "369.99":
                        sharps.Add("F#");
                        sharpsNotesFrequency.Add("369.99");
                        notes.Add("F#");
                        break;
                    case "392.0":
                        natural.Add("G");
                        naturalNotesFrequency.Add("392.00");
                        notes.Add("G");
                        break;
                    case "415.30":
                        sharps.Add("G#");
                        sharpsNotesFrequency.Add("415.30");
                        notes.Add("G#");
                        break;
                    case "440.0":
                        natural.Add("A");
                        naturalNotesFrequency.Add("440.00");
                        notes.Add("A");
                        break;
                    case "466.16":
                        sharps.Add("A#");
                        sharpsNotesFrequency.Add("466.16");
                        notes.Add("A#");
                        break;
                    case "493.88":
                        natural.Add("B");
                        naturalNotesFrequency.Add("493.88");
                        notes.Add("B");
                        break;
                }
            }
        }
    }
    }
