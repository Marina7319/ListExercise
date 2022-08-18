using System;
using System.Collections.Generic;
using System.Linq;
namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                }
                firstPlayer.Remove(firstPlayer[0]);
                secondPlayer.Remove(secondPlayer[0]);
                int sumSecondPlayer = secondPlayer.Sum();
                int sumFirstPlayer = firstPlayer.Sum();
                if (secondPlayer.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {sumFirstPlayer - sumSecondPlayer}");
                    break;
                }
                else if (firstPlayer.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {sumSecondPlayer - sumFirstPlayer}");
                    break;
                }
            }
        }
    }
}
