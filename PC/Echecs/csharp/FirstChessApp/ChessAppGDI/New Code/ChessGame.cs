﻿using System;
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
            /*
            for(int i = 0; i < boardList.Count; i++)
            {
                Console.WriteLine(boardList[i].ToString());
            }
            */
            if ((bp.X >= 0) & (bp.X < 8) & (bp.Y >= 0) & (bp.Y < 8))
            {
                if (boardView.GetChessBoard().GetBoard()[bp.X, bp.Y].HasPiece() && !isSelecting)
                {
                    selectedPosition = new BoardPosition(bp.X, bp.Y);
                    isSelecting = true;
                    boardList = ChessMechanics.AvaiableMoves(bp, boardView);

                }
                else if (isSelecting)
                {
                    for (int i = 0; i < boardList.Count; i++)
                    {
                        Console.WriteLine(boardList[i].ToString());
                    }
                    Console.WriteLine("bp: " + bp);
                    Console.WriteLine("bp is in the list: " + IsInList(bp, boardList));
                    if (IsInList(bp, boardList))
                    {
                        if ((bp.X == selectedPosition.X) && (bp.Y == selectedPosition.Y))
                        {
                            selectedPosition = new BoardPosition(-2, -1);
                            isSelecting = false;

                        }
                        else if (boardView.GetChessBoard().GetBoard()[bp.X, bp.Y].HasPiece() &&
                            boardView.GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece().getColor().Equals(ChessBoard.OtherColor(boardView.GetChessBoard().GetBoard()[selectedPosition.X, selectedPosition.Y].GetPiece().getColor())))
                        {
                            boardView.movePiece(selectedPosition, bp);
                            selectedPosition = new BoardPosition(-2, -1);
                            isSelecting = false;

                        }
                        else if (!boardView.GetChessBoard().GetBoard()[bp.X, bp.Y].HasPiece())
                        {
                            boardView.movePiece(selectedPosition, bp);
                            selectedPosition = new BoardPosition(-2, -1);
                            isSelecting = false;

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
                return boardView.GetChessBoard().GetBoard()[selectedPosition.X, selectedPosition.Y].ToString() + selectedPosition.ToString();
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

    }

}
