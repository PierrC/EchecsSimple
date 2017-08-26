using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Game_Engin
{
    class PieceManipulator
    {

        Boolean isSelectingPiece;
        BoardPosition selectedBoardPosition;



        public PieceManipulator()
        {
            isSelectingPiece = false;
            selectedBoardPosition = new BoardPosition();
            selectedBoardPosition.Invalid();
            ReplacePieceType = Piece.PieceType.QUEEN;
        }

        private void MovePiece(BoardPosition bp, ChessBoard aBoard)
        {
            aBoard.MovesPiece(selectedBoardPosition, bp);

            if (aBoard.GetBoard()[bp.X, bp.Y].GetPiece().GetPieceType().Equals(Piece.PieceType.PAWN))
            {
                if ((bp.Y == 0) || (bp.Y == 7))
                {
                    ReplacePawn(bp, aBoard);
                }
            }
        }
        
        public void ManipulatingPiece(BoardPosition bp, ChessBoard aBoard)
        {
            if (!isSelectingPiece)
            {
                if (aBoard.GetBoard()[bp.X, bp.Y].HasPiece())
                {
                    SelectPiece(bp, aBoard);
                    Console.WriteLine("Piece " + aBoard.GetBoard()[bp.X, bp.Y].GetPiece().ToString() + " is selected");

                }
            }
            else if (!(bp.IsSamePosition(selectedBoardPosition)))
            {
                MovePiece(bp, aBoard);
                Deselelect();
            }
        }
        private void SelectPiece(BoardPosition bp, ChessBoard aBoard)
        {
            if (aBoard.GetBoard()[bp.X, bp.Y].HasPiece())
            {
                selectedBoardPosition = bp;
                isSelectingPiece = true;
            }
        }
        
        public void Deselelect()
        {
            isSelectingPiece = false;
            selectedBoardPosition = null;
        }

        public String SelectedPieceToString(ChessBoard aBoard)
        {
            if(aBoard.GetBoard()[selectedBoardPosition.X, selectedBoardPosition.Y].HasPiece())
            {
                return aBoard.GetBoard()[selectedBoardPosition.X, selectedBoardPosition.Y].GetPiece().ToString();
            }
            return " ";
        }




        Piece.PieceType ReplacePieceType;
        private void ReplacePawn(BoardPosition bp, ChessBoard aBoard)
        {
            Piece replacement;
            if (bp.Y == 0)
            {
                replacement = new Piece(ReplacePieceType, Piece.Color.WHITE);
            }
            else
            {
                replacement = new Piece(ReplacePieceType, Piece.Color.BLACK);
            }
            aBoard.GetBoard()[bp.X, bp.Y].SetPiece(replacement);
            
        }

        public void SetConvertPiece(int i)
        {
            switch (i)
            {
                case 0:
                    ReplacePieceType = Piece.PieceType.BISHOP;
                    break;
                case 1:
                    ReplacePieceType = Piece.PieceType.KNIGHT;
                    break;
                case 2:
                    ReplacePieceType = Piece.PieceType.QUEEN;
                    break;
                case 3:
                    ReplacePieceType = Piece.PieceType.ROOK;
                    break;
                default:
                    ReplacePieceType = Piece.PieceType.QUEEN;
                    break;
            }
        }



    }
}
