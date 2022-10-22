using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Utils {
    public class Move {
        public void Screen(Form form) {
            Form current = Application.OpenForms.Cast<Form>().Last();
            current.Hide();

            form.Show();
            form.DesktopLocation = new Point(current.Left, current.Top);
        }
    }
}
