using System;

namespace Collections
{
    // reminder default type access is internal
    class Program
    {
        static void Main(string[] args)
        {
            // int num = 123;
            // random r = new Random();

            var num = 123;
            var r = new Random();
            // C# has "var for compile-time type interface
            //the compiler guesses the type of the variable based on what is to the right of the equals sign

            // use var when it is obvious to the reader what the type is, but not when it would make the code less self-documenting

            Arrays();
        }

        // reminder default member access is private
        static void Arrays()
        {
            // "int[]" is a type, it means array of int
            //this line declares and int array variable and creates a size 5 array filled with default value for int (0)
            int[] myNums = new int[5];
            // once an array has that size, it is that size forever

            // for each i from 0 up to but not including 5
            for (int i = 0; i < myNums.Length; i++)
            {
                // set the value to ith place
                myNums[i] = i * i;
                //print value
                Console.WriteLine(myNums[i]);
            }
            // the indexing in C# as in most laguage is 0-based
            // so in an array of 5 we have 0, 1, 2, 3, 4

            // for each thing in the collection
            foreach (var item in myNums)
            {
                // print it
                Console.WriteLine(item);
                //we cant modify it, though
            }

            Console.WriteLine("how many elements in the array? ");
            var count = int.Parse(Console.ReadLine());
            var array = new int[count];
            // we can set the length dynamically, it just cant be changed after that

            // we have array initilization syntax that looks like this
            var names = new[] { "Nick", "Fred", "Bill" };
            // the type is inferred (string), the length is infered (3)

            // we can put arrays inside arrays to get 2D and 3D etc data
        }
    }
}
