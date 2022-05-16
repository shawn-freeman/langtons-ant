namespace langtons_ant
{
    public class GridHandler
    {
        private Dictionary<int, Dictionary<int, Square>> _grid { get; set; }

        public GridHandler()
        {
            _grid = new Dictionary<int, Dictionary<int, Square>>();
        }

        public Square GetSquare(int x, int y)
        {
            if (!_grid.ContainsKey(x)) _grid.Add(x, new Dictionary<int, Square>());

            if (!_grid[x].ContainsKey(y)) _grid[x].Add(y, new Square());

            return _grid[x][y];
        }

        public string OutputGrid()
        {
            //determine min and max x values
            var minX = _grid.Keys.Min();
            var maxX = _grid.Keys.Max();

            //determine min and max y values
            var minY = 0;
            var maxY = 0;
            foreach (var key in _grid.Keys)
            {
                var tempMinY = _grid[key].Keys.Min();
                var tempMaxY = _grid[key].Keys.Max();

                if (tempMinY < minY) minY = tempMinY;

                if (tempMaxY > maxY) maxY = tempMaxY;
            }

            Console.WriteLine("\r\n***** BEGIN OUTPUT *****");
            var outputString = "";

            for (var y = minY; y <= maxY; y++)
            {
                for (var x = minX; x <= maxX; x++)
                {
                    var square = GetSquare(x, y);
                    var colorCharacter = (square.Color == SquareColor.WHITE) ? "W" : "B";
                    outputString += $"[{colorCharacter}]";
                }
                outputString += "\r\n";
            }

            return outputString;
        }
    }
}
