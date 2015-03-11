using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CatsConcert
{
    static void Main(string[] args)
    {
        var numberOfCats = Console.ReadLine().Split(' ');
        int catsCount = int.Parse(numberOfCats[0]);
        var numberOfSongs = Console.ReadLine().Split(' ');
        int songsCoung = int.Parse(numberOfSongs[0]);
        var dictCatsAndSongs = new Dictionary<int,List<int>>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].Equals("Mew!"))
            {
                break;
            }
            var currentCat = int.Parse(input[1]);
            var currentSong = int.Parse(input[4]);
            var allSongsCurrentCat = new List<int>();
            if (dictCatsAndSongs.TryGetValue(currentCat, out allSongsCurrentCat))
            {
                allSongsCurrentCat.Add(currentSong);
                dictCatsAndSongs[currentCat] = allSongsCurrentCat;
            }
            else
            {
                dictCatsAndSongs.Add(currentCat, new List<int>() { currentSong });
            }
        }

        var uniqueSongsOnly = new HashSet<int>();
        foreach (var cat in dictCatsAndSongs)
        {
            foreach (var song in cat.Value)
            {
                uniqueSongsOnly.Add(song);
            }
        }

        int minCounter = int.MaxValue;

        foreach (var song in uniqueSongsOnly)
        {
            int counter = 1;
            foreach (var cat in dictCatsAndSongs)
            {
                if (cat.Value.Contains(song))
                {
                    continue;
                }
                else
                {
                    counter++;
                }
            }
            if (counter < minCounter)
            {
                minCounter = counter;
            }
        }


        if (dictCatsAndSongs.Count() > catsCount)
        { 
            Console.WriteLine(dictCatsAndSongs.Count());
        }
        else if ((dictCatsAndSongs.Count() == catsCount))
        {
            Console.WriteLine(minCounter);
        }
        else
        {
            Console.WriteLine("No concert!");
        }
    }
}