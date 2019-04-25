using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionTesting.Library
{
    public class StringCollection : GenericCollection<string>
    {
       // public StringCollection() : base(new List<string> { "a" })
        public StringCollection() : base() // calls zero parametor ctor of parent
        {
            // 1. constructors are not inherited
            // 2. every child-class constructor has to call exactly one parent class constructor.
            // by default it tries to call a zero parameter constructor first
        }

        public StringCollection(IEnumerable<string> coll) : base(coll)
        {
        }

        public void Add(string s)
        {
            List.Add(s);
        }
        public void Remove(string s)
        {
            List.Remove(s);
        }

        public bool isAlphabaticOrder()
        {
            // length of the string  
            int n = List.Count;

            // create a character array  
            // of the length of the string  
            string[] s = new string[n];

            // assign the string  
            // to character array  
            for (int i = 0; i < n; i++)
            {
                s[i] = List[i];
            }

            // sort the character array  
            Array.Sort(s);

            // check if the character array  
            // is equal to the string or not  
            for (int i = 0; i < n; i++)
            {
                if (s[i] != List[i])
                {
                    return false;
                }
            }

            return true;
        }
        public void Clear()
        {
            List.Clear();
        }

        public void Reverse()
        {
            List.Reverse();
        }

        public bool isStringUpper()
        {
            // return List.All(s => s.All(c => char.IsUpper(c)));
            return List.All(s => s.All(char.IsUpper));
        }

        public string GetLongestString()
        {
            if (List.Count == 0)
            {
                return null;
            }
            var maxLength = 0;
            string max = null;
            foreach (var item in List)
            {
                if (item?.Length > maxLength)
                {
                    maxLength = item.Length;
                    max = item;
                }
            }
            return max;
        }

        public static void OtherLINQ()
        {
            // ALL
            // Any (true if ANY in collection is true for the condition)
            // First
            // Max
            // Average
            // Where

            // one of the most important LINQ methods is Select
            // it maps values to new values
            var firstLetter = List.Select(s => s[0]);

            // we've been using the "method syntax"
            // there is a query syntax 

            var firstLetters2 = from x in List
                                 where x != null
                                select x[0];
                               

            // LINQ stands for Language Integrated Query
            // 
        }

        public string GetLonestStringLinQ()
        {
            if (List.Count == 0)
            {
                return null;
            }
            // using LINQ, we can eliminate a lote of boilerplate for-loop tyep code.
            // Max and FirstofDefault are LINQ extension methods
            // they take functions/delegates as arguments
            // usually we use lambda expresions

            //                           a func mapping each element to some number
            //                           vvvvvvvvvv
            var maxLength = List.Max(x => x.Length);

            return List.First(x => x.Length == maxLength);
        }


        // we can override most any operator: +, -, +=, ||, &&, ==
        public string this[int index]
        {
            get => List[index];
            set { List[index] = value; }
        }

       
    }  
}
