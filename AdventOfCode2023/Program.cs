﻿using AdventOfCode2023.Days.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Development\AdventOfCode2023\AdventOfCode2023\Days\Tasks";
            //System.Console.ReadKey();
            string currentDay = "1";
            string part = "2";

            //string[] fileContent = FileReader.ReadFileArray(filePath, currentDay, part);
            //List<string> fileContentList = FileReader.ReadFileList(filePath, currentDay);

            //Console.WriteLine(fileContentList);
            switch (currentDay)
            {
                case "1":
                    if (part == "0")
                    {
                        //Day1 Part0
                        //Console.WriteLine(Day1.PartOne(FileReader.ReadFileList(filePath, currentDay, part)));
                        Console.WriteLine(Day1.PartTwo(FileReader.ReadFileList(filePath, currentDay, part)));
                    }
                    else if (part == "1")
                    {
                        //Day1 Part1
                        Console.WriteLine(Day1.PartOne(FileReader.ReadFileList(filePath, currentDay)));
                    }
                    else
                    {
                        //Day1 Part2
                        Console.WriteLine(Day1.PartTwo(FileReader.ReadFileList(filePath, currentDay)));
                    }
                    break;
                case "2":
                    if (part == "0")
                    {
                        //Day2 Part0
                        //Console.WriteLine(Day2.PartOne(fileContent));
                        //Console.WriteLine(Day2.PartTwo(FileReader.ReadFileArray(filePath, currentDay, part)));
                    }
                    else if (part == "1")
                    {
                        //Day2 Part1
                        Console.WriteLine(Day2.PartOne(FileReader.ReadFileList(filePath, currentDay)));
                    }
                    else
                    {
                        //Day2 Part2
                        Console.WriteLine(Day2.PartTwo(FileReader.ReadFileList(filePath, currentDay)));
                    }
                    break;
                case "3":
                    if (part == "0")
                    {
                        //Day3 Part0
                        Console.WriteLine(Day3.PartOne(FileReader.ReadFileList(filePath, currentDay, part)));
                    }
                    else if (part == "1")
                    {
                        //Day3 Part1
                        //Console.WriteLine(Day3.PartOne(FileReader.ReadFileList(filePath, currentDay)));
                    }
                    else
                    {
                        //Day3 Part2
                        //Console.WriteLine(Day3.PartTwo(FileReader.ReadFileList(filePath, currentDay)));
                    }
                    break;
                case "6":
                    if (part == "0")
                    {
                        //Day2 Part0
                        Console.WriteLine(Day6.PartOne(FileReader.ReadFileList(filePath, currentDay, part)));
                    }
                    else if (part == "1")
                    {
                        //Day2 Part1
                        Console.WriteLine(Day6.PartOne(FileReader.ReadFileList(filePath, currentDay)));
                    }
                    else
                    {
                        //Day2 Part2
                        Console.WriteLine(Day6.PartTwo(FileReader.ReadFileList(filePath, currentDay)));
                    }
                    break;
            }

            System.Console.ReadKey();
        }
    }
}