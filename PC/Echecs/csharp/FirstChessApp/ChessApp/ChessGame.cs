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
            aChessBoardView = new ChessBoardView(aChessBoard, Brushes.White, Brushes.Black);

            NewGame();
        }
        
        public void SetConvertPiece(int i)
        {
            aPieceManipulator.SetConvertPiece(i);
        }

        public void ManipulatePiece(BoardPosition bp)
        {
            aPieceManipulator.ManipulatingPiece(bp, aChessBoard);
        }

        public void DiscardPiece()
        {
            aPieceManipulator.Deselelect();
        }

        private void NewGame()
        {
            aChessBoard.SetPieces();
        }

        public void DrawGame(Graphics g)
        {
            aChessBoardView.DrawGame(g);
        }

        public String SelectedPieceString()
        {
            return aPieceManipulator.SelectedPieceToString(aChessBoard);
        }


    }
}
