using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChessEngine;

namespace ChessApp3
{
    public partial class GameControl : UserControl
    {
        private ChessGame Game_;

        public event EventHandler DisplayBegins;
        public event EventHandler DisplayEnds;

        public GameControl()
        {
            InitializeComponent();
        }

        public ChessGame Game { get => Game_; set => Game_ = value; }

        public void GameChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Redraw Game From notification.");
            if (sender is ChessGame)
                this.UpdateGUI();
        }

        private void UpdateGUI()
        {
            this.PlayerTextBox.Text = Game.IsCurrentPlayerBlack() ? "Black" : "White";
            if (Game.SelectedPiece != null)
                this.PieceTextBox.Text =
                    Game.SelectedPiece.ToString() +
                    " " +
                    Game.SelectedPiece.Position.ToString();
            else
                this.PieceTextBox.Text = "";
        }

        private void OnDisplayBegins(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Display begins");
            if (DisplayBegins != null)
                DisplayBegins(this, new EventArgs());

        }

        private void OnDisaplyEnds(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Display ends");
            Console.WriteLine("Display begins");
            if (DisplayEnds != null)
                DisplayEnds(this, new EventArgs());

        }
    }
}
