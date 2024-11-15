using System;

namespace MusicTask
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicCompany musicCompany = new MusicCompany();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Pop Song");
                Console.WriteLine("2. Add Rock Song");
                Console.WriteLine("3. Add Rap Song");
                Console.WriteLine("4. Print All Songs");
                Console.WriteLine("5. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPopSong(musicCompany);
                        break;
                    case "2":
                        AddRockSong(musicCompany);
                        break;
                    case "3":
                        AddRapSong(musicCompany);
                        break;
                    case "4":
                        musicCompany.PrintAllSongs();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddPopSong(MusicCompany musicCompany)
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            Console.Write("Enter artist: ");
            string artist = Console.ReadLine();

            Console.Write("Enter duration: ");
            if (!double.TryParse(Console.ReadLine(), out double duration))
            {
                Console.WriteLine("Invalid duration. Please try again.");
                return;
            }

            Console.Write("Enter release date (yyyy-mm-dd): ");
            string releaseDate = Console.ReadLine();

            Console.Write("Enter genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter album: ");
            string album = Console.ReadLine();

            Console.Write("Is in Top 100 (true/false): ");
            if (!bool.TryParse(Console.ReadLine(), out bool isInTop100))
            {
                Console.WriteLine("Invalid input. Please try again.");
                return;
            }

            Pop popSong = new Pop(title, artist, album, duration, releaseDate, genre, isInTop100);
            musicCompany.AddSong(popSong);
        }

        static void AddRockSong(MusicCompany musicCompany)
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            Console.Write("Enter artist: ");
            string artist = Console.ReadLine();

            Console.Write("Enter duration: ");
            if (!double.TryParse(Console.ReadLine(), out double duration))
            {
                Console.WriteLine("Invalid duration. Please try again.");
                return;
            }

            Console.Write("Enter release date (yyyy-mm-dd): ");
            string releaseDate = Console.ReadLine();

            Console.Write("Enter genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter album: ");
            string album = Console.ReadLine();

            Rock rockSong = new Rock(title, artist, album, duration, genre, releaseDate);
            musicCompany.AddSong(rockSong);
        }

        static void AddRapSong(MusicCompany musicCompany)
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            Console.Write("Enter artist: ");
            string artist = Console.ReadLine();

            Console.Write("Enter duration: ");
            if (!double.TryParse(Console.ReadLine(), out double duration))
            {
                Console.WriteLine("Invalid duration. Please try again.");
                return;
            }

            Console.Write("Enter release date (yyyy-mm-dd): ");
            string releaseDate = Console.ReadLine();

            Console.Write("Enter genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter album: ");
            string album = Console.ReadLine();

            Rap rapSong = new Rap(title, artist, album, duration, genre, releaseDate);
            musicCompany.AddSong(rapSong);
        }
    }
}