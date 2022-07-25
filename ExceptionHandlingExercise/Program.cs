using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str
            var arr = new char[] { 'A', 'b', 'C', '1', '2', '3', '4', '5', '6' };
            var numbers = new List<int>();
            string str = "";
            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            //foreach(var i in arr)  //didn't need this
            //{
            //    int.Parse(i.ToString());
            //}


            //TODO START HERE:
            
            // Make a foreach loop to iterate through your character array
            foreach (var i in arr)
            {
                // Now create a try catch
                try
                {
                    // Inside your try block
                    // set your string variable to each array element in your char[] to .ToString()
                    // Now, using int.Parse, parse your string variable and store in an int variable
                    // Then add each int to your list

                    str = i.ToString();
                    int whatever = int.Parse(str);
                    numbers.Add(whatever);

                    //int whatever = int.Parse(i.ToString());
                    //numbers.Add(whatever);
                }
                catch (Exception e)
                {

                    Console.WriteLine($"\nUnable to Parse '{i}'");
                    Console.WriteLine($"{e.Message}\n******");
                }
            }



            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection



            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
