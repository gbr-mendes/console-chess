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

        private bool CanMove(Position position)
        {
            Piece? piece = Board.Piece(position);
            return piece == null || piece.Color != Color;
        }

        public override bool[,] PossibleMoviments()
        {
            bool[,] moviments = new bool[Board.Lines, Board.Columns];
            Position position = new Position(0, 0);
            // N
            position.SetValues(Position.Line - 1, Position.Column);
            if(Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
            }
            // NE
            position.SetValues(Position.Line - 1, Position.Column + 1);
            if (Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
            }
            // E
            position.SetValues(Position.Line, Position.Column + 1);
            if (Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
            }
            // SE
            position.SetValues(Position.Line + 1, Position.Column + 1);
            if (Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
            }
            // S
            position.SetValues(Position.Line + 1, Position.Column);
            if (Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
            }
            // SW
            position.SetValues(Position.Line + 1, Position.Column - 1);
            if (Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
            }
            // W
            position.SetValues(Position.Line, Position.Column - 1);
            if (Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
            }

            // NW
            position.SetValues(Position.Line - 1, Position.Column - 1);
            if (Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
            }
            return moviments;
        }
    }
}
