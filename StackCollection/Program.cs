using System;
using System.Collections.Generic;
using System.Numerics;

namespace PriorityQueueExample
{
    class Priority
    {
        static void Main(string[] args)
        {

            Stack<string> players = new Stack<string>();


            players.Push("Chris");
            players.Push("James");
            players.Push("Mark");
            players.Push("Ethan");
            players.Push("Brad");

            if(players.Contains("Ethan"))
            {
                Console.WriteLine("Ethan is online");
            }
            else
            {
                Console.WriteLine("Ethan is offline");
            }
            
            players.Pop();

            Console.WriteLine($"There are {players.Count} players online.");


            Console.WriteLine("Players currently online:");
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
}