namespace adonet_db_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cerca un gioco per il suo id");
            int searchGameId = int.Parse(Console.ReadLine());   

            VideogameManager.GetVideogameByID(searchGameId);

            Console.WriteLine("Inserisci il nome del videogioco:");
            string name = Console.ReadLine();

            Console.WriteLine("Inserisci la descrizione del videogioco:");
            string overview = Console.ReadLine();

            Console.WriteLine("Inserisci la data di rilascio del videogioco (YYYY-MM-DD):");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime releaseDate))
            {
                Console.WriteLine("Data non valida.");
                return;
            }

            DateTime createdAt = DateTime.Now;
            DateTime updatedAt = DateTime.Now;

            Console.WriteLine("Inserisci l'ID della casa di produzione del videogioco:");
            if (!int.TryParse(Console.ReadLine(), out int softwareHouseId))
            {
                Console.WriteLine("ID non valido.");
                return;
            }

            VideogameManager.InsertVideogame(name, overview, releaseDate, createdAt, updatedAt, softwareHouseId);


            

        }


       
    }
}
