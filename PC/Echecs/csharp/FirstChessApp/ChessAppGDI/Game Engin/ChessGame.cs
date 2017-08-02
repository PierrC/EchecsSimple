using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class ChessGame
    {
        ChessBoardView boardView;
        List<BoardPosition> boardList;

        Boolean isSelecting = false;
        BoardPosition selectedPosition;
        Piece.Colors playerColor = Piece.Colors.WHITE;

        // Piece convertPiece;

        public ChessGame()
        {
            boardView = new ChessBoardView();
        }

        public void MovePiece(BoardPosition bp)
        {
            if ((bp.X >= 0) & (bp.X < 8) & (bp.Y >= 0) & (bp.Y < 8))
            {
                if (boardView.GetChessBoard().GetBoard()[bp.X, bp.Y].HasPiece() && !isSelecting)
                {
                    if (boardView.GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece().Color == playerColor)
                    {
                        selectedPosition = new BoardPosition(bp.X, bp.Y);
                        isSelecting = true;
                        boardList = ChessMechanics.AvaiableMoves(bp, boardView);
                    }
                }
                else if (isSelecting)
                {
                    if (IsInList(bp, boardList))
                    {
                        if ((bp.X == selectedPosition.X) && (bp.Y == selectedPosition.Y))
                        {
                            selectedPosition = new BoardPosition(-2, -1);
                            isSelecting = false;
                        }
                        else if (boardView.GetChessBoard().GetBoard()[bp.X, bp.Y].HasPiece() &&
                            boardView.GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece().Color.Equals(ChessBoard.OtherColor(boardView.GetChessBoard().GetBoard()[selectedPosition.X, selectedPosition.Y].GetPiece().Color)))
                        {
                            boardView.movePiece(selectedPosition, bp);
                            selectedPosition = new BoardPosition(-2, -1);
                            isSelecting = false;
                            ChangePlayerColor();

                        //    Console.WriteLine(bp.ToString() + " "
                        //        + ChessMechanics.SquareIsThreatened(getChessBoardView().GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece(), bp, getChessBoardView()));

                        }
                        else if (!boardView.GetChessBoard().GetBoard()[bp.X, bp.Y].HasPiece())
                        {
                            boardView.movePiece(selectedPosition, bp);
                            selectedPosition = new BoardPosition(-2, -1);
                            isSelecting = false;
                            ChangePlayerColor();
                        //    Console.WriteLine(bp.ToString() + " "
                        //        + ChessMechanics.SquareIsThreatened(getChessBoardView().GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece(), bp, getChessBoardView()));
                        }
                    }
                }
            }
        }

        public void DiscardPiece()
        {
            isSelecting = false;
            selectedPosition = new BoardPosition(-2, -1);
        }

        public String PrintPiece()
        {
            if (isSelecting)
            {
                return boardView.GetChessBoard().GetBoard()[selectedPosition.X, selectedPosition.Y].ToString() + " " + selectedPosition.ToString();
            }
            return " ";
        }
        
        public bool IsInList(BoardPosition bp, List<BoardPosition> list)
        {
            for(int i = 0; i < list.Count(); i++)
            {
                if(bp.IsSamePosition(list[i]))
                {
                    return true;
                }
            }

            return false;
        }
        
        public ChessBoardView getChessBoardView()
        {
            return boardView;
        }
        
        public void SetConvertPiece(int i)
        {
            switch (i)
            {
                case 0:
                    boardView.SetReplacePiece(new Piece(Piece.Types.BISHOP, Piece.Colors.WHITE));
                    break;
                case 1:
                    boardView.SetReplacePiece(new Piece(Piece.Types.KNIGHT, Piece.Colors.WHITE));
                    break;
                case 2:
                    boardView.SetReplacePiece(new Piece(Piece.Types.QUEEN, Piece.Colors.WHITE));
                    break;
                case 3:
                    boardView.SetReplacePiece(new Piece(Piece.Types.QUEEN, Piece.Colors.WHITE));
                    break;
                default:
                    boardView.SetReplacePiece(new Piece(Piece.Types.BISHOP, Piece.Colors.WHITE));
                    break;
            }
        }

        public void SetPlayerColor(Piece.Colors pColor)
        {
            playerColor = pColor;

        }

        public Piece.Colors GetPlayerColor()
        {
            return playerColor;
        }
        
        public void ChangePlayerColor()
        {
            if (playerColor == Piece.Colors.WHITE)
            {
                playerColor = Piece.Colors.BLACK;
            }
            else
            {
                playerColor = Piece.Colors.WHITE;
            }
        }
        
        public bool HasKing()
        {
            bool whiteKing = false;
            bool blackKing = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (getChessBoardView().GetChessBoard().GetBoard()[i, j].HasPiece())
                    {
                        if (getChessBoardView().GetChessBoard().GetBoard()[i, j].GetPiece().Type == Piece.Types.KING)
                        {
                            if (getChessBoardView().GetChessBoard().GetBoard()[i, j].GetPiece().Color == Piece.Colors.BLACK)
                            {
                                blackKing = true;
                            }
                            else if (getChessBoardView().GetChessBoard().GetBoard()[i, j].GetPiece().Color == Piece.Colors.WHITE)
                            {
                                whiteKing = true;
                            }
                        }
                    }
                }
            }
            if (whiteKing == false || blackKing == false)
            {
                return false;
            }
            return true;
        }

        public Piece.Colors KingKilled()
        {
            bool whiteKing = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (getChessBoardView().GetChessBoard().GetBoard()[i, j].HasPiece())
                    {
                        if (getChessBoardView().GetChessBoard().GetBoard()[i, j].GetPiece().Type == Piece.Types.KING)
                        {
                            if (getChessBoardView().GetChessBoard().GetBoard()[i, j].GetPiece().Color == Piece.Colors.WHITE)
                            {
                                whiteKing = true;
                            }
                        }
                    }
                }
            }
            if (whiteKing == false)
            {
                return Piece.Colors.WHITE;
            }
            return Piece.Colors.BLACK;
        }



    }

}
