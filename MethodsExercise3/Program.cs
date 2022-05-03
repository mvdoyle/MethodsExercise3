using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = null;

            int[] otherArray = new int[0];

            var userInput = "";
            int age;
            bool proceed;

            do
            {

                Console.WriteLine($"How old is the potential voter?");
                userInput = Console.ReadLine();
                proceed = int.TryParse(userInput, out age);

            } while (!proceed);


            OfVotingAge(age);


        }

        /// <summary>
        /// Write a method
        /// that takes a number from the user
        /// and returns an array with that many indexes.
        /// The values shall be random numbers.
        ///
        /// 
        /// </summary>
        /// <returns></returns>

        public static int[] CreateRandoArray()
        {
            Console.WriteLine($"How many items would you like in your array?");

            var userInput = int.Parse(Console.ReadLine());

            var newArray = new int[userInput];

            for (int i = 0; i < newArray.Length; i++)
            {
                var random = new Random();

                newArray[i] = random.Next(1, 3000);
            }

            return newArray;
        }



        /// <summary>
        /// Write a method to read the age of a candidate
        /// and determine whether they can vote.
        /// Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        ///
        /// pseudo code:
        /// the way I'll go about this is
        ///  if age >= 18 - yes they can vote
        ///
        /// converted pseudo into actual code
        /// if(age >= 18)
        /// {
        ///   return true;</summary>
        /// }<param name="age"></param>
        /// <returns></returns>

        public static bool OfVotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"Yes they are of voting age");
                return true;
            }
            else
            {
                Console.WriteLine($"Too young to vote by {18 - age} years");
                return false;
            }
        }

        //Write a method
        //to check whether a given number is even or odd.

        //where do i write this method?
        //outside the main method and inside the scope of the Program class
        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"yo that's even");
            }
            else
            {
                Console.WriteLine($"definitely odd");
            }

        }

        /// <summary>
        /// Write a method to check whether a given number is positive or negative.
        /// </summary>
        /// <param name="num1"></param>
        /// <returns></returns>
        //
        //need to write a method, but how?
        //access modifier
        //static keyword
        //return type
        //method name
        //parameters
        //scope
        public static bool IsPositive(int num1)
        {
            //need to determine if its negative or positive
            if (num1 > 0)
            {
                return true;
            }

            return false;

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time.

        //step 1: where do I write this method?
        // outside the scope of the main method - but inside the scope of the Progam class

        //step 2: How do I define a method?
        //2a: access modifier
        //2b: static keyword
        //2c: return type - void: lack of a return type
        //2d: name of method
        //2e: parameters - and do we need any?
        //2f: scope - this is where the method will do what our end goal is

        public static void UpByThrees()
        {
            //i need code execute a certain number of times - how can i do this?
            // with a for loop
            //how do I a write a for loop
            for (int i = 3; i <= 999; i += 3)
            {
                //what will i do in the scope of the for loop?
                //console writeline
                Console.WriteLine(i);
            }
        }


        //step 1: find out where I can write my method
        //right here
        //if you dont know - try it somewhere - come back to this later

        //step 2: find out how to define the method
        //step 2a: remember the pieces that make a method
        //1b.access modifier
        //public
        //2b.static keyword
        //static
        //3b.return type
        //ask myself - what is the result of this method?  Lets find a type for that result
        //bool - true or false: are these 2 numbers the same? (yes or no)
        //4b.name of the method
        //AreTwoNumbersTheSame
        //5b.parameters
        //i know there will be 2 parameters
        //i know that they will be integers
        //I just need to name them - they can be named whatever I want
        //int num1, int num2
        //6b.scope
        //starts with curly braces / ends with curly braces
        //this is what my method will do!
        //this is where the result will occur - bool value (return type)

        public static bool AreTwoNumbersTheSame(int num1, int num2)
        {
            //we want to compare the 2 numbers - how do we do that?
            //num1 != num2
            //found our way of comparing to numbers but now we need a structure to use that comparison
            if (num1 != num2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //Write a method to check if an integer (from the user) is in the range -10 to 10
        public static bool IsTenRange(int num)
        {
            if (num <= 10 && num >= -10)
            {
                return true;
            }

            return false;
        }

    }
}
