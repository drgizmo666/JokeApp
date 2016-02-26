using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jokeArr = new string[] { "Why did the blonde get excited after finishing her puzzle in 6 months? -- The box said 2-4 years!",
            "I once farted in an elevator, it was wrong on so many levels.", 
            "If 4 out of 5 people SUFFER from diarrhea; does that mean that one enjoys it?"};
            Random r = new Random();
            Console.WriteLine(jokeArr[r.Next(3)]);
            Console.ReadLine();
        }
    }
}
