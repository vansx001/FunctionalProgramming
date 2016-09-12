using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            AverageLinq average = new AverageLinq(); //Average assignment
            average.CalculateAverage();

            LetterFrequencyLinq letters = new LetterFrequencyLinq(); //Letter Frequency assignment
            letters.RunLetterFrequency();

            Console.ReadKey();
        }
    }
}

