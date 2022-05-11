using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace langtons_ant
{
    public enum AntDirection
    {
        TOP,
        LEFT,
        RIGHT,
        BOTTOM,
    }

    public class Ant
    {
        public AntDirection Direction { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        GridHandler _gridHandler;

        public Ant(GridHandler gridHandler)
        {
            Direction = AntDirection.RIGHT;
            x = 0;
            y = 0;
            _gridHandler = gridHandler;
        }

        public void Move()
        {
            Square square = _gridHandler.GetSquare(x, y);
            Console.WriteLine($"Ant: {x}|{y} Direction: {Direction}");
            switch (Direction)
            {
                case AntDirection.TOP:
                    square = _gridHandler.GetSquare(x, y -1);

                    //clockwise
                    if (square.Color == SquareColor.WHITE)
                    {
                        Direction = AntDirection.RIGHT;
                        square.Color = SquareColor.BLACK;
                    }
                    //counter-clockwise
                    else if (square.Color == SquareColor.BLACK)
                    {
                        Direction = AntDirection.LEFT;
                        square.Color = SquareColor.WHITE;
                    }

                    y -= 1;
                    break;

                case AntDirection.RIGHT:
                    square = _gridHandler.GetSquare(x + 1, y);

                    //clockwise
                    if (square.Color == SquareColor.WHITE)
                    {
                        Direction = AntDirection.BOTTOM;
                        square.Color = SquareColor.BLACK;
                    }
                    //counter-clockwise
                    else if (square.Color == SquareColor.BLACK)
                    {
                        Direction = AntDirection.TOP;
                        square.Color = SquareColor.WHITE;
                    }

                    x += 1;
                    break;
                case AntDirection.BOTTOM:
                    square = _gridHandler.GetSquare(x, y + 1);

                    //clockwise
                    if (square.Color == SquareColor.WHITE)
                    {
                        Direction = AntDirection.LEFT;
                        square.Color = SquareColor.BLACK;
                    }
                    //counter-clockwise
                    else if (square.Color == SquareColor.BLACK)
                    {
                        Direction = AntDirection.RIGHT;
                        square.Color = SquareColor.WHITE;
                    }

                    y += 1;
                    break;
                case AntDirection.LEFT:
                    square = _gridHandler.GetSquare(x - 1, y);

                    //clockwise
                    if (square.Color == SquareColor.WHITE)
                    {
                        Direction = AntDirection.TOP;
                        square.Color = SquareColor.BLACK;
                    }
                    //counter-clockwise
                    else if (square.Color == SquareColor.BLACK)
                    {
                        Direction = AntDirection.BOTTOM;
                        square.Color = SquareColor.WHITE;
                    }

                    x -= 1;
                    break;
            }
        }
    }
}
