using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Utils {
    public class Window {
        public void SetFont(System.Windows.Forms.Form.ControlCollection controls) {
            foreach (Control control in controls) {
                control.Font = new Font("SF Pro Round", control.Font.Size);
            }
        }
    }
}
