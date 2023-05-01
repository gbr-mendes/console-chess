﻿using board;
using board.Exceptions;
using board.Enum;
using console_chess.Chess;

namespace console_chess
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                ChessMate mate = new ChessMate();
                while (!mate.Finished)
                {
                    Console.Clear();
                    Screen.PrintBoard(mate.Board);
                    Console.Write("\nOrigin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();
                    Console.Write("Destination: ");
                    Position destination = Screen.ReadChessPosition().ToPosition();
                    mate.MovePiece(origin, destination);
                }
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}