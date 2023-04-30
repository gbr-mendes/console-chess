using board;
using board.Exceptions;
using board.Enum;
using console_chess.Xadrez;

namespace console_chess
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           try
            {
                Board board = new Board(8, 8);
                board.InsertPiece(new Tower(board, Color.Black), new Position(0, 0));
                board.InsertPiece(new Tower(board, Color.Black), new Position(1, 2));
                board.InsertPiece(new King(board, Color.Black), new Position(0, 2));
                Screen.PrintBoard(board);
            }catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}