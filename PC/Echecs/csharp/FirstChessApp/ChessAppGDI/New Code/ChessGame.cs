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

        public void DrawBoard(Graphics g)
        {
            boardView.DrawGame(g);
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
                        }
                        else if (!boardView.GetChessBoard().GetBoard()[bp.X, bp.Y].HasPiece())
                        {
                            boardView.movePiece(selectedPosition, bp);
                            selectedPosition = new BoardPosition(-2, -1);
                            isSelecting = false;
                            ChangePlayerColor();
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
        
        public void SetConvertPiece(Piece pPiece)
        {
            boardView.SetReplacePiece( pPiece);
        }
        
        public ChessBoardView getChessBoardView()
        {
            return boardView;
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


    }

}
