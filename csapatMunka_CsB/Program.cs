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
                    Console.WriteLine("Filmek keresése\n " +
                        "\tnév alapján: N\n" +
                        "\trendező alapján: R\n" +
                        "\tév alapján: E\n" +
                        "\tMás adattípus alapján: M\n");
                    Console.WriteLine("Rendező keresése\n" +
                        "\tfilm alapján alapján: F\n" +
                        "\tstílus alapján: S\n");

                    Console.WriteLine("Új film felvétele: Enter");
                    Console.WriteLine("Kilépés: Q");
                }

                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        UjFelvetel();
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Érvénytelen billentyű. Próbáld újra!");
                        break;
                }
            }
        }

        private static void UjFelvetel()
        {
            try
            {
                const int minEv = 1900;
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

                Console.Write("Add meg a rendező nevét: ");
                string rendezo = Console.ReadLine();

                Console.Write("Add meg a zeneszerző nevét: ");
                string zeneszerzo = Console.ReadLine();

                Console.Write("Add meg a film költségvetését (USD): ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal koltsegvetes) || koltsegvetes < 0)
                {
                    Console.WriteLine("Hiba! Kérlek, érvényes pozitív számot adj meg a költségvetéshez.");
                    return;
                }

                Console.Write("Add meg a film bevételét (USD): ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal bevetel) || bevetel < 0)
                {
                    Console.WriteLine("Hiba! Kérlek, érvényes pozitív számot adj meg a bevételhez.");
                    return;
                }

                switch (mufaj) {
                    case "Action":
                        Console.Write("Add meg a főhős nevét: ");
                        string fohos = Console.ReadLine();
                        Console.Write("Add meg a főgonosz nevét: ");
                        string fogonosz = Console.ReadLine();

                        Console.Write("Add meg a kaszkadőrmutatványok intenzitási szintjét (1-10): ");


                int intenzitas = 0;
                        do
                        {
                            Console.WriteLine("Hiba! Kérlek, érvényes számot adj meg 1 és 10 között az intenzitási szinthez.");
                        }
                        while (!int.TryParse(Console.ReadLine(), out intenzitas) || intenzitas < 1 || intenzitas > 10);

                        Action ujAction = new Action(
                            cim,
                            new DateTime(ev, 1, 1),
                            mufaj,
                            rendezo,
                            zeneszerzo,
                            koltsegvetes,
                            bevetel,
                            "Action",
                            "Heroic",
                            "Serious",
                            "General Audience",
                            fohos,
                            fogonosz,
                            intenzitas
                        );
                        movieGenres.Add(ujAction);
                        movies.Add(ujAction);
                        Console.WriteLine("Új Action film sikeresen hozzáadva!");
                        break;
                    case "Adventure":
                        Console.Write("Van kincskeresés a filmben? (igen/nem): ");
                       //do while

                        string kincskereses;
                        do
                        {
                            Console.WriteLine("Hiba! Kérlek, érvényes számot adj meg 1 és 10 között az intenzitási szinthez.");
                            kincskereses = Console.ReadLine().ToLower();
                        }
                        while (kincskereses != "igen" || kincskereses != "nem");


                        Console.Write("Add meg a főszereplő nevét: ");
                        string foszereplo = Console.ReadLine();
                        Console.Write("Add meg a főellenség nevét: ");
                        string foellenseg = Console.ReadLine();


                        Adventure ujAdventure = new Adventure(
                            cim,
                            new DateTime(ev, 1, 1),
                            mufaj,
                            rendezo,
                            zeneszerzo,
                            koltsegvetes,
                            bevetel,
                            "Adventure",
                            "Exploration",
                            "Exciting",
                            "Teens and Adults",
                            kincskereses == "igen",
                            foszereplo,
                            foellenseg
                        );
                        break;
                    case "Animation":
                        // Implement Animation specific input and object creation here
                        /*            
                        string animationStyle,
                        string targetAgeGroup,
                        string studioName,
                        string mainCharacterName*/
                        Console.Write("Add meg az animáció stílusát: ");
                        string animacioStilus = Console.ReadLine();

                        Console.Write("Add meg a célzott korcsoportot: ");
                        string celzottKorcsoport = Console.ReadLine();

                        Console.Write("Add meg a stúdió nevét: ");
                        string studioNev = Console.ReadLine();

                        Console.Write("Add meg a fő karakter nevét: ");
                        string foKarakterNev = Console.ReadLine();

                        Animation ujAnimation = new Animation(
                            cim,
                            new DateTime(ev, 1, 1),
                            mufaj,
                            rendezo,
                            zeneszerzo,
                            koltsegvetes,
                            bevetel,
                            "Animation",
                            "Family",
                            "Light-hearted",
                            "Children",
                            animacioStilus,
                            celzottKorcsoport,
                            studioNev,
                            foKarakterNev
                        );

                        break;
                    case "Crime":
                        /*
                        string crimeType,
                        string investigatorName,
                        bool isBasedOnTrueEvents,
                        int victimCount*/

                        Console.Write("Add meg a bűncselekmény típusát: ");
                        string bunCselekmenyTipus = Console.ReadLine();

                        Console.Write("Add meg a nyomozó nevét: ");
                        string nyomozoNev = Console.ReadLine();

                        Console.Write("Valós eseményeken alapul a film? (igen/nem): ");
                        string valosEsemeny = Console.ReadLine().ToLower();
                        if (!(valosEsemeny != "igen" || valosEsemeny != "nem"))
                        {
                            bool valos = valosEsemeny == "igen";
                        }
                        else
                        {
                            Console.WriteLine("Hiba! Kérlek, csak 'igen' vagy 'nem' választ adj meg.");
                            break;
                        }

                        Console.Write("Add meg az áldozatok számát: ");
                        if (!int.TryParse(Console.ReadLine(), out int aldozatSzam) || aldozatSzam < 0)
                        {
                            Console.WriteLine("Hiba! Kérlek, érvényes pozitív számot adj meg az áldozatok számához.");
                            break;
                        }

                        Crime ujCrime = new Crime(
                            cim,
                            new DateTime(ev, 1, 1),
                            mufaj,
                            rendezo,
                            zeneszerzo,
                            koltsegvetes,
                            bevetel,
                            "Crime",
                            "Mystery",
                            "Suspenseful",
                            "Adults",
                            bunCselekmenyTipus,
                            nyomozoNev,
                            valosEsemeny == "igen",
                            aldozatSzam
                        );

                        break;
                    case "Drama":
                        /*            string conflictType,
            string mainProtagonistName,
            int emotionalIntensityLevel,
            bool hasTragicEnding*/

                        Console.WriteLine("Add meg a konfliktus típusát: ");
                        string konfliktusTipus = Console.ReadLine();

                        Console.WriteLine("Add meg a főszereplő nevét: ");
                        string foSzereploNev = Console.ReadLine();


                        string tragikusBefejezes;

                        Console.Write("Tragikus a befejezés?");
                        do
                        {
                            Console.WriteLine("Kérlek, érvényes adatot adj meg!");
                            tragikusBefejezes = Console.ReadLine().ToLower();
                        }
                        while (tragikusBefejezes != "igen" || tragikusBefejezes != "nem");

                        Drama ujDrama = new Drama(
                            cim,
                            new DateTime(ev, 1, 1),
                            mufaj,
                            rendezo,
                            zeneszerzo,
                            koltsegvetes,
                            bevetel,
                            "Drama",
                            "Emotional",
                            "Serious",
                            "Adults",
                            konfliktusTipus,
                            foSzereploNev,
                            tragikusBefejezes == "igen"
                        );

                        Console.WriteLine(
                            "Új Drama film sikeresen hozzáadva!"
                        );

                        break;

                }

            }
            catch (InvalidDataException e)
            {
                Console.WriteLine("Hiba történt az adatok bevitele során (nem megfelelő adatformátum). Kérlek, próbáld újra.\n\n"+ e.ToString()+"\n");
            }
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
