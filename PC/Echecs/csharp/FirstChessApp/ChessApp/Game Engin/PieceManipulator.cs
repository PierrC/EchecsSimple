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
                else if (bp.Y == 2 && aBoard.GetBoard()[bp.X, bp.Y].GetPiece().GetColor().Equals(Piece.Color.BLACK))
                {
                    if(aBoard.GetBoard()[bp.X, bp.Y + 1].HasPiece() && aBoard.GetBoard()[bp.X, bp.Y + 1].GetPiece().GetJumpedLastTurn())
                    {
                        aBoard.GetBoard()[bp.X, bp.Y + 1].RemovePiece();
                    }
                }
                else if (bp.Y == 5 && aBoard.GetBoard()[bp.X, bp.Y].GetPiece().GetColor().Equals(Piece.Color.WHITE))
                {
                    if (aBoard.GetBoard()[bp.X, bp.Y - 1].HasPiece() && aBoard.GetBoard()[bp.X, bp.Y - 1].GetPiece().GetJumpedLastTurn())
                    {
                        aBoard.GetBoard()[bp.X, bp.Y - 1].RemovePiece();
                    }
                }
            }
        }
        
        public void ManipulatingPiece(BoardPosition bp, ChessBoard aBoard)
        {
        //    
            if (!isSelectingPiece && aBoard.GetBoard()[bp.X, bp.Y].HasPiece())
            {
                if (aBoard.GetBoard()[bp.X, bp.Y].GetPiece().GetColor().Equals(aCurrentColor))
                {
                    SelectPiece(bp, aBoard);
                    listOfMoves = MoveMechanic.GetAvaiableMoves(bp, aBoard);
                    
                }
            }
            else if (isSelectingPiece && !(bp.IsSamePosition(selectedBoardPosition)))
            {
                aBoard.GetBoard()[selectedBoardPosition.X, selectedBoardPosition.Y].GetPiece().SetJumpedLastTurn(false);
                if (IsInList(bp))
                {
                        if (selectedBoardPosition.Y == 1 || selectedBoardPosition.Y == 6)
                        {
                            if (aBoard.GetBoard()[selectedBoardPosition.X, selectedBoardPosition.Y].GetPiece().GetPieceType()
                                .Equals(Piece.PieceType.PAWN) && !aBoard.GetBoard()[selectedBoardPosition.X, selectedBoardPosition.Y].GetPiece().GetHasMoved())
                            {
                                if (Math.Abs(bp.Y - selectedBoardPosition.Y) == 2)
                                {
                                    aBoard.GetBoard()[selectedBoardPosition.X, selectedBoardPosition.Y].GetPiece().SetJumpedLastTurn(true);
                                }
                            }
                        }
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
                if(aBoard.GetBoard()[bp.X, bp.Y].GetPiece().GetPieceType().Equals(Piece.PieceType.PAWN))
                {
                    Console.WriteLine("Pawn has Jumped:" + aBoard.GetBoard()[bp.X, bp.Y].GetPiece().GetJumpedLastTurn());
                }
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

        public void RemoveJumpedLastTurn(ChessBoard chessBoard, Piece.Color color)
        {
            for(int i = 0; i < chessBoard.GetBoard().Length; i++)
            {
                for(int j = 0; j < chessBoard.GetBoard().Length; j++)
                {
                    if(chessBoard.GetBoard()[i, j].HasPiece() && chessBoard.GetBoard()[i, j].GetPiece().GetColor() == color)
                    {
                        if(chessBoard.GetBoard()[i, j].GetPiece().GetJumpedLastTurn())
                        {
                            chessBoard.GetBoard()[i, j].GetPiece().SetJumpedLastTurn(false);
                        }
                    }
                }
            }
        }
        
    }
}
