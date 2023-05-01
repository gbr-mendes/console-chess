using board;
using board.Exceptions;
using board.Enum;
using console_chess.Chess;
using xadrez_console.Chess;

namespace console_chess
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ChessPosition pos = new ChessPosition('c',7);
            Console.WriteLine(pos.ToPosition());
        }
    }
}