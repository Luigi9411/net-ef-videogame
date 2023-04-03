using net_ef_videogame;


while (true)
{
    int option = 0;

    while (option is 0)
    {
        Console.WriteLine("Scegli una tra le opzioni:");
        Console.WriteLine("Inserisci un nuovo videogioco (1 o 'inserisci')");
        Console.WriteLine("Ricerca un videogioco per id (2 o 'inserisci')");
        Console.WriteLine("Ricerca tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input (3 o'filtra')");
        Console.WriteLine("Eliminare un nuovo videogioco (4 o 'inserisci')");
        Console.WriteLine("Inserisci un nuovo videogioco (5 o 'inserisci')");
        Console.WriteLine("Chiudere il programma (6 o 'chiudi')");

        var input = Console.ReadLine();
        option = identifyOption(input);
    }

    switch (option)
    {
        case 1:
            {
                Console.Write("Inserisci il nome: ");
                var name = Console.ReadLine() ?? "";

                Console.Write("Inserisci l'overview: ");
                var overview = Console.ReadLine() ?? "";

                Console.Write("Inserisci la release date (yyyy-MM-dd): ");
                var releaseDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Inserisci l'id della software house: ");
                var softwareHouseId = Convert.ToInt64(Console.ReadLine());

                var vg = new Videogame(name, overview, releaseDate, softwareHouseId);
                VideogameManager.InsertVideogame(vg);

                Console.WriteLine("Videogioco inserito.");

            }
            break;
        case 2:
            {
                Console.Write("Inserisci l'id: ");
                var id = Convert.ToInt64(Console.ReadLine());
                var game = VideogameManager.GetById(id);

                if (game is null)
                    Console.WriteLine("Videogame non trovato.");
                else
                    Console.WriteLine(game);
            }
            break;
        case 3:
            {
                Console.Write("Inserisci il nome: ");
                var name = Console.ReadLine() ?? "";

                var videogames = VideogameManager.GetByName(name);

                if (videogames is null || videogames.Count() == 0)
                {
                    Console.WriteLine("Nessun videogioco trovato.");
                }
                else
                {
                    Console.WriteLine($"Trovati {videogames.Count()} videogioco:");
                    foreach (var videogame in videogames)
                    {
                        Console.WriteLine(videogame);
                    }
                }
            }
            break;
        case 4:
            {
                Console.Write("Passa l'id: ");
                var id = Convert.ToInt64(Console.ReadLine());
                VideogameManager.DeleteVideogame(id);

                Console.WriteLine("Videogioco eliminato.");
            }
            break;
        case 5:
            {
                Console.Write("Inserisci il nome: ");
                var name = Console.ReadLine() ?? "";

                Console.Write("Inserisci la tax id: ");
                var taxId = Convert.ToInt64(Console.ReadLine());

                Console.Write("Inserisci la città: ");
                var city = Console.ReadLine() ?? "";

                Console.Write("Inserisci la nazione: ");
                var country = Console.ReadLine() ?? "";

                var sh = new Software_house(name, taxId, city, country);
                VideogameManager.InsertSoftwareHouse(sh);

                Console.WriteLine("Software House inserita.");

            }
            break;
        case 6:
            Console.WriteLine("Esco.");
            return;
    }

    int identifyOption(string? input)
    {
        switch (input)
        {
            case "1":
            case "inserisci":
                return 1;
            case "2":
            case "ricerca":
                return 2;
            case "3":
            case "filtra":
                return 3;
            case "4":
            case "elimina":
                return 4;
            case "5":
            case "aggiungi":
                return 5;
            case "6":
            case "chiudi":
                return 6;
            default:
                Console.WriteLine("Input non valido.");
                return 0;
        }
    }
}
