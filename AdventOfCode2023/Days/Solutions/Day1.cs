using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdventOfCode2023.Days.Solutions
{
    internal class Day1
    {
        public static int PartOne(List<string> fileInput)
        {
            Console.WriteLine("Part One");
            foreach (string line in fileInput)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            List<int> NumbersList = new List<int>();
            foreach (var line in fileInput)
            {
                string numbersOnly = "";

                foreach (char c in line)
                {
                    if (char.IsDigit(c))
                    {
                        numbersOnly += c;
                    }
                }

                // Get the first character
                char firstNumber = numbersOnly[0];

                // Get the last character
                char lastNumber = numbersOnly[numbersOnly.Length - 1];

                string finalNumberByLine = "" + firstNumber + lastNumber;
                int realNumber = Int32.Parse(finalNumberByLine);
                NumbersList.Add(realNumber);
            }

            int result = 0;
            foreach (var number in NumbersList)
            {
                result += number;
            }

            return result;
        }

        public static int PartTwo(List<string> fileInput)
        {            
            //Find all smushed numbers, written, and replace them with both separated
            Dictionary<string, string> smushedNumbers = new Dictionary<string, string>
            {
                {"oneight", "oneeight"}, 
                {"twone", "twoone"},
                {"threeight", "threeeight"},
                {"fiveight", "fiveeight"},
                {"sevenine", "sevennine"},
                {"eightwo", "eighttwo"},
                {"eighthree", "eightthree"}
            };

            List<string> newFileInput0 = new List<string>();
            string newLine = "";

            foreach (var line in fileInput)
            {
                newLine = line;
                foreach (var kvp in smushedNumbers)
                {
                    newLine = newLine.Replace(kvp.Key, kvp.Value);
                }
                newFileInput0.Add(newLine);
            }

            //String value to integer
            Dictionary<string, int> numberWords = new Dictionary<string, int>
            {
                {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4},
                {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9}
            };

            List<string> newFileInput = new List<string>();

            //Find all written numbers, and replace them with integer values
            foreach (var line in newFileInput0)
            {
                newLine = line;
                foreach (var kvp in numberWords)
                {
                    string pattern = $@"{kvp.Key}"; // word boundary regex pattern

                    MatchCollection matches = Regex.Matches(line, pattern, RegexOptions.IgnoreCase);

                    if (matches.Count > 0)
                    {
                        newLine = newLine.Replace(kvp.Key, kvp.Value.ToString());
                    }                    
                }
                newFileInput.Add(newLine);
            }

            return PartOne(newFileInput);
        }
    }

}