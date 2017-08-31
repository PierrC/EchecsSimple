using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Game_Engin
{

    public class PieceManipulator
    {
        Boolean isSelectingPiece;
        BoardPosition selectedBoardPosition;
        PromotionManipulator aPromotionManipulator;
        List<BoardPosition> listOfMoves;

        Piece.Color aCurrentColor;

        public PieceManipulator()
        {
            aPromotionManipulator = new PromotionManipulator();
            isSelectingPiece = false;
            selectedBoardPosition = new BoardPosition();
            aCurrentColor = Piece.Color.WHITE;
            selectedBoardPosition.Invalid();
            listOfMoves = null;
        }

        private void MovePiece(BoardPosition bp, ChessBoard aBoard)
        {
            aBoard.MovesPiece(selectedBoardPosition, bp);
            aBoard.GetBoard()[bp.X, bp.Y].GetPiece().IsMoved();
            if (aBoard.GetBoard()[bp.X, bp.Y].GetPiece().GetPieceType().Equals(Piece.PieceType.PAWN))
            {
                if ((bp.Y == 0) || (bp.Y == 7))
                {
                    aPromotionManipulator.PromotePawn(bp, aBoard);
                }
            }
        }
        
        public void ManipulatingPiece(BoardPosition bp, ChessBoard aBoard)
        {
            if (!isSelectingPiece && aBoard.GetBoard()[bp.X, bp.Y].HasPiece())
            {
                if (aBoard.GetBoard()[bp.X, bp.Y].GetPiece().GetColor().Equals(aCurrentColor))
                {
                    SelectPiece(bp, aBoard);
                    listOfMoves = MoveMechanic.GetAvaiableMoves(bp, aBoard);

                    Console.WriteLine("Piece " + aBoard.GetBoard()[bp.X, bp.Y].GetPiece().ToString() + " is selected");
                    Console.WriteLine("Selected Position " + bp.ToString());
                    foreach (BoardPosition position in listOfMoves)
                    {
                        Console.WriteLine(position.ToString());
                    }
                    // insert list of possible moves
                }
            }
            else if (isSelectingPiece && !(bp.IsSamePosition(selectedBoardPosition)))
            {
                Console.WriteLine("Placing Piece");
                // compare with list of BoardPosition here
                if (IsInList(bp))
                {
                    if (aBoard.GetBoard()[bp.X, bp.Y].HasPiece() &&
                        !aBoard.GetBoard()[bp.X, bp.Y].GetPiece().GetColor().Equals(aCurrentColor))
                    {
                        MovePiece(bp, aBoard);
                        Deselelect();

                        ChangeCurrentColor();
                    }
                    else if(!aBoard.GetBoard()[bp.X, bp.Y].HasPiece())
                    {
                        MovePiece(bp, aBoard);
                        Deselelect();
                        ChangeCurrentColor();
                    }
                }
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
            listOfMoves = null;
        }

        public String SelectedPieceToString(ChessBoard aBoard)
        {
            if(aBoard.GetBoard()[selectedBoardPosition.X, selectedBoardPosition.Y].HasPiece())
            {
                return aBoard.GetBoard()[selectedBoardPosition.X, selectedBoardPosition.Y].GetPiece().ToString();
            }
            return " ";
        }

        public void SetPromotingPiece(int i)
        {
            aPromotionManipulator.SetPromotionPiece(i);
        }

        public void SetCurrentColor(Piece.Color pColor)
        {
            aCurrentColor = pColor;
        }

        public void ChangeCurrentColor()
        {
            if (aCurrentColor == Piece.Color.WHITE)
            {
                aCurrentColor = Piece.Color.BLACK;
            }
            else
            {
                aCurrentColor = Piece.Color.WHITE;
            }
        }

        private bool IsInList(BoardPosition bp)
        {
            for (int i = 0; i < listOfMoves.Count(); i++)
            {
                if (bp.IsSamePosition(listOfMoves[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public List<BoardPosition> GetListOfMoves()
        {
            return listOfMoves;
        }


    }
}
