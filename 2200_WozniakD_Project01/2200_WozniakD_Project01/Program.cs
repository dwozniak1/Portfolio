﻿///Name: Delaney Wozniak
///Class: INFO 2200
///Section: X01
///Professor: Sharp
///Date: 01/23/2024
///Project #: 01
///By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. 
///I attest that no part of this assignment, in whole or in part, was generated by Generative Artificial Intelligence (e.g., ChatGPT, Bard, Copilot, etc.) nor obtained from a paid solution service (e.g., Chegg, Course Hero, Bartleby, etc.). 
///I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_WozniakD_Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Delaney's College Search App"); //display welcome message
            Console.WriteLine(); //empty line

            Console.Write("Please enter a college and I will return the city. (x to exit, random to get a Random College/City): "); //display prompt
            string userinput = Console.ReadLine(); //get user input

            Dictionary<string, string> collegeDict = new Dictionary<string, string>(); //new dictionary

            StreamReader reader = new StreamReader("colleges.txt"); //read colleges text file
            while (!reader.EndOfStream) //while loop to add text file to dictionary
            {
                string line = reader.ReadLine(); //read all lines of text file
                string[] tempcolleges = line.Split(','); //
                string college = tempcolleges[0]; //add colleges to dictionary
                string city = tempcolleges[1]; //add cities to dictionary
                collegeDict.Add(college.ToUpper(), city); //add all colleges and cities to dictionary
            }

            reader.Close(); //stop reading text file

            //while loop to search for users input in dictionary
            while (userinput != "x")
            {
                if(collegeDict.TryGetValue(userinput.ToUpper(), out string city))
                {
                    Console.WriteLine(); //empty line
                    Console.WriteLine($"College: {userinput}"); //display user input college
                    Console.WriteLine($"City: {city}"); //display city
                    Console.WriteLine(); //empty line
                }
                Random rand = new Random(); //random class
                int totalColleges = rand.Next(collegeDict.Count); //count method to fetch size of dictionary
                string randCollege = collegeDict.ElementAt(totalColleges).Key; //retrieve a random key
                if (collegeDict.TryGetValue(randCollege, out string randcity))
                {
                    Console.WriteLine($"Random College: {randCollege},{randcity}"); //display college and city
                }
                else
                {
                    Console.WriteLine($"Could not find {userinput} in the database"); //display error message
                    userinput = Console.ReadLine(); //read user input
                }
            }
        }
    }
}