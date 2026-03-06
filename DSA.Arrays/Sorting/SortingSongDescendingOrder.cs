using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Sorting
{
 //Input:
// Song A  12
// Song B  6
// Song C  12
// Song D  5
// Song E  7

//Output:
// Song A
// Song C
// Song E
// Song B
// Song D

    public static class SortingSongDescendingOrder
    {
        public static IEnumerable<string> GetSongs(List<Song> songList) 
        {
            // select Requests from songList Order By Requests DESC;

            var list = songList.OrderByDescending(s => s.Requests)
                       .Select(x => x.Name);
                       //.ToList(); // now return type is IEnumerable not List<string>

            return list;
        }
    }

    public class Song 
    {
        public string Name { get; set; }
        public int Requests { get; set; }
    }
}
