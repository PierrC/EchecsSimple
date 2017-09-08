using ChessApp.View_Engin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Game_Engin
{
    public class ChessGame
    {
        ChessBoard aChessBoard;
        ChessBoardView aChessBoardView;
        PieceManipulator aPieceManipulator;
        

        public ChessGame()
        {
            aChessBoard = new ChessBoard();
            aPieceManipulator = new PieceManipulator();
            aChessBoardView = new ChessBoardView(aChessBoard, aPieceManipulator, Brushes.White, Brushes.Black);

            NewGame();
        }
        
        public void NewGame()
        {
            aChessBoard.SetPieces();
            aPieceManipulator.SetCurrentColor(Piece.Color.WHITE);
        }

        public void SetConvertPiece(int i)
        {
            aPieceManipulator.SetPromotingPiece(i);
        }

        public void ManipulatePiece(BoardPosition bp)
        {
            if ((bp.X >= 0) & (bp.X < 8) & (bp.Y >= 0) & (bp.Y < 8))
            {
                aPieceManipulator.ManipulatingPiece(bp, aChessBoard);
            }
        }

        public void DiscardPiece()
        {
            aPieceManipulator.Deselelect();
        }

        public void DrawGame(Graphics g)
        {
            aChessBoardView.DrawGame(g);
        }

        public String SelectedPieceString()
        {
            return aPieceManipulator.SelectedPieceToString(aChessBoard);
        }

        public Boolean checkWhiteKing()
        {
            return aChessBoard.CheckWhiteKing();
        }

        public Boolean checkBlackKing()
        {
            return aChessBoard.CheckBlackKing();
        }

    }
}
