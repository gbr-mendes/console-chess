using Board;
using System;


namespace xadrez_console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Position P;
            P = new Position(3, 4);
            Console.WriteLine($"Posição: {P}");
        }
    }
}