using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace langtons_ant
{
    public enum SquareColor
    {
        WHITE,
        BLACK
    }
    public class Square
    {
        public SquareColor Color { get; set; }

        public Square()
        {
            Color = SquareColor.WHITE;
        }
    }
}
