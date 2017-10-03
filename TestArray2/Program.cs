using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Numbers = { 1, 2, 3, 4, 5 }; // initalizes an array of integers
            //char[] Vowels = { 'a', 'e', 'i', 'o', 'u' }; // initializes  


            // read the grades from the user

            // find the average of the grades
            // average = to sum/size

            Console.WriteLine("How many students do you have?");
            int size = int.Parse(Console.ReadLine()); // reads amount of students

            double[] StudentGrades = new double[size]; // starts array

            for (int i = 0; i < StudentGrades.Length; i++) // for loop to read the grades from the user
            {
                Console.WriteLine("Please enter grade for student No."+(i+1)); // prompts user for grade
                StudentGrades[i] = double.Parse(Console.ReadLine()); // takes numbers which are double and parsed them to a string 
                // and assigns them to student grades, now theyre stored in memory 

            }

            double Sum = 0; //create Sum variable
            double Avg = 0; // create average variable

            for (int i = 0; i < StudentGrades.Length; i++) // for statement to get average
            {
                Sum = Sum + StudentGrades[i]; // assigns students grades to sum

            }

            Avg = Sum / size; // divides sum of grade by number of students to get avg
            // creates avg outside of loop to stop it from looping

            Console.WriteLine($"the average is equal to {Avg}"); // finds the average of the grades.. also using dollar 
            // sign to include variables into a string





        }
    }
}
