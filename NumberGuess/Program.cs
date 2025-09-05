using System;


namespace NumberGuess
{
    internal class Program
    {
        private static GuessNumber guessNumber = new GuessNumber();
        private static PlayGame playGame = new PlayGame();
        static void Main(string[] args)
        {
            

            while (true)
            {

                Greetings();
                string secim = Console.ReadLine();
                if (secim == "0")
                {
                    break;
                }

                switch (secim)
                {
                    case "1": Easy(); break;
                    case "2":  break;
                    case "3":  break;
                    case "4":  break;
                }


            }

            void Greetings()
            {
                Console.WriteLine("=== Sayı Tahmin Oyunu ===");
                Console.WriteLine("=== Lütfen Zorluk Derecesini Seçiniz ===");
                Console.WriteLine("1) Kolay | 1 - 50 | 10 Tahmin Hakkı");
                Console.WriteLine("2) Orta | 1 - 100 | 7 Tahmin Hakkı");
                Console.WriteLine("3) Zor | 1 - 500 | 8 Tahmin Hakkı");
                Console.WriteLine("4) Uzman | 1 - 1000 | 10 Tahmin Hakkı");
                Console.WriteLine("0) Çıkış");
            }

            void Easy()
            {

                int GuessLimit = 10;
                int min = 1;
                int max = 3;
                int sayi = guessNumber.ChooseLevelRandom(min, max); // döngüden önce kullan her seferinde yeni numara üretme  

                playGame.PlayGames(GuessLimit, min, max, sayi);

            }

        }

        
    }
}

