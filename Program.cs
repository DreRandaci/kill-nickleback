using System;
using System.Collections.Generic;

namespace kill_nickleback
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a List, named goodSongs, that will hold tuples consisting of two strings.
            List<(string band, string song)> goodSongs = new List<(string band, string song)>();


            // Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:
                // i. The name of an artist
                // ii. A song by that artist
            
            HashSet<(string band, string song)> allSongs = new HashSet<(string, string)>();
            allSongs.Add(("Nickelback", "Photograph")); 
            allSongs.Add(("Nickelback", "Rockstar")); 
            allSongs.Add(("Nickelback", "Somday")); 
            allSongs.Add(("Disturbed", "Down with the Sickness")); 
            allSongs.Add(("Godsmack", "I Stand Alone")); 
            allSongs.Add(("Chavelle", "Send the Pain Below")); 
            allSongs.Add(("Sevendust", "Enemy")); 
                                
            // Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".
            foreach ((string band, string song) song in allSongs)
            {
                // If the band is not Nickelback, then add it to the goodSongs list
                if (song.band != "Nickelback")
                {
                    goodSongs.Add(song);
                }
            }

            // Use another foreach loop to print out all the good songs.
            goodSongs.ForEach(s => Console.WriteLine($"\"{s.song}\" by {s.band}"));
        }
    }
}
