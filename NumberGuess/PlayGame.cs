using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    public class PlayGame
    {
        public void PlayGames(int GuessLimit, int min, int max, int sayi)
        {
            while (true)
            {
                Console.WriteLine($"Lütfen {min} ile {max} arasında bir sayı giriniz");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int secim))
                {
                    Console.WriteLine("Gecersiz Giris!! Lutfen sadece sayi giriniz.");
                    continue;
                }




                if (GuessLimit == 0)
                {
                    Console.WriteLine($"Oyun sona erdi. Lütfen tekrar deneyiniz. Doğru sayı: {sayi}");
                    break;
                }


                if (secim <= 0)
                {
                    Console.WriteLine("Lütfen sıfırdan büyük sayı seçiniz!!");

                }
                else if (sayi == secim)
                {
                    Console.WriteLine("Tahmininiz dogru!!");
                    break;
                }
                else if (secim > sayi)
                {
                    Console.WriteLine("Daha Küçük");
                    GuessLimit--;
                    Console.WriteLine($"Kalan hakkınız {GuessLimit} ");

                }
                else if (secim < sayi)
                {
                    Console.WriteLine("Daha Büyük");
                    GuessLimit--;
                    Console.WriteLine($"Kalan hakkınız {GuessLimit} ");
                }
            }

        }
    }
}
