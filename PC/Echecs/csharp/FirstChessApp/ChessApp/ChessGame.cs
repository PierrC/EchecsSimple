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
        
        private void NewGame()
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

        public Boolean CheckWhiteKing()
        {
            Piece whiteKing = new Piece(Piece.PieceType.KING, Piece.Color.WHITE);
            for(int i = 0; i < aChessBoard.GetBoard().Length; i++)
            {
                for (int j = 0; j < aChessBoard.GetBoard().Length; j++)
                {
                    if (aChessBoard.GetBoard()[i, j].HasPiece())
                    {
                        if (aChessBoard.GetBoard()[i, j].GetPiece().GetPieceType().Equals(whiteKing))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public Boolean CheckBlackKing()
        {
            Piece blackKing = new Piece(Piece.PieceType.KING, Piece.Color.BLACK);
            for (int i = 0; i < aChessBoard.GetBoard().Length; i++)
            {
                for (int j = 0; j < aChessBoard.GetBoard().Length; j++)
                {
                    if (aChessBoard.GetBoard()[i, j].HasPiece())
                    {
                        if (aChessBoard.GetBoard()[i, j].GetPiece().GetPieceType().Equals(blackKing))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }
}
