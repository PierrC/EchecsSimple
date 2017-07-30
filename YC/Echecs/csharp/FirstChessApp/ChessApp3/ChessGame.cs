using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp3
{
    public class ChessGame
    {
        private Chessboard Board_;
        private PieceSet BlackPieces_;
        private PieceSet WhitePieces_;

        private Piece.PlayerColors CurrentPlayer_;
        private Piece SelectedPiece_;
        private List<Position> PossibleNewPositions_;


        public Chessboard Board { get => Board_; }
        public PieceSet BlackPieces { get => BlackPieces_; }
        public PieceSet WhitePieces { get => WhitePieces_; }
        public Piece SelectedPiece { get => SelectedPiece_; set => SelectedPiece_ = value; }

        public event EventHandler Changed;

        public ChessGame()
        {
            Board_ = new Chessboard();
            BlackPieces_ = new PieceSet(Piece.PlayerColors.BLACK);
            WhitePieces_ = new PieceSet(Piece.PlayerColors.WHITE);
            SetUpBoard(Board, WhitePieces);
            SetUpBoard(Board, BlackPieces);
            CurrentPlayer_ = Piece.PlayerColors.WHITE;
            SelectedPiece = null;
        }

        protected virtual void Notifychange()
        {
            if (Changed != null)
                Changed(this, new EventArgs());
        }

        public Boolean IsCurrentPlayerBlack()
        {
            return CurrentPlayer_ == Piece.PlayerColors.BLACK;
        }

        public void SwapCurrentPlayer()
        {
            CurrentPlayer_ = IsCurrentPlayerBlack() ? Piece.PlayerColors.WHITE : Piece.PlayerColors.BLACK;
        }

        public void OnSquareSelection(Position SelectedSquarePosition)
        {
            Square SelectedSquare = Board.GetSquare(SelectedSquarePosition);
            if (SelectedSquare != null)
            {
                Piece SPiece = SelectedSquare.Piece;
                if (SPiece != null)
                 {
                    if (SPiece.IsBlack == IsCurrentPlayerBlack())
                    {
                        SelectedPiece = SPiece;
                        //List<Position> Pos = GetPossiblePositions(SelectedPiece, Board);
                        Notifychange();
                    }
                    else
                    {
                        Console.WriteLine("You select a Piece from the side");
                        SelectedPiece = null;
                        //List<Position> Pos = null;
                        Notifychange();
                    }
                }
                else
                {
                    SelectedPiece = null;
                    //List<Position> Pos = null;
                    Notifychange();
                }
            }
        }

        private void SetUpBoard(Chessboard IBoard, PieceSet IPieces)
        {
            foreach (Piece P in IPieces)
            {
                Square square = Board.GetSquare(P.Position);
                square.Piece = P;
            }
        }
    }
}
