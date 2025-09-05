using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    public class GuessNumber
    {
        private readonly Random _rnd = new Random();

        public int ChooseLevelRandom(int min, int max)
        {
            int s =_rnd.Next(min, max + 1);
            return s;
        }
        
    }
}
