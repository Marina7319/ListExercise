using System;
using System.Linq;
using System.Collections.Generic;
namespace _7.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            List<string> numberList = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                string[] num = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < num.Length; j++)
                {
                    numberList.Add(num[j]);
                }
            }
            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}
