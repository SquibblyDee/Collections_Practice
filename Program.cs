using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to hold integer values 0 through 9
            Console.WriteLine("\n");
            Console.WriteLine("Array with values 0-9:");
            int[] arrNum0Through9 = {0,1,2,3,4,5,6,7,9};
            foreach(int num in arrNum0Through9)
            {
                Console.WriteLine("Number: {0}", num);
            }

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            Console.WriteLine("\n");
            Console.WriteLine("Array filled with names:");
            string[] arrNames = {"Tim", "Martin", "Nikki", "Sara"};
            foreach(string name in arrNames)
            {
                Console.WriteLine("Hi, my name is {0}", name);
            }

            // Create an array of length 10 that alternates between true and false values, starting with true
            Console.WriteLine("\n");
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

            // Create a list of ice cream flavors that holds at least 5 
            // different flavors (feel free to add more than 5!)
            Console.WriteLine("\n");
            Console.WriteLine("List of flavors:");
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Cookie Dough");
            flavors.Add("Mint Chocolate Chip");
            flavors.Add("Metropolitan");
            flavors.Add("Fudge Brownie");
            // Output the length of this list after building it
            Console.WriteLine("List length = {0}", flavors.Count);
            // Output the third flavor in the list, then remove this value
            Console.WriteLine("3rd flavor is: {0}", flavors[2]);
            flavors.RemoveAt(2);
            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine("List length after removal = {0}", flavors.Count);
            foreach(string flavor in flavors)
            {
                Console.WriteLine("Flavor {0}", flavor);
            }

            // Create a dictionary that will store both string keys as well as string values
            Console.WriteLine("\n");
            Console.WriteLine("Dictionary of User Info:");
            Dictionary<string,string> userInfo = new Dictionary<string,string>();
            // For each name in the array of names you made previously, 
            // add it as a new key in this dictionary with value null
            foreach(string name in arrNames)
            {
                userInfo.Add(name, "null");
            }
            // For each name key, select a random flavor from the flavor
            //  list above and store it as the value
            Random rand = new Random();
            foreach(KeyValuePair<string,string> entry in userInfo.ToList())
            {
                int randFlavor = rand.Next(0,6);
                userInfo[entry.Key] = flavors[randFlavor];
            }
            // Loop through the dictionary and print out each user's name 
            // and their associated ice cream flavor
            foreach(KeyValuePair<string,string> entry in userInfo)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

        }
    }
}
