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
            Game.Changed += new EventHandler(renderAreaControl1.GameChanged);
            renderAreaControl1.Game = this.Game;
            renderAreaControl1.GameView = this.GameView;

        }
    }
}
