using board.Exceptions;
namespace board
{
    internal class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[Lines, Columns];
        }

        public Piece Piece(int line, int column)
        {
            return Pieces[line, column];
        }

        public Piece Piece(Position position)
        {
            return Pieces[position.Line, position.Column];
        }

        public void InsertPiece(Piece piece, Position position)
        {
            if(FilledPosition(position))
            {
                throw new BoardException("Position already filled");
            }
            Pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        public Piece? RemovePiece(Position position)
        {
            Piece piece = Piece(position);
            if(piece == null)
            {
                return null;
            }
            piece.Position = null;
            Pieces[position.Line, position.Column] = null;
            return piece;
        }

        public bool FilledPosition(Position position)
        {
            ValidatePosition(position);
            return Piece(position) != null;
        }

        public bool PositionIsValid(Position position)
        {
            if (position.Line < 0 || position.Line >= Lines || position.Column < 0 || position.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if(!PositionIsValid(position))
            {
                throw new BoardException("Invalid position!");
            }
        }
    }
}
