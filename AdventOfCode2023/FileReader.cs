using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023
{
    internal class FileReader
    {

        public static string[] ReadFileArray(string filePath, string day)
        {
            string fullFilePath = filePath + @"\day" + day + ".txt";

            string[] lines = System.IO.File.ReadAllLines(fullFilePath);

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents: ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            return lines;

        }

        public static List<string> ReadFileList(string filePath, string day)
        {
            string fullFilePath = filePath + @"\day" + day + ".txt";

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            //(@"C:\Users\Public\TestFolder\WriteLines2.txt")            
            string[] lines = System.IO.File.ReadAllLines(fullFilePath);
            List<string> newFileContents = new List<string>();


            for (int i = 0; i < lines.Length; i++)
            {
                newFileContents.Add(lines[i]);
            }

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents: ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //System.Console.ReadKey();

            return newFileContents;
        }

    }
}
