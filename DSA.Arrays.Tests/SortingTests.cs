using DSA.Arrays.Sorting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Tests
{
    public static class SortingTests
    {
        [Fact]
        public static void SortingSongsDescendingOrder_Should_Run_Without_Error() 
        {
            //Arrange
            List<Song> songList = new List<Song> {
                new Song {Name="SongA",Requests=12 },
                new Song {Name="SongB",Requests=6 },
                new Song {Name="SongC",Requests=12 },
                new Song {Name="SongD",Requests=5 },
                new Song {Name="SongE",Requests=7 }
            };

            IEnumerable <string> expectedSongList = new List<string> {
                {"SongA"},
                {"SongC"},
                {"SongE"},
                {"SongB"},
                {"SongD"},
            };



            //Act
            var result = SortingSongDescendingOrder.GetSongs(songList);

            //Assert
            Assert.Equal(expectedSongList, result);
        }
    }
}
