using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Utils;

namespace TicTacToe.Forms {
    public partial class WinForm : Form {
        private Game.Winner _winner;

        public WinForm(Game.Winner winner) {
            InitializeComponent();

            _winner = winner;
            Init();
        }

        private void Init() {
            if(_winner == Game.Winner.X) {
                _labelTitle.Text = "You win!";
                _labelSubtitle.Text = "You get +25 score.";
            } else if (_winner == Game.Winner.O) {
                _labelTitle.Text = "You lose!";
                _labelSubtitle.Text = "No score was won.";
            } else if( _winner == Game.Winner.Draw) {
                _labelTitle.Text = "It's a draw!";
                _labelSubtitle.Text = "You get +10 score.";
            }
        }

        public delegate void HomeClicked();
        public event HomeClicked OnHomeClicked;

        public delegate void NextClicked();
        public event NextClicked OnNextClicked;

        private void _buttonNext_Click(object sender, EventArgs e) {
            OnNextClicked?.Invoke();
        }

        private void _buttonHome_Click(object sender, EventArgs e) {
            OnHomeClicked?.Invoke();
        }
    }
}
