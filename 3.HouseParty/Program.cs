using System;
using System.Collections.Generic;
using System.Linq;
namespace _3.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var listOfNames = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                string currName = command[0];
                if (listOfNames.Contains(currName) && command[2] == "going!")
                {
                    Console.WriteLine($"{currName} is already in the list!");
                }
                else if (listOfNames.Contains(currName) && command[2] == "not")
                {
                    listOfNames.Remove(currName);
                }
                else if (!listOfNames.Contains(currName) && command[2] == "not")
                {
                    Console.WriteLine($"{currName} is not in the list!");
                }
                else if (command[2] == "going!")
                {
                    listOfNames.Add(currName);
                }
            }
            foreach (string currName in listOfNames)
            {
                Console.WriteLine(string.Join(" ", currName));
            }
        }
    }
}
