using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class AverageLinq
    {
        ////#1) Write a function that takes in a string of grades(e.g., "90,100,82,89,55"), 
        ////and returns an average of all but the lowest three grades(e.g., "90,100" => 95).

        //Data source
        string gradesAsString = "90, 100, 82, 89, 55";

        public AverageLinq()
        {
        }

        public void CalculateAverage()      
        {
        //Query 
            int gradeInt;
            var gradesAsInt = gradesAsString.Split(new[] { ',' })
                .Select(gradesAsString => int.TryParse(gradesAsString, out gradeInt) ? gradeInt : 0).ToList()
                .OrderBy(gradeValues => gradeValues).Skip(3);

        //Execute
            double gradeAverage = gradesAsInt.Average();
            Console.WriteLine("#1) FINDING THE AVERAGE USING LINQ\n");
            Console.WriteLine("ORIGINAL LIST OF GRADES: " + gradesAsString);
            Console.WriteLine("GRADE AVERAGE (excluding the lowest three grades): " + gradeAverage);
        }
    }
}
