using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    ////#2) Write a function that takes in a string of letters(e.g., "Llewellyn") and returns a 
    ////alphabetically ordered string corresponding to the letter frequency (e.g., "E2L4N1W1Y1")
    ////USE LINQ AND LAMBDA TO SOLVE^

    class LetterFrequencyLinq
    {
        //Data source
        string word = "Llewellyn";

        public void RunLetterFrequency()
        {
            Console.WriteLine("\n\n#2) FIND THE FREQUENCY OF EACH LETTER");
               Console.WriteLine("\nThe word is: " + word);

            //Query 
            var letterFrequency = word.ToUpper()
                .OrderBy(az => az)
                .GroupBy(character => character)
                .Select(count => new { Char = count.Key, Count = count.Count() });

            //Execute
            foreach (var letter in letterFrequency)
            {
                Console.Write("{0}{1}", letter.Char, letter.Count);
            }
        }
    }
}