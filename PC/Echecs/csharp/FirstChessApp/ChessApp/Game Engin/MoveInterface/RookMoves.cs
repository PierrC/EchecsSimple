using ChessAppGDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Game_Engin.MoveInterface
{
    class RookMoves : MoveBehavior
    {
        public List<BoardPosition> GetPossibleMoves(ChessBoard pChessBoard, BoardPosition bp)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();

            boardPositionList.Add(bp);
            Piece p = pChessBoard.GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece();
            int index = 0;
            int i = bp.X;
            int j = bp.Y;
            // Up
            while (j < 7)
            {
                j++;
                if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
            }
            for (int m = 0; m < boardPositionList.Count; m++)
            {
                //   Console.WriteLine("Rook moves 1:" + boardPositionList[m].ToString());
                index = m;
            }
            i = bp.X;
            j = bp.Y;
            while (j > 0)
            {
                j--;
                if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
            }
            for (int m = index; m < boardPositionList.Count; m++)
            {
                //  Console.WriteLine("Rook moves 2:" + boardPositionList[m].ToString());
                index = m;
            }
            i = bp.X;
            j = bp.Y;
            while (i < 7)
            {
                i++;
                if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
            }
            for (int m = index; m < boardPositionList.Count; m++)
            {
                //  Console.WriteLine("Rook moves 3:" + boardPositionList[m].ToString());
                index = m;
            }
            i = bp.X;
            j = bp.Y;
            while (i > 0)
            {
                i--;
                if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
            }

            return boardPositionList;
        }
    }
        
    }
}
