using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023.Days.Solutions
{
    internal class Day6
    {

        public static int PartOne(List<string> fileInput)
        {            
            //Input data
            List<int> time = new List<int>();
            List<int> distance = new List<int>();

            List<int> winningOpportuinities = new List<int>();

            //Initialize
            string[] timeSplit = fileInput[0].Split(' ');
            string[] distanceSplit = fileInput[1].Split(' ');

            for (int i = 0; i < timeSplit.Length; i++)
            {
                time.Add(Int32.Parse(timeSplit[i]));
                distance.Add(Int32.Parse(distanceSplit[i]));
            }
                        
            //Logic
            //foreach (var gameLasted in time)
            for (int i = 0; i < time.Count; i++)
            {
                //Times, when we win
                List<int> winnigSituation = new List<int>();
                for (int j = 0; j < time[i]; j++)
                {
                    int actualTimeHold = j;
                    int actualDistanceTaken = (time[i] - j) * j;

                    if (actualDistanceTaken > distance[i])
                    {
                        winnigSituation.Add(actualDistanceTaken);
                    }
                }

                int winsPerGame = winnigSituation.Count;
                winningOpportuinities.Add(winsPerGame);
            }

            int recordBeaten = 1;
            foreach (var number in winningOpportuinities)
            {
                recordBeaten *= number;
            }

            return recordBeaten;
        }

        public static long PartTwo(List<string> fileInput)
        {
            //Input data
            long time = Int64.Parse(fileInput[0]);
            long distance = Int64.Parse(fileInput[1]);


            //Logic
            long recordBeaten = 0;
            for (long i = 0; i < time; i++)
            {
                double actualDistanceTaken = (time - i) * i;

                if (actualDistanceTaken > distance)
                {
                    recordBeaten = time - i;
                    break;
                }
            }
            long winFrom = (time - recordBeaten);
            long countBeaten = time - 2 * winFrom + 1;
            Console.WriteLine(countBeaten);

            return countBeaten;
        }

    }
}
