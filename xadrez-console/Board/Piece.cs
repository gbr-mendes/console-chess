﻿using board.Enum;

namespace board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QtyMoviments { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Position position, Board board, Color color)
        {
            Position = position;
            Board = board;
            Color = color;
        }
    }
}