using board;
using board.Enum;

namespace console_chess.Chess
{
    internal class Tower : Piece
    {
        public Tower(Board board, Color color) : base(board, color) { }

        public override string ToString()
        {
            return "T ";
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
            // up
            position.SetValues(Position.Line - 1, Position.Column);
            while (Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }
                position.Line = position.Line - 1;
            }

            // down
            position.SetValues(Position.Line + 1, Position.Column);
            while (Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }
                position.Line = position.Line + 1;
            }


            // right
            position.SetValues(Position.Line, Position.Column + 1);
            while (Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }
                position.Column = position.Column + 1;
            }

            // left
            position.SetValues(Position.Line, Position.Column - 1);
            while (Board.PositionIsValid(position) && CanMove(position))
            {
                moviments[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }
                position.Column = position.Column - 1;
            }

            return moviments;
        }
    }
}
