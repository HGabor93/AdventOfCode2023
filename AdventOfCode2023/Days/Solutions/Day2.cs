using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023.Days.Solutions
{
    internal class Day2
    {
        public static int PartOne(List<string> fileInput) 
        { 
            List<int> possibleGameIDs = new List<int>();
            int sumOfPossibleGameIDs = 0;
            
            const string colorRed = "red";
            const string colorBlue = "blue";
            const string colorGreen = "green";

            //Loop
            foreach (var game in fileInput)
            {
                //Fist split => Game n: Set details
                string[] gameAndSets = game.Split(": ");
                int gameNumber = Int32.Parse(gameAndSets[0].Split(" ")[1]);

                //Each set's validation: true or false
                List<bool> validityOfSets = new List<bool>();

                //Split Sets
                string[] sets = gameAndSets[1].Split("; ");
                
                foreach (string set in sets)
                {                    
                    int redCubes = 0;
                    int greenCubes = 0;
                    int blueCubes = 0;                    

                    //Split to cubes
                    string[] setOfCubes = set.Split(", ");

                    foreach (var cubes in setOfCubes)
                    {
                        //Cube: Number Color
                        string[] oneColoredCubes = cubes.Split(" ");

                        //Different color count
                        switch (oneColoredCubes[1])
                        {
                            case colorRed:
                                redCubes = Int32.Parse(oneColoredCubes[0]);
                                break;

                            case colorGreen:
                                greenCubes = Int32.Parse(oneColoredCubes[0]);
                                break;

                            case colorBlue:
                                blueCubes = Int32.Parse(oneColoredCubes[0]);
                                break;
                        }
                    }

                    validityOfSets.Add(isValidSet(redCubes, greenCubes, blueCubes));
                    
                }
                int trueCount = validityOfSets.Count(b => b); // Count the number of 'true' values
                int falseCount = validityOfSets.Count(b => !b); // Count the number of 'false' values


                if (falseCount == 0)
                {
                    possibleGameIDs.Add(gameNumber);
                }                
            }


            sumOfPossibleGameIDs = possibleGameIDs.Sum(x => Convert.ToInt32(x));

            return sumOfPossibleGameIDs; 
        }

        public static int PartTwo(List<string> fileInput) 
        {            
            const string colorRed = "red";
            const string colorBlue = "blue";
            const string colorGreen = "green";

            int sumPower = 0;

            //Loop
            foreach (var game in fileInput)
            {
                //Fist split => Game n: Set details
                string[] gameAndSets = game.Split(": ");
                int gameNumber = Int32.Parse(gameAndSets[0].Split(" ")[1]);

                //Each set's validation: true or false
                List<int> redCubeNumbers = new List<int>();
                List<int> greenCubeNumbers = new List<int>();
                List<int> blueCubeNumbers = new List<int>();

                //Split Sets
                string[] sets = gameAndSets[1].Split("; ");

                foreach (string set in sets)
                {
                    int redCubes = 0;
                    int greenCubes = 0;
                    int blueCubes = 0;

                    //Split to cubes
                    string[] setOfCubes = set.Split(", ");

                    foreach (var cubes in setOfCubes)
                    {
                        //Cube: Number Color
                        string[] oneColoredCubes = cubes.Split(" ");

                        //Different color count
                        switch (oneColoredCubes[1])
                        {
                            case colorRed:
                                redCubes = Int32.Parse(oneColoredCubes[0]);
                                break;

                            case colorGreen:
                                greenCubes = Int32.Parse(oneColoredCubes[0]);
                                break;

                            case colorBlue:
                                blueCubes = Int32.Parse(oneColoredCubes[0]);
                                break;
                        }
                    }
                    //
                    redCubeNumbers.Add(redCubes);
                    greenCubeNumbers.Add(greenCubes);
                    blueCubeNumbers.Add(blueCubes);

                }
                //Per game
                                
                int closestMaxNumberRed = redCubeNumbers.Max();
                int closestMaxNumberGreen = greenCubeNumbers.Max();
                int closestMaxNumberBlue = blueCubeNumbers.Max();

                int gamePower = closestMaxNumberRed * closestMaxNumberGreen * closestMaxNumberBlue;
                sumPower += gamePower;
            }
                        
            return sumPower;
        }

        public static bool isValidSet(int redCubes, int greenCubes, int blueCubes)
        {
            //Rules
            const int redCubesMax = 12;
            const int greenCubesMax = 13;
            const int blueCubesMax = 14;

            if (redCubes <= redCubesMax && greenCubes <= greenCubesMax && blueCubes <= blueCubesMax)
            {
                return true;
            }
            
            return false;
        }
    }
}
