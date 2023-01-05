using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Utils {
    public class Sleep {
        public Sleep(int time) {
            Thread thread = new Thread(delegate () {
                System.Threading.Thread.Sleep(time);
            });

            thread.Start();
            while (thread.IsAlive) Application.DoEvents();
        }
    }
}
