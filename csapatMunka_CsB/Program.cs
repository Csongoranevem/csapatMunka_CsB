using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csapatMunka_CsB
{
    internal class Program
    {

        static List<Movie> movies = new List<Movie>();

        static List<MovieGenre> movieGenres = new List<MovieGenre>();
        int v;
        static void Main(string[] args)
        {
            FajlBeolvasas();

            while (true)
            {
                if (!Console.KeyAvailable)
                {
                    Console.WriteLine("Új film felvétele: Enter");
                    Console.WriteLine("Kilépés: Q");
                }
                    

                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Q)
                    break;

                UjFelvetel();
            }


            Console.ReadKey();

        }

        private static void UjFelvetel()
        {
            const int minEv = 1895;
            const int maxEv = 2026;
            Console.Write("Add meg a film címét: ");
            string cim = Console.ReadLine();
            Console.Write("Add meg a megjelenés évét: ");
            int ev = Convert.ToInt32(Console.ReadLine());
            while (ev < minEv || ev > maxEv)
            {
                Console.WriteLine($"Hiba! Kérlek {minEv} és {maxEv} közötti évet adj meg!");
                Console.Write("Add meg a megjelenés évét: ");
                ev = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Add meg a film műfaját: ");
            string mufaj = Console.ReadLine();

        }

        private static void FajlBeolvasas()
        {
            StreamReader sr = new StreamReader("movies.csv", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');
                movies.Add(new Movie(adat[0], Convert.ToDateTime(adat[1]), adat[2], adat[3], adat[4], Convert.ToDecimal(adat[5]), Convert.ToDecimal(adat[6])));

                // fill the genres list

                string genre = adat[2];
                switch (genre)
                {
                    case "Action":
                        //movieGenres.Add(new Action(...));
                        break;
                    case "Drama":
                        //movieGenres.Add(new Drama(...));
                        break;
                    case "Comedy":
                        //movieGenres.Add(new Comedy(...));
                        break;

                    case "Science Fiction":
                        //movieGenres.Add(new ScienceFiction(...));
                        break;

                    case "Horror":
                        //movieGenres.Add(new Horror(...));
                        break;
                    case "Romance":
                        //movieGenres.Add(new Romance(...));
                        break;
                    case "Thriller":
                        //movieGenres.Add(new Thriller(...));
                        break;
                    case "Crime":
                        //movieGenres.Add(new Crime(...));
                        break;
                    case "Fantasy":
                        //movieGenres.Add(new Fantasy(...));
                        break;
                    case "Historical Drama":
                        //movieGenres.Add(new HistoricalDrama(...));
                        break;
                    case "Animation":
                        //movieGenres.Add(new Animation(...));
                        break;
                    case "Superhero":
                        //movieGenres.Add(new Superhero(...));
                        break;
                    case "Musical":
                        //movieGenres.Add(new Musical(...));
                        break;

                    default:
                        break;
                }


            }

            if (movies.Count >= 0)
            {
                Console.WriteLine("Fájl sikeresen beolvasva");
                foreach (var item in movies)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Hiba a fájl beolvasásakor");
            }

            


        }
    }
}
