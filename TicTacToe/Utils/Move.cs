using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Utils {
    public class Move {
        public void Screen(Form form) {
            // hide current screen
            Form current = Application.OpenForms.Cast<Form>().Last();
            current.Hide();

            // show next screen
            form.Show();

            // parent center
            int centerX = current.Left + (current.Width / 2) - (form.Width / 2);
            int centerY = current.Top + (current.Height / 2) - (form.Height / 2);
            form.DesktopLocation = new Point(centerX, centerY);
        }
    }
}
