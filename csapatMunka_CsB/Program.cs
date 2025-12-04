using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Globalization;

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
                    Console.WriteLine("\n Teljes lista: A:\n");
                    Console.WriteLine("Filmek keresése\n " +
                        "\tnév alapján: N\n" +
                        "\trendező alapján: R\n" +
                        "\tév alapján: E\n");
                    Console.WriteLine("Rendező keresése\n" +
                        "\tfilm alapján: F\n" +
                        "\tstílus alapján: S\n");

                    Console.WriteLine("Új film felvétele: Enter");
                    Console.WriteLine("Kilépés: Q");
                }

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.Enter:
                        UjFelvetel();
                        FajlBeolvasas();
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.N:
                        Kereses("N");
                        break;
                    case ConsoleKey.R:
                        Kereses("R");
                        break;
                    case ConsoleKey.E:
                        Kereses("E");
                        break;
                    case ConsoleKey.F:
                        Kereses("F");
                        break;
                    case ConsoleKey.S:
                        Kereses("S");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("\nTeljes film lista:\n");
                        foreach (var movie in movies)
                        {
                            Console.WriteLine(movie.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("Érvénytelen billentyű. Próbáld újra!");
                        break;
                }
            }
        }

        private static void Kereses(string v)
        {
            switch (v.ToLower())
            {
                case "n":
                    Console.Write("\nÍrd be a film címét (akár csak egy részletét): ");
                    string bevitt = Console.ReadLine();
                    List<Movie> found = movies.FindAll(m => m.Movie_Name.IndexOf(bevitt, StringComparison.OrdinalIgnoreCase) >= 0);

                    if (found.Count > 0)
                    {
                        Console.WriteLine("\nTalált filmek:");
                        foreach (var movie in found)
                        {
                            Console.WriteLine(movie.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nem található ilyen film.");
                    }
                    break;
                case "r":
                    Console.Write("Írd be a rendező nevét (akár csak egy részletét): ");
                    string bevittR = Console.ReadLine();
                    List<Movie> foundR = movies.FindAll(m => m.Director.IndexOf(bevittR, StringComparison.OrdinalIgnoreCase) >= 0);

                    if (foundR.Count > 0)
                    {
                        Console.WriteLine("Talált filmek:");
                        foreach (var movie in foundR)
                        {
                            Console.WriteLine(movie.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nem található ilyen film.");
                    }

                    break;
                case "e":
                    Console.Write("Írd be az évet (akár csak egy részletét): ");
                    string bevittE = Console.ReadLine();
                    List<Movie> foundE = movies.FindAll(m => m.Release_Date.Year.ToString().IndexOf(bevittE, StringComparison.OrdinalIgnoreCase) >= 0);

                    if (foundE.Count > 0)
                    {
                        Console.WriteLine("Talált filmek:");
                        foreach (var movie in foundE)
                        {
                            Console.WriteLine(movie.Movie_Name + " - " + movie.Release_Date);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nem található ilyen film.");
                    }

                    break;
                case "f":
                    Console.Write("Írd be az film címét (akár csak egy részletét): ");
                    string bevittF = Console.ReadLine();
                    List<Movie> foundF = movies.FindAll(m => m.Movie_Name.IndexOf(bevittF, StringComparison.OrdinalIgnoreCase) >= 0);

                    if (foundF.Count > 0)
                    {
                        Console.WriteLine("Talált rendezők:");
                        foreach (var movie in foundF)
                        {
                            Console.WriteLine(movie.Movie_Name + " - " + movie.Director);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nem található ilyen film.");
                    }

                    break;
                case "s":
                    Console.Write("Írd be a stílust (akár csak egy részletét): ");
                    string bevittS = Console.ReadLine();
                    List<Movie> foundS = movies.FindAll(m => m.Movie_Type.IndexOf(bevittS, StringComparison.OrdinalIgnoreCase) >= 0);

                    if (foundS.Count > 0)
                    {
                        Console.WriteLine("Talált rendezők:");
                        foreach (var movie in foundS)
                        {
                            Console.WriteLine(movie.Movie_Name +" - "+ movie.Director);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nem található ilyen film.");
                    }

                    break;

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

                var plusdata1 = "";
                var plusdata2 ="";
                var plusdata3 = "";
                var plusdata4 = 0;

                switch (mufaj) {
                    case "Action":
                        Console.Write("Add meg a főhős nevét: ");
                        string fohos = Console.ReadLine();
                        plusdata1 = fohos;
                        Console.Write("Add meg a főgonosz nevét: ");
                        string fogonosz = Console.ReadLine();
                        plusdata2 = fogonosz;
                        Console.Write("Add meg a kaszkadőrmutatványok intenzitási szintjét (1-10): ");


                int intenzitas = 0;
                        do
                        {
                            Console.WriteLine("Hiba! Kérlek, érvényes számot adj meg 1 és 10 között az intenzitási szinthez.");
                        }
                        while (!int.TryParse(Console.ReadLine(), out intenzitas) || intenzitas < 1 || intenzitas > 10);
                        plusdata4 = intenzitas;
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

                        StreamWriter sw = new StreamWriter("movies_new.csv", true, Encoding.UTF8);
                        sw.WriteLine($"{ujAction.Movie_Name};{ujAction.Release_Date};{ujAction.Movie_Type};{ujAction.Director};{ujAction.Music_Composer};{ujAction.Money_Spent};{ujAction.Income};{ujAction.MainHeroName};{ujAction.MainVillainName};{ujAction.StuntIntensityLevel}");

                        sw.Close();

                        Console.WriteLine("Új Action film sikeresen hozzáadva!");
                        break;
                    case "Adventure":

                        Console.Write("Van kincskeresés a filmben? (igen/nem): ");
                        string kincskereses;

                        do
                        {
                            kincskereses = Console.ReadLine().ToLower();
                            if (kincskereses != "igen" && kincskereses != "nem")
                            {
                                Console.WriteLine("Hiba! Csak 'igen' vagy 'nem' választ adhatsz meg.");
                                Console.Write("Van kincskeresés a filmben? (igen/nem): ");
                            }
                        }
                        while (kincskereses != "igen" && kincskereses != "nem");

                        bool vanKincsKereses = kincskereses == "igen";

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
                            vanKincsKereses,
                            foszereplo,
                            foellenseg
                        );

                        movieGenres.Add(ujAdventure);
                        movies.Add(ujAdventure);

                        // CSV MENTÉS UGYANÚGY, MINT ACTION
                        StreamWriter swA = new StreamWriter("movies_new.csv", true, Encoding.UTF8);
                        swA.WriteLine(
                            $"{ujAdventure.Movie_Name};" +
                            $"{ujAdventure.Release_Date};" +
                            $"{ujAdventure.Movie_Type};" +
                            $"{ujAdventure.Director};" +
                            $"{ujAdventure.Music_Composer};" +
                            $"{ujAdventure.Money_Spent};" +
                            $"{ujAdventure.Income};" +
                            $"{(vanKincsKereses ? "igen" : "nem")};" +
                            $"{ujAdventure.MainProtagonistName};" +
                            $"{ujAdventure.MainAntagonistName}"
                        );
                        swA.Close();

                        Console.WriteLine("Új Adventure film sikeresen hozzáadva!");
                        break;
                    case "Animation":

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

                        movieGenres.Add(ujAnimation);
                        movies.Add(ujAnimation);

                        using (StreamWriter swAnim = new StreamWriter("movies_new.csv", true, Encoding.UTF8))
                        {
                            swAnim.WriteLine(
                                $"{ujAnimation.Movie_Name};" +
                                $"{ujAnimation.Release_Date};" +
                                $"{ujAnimation.Movie_Type};" +
                                $"{ujAnimation.Director};" +
                                $"{ujAnimation.Music_Composer};" +
                                $"{ujAnimation.Money_Spent};" +
                                $"{ujAnimation.Income};" +
                                $"{ujAnimation.AnimationStyle};" +
                                $"{ujAnimation.TargetAgeGroup};" +
                                $"{ujAnimation.StudioName};" +
                                $"{ujAnimation.MainCharacterName}"
                            );
                        }

                        Console.WriteLine("Új Animation film sikeresen hozzáadva!");
                        break;
                    case "Crime":

                        Console.Write("Add meg a bűncselekmény típusát: ");
                        string bunCselekmenyTipus = Console.ReadLine();

                        Console.Write("Add meg a nyomozó nevét: ");
                        string nyomozoNev = Console.ReadLine();

                        // --- VALÓS ESEMÉNY VALIDÁCIÓ ---
                        Console.Write("Valós eseményeken alapul a film? (igen/nem): ");
                        string valosEsemeny;

                        do
                        {
                            valosEsemeny = Console.ReadLine().ToLower();
                            if (valosEsemeny != "igen" && valosEsemeny != "nem")
                            {
                                Console.WriteLine("Hiba! Csak 'igen' vagy 'nem' lehet.");
                                Console.Write("Valós eseményeken alapul? (igen/nem): ");
                            }
                        }
                        while (valosEsemeny != "igen" && valosEsemeny != "nem");

                        bool valos = valosEsemeny == "igen";

                        // --- ALDOZATOK SZÁMA ---
                        Console.Write("Add meg az áldozatok számát: ");
                        int aldozatSzam;
                        while (!int.TryParse(Console.ReadLine(), out aldozatSzam) || aldozatSzam < 0)
                        {
                            Console.WriteLine("Hiba! Csak pozitív egész szám lehet!");
                            Console.Write("Áldozatok száma: ");
                        }

                        // --- OBJEKTUM LÉTREHOZÁSA ---
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
                            valos,
                            aldozatSzam
                        );

                        movieGenres.Add(ujCrime);
                        movies.Add(ujCrime);

                        // --- CSV MENTÉS UGYANÚGY MINT ACTION ---
                        using (StreamWriter swCrime = new StreamWriter("movies_new.csv", true, Encoding.UTF8))
                        {
                            swCrime.WriteLine(
                                $"{ujCrime.Movie_Name};" +
                                $"{ujCrime.Release_Date};" +
                                $"{ujCrime.Movie_Type};" +
                                $"{ujCrime.Director};" +
                                $"{ujCrime.Music_Composer};" +
                                $"{ujCrime.Money_Spent};" +
                                $"{ujCrime.Income};" +
                                $"{ujCrime.CrimeType};" +
                                $"{ujCrime.InvestigatorName};" +
                                $"{(valos ? "igen" : "nem")};" +
                                $"{ujCrime.VictimCount}"
                            );
                        }

                        Console.WriteLine("Új Crime film sikeresen hozzáadva!");
                        break;
                    case "Drama":

                        Console.Write("Add meg a konfliktus típusát: ");
                        string konfliktusTipus = Console.ReadLine();

                        Console.Write("Add meg a főszereplő nevét: ");
                        string foSzereploNev = Console.ReadLine();

                        string tragikusBefejezes;

                        Console.Write("Tragikus a befejezés? (igen/nem): ");
                        do
                        {
                            tragikusBefejezes = Console.ReadLine().ToLower();
                            if (tragikusBefejezes != "igen" && tragikusBefejezes != "nem")
                            {
                                Console.WriteLine("Hiba! Csak 'igen' vagy 'nem' lehet.");
                                Console.Write("Tragikus a befejezés? (igen/nem): ");
                            }
                        }
                        while (tragikusBefejezes != "igen" && tragikusBefejezes != "nem");

                        bool tragikus = tragikusBefejezes == "igen";

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
                            tragikus
                        );

                        movieGenres.Add(ujDrama);
                        movies.Add(ujDrama);

                        using (StreamWriter swDrama = new StreamWriter("movies_new.csv", true, Encoding.UTF8))
                        {
                            swDrama.WriteLine(
                                $"{ujDrama.Movie_Name};" +
                                $"{ujDrama.Release_Date};" +
                                $"{ujDrama.Movie_Type};" +
                                $"{ujDrama.Director};" +
                                $"{ujDrama.Music_Composer};" +
                                $"{ujDrama.Money_Spent};" +
                                $"{ujDrama.Income};" +
                                $"{ujDrama.ConflictType};" +
                                $"{ujDrama.MainProtagonistName};" +
                                $"{(tragikus ? "igen" : "nem")}"
                            );
                        }

                        Console.WriteLine("Új Drama film sikeresen hozzáadva!");
                        break;

                    default:
                        Console.WriteLine("Ismeretlen műfaj. Kérlek, próbáld újra.");
                        break;


                }



            }

            catch (FormatException e)
            {
                Console.WriteLine("Hiba történt az adatok bevitele során (nem megfelelő adatformátum). Kérlek, próbáld újra.\n\n"+ e.ToString()+"\n");
            }
        }

        private static void FajlBeolvasas()
        {
            StreamReader sr = new StreamReader("movies_new.csv", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');
                movies.Add(new Movie(adat[0], Convert.ToDateTime(adat[1]), adat[2], adat[3], adat[4], Convert.ToDecimal(adat[5]), Convert.ToDecimal(adat[6])));

                // fill the genres list
                string genre = adat[2];
            }


            if( movies.Count == 0)
            {
                Console.WriteLine("Hiba a fájl beolvasásakor");
            }
            sr.Close();
        }
    }
}
