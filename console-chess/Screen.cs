﻿using board;
using board.Enum;
using console_chess.Chess;

namespace console_chess
{
    internal class Screen
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Lines; i++)
            {
                Console.Write(board.Lines - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    if (board.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }else
                    {
                        PrintPiece(board.Piece(i, j));
                    }
                    //Console.Write(board.Piece(i, j) + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < board.Columns; i++)
            {
                if(i == 0)
                {
                    Console.Write(' ');
                }
                char letter = (char)('a' + i);
                Console.Write($" {letter}");
            }
        }

        private static void PrintPiece(Piece piece)
        {
            if(piece.Color == Color.White)
            {
                Console.Write(piece);
            }else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }

        public static ChessPosition ReadChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new ChessPosition(column, line);
        }
    }
}
