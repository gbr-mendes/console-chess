﻿using board.Enum;

namespace board
{
    internal abstract class Piece
    {
        public Position? Position { get; set; }
        public Color Color { get; protected set; }
        public int QtyMoviments { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            Board = board;
            Color = color;
        }

        public void IncreaseMoviments()
        {
            QtyMoviments++;
        }

        public abstract bool[,] PossibleMoviments();
    }
}
