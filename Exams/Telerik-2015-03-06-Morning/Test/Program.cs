using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> catSongs = new List<List<int>>();
            catSongs.Insert(2, new List<int>() {10, 12});
        }
    }
}
