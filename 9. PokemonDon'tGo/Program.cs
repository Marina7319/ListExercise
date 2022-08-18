using System;
using System.Collections.Generic;
using System.Linq;
namespace _9._PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index;
            int currentLine;
            int sum = 0;
            while (sequence.Count != 0)
            {
                index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    currentLine = sequence[0];
                    sum += currentLine;
                    sequence[0] = sequence[sequence.Count - 1];
                }
                else if (index > sequence.Count - 1)
                {
                    currentLine = sequence[sequence.Count - 1];
                    sum += currentLine;
                    sequence[sequence.Count - 1] = sequence[0];
                }
                else
                {
                    currentLine = sequence[index];
                    sum += currentLine;
                    sequence.RemoveAt(index);
                }
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= currentLine)
                    {
                        sequence[i] += currentLine;
                    }
                    else
                    {
                        sequence[i] -= currentLine;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
