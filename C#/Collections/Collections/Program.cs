using System;
using System.Collections;
using System.Collections.Generic;

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
            Lists();
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

            // we can put arrays inside arrays to get 2D and 3D etc data. 
            // "jagged arrays"

            int[][] twoD = new int[3][];
            twoD[0] = new int[4];
            twoD[1] = new[] { 1, 6, 3, 6 };
            twoD[2] = new int[4];

            //access the first row and second column
            var x = twoD[0][1];

            // that's one wy to get 2d, 3d, etc
            // the other is called multidimensional array

            int[,] twoDMulti = new int[4, 5]; //4 by 5
            twoDMulti[2, 3] = 5; // set 3rd row, 4th column to 5

            // however we usually avoid arrays unless there is a performance need.

        }

        static void Lists()
        {
            // first, we had "non-generic" list, called ArrayList
            ArrayList numList = new ArrayList();
            // this has a changeable length, starting at size 0
            // technically, it is a list of "object" type.
            numList.Add(2);
            numList.Add(5);
            numList.Add(8);

            numList.Remove(8);

            //var num = numList[0];
            // var twice = num + num; not allowed because num is object type, not integer type

            int num = (int)numList[0];  //this is called casting, it attempts to convert whatever is to the right to the given type. might fail at runtime if it cant convert
            var twice = num + num;


            string s = (string)numList[1]; //will throw invalid cast extraction
            string s2 = ((int)numList[1]).ToString(); // "3"
            string theNumberThree = 3.ToString();

            // implicit and explicit casting
            double d = 4; // C# knows that i cant lose any information going from int to double, so it does it automatically

            // int n = d; does not work because it could lose data going from double to int
            int n = (int)d; // casting it as int is required to convert from double to int

            // for objects made from classes, you can cast implicitly from child types to parent types
            // object is parent class of random
            object o = new Random(); //implicit casting, otherwise known as upcasting. all upcasting is implicit

            Random R = (Random)o; // downcasting is explicit because at runtime "o" might not really be a Random

            // generic list
            // with generics, we can write code for many different types and when we need them, we'll decide what type they need to b
            var genericIntList = new List<int>();

            genericIntList.Add(3);

            var value = genericIntList[0];
            //list class can make any list instances, each of which have its own type that it requires

            List<List<string>> twoDStringList = new List<List<string>>
            {
                new List<string> {"1", "3", "5" },
                new List<string> { "as", "2", "ggg"}
            };
            // just like for arrays, we have a "initialization syntax" for lists, that winds up calling the Add method under the hood

            //list class can make many lists instances each of which might have its own type that it requires.


        }
        static void OtherCollections()
        {
            // we have some other classes
            var set = new HashSet<string> { "abc", "ab", "ab" };
            set.Add("221df"); // if that strig was already in the hash set, nothing happens
            // this is based on the mathmatical idea of "set". no duplicates allowed/duplicates ignored
            // NO oreder

            var number = set.Count; // 3 because ab is a duplicate

            foreach (var item in set)
            {
                // no guarantees about what order they will come out in
            }

            // we have "map" or "dictionary"
            var numberOfTimesSeenWord = new Dictionary<string, int>();
            numberOfTimesSeenWord["food"] = 1;
            numberOfTimesSeenWord["pc"] = 3;

            // a dictionary will store some value, for each key

            // in the same way that in a list, each index from 0 to total has some value...
            // in dictionary, each key that you insert at, will have one value at that spot
            // both hashset and dictionary are implemented with hashtables

            // this means that searching through them for one thing is very cheap and fast.

            var List = new List<int> { 3, 4, 6, 2, 6 };
            var newSet = new HashSet<int>(List);
            // the set doesn't _contain_ the list,
            // it gets its initial values from the list.
            var count = newSet.Count; // 4.

        }
    }
}
