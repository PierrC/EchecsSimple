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


        public Chessboard Board { get => Board_; }
        public PieceSet BlackPieces { get => BlackPieces_; }
        public PieceSet WhitePieces { get => WhitePieces_; }
        public Piece SelectedPiece { get => SelectedPiece_; set => SelectedPiece_ = value; }

        public ChessGame()
        {
            Board_ = new Chessboard();
            BlackPieces_ = new PieceSet(Piece.PlayerColors.BLACK);
            WhitePieces_ = new PieceSet(Piece.PlayerColors.WHITE);
            CurrentPlayer_ = Piece.PlayerColors.WHITE;
            SelectedPiece = null;
        }

        public Boolean IsCurrentPlayerBlack()
        {
            return CurrentPlayer_ == Piece.PlayerColors.BLACK;
        }

        public void SwapCurrentPlayer()
        {
            CurrentPlayer_ = IsCurrentPlayerBlack() ? Piece.PlayerColors.WHITE : Piece.PlayerColors.BLACK;
        }
    }
}
