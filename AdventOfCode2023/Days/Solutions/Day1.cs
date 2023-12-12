using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdventOfCode2023.Days.Solutions
{
    internal class Day1
    {
        public static int PartOne(List<string> fileInput)
        {
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
            return 0;
        }
    }

}