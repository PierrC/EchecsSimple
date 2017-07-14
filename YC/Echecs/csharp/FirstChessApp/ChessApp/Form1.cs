using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            allPieceControl();
        }

        private Coordinates CalculatePosition(int px, int py)
        {
            int x = px;
            x = ((x-18) / 61);
            x = Math.Min(x * 61, 447);
            x += 18;

            int y = py;
            y = ((y - 18) / 61);
            y = Math.Min(y * 61, 447);
            y += 20;

            return new Coordinates(x, y);
        }

        public Coordinates CalculateBoardPosition(int px, int py)
        {
            int x = px;
            x = ((x - 18) / 61);

            int y = py;
            y = ((y - 20) / 61);

            return new Coordinates(x, y);
        }

        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {
            Image imag = Image.FromFile("C:/Users/pierr/Documents/Visual Studio 2017/Projects/ChessApp/ChessApp/Resources/whitePawn.gif");
            e.Graphics.DrawImage(imag, new Point(100, 100));
        }

        

        private static void chessMenuTest()
        {
            ChessGame chessGame = new ChessGame();


        }


        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whitePawn1.Visible = true;
            whitePawn1.Location = new Point(18, 386);
            whitePawn2.Visible = true;
            whitePawn2.Location = new Point(79, 386);
            whitePawn3.Visible = true;
            whitePawn3.Location = new Point(140, 386);
            whitePawn4.Visible = true;
            whitePawn4.Location = new Point(201, 386);
            whitePawn5.Visible = true;
            whitePawn5.Location = new Point(262, 386);
            whitePawn6.Visible = true;
            whitePawn6.Location = new Point(323, 386);
            whitePawn7.Visible = true;
            whitePawn7.Location = new Point(384, 386);
            whitePawn8.Visible = true;
            whitePawn8.Location = new Point(445, 386);
            
            blackPawn1.Visible = true;
            blackPawn1.Location = new Point(18, 81);
            blackPawn2.Visible = true;
            blackPawn2.Location = new Point(79, 81);
            blackPawn3.Visible = true;
            blackPawn3.Location = new Point(140, 81);
            blackPawn4.Visible = true;
            blackPawn4.Location = new Point(201, 81);
            blackPawn5.Visible = true;
            blackPawn5.Location = new Point(262, 81);
            blackPawn6.Visible = true;
            blackPawn6.Location = new Point(323, 81);
            blackPawn7.Visible = true;
            blackPawn7.Location = new Point(384, 81);
            blackPawn8.Visible = true;
            blackPawn8.Location = new Point(445, 81);

        }
        
        private Point firstPoint = new Point();

        public void allPieceControl()
        {
            pieceControl(whitePawn1);
            pieceControl(whitePawn2);
            pieceControl(whitePawn3);
            pieceControl(whitePawn4);
            pieceControl(whitePawn5);
            pieceControl(whitePawn6);
            pieceControl(whitePawn7);
            pieceControl(whitePawn8);



            pieceControl(blackPawn1);
            pieceControl(blackPawn2);
            pieceControl(blackPawn3);
            pieceControl(blackPawn4);
            pieceControl(blackPawn5);
            pieceControl(blackPawn6);
            pieceControl(blackPawn7);
            pieceControl(blackPawn8);

            pieceControl(blackRook1);
            pieceControl(blackRook2);
            pieceControl(blackKnight1);
            pieceControl(blackKnight2);

        }

        public void pieceControl(Panel piece)
        {
            piece.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };
            piece.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    // create new temp point
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    // Apply value to object
                    piece.Location = new Point(piece.Location.X - res.X, piece.Location.Y - res.Y);

                    // Update first Point
                    firstPoint = temp;

                    piece.BringToFront();

                    System.Diagnostics.Debug.WriteLine("White Pawn " + piece.Location.X + " " + piece.Location.Y);
                    System.Diagnostics.Debug.WriteLine("temp " + temp.X + " " + temp.Y);
                    System.Diagnostics.Debug.WriteLine("Mouse " + Control.MousePosition.X + " " + Control.MousePosition.Y);

                }
            };
            piece.MouseUp += (ss, ee) =>
            {
                Point temp = Control.MousePosition;
                Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                Coordinates coor = CalculatePosition(piece.Location.X + 30, piece.Location.Y + 30);
                piece.Location = new Point(coor.GetX(), coor.GetY());
            };
        }



        

    }
}
