using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int piecesCount = widht * height;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{piecesCount} pieces are left.");
                    break;  
                }

                int piecesToTake = int.Parse(command);
                if (piecesToTake > piecesCount)
                {
                    Console.WriteLine($"No more cake left! You need {piecesToTake - piecesCount} pieces more.");
                    break;
                }
                piecesCount -= piecesToTake;
                if (piecesCount == 0)
                {
                    Console.WriteLine($"{piecesCount} pieces are left.");
                    break;
                }
            }
        }
    }
}
