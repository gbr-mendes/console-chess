using board;
using board.Enum;

namespace console_chess.Chess
{
    internal class King : Piece
    {
        public King(Board board, Color color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "R ";
        }
    }
}
