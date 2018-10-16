using System;
using System.Collections.Generic;

namespace dotnet_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // ----ARRAYS ---- //

            // array of ints 0-9
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};


            // string of names array
            string[] stringArray2 = new string[4] {"Tim", "Martin", "Niki", "Sara"};
            

            // array of  0-10 that alternates between true and false values, starting with true
            bool[] boolArray = new bool[10];
            for(int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    boolArray[i] = true;
                }
                else
                {
                    boolArray[i] = false;
                }
                // Console.WriteLine(boolArray[i]);
            }

            // -- List of flavors -- //
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Neopolitan");
            flavors.Add("Pistachio");
            flavors.Add("Phish Food");

            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            // ----Dictionary---- //
            Dictionary<string, string> User = new Dictionary<string, string>();
            User.Add("Elton", "Chocolate");
            User.Add("Leon", "Vanilla");
            User.Add("Daniel", "Neopolitan");
            User.Add("Keith", "Pistachio");
            User.Add("Nico", "Phish Food");

            foreach (KeyValuePair<string,string> entry in User)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
