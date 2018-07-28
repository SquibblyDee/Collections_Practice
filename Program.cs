using System;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to hold integer values 0 through 9
            Console.WriteLine("Array with values 0-9:");
            int[] arrNum0Through9 = {0,1,2,3,4,5,6,7,9};
            foreach(int num in arrNum0Through9)
            {
                Console.WriteLine("Number: {0}", num);
            }

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            Console.WriteLine("Array filled with names:");
            string[] arrNames = {"Tim", "Martin", "Nikki", "Sara"};
            foreach(string name in arrNames)
            {
                Console.WriteLine("Hi, my name is {0}", name);
            }

            // Create an array of length 10 that alternates between true and false values, starting with true
            Console.WriteLine("Array of alternating bools:");
            bool[] boolArray = new bool[10];
            bool value = true;
            for(int i=0; i<boolArray.Length; i++)
            {
                if(value==true)
                {
                    boolArray[i] = value;
                    value = false;
                }
                else
                {
                    boolArray[i] = value;
                    value = true;
                }
            }
            foreach(bool entry in boolArray)
            {
                Console.WriteLine("Our bool value {0}:", entry);
            }
        }
    }
}
