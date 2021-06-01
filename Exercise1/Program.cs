using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {       
        static Song[] songs = new Song[2];
        static void Main(string[] args) {
            songs[0] = new Song("サウダージ", "ポルノグラフティ", 250);
            songs[1] = new Song("韻波句徒", "CHEHON", 320);

            PrintSongs(songs);

        }

        private static void PrintSongs(Song[] songs) {
            
            foreach (var song in songs) {
                int min = song.Length1 / 60;
                int sec = song.Length1 % 60;
                    Console.WriteLine("{0},{1},{2}:{3}", song.Title1,song.ArtistName1,min,sec);
            }
        }
    }
}
