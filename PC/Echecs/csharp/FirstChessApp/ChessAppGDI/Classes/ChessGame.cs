using ChessAppGDI.New_Code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.Classes
{
    public class ChessGame
    {
        ChessBoardView chessGame;
        Boolean isSelecting = false;
        BoardPosition selectedPosition;

        public ChessGame()
        {
            chessGame = new ChessBoardView();
        }

        public void DrawGame(Graphics g)
        {
            chessGame.DrawGame(g);
        }

        public void DiscardPiece()
        {
            isSelecting = false;
            selectedPosition = new BoardPosition(-2, -1);
        }

        public void movePiece(Point p)
        {
            BoardPosition bp = PositionAndPixels.PixelsToBoardPosition(p);

            if ((bp.X >= 0) & (bp.X < 8) & (bp.Y >= 0) & (bp.Y < 8))
            {
                if (chessGame.GetChessBoard().GetHasPiece()[bp.X, bp.Y] && !isSelecting)
                {
                    selectedPosition = new BoardPosition(bp.X, bp.Y);
                    isSelecting = true;
                    
                }
                else if (isSelecting && (bp.X == selectedPosition.X) && (bp.Y == selectedPosition.Y))
                {
                    selectedPosition = new BoardPosition(-2, -1);
                    isSelecting = false;
                }
                else if (isSelecting &&
                    chessGame.GetChessBoard().GetHasPiece()[bp.X, bp.Y] &&
                    chessGame.GetChessBoard().GetBoard()[bp.X, bp.Y].getColor().Equals(ChessBoard.OtherColor(chessGame.GetChessBoard().GetBoard()[selectedPosition.X, selectedPosition.Y].getColor())))
                {
                    chessGame.movePiece(selectedPosition, bp);
                    selectedPosition = new BoardPosition(-2, -1);
                    isSelecting = false;
                }
                else if (isSelecting && !chessGame.GetChessBoard().GetHasPiece()[bp.X, bp.Y])
                {
                    chessGame.movePiece(selectedPosition, bp);
                    selectedPosition = new BoardPosition(-2, -1);
                    isSelecting = false;
                }
            }
        }
        
        public String SelectedPiece()
        {
            if (isSelecting)
            {
                return chessGame.GetViewBoard()[selectedPosition.X, selectedPosition.Y].ToString() + " " + selectedPosition.ToString();
            }
            else
            {
                return " ";
            }
        }
        

        /*


        public List<BoardPosition> DetermineMoves()
        {

        }
         * 
      
        public List<Coordinates> MoveSetPiece(piece pPiece)
        {
            List<Coordinates> list = new List<Coordinates>();
            int CoorX = 0;
            int CoorY = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (chessBoard[i, j].hasPiece())
                    {
                        if (chessBoard[i, j].getPiece().Equals(pPiece))
                        {
                            CoorX = i;
                            CoorY = j;
                        }
                    }
                }
            }

            if (pPiece.GetPlayer().Equals(piece.playerNumber.PLAYER1))
            {

                if( pPiece.GetType().Equals(typeof(Pawn)))
                {
                    list.Add(new Coordinates(CoorX - 1, CoorY));
                    if (CoorY != 0)
                    {
                        if( chessBoard[ CoorX-1 , CoorY-1 ].hasPiece())
                        {
                            list.Add(new Coordinates(CoorX - 1, CoorY - 1));
                        }
                    }
                    if (CoorY != 7)
                    {
                        if (chessBoard[CoorX - 1, CoorY + 1].hasPiece())
                        {
                            list.Add(new Coordinates(CoorX - 1, CoorY + 1));
                        }
                    }
                    if (!((Pawn)pPiece).hasHeMoved())
                    {
                        list.Add(new Coordinates(CoorX - 2, CoorY));
                    }

                }
                else if (pPiece.GetType().Equals(typeof(Rook)))
                {
                    int tempX = CoorX;
                    int tempY = CoorY;
                    while (tempX != 7)
                    {
               
                        if(chessBoard[tempX+1,tempY].hasPiece() )
                        {
                            if(!chessBoard[tempX + 1, tempY].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX + 1, tempY));
                                
                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX + 1, tempY));
                        tempX += 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempX != 0)
                    {

                        if (chessBoard[tempX - 1, tempY].hasPiece())
                        {
                            if (!chessBoard[tempX - 1, tempY].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX - 1, tempY));

                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX - 1, tempY));
                        tempX -= 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempY != 7)
                    {

                        if (chessBoard[tempX , tempY+ 1].hasPiece())
                        {
                            if (!chessBoard[tempX, tempY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX, tempY + 1));

                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX, tempY + 1));
                        tempY += 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempY != 0)
                    {

                        if (chessBoard[tempX, tempY - 1].hasPiece())
                        {
                            if (!chessBoard[tempX, tempY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX, tempY - 1));

                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX, tempY - 1));
                        tempY -= 1;
                    }
                }
                
                else if (pPiece.GetType().Equals(typeof(Knight)) || pPiece.GetType().Equals(typeof(Queen)))
                {
                    /////////////////////////////////////////////////
                    //
                    //
                    //             8 o 1
                    //           7   o   2 
                    //           o o x o o
                    //           6   o   3   
                    //             5 o 4 
                    //
                    //
                    ///////////////////// 1 /////////////////////////
                    if(CoorX >= 2 && CoorY <= 6)
                    {
                        if (chessBoard[CoorX -2, CoorY + 1].hasPiece())
                        {
                            if (!chessBoard[CoorX - 2, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX - 2, CoorY + 1));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX - 2, CoorY + 1));
                        }
                    }
                    ///////////////////// 2 /////////////////////////
                    if (CoorX >= 1 && CoorY <= 5)
                    {
                        if (chessBoard[CoorX - 1, CoorY + 2].hasPiece())
                        {
                            if (!chessBoard[CoorX - 1, CoorY + 2].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX - 1, CoorY + 2));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX - 1, CoorY + 2));
                        }
                    }
                    ///////////////////// 3 /////////////////////////
                    if (CoorX <= 6 && CoorY <= 5)
                    {
                        if (chessBoard[CoorX + 1, CoorY + 2].hasPiece())
                        {
                            if (!chessBoard[CoorX + 1, CoorY + 2].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 1, CoorY + 2));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX + 1, CoorY + 2));
                        }
                    }
                    ///////////////////// 4 /////////////////////////
                    if (CoorX <= 5 && CoorY <= 6)
                    {
                        if (chessBoard[CoorX + 2, CoorY + 1].hasPiece())
                        {
                            if (!chessBoard[CoorX + 2, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 2, CoorY + 1));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX + 2, CoorY + 1));
                        }
                    }
                    ///////////////////// 5 /////////////////////////
                    if (CoorX <= 5 && CoorY >= 1)
                    {
                        if (chessBoard[CoorX + 2, CoorY - 1].hasPiece())
                        {
                            if (!chessBoard[CoorX + 2, CoorY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 2, CoorY - 1));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX + 2, CoorY - 1));
                        }
                    }
                    ///////////////////// 6 /////////////////////////
                    if (CoorX <= 6 && CoorY >= 2)
                    {
                        if (chessBoard[CoorX + 1, CoorY - 2].hasPiece())
                        {
                            if (!chessBoard[CoorX + 1, CoorY - 2].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 1, CoorY - 2));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX + 1, CoorY - 2));
                        }
                    }
                    ///////////////////// 7 /////////////////////////
                    if (CoorX >= 1 && CoorY >= 2)
                    {
                        if (chessBoard[CoorX - 1, CoorY - 2].hasPiece())
                        {
                            if (!chessBoard[CoorX - 1, CoorY - 2].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX - 1, CoorY - 2));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX - 1, CoorY - 2));
                        }
                    }
                    ///////////////////// 8 /////////////////////////
                    if (CoorX >= 2 && CoorY >= 1)
                    {
                        if (chessBoard[CoorX + 2, CoorY + 1].hasPiece())
                        {
                            if (!chessBoard[CoorX + 2, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 2, CoorY + 1));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX + 2, CoorY + 1));
                        }
                    }

                }
                else if (pPiece.GetType().Equals(typeof(Bishop)) || pPiece.GetType().Equals(typeof(Queen)))
                {
                    int tempX = CoorX;
                    int tempY = CoorY;
                    while(tempX != 0 && tempY != 0)
                    {
                        if (chessBoard[tempX - 1, tempY - 1].hasPiece())
                        {
                            if (!chessBoard[tempX - 1, tempY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX - 1, tempY - 1));
                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX-1, tempY - 1));
                        tempX -= 1;
                        tempY -= 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempX != 0 && tempY != 7)
                    {
                        if (chessBoard[tempX - 1, tempY + 1].hasPiece())
                        {
                            if (!chessBoard[tempX - 1, tempY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX - 1, tempY + 1));
                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX - 1, tempY + 1));
                        tempX -= 1;
                        tempY += 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempX != 7 && tempY != 7)
                    {
                        if (chessBoard[tempX + 1, tempY + 1].hasPiece())
                        {
                            if (!chessBoard[tempX + 1, tempY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX + 1, tempY + 1));
                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX + 1, tempY + 1));
                        tempX += 1;
                        tempY += 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempX != 7 && tempY != 0)
                    {
                        if (chessBoard[tempX + 1, tempY - 1].hasPiece())
                        {
                            if (!chessBoard[tempX + 1, tempY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX + 1, tempY - 1));
                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX + 1, tempY - 1));
                        tempX += 1;
                        tempY -= 1;
                    }
                }
                /* 
                 * In case I ddecide to separte the queen from the rook and bishop
                 
                else if (pPiece.GetType().Equals(typeof(Queen)))
                {

                }
                else if (pPiece.GetType().Equals(typeof(King)))
                {
                    if(CoorX >= 1)
                    {
                        if(CoorY >= 1)
                        {
                            if (!chessBoard[CoorX - 1, CoorY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX - 1, CoorY - 1));
                            }
}
                        if (!chessBoard[CoorX - 1, CoorY].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                        {
                            list.Add(new Coordinates(CoorX - 1, CoorY));
                        }
                        if (CoorY <= 6)
                        {
                            if (!chessBoard[CoorX - 1, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX - 1, CoorY + 1));
                            }
                        }
                    }

                    if (CoorY >= 1)
                    {
                        if (!chessBoard[CoorX, CoorY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                        {
                            list.Add(new Coordinates(CoorX, CoorY - 1));
                        }
                    }
                    if (CoorY <= 6)
                    {
                        if (!chessBoard[CoorX, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                        {
                            list.Add(new Coordinates(CoorX, CoorY + 1));
                        }
                    }

                    if (CoorX <= 6)
                    {
                        if (CoorY >= 1)
                        {
                            if (!chessBoard[CoorX + 1, CoorY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 1, CoorY - 1));
                            }
                        }
                        if (!chessBoard[CoorX + 1, CoorY].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                        {
                            list.Add(new Coordinates(CoorX + 1, CoorY));
                        }
                        if (CoorY <= 6)
                        {
                            if (!chessBoard[CoorX + 1, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 1, CoorY + 1));
                            }
                        }
                    }
                }


            }
            else
            {

                if (pPiece.GetType().Equals(typeof(Pawn)))
                {
                    list.Add(new Coordinates(CoorX - 1, CoorY));
                    if (CoorY != 0)
                    {
                        if (chessBoard[CoorX - 1, CoorY - 1].hasPiece())
                        {
                            list.Add(new Coordinates(CoorX - 1, CoorY - 1));
                        }
                    }
                    if (CoorY != 7)
                    {
                        if (chessBoard[CoorX - 1, CoorY + 1].hasPiece())
                        {
                            list.Add(new Coordinates(CoorX - 1, CoorY + 1));
                        }
                    }
                    if (!((Pawn) pPiece).hasHeMoved())
                    {
                        list.Add(new Coordinates(CoorX - 2, CoorY));
                    }

                }
                else if (pPiece.GetType().Equals(typeof(Rook)))
                {
                    int tempX = CoorX;
int tempY = CoorY;
                    while (tempX != 7)
                    {

                        if (chessBoard[tempX + 1, tempY].hasPiece())
                        {
                            if (!chessBoard[tempX + 1, tempY].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX + 1, tempY));

                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX + 1, tempY));
                        tempX += 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempX != 0)
                    {

                        if (chessBoard[tempX - 1, tempY].hasPiece())
                        {
                            if (!chessBoard[tempX - 1, tempY].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX - 1, tempY));

                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX - 1, tempY));
                        tempX -= 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempY != 7)
                    {

                        if (chessBoard[tempX, tempY + 1].hasPiece())
                        {
                            if (!chessBoard[tempX, tempY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX, tempY + 1));

                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX, tempY + 1));
                        tempY += 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempY != 0)
                    {

                        if (chessBoard[tempX, tempY - 1].hasPiece())
                        {
                            if (!chessBoard[tempX, tempY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX, tempY - 1));

                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX, tempY - 1));
                        tempY -= 1;
                    }
                }

                else if (pPiece.GetType().Equals(typeof(Knight)) || pPiece.GetType().Equals(typeof(Queen)))
                {
                    /////////////////////////////////////////////////
                    //
                    //
                    //             8 o 1
                    //           7   o   2 
                    //           o o x o o
                    //           6   o   3   
                    //             5 o 4 
                    //
                    //
                    //
                    ///////////////////// 1 /////////////////////////
                    if (CoorX >= 2 && CoorY <= 6)
                    {
                        if (chessBoard[CoorX - 2, CoorY + 1].hasPiece())
                        {
                            if (!chessBoard[CoorX - 2, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX - 2, CoorY + 1));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX - 2, CoorY + 1));
                        }
                    }
                    ///////////////////// 2 /////////////////////////
                    if (CoorX >= 1 && CoorY <= 5)
                    {
                        if (chessBoard[CoorX - 1, CoorY + 2].hasPiece())
                        {
                            if (!chessBoard[CoorX - 1, CoorY + 2].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX - 1, CoorY + 2));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX - 1, CoorY + 2));
                        }
                    }
                    ///////////////////// 3 /////////////////////////
                    if (CoorX <= 6 && CoorY <= 5)
                    {
                        if (chessBoard[CoorX + 1, CoorY + 2].hasPiece())
                        {
                            if (!chessBoard[CoorX + 1, CoorY + 2].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 1, CoorY + 2));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX + 1, CoorY + 2));
                        }
                    }
                    ///////////////////// 4 /////////////////////////
                    if (CoorX <= 5 && CoorY <= 6)
                    {
                        if (chessBoard[CoorX + 2, CoorY + 1].hasPiece())
                        {
                            if (!chessBoard[CoorX + 2, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 2, CoorY + 1));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX + 2, CoorY + 1));
                        }
                    }
                    ///////////////////// 5 /////////////////////////
                    if (CoorX <= 5 && CoorY >= 1)
                    {
                        if (chessBoard[CoorX + 2, CoorY - 1].hasPiece())
                        {
                            if (!chessBoard[CoorX + 2, CoorY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 2, CoorY - 1));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX + 2, CoorY - 1));
                        }
                    }
                    ///////////////////// 6 /////////////////////////
                    if (CoorX <= 6 && CoorY >= 2)
                    {
                        if (chessBoard[CoorX + 1, CoorY - 2].hasPiece())
                        {
                            if (!chessBoard[CoorX + 1, CoorY - 2].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 1, CoorY - 2));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX + 1, CoorY - 2));
                        }
                    }
                    ///////////////////// 7 /////////////////////////
                    if (CoorX >= 1 && CoorY >= 2)
                    {
                        if (chessBoard[CoorX - 1, CoorY - 2].hasPiece())
                        {
                            if (!chessBoard[CoorX - 1, CoorY - 2].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX - 1, CoorY - 2));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX - 1, CoorY - 2));
                        }
                    }
                    ///////////////////// 8 /////////////////////////
                    if (CoorX >= 2 && CoorY >= 1)
                    {
                        if (chessBoard[CoorX + 2, CoorY + 1].hasPiece())
                        {
                            if (!chessBoard[CoorX + 2, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(CoorX + 2, CoorY + 1));
                            }
                        }
                        else
                        {
                            list.Add(new Coordinates(CoorX + 2, CoorY + 1));
                        }
                    }

                }
                else if (pPiece.GetType().Equals(typeof(Bishop)) || pPiece.GetType().Equals(typeof(Queen)))
                {
                    int tempX = CoorX;
int tempY = CoorY;
                    while (tempX != 0 && tempY != 0)
                    {
                        if (chessBoard[tempX - 1, tempY - 1].hasPiece())
                        {
                            if (!chessBoard[tempX - 1, tempY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX - 1, tempY - 1));
                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX - 1, tempY - 1));
                        tempX -= 1;
                        tempY -= 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempX != 0 && tempY != 7)
                    {
                        if (chessBoard[tempX - 1, tempY + 1].hasPiece())
                        {
                            if (!chessBoard[tempX - 1, tempY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX - 1, tempY + 1));
                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX - 1, tempY + 1));
                        tempX -= 1;
                        tempY += 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempX != 7 && tempY != 7)
                    {
                        if (chessBoard[tempX + 1, tempY + 1].hasPiece())
                        {
                            if (!chessBoard[tempX + 1, tempY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX + 1, tempY + 1));
                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX + 1, tempY + 1));
                        tempX += 1;
                        tempY += 1;
                    }
                    tempX = CoorX;
                    tempY = CoorY;
                    while (tempX != 7 && tempY != 0)
                    {
                        if (chessBoard[tempX + 1, tempY - 1].hasPiece())
                        {
                            if (!chessBoard[tempX + 1, tempY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER1))
                            {
                                list.Add(new Coordinates(tempX + 1, tempY - 1));
                            }
                            break;
                        }
                        list.Add(new Coordinates(tempX + 1, tempY - 1));
                        tempX += 1;
                        tempY -= 1;
                    }
                }
                /* 
                 * In case I ddecide to separte the queen from the rook and bishop
                 
                else if (pPiece.GetType().Equals(typeof(Queen)))
                {

                }
                else if (pPiece.GetType().Equals(typeof(King)))
                {
                    if (CoorX >= 1)
                    {
                        if (CoorY >= 1)
                        {
                            if (!chessBoard[CoorX - 1, CoorY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER2))
                            {
                                list.Add(new Coordinates(CoorX - 1, CoorY - 1));
                            }
                        }
                        if (!chessBoard[CoorX - 1, CoorY].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER2))
                        {
                            list.Add(new Coordinates(CoorX - 1, CoorY));
                        }
                        if (CoorY <= 6)
                        {
                            if (!chessBoard[CoorX - 1, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER2))
                            {
                                list.Add(new Coordinates(CoorX - 1, CoorY + 1));
                            }
                        }
                    }

                    if (CoorY >= 1)
                    {
                        if (!chessBoard[CoorX, CoorY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER2))
                        {
                            list.Add(new Coordinates(CoorX, CoorY - 1));
                        }
                    }
                    if (CoorY <= 6)
                    {
                        if (!chessBoard[CoorX, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER2))
                        {
                            list.Add(new Coordinates(CoorX, CoorY + 1));
                        }
                    }

                    if (CoorX <= 6)
                    {
                        if (CoorY >= 1)
                        {
                            if (!chessBoard[CoorX + 1, CoorY - 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER2))
                            {
                                list.Add(new Coordinates(CoorX + 1, CoorY - 1));
                            }
                        }
                        if (!chessBoard[CoorX + 1, CoorY].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER2))
                        {
                            list.Add(new Coordinates(CoorX + 1, CoorY));
                        }
                        if (CoorY <= 6)
                        {
                            if (!chessBoard[CoorX + 1, CoorY + 1].getPiece().GetPlayer().Equals(piece.playerNumber.PLAYER2))
                            {
                                list.Add(new Coordinates(CoorX + 1, CoorY + 1));
                            }
                        }
                    }
                }
            }

            Coordinates co = new Coordinates(CoorX, CoorY);
list.Add(co);
            return list;
        }






        */

    }
}
