using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessApp.Pieces;


namespace ChessApp
{
    class ChessGame
    {
        /*
         * This is a comment to show that
         * github works.
         * 
         */
        public ChessGame(piece.color player1Color)
        {
            Player player1 = new Player(player1Color, piece.playerNumber.PLAYER1);
            Player player2 = new Player(OtherColor(player1Color), piece.playerNumber.PLAYER2);

            chessBoard = new square[8, 8];

            // Player 1 is at the bottom
            for (int i = 0; i < 8; i++)
            {
                chessBoard[6, i].putPiece(new Pawn(player1.getPlayer(), player1.getColor()));
            }
            chessBoard[7, 0].putPiece(new Rook(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 7].putPiece(new Rook(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 1].putPiece(new Knight(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 6].putPiece(new Knight(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 2].putPiece(new Bishop(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 5].putPiece(new Bishop(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 3].putPiece(new Queen(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 4].putPiece(new King(player1.getPlayer(), player1.getColor()));

            // Player 2 is at the top
            for (int i = 0; i < 8; i++)
            {
                chessBoard[1, i].putPiece(new Pawn(player2.getPlayer(), player2.getColor()));
            }
            chessBoard[0, 0].putPiece(new Rook(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 7].putPiece(new Rook(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 1].putPiece(new Knight(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 6].putPiece(new Knight(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 2].putPiece(new Bishop(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 5].putPiece(new Bishop(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 3].putPiece(new Queen(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 4].putPiece(new King(player2.getPlayer(), player2.getColor()));


        }
        
        public ChessGame()
        {
            Player player1 = new Player(piece.color.WHITE, piece.playerNumber.PLAYER1);
            Player player2 = new Player(piece.color.BLACK, piece.playerNumber.PLAYER2);

            chessBoard = new square[8, 8];

            // Player 1 is at the bottom
            for (int i = 0; i < 8; i++)
            {
                chessBoard[6, i].putPiece(new Pawn(player1.getPlayer(), player1.getColor()));
            }
            chessBoard[7, 0].putPiece(new Rook(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 7].putPiece(new Rook(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 1].putPiece(new Knight(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 6].putPiece(new Knight(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 2].putPiece(new Bishop(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 5].putPiece(new Bishop(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 3].putPiece(new Queen(player1.getPlayer(), player1.getColor()));
            chessBoard[7, 4].putPiece(new King(player1.getPlayer(), player1.getColor()));

            // Player 2 is at the top
            for (int i = 0; i < 8; i++)
            {
                chessBoard[1, i].putPiece(new Pawn(player2.getPlayer(), player2.getColor()));
            }
            chessBoard[0, 0].putPiece(new Rook(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 7].putPiece(new Rook(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 1].putPiece(new Knight(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 6].putPiece(new Knight(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 2].putPiece(new Bishop(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 5].putPiece(new Bishop(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 3].putPiece(new Queen(player2.getPlayer(), player2.getColor()));
            chessBoard[0, 4].putPiece(new King(player2.getPlayer(), player2.getColor()));

        }
        

        square[,] chessBoard = new square[8,8];
        

        public void MovePiece(piece pPiece, Coordinates pCoor)
        {
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
            if (pPiece.GetType().Equals(typeof(Pawn)))
            {
                ((Pawn)pPiece).moved();
            }
            piece removedPiece = chessBoard[CoorX, CoorY].removePiece();
            chessBoard[pCoor.GetX(), pCoor.GetY()].putPiece(pPiece);
        }
        

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
                
                else if (pPiece.GetType().Equals(typeof(Knight)) )
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
                 */
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
                 */
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
        

        private static piece.color OtherColor(piece.color pColor)
        {
            if (pColor.Equals(piece.color.WHITE))
            {
                return piece.color.BLACK;
            }
            else
            {
                return piece.color.WHITE;
            }
        }


        private static void discardImage(piece pPiece)
        {
            pPiece.SetCoor(new Coordinates(525, 531));
        }


    }


}
