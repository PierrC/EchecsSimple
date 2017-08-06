using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ChessEngine;

namespace ChessApp3
{
    public partial class ChessAppMainForm : Form
    {
        private ChessGame Game_;
        private ChessGameView GameView_;

        public ChessGame Game { get => Game_; }
        public ChessGameView GameView { get => GameView_; }

        public ChessAppMainForm()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            Game_ = new ChessGame();
            GameView_ = new ChessGameView(Game);
            Game.Changed += new EventHandler(renderAreaControl.GameChanged);
            Game.Changed += new EventHandler(gameControl.GameChanged);
            renderAreaControl.Game = this.Game;
            renderAreaControl.GameView = this.GameView;
            gameControl.Game = this.Game;
            gameControl.DisplayBegins += new EventHandler(renderAreaControl.DisplayBegins);
            gameControl.DisplayEnds += new EventHandler(renderAreaControl.DisplayEnds);

        }
    }
}
