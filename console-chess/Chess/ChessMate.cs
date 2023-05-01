using board;
using board.Enum;

namespace console_chess.Chess
{
    internal class ChessMate
    {
        public Board Board { get; private set; }
        private int Play { get; set; }
        private Color Player { get; set; }
        public bool Finished { get; private set; }

        public ChessMate()
        {
            Board = new Board(8, 8);
            Play = 1;
            Player = Color.White;
            Finished = false;
            PutPieces();
        }

        public void MovePiece(Position origin, Position destination)
        {
            Piece? piece = Board.RemovePiece(origin);
            if (piece != null)
            {
                piece.IncreaseMoviments();
                Piece? capturedPiece = Board.RemovePiece(destination);
                Board.InsertPiece(piece, destination);
            }
        }

        private void PutPieces()
        {
            // white
            Board.InsertPiece(new Tower(Board, Color.White), new ChessPosition('a', 1).ToPosition());
            Board.InsertPiece(new Tower(Board, Color.White), new ChessPosition('h', 1).ToPosition());
            Board.InsertPiece(new King(Board, Color.White), new ChessPosition('e', 1).ToPosition());

            // black
            Board.InsertPiece(new Tower(Board, Color.Black), new ChessPosition('a', 8).ToPosition());
            Board.InsertPiece(new Tower(Board, Color.Black), new ChessPosition('h', 8).ToPosition());
            Board.InsertPiece(new King(Board, Color.Black), new ChessPosition('e', 8).ToPosition());
        }
    }
}
