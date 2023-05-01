using board;
using board.Enum;

namespace console_chess.Chess
{
    internal class Tower : Piece
    {
        public Tower(Board board, Color color): base(board, color) { }

        public override string ToString()
        {
            return "T ";
        }
    }
}
